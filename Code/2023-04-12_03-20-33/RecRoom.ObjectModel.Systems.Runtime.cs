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
	[Cpp2IlInjected.Address(RVA = "0x2D4A160", Offset = "0x2D49560", VA = "0x182D4A160")]
	static BACKMEJJOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3DAD620", Offset = "0x3DACA20", VA = "0x183DAD620")]
	public static void PEMAFCFLIEJ<T>(T GLOMCJNAEIH, ref T KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D49FD0", Offset = "0x2D493D0", VA = "0x182D49FD0")]
	public static void PEMAFCFLIEJ(FixedString32 GLOMCJNAEIH, ref string KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D49F50", Offset = "0x2D49350", VA = "0x182D49F50")]
	public static void PEMAFCFLIEJ(string GLOMCJNAEIH, ref FixedString32 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A090", Offset = "0x2D49490", VA = "0x182D4A090")]
	public static void PEMAFCFLIEJ(FixedString64 GLOMCJNAEIH, ref string KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A030", Offset = "0x2D49430", VA = "0x182D4A030")]
	public static void PEMAFCFLIEJ(string GLOMCJNAEIH, ref FixedString64 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A130", Offset = "0x2D49530", VA = "0x182D4A130")]
	public static void PEMAFCFLIEJ(MJMNFMKBJIH GLOMCJNAEIH, ref Vector3 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D49EF0", Offset = "0x2D492F0", VA = "0x182D49EF0")]
	public static void PEMAFCFLIEJ(Vector3 GLOMCJNAEIH, ref MJMNFMKBJIH KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A000", Offset = "0x2D49400", VA = "0x182D4A000")]
	public static void PEMAFCFLIEJ(ELFCMIMIBOL GLOMCJNAEIH, ref Vector4 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2D49E80", Offset = "0x2D49280", VA = "0x182D49E80")]
	public static void PEMAFCFLIEJ(Vector4 GLOMCJNAEIH, ref ELFCMIMIBOL KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A000", Offset = "0x2D49400", VA = "0x182D4A000")]
	public static void PEMAFCFLIEJ(ELFCMIMIBOL GLOMCJNAEIH, ref Quaternion KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D49E80", Offset = "0x2D49280", VA = "0x182D49E80")]
	public static void PEMAFCFLIEJ(Quaternion GLOMCJNAEIH, ref ELFCMIMIBOL KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D49DF0", Offset = "0x2D491F0", VA = "0x182D49DF0")]
	public static void PEMAFCFLIEJ(MJMNFMKBJIH GLOMCJNAEIH, ref float3 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D49EF0", Offset = "0x2D492F0", VA = "0x182D49EF0")]
	public static void PEMAFCFLIEJ(float3 GLOMCJNAEIH, ref MJMNFMKBJIH KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D49E20", Offset = "0x2D49220", VA = "0x182D49E20")]
	public static void PEMAFCFLIEJ(ELFCMIMIBOL GLOMCJNAEIH, ref float4 KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D49E80", Offset = "0x2D49280", VA = "0x182D49E80")]
	public static void PEMAFCFLIEJ(float4 GLOMCJNAEIH, ref ELFCMIMIBOL KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D49E20", Offset = "0x2D49220", VA = "0x182D49E20")]
	public static void PEMAFCFLIEJ(ELFCMIMIBOL GLOMCJNAEIH, ref quaternion KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A0C0", Offset = "0x2D494C0", VA = "0x182D4A0C0")]
	public static void PEMAFCFLIEJ(quaternion GLOMCJNAEIH, ref ELFCMIMIBOL KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D49F90", Offset = "0x2D49390", VA = "0x182D49F90")]
	public static void PEMAFCFLIEJ(Entity GLOMCJNAEIH, ref MDJLKHGDBCE KMOLMNMNMNO, CAANBCJACEG LNANHOBPAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D49E60", Offset = "0x2D49260", VA = "0x182D49E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6E0530", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MNJAFLLCGLD OMJDBNDAANI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x722210", Offset = "0x721610", VA = "0x180722210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D4BBA0", Offset = "0x2D4AFA0", VA = "0x182D4BBA0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
	public BFFFIIHIBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3119FF0", Offset = "0x31193F0", VA = "0x183119FF0", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3119F70", Offset = "0x3119370", VA = "0x183119F70")]
	[Preserve]
	private void IHEOGMAENJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public GLMDBLKBNNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D47D90", Offset = "0x2D47190", VA = "0x182D47D90", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public AMBBOCEBBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F040", Offset = "0x2B4E440", VA = "0x182B4F040")]
		public static ObjectModelConfigAsset IHLBCLFNJEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xE24C60", Offset = "0xE24060", VA = "0x180E24C60")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BEC80", Offset = "0x41BE080", VA = "0x1841BEC80")]
			public static IJDKBBDMEBI GBHAGFGCIEP(int LPKIPPIIMKJ)
			{
				return default(IJDKBBDMEBI);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x41BEAF0", Offset = "0x41BDEF0", VA = "0x1841BEAF0")]
			private static void AODNNJGAIJH(GPEJGMHBDPO HHDOKHJIBAD, GPEJGMHBDPO FEHBBDMJOCH, IJDKBBDMEBI DGPLFECNDCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x41BF070", Offset = "0x41BE470", VA = "0x1841BF070")]
			public static int IKMHMDNOMMB(GameObject BLPBCMIHDMD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x41BF240", Offset = "0x41BE640", VA = "0x1841BF240")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B4F250", Offset = "0x2B4E650", VA = "0x182B4F250")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F920", Offset = "0x2B4ED20", VA = "0x182B4F920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static PLHAEEKILKB JFDMKHENBCB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FB00", Offset = "0x2B4EF00", VA = "0x182B4FB00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FD00", Offset = "0x2B4F100", VA = "0x182B4FD00")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool DGIKKNHIAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FF20", Offset = "0x2B4F320", VA = "0x182B4FF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static FEPIHHOJCOJ LOLLNGHJAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B50880", Offset = "0x2B4FC80", VA = "0x182B50880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static MNJAFLLCGLD OMJDBNDAANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FA00", Offset = "0x2B4EE00", VA = "0x182B4FA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static EHCGNDKDHFM FAMBGOHJMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2B50390", Offset = "0x2B4F790", VA = "0x182B50390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static NNPPGMKPBPK NMOFOMIKKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F0E0", Offset = "0x2B4E4E0", VA = "0x182B4F0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static FOBNDAGEMLO FPIICNIIOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FA80", Offset = "0x2B4EE80", VA = "0x182B4FA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static CGDDJBMDAKP AKFBLEDGEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B50A60", Offset = "0x2B4FE60", VA = "0x182B50A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool AMBDDFHIMPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2B4FC20", Offset = "0x2B4F020", VA = "0x182B4FC20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool OIJEJAPNBOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2B50410", Offset = "0x2B4F810", VA = "0x182B50410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool DCOCGOHKOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2B4F400", Offset = "0x2B4E800", VA = "0x182B4F400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool BKCPMHDPPJP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2B50920", Offset = "0x2B4FD20", VA = "0x182B50920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2B50330", Offset = "0x2B4F730", VA = "0x182B50330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool NIBAEDKKIOA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2B50AE0", Offset = "0x2B4FEE0", VA = "0x182B50AE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2B50CC0", Offset = "0x2B500C0", VA = "0x182B50CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action NKOIMHHPNOC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2B500E0", Offset = "0x2B4F4E0", VA = "0x182B500E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B50660", Offset = "0x2B4FA60", VA = "0x182B50660")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F160", Offset = "0x2B4E560", VA = "0x182B4F160")]
		public static GPEJGMHBDPO BPFLLEIAFPB(GameObject BLPBCMIHDMD)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B50080", Offset = "0x2B4F480", VA = "0x182B50080")]
		public static bool JBIJHELDJID(ByteString BMHLFOOGPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B50760", Offset = "0x2B4FB60", VA = "0x182B50760")]
		public static CDFLNPBCBAA MAMJHGMNPEO(IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F2B0", Offset = "0x2B4E6B0", VA = "0x182B4F2B0")]
		public static (ByteString, IDisposable) CJKIIDNIDDE()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B501E0", Offset = "0x2B4F5E0", VA = "0x182B501E0")]
		public static (ByteString, IDisposable) JGECDNFPBAM(IEnumerable<GPEJGMHBDPO> CMLLBIKBAEF)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F5F0", Offset = "0x2B4E9F0", VA = "0x182B4F5F0")]
		public static bool EHGJDJBMNBB(GameObject BLPBCMIHDMD, out IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B50540", Offset = "0x2B4F940", VA = "0x182B50540")]
		public static bool KGFIKFLJCOF(IEnumerable<EMMEDLLCNCH> PNDLEPGFOGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B50980", Offset = "0x2B4FD80", VA = "0x182B50980")]
		public static void NJLLPDINJFK(bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B50B40", Offset = "0x2B4FF40", VA = "0x182B50B40")]
		public static Task PGBHOMEMIJD(bool IGPDCEGDODH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F840", Offset = "0x2B4EC40", VA = "0x182B4F840")]
		private static PLHAEEKILKB FBBCMMBONPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B4F720", Offset = "0x2B4EB20", VA = "0x182B4F720")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B556F0", Offset = "0x2B54AF0", VA = "0x182B556F0")]
		public static bool BCMCEFMMKOB(EMAJLAJEHKH PFHGJECLIGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B557A0", Offset = "0x2B54BA0", VA = "0x182B557A0")]
		public static EMAJLAJEHKH GBHABPPKBJN(GameObject BLPBCMIHDMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B559D0", Offset = "0x2B54DD0", VA = "0x182B559D0")]
		public static EMAJLAJEHKH GBHABPPKBJN(GameObject BLPBCMIHDMD, IJDKBBDMEBI DGPLFECNDCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B55EC0", Offset = "0x2B552C0", VA = "0x182B55EC0")]
		public static bool OMDHKONIAAB(GameObject LOCIAIPOBLA, string ANCBAFIJPAE, bool JHOHJFFPNPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B55CC0", Offset = "0x2B550C0", VA = "0x182B55CC0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void NFJDPFLAOPI(GameObject LOCIAIPOBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B55BD0", Offset = "0x2B54FD0", VA = "0x182B55BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public GPEJGMHBDPO PJKAPDAPHHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x701040", Offset = "0x700440", VA = "0x180701040", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(GPEJGMHBDPO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x2AA8DE0", Offset = "0x2AA81E0", VA = "0x182AA8DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x310C700", Offset = "0x310BB00", VA = "0x18310C700", Slot = "15")]
			get
			{
				return default(GPEJGMHBDPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public CDFLNPBCBAA HJKKKHLKLHO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x310C7B0", Offset = "0x310BBB0", VA = "0x18310C7B0", Slot = "6")]
			get
			{
				return default(CDFLNPBCBAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool LCLDHDEMAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x310C6F0", Offset = "0x310BAF0", VA = "0x18310C6F0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public JOIKFKIBIDF GDOPJIHDKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9BA4F0", Offset = "0x9B98F0", VA = "0x1809BA4F0", Slot = "7")]
			get
			{
				return default(JOIKFKIBIDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MNJAFLLCGLD OMJDBNDAANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x310BDF0", Offset = "0x310B1F0", VA = "0x18310BDF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private EOBKLCMHAME CPCMBJKPKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x310BD90", Offset = "0x310B190", VA = "0x18310BD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool HPJFGMAKOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x79A190", Offset = "0x799590", VA = "0x18079A190", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> DKOHJIMIECE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x310C5B0", Offset = "0x310B9B0", VA = "0x18310C5B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x310C7E0", Offset = "0x310BBE0", VA = "0x18310C7E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<EMAJLAJEHKH> JFLFBIIMDGA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x310C650", Offset = "0x310BA50", VA = "0x18310C650", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x310C880", Offset = "0x310BC80", VA = "0x18310C880", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x310BAC0", Offset = "0x310AEC0", VA = "0x18310BAC0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x310C310", Offset = "0x310B710", VA = "0x18310C310", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x310BFC0", Offset = "0x310B3C0", VA = "0x18310BFC0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x310C280", Offset = "0x310B680", VA = "0x18310C280", Slot = "10")]
		public void OnEmbody(EEPEPNPEOFG BKFHGKOCNCC, GPEJGMHBDPO LCCDBPIJCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x310C300", Offset = "0x310B700", VA = "0x18310C300", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x310C070", Offset = "0x310B470", VA = "0x18310C070", Slot = "12")]
		public void OnDisembody(bool PMMCMPPCHMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x310C460", Offset = "0x310B860", VA = "0x18310C460")]
		private void PEAAOCOHBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x310BED0", Offset = "0x310B2D0", VA = "0x18310BED0")]
		private void IEPKMGFHODI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x310BCA0", Offset = "0x310B0A0", VA = "0x18310BCA0")]
		private void CMONGHJDGLF(bool MFNFGLHHIIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x310BF60", Offset = "0x310B360", VA = "0x18310BF60", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xF41F00", Offset = "0xF41300", VA = "0x180F41F00", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B5F120", Offset = "0x2B5E520", VA = "0x182B5F120", Slot = "6")]
			get
			{
				return default(OBNHEEKLBIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F0C0", Offset = "0x2B5E4C0", VA = "0x182B5F0C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1BD0", Offset = "0x6E0FD0", VA = "0x1806E1BD0", Slot = "6")]
			get
			{
				return default(OBNHEEKLBIB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x784430", Offset = "0x783830", VA = "0x180784430", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GPEJGMHBDPO PJKAPDAPHHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xC11C00", Offset = "0xC11000", VA = "0x180C11C00", Slot = "5")]
			get
			{
				return default(GPEJGMHBDPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool LCLDHDEMAPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6E0030", Offset = "0x6DF430", VA = "0x1806E0030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA4A830", Offset = "0xA49C30", VA = "0x180A4A830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity OIMONIPJMNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal FOBNDAGEMLO FPIICNIIOKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal EOBKLCMHAME OMHHCDEFKIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2CE14B0", Offset = "0x2CE08B0", VA = "0x182CE14B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2CE10C0", Offset = "0x2CE04C0", VA = "0x182CE10C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1520", Offset = "0x2CE0920", VA = "0x182CE1520")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2CE11A0", Offset = "0x2CE05A0", VA = "0x182CE11A0")]
		internal void JHHOMPLGCBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1100", Offset = "0x2CE0500", VA = "0x182CE1100")]
		private bool DADIFHMBCFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2CE10D0", Offset = "0x2CE04D0", VA = "0x182CE10D0")]
		private void BNMMGJOPBHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1520", Offset = "0x2CE0920", VA = "0x182CE1520")]
		internal void NCMANBGJLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1610", Offset = "0x2CE0A10", VA = "0x182CE1610")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2CE16F0", Offset = "0x2CE0AF0", VA = "0x182CE16F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public KHCCBBJDMKM JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MNJAFLLCGLD OMJDBNDAANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public PJNMANJFEMH JJCHHCLNGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public JJLHCHOLEPN JMBHPDNDFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KCIOFPNPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x892B10", Offset = "0x891F10", VA = "0x180892B10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool PIODGPGALDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3122830", Offset = "0x3121C30", VA = "0x183122830", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PIEGKGHOKCE JBBLCINBLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x94D020", Offset = "0x94C420", VA = "0x18094D020", Slot = "10")]
		get
		{
			return default(PIEGKGHOKCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3122840", Offset = "0x3121C40", VA = "0x183122840")]
	public static JNFIKBCHEPC BMDGCEOIEEG(EHPGCEGHLNO HPFBGIEBCLA, DGHHMLJKDPD HGNBPKPAAFI = DGHHMLJKDPD.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private static void PKFBLPCDBDE(EHPGCEGHLNO HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private static void FEPCAGCDNJE(EHPGCEGHLNO HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3122990", Offset = "0x3121D90", VA = "0x183122990", Slot = "11")]
	public void FEIOIOFEHFM(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x28489C0", Offset = "0x2847DC0", VA = "0x1828489C0")]
	private void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3122AE0", Offset = "0x3121EE0", VA = "0x183122AE0")]
	private void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3122930", Offset = "0x3121D30", VA = "0x183122930", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public JNFIKBCHEPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FMAFJGMFEKD
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x31145D0", Offset = "0x31139D0", VA = "0x1831145D0")]
	public static CDFLNPBCBAA NFKICFAFKEF(this PLHAEEKILKB ALNGLBHBEKI, IJDKBBDMEBI DGPLFECNDCD, OBNHEEKLBIB IBFEICPOBBG)
	{
		return default(CDFLNPBCBAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x31144B0", Offset = "0x31138B0", VA = "0x1831144B0")]
	public static NBODNKOLKBD LOKKOCJOODO(this PLHAEEKILKB ALNGLBHBEKI)
	{
		return default(NBODNKOLKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x31142D0", Offset = "0x31136D0", VA = "0x1831142D0")]
	public static GPEJGMHBDPO BPFLLEIAFPB(this PLHAEEKILKB ALNGLBHBEKI, Entity PJEENOLDJIO)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3114380", Offset = "0x3113780", VA = "0x183114380")]
	public static GPEJGMHBDPO BPFLLEIAFPB(this PLHAEEKILKB ALNGLBHBEKI, IJDKBBDMEBI DGPLFECNDCD)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x31141B0", Offset = "0x31135B0", VA = "0x1831141B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3125910", Offset = "0x3124D10", VA = "0x183125910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3125610", Offset = "0x3124A10", VA = "0x183125610", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3125700", Offset = "0x3124B00", VA = "0x183125700", Slot = "16")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3125870", Offset = "0x3124C70", VA = "0x183125870", Slot = "13")]
	public void LDFIGNNEJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "6")]
	public void NEMOFPFLNCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x31256B0", Offset = "0x3124AB0", VA = "0x1831256B0", Slot = "7")]
	public void JBNMEOHKANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x31254C0", Offset = "0x31248C0", VA = "0x1831254C0", Slot = "8")]
	public void EBALAAGLHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1210E40", Offset = "0x1210240", VA = "0x181210E40", Slot = "9")]
	public void FLHDAFPJPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3125570", Offset = "0x3124970", VA = "0x183125570", Slot = "10")]
	public void GGOEDFNGDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x31257B0", Offset = "0x3124BB0", VA = "0x1831257B0", Slot = "11")]
	public bool KGFIKFLJCOF(IEnumerable<EMMEDLLCNCH> PNDLEPGFOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x31255C0", Offset = "0x31249C0", VA = "0x1831255C0", Slot = "12")]
	public void HBECBLLPJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x31259B0", Offset = "0x3124DB0", VA = "0x1831259B0", Slot = "14")]
	public void OHBHCAIGIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x31258B0", Offset = "0x3124CB0", VA = "0x1831258B0", Slot = "15")]
	public void LGOJHIHHOKC(bool CEHAMLKELDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3125540", Offset = "0x3124940", VA = "0x183125540")]
	private void EMBHMOKLPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B45B50", Offset = "0x2B44F50", VA = "0x182B45B50", Slot = "6")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2B459D0", Offset = "0x2B44DD0", VA = "0x182B459D0", Slot = "4")]
	public ByteString CJKIIDNIDDE(out IDisposable FIOJMHPAHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2B45A30", Offset = "0x2B44E30", VA = "0x182B45A30", Slot = "5")]
	public void EOLLHEJPBAN(ByteString FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C20110", Offset = "0x3C1F510", VA = "0x183C20110", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type DBLKLNHCEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C21190", Offset = "0x3C20590", VA = "0x183C21190", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public EBDBOJDCJEC HAKFDIMBFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3C209B0", Offset = "0x3C1FDB0", VA = "0x183C209B0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int HPBCENIKLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3C25D00", Offset = "0x3C25100", VA = "0x183C25D00", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IOBEOAGNJJA FGOPDNCKKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C20C80", Offset = "0x3C20080", VA = "0x183C20C80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x33EAD60", Offset = "0x33EA160", VA = "0x1833EAD60", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x33EB3C0", Offset = "0x33EA7C0", VA = "0x1833EB3C0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::MOFEKMBHHLI<IJDKBBDMEBI> NKOIMHHPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C21300", Offset = "0x3C20700", VA = "0x183C21300", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3C239D0", Offset = "0x3C22DD0", VA = "0x183C239D0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x30076D0", Offset = "0x3006AD0", VA = "0x1830076D0")]
	public PLOKGEGHGGL(global::DFDBMCBGAEF<Entity> MLIELKFMALM, FOBNDAGEMLO AKPCEKFNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3C1B820", Offset = "0x3C1AC20", VA = "0x183C1B820")]
	private Entity BAGBAIEEPPJ(IJDKBBDMEBI DGPLFECNDCD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x33E7030", Offset = "0x33E6430", VA = "0x1833E7030")]
	private IJDKBBDMEBI BAGBAIEEPPJ(Entity PJEENOLDJIO)
	{
		return default(IJDKBBDMEBI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D720", Offset = "0x3C1CB20", VA = "0x183C1D720", Slot = "4")]
	public T BOEAFIEBIHC(IJDKBBDMEBI DGPLFECNDCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3C22100", Offset = "0x3C21500", VA = "0x183C22100")]
	public bool JPNFGACMGOG(IJDKBBDMEBI DGPLFECNDCD, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3C1EBB0", Offset = "0x3C1DFB0", VA = "0x183C1EBB0")]
	public bool CBCHFBKJCOA(IJDKBBDMEBI DGPLFECNDCD, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3C1BC30", Offset = "0x3C1B030", VA = "0x183C1BC30", Slot = "9")]
	public bool BKIFKBMENNF(IJDKBBDMEBI DGPLFECNDCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x33EBFA0", Offset = "0x33EB3A0", VA = "0x1833EBFA0", Slot = "26")]
	public object IIKMGFNOMEN(IJDKBBDMEBI DGPLFECNDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3C24150", Offset = "0x3C23550", VA = "0x183C24150")]
	public bool LAOIDJMPGGI(IJDKBBDMEBI DGPLFECNDCD, in object GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x33E7A50", Offset = "0x33E6E50", VA = "0x1833E7A50")]
	public void BOEAFIEBIHC(IJDKBBDMEBI DGPLFECNDCD, in GHPDGIAHCBK KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x33ED260", Offset = "0x33EC660", VA = "0x1833ED260")]
	public bool JPNFGACMGOG(IJDKBBDMEBI DGPLFECNDCD, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x33E9F20", Offset = "0x33E9320", VA = "0x1833E9F20")]
	public bool CBCHFBKJCOA(IJDKBBDMEBI DGPLFECNDCD, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3003220", Offset = "0x3002620", VA = "0x183003220", Slot = "22")]
	public void LPKKHPLBIJM(PAOKNLKENHE NIICHBPFANE, [Optional] object MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C25100", Offset = "0x3C24500", VA = "0x183C25100", Slot = "15")]
	public void LPKKHPLBIJM(IJDKBBDMEBI EBOIOCBODNI, FDCKEIMNKII NIICHBPFANE, object MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x33EAE20", Offset = "0x33EA220", VA = "0x1833EAE20", Slot = "14")]
	public bool EBGLHADENDP(IJDKBBDMEBI KMOLMNMNMNO, IJDKBBDMEBI GLOMCJNAEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x272AB90", Offset = "0x2729F90", VA = "0x18272AB90", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C29EF0", Offset = "0x3C292F0", VA = "0x183C29EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD460", Offset = "0x2FFC860", VA = "0x182FFD460")]
	public string HADDKMAPJJJ(in MPOLKMCKMLM PCAFGDJMGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3C22850", Offset = "0x3C21C50", VA = "0x183C22850")]
	private void KDHLIDENPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E770", Offset = "0x3C1DB70", VA = "0x183C1E770")]
	private void BONCDEDJNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3C28220", Offset = "0x3C27620", VA = "0x183C28220")]
	private void PIOCKEMLGJJ(Entity PJEENOLDJIO, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3C20410", Offset = "0x3C1F810", VA = "0x183C20410")]
	private void FCDILPBBFPE(Entity PJEENOLDJIO, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3C26F20", Offset = "0x3C26320", VA = "0x183C26F20")]
	[Conditional("DEBUG_BUILD")]
	private static void NLOGCFCJHJP(Entity PJEENOLDJIO, IJDKBBDMEBI DGPLFECNDCD, string GPBJNICHLBB, string LHIPDNIACGO, [CallerMemberName] string OCAFPAEFJBH = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7050", Offset = "0x2FB6450", VA = "0x182FB7050", Slot = "5")]
	private bool HCFPKDINMOF(IJDKBBDMEBI EBOIOCBODNI, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2FB74F0", Offset = "0x2FB68F0", VA = "0x182FB74F0", Slot = "6")]
	private bool NIDONLBPICE(IJDKBBDMEBI EBOIOCBODNI, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0F50", Offset = "0x2AB0350", VA = "0x182AB0F50", Slot = "10")]
	private bool HECAKJABJIL(IJDKBBDMEBI EBOIOCBODNI, in object GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x33F0500", Offset = "0x33EF900", VA = "0x1833F0500", Slot = "11")]
	private void NIMMJDPMIPD(IJDKBBDMEBI EBOIOCBODNI, in GHPDGIAHCBK KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x33EADF0", Offset = "0x33EA1F0", VA = "0x1833EADF0", Slot = "12")]
	private bool CEOJKKAGMAP(IJDKBBDMEBI EBOIOCBODNI, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x33EBAC0", Offset = "0x33EAEC0", VA = "0x1833EBAC0", Slot = "13")]
	private bool GPEOPABKOBB(IJDKBBDMEBI EBOIOCBODNI, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2FFBB80", Offset = "0x2FFAF80", VA = "0x182FFBB80", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FFC6E0", Offset = "0x2FFBAE0", VA = "0x182FFC6E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type DBLKLNHCEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2FFDE20", Offset = "0x2FFD220", VA = "0x182FFDE20", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public EBDBOJDCJEC HAKFDIMBFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD0E0", Offset = "0x2FFC4E0", VA = "0x182FFD0E0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int HPBCENIKLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3004200", Offset = "0x3003600", VA = "0x183004200", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IOBEOAGNJJA FGOPDNCKKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD7A0", Offset = "0x2FFCBA0", VA = "0x182FFD7A0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2FFBA00", Offset = "0x2FFAE00", VA = "0x182FFBA00", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC770", Offset = "0x2FFBB70", VA = "0x182FFC770", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::MOFEKMBHHLI<GPEJGMHBDPO> NKOIMHHPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2FFE810", Offset = "0x2FFDC10", VA = "0x182FFE810", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3001880", Offset = "0x3000C80", VA = "0x183001880", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x30076D0", Offset = "0x3006AD0", VA = "0x1830076D0")]
	public DIJBCAAPJBG(global::DFDBMCBGAEF<Entity> MLIELKFMALM, FOBNDAGEMLO AKPCEKFNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1E388B0", Offset = "0x1E37CB0", VA = "0x181E388B0")]
	private Entity BAGBAIEEPPJ(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2FF6310", Offset = "0x2FF5710", VA = "0x182FF6310")]
	private GPEJGMHBDPO BAGBAIEEPPJ(Entity PJEENOLDJIO)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2FF7B60", Offset = "0x2FF6F60", VA = "0x182FF7B60", Slot = "4")]
	public T BOEAFIEBIHC(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2FFF6A0", Offset = "0x2FFEAA0", VA = "0x182FFF6A0")]
	public bool JPNFGACMGOG(GPEJGMHBDPO GBPGPLEPLBP, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2FFB2A0", Offset = "0x2FFA6A0", VA = "0x182FFB2A0")]
	public bool CBCHFBKJCOA(GPEJGMHBDPO GBPGPLEPLBP, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2FF6480", Offset = "0x2FF5880", VA = "0x182FF6480", Slot = "9")]
	public bool BKIFKBMENNF(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2FFDC80", Offset = "0x2FFD080", VA = "0x182FFDC80", Slot = "26")]
	public object IIKMGFNOMEN(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3002170", Offset = "0x3001570", VA = "0x183002170")]
	public bool LAOIDJMPGGI(GPEJGMHBDPO GBPGPLEPLBP, in object GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2FF81A0", Offset = "0x2FF75A0", VA = "0x182FF81A0")]
	public void BOEAFIEBIHC(GPEJGMHBDPO GBPGPLEPLBP, in GHPDGIAHCBK KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2FFEB50", Offset = "0x2FFDF50", VA = "0x182FFEB50")]
	public bool JPNFGACMGOG(GPEJGMHBDPO GBPGPLEPLBP, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2FFB1F0", Offset = "0x2FFA5F0", VA = "0x182FFB1F0")]
	public bool CBCHFBKJCOA(GPEJGMHBDPO GBPGPLEPLBP, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3003220", Offset = "0x3002620", VA = "0x183003220", Slot = "22")]
	public void LPKKHPLBIJM(PAOKNLKENHE NIICHBPFANE, [Optional] object MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3003EE0", Offset = "0x30032E0", VA = "0x183003EE0", Slot = "15")]
	public void LPKKHPLBIJM(GPEJGMHBDPO EBOIOCBODNI, FDCKEIMNKII NIICHBPFANE, object MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC0C0", Offset = "0x2FFB4C0", VA = "0x182FFC0C0", Slot = "14")]
	public bool EBGLHADENDP(GPEJGMHBDPO KMOLMNMNMNO, GPEJGMHBDPO GLOMCJNAEIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3000DB0", Offset = "0x30001B0", VA = "0x183000DB0")]
	private void KDHLIDENPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2FF9590", Offset = "0x2FF8990", VA = "0x182FF9590")]
	private void BONCDEDJNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3005210", Offset = "0x3004610", VA = "0x183005210")]
	private void PIOCKEMLGJJ(Entity PJEENOLDJIO, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2FFCC90", Offset = "0x2FFC090", VA = "0x182FFCC90")]
	private void FCDILPBBFPE(Entity PJEENOLDJIO, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2FFBBB0", Offset = "0x2FFAFB0", VA = "0x182FFBBB0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x30073B0", Offset = "0x30067B0", VA = "0x1830073B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD460", Offset = "0x2FFC860", VA = "0x182FFD460")]
	public string HADDKMAPJJJ(in MPOLKMCKMLM PCAFGDJMGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC770", Offset = "0x2FFBB70", VA = "0x182FFC770", Slot = "5")]
	private bool KLGKDFLMMKH(GPEJGMHBDPO EBOIOCBODNI, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3000050", Offset = "0x2FFF450", VA = "0x183000050", Slot = "6")]
	private bool KAMONPCECNN(GPEJGMHBDPO EBOIOCBODNI, in T GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3004520", Offset = "0x3003920", VA = "0x183004520", Slot = "10")]
	private bool OCIGGPHBFBA(GPEJGMHBDPO EBOIOCBODNI, in object GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC3D0", Offset = "0x2FFB7D0", VA = "0x182FFC3D0", Slot = "11")]
	private void EBKOOJHOLMB(GPEJGMHBDPO EBOIOCBODNI, in GHPDGIAHCBK KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2FFE8C0", Offset = "0x2FFDCC0", VA = "0x182FFE8C0", Slot = "12")]
	private bool JGKMKDCMLHE(GPEJGMHBDPO EBOIOCBODNI, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2FF62D0", Offset = "0x2FF56D0", VA = "0x182FF62D0", Slot = "13")]
	private bool AAECOHFHAJN(GPEJGMHBDPO EBOIOCBODNI, in MPOLKMCKMLM GLLAKMPHGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2FFBB80", Offset = "0x2FFAF80", VA = "0x182FFBB80", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE63C0", Offset = "0xCE57C0", VA = "0x180CE63C0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xCEBD90", Offset = "0xCEB190", VA = "0x180CEBD90")]
	public KDFLMOJDNAH(NativeArray<EntityRemapUtility.EntityRemapInfo> HOLOKBFKLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3124520", Offset = "0x3123920", VA = "0x183124520", Slot = "6")]
	public GPEJGMHBDPO NIDPNGHEKLF(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3124570", Offset = "0x3123970", VA = "0x183124570", Slot = "7")]
	public Entity NIDPNGHEKLF(Entity PJEENOLDJIO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3124580", Offset = "0x3123980", VA = "0x183124580", Slot = "8")]
	public IEnumerable<GPEJGMHBDPO> NIDPNGHEKLF(IEnumerable<GPEJGMHBDPO> CMLLBIKBAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x31244C0", Offset = "0x31238C0", VA = "0x1831244C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD98B0", Offset = "0x2CD8CB0", VA = "0x182CD98B0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool APJNBIELNNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2CD9820", Offset = "0x2CD8C20", VA = "0x182CD9820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2CD99C0", Offset = "0x2CD8DC0", VA = "0x182CD99C0")]
		public static SerializationRemapScope NDLIONNJEPP()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9D40", Offset = "0x2CD9140", VA = "0x182CD9D40")]
		public SerializationRemapScope(CONHDBOPGAO HJINIPHPMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9710", Offset = "0x2CD8B10", VA = "0x182CD9710", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9B50", Offset = "0x2CD8F50", VA = "0x182CD9B50")]
		public static GPEJGMHBDPO NIDPNGHEKLF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9A20", Offset = "0x2CD8E20", VA = "0x182CD9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D507D0", Offset = "0x2D4FBD0", VA = "0x182D507D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2D50510", Offset = "0x2D4F910", VA = "0x182D50510")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event GAKNGMOAHFO AEDIJKMJDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2D508A0", Offset = "0x2D4FCA0", VA = "0x182D508A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2D505B0", Offset = "0x2D4F9B0", VA = "0x182D505B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event GKMMCIEDEKI HHNGMJPOBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2D50710", Offset = "0x2D4FB10", VA = "0x182D50710")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2D50650", Offset = "0x2D4FA50", VA = "0x182D50650")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2D506F0", Offset = "0x2D4FAF0", VA = "0x182D506F0")]
	[Conditional("UNITY_EDITOR")]
	public void FJLIPCHEOBE(IJDKBBDMEBI IIIBOGBNOJB, in ADIOIKPLFDJ FNIHENPLJHK, bool GEEHDIBABFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2D507B0", Offset = "0x2D4FBB0", VA = "0x182D507B0")]
	[Conditional("UNITY_EDITOR")]
	public void IBLCGNHLMAO(IJDKBBDMEBI IIIBOGBNOJB, bool GEEHDIBABFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2D50870", Offset = "0x2D4FC70", VA = "0x182D50870")]
	[Conditional("UNITY_EDITOR")]
	public void NIOBEEEGPGI(IJDKBBDMEBI IIIBOGBNOJB, BPHAMHGLCNC MLIELKFMALM, in MPOLKMCKMLM KPPLMEOMNGF, bool GEEHDIBABFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3118FD0", Offset = "0x31183D0", VA = "0x183118FD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3118890", Offset = "0x3117C90", VA = "0x183118890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> HPEMBFHBBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3118EE0", Offset = "0x31182E0", VA = "0x183118EE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3118970", Offset = "0x3117D70", VA = "0x183118970")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event MMLJPPFFNLH CABKJPMCPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3118DA0", Offset = "0x31181A0", VA = "0x183118DA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3118460", Offset = "0x3117860", VA = "0x183118460")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event IFNNCMBFHAJ AEDIJKMJDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3119160", Offset = "0x3118560", VA = "0x183119160")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3118640", Offset = "0x3117A40", VA = "0x183118640")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event MMLJPPFFNLH CMGHLCAMFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x31190C0", Offset = "0x31184C0", VA = "0x1831190C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3118C10", Offset = "0x3118010", VA = "0x183118C10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event IFNNCMBFHAJ HCMCPBGGNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3118500", Offset = "0x3117900", VA = "0x183118500")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x31183C0", Offset = "0x31177C0", VA = "0x1831183C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event NLOBLMEMGGO HHNGMJPOBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3118AD0", Offset = "0x3117ED0", VA = "0x183118AD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x31186E0", Offset = "0x3117AE0", VA = "0x1831186E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event LOJCLENIFBB APEBLENHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3118A30", Offset = "0x3117E30", VA = "0x183118A30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x31185A0", Offset = "0x31179A0", VA = "0x1831185A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> BEPLPCENJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3118CB0", Offset = "0x31180B0", VA = "0x183118CB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3118780", Offset = "0x3117B80", VA = "0x183118780")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event ELAKNFEBOHJ HPLODIPHEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3119200", Offset = "0x3118600", VA = "0x183119200")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3118B70", Offset = "0x3117F70", VA = "0x183118B70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3118D50", Offset = "0x3118150", VA = "0x183118D50")]
	[Conditional("UNITY_EDITOR")]
	public void IIHJPKFCABP(IJDKBBDMEBI DGPLFECNDCD, in ADIOIKPLFDJ FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3118D80", Offset = "0x3118180", VA = "0x183118D80")]
	[Conditional("UNITY_EDITOR")]
	public void JNDLLJLPINO(IJDKBBDMEBI DGPLFECNDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3118E40", Offset = "0x3118240", VA = "0x183118E40")]
	[Conditional("UNITY_EDITOR")]
	public void KMLGLEKDNEJ(IJDKBBDMEBI DGPLFECNDCD, in ADIOIKPLFDJ FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x31192A0", Offset = "0x31186A0", VA = "0x1831192A0")]
	[Conditional("UNITY_EDITOR")]
	public void PCNEGMDHNFA(IJDKBBDMEBI DGPLFECNDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3119090", Offset = "0x3118490", VA = "0x183119090")]
	[Conditional("UNITY_EDITOR")]
	public void NFGDMNCOPDJ(IJDKBBDMEBI DGPLFECNDCD, BPHAMHGLCNC MLIELKFMALM, in MPOLKMCKMLM KPPLMEOMNGF, bool DCHMPDGMBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3118950", Offset = "0x3117D50", VA = "0x183118950")]
	[Conditional("UNITY_EDITOR")]
	public void EMIMEKDCAPI(IJDKBBDMEBI DGPLFECNDCD, BPHAMHGLCNC MLIELKFMALM, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x31192C0", Offset = "0x31186C0", VA = "0x1831192C0")]
	[Conditional("UNITY_EDITOR")]
	public void PMBPENPHCCJ(string GOENAEMJAON, object OBBOCNIOLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3118FA0", Offset = "0x31183A0", VA = "0x183118FA0")]
	[Conditional("UNITY_EDITOR")]
	public void MAKCPDAKGBN(FOLBPKGHHOJ EBOIOCBODNI, ReadOnlyMemory<byte> OBBOCNIOLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3118820", Offset = "0x3117C20", VA = "0x183118820")]
	[Conditional("UNITY_EDITOR")]
	public void DNOKICKLCAG(World BKFHGKOCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3118E70", Offset = "0x3118270", VA = "0x183118E70")]
	[Conditional("UNITY_EDITOR")]
	public void LJJLEOOHJPA(World BKFHGKOCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public GDLOHCFNDBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[IABFONFHPFO(typeof(JEOCGGOIEBA), new string[] { })]
public class EGJIMMHENNE : JEOCGGOIEBA
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2D61050", Offset = "0x2D60450", VA = "0x182D61050", Slot = "5")]
	public void AKEOAFPDGOF(object GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2D61350", Offset = "0x2D60750", VA = "0x182D61350", Slot = "6")]
	public void KHNNKKDCGJN(object GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2D61140", Offset = "0x2D60540", VA = "0x182D61140", Slot = "7")]
	public void CJHKNGFKCCC(object GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2D61230", Offset = "0x2D60630", VA = "0x182D61230", Slot = "4")]
	public IDisposable FIHMOHBBGKC(object GOMILMNIGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D4CEB0", Offset = "0x2D4C2B0", VA = "0x182D4CEB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CF00", Offset = "0x2D4C300", VA = "0x182D4CF00", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C8E0", Offset = "0x2D4BCE0", VA = "0x182D4C8E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D080", Offset = "0x2D4C480", VA = "0x182D4D080")]
		public bool KGFIKFLJCOF(IEnumerable<EMMEDLLCNCH> CAGEECIKHAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D430", Offset = "0x2D4C830", VA = "0x182D4D430")]
		public static bool LPGEGIPIELB(EMMEDLLCNCH LPOCBPNMNHF, out IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2D4CAC0", Offset = "0x2D4BEC0", VA = "0x182D4CAC0")]
		private void GKPNNODKKDP(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL, IEnumerable<EMMEDLLCNCH> CAGEECIKHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D200", Offset = "0x2D4C600", VA = "0x182D4D200")]
		private void LEKJJLKFFDG(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2D4DFB0", Offset = "0x2D4D3B0", VA = "0x182D4DFB0")]
		private void OBENAKHEJDH(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL, IJDKBBDMEBI DGPLFECNDCD, string GOENAEMJAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C580", Offset = "0x2D4B980", VA = "0x182D4C580")]
		private void ALPJFPHHPCN(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D710", Offset = "0x2D4CB10", VA = "0x182D4D710")]
		private void NOAAGBFJDBN(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL, List<EMMEDLLCNCH> EGFBJAJJONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C8F0", Offset = "0x2D4BCF0", VA = "0x182D4C8F0")]
		private NativeList<IJDKBBDMEBI> FJMKEMFGEOE(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL)
		{
			return default(NativeList<IJDKBBDMEBI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D540", Offset = "0x2D4C940", VA = "0x182D4D540")]
		private NativeArray<Entity> MFGNADIBFJN(NativeList<IJDKBBDMEBI> OKEAMEHANCD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2D4E430", Offset = "0x2D4D830", VA = "0x182D4E430")]
		private static void PCHHADECPGF(Dictionary<IJDKBBDMEBI, EMMEDLLCNCH> MOBIBCNEEOL, IJDKBBDMEBI DGPLFECNDCD, EMMEDLLCNCH LPOCBPNMNHF, string GOENAEMJAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D5F580", Offset = "0x2D5E980", VA = "0x182D5F580")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x2D5F5C0", Offset = "0x2D5E9C0", VA = "0x182D5F5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool NNEIKEIFBMI
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x2D5F600", Offset = "0x2D5EA00", VA = "0x182D5F600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x2D5F640", Offset = "0x2D5EA40", VA = "0x182D5F640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		public void LKIFDPINEGH(string GOENAEMJAON, EntityManager JGDEKKJFKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		public static void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E4250", Offset = "0x6E3650", VA = "0x1806E4250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E4270", Offset = "0x6E3670", VA = "0x1806E4270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool HELAKMEDDAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x800E90", Offset = "0x800290", VA = "0x180800E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x800EA0", Offset = "0x8002A0", VA = "0x180800EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CDB9B0", Offset = "0x2CDADB0", VA = "0x182CDB9B0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2CDA6B0", Offset = "0x2CD9AB0", VA = "0x182CDA6B0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool KJPFFELANDM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x783D00", Offset = "0x783100", VA = "0x180783D00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x7844B0", Offset = "0x7838B0", VA = "0x1807844B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public FNDMDJJGFHH FDBKDEBJKKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB4C0", Offset = "0x2CDA8C0", VA = "0x182CDB4C0", Slot = "16")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA6A0", Offset = "0x2CD9AA0", VA = "0x182CDA6A0", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB390", Offset = "0x2CDA790", VA = "0x182CDB390")]
		public static bool JBIJHELDJID(ByteString BMHLFOOGPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x722210", Offset = "0x721610", VA = "0x180722210")]
		public void CPGMIMAKPKD(OAOFKKDMKNC PKHJCMCBPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB8E0", Offset = "0x2CDACE0", VA = "0x182CDB8E0", Slot = "5")]
		public void LAOAAHMJCFG(bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBA70", Offset = "0x2CDAE70", VA = "0x182CDBA70", Slot = "6")]
		public Task LNAILFNIBOP(bool IGPDCEGDODH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA520", Offset = "0x2CD9920", VA = "0x182CDA520", Slot = "7")]
		public ByteString CJKIIDNIDDE(out IDisposable FIOJMHPAHHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA340", Offset = "0x2CD9740", VA = "0x182CDA340", Slot = "19")]
		public ByteString CJKIIDNIDDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA6C0", Offset = "0x2CD9AC0", VA = "0x182CDA6C0", Slot = "9")]
		public bool EOLLHEJPBAN(ByteString MBNJCFBPOAL, NJNFGALPFEE HGNBPKPAAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2CDABB0", Offset = "0x2CD9FB0", VA = "0x182CDABB0")]
		private bool GMGGAPDFFIN(ByteString MBNJCFBPOAL, NJNFGALPFEE HGNBPKPAAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9DD0", Offset = "0x2CD91D0", VA = "0x182CD9DD0", Slot = "8")]
		public void ACDCHJGJMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA940", Offset = "0x2CD9D40", VA = "0x182CDA940", Slot = "10")]
		public bool GGOEDFNGDOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB560", Offset = "0x2CDA960", VA = "0x182CDB560", Slot = "11")]
		public bool KGFIKFLJCOF(IEnumerable<EMMEDLLCNCH> PNDLEPGFOGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9FA0", Offset = "0x2CD93A0", VA = "0x182CD9FA0")]
		public bool AFFHLMLBHHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2CDAED0", Offset = "0x2CDA2D0", VA = "0x182CDAED0", Slot = "12")]
		public bool HBECBLLPJDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA0B0", Offset = "0x2CD94B0", VA = "0x182CDA0B0")]
		public void CAGDCHNLIOC(FNDMDJJGFHH.OADFLCFJFGF.HEDMGLIHHHI ADOLOEKMGLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB100", Offset = "0x2CDA500", VA = "0x182CDB100")]
		private bool HCLGEPCMJMB(ByteString MBNJCFBPOAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA720", Offset = "0x2CD9B20", VA = "0x182CDA720")]
		private void FFKJFAANGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBB00", Offset = "0x2CDAF00", VA = "0x182CDBB00")]
		private ByteString NPIKIFGINIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB7D0", Offset = "0x2CDABD0", VA = "0x182CDB7D0")]
		private ByteString KMAEBGCBAED(ByteString BMHLFOOGPAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA600", Offset = "0x2CD9A00", VA = "0x182CDA600")]
		private FNDMDJJGFHH.OADFLCFJFGF.HEDMGLIHHHI DELOPEIOJBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA080", Offset = "0x2CD9480", VA = "0x182CDA080")]
		private void AFOCEKJHPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBB60", Offset = "0x2CDAF60", VA = "0x182CDBB60", Slot = "13")]
		public bool OHBHCAIGIHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB9C0", Offset = "0x2CDADC0", VA = "0x182CDB9C0", Slot = "14")]
		public void LGOJHIHHOKC(bool CEHAMLKELDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA770", Offset = "0x2CD9B70", VA = "0x182CDA770")]
		private void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D46080", Offset = "0x2D45480", VA = "0x182D46080", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2D45AE0", Offset = "0x2D44EE0", VA = "0x182D45AE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<CONHDBOPGAO> PGEIPEOFDGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D45FE0", Offset = "0x2D453E0", VA = "0x182D45FE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D45D10", Offset = "0x2D45110", VA = "0x182D45D10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action IJICLIHOPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D46120", Offset = "0x2D45520", VA = "0x182D46120", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D45F40", Offset = "0x2D45340", VA = "0x182D45F40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action BIIPHAMKIME
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D45C70", Offset = "0x2D45070", VA = "0x182D45C70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D45DB0", Offset = "0x2D451B0", VA = "0x182D45DB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<CONHDBOPGAO> KNBEBGNBJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D45BD0", Offset = "0x2D44FD0", VA = "0x182D45BD0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D45E50", Offset = "0x2D45250", VA = "0x182D45E50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x12008A0", Offset = "0x11FFCA0", VA = "0x1812008A0")]
	public void ACDCHJGJMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x12006E0", Offset = "0x11FFAE0", VA = "0x1812006E0")]
	public void IOMMAIDLKGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1182F40", Offset = "0x1182340", VA = "0x181182F40")]
	public void OGEMCEMIGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D45EF0", Offset = "0x2D452F0", VA = "0x182D45EF0")]
	public void NINDDAOKPBN(CONHDBOPGAO OIAFFOAGAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D45B80", Offset = "0x2D44F80", VA = "0x182D45B80")]
	public void GNBELAEHPMG(CONHDBOPGAO OIAFFOAGAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E7580", Offset = "0x6E6980", VA = "0x1806E7580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6E75A0", Offset = "0x6E69A0", VA = "0x1806E75A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager DDFIBDHKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x31167C0", Offset = "0x3115BC0", VA = "0x1831167C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1957CC0", Offset = "0x19570C0", VA = "0x181957CC0", Slot = "14")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3116AE0", Offset = "0x3115EE0", VA = "0x183116AE0", Slot = "15")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x31165C0", Offset = "0x31159C0", VA = "0x1831165C0", Slot = "16")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1957BF0", Offset = "0x1956FF0", VA = "0x181957BF0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B4CEF0", Offset = "0x2B4C2F0", VA = "0x182B4CEF0")]
	private GPEJGMHBDPO DHJIOFINLAO(Entity PJEENOLDJIO)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x31172B0", Offset = "0x31166B0", VA = "0x1831172B0", Slot = "4")]
	public GPEJGMHBDPO PLFCFKIEBOC(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x31168C0", Offset = "0x3115CC0", VA = "0x1831168C0", Slot = "19")]
	public void JJOOJLAKEOM(ref List<GPEJGMHBDPO> NKLDGGPGPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x31171E0", Offset = "0x31165E0", VA = "0x1831171E0", Slot = "20")]
	public IEnumerable<GPEJGMHBDPO> PKDPPNNMDAK(GPEJGMHBDPO GBPGPLEPLBP, bool GNDBKIJJAND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x31162D0", Offset = "0x31156D0", VA = "0x1831162D0", Slot = "21")]
	public GPEJGMHBDPO ELIAHCIMIEO(GPEJGMHBDPO GBPGPLEPLBP, int EGBCAPEEJBF)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x31164A0", Offset = "0x31158A0", VA = "0x1831164A0", Slot = "22")]
	public int EOLCOIPHINA(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3116C80", Offset = "0x3116080", VA = "0x183116C80", Slot = "8")]
	public int KIPGBJMICGF(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x31170C0", Offset = "0x31164C0", VA = "0x1831170C0", Slot = "9")]
	public LNMIPKFIEGC PEHLCNLPMAC(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(LNMIPKFIEGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3116E20", Offset = "0x3116220", VA = "0x183116E20", Slot = "23")]
	public bool OJBBEGIAKJG(GPEJGMHBDPO GBPGPLEPLBP, out LNMIPKFIEGC ANHOGGAMAEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3116BB0", Offset = "0x3115FB0", VA = "0x183116BB0", Slot = "24")]
	public IEnumerable<GPEJGMHBDPO> JNFNFOAALOH(GPEJGMHBDPO GBPGPLEPLBP, bool GNDBKIJJAND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3116FF0", Offset = "0x31163F0", VA = "0x183116FF0", Slot = "12")]
	public GPEJGMHBDPO OLCENLILHJP(GPEJGMHBDPO PDOBLLBCDKJ, GPEJGMHBDPO FENFFOFPKDO)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3116200", Offset = "0x3115600", VA = "0x183116200", Slot = "13")]
	public bool DBLIAABGAHD(GPEJGMHBDPO PDOBLLBCDKJ, GPEJGMHBDPO FENFFOFPKDO, out GPEJGMHBDPO HGNJLFHFDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x31166B0", Offset = "0x3115AB0", VA = "0x1831166B0", Slot = "5")]
	public GPEJGMHBDPO FCHNDLGHOIE(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x31171B0", Offset = "0x31165B0", VA = "0x1831171B0", Slot = "11")]
	public bool PFJDPANHIDM(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO ADAJCIOPLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x31161D0", Offset = "0x31155D0", VA = "0x1831161D0", Slot = "25")]
	public bool CCMBIGLHNMK(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO BOGHNKLNLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x31161A0", Offset = "0x31155A0", VA = "0x1831161A0", Slot = "10")]
	public bool BEPDKIFHAFJ(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO PDOBLLBCDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3116810", Offset = "0x3115C10", VA = "0x183116810", Slot = "6")]
	public bool JDHACNMMLIE(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO OKMBLMILFGG, bool ANHIENPBNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3116750", Offset = "0x3115B50", VA = "0x183116750", Slot = "7")]
	public bool GLJCMDFJBFM(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO OKMBLMILFGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D60930", Offset = "0x2D5FD30", VA = "0x182D60930", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D60360", Offset = "0x2D5F760", VA = "0x182D60360", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D605D0", Offset = "0x2D5F9D0", VA = "0x182D605D0")]
	public HPMBAGGHCAG HHNKAJHAOAE(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2D607E0", Offset = "0x2D5FBE0", VA = "0x182D607E0")]
	public HPMBAGGHCAG HHNKAJHAOAE(BPHAMHGLCNC AOKMGDODDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2D604B0", Offset = "0x2D5F8B0", VA = "0x182D604B0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2D60980", Offset = "0x2D5FD80", VA = "0x182D60980")]
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
		[Cpp2IlInjected.Address(RVA = "0xCE63C0", Offset = "0xCE57C0", VA = "0x180CE63C0")]
		get
		{
			return default(NativeList<PGHABJEAHKP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<EJDOAJBNLAC> FKMHHEDDFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xC11C00", Offset = "0xC11000", VA = "0x180C11C00")]
		get
		{
			return default(NativeList<EJDOAJBNLAC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<DFLCMAHAHIM> DEIDKIDMILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xE991A0", Offset = "0xE985A0", VA = "0x180E991A0")]
		get
		{
			return default(NativeList<DFLCMAHAHIM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<EJDOAJBNLAC> MPOKGNKHHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xFE5210", Offset = "0xFE4610", VA = "0x180FE5210")]
		get
		{
			return default(NativeList<EJDOAJBNLAC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle DOPKIHCHLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x10F60B0", Offset = "0x10F54B0", VA = "0x1810F60B0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1370560", Offset = "0x136F960", VA = "0x181370560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool KCIOFPNPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xED5AB0", Offset = "0xED4EB0", VA = "0x180ED5AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool PMNEPBJNENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x311BFF0", Offset = "0x311B3F0", VA = "0x18311BFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x311C0A0", Offset = "0x311B4A0", VA = "0x18311C0A0")]
	public HPMBAGGHCAG(Allocator GOLNHBOGNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x311BB00", Offset = "0x311AF00", VA = "0x18311BB00")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x311BEC0", Offset = "0x311B2C0", VA = "0x18311BEC0")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x311BB90", Offset = "0x311AF90", VA = "0x18311BB90")]
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
	[Cpp2IlInjected.Address(RVA = "0x311B3A0", Offset = "0x311A7A0", VA = "0x18311B3A0", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x311B380", Offset = "0x311A780", VA = "0x18311B380", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B56E80", Offset = "0x2B56280", VA = "0x182B56E80", Slot = "5")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2B56EE0", Offset = "0x2B562E0", VA = "0x182B56EE0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2B56BD0", Offset = "0x2B55FD0", VA = "0x182B56BD0")]
		public void FABNEPJDBBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2B56AE0", Offset = "0x2B55EE0", VA = "0x182B56AE0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2B56C70", Offset = "0x2B56070", VA = "0x182B56C70")]
		public void HNKLBDKIDPO(global::DFJBCINJNGH<int> BFIKAJGDHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2B56F50", Offset = "0x2B56350", VA = "0x182B56F50")]
		public void KPDKGAONBIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x9B8200", Offset = "0x9B7600", VA = "0x1809B8200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2B451E0", Offset = "0x2B445E0", VA = "0x182B451E0")]
	public IJDKBBDMEBI MKEIGDPDNLI()
	{
		return default(IJDKBBDMEBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2B45230", Offset = "0x2B44630", VA = "0x182B45230")]
	public void NEFAKFGJPMJ(IJDKBBDMEBI DGPLFECNDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xECBD80", Offset = "0xECB180", VA = "0x180ECBD80", Slot = "6")]
	public virtual void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0010", Offset = "0x6DF410", VA = "0x1806E0010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x311F210", Offset = "0x311E610", VA = "0x18311F210", Slot = "7")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x311F2B0", Offset = "0x311E6B0", VA = "0x18311F2B0")]
	private void OFOOPHJOKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x311F1B0", Offset = "0x311E5B0", VA = "0x18311F1B0", Slot = "6")]
	public override void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B47580", Offset = "0x2B46980", VA = "0x182B47580")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery AIOPFBNCFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x701040", Offset = "0x700440", VA = "0x180701040")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery KLEEMFNPACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x701030", Offset = "0x700430", VA = "0x180701030")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery PPKPGCAMEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xFC8D60", Offset = "0xFC8160", VA = "0x180FC8D60")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery DGKJGDIEGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x10F60B0", Offset = "0x10F54B0", VA = "0x1810F60B0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery FJCBIDLCECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x10F6890", Offset = "0x10F5C90", VA = "0x1810F6890")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery MPKDCDEMDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2B47700", Offset = "0x2B46B00", VA = "0x182B47700")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int DNIDCAJKPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2B476E0", Offset = "0x2B46AE0", VA = "0x182B476E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int IHMBBPFEOBG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2B475D0", Offset = "0x2B469D0", VA = "0x182B475D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int FEDBEPEBODG
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2B476C0", Offset = "0x2B46AC0", VA = "0x182B476C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int NDKLKDPOBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2B47640", Offset = "0x2B46A40", VA = "0x182B47640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int FDOHOLAIHME
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2B46E30", Offset = "0x2B46230", VA = "0x182B46E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int HINADLHMOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2B46EB0", Offset = "0x2B462B0", VA = "0x182B46EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "4")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2B475F0", Offset = "0x2B469F0", VA = "0x182B475F0", Slot = "5")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2B46ED0", Offset = "0x2B462D0", VA = "0x182B46ED0", Slot = "6")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2B47660", Offset = "0x2B46A60", VA = "0x182B47660")]
	private EntityQueryDesc LKHBLEGDHOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2B46E50", Offset = "0x2B46250", VA = "0x182B46E50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2B47420", Offset = "0x2B46820", VA = "0x182B47420")]
	public OKPPODDCHEL FGOOKEJCEGB(GPEJGMHBDPO LCCDBPIJCNE)
	{
		return default(OKPPODDCHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2B47370", Offset = "0x2B46770", VA = "0x182B47370")]
	public OKPPODDCHEL FGOOKEJCEGB(Entity PJEENOLDJIO)
	{
		return default(OKPPODDCHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2B474D0", Offset = "0x2B468D0", VA = "0x182B474D0")]
	public OBNHEEKLBIB IJPMOHIFBJK(Entity PJEENOLDJIO)
	{
		return default(OBNHEEKLBIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2B47780", Offset = "0x2B46B80", VA = "0x182B47780")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int DNIDCAJKPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2B554C0", Offset = "0x2B548C0", VA = "0x182B554C0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int IHMBBPFEOBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2B546B0", Offset = "0x2B53AB0", VA = "0x182B546B0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int FEDBEPEBODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2B55240", Offset = "0x2B54640", VA = "0x182B55240", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int NDKLKDPOBBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2B54C10", Offset = "0x2B54010", VA = "0x182B54C10", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int FDOHOLAIHME
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2B537F0", Offset = "0x2B52BF0", VA = "0x182B537F0", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int HINADLHMOGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2B53E10", Offset = "0x2B53210", VA = "0x182B53E10", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<GPEJGMHBDPO, OBNHEEKLBIB> LONFBPMMGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2B53E40", Offset = "0x2B53240", VA = "0x182B53E40", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2B53490", Offset = "0x2B52890", VA = "0x182B53490", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<GPEJGMHBDPO> BGPPAHLBDPO
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2B54F50", Offset = "0x2B54350", VA = "0x182B54F50", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2B54410", Offset = "0x2B53810", VA = "0x182B54410", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2B54930", Offset = "0x2B53D30", VA = "0x182B54930", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2B53B30", Offset = "0x2B52F30", VA = "0x182B53B30", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2B54E10", Offset = "0x2B54210", VA = "0x182B54E10")]
		private void MHIOIGHIBNM(Entity PJEENOLDJIO, OBNHEEKLBIB IBFEICPOBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2B539D0", Offset = "0x2B52DD0", VA = "0x182B539D0")]
		private void DHGHBKGBICL(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2B53A60", Offset = "0x2B52E60", VA = "0x182B53A60")]
		internal GPEJGMHBDPO DHJIOFINLAO(Entity PJEENOLDJIO)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2B54EB0", Offset = "0x2B542B0", VA = "0x182B54EB0", Slot = "41")]
		public LNMIPKFIEGC MMPNOCAJABC()
		{
			return default(LNMIPKFIEGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2B554F0", Offset = "0x2B548F0", VA = "0x182B554F0", Slot = "42")]
		public LNMIPKFIEGC PECJIHCFOKA()
		{
			return default(LNMIPKFIEGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2B53CB0", Offset = "0x2B530B0", VA = "0x182B53CB0", Slot = "43")]
		public LNMIPKFIEGC EAABOFBIABC()
		{
			return default(LNMIPKFIEGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2B54000", Offset = "0x2B53400", VA = "0x182B54000", Slot = "10")]
		public OKPPODDCHEL FGOOKEJCEGB(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(OKPPODDCHEL);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2B544B0", Offset = "0x2B538B0", VA = "0x182B544B0", Slot = "11")]
		public OBNHEEKLBIB IJPMOHIFBJK(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(OBNHEEKLBIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2B54600", Offset = "0x2B53A00", VA = "0x182B54600")]
		private LNMIPKFIEGC IKMNJMMAFKM(EntityQuery APEJLGJADFF)
		{
			return default(LNMIPKFIEGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2B53620", Offset = "0x2B52A20", VA = "0x182B53620", Slot = "33")]
		public bool BKIFKBMENNF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2B535D0", Offset = "0x2B529D0", VA = "0x182B535D0", Slot = "29")]
		public void BAFMLPIANAD(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2B53970", Offset = "0x2B52D70", VA = "0x182B53970", Slot = "30")]
		public void DBEGAACJLOG(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2B54890", Offset = "0x2B53C90", VA = "0x182B54890", Slot = "31")]
		public void JMGLAECFLLN(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2B552F0", Offset = "0x2B546F0", VA = "0x182B552F0", Slot = "22")]
		public CDFLNPBCBAA NPGIBDEMFPM(OBNHEEKLBIB IBFEICPOBBG, bool BABPFLEGDHL)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2B55270", Offset = "0x2B54670", VA = "0x182B55270", Slot = "23")]
		public CDFLNPBCBAA NPGIBDEMFPM(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2B54340", Offset = "0x2B53740", VA = "0x182B54340", Slot = "24")]
		public CDFLNPBCBAA HBBIFLCNHAN(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2B54FF0", Offset = "0x2B543F0", VA = "0x182B54FF0", Slot = "25")]
		public CDFLNPBCBAA NFKICFAFKEF(IJDKBBDMEBI DGPLFECNDCD, OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2B54BA0", Offset = "0x2B53FA0", VA = "0x182B54BA0", Slot = "44")]
		public CDFLNPBCBAA JMPLLPHEPGD(int OLCDBMHGIMP, OBNHEEKLBIB IBFEICPOBBG, GameObject BLPBCMIHDMD)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2B54D70", Offset = "0x2B54170", VA = "0x182B54D70", Slot = "26")]
		public NBODNKOLKBD LOKKOCJOODO()
		{
			return default(NBODNKOLKBD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2B53820", Offset = "0x2B52C20", VA = "0x182B53820", Slot = "45")]
		public LADIDIPKOKJ CMIPAENJOBN(LFGFCMFBCNM HAOFNDAEGFJ)
		{
			return default(LADIDIPKOKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2B53A80", Offset = "0x2B52E80", VA = "0x182B53A80", Slot = "27")]
		public DAIBEFDKFJE DPPJEBGFDDC()
		{
			return default(DAIBEFDKFJE);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2B53EE0", Offset = "0x2B532E0", VA = "0x182B53EE0", Slot = "28")]
		public BCDBMEOMLBF FEGDAGMALKP(MCLBIBPLLEA HAOFNDAEGFJ)
		{
			return default(BCDBMEOMLBF);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2B54110", Offset = "0x2B53510", VA = "0x182B54110", Slot = "12")]
		public void GBHABPPKBJN(IJDKBBDMEBI DGPLFECNDCD, EMAJLAJEHKH LJJGKNLIGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2B54190", Offset = "0x2B53590", VA = "0x182B54190", Slot = "13")]
		public CDFLNPBCBAA GEMGJFNJBAB(GPEJGMHBDPO GBPGPLEPLBP, [Optional] object JAKCBCDLMLB)
		{
			return default(CDFLNPBCBAA);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2B54CB0", Offset = "0x2B540B0", VA = "0x182B54CB0", Slot = "14")]
		public bool KLLNBFNLACK(GPEJGMHBDPO GBPGPLEPLBP, out EMAJLAJEHKH GPPHCPBMODE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2B540C0", Offset = "0x2B534C0", VA = "0x182B540C0", Slot = "46")]
		public Transform FPAEAJMMINO(GPEJGMHBDPO GBPGPLEPLBP, [Optional] object JAKCBCDLMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2B537A0", Offset = "0x2B52BA0", VA = "0x182B537A0", Slot = "16")]
		public bool CGMALIJKBMC(GPEJGMHBDPO GBPGPLEPLBP, out Transform PKIKNDCFAFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2B53920", Offset = "0x2B52D20", VA = "0x182B53920", Slot = "17")]
		public bool CPIAGHNENJJ(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2B553E0", Offset = "0x2B547E0", VA = "0x182B553E0")]
		public bool OCEBLLHENFE(EMAJLAJEHKH KPPLMEOMNGF, [Optional] object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2B55410", Offset = "0x2B54810", VA = "0x182B55410", Slot = "47")]
		public bool OCEBLLHENFE(GPEJGMHBDPO GBPGPLEPLBP, [Optional] object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2B54D50", Offset = "0x2B54150", VA = "0x182B54D50", Slot = "48")]
		public void LNLDIFPJBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2B546E0", Offset = "0x2B53AE0", VA = "0x182B546E0", Slot = "15")]
		public void JJCKLLJLOGC(EMAJLAJEHKH AELIHOPICED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2B543D0", Offset = "0x2B537D0", VA = "0x182B543D0", Slot = "49")]
		public void HHLPCJAJHPN(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2B54580", Offset = "0x2B53980", VA = "0x182B54580", Slot = "18")]
		public bool IKALCDHMJEH(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2B55440", Offset = "0x2B54840", VA = "0x182B55440", Slot = "19")]
		public bool ODMDIGGOFIK(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2B55600", Offset = "0x2B54A00", VA = "0x182B55600", Slot = "50")]
		public bool PODBFJOOFPP(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2B54C40", Offset = "0x2B54040", VA = "0x182B54C40", Slot = "51")]
		public bool KFENFCDAEAH(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2B54130", Offset = "0x2B53530", VA = "0x182B54130", Slot = "32")]
		public NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)> GCBMLPIIEEI(NativeArray<GPEJGMHBDPO> PJAAAGDAINA, Allocator GOLNHBOGNGC)
		{
			return default(NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2B53530", Offset = "0x2B52930", VA = "0x182B53530", Slot = "21")]
		public IJDKBBDMEBI BAAKGEKGEDO(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(IJDKBBDMEBI);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2B536B0", Offset = "0x2B52AB0", VA = "0x182B536B0", Slot = "20")]
		public GPEJGMHBDPO BPFLLEIAFPB(IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2B53D50", Offset = "0x2B53150", VA = "0x182B53D50")]
		private void EDKGEGKEJEA(OBNHEEKLBIB IBFEICPOBBG, GPEJGMHBDPO GBPGPLEPLBP, IJDKBBDMEBI DGPLFECNDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D47AE0", Offset = "0x2D46EE0", VA = "0x182D47AE0", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2D479E0", Offset = "0x2D46DE0", VA = "0x182D479E0")]
	public NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)> GCBMLPIIEEI(NativeArray<GPEJGMHBDPO> PJAAAGDAINA, Allocator GOLNHBOGNGC)
	{
		return default(NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2D46F00", Offset = "0x2D46300", VA = "0x182D46F00")]
	private void ADPDJBHKJMP(NativeMultiHashMap<int, (GPEJGMHBDPO src, GPEJGMHBDPO dst)> GIFFOIDMGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2D47550", Offset = "0x2D46950", VA = "0x182D47550")]
	private void BBMKMNFHGHJ(NativeMultiHashMap<int, (GPEJGMHBDPO src, GPEJGMHBDPO dst)> GIFFOIDMGKM, int IBFEICPOBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2D473C0", Offset = "0x2D467C0", VA = "0x182D473C0")]
	private void AKKMIAKHEDE(NativeMultiHashMap<int, (GPEJGMHBDPO src, GPEJGMHBDPO dst)> GIFFOIDMGKM, int IBFEICPOBBG, GBOCHCBEADE ICBILMELIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2D470E0", Offset = "0x2D464E0", VA = "0x182D470E0")]
	private NativeMultiHashMap<int, (GPEJGMHBDPO, GPEJGMHBDPO)> AFBPHKKBPMO(Allocator GOLNHBOGNGC, NativeArray<GPEJGMHBDPO> PJAAAGDAINA, out NativeArray<(GPEJGMHBDPO src, GPEJGMHBDPO dst)> DBMMCBDCINA)
	{
		return default(NativeMultiHashMap<int, (GPEJGMHBDPO, GPEJGMHBDPO)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CE4560", Offset = "0x2CE3960", VA = "0x182CE4560")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private JLCGKPAGLMB JADDHOMJIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x2CE2C10", Offset = "0x2CE2010", VA = "0x182CE2C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE4890", Offset = "0x2CE3C90", VA = "0x182CE4890", Slot = "33")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2760", Offset = "0x2CE1B60", VA = "0x182CE2760", Slot = "34")]
		public bool CJELNEIGLGO(Transform PKIKNDCFAFJ, out GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3EB0", Offset = "0x2CE32B0", VA = "0x182CE3EB0", Slot = "35")]
		public Transform FJEJMGNKJIP(Entity PJEENOLDJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE24F0", Offset = "0x2CE18F0", VA = "0x182CE24F0", Slot = "30")]
		public bool CGMALIJKBMC(Entity PJEENOLDJIO, out Transform PKIKNDCFAFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6690", Offset = "0x2CE5A90", VA = "0x182CE6690")]
		private void PLKCLPDECOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5E50", Offset = "0x2CE5250", VA = "0x182CE5E50", Slot = "29")]
		public void OMKFDFNIAJJ(Entity PJEENOLDJIO, out Matrix4x4 KFNJNHOHJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2CE4370", Offset = "0x2CE3770", VA = "0x182CE4370", Slot = "4")]
		public void IEPKMGFHODI(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1E00", Offset = "0x2CE1200", VA = "0x182CE1E00")]
		public void BHFIJGMDJJP(Entity PJEENOLDJIO, Vector3 MBFNFKBJPCL, Quaternion EBMHHHHKPIA, Vector3 KAEBFLACOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2CE61C0", Offset = "0x2CE55C0", VA = "0x182CE61C0")]
		public void PANAMLFNMKM(Entity PJEENOLDJIO, Vector3 MBFNFKBJPCL, Quaternion EBMHHHHKPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5540", Offset = "0x2CE4940", VA = "0x182CE5540", Slot = "27")]
		public void NFCGOIEOCJB(Entity PJEENOLDJIO, out Matrix4x4 IDBPHKDPEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2CE62D0", Offset = "0x2CE56D0", VA = "0x182CE62D0")]
		public void PHOECKOKDKI(Entity PJEENOLDJIO, in Matrix4x4 KFNJNHOHJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3C30", Offset = "0x2CE3030", VA = "0x182CE3C30")]
		public void EPNNOBOLICL(Entity PJEENOLDJIO, in Matrix4x4 KFNJNHOHJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2330", Offset = "0x2CE1730", VA = "0x182CE2330")]
		public void CDPIOPMOHPP(Entity PJEENOLDJIO, in Matrix4x4 FEMLPJHHNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1B00", Offset = "0x2CE0F00", VA = "0x182CE1B00", Slot = "5")]
		public void BBOADPLCJPI(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2CE49A0", Offset = "0x2CE3DA0", VA = "0x182CE49A0", Slot = "6")]
		public Vector3 KIFABACKKPJ(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2CE66B0", Offset = "0x2CE5AB0", VA = "0x182CE66B0", Slot = "7")]
		public void PPJHEHDDOLF(Entity PJEENOLDJIO, Quaternion KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE52A0", Offset = "0x2CE46A0", VA = "0x182CE52A0", Slot = "8")]
		public Quaternion MHFNKDBALLE(Entity PJEENOLDJIO)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1C20", Offset = "0x2CE1020", VA = "0x182CE1C20", Slot = "12")]
		public void BFHLPIKGJHN(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3880", Offset = "0x2CE2C80", VA = "0x182CE3880", Slot = "11")]
		public Vector3 EJGNALJEEBN(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1A60", Offset = "0x2CE0E60", VA = "0x182CE1A60")]
		public void BBHPGOADENE(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE26C0", Offset = "0x2CE1AC0", VA = "0x182CE26C0")]
		private Vector3 CJBHDMBPEAD(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2CE18D0", Offset = "0x2CE0CD0", VA = "0x182CE18D0", Slot = "14")]
		public float AKMGLHLMAOI(Entity PJEENOLDJIO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5B30", Offset = "0x2CE4F30", VA = "0x182CE5B30", Slot = "13")]
		public void OCKPLCBEGKF(Entity PJEENOLDJIO, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2CE60D0", Offset = "0x2CE54D0", VA = "0x182CE60D0")]
		private float OPLEPMOKCHG(Entity PJEENOLDJIO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2A60", Offset = "0x2CE1E60", VA = "0x182CE2A60")]
		public void CNDMIDAMEME(Entity PJEENOLDJIO, float AJLJCODIBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2CE25E0", Offset = "0x2CE19E0", VA = "0x182CE25E0", Slot = "16")]
		public Vector3 CIIFPNOANIO(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2CE45B0", Offset = "0x2CE39B0", VA = "0x182CE45B0", Slot = "15")]
		public void JDCBGNOIOGJ(Entity PJEENOLDJIO, Vector3 GJHOGJGJPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5FA0", Offset = "0x2CE53A0", VA = "0x182CE5FA0")]
		private Vector3 OPGOCMDKKDG(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5C40", Offset = "0x2CE5040", VA = "0x182CE5C40")]
		public void OEDLLEEOMJO(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2CE46E0", Offset = "0x2CE3AE0", VA = "0x182CE46E0")]
		[Conditional("DEBUG_BUILD")]
		private void JJCALJOMFHF(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2CD0", Offset = "0x2CE20D0", VA = "0x182CE2CD0", Slot = "36")]
		public void DNJCOHKIFIM(Entity PJEENOLDJIO, Vector3 MIFJBHLKJIN, Quaternion OLBDAPNGDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3FF0", Offset = "0x2CE33F0", VA = "0x182CE3FF0", Slot = "9")]
		public void GFCMMFBPAAM(Entity PJEENOLDJIO, out Vector3 MIFJBHLKJIN, out Quaternion OLBDAPNGDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5D10", Offset = "0x2CE5110", VA = "0x182CE5D10", Slot = "10")]
		public void OFHLPIDPPON(Entity PJEENOLDJIO, out Vector3 MIFJBHLKJIN, out Quaternion OLBDAPNGDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5080", Offset = "0x2CE4480", VA = "0x182CE5080", Slot = "37")]
		public void LPBOFGEKIEB(Entity PJEENOLDJIO, Vector3 MIFJBHLKJIN, Quaternion OLBDAPNGDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3A70", Offset = "0x2CE2E70", VA = "0x182CE3A70")]
		public void EOKKNDBKCHA(Entity PJEENOLDJIO, Vector3 MIFJBHLKJIN, Quaternion OLBDAPNGDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE4140", Offset = "0x2CE3540", VA = "0x182CE4140", Slot = "17")]
		public void GNNLADJMFCP(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1D20", Offset = "0x2CE1120", VA = "0x182CE1D20", Slot = "18")]
		public Vector3 BGOGHJCBENP(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2FA0", Offset = "0x2CE23A0", VA = "0x182CE2FA0", Slot = "19")]
		public void EGLJAPGDEPG(Entity PJEENOLDJIO, Quaternion KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5550", Offset = "0x2CE4950", VA = "0x182CE5550", Slot = "20")]
		public Quaternion NINNEGKMMIN(Entity PJEENOLDJIO)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1ED0", Offset = "0x2CE12D0", VA = "0x182CE1ED0", Slot = "22")]
		public void CAEMMIGJJCA(Entity PJEENOLDJIO, Vector3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1970", Offset = "0x2CE0D70", VA = "0x182CE1970", Slot = "21")]
		public Vector3 AOLOKGKNIJJ(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2E30", Offset = "0x2CE2230", VA = "0x182CE2E30", Slot = "23")]
		public void EAMNBHFMEKI(Entity PJEENOLDJIO, float PJBHBFMMIOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2CE17B0", Offset = "0x2CE0BB0", VA = "0x182CE17B0", Slot = "24")]
		public float ABJFADFPCJD(Entity PJEENOLDJIO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5640", Offset = "0x2CE4A40", VA = "0x182CE5640", Slot = "25")]
		public void NPOMLANMLPB(Entity PJEENOLDJIO, Vector3 KEEGNGGHACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2920", Offset = "0x2CE1D20", VA = "0x182CE2920", Slot = "26")]
		public Vector3 CKJMHGEKPOL(Entity PJEENOLDJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2CE31E0", Offset = "0x2CE25E0", VA = "0x182CE31E0", Slot = "31")]
		public void EIANPNBBNBO(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3D60", Offset = "0x2CE3160", VA = "0x182CE3D60")]
		private GPEJGMHBDPO FBOGJOOPDJE(Transform PKIKNDCFAFJ)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2CE4AB0", Offset = "0x2CE3EB0", VA = "0x182CE4AB0")]
		private static TransformEntity LBFHOGFNEJO(OBNHEEKLBIB HAOFNDAEGFJ, GameObject LOCIAIPOBLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2AF0", Offset = "0x2CE1EF0", VA = "0x182CE2AF0", Slot = "32")]
		public void CONCMHPGOPE(Entity PJEENOLDJIO, Entity KJNCJMANDLF, Entity KHLHKJKADHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3F70", Offset = "0x2CE3370", VA = "0x182CE3F70")]
		private KEGHKGPFCFN GFCMMFBPAAM(Entity PJEENOLDJIO)
		{
			return default(KEGHKGPFCFN);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3990", Offset = "0x2CE2D90", VA = "0x182CE3990")]
		private bool EMHBKFNELKD(Entity PJEENOLDJIO, out Entity OKMBLMILFGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5390", Offset = "0x2CE4790", VA = "0x182CE5390")]
		private void MLINHKKJOFD(Entity PJEENOLDJIO, out Matrix4x4 KFNJNHOHJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2CE4CE0", Offset = "0x2CE40E0", VA = "0x182CE4CE0")]
		private void LDMKFKEOFOB(Entity PJEENOLDJIO, out Matrix4x4 FEMLPJHHNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5E40", Offset = "0x2CE5240", VA = "0x182CE5E40", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B42230", Offset = "0x2B41630", VA = "0x182B42230", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2B421C0", Offset = "0x2B415C0", VA = "0x182B421C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x41BDDB0", Offset = "0x41BD1B0", VA = "0x1841BDDB0")]
		public OIGOMFLAIKO(GNEGPFIBKFN OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x41BDD90", Offset = "0x41BD190", VA = "0x1841BDD90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x10AD9F0", Offset = "0x10ACDF0", VA = "0x1810AD9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action GMBFHBMIPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x311A250", Offset = "0x3119650", VA = "0x18311A250")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x311A320", Offset = "0x3119720", VA = "0x18311A320")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x311A2F0", Offset = "0x31196F0", VA = "0x18311A2F0")]
	public OIGOMFLAIKO HJDABMCHLDO()
	{
		return default(OIGOMFLAIKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x13BD120", Offset = "0x13BC520", VA = "0x1813BD120")]
	public void ICIPFBNLMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x311A230", Offset = "0x3119630", VA = "0x18311A230")]
	public void DEDKIMIMABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0xDD91C0", Offset = "0xDD85C0", VA = "0x180DD91C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DD0", Offset = "0x9C41D0", VA = "0x1809C4DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BB460", Offset = "0x41BA860", VA = "0x1841BB460")]
			public LFNAJNOEDIE(NativeArray<int> NJFCJFKAOFB, NativeArray<int> CAHDBKNLLCN, Dictionary<ComponentSystemBase, int> KMOICGDDEDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x41BB1E0", Offset = "0x41BA5E0", VA = "0x1841BB1E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
			[DebuggerHidden]
			public NBOAFDCGCNH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x41BC860", Offset = "0x41BBC60", VA = "0x1841BC860", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x41BCA30", Offset = "0x41BBE30", VA = "0x1841BCA30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x41BC980", Offset = "0x41BBD80", VA = "0x1841BC980", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x41BC980", Offset = "0x41BBD80", VA = "0x1841BC980", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x310D4C0", Offset = "0x310C8C0", VA = "0x18310D4C0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x310CBD0", Offset = "0x310BFD0", VA = "0x18310CBD0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x310D9B0", Offset = "0x310CDB0", VA = "0x18310D9B0")]
		[IteratorStateMachine(typeof(NBOAFDCGCNH))]
		private IEnumerable<ComponentSystemBase> OIEJAFGAPNA(int GODLNPABGMH, int EICPOANFBCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x310D940", Offset = "0x310CD40", VA = "0x18310D940", Slot = "5")]
		public void NMNMMBPECAK(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x310D630", Offset = "0x310CA30", VA = "0x18310D630")]
		private void LCKAEHCHHME(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x310D780", Offset = "0x310CB80", VA = "0x18310D780")]
		public void LCKAEHCHHME(PGBOFPGBDBH LEHOMGAJBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x310C920", Offset = "0x310BD20", VA = "0x18310C920")]
		private void DDMLGMDJGOM(PGBOFPGBDBH LEHOMGAJBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x310DA40", Offset = "0x310CE40", VA = "0x18310DA40")]
		private void OJKCDCDMAKP(PGBOFPGBDBH LEHOMGAJBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x310CCA0", Offset = "0x310C0A0", VA = "0x18310CCA0")]
		private void EMIGBBKDFOE(PGBOFPGBDBH LEHOMGAJBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x310D400", Offset = "0x310C800", VA = "0x18310D400")]
		private void JHCGFCODJBC(int GODLNPABGMH, int EICPOANFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x310D880", Offset = "0x310CC80", VA = "0x18310D880")]
		private void NJLLPDINJFK(int GODLNPABGMH, int EICPOANFBCD, bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x310CBB0", Offset = "0x310BFB0", VA = "0x18310CBB0")]
		private int DHCIAGOLJPH(PGBOFPGBDBH LEHOMGAJBKN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x310CE70", Offset = "0x310C270", VA = "0x18310CE70")]
		private bool JFGPOJAFIDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x310D540", Offset = "0x310C940", VA = "0x18310D540")]
		private Dictionary<ComponentSystemBase, int> JOPGNALCFCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x310CC60", Offset = "0x310C060", VA = "0x18310CC60")]
		private void EBACANHNCJP(NativeArray<int> NJFCJFKAOFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x310CD60", Offset = "0x310C160", VA = "0x18310CD60")]
		private void GCNGLHGHKAO(NativeArray<int> CAHDBKNLLCN, NativeArray<int> NJFCJFKAOFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x310CE10", Offset = "0x310C210", VA = "0x18310CE10")]
		private static PGBOFPGBDBH HHBAIIGOAFP(Type HAOFNDAEGFJ, PGBOFPGBDBH PNIJKHBHNEL)
		{
			return default(PGBOFPGBDBH);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x310DB60", Offset = "0x310CF60", VA = "0x18310DB60")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x310D950", Offset = "0x310CD50", VA = "0x18310D950")]
		[CompilerGenerated]
		private void OBIKDKPJMAL(MIBCENMOHFA NHELGCBBJNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x310CD00", Offset = "0x310C100", VA = "0x18310CD00")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CE0370", Offset = "0x2CDF770", VA = "0x182CE0370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool JPHFAJGBAAB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2CDFC40", Offset = "0x2CDF040", VA = "0x182CDFC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool LKCDCDILHHD
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0370", Offset = "0x2CDF770", VA = "0x182CE0370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool FFPGEGOCGBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0370", Offset = "0x2CDF770", VA = "0x182CE0370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2CE0560", Offset = "0x2CDF960", VA = "0x182CE0560", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2CE06D0", Offset = "0x2CDFAD0", VA = "0x182CE06D0", Slot = "14")]
		public void KABICKOEJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2CE0940", Offset = "0x2CDFD40", VA = "0x182CE0940", Slot = "15")]
		public void LGAJLHMGPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2CE02A0", Offset = "0x2CDF6A0", VA = "0x182CE02A0", Slot = "5")]
		public void GEKCCLOOMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2CE03E0", Offset = "0x2CDF7E0", VA = "0x182CE03E0", Slot = "6")]
		public void IHDNKPLAFED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2CE0A60", Offset = "0x2CDFE60", VA = "0x182CE0A60", Slot = "7")]
		public void OGGLGECIIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2CE0120", Offset = "0x2CDF520", VA = "0x182CE0120", Slot = "8")]
		public void FOEEKBCPEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF9F0", Offset = "0x2CDEDF0", VA = "0x182CDF9F0", Slot = "9")]
		public void AKJGGNJGIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2CDFCE0", Offset = "0x2CDF0E0", VA = "0x182CDFCE0", Slot = "10")]
		public void EMNHCFJLCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2CDFB70", Offset = "0x2CDEF70", VA = "0x182CDFB70", Slot = "11")]
		public void BBGKALGNPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "13")]
		public void JGDCKJHGEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2CE07F0", Offset = "0x2CDFBF0", VA = "0x182CE07F0", Slot = "12")]
		public void KFGLKCIAMKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public JLCGKPAGLMB JADDHOMJIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B43210", Offset = "0x2B42610", VA = "0x182B43210", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2CEEC40", Offset = "0x2CEE040", VA = "0x182CEEC40", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool KCIOFPNPCCB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x6FA8D0", Offset = "0x6F9CD0", VA = "0x1806FA8D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2CEEB30", Offset = "0x2CEDF30", VA = "0x182CEEB30", Slot = "10")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2CEEC60", Offset = "0x2CEE060", VA = "0x182CEEC60", Slot = "11")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE7F0", Offset = "0x2CEDBF0", VA = "0x182CEE7F0")]
		private void BMDGCEOIEEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE900", Offset = "0x2CEDD00", VA = "0x182CEE900", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2CEECB0", Offset = "0x2CEE0B0", VA = "0x182CEECB0", Slot = "8")]
		public ComponentSystemBase NIOCCJPAFAI(Type HAOFNDAEGFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x701040", Offset = "0x700440", VA = "0x180701040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BB050", Offset = "0x41BA450", VA = "0x1841BB050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x987E80", Offset = "0x987280", VA = "0x180987E80")]
		[DebuggerHidden]
		public KMFLOABPIKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x41BAD40", Offset = "0x41BA140", VA = "0x1841BAD40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x41BB010", Offset = "0x41BA410", VA = "0x1841BB010", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x41BAF70", Offset = "0x41BA370", VA = "0x1841BAF70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x41BAF70", Offset = "0x41BA370", VA = "0x1841BAF70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3127180", Offset = "0x3126580", VA = "0x183127180", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<MGJBDIBFMNC> EILOCIJEEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x31271E0", Offset = "0x31265E0", VA = "0x1831271E0", Slot = "8")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3127160", Offset = "0x3126560", VA = "0x183127160", Slot = "9")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3127060", Offset = "0x3126460", VA = "0x183127060", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x31276E0", Offset = "0x3126AE0", VA = "0x1831276E0", Slot = "6")]
	public bool LKKDNIJHMJA(MGJBDIBFMNC MLIELKFMALM, out JEOAIDCLOLN DEGOBDGJJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3126BA0", Offset = "0x3125FA0", VA = "0x183126BA0")]
	private void CGLAALLIAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x3127540", Offset = "0x3126940", VA = "0x183127540")]
	private void LGLKHBBBFEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3127850", Offset = "0x3126C50", VA = "0x183127850")]
	private HEDJDIFJHAC PGGKANLMGJB(string DAAADHGLPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3127180", Offset = "0x3126580", VA = "0x183127180")]
	private HEDJDIFJHAC IFKKNIBNOPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x31272D0", Offset = "0x31266D0", VA = "0x1831272D0")]
	private HEDJDIFJHAC KENNHHFBGBF(string DAAADHGLPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x31269D0", Offset = "0x3125DD0", VA = "0x1831269D0")]
	private HEDJDIFJHAC BIJLDHLICJD(string NEIBENCLOEC, string JAKCBCDLMLB, [Optional] HEDJDIFJHAC HPENJENHMMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x31270F0", Offset = "0x31264F0", VA = "0x1831270F0")]
	[IteratorStateMachine(typeof(KMFLOABPIKI))]
	private IEnumerable<(string, string)> EDIHNOODPBB(string DAAADHGLPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3126F30", Offset = "0x3126330", VA = "0x183126F30")]
	private bool CHFMCKCPEHM(MGJBDIBFMNC MLIELKFMALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3126F80", Offset = "0x3126380", VA = "0x183126F80")]
	private LILOCMPMJLJ DHBJFKGINDB(MGJBDIBFMNC MLIELKFMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3127800", Offset = "0x3126C00", VA = "0x183127800")]
	private LILOCMPMJLJ OMKBOHBIHNB(MGJBDIBFMNC MLIELKFMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3127240", Offset = "0x3126640", VA = "0x183127240")]
	private LILOCMPMJLJ KDIFMHAFCCF(MGJBDIBFMNC MLIELKFMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x37E0700", Offset = "0x37DFB00", VA = "0x1837E0700")]
	private T PCDKLBFDPBK<T>(MGJBDIBFMNC MLIELKFMALM) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3126960", Offset = "0x3125D60", VA = "0x183126960")]
	private FieldInfo BCJGLIMJFKE(MGJBDIBFMNC MLIELKFMALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x31278B0", Offset = "0x3126CB0", VA = "0x1831278B0")]
	public KOLDOIACOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3127770", Offset = "0x3126B70", VA = "0x183127770")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JEOAIDCLOLN KPEGMGBBKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<JEOAIDCLOLN> EPIAMHJOEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<MGJBDIBFMNC> DPCFLKEACDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x311A670", Offset = "0x3119A70", VA = "0x18311A670")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B56B0", Offset = "0x41B4AB0", VA = "0x1841B56B0")]
			public CJMIHABBCHJ(HistoryService GNJOCELFONM, bool BLGMOFOMDOD, uint LFMBJAIIPEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x41B5680", Offset = "0x41B4A80", VA = "0x1841B5680", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41B8DA0", Offset = "0x41B81A0", VA = "0x1841B8DA0")]
				public INMBGCEJKNM(KJLOGOAGLJE COANEGMLMGF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x41B6F80", Offset = "0x41B6380", VA = "0x1841B6F80", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41B6FB0", Offset = "0x41B63B0", VA = "0x1841B6FB0")]
				public FAOIAHJBGOM(KJLOGOAGLJE COANEGMLMGF)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x41B6F80", Offset = "0x41B6380", VA = "0x1841B6F80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BA640", Offset = "0x41B9A40", VA = "0x1841BA640")]
			public KJLOGOAGLJE(HistoryService MBIMJJEJMCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x41BA610", Offset = "0x41B9A10", VA = "0x1841BA610")]
			public bool NKCBMOOJDBH(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x41BA570", Offset = "0x41B9970", VA = "0x1841BA570")]
			public FAOIAHJBGOM CNMMAAFNDFL()
			{
				return default(FAOIAHJBGOM);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x41BA5C0", Offset = "0x41B99C0", VA = "0x1841BA5C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public BEEHNCPJMPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x41B4820", Offset = "0x41B3C20", VA = "0x1841B4820")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public DMOOMEOPNGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x41B6020", Offset = "0x41B5420", VA = "0x1841B6020")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public IMIEBIAMFFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x41B8CB0", Offset = "0x41B80B0", VA = "0x1841B8CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F6770", Offset = "0x6F5B70", VA = "0x1806F6770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool GGNGEMDMIDB
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x311C820", Offset = "0x311BC20", VA = "0x18311C820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool AMDHMLCMIBN
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x311E1A0", Offset = "0x311D5A0", VA = "0x18311E1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool LNJPOLKFNGB
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x311E240", Offset = "0x311D640", VA = "0x18311E240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int LNDBDIMKAJC
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x311E270", Offset = "0x311D670", VA = "0x18311E270")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int PBELHMPBAPE
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x311DFF0", Offset = "0x311D3F0", VA = "0x18311DFF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool IHCOBENEKCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x311D190", Offset = "0x311C590", VA = "0x18311D190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool AKBBMIGELMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x311D120", Offset = "0x311C520", VA = "0x18311D120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool FMEHOHIOCBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x91FD30", Offset = "0x91F130", VA = "0x18091FD30", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xF65DD0", Offset = "0xF651D0", VA = "0x180F65DD0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer NAPFNKPIMEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x311E010", Offset = "0x311D410", VA = "0x18311E010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action EAHEKKNPCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x311CF60", Offset = "0x311C360", VA = "0x18311CF60", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x311C3A0", Offset = "0x311B7A0", VA = "0x18311C3A0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action PPJFBBNFAEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x311D020", Offset = "0x311C420", VA = "0x18311D020")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x311E380", Offset = "0x311D780", VA = "0x18311E380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x311D2A0", Offset = "0x311C6A0", VA = "0x18311D2A0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x311CA90", Offset = "0x311BE90", VA = "0x18311CA90", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x311E0E0", Offset = "0x311D4E0", VA = "0x18311E0E0")]
		private void ODNPEIAAKKN(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x311C320", Offset = "0x311B720", VA = "0x18311C320")]
		private void ACCCPGOJEGO(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM LOAIKIOKFPK, MPOLKMCKMLM GLLAKMPHGJD, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x311CD80", Offset = "0x311C180", VA = "0x18311CD80")]
		private void GCANCHLLJPN(IJDKBBDMEBI LCCDBPIJCNE, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x311CA30", Offset = "0x311BE30", VA = "0x18311CA30", Slot = "14")]
		public IDisposable DMDHNMJLKDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x311D0C0", Offset = "0x311C4C0", VA = "0x18311D0C0", Slot = "9")]
		public IDisposable HCOCEBGMCAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x311DC80", Offset = "0x311D080", VA = "0x18311DC80", Slot = "6")]
		public UndoAction MKACKFBEKFL()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x311C620", Offset = "0x311BA20", VA = "0x18311C620", Slot = "15")]
		public RedoAction BNAODKOCPOB()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x311C440", Offset = "0x311B840", VA = "0x18311C440", Slot = "16")]
		public UndoAction BKEHEAGIMGN()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x311C6E0", Offset = "0x311BAE0", VA = "0x18311C6E0", Slot = "7")]
		public RedoAction BNAODKOCPOB(UndoAction NMAMPMADCBK)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x311C500", Offset = "0x311B900", VA = "0x18311C500", Slot = "8")]
		public UndoAction BKEHEAGIMGN(RedoAction NMAMPMADCBK)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x311C340", Offset = "0x311B740", VA = "0x18311C340")]
		public bool AGDFIKNFHPD(OGOMGDIDANE BNGGLNMHDJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x311CD30", Offset = "0x311C130", VA = "0x18311CD30", Slot = "17")]
		public void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x311E020", Offset = "0x311D420", VA = "0x18311E020")]
		public void NPGIBDEMFPM(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x311D750", Offset = "0x311CB50", VA = "0x18311D750")]
		public void LCEHEIOELIM(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, in MPOLKMCKMLM GLLAKMPHGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x311DAF0", Offset = "0x311CEF0", VA = "0x18311DAF0")]
		public void MDGFLFKOGME(IJDKBBDMEBI LCCDBPIJCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x311E310", Offset = "0x311D710", VA = "0x18311E310")]
		private void PCLMCAIONGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x311C880", Offset = "0x311BC80", VA = "0x18311C880")]
		private void CNPPNBLODBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x311C800", Offset = "0x311BC00", VA = "0x18311C800")]
		private void CDAFMEIOCMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x311D1A0", Offset = "0x311C5A0", VA = "0x18311D1A0")]
		private HAOHNOCBDIF JKLMOALPJMD()
		{
			return default(HAOHNOCBDIF);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x311D000", Offset = "0x311C400", VA = "0x18311D000")]
		private uint GKLDAECJLBL()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x311C380", Offset = "0x311B780", VA = "0x18311C380")]
		private bool BAKDHNKICLJ(out HAOHNOCBDIF FFBLFKDINEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x311E420", Offset = "0x311D820", VA = "0x18311E420")]
		private bool PHKFGNAEPHH(out HAOHNOCBDIF FFBLFKDINEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x311E440", Offset = "0x311D840", VA = "0x18311E440")]
		private RedoAction PMDKIDJFMEG(HAOHNOCBDIF FFBLFKDINEA)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x311D130", Offset = "0x311C530", VA = "0x18311D130")]
		private UndoAction JAECFBLBAML(HAOHNOCBDIF FFBLFKDINEA)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x311D830", Offset = "0x311CC30", VA = "0x18311D830")]
		private HAOHNOCBDIF LHDGGGAEMPE(HAOHNOCBDIF FFBLFKDINEA, ActionBuffer MNLJMCGEPLD, bool BLGMOFOMDOD)
		{
			return default(HAOHNOCBDIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x311DBA0", Offset = "0x311CFA0", VA = "0x18311DBA0")]
		private void MHIMJCDIPKJ(Action FFBLFKDINEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x242FDE0", Offset = "0x242F1E0", VA = "0x18242FDE0")]
		private T MHIMJCDIPKJ<T>(Func<T> GBGEJGMHGKE)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x311E350", Offset = "0x311D750", VA = "0x18311E350")]
		private CJMIHABBCHJ PGCNKHNHKEK(bool BLGMOFOMDOD, uint LFMBJAIIPEH)
		{
			return default(CJMIHABBCHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x311E580", Offset = "0x311D980", VA = "0x18311E580")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x311DD40", Offset = "0x311D140", VA = "0x18311DD40")]
		[CompilerGenerated]
		private UndoAction MOFBAJAFKMG()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x311C8C0", Offset = "0x311BCC0", VA = "0x18311C8C0")]
		[CompilerGenerated]
		private RedoAction COGAGJCBMNH()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x311DE90", Offset = "0x311D290", VA = "0x18311DE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1BD0", Offset = "0x6E0FD0", VA = "0x1806E1BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xCEBD90", Offset = "0xCEB190", VA = "0x180CEBD90")]
	public MBOMJEFALDL(NativeArray<byte> EGIDMCNFHCK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2B41DB0", Offset = "0x2B411B0", VA = "0x182B41DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1BD0", Offset = "0x6E0FD0", VA = "0x1806E1BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0xCEBD90", Offset = "0xCEB190", VA = "0x180CEBD90")]
	public CMHGAHJMLIF(NativeArray<byte> EGIDMCNFHCK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2D50100", Offset = "0x2D4F500", VA = "0x182D50100")]
	public static CMHGAHJMLIF HEFILGHKDEM(NativeArray<byte> EGIDMCNFHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2E00C30", Offset = "0x2E00030", VA = "0x182E00C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1BD0", Offset = "0x6E0FD0", VA = "0x1806E1BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xCEBD90", Offset = "0xCEB190", VA = "0x180CEBD90")]
	public BDKAFDDMKPO(NativeArray<byte> EGIDMCNFHCK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2D4BB40", Offset = "0x2D4AF40", VA = "0x182D4BB40")]
	public static BDKAFDDMKPO HEFILGHKDEM(NativeArray<byte> EGIDMCNFHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3DAE860", Offset = "0x3DADC60", VA = "0x183DAE860")]
	public void DGONKICHOIN<T>(in T KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3DAE8C0", Offset = "0x3DADCC0", VA = "0x183DAE8C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B42530", Offset = "0x2B41930", VA = "0x182B42530")]
	public static Span<byte> KEHDAOBPPPA(this NativeArray<byte> EGIDMCNFHCK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2B426C0", Offset = "0x2B41AC0", VA = "0x182B426C0")]
	public static ReadOnlySpan<byte> NPPIMJPMMMP(this NativeArray<byte> EGIDMCNFHCK)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2B425C0", Offset = "0x2B419C0", VA = "0x182B425C0")]
	public static NativeArray<byte> LOIKFCLLDJF(this NativeArray<byte> EGIDMCNFHCK, int GODLNPABGMH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2B42640", Offset = "0x2B41A40", VA = "0x182B42640")]
	public static NativeArray<byte> MEHMIAFMLCG(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x29EF2C0", Offset = "0x29EE6C0", VA = "0x1829EF2C0")]
	public static NativeArray<byte> MEHMIAFMLCG<T>(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2B42840", Offset = "0x2B41C40", VA = "0x182B42840")]
	public static NativeArray<byte> OLKHDAMDPIG(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x29EF320", Offset = "0x29EE720", VA = "0x1829EF320")]
	public static NativeArray<byte> OLKHDAMDPIG<T>(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2B428B0", Offset = "0x2B41CB0", VA = "0x182B428B0")]
	public static NativeArray<byte> PAHKEBDDEHH(this NativeArray<byte> EGIDMCNFHCK, int KJAHKKMJHHG = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x29EF380", Offset = "0x29EE780", VA = "0x1829EF380")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEBD90", Offset = "0xCEB190", VA = "0x180CEBD90")]
	public LHOCDONFHBE(NativeList<byte> EHJGMBFBLBN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F550", Offset = "0x2B3E950", VA = "0x182B3F550")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CB60", Offset = "0x2B5BF60", VA = "0x182B5CB60")]
		public ADCMMFFHADO.FCIGFKLHDBP HJDABMCHLDO()
		{
			return default(ADCMMFFHADO.FCIGFKLHDBP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CBA0", Offset = "0x2B5BFA0", VA = "0x182B5CBA0", Slot = "4")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CC00", Offset = "0x2B5C000", VA = "0x182B5CC00", Slot = "5")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C610", Offset = "0x2B5BA10", VA = "0x182B5C610", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CEC0", Offset = "0x2B5C2C0", VA = "0x182B5CEC0")]
		public void MKACKFBEKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C860", Offset = "0x2B5BC60", VA = "0x182B5C860")]
		public void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CFD0", Offset = "0x2B5C3D0", VA = "0x182B5CFD0")]
		private void MKHMFDOLINH(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CE80", Offset = "0x2B5C280", VA = "0x182B5CE80")]
		private void LIKAMDDGELI(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM LOAIKIOKFPK, MPOLKMCKMLM GLLAKMPHGJD, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C830", Offset = "0x2B5BC30", VA = "0x182B5C830")]
		private void EPMHDFKPLEJ(IJDKBBDMEBI LCCDBPIJCNE, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C880", Offset = "0x2B5BC80", VA = "0x182B5C880")]
		private void GNKEMEEABAB(GJNEDJALMDE EHNCKNECPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D000", Offset = "0x2B5C400", VA = "0x182B5D000")]
		private void OIJINCLADKN(GJNEDJALMDE EHNCKNECPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C550", Offset = "0x2B5B950", VA = "0x182B5C550")]
		private void DOAMIHPOINF(GJNEDJALMDE EHNCKNECPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2B5CB80", Offset = "0x2B5BF80", VA = "0x182B5CB80")]
		private void ICIPFBNLMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C530", Offset = "0x2B5B930", VA = "0x182B5C530")]
		private void DEDKIMIMABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D130", Offset = "0x2B5C530", VA = "0x182B5D130")]
		private void POCKKLGKKFG(GJNEDJALMDE EHNCKNECPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3F65510", Offset = "0x3F64910", VA = "0x183F65510", Slot = "6")]
		private void ECALMKPNLAI<TKey, T>(global::PKAHIOONALH<TKey, T> MLIELKFMALM, object MFEOJPNCOBA) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5D2B0", Offset = "0x2B5C6B0", VA = "0x182B5D2B0")]
		public void NPGIBDEMFPM(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D220", Offset = "0x2B5C620", VA = "0x182B5D220")]
		public void LCEHEIOELIM(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, in MPOLKMCKMLM LOAIKIOKFPK, in MPOLKMCKMLM GLLAKMPHGJD, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D290", Offset = "0x2B5C690", VA = "0x182B5D290")]
		public void MDGFLFKOGME(IJDKBBDMEBI LCCDBPIJCNE, bool HJCOFHMAOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x2CD1C00", Offset = "0x2CD1000", VA = "0x182CD1C00")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public NMAGLEIDGHF[] HJOLNCNNDFA
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x2CD1C50", Offset = "0x2CD1050", VA = "0x182CD1C50")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
			public AEIKLODAOFE(ActionBuffer KAIDENHIDAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2CD1B10", Offset = "0x2CD0F10", VA = "0x182CD1B10")]
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
				[Cpp2IlInjected.Address(RVA = "0x2CD5910", Offset = "0x2CD4D10", VA = "0x182CD5910")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(GJNEDJALMDE, string, object)> NDLOCDALLEL
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2CD5960", Offset = "0x2CD4D60", VA = "0x182CD5960")]
			public NMAGLEIDGHF(ActionBuffer KAIDENHIDAD, HAOHNOCBDIF FFBLFKDINEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2CD5810", Offset = "0x2CD4C10", VA = "0x182CD5810")]
			private string MNOMENMHBNK(GJNEDJALMDE EMGGINCCEHB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2CD54D0", Offset = "0x2CD48D0", VA = "0x182CD54D0")]
			private void MGAGAAKAIAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x29F0CA0", Offset = "0x29F00A0", VA = "0x1829F0CA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D48CB0", Offset = "0x2D480B0", VA = "0x182D48CB0")]
			get
			{
				return default(ECAJINLFENJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int IIEJMBAKGHF
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x2D49070", Offset = "0x2D48470", VA = "0x182D49070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D49100", Offset = "0x2D48500", VA = "0x182D49100")]
		public ActionBuffer(ODHBDONHIOF OKGDPALNOAA, KNGDFJPFKAH ICBILMELIDM, bool GJELBFGDNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D48EA0", Offset = "0x2D482A0", VA = "0x182D48EA0")]
		public bool MHKBLPPBOOD(out HAOHNOCBDIF FFBLFKDINEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D48AD0", Offset = "0x2D47ED0", VA = "0x182D48AD0")]
		public void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D48F30", Offset = "0x2D48330", VA = "0x182D48F30")]
		public HAOHNOCBDIF MKACKFBEKFL(EIMPGEHINCC GLKGCBOKLJL, EAIOBOKBFDP JKCCIJPHOBG, uint HNCBIABFJPH)
		{
			return default(HAOHNOCBDIF);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D485D0", Offset = "0x2D479D0", VA = "0x182D485D0")]
		public bool ADOGLCANOKE(uint HNCBIABFJPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D483E0", Offset = "0x2D477E0", VA = "0x182D483E0")]
		public bool AACLAIDNHNK(uint HNCBIABFJPH, out HAOHNOCBDIF NMAMPMADCBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D48B40", Offset = "0x2D47F40", VA = "0x182D48B40")]
		public void HHEFMAHOKLG(HAOHNOCBDIF NMAMPMADCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D48990", Offset = "0x2D47D90", VA = "0x182D48990")]
		[Conditional("DEBUG_BUILD")]
		private void EELGGEHAFMK(HAOHNOCBDIF NMAMPMADCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D48CF0", Offset = "0x2D480F0", VA = "0x182D48CF0")]
		private void LHDGGGAEMPE(HAOHNOCBDIF NHOLBOBHHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D48600", Offset = "0x2D47A00", VA = "0x182D48600")]
		private void AODFDAGAHFI(CMHGAHJMLIF DEAFIOFDCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D48E40", Offset = "0x2D48240", VA = "0x182D48E40")]
		private void MAOMFFHKMOI(HAOHNOCBDIF FFBLFKDINEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D48840", Offset = "0x2D47C40", VA = "0x182D48840")]
		private CMHGAHJMLIF CACNNAPEAJJ(HAOHNOCBDIF FFBLFKDINEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D48920", Offset = "0x2D47D20", VA = "0x182D48920", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E06E0", Offset = "0x6DFAE0", VA = "0x1806E06E0")]
	public ICLOMBCOJEF(ODHBDONHIOF OKGDPALNOAA, KNGDFJPFKAH ICBILMELIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2432A00", Offset = "0x2431E00", VA = "0x182432A00", Slot = "4")]
	public void EFBHNODPNDJ<TKey, T>(global::PKAHIOONALH<TKey, T> JKKOPMICBJA, [Optional] object MFEOJPNCOBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x311E600", Offset = "0x311DA00", VA = "0x18311E600")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD2260", Offset = "0x2CD1660", VA = "0x182CD2260")]
		public FCIGFKLHDBP(ADCMMFFHADO OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2240", Offset = "0x2CD1640", VA = "0x182CD2240", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D44810", Offset = "0x2D43C10", VA = "0x182D44810")]
		get
		{
			return default(EIMPGEHINCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool OHGLIFCLEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D44BF0", Offset = "0x2D43FF0", VA = "0x182D44BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2D44C00", Offset = "0x2D44000", VA = "0x182D44C00")]
	public ADCMMFFHADO(EIMPGEHINCC.BEMKIHCEIOB CIMKFPCFBNF = EIMPGEHINCC.BEMKIHCEIOB.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2D44850", Offset = "0x2D43C50", VA = "0x182D44850")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D44B00", Offset = "0x2D43F00", VA = "0x182D44B00")]
	public void NPGIBDEMFPM(IJDKBBDMEBI LCCDBPIJCNE, ADIOIKPLFDJ IHJHNOGDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2D44990", Offset = "0x2D43D90", VA = "0x182D44990")]
	public void LCEHEIOELIM(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2D44A20", Offset = "0x2D43E20", VA = "0x182D44A20")]
	public void MDGFLFKOGME(IJDKBBDMEBI LCCDBPIJCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2D44890", Offset = "0x2D43C90", VA = "0x182D44890")]
	public void ICIPFBNLMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2D44700", Offset = "0x2D43B00", VA = "0x182D44700")]
	public void DEDKIMIMABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2D44800", Offset = "0x2D43C00", VA = "0x182D44800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2D44860", Offset = "0x2D43C60", VA = "0x182D44860")]
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
		[Cpp2IlInjected.Address(RVA = "0x3119EA0", Offset = "0x31192A0", VA = "0x183119EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x701050", Offset = "0x700450", VA = "0x180701050")]
	public GJNEDJALMDE(IJDKBBDMEBI LCCDBPIJCNE, BPHAMHGLCNC AOKMGDODDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3119E40", Offset = "0x3119240", VA = "0x183119E40")]
	public void LIPJNEJALJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x3119C90", Offset = "0x3119090", VA = "0x183119C90", Slot = "4")]
	public int CompareTo(GJNEDJALMDE JHMCLPBFJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x3119EB0", Offset = "0x31192B0", VA = "0x183119EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3119D20", Offset = "0x3119120", VA = "0x183119D20", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3119CD0", Offset = "0x31190D0", VA = "0x183119CD0", Slot = "5")]
	public bool Equals(GJNEDJALMDE JHMCLPBFJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x3119E00", Offset = "0x3119200", VA = "0x183119E00")]
	public static bool IIPILNNMHKL(GJNEDJALMDE AJDPMFOKMPC, GJNEDJALMDE DAAPHBHBHCO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3119E50", Offset = "0x3119250", VA = "0x183119E50")]
	public static bool NCOOAABHIPD(GJNEDJALMDE AJDPMFOKMPC, GJNEDJALMDE DAAPHBHBHCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3119DC0", Offset = "0x31191C0", VA = "0x183119DC0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x311A490", Offset = "0x3119890", VA = "0x18311A490")]
		public void DBJECMLBLNK(IJDKBBDMEBI LCCDBPIJCNE, ODHBDONHIOF OKGDPALNOAA, HistoryService MBIMJJEJMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x311A3C0", Offset = "0x31197C0", VA = "0x18311A3C0", Slot = "4")]
		private void CLHPNLMKHIP(OHACNMOLGIH MLIELKFMALM, in MPOLKMCKMLM KPPLMEOMNGF, object MFEOJPNCOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class GDCBANIHENN
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x31182C0", Offset = "0x31176C0", VA = "0x1831182C0")]
	public static void OIJINCLADKN(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB, ADIOIKPLFDJ IHJHNOGDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x3118060", Offset = "0x3117460", VA = "0x183118060")]
	public static void CHDFDHALOJD(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3118120", Offset = "0x3117520", VA = "0x183118120")]
	public static void DOAMIHPOINF(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3118170", Offset = "0x3117570", VA = "0x183118170")]
	public static void FEDJBBEEOMK(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3118220", Offset = "0x3117620", VA = "0x183118220")]
	public static ADIOIKPLFDJ KAJODJILOGD(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB)
	{
		return default(ADIOIKPLFDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x238C750", Offset = "0x238BB50", VA = "0x18238C750")]
	public static T ICNGPLOGIFB<T>(EIMPGEHINCC GLKGCBOKLJL, GJNEDJALMDE EMGGINCCEHB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x238C710", Offset = "0x238BB10", VA = "0x18238C710")]
	public static T ICNGPLOGIFB<T>(ref CMHGAHJMLIF FNIHENPLJHK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x3118270", Offset = "0x3117670", VA = "0x183118270")]
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
		[Cpp2IlInjected.Address(RVA = "0x41B47E0", Offset = "0x41B3BE0", VA = "0x1841B47E0")]
		public BCBGPFPJACO(EIMPGEHINCC EHJGMBFBLBN, EAIOBOKBFDP JKCCIJPHOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x41B43E0", Offset = "0x41B37E0", VA = "0x1841B43E0")]
		public void OPJGGHDHMGP(NativeList<byte> BBKJOBCNEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x41B4140", Offset = "0x41B3540", VA = "0x1841B4140")]
		private void GEPEPIMHLGH(GJNEDJALMDE EMGGINCCEHB, ref BDKAFDDMKPO OIMCEIHNOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x41B3ED0", Offset = "0x41B32D0", VA = "0x1841B3ED0")]
		private void DHEJHCOJENK(GJNEDJALMDE EMGGINCCEHB, ref BDKAFDDMKPO OIMCEIHNOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x41B3F60", Offset = "0x41B3360", VA = "0x1841B3F60")]
		private NativeArray<byte> EJPFMCJBPLI(NativeList<byte> BBKJOBCNEOF)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x41B4050", Offset = "0x41B3450", VA = "0x1841B4050")]
		private NativeArray<byte> FEEMNAJBONB(NativeList<byte> BBKJOBCNEOF, int GDDNEEFIBDF)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x41B4190", Offset = "0x41B3590", VA = "0x1841B4190")]
		private int GKMBDBJKADB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x41B4680", Offset = "0x41B3A80", VA = "0x1841B4680")]
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
		[Cpp2IlInjected.Address(RVA = "0x41B2BD0", Offset = "0x41B1FD0", VA = "0x1841B2BD0")]
		internal ACHPMAOFGNK(EIMPGEHINCC EHJGMBFBLBN, GJNEDJALMDE EHNCKNECPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x41B2960", Offset = "0x41B1D60", VA = "0x1841B2960", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x41B2990", Offset = "0x41B1D90", VA = "0x1841B2990")]
		public void FMIJJIPPKFC(NativeArray<byte> KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x41B29F0", Offset = "0x41B1DF0", VA = "0x1841B29F0")]
		public void JAPGIHIMBEL(NativeArray<byte> KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x41B2950", Offset = "0x41B1D50", VA = "0x1841B2950")]
		public void DHEJHCOJENK(in MPOLKMCKMLM KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E760", Offset = "0x2A6DB60", VA = "0x182A6E760")]
		public void DHEJHCOJENK<T>(T KPPLMEOMNGF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x41B2AB0", Offset = "0x41B1EB0", VA = "0x1841B2AB0")]
		private void KEGBOBEHJBC(int KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x41B2B20", Offset = "0x41B1F20", VA = "0x1841B2B20")]
		private void KEGBOBEHJBC(in MPOLKMCKMLM KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x41B2A50", Offset = "0x41B1E50", VA = "0x1841B2A50")]
		private unsafe void KEGBOBEHJBC(void* BIDBAIHFLFD, int GDDNEEFIBDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x41B2990", Offset = "0x41B1D90", VA = "0x1841B2990")]
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
		[Cpp2IlInjected.Address(RVA = "0x41B6F40", Offset = "0x41B6340", VA = "0x1841B6F40")]
		internal FAAFIHDHLAN(EIMPGEHINCC EHJGMBFBLBN, NativeArray<byte> FNIHENPLJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x41B6C80", Offset = "0x41B6080", VA = "0x1841B6C80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x41B6E80", Offset = "0x41B6280", VA = "0x1841B6E80")]
		public NativeArray<byte> MLEADCLLMII(int GDDNEEFIBDF)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x41B6C90", Offset = "0x41B6090", VA = "0x1841B6C90")]
		public NativeArray<byte> KOGOOLHIMII()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2A70780", Offset = "0x2A6FB80", VA = "0x182A70780")]
		public T LAPMNFNPPEF<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x41B6D80", Offset = "0x41B6180", VA = "0x1841B6D80")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BCCB0", Offset = "0x41BC0B0", VA = "0x1841BCCB0", Slot = "4")]
			get
			{
				return default(GJNEDJALMDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x41BCC70", Offset = "0x41BC070", VA = "0x1841BCC70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x31C63D0", Offset = "0x31C57D0", VA = "0x1831C63D0")]
		internal NHPNHPOMKAN(NativeList<GJNEDJALMDE> GLOMCJNAEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x41BCB30", Offset = "0x41BBF30", VA = "0x1841BCB30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x41BCC30", Offset = "0x41BC030", VA = "0x1841BCC30", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BABD0", Offset = "0x41B9FD0", VA = "0x1841BABD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int IBBOMNPJGPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x41BAB80", Offset = "0x41B9F80", VA = "0x1841BAB80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x41BAB50", Offset = "0x41B9F50", VA = "0x1841BAB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public BEMKIHCEIOB IOLLCPFPNED
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x41BAB60", Offset = "0x41B9F60", VA = "0x1841BAB60")]
			get
			{
				return default(BEMKIHCEIOB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x41BAB70", Offset = "0x41B9F70", VA = "0x1841BAB70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool OHGLIFCLEFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x41BAC30", Offset = "0x41BA030", VA = "0x1841BAC30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x41BAC10", Offset = "0x41BA010", VA = "0x1841BAC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool KFOHGDOOFBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x41BAC40", Offset = "0x41BA040", VA = "0x1841BAC40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x41BAAF0", Offset = "0x41B9EF0", VA = "0x1841BAAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x41BAC50", Offset = "0x41BA050", VA = "0x1841BAC50")]
		public KLGNLMLHPEF(BEMKIHCEIOB CIMKFPCFBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x41BAAC0", Offset = "0x41B9EC0", VA = "0x1841BAAC0")]
		private int BOEAFIEBIHC(int LKCJJEBACFP, int HEFBLHDCOBM = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x41BAB90", Offset = "0x41B9F90", VA = "0x1841BAB90")]
		private void JPNFGACMGOG(int LKCJJEBACFP, int KPPLMEOMNGF, int HEFBLHDCOBM = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x41BAB10", Offset = "0x41B9F10", VA = "0x1841BAB10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D62020", Offset = "0x2D61420", VA = "0x182D62020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool PMNEPBJNENC
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D61EF0", Offset = "0x2D612F0", VA = "0x182D61EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int IBBOMNPJGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D61D20", Offset = "0x2D61120", VA = "0x182D61D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int DEELBMINOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D61570", Offset = "0x2D60970", VA = "0x182D61570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D61FE0", Offset = "0x2D613E0", VA = "0x182D61FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2D61530", Offset = "0x2D60930", VA = "0x182D61530")]
	public static EIMPGEHINCC BMDGCEOIEEG(BEMKIHCEIOB CIMKFPCFBNF = BEMKIHCEIOB.Last, int MPDIEGJOOBA = 16, int JONLFIPEDCN = 256)
	{
		return default(EIMPGEHINCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2D62130", Offset = "0x2D61530", VA = "0x182D62130")]
	private EIMPGEHINCC(BEMKIHCEIOB CIMKFPCFBNF, int MPDIEGJOOBA, int JONLFIPEDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D616A0", Offset = "0x2D60AA0", VA = "0x182D616A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D61860", Offset = "0x2D60C60", VA = "0x182D61860")]
	public ACHPMAOFGNK GNKEMEEABAB(GJNEDJALMDE EHNCKNECPAL)
	{
		return default(ACHPMAOFGNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D61E60", Offset = "0x2D61260", VA = "0x182D61E60")]
	public FAAFIHDHLAN LMPCHNBHKDC(GJNEDJALMDE EHNCKNECPAL)
	{
		return default(FAAFIHDHLAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D61B30", Offset = "0x2D60F30", VA = "0x182D61B30")]
	public bool JIBEPPJMFCH(GJNEDJALMDE EHNCKNECPAL, out FAAFIHDHLAN AKMHDEFEKOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D61AE0", Offset = "0x2D60EE0", VA = "0x182D61AE0")]
	public bool IPHPDBNLADP(GJNEDJALMDE EHNCKNECPAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D61F10", Offset = "0x2D61310", VA = "0x182D61F10")]
	public bool NBALFPMAHGJ(GJNEDJALMDE EHNCKNECPAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2D615B0", Offset = "0x2D609B0", VA = "0x182D615B0")]
	public void CPJGLJCDGOO(NativeList<byte> BBKJOBCNEOF, EAIOBOKBFDP JKCCIJPHOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x2306AB0", Offset = "0x2305EB0", VA = "0x182306AB0")]
	public T IPFANDCPJOE<T>(GJNEDJALMDE EHNCKNECPAL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D61780", Offset = "0x2D60B80", VA = "0x182D61780")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2D61D30", Offset = "0x2D61130", VA = "0x182D61D30")]
	public NHPNHPOMKAN KGLEFCHHJJI()
	{
		return default(NHPNHPOMKAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2D618F0", Offset = "0x2D60CF0", VA = "0x182D618F0")]
	private void HGIFOPINIAH(GJNEDJALMDE EHNCKNECPAL, int GODLNPABGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2D61D70", Offset = "0x2D61170", VA = "0x182D61D70")]
	private void LIPJNEJALJE(int JMOLLNMGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2D61440", Offset = "0x2D60840", VA = "0x182D61440")]
	private void ACMIFKHCHID(GJNEDJALMDE EHNCKNECPAL, int GODLNPABGMH, int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2306C40", Offset = "0x2306040", VA = "0x182306C40")]
	private static T IPFANDCPJOE<T>(NativeArray<byte> EGIDMCNFHCK, int LKCJJEBACFP = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2D62070", Offset = "0x2D61470", VA = "0x182D62070", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2D62030", Offset = "0x2D61430", VA = "0x182D62030", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x38A3F10", Offset = "0x38A3310", VA = "0x1838A3F10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x38A4030", Offset = "0x38A3430", VA = "0x1838A4030", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2550", Offset = "0x2FB1950", VA = "0x182FB2550")]
	public ANHDKBGNFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x14FF8B0", Offset = "0x14FECB0", VA = "0x1814FF8B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D525E0", Offset = "0x2D519E0", VA = "0x182D525E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2D52680", Offset = "0x2D51A80", VA = "0x182D52680", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D44570", Offset = "0x2D43970", VA = "0x182D44570", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2D445C0", Offset = "0x2D439C0", VA = "0x182D445C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2D44650", Offset = "0x2D43A50", VA = "0x182D44650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public ACICEEJKODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3120220", Offset = "0x311F620", VA = "0x183120220", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x3120270", Offset = "0x311F670", VA = "0x183120270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public IOAJNJPOEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D5FDA0", Offset = "0x2D5F1A0", VA = "0x182D5FDA0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FDF0", Offset = "0x2D5F1F0", VA = "0x182D5FDF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FE80", Offset = "0x2D5F280", VA = "0x182D5FE80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D5B790", Offset = "0x2D5AB90", VA = "0x182D5B790", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B720", Offset = "0x2D5AB20", VA = "0x182D5B720")]
		public void IHGGPOIHOJD(NativeListAsync<ODILOCJODCG> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B7E0", Offset = "0x2D5ABE0", VA = "0x182D5B7E0")]
		public void OFICLPBCEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B5B0", Offset = "0x2D5A9B0", VA = "0x182D5B5B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2D5BCA0", Offset = "0x2D5B0A0", VA = "0x182D5BCA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B59F60", Offset = "0x2B59360", VA = "0x182B59F60", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x2B59E00", Offset = "0x2B59200", VA = "0x182B59E00", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2B59CE0", Offset = "0x2B590E0", VA = "0x182B59CE0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2B59B70", Offset = "0x2B58F70", VA = "0x182B59B70", Slot = "5")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2B59950", Offset = "0x2B58D50", VA = "0x182B59950", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2B59AA0", Offset = "0x2B58EA0", VA = "0x182B59AA0", Slot = "8")]
		public bool ELPDMAKIGPE(GPEJGMHBDPO GBPGPLEPLBP, out Collider MMNMMMMCHOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2B59EA0", Offset = "0x2B592A0", VA = "0x182B59EA0")]
		private void NNCNEPPIONG(Entity PJEENOLDJIO, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM ENFEPLFMJNK, MPOLKMCKMLM IEFBANIHOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2B599E0", Offset = "0x2B58DE0", VA = "0x182B599E0", Slot = "9")]
		public void EGMKKCJGINM(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B61080", Offset = "0x2B60480", VA = "0x182B61080")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2B613A0", Offset = "0x2B607A0", VA = "0x182B613A0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2B60B20", Offset = "0x2B5FF20", VA = "0x182B60B20", Slot = "6")]
		public KLALODLBPPC HDJGOBKHOHI(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2B61F10", Offset = "0x2B61310", VA = "0x182B61F10", Slot = "5")]
		public void MGJHNOCJPAI(GPEJGMHBDPO GBPGPLEPLBP, KLALODLBPPC KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FF40", Offset = "0x2B5F340", VA = "0x182B5FF40", Slot = "34")]
		public CollisionDetectionMode DBCLLGDDCGL(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F720", Offset = "0x2B5EB20", VA = "0x182B5F720", Slot = "35")]
		public void BGKEEAMIHGM(GPEJGMHBDPO GBPGPLEPLBP, CollisionDetectionMode KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2B60720", Offset = "0x2B5FB20", VA = "0x182B60720", Slot = "36")]
		public CLIIJKDLFPK GEAIKJCLOGP(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(CLIIJKDLFPK);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F290", Offset = "0x2B5E690", VA = "0x182B5F290", Slot = "37")]
		public void ADGMABPELNK(GPEJGMHBDPO GBPGPLEPLBP, CLIIJKDLFPK KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2B61B90", Offset = "0x2B60F90", VA = "0x182B61B90", Slot = "38")]
		public bool LDLGFHNEPCH(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2B60640", Offset = "0x2B5FA40", VA = "0x182B60640", Slot = "39")]
		public void FOOEIAEOEKK(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2B62550", Offset = "0x2B61950", VA = "0x182B62550", Slot = "40")]
		public GPEJGMHBDPO PLFCFKIEBOC(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FD80", Offset = "0x2B5F180", VA = "0x182B5FD80", Slot = "41")]
		public void CEJMMPCINJH(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2B603B0", Offset = "0x2B5F7B0", VA = "0x182B603B0", Slot = "42")]
		public GPEJGMHBDPO FCHNDLGHOIE(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2B612C0", Offset = "0x2B606C0", VA = "0x182B612C0", Slot = "43")]
		public void JDHACNMMLIE(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2B608F0", Offset = "0x2B5FCF0", VA = "0x182B608F0", Slot = "7")]
		public void GFLPJLNLLDG(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2B61A80", Offset = "0x2B60E80", VA = "0x182B61A80", Slot = "8")]
		public void LDFJFKBFDMD(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2B61990", Offset = "0x2B60D90", VA = "0x182B61990", Slot = "9")]
		public int KIPGBJMICGF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2B60220", Offset = "0x2B5F620", VA = "0x182B60220", Slot = "10")]
		public GPEJGMHBDPO ELIAHCIMIEO(GPEJGMHBDPO GBPGPLEPLBP, int EGBCAPEEJBF)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2B615E0", Offset = "0x2B609E0", VA = "0x182B615E0", Slot = "11")]
		public void KEBPCPNFNOA(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2B607C0", Offset = "0x2B5FBC0", VA = "0x182B607C0", Slot = "12")]
		public void GFKEMMLPMKC(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB, GPEJGMHBDPO KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2B620D0", Offset = "0x2B614D0", VA = "0x182B620D0", Slot = "13")]
		public void NAIJGGADILP(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2B60D10", Offset = "0x2B60110", VA = "0x182B60D10", Slot = "14")]
		public bool IBIMJNBNPAM(GPEJGMHBDPO GBPGPLEPLBP, out GPEJGMHBDPO KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2B61910", Offset = "0x2B60D10", VA = "0x182B61910", Slot = "15")]
		public void KIFINBFGOBH(GPEJGMHBDPO GBPGPLEPLBP, float3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FB90", Offset = "0x2B5EF90", VA = "0x182B5FB90", Slot = "16")]
		public bool BODINHBKBCO(GPEJGMHBDPO GBPGPLEPLBP, out float3 KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2B60550", Offset = "0x2B5F950", VA = "0x182B60550", Slot = "17")]
		public void FJHKIOFBFIG(GPEJGMHBDPO GBPGPLEPLBP, float3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F790", Offset = "0x2B5EB90", VA = "0x182B5F790", Slot = "18")]
		public bool BHGNDGMNKEH(GPEJGMHBDPO GBPGPLEPLBP, out float3 KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2B60C10", Offset = "0x2B60010", VA = "0x182B60C10", Slot = "26")]
		public float3 HELAJODAOIB(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2B60C90", Offset = "0x2B60090", VA = "0x182B60C90", Slot = "27")]
		public void HNNBIOJHDFN(GPEJGMHBDPO GBPGPLEPLBP, float3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2B62460", Offset = "0x2B61860", VA = "0x182B62460", Slot = "28")]
		public float PEJCKENHMFC(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2B62250", Offset = "0x2B61650", VA = "0x182B62250", Slot = "29")]
		public void OHAEJELHKHK(GPEJGMHBDPO GBPGPLEPLBP, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2B60F00", Offset = "0x2B60300", VA = "0x182B60F00", Slot = "30")]
		public float IGKPCBJHCAP(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2B623F0", Offset = "0x2B617F0", VA = "0x182B623F0", Slot = "31")]
		public void PCLAMECJFPB(GPEJGMHBDPO GBPGPLEPLBP, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2B622C0", Offset = "0x2B616C0", VA = "0x182B622C0", Slot = "32")]
		public bool OIEFKDDNJOK(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2B61180", Offset = "0x2B60580", VA = "0x182B61180", Slot = "33")]
		public void IOPJGMHMNEP(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F3C0", Offset = "0x2B5E7C0", VA = "0x182B5F3C0", Slot = "19")]
		public void AJFINOGDGGA(GPEJGMHBDPO GBPGPLEPLBP, float3 KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F8F0", Offset = "0x2B5ECF0", VA = "0x182B5F8F0", Slot = "20")]
		public bool BHHCKKBPFDB(GPEJGMHBDPO GBPGPLEPLBP, out float3 KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2B605D0", Offset = "0x2B5F9D0", VA = "0x182B605D0", Slot = "21")]
		public void FOCPOBBHBIN(GPEJGMHBDPO GBPGPLEPLBP, quaternion KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2B61DB0", Offset = "0x2B611B0", VA = "0x182B61DB0", Slot = "22")]
		public bool MBDCDFKIFAL(GPEJGMHBDPO GBPGPLEPLBP, out quaternion KPPLMEOMNGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F440", Offset = "0x2B5E840", VA = "0x182B5F440", Slot = "23")]
		public bool APGPCNDDAAC(GPEJGMHBDPO GBPGPLEPLBP, out float3 HEEAFJJDDDN, out quaternion HNDEAFEIHNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2B62390", Offset = "0x2B61790", VA = "0x182B62390", Slot = "44")]
		public CACECFKIIAN PBHLDOLFJFK(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(CACECFKIIAN);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2B60340", Offset = "0x2B5F740", VA = "0x182B60340", Slot = "45")]
		public void EPMPDPGCKBN(GPEJGMHBDPO GBPGPLEPLBP, CACECFKIIAN KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F330", Offset = "0x2B5E730", VA = "0x182B5F330", Slot = "72")]
		public void ADPCEDEIBAN(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2B624C0", Offset = "0x2B618C0", VA = "0x182B624C0", Slot = "73")]
		public void PJMHPOOCMGC(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FEC0", Offset = "0x2B5F2C0", VA = "0x182B5FEC0", Slot = "74")]
		public bool CMBFFGPGFGA(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FFA0", Offset = "0x2B5F3A0", VA = "0x182B5FFA0", Slot = "81")]
		public void DKHHOAIECEJ(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2B61550", Offset = "0x2B60950", VA = "0x182B61550", Slot = "82")]
		public void KDIPPBLKDPA(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2B62160", Offset = "0x2B61560", VA = "0x182B62160", Slot = "83")]
		public bool NEOJDDFALBE(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2B600C0", Offset = "0x2B5F4C0", VA = "0x182B600C0", Slot = "84")]
		public IEnumerable<object> DLCLEHONLLJ(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2B61340", Offset = "0x2B60740", VA = "0x182B61340", Slot = "46")]
		public bool JEADMAHLCBM(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2B618B0", Offset = "0x2B60CB0", VA = "0x182B618B0", Slot = "47")]
		public void KGNFPJNJGIF(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2B60A60", Offset = "0x2B5FE60", VA = "0x182B60A60", Slot = "48")]
		public bool GPKPIMDMNCB(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2B61450", Offset = "0x2B60850", VA = "0x182B61450", Slot = "49")]
		public void JPEIOCMBKHL(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2B604F0", Offset = "0x2B5F8F0", VA = "0x182B604F0", Slot = "50")]
		public bool FGNIDPMGLCC(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2B606B0", Offset = "0x2B5FAB0", VA = "0x182B606B0", Slot = "51")]
		public void FPJCLJEKIMI(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2B61D50", Offset = "0x2B61150", VA = "0x182B61D50", Slot = "52")]
		public RigidbodyConstraints LOBIBEONOFE(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F6B0", Offset = "0x2B5EAB0", VA = "0x182B5F6B0", Slot = "53")]
		public void BBGMNJCNHOM(GPEJGMHBDPO GBPGPLEPLBP, RigidbodyConstraints KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2B60BB0", Offset = "0x2B5FFB0", VA = "0x182B60BB0", Slot = "54")]
		public float HEKNDLKLNGB(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2B621E0", Offset = "0x2B615E0", VA = "0x182B621E0", Slot = "55")]
		public void OECEHKGENPJ(GPEJGMHBDPO GBPGPLEPLBP, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2B60A00", Offset = "0x2B5FE00", VA = "0x182B60A00", Slot = "56")]
		public float GKHNAPBHBOA(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FA50", Offset = "0x2B5EE50", VA = "0x182B5FA50", Slot = "57")]
		public void BHLAGEHDKAO(GPEJGMHBDPO GBPGPLEPLBP, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2B60AC0", Offset = "0x2B5FEC0", VA = "0x182B60AC0", Slot = "58")]
		public bool HCACJPAEEKE(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2B61FC0", Offset = "0x2B613C0", VA = "0x182B61FC0", Slot = "59")]
		public void MHJHELHLJLI(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FE60", Offset = "0x2B5F260", VA = "0x182B5FE60", Slot = "60")]
		public bool CGDCEMJAEGO(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2B62320", Offset = "0x2B61720", VA = "0x182B62320", Slot = "61")]
		public void PAFABGIFGOF(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FE00", Offset = "0x2B5F200", VA = "0x182B5FE00", Slot = "62")]
		public int CFGBCGALNND(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2B62030", Offset = "0x2B61430", VA = "0x182B62030", Slot = "63")]
		public void MKPPILDMAIM(GPEJGMHBDPO GBPGPLEPLBP, int KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FCF0", Offset = "0x2B5F0F0", VA = "0x182B5FCF0", Slot = "64")]
		public Rigidbody BPICHLHNMGF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2B61BF0", Offset = "0x2B60FF0", VA = "0x182B61BF0", Slot = "65")]
		public void LMBCLHNJMDN(GPEJGMHBDPO GBPGPLEPLBP, Rigidbody KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2B60F60", Offset = "0x2B60360", VA = "0x182B60F60", Slot = "75")]
		public void IHDBPPFEHMM(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2B60FF0", Offset = "0x2B603F0", VA = "0x182B60FF0", Slot = "76")]
		public void IJGOFLCDNLM(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2B610A0", Offset = "0x2B604A0", VA = "0x182B610A0", Slot = "77")]
		public bool ILAGIPAEENF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2B60460", Offset = "0x2B5F860", VA = "0x182B60460", Slot = "66")]
		public object FFDFJBDFOEC(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2B616D0", Offset = "0x2B60AD0", VA = "0x182B616D0", Slot = "67")]
		public void KFOPGECHEIG(GPEJGMHBDPO GBPGPLEPLBP, object KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B60E70", Offset = "0x2B60270", VA = "0x182B60E70", Slot = "68")]
		public object ICHHOINEMPN(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F130", Offset = "0x2B5E530", VA = "0x182B5F130", Slot = "69")]
		public void AALDAPDLJAO(GPEJGMHBDPO GBPGPLEPLBP, object KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B601C0", Offset = "0x2B5F5C0", VA = "0x182B601C0", Slot = "70")]
		public float EJEKBMDLIBA(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B611F0", Offset = "0x2B605F0", VA = "0x182B611F0", Slot = "71")]
		public void JCFEOFGMADC(GPEJGMHBDPO GBPGPLEPLBP, float KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B614C0", Offset = "0x2B608C0", VA = "0x182B614C0", Slot = "78")]
		public void JPFBIOHPAPP(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B60030", Offset = "0x2B5F430", VA = "0x182B60030", Slot = "79")]
		public void DKLIPDIJDHM(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B61830", Offset = "0x2B60C30", VA = "0x182B61830", Slot = "80")]
		public bool KGGLAGBBAOM(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B61120", Offset = "0x2B60520", VA = "0x182B61120", Slot = "24")]
		public void INILHHKBDKI(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B61260", Offset = "0x2B60660", VA = "0x182B61260", Slot = "25")]
		public void JDFMDINMCNB(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x40874D0", Offset = "0x40868D0", VA = "0x1840874D0")]
		private void KNOFDGJEOGM<T>(GPEJGMHBDPO GBPGPLEPLBP, bool KPPLMEOMNGF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x4087470", Offset = "0x4086870", VA = "0x184087470")]
		private bool KHJDFFMKJOL<T>(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x4088080", Offset = "0x4087480", VA = "0x184088080")]
		private void PMMODKPOELK<T>(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4086C00", Offset = "0x4086000", VA = "0x184086C00")]
		private bool AIJGPGGBGFG<TC, TV>(GPEJGMHBDPO GBPGPLEPLBP, Func<TC, TV> GBGEJGMHGKE, out TV KPPLMEOMNGF) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x4086CD0", Offset = "0x40860D0", VA = "0x184086CD0")]
		private bool AIJGPGGBGFG<T>(GPEJGMHBDPO GBPGPLEPLBP, out T KPPLMEOMNGF) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x4087520", Offset = "0x4086920", VA = "0x184087520")]
		private T LEKEELENHIE<T>(GPEJGMHBDPO GBPGPLEPLBP) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x4086F20", Offset = "0x4086320", VA = "0x184086F20")]
		private void IKMPHAGPNKE<T>(GPEJGMHBDPO GBPGPLEPLBP, T KPPLMEOMNGF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x4087970", Offset = "0x4086D70", VA = "0x184087970")]
		private void LKGJFMLBKJI<T>(GPEJGMHBDPO GBPGPLEPLBP, T KPPLMEOMNGF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x4086CD0", Offset = "0x40860D0", VA = "0x184086CD0")]
		private bool DKLPDHEDJBI<T>(GPEJGMHBDPO GBPGPLEPLBP, out T KPPLMEOMNGF) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x4086E00", Offset = "0x4086200", VA = "0x184086E00")]
		private T FOAIHDEBEMM<T>(GPEJGMHBDPO GBPGPLEPLBP) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x4086CD0", Offset = "0x40860D0", VA = "0x184086CD0")]
		private void MFJMMAHLBLJ<T>(GPEJGMHBDPO GBPGPLEPLBP, T KPPLMEOMNGF) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x4087FD0", Offset = "0x40873D0", VA = "0x184087FD0")]
		private void MBNIFFNJBGE<T>(GPEJGMHBDPO GBPGPLEPLBP, T KPPLMEOMNGF) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B620A0", Offset = "0x2B614A0", VA = "0x182B620A0")]
		private GPEJGMHBDPO MLCHMPFJNGD(Entity PJEENOLDJIO)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5FAC0", Offset = "0x2B5EEC0", VA = "0x182B5FAC0")]
		private DynamicBuffer<Entity> BLLJAKKJPOO(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x4086E60", Offset = "0x4086260", VA = "0x184086E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
			[DebuggerHidden]
			public PKLNDKFKAED(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x41BE540", Offset = "0x41BD940", VA = "0x1841BE540", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x41BE200", Offset = "0x41BD600", VA = "0x1841BE200", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x41BE5C0", Offset = "0x41BD9C0", VA = "0x1841BE5C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x41BE500", Offset = "0x41BD900", VA = "0x1841BE500", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x41BE450", Offset = "0x41BD850", VA = "0x1841BE450", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KLALODLBPPC> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x41BE450", Offset = "0x41BD850", VA = "0x1841BE450", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3127D20", Offset = "0x3127120", VA = "0x183127D20", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x3127C00", Offset = "0x3127000", VA = "0x183127C00")]
		public void IHGGPOIHOJD(NativeArray<Entity> GMAMPIGCEAB, bool LNOMECDPGOO, bool LMDHKCKFPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x3128530", Offset = "0x3127930", VA = "0x183128530")]
		public void OFICLPBCEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x3127D70", Offset = "0x3127170", VA = "0x183127D70")]
		private void MMCDAINHJOD(NativeArray<Entity> GMAMPIGCEAB, bool LNOMECDPGOO, bool LMDHKCKFPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x3127A20", Offset = "0x3126E20", VA = "0x183127A20")]
		[IteratorStateMachine(typeof(PKLNDKFKAED))]
		private IEnumerable<KLALODLBPPC> BNOBLHNNDHL(NativeArray<Entity> GMAMPIGCEAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x3127AB0", Offset = "0x3126EB0", VA = "0x183127AB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x3128790", Offset = "0x3127B90", VA = "0x183128790")]
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
		[Cpp2IlInjected.Address(RVA = "0x31262B0", Offset = "0x31256B0", VA = "0x1831262B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public GJOKNGAFGLP IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x3125CB0", Offset = "0x31250B0", VA = "0x183125CB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public GJOKNGAFGLP IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x3125CB0", Offset = "0x31250B0", VA = "0x183125CB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x3125CF0", Offset = "0x31250F0", VA = "0x183125CF0", Slot = "11")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x3125E20", Offset = "0x3125220", VA = "0x183125E20", Slot = "12")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "13")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3125EA0", Offset = "0x31252A0", VA = "0x183125EA0")]
	private void LDHGKFGDPIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x27D0130", Offset = "0x27CF530", VA = "0x1827D0130")]
	private string EAIPEFGMMJF(string GOENAEMJAON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x3125D40", Offset = "0x3125140", VA = "0x183125D40", Slot = "7")]
	public GJOKNGAFGLP IIODFPDLLAC(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x3125A00", Offset = "0x3124E00", VA = "0x183125A00")]
	private bool CBMGJGOPPBN(Type PMIFMNEAFNB, string GOENAEMJAON, out GJOKNGAFGLP LPPHHGKFEEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x31261A0", Offset = "0x31255A0", VA = "0x1831261A0", Slot = "8")]
	public BPHAMHGLCNC MHMDIEIEIKA(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return default(BPHAMHGLCNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3125CD0", Offset = "0x31250D0", VA = "0x183125CD0", Slot = "9")]
	public IEnumerator<GJOKNGAFGLP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x3125CD0", Offset = "0x31250D0", VA = "0x183125CD0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x31262D0", Offset = "0x31256D0", VA = "0x1831262D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3F640", Offset = "0x2B3EA40", VA = "0x182B3F640", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F6B0", Offset = "0x2B3EAB0", VA = "0x182B3F6B0", Slot = "6")]
	public bool GPAAOLEILLP(BPHAMHGLCNC CLOAPFCHKDE, out int MKMGHJFMNMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F720", Offset = "0x2B3EB20", VA = "0x182B3F720", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F6A0", Offset = "0x2B3EAA0", VA = "0x182B3F6A0", Slot = "5")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F780", Offset = "0x2B3EB80", VA = "0x182B3F780")]
	private void KKMHDFJKFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F9F0", Offset = "0x2B3EDF0", VA = "0x182B3F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B56A70", Offset = "0x2B55E70", VA = "0x182B56A70", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public AGAFPGKKJCP IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B56370", Offset = "0x2B55770", VA = "0x182B56370", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public AGAFPGKKJCP IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B56370", Offset = "0x2B55770", VA = "0x182B56370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "10")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2B56700", Offset = "0x2B55B00", VA = "0x182B56700", Slot = "11")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "12")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2B565D0", Offset = "0x2B559D0", VA = "0x182B565D0", Slot = "6")]
	public AGAFPGKKJCP IIODFPDLLAC(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2B569A0", Offset = "0x2B55DA0", VA = "0x182B569A0", Slot = "7")]
	public BPHAMHGLCNC MHMDIEIEIKA(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return default(BPHAMHGLCNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2B564F0", Offset = "0x2B558F0", VA = "0x182B564F0", Slot = "8")]
	public IEnumerator<AGAFPGKKJCP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2B56A80", Offset = "0x2B55E80", VA = "0x182B56A80", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2355580", Offset = "0x2354980", VA = "0x182355580", Slot = "13")]
	public void EFBHNODPNDJ<TKey, T>(global::PKAHIOONALH<TKey, T> MLIELKFMALM, [Optional] object MFEOJPNCOBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2B563B0", Offset = "0x2B557B0", VA = "0x182B563B0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public PJPHBCLBKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2B56370", Offset = "0x2B55770", VA = "0x182B56370")]
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
		[Cpp2IlInjected.Address(RVA = "0x3123F00", Offset = "0x3123300", VA = "0x183123F00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public MGJBDIBFMNC IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x31237A0", Offset = "0x3122BA0", VA = "0x1831237A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public MGJBDIBFMNC IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x31237A0", Offset = "0x3122BA0", VA = "0x1831237A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x3123DC0", Offset = "0x31231C0", VA = "0x183123DC0", Slot = "9")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3123850", Offset = "0x3122C50", VA = "0x183123850", Slot = "10")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x3123AB0", Offset = "0x3122EB0", VA = "0x183123AB0")]
	private MGJBDIBFMNC GFAMKPCIPGK(int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x3123CA0", Offset = "0x31230A0", VA = "0x183123CA0", Slot = "6")]
	public MGJBDIBFMNC IIODFPDLLAC(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x3123E30", Offset = "0x3123230", VA = "0x183123E30", Slot = "14")]
	public BPHAMHGLCNC MHMDIEIEIKA(DLPKPOKLLDJ GPBJNICHLBB)
	{
		return default(BPHAMHGLCNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x3123B90", Offset = "0x3122F90", VA = "0x183123B90", Slot = "7")]
	public IEnumerator<MGJBDIBFMNC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x3123B90", Offset = "0x3122F90", VA = "0x183123B90", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x37C4A70", Offset = "0x37C3E70", VA = "0x1837C4A70", Slot = "11")]
	public void EFBHNODPNDJ<TKey, T>(global::PKAHIOONALH<TKey, T> MLIELKFMALM, [Optional] object MFEOJPNCOBA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x31237B0", Offset = "0x3122BB0", VA = "0x1831237B0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public KCAGAILGGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x31237A0", Offset = "0x3122BA0", VA = "0x1831237A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6E7590", Offset = "0x6E6990", VA = "0x1806E7590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2D44F80", Offset = "0x2D44380", VA = "0x182D44F80", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2D44E90", Offset = "0x2D44290", VA = "0x182D44E90")]
	private void IHPFHAJBBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x29E7390", Offset = "0x29E6790", VA = "0x1829E7390")]
	public T AAOAHJEMNCJ<T>() where T : GBOCHCBEADE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2D450B0", Offset = "0x2D444B0", VA = "0x182D450B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D44DC0", Offset = "0x2D441C0", VA = "0x182D44DC0")]
	public MGJBDIBFMNC HGJABPPMKIA(DLPKPOKLLDJ GOENAEMJAON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6D90", Offset = "0x2BA6190", VA = "0x182BA6D90")]
	public global::DIJBCAAPJBG<T> HGJABPPMKIA<T>(DLPKPOKLLDJ GOENAEMJAON) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2D44CF0", Offset = "0x2D440F0", VA = "0x182D44CF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public ADFGLBDCGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class AKJNHIEIJEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2BABC80", Offset = "0x2BAB080", VA = "0x182BABC80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D5BE40", Offset = "0x2D5B240", VA = "0x182D5BE40", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x2D5BD20", Offset = "0x2D5B120", VA = "0x182D5BD20")]
	public void CMONGHJDGLF(IJDKBBDMEBI DGPLFECNDCD, bool MFNFGLHHIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
		[DebuggerHidden]
		public EMEFJIGINHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x41B6BB0", Offset = "0x41B5FB0", VA = "0x1841B6BB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x41B6800", Offset = "0x41B5C00", VA = "0x1841B6800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x41B6C30", Offset = "0x41B6030", VA = "0x1841B6C30")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x41B6B70", Offset = "0x41B5F70", VA = "0x1841B6B70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x41B6AE0", Offset = "0x41B5EE0", VA = "0x1841B6AE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x41B6AE0", Offset = "0x41B5EE0", VA = "0x1841B6AE0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B3F160", Offset = "0x2B3E560", VA = "0x182B3F160", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E460", Offset = "0x2B3D860", VA = "0x182B3E460", Slot = "5")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E0E0", Offset = "0x2B3D4E0", VA = "0x182B3E0E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E0D0", Offset = "0x2B3D4D0", VA = "0x182B3E0D0")]
	private void DKHHHBJFOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E9A0", Offset = "0x2B3DDA0", VA = "0x182B3E9A0")]
	internal void IEFCAOLALKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E7C0", Offset = "0x2B3DBC0", VA = "0x182B3E7C0")]
	private void HOLLIAOCKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F280", Offset = "0x2B3E680", VA = "0x182B3F280")]
	private void MNCMMOOGNBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F230", Offset = "0x2B3E630", VA = "0x182B3F230")]
	[IteratorStateMachine(typeof(EMEFJIGINHJ))]
	private IEnumerable<RRCustomPropTag> KOALJDNAIEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2B3DC50", Offset = "0x2B3D050", VA = "0x182B3DC50")]
	private void CHJFAIPGPFE(GPEJGMHBDPO GBPGPLEPLBP, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E680", Offset = "0x2B3DA80", VA = "0x182B3E680")]
	private void GBHABPPKBJN(SerializableGuid DBODHDCBMLJ, GameObject BLPBCMIHDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2B3EDD0", Offset = "0x2B3E1D0", VA = "0x182B3EDD0")]
	private void JDNPOKNLCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E280", Offset = "0x2B3D680", VA = "0x182B3E280")]
	private bool EPGKABFBDKL(KNLEFPMCGDO EELGGBLPOIL, Transform OKMBLMILFGG, out GameObject NMHCDAEEFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E630", Offset = "0x2B3DA30", VA = "0x182B3E630")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F380", Offset = "0x2B3E780", VA = "0x182B3F380")]
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
			[Cpp2IlInjected.Address(RVA = "0x701040", Offset = "0x700440", VA = "0x180701040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2B5F040", Offset = "0x2B5E440", VA = "0x182B5F040")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE09F70", Offset = "0xE09370", VA = "0x180E09F70")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D4E750", Offset = "0x2D4DB50", VA = "0x182D4E750", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D4F850", Offset = "0x2D4EC50", VA = "0x182D4F850", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F7E0", Offset = "0x2D4EBE0", VA = "0x182D4F7E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F8C0", Offset = "0x2D4ECC0", VA = "0x182D4F8C0")]
	private void MBBOHHGLIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F820", Offset = "0x2D4EC20", VA = "0x182D4F820")]
	private void EDAAICNBGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B406E0", Offset = "0x2B3FAE0", VA = "0x182B406E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public GPEJGMHBDPO EJMHGHICPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FEA0", Offset = "0x2B3F2A0", VA = "0x182B3FEA0", Slot = "9")]
		get
		{
			return default(GPEJGMHBDPO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2B40AA0", Offset = "0x2B3FEA0", VA = "0x182B40AA0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CDFLNPBCBAA MOPPCBEDDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2B409E0", Offset = "0x2B3FDE0", VA = "0x182B409E0", Slot = "11")]
		get
		{
			return default(CDFLNPBCBAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2B40AA0", Offset = "0x2B3FEA0", VA = "0x182B40AA0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public CDFLNPBCBAA AELCMLEDMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2B40C70", Offset = "0x2B40070", VA = "0x182B40C70", Slot = "13")]
		get
		{
			return default(CDFLNPBCBAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint GHJNABOINON
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FF60", Offset = "0x2B3F360", VA = "0x182B3FF60")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event NEHADPJGDHC NMNMMBPECAK
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FE00", Offset = "0x2B3F200", VA = "0x182B3FE00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2B40AC0", Offset = "0x2B3FEC0", VA = "0x182B40AC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2B40910", Offset = "0x2B3FD10", VA = "0x182B40910", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2B403B0", Offset = "0x2B3F7B0", VA = "0x182B403B0", Slot = "5")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2B40300", Offset = "0x2B3F700", VA = "0x182B40300", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2B40D30", Offset = "0x2B40130", VA = "0x182B40D30")]
	private void PMMOCKFCAEA(Entity PJEENOLDJIO, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM ENFEPLFMJNK, MPOLKMCKMLM IEFBANIHOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2B40B60", Offset = "0x2B3FF60", VA = "0x182B40B60", Slot = "14")]
	public GPEJGMHBDPO OLCENLILHJP(GPEJGMHBDPO PDOBLLBCDKJ, GPEJGMHBDPO FENFFOFPKDO)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2B40010", Offset = "0x2B3F410", VA = "0x182B40010", Slot = "15")]
	public bool DBLIAABGAHD(GPEJGMHBDPO PDOBLLBCDKJ, GPEJGMHBDPO FENFFOFPKDO, out GPEJGMHBDPO HGNJLFHFDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2B40780", Offset = "0x2B3FB80", VA = "0x182B40780", Slot = "16")]
	public void ILCEMCLBPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2B3FF40", Offset = "0x2B3F340", VA = "0x182B3FF40", Slot = "17")]
	public void APCOHHNFOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2B40110", Offset = "0x2B3F510", VA = "0x182B40110", Slot = "18")]
	public bool DMNDLLJKJKD(GPEJGMHBDPO NMAMPMADCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2B40550", Offset = "0x2B3F950", VA = "0x182B40550")]
	private void IDAACAFLGLI(GPEJGMHBDPO GNGEBABNPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x311B0B0", Offset = "0x311A4B0", VA = "0x18311B0B0", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x311B040", Offset = "0x311A440", VA = "0x18311B040", Slot = "5")]
	public void JANFKDNKIJO(GPEJGMHBDPO LCCDBPIJCNE, bool KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x241BA80", Offset = "0x241AE80", VA = "0x18241BA80")]
	private void JPNFGACMGOG<T>(GPEJGMHBDPO LCCDBPIJCNE, bool KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD95D0", Offset = "0x2CD89D0", VA = "0x182CD95D0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9560", Offset = "0x2CD8960", VA = "0x182CD9560", Slot = "5")]
		public void BMOHKAOODHK(GPEJGMHBDPO LCCDBPIJCNE, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9650", Offset = "0x2CD8A50", VA = "0x182CD9650", Slot = "6")]
		public void NPFGMIKLPAP(GPEJGMHBDPO LCCDBPIJCNE, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x241BA80", Offset = "0x241AE80", VA = "0x18241BA80")]
		private void JPNFGACMGOG<T>(GPEJGMHBDPO LCCDBPIJCNE, bool KPPLMEOMNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B440A0", Offset = "0x2B434A0", VA = "0x182B440A0", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0xC36E50", Offset = "0xC36250", VA = "0x180C36E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE110", Offset = "0x2CED510", VA = "0x182CEE110", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ NOOBBCKAGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2CED6F0", Offset = "0x2CECAF0", VA = "0x182CED6F0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDB20", Offset = "0x2CECF20", VA = "0x182CEDB20", Slot = "6")]
		public bool HGCEOMJIBGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE740", Offset = "0x2CEDB40", VA = "0x182CEE740", Slot = "7")]
		public bool MLAHAICGOPD(IEnumerable<EMMEDLLCNCH> PNDLEPGFOGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDC80", Offset = "0x2CED080", VA = "0x182CEDC80", Slot = "5")]
		public ByteString IDGEKAFJKEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2CED630", Offset = "0x2CECA30", VA = "0x182CED630")]
		private void AHIDBLHDIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2CED720", Offset = "0x2CECB20", VA = "0x182CED720")]
		private void GKLEIOJOBBM(KDFLMOJDNAH OIAFFOAGAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE260", Offset = "0x2CED660", VA = "0x182CEE260")]
		private void MKJBPNKKHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2CED840", Offset = "0x2CECC40", VA = "0x182CED840")]
		private void HBKDLOBFCFI(CONHDBOPGAO OIAFFOAGAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2CED7F0", Offset = "0x2CECBF0", VA = "0x182CED7F0", Slot = "8")]
		public void HBECBLLPJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2CED650", Offset = "0x2CECA50", VA = "0x182CED650")]
		private KDFLMOJDNAH AHPBEKCMKPJ(EntityManager ABFDLFMHAJL, EntityManager LKAGEFPMCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x311B3F0", Offset = "0x311A7F0", VA = "0x18311B3F0")]
	public GameObject GIEPJEOMMKO(MCLBIBPLLEA CLFHKFOADIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x311B4C0", Offset = "0x311A8C0", VA = "0x18311B4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CE1000", Offset = "0x2CE0400", VA = "0x182CE1000")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0E70", Offset = "0x2CE0270", VA = "0x182CE0E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool LDCFIBOIKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x6FA8D0", Offset = "0x6F9CD0", VA = "0x1806FA8D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x71C000", Offset = "0x71B400", VA = "0x18071C000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x25729D0", Offset = "0x2571DD0", VA = "0x1825729D0", Slot = "4")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2CE0FB0", Offset = "0x2CE03B0", VA = "0x182CE0FB0", Slot = "5")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2CE0EF0", Offset = "0x2CE02F0", VA = "0x182CE0EF0")]
		public void IDBFLDBCCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CDD1C0", Offset = "0x2CDC5C0", VA = "0x182CDD1C0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD090", Offset = "0x2CDC490", VA = "0x182CDD090", Slot = "5")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCFF0", Offset = "0x2CDC3F0", VA = "0x182CDCFF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD230", Offset = "0x2CDC630", VA = "0x182CDD230")]
		private void POIDDGAPPAI(Entity PJEENOLDJIO, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x310DC60", Offset = "0x310D060", VA = "0x18310DC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private MGKDLMNJGLC KEPENBEICJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x310DB90", Offset = "0x310CF90", VA = "0x18310DB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x310DBE0", Offset = "0x310CFE0", VA = "0x18310DBE0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x310DB70", Offset = "0x310CF70", VA = "0x18310DB70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public EDLFHEBOAMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x41B63D0", Offset = "0x41B57D0", VA = "0x1841B63D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BPDPCGLKBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x41B4B90", Offset = "0x41B3F90", VA = "0x1841B4B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x94D020", Offset = "0x94C420", VA = "0x18094D020", Slot = "4")]
		get
		{
			return default(PIEGKGHOKCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private NPAPPEKNDDD BFPFOELPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x3117570", Offset = "0x3116970", VA = "0x183117570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x3117520", Offset = "0x3116920", VA = "0x183117520", Slot = "5")]
	public void FEIOIOFEHFM(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x31175C0", Offset = "0x31169C0", VA = "0x1831175C0", Slot = "6")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x31176F0", Offset = "0x3116AF0", VA = "0x1831176F0", Slot = "7")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x3117440", Offset = "0x3116840", VA = "0x183117440", Slot = "8")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x3117310", Offset = "0x3116710", VA = "0x183117310", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2389CF0", Offset = "0x23890F0", VA = "0x182389CF0")]
	private void ABFIAEOBJJK<T>(Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x29C1680", Offset = "0x29C0A80", VA = "0x1829C1680", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x29C16E0", Offset = "0x29C0AE0", VA = "0x1829C16E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x29C1650", Offset = "0x29C0A50", VA = "0x1829C1650", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x79A190", Offset = "0x799590", VA = "0x18079A190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x29C15C0", Offset = "0x29C09C0", VA = "0x1829C15C0")]
	public EGHLJOHKCPL(Func<From, To> DKEBKHECPOH, Func<To, From> IICCJFLIFIF, bool BHCHPGOJODJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x29C11B0", Offset = "0x29C05B0", VA = "0x1829C11B0", Slot = "11")]
	public void Add(To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x29C1210", Offset = "0x29C0610", VA = "0x1829C1210", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x29C1240", Offset = "0x29C0640", VA = "0x1829C1240", Slot = "13")]
	public bool Contains(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x29C12A0", Offset = "0x29C06A0", VA = "0x1829C12A0", Slot = "14")]
	public void CopyTo(To[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x29C13B0", Offset = "0x29C07B0", VA = "0x1829C13B0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x29C1420", Offset = "0x29C0820", VA = "0x1829C1420", Slot = "6")]
	public int IndexOf(To DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x29C1480", Offset = "0x29C0880", VA = "0x1829C1480", Slot = "7")]
	public void Insert(int EGBCAPEEJBF, To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x29C1530", Offset = "0x29C0930", VA = "0x1829C1530", Slot = "15")]
	public bool Remove(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x29C1500", Offset = "0x29C0900", VA = "0x1829C1500", Slot = "8")]
	public void RemoveAt(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x29C1590", Offset = "0x29C0990", VA = "0x1829C1590", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x285FB70", Offset = "0x285EF70", VA = "0x18285FB70", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x285FBC0", Offset = "0x285EFC0", VA = "0x18285FBC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x285FB30", Offset = "0x285EF30", VA = "0x18285FB30", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool NLCBLEMMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2742CD0", Offset = "0x27420D0", VA = "0x182742CD0")]
	public KJJDOFLKDCI(Func<From, To> DKEBKHECPOH, Func<To, From> IICCJFLIFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x285F740", Offset = "0x285EB40", VA = "0x18285F740", Slot = "11")]
	public void Add(To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x285F780", Offset = "0x285EB80", VA = "0x18285F780", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x285F7C0", Offset = "0x285EBC0", VA = "0x18285F7C0", Slot = "13")]
	public bool Contains(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x285F880", Offset = "0x285EC80", VA = "0x18285F880", Slot = "14")]
	public void CopyTo(To[] EGIDMCNFHCK, int FMNFDAHCLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x285F940", Offset = "0x285ED40", VA = "0x18285F940", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x285FA00", Offset = "0x285EE00", VA = "0x18285FA00", Slot = "6")]
	public int IndexOf(To DKIDMLOAMGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x285FA70", Offset = "0x285EE70", VA = "0x18285FA70", Slot = "7")]
	public void Insert(int EGBCAPEEJBF, To DKIDMLOAMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x285FAF0", Offset = "0x285EEF0", VA = "0x18285FAF0", Slot = "15")]
	public bool Remove(To DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x285FAB0", Offset = "0x285EEB0", VA = "0x18285FAB0", Slot = "8")]
	public void RemoveAt(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x27E12F0", Offset = "0x27E06F0", VA = "0x1827E12F0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public NGFCJPHMDGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x41BCA70", Offset = "0x41BBE70", VA = "0x1841BCA70")]
		internal void <InitServices>b__1(MIBCENMOHFA svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x41BCAD0", Offset = "0x41BBED0", VA = "0x1841BCAD0")]
		internal void <InitServices>b__2(PFFHIJLFPMD svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x311B130", Offset = "0x311A530", VA = "0x18311B130")]
	public static void LBLKFPNACLN(this NPAPPEKNDDD BKFHGKOCNCC, FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x241BAF0", Offset = "0x241AEF0", VA = "0x18241BAF0")]
	public static void ABFIAEOBJJK<T>(this NPAPPEKNDDD BKFHGKOCNCC, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x241C030", Offset = "0x241B430", VA = "0x18241C030")]
	public static void HIIBCEBNIGH<T>(this NPAPPEKNDDD BKFHGKOCNCC, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x241C290", Offset = "0x241B690", VA = "0x18241C290")]
	public static void NLIBGFMKGNO<T>(this NPAPPEKNDDD BKFHGKOCNCC, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x241BD10", Offset = "0x241B110", VA = "0x18241BD10")]
	public static void HGDNHAGBKNJ<T>(this NPAPPEKNDDD BKFHGKOCNCC, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x241BB60", Offset = "0x241AF60", VA = "0x18241BB60")]
	public static void EOAAICFCIPM<T>(this NPAPPEKNDDD BKFHGKOCNCC, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x241BEC0", Offset = "0x241B2C0", VA = "0x18241BEC0")]
	public static void HIIBCEBNIGH<T>(IEnumerable<ComponentSystemBase> FGEEBMNILFP, Action<T> PIJHAFCEHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x241C1D0", Offset = "0x241B5D0", VA = "0x18241C1D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B3F480", Offset = "0x2B3E880", VA = "0x182B3F480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public DDLIKBJKCOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x2B562A0", Offset = "0x2B556A0", VA = "0x182B562A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CDC1E0", Offset = "0x2CDB5E0", VA = "0x182CDC1E0")]
		public static void LDHMAOMPMOJ(this EHPGCEGHLNO HPFBGIEBCLA, DGHHMLJKDPD HGNBPKPAAFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBF80", Offset = "0x2CDB380", VA = "0x182CDBF80")]
		public static void BMOAPIFINMA(this EHPGCEGHLNO HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC410", Offset = "0x2CDB810", VA = "0x182CDC410")]
		public static void LDHMAOMPMOJ(this EHPGCEGHLNO HPFBGIEBCLA, [Optional] string[] MCDHAAGLAGD, [Optional] string[] OLODNCAENMJ, [Optional] string[] CNAHBAPFKNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC080", Offset = "0x2CDB480", VA = "0x182CDC080")]
		public static void CGIPIPBKEJN(this EHPGCEGHLNO HPFBGIEBCLA, params string[] BLGBFHLBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC130", Offset = "0x2CDB530", VA = "0x182CDC130")]
		public static void KAMILGFPOHK(this EHPGCEGHLNO HPFBGIEBCLA, params string[] BLGBFHLBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC520", Offset = "0x2CDB920", VA = "0x182CDC520")]
		private static string[] LKOBGLNBAEI(DGHHMLJKDPD HGNBPKPAAFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBDC0", Offset = "0x2CDB1C0", VA = "0x182CDBDC0")]
		private static bool BAFLKMOGAPA(DGHHMLJKDPD HGNBPKPAAFI, out string[] PGMGILACNBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D4C4D0", Offset = "0x2D4B8D0", VA = "0x182D4C4D0")]
	public EOBELOOOIIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action BCDKGFIJJDD();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D62580", Offset = "0x2D61980", VA = "0x182D62580")]
	public MethodInfo NBKKHLNFPLA(Action FFBLFKDINEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D623D0", Offset = "0x2D617D0", VA = "0x182D623D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B47D60", Offset = "0x2B47160", VA = "0x182B47D60", Slot = "5")]
	public override Action BCDKGFIJJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BENMIKCNMJG<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2B47DF0", Offset = "0x2B471F0", VA = "0x182B47DF0")]
	[Preserve]
	public void LPMGNLLDDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2B41F30", Offset = "0x2B41330", VA = "0x182B41F30")]
	protected OJPFDPPCFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class BOOCJNPMKNA : EOBELOOOIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C3B0", Offset = "0x2D4B7B0", VA = "0x182D4C3B0", Slot = "5")]
	public override Action BCDKGFIJJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void LPHEFIDJEDE<T>() where T : KHHHMANHCMP;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C440", Offset = "0x2D4B840", VA = "0x182D4C440")]
	[Preserve]
	public void LPMGNLLDDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C4D0", Offset = "0x2D4B8D0", VA = "0x182D4C4D0")]
	protected BOOCJNPMKNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class MCELHJMBBCH : EOBELOOOIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x2B41E10", Offset = "0x2B41210", VA = "0x182B41E10", Slot = "5")]
	public override Action BCDKGFIJJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IGJJAOCCECA<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x2B41EA0", Offset = "0x2B412A0", VA = "0x182B41EA0")]
	[Preserve]
	public void LPMGNLLDDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x2B41F30", Offset = "0x2B41330", VA = "0x182B41F30")]
	protected MCELHJMBBCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class LNJAILBBBPK
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x2B41180", Offset = "0x2B40580", VA = "0x182B41180")]
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
				[Cpp2IlInjected.Address(RVA = "0x270BC50", Offset = "0x270B050", VA = "0x18270BC50", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x41B4A50", Offset = "0x41B3E50", VA = "0x1841B4A50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x41B4AA0", Offset = "0x41B3EA0", VA = "0x1841B4AA0")]
			[DebuggerHidden]
			public BLCIGMFMKOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x41B4880", Offset = "0x41B3C80", VA = "0x1841B4880", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x41B4A10", Offset = "0x41B3E10", VA = "0x1841B4A10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x41B4960", Offset = "0x41B3D60", VA = "0x1841B4960", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x41B4960", Offset = "0x41B3D60", VA = "0x1841B4960", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x270BC50", Offset = "0x270B050", VA = "0x18270BC50", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x41B7A80", Offset = "0x41B6E80", VA = "0x1841B7A80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x41B4AA0", Offset = "0x41B3EA0", VA = "0x1841B4AA0")]
			[DebuggerHidden]
			public GILMEBKPOOD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x41B7AD0", Offset = "0x41B6ED0", VA = "0x1841B7AD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x41B77A0", Offset = "0x41B6BA0", VA = "0x1841B77A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x41B7B60", Offset = "0x41B6F60", VA = "0x1841B7B60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x41B7A40", Offset = "0x41B6E40", VA = "0x1841B7A40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x41B7990", Offset = "0x41B6D90", VA = "0x1841B7990", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x41B7990", Offset = "0x41B6D90", VA = "0x1841B7990", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x270BC50", Offset = "0x270B050", VA = "0x18270BC50", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x41BC5E0", Offset = "0x41BB9E0", VA = "0x1841BC5E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x41B4AA0", Offset = "0x41B3EA0", VA = "0x1841B4AA0")]
			[DebuggerHidden]
			public MLHKJDGHBAB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x41BC630", Offset = "0x41BBA30", VA = "0x1841BC630", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x41BC1D0", Offset = "0x41BB5D0", VA = "0x1841BC1D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x41BC700", Offset = "0x41BBB00", VA = "0x1841BC700")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x41BC750", Offset = "0x41BBB50", VA = "0x1841BC750")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x41BC5A0", Offset = "0x41BB9A0", VA = "0x1841BC5A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x41BC500", Offset = "0x41BB900", VA = "0x1841BC500", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x41BC500", Offset = "0x41BB900", VA = "0x1841BC500", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x3111090", Offset = "0x3110490", VA = "0x183111090")]
		public static Entity JBLCGLJHIOG(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x3110CA0", Offset = "0x31100A0", VA = "0x183110CA0")]
		public static DynamicBuffer<ChildrenData> FCHBCBICGMH(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x3111230", Offset = "0x3110630", VA = "0x183111230")]
		public static DynamicBuffer<ChildrenData> JKEFMKGAFNC(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x3111100", Offset = "0x3110500", VA = "0x183111100")]
		public static NativeArray<Entity> JCFAOEENOOF(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Allocator GOLNHBOGNGC)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x3110F90", Offset = "0x3110390", VA = "0x183110F90")]
		public static bool HMDLBGPCNIP(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Allocator GOLNHBOGNGC, out NativeArray<Entity> HPJAEDPBFNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x310FFD0", Offset = "0x310F3D0", VA = "0x18310FFD0")]
		public static NativeArray<Entity> AAPKPAPPKJH(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x3110B70", Offset = "0x310FF70", VA = "0x183110B70")]
		public static Entity ELIAHCIMIEO(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, int EGBCAPEEJBF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x3111440", Offset = "0x3110840", VA = "0x183111440")]
		public static int KIPGBJMICGF(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x3110910", Offset = "0x310FD10", VA = "0x183110910")]
		public static void DNGOJPJPEBP(NativeArray<Entity> OCFBEMCGNEI, NativeArray<Entity> DJHPOGLHKJI, EntityManager JGDEKKJFKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x3110580", Offset = "0x310F980", VA = "0x183110580")]
		public static int CJNFLMDPHGO(this EntityManager JGDEKKJFKAJ, Entity OKMBLMILFGG, Entity BOGHNKLNLII)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x3111670", Offset = "0x3110A70", VA = "0x183111670")]
		public static bool PFJDPANHIDM(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Entity ADAJCIOPLGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x31117D0", Offset = "0x3110BD0", VA = "0x1831117D0")]
		public static IEnumerable<Entity> PKDPPNNMDAK(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x31102C0", Offset = "0x310F6C0", VA = "0x1831102C0")]
		public static bool CCMBIGLHNMK(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Entity BOGHNKLNLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x3110130", Offset = "0x310F530", VA = "0x183110130")]
		public static bool BEPDKIFHAFJ(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Entity PDOBLLBCDKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x3110370", Offset = "0x310F770", VA = "0x183110370")]
		public static NativeList<Entity> CHFELALAAIJ(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, bool GNDBKIJJAND = false, Allocator GOLNHBOGNGC = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x31112C0", Offset = "0x31106C0", VA = "0x1831112C0")]
		public static IEnumerable<Entity> JNFNFOAALOH(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x31118E0", Offset = "0x3110CE0", VA = "0x1831118E0")]
		public static Entity PLFCFKIEBOC(this EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x31106B0", Offset = "0x310FAB0", VA = "0x1831106B0")]
		public static bool DBLIAABGAHD(this EntityManager JGDEKKJFKAJ, Entity PDOBLLBCDKJ, Entity FENFFOFPKDO, out Entity HGNJLFHFDIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x3110E10", Offset = "0x3110210", VA = "0x183110E10")]
		internal static void FLIFJBCJMOD(EntityManager JGDEKKJFKAJ, Entity OKMBLMILFGG, Entity BOGHNKLNLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x3110E90", Offset = "0x3110290", VA = "0x183110E90")]
		internal static void GLCMELCNEDN(EntityManager JGDEKKJFKAJ, Entity OKMBLMILFGG, Entity BOGHNKLNLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x31115E0", Offset = "0x31109E0", VA = "0x1831115E0")]
		[IteratorStateMachine(typeof(BLCIGMFMKOJ))]
		private static IEnumerable<Entity> ODOEDOCNMDI(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x3111550", Offset = "0x3110950", VA = "0x183111550")]
		[IteratorStateMachine(typeof(GILMEBKPOOD))]
		private static IEnumerable<Entity> NNDFBOJHPDM(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x3110630", Offset = "0x310FA30", VA = "0x183110630")]
		[IteratorStateMachine(typeof(MLHKJDGHBAB))]
		private static IEnumerable<Entity> CLJLPKANAFH(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x3110D30", Offset = "0x3110130", VA = "0x183110D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public KHCCBBJDMKM JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public EEPEPNPEOFG BFPFOELPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public PJCCMDKJKFG EPDHPONELOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public PLHAEEKILKB JFDMKHENBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public FOBNDAGEMLO FPIICNIIOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public CGDDJBMDAKP AKFBLEDGEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x6E7580", Offset = "0x6E6980", VA = "0x1806E7580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public EOBKLCMHAME OMHHCDEFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6E00D0", Offset = "0x6DF4D0", VA = "0x1806E00D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public EPLLJMMPLGC JJCHHCLNGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x6F6760", Offset = "0x6F5B60", VA = "0x1806F6760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public OHFKOIDMPOO FPIIOFIPILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x6E00B0", Offset = "0x6DF4B0", VA = "0x1806E00B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public FMGCEKBAGOP DPCFLKEACDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x6F6770", Offset = "0x6F5B70", VA = "0x1806F6770", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public DMNNGJLJJJC IEMKBGEBCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x6F6780", Offset = "0x6F5B80", VA = "0x1806F6780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public AIIFBLBGOBI FJMJMIJBCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x6F6700", Offset = "0x6F5B00", VA = "0x1806F6700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public EHCGNDKDHFM FAMBGOHJMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6710", Offset = "0x6F5B10", VA = "0x1806F6710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public NNPPGMKPBPK NMOFOMIKKED
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x71C6D0", Offset = "0x71BAD0", VA = "0x18071C6D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public AHELNIAPJDN MOCOCKENKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x6E6D80", Offset = "0x6E6180", VA = "0x1806E6D80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public HBMNANFILGC NOKBBCNBEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E20", Offset = "0x6E6220", VA = "0x1806E6E20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public BIEHHNEIICJ PAGKBNBNKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x71C6A0", Offset = "0x71BAA0", VA = "0x18071C6A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public BJNLEMECNFA EOJIPMNJOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6720", Offset = "0x6F5B20", VA = "0x1806F6720", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public MJBFDNAELPM JILOHMEMMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x6F6730", Offset = "0x6F5B30", VA = "0x1806F6730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public OLGPCPINIDC INDLFDCDHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x6F6750", Offset = "0x6F5B50", VA = "0x1806F6750", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public PIEGKGHOKCE JBBLCINBLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x706AA0", Offset = "0x705EA0", VA = "0x180706AA0", Slot = "21")]
		get
		{
			return default(PIEGKGHOKCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x3125190", Offset = "0x3124590", VA = "0x183125190", Slot = "22")]
	public void FEIOIOFEHFM(FEPIHHOJCOJ NOOBBCKAGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2A10", Offset = "0x1FC1E10", VA = "0x181FC2A10", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x3125480", Offset = "0x3124880", VA = "0x183125480", Slot = "23")]
	public void NMNMMBPECAK(FEPIHHOJCOJ NOOBBCKAGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F6790", Offset = "0x6F5B90", VA = "0x1806F6790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B6380", Offset = "0x41B5780", VA = "0x1841B6380", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public EDEOFJKHDMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x41B61D0", Offset = "0x41B55D0", VA = "0x1841B61D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x41B6340", Offset = "0x41B5740", VA = "0x1841B6340", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1BD0", Offset = "0x6E0FD0", VA = "0x1806E1BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x784430", Offset = "0x783830", VA = "0x180784430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int HEMFIMDKICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC90", Offset = "0x6FB090", VA = "0x1806FBC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x784340", Offset = "0x783740", VA = "0x180784340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x3115250", Offset = "0x3114650", VA = "0x183115250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x3115380", Offset = "0x3114780", VA = "0x183115380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x3116120", Offset = "0x3115520", VA = "0x183116120")]
	public FPHDAPPLMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x3115FE0", Offset = "0x31153E0", VA = "0x183115FE0")]
	public FPHDAPPLMBA(int OECMPIPLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x3115C60", Offset = "0x3115060", VA = "0x183115C60")]
	public bool KGNHPEHADKP(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x3115D40", Offset = "0x3115140", VA = "0x183115D40")]
	public bool MILBJPHEDCF(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x31152F0", Offset = "0x31146F0", VA = "0x1831152F0")]
	public bool EGHJJKFFGDL(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x3115370", Offset = "0x3114770", VA = "0x183115370")]
	public bool EMBOEJCGPBA(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x3115AE0", Offset = "0x3114EE0", VA = "0x183115AE0")]
	public void JHNODPHEAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x31159F0", Offset = "0x3114DF0", VA = "0x1831159F0")]
	public void HIANJBIKEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x3115B70", Offset = "0x3114F70", VA = "0x183115B70")]
	public void JPNFGACMGOG(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x3115530", Offset = "0x3114930", VA = "0x183115530")]
	public void FPEOCMBDEPF(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x3115E30", Offset = "0x3115230", VA = "0x183115E30")]
	public bool OLMDFONJDCE(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x3115EC0", Offset = "0x31152C0", VA = "0x183115EC0")]
	public void OOBAJEHGDJF(int LKCJJEBACFP, int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x3115830", Offset = "0x3114C30", VA = "0x183115830")]
	public void HAPIIJDFKIK(int MHOBHCMCJBM, int HFNHDBFKNLC, int KJAHKKMJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x3115680", Offset = "0x3114A80", VA = "0x183115680")]
	public int GBJBCHALJOG(int KJAHKKMJHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x3115750", Offset = "0x3114B50", VA = "0x183115750")]
	public int GBJBCHALJOG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x3115630", Offset = "0x3114A30", VA = "0x183115630")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x31157C0", Offset = "0x3114BC0", VA = "0x1831157C0", Slot = "4")]
	[IteratorStateMachine(typeof(EDEOFJKHDMG))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x31157C0", Offset = "0x3114BC0", VA = "0x1831157C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x14CA010", Offset = "0x14C9410", VA = "0x1814CA010")]
	public EIODOCPCLNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EBE0", Offset = "0x1F7DFE0", VA = "0x181F7EBE0")]
	public EIODOCPCLNH(global::DFPNLGKLLNI<T> OFGEDPJNLHJ, global::NIMGDENJGPM<T> HMEPNCLLPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E8A0", Offset = "0x1F7DCA0", VA = "0x181F7E8A0", Slot = "11")]
	public override T EOLLHEJPBAN(IDNDLGCBDKF AKJDPBEAJPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E590", Offset = "0x1F7D990", VA = "0x181F7E590", Slot = "12")]
	public override void CJKIIDNIDDE(IDNDLGCBDKF AKJDPBEAJPA, T KPPLMEOMNGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class MIJIICGHBAK
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x29F08C0", Offset = "0x29EFCC0", VA = "0x1829F08C0")]
	public static BPHAMHGLCNC GBHABPPKBJN<T>(this DHPMLHOBOOK ICBILMELIDM, global::CKGECMCPKDO<T> GOENAEMJAON, global::DFPNLGKLLNI<T> OFGEDPJNLHJ, global::NIMGDENJGPM<T> HMEPNCLLPDD) where T : struct
	{
		return default(BPHAMHGLCNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class LGEJMOFIIHK<T> : global::EIODOCPCLNH<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x2A506B0", Offset = "0x2A4FAB0", VA = "0x182A506B0")]
	public LGEJMOFIIHK(T EKDCKLAKFJN, T IBFPNBPAEOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class AJHEAFJCDGO<T> : global::HGLMBFKILIE<T> where T : struct, KHHHMANHCMP
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x25AFAE0", Offset = "0x25AEEE0", VA = "0x1825AFAE0", Slot = "11")]
	public override T EOLLHEJPBAN(IDNDLGCBDKF AKJDPBEAJPA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x25AF9C0", Offset = "0x25AEDC0", VA = "0x1825AF9C0", Slot = "12")]
	public override void CJKIIDNIDDE(IDNDLGCBDKF AKJDPBEAJPA, T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x1BA1CE0", Offset = "0x1BA10E0", VA = "0x181BA1CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2758270", Offset = "0x2757670", VA = "0x182758270", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x2758F60", Offset = "0x2758360", VA = "0x182758F60", Slot = "8")]
	public override void EOLLHEJPBAN(IDNDLGCBDKF AKJDPBEAJPA, in GHPDGIAHCBK NMAMPMADCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x27577F0", Offset = "0x2756BF0", VA = "0x1827577F0", Slot = "9")]
	public override void CJKIIDNIDDE(IDNDLGCBDKF AKJDPBEAJPA, in MPOLKMCKMLM EHNCKNECPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x27595B0", Offset = "0x27589B0", VA = "0x1827595B0", Slot = "10")]
	public override void LPKKHPLBIJM(IDNDLGCBDKF AKJDPBEAJPA, GMGJEMLNHGE NIICHBPFANE, object MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x14FF8B0", Offset = "0x14FECB0", VA = "0x1814FF8B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
			public JAIIPFPDEOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x354FB60", Offset = "0x354EF60", VA = "0x18354FB60")]
			internal void <RegisterFixedString>b__0(IDNDLGCBDKF p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x354FD90", Offset = "0x354F190", VA = "0x18354FD90")]
			internal T <RegisterFixedString>b__1(IDNDLGCBDKF p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x41B8CE0", Offset = "0x41B80E0", VA = "0x1841B8CE0")]
		public static void HKCGAKMPIED(IIAGOIHDMCC JEMCFCDDPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x2A82E00", Offset = "0x2A82200", VA = "0x182A82E00")]
		private static void JINLLMKAMNB<T>(IIAGOIHDMCC JEMCFCDDPDL, int IBFPNBPAEOD) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x2A82F20", Offset = "0x2A82320", VA = "0x182A82F20")]
		private static void PLDILALKEJE<T>(IDNDLGCBDKF JPPIJLBNKPM, T APLGHPJFDAI, int IBFPNBPAEOD) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x2A827B0", Offset = "0x2A81BB0", VA = "0x182A827B0")]
		private static T HJHJBFNNDEL<T>(IDNDLGCBDKF JPPIJLBNKPM, int IBFPNBPAEOD) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A82590", Offset = "0x2A81990", VA = "0x182A82590", Slot = "6")]
		public override void BENMIKCNMJG<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x41B87C0", Offset = "0x41B7BC0", VA = "0x1841B87C0")]
		public static void JDEFDBGAAPE(IIAGOIHDMCC JEMCFCDDPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x41B8870", Offset = "0x41B7C70", VA = "0x1841B8870")]
		public IHKMFLAMIMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x3111C20", Offset = "0x3111020", VA = "0x183111C20")]
	public static void KJKOKPHEMIO(IIAGOIHDMCC JEMCFCDDPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x1E68C20", Offset = "0x1E68020", VA = "0x181E68C20")]
	public static void IIFKIALBGHG<T>(IIAGOIHDMCC JEMCFCDDPDL, global::DFPNLGKLLNI<T> OFGEDPJNLHJ, global::NIMGDENJGPM<T> HMEPNCLLPDD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x1E68CB0", Offset = "0x1E680B0", VA = "0x181E68CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D50000", Offset = "0x2D4F400", VA = "0x182D50000")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x79A190", Offset = "0x799590", VA = "0x18079A190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2D4BAC0", Offset = "0x2D4AEC0", VA = "0x182D4BAC0")]
	public BCOMHCIKEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D4BA00", Offset = "0x2D4AE00", VA = "0x182D4BA00")]
	public BCOMHCIKEPP(Dictionary<BPHAMHGLCNC, JGIBKOJOACC> JEMCFCDDPDL, bool JLMINONKOLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x2D4B6A0", Offset = "0x2D4AAA0", VA = "0x182D4B6A0", Slot = "7")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D4B700", Offset = "0x2D4AB00", VA = "0x182D4B700", Slot = "8")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D4B4E0", Offset = "0x2D4A8E0", VA = "0x182D4B4E0", Slot = "9")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D4B930", Offset = "0x2D4AD30", VA = "0x182D4B930", Slot = "4")]
	public BPHAMHGLCNC MHMDIEIEIKA(DLPKPOKLLDJ GOENAEMJAON)
	{
		return default(BPHAMHGLCNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2D4B530", Offset = "0x2D4A930", VA = "0x182D4B530", Slot = "5")]
	public void GBHABPPKBJN(BPHAMHGLCNC CLOAPFCHKDE, JGIBKOJOACC NLIHAKMICKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2D4B3A0", Offset = "0x2D4A7A0", VA = "0x182D4B3A0")]
	[Conditional("DEBUG_BUILD")]
	private void EEJHOPIFLAD(BPHAMHGLCNC CLOAPFCHKDE, Type HAOFNDAEGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2D4B780", Offset = "0x2D4AB80", VA = "0x182D4B780", Slot = "6")]
	public bool LEDONIKBHEA(BPHAMHGLCNC CLOAPFCHKDE, out JGIBKOJOACC NLIHAKMICKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D4B2C0", Offset = "0x2D4A6C0", VA = "0x182D4B2C0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA8D0", Offset = "0x6F9CD0", VA = "0x1806FA8D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x71C000", Offset = "0x71B400", VA = "0x18071C000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6CB0", Offset = "0x2CE60B0", VA = "0x182CE6CB0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6D30", Offset = "0x2CE6130", VA = "0x182CE6D30")]
		public TypeSerializerService(Dictionary<Type, JGIBKOJOACC> JEMCFCDDPDL, bool JLMINONKOLE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6B20", Offset = "0x2CE5F20", VA = "0x182CE6B20", Slot = "4")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6A00", Offset = "0x2CE5E00", VA = "0x182CE6A00", Slot = "5")]
		public void GBHABPPKBJN(Type HAOFNDAEGFJ, JGIBKOJOACC NLIHAKMICKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6B80", Offset = "0x2CE5F80", VA = "0x182CE6B80", Slot = "6")]
		public bool LEDONIKBHEA(Type HAOFNDAEGFJ, out JGIBKOJOACC NLIHAKMICKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6920", Offset = "0x2CE5D20", VA = "0x182CE6920", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D5C1B0", Offset = "0x2D5B5B0", VA = "0x182D5C1B0", Slot = "6")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C200", Offset = "0x2D5B600", VA = "0x182D5C200", Slot = "7")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C140", Offset = "0x2D5B540", VA = "0x182D5C140", Slot = "4")]
	public void GBHABPPKBJN(BPHAMHGLCNC AOKMGDODDPA, Type DDANHEOJOHK, PNKMIOFLGOC HGLGAJBLDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C0D0", Offset = "0x2D5B4D0", VA = "0x182D5C0D0", Slot = "5")]
	public bool CNBLODMEEBF(BPHAMHGLCNC AOKMGDODDPA, out PNKMIOFLGOC HGLGAJBLDDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C260", Offset = "0x2D5B660", VA = "0x182D5C260")]
	[Conditional("DEBUG_BUILD")]
	private void LEAAKOEBBEO(BPHAMHGLCNC AOKMGDODDPA, Type DDANHEOJOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C3F0", Offset = "0x2D5B7F0", VA = "0x182D5C3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D4FD70", Offset = "0x2D4F170", VA = "0x182D4FD70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool PIODGPGALDM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7AB560", Offset = "0x7AA960", VA = "0x1807AB560", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x941400", Offset = "0x940800", VA = "0x180941400", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F8F0", Offset = "0x2D4ECF0", VA = "0x182D4F8F0", Slot = "6")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D4FE80", Offset = "0x2D4F280", VA = "0x182D4FE80", Slot = "7")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D4FAA0", Offset = "0x2D4EEA0", VA = "0x182D4FAA0", Slot = "8")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D4FA00", Offset = "0x2D4EE00", VA = "0x182D4FA00")]
	private void EONPIEEJHFP(GPEJGMHBDPO GBPGPLEPLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D4FDC0", Offset = "0x2D4F1C0", VA = "0x182D4FDC0", Slot = "4")]
	public bool HLPJCPMPMOI(IJDKBBDMEBI DGPLFECNDCD, BPHAMHGLCNC MLIELKFMALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D4FB50", Offset = "0x2D4EF50", VA = "0x182D4FB50", Slot = "5")]
	public void HGONIOHMEBK(IJDKBBDMEBI DGPLFECNDCD, Span<BPHAMHGLCNC> ICBILMELIDM, bool MDCMJGBFODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F8F0", Offset = "0x2D4ECF0", VA = "0x182D4F8F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D4FF00", Offset = "0x2D4F300", VA = "0x182D4FF00")]
	public CJDHLCELCED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class COCONAMFLJM
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D502B0", Offset = "0x2D4F6B0", VA = "0x182D502B0")]
	public static void ECIBCLFFOMM(this IDNDLGCBDKF AKJDPBEAJPA, ReadOnlyMemory<byte> AODPABKGGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x2318F80", Offset = "0x2318380", VA = "0x182318F80")]
	public static void ACBIDAJPHGD<T>(this IDNDLGCBDKF AKJDPBEAJPA, in T KPPLMEOMNGF) where T : struct, KHHHMANHCMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x23190B0", Offset = "0x23184B0", VA = "0x1823190B0")]
	public static T JNAOCBCMBGH<T>(this IDNDLGCBDKF AKJDPBEAJPA) where T : struct, KHHHMANHCMP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D50160", Offset = "0x2D4F560", VA = "0x182D50160")]
	public static void ACBIDAJPHGD(this IDNDLGCBDKF AKJDPBEAJPA, FFBLPEHDKDF PDAMOLAHIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D504E0", Offset = "0x2D4F8E0", VA = "0x182D504E0")]
	public static FFBLPEHDKDF NJOCBGFKEDD(this IDNDLGCBDKF AKJDPBEAJPA)
	{
		return default(FFBLPEHDKDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D50330", Offset = "0x2D4F730", VA = "0x182D50330")]
	public static void NECHCDBGEDF(this IDNDLGCBDKF BBPDLFOHCNG, uint NJEPIMFKKCO, bool AKPBIFOOPJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D50190", Offset = "0x2D4F590", VA = "0x182D50190")]
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
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public FJGDBPGDLIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1840", Offset = "0x2AB0C40", VA = "0x182AB1840")]
		internal void <GetByteEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB18B0", Offset = "0x2AB0CB0", VA = "0x182AB18B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public HGLHKHONFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2757730", Offset = "0x2756B30", VA = "0x182757730")]
		internal void <GetSByteEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x27577A0", Offset = "0x2756BA0", VA = "0x1827577A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public NPMNAFAMPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x37BDF20", Offset = "0x37BD320", VA = "0x1837BDF20")]
		internal void <GetShortEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x37BDF90", Offset = "0x37BD390", VA = "0x1837BDF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public JDDGIGFNCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x316E740", Offset = "0x316DB40", VA = "0x18316E740")]
		internal void <GetUShortEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x316E7B0", Offset = "0x316DBB0", VA = "0x18316E7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public GFEEIIIJGNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x3183C20", Offset = "0x3183020", VA = "0x183183C20")]
		internal void <GetIntEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x3183C80", Offset = "0x3183080", VA = "0x183183C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public GFEKPPGEEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x3183CD0", Offset = "0x31830D0", VA = "0x183183CD0")]
		internal void <GetUIntEnumDelegates>b__0(IDNDLGCBDKF b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x3183D30", Offset = "0x3183130", VA = "0x183183D30")]
		internal T <GetUIntEnumDelegates>b__1(IDNDLGCBDKF b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x22DDF00", Offset = "0x22DD300", VA = "0x1822DDF00")]
	public static void GFAAFAFPCPB<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x22DE120", Offset = "0x22DD520", VA = "0x1822DE120")]
	private static void OECGCPDEKOE<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x22DE120", Offset = "0x22DD520", VA = "0x1822DE120")]
	private static void HFKKMOPOLOK<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x22DDDB0", Offset = "0x22DD1B0", VA = "0x1822DDDB0")]
	private static void EBDLODACFAH<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x22DDDB0", Offset = "0x22DD1B0", VA = "0x1822DDDB0")]
	private static void LIMMMCDOHMA<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x22DDC60", Offset = "0x22DD060", VA = "0x1822DDC60")]
	private static void FHNHHCMHCAC<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x22DDC60", Offset = "0x22DD060", VA = "0x1822DDC60")]
	private static void CPABNGLBGFI<T>(T EKDCKLAKFJN, T IBFPNBPAEOD, out global::DFPNLGKLLNI<T> FEDPBKDJHFP, out global::NIMGDENJGPM<T> NKFDHCIAIEO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class IENBFKHMMCN : OMMIJKDJINI, PFFHIJLFPMD
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x311F300", Offset = "0x311E700", VA = "0x18311F300", Slot = "4")]
	private void FOJNOIOPKLP(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void MIFGDNDEHIK(DHPMLHOBOOK ICBILMELIDM);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
	protected IENBFKHMMCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[INBKPPOJOGA(typeof(LocalPoseData))]
public sealed class JACAEMOPGKD : IENBFKHMMCN
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x31209E0", Offset = "0x311FDE0", VA = "0x1831209E0", Slot = "5")]
	protected override void MIFGDNDEHIK(DHPMLHOBOOK ICBILMELIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D58AF0", Offset = "0x2D57EF0", VA = "0x182D58AF0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2D58E50", Offset = "0x2D58250", VA = "0x182D58E50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2D58FD0", Offset = "0x2D583D0", VA = "0x182D58FD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2D58FA0", Offset = "0x2D583A0", VA = "0x182D58FA0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2D58330", Offset = "0x2D57730", VA = "0x182D58330")]
		private void BPPGOHFOFEO(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2D58950", Offset = "0x2D57D50", VA = "0x182D58950")]
		private void IOMLEDCABAI(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2D58670", Offset = "0x2D57A70", VA = "0x182D58670")]
		private void CKPIOEECHMJ(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2D58180", Offset = "0x2D57580", VA = "0x182D58180")]
		private void BLHNLGEPKMO(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2D58C40", Offset = "0x2D58040", VA = "0x182D58C40")]
		private void OEFHCCMBDEC(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2D58B60", Offset = "0x2D57F60", VA = "0x182D58B60")]
		private void MKNCGIBNGGA(GPEJGMHBDPO GBPGPLEPLBP, int HIFBLLMBEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D626A0", Offset = "0x2D61AA0", VA = "0x182D626A0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2D62CD0", Offset = "0x2D620D0", VA = "0x182D62CD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2D62D90", Offset = "0x2D62190", VA = "0x182D62D90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2D626F0", Offset = "0x2D61AF0", VA = "0x182D626F0")]
	private void OKFFABCDFPB(NativeArray<Entity> GMAMPIGCEAB, NativeList<Entity> MAGLBLOKDFO, ComponentDataFromEntity<PJEFIJNLAOI> DJJOBGKBOLN, BufferFromEntity<ChildrenData> CGNJHCJMHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public EPDCKAODPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class PAGEBCNLPIB : ParentSystemBase<AuthoredParentData, OFFHECIKBLF, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2B56090", Offset = "0x2B55490", VA = "0x182B56090", Slot = "14")]
	protected override EntityQueryDesc ADAALLKIPAL(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x78B6D0", Offset = "0x78AAD0", VA = "0x18078B6D0", Slot = "15")]
	protected override EntityQueryDesc DMEIABLFLEH(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2B560D0", Offset = "0x2B554D0", VA = "0x182B560D0", Slot = "16")]
	protected override EntityQueryDesc KPMCEEDGEPG(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x2B56050", Offset = "0x2B55450", VA = "0x182B56050", Slot = "17")]
	protected override EntityQueryDesc ACCGLGMDDKF(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x2B56150", Offset = "0x2B55550", VA = "0x182B56150")]
	public PAGEBCNLPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2B56110", Offset = "0x2B55510", VA = "0x182B56110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3120290", Offset = "0x311F690", VA = "0x183120290", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x3120310", Offset = "0x311F710", VA = "0x183120310", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x31203B0", Offset = "0x311F7B0", VA = "0x1831203B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public IOPPJNEEHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B47790", Offset = "0x2B46B90", VA = "0x182B47790", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2B47810", Offset = "0x2B46C10", VA = "0x182B47810", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2B478B0", Offset = "0x2B46CB0", VA = "0x182B478B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public NNJNDLKLICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3115170", Offset = "0x3114570", VA = "0x183115170", Slot = "4")]
	public bool Equals(JPGEHKBMENC JHMCLPBFJBC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE20", Offset = "0x7FE220", VA = "0x1807FEE20")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FEE20", Offset = "0x7FE220", VA = "0x1807FEE20")]
	public static KJDKPBCMHHG HEFILGHKDEM(FOLAJHLHGHC BDCLOJHOMDK)
	{
		return default(KJDKPBCMHHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class OJPBPMICBGP : AAANMICNOEB
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x2B47B30", Offset = "0x2B46F30", VA = "0x182B47B30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2B47CC0", Offset = "0x2B470C0", VA = "0x182B47CC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x2B41DA0", Offset = "0x2B411A0", VA = "0x182B41DA0")]
	protected OJPBPMICBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D44280", Offset = "0x2D43680", VA = "0x182D44280", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x2D442F0", Offset = "0x2D436F0", VA = "0x182D442F0")]
	protected void KCKIJJMDLHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x2D43F90", Offset = "0x2D43390", VA = "0x182D43F90")]
	protected void HNBINKBJCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x2D44210", Offset = "0x2D43610", VA = "0x182D44210")]
	protected LNMIPKFIEGC IKMNJMMAFKM()
	{
		return default(LNMIPKFIEGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	protected AAANMICNOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class KABFGNEFJKH : AAANMICNOEB
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x3123570", Offset = "0x3122970", VA = "0x183123570", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x3123700", Offset = "0x3122B00", VA = "0x183123700", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2B41DA0", Offset = "0x2B411A0", VA = "0x182B41DA0")]
	protected KABFGNEFJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class JJGPOFFPHGA : AAANMICNOEB
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x3121CA0", Offset = "0x31210A0", VA = "0x183121CA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x3121DB0", Offset = "0x31211B0", VA = "0x183121DB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x2B41DA0", Offset = "0x2B411A0", VA = "0x182B41DA0")]
	protected JJGPOFFPHGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B41D30", Offset = "0x2B41130", VA = "0x182B41D30", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2B41DA0", Offset = "0x2B411A0", VA = "0x182B41DA0")]
	public MBFNDBILOHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3F4D0", Offset = "0x2B3E8D0", VA = "0x182B3F4D0", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F540", Offset = "0x2B3E940", VA = "0x182B3F540")]
	public LGMKIIIENBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B44180", Offset = "0x2B43580", VA = "0x182B44180", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F540", Offset = "0x2B3E940", VA = "0x182B3F540")]
	public NBDMNJBAIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D47BD0", Offset = "0x2D46FD0", VA = "0x182D47BD0", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F540", Offset = "0x2B3E940", VA = "0x182B3F540")]
	public AKFFNGCIKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3120630", Offset = "0x311FA30", VA = "0x183120630", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x2B41DA0", Offset = "0x2B411A0", VA = "0x182B41DA0")]
	public IPBGIFKKPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B41F40", Offset = "0x2B41340", VA = "0x182B41F40", Slot = "15")]
		get
		{
			return default(DMBFIJFHJEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F540", Offset = "0x2B3E940", VA = "0x182B3F540")]
	public MDGFCFDNKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D5EE50", Offset = "0x2D5E250", VA = "0x182D5EE50")]
	public DMBFIJFHJEL(ComponentType EKKJDILLMHE, ComponentType IJHBCFMOMGF, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x22FAE50", Offset = "0x22FA250", VA = "0x1822FAE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x791DB0", Offset = "0x7911B0", VA = "0x180791DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int CONDCHODOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9550", Offset = "0x8A8950", VA = "0x1808A9550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xE9C130", Offset = "0xE9B530", VA = "0x180E9C130", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x31151C0", Offset = "0x31145C0", VA = "0x1831151C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x3115170", Offset = "0x3114570", VA = "0x183115170", Slot = "8")]
	public bool Equals(FOLAJHLHGHC JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x3115200", Offset = "0x3114600", VA = "0x183115200", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B4C10", Offset = "0x41B4010", VA = "0x1841B4C10")]
			public CANIDKBJIKJ(FOLAJHLHGHC BDCLOJHOMDK, float3 MIFJBHLKJIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x41B4BF0", Offset = "0x41B3FF0", VA = "0x1841B4BF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
			public FGBDKLPAKFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
			public KIHKNOENEBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
			public FNKBIOBMAFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
				[Cpp2IlInjected.Address(RVA = "0x41B3460", Offset = "0x41B2860", VA = "0x1841B3460")]
				public void LICMABLNMJG(UpdateConnectableVisuals JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x41B33A0", Offset = "0x41B27A0", VA = "0x1841B33A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B5B40", Offset = "0x41B4F40", VA = "0x1841B5B40")]
			internal void OCIBIOHOPKH(Entity PJEENOLDJIO, WorldPoseData FJNMJJIHMCM, in DynamicBuffer<KJDKPBCMHHG> KFCHBPFAEMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x41B5D80", Offset = "0x41B5180", VA = "0x1841B5D80", Slot = "5")]
			public void ReadFromDisplayClass(ref FGBDKLPAKFD BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x41B5DB0", Offset = "0x41B51B0", VA = "0x1841B5DB0", Slot = "6")]
			public void WriteToDisplayClass(ref FGBDKLPAKFD BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x41B5870", Offset = "0x41B4C70", VA = "0x1841B5870", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x41B59C0", Offset = "0x41B4DC0", VA = "0x1841B59C0")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref AFCBAGFKMJL.DOEMCLCFJIK KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x41B5B00", Offset = "0x41B4F00", VA = "0x1841B5B00")]
			public void LICMABLNMJG(UpdateConnectableVisuals JFLOFOFLJIH, ref FGBDKLPAKFD BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x41B5950", Offset = "0x41B4D50", VA = "0x1841B5950")]
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
				[Cpp2IlInjected.Address(RVA = "0x41B7E50", Offset = "0x41B7250", VA = "0x1841B7E50")]
				public void LICMABLNMJG(UpdateConnectableVisuals JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x41B7DB0", Offset = "0x41B71B0", VA = "0x1841B7DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BB6C0", Offset = "0x41BAAC0", VA = "0x1841BB6C0")]
			internal void OCIBIOHOPKH(in WorldPoseData FJNMJJIHMCM, in DynamicBuffer<JPGEHKBMENC> KFCHBPFAEMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x1310140", Offset = "0x130F540", VA = "0x181310140", Slot = "5")]
			public void ReadFromDisplayClass(ref KIHKNOENEBK BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x41BB480", Offset = "0x41BA880", VA = "0x1841BB480", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x41BB550", Offset = "0x41BA950", VA = "0x1841BB550")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref HJMLEKCMIEJ.JDPJPDPLNEA KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x41BB620", Offset = "0x41BAA20", VA = "0x1841BB620")]
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
				[Cpp2IlInjected.Address(RVA = "0x41B72F0", Offset = "0x41B66F0", VA = "0x1841B72F0")]
				public void LICMABLNMJG(UpdateConnectableVisuals JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x41B7220", Offset = "0x41B6620", VA = "0x1841B7220")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BB9B0", Offset = "0x41BADB0", VA = "0x1841BB9B0")]
			internal void OCIBIOHOPKH(in WorldPoseData FJNMJJIHMCM, in MFOFDKAGJEK LCBCIHMHDMO, in DynamicBuffer<JPGEHKBMENC> KFCHBPFAEMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x1310140", Offset = "0x130F540", VA = "0x181310140", Slot = "5")]
			public void ReadFromDisplayClass(ref FNKBIOBMAFE BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x41BB7D0", Offset = "0x41BABD0", VA = "0x1841BB7D0", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x41BB850", Offset = "0x41BAC50", VA = "0x1841BB850")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref FNNDAOCMNLJ.NHHMHCEKBBE KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x41BB970", Offset = "0x41BAD70", VA = "0x1841BB970")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CEA3F0", Offset = "0x2CE97F0", VA = "0x182CEA3F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7320", Offset = "0x2CE6720", VA = "0x182CE7320")]
		internal HCEFJNDGODN ABEGHGNHLLG(FOLAJHLHGHC BDCLOJHOMDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9640", Offset = "0x2CE8A40", VA = "0x182CE9640", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2CEAF30", Offset = "0x2CEA330", VA = "0x182CEAF30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB1B0", Offset = "0x2CEA5B0", VA = "0x182CEB1B0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB340", Offset = "0x2CEA740", VA = "0x182CEB340", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB170", Offset = "0x2CEA570", VA = "0x182CEB170", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9700", Offset = "0x2CE8B00", VA = "0x182CE9700")]
		private void KHCHPGBLLJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9ED0", Offset = "0x2CE92D0", VA = "0x182CE9ED0")]
		private void LMNELOPMGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA430", Offset = "0x2CE9830", VA = "0x182CEA430")]
		private void NJNNKHOFNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB380", Offset = "0x2CEA780", VA = "0x182CEB380", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9030", Offset = "0x2CE8430", VA = "0x182CE9030")]
		private void HMNCABBCMFO(EntityQuery BPIFFIIDDIC, EntityQuery CHENOCAGDJL, EntityQuery BDNJLMMMHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB710", Offset = "0x2CEAB10", VA = "0x182CEB710")]
		private void PMMODKPOELK(EntityQuery BDNJLMMMHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7CE0", Offset = "0x2CE70E0", VA = "0x182CE7CE0")]
		private void EMPBDBOHOJD(NativeArrayAsync<Entity> EHIBMPOCMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7870", Offset = "0x2CE6C70", VA = "0x182CE7870")]
		private void DBFNCNGHHLH(NativeArrayAsync<Entity> AOOECIAPIFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9D30", Offset = "0x2CE9130", VA = "0x182CE9D30")]
		private void KNMFBANLOEO(NativeArrayAsync<Entity> DGEDLENHJLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7B10", Offset = "0x2CE6F10", VA = "0x182CE7B10")]
		private void DIFDLCGIOKG(NativeList<FOLAJHLHGHC> ODBCMMPFKLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2CE84F0", Offset = "0x2CE78F0", VA = "0x182CE84F0")]
		private NativeList<FOLAJHLHGHC> HBIPEEDJJPM(NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(NativeList<FOLAJHLHGHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8A10", Offset = "0x2CE7E10", VA = "0x182CE8A10")]
		private void HCNELJHHOCL(NativeArray<Entity> GMAMPIGCEAB, NativeList<FOLAJHLHGHC> ODBCMMPFKLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7FC0", Offset = "0x2CE73C0", VA = "0x182CE7FC0")]
		private void GNMACPHGKGL(NativeArray<Entity> DKDJJFDGEMD, NativeArray<Entity> KENGEDAIJDB, NativeList<FOLAJHLHGHC> JAJAJEGKILP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA7E0", Offset = "0x2CE9BE0", VA = "0x182CEA7E0")]
		private void NLIEPODEPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2CEAC90", Offset = "0x2CEA090", VA = "0x182CEAC90")]
		private NativeListAsync<CANIDKBJIKJ> OINFMJJBMBM(EntityQuery APEJLGJADFF, Func<NativeList<CANIDKBJIKJ>, JobHandle> HNCEEGILEGK)
		{
			return default(NativeListAsync<CANIDKBJIKJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7980", Offset = "0x2CE6D80", VA = "0x182CE7980")]
		private JobHandle DCGOMBPNMLI(NativeList<CANIDKBJIKJ> EHJGMBFBLBN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7530", Offset = "0x2CE6930", VA = "0x182CE7530")]
		private JobHandle ALDKLBELIJL(NativeList<CANIDKBJIKJ> EHJGMBFBLBN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9510", Offset = "0x2CE8910", VA = "0x182CE9510")]
		private JobHandle IOHAOBDMMAF(NativeList<CANIDKBJIKJ> EHJGMBFBLBN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9810", Offset = "0x2CE8C10", VA = "0x182CE9810")]
		private void KHKNGDAHBAE(NativeListAsync<CANIDKBJIKJ> EHJGMBFBLBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9AA0", Offset = "0x2CE8EA0", VA = "0x182CE9AA0")]
		private void KLFGBFBPNLA(NativeListAsync<CANIDKBJIKJ> EHJGMBFBLBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7C80", Offset = "0x2CE7080", VA = "0x182CE7C80")]
		private bool EGCLNNMCELP(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA320", Offset = "0x2CE9720", VA = "0x182CEA320")]
		private NativeArray<Entity> MPCMNLGDDHP(Entity PJEENOLDJIO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7370", Offset = "0x2CE6770", VA = "0x182CE7370")]
		private FOLAJHLHGHC ADHBPIGNGAG(NativeList<FOLAJHLHGHC> JAJAJEGKILP)
		{
			return default(FOLAJHLHGHC);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA020", Offset = "0x2CE9420", VA = "0x182CEA020")]
		private void LPDECKMEDNA(FOLAJHLHGHC BDCLOJHOMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2CEADD0", Offset = "0x2CEA1D0", VA = "0x182CEADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7670", Offset = "0x2CE6A70", VA = "0x182CE7670")]
		public static EntityQuery BJGIDNABIMI(ComponentSystemBase JFLOFOFLJIH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB4B0", Offset = "0x2CEA8B0", VA = "0x182CEB4B0")]
		public static EntityQuery PDBMCDDIDCA(ComponentSystemBase JFLOFOFLJIH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2CEA0B0", Offset = "0x2CE94B0", VA = "0x182CEA0B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5BC60", Offset = "0x2B5B060", VA = "0x182B5BC60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BBD0", Offset = "0x2B5AFD0", VA = "0x182B5BBD0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BD60", Offset = "0x2B5B160", VA = "0x182B5BD60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public EBGGPCADDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
	public EBGGPCADDGJ(EMAJLAJEHKH AIJDONAKHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x2D602F0", Offset = "0x2D5F6F0", VA = "0x182D602F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D4C200", Offset = "0x2D4B600", VA = "0x182D4C200", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C260", Offset = "0x2D4B660", VA = "0x182D4C260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C290", Offset = "0x2D4B690", VA = "0x182D4C290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	protected BOBDGHNGPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x31231B0", Offset = "0x31225B0", VA = "0x1831231B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int DKCGFGMKLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x3122F00", Offset = "0x3122300", VA = "0x183122F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x3122F30", Offset = "0x3122330", VA = "0x183122F30", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x31231C0", Offset = "0x31225C0", VA = "0x1831231C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x31233C0", Offset = "0x31227C0", VA = "0x1831233C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x3122E80", Offset = "0x3122280", VA = "0x183122E80")]
	public int CLEDONPNABJ(SceneTag JLPOKIGCHBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x3122F10", Offset = "0x3122310", VA = "0x183122F10")]
	public int GHLJGKCNJAI(SceneTag JLPOKIGCHBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x3122C60", Offset = "0x3122060", VA = "0x183122C60")]
	protected void BOIFAPGKPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x31233E0", Offset = "0x31227E0", VA = "0x1831233E0")]
	protected void PMDABOOEHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x3123050", Offset = "0x3122450", VA = "0x183123050")]
	public NativeArrayAsync<Entity> LDCFNAIPDIB(SceneTag JLPOKIGCHBG, Allocator GOLNHBOGNGC = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x3122F90", Offset = "0x3122390", VA = "0x183122F90")]
	public NativeArrayAsync<Entity> KBOJEPFPNKN(SceneTag JLPOKIGCHBG, Allocator GOLNHBOGNGC = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x3122BD0", Offset = "0x3121FD0", VA = "0x183122BD0")]
	public bool AFOEKCKEOCB(SceneTag JLPOKIGCHBG, out NativeArrayAsync<Entity> AIJDONAKHON, Allocator GOLNHBOGNGC = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x3122EA0", Offset = "0x31222A0", VA = "0x183122EA0")]
	public bool CPIAGHNENJJ(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x31230E0", Offset = "0x31224E0", VA = "0x1831230E0")]
	public EMAJLAJEHKH MAONNFPMIBI(Entity PJEENOLDJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x3122FE0", Offset = "0x31223E0", VA = "0x183122FE0")]
	public bool KLLNBFNLACK(Entity PJEENOLDJIO, out EBGGPCADDGJ AIJDONAKHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x31230A0", Offset = "0x31224A0", VA = "0x1831230A0")]
	public void LDHHNPPIDMN(Entity PJEENOLDJIO, EBGGPCADDGJ AIJDONAKHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x3123150", Offset = "0x3122550", VA = "0x183123150")]
	public bool ODEOGIOICML(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void LCHFPPHLBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public JOPEEOLALKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D47EE0", Offset = "0x2D472E0", VA = "0x182D47EE0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2D47FA0", Offset = "0x2D473A0", VA = "0x182D47FA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2D48060", Offset = "0x2D47460", VA = "0x182D48060", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC2A0", Offset = "0x2BAB6A0", VA = "0x182BAC2A0")]
	private bool JMGKGIGAGKI<TComponentData>(EntityQuery APEJLGJADFF, out NativeArray<Entity> GMAMPIGCEAB, out NativeArray<TComponentData> MDPFJMFBAOK) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D47F30", Offset = "0x2D47330", VA = "0x182D47F30")]
	public EMAJLAJEHKH MAONNFPMIBI(Entity PJEENOLDJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public ANBBCJHLCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CDCB80", Offset = "0x2CDBF80", VA = "0x182CDCB80", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCBD0", Offset = "0x2CDBFD0", VA = "0x182CDCBD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCE00", Offset = "0x2CDC200", VA = "0x182CDCE00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC7B0", Offset = "0x2CDBBB0", VA = "0x182CDC7B0")]
		private void GBJBCHALJOG(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCF30", Offset = "0x2CDC330", VA = "0x182CDCF30")]
		private void PMMODKPOELK(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCD90", Offset = "0x2CDC190", VA = "0x182CDCD90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC820", Offset = "0x2CDBC20", VA = "0x182CDC820")]
		private void HKIAPADCEBA(EntityQuery APEJLGJADFF, bool HAAPPAEMABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		public PPKJHCCEPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BB160", Offset = "0x41BA560", VA = "0x1841BB160")]
			public void LICMABLNMJG(GCJOGLOLCBD JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x41BB0A0", Offset = "0x41BA4A0", VA = "0x1841BB0A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x41BE810", Offset = "0x41BDC10", VA = "0x1841BE810")]
		internal void OCIBIOHOPKH(Entity JMFCHNOMKAM, SplineShapeData BJBDNHBIPAI, DynamicBuffer<LinkedEntityGroup> BFNDINBALAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x41BE610", Offset = "0x41BDA10", VA = "0x1841BE610", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x41BE6E0", Offset = "0x41BDAE0", VA = "0x1841BE6E0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref LCLLEOELAFF.EIFBICKMEGN KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x41BE800", Offset = "0x41BDC00", VA = "0x1841BE800")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BA510", Offset = "0x41B9910", VA = "0x1841BA510")]
			public void LICMABLNMJG(GCJOGLOLCBD JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x41BA490", Offset = "0x41B9890", VA = "0x1841BA490")]
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
		[Cpp2IlInjected.Address(RVA = "0x41BEA50", Offset = "0x41BDE50", VA = "0x1841BEA50")]
		internal void OCIBIOHOPKH(Entity ODIEOJHEKBE, SplinePointParentData EIALPBJMENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x41BEAE0", Offset = "0x41BDEE0", VA = "0x1841BEAE0", Slot = "5")]
		public void ReadFromDisplayClass(ref PPKJHCCEPLC BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x41BE870", Offset = "0x41BDC70", VA = "0x1841BE870", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x41BE910", Offset = "0x41BDD10", VA = "0x1841BE910")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref KHFFANINBGC.JIECIMAGGIK KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x41BE9C0", Offset = "0x41BDDC0", VA = "0x1841BE9C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3117D70", Offset = "0x3117170", VA = "0x183117D70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x3117E20", Offset = "0x3117220", VA = "0x183117E20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public GCJOGLOLCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x3117AD0", Offset = "0x3116ED0", VA = "0x183117AD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x31177D0", Offset = "0x3116BD0", VA = "0x1831177D0")]
	public static EntityQuery BIIJLNAHEEL(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x3117970", Offset = "0x3116D70", VA = "0x183117970")]
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
	[Cpp2IlInjected.Address(RVA = "0x311A5F0", Offset = "0x31199F0", VA = "0x18311A5F0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x311A650", Offset = "0x3119A50", VA = "0x18311A650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public HBFOEJBCPJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		public HMEENMEPIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, CEDELNEJEJO previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B8900", Offset = "0x41B7D00", VA = "0x1841B8900")]
			public void LICMABLNMJG(CGBHHPHCONE JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x41B8880", Offset = "0x41B7C80", VA = "0x1841B8880")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD21C0", Offset = "0x2CD15C0", VA = "0x182CD21C0")]
		internal void OCIBIOHOPKH(Entity PJEENOLDJIO, ParentData IMFNGEBEPMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x1310140", Offset = "0x130F540", VA = "0x181310140", Slot = "5")]
		public void ReadFromDisplayClass(ref HMEENMEPIMH BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2060", Offset = "0x2CD1460", VA = "0x182CD2060", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x2CD20D0", Offset = "0x2CD14D0", VA = "0x182CD20D0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref IHPPCKNIIDJ.INHMMFLPHNL KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2180", Offset = "0x2CD1580", VA = "0x182CD2180")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B7640", Offset = "0x41B6A40", VA = "0x1841B7640")]
			public void LICMABLNMJG(CGBHHPHCONE JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x41B75A0", Offset = "0x41B69A0", VA = "0x1841B75A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD5030", Offset = "0x2CD4430", VA = "0x182CD5030")]
		internal void OCIBIOHOPKH(Entity PJEENOLDJIO, ParentData IMFNGEBEPMB, CEDELNEJEJO KCDBOIAJNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2CD50F0", Offset = "0x2CD44F0", VA = "0x182CD50F0", Slot = "5")]
		public void ReadFromDisplayClass(ref HMEENMEPIMH BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2CD4EA0", Offset = "0x2CD42A0", VA = "0x182CD4EA0", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2CD4F10", Offset = "0x2CD4310", VA = "0x182CD4F10")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref GEIJKKPACAG.OAABMHIJDFB KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x2CD4FF0", Offset = "0x2CD43F0", VA = "0x182CD4FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B5620", Offset = "0x41B4A20", VA = "0x1841B5620")]
			public void LICMABLNMJG(CGBHHPHCONE JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x41B55A0", Offset = "0x41B49A0", VA = "0x1841B55A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD1FD0", Offset = "0x2CD13D0", VA = "0x182CD1FD0")]
		internal void OCIBIOHOPKH(Entity PJEENOLDJIO, CEDELNEJEJO KCDBOIAJNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2050", Offset = "0x2CD1450", VA = "0x182CD2050", Slot = "5")]
		public void ReadFromDisplayClass(ref HMEENMEPIMH BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2CD1E70", Offset = "0x2CD1270", VA = "0x182CD1E70", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2CD1EE0", Offset = "0x2CD12E0", VA = "0x182CD1EE0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref CELEOFPKKPD.PCFBFNDKKOL KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2CD1F90", Offset = "0x2CD1390", VA = "0x182CD1F90")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D4F1B0", Offset = "0x2D4E5B0", VA = "0x182D4F1B0", Slot = "14")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F520", Offset = "0x2D4E920", VA = "0x182D4F520", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public CGBHHPHCONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F4C0", Offset = "0x2D4E8C0", VA = "0x182D4F4C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x2D4ED50", Offset = "0x2D4E150", VA = "0x182D4ED50")]
	public static EntityQuery BBHAJCMHJBK(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F290", Offset = "0x2D4E690", VA = "0x182D4F290")]
	public static EntityQuery LOGOANOEIEB(ComponentSystemBase JFLOFOFLJIH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D4EFB0", Offset = "0x2D4E3B0", VA = "0x182D4EFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3120710", Offset = "0x311FB10", VA = "0x183120710", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x31206A0", Offset = "0x311FAA0", VA = "0x1831206A0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x31207A0", Offset = "0x311FBA0", VA = "0x1831207A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class MHEHMPGEHBA : ParentSystemBase<ParentData, CEDELNEJEJO, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x2B42430", Offset = "0x2B41830", VA = "0x182B42430", Slot = "14")]
	protected override EntityQueryDesc ADAALLKIPAL(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x78B6D0", Offset = "0x78AAD0", VA = "0x18078B6D0", Slot = "15")]
	protected override EntityQueryDesc DMEIABLFLEH(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x2B42470", Offset = "0x2B41870", VA = "0x182B42470", Slot = "16")]
	protected override EntityQueryDesc KPMCEEDGEPG(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x2B423F0", Offset = "0x2B417F0", VA = "0x182B423F0", Slot = "17")]
	protected override EntityQueryDesc ACCGLGMDDKF(EntityQueryDesc APEJLGJADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x2B424F0", Offset = "0x2B418F0", VA = "0x182B424F0")]
	public MHEHMPGEHBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x2B424B0", Offset = "0x2B418B0", VA = "0x182B424B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2862020", Offset = "0x2861420", VA = "0x182862020", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x35C90E0", Offset = "0x35C84E0", VA = "0x1835C90E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1F7ED60", Offset = "0x1F7E160", VA = "0x181F7ED60")]
			private int BCMGAFLLCEJ(DynamicBuffer<ChildrenData> DJHPOGLHKJI, Entity PJEENOLDJIO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x1F7F4F0", Offset = "0x1F7E8F0", VA = "0x181F7F4F0")]
			private void PKOGDGKDNAA(Entity OKMBLMILFGG, DynamicBuffer<ChildrenData> DJHPOGLHKJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x1F7F130", Offset = "0x1F7E530", VA = "0x181F7F130")]
			private void HFCPKGNPHGM(Entity OKMBLMILFGG, DynamicBuffer<ChildrenData> DJHPOGLHKJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x1F7EFD0", Offset = "0x1F7E3D0", VA = "0x181F7EFD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2753F80", Offset = "0x2753380", VA = "0x182753F80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C7380", Offset = "0x28C6780", VA = "0x1828C7380")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x28C5390", Offset = "0x28C4790", VA = "0x1828C5390")]
		private int BCMGAFLLCEJ(DynamicBuffer<ChildrenData> DJHPOGLHKJI, Entity PJEENOLDJIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x28C6AB0", Offset = "0x28C5EB0", VA = "0x1828C6AB0")]
		private void NFHEJFHDAHL(Entity GJDECBBPLAI, Entity IDJGDIEPILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x78B6D0", Offset = "0x78AAD0", VA = "0x18078B6D0", Slot = "14")]
		protected virtual EntityQueryDesc ADAALLKIPAL(EntityQueryDesc APEJLGJADFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x78B6D0", Offset = "0x78AAD0", VA = "0x18078B6D0", Slot = "15")]
		protected virtual EntityQueryDesc DMEIABLFLEH(EntityQueryDesc APEJLGJADFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x78B6D0", Offset = "0x78AAD0", VA = "0x18078B6D0", Slot = "16")]
		protected virtual EntityQueryDesc KPMCEEDGEPG(EntityQueryDesc APEJLGJADFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc ACCGLGMDDKF(EntityQueryDesc APEJLGJADFF);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x28C7010", Offset = "0x28C6410", VA = "0x1828C7010", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x28C6590", Offset = "0x28C5990", VA = "0x1828C6590")]
		private void HEBEMMNGPBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x28C68F0", Offset = "0x28C5CF0", VA = "0x1828C68F0")]
		private void KELPDGDADFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x28C5B30", Offset = "0x28C4F30", VA = "0x1828C5B30")]
		private JobHandle GFMBNHDDEGH(JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x28C5850", Offset = "0x28C4C50", VA = "0x1828C5850")]
		private void CDBMMMMAPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x28C72B0", Offset = "0x28C66B0", VA = "0x1828C72B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x276EC60", Offset = "0x276E060", VA = "0x18276EC60", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x14FF8B0", Offset = "0x14FECB0", VA = "0x1814FF8B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD26A0", Offset = "0x2CD1AA0", VA = "0x182CD26A0")]
		public GADGPAJFCKD(NativeList<Entity> CMKIJDLHCPJ, NativeList<Entity> FJDBOOKELJF, JobHandle DGGOEPGELHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2620", Offset = "0x2CD1A20", VA = "0x182CD2620")]
		public JobHandle HHNDJHENABI(JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2590", Offset = "0x2CD1990", VA = "0x182CD2590", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD39F0", Offset = "0x2CD2DF0", VA = "0x182CD39F0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x2CD41B0", Offset = "0x2CD35B0", VA = "0x182CD41B0")]
		private void NLIEMFCMBNK(Entity PJEENOLDJIO, bool DJLCOHNAEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3B80", Offset = "0x2CD2F80", VA = "0x182CD3B80")]
		private void FLJNJLIEKLI(Entity PJEENOLDJIO, bool DJLCOHNAEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x2CD4050", Offset = "0x2CD3450", VA = "0x182CD4050")]
		public GADGPAJFCKD MMNMKFJHIAB(NativeArray<Entity> NKLDGGPGPDP, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3FD0", Offset = "0x2CD33D0", VA = "0x182CD3FD0")]
		public GADGPAJFCKD LHIJGDGHKEE(NativeArray<Entity> NKLDGGPGPDP, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3EF0", Offset = "0x2CD32F0", VA = "0x182CD3EF0")]
		public GADGPAJFCKD KJOIMKJFHNC(NativeList<EJDOAJBNLAC> EHJGMBFBLBN, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x2CD4240", Offset = "0x2CD3640", VA = "0x182CD4240")]
		public GADGPAJFCKD ODJODPEDHNB(NativeList<EJDOAJBNLAC> EHJGMBFBLBN, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x2CD40D0", Offset = "0x2CD34D0", VA = "0x182CD40D0")]
		public GADGPAJFCKD NGJOOGCPOPK(NativeList<DFLCMAHAHIM> EHJGMBFBLBN, JobHandle OFHDPBCPCFP)
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x2A85E10", Offset = "0x2A85210", VA = "0x182A85E10")]
		private GADGPAJFCKD GEHHGFMIJEJ<T>(NativeList<T> EHJGMBFBLBN, int IBMHHJLNPFA, int EHNCJMOMENA, HBJOHDNGEOA COAEGBJAHMB, JobHandle OFHDPBCPCFP) where T : struct
		{
			return default(GADGPAJFCKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3C90", Offset = "0x2CD3090", VA = "0x182CD3C90")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D5DD80", Offset = "0x2D5D180", VA = "0x182D5DD80")]
	protected DDKJOGCAJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C690", Offset = "0x2D5BA90", VA = "0x182D5C690", Slot = "14")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2D5CCE0", Offset = "0x2D5C0E0", VA = "0x182D5CCE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2D5CF10", Offset = "0x2D5C310", VA = "0x182D5CF10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x80AAA0", Offset = "0x809EA0", VA = "0x18080AAA0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2D5CC80", Offset = "0x2D5C080", VA = "0x182D5CC80")]
	private void NHJFEKPEAEB(NativeArray<Entity> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C5F0", Offset = "0x2D5B9F0", VA = "0x182D5C5F0")]
	private void AFMLGMIHFOF(NativeArray<Entity> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2D5CA30", Offset = "0x2D5BE30", VA = "0x182D5CA30")]
	private void LNLDDMCLLPN(GADGPAJFCKD KIEIMPAHGJC, string PBDBHLLHLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2D5CB70", Offset = "0x2D5BF70", VA = "0x182D5CB70")]
	private void LNLDDMCLLPN(NativeListAsync<Entity> KCMICKABOHN, string PBDBHLLHLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C770", Offset = "0x2D5BB70", VA = "0x182D5C770")]
	private void IIOAABNIJCO(GADGPAJFCKD KIEIMPAHGJC, string PBDBHLLHLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C8B0", Offset = "0x2D5BCB0", VA = "0x182D5C8B0")]
	private void IIOAABNIJCO(NativeListAsync<Entity> KCMICKABOHN, string PBDBHLLHLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C9C0", Offset = "0x2D5BDC0", VA = "0x182D5C9C0")]
	private bool JJCNIIHFHLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		public EKGAOGAJFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B8290", Offset = "0x41B7690", VA = "0x1841B8290")]
			public void LICMABLNMJG(IKKOMIHLCNH JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x41B8280", Offset = "0x41B7680", VA = "0x1841B8280")]
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
		[Cpp2IlInjected.Address(RVA = "0x41BC0C0", Offset = "0x41BB4C0", VA = "0x1841BC0C0")]
		internal void OCIBIOHOPKH(Entity CJDLKEIECEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x41B8210", Offset = "0x41B7610", VA = "0x1841B8210", Slot = "5")]
		public void ReadFromDisplayClass(ref EKGAOGAJFIM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x41B8240", Offset = "0x41B7640", VA = "0x1841B8240", Slot = "6")]
		public void WriteToDisplayClass(ref EKGAOGAJFIM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x41BBF50", Offset = "0x41BB350", VA = "0x1841BBF50", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x41BC010", Offset = "0x41BB410", VA = "0x1841BC010")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref IAIIMLNMGKM.NCCCAIBNFOL KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x41BC080", Offset = "0x41BB480", VA = "0x1841BC080")]
		public void LICMABLNMJG(IKKOMIHLCNH JFLOFOFLJIH, ref EKGAOGAJFIM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x41BBFA0", Offset = "0x41BB3A0", VA = "0x1841BBFA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x311F890", Offset = "0x311EC90", VA = "0x18311F890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x311F580", Offset = "0x311E980", VA = "0x18311F580", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x311F8F0", Offset = "0x311ECF0", VA = "0x18311F8F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public IKKOMIHLCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x311F7B0", Offset = "0x311EBB0", VA = "0x18311F7B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x311F5E0", Offset = "0x311E9E0", VA = "0x18311F5E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3120ED0", Offset = "0x31202D0", VA = "0x183120ED0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x3120F40", Offset = "0x3120340", VA = "0x183120F40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x3120FE0", Offset = "0x31203E0", VA = "0x183120FE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public JFABACOIMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E0000", Offset = "0x6DF400", VA = "0x1806E0000")]
	public static ONCPMHDBOJK HEFILGHKDEM(in FJFJJACADNC HKKCKPMLCBB)
	{
		return default(ONCPMHDBOJK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0000", Offset = "0x6DF400", VA = "0x1806E0000")]
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
	[Cpp2IlInjected.Address(RVA = "0x3126930", Offset = "0x3125D30", VA = "0x183126930", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20")]
	public KLEHOOKIDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		public PEBECNNPEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BAA60", Offset = "0x41B9E60", VA = "0x1841BAA60")]
			public void LICMABLNMJG(KHECNBBCLAJ JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x41BA9E0", Offset = "0x41B9DE0", VA = "0x1841BA9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x41B8110", Offset = "0x41B7510", VA = "0x1841B8110")]
		internal void OCIBIOHOPKH(Entity CJDLKEIECEK, ONCPMHDBOJK MCOHFLALPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x41B8210", Offset = "0x41B7610", VA = "0x1841B8210", Slot = "5")]
		public void ReadFromDisplayClass(ref PEBECNNPEEC BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x41B8240", Offset = "0x41B7640", VA = "0x1841B8240", Slot = "6")]
		public void WriteToDisplayClass(ref PEBECNNPEEC BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x41B7EC0", Offset = "0x41B72C0", VA = "0x1841B7EC0", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x41B7FD0", Offset = "0x41B73D0", VA = "0x1841B7FD0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref KKDBLGPGFLE.ELBGFLFDFMB KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x41B8080", Offset = "0x41B7480", VA = "0x1841B8080")]
		public void LICMABLNMJG(KHECNBBCLAJ JFLOFOFLJIH, ref PEBECNNPEEC BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x41B7F60", Offset = "0x41B7360", VA = "0x1841B7F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x3126660", Offset = "0x3125A60", VA = "0x183126660", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x3126350", Offset = "0x3125750", VA = "0x183126350", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x31266C0", Offset = "0x3125AC0", VA = "0x1831266C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public KHECNBBCLAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x3126580", Offset = "0x3125980", VA = "0x183126580", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x31263B0", Offset = "0x31257B0", VA = "0x1831263B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B2CF0", Offset = "0x41B20F0", VA = "0x1841B2CF0")]
			public AEPBCEGDJLK(int KNECCHHDDJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x41B2C70", Offset = "0x41B2070", VA = "0x1841B2C70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BA250", Offset = "0x41B9650", VA = "0x1841BA250", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BA100", Offset = "0x41B9500", VA = "0x1841BA100", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B58B90", Offset = "0x2B57F90", VA = "0x182B58B90", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2B58EA0", Offset = "0x2B582A0", VA = "0x182B58EA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2B58D20", Offset = "0x2B58120", VA = "0x182B58D20", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2B59160", Offset = "0x2B58560", VA = "0x182B59160", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2B58D60", Offset = "0x2B58160", VA = "0x182B58D60")]
		private void MNDENFIBNEM(EntityQuery APEJLGJADFF, out (NativeArrayAsync<ONCPMHDBOJK> handles, NativeArrayAsync<DFOPMDEEAAA> bounds) FNIHENPLJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2B584E0", Offset = "0x2B578E0", VA = "0x182B584E0")]
		private void CCIMKGPMDNM((NativeArrayAsync<ONCPMHDBOJK> handles, NativeArrayAsync<DFOPMDEEAAA> bounds) FNIHENPLJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x2B58D20", Offset = "0x2B58120", VA = "0x182B58D20")]
		private void LGCNMJHCEMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x2B583A0", Offset = "0x2B577A0", VA = "0x182B583A0")]
		private void BMBFJAAODMM(EntityQuery APEJLGJADFF, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<ONCPMHDBOJK> handles) FNIHENPLJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2B58740", Offset = "0x2B57B40", VA = "0x182B58740")]
		private void FNKHJHKJGLE((NativeArrayAsync<Entity> entities, NativeArrayAsync<ONCPMHDBOJK> handles) FNIHENPLJHK, AEPBCEGDJLK FBPIKFEBIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2B58A30", Offset = "0x2B57E30", VA = "0x182B58A30")]
		private JobHandle JIBKGIOKBBD(AEPBCEGDJLK FBPIKFEBIAF, ComponentDataFromEntity<WorldPoseData> KCEIJEGEMNM, ComponentDataFromEntity<WorldUniformScaleData> PNMJBGHHDAG, ComponentDataFromEntity<WorldDeformableScaleData> OFKJNJJCIHM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2B58BF0", Offset = "0x2B57FF0", VA = "0x182B58BF0")]
		private JobHandle KPKDFHOAADN(AEPBCEGDJLK FBPIKFEBIAF, ComponentDataFromEntity<WorldPoseData> KCEIJEGEMNM, ComponentDataFromEntity<WorldUniformScaleData> PNMJBGHHDAG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B4AD0", Offset = "0x41B3ED0", VA = "0x1841B4AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B82A0", Offset = "0x41B76A0", VA = "0x1841B82A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CDEE20", Offset = "0x2CDE220", VA = "0x182CDEE20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF030", Offset = "0x2CDE430", VA = "0x182CDF030", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEA20", Offset = "0x2CDDE20", VA = "0x182CDEA20")]
		private JobHandle LNNFIAPGKKB(NativeArrayAsync<Entity> EGIDMCNFHCK, int GDDNEEFIBDF, JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE840", Offset = "0x2CDDC40", VA = "0x182CDE840")]
		private JobHandle LNNFIAPGKKB(NativeArray<Entity> HFIBNNPNLKF, int GDDNEEFIBDF, [Optional] JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE490", Offset = "0x2CDD890", VA = "0x182CDE490")]
		private NativeArrayAsync<Entity> APCKJNJHEBA(EntityQuery APEJLGJADFF)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF550", Offset = "0x2CDE950", VA = "0x182CDF550")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) PHBPMPDPOEH(NativeArrayAsync<Entity> KGOLNHMMNBM)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x2CDED90", Offset = "0x2CDE190", VA = "0x182CDED90")]
		private void ONHNIDAHGMD(out NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEBD0", Offset = "0x2CDDFD0", VA = "0x182CDEBD0")]
		private void MIOPNBKJLGK(NativeList<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEB00", Offset = "0x2CDDF00", VA = "0x182CDEB00")]
		private void MIOPNBKJLGK(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEC60", Offset = "0x2CDE060", VA = "0x182CDEC60")]
		private void NHGFEDCDHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		private static void IDHIHKCJOFD(int IHACKODNHGG, int MJBICGGKNIG, int HNOHGDAJGDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE510", Offset = "0x2CDD910", VA = "0x182CDE510")]
		private static DFOPMDEEAAA BJFFIJOAHGK(NativeArray<Entity> MDHAPBKCBBF, ComponentDataFromEntity<SplinePointPositionData> EDBNNBFNOCO, ComponentDataFromEntity<SplinePointScaleData> FMEAIJLKJAN)
		{
			return default(DFOPMDEEAAA);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D5FAE0", Offset = "0x2D5EEE0", VA = "0x182D5FAE0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F7A0", Offset = "0x2D5EBA0", VA = "0x182D5F7A0")]
		public bool DAHFHGFHPCJ(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FC00", Offset = "0x2D5F000", VA = "0x182D5FC00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FAA0", Offset = "0x2D5EEA0", VA = "0x182D5FAA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FD30", Offset = "0x2D5F130", VA = "0x182D5FD30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x1E12290", Offset = "0x1E11690", VA = "0x181E12290", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FAA0", Offset = "0x2D5EEA0", VA = "0x182D5FAA0")]
		private void GCELLLDPPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FB50", Offset = "0x2D5EF50", VA = "0x182D5FB50")]
		private void OPEJIMPAIHH(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F850", Offset = "0x2D5EC50", VA = "0x182D5F850")]
		private void FGHBEEJDDME(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F990", Offset = "0x2D5ED90", VA = "0x182D5F990")]
		private void GAKJMOCPHOD(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F680", Offset = "0x2D5EA80", VA = "0x182D5F680")]
		private void AHLGMHDFGHG(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x310F350", Offset = "0x310E750", VA = "0x18310F350", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x310F990", Offset = "0x310ED90", VA = "0x18310F990", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x310F400", Offset = "0x310E800", VA = "0x18310F400")]
		private void LECPEIKJNEP(ENGIDADGGAI LPKJFCDGPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		private void ANCMENMABOC(Entity PJEENOLDJIO, IJDKBBDMEBI DGPLFECNDCD, GJOKNGAFGLP LPPHHGKFEEH, MEGNPFABGGE BPLHNLGGGBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5EEB0", Offset = "0x2B5E2B0", VA = "0x182B5EEB0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EF40", Offset = "0x2B5E340", VA = "0x182B5EF40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CE6880", Offset = "0x2CE5C80", VA = "0x182CE6880", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2CE68D0", Offset = "0x2CE5CD0", VA = "0x182CE68D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD5A20", Offset = "0x2CD4E20", VA = "0x182CD5A20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D50C80", Offset = "0x2D50080", VA = "0x182D50C80", Slot = "14")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D50C90", Offset = "0x2D50090", VA = "0x182D50C90", Slot = "15")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D50D20", Offset = "0x2D50120", VA = "0x182D50D20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D50E70", Offset = "0x2D50270", VA = "0x182D50E70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D51090", Offset = "0x2D50490", VA = "0x182D51090")]
		private bool PKOJOGDDNEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D50940", Offset = "0x2D4FD40", VA = "0x182D50940")]
		private void FJGFAOGAOED(EntityQuery APEJLGJADFF, float3 EMEAMHLICPL, string GOENAEMJAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5BAF0", Offset = "0x2B5AEF0", VA = "0x182B5BAF0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BB40", Offset = "0x2B5AF40", VA = "0x182B5BB40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CED290", Offset = "0x2CEC690", VA = "0x182CED290", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x2CED300", Offset = "0x2CEC700", VA = "0x182CED300", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2CED390", Offset = "0x2CEC790", VA = "0x182CED390", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x310EC30", Offset = "0x310E030", VA = "0x18310EC30", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x310ED00", Offset = "0x310E100", VA = "0x18310ED00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x310E2F0", Offset = "0x310D6F0", VA = "0x18310E2F0")]
		private void FDAKLCEAJBD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> EHJGMBFBLBN, EntityQueryDesc ICENFFJJEBG, bool MMACFBGEFCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x310E400", Offset = "0x310D800", VA = "0x18310E400")]
		private void FDAKLCEAJBD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> EHJGMBFBLBN, EntityQueryDesc ICENFFJJEBG, bool MMACFBGEFCH, bool FJHEIJDCBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x310EF60", Offset = "0x310E360", VA = "0x18310EF60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x310DF00", Offset = "0x310D300", VA = "0x18310DF00")]
		private void AMHGNHLMFNN(EntityQuery APEJLGJADFF, bool EOGLAAENHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x310E800", Offset = "0x310DC00", VA = "0x18310E800")]
		private void INFBEAMFJHG(EntityQuery APEJLGJADFF, bool LMDHKCKFPPO, bool EOGLAAENHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x310EA10", Offset = "0x310DE10", VA = "0x18310EA10")]
		private void JDBNKAABPGA(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x310E180", Offset = "0x310D580", VA = "0x18310E180")]
		private void EOFLEAFFCKN(NativeList<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x310E6E0", Offset = "0x310DAE0", VA = "0x18310E6E0")]
		private void HDOEENDDIGA(NativeArray<Entity> GMAMPIGCEAB, bool LMDHKCKFPPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x310DD00", Offset = "0x310D100", VA = "0x18310DD00")]
		private NativeList<Entity> ALCFPHIEPAM(NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x310ECC0", Offset = "0x310E0C0", VA = "0x18310ECC0")]
		private NativeList<Entity> MOHBBPBJPAC(NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x310EC80", Offset = "0x310E080", VA = "0x18310EC80")]
		private NativeList<Entity> KFCBPGOIOCC(NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x310E540", Offset = "0x310D940", VA = "0x18310E540")]
		private NativeList<Entity> GNBIAIPGIPD(NativeArray<Entity> GMAMPIGCEAB, bool MLALFFLGLGA)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x310E0F0", Offset = "0x310D4F0", VA = "0x18310E0F0")]
		private EPMKAAKOKHK BNOBLHNNDHL(NativeArray<Entity> GMAMPIGCEAB)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(EPMKAAKOKHK);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x310F280", Offset = "0x310E680", VA = "0x18310F280")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5BB60", Offset = "0x2B5AF60", VA = "0x182B5BB60", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BBB0", Offset = "0x2B5AFB0", VA = "0x182B5BBB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D5F2F0", Offset = "0x2D5E6F0", VA = "0x182D5F2F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F4B0", Offset = "0x2D5E8B0", VA = "0x182D5F4B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D5EE70", Offset = "0x2D5E270", VA = "0x182D5EE70")]
		private void IMNGGODJJMA(EntityQuery APEJLGJADFF, bool LOGAOEPCLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F0B0", Offset = "0x2D5E4B0", VA = "0x182D5F0B0")]
		private void OEANHLNOPBH(EntityQuery APEJLGJADFF, bool LOGAOEPCLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D49550", Offset = "0x2D48950", VA = "0x182D49550", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2D49C70", Offset = "0x2D49070", VA = "0x182D49C70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D49D80", Offset = "0x2D49180", VA = "0x182D49D80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2D499F0", Offset = "0x2D48DF0", VA = "0x182D499F0")]
		private void OCAGKEDDIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2D49B00", Offset = "0x2D48F00", VA = "0x182D49B00")]
		private void OLGAMBNKJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D496D0", Offset = "0x2D48AD0", VA = "0x182D496D0")]
		private void OAINHJLOHDI(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D493B0", Offset = "0x2D487B0", VA = "0x182D493B0")]
		private void ANPHNIDNPMP(NativeArray<Entity> GMAMPIGCEAB, int MLDPHJMEGHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2D495C0", Offset = "0x2D489C0", VA = "0x182D495C0")]
		private void MPANPINBHOK(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D494F0", Offset = "0x2D488F0", VA = "0x182D494F0")]
		private void FOFAGLLEEJI(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		private static void DGGMPLPPLMA(int HIFBLLMBEPO, Transform PKIKNDCFAFJ, Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class LICJKBGILLD
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x2B3F5B0", Offset = "0x2B3E9B0", VA = "0x182B3F5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D52A30", Offset = "0x2D51E30", VA = "0x182D52A30", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2D52A80", Offset = "0x2D51E80", VA = "0x182D52A80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2D52B40", Offset = "0x2D51F40", VA = "0x182D52B40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B41BB0", Offset = "0x2B40FB0", VA = "0x182B41BB0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x2B419F0", Offset = "0x2B40DF0", VA = "0x182B419F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity BJNFIFJNIOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x2B41830", Offset = "0x2B40C30", VA = "0x182B41830")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public GPEJGMHBDPO KPMACBBGDGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x2B41C10", Offset = "0x2B41010", VA = "0x182B41C10")]
			get
			{
				return default(GPEJGMHBDPO);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x2B41570", Offset = "0x2B40970", VA = "0x182B41570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public GPEJGMHBDPO MIGEIOLOIHL
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x2B41730", Offset = "0x2B40B30", VA = "0x182B41730")]
			get
			{
				return default(GPEJGMHBDPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2B41A90", Offset = "0x2B40E90", VA = "0x182B41A90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x2B417C0", Offset = "0x2B40BC0", VA = "0x182B417C0", Slot = "15")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x2B41B30", Offset = "0x2B40F30", VA = "0x182B41B30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x2B415E0", Offset = "0x2B409E0", VA = "0x182B415E0", Slot = "14")]
		protected override void IHLAFFFPCME(NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> IGBHJEHMJKP, NativeArray<Entity> GPMOJKJNJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2B41890", Offset = "0x2B40C90", VA = "0x182B41890")]
		private void KGKBKLCDBCM(NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> GPMOJKJNJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2B41280", Offset = "0x2B40680", VA = "0x182B41280")]
		private void BDDJMMHOFNI(Entity PJEENOLDJIO, Entity JCOHCMAHJBI, Entity ILGBJHAFEBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x29E7240", Offset = "0x29E6640", VA = "0x1829E7240")]
		private bool LEDONIKBHEA<T>(out T KPPLMEOMNGF) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x29E72D0", Offset = "0x29E66D0", VA = "0x1829E72D0")]
		private void OGNINEINMEG<T>(T KPPLMEOMNGF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2B41970", Offset = "0x2B40D70", VA = "0x182B41970")]
		public bool KPILHKEKFNF(GPEJGMHBDPO JEKPLGHLKLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2B41540", Offset = "0x2B40940", VA = "0x182B41540")]
		private static bool GDDJHAIALKN(GPEJGMHBDPO FHHOOPJNCAN, GPEJGMHBDPO AFKEDDEKEKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2B41CF0", Offset = "0x2B410F0", VA = "0x182B41CF0")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2B41A50", Offset = "0x2B40E50", VA = "0x182B41A50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D5B020", Offset = "0x2D5A420", VA = "0x182D5B020", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B070", Offset = "0x2D5A470", VA = "0x182D5B070", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B110", Offset = "0x2D5A510", VA = "0x182D5B110", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2D5ADC0", Offset = "0x2D5A1C0", VA = "0x182D5ADC0")]
		private NativeArray<Entity> GFHFIDHIMFA(int KJAHKKMJHHG)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AF10", Offset = "0x2D5A310", VA = "0x182D5AF10")]
		private void JEJNMBJPOOK(NativeArray<Entity> NLPMPLFDPEN, NativeArray<Entity> DLNKIPKCMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x311C190", Offset = "0x311B590", VA = "0x18311C190", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x311C280", Offset = "0x311B680", VA = "0x18311C280", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DF5EF0", Offset = "0x2DF52F0", VA = "0x182DF5EF0")]
	public static NativeArray<T> GEHHGFMIJEJ<T>(NativeArray<Entity> GMAMPIGCEAB, EntityManager JGDEKKJFKAJ) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E9B0", Offset = "0x2D4DDB0", VA = "0x182D4E9B0")]
	public static void AIKMKNJPOIC(EntityQuery APEJLGJADFF, EntityManager JGDEKKJFKAJ, FOBNDAGEMLO AKPCEKFNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2D4EC20", Offset = "0x2D4E020", VA = "0x182D4EC20")]
	public static void POHPIDDFNMB(NativeArray<Entity> NLPMPLFDPEN, FOBNDAGEMLO AKPCEKFNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x2D4EAF0", Offset = "0x2D4DEF0", VA = "0x182D4EAF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CEC830", Offset = "0x2CEBC30", VA = "0x182CEC830", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2CED190", Offset = "0x2CEC590", VA = "0x182CED190", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2CED230", Offset = "0x2CEC630", VA = "0x182CED230", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB830", Offset = "0x2CEAC30", VA = "0x182CEB830")]
		private void AEIJLFBMOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC040", Offset = "0x2CEB440", VA = "0x182CEC040")]
		private void DNHEALBDPIJ(NativeArray<Entity> NLPMPLFDPEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC8C0", Offset = "0x2CEBCC0", VA = "0x182CEC8C0")]
		private void LOLOAIAJFIO(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC150", Offset = "0x2CEB550", VA = "0x182CEC150")]
		private void GJALCBPPEEJ(NativeArray<Entity> DLNKIPKCMPA, NativeArray<RigidTransform> APBAKONFHJF, NativeArray<RigidTransform> DHMONBDMIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC3A0", Offset = "0x2CEB7A0", VA = "0x182CEC3A0")]
		private void GMJAEPCGKON(NativeArray<RigidTransform> DHMONBDMIGL, NativeArray<Entity> DLNKIPKCMPA, NativeList<Entity> EHELFJGPLMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5A100", Offset = "0x2B59500", VA = "0x182B5A100", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A170", Offset = "0x2B59570", VA = "0x182B5A170", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A2C0", Offset = "0x2B596C0", VA = "0x182B5A2C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A090", Offset = "0x2B59490", VA = "0x182B5A090")]
		private void CLHKKCKBGPE(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5B960", Offset = "0x2B5AD60", VA = "0x182B5B960", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B9F0", Offset = "0x2B5ADF0", VA = "0x182B5B9F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BA90", Offset = "0x2B5AE90", VA = "0x182B5BA90", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B7D0", Offset = "0x2B5ABD0", VA = "0x182B5B7D0")]
		private void GFHIHMIOGLP(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD7630", Offset = "0x2CD6A30", VA = "0x182CD7630", Slot = "14")]
		protected override void IHLAFFFPCME(NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> IGBHJEHMJKP, NativeArray<Entity> GPMOJKJNJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7560", Offset = "0x2CD6960", VA = "0x182CD7560")]
		[BurstCompile]
		private static void IHLAFFFPCME(NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> GPMOJKJNJPH, ComponentDataFromEntity<global::PMDPALLMDFD> FFLKNEGJGHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2CD77C0", Offset = "0x2CD6BC0", VA = "0x182CD77C0")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7780", Offset = "0x2CD6B80", VA = "0x182CD7780", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FB20F0", Offset = "0x2FB14F0", VA = "0x182FB20F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x2FB24C0", Offset = "0x2FB18C0", VA = "0x182FB24C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x2FB2490", Offset = "0x2FB1890", VA = "0x182FB2490", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x2FB1870", Offset = "0x2FB0C70", VA = "0x182FB1870")]
		private void NEBPAFFGLCE(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x2FB07F0", Offset = "0x2FAFBF0", VA = "0x182FB07F0")]
		private void ADNAFCGMIMI(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x2FB0FD0", Offset = "0x2FB03D0", VA = "0x182FB0FD0")]
		private void HJIBJBIHKEM(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void IHLAFFFPCME(NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> IGBHJEHMJKP, NativeArray<Entity> GPMOJKJNJPH);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x2FB2550", Offset = "0x2FB1950", VA = "0x182FB2550")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x14FF8B0", Offset = "0x14FECB0", VA = "0x1814FF8B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3121E40", Offset = "0x3121240", VA = "0x183121E40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x3122040", Offset = "0x3121440", VA = "0x183122040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x3122190", Offset = "0x3121590", VA = "0x183122190")]
	public JLGDKJGFNPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B56270", Offset = "0x2B55670", VA = "0x182B56270")]
	public static Entity HEFILGHKDEM(GIAOKBBLBMM FNIHENPLJHK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2B56270", Offset = "0x2B55670", VA = "0x182B56270")]
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
		[Cpp2IlInjected.Address(RVA = "0x311EF50", Offset = "0x311E350", VA = "0x18311EF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x311F150", Offset = "0x311E550", VA = "0x18311F150")]
	public IDEGAILMGHG(ComponentType DDFJPMOIHNM, NativeList<int> CAHDBKNLLCN, NativeList<int> GCNEFCAOPJG, NativeArray<Entity> GMAMPIGCEAB, NativeArray<Entity> LJDCHIOFGBL, NativeArray<byte> KCDBOIAJNCE, NativeArray<byte> IMFNGEBEPMB, int ODDNJFFKMJI, int CPFNENOGHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x311ED30", Offset = "0x311E130", VA = "0x18311ED30")]
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
	[Cpp2IlInjected.Address(RVA = "0x311EFD0", Offset = "0x311E3D0", VA = "0x18311EFD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x311F100", Offset = "0x311E500", VA = "0x18311F100")]
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
	[Cpp2IlInjected.Address(RVA = "0x311F020", Offset = "0x311E420", VA = "0x18311F020", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3123540", Offset = "0x3122940", VA = "0x183123540")]
	public JPEEACBJEJB(ComponentType DDFJPMOIHNM, int ODDNJFFKMJI, int CPFNENOGHKI, EntityQuery APEJLGJADFF, NativeArray<HJMJEPLELOA> ICBILMELIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x31234F0", Offset = "0x31228F0", VA = "0x1831234F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x701050", Offset = "0x700450", VA = "0x180701050")]
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
	[Cpp2IlInjected.Address(RVA = "0x701050", Offset = "0x700450", VA = "0x180701050")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B42190", Offset = "0x2B41590", VA = "0x182B42190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public BPHAMHGLCNC FOEPHKKCDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40")]
		get
		{
			return default(BPHAMHGLCNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x2B41FB0", Offset = "0x2B413B0", VA = "0x182B41FB0")]
	public MPOLKMCKMLM BFEJHELLIAA(Type HAOFNDAEGFJ)
	{
		return default(MPOLKMCKMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x2B420A0", Offset = "0x2B414A0", VA = "0x182B420A0")]
	public MPOLKMCKMLM PDJLJJCOAFF(Type HAOFNDAEGFJ)
	{
		return default(MPOLKMCKMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x29E9F90", Offset = "0x29E9390", VA = "0x1829E9F90")]
	public T BFEJHELLIAA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x29E9FB0", Offset = "0x29E93B0", VA = "0x1829E9FB0")]
	public T PDJLJJCOAFF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x2B421A0", Offset = "0x2B415A0", VA = "0x182B421A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3121330", Offset = "0x3120730", VA = "0x183121330", Slot = "17")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x31215C0", Offset = "0x31209C0", VA = "0x1831215C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x3121380", Offset = "0x3120780", VA = "0x183121380", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	protected JGLHBDCLLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3124620", Offset = "0x3123A20", VA = "0x183124620")]
		get
		{
			return default(JPEEACBJEJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x3124FC0", Offset = "0x31243C0", VA = "0x183124FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x3125080", Offset = "0x3124480", VA = "0x183125080")]
	public KDNHCONPDAI(EEPEPNPEOFG DOFDFFCHKPB, JHCDFELAIDH AOHKNGHOEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x3125010", Offset = "0x3124410", VA = "0x183125010")]
	public bool OHBANFGHGGE(ComponentType DDFJPMOIHNM, out JPEEACBJEJB ADOLOEKMGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x3124F30", Offset = "0x3124330", VA = "0x183124F30")]
	public Dictionary<ComponentType, JPEEACBJEJB>.Enumerator KGLEFCHHJJI()
	{
		return default(Dictionary<ComponentType, JPEEACBJEJB>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x31248E0", Offset = "0x3123CE0", VA = "0x1831248E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x3124A80", Offset = "0x3123E80", VA = "0x183124A80")]
	private void GJNMIPMPDLB(IEnumerable<GBOCHCBEADE> BMIKDMDNIPC, EntityManager JGDEKKJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x3124E80", Offset = "0x3124280", VA = "0x183124E80")]
	private static int HIFKHPIAFOH(GBOCHCBEADE JFILCDKBAEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x31246B0", Offset = "0x3123AB0", VA = "0x1831246B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7D30", Offset = "0xCD7130", VA = "0x180CD7D30", Slot = "4")]
			get
			{
				return default(MEGNPFABGGE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x2CD3710", Offset = "0x2CD2B10", VA = "0x182CD3710", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3760", Offset = "0x2CD2B60", VA = "0x182CD3760")]
		internal IKOJPKACCMB(NativeMultiHashMap<Entity, MEGNPFABGGE> MOBIBCNEEOL, Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3500", Offset = "0x2CD2900", VA = "0x182CD3500", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x2CD34D0", Offset = "0x2CD28D0", VA = "0x182CD34D0")]
		public IKOJPKACCMB KGLEFCHHJJI()
		{
			return default(IKOJPKACCMB);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x2CD35D0", Offset = "0x2CD29D0", VA = "0x182CD35D0", Slot = "9")]
		private IEnumerator<MEGNPFABGGE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3670", Offset = "0x2CD2A70", VA = "0x182CD3670", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D5E740", Offset = "0x2D5DB40", VA = "0x182D5E740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x2D5E660", Offset = "0x2D5DA60", VA = "0x182D5E660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x26AEC90", Offset = "0x26AE090", VA = "0x1826AEC90")]
	public DLBHGBHCIGG(BFHHLLCINGL KFCHBPFAEMJ, JobHandle APGGDPBCICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x2D5E830", Offset = "0x2D5DC30", VA = "0x182D5E830")]
	public bool NPDCHEEKIJH(Allocator GOLNHBOGNGC, out NativeKeyValueArrays<Entity, MEGNPFABGGE> GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2D5E970", Offset = "0x2D5DD70", VA = "0x182D5E970")]
	public bool OCLKKJPHBMC(Allocator GOLNHBOGNGC, out (NativeArray<Entity> entities, int uniqueCount) GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2D5E540", Offset = "0x2D5D940", VA = "0x182D5E540")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B452E0", Offset = "0x2B446E0", VA = "0x182B452E0")]
		get
		{
			return default(JPEEACBJEJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2B458B0", Offset = "0x2B44CB0", VA = "0x182B458B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x2B458F0", Offset = "0x2B44CF0", VA = "0x182B458F0")]
	public NFFGAJCCLIN(KDNHCONPDAI JGHKHMIKDHP, EEPEPNPEOFG DOFDFFCHKPB, JHCDFELAIDH AOHKNGHOEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x2B45830", Offset = "0x2B44C30", VA = "0x182B45830")]
	public List<JPEEACBJEJB>.Enumerator KGLEFCHHJJI()
	{
		return default(List<JPEEACBJEJB>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B45370", Offset = "0x2B44770", VA = "0x182B45370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B454F0", Offset = "0x2B448F0", VA = "0x182B454F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B497F0", Offset = "0x2B48BF0", VA = "0x182B497F0")]
	public OMEHKNGHBDB(ObjectInstantiationService APEJINPFNBH, EEPEPNPEOFG DOFDFFCHKPB, JHCDFELAIDH AOHKNGHOEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B48C80", Offset = "0x2B48080", VA = "0x182B48C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B49040", Offset = "0x2B48440", VA = "0x182B49040")]
	public bool GOIDOBEHMKN(OBNHEEKLBIB IBFEICPOBBG, out Entity IJBPCAELLON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B48520", Offset = "0x2B47920", VA = "0x182B48520")]
	private void CACLJONLPEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B47E80", Offset = "0x2B47280", VA = "0x182B47E80")]
	private EntityArchetype BBDFPHMMLMC(EntityArchetype AJNNHCKHNHJ)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B493C0", Offset = "0x2B487C0", VA = "0x182B493C0")]
	public static void OJBBADHIPIG(EntityManager ABFDLFMHAJL, EntityManager LKAGEFPMCDG, NativeArray<Entity> INCINPMOBBH, NativeArray<EntityArchetype> BLPNOFOBPBN, [Optional] NativeArray<Entity> PGJHMFMABMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B483B0", Offset = "0x2B477B0", VA = "0x182B483B0")]
	[Conditional("DEBUG_BUILD")]
	private static void BIKKEHKAHIB(NativeArray<EntityArchetype> HGMIABMNLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B490A0", Offset = "0x2B484A0", VA = "0x182B490A0")]
	private static string HADDKMAPJJJ(EntityArchetype GOEEEEBMLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B48D50", Offset = "0x2B48150", VA = "0x182B48D50")]
	[CompilerGenerated]
	internal static void FJFIIJKFFHH(ref Span<ComponentType> KGJLLBIEGDF, ComponentType KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B48E90", Offset = "0x2B48290", VA = "0x182B48E90")]
	[CompilerGenerated]
	internal static void GICKGMNCGCO(Span<ComponentType> EGIDMCNFHCK, ref Span<ComponentType> KGJLLBIEGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B492E0", Offset = "0x2B486E0", VA = "0x182B492E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D49240", Offset = "0x2D48640", VA = "0x182D49240", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D49300", Offset = "0x2D48700", VA = "0x182D49300", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD3300", Offset = "0x2CD2700", VA = "0x182CD3300", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x2CD3440", Offset = "0x2CD2840", VA = "0x182CD3440")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD2290", Offset = "0x2CD1690", VA = "0x182CD2290", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD1D20", Offset = "0x2CD1120", VA = "0x182CD1D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD2C30", Offset = "0x2CD2030", VA = "0x182CD2C30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D55700", Offset = "0x2D54B00", VA = "0x182D55700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private BFHHLLCINGL GDOPJIHDKEG
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x2D52F40", Offset = "0x2D52340", VA = "0x182D52F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D54860", Offset = "0x2D53C60", VA = "0x182D54860", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "15")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D55AA0", Offset = "0x2D54EA0", VA = "0x182D55AA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D55C60", Offset = "0x2D55060", VA = "0x182D55C60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D55BF0", Offset = "0x2D54FF0", VA = "0x182D55BF0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D52F60", Offset = "0x2D52360", VA = "0x182D52F60")]
		private void BKEGCBNLBOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D54600", Offset = "0x2D53A00", VA = "0x182D54600")]
		internal void FAACDNBNAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D53E30", Offset = "0x2D53230", VA = "0x182D53E30")]
		private void FAACDNBNAGJ(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D52C00", Offset = "0x2D52000", VA = "0x182D52C00")]
		private void ANCANMEMKKN(NativeArray<Entity> INCINPMOBBH, NativeArray<RRObjectPrefabData> FENDMLNLIDM, ref NativeArray<Entity> CJDMDALAHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D556E0", Offset = "0x2D54AE0", VA = "0x182D556E0")]
		internal void NDMAHIHAEKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D552E0", Offset = "0x2D546E0", VA = "0x182D552E0")]
		private void NDMAHIHAEKA(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2D536D0", Offset = "0x2D52AD0", VA = "0x182D536D0")]
		internal void EEHGMAABJGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2D557C0", Offset = "0x2D54BC0", VA = "0x182D557C0")]
		private void ONEBEKBHMGD(BFHHLLCINGL KFCHBPFAEMJ, JPEEACBJEJB JJPMEEGFFGM, bool EJFAOPNCMBG, ref JobHandle HBKMCOINHFO, ref JobHandle PGAKIGHHDBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2D548B0", Offset = "0x2D53CB0", VA = "0x182D548B0")]
		internal bool LJAOABGJLCA(in JPEEACBJEJB NANIPOPDLDJ, out JobHandle BDCLOJHOMDK, out IDEGAILMGHG LELNBCFCCGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D548E0", Offset = "0x2D53CE0", VA = "0x182D548E0")]
		private bool LJAOABGJLCA(in JPEEACBJEJB NANIPOPDLDJ, bool EJFAOPNCMBG, out JobHandle BDCLOJHOMDK, out IDEGAILMGHG LELNBCFCCGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D54620", Offset = "0x2D53A20", VA = "0x182D54620")]
		internal (NativeList<int>, NativeList<int>) GJOMOEDEHCC(NativeList<NEEMIEDAPCM> MAGLBLOKDFO, int KNECCHHDDJH, JobHandle OFHDPBCPCFP, out JobHandle DGGOEPGELHE, Allocator GOLNHBOGNGC = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D53620", Offset = "0x2D52A20", VA = "0x182D53620")]
		internal static NativeArray<Entity> CODPEHMAOJL(EntityQuery APEJLGJADFF, out JobHandle HMBMADBNCFH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D547E0", Offset = "0x2D53BE0", VA = "0x182D547E0")]
		internal static NativeArray<byte> HLFCMGDDLLJ(int FHNEBAPANCE, out JobHandle CPDJIHHOHEH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D55DA0", Offset = "0x2D551A0", VA = "0x182D55DA0")]
		internal static NativeArray<byte> PCAOCPMFNDF(EntityQuery APEJLGJADFF, int DFMDKBNGDLJ, out JobHandle CPDJIHHOHEH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D52E40", Offset = "0x2D52240", VA = "0x182D52E40")]
		internal static NativeArray<Entity> APCKJNJHEBA(EntityQuery APEJLGJADFF, out JobHandle NEPHIFININB)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2D53220", Offset = "0x2D52620", VA = "0x182D53220")]
		internal NativeArray<byte> CDKLJOEGHNE(NativeArray<Entity> GMAMPIGCEAB, JPEEACBJEJB JJPMEEGFFGM, JobHandle OFHDPBCPCFP, out JobHandle DGGOEPGELHE, Allocator GOLNHBOGNGC = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x2D53490", Offset = "0x2D52890", VA = "0x182D53490")]
		internal JobHandle CLPFKFBNOED(in IDEGAILMGHG FNIHENPLJHK, in JPEEACBJEJB JJPMEEGFFGM, NativeMultiHashMap<Entity, MEGNPFABGGE> NEDMLOIKIFG, JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E38E90", Offset = "0x1E38290", VA = "0x181E38E90")]
		private JobHandle EAPOHBPAEDH(JobHandle AIGKIAHLJHD, JobHandle APEOOHMEEJI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E38E90", Offset = "0x1E38290", VA = "0x181E38E90")]
		private JobHandle EAPOHBPAEDH(JobHandle AIGKIAHLJHD, JobHandle APEOOHMEEJI, JobHandle IMCMEEIGING)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B5C3A0", Offset = "0x2B5B7A0", VA = "0x182B5C3A0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType ILDNNFHLDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C3D0", Offset = "0x2B5B7D0", VA = "0x182B5C3D0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType HOEGHECCJPN
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C370", Offset = "0x2B5B770", VA = "0x182B5C370", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C400", Offset = "0x2B5B800", VA = "0x182B5C400")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B5C440", Offset = "0x2B5B840", VA = "0x182B5C440", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType ILDNNFHLDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C470", Offset = "0x2B5B870", VA = "0x182B5C470", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType HOEGHECCJPN
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C410", Offset = "0x2B5B810", VA = "0x182B5C410", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C400", Offset = "0x2B5B800", VA = "0x182B5C400")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3114710", Offset = "0x3113B10", VA = "0x183114710", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x31147A0", Offset = "0x3113BA0", VA = "0x1831147A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public FNIHOBLGIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		public FBMCOINBLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B5810", Offset = "0x41B4C10", VA = "0x1841B5810")]
			public void LICMABLNMJG(JHGLFLMIJNB JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x41B5790", Offset = "0x41B4B90", VA = "0x1841B5790")]
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
		[Cpp2IlInjected.Address(RVA = "0x41BE030", Offset = "0x41BD430", VA = "0x1841BE030")]
		internal void OCIBIOHOPKH(Entity PJEENOLDJIO, SplinePointParentData BJNJDEBFECO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x41BE0A0", Offset = "0x41BD4A0", VA = "0x1841BE0A0", Slot = "5")]
		public void ReadFromDisplayClass(ref FBMCOINBLGP BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x41BE0B0", Offset = "0x41BD4B0", VA = "0x1841BE0B0", Slot = "6")]
		public void WriteToDisplayClass(ref FBMCOINBLGP BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x41BDDE0", Offset = "0x41BD1E0", VA = "0x1841BDDE0", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x41BDEF0", Offset = "0x41BD2F0", VA = "0x1841BDEF0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref DJNACAOLNDF.BAPHBLJLNEA KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x41BDFA0", Offset = "0x41BD3A0", VA = "0x1841BDFA0")]
		public void LICMABLNMJG(JHGLFLMIJNB JFLOFOFLJIH, ref FBMCOINBLGP BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x41BDE80", Offset = "0x41BD280", VA = "0x1841BDE80")]
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
	[Cpp2IlInjected.Address(RVA = "0x31219E0", Offset = "0x3120DE0", VA = "0x1831219E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public JHGLFLMIJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x31217B0", Offset = "0x3120BB0", VA = "0x1831217B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x3121650", Offset = "0x3120A50", VA = "0x183121650")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D45840", Offset = "0x2D44C40", VA = "0x182D45840", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2D458D0", Offset = "0x2D44CD0", VA = "0x182D458D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public AFNNDICDEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(FNIHOBLGIFG))]
public class KKMLKMNCJIO : HCAPJDLAPMD
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x3126820", Offset = "0x3125C20", VA = "0x183126820", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public KKMLKMNCJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		public GGCECDPGKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B3560", Offset = "0x41B2960", VA = "0x1841B3560")]
			public void LICMABLNMJG(BFMCGMOHAHJ JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x41B34E0", Offset = "0x41B28E0", VA = "0x1841B34E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD52D0", Offset = "0x2CD46D0", VA = "0x182CD52D0")]
		internal void OCIBIOHOPKH(Entity PJEENOLDJIO, ObjectNetworkIdComponentData HLIFFLHFFOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x1310140", Offset = "0x130F540", VA = "0x181310140", Slot = "5")]
		public void ReadFromDisplayClass(ref GGCECDPGKBM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x2898130", Offset = "0x2897530", VA = "0x182898130", Slot = "6")]
		public void WriteToDisplayClass(ref GGCECDPGKBM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x2CD5100", Offset = "0x2CD4500", VA = "0x182CD5100", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x2CD51E0", Offset = "0x2CD45E0", VA = "0x182CD51E0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref AKOOEDHAMBM.BBGLEBPHLFP KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x2CD5290", Offset = "0x2CD4690", VA = "0x182CD5290")]
		public void LICMABLNMJG(BFMCGMOHAHJ JFLOFOFLJIH, ref GGCECDPGKBM BFCCEFMGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x2CD5170", Offset = "0x2CD4570", VA = "0x182CD5170")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D4BD70", Offset = "0x2D4B170", VA = "0x182D4BD70", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D4BFD0", Offset = "0x2D4B3D0", VA = "0x182D4BFD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public BFMCGMOHAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D4BDD0", Offset = "0x2D4B1D0", VA = "0x182D4BDD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D4BC10", Offset = "0x2D4B010", VA = "0x182D4BC10")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B7740", Offset = "0x41B6B40", VA = "0x1841B7740")]
			public void LICMABLNMJG(AENNHIAGJIH JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x41B76C0", Offset = "0x41B6AC0", VA = "0x1841B76C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD48D0", Offset = "0x2CD3CD0", VA = "0x182CD48D0")]
		public void OCIBIOHOPKH(Entity PJEENOLDJIO, ParentData OMKPIJFONFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2CD4700", Offset = "0x2CD3B00", VA = "0x182CD4700", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x2CD47E0", Offset = "0x2CD3BE0", VA = "0x182CD47E0")]
		public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref GHPFNGMNLLA.ECHIHLDPEFG KMKJFLCAOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x2CD4890", Offset = "0x2CD3C90", VA = "0x182CD4890")]
		public void LICMABLNMJG(AENNHIAGJIH JFLOFOFLJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x2CD4770", Offset = "0x2CD3B70", VA = "0x182CD4770")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D452E0", Offset = "0x2D446E0", VA = "0x182D452E0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x2D45730", Offset = "0x2D44B30", VA = "0x182D45730", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public AENNHIAGJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2D45340", Offset = "0x2D44740", VA = "0x182D45340")]
	[CompilerGenerated]
	private void KNBMIABBHAE(Entity PJEENOLDJIO, ParentData OMKPIJFONFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x2D45530", Offset = "0x2D44930", VA = "0x182D45530", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x2D45180", Offset = "0x2D44580", VA = "0x182D45180")]
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
	[Cpp2IlInjected.Address(RVA = "0x311E6D0", Offset = "0x311DAD0", VA = "0x18311E6D0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x311E720", Offset = "0x311DB20", VA = "0x18311E720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x311E800", Offset = "0x311DC00", VA = "0x18311E800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x311E9E0", Offset = "0x311DDE0", VA = "0x18311E9E0")]
	private void PEFHGEALJKG(Entity PJEENOLDJIO, OBNHEEKLBIB IBFEICPOBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public IDDDCOAFMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5A3D0", Offset = "0x2B597D0", VA = "0x182B5A3D0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A420", Offset = "0x2B59820", VA = "0x182B5A420", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
			public BIPJDKBMHOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
				[Cpp2IlInjected.Address(RVA = "0x41B3670", Offset = "0x41B2A70", VA = "0x1841B3670")]
				public void LICMABLNMJG(PostLoadInitializeNetworkId JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x41B35C0", Offset = "0x41B29C0", VA = "0x1841B35C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BA950", Offset = "0x41B9D50", VA = "0x1841BA950")]
			internal void OCIBIOHOPKH(Entity PJEENOLDJIO, int AJPEDLMCFNF, ref ObjectNetworkIdComponentData HLIFFLHFFOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x1310140", Offset = "0x130F540", VA = "0x181310140", Slot = "5")]
			public void ReadFromDisplayClass(ref BIPJDKBMHOF BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x2898130", Offset = "0x2897530", VA = "0x182898130", Slot = "6")]
			public void WriteToDisplayClass(ref BIPJDKBMHOF BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x41BA680", Offset = "0x41B9A80", VA = "0x1841BA680", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x41BA7E0", Offset = "0x41B9BE0", VA = "0x1841BA7E0")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref ANGHBFBBDNC.GFNAGLJEHIM KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x41BA8B0", Offset = "0x41B9CB0", VA = "0x1841BA8B0")]
			public void LICMABLNMJG(PostLoadInitializeNetworkId JFLOFOFLJIH, ref BIPJDKBMHOF BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x41BA770", Offset = "0x41B9B70", VA = "0x1841BA770")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5ADF0", Offset = "0x2B5A1F0", VA = "0x182B5ADF0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B350", Offset = "0x2B5A750", VA = "0x182B5B350", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B3F0", Offset = "0x2B5A7F0", VA = "0x182B5B3F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A630", Offset = "0x2B59A30", VA = "0x182B5A630")]
		public void AHBOJDGFGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A8A0", Offset = "0x2B59CA0", VA = "0x182B5A8A0")]
		private void GGHEIEKHBEB(NativeHashMap<IJDKBBDMEBI, Entity> MOBIBCNEEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2B5AE60", Offset = "0x2B5A260", VA = "0x182B5AE60")]
		private void MNLGJNGPGHH(NativeHashMap<IJDKBBDMEBI, Entity> MOBIBCNEEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B0C0", Offset = "0x2B5A4C0", VA = "0x182B5B0C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A700", Offset = "0x2B59B00", VA = "0x182B5A700")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D60A00", Offset = "0x2D5FE00", VA = "0x182D60A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2D60A90", Offset = "0x2D5FE90", VA = "0x182D60A90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public EFKFOBBDNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D469D0", Offset = "0x2D45DD0", VA = "0x182D469D0", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2D46C00", Offset = "0x2D46000", VA = "0x182D46C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2D46A70", Offset = "0x2D45E70", VA = "0x182D46A70")]
	private void KBLNNDAKFEH(NativeList<EntityArchetype> HGMIABMNLHP, NativeHashMap<int, ADEHAJBPFKB> GEGOINCNNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x2D461C0", Offset = "0x2D455C0", VA = "0x182D461C0")]
	private Span<int> EHPDKBEJCNH(EntityArchetype GOEEEEBMLPJ)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2D46300", Offset = "0x2D45700", VA = "0x182D46300")]
	private bool ENDKKKAGPEN(int DFMDKBNGDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x2D463D0", Offset = "0x2D457D0", VA = "0x182D463D0")]
	private void HCHKBOEAGLM(NativeHashMap<int, ADEHAJBPFKB> GEGOINCNNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public AGPKBABMEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5B450", Offset = "0x2B5A850", VA = "0x182B5B450", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B6D0", Offset = "0x2B5AAD0", VA = "0x182B5B6D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
			public FLGDIKLBOOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x2CD2C20", Offset = "0x2CD2020", VA = "0x182CD2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B7020", Offset = "0x41B6420", VA = "0x1841B7020")]
			internal void OCIBIOHOPKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x41B71E0", Offset = "0x41B65E0", VA = "0x1841B71E0", Slot = "5")]
			public void ReadFromDisplayClass(ref FLGDIKLBOOJ BFCCEFMGPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x41B6FF0", Offset = "0x41B63F0", VA = "0x1841B6FF0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x41B7000", Offset = "0x41B6400", VA = "0x1841B7000")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CDD400", Offset = "0x2CDC800", VA = "0x182CDD400", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD3C0", Offset = "0x2CDC7C0", VA = "0x182CDD3C0")]
		public JobHandle AGCLIILCDCC(JobHandle OFHDPBCPCFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD770", Offset = "0x2CDCB70", VA = "0x182CDD770", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD460", Offset = "0x2CDC860", VA = "0x182CDD460")]
		private bool LLGALBNOCLL(JobHandle OFHDPBCPCFP, int DFMDKBNGDLJ, out JobHandle PIPNFOBKJAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B56190", Offset = "0x2B55590", VA = "0x182B56190", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public PCJDAPKOHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D45990", Offset = "0x2D44D90", VA = "0x182D45990", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public AFOFMCAJGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3119B40", Offset = "0x3118F40", VA = "0x183119B40", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public GDPFDGNKBCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D5C470", Offset = "0x2D5B870", VA = "0x182D5C470", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public DCBPIOFBCON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x706AA0", Offset = "0x705EA0", VA = "0x180706AA0", Slot = "18")]
		get
		{
			return default(ENGIDADGGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F8E0", Offset = "0x2D4ECE0", VA = "0x182D4F8E0")]
	public CHNECHPGLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3119320", Offset = "0x3118720", VA = "0x183119320", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public GDMLMDCLMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class AKMJPBDCOIH : IJINHHBANEE
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public AKMJPBDCOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "18")]
		get
		{
			return default(ENGIDADGGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F8E0", Offset = "0x2D4ECE0", VA = "0x182D4F8E0")]
	public EKAIDLCEKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B441F0", Offset = "0x2B435F0", VA = "0x182B441F0", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public NBKHBFHAFOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class KAMIOINKBNK : IJINHHBANEE
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public KAMIOINKBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class DDMHCNFHEOF : IJINHHBANEE
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public DDMHCNFHEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class IKNNJGPDECM : HCAPJDLAPMD
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public IKNNJGPDECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D44690", Offset = "0x2D43A90", VA = "0x182D44690", Slot = "14")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2D446E0", Offset = "0x2D43AE0", VA = "0x182D446E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public ACLELFMAFNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD37F0", Offset = "0x2CD2BF0", VA = "0x182CD37F0", Slot = "4")]
			public void Execute(int EGBCAPEEJBF, TransformAccess PKIKNDCFAFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x2CD39B0", Offset = "0x2CD2DB0", VA = "0x182CD39B0")]
			private bool GOHCEKLGJPJ(float3 IEFBANIHOGG, float3 ENFEPLFMJNK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x2CD3780", Offset = "0x2CD2B80", VA = "0x182CD3780")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD2370", Offset = "0x2CD1770", VA = "0x182CD2370", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D59060", Offset = "0x2D58460", VA = "0x182D59060", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2D590D0", Offset = "0x2D584D0", VA = "0x182D590D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x2D59100", Offset = "0x2D58500", VA = "0x182D59100", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x41BE180", Offset = "0x41BD580", VA = "0x1841BE180")]
				public void LICMABLNMJG(RegisterTransforms JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x41BE0C0", Offset = "0x41BD4C0", VA = "0x1841BE0C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B8BB0", Offset = "0x41B7FB0", VA = "0x1841B8BB0")]
			internal void OCIBIOHOPKH(Entity PJEENOLDJIO, EKKIFIHKFLD FMNFDAHCLKF, Transform PKIKNDCFAFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x41B8960", Offset = "0x41B7D60", VA = "0x1841B8960", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x41B8AC0", Offset = "0x41B7EC0", VA = "0x1841B8AC0")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, ref PIGEBJHBNEJ.BKFKJHABCIN KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x41B8BA0", Offset = "0x41B7FA0", VA = "0x1841B8BA0")]
			public void LICMABLNMJG(RegisterTransforms JFLOFOFLJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x41B8A50", Offset = "0x41B7E50", VA = "0x1841B8A50")]
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
				[Cpp2IlInjected.Address(RVA = "0x41B6170", Offset = "0x41B5570", VA = "0x1841B6170")]
				public void LICMABLNMJG(RegisterTransforms JFLOFOFLJIH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x41B60F0", Offset = "0x41B54F0", VA = "0x1841B60F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B74C0", Offset = "0x41B68C0", VA = "0x1841B74C0")]
			internal void OCIBIOHOPKH(Entity PJEENOLDJIO, EKKIFIHKFLD FMNFDAHCLKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x41B7380", Offset = "0x41B6780", VA = "0x1841B7380", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int NOFANLFHHDM, int LCLJEOOJFPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x41B7410", Offset = "0x41B6810", VA = "0x1841B7410")]
			public void IGFMHINDANN(ref ArchetypeChunk NBAMNFJPPMO, [NoAlias] ref EAAMBLNHDPL.AILHLLKAEIE KMKJFLCAOML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x41B6170", Offset = "0x41B5570", VA = "0x1841B6170")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD6950", Offset = "0x2CD5D50", VA = "0x182CD6950", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7230", Offset = "0x2CD6630", VA = "0x182CD7230", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7440", Offset = "0x2CD6840", VA = "0x182CD7440", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6710", Offset = "0x2CD5B10", VA = "0x182CD6710")]
		private void JDJFCFAMOPM(EntityQuery APEJLGJADFF, DLGLKFHNPHN HNHPNLJGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6120", Offset = "0x2CD5520", VA = "0x182CD6120")]
		private void BJENGOHAFEL(EntityQuery APEJLGJADFF, DLGLKFHNPHN HNHPNLJGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x2CD73E0", Offset = "0x2CD67E0", VA = "0x182CD73E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x2CD69A0", Offset = "0x2CD5DA0", VA = "0x182CD69A0")]
		private void KNDELIFLDNB(NativeArray<Entity> GMAMPIGCEAB, DLGLKFHNPHN HNHPNLJGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6AE0", Offset = "0x2CD5EE0", VA = "0x182CD6AE0")]
		[BurstCompile]
		internal static void LNBAOAGDPHC(NativeArray<EKKIFIHKFLD> FAPDJHOMNBP, ComponentDataFromEntity<EKKIFIHKFLD> LMDOBONNMBE, DLGLKFHNPHN HNHPNLJGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		private static void NEFLBIDMHGB(Transform PKIKNDCFAFJ, Entity PJEENOLDJIO, int EGBCAPEEJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		private static void EAGEMOEOPCH(Entity PJEENOLDJIO, int EGBCAPEEJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		private static void EALIJHIBOHB(int EGBCAPEEJBF, DLGLKFHNPHN HNHPNLJGNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6530", Offset = "0x2CD5930", VA = "0x182CD6530")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void HJGKEGJMDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6FC0", Offset = "0x2CD63C0", VA = "0x182CD6FC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6390", Offset = "0x2CD5790", VA = "0x182CD6390")]
		public static EntityQuery CCGJKIDKLHE(ComponentSystemBase JFLOFOFLJIH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6DF0", Offset = "0x2CD61F0", VA = "0x182CD6DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD2B40", Offset = "0x2CD1F40", VA = "0x182CD2B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD5F80", Offset = "0x2CD5380", VA = "0x182CD5F80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD6020", Offset = "0x2CD5420", VA = "0x182CD6020", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D595B0", Offset = "0x2D589B0", VA = "0x182D595B0", Slot = "14")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x2D59780", Offset = "0x2D58B80", VA = "0x182D59780", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x2D59970", Offset = "0x2D58D70", VA = "0x182D59970", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x2D59A00", Offset = "0x2D58E00", VA = "0x182D59A00", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x2D59A30", Offset = "0x2D58E30", VA = "0x182D59A30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x2D59600", Offset = "0x2D58A00", VA = "0x182D59600")]
		private NativeArray<Entity> LJCJCGOGGIJ(NativeArray<EKKIFIHKFLD> CAHDBKNLLCN, NativeList<Entity> INCINPMOBBH, TransformAccessArray PHOCMDGPOCL, TransformAccessArray GHHOJCBLCMM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B5BA90", Offset = "0x2B5AE90", VA = "0x182B5BA90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A400", Offset = "0x2D59800", VA = "0x182D5A400", Slot = "14")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A690", Offset = "0x2D59A90", VA = "0x182D5A690", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A510", Offset = "0x2D59910", VA = "0x182D5A510")]
		private static void NNIPCDCHEHM(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, Entity OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A360", Offset = "0x2D59760", VA = "0x182D5A360")]
		private static bool CGMALIJKBMC(EntityManager JGDEKKJFKAJ, Entity PJEENOLDJIO, out Transform PKIKNDCFAFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BDCC0", Offset = "0x41BD0C0", VA = "0x1841BDCC0")]
			[Conditional("DEBUG_BUILD")]
			private void PFKMHOPKOLM(Entity PJEENOLDJIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x41BD5D0", Offset = "0x41BC9D0", VA = "0x1841BD5D0", Slot = "4")]
			public void Execute(ArchetypeChunk NBAMNFJPPMO, int EGBCAPEEJBF, int BFFCDCOGKIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x41BD8C0", Offset = "0x41BCCC0", VA = "0x1841BD8C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3128810", Offset = "0x3127C10", VA = "0x183128810", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x3128930", Offset = "0x3127D30", VA = "0x183128930", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CD5350", Offset = "0x2CD4750", VA = "0x182CD5350", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int EGBCAPEEJBF, int BFFCDCOGKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x2CD5450", Offset = "0x2CD4850", VA = "0x182CD5450")]
		public bool HGJBBDHLFGJ(ArchetypeChunk NBAMNFJPPMO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery PLMFIIKDHIN;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E520", Offset = "0x2D4D920", VA = "0x182D4E520", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E650", Offset = "0x2D4DA50", VA = "0x182D4E650", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle MBMDILHMIPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public CAMNDGJOEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x41BCD00", Offset = "0x41BC100", VA = "0x1841BCD00", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int EGBCAPEEJBF, int BFFCDCOGKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x41BD0B0", Offset = "0x41BC4B0", VA = "0x1841BD0B0")]
		public bool HGJBBDHLFGJ(ArchetypeChunk NBAMNFJPPMO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery GAICKEELBKP;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x3113680", Offset = "0x3112A80", VA = "0x183113680", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x3113790", Offset = "0x3112B90", VA = "0x183113790", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle MBMDILHMIPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0xE9AFD0", Offset = "0xE9A3D0", VA = "0x180E9AFD0")]
	public FEJGIKEOHDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x41B36E0", Offset = "0x41B2AE0", VA = "0x1841B36E0", Slot = "4")]
		public void Execute(ArchetypeChunk NBAMNFJPPMO, int EGBCAPEEJBF, int BFFCDCOGKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x41B3DF0", Offset = "0x41B31F0", VA = "0x1841B3DF0")]
		public bool HGJBBDHLFGJ(ArchetypeChunk NBAMNFJPPMO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery GAICKEELBKP;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x3120C30", Offset = "0x3120030", VA = "0x183120C30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x3120D60", Offset = "0x3120160", VA = "0x183120D60", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle MBMDILHMIPH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20")]
	public JBHKGDKMJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B5C4D0", Offset = "0x2B5B8D0", VA = "0x182B5C4D0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType ILDNNFHLDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C500", Offset = "0x2B5B900", VA = "0x182B5C500", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType HOEGHECCJPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x2B5C4A0", Offset = "0x2B5B8A0", VA = "0x182B5C4A0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5C400", Offset = "0x2B5B800", VA = "0x182B5C400")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x747C20", Offset = "0x747020", VA = "0x180747C20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D4B250", Offset = "0x2D4A650", VA = "0x182D4B250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] FCHPHLFAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x2D4ABE0", Offset = "0x2D49FE0", VA = "0x182D4ABE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] FCHPHLFAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2D622E0", Offset = "0x2D616E0", VA = "0x182D622E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public ENEDEFLCFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class FNJLPPNLJMI : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x3114E30", Offset = "0x3114230", VA = "0x183114E30", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public FNJLPPNLJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] FCHPHLFAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C110", Offset = "0x2D4B510", VA = "0x182D4C110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public BKMPJEINJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class CBPOBHNGDEN : FMHBHMFLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E7E0", Offset = "0x2D4DBE0", VA = "0x182D4E7E0", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public CBPOBHNGDEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3113CB0", Offset = "0x31130B0", VA = "0x183113CB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] FCHPHLFAFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x3113900", Offset = "0x3112D00", VA = "0x183113900", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D48340", Offset = "0x2D47740", VA = "0x182D48340", Slot = "4")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x310FF10", Offset = "0x310F310", VA = "0x18310FF10", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x310FAE0", Offset = "0x310EEE0", VA = "0x18310FAE0", Slot = "5")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x310FBE0", Offset = "0x310EFE0", VA = "0x18310FBE0")]
		public Entity FCHNDLGHOIE(Entity PJEENOLDJIO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x310FE10", Offset = "0x310F210", VA = "0x18310FE10")]
		public bool GLJCMDFJBFM(Entity PJEENOLDJIO, Entity KHLHKJKADHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x310FE70", Offset = "0x310F270", VA = "0x18310FE70")]
		public bool JDHACNMMLIE(Entity PJEENOLDJIO, Entity KHLHKJKADHO, bool ANHIENPBNCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x310FC30", Offset = "0x310F030", VA = "0x18310FC30")]
		private bool FEGHGECEIIF(Entity PJEENOLDJIO, Entity KHLHKJKADHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B42C80", Offset = "0x2B42080", VA = "0x182B42C80")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x2B42DD0", Offset = "0x2B421D0", VA = "0x182B42DD0", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x2B42C60", Offset = "0x2B42060", VA = "0x182B42C60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2B42F90", Offset = "0x2B42390", VA = "0x182B42F90")]
	public bool PFJDPANHIDM(Entity PJEENOLDJIO, Entity ADAJCIOPLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x2B43050", Offset = "0x2B42450", VA = "0x182B43050")]
	public IEnumerable<Entity> PKDPPNNMDAK(Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x2B429F0", Offset = "0x2B41DF0", VA = "0x182B429F0")]
	public bool CCMBIGLHNMK(Entity PJEENOLDJIO, Entity BOGHNKLNLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x2B42930", Offset = "0x2B41D30", VA = "0x182B42930")]
	public bool BEPDKIFHAFJ(Entity PJEENOLDJIO, Entity PDOBLLBCDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x2B42AB0", Offset = "0x2B41EB0", VA = "0x182B42AB0")]
	public NativeList<Entity> CHFELALAAIJ(Entity PJEENOLDJIO, bool GNDBKIJJAND = false, Allocator GOLNHBOGNGC = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x2B42ED0", Offset = "0x2B422D0", VA = "0x182B42ED0")]
	public IEnumerable<Entity> JNFNFOAALOH(Entity PJEENOLDJIO, bool GNDBKIJJAND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x2B43110", Offset = "0x2B42510", VA = "0x182B43110")]
	public Entity PLFCFKIEBOC(Entity PJEENOLDJIO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x2B42D80", Offset = "0x2B42180", VA = "0x182B42D80")]
	public NativeArray<Entity> JJOOJLAKEOM()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x2B42B90", Offset = "0x2B41F90", VA = "0x182B42B90")]
	public bool DBLIAABGAHD(Entity PDOBLLBCDKJ, Entity FENFFOFPKDO, out Entity HGNJLFHFDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x2B42CD0", Offset = "0x2B420D0", VA = "0x182B42CD0")]
	private Entity JBLCGLJHIOG(Entity PJEENOLDJIO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E8ECD0", Offset = "0x3E8E0D0", VA = "0x183E8ECD0")]
		public static void MGAGAAKAIAK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(FEPIHHOJCOJ HPFBGIEBCLA, global::CKGECMCPKDO<Entity> GPBJNICHLBB, out global::AJPCLLKECKK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> NDEMEIEOCFP) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, PGCNPEJMMNE where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, PGCNPEJMMNE, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2B56AA0", Offset = "0x2B55EA0", VA = "0x182B56AA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x25B2000", Offset = "0x25B1400", VA = "0x1825B2000")]
	public AJPCLLKECKK(FEPIHHOJCOJ HPFBGIEBCLA, global::CKGECMCPKDO<Entity> GPBJNICHLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x25B1640", Offset = "0x25B0A40", VA = "0x1825B1640")]
	private bool LGCIMFDMKLJ(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x25B0B00", Offset = "0x25AFF00", VA = "0x1825B0B00")]
	private bool BCFJNBEFCKB(Entity PJEENOLDJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x25B0C70", Offset = "0x25B0070", VA = "0x1825B0C70")]
	public bool GLJCMDFJBFM(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x25B0CA0", Offset = "0x25B00A0", VA = "0x1825B0CA0")]
	public bool JJKNOCNMDKP(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x25B0CD0", Offset = "0x25B00D0", VA = "0x1825B0CD0")]
	private bool JJKNOCNMDKP(Entity PJEENOLDJIO, in Entity KHLHKJKADHO, bool FMPKDFINFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private static void HHBKIMLAEJJ(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private static void CDOMMKEEELD(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private static void MNEFGHBHOAC(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private static void CNFIIAOIIDD(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private static void JAPGLHBFJAM(Entity PJEENOLDJIO, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x25B1700", Offset = "0x25B0B00", VA = "0x1825B1700")]
	private bool PFJDPANHIDM(Entity PJEENOLDJIO, Entity ADAJCIOPLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x25B18C0", Offset = "0x25B0CC0", VA = "0x1825B18C0")]
	private void PLGCGMOFAKO(Entity PJEENOLDJIO, in Entity KJNCJMANDLF, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x25B07C0", Offset = "0x25AFBC0", VA = "0x1825B07C0")]
	private void AFDBPDKMBKI(Entity PJEENOLDJIO, in Entity KJNCJMANDLF, in Entity KHLHKJKADHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x25B1110", Offset = "0x25B0510", VA = "0x1825B1110")]
	private bool KLGJIJHNJED(KACNPMDLMIP MCBFELIJCMG, in IJDKBBDMEBI NJCPGBBLOPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x25B1510", Offset = "0x25B0910", VA = "0x1825B1510")]
	private void LDFJFKBFDMD(Entity OKMBLMILFGG, Entity BOGHNKLNLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x25B0B50", Offset = "0x25AFF50", VA = "0x1825B0B50")]
	private void GFLPJLNLLDG(Entity OKMBLMILFGG, Entity BOGHNKLNLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private void EALIJHIBOHB(Entity PJEENOLDJIO, Entity KJNCJMANDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0000", Offset = "0x6DF400", VA = "0x1806E0000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(HLMPEBPKEBN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x745420", Offset = "0x744820", VA = "0x180745420", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B4BA20", Offset = "0x2B4AE20", VA = "0x182B4BA20")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int OKELKMPBJAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x2B4CED0", Offset = "0x2B4C2D0", VA = "0x182B4CED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int DKCGFGMKLNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A560", Offset = "0x2B49960", VA = "0x182B4A560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x10C4D40", Offset = "0x10C4140", VA = "0x1810C4D40", Slot = "4")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BCC0", Offset = "0x2B4B0C0", VA = "0x182B4BCC0", Slot = "5")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2B49FA0", Offset = "0x2B493A0", VA = "0x182B49FA0")]
		public void DDJDAFAEPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A580", Offset = "0x2B49980", VA = "0x182B4A580", Slot = "6")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A430", Offset = "0x2B49830", VA = "0x182B4A430", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2B49F60", Offset = "0x2B49360", VA = "0x182B49F60")]
		public int CLEDONPNABJ(SceneTag JLPOKIGCHBG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B140", Offset = "0x2B4A540", VA = "0x182B4B140")]
		public int GHLJGKCNJAI(SceneTag JLPOKIGCHBG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B750", Offset = "0x2B4AB50", VA = "0x182B4B750")]
		public bool IJAPGDOFHNC(Entity PJEENOLDJIO, Allocator GOLNHBOGNGC, out NativeList<Entity> PFBMHJNEFDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BA70", Offset = "0x2B4AE70", VA = "0x182B4BA70")]
		public bool JMGMOHAEDDO(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2B49F80", Offset = "0x2B49380", VA = "0x182B49F80")]
		public bool CPIAGHNENJJ(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BFB0", Offset = "0x2B4B3B0", VA = "0x182B4BFB0")]
		public bool KLLNBFNLACK(Entity PJEENOLDJIO, out EMAJLAJEHKH AIJDONAKHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BF00", Offset = "0x2B4B300", VA = "0x182B4BF00")]
		private bool KLLNBFNLACK(Transform PKIKNDCFAFJ, out EMAJLAJEHKH AIJDONAKHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C020", Offset = "0x2B4B420", VA = "0x182B4C020")]
		private void LDHHNPPIDMN(Entity PJEENOLDJIO, EMAJLAJEHKH AIJDONAKHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CE30", Offset = "0x2B4C230", VA = "0x182B4CE30")]
		private bool ODEOGIOICML(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AE50", Offset = "0x2B4A250", VA = "0x182B4AE50")]
		public void GBHABPPKBJN(IJDKBBDMEBI DGPLFECNDCD, EMAJLAJEHKH LJJGKNLIGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2B49FF0", Offset = "0x2B493F0", VA = "0x182B49FF0")]
		public bool DKJMMHKMEIK(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C6A0", Offset = "0x2B4BAA0", VA = "0x182B4C6A0")]
		public bool OCEBLLHENFE(GPEJGMHBDPO GBPGPLEPLBP, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CDE0", Offset = "0x2B4C1E0", VA = "0x182B4CDE0")]
		public bool OCEBLLHENFE(Entity PJEENOLDJIO, [Optional] object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CA50", Offset = "0x2B4BE50", VA = "0x182B4CA50")]
		public bool OCEBLLHENFE(EMAJLAJEHKH FKGNAFCFFNM, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B160", Offset = "0x2B4A560", VA = "0x182B4B160")]
		public bool HHLPCJAJHPN(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B530", Offset = "0x2B4A930", VA = "0x182B4B530")]
		public bool HHLPCJAJHPN(EMAJLAJEHKH AIJDONAKHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CA70", Offset = "0x2B4BE70", VA = "0x182B4CA70")]
		public bool OCEBLLHENFE(EMAJLAJEHKH AIJDONAKHON, [Optional] object JAKCBCDLMLB, bool AKNNPOEHKML = false, bool GDAKGKKKJIB = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A8F0", Offset = "0x2B49CF0", VA = "0x182B4A8F0")]
		public Transform FPAEAJMMINO(Entity PJEENOLDJIO, [Optional] object JAKCBCDLMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2B49E90", Offset = "0x2B49290", VA = "0x182B49E90")]
		public bool CGMALIJKBMC(Entity PJEENOLDJIO, out Transform PKIKNDCFAFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B050", Offset = "0x2B4A450", VA = "0x182B4B050")]
		public EMAJLAJEHKH GEMGJFNJBAB(Entity PJEENOLDJIO, [Optional] object JAKCBCDLMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C190", Offset = "0x2B4B590", VA = "0x182B4C190")]
		public void LNLDIFPJBJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x2B4AA60", Offset = "0x2B49E60", VA = "0x182B4AA60")]
		public void GAMKIILCKEA(SceneTag JLPOKIGCHBG, bool IKGFLBEBIIJ, global::DFJBCINJNGH<int> INEFPCANEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D210", Offset = "0x2B4C610", VA = "0x182B4D210")]
		private void PLAOKLEJJNE(Entity PJEENOLDJIO, bool IKGFLBEBIIJ, bool JJJAABLAABK, global::DFJBCINJNGH<int> INEFPCANEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A390", Offset = "0x2B49790", VA = "0x182B4A390")]
		private void DOLHFLACLHB(Entity PJEENOLDJIO, EMAJLAJEHKH AIJDONAKHON, bool IKGFLBEBIIJ, bool JJJAABLAABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x2B49AF0", Offset = "0x2B48EF0", VA = "0x182B49AF0")]
		public EMAJLAJEHKH BKPJBJAHFPL(Entity PJEENOLDJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B9A0", Offset = "0x2B4ADA0", VA = "0x182B4B9A0")]
		public bool IKALCDHMJEH(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CE50", Offset = "0x2B4C250", VA = "0x182B4CE50")]
		public bool ODMDIGGOFIK(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BE90", Offset = "0x2B4B290", VA = "0x182B4BE90")]
		public bool KFENFCDAEAH(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D7E0", Offset = "0x2B4CBE0", VA = "0x182B4D7E0")]
		public bool PODBFJOOFPP(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D710", Offset = "0x2B4CB10", VA = "0x182B4D710")]
		public bool PODBFJOOFPP(HLMPEBPKEBN BDCLOJHOMDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void LCHFPPHLBIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D150", Offset = "0x2B4C550", VA = "0x182B4D150")]
		private void PKJEHBIFOJM(bool NOONJLFPGAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C610", Offset = "0x2B4BA10", VA = "0x182B4C610")]
		private bool NHMPHOBHAIA(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2B4BDF0", Offset = "0x2B4B1F0", VA = "0x182B4BDF0")]
		private EMAJLAJEHKH KEECFPBAHLO(Entity PJEENOLDJIO, object JAKCBCDLMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C420", Offset = "0x2B4B820", VA = "0x182B4C420")]
		private EMAJLAJEHKH MLLCEFLEBEJ(Entity PJEENOLDJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2B4A6D0", Offset = "0x2B49AD0", VA = "0x182B4A6D0")]
		private (Vector3, Quaternion, Vector3) FNGBPLDCIMD(Entity PJEENOLDJIO)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2B49D80", Offset = "0x2B49180", VA = "0x182B49D80")]
		private void CBMAKDDNCFD(Entity PJEENOLDJIO, OBNHEEKLBIB IBFEICPOBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2B49A30", Offset = "0x2B48E30", VA = "0x182B49A30")]
		private void ANDMGAMIEMN(GPEJGMHBDPO GBPGPLEPLBP, EMAJLAJEHKH LJJGKNLIGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B560", Offset = "0x2B4A960", VA = "0x182B4B560")]
		private void ICIBIMIIPGG(EMAJLAJEHKH LJJGKNLIGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CF20", Offset = "0x2B4C320", VA = "0x182B4CF20")]
		private void OPCELEDPBNN(EMAJLAJEHKH AIJDONAKHON, Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2B49B40", Offset = "0x2B48F40", VA = "0x182B49B40")]
		private void BNFMPEAMBCE(Entity PJEENOLDJIO, EMAJLAJEHKH AIJDONAKHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4C0B0", Offset = "0x2B4B4B0", VA = "0x182B4C0B0")]
		private void LINEOMFIGBN(Entity PJEENOLDJIO, Transform PKIKNDCFAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2B4CEF0", Offset = "0x2B4C2F0", VA = "0x182B4CEF0")]
		private GPEJGMHBDPO ONMDEPNPKNN(Entity PJEENOLDJIO)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D8A0", Offset = "0x2B4CCA0", VA = "0x182B4D8A0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4B680", Offset = "0x2B4AA80", VA = "0x182B4B680")]
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
	[Cpp2IlInjected.Address(RVA = "0x31254A0", Offset = "0x31248A0", VA = "0x1831254A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B4E7B0", Offset = "0x2B4DBB0", VA = "0x182B4E7B0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, OBNHEEKLBIB> LONFBPMMGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E670", Offset = "0x2B4DA70", VA = "0x182B4E670")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E1D0", Offset = "0x2B4D5D0", VA = "0x182B4E1D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> NJBAOBGNPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E5D0", Offset = "0x2B4D9D0", VA = "0x182B4E5D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x2B4E270", Offset = "0x2B4D670", VA = "0x182B4E270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E890", Offset = "0x2B4DC90", VA = "0x182B4E890", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x1957BF0", Offset = "0x1956FF0", VA = "0x181957BF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E510", Offset = "0x2B4D910", VA = "0x182B4E510")]
		public bool BKIFKBMENNF(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E170", Offset = "0x2B4D570", VA = "0x182B4E170")]
		internal void AEMLKBKAAHB(Entity PJEENOLDJIO, OBNHEEKLBIB IBFEICPOBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E590", Offset = "0x2B4D990", VA = "0x182B4E590")]
		public void DBEGAACJLOG(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E760", Offset = "0x2B4DB60", VA = "0x182B4E760")]
		public void IIEHKMHGPPF(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E0B0", Offset = "0x2B4D4B0", VA = "0x182B4E0B0")]
		private bool AAMEFLDCGEG(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E310", Offset = "0x2B4D710", VA = "0x182B4E310")]
		public void BAFMLPIANAD(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E9D0", Offset = "0x2B4DDD0", VA = "0x182B4E9D0")]
		private bool KPEPCHEBEIO(Entity PJEENOLDJIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E800", Offset = "0x2B4DC00", VA = "0x182B4E800")]
		public void JMGLAECFLLN(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E970", Offset = "0x2B4DD70", VA = "0x182B4E970")]
		private void KONALOJIFAD(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2B4EB90", Offset = "0x2B4DF90", VA = "0x182B4EB90")]
		private void MICEHPFDJMJ(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E710", Offset = "0x2B4DB10", VA = "0x182B4E710")]
		public void GAKJMOCPHOD(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		private void OANDCCGGIBF(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x2B4EDF0", Offset = "0x2B4E1F0", VA = "0x182B4EDF0")]
		private void NCCMKGOOLMK(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x270BC50", Offset = "0x270B050", VA = "0x18270BC50", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x41B5FD0", Offset = "0x41B53D0", VA = "0x1841B5FD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x41B4AA0", Offset = "0x41B3EA0", VA = "0x1841B4AA0")]
			[DebuggerHidden]
			public DLMMPPCGMPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x41B5DF0", Offset = "0x41B51F0", VA = "0x1841B5DF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x41B5F90", Offset = "0x41B5390", VA = "0x1841B5F90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x41B5EF0", Offset = "0x41B52F0", VA = "0x1841B5EF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(MCLBIBPLLEA, OBNHEEKLBIB)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x41B5EF0", Offset = "0x41B52F0", VA = "0x1841B5EF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B526C0", Offset = "0x2B51AC0", VA = "0x182B526C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x2B52190", Offset = "0x2B51590", VA = "0x182B52190")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x2B521B0", Offset = "0x2B515B0", VA = "0x182B521B0", Slot = "5")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x2B516A0", Offset = "0x2B50AA0", VA = "0x182B516A0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x2B52590", Offset = "0x2B51990", VA = "0x182B52590")]
		internal IEnumerable<Type> KMECGPEEKNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x2B52650", Offset = "0x2B51A50", VA = "0x182B52650")]
		internal EADJHKFEPHB NAADMHBFLJJ(Type HAOFNDAEGFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x2B525F0", Offset = "0x2B519F0", VA = "0x182B525F0")]
		public EntityArchetype LIKCJCCEEML(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x2B52710", Offset = "0x2B51B10", VA = "0x182B52710")]
		public NativeHashMap<int, EntityArchetype> OADBMDPJFAA(Allocator GOLNHBOGNGC = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x2B52060", Offset = "0x2B51460", VA = "0x182B52060")]
		public bool IHPGGKKJONC(OBNHEEKLBIB IBFEICPOBBG, out EntityArchetype GOEEEEBMLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x2B51630", Offset = "0x2B50A30", VA = "0x182B51630", Slot = "4")]
		[IteratorStateMachine(typeof(DLMMPPCGMPF))]
		public IEnumerable<(MCLBIBPLLEA, OBNHEEKLBIB)> BJDHAHLCMPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x2B51B90", Offset = "0x2B50F90", VA = "0x182B51B90")]
		public Entity GCBMLPIIEEI(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x2B52130", Offset = "0x2B51530", VA = "0x182B52130")]
		public OBNHEEKLBIB IJPMOHIFBJK(LFGFCMFBCNM HAOFNDAEGFJ)
		{
			return default(OBNHEEKLBIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x2B520D0", Offset = "0x2B514D0", VA = "0x182B520D0")]
		public OBNHEEKLBIB IJPMOHIFBJK(MCLBIBPLLEA HAOFNDAEGFJ)
		{
			return default(OBNHEEKLBIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2B51A20", Offset = "0x2B50E20", VA = "0x182B51A20")]
		public NativeHashMap<int, Entity> ELIBOEJPFPF(Allocator GOLNHBOGNGC = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2B519D0", Offset = "0x2B50DD0", VA = "0x182B519D0")]
		public IEnumerable<OBNHEEKLBIB> ELDKICPEIAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x2B529F0", Offset = "0x2B51DF0", VA = "0x182B529F0")]
		public Entity OHMHGAHGEDO(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x2B51CA0", Offset = "0x2B510A0", VA = "0x182B51CA0")]
		public bool GOIDOBEHMKN(OBNHEEKLBIB IBFEICPOBBG, out Entity IJBPCAELLON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x2B52A50", Offset = "0x2B51E50", VA = "0x182B52A50")]
		private void PHGADILCCDJ(EADJHKFEPHB GMLCPNMKKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x2B51E30", Offset = "0x2B51230", VA = "0x182B51E30")]
		internal void IHEGNPLFLCB(OBNHEEKLBIB IBFEICPOBBG, ComponentTypeList JMAALAELOEJ, MFECPBIKMNM BGJMDFDIANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x2B52890", Offset = "0x2B51C90", VA = "0x182B52890")]
		private void OCDOEOMMJBC(OBNHEEKLBIB IBFEICPOBBG, ComponentTypeList MDPFJMFBAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x2B51D10", Offset = "0x2B51110", VA = "0x182B51D10")]
		internal Entity HNCHNFAFPMN(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x2B52EF0", Offset = "0x2B522F0", VA = "0x182B52EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B43EF0", Offset = "0x2B432F0", VA = "0x182B43EF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private KDNHCONPDAI FABDBHDPBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2B43210", Offset = "0x2B42610", VA = "0x182B43210", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private NFFGAJCCLIN MNONINDJKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4D40", Offset = "0x6F4140", VA = "0x1806F4D40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, MEGNPFABGGE> DBIAPNDDDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x701030", Offset = "0x700430", VA = "0x180701030", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, MEGNPFABGGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle OAGPBGCEAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x1328600", Offset = "0x1327A00", VA = "0x181328600", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8110", Offset = "0x1DB7510", VA = "0x181DB8110", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool GFCOLJLAACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x2B43230", Offset = "0x2B42630", VA = "0x182B43230", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World CEFJMBBLPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x2B43B20", Offset = "0x2B42F20", VA = "0x182B43B20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x2B43FF0", Offset = "0x2B433F0", VA = "0x182B43FF0")]
	public MLJIAFDGHKL(AJCPIOLJNKH CNDDLBPKDGJ, ENGIDADGGAI LPKJFCDGPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x2B431C0", Offset = "0x2B425C0", VA = "0x182B431C0", Slot = "11")]
	private void ADCBONGPGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x2B43A30", Offset = "0x2B42E30", VA = "0x182B43A30", Slot = "10")]
	private bool JEBMFJDBMPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x2B432B0", Offset = "0x2B426B0", VA = "0x182B432B0", Slot = "12")]
	private void FBELMOLADLN(ComponentType DDFJPMOIHNM, in IDEGAILMGHG GFJDKJPDPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x2B43240", Offset = "0x2B42640", VA = "0x182B43240", Slot = "13")]
	private bool DDFJDJGEANG(OBNHEEKLBIB IBFEICPOBBG, out Entity IJBPCAELLON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x2B43F50", Offset = "0x2B43350", VA = "0x182B43F50", Slot = "16")]
	private bool OOEOABAJJJF(out NativeArray<int> CJNALNIEFIB, Allocator GOLNHBOGNGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x2B43780", Offset = "0x2B42B80", VA = "0x182B43780", Slot = "17")]
	private bool GGIIIOKHLON(ComponentType DDFJPMOIHNM, out IDEGAILMGHG BMOGBHKCIKH, out JPEEACBJEJB JJPMEEGFFGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x2B43650", Offset = "0x2B42A50", VA = "0x182B43650", Slot = "18")]
	private bool GGIIIOKHLON(ComponentType DDFJPMOIHNM, out IDEGAILMGHG BMOGBHKCIKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x2B43900", Offset = "0x2B42D00", VA = "0x182B43900", Slot = "19")]
	private IDEGAILMGHG IENEEFAEBGB(ComponentType DDFJPMOIHNM)
	{
		return default(IDEGAILMGHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x2B431D0", Offset = "0x2B425D0", VA = "0x182B431D0", Slot = "20")]
	private DLBHGBHCIGG AHMGDGAEDMK()
	{
		return default(DLBHGBHCIGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x2B439F0", Offset = "0x2B42DF0", VA = "0x182B439F0", Slot = "21")]
	private void IJAIOOPCHNI(JobHandle DGGOEPGELHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x2B433A0", Offset = "0x2B427A0", VA = "0x182B433A0")]
	public void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x2B43CD0", Offset = "0x2B430D0", VA = "0x182B43CD0")]
	private bool MPGAPHPBGFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2B43B80", Offset = "0x2B42F80", VA = "0x182B43B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D47B70", Offset = "0x2D46F70", VA = "0x182D47B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public KDNHCONPDAI HNMCOECENCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B60A0", Offset = "0x41B54A0", VA = "0x1841B60A0")]
			public DNPLLOBJPPN(PropertyDiffStateService GNJOCELFONM, ENGIDADGGAI EFLCOPLIDLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x41B6080", Offset = "0x41B5480", VA = "0x1841B6080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public ADIGHOEHBBA NCAPNFBPPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D320", Offset = "0x2B5C720", VA = "0x182B5D320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public BFHHLLCINGL LJCFDCJLPGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x2B5D320", Offset = "0x2B5C720", VA = "0x182B5D320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE60", Offset = "0x8AD260", VA = "0x1808ADE60")]
		public ADIGHOEHBBA IIICEPLLPOE(ENGIDADGGAI LPKJFCDGPPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE60", Offset = "0x8AD260", VA = "0x1808ADE60")]
		public BFHHLLCINGL NENFCOIJJCO(ENGIDADGGAI LPKJFCDGPPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D9B0", Offset = "0x2B5CDB0", VA = "0x182B5D9B0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D510", Offset = "0x2B5C910", VA = "0x182B5D510", Slot = "5")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D950", Offset = "0x2B5CD50", VA = "0x182B5D950")]
		public void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D360", Offset = "0x2B5C760", VA = "0x182B5D360", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D930", Offset = "0x2B5CD30", VA = "0x182B5D930")]
		public DNPLLOBJPPN FJBJJDMAHDE(ENGIDADGGAI LPKJFCDGPPB)
		{
			return default(DNPLLOBJPPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DA80", Offset = "0x2B5CE80", VA = "0x182B5DA80")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CD94A0", Offset = "0x2CD88A0", VA = "0x182CD94A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> MMDKMABPOEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x15AB660", Offset = "0x15AAA60", VA = "0x1815AB660")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0x21A5CD0", Offset = "0x21A50D0", VA = "0x1821A5CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity NHDHGIPPGNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x2CD7B70", Offset = "0x2CD6F70", VA = "0x182CD7B70")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag CFMNECNKNCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x2CD88F0", Offset = "0x2CD7CF0", VA = "0x182CD88F0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity MLPNHPBGJDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x2CD88F0", Offset = "0x2CD7CF0", VA = "0x182CD88F0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x2CD8B70", Offset = "0x2CD7F70", VA = "0x182CD8B70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x2CD8D70", Offset = "0x2CD8170", VA = "0x182CD8D70")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2CD90C0", Offset = "0x2CD84C0", VA = "0x182CD90C0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7D90", Offset = "0x2CD7190", VA = "0x182CD7D90", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9080", Offset = "0x2CD8480", VA = "0x182CD9080")]
		public void JMELJNJFPGN(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8E70", Offset = "0x2CD8270", VA = "0x182CD8E70")]
		public NativeArray<Entity> JHLMEAAPBJD(Allocator GOLNHBOGNGC = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8430", Offset = "0x2CD7830", VA = "0x182CD8430")]
		public void ELENEGOBLIL(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2CD91E0", Offset = "0x2CD85E0", VA = "0x182CD91E0")]
		public Entity JMOAKLIBCCD(string GOENAEMJAON = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9480", Offset = "0x2CD8880", VA = "0x182CD9480")]
		public void PBODALFBJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9310", Offset = "0x2CD8710", VA = "0x182CD9310")]
		public void MBBOHHGLIIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7DE0", Offset = "0x2CD71E0", VA = "0x182CD7DE0")]
		public void EANLCDJNFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8530", Offset = "0x2CD7930", VA = "0x182CD8530")]
		public void GOELJBODCNJ(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8DC0", Offset = "0x2CD81C0", VA = "0x182CD8DC0")]
		public bool IPADCBPCPGH(Entity JLPOKIGCHBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9470", Offset = "0x2CD8870", VA = "0x182CD9470")]
		public void OOJCMAGCADB(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2CD78B0", Offset = "0x2CD6CB0", VA = "0x182CD78B0")]
		public string BIHINHGILHF(Entity JLPOKIGCHBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		public void EDKCKEIEAOD(Entity JLPOKIGCHBG, string GOENAEMJAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8940", Offset = "0x2CD7D40", VA = "0x182CD8940")]
		public bool HNDJOPDNOAF(string GOENAEMJAON, out Entity JLPOKIGCHBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9360", Offset = "0x2CD8760", VA = "0x182CD9360")]
		public void NFMBMJKEPII(Entity JLPOKIGCHBG, bool ENINEBIKNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9000", Offset = "0x2CD8400", VA = "0x182CD9000")]
		public void JMBFOGIBBKI(Entity PJEENOLDJIO, bool ONDAHMMKLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8F90", Offset = "0x2CD8390", VA = "0x182CD8F90")]
		public void JMBFOGIBBKI(NativeArray<Entity> GMAMPIGCEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8EA0", Offset = "0x2CD82A0", VA = "0x182CD8EA0")]
		public void JMBFOGIBBKI(EntityQuery APEJLGJADFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7EF0", Offset = "0x2CD72F0", VA = "0x182CD7EF0")]
		public void EJGFBNMKAFK(Entity PJEENOLDJIO, Entity JLPOKIGCHBG, bool ONDAHMMKLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8120", Offset = "0x2CD7520", VA = "0x182CD8120")]
		public void EJGFBNMKAFK(NativeArray<Entity> GMAMPIGCEAB, Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7E40", Offset = "0x2CD7240", VA = "0x182CD7E40")]
		public void EJGFBNMKAFK(EntityQuery APEJLGJADFF, Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2CD79C0", Offset = "0x2CD6DC0", VA = "0x182CD79C0")]
		private void CDICGMDKLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7D20", Offset = "0x2CD7120", VA = "0x182CD7D20")]
		private void DBDBLBIBDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7B70", Offset = "0x2CD6F70", VA = "0x182CD7B70")]
		private Entity GIEMINCDJOD()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9260", Offset = "0x2CD8660", VA = "0x182CD9260")]
		private void LJCJIFIFHHG(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8820", Offset = "0x2CD7C20", VA = "0x182CD8820")]
		private void GPOMEJECHAB(EntityQuery CPAINGMLFPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8540", Offset = "0x2CD7940", VA = "0x182CD8540")]
		private void GPOMEJECHAB(NativeArray<Entity> LKMIJPPNOAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7800", Offset = "0x2CD6C00", VA = "0x182CD7800")]
		private void AAPDCAOIAGP(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8300", Offset = "0x2CD7700", VA = "0x182CD8300")]
		private void EKMPEDDELDN(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8A00", Offset = "0x2CD7E00", VA = "0x182CD8A00")]
		private void IBEJHOGDGPK(SceneTag ECMPHEDFJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7D50", Offset = "0x2CD7150", VA = "0x182CD7D50")]
		private void DEBNKFEGAMC(SceneTag ECMPHEDFJAA, global::DFJBCINJNGH<int> INEFPCANEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8BE0", Offset = "0x2CD7FE0", VA = "0x182CD8BE0")]
		private void IGOEFMKPOKC(SceneTag ECMPHEDFJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8960", Offset = "0x2CD7D60", VA = "0x182CD8960")]
		private void IAOBMGOFNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x37283F0", Offset = "0x37277F0", VA = "0x1837283F0")]
		private void GBMGJJMIHBD<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void IDMKFOIFGMM(SceneTag ECMPHEDFJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7CC0", Offset = "0x2CD70C0", VA = "0x182CD7CC0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void COBHPPIELJI(EntityQuery APEJLGJADFF, string GOENAEMJAON, SceneTag ECMPHEDFJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2CD9330", Offset = "0x2CD8730", VA = "0x182CD9330")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void MLPNNPNKCMA(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void NGNBNLLDKHA(Entity JLPOKIGCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CE6FE0", Offset = "0x2CE63E0", VA = "0x182CE6FE0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x2CE71A0", Offset = "0x2CE65A0", VA = "0x182CE71A0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7030", Offset = "0x2CE6430", VA = "0x182CE7030", Slot = "5")]
		public void JMELJNJFPGN(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x2CE6DF0", Offset = "0x2CE61F0", VA = "0x182CE6DF0", Slot = "6")]
		public bool HHEDFEIEHGE(GPEJGMHBDPO GBPGPLEPLBP, Transform PKIKNDCFAFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7230", Offset = "0x2CE6630", VA = "0x182CE7230")]
		private bool PAIIKHJPBKK(Scene JLPOKIGCHBG, out Entity ODFLICDBILE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2CE72A0", Offset = "0x2CE66A0", VA = "0x182CE72A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CDE430", Offset = "0x2CDD830", VA = "0x182CDE430")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity OIMONIPJMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager DDFIBDHKCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x2CDE070", Offset = "0x2CDD470", VA = "0x182CDE070")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x3729CE0", Offset = "0x37290E0", VA = "0x183729CE0")]
		public T BOEAFIEBIHC<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x3729DA0", Offset = "0x37291A0", VA = "0x183729DA0")]
		public void JPNFGACMGOG<T>(T KPPLMEOMNGF) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE0C0", Offset = "0x2CDD4C0", VA = "0x182CDE0C0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x2CDDED0", Offset = "0x2CDD2D0", VA = "0x182CDDED0", Slot = "5")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x2CDDED0", Offset = "0x2CDD2D0", VA = "0x182CDDED0")]
		private void JHIKPAHHLJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x2CDDB60", Offset = "0x2CDCF60", VA = "0x182CDDB60", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE130", Offset = "0x2CDD530", VA = "0x182CDE130")]
		private ComponentTypeList KMHLNGCODFP()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		private static void MDJJBCOLMCA(int KJAHKKMJHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		private static void OLAMCDMKCKN(Type HAOFNDAEGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x2CDDE30", Offset = "0x2CDD230", VA = "0x182CDDE30")]
		private static void EHHGLFMFANK(Type HAOFNDAEGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public FOIFNBDOPHG LCOLAJIIDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public FOIFNBDOPHG JANEGFAEFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public FOIFNBDOPHG AJLHAKJEEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public FOIFNBDOPHG CCCDBGFCEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public FOIFNBDOPHG GFOEMCFLMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x6E7580", Offset = "0x6E6980", VA = "0x1806E7580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager DDFIBDHKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2B41020", Offset = "0x2B40420", VA = "0x182B41020")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x2B41070", Offset = "0x2B40470", VA = "0x182B41070", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x2B40F30", Offset = "0x2B40330", VA = "0x182B40F30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x29D9EB0", Offset = "0x29D92B0", VA = "0x1829D9EB0")]
	private void MGAGAAKAIAK<T>(ref global::BLGJBPKCMHC<T> ABGEACDGIFN) where T : struct, LOINMAGCOGI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x29D9EB0", Offset = "0x29D92B0", VA = "0x1829D9EB0")]
	private void MGAGAAKAIAK<TC, TV>(ref global::CMEECFLOIOG<TC, TV> ABGEACDGIFN) where TC : struct, LOINMAGCOGI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x27E4270", Offset = "0x27E3670", VA = "0x1827E4270")]
		get
		{
			return default(DLGLKFHNPHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x2D4AB50", Offset = "0x2D49F50", VA = "0x182D4AB50", Slot = "4")]
	public void IDHODADPCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x2D4AB40", Offset = "0x2D49F40", VA = "0x182D4AB40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x41BACF0", Offset = "0x41BA0F0", VA = "0x1841BACF0")]
			public KMACIEDNIMC(TransformOwnershipPhase OKMBLMILFGG, CGLIONODIEH LPKJFCDGPPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x41BACD0", Offset = "0x41BA0D0", VA = "0x1841BACD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040")]
			get
			{
				return default(CGLIONODIEH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x700F30", Offset = "0x700330", VA = "0x180700F30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool JLFKGHOLHAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xB7A210", Offset = "0xB79610", VA = "0x180B7A210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool AHMDAPIFBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x129C420", Offset = "0x129B820", VA = "0x18129C420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1730", Offset = "0x2CE0B30", VA = "0x182CE1730")]
		public KMACIEDNIMC GACKDKHDLDA()
		{
			return default(KMACIEDNIMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE1700", Offset = "0x2CE0B00", VA = "0x182CE1700")]
		public KMACIEDNIMC EDOHLAGGJCK()
		{
			return default(KMACIEDNIMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D51E30", Offset = "0x2D51230", VA = "0x182D51E30", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2D52230", Offset = "0x2D51630", VA = "0x182D52230", Slot = "5")]
		public bool OOECJDIBCJG(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2D512E0", Offset = "0x2D506E0", VA = "0x182D512E0", Slot = "7")]
		public bool ANEFOLKNAML(GPEJGMHBDPO GBPGPLEPLBP, out Guid APEBDJMHLDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2D51C30", Offset = "0x2D51030", VA = "0x182D51C30", Slot = "8")]
		public Guid GPFKGAPLFOM(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2D51FD0", Offset = "0x2D513D0", VA = "0x182D51FD0", Slot = "9")]
		public void OJJGJMGDHKM(GPEJGMHBDPO GBPGPLEPLBP, Guid APEBDJMHLDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2D51D40", Offset = "0x2D51140", VA = "0x182D51D40", Slot = "10")]
		public bool JKFHLGOCOCL(GPEJGMHBDPO GBPGPLEPLBP, out Guid EOJILANFMJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2D515B0", Offset = "0x2D509B0", VA = "0x182D515B0", Slot = "11")]
		public Guid BOGBLLJOODM(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2D52330", Offset = "0x2D51730", VA = "0x182D52330", Slot = "12")]
		public void PDMPFOHPPIM(GPEJGMHBDPO GBPGPLEPLBP, Guid EOJILANFMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x2D51ED0", Offset = "0x2D512D0", VA = "0x182D51ED0", Slot = "13")]
		public bool KDIANNPMDKF(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x2D51540", Offset = "0x2D50940", VA = "0x182D51540", Slot = "14")]
		public void BLEBBBBBHKJ(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2D51870", Offset = "0x2D50C70", VA = "0x182D51870", Slot = "15")]
		public void GGBFNFKCOCA(GPEJGMHBDPO NMAMPMADCBK, GPEJGMHBDPO OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2D513D0", Offset = "0x2D507D0", VA = "0x182D513D0")]
		private void BCKHPMBMBJO(GMACJOGODPF JPGPKCIKOBK, GPEJGMHBDPO OKMBLMILFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2D51150", Offset = "0x2D50550", VA = "0x182D51150")]
		private void ACAAABHNDBA(GMACJOGODPF JPGPKCIKOBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2D51720", Offset = "0x2D50B20", VA = "0x182D51720")]
		private bool FDLCKPKNNLO(CDFLNPBCBAA AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2D51F20", Offset = "0x2D51320", VA = "0x182D51F20")]
		private bool KNNMBDGPCPK(CDFLNPBCBAA AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2D516C0", Offset = "0x2D50AC0", VA = "0x182D516C0", Slot = "6")]
		public bool DLJJNAGJIEG(GPEJGMHBDPO LCCDBPIJCNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
				[Cpp2IlInjected.Address(RVA = "0x701040", Offset = "0x700440", VA = "0x180701040", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2CD4CE0", Offset = "0x2CD40E0", VA = "0x182CD4CE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x987E80", Offset = "0x987280", VA = "0x180987E80")]
			[DebuggerHidden]
			public KILKHJDNCCJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x2CD4D30", Offset = "0x2CD4130", VA = "0x182CD4D30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x2CD48F0", Offset = "0x2CD3CF0", VA = "0x182CD48F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x2CD4E00", Offset = "0x2CD4200", VA = "0x182CD4E00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x2CD4E50", Offset = "0x2CD4250", VA = "0x182CD4E50")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x2CD4CA0", Offset = "0x2CD40A0", VA = "0x182CD4CA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x2CD4BF0", Offset = "0x2CD3FF0", VA = "0x182CD4BF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GPEJGMHBDPO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x2CD4BF0", Offset = "0x2CD3FF0", VA = "0x182CD4BF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F6750", Offset = "0x6F5B50", VA = "0x1806F6750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x8130C0", Offset = "0x8124C0", VA = "0x1808130C0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<GPEJGMHBDPO, GPEJGMHBDPO> INOBOELIHGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x2D56E40", Offset = "0x2D56240", VA = "0x182D56E40", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x2D56920", Offset = "0x2D55D20", VA = "0x182D56920", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<GPEJGMHBDPO, GPEJGMHBDPO> AODOAHCEEHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x2D57D30", Offset = "0x2D57130", VA = "0x182D57D30", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x2D569C0", Offset = "0x2D55DC0", VA = "0x182D569C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<GPEJGMHBDPO, GPEJGMHBDPO, GPEJGMHBDPO> HFJJFLHPAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x2D57840", Offset = "0x2D56C40", VA = "0x182D57840", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x2D56D40", Offset = "0x2D56140", VA = "0x182D56D40", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<GPEJGMHBDPO> GLMHPCHPLPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x2D57C90", Offset = "0x2D57090", VA = "0x182D57C90", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2D56710", Offset = "0x2D55B10", VA = "0x182D56710", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x2D57A10", Offset = "0x2D56E10", VA = "0x182D57A10", Slot = "25")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x2D57250", Offset = "0x2D56650", VA = "0x182D57250", Slot = "26")]
		public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x2D56EE0", Offset = "0x2D562E0", VA = "0x182D56EE0", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x2D56DE0", Offset = "0x2D561E0", VA = "0x182D56DE0")]
		private void DJCMEJLBKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x2D567B0", Offset = "0x2D55BB0", VA = "0x182D567B0")]
		private void BFKAFDKKDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x2D57090", Offset = "0x2D56490", VA = "0x182D57090")]
		private void EPKHBNJNPOI(Entity PJEENOLDJIO, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM ENFEPLFMJNK, MPOLKMCKMLM IEFBANIHOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x2D56B10", Offset = "0x2D55F10", VA = "0x182D56B10")]
		private void DAFALAINKDK(Entity PJEENOLDJIO, BPHAMHGLCNC AOKMGDODDPA, MPOLKMCKMLM ENFEPLFMJNK, MPOLKMCKMLM IEFBANIHOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x1E38E90", Offset = "0x1E38290", VA = "0x181E38E90", Slot = "14")]
		public GPEJGMHBDPO MGDOBBAPFPD(GPEJGMHBDPO GBPGPLEPLBP, int BLFHAJEHJFK)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x1461B50", Offset = "0x1460F50", VA = "0x181461B50", Slot = "15")]
		public Color MNCGELPPEGP(GPEJGMHBDPO GBPGPLEPLBP, int BLFHAJEHJFK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2D57E60", Offset = "0x2D57260", VA = "0x182D57E60", Slot = "16")]
		public float3 PLELCPCFFPP(GPEJGMHBDPO GBPGPLEPLBP, int BLFHAJEHJFK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2D56260", Offset = "0x2D55660", VA = "0x182D56260", Slot = "17")]
		public bool AAFEMIFHGLM(GPEJGMHBDPO GBPGPLEPLBP, GPEJGMHBDPO LOGHNPBJPGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2D56A60", Offset = "0x2D55E60", VA = "0x182D56A60", Slot = "18")]
		public GPEJGMHBDPO CEEOGDGFJIM(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2D576F0", Offset = "0x2D56AF0", VA = "0x182D576F0", Slot = "21")]
		public void FJDLPPGILIA(GPEJGMHBDPO GBPGPLEPLBP, Vector3 MDNCMKKCHIF, Quaternion KJNACLNKACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2D578E0", Offset = "0x2D56CE0", VA = "0x182D578E0", Slot = "23")]
		public float3 HNNEKJLPDCG(PKBLDCAOGAD PLOBJHJCCPA)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2D57980", Offset = "0x2D56D80", VA = "0x182D57980", Slot = "24")]
		public quaternion JKAHAIGFPCF(PKBLDCAOGAD PLOBJHJCCPA)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2D57B90", Offset = "0x2D56F90", VA = "0x182D57B90", Slot = "28")]
		public RigidTransform KHHDHCINGPM(PKBLDCAOGAD PLOBJHJCCPA)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2D56310", Offset = "0x2D55710", VA = "0x182D56310", Slot = "22")]
		public bool AICNMJGJMLB(GPEJGMHBDPO GBPGPLEPLBP, out RigidTransform LLIGAMMEJDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2D57DD0", Offset = "0x2D571D0", VA = "0x182D57DD0", Slot = "19")]
		[IteratorStateMachine(typeof(KILKHJDNCCJ))]
		public IEnumerable<GPEJGMHBDPO> PEKEMJACJCC(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x2D565B0", Offset = "0x2D559B0", VA = "0x182D565B0", Slot = "20")]
		public GPEJGMHBDPO AKMDKGCFANK(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2D56B70", Offset = "0x2D55F70", VA = "0x182D56B70", Slot = "29")]
		public void DCHFFGHDPLJ(ref List<GPEJGMHBDPO> NKLDGGPGPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2D56490", Offset = "0x2D55890", VA = "0x182D56490")]
		private Entity AKMDKGCFANK(Entity PJEENOLDJIO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2D580D0", Offset = "0x2D574D0", VA = "0x182D580D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B4DAF0", Offset = "0x2B4CEF0", VA = "0x182B4DAF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DB40", Offset = "0x2B4CF40", VA = "0x182B4DB40", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DAD0", Offset = "0x2B4CED0", VA = "0x182B4DAD0")]
		public Entity HBBIFLCNHAN(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DCD0", Offset = "0x2B4D0D0", VA = "0x182B4DCD0")]
		public Entity NFKICFAFKEF(IJDKBBDMEBI DGPLFECNDCD, OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DD40", Offset = "0x2B4D140", VA = "0x182B4DD40")]
		public Entity NPGIBDEMFPM(OBNHEEKLBIB IBFEICPOBBG, bool BABPFLEGDHL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DD30", Offset = "0x2B4D130", VA = "0x182B4DD30")]
		public Entity NPGIBDEMFPM(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D9A0", Offset = "0x2B4CDA0", VA = "0x182B4D9A0")]
		public Entity DPPJEBGFDDC()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DA00", Offset = "0x2B4CE00", VA = "0x182B4DA00")]
		public Entity FEGDAGMALKP(MCLBIBPLLEA HAOFNDAEGFJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D920", Offset = "0x2B4CD20", VA = "0x182B4D920")]
		public Entity CMIPAENJOBN(LFGFCMFBCNM HAOFNDAEGFJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DA80", Offset = "0x2B4CE80", VA = "0x182B4DA80")]
		public NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)> GCBMLPIIEEI(NativeArray<GPEJGMHBDPO> PJAAAGDAINA, Allocator GOLNHBOGNGC)
		{
			return default(NativeArray<(GPEJGMHBDPO, GPEJGMHBDPO)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2B4D9B0", Offset = "0x2B4CDB0", VA = "0x182B4D9B0")]
		public IEnumerable<OBNHEEKLBIB> ELDKICPEIAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DC70", Offset = "0x2B4D070", VA = "0x182B4DC70")]
		public EntityArchetype LIKCJCCEEML(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DDD0", Offset = "0x2B4D1D0", VA = "0x182B4DDD0")]
		public Entity OHMHGAHGEDO(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DE30", Offset = "0x2B4D230", VA = "0x182B4DE30")]
		private Entity PMHCHMLLONO(OBNHEEKLBIB IBFEICPOBBG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DEB0", Offset = "0x2B4D2B0", VA = "0x182B4DEB0")]
		private Entity PMHCHMLLONO(OBNHEEKLBIB IBFEICPOBBG, bool BABPFLEGDHL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2B4DF40", Offset = "0x2B4D340", VA = "0x182B4DF40")]
		private Entity PMHCHMLLONO(OBNHEEKLBIB IBFEICPOBBG, IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B58220", Offset = "0x2B57620", VA = "0x182B58220", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x2B57CA0", Offset = "0x2B570A0", VA = "0x182B57CA0", Slot = "9")]
		public void IDHODADPCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x2B57E10", Offset = "0x2B57210", VA = "0x182B57E10", Slot = "10")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x2B574A0", Offset = "0x2B568A0", VA = "0x182B574A0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x2B57AC0", Offset = "0x2B56EC0", VA = "0x182B57AC0", Slot = "4")]
		public FJFJJACADNC GPCHMCKOJPO(Entity PJEENOLDJIO)
		{
			return default(FJFJJACADNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x2B578A0", Offset = "0x2B56CA0", VA = "0x182B578A0", Slot = "5")]
		public void GIPLOPMFHON(NativeArray<FJFJJACADNC> IJELHBLKOKB, NativeArray<DFOPMDEEAAA> BNIHLJDPCCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x2B573D0", Offset = "0x2B567D0", VA = "0x182B573D0", Slot = "6")]
		public void DJKDLEFDGCC(FJFJJACADNC BDCLOJHOMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x2B58260", Offset = "0x2B57660", VA = "0x182B58260", Slot = "7")]
		public bool OAPHHMFPIBI(FJFJJACADNC BDCLOJHOMDK, out Collider MMNMMMMCHOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x2B57F10", Offset = "0x2B57310", VA = "0x182B57F10")]
		public bool LANBAAACLOF(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, float FNIJMIADAMA, Allocator GOLNHBOGNGC, out NativeArray<Entity> GMAMPIGCEAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2B58300", Offset = "0x2B57700", VA = "0x182B58300")]
		private void OHBHENIMPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC199C0", VA = "0x180C1A5C0")]
		private void HJFJMKEAOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2B57C10", Offset = "0x2B57010", VA = "0x182B57C10")]
		private void HEHKNFLFKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x984080", Offset = "0x983480", VA = "0x180984080")]
		private void IOFODMINCEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2B571F0", Offset = "0x2B565F0", VA = "0x182B571F0")]
		private BoxCollider CBOPOBPLKJJ(Entity PJEENOLDJIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2B57350", Offset = "0x2B56750", VA = "0x182B57350")]
		private void CPBGBFGDACC(BoxCollider MNOELEFBNOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2B57310", Offset = "0x2B56710", VA = "0x182B57310")]
		[Conditional("UNITY_EDITOR")]
		private void CGABOGFKFCC(GameObject BLPBCMIHDMD, Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x2B575A0", Offset = "0x2B569A0", VA = "0x182B575A0")]
		private void ECEELOAIMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x2B57790", Offset = "0x2B56B90", VA = "0x182B57790")]
		private void GDJKCJAFJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x2B56FE0", Offset = "0x2B563E0", VA = "0x182B56FE0")]
		private void AALCPCAKNJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x2B57EE0", Offset = "0x2B572E0", VA = "0x182B57EE0")]
		private void JOHMHPFHMGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x2B57AB0", Offset = "0x2B56EB0", VA = "0x182B57AB0")]
		private void GNLIPBHAEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2B57C60", Offset = "0x2B57060", VA = "0x182B57C60")]
		private void HGMOPFDFALP(Scene DCGIJKGOJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2B57ED0", Offset = "0x2B572D0", VA = "0x182B57ED0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B3D650", Offset = "0x2B3CA50", VA = "0x182B3D650", Slot = "5")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x2B3D6C0", Offset = "0x2B3CAC0", VA = "0x182B3D6C0")]
	public bool LANBAAACLOF(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, float FNIJMIADAMA, out MFGNBHMPCKE DDGIJLNCGHO, out Entity MJJCFFJMMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x2B3DB40", Offset = "0x2B3CF40", VA = "0x182B3DB40")]
	public static bool LODKPFNGBNP(in Span<MFGNBHMPCKE> HKAIPIBCMIK, float FNIJMIADAMA, out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x2B3D620", Offset = "0x2B3CA20", VA = "0x182B3D620")]
	public static float GEHDIMGIPCG(float IFKFINIBHON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public LBLNCLBMJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x2B3DC40", Offset = "0x2B3D040", VA = "0x182B3DC40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x41B9000", Offset = "0x41B8400", VA = "0x1841B9000", Slot = "4")]
		public void Execute(int EGBCAPEEJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x41B9FC0", Offset = "0x41B93C0", VA = "0x1841B9FC0")]
		private static float3 PLPKGOCPNJI(in float4x4 NJAPOBEJPBC, in float3 JPPIJLBNKPM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x41B99B0", Offset = "0x41B8DB0", VA = "0x1841B99B0")]
		private static float3 FJPOPODFDAP(in float4x4 NJAPOBEJPBC, in float3 ABDBMKJBNIN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x41B9B70", Offset = "0x41B8F70", VA = "0x1841B9B70")]
		private static float3 INMKOFEFMAL(in float4x4 NJAPOBEJPBC, in float3 JPPIJLBNKPM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x41B8DE0", Offset = "0x41B81E0", VA = "0x1841B8DE0")]
		private static float3 EEJDMPEHEHL(in float4x4 NJAPOBEJPBC, in float3 ABDBMKJBNIN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x41B9C70", Offset = "0x41B9070", VA = "0x1841B9C70")]
		private bool OLDMIFFHPAE(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, in NativeArray<Entity> COBLCAKGCPD, out float3 DDGIJLNCGHO, out float3 MFJFJLMHLGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x41B92E0", Offset = "0x41B86E0", VA = "0x1841B92E0")]
		public static bool FCALJBGONIL(in float3 LKINPFLLJBO, in float3 PLKHGCCMBEC, in float3 FOFAPKNFCHO, in float3 LJIGMONOFNF, float ALBDIEBELLC, float BNJALKGHBFN, out float JELHNILOKLO, out float3 IMBJBGHLGBL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager JGDEKKJFKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x3123F50", Offset = "0x3123350", VA = "0x183123F50", Slot = "5")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x3123FD0", Offset = "0x31233D0", VA = "0x183123FD0")]
	public void LANBAAACLOF(in NativeArray<Entity> GMAMPIGCEAB, in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, in NativeArray<MFGNBHMPCKE> FHBDPKANIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public KCNEEOJOHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x31244B0", Offset = "0x31238B0", VA = "0x1831244B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE991A0", Offset = "0xE985A0", VA = "0x180E991A0")]
			get
			{
				return default(NativeHashMap<IJDKBBDMEBI, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint ENABEPLFKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x2B512F0", Offset = "0x2B506F0", VA = "0x182B512F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool KCIOFPNPCCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x8E0DA0", Offset = "0x8E01A0", VA = "0x1808E0DA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0xD28250", Offset = "0xD27650", VA = "0x180D28250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x2B510E0", Offset = "0x2B504E0", VA = "0x182B510E0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x2B50FF0", Offset = "0x2B503F0", VA = "0x182B50FF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x2B51060", Offset = "0x2B50460", VA = "0x182B51060")]
		public void FPEOCMBDEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x2B51320", Offset = "0x2B50720", VA = "0x182B51320")]
		public void LPNMIKCIFCB(IJDKBBDMEBI DGPLFECNDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x2B514E0", Offset = "0x2B508E0", VA = "0x182B514E0")]
		private GPEJGMHBDPO ONMDEPNPKNN(Entity PJEENOLDJIO)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2B50F10", Offset = "0x2B50310", VA = "0x182B50F10")]
		public GPEJGMHBDPO BPFLLEIAFPB(IJDKBBDMEBI DGPLFECNDCD)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2B50E20", Offset = "0x2B50220", VA = "0x182B50E20")]
		public IJDKBBDMEBI BAAKGEKGEDO(GPEJGMHBDPO GBPGPLEPLBP)
		{
			return default(IJDKBBDMEBI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x2B51200", Offset = "0x2B50600", VA = "0x182B51200")]
		public void KBFOFICGPKI(Entity PJEENOLDJIO, IJDKBBDMEBI DGPLFECNDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x2B50EB0", Offset = "0x2B502B0", VA = "0x182B50EB0")]
		public void BLABKBJHPNC(Entity PJEENOLDJIO, IJDKBBDMEBI DGPLFECNDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x2B51290", Offset = "0x2B50690", VA = "0x182B51290")]
		public void KIOLCCBJOBI(Entity PJEENOLDJIO, IJDKBBDMEBI DGPLFECNDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x2B51510", Offset = "0x2B50910", VA = "0x182B51510")]
		public void PFFBIGAMFCF(Entity PJEENOLDJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B5E720", Offset = "0x2B5DB20", VA = "0x182B5E720")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E400", Offset = "0x2B5D800", VA = "0x182B5E400")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action LOCFIDHMJBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x2B5E190", Offset = "0x2B5D590", VA = "0x182B5E190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x2B5ED00", Offset = "0x2B5E100", VA = "0x182B5ED00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E230", Offset = "0x2B5D630", VA = "0x182B5E230", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DEA0", Offset = "0x2B5D2A0", VA = "0x182B5DEA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DF30", Offset = "0x2B5D330", VA = "0x182B5DF30")]
		public void GBHABPPKBJN(BPHAMHGLCNC AOKMGDODDPA, AFAANOBHJND PEPHBHFBJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DB20", Offset = "0x2B5CF20", VA = "0x182B5DB20")]
		public void CHMCBDDDGAK(BPHAMHGLCNC AOKMGDODDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x2B5DC10", Offset = "0x2B5D010", VA = "0x182B5DC10")]
		internal void DBOJCEDCOGH(ADIGHOEHBBA KFCHBPFAEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E7C0", Offset = "0x2B5DBC0", VA = "0x182B5E7C0")]
		private void PIKBKPKNCAK(ADIGHOEHBBA KFCHBPFAEMJ, int DFMDKBNGDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E4A0", Offset = "0x2B5D8A0", VA = "0x182B5E4A0")]
		private void PGNDJLFMPAF(GJOKNGAFGLP LPPHHGKFEEH, EBDBOJDCJEC KNOCGJLOCND, LEJIJCIELFE HCHKLEAOPLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E280", Offset = "0x2B5D680", VA = "0x182B5E280")]
		private GCNEANLILED MKKOFEHHBLA(GJOKNGAFGLP LPPHHGKFEEH, EBDBOJDCJEC KNOCGJLOCND)
		{
			return default(GCNEANLILED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2B5E0A0", Offset = "0x2B5D4A0", VA = "0x182B5E0A0")]
		private LEJIJCIELFE IFIKLHKHPJC(GCNEANLILED JJPMEEGFFGM, GJOKNGAFGLP LPPHHGKFEEH, EBDBOJDCJEC KNOCGJLOCND)
		{
			return default(LEJIJCIELFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2B5EDF0", Offset = "0x2B5E1F0", VA = "0x182B5EDF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x701040", Offset = "0x700440", VA = "0x180701040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x41B7D60", Offset = "0x41B7160", VA = "0x1841B7D60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x987E80", Offset = "0x987280", VA = "0x180987E80")]
		[DebuggerHidden]
		public GJCIHOKNLDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x41B7BB0", Offset = "0x41B6FB0", VA = "0x1841B7BB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x41B7D20", Offset = "0x41B7120", VA = "0x1841B7D20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x41B7C70", Offset = "0x41B7070", VA = "0x1841B7C70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GPEJGMHBDPO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x41B7C70", Offset = "0x41B7070", VA = "0x1841B7C70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B46220", Offset = "0x2B45620", VA = "0x182B46220")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private JLCGKPAGLMB JADDHOMJIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2B45E70", Offset = "0x2B45270", VA = "0x182B45E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2B46270", Offset = "0x2B45670", VA = "0x182B46270", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x2B46060", Offset = "0x2B45460", VA = "0x182B46060", Slot = "5")]
	public void FABNEPJDBBC(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x2B45F20", Offset = "0x2B45320", VA = "0x182B45F20", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x2B467C0", Offset = "0x2B45BC0", VA = "0x182B467C0")]
	private void NNMHBFEKPHF(Entity PKFLKNEEDLH, in MPOLKMCKMLM MGONAHKOAND, in MPOLKMCKMLM GLLAKMPHGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x2B45EC0", Offset = "0x2B452C0", VA = "0x182B45EC0", Slot = "14")]
	public GPEJGMHBDPO DPPJEBGFDDC()
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x2B45CC0", Offset = "0x2B450C0", VA = "0x182B45CC0", Slot = "10")]
	public void CCGJMNHJJAC(GPEJGMHBDPO GBPGPLEPLBP, ALCCBEKLCMG DGCNIAGLPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2B46A40", Offset = "0x2B45E40", VA = "0x182B46A40", Slot = "9")]
	public ALCCBEKLCMG OLDBJJKNILI(GPEJGMHBDPO GBPGPLEPLBP)
	{
		return default(ALCCBEKLCMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x2B46B30", Offset = "0x2B45F30", VA = "0x182B46B30", Slot = "11")]
	public GPEJGMHBDPO OOKIKAGIJNP(GPEJGMHBDPO JMFCHNOMKAM, [Optional] Vector3? MIFJBHLKJIN, [Optional] Quaternion? OLBDAPNGDPL, [Optional] Vector3? NHAEEIBBDJN)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x2B45C80", Offset = "0x2B45080", VA = "0x182B45C80", Slot = "15")]
	public GPEJGMHBDPO BCADGGEEHNI(GPEJGMHBDPO CPIJGODGGEN, int EGBCAPEEJBF, [Optional] Vector3? MIFJBHLKJIN, [Optional] Quaternion? OLBDAPNGDPL, [Optional] Vector3? NHAEEIBBDJN)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x2B464A0", Offset = "0x2B458A0", VA = "0x182B464A0", Slot = "7")]
	public GPEJGMHBDPO LBOODFBPPFK(GPEJGMHBDPO CPIJGODGGEN, int EGBCAPEEJBF)
	{
		return default(GPEJGMHBDPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x2B45DB0", Offset = "0x2B451B0", VA = "0x182B45DB0", Slot = "16")]
	public void CNCOEPMNCPB(GPEJGMHBDPO CPIJGODGGEN, GPEJGMHBDPO ODIEOJHEKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x2B46300", Offset = "0x2B45700", VA = "0x182B46300", Slot = "12")]
	public void KBJMLCHBBAI(GPEJGMHBDPO CPIJGODGGEN, int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x2B46620", Offset = "0x2B45A20", VA = "0x182B46620", Slot = "17")]
	public void NMLEFFGGLOH(GPEJGMHBDPO CPIJGODGGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x2B45BE0", Offset = "0x2B44FE0", VA = "0x182B45BE0", Slot = "8")]
	public int ACEEDCJJPCG(GPEJGMHBDPO CPIJGODGGEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x2B46590", Offset = "0x2B45990", VA = "0x182B46590", Slot = "6")]
	[IteratorStateMachine(typeof(GJCIHOKNLDJ))]
	public IEnumerable<GPEJGMHBDPO> LGEIHKMDLLG(GPEJGMHBDPO CPIJGODGGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x2B45FD0", Offset = "0x2B453D0", VA = "0x182B45FD0")]
	private bool EABIACNMDHE(GPEJGMHBDPO CPIJGODGGEN, out NativeArray<Entity> DJHPOGLHKJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2B46160", Offset = "0x2B45560", VA = "0x182B46160")]
	private NativeArray<Entity> GIGDNIJJOJM(GPEJGMHBDPO CPIJGODGGEN)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3113FF0", Offset = "0x31133F0", VA = "0x183113FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x3114040", Offset = "0x3113440", VA = "0x183114040", Slot = "4")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x31140C0", Offset = "0x31134C0", VA = "0x1831140C0")]
	public void LCDMKGLCGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x3113D20", Offset = "0x3113120", VA = "0x183113D20")]
	public void DJNGEIEFBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x311A840", Offset = "0x3119C40", VA = "0x18311A840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x311A950", Offset = "0x3119D50", VA = "0x18311A950")]
	public HEEHFNGKCPD(Type HAOFNDAEGFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x311A810", Offset = "0x3119C10", VA = "0x18311A810")]
	public static HEEHFNGKCPD HEFILGHKDEM(Type HAOFNDAEGFJ)
	{
		return default(HEEHFNGKCPD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x311A7F0", Offset = "0x3119BF0", VA = "0x18311A7F0")]
	public static Type HEFILGHKDEM(HEEHFNGKCPD BDCLOJHOMDK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x107DF40", Offset = "0x107D340", VA = "0x18107DF40")]
	public static bool IIPILNNMHKL(HEEHFNGKCPD BECDKHGLGNB, HEEHFNGKCPD ICPOAGANOLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x107DF40", Offset = "0x107D340", VA = "0x18107DF40")]
	public static bool NCOOAABHIPD(HEEHFNGKCPD BECDKHGLGNB, HEEHFNGKCPD ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x887520", Offset = "0x886920", VA = "0x180887520", Slot = "4")]
	public bool Equals(HEEHFNGKCPD JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x311A770", Offset = "0x3119B70", VA = "0x18311A770", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x311A920", Offset = "0x3119D20", VA = "0x18311A920", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x31226C0", Offset = "0x3121AC0", VA = "0x1831226C0")]
	static JLNADKCMJCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x22E92F0", Offset = "0x22E86F0", VA = "0x1822E92F0")]
	public static bool GBJBCHALJOG<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x3122420", Offset = "0x3121820", VA = "0x183122420")]
	public static bool GBJBCHALJOG(Type HAOFNDAEGFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x31222B0", Offset = "0x31216B0", VA = "0x1831222B0")]
	private static bool GBJBCHALJOG(Type HAOFNDAEGFJ, out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x22E9380", Offset = "0x22E8780", VA = "0x1822E9380")]
	public static int KKIINDDINID<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x3122490", Offset = "0x3121890", VA = "0x183122490")]
	public static int KKIINDDINID(Type HAOFNDAEGFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x22E9410", Offset = "0x22E8810", VA = "0x1822E9410")]
	public static bool LEDONIKBHEA<T>(out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x3122500", Offset = "0x3121900", VA = "0x183122500")]
	public static bool LEDONIKBHEA(Type HAOFNDAEGFJ, out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x3122210", Offset = "0x3121610", VA = "0x183122210")]
	public static Type BOEAFIEBIHC(int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x31225A0", Offset = "0x31219A0", VA = "0x1831225A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x800F00", Offset = "0x800300", VA = "0x180800F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x2344760", Offset = "0x2343B60", VA = "0x182344760")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> DICJPCHOIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x3226F10", Offset = "0x3226310", VA = "0x183226F10")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x9055B0", Offset = "0x9049B0", VA = "0x1809055B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x3226FB0", Offset = "0x32263B0", VA = "0x183226FB0")]
	public MNKKKLOFPDB(int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x3226E60", Offset = "0x3226260", VA = "0x183226E60")]
	public int LGFPODHHMBH(T KPPLMEOMNGF, int GODLNPABGMH, int KJAHKKMJHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x3226DA0", Offset = "0x32261A0", VA = "0x183226DA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x29B9AB0", Offset = "0x29B8EB0", VA = "0x1829B9AB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int IEAACCILOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x29BA9A0", Offset = "0x29B9DA0", VA = "0x1829BA9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int LFCNNPBFNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x29B9F10", Offset = "0x29B9310", VA = "0x1829B9F10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x29BA710", Offset = "0x29B9B10", VA = "0x1829BA710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool FAFBILBNMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x29BA820", Offset = "0x29B9C20", VA = "0x1829BA820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> DICJPCHOIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x29BA9F0", Offset = "0x29B9DF0", VA = "0x1829BA9F0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x29BB280", Offset = "0x29BA680", VA = "0x1829BB280")]
	public EEGOPNFAMDL(int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x29BAD40", Offset = "0x29BA140", VA = "0x1829BAD40")]
	public T PGFBGCNBPKF(int EGBCAPEEJBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x29BA400", Offset = "0x29B9800", VA = "0x1829BA400")]
	public void HMOKBDLKNIA(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x29B98E0", Offset = "0x29B8CE0", VA = "0x1829B98E0")]
	public void ANIKBIHIFCK(Span<T> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x29BA0A0", Offset = "0x29B94A0", VA = "0x1829BA0A0")]
	public void GBJBCHALJOG(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x29BA280", Offset = "0x29B9680", VA = "0x1829BA280")]
	private void HLAGOAGKLGA(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x29B9B40", Offset = "0x29B8F40", VA = "0x1829B9B40")]
	public void CMEPDJJCKOF(Span<T> KDCOOOFOCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x29BA1B0", Offset = "0x29B95B0", VA = "0x1829BA1B0")]
	public void GCCKHMHCNIK(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x29BAD90", Offset = "0x29BA190", VA = "0x1829BAD90")]
	public void PINJNKFLMFA(int EOHBLJKNKIF, int EICPOANFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x29BAFB0", Offset = "0x29BA3B0", VA = "0x1829BAFB0")]
	public void PJBBGDBFNGB(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x29BA470", Offset = "0x29B9870", VA = "0x1829BA470")]
	public void JIKJIAINCEG(int EOHBLJKNKIF, int EICPOANFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x29BA760", Offset = "0x29B9B60", VA = "0x1829BA760")]
	public void MMGHCEPKACF(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x29BB150", Offset = "0x29BA550", VA = "0x1829BB150")]
	public void POAELJEPEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x29BA680", Offset = "0x29B9A80", VA = "0x1829BA680")]
	public int LGFPODHHMBH(T KPPLMEOMNGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x29B9A50", Offset = "0x29B8E50", VA = "0x1829B9A50")]
	public bool BNDEAHDJONI(T KPPLMEOMNGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x29B9EC0", Offset = "0x29B92C0", VA = "0x1829B9EC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x29BB210", Offset = "0x29BA610", VA = "0x1829BB210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x29BA210", Offset = "0x29B9610", VA = "0x1829BA210")]
	public static Span<T> HEFILGHKDEM(global::EEGOPNFAMDL<T> EHJGMBFBLBN)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x29B9D80", Offset = "0x29B9180", VA = "0x1829B9D80")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DOFNCEMJICN(int KPPLMEOMNGF, int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void GBAFNLLNGNI(int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x29B9F40", Offset = "0x29B9340", VA = "0x1829B9F40")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void GBAFNLLNGNI(int GDDNEEFIBDF, int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x29BA860", Offset = "0x29B9C60", VA = "0x1829BA860")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NNELNNKODBI(int KPPLMEOMNGF, int GDDNEEFIBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x29BAB40", Offset = "0x29B9F40", VA = "0x1829BAB40")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void PDCNOCBDJAC(int EOHBLJKNKIF, int EICPOANFBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x29BB010", Offset = "0x29BA410", VA = "0x1829BB010")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D5EDC0", Offset = "0x2D5E1C0", VA = "0x182D5EDC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> LEJDCOPNFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0xC488C0", Offset = "0xC47CC0", VA = "0x180C488C0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray DOLJEJLKCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool KCIOFPNPCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x2D5EBF0", Offset = "0x2D5DFF0", VA = "0x182D5EBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x2D5EDD0", Offset = "0x2D5E1D0", VA = "0x182D5EDD0")]
	public DLGLKFHNPHN(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x2D5ED70", Offset = "0x2D5E170", VA = "0x182D5ED70")]
	public Entity GHNMBAICEAM(int EGBCAPEEJBF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x2D5EC10", Offset = "0x2D5E010", VA = "0x182D5EC10")]
	public Transform FJEJMGNKJIP(int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x2D5EB20", Offset = "0x2D5DF20", VA = "0x182D5EB20")]
	public void BIOKPKCMOHA(int KNECCHHDDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x2D5EC20", Offset = "0x2D5E020", VA = "0x182D5EC20")]
	public int GBJBCHALJOG(Transform PKIKNDCFAFJ, Entity PJEENOLDJIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x2D5ECF0", Offset = "0x2D5E0F0", VA = "0x182D5ECF0")]
	public int GCCKHMHCNIK(int EGBCAPEEJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x2D5EB70", Offset = "0x2D5DF70", VA = "0x182D5EB70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x2D5EAE0", Offset = "0x2D5DEE0", VA = "0x182D5EAE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3120180", Offset = "0x311F580", VA = "0x183120180")]
	public ILMNJLCHNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x311FD20", Offset = "0x311F120", VA = "0x18311FD20")]
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
	[Cpp2IlInjected.Address(RVA = "0x311FEA0", Offset = "0x311F2A0", VA = "0x18311FEA0")]
	public void JPNFGACMGOG(Type HAOFNDAEGFJ, MPOLKMCKMLM KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x311FA40", Offset = "0x311EE40", VA = "0x18311FA40")]
	public MPOLKMCKMLM BOEAFIEBIHC(Type HAOFNDAEGFJ)
	{
		return default(MPOLKMCKMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x31200E0", Offset = "0x311F4E0", VA = "0x1831200E0")]
	private NativeArray<byte> KPCBHHFBPJO(int2 OGCMIPINAPI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x311FC80", Offset = "0x311F080", VA = "0x18311FC80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x311FD80", Offset = "0x311F180", VA = "0x18311FD80", Slot = "1")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B3FB10", Offset = "0x2B3EF10", VA = "0x182B3FB10")]
	internal static void FPEOCMBDEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void JPNFGACMGOG<T>(T KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x2B3FB80", Offset = "0x2B3EF80", VA = "0x182B3FB80")]
	public static void JPNFGACMGOG(Type HAOFNDAEGFJ, MPOLKMCKMLM KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T BOEAFIEBIHC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x2B3FA70", Offset = "0x2B3EE70", VA = "0x182B3FA70")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D4C2B0", Offset = "0x2D4B6B0", VA = "0x182D4C2B0", Slot = "4")]
	public bool Equals(LinkedEntityGroup PMEDGJGANML, LinkedEntityGroup NIPKEFBPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2D4C2D0", Offset = "0x2D4B6D0", VA = "0x182D4C2D0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup AELIHOPICED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public BOIJEFDNHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class FACGGEEGLAK
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void OEAMAPCANPO(in Vector3 MIFJBHLKJIN, in Quaternion OLBDAPNGDPL, in Vector3 NHAEEIBBDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void OAFBDJOEHMB(in Vector3 NGBOFGADIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void BEGFIJDNAIK(in Quaternion OLBDAPNGDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void JNDHLGDBOOI(in Vector3 FLILAGFCIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void NPIGCOCOGAK(in Vector3 FLILAGFCIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void GAPIFPGGAGM(in float AEIEKJBHCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x3111AF0", Offset = "0x3110EF0", VA = "0x183111AF0")]
	[Conditional("DEBUG_BUILD")]
	public static void FDBHMNJEDFN(in float3 KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void MMGFCFNELMN(in float KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x3111BD0", Offset = "0x3110FD0", VA = "0x183111BD0")]
	[Conditional("DEBUG_BUILD")]
	public static void MMGFCFNELMN(in Vector3 KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x3111BA0", Offset = "0x3110FA0", VA = "0x183111BA0")]
	[Conditional("DEBUG_BUILD")]
	public static void MMGFCFNELMN(in Quaternion KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x3111A70", Offset = "0x3110E70", VA = "0x183111A70")]
	[Conditional("DEBUG_BUILD")]
	public static void ENPBGKMBFMK(in float KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x3111A80", Offset = "0x3110E80", VA = "0x183111A80")]
	[Conditional("DEBUG_BUILD")]
	public static void ENPBGKMBFMK(in Vector3 KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x3111AC0", Offset = "0x3110EC0", VA = "0x183111AC0")]
	[Conditional("DEBUG_BUILD")]
	public static void ENPBGKMBFMK(in Quaternion KPPLMEOMNGF, string GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D5DE20", Offset = "0x2D5D220", VA = "0x182D5DE20")]
	public DFLCMAHAHIM(Entity PJEENOLDJIO, Entity KJNCJMANDLF, Entity KHLHKJKADHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x2D5DDC0", Offset = "0x2D5D1C0", VA = "0x182D5DDC0")]
	public static DFLCMAHAHIM HEFILGHKDEM((Entity entity, Entity oldParent, Entity newParent) MHIEFDEAPAM)
	{
		return default(DFLCMAHAHIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2D5DE00", Offset = "0x2D5D200", VA = "0x182D5DE00")]
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
	[Cpp2IlInjected.Address(RVA = "0xEA18D0", Offset = "0xEA0CD0", VA = "0x180EA18D0")]
	public EJDOAJBNLAC(Entity PJEENOLDJIO, Entity OKMBLMILFGG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x2D622A0", Offset = "0x2D616A0", VA = "0x182D622A0")]
	public static EJDOAJBNLAC HEFILGHKDEM((Entity entity, Entity parent) MHIEFDEAPAM)
	{
		return default(EJDOAJBNLAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2D622D0", Offset = "0x2D616D0", VA = "0x182D622D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3119EA0", Offset = "0x31192A0", VA = "0x183119EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x38A4570", Offset = "0x38A3970", VA = "0x1838A4570")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x38A44B0", Offset = "0x38A38B0", VA = "0x1838A44B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x38A4640", Offset = "0x38A3A40", VA = "0x1838A4640")]
	public AODOKPCJNJI(T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x38A4610", Offset = "0x38A3A10", VA = "0x1838A4610", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x701050", Offset = "0x700450", VA = "0x180701050")]
	public PGHABJEAHKP(EIHEHJOIBDF JFCJMBGMPGA, int JMOLLNMGGHK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x2B56270", Offset = "0x2B55670", VA = "0x182B56270")]
	public static PGHABJEAHKP HEFILGHKDEM((EIHEHJOIBDF eventType, int eventIndex) PMEDGJGANML)
	{
		return default(PGHABJEAHKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x2B56290", Offset = "0x2B55690", VA = "0x182B56290")]
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
	[Cpp2IlInjected.Address(RVA = "0x311F440", Offset = "0x311E840", VA = "0x18311F440", Slot = "5")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x311F490", Offset = "0x311E890", VA = "0x18311F490")]
	public bool LANBAAACLOF(in float3 ANCODJBIPAB, in float3 JLBPNKFCLFO, float FNIJMIADAMA, Allocator GOLNHBOGNGC, out NativeArray<Entity> GMAMPIGCEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public IGIGJEFCDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x311F490", Offset = "0x311E890", VA = "0x18311F490", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D60B30", Offset = "0x2D5FF30", VA = "0x182D60B30", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public EGDMFPJGNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x311F360", Offset = "0x311E760", VA = "0x18311F360", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public IEPFALJOLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D5DE30", Offset = "0x2D5D230", VA = "0x182D5DE30", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public DKPIFALCPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class NNAEKBCEOJJ : IJINHHBANEE
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public NNAEKBCEOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B42300", Offset = "0x2B41700", VA = "0x182B42300", Slot = "16")]
	protected override ComponentSystemBase OJJGMJDNJEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x2B423E0", Offset = "0x2B417E0", VA = "0x182B423E0")]
	public MGKDLMNJGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[BLPHJEIJPDJ(typeof(AuthoredLocalPoseData))]
public sealed class AMACAACHNJD : IJOAAFPCIPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x2D47D00", Offset = "0x2D47100", VA = "0x182D47D00", Slot = "8")]
	protected override bool LHGDJEIAACJ(ReadOnlySpan<AuthoredLocalPoseData> KDCOOOFOCDB, CAANBCJACEG LNANHOBPAPC, out ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x2D47C40", Offset = "0x2D47040", VA = "0x182D47C40", Slot = "9")]
	protected override bool LEMCGNFOKAO(int LFMBJAIIPEH, Span<AuthoredLocalPoseData> KDCOOOFOCDB, in ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x2D47D80", Offset = "0x2D47180", VA = "0x182D47D80")]
	public AMACAACHNJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[BLPHJEIJPDJ(typeof(LocalPoseData))]
public sealed class ONMBDEJKNAF : MFBAIOPOAOK
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x2B499A0", Offset = "0x2B48DA0", VA = "0x182B499A0", Slot = "8")]
	protected override bool LHGDJEIAACJ(ReadOnlySpan<LocalPoseData> KDCOOOFOCDB, CAANBCJACEG LNANHOBPAPC, out ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x2B498E0", Offset = "0x2B48CE0", VA = "0x182B498E0", Slot = "9")]
	protected override bool LEMCGNFOKAO(int LFMBJAIIPEH, Span<LocalPoseData> KDCOOOFOCDB, in ReadOnlySpan<byte> BMHLFOOGPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x2B49A20", Offset = "0x2B48E20", VA = "0x182B49A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x2CEF7F0", Offset = "0x2CEEBF0", VA = "0x182CEF7F0", Slot = "6")]
		public sealed override void LDHMAOMPMOJ(JNCGCMMLAKP PEPHBHFBJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x2CEED20", Offset = "0x2CEE120", VA = "0x182CEED20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x311AA10", Offset = "0x3119E10", VA = "0x18311AA10")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x311AB20", Offset = "0x3119F20", VA = "0x18311AB20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
