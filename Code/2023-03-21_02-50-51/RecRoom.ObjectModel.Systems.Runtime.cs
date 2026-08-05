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
public sealed class EILLHKIGJDB<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class EOLJHDMGCLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::EILLHKIGJDB<T> HGDAHEMLNIK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] FJKPBJHNCJF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public EOLJHDMGCLP(global::EILLHKIGJDB<T> HGDAHEMLNIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class GFAJICFPKHH : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::EILLHKIGJDB<T> <>4__this;

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
		public GFAJICFPKHH(int <>1__state)
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
	private const int HDNOELKPOHL = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> IKCFBHHOABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int LJCCKGLACJE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T IOEJBJHPAFG
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
	private bool BIJBAFFKCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool KDNIBAAPCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool OLOFHCFEHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LBDHOLBKIHI
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
	public int EIFLHBHGPLJ
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
	public EILLHKIGJDB(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public EILLHKIGJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void FKLAKIJPDJB(int LHHBOCAHDEE, T FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void DCPLCAPJDEC(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] DDHHGNBIMIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void GEHPENLABLJ(NativeArray<T> CIMBPHJAHGJ, int BLCDEHFGKBI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::EILLHKIGJDB<>.GFAJICFPKHH))]
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
	public int FDIMGBOHNMI(T FNHAIFCEKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool ALIFOBNBCOA(T FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void BNHKHBDEEDO(int MGGAPHEPKJK, int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void BIIOGAGHEGM(int MGGAPHEPKJK, int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void LHOOMIHENEL(int MGGAPHEPKJK, int OBHIANFIDPA, int FCKFNIPNJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int MGCNFIKAPGB(int LHHBOCAHDEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T HBOBBBEDLGL(int LHHBOCAHDEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void DFJOPJCFDFO(int LHHBOCAHDEE, T FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void CJABLGAINNA(int LHHBOCAHDEE, T FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void OOBKFJCEHOC(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int BMAHAMIFJIM(int NPHADDCNBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int FJLEBBGCFDC(int NPHADDCNBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void LJIMBHOKGJG(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void IPHIGNGBCIN(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T BJNDEBDBCBL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T IAFBBAFOGLI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void HGCLAOEOCGI(int LHHBOCAHDEE, IReadOnlyCollection<T> MJNFLJIGHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void PGHBHCGNIAI(int LHHBOCAHDEE, int GOBOKPPMHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void INNIEEKHEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void LAGCPEIMJME(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void DENHGLEPDDN(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void PEHFPPEEEDM(int OBHIANFIDPA, int FCKFNIPNJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T HAJEGIIBGMF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T HBJGFNBGCFM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[LHEALDPACNM]
public static class OGBILDDHDHB
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x28A0390", Offset = "0x289EB90", VA = "0x1828A0390")]
	static OGBILDDHDHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x227F120", Offset = "0x227D920", VA = "0x18227F120")]
	public static void NBOBJLAFMAI<T>(T OEDLDNKMKMJ, ref T LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28A0150", Offset = "0x289E950", VA = "0x1828A0150")]
	public static void NBOBJLAFMAI(FixedString32 OEDLDNKMKMJ, ref string LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x28A02E0", Offset = "0x289EAE0", VA = "0x1828A02E0")]
	public static void NBOBJLAFMAI(string OEDLDNKMKMJ, ref FixedString32 LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x28A0250", Offset = "0x289EA50", VA = "0x1828A0250")]
	public static void NBOBJLAFMAI(FixedString64 OEDLDNKMKMJ, ref string LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x28A00F0", Offset = "0x289E8F0", VA = "0x1828A00F0")]
	public static void NBOBJLAFMAI(string OEDLDNKMKMJ, ref FixedString64 LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28A0020", Offset = "0x289E820", VA = "0x1828A0020")]
	public static void NBOBJLAFMAI(CGLBPMONGLE OEDLDNKMKMJ, ref Vector3 LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x28A01F0", Offset = "0x289E9F0", VA = "0x1828A01F0")]
	public static void NBOBJLAFMAI(Vector3 OEDLDNKMKMJ, ref CGLBPMONGLE LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28A0050", Offset = "0x289E850", VA = "0x1828A0050")]
	public static void NBOBJLAFMAI(MDFHBEHLBBG OEDLDNKMKMJ, ref Vector4 LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x28A0080", Offset = "0x289E880", VA = "0x1828A0080")]
	public static void NBOBJLAFMAI(Vector4 OEDLDNKMKMJ, ref MDFHBEHLBBG LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28A0050", Offset = "0x289E850", VA = "0x1828A0050")]
	public static void NBOBJLAFMAI(MDFHBEHLBBG OEDLDNKMKMJ, ref Quaternion LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28A0080", Offset = "0x289E880", VA = "0x1828A0080")]
	public static void NBOBJLAFMAI(Quaternion OEDLDNKMKMJ, ref MDFHBEHLBBG LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28A01C0", Offset = "0x289E9C0", VA = "0x1828A01C0")]
	public static void NBOBJLAFMAI(CGLBPMONGLE OEDLDNKMKMJ, ref float3 LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28A01F0", Offset = "0x289E9F0", VA = "0x1828A01F0")]
	public static void NBOBJLAFMAI(float3 OEDLDNKMKMJ, ref CGLBPMONGLE LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28A0280", Offset = "0x289EA80", VA = "0x1828A0280")]
	public static void NBOBJLAFMAI(MDFHBEHLBBG OEDLDNKMKMJ, ref float4 LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28A0080", Offset = "0x289E880", VA = "0x1828A0080")]
	public static void NBOBJLAFMAI(float4 OEDLDNKMKMJ, ref MDFHBEHLBBG LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28A0280", Offset = "0x289EA80", VA = "0x1828A0280")]
	public static void NBOBJLAFMAI(MDFHBEHLBBG OEDLDNKMKMJ, ref quaternion LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x28A0320", Offset = "0x289EB20", VA = "0x1828A0320")]
	public static void NBOBJLAFMAI(quaternion OEDLDNKMKMJ, ref MDFHBEHLBBG LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28A0180", Offset = "0x289E980", VA = "0x1828A0180")]
	public static void NBOBJLAFMAI(Entity OEDLDNKMKMJ, ref JGAJPOPBAHB LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28A02C0", Offset = "0x289EAC0", VA = "0x1828A02C0")]
	public static void NBOBJLAFMAI(JGAJPOPBAHB OEDLDNKMKMJ, ref Entity LPGFPBINEAE, AFDHGGDCOPP HIGOLFJOLNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OIGNJMDILHE]
public class DOECFBJKPPB : ComponentSystem, HNOABDNADGF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FEIANFNLNIA BNGGOEBDDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D6130", Offset = "0x6D4930", VA = "0x1806D6130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DLNPACLOKII NODGMKJOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x717210", Offset = "0x715A10", VA = "0x180717210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D710", Offset = "0x2D1BF10", VA = "0x182D1D710", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
	public DOECFBJKPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OIGNJMDILHE]
[UpdateInGroup(typeof(LHOLAAJHLBH))]
internal class AMJHPJDOFBA : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2D085D0", Offset = "0x2D06DD0", VA = "0x182D085D0", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2D08810", Offset = "0x2D07010", VA = "0x182D08810")]
	[Preserve]
	private void NILMAKFMDML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public AMJHPJDOFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[OIGNJMDILHE]
[UpdateInGroup(typeof(LHOLAAJHLBH))]
internal class FLJJNKDOCMI : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x31C6490", Offset = "0x31C4C90", VA = "0x1831C6490", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public FLJJNKDOCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28A7BC0", Offset = "0x28A63C0", VA = "0x1828A7BC0")]
		public static ObjectModelConfigAsset BFICMLBOCPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[IECCMKJMAAC(LAEALBOAPLI.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[IECCMKJMAAC(LAEALBOAPLI.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int ADEPDEBKGGB = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly DELGGOALDMF MGFJDFPNJKC;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4192C90", Offset = "0x4191490", VA = "0x184192C90")]
			public static IOAGKMCGKAI JOLEDJNAOKO(int LMLABJIMGIP)
			{
				return default(IOAGKMCGKAI);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4192B00", Offset = "0x4191300", VA = "0x184192B00")]
			private static void FLEAPNKDODN(FJJPMAIFPPM BGPLGGILDFO, FJJPMAIFPPM ILMJNMHOGFA, IOAGKMCGKAI DGNLFFKHMAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4193080", Offset = "0x4191880", VA = "0x184193080")]
			public static int KACPLBJECGB(GameObject IMPKIJJJHKI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4193250", Offset = "0x4191A50", VA = "0x184193250")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void KIAHPHOMEEP(FJJPMAIFPPM AIOPADAFDKL, int LMLABJIMGIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static BENLBCJOMLF NDEFPJDAEEH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static DOGGHHKGPAD MIJOBBAGFOL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static BENLBCJOMLF EDFFAALBDBP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x28A98A0", Offset = "0x28A80A0", VA = "0x1828A98A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x28A8840", Offset = "0x28A7040", VA = "0x1828A8840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static DOGGHHKGPAD LEGGCOJOJJH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x28A94A0", Offset = "0x28A7CA0", VA = "0x1828A94A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x28A8350", Offset = "0x28A6B50", VA = "0x1828A8350")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool KBEMNBFKMCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x28A9740", Offset = "0x28A7F40", VA = "0x1828A9740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static FEIANFNLNIA BNGGOEBDDNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x28A8A80", Offset = "0x28A7280", VA = "0x1828A8A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static DLNPACLOKII NODGMKJOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28A8690", Offset = "0x28A6E90", VA = "0x1828A8690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static BJFMFKKFIDI BNGBDOKGELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x28A89A0", Offset = "0x28A71A0", VA = "0x1828A89A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static KEFOHIEBEBL APADFNIFNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x28A7E80", Offset = "0x28A6680", VA = "0x1828A7E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static GGNOOGMPGOK EBKOGFGEFED
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x28A92D0", Offset = "0x28A7AD0", VA = "0x1828A92D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static HIFGFPBNEMJ MHHEPELPLNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x28A8920", Offset = "0x28A7120", VA = "0x1828A8920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool EIFFKOMINAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x28A8270", Offset = "0x28A6A70", VA = "0x1828A8270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool ACOAKGGLBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x28A91A0", Offset = "0x28A79A0", VA = "0x1828A91A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool ONEMGJDEKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x28A7F00", Offset = "0x28A6700", VA = "0x1828A7F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool GFGLFKFNHOO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x28A85D0", Offset = "0x28A6DD0", VA = "0x1828A85D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x28A95C0", Offset = "0x28A7DC0", VA = "0x1828A95C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool BFDJFJADALL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x28A8A20", Offset = "0x28A7220", VA = "0x1828A8A20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x28A8630", Offset = "0x28A6E30", VA = "0x1828A8630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action GLGIELNIAJC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x28A90A0", Offset = "0x28A78A0", VA = "0x1828A90A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x28A7D80", Offset = "0x28A6580", VA = "0x1828A7D80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x28A8D20", Offset = "0x28A7520", VA = "0x1828A8D20")]
		public static FJJPMAIFPPM IINJGBNILBC(GameObject IMPKIJJJHKI)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28A8E10", Offset = "0x28A7610", VA = "0x1828A8E10")]
		public static bool KCMLEOEMIMC(ByteString GJAPHEDPMNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28A8B20", Offset = "0x28A7320", VA = "0x1828A8B20")]
		public static JPEOKMJCLOL HOGOBLLJCKO(IOAGKMCGKAI DGNLFFKHMAE)
		{
			return default(JPEOKMJCLOL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28A9350", Offset = "0x28A7B50", VA = "0x1828A9350")]
		public static (ByteString, IDisposable) ODHIHDMAPDF()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28A8E70", Offset = "0x28A7670", VA = "0x1828A8E70")]
		public static (ByteString, IDisposable) KLBNCFKOIBK(IEnumerable<FJJPMAIFPPM> FMJIGOMDJDN)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28A8710", Offset = "0x28A6F10", VA = "0x1828A8710")]
		public static bool DHGEPODKHLL(GameObject IMPKIJJJHKI, out IOAGKMCGKAI DGNLFFKHMAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28A7C60", Offset = "0x28A6460", VA = "0x1828A7C60")]
		public static bool AEFCHBOJDMB(IEnumerable<ILMPIIJELKE> EHADBCLKLDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28A8FC0", Offset = "0x28A77C0", VA = "0x1828A8FC0")]
		public static void LKIKMLNPCFK(bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28A80F0", Offset = "0x28A68F0", VA = "0x1828A80F0")]
		public static Task BIGMECMELOL(bool KEBPJDOCLJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28A8C40", Offset = "0x28A7440", VA = "0x1828A8C40")]
		private static DOGGHHKGPAD IHOELCCAJEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28A9620", Offset = "0x28A7E20", VA = "0x1828A9620")]
		private static bool PGAAKPDHPKC()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[IECCMKJMAAC(LAEALBOAPLI.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28AE310", Offset = "0x28ACB10", VA = "0x1828AE310")]
		public static bool FMIPONBDHOD(CAEEJNEMGJH CFPIIPNNJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28AE5C0", Offset = "0x28ACDC0", VA = "0x1828AE5C0")]
		public static CAEEJNEMGJH OFCCGGLDJKB(GameObject IMPKIJJJHKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28AE3C0", Offset = "0x28ACBC0", VA = "0x1828AE3C0")]
		public static CAEEJNEMGJH OFCCGGLDJKB(GameObject IMPKIJJJHKI, IOAGKMCGKAI DGNLFFKHMAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28AE210", Offset = "0x28ACA10", VA = "0x1828AE210")]
		public static bool FHLPOODKAMF(GameObject HFJAINPDLBF, string MPGBCBMLKLF, bool EFCPDCACEMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28AE010", Offset = "0x28AC810", VA = "0x1828AE010")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void CMNFDFNFBLH(GameObject HFJAINPDLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28AE7F0", Offset = "0x28ACFF0", VA = "0x1828AE7F0")]
		[CompilerGenerated]
		internal static string ONHJIBFLLAM((GameObject go, string prefabName) OBPCMKOMOOP)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, AJNPGLFGCDG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool MMIMOGPFBMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public FJJPMAIFPPM MAIBPHPGEPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(FJJPMAIFPPM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x26F2730", Offset = "0x26F0F30", VA = "0x1826F2730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[IECCMKJMAAC(LAEALBOAPLI.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, CAEEJNEMGJH, AJNPGLFGCDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string LKCOHMIJIEE = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private IIKFEEDEEPI DMJFIAAGODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private FJJPMAIFPPM NGPFKAJPHJF;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public FJJPMAIFPPM MAIBPHPGEPA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x31C0C80", Offset = "0x31BF480", VA = "0x1831C0C80", Slot = "15")]
			get
			{
				return default(FJJPMAIFPPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public JPEOKMJCLOL DGHNMGFNHNE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x31C0D30", Offset = "0x31BF530", VA = "0x1831C0D30", Slot = "6")]
			get
			{
				return default(JPEOKMJCLOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool MMIMOGPFBMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x31C0C70", Offset = "0x31BF470", VA = "0x1831C0C70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IIKFEEDEEPI NHJKHPBNJFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4F0", Offset = "0x9ADCF0", VA = "0x1809AF4F0", Slot = "7")]
			get
			{
				return default(IIKFEEDEEPI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private DLNPACLOKII NODGMKJOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x31C02B0", Offset = "0x31BEAB0", VA = "0x1831C02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private HMGEJIKOHBO FHOGGJNEJOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x31C0490", Offset = "0x31BEC90", VA = "0x1831C0490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool PKGICIFJLPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x78F190", Offset = "0x78D990", VA = "0x18078F190", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> OMPEBKLHJGD
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x31C0B30", Offset = "0x31BF330", VA = "0x1831C0B30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x31C0D60", Offset = "0x31BF560", VA = "0x1831C0D60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<CAEEJNEMGJH> BCGNBFKDNPP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x31C0BD0", Offset = "0x31BF3D0", VA = "0x1831C0BD0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x31C0E00", Offset = "0x31BF600", VA = "0x1831C0E00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x31C00A0", Offset = "0x31BE8A0", VA = "0x1831C00A0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x31C08A0", Offset = "0x31BF0A0", VA = "0x1831C08A0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x31C0550", Offset = "0x31BED50", VA = "0x1831C0550", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x31C0810", Offset = "0x31BF010", VA = "0x1831C0810", Slot = "10")]
		public void OnEmbody(PNONIBNMECP IFJKGEPFDIB, FJJPMAIFPPM NGPFKAJPHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x31C0890", Offset = "0x31BF090", VA = "0x1831C0890", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x31C0600", Offset = "0x31BEE00", VA = "0x1831C0600", Slot = "12")]
		public void OnDisembody(bool EADJPFPJIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x31C0390", Offset = "0x31BEB90", VA = "0x1831C0390")]
		private void JDLFKJEHALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x31C0220", Offset = "0x31BEA20", VA = "0x1831C0220")]
		private void CLLMPJIFGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x31C09F0", Offset = "0x31BF1F0", VA = "0x1831C09F0")]
		private void PNJLJBCFDNH(bool JDHFEMCKGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x31C04F0", Offset = "0x31BECF0", VA = "0x1831C04F0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xFAFE10", Offset = "0xFAE610", VA = "0x180FAFE10", Slot = "9")]
		private GameObject ACCNMMEACOC()
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
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[IECCMKJMAAC(LAEALBOAPLI.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override KCPOKGIHHKK HPIENHIIFPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x28B8320", Offset = "0x28B6B20", VA = "0x1828B8320", Slot = "6")]
			get
			{
				return default(KCPOKGIHHKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x28B82C0", Offset = "0x28B6AC0", VA = "0x1828B82C0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[IECCMKJMAAC(LAEALBOAPLI.Registration)]
	public class TransformEntity : MonoBehaviour, AJNPGLFGCDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private KCPOKGIHHKK prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private FJJPMAIFPPM AIOPADAFDKL;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual KCPOKGIHHKK HPIENHIIFPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6D6BD0", Offset = "0x6D53D0", VA = "0x1806D6BD0", Slot = "6")]
			get
			{
				return default(KCPOKGIHHKK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x779430", Offset = "0x777C30", VA = "0x180779430", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public FJJPMAIFPPM MAIBPHPGEPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xC06C00", Offset = "0xC05400", VA = "0x180C06C00", Slot = "5")]
			get
			{
				return default(FJJPMAIFPPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool MMIMOGPFBMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6D5030", Offset = "0x6D3830", VA = "0x1806D5030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA3F830", Offset = "0xA3E030", VA = "0x180A3F830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity FMGJPDKNJGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal GGNOOGMPGOK EBKOGFGEFED
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal HMGEJIKOHBO CMGDBGNELLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C9FDD0", Offset = "0x2C9E5D0", VA = "0x182C9FDD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FC00", Offset = "0x2C9E400", VA = "0x182C9FC00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FC10", Offset = "0x2C9E410", VA = "0x182C9FC10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FE40", Offset = "0x2C9E640", VA = "0x182C9FE40")]
		internal void ODGJJHFNDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FD30", Offset = "0x2C9E530", VA = "0x182C9FD30")]
		private bool FCOACPOJBGP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FD00", Offset = "0x2C9E500", VA = "0x182C9FD00")]
		private void EANLEBKJMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FC10", Offset = "0x2C9E410", VA = "0x182C9FC10")]
		internal void BBLGJGOPDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0150", Offset = "0x2C9E950", VA = "0x182CA0150")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0230", Offset = "0x2C9EA30", VA = "0x182CA0230")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[FIKNCOOOHID(typeof(DOGGHHKGPAD), new string[] { })]
[NDHPNMMJOHD(typeof(MFCLKPKNHMJ))]
public class MCJACDLJDJB : DOGGHHKGPAD, KJMOLFDIMPO, MFCLKPKNHMJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NGKBJMLOEKJ BDDMBDBDABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private DLNPACLOKII CPOMNNHFPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private HILDNPBHGOE GHFACKFNNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private EFPEDJCAGJM LIKPNGOHAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private GJOPNMNFNFH AOPMIABPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private FJCJOMHLGKK DEIPFAPPBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NGKBJMLOEKJ BNGGOEBDDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public HILDNPBHGOE BDNKJIMKMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DLNPACLOKII NODGMKJOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public GJOPNMNFNFH PAOMJPJGJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FJCJOMHLGKK CNGKDBCNBKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IFJHKPDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886310", VA = "0x180887B10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool NELKOMOKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x31DE8F0", Offset = "0x31DD0F0", VA = "0x1831DE8F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FABKOFGEAEO IHCFGGOCMJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x942020", Offset = "0x940820", VA = "0x180942020", Slot = "10")]
		get
		{
			return default(FABKOFGEAEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x31DE900", Offset = "0x31DD100", VA = "0x1831DE900")]
	public static MCJACDLJDJB OJONNLHFKNA(NGKBJMLOEKJ BDDMBDBDABJ, JPCPGGKPCML DOJAOGGMBHJ = JPCPGGKPCML.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private static void FBGNIPHONGA(NGKBJMLOEKJ BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private static void MJPAEBJPFGB(NGKBJMLOEKJ BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x31DE7A0", Offset = "0x31DCFA0", VA = "0x1831DE7A0", Slot = "11")]
	public void HLHNMHIAHFM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FD30", Offset = "0x2C7E530", VA = "0x182C7FD30")]
	private void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x31DE650", Offset = "0x31DCE50", VA = "0x1831DE650")]
	private void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x31DE740", Offset = "0x31DCF40", VA = "0x1831DE740", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public MCJACDLJDJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IHIOGBDKBPH
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x31D0050", Offset = "0x31CE850", VA = "0x1831D0050")]
	public static JPEOKMJCLOL BGCJNDHKFOO(this DOGGHHKGPAD MIJOBBAGFOL, IOAGKMCGKAI DGNLFFKHMAE, KCPOKGIHHKK GANNEANJGDH)
	{
		return default(JPEOKMJCLOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x31D0190", Offset = "0x31CE990", VA = "0x1831D0190")]
	public static JHEAGBIAAJG FFAKLJDMJDH(this DOGGHHKGPAD MIJOBBAGFOL)
	{
		return default(JHEAGBIAAJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x31D03E0", Offset = "0x31CEBE0", VA = "0x1831D03E0")]
	public static FJJPMAIFPPM IINJGBNILBC(this DOGGHHKGPAD MIJOBBAGFOL, Entity DJGIAPPGDDP)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x31D02B0", Offset = "0x31CEAB0", VA = "0x1831D02B0")]
	public static FJJPMAIFPPM IINJGBNILBC(this DOGGHHKGPAD MIJOBBAGFOL, IOAGKMCGKAI DGNLFFKHMAE)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x31D0490", Offset = "0x31CEC90", VA = "0x1831D0490")]
	public static IOAGKMCGKAI NLKPEHJCAGC(this DOGGHHKGPAD MIJOBBAGFOL, FJJPMAIFPPM AIOPADAFDKL)
	{
		return default(IOAGKMCGKAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum JPCPGGKPCML
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
[FIKNCOOOHID(typeof(FJCJOMHLGKK), new string[] { })]
public class JJCNNHCIGAD : FJCJOMHLGKK, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[EOIIILOBJAK]
	private MFCLKPKNHMJ MIANENOIHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NGKBJMLOEKJ BDDMBDBDABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private JDDNAJGNJBI AOPMIABPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EFPEDJCAGJM LIKPNGOHAKC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FMNABBHHKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x31D5850", Offset = "0x31D4050", VA = "0x1831D5850", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x31D59A0", Offset = "0x31D41A0", VA = "0x1831D59A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x31D5650", Offset = "0x31D3E50", VA = "0x1831D5650", Slot = "16")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x31D5610", Offset = "0x31D3E10", VA = "0x1831D5610", Slot = "13")]
	public void BCCPDEHDMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "6")]
	public void OPAPAFHABEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x31D57D0", Offset = "0x31D3FD0", VA = "0x1831D57D0", Slot = "7")]
	public void GAMCBGAJNMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x31D5750", Offset = "0x31D3F50", VA = "0x1831D5750", Slot = "8")]
	public void ECFGMOKINEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F6DD80", Offset = "0x1F6C580", VA = "0x181F6DD80", Slot = "9")]
	public void BBEGCMBOHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x31D5700", Offset = "0x31D3F00", VA = "0x1831D5700", Slot = "10")]
	public void DELIKFNJIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x31D5550", Offset = "0x31D3D50", VA = "0x1831D5550", Slot = "11")]
	public bool AEFCHBOJDMB(IEnumerable<ILMPIIJELKE> EHADBCLKLDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x31D5A40", Offset = "0x31D4240", VA = "0x1831D5A40", Slot = "12")]
	public void PMKGKFFMMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x31D5950", Offset = "0x31D4150", VA = "0x1831D5950", Slot = "14")]
	public void LCHKJPJNLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x31D58F0", Offset = "0x31D40F0", VA = "0x1831D58F0", Slot = "15")]
	public void ILHDAAGACPF(bool DADJEOILOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x31D5820", Offset = "0x31D4020", VA = "0x1831D5820")]
	private void HMHNNILDLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public JJCNNHCIGAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[FIKNCOOOHID(typeof(GJOPNMNFNFH), new string[] { })]
public class LFHOOIFHJKI : GJOPNMNFNFH, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[EOIIILOBJAK]
	private MFCLKPKNHMJ MIANENOIHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NGKBJMLOEKJ BDDMBDBDABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JDDNAJGNJBI AOPMIABPHBO;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x31DA110", Offset = "0x31D8910", VA = "0x1831DA110", Slot = "6")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x31DA2C0", Offset = "0x31D8AC0", VA = "0x1831DA2C0", Slot = "4")]
	public ByteString ODHIHDMAPDF(out IDisposable AIKKNIBMGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x31DA1A0", Offset = "0x31D89A0", VA = "0x1831DA1A0", Slot = "5")]
	public void JFCMHHFNDFE(ByteString LBEMEOBAAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public LFHOOIFHJKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class FFNNPMNCCNE<T> : global::LPJAJMKANHA<T>, global::ABJCAJMMMEG<IOAGKMCGKAI, T>, global::LBDNGNKNFJN<IOAGKMCGKAI>, BEFHLLMPLPH, IDisposable, OJFEPNOINDA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly global::LBDNGNKNFJN<Entity> NPCKPCNEDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Delegate NJBDEJFBEAH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string ILMHEGPAEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x323FE70", Offset = "0x323E670", VA = "0x18323FE70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type ECHKLFAEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x323E2C0", Offset = "0x323CAC0", VA = "0x18323E2C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KKMMECBGMDP NBOAKBDFGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x323BAC0", Offset = "0x323A2C0", VA = "0x18323BAC0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int PNGDFPPKAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x322E1C0", Offset = "0x322C9C0", VA = "0x18322E1C0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HAPDJLHBIJI MBMKNBNPPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3232A40", Offset = "0x3231240", VA = "0x183232A40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x106E360", Offset = "0x106CB60", VA = "0x18106E360", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x323A2F0", Offset = "0x3238AF0", VA = "0x18323A2F0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::MAIOAIKFNKB<IOAGKMCGKAI> GLGIELNIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x323E730", Offset = "0x323CF30", VA = "0x18323E730", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x322E890", Offset = "0x322D090", VA = "0x18322E890", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x28E16A0", Offset = "0x28DFEA0", VA = "0x1828E16A0")]
	public FFNNPMNCCNE(global::LBDNGNKNFJN<Entity> NPCKPCNEDPB, GGNOOGMPGOK KKLJBHKLNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3231080", Offset = "0x322F880", VA = "0x183231080")]
	private Entity AMBBLJNNNML(IOAGKMCGKAI DGNLFFKHMAE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F800", Offset = "0x2C6E000", VA = "0x182C6F800")]
	private IOAGKMCGKAI AMBBLJNNNML(Entity DJGIAPPGDDP)
	{
		return default(IOAGKMCGKAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3238350", Offset = "0x3236B50", VA = "0x183238350", Slot = "4")]
	public T HEJAGBNBHFE(IOAGKMCGKAI DGNLFFKHMAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3231A80", Offset = "0x3230280", VA = "0x183231A80")]
	public bool BJPKOCBPDKP(IOAGKMCGKAI DGNLFFKHMAE, in T PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x323A800", Offset = "0x3239000", VA = "0x18323A800")]
	public bool HKNNBEJHLAJ(IOAGKMCGKAI DGNLFFKHMAE, in T PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x323C050", Offset = "0x323A850", VA = "0x18323C050", Slot = "9")]
	public bool JONADHNAPOD(IOAGKMCGKAI DGNLFFKHMAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x32356B0", Offset = "0x3233EB0", VA = "0x1832356B0", Slot = "26")]
	public object FONIIOAHOEA(IOAGKMCGKAI DGNLFFKHMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3235AF0", Offset = "0x32342F0", VA = "0x183235AF0")]
	public bool GDPGHMOFBNA(IOAGKMCGKAI DGNLFFKHMAE, in object PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3238270", Offset = "0x3236A70", VA = "0x183238270")]
	public void HEJAGBNBHFE(IOAGKMCGKAI DGNLFFKHMAE, in KMFGGFFJPFH NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x32315E0", Offset = "0x322FDE0", VA = "0x1832315E0")]
	public bool BJPKOCBPDKP(IOAGKMCGKAI DGNLFFKHMAE, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x323B950", Offset = "0x323A150", VA = "0x18323B950")]
	public bool HKNNBEJHLAJ(IOAGKMCGKAI DGNLFFKHMAE, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x28E0A30", Offset = "0x28DF230", VA = "0x1828E0A30", Slot = "22")]
	public void NELPADDHGOD(KGPEFICHJKL MPOCBDEMIGO, [Optional] object CDBJCAAPIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x323F1C0", Offset = "0x323D9C0", VA = "0x18323F1C0", Slot = "15")]
	public void NELPADDHGOD(IOAGKMCGKAI NHBANLNJEIH, EGMBBKCIEEA MPOCBDEMIGO, object CDBJCAAPIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x323DEB0", Offset = "0x323C6B0", VA = "0x18323DEB0", Slot = "14")]
	public bool LBMJLEFFBAH(IOAGKMCGKAI LPGFPBINEAE, IOAGKMCGKAI OEDLDNKMKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x265DAE0", Offset = "0x265C2E0", VA = "0x18265DAE0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x32401E0", Offset = "0x323E9E0", VA = "0x1832401E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2380", Offset = "0x2FC0B80", VA = "0x182FC2380")]
	public string HGKCPACHNMB(in OJMHOIEICMJ KNLMOBNIKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x323CD80", Offset = "0x323B580", VA = "0x18323CD80")]
	private void KNPGEINOHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x32375B0", Offset = "0x3235DB0", VA = "0x1832375B0")]
	private void HBPKNJMAKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x32338B0", Offset = "0x32320B0", VA = "0x1832338B0")]
	private void FMIGDDHCMIO(Entity DJGIAPPGDDP, in OJMHOIEICMJ CEOLOJHDIEE, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x323DB90", Offset = "0x323C390", VA = "0x18323DB90")]
	private void LBHOFFHPHPA(Entity DJGIAPPGDDP, in OJMHOIEICMJ CEOLOJHDIEE, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x322F700", Offset = "0x322DF00", VA = "0x18322F700")]
	[Conditional("DEBUG_BUILD")]
	private static void AICAMLEGBCH(Entity DJGIAPPGDDP, IOAGKMCGKAI DGNLFFKHMAE, string OABNINOCHNF, string OCHOILPFBKG, [CallerMemberName] string NKCEBILBNLE = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2C71E70", Offset = "0x2C70670", VA = "0x182C71E70", Slot = "5")]
	private bool FPFKANNLNIM(IOAGKMCGKAI NHBANLNJEIH, in T PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FB50", Offset = "0x2C6E350", VA = "0x182C6FB50", Slot = "6")]
	private bool APGHKPAKOCG(IOAGKMCGKAI NHBANLNJEIH, in T PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x28BC4E0", Offset = "0x28BACE0", VA = "0x1828BC4E0", Slot = "10")]
	private bool HGAJOHFNIAC(IOAGKMCGKAI NHBANLNJEIH, in object PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2C770B0", Offset = "0x2C758B0", VA = "0x182C770B0", Slot = "11")]
	private void NNAEHDGKNOK(IOAGKMCGKAI NHBANLNJEIH, in KMFGGFFJPFH NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2C705A0", Offset = "0x2C6EDA0", VA = "0x182C705A0", Slot = "12")]
	private bool CDGNHAHBGDI(IOAGKMCGKAI NHBANLNJEIH, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2C70760", Offset = "0x2C6EF60", VA = "0x182C70760", Slot = "13")]
	private bool CPJECEODLPF(IOAGKMCGKAI NHBANLNJEIH, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x28DECB0", Offset = "0x28DD4B0", VA = "0x1828DECB0", Slot = "16")]
	private string GAAPAGBMJKI(in OJMHOIEICMJ NPHADDCNBHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class MNFHHBDNCBA<T> : global::PDGNJHJPBNB<T>, global::ABJCAJMMMEG<FJJPMAIFPPM, T>, global::LBDNGNKNFJN<FJJPMAIFPPM>, BEFHLLMPLPH, IDisposable, CBKEAKDLCBB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly global::LBDNGNKNFJN<Entity> NPCKPCNEDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Delegate NJBDEJFBEAH;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string ILMHEGPAEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6620", Offset = "0x2FC4E20", VA = "0x182FC6620", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type ECHKLFAEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5390", Offset = "0x2FC3B90", VA = "0x182FC5390", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public KKMMECBGMDP NBOAKBDFGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3620", Offset = "0x2FC1E20", VA = "0x182FC3620", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int PNGDFPPKAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2FBB890", Offset = "0x2FBA090", VA = "0x182FBB890", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public HAPDJLHBIJI MBMKNBNPPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2FBCE40", Offset = "0x2FBB640", VA = "0x182FBCE40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28E10C0", Offset = "0x28DF8C0", VA = "0x1828E10C0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2300", Offset = "0x2FC0B00", VA = "0x182FC2300", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::MAIOAIKFNKB<FJJPMAIFPPM> GLGIELNIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2FC58E0", Offset = "0x2FC40E0", VA = "0x182FC58E0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2FBB930", Offset = "0x2FBA130", VA = "0x182FBB930", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x28E16A0", Offset = "0x28DFEA0", VA = "0x1828E16A0")]
	public MNFHHBDNCBA(global::LBDNGNKNFJN<Entity> NPCKPCNEDPB, GGNOOGMPGOK KKLJBHKLNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1ED57C0", Offset = "0x1ED3FC0", VA = "0x181ED57C0")]
	private Entity AMBBLJNNNML(FJJPMAIFPPM AIOPADAFDKL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x28D9430", Offset = "0x28D7C30", VA = "0x1828D9430")]
	private FJJPMAIFPPM AMBBLJNNNML(Entity DJGIAPPGDDP)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1A00", Offset = "0x2FC0200", VA = "0x182FC1A00", Slot = "4")]
	public T HEJAGBNBHFE(FJJPMAIFPPM AIOPADAFDKL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC440", Offset = "0x2FBAC40", VA = "0x182FBC440")]
	public bool BJPKOCBPDKP(FJJPMAIFPPM AIOPADAFDKL, in T PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2FC31D0", Offset = "0x2FC19D0", VA = "0x182FC31D0")]
	public bool HKNNBEJHLAJ(FJJPMAIFPPM AIOPADAFDKL, in T PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3800", Offset = "0x2FC2000", VA = "0x182FC3800", Slot = "9")]
	public bool JONADHNAPOD(FJJPMAIFPPM AIOPADAFDKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2FBEC80", Offset = "0x2FBD480", VA = "0x182FBEC80", Slot = "26")]
	public object FONIIOAHOEA(FJJPMAIFPPM AIOPADAFDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2FBF210", Offset = "0x2FBDA10", VA = "0x182FBF210")]
	public bool GDPGHMOFBNA(FJJPMAIFPPM AIOPADAFDKL, in object PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2FC11D0", Offset = "0x2FBF9D0", VA = "0x182FC11D0")]
	public void HEJAGBNBHFE(FJJPMAIFPPM AIOPADAFDKL, in KMFGGFFJPFH NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC1F0", Offset = "0x2FBA9F0", VA = "0x182FBC1F0")]
	public bool BJPKOCBPDKP(FJJPMAIFPPM AIOPADAFDKL, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2950", Offset = "0x2FC1150", VA = "0x182FC2950")]
	public bool HKNNBEJHLAJ(FJJPMAIFPPM AIOPADAFDKL, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x28E0A30", Offset = "0x28DF230", VA = "0x1828E0A30", Slot = "22")]
	public void NELPADDHGOD(KGPEFICHJKL MPOCBDEMIGO, [Optional] object CDBJCAAPIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5EE0", Offset = "0x2FC46E0", VA = "0x182FC5EE0", Slot = "15")]
	public void NELPADDHGOD(FJJPMAIFPPM NHBANLNJEIH, EGMBBKCIEEA MPOCBDEMIGO, object CDBJCAAPIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC50F0", Offset = "0x2FC38F0", VA = "0x182FC50F0", Slot = "14")]
	public bool LBMJLEFFBAH(FJJPMAIFPPM LPGFPBINEAE, FJJPMAIFPPM OEDLDNKMKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4480", Offset = "0x2FC2C80", VA = "0x182FC4480")]
	private void KNPGEINOHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2FBFC70", Offset = "0x2FBE470", VA = "0x182FBFC70")]
	private void HBPKNJMAKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD720", Offset = "0x2FBBF20", VA = "0x182FBD720")]
	private void FMIGDDHCMIO(Entity DJGIAPPGDDP, in OJMHOIEICMJ CEOLOJHDIEE, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4BC0", Offset = "0x2FC33C0", VA = "0x182FC4BC0")]
	private void LBHOFFHPHPA(Entity DJGIAPPGDDP, in OJMHOIEICMJ CEOLOJHDIEE, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x28DA0C0", Offset = "0x28D88C0", VA = "0x1828DA0C0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6990", Offset = "0x2FC5190", VA = "0x182FC6990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2380", Offset = "0x2FC0B80", VA = "0x182FC2380")]
	public string HGKCPACHNMB(in OJMHOIEICMJ KNLMOBNIKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x28DDE70", Offset = "0x28DC670", VA = "0x1828DDE70", Slot = "5")]
	private bool PPAKBDLCPBM(FJJPMAIFPPM NHBANLNJEIH, in T PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x28DEE70", Offset = "0x28DD670", VA = "0x1828DEE70", Slot = "6")]
	private bool JGAFPNGKKEH(FJJPMAIFPPM NHBANLNJEIH, in T PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x28DE180", Offset = "0x28DC980", VA = "0x1828DE180", Slot = "10")]
	private bool HKEMAFMBDLC(FJJPMAIFPPM NHBANLNJEIH, in object PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x28E11B0", Offset = "0x28DF9B0", VA = "0x1828E11B0", Slot = "11")]
	private void OJNOODIGJKL(FJJPMAIFPPM NHBANLNJEIH, in KMFGGFFJPFH NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x28DA0F0", Offset = "0x28D88F0", VA = "0x1828DA0F0", Slot = "12")]
	private bool FIKABFMMFPI(FJJPMAIFPPM NHBANLNJEIH, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x28E0870", Offset = "0x28DF070", VA = "0x1828E0870", Slot = "13")]
	private bool MINLCGJPMCL(FJJPMAIFPPM NHBANLNJEIH, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x28DECB0", Offset = "0x28DD4B0", VA = "0x1828DECB0", Slot = "16")]
	private string HMEJJDBHOGH(in OJMHOIEICMJ NPHADDCNBHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KIDCDCBHCHF : IDisposable, FEKHKPAALFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> PDJKAODKNJI;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> LGDJBCABNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xCE0D90", Offset = "0xCDF590", VA = "0x180CE0D90")]
	public KIDCDCBHCHF(NativeArray<EntityRemapUtility.EntityRemapInfo> PDJKAODKNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x31D72C0", Offset = "0x31D5AC0", VA = "0x1831D72C0", Slot = "6")]
	public FJJPMAIFPPM HJJJGMCAKEL(FJJPMAIFPPM AIOPADAFDKL)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x31D7310", Offset = "0x31D5B10", VA = "0x1831D7310", Slot = "7")]
	public Entity HJJJGMCAKEL(Entity DJGIAPPGDDP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x31D7220", Offset = "0x31D5A20", VA = "0x1831D7220", Slot = "8")]
	public IEnumerable<FJJPMAIFPPM> HJJJGMCAKEL(IEnumerable<FJJPMAIFPPM> FMJIGOMDJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x31D71C0", Offset = "0x31D59C0", VA = "0x1831D71C0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[IECCMKJMAAC(LAEALBOAPLI.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly DELGGOALDMF CALGLKLCKIP;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static int CMMIJAAKLFD;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static FEKHKPAALFH BOAFCCFONHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool CPMNAGCLCHH;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> LGDJBCABNEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x2C985F0", Offset = "0x2C96DF0", VA = "0x182C985F0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool BFCAGIPBEBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2C98700", Offset = "0x2C96F00", VA = "0x182C98700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2C98790", Offset = "0x2C96F90", VA = "0x182C98790")]
		public static SerializationRemapScope PCPALIPONIL()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2C98880", Offset = "0x2C97080", VA = "0x182C98880")]
		public SerializationRemapScope(FEKHKPAALFH DHGAAKEPCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2C98250", Offset = "0x2C96A50", VA = "0x182C98250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2C98360", Offset = "0x2C96B60", VA = "0x182C98360")]
		public static FJJPMAIFPPM HJJJGMCAKEL(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2C984C0", Offset = "0x2C96CC0", VA = "0x182C984C0")]
		public static Entity HJJJGMCAKEL(Entity DJGIAPPGDDP)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[LDBLEAFJJLE(EKKHFCELHOI.Application)]
[FIKNCOOOHID(typeof(IGHBHKBOGDI), new string[] { "Editor" })]
public sealed class IGHBHKBOGDI
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void KIEAAHAAEKK(IOAGKMCGKAI BBIDHGLPNPG, IFDMHNGCHMF LBEMEOBAAJI, bool NFIJAFAPPBB);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void EFOADDCIFGA(IOAGKMCGKAI BBIDHGLPNPG, bool NFIJAFAPPBB);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void AODNKLGJJBC(IOAGKMCGKAI BBIDHGLPNPG, OBIAPIAFCLH NPCKPCNEDPB, in OJMHOIEICMJ NPHADDCNBHE, bool NFIJAFAPPBB);

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event KIEAAHAAEKK CLCJGJJOAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x31CFC20", Offset = "0x31CE420", VA = "0x1831CFC20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x31CFE70", Offset = "0x31CE670", VA = "0x1831CFE70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event EFOADDCIFGA BCLMEPJAFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x31CFF10", Offset = "0x31CE710", VA = "0x1831CFF10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x31CFCC0", Offset = "0x31CE4C0", VA = "0x1831CFCC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event AODNKLGJJBC MKJACCPCILH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x31CFFB0", Offset = "0x31CE7B0", VA = "0x1831CFFB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x31CFDA0", Offset = "0x31CE5A0", VA = "0x1831CFDA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x31CFD60", Offset = "0x31CE560", VA = "0x1831CFD60")]
	[Conditional("UNITY_EDITOR")]
	public void DAIHDFIGCGO(IOAGKMCGKAI BBIDHGLPNPG, in IFDMHNGCHMF LBEMEOBAAJI, bool NFIJAFAPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x31CFD80", Offset = "0x31CE580", VA = "0x1831CFD80")]
	[Conditional("UNITY_EDITOR")]
	public void IGHNMMGPHJF(IOAGKMCGKAI BBIDHGLPNPG, bool NFIJAFAPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x31CFE40", Offset = "0x31CE640", VA = "0x1831CFE40")]
	[Conditional("UNITY_EDITOR")]
	public void NBIIFPINFLK(IOAGKMCGKAI BBIDHGLPNPG, OBIAPIAFCLH NPCKPCNEDPB, in OJMHOIEICMJ NPHADDCNBHE, bool NFIJAFAPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public IGHBHKBOGDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[FIKNCOOOHID(typeof(HBKPFEBKAOJ), new string[] { "Editor" })]
[LDBLEAFJJLE(EKKHFCELHOI.Application)]
public sealed class HBKPFEBKAOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void PLOFNEECIAC(IOAGKMCGKAI DGNLFFKHMAE, IFDMHNGCHMF LBEMEOBAAJI, bool NFIJAFAPPBB);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void EOODMCBADKL(IOAGKMCGKAI DGNLFFKHMAE, bool NFIJAFAPPBB);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void CLLCIKHPAOB(IOAGKMCGKAI DGNLFFKHMAE, OBIAPIAFCLH NPCKPCNEDPB, in OJMHOIEICMJ NPHADDCNBHE, bool NFIJAFAPPBB, bool LAGKCACKFDN);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void MBDELEJLELC(IOAGKMCGKAI DGNLFFKHMAE, OBIAPIAFCLH NPCKPCNEDPB, in OJMHOIEICMJ CEOLOJHDIEE, in OJMHOIEICMJ PMHHEDOHMIJ);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate void ACECBBEADMF(OIIHFFHFMGL NHBANLNJEIH, ReadOnlyMemory<byte> HBMMCJPOJGP);

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event Action<World> EHAACNGJHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x31CB460", Offset = "0x31C9C60", VA = "0x1831CB460")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x31CB800", Offset = "0x31CA000", VA = "0x1831CB800")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> MHBPMDAFHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x31CBB40", Offset = "0x31CA340", VA = "0x1831CBB40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x31CB370", Offset = "0x31C9B70", VA = "0x1831CB370")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event PLOFNEECIAC CLCJGJJOAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x31CAF40", Offset = "0x31C9740", VA = "0x1831CAF40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x31CBC00", Offset = "0x31CA400", VA = "0x1831CBC00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event EOODMCBADKL BCLMEPJAFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x31CBD10", Offset = "0x31CA510", VA = "0x1831CBD10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x31CB080", Offset = "0x31C9880", VA = "0x1831CB080")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event PLOFNEECIAC BDBHJMEKMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x31CBAA0", Offset = "0x31CA2A0", VA = "0x1831CBAA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x31CB960", Offset = "0x31CA160", VA = "0x1831CB960")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event EOODMCBADKL HILMBPOLEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x31CB8C0", Offset = "0x31CA0C0", VA = "0x1831CB8C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x31CB1C0", Offset = "0x31C99C0", VA = "0x1831CB1C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event CLLCIKHPAOB MKJACCPCILH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x31CBDB0", Offset = "0x31CA5B0", VA = "0x1831CBDB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x31CBA00", Offset = "0x31CA200", VA = "0x1831CBA00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event MBDELEJLELC GHNMMMKKILA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x31CB120", Offset = "0x31C9920", VA = "0x1831CB120")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x31CB740", Offset = "0x31C9F40", VA = "0x1831CB740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> KEECCGLNLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x31CB570", Offset = "0x31C9D70", VA = "0x1831CB570")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x31CAFE0", Offset = "0x31C97E0", VA = "0x1831CAFE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event ACECBBEADMF NJOPMJFPKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x31CB6A0", Offset = "0x31C9EA0", VA = "0x1831CB6A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x31CB2D0", Offset = "0x31C9AD0", VA = "0x1831CB2D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x31CBE50", Offset = "0x31CA650", VA = "0x1831CBE50")]
	[Conditional("UNITY_EDITOR")]
	public void PIBKNADHIIE(IOAGKMCGKAI DGNLFFKHMAE, in IFDMHNGCHMF LBEMEOBAAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x31CB520", Offset = "0x31C9D20", VA = "0x1831CB520")]
	[Conditional("UNITY_EDITOR")]
	public void GOAEBJHJKGA(IOAGKMCGKAI DGNLFFKHMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x31CB670", Offset = "0x31C9E70", VA = "0x1831CB670")]
	[Conditional("UNITY_EDITOR")]
	public void IDDDKGNPHID(IOAGKMCGKAI DGNLFFKHMAE, in IFDMHNGCHMF LBEMEOBAAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x31CB7E0", Offset = "0x31C9FE0", VA = "0x1831CB7E0")]
	[Conditional("UNITY_EDITOR")]
	public void JDOJGEKDDOJ(IOAGKMCGKAI DGNLFFKHMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x31CB430", Offset = "0x31C9C30", VA = "0x1831CB430")]
	[Conditional("UNITY_EDITOR")]
	public void FFDJIAJFLJB(IOAGKMCGKAI DGNLFFKHMAE, OBIAPIAFCLH NPCKPCNEDPB, in OJMHOIEICMJ NPHADDCNBHE, bool LAGKCACKFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x31CAF20", Offset = "0x31C9720", VA = "0x1831CAF20")]
	[Conditional("UNITY_EDITOR")]
	public void ADEMAAPKHHB(IOAGKMCGKAI DGNLFFKHMAE, OBIAPIAFCLH NPCKPCNEDPB, in OJMHOIEICMJ CEOLOJHDIEE, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x31CB610", Offset = "0x31C9E10", VA = "0x1831CB610")]
	[Conditional("UNITY_EDITOR")]
	public void IDCFJJDDGLD(string LOIAMCEJAFO, object HBMMCJPOJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x31CB540", Offset = "0x31C9D40", VA = "0x1831CB540")]
	[Conditional("UNITY_EDITOR")]
	public void HKCAICBGBBA(OIIHFFHFMGL NHBANLNJEIH, ReadOnlyMemory<byte> HBMMCJPOJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x31CB260", Offset = "0x31C9A60", VA = "0x1831CB260")]
	[Conditional("UNITY_EDITOR")]
	public void EFIOFPPOBDM(World IFJKGEPFDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x31CBCA0", Offset = "0x31CA4A0", VA = "0x1831CBCA0")]
	[Conditional("UNITY_EDITOR")]
	public void OCOOPJDLMCC(World IFJKGEPFDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public HBKPFEBKAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[FIKNCOOOHID(typeof(MKHJMONLEHH), new string[] { })]
public class NGBIAGHIGGN : MKHJMONLEHH
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x289EAA0", Offset = "0x289D2A0", VA = "0x18289EAA0", Slot = "5")]
	public void NLINAHHJJGE(object EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x289E890", Offset = "0x289D090", VA = "0x18289E890", Slot = "6")]
	public void EHAIGJGAEJG(object EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x289E7A0", Offset = "0x289CFA0", VA = "0x18289E7A0", Slot = "7")]
	public void BPIAAHBLGKB(object EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x289E980", Offset = "0x289D180", VA = "0x18289E980", Slot = "4")]
	public IDisposable MCJLLGNNKIF(object EPAIMCEIMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public NGBIAGHIGGN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[IECCMKJMAAC(LAEALBOAPLI.Serialization)]
	[FIKNCOOOHID(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	internal class BulkInstantiateSceneObjectService : HNOABDNADGF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string EIEMKOGIAMF = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[EOIIILOBJAK]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[EOIIILOBJAK]
		private PNONIBNMECP MOMLDEEAAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[EOIIILOBJAK]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[EOIIILOBJAK]
		private HMGEJIKOHBO FLBPGJKFMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EntityQuery AGBPLEEKMNG;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EntityManager NKKGJCLICDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2D0B050", Offset = "0x2D09850", VA = "0x182D0B050")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AB80", Offset = "0x2D09380", VA = "0x182D0AB80", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AF30", Offset = "0x2D09730", VA = "0x182D0AF30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AA00", Offset = "0x2D09200", VA = "0x182D0AA00")]
		public bool AEFCHBOJDMB(IEnumerable<ILMPIIJELKE> OEBLGIDBEPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AF40", Offset = "0x2D09740", VA = "0x182D0AF40")]
		public static bool EKLIOOOOMLM(ILMPIIJELKE ODNHKCNDAKN, out IOAGKMCGKAI DGNLFFKHMAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B0A0", Offset = "0x2D098A0", VA = "0x182D0B0A0")]
		private void FAIOIKIOIEL(Dictionary<IOAGKMCGKAI, ILMPIIJELKE> JFGKCBHLINC, IEnumerable<ILMPIIJELKE> OEBLGIDBEPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2D0AD00", Offset = "0x2D09500", VA = "0x182D0AD00")]
		private void DHLFEDHHBCD(Dictionary<IOAGKMCGKAI, ILMPIIJELKE> JFGKCBHLINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B950", Offset = "0x2D0A150", VA = "0x182D0B950")]
		private void LBLLHPGBHOD(Dictionary<IOAGKMCGKAI, ILMPIIJELKE> JFGKCBHLINC, IOAGKMCGKAI DGNLFFKHMAE, string LOIAMCEJAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B420", Offset = "0x2D09C20", VA = "0x182D0B420")]
		private void JGFPCEBEEKN(Dictionary<IOAGKMCGKAI, ILMPIIJELKE> JFGKCBHLINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C000", Offset = "0x2D0A800", VA = "0x182D0C000")]
		private void MKMCGIPEKGA(Dictionary<IOAGKMCGKAI, ILMPIIJELKE> JFGKCBHLINC, List<ILMPIIJELKE> MCKMNOCBJOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2D0BE30", Offset = "0x2D0A630", VA = "0x182D0BE30")]
		private NativeList<IOAGKMCGKAI> MEABGGFKCIE(Dictionary<IOAGKMCGKAI, ILMPIIJELKE> JFGKCBHLINC)
		{
			return default(NativeList<IOAGKMCGKAI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2D0B780", Offset = "0x2D09F80", VA = "0x182D0B780")]
		private NativeArray<Entity> KCBDCJKBNMA(NativeList<IOAGKMCGKAI> FKCHNBGJBGL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C8A0", Offset = "0x2D0B0A0", VA = "0x182D0C8A0")]
		private static void NGOBNJLCPPF(Dictionary<IOAGKMCGKAI, ILMPIIJELKE> JFGKCBHLINC, IOAGKMCGKAI DGNLFFKHMAE, ILMPIIJELKE ODNHKCNDAKN, string LOIAMCEJAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[LDBLEAFJJLE(EKKHFCELHOI.Application)]
	[FIKNCOOOHID(typeof(DebugWorldsService), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.Serialization)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static bool NELKOMOKEAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x2D1E870", Offset = "0x2D1D070", VA = "0x182D1E870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x2D1E7F0", Offset = "0x2D1CFF0", VA = "0x182D1E7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool KDAHKHLGICG
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x2D1E8B0", Offset = "0x2D1D0B0", VA = "0x182D1E8B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x2D1E830", Offset = "0x2D1D030", VA = "0x182D1E830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public void EKPHELJABDN(string LOIAMCEJAFO, EntityManager AIFDIGHJEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public static void MMLFENDEPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[FIKNCOOOHID(typeof(EFPEDJCAGJM), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.Application)]
internal class EFPEDJCAGJM
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool NELKOMOKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D9250", Offset = "0x6D7A50", VA = "0x1806D9250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D9270", Offset = "0x6D7A70", VA = "0x1806D9270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool APKIMNECGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E90", Offset = "0x7F4690", VA = "0x1807F5E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EA0", Offset = "0x7F46A0", VA = "0x1807F5EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public EFPEDJCAGJM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[FIKNCOOOHID(typeof(JDDNAJGNJBI), new string[] { })]
	[NDHPNMMJOHD(typeof(SerializationService))]
	[IECCMKJMAAC(LAEALBOAPLI.Serialization)]
	internal class SerializationService : JDDNAJGNJBI, IDisposable, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly DELGGOALDMF DPJGFNOIDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[EOIIILOBJAK]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[EOIIILOBJAK]
		private OBEIMMOBIBP EDCAIOHEHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[EOIIILOBJAK]
		private EFPEDJCAGJM LIKPNGOHAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private NIEJGDDPJNF MLECFLPEGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private FMCAGKALAFL INGDEIBBHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private SerializationRemapScope AIKKNIBMGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool? CHNIAADBBCH;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool IMNFKBOLFMA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2C99510", Offset = "0x2C97D10", VA = "0x182C99510", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2C9A250", Offset = "0x2C98A50", VA = "0x182C9A250", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool MDLEPPFOFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x778D00", Offset = "0x777500", VA = "0x180778D00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x7794B0", Offset = "0x777CB0", VA = "0x1807794B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public FMCAGKALAFL NGCFMDOIIDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C98F70", Offset = "0x2C97770", VA = "0x182C98F70", Slot = "16")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C99520", Offset = "0x2C97D20", VA = "0x182C99520", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C99CA0", Offset = "0x2C984A0", VA = "0x182C99CA0")]
		public static bool KCMLEOEMIMC(ByteString GJAPHEDPMNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x717210", Offset = "0x715A10", VA = "0x180717210")]
		public void LECALPAGEOD(NIEJGDDPJNF AMIHCJLNBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A260", Offset = "0x2C98A60", VA = "0x182C9A260", Slot = "5")]
		public void NLAIFFIGINK(bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C99C10", Offset = "0x2C98410", VA = "0x182C99C10", Slot = "6")]
		public Task JOFACINMFJP(bool KEBPJDOCLJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A330", Offset = "0x2C98B30", VA = "0x182C9A330", Slot = "7")]
		public ByteString ODHIHDMAPDF(out IDisposable AIKKNIBMGAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A410", Offset = "0x2C98C10", VA = "0x182C9A410", Slot = "19")]
		public ByteString ODHIHDMAPDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C99BB0", Offset = "0x2C983B0", VA = "0x182C99BB0", Slot = "9")]
		public bool JFCMHHFNDFE(ByteString EINMNBLECBG, JHPDMBEMKLI DOJAOGGMBHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C98910", Offset = "0x2C97110", VA = "0x182C98910")]
		private bool ACLEJGNGMFJ(ByteString EINMNBLECBG, JHPDMBEMKLI DOJAOGGMBHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C99640", Offset = "0x2C97E40", VA = "0x182C99640", Slot = "8")]
		public void GKPLGLJFJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C992A0", Offset = "0x2C97AA0", VA = "0x182C992A0", Slot = "10")]
		public bool DELIKFNJIGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2C98C30", Offset = "0x2C97430", VA = "0x182C98C30", Slot = "11")]
		public bool AEFCHBOJDMB(IEnumerable<ILMPIIJELKE> EHADBCLKLDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2C99FA0", Offset = "0x2C987A0", VA = "0x182C99FA0")]
		public bool LNALGKEBAFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A640", Offset = "0x2C98E40", VA = "0x182C9A640", Slot = "12")]
		public bool PMKGKFFMMHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C99010", Offset = "0x2C97810", VA = "0x182C99010")]
		public void DBOIDADAJAD(FMCAGKALAFL.DJNLFEKNEBM.NAHABFLOKPH CDFGNMNLBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C99920", Offset = "0x2C98120", VA = "0x182C99920")]
		private bool JCNBOLEBMNO(ByteString EINMNBLECBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A5F0", Offset = "0x2C98DF0", VA = "0x182C9A5F0")]
		private void PFDDCPIOHJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2C99810", Offset = "0x2C98010", VA = "0x182C99810")]
		private ByteString IDDMIHKEHEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C99530", Offset = "0x2C97D30", VA = "0x182C99530")]
		private ByteString GDCKMJMAGDE(ByteString GJAPHEDPMNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C98ED0", Offset = "0x2C976D0", VA = "0x182C98ED0")]
		private FMCAGKALAFL.DJNLFEKNEBM.NAHABFLOKPH BPDOOKEFFPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C98EA0", Offset = "0x2C976A0", VA = "0x182C98EA0")]
		private void AOGODGBPFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C99DD0", Offset = "0x2C985D0", VA = "0x182C99DD0", Slot = "13")]
		public bool LCHKJPJNLEE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C99870", Offset = "0x2C98070", VA = "0x182C99870", Slot = "14")]
		public void ILHDAAGACPF(bool DADJEOILOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A080", Offset = "0x2C98880", VA = "0x182C9A080")]
		private void MMLFENDEPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[FIKNCOOOHID(typeof(FAIAJFOHDOE), new string[] { })]
[NDHPNMMJOHD(typeof(OBEIMMOBIBP))]
internal class OBEIMMOBIBP : FAIAJFOHDOE
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action GAMCBGAJNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x289FCB0", Offset = "0x289E4B0", VA = "0x18289FCB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x289F940", Offset = "0x289E140", VA = "0x18289F940", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<FEKHKPAALFH> HGEBLCINIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x289FDF0", Offset = "0x289E5F0", VA = "0x18289FDF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x289FF80", Offset = "0x289E780", VA = "0x18289FF80", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action JJFFKGJODEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x289F9E0", Offset = "0x289E1E0", VA = "0x18289F9E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x289FE90", Offset = "0x289E690", VA = "0x18289FE90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action KIHNBJDHJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x289FA80", Offset = "0x289E280", VA = "0x18289FA80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x289FD50", Offset = "0x289E550", VA = "0x18289FD50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<FEKHKPAALFH> HHIFNCCLFID
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x289FB20", Offset = "0x289E320", VA = "0x18289FB20", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x289FBC0", Offset = "0x289E3C0", VA = "0x18289FBC0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x10BBF50", Offset = "0x10BA750", VA = "0x1810BBF50")]
	public void GKPLGLJFJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x10BC150", Offset = "0x10BA950", VA = "0x1810BC150")]
	public void ABCNEJPJHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1212BB0", Offset = "0x12113B0", VA = "0x181212BB0")]
	public void FPCPFEMDLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x289FC60", Offset = "0x289E460", VA = "0x18289FC60")]
	public void GDBHMBPDKNM(FEKHKPAALFH BOAFCCFONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x289FF30", Offset = "0x289E730", VA = "0x18289FF30")]
	public void NNMJCGFJGOA(FEKHKPAALFH BOAFCCFONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public OBEIMMOBIBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[FIKNCOOOHID(typeof(HIFGFPBNEMJ), new string[] { })]
public class MFNNCLAOFEF : HIFGFPBNEMJ, DAANNPIBALJ, BGAFKNOHCIN, HNOABDNADGF, INBMAMBAHGE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityHierarchyParents OJCGOLJENME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private IIIGDFLHPJF DJNFBFHLKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ObjectEmbodimentService BFLDNFIFFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public global::PDGNJHJPBNB<FJJPMAIFPPM> MINIKDOMMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5A0", Offset = "0x6DADA0", VA = "0x1806DC5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager NKKGJCLICDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2899F90", Offset = "0x2898790", VA = "0x182899F90")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1A03F60", Offset = "0x1A02760", VA = "0x181A03F60", Slot = "14")]
	public void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2899DC0", Offset = "0x28985C0", VA = "0x182899DC0", Slot = "15")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2899AD0", Offset = "0x28982D0", VA = "0x182899AD0", Slot = "16")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1A03E90", Offset = "0x1A02690", VA = "0x181A03E90", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x289A300", Offset = "0x2898B00", VA = "0x18289A300")]
	private FJJPMAIFPPM HMPEAMHCKFA(Entity DJGIAPPGDDP)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x289A330", Offset = "0x2898B30", VA = "0x18289A330", Slot = "4")]
	public FJJPMAIFPPM JKKPEICCMFG(FJJPMAIFPPM AIOPADAFDKL)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2899FE0", Offset = "0x28987E0", VA = "0x182899FE0", Slot = "19")]
	public void FDFHFHEFAJP(ref List<FJJPMAIFPPM> DMECHADKKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2899A00", Offset = "0x2898200", VA = "0x182899A00", Slot = "20")]
	public IEnumerable<FJJPMAIFPPM> BLHBEIDAIFI(FJJPMAIFPPM AIOPADAFDKL, bool MEEOIIMCDHN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x289A200", Offset = "0x2898A00", VA = "0x18289A200", Slot = "21")]
	public FJJPMAIFPPM HJKEFAKELHJ(FJJPMAIFPPM AIOPADAFDKL, int LHHBOCAHDEE)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2899860", Offset = "0x2898060", VA = "0x182899860", Slot = "22")]
	public int BCGHKNPAKIP(FJJPMAIFPPM AIOPADAFDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x289A650", Offset = "0x2898E50", VA = "0x18289A650", Slot = "8")]
	public int NKKPNKDOOCN(FJJPMAIFPPM AIOPADAFDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x289A3C0", Offset = "0x2898BC0", VA = "0x18289A3C0", Slot = "9")]
	public HPJLDICLHHD LHGPBJNPPBO(FJJPMAIFPPM AIOPADAFDKL)
	{
		return default(HPJLDICLHHD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2899BC0", Offset = "0x28983C0", VA = "0x182899BC0", Slot = "23")]
	public bool CGCCAABONEG(FJJPMAIFPPM AIOPADAFDKL, out HPJLDICLHHD NHFOFMBHCJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x289A4B0", Offset = "0x2898CB0", VA = "0x18289A4B0", Slot = "24")]
	public IEnumerable<FJJPMAIFPPM> LNFGNLEGECP(FJJPMAIFPPM AIOPADAFDKL, bool MEEOIIMCDHN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x289A580", Offset = "0x2898D80", VA = "0x18289A580", Slot = "12")]
	public FJJPMAIFPPM MNCLLCOLFLA(FJJPMAIFPPM GFJEHCBMJMC, FJJPMAIFPPM FPIHIJPFEDK)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2899E90", Offset = "0x2898690", VA = "0x182899E90", Slot = "13")]
	public bool DGHKOIDPNCJ(FJJPMAIFPPM GFJEHCBMJMC, FJJPMAIFPPM FPIHIJPFEDK, out FJJPMAIFPPM IHHHDHPFGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x289A730", Offset = "0x2898F30", VA = "0x18289A730", Slot = "5")]
	public FJJPMAIFPPM PHLGOOAEONB(FJJPMAIFPPM AIOPADAFDKL)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x28999D0", Offset = "0x28981D0", VA = "0x1828999D0", Slot = "11")]
	public bool BIPOOOEDCME(FJJPMAIFPPM AIOPADAFDKL, FJJPMAIFPPM NAFEMOBEBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2899F60", Offset = "0x2898760", VA = "0x182899F60", Slot = "25")]
	public bool DODOFFOODPK(FJJPMAIFPPM AIOPADAFDKL, FJJPMAIFPPM PLIEEOJAEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x289A390", Offset = "0x2898B90", VA = "0x18289A390", Slot = "10")]
	public bool LEJLCLKDFHJ(FJJPMAIFPPM AIOPADAFDKL, FJJPMAIFPPM GFJEHCBMJMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2899D90", Offset = "0x2898590", VA = "0x182899D90", Slot = "6")]
	public bool CKPOHKFAFGL(FJJPMAIFPPM AIOPADAFDKL, FJJPMAIFPPM FAAJOMIIHED, bool HOGIBHGKCBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x289A700", Offset = "0x2898F00", VA = "0x18289A700", Slot = "7")]
	public bool OLDOCOJJOPA(FJJPMAIFPPM AIOPADAFDKL, FJJPMAIFPPM FAAJOMIIHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public MFNNCLAOFEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
[FIKNCOOOHID(typeof(MGDMBBFBAJB), new string[] { })]
internal class MGDMBBFBAJB : HNOABDNADGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[EOIIILOBJAK]
	private JHIICGGLBCC AIDEINAMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<int, LLOMGAJNLGK> DKHKMLCDAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x289AAF0", Offset = "0x28992F0", VA = "0x18289AAF0", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x289AB40", Offset = "0x2899340", VA = "0x18289AB40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x289A8E0", Offset = "0x28990E0", VA = "0x18289A8E0")]
	public LLOMGAJNLGK BMDAEJJMPCE(DMLMOBPCOID OABNINOCHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x289A790", Offset = "0x2898F90", VA = "0x18289A790")]
	public LLOMGAJNLGK BMDAEJJMPCE(OBIAPIAFCLH GCAANJILJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x289AC90", Offset = "0x2899490", VA = "0x18289AC90")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x289ADB0", Offset = "0x28995B0", VA = "0x18289ADB0")]
	public MGDMBBFBAJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class LLOMGAJNLGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<FOAHIHJJOGA> NLKFLMFOOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<NMHNICEEPMK> FBBCFNBDFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<AJKPJGJILHO> ENOIEMPKPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<NMHNICEEPMK> LCAJEAKHAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<FOAHIHJJOGA> HGGCGJNPJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0")]
		get
		{
			return default(NativeList<FOAHIHJJOGA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<NMHNICEEPMK> DCANCCACBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xC06C00", Offset = "0xC05400", VA = "0x180C06C00")]
		get
		{
			return default(NativeList<NMHNICEEPMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<AJKPJGJILHO> OLMAOHGJBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xE995E0", Offset = "0xE97DE0", VA = "0x180E995E0")]
		get
		{
			return default(NativeList<AJKPJGJILHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<NMHNICEEPMK> MHBGGAAPFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x118F390", Offset = "0x118DB90", VA = "0x18118F390")]
		get
		{
			return default(NativeList<NMHNICEEPMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle MGBHICMLKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x1285530", Offset = "0x1283D30", VA = "0x181285530")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1535FD0", Offset = "0x15347D0", VA = "0x181535FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool IFJHKPDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xFBF0D0", Offset = "0xFBD8D0", VA = "0x180FBF0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool MNMMIHOJOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x31DBDF0", Offset = "0x31DA5F0", VA = "0x1831DBDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x31DBF30", Offset = "0x31DA730", VA = "0x1831DBF30")]
	public LLOMGAJNLGK(Allocator OODGOAPHOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x31DBEA0", Offset = "0x31DA6A0", VA = "0x1831DBEA0")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x31DB980", Offset = "0x31DA180", VA = "0x1831DB980")]
	public void IPHJFMDKADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x31DBAB0", Offset = "0x31DA2B0", VA = "0x1831DBAB0")]
	public void LGCDELLOPGJ(Entity DJGIAPPGDDP, Entity KHANAHCNFDD, Entity ILKPJDALDEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[FIKNCOOOHID(typeof(FIBNFMDAIJF), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
public class FIBNFMDAIJF : HNOABDNADGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[EOIIILOBJAK]
	private SceneService NHAGBLLKJEL;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x31C6420", Offset = "0x31C4C20", VA = "0x1831C6420", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x31C6470", Offset = "0x31C4C70", VA = "0x1831C6470", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public FIBNFMDAIJF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[FIKNCOOOHID(typeof(PhotonInstanceCleanupService), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.Lifecycle)]
	[LDBLEAFJJLE(EKKHFCELHOI.PhotonRoom)]
	public class PhotonInstanceCleanupService : HNOABDNADGF, BGAFKNOHCIN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private FJCJOMHLGKK KGAFOMHDIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MFCLKPKNHMJ MIANENOIHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeList<int> MLILOFJGHMH;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x28AFE30", Offset = "0x28AE630", VA = "0x1828AFE30", Slot = "5")]
		public void CDCHANKPBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x28AFE90", Offset = "0x28AE690", VA = "0x1828AFE90", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x28AFD90", Offset = "0x28AE590", VA = "0x1828AFD90")]
		public void CDAPNANJPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x28AFF00", Offset = "0x28AE700", VA = "0x1828AFF00", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x28AFB80", Offset = "0x28AE380", VA = "0x1828AFB80")]
		public void BEJPBDKLLFL(global::CCPILFHLPCE<int> LAEJGLCBCIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x28AFFF0", Offset = "0x28AE7F0", VA = "0x1828AFFF0")]
		public void HOLPDNCIDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PhotonInstanceCleanupService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal abstract class JMMLBBMEHOG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint DMBOOMKBEDJ;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public abstract uint KPPDHEIBHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x9AD200", Offset = "0x9ABA00", VA = "0x1809AD200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x31D6440", Offset = "0x31D4C40", VA = "0x1831D6440")]
	public IOAGKMCGKAI BONOJCIGIMI()
	{
		return default(IOAGKMCGKAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x31D6490", Offset = "0x31D4C90", VA = "0x1831D6490")]
	public void NLMOONDCLFD(IOAGKMCGKAI DGNLFFKHMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xF17A80", Offset = "0xF16280", VA = "0x180F17A80", Slot = "6")]
	public virtual void NDKMADGHFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	protected JMMLBBMEHOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
[FIKNCOOOHID(typeof(DIFNEHGONLN), new string[] { })]
internal sealed class DIFNEHGONLN : JMMLBBMEHOG, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[EOIIILOBJAK]
	private HILDNPBHGOE GHFACKFNNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint EBHCCAJEKMJ;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint KPPDHEIBHPA
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6D5010", Offset = "0x6D3810", VA = "0x1806D5010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B570", Offset = "0x2D19D70", VA = "0x182D1B570", Slot = "7")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B520", Offset = "0x2D19D20", VA = "0x182D1B520")]
	private void CKFMNCLGPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B610", Offset = "0x2D19E10", VA = "0x182D1B610", Slot = "6")]
	public override void NDKMADGHFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
	public DIFNEHGONLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[FIKNCOOOHID(typeof(PPHPGJCMABF), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
internal sealed class PPHPGJCMABF : JMMLBBMEHOG
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint KPPDHEIBHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6DC170", Offset = "0x6DA970", VA = "0x1806DC170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
	public PPHPGJCMABF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
[FIKNCOOOHID(typeof(DPEBGGGDMAN), new string[] { })]
internal sealed class DPEBGGGDMAN : DAANNPIBALJ, BGAFKNOHCIN, HNOABDNADGF, INBMAMBAHGE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[EOIIILOBJAK]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery LMFPIHHIGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery JLLNHFFIBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery BINLKOAGHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery KKINCBGELME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery EGOEHFGGDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery JPKIBDOMOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private EntityManager NKKGJCLICDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2D1DEB0", Offset = "0x2D1C6B0", VA = "0x182D1DEB0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery CGNMLEDJGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery FGJEHPBPGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6F6030", Offset = "0x6F4830", VA = "0x1806F6030")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery JDAPKICNENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x10E33C0", Offset = "0x10E1BC0", VA = "0x1810E33C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery MMKLOIBCGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1285530", Offset = "0x1283D30", VA = "0x181285530")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery CHHACBCMOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x16C49D0", Offset = "0x16C31D0", VA = "0x1816C49D0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery MPBJNODIKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2D1DF00", Offset = "0x2D1C700", VA = "0x182D1DF00")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int LGBKCFBOBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E0B0", Offset = "0x2D1C8B0", VA = "0x182D1E0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int BEGHFIHPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E070", Offset = "0x2D1C870", VA = "0x182D1E070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int FEFGMIGEIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E090", Offset = "0x2D1C890", VA = "0x182D1E090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int NBABEEOGEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2D1DE90", Offset = "0x2D1C690", VA = "0x182D1DE90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int FALJDHIMKON
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2D1DF80", Offset = "0x2D1C780", VA = "0x182D1DF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int BIEELNKAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2D1DFA0", Offset = "0x2D1C7A0", VA = "0x182D1DFA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "4")]
	public void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DD80", Offset = "0x2D1C580", VA = "0x182D1DD80", Slot = "5")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D8E0", Offset = "0x2D1C0E0", VA = "0x182D1D8E0", Slot = "6")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DDD0", Offset = "0x2D1C5D0", VA = "0x182D1DDD0")]
	private EntityQueryDesc DKIAMJOPNGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DE30", Offset = "0x2D1C630", VA = "0x182D1DE30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D780", Offset = "0x2D1BF80", VA = "0x182D1D780")]
	public EBDMEILOJLB BCADGHMMIKH(FJJPMAIFPPM NGPFKAJPHJF)
	{
		return default(EBDMEILOJLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D830", Offset = "0x2D1C030", VA = "0x182D1D830")]
	public EBDMEILOJLB BCADGHMMIKH(Entity DJGIAPPGDDP)
	{
		return default(EBDMEILOJLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DFC0", Offset = "0x2D1C7C0", VA = "0x182D1DFC0")]
	public KCPOKGIHHKK KMAFHPIEDOJ(Entity DJGIAPPGDDP)
	{
		return default(KCPOKGIHHKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E0D0", Offset = "0x2D1C8D0", VA = "0x182D1E0D0")]
	public DPEBGGGDMAN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[IECCMKJMAAC(LAEALBOAPLI.All)]
	[FIKNCOOOHID(typeof(GGNOOGMPGOK), new string[] { })]
	public class ObjectService : HNOABDNADGF, GGNOOGMPGOK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly DELGGOALDMF BCEHLCLBBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[EOIIILOBJAK]
		private DLNPACLOKII CPOMNNHFPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[EOIIILOBJAK]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[EOIIILOBJAK]
		private ObjectLifecycleService KPJGDFLAFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[EOIIILOBJAK]
		private ObjectEmbodimentService BFLDNFIFFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[EOIIILOBJAK]
		private ObjectInstantiationService HFGBBMMCEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[EOIIILOBJAK]
		private DPEBGGGDMAN DJNFBFHLKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ObjectNetworkToLocalMapService DDLHJELICBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public DLNPACLOKII NODGMKJOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int LGBKCFBOBIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x28ADDA0", Offset = "0x28AC5A0", VA = "0x1828ADDA0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int BEGHFIHPJCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x28AD7E0", Offset = "0x28ABFE0", VA = "0x1828AD7E0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int FEFGMIGEIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x28ADC60", Offset = "0x28AC460", VA = "0x1828ADC60", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int NBABEEOGEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x28ACA20", Offset = "0x28AB220", VA = "0x1828ACA20", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int FALJDHIMKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x28AD260", Offset = "0x28ABA60", VA = "0x1828AD260", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int BIEELNKAHLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x28AD530", Offset = "0x28ABD30", VA = "0x1828AD530", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<FJJPMAIFPPM, KCPOKGIHHKK> AMODIEKGJDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x28ADC80", Offset = "0x28AC480", VA = "0x1828ADC80", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x28ADEF0", Offset = "0x28AC6F0", VA = "0x1828ADEF0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<FJJPMAIFPPM> INGELFBHGOI
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x28AD550", Offset = "0x28ABD50", VA = "0x1828AD550", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x28ACDD0", Offset = "0x28AB5D0", VA = "0x1828ACDD0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x28AC5E0", Offset = "0x28AADE0", VA = "0x1828AC5E0", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x28AC8A0", Offset = "0x28AB0A0", VA = "0x1828AC8A0", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x28ADDC0", Offset = "0x28AC5C0", VA = "0x1828ADDC0")]
		private void PKGDAKMHKJM(Entity DJGIAPPGDDP, KCPOKGIHHKK GANNEANJGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x28ADE60", Offset = "0x28AC660", VA = "0x1828ADE60")]
		private void PKMHCBPKBHC(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x28AD240", Offset = "0x28ABA40", VA = "0x1828AD240")]
		internal FJJPMAIFPPM HMPEAMHCKFA(Entity DJGIAPPGDDP)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x28AD740", Offset = "0x28ABF40", VA = "0x1828AD740", Slot = "41")]
		public HPJLDICLHHD KOFFEBPOLDE()
		{
			return default(HPJLDICLHHD);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x28AD890", Offset = "0x28AC090", VA = "0x1828AD890", Slot = "42")]
		public HPJLDICLHHD LJFGNPOCBDF()
		{
			return default(HPJLDICLHHD);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x28AD5F0", Offset = "0x28ABDF0", VA = "0x1828AD5F0", Slot = "43")]
		public HPJLDICLHHD KLIAGLAFAKB()
		{
			return default(HPJLDICLHHD);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x28AC190", Offset = "0x28AA990", VA = "0x1828AC190", Slot = "10")]
		public EBDMEILOJLB BCADGHMMIKH(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(EBDMEILOJLB);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x28AD690", Offset = "0x28ABE90", VA = "0x1828AD690", Slot = "11")]
		public KCPOKGIHHKK KMAFHPIEDOJ(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(KCPOKGIHHKK);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x28AD940", Offset = "0x28AC140", VA = "0x1828AD940")]
		private HPJLDICLHHD MCOHPGNECJD(EntityQuery PPFDACOOOGO)
		{
			return default(HPJLDICLHHD);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x28AD460", Offset = "0x28ABC60", VA = "0x1828AD460", Slot = "33")]
		public bool JONADHNAPOD(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x28ACD80", Offset = "0x28AB580", VA = "0x1828ACD80", Slot = "29")]
		public void FOAPFFHPHEB(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x28ACA40", Offset = "0x28AB240", VA = "0x1828ACA40", Slot = "30")]
		public void EGJAMHDMJIL(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x28AC0F0", Offset = "0x28AA8F0", VA = "0x1828AC0F0", Slot = "31")]
		public void BBJPDKOAPIC(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x28ADB00", Offset = "0x28AC300", VA = "0x1828ADB00", Slot = "22")]
		public JPEOKMJCLOL NJAIGPBILBM(KCPOKGIHHKK GANNEANJGDH, bool FDKNMDGFIME)
		{
			return default(JPEOKMJCLOL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x28ADA50", Offset = "0x28AC250", VA = "0x1828ADA50", Slot = "23")]
		public JPEOKMJCLOL NJAIGPBILBM(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(JPEOKMJCLOL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x28AD800", Offset = "0x28AC000", VA = "0x1828AD800", Slot = "24")]
		public JPEOKMJCLOL LFBFJKNANFO(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(JPEOKMJCLOL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x28AC1C0", Offset = "0x28AA9C0", VA = "0x1828AC1C0", Slot = "25")]
		public JPEOKMJCLOL BGCJNDHKFOO(IOAGKMCGKAI DGNLFFKHMAE, KCPOKGIHHKK GANNEANJGDH)
		{
			return default(JPEOKMJCLOL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x28AD3F0", Offset = "0x28ABBF0", VA = "0x1828AD3F0", Slot = "44")]
		public JPEOKMJCLOL JNJPJDEANMC(int BIBNMNNMCGB, KCPOKGIHHKK GANNEANJGDH, GameObject IMPKIJJJHKI)
		{
			return default(JPEOKMJCLOL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x28ACC70", Offset = "0x28AB470", VA = "0x1828ACC70", Slot = "26")]
		public JHEAGBIAAJG FFAKLJDMJDH()
		{
			return default(JHEAGBIAAJG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x28AC4C0", Offset = "0x28AACC0", VA = "0x1828AC4C0", Slot = "45")]
		public HJCDLBECFGP CDILNCFJGNP(MGJGOIMGAFJ EHPFPOFFCEJ)
		{
			return default(HJCDLBECFGP);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x28AC390", Offset = "0x28AAB90", VA = "0x1828AC390", Slot = "27")]
		public GKOGEGKNIEF BKIIIKIIBKB()
		{
			return default(GKOGEGKNIEF);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x28ACB30", Offset = "0x28AB330", VA = "0x1828ACB30", Slot = "28")]
		public BIMLNOKFEIK FEEOOJENLHP(FILDKNJLENH EHPFPOFFCEJ)
		{
			return default(BIMLNOKFEIK);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x28ADD20", Offset = "0x28AC520", VA = "0x1828ADD20", Slot = "12")]
		public void OFCCGGLDJKB(IOAGKMCGKAI DGNLFFKHMAE, CAEEJNEMGJH HDELAAJDCEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x28AD0F0", Offset = "0x28AB8F0", VA = "0x1828AD0F0", Slot = "13")]
		public JPEOKMJCLOL HIBLLJMNEMO(FJJPMAIFPPM AIOPADAFDKL, [Optional] object JPCLKLIDFBB)
		{
			return default(JPEOKMJCLOL);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x28AC850", Offset = "0x28AB050", VA = "0x1828AC850", Slot = "14")]
		public bool COKDPCHCLPD(FJJPMAIFPPM AIOPADAFDKL, out CAEEJNEMGJH KGFIMLECODA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x28ACD30", Offset = "0x28AB530", VA = "0x1828ACD30", Slot = "46")]
		public Transform FNEGDLIKGHL(FJJPMAIFPPM AIOPADAFDKL, [Optional] object JPCLKLIDFBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x28AC470", Offset = "0x28AAC70", VA = "0x1828AC470", Slot = "16")]
		public bool BNKAAADAPEE(FJJPMAIFPPM AIOPADAFDKL, out Transform KPFEIMOAGDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x28ACEB0", Offset = "0x28AB6B0", VA = "0x1828ACEB0", Slot = "17")]
		public bool HEGEOODMEBB(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x28ADD40", Offset = "0x28AC540", VA = "0x1828ADD40")]
		public bool PDIAKNNKHKL(CAEEJNEMGJH NPHADDCNBHE, [Optional] object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x28ADD70", Offset = "0x28AC570", VA = "0x1828ADD70", Slot = "47")]
		public bool PDIAKNNKHKL(FJJPMAIFPPM AIOPADAFDKL, [Optional] object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x28ACB10", Offset = "0x28AB310", VA = "0x1828ACB10", Slot = "48")]
		public void EOABLDLDILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x28ACF40", Offset = "0x28AB740", VA = "0x1828ACF40", Slot = "15")]
		public void HFNLCEFHIOP(CAEEJNEMGJH BFHAMCLNCKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x28ACE70", Offset = "0x28AB670", VA = "0x1828ACE70", Slot = "49")]
		public void GOICCLCLKJM(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x28AC070", Offset = "0x28AA870", VA = "0x1828AC070", Slot = "18")]
		public bool ALHNMHGEKED(Entity DJGIAPPGDDP, object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x28AD280", Offset = "0x28ABA80", VA = "0x1828AD280", Slot = "19")]
		public bool IIJMDCCECDI(Entity DJGIAPPGDDP, object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x28ACAA0", Offset = "0x28AB2A0", VA = "0x1828ACAA0", Slot = "50")]
		public bool EHFOKJPLIKI(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x28AD6D0", Offset = "0x28ABED0", VA = "0x1828AD6D0", Slot = "51")]
		public bool KNDIAODLPBP(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x28AD9F0", Offset = "0x28AC1F0", VA = "0x1828AD9F0", Slot = "32")]
		public NativeArray<(FJJPMAIFPPM, FJJPMAIFPPM)> MECJJFBHJKN(NativeArray<FJJPMAIFPPM> AHCLHKEHEEF, Allocator OODGOAPHOCI)
		{
			return default(NativeArray<(FJJPMAIFPPM, FJJPMAIFPPM)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x28ADBC0", Offset = "0x28AC3C0", VA = "0x1828ADBC0", Slot = "21")]
		public IOAGKMCGKAI NLKPEHJCAGC(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(IOAGKMCGKAI);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x28AD300", Offset = "0x28ABB00", VA = "0x1828AD300", Slot = "20")]
		public FJJPMAIFPPM IINJGBNILBC(IOAGKMCGKAI DGNLFFKHMAE)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x28AD4F0", Offset = "0x28ABCF0", VA = "0x1828AD4F0")]
		private void KBCCECNNMGA(KCPOKGIHHKK GANNEANJGDH, FJJPMAIFPPM AIOPADAFDKL, IOAGKMCGKAI DGNLFFKHMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
[FIKNCOOOHID(typeof(IKMHKOPGMMB), new string[] { })]
internal sealed class IKMHKOPGMMB : HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private ObjectInstantiationService HFGBBMMCEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[EOIIILOBJAK]
	private DPEBGGGDMAN DJNFBFHLKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[EOIIILOBJAK]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x31D1510", Offset = "0x31CFD10", VA = "0x1831D1510", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x31D1EF0", Offset = "0x31D06F0", VA = "0x1831D1EF0")]
	public NativeArray<(FJJPMAIFPPM, FJJPMAIFPPM)> MECJJFBHJKN(NativeArray<FJJPMAIFPPM> AHCLHKEHEEF, Allocator OODGOAPHOCI)
	{
		return default(NativeArray<(FJJPMAIFPPM, FJJPMAIFPPM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x31D1A30", Offset = "0x31D0230", VA = "0x1831D1A30")]
	private void GIOPCDFELFJ(NativeMultiHashMap<int, (FJJPMAIFPPM src, FJJPMAIFPPM dst)> HLJBNJANGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x31D15A0", Offset = "0x31CFDA0", VA = "0x1831D15A0")]
	private void EDIIDLDMNLC(NativeMultiHashMap<int, (FJJPMAIFPPM src, FJJPMAIFPPM dst)> HLJBNJANGEJ, int GANNEANJGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x31D1380", Offset = "0x31CFB80", VA = "0x1831D1380")]
	private void CINBHMEDIGJ(NativeMultiHashMap<int, (FJJPMAIFPPM src, FJJPMAIFPPM dst)> HLJBNJANGEJ, int GANNEANJGDH, NDFGOBMDHCC AIDEINAMABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x31D1C10", Offset = "0x31D0410", VA = "0x1831D1C10")]
	private NativeMultiHashMap<int, (FJJPMAIFPPM, FJJPMAIFPPM)> LFEEEBLKKEA(Allocator OODGOAPHOCI, NativeArray<FJJPMAIFPPM> AHCLHKEHEEF, out NativeArray<(FJJPMAIFPPM src, FJJPMAIFPPM dst)> CBDOPKFJHCG)
	{
		return default(NativeMultiHashMap<int, (FJJPMAIFPPM, FJJPMAIFPPM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public IKMHKOPGMMB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[IECCMKJMAAC(LAEALBOAPLI.TransformSyncing)]
	[NDHPNMMJOHD(typeof(TransformService))]
	[FIKNCOOOHID(typeof(HMGEJIKOHBO), new string[] { })]
	public class TransformService : HMGEJIKOHBO, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly DELGGOALDMF FHEDMACEMDA;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly DELGGOALDMF MDJIOODKBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NIAKDNFBLHC KCPLDCIJMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private PNONIBNMECP IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private HIFGFPBNEMJ GJCNCJNMMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TransformOwnershipPhase JFMGHGJMCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ObjectEmbodimentService OMHLILNOJHE;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private EntityManager NKKGJCLICDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x2CA1BD0", Offset = "0x2CA03D0", VA = "0x182CA1BD0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private NBDMAOHFKJB AFGIMGNBGBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x2CA4450", Offset = "0x2CA2C50", VA = "0x182CA4450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1260", Offset = "0x2C9FA60", VA = "0x182CA1260", Slot = "33")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0C70", Offset = "0x2C9F470", VA = "0x182CA0C70", Slot = "34")]
		public bool APCFJLNJAFG(Transform KPFEIMOAGDN, out FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2CD0", Offset = "0x2CA14D0", VA = "0x182CA2CD0", Slot = "35")]
		public Transform ILPEICCBMJP(Entity DJGIAPPGDDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0F80", Offset = "0x2C9F780", VA = "0x182CA0F80", Slot = "30")]
		public bool BNKAAADAPEE(Entity DJGIAPPGDDP, out Transform KPFEIMOAGDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0F60", Offset = "0x2C9F760", VA = "0x182CA0F60")]
		private void BKMPFDLBJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4510", Offset = "0x2CA2D10", VA = "0x182CA4510", Slot = "29")]
		public void MEIEDGJKMIK(Entity DJGIAPPGDDP, out Matrix4x4 GMFDLFPBDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1070", Offset = "0x2C9F870", VA = "0x182CA1070", Slot = "4")]
		public void CLLMPJIFGBJ(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4840", Offset = "0x2CA3040", VA = "0x182CA4840")]
		public void MODAIKAPOFA(Entity DJGIAPPGDDP, Vector3 GFAGIPAOELL, Quaternion DLNPDPAPICJ, Vector3 EMPHDDEDCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1C20", Offset = "0x2CA0420", VA = "0x182CA1C20")]
		public void EPJOCNOLPIP(Entity DJGIAPPGDDP, Vector3 GFAGIPAOELL, Quaternion DLNPDPAPICJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5240", Offset = "0x2CA3A40", VA = "0x182CA5240", Slot = "27")]
		public void PLFNLPEDELM(Entity DJGIAPPGDDP, out Matrix4x4 IPDNFDHGMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1F00", Offset = "0x2CA0700", VA = "0x182CA1F00")]
		public void FLGIDCGNINC(Entity DJGIAPPGDDP, in Matrix4x4 GMFDLFPBDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2820", Offset = "0x2CA1020", VA = "0x182CA2820")]
		public void HMMLLFGEBOK(Entity DJGIAPPGDDP, in Matrix4x4 GMFDLFPBDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0AB0", Offset = "0x2C9F2B0", VA = "0x182CA0AB0")]
		public void AKPFBKOPDAI(Entity DJGIAPPGDDP, in Matrix4x4 OBNGLMGFNMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2BB0", Offset = "0x2CA13B0", VA = "0x182CA2BB0", Slot = "5")]
		public void ILHCKIDLEFJ(Entity DJGIAPPGDDP, Vector3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3450", Offset = "0x2CA1C50", VA = "0x182CA3450", Slot = "6")]
		public Vector3 JODIKGHCJNL(Entity DJGIAPPGDDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1370", Offset = "0x2C9FB70", VA = "0x182CA1370", Slot = "7")]
		public void CNPDFAEEGEK(Entity DJGIAPPGDDP, Quaternion NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1D30", Offset = "0x2CA0530", VA = "0x182CA1D30", Slot = "8")]
		public Quaternion FFDINKKNLFM(Entity DJGIAPPGDDP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4740", Offset = "0x2CA2F40", VA = "0x182CA4740", Slot = "12")]
		public void MNDBCCAODLG(Entity DJGIAPPGDDP, Vector3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA19D0", Offset = "0x2CA01D0", VA = "0x182CA19D0", Slot = "11")]
		public Vector3 EFJOOGCAHKH(Entity DJGIAPPGDDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2D90", Offset = "0x2CA1590", VA = "0x182CA2D90")]
		public void JCADPDFDEIH(Entity DJGIAPPGDDP, Vector3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5250", Offset = "0x2CA3A50", VA = "0x182CA5250")]
		private Vector3 POPLNLICHII(Entity DJGIAPPGDDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0E30", Offset = "0x2C9F630", VA = "0x182CA0E30", Slot = "14")]
		public float BDNDHADAPJC(Entity DJGIAPPGDDP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3560", Offset = "0x2CA1D60", VA = "0x182CA3560", Slot = "13")]
		public void KBMMJMJJKJC(Entity DJGIAPPGDDP, float NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3070", Offset = "0x2CA1870", VA = "0x182CA3070")]
		private float JIGJNOGIEOD(Entity DJGIAPPGDDP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0ED0", Offset = "0x2C9F6D0", VA = "0x182CA0ED0")]
		public void BKBBCOHPNOO(Entity DJGIAPPGDDP, float JDCADHFCCJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4B80", Offset = "0x2CA3380", VA = "0x182CA4B80", Slot = "16")]
		public Vector3 OAJCHJLJNPO(Entity DJGIAPPGDDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2A80", Offset = "0x2CA1280", VA = "0x182CA2A80", Slot = "15")]
		public void IILPCPMKAFN(Entity DJGIAPPGDDP, Vector3 PFLJAHKHMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2950", Offset = "0x2CA1150", VA = "0x182CA2950")]
		private Vector3 IFLKMJBPCFP(Entity DJGIAPPGDDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2620", Offset = "0x2CA0E20", VA = "0x182CA2620")]
		public void GOGNNIBAPJC(Entity DJGIAPPGDDP, Vector3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2CA22C0", Offset = "0x2CA0AC0", VA = "0x182CA22C0")]
		[Conditional("DEBUG_BUILD")]
		private void FMOGAPFMOHM(Entity DJGIAPPGDDP, Vector3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3C50", Offset = "0x2CA2450", VA = "0x182CA3C50", Slot = "36")]
		public void LFKHBMACFMP(Entity DJGIAPPGDDP, Vector3 LMLCHIPKJPI, Quaternion ILBCPDKFKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2CA31E0", Offset = "0x2CA19E0", VA = "0x182CA31E0", Slot = "9")]
		public void JKMDHGEJAAC(Entity DJGIAPPGDDP, out Vector3 LMLCHIPKJPI, out Quaternion ILBCPDKFKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA26F0", Offset = "0x2CA0EF0", VA = "0x182CA26F0", Slot = "10")]
		public void HFJMEFMCPIG(Entity DJGIAPPGDDP, out Vector3 LMLCHIPKJPI, out Quaternion ILBCPDKFKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0430", Offset = "0x2C9EC30", VA = "0x182CA0430", Slot = "37")]
		public void ABMLKAOACLK(Entity DJGIAPPGDDP, Vector3 LMLCHIPKJPI, Quaternion ILBCPDKFKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1470", Offset = "0x2C9FC70", VA = "0x182CA1470")]
		public void DADDGKLMDBP(Entity DJGIAPPGDDP, Vector3 LMLCHIPKJPI, Quaternion ILBCPDKFKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3670", Offset = "0x2CA1E70", VA = "0x182CA3670", Slot = "17")]
		public void KEMPDDAHJHG(Entity DJGIAPPGDDP, Vector3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4660", Offset = "0x2CA2E60", VA = "0x182CA4660", Slot = "18")]
		public Vector3 MMBFIJFLMNM(Entity DJGIAPPGDDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA38A0", Offset = "0x2CA20A0", VA = "0x182CA38A0", Slot = "19")]
		public void LDMGALIACCF(Entity DJGIAPPGDDP, Quaternion NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4C60", Offset = "0x2CA3460", VA = "0x182CA4C60", Slot = "20")]
		public Quaternion OPBHGPBIOJE(Entity DJGIAPPGDDP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0650", Offset = "0x2C9EE50", VA = "0x182CA0650", Slot = "22")]
		public void AINMHABFNBF(Entity DJGIAPPGDDP, Vector3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1AE0", Offset = "0x2CA02E0", VA = "0x182CA1AE0", Slot = "21")]
		public Vector3 EGODNHDKMKM(Entity DJGIAPPGDDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3AE0", Offset = "0x2CA22E0", VA = "0x182CA3AE0", Slot = "23")]
		public void LECJJDCHLEH(Entity DJGIAPPGDDP, float AFBOINKGKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3330", Offset = "0x2CA1B30", VA = "0x182CA3330", Slot = "24")]
		public float JNOEDOPFBLM(Entity DJGIAPPGDDP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4D50", Offset = "0x2CA3550", VA = "0x182CA4D50", Slot = "25")]
		public void PAMOEOFOPBP(Entity DJGIAPPGDDP, Vector3 ADLHIHEAKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA02F0", Offset = "0x2C9EAF0", VA = "0x182CA02F0", Slot = "26")]
		public Vector3 ABMDHGJJEPA(Entity DJGIAPPGDDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3DB0", Offset = "0x2CA25B0", VA = "0x182CA3DB0", Slot = "31")]
		public void LLDMBACBOCA(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4A30", Offset = "0x2CA3230", VA = "0x182CA4A30")]
		private FJJPMAIFPPM NPBKKBPGNFF(Transform KPFEIMOAGDN)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2E40", Offset = "0x2CA1640", VA = "0x182CA2E40")]
		private static TransformEntity JHJKMGOBFEG(KCPOKGIHHKK EHPFPOFFCEJ, GameObject HFJAINPDLBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4910", Offset = "0x2CA3110", VA = "0x182CA4910", Slot = "32")]
		public void NGPBMAKGCLO(Entity DJGIAPPGDDP, Entity KHANAHCNFDD, Entity ILKPJDALDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3160", Offset = "0x2CA1960", VA = "0x182CA3160")]
		private IJIAOACCMAD JKMDHGEJAAC(Entity DJGIAPPGDDP)
		{
			return default(IJIAOACCMAD);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1E20", Offset = "0x2CA0620", VA = "0x182CA1E20")]
		private bool FJIKHDNKEIL(Entity DJGIAPPGDDP, out Entity FAAJOMIIHED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2470", Offset = "0x2CA0C70", VA = "0x182CA2470")]
		private void GJJPPEPFOPF(Entity DJGIAPPGDDP, out Matrix4x4 GMFDLFPBDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1630", Offset = "0x2C9FE30", VA = "0x182CA1630")]
		private void DGOBGGFAAFD(Entity DJGIAPPGDDP, out Matrix4x4 OBNGLMGFNMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2E30", Offset = "0x2CA1630", VA = "0x182CA2E30", Slot = "28")]
		private void JEDAFMINKKN(Entity DJGIAPPGDDP, in Matrix4x4 IPDNFDHGMED)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
[FIKNCOOOHID(typeof(EJIJHIJDHAP), new string[] { })]
internal sealed class EJIJHIJDHAP : HNOABDNADGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[EOIIILOBJAK]
	private HILDNPBHGOE GHFACKFNNLB;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x31BF680", Offset = "0x31BDE80", VA = "0x1831BF680", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x31BF750", Offset = "0x31BDF50", VA = "0x1831BF750", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public EJIJHIJDHAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
[FIKNCOOOHID(typeof(NJJMCMLLMLI), new string[] { })]
public class NJJMCMLLMLI
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct NMADCOIOHLG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly NJJMCMLLMLI FAAJOMIIHED;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x4191480", Offset = "0x418FC80", VA = "0x184191480")]
		public NMADCOIOHLG(NJJMCMLLMLI FAAJOMIIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x4191460", Offset = "0x418FC60", VA = "0x184191460", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int FICDPDGAMAE;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool KDAOOHAJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x102CA30", Offset = "0x102B230", VA = "0x18102CA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action FPIGMLGLAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x289EEA0", Offset = "0x289D6A0", VA = "0x18289EEA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x289EF40", Offset = "0x289D740", VA = "0x18289EF40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x289EE70", Offset = "0x289D670", VA = "0x18289EE70")]
	public NMADCOIOHLG AADANFBDLIK()
	{
		return default(NMADCOIOHLG);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x16AAA90", Offset = "0x16A9290", VA = "0x1816AAA90")]
	public void APHNHAIKJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x289EFE0", Offset = "0x289D7E0", VA = "0x18289EFE0")]
	public void PEDILBMCKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public NJJMCMLLMLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[FIKNCOOOHID(typeof(DPOMMEHNOPH), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
public class DPOMMEHNOPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int FICDPDGAMAE;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool NELKOMOKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xDCE1C0", Offset = "0xDCC9C0", VA = "0x180DCE1C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9B9DD0", Offset = "0x9B85D0", VA = "0x1809B9DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DPOMMEHNOPH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[FIKNCOOOHID(typeof(EnableComponentSystemsInScope), new string[] { })]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[IECCMKJMAAC(LAEALBOAPLI.ComponentSystemTypes)]
	public class EnableComponentSystemsInScope : HNOABDNADGF, AAHMCPLHFFN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct CLIGIIPOOBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private NativeArray<int> LKIAINPIDCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private NativeArray<int> MMKNKBBOLLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private Dictionary<ComponentSystemBase, int> KICPBPIGBJO;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x4189380", Offset = "0x4187B80", VA = "0x184189380")]
			public CLIGIIPOOBP(NativeArray<int> LKIAINPIDCF, NativeArray<int> MMKNKBBOLLG, Dictionary<ComponentSystemBase, int> KICPBPIGBJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x4189100", Offset = "0x4187900", VA = "0x184189100")]
			public void BAICGEJLDBA(IEnumerable<ComponentSystemBase> CPOMNNHFPBO, EKKHFCELHOI OBKBACHOFEO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class JJCDADFBCMD : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
			[DebuggerHidden]
			public JJCDADFBCMD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x418F3F0", Offset = "0x418DBF0", VA = "0x18418F3F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x418F5C0", Offset = "0x418DDC0", VA = "0x18418F5C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x418F510", Offset = "0x418DD10", VA = "0x18418F510", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x418F510", Offset = "0x418DD10", VA = "0x18418F510", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const EKKHFCELHOI PJFBEFMKNOF = EKKHFCELHOI.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly DELGGOALDMF EOKJGLPHCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[EOIIILOBJAK]
		private PNONIBNMECP MOMLDEEAAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private World IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private FEIANFNLNIA BDDMBDBDABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeArray<int> LPDLLJJGBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NativeArray<int> HBMPECHPHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int OGPINCOPHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private EKKHFCELHOI FGIIKJLHBOL;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x31C0FB0", Offset = "0x31BF7B0", VA = "0x1831C0FB0", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x31C10A0", Offset = "0x31BF8A0", VA = "0x1831C10A0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x31C1130", Offset = "0x31BF930", VA = "0x1831C1130")]
		[IteratorStateMachine(typeof(JJCDADFBCMD))]
		private IEnumerable<ComponentSystemBase> GEEKPAPFAPN(int DAOIPFCHFFJ, int FBIOFODCNKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x31C0F30", Offset = "0x31BF730", VA = "0x1831C0F30", Slot = "5")]
		public void ALBEHPNMNIP(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x31C0F30", Offset = "0x31BF730", VA = "0x1831C0F30")]
		private void OFCJGBDOKFO(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x31C18D0", Offset = "0x31C00D0", VA = "0x1831C18D0")]
		public void OFCJGBDOKFO(EKKHFCELHOI JDPPHDDOKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x31C1330", Offset = "0x31BFB30", VA = "0x1831C1330")]
		private void JJCEMBGACOM(EKKHFCELHOI JDPPHDDOKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x31C0EA0", Offset = "0x31BF6A0", VA = "0x1831C0EA0")]
		private void AHPAJEDFONC(EKKHFCELHOI JDPPHDDOKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x31C1220", Offset = "0x31BFA20", VA = "0x1831C1220")]
		private void GKCBHKAGAAL(EKKHFCELHOI JDPPHDDOKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x31C1810", Offset = "0x31C0010", VA = "0x1831C1810")]
		private void OAEKIGCBICO(int DAOIPFCHFFJ, int FBIOFODCNKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x31C1600", Offset = "0x31BFE00", VA = "0x1831C1600")]
		private void LKIKMLNPCFK(int DAOIPFCHFFJ, int FBIOFODCNKG, bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x31C1080", Offset = "0x31BF880", VA = "0x1831C1080")]
		private int DMPKDAKGHIP(EKKHFCELHOI JDPPHDDOKND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x31C19D0", Offset = "0x31C01D0", VA = "0x1831C19D0")]
		private bool OMFHMKNOKLJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x31C16C0", Offset = "0x31BFEC0", VA = "0x1831C16C0")]
		private Dictionary<ComponentSystemBase, int> MDCEJBNEMEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x31C15C0", Offset = "0x31BFDC0", VA = "0x1831C15C0")]
		private void LAFFPBNFOMO(NativeArray<int> LKIAINPIDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x31C1280", Offset = "0x31BFA80", VA = "0x1831C1280")]
		private void IBDLLHNPDGL(NativeArray<int> MMKNKBBOLLG, NativeArray<int> LKIAINPIDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x31C11C0", Offset = "0x31BF9C0", VA = "0x1831C11C0")]
		private static EKKHFCELHOI GJPJOOOACBJ(Type EHPFPOFFCEJ, EKKHFCELHOI CMEPDMFEMEH)
		{
			return default(EKKHFCELHOI);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x31C2050", Offset = "0x31C0850", VA = "0x1831C2050")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x31C1F60", Offset = "0x31C0760", VA = "0x1831C1F60")]
		[CompilerGenerated]
		private void PBODBDMAGOH(HNOABDNADGF LKBBPJPNDBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x31C17B0", Offset = "0x31BFFB0", VA = "0x1831C17B0")]
		[CompilerGenerated]
		private void NJDIJGMDCJI(INBMAMBAHGE LKBBPJPNDBM)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[IECCMKJMAAC(LAEALBOAPLI.WorldService)]
	[FIKNCOOOHID(typeof(JDLGCJBNHOE), new string[] { })]
	public class TickService : HNOABDNADGF, JDLGCJBNHOE
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly ProfilerMarker FAJKDKKILDG;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ProfilerMarker BBNCBKDNBMP;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly ProfilerMarker BFMEGANFHAK;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly ProfilerMarker MJOAANFIJKK;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly ProfilerMarker FLDPNGGIFNI;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly ProfilerMarker FADJNGEBCNM;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly ProfilerMarker GBMNGAECALD;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly ProfilerMarker MPPFNCOONLJ;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly ProfilerMarker GCILAMHNGFB;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly ProfilerMarker EOAILKFJJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[EOIIILOBJAK]
		private PNONIBNMECP MOMLDEEAAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[EOIIILOBJAK]
		private JDDNAJGNJBI AOPMIABPHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[EOIIILOBJAK]
		private EFPEDJCAGJM AFJGCADODCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[EOIIILOBJAK]
		private TransformOwnershipPhase FBCMJKDDCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[EOIIILOBJAK]
		private TimeService LMENJFALMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private KPAAIPGAPMC IFJKGEPFDIB;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool NJIHJODDPDI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EB60", Offset = "0x2C9D360", VA = "0x182C9EB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool POODFBBONKO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F380", Offset = "0x2C9DB80", VA = "0x182C9F380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool KGKDPJHAEPA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EB60", Offset = "0x2C9D360", VA = "0x182C9EB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool MKIFDALFNGB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EB60", Offset = "0x2C9D360", VA = "0x182C9EB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E920", Offset = "0x2C9D120", VA = "0x182C9E920", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F0E0", Offset = "0x2C9D8E0", VA = "0x182C9F0E0", Slot = "14")]
		public void JFPPLHADJAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E530", Offset = "0x2C9CD30", VA = "0x182C9E530", Slot = "15")]
		public void AGFKNFFLOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C9EBD0", Offset = "0x2C9D3D0", VA = "0x182C9EBD0", Slot = "5")]
		public void GEFKOLGIKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E650", Offset = "0x2C9CE50", VA = "0x182C9E650", Slot = "6")]
		public void AGPLOCAKBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F5A0", Offset = "0x2C9DDA0", VA = "0x182C9F5A0", Slot = "7")]
		public void ODDLAECFEFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F200", Offset = "0x2C9DA00", VA = "0x182C9F200", Slot = "8")]
		public void LJNOMKPPCAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F420", Offset = "0x2C9DC20", VA = "0x182C9F420", Slot = "9")]
		public void MJMLKBJNHCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C9ECA0", Offset = "0x2C9D4A0", VA = "0x182C9ECA0", Slot = "10")]
		public void GOCHNIMACIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C9EA90", Offset = "0x2C9D290", VA = "0x182C9EA90", Slot = "11")]
		public void EKGOKHEPLAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "13")]
		public void JPENEDBCGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E7D0", Offset = "0x2C9CFD0", VA = "0x182C9E7D0", Slot = "12")]
		public void BIBOOJJLIFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[FIKNCOOOHID(typeof(PNONIBNMECP), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.WorldService)]
	public class WorldService : PNONIBNMECP, IDisposable, BGAFKNOHCIN, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private KPAAIPGAPMC IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private HBKPFEBKAOJ MCILAPBKIBA;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public KPAAIPGAPMC BCCOIHBMLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public NBDMAOHFKJB AFGIMGNBGBD
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2CAD6E0", Offset = "0x2CABEE0", VA = "0x182CAD6E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager NKKGJCLICDN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2CAD6C0", Offset = "0x2CABEC0", VA = "0x182CAD6C0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool IFJHKPDANNN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8D0", Offset = "0x6EE0D0", VA = "0x1806EF8D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD330", Offset = "0x2CABB30", VA = "0x182CAD330", Slot = "10")]
		public void CDCHANKPBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD440", Offset = "0x2CABC40", VA = "0x182CAD440", Slot = "11")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD700", Offset = "0x2CABF00", VA = "0x182CAD700")]
		private void OJONNLHFKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD490", Offset = "0x2CABC90", VA = "0x182CAD490", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD810", Offset = "0x2CAC010", VA = "0x182CAD810", Slot = "8")]
		public ComponentSystemBase OPFJPJEHIOH(Type EHPFPOFFCEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[FIKNCOOOHID(typeof(DAKEIBCIDGC), new string[] { })]
public sealed class GILCOPNNPPP : DAKEIBCIDGC, DAANNPIBALJ, BGAFKNOHCIN, HNOABDNADGF, INBMAMBAHGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class IOHJOEPELMB : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x418EA60", Offset = "0x418D260", VA = "0x18418EA60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x97CE80", Offset = "0x97B680", VA = "0x18097CE80")]
		[DebuggerHidden]
		public IOHJOEPELMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x418E750", Offset = "0x418CF50", VA = "0x18418E750", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x418EA20", Offset = "0x418D220", VA = "0x18418EA20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x418E980", Offset = "0x418D180", VA = "0x18418E980", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x418E980", Offset = "0x418D180", VA = "0x18418E980", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[EOIIILOBJAK]
	private IOIEJFCEOCP AIDEINAMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly MGHBKEONNDB AHOABCNJPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Dictionary<string, LOCABJIHLHF> NHJCCLDOJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Dictionary<int, BDHEIHALJHA> BEGNJMOKEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<CBKEAKDLCBB> HFFFHJBHMDK;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public BDHEIHALJHA PGPOJHKEGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x31C9990", Offset = "0x31C8190", VA = "0x1831C9990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<CBKEAKDLCBB> PENGILLAIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
	public void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x31C9810", Offset = "0x31C8010", VA = "0x1831C9810", Slot = "8")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x31C9760", Offset = "0x31C7F60", VA = "0x1831C9760", Slot = "9")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x31C9900", Offset = "0x31C8100", VA = "0x1831C9900", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x31C9870", Offset = "0x31C8070", VA = "0x1831C9870", Slot = "6")]
	public bool DMBJHJAFAJD(CBKEAKDLCBB NPCKPCNEDPB, out BDHEIHALJHA DAMNENENKAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x31C9A40", Offset = "0x31C8240", VA = "0x1831C9A40")]
	private void HCECNMGHIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x31C95C0", Offset = "0x31C7DC0", VA = "0x1831C95C0")]
	private void BDAIAPHEBLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x31C9FB0", Offset = "0x31C87B0", VA = "0x1831C9FB0")]
	private LOCABJIHLHF KKNAHMMDAOC(string FDEICCGJGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x31C9990", Offset = "0x31C8190", VA = "0x1831C9990")]
	private LOCABJIHLHF EHCAKFPCDHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x31CA060", Offset = "0x31C8860", VA = "0x1831CA060")]
	private LOCABJIHLHF NLNANCAJAJM(string FDEICCGJGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x31CA2D0", Offset = "0x31C8AD0", VA = "0x1831CA2D0")]
	private LOCABJIHLHF OKPPFHAOEGC(string EKLHOMDDPCF, string JPCLKLIDFBB, [Optional] LOCABJIHLHF CFOBNGBDMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x31C9F40", Offset = "0x31C8740", VA = "0x1831C9F40")]
	[IteratorStateMachine(typeof(IOHJOEPELMB))]
	private IEnumerable<(string, string)> JLAPMDEHMKK(string FDEICCGJGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x31CA010", Offset = "0x31C8810", VA = "0x1831CA010")]
	private bool LPLCJNEMPDK(CBKEAKDLCBB NPCKPCNEDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x31C9E60", Offset = "0x31C8660", VA = "0x1831C9E60")]
	private MGHBKEONNDB HINPNAJOGGH(CBKEAKDLCBB NPCKPCNEDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x31C99F0", Offset = "0x31C81F0", VA = "0x1831C99F0")]
	private MGHBKEONNDB FCHCJLEKCDA(CBKEAKDLCBB NPCKPCNEDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x31C9780", Offset = "0x31C7F80", VA = "0x1831C9780")]
	private MGHBKEONNDB CIMOACCGDJF(CBKEAKDLCBB NPCKPCNEDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x269E470", Offset = "0x269CC70", VA = "0x18269E470")]
	private T DMPLEOCGBMB<T>(CBKEAKDLCBB NPCKPCNEDPB) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x31C9550", Offset = "0x31C7D50", VA = "0x1831C9550")]
	private FieldInfo AEPJLCEINEF(CBKEAKDLCBB NPCKPCNEDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x31CA4A0", Offset = "0x31C8CA0", VA = "0x1831CA4A0")]
	public GILCOPNNPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x31C9DD0", Offset = "0x31C85D0", VA = "0x1831C9DD0")]
	[CompilerGenerated]
	private int HFGKBHLFEFD(CBKEAKDLCBB HDPOKDCLGGE, CBKEAKDLCBB JBKIIGINOKM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class LOCABJIHLHF : BDHEIHALJHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly string AMBOJKGCHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly LOCABJIHLHF CFOBNGBDMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly List<LOCABJIHLHF> IHKKBICDPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly List<CBKEAKDLCBB> AIDEINAMABM;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string NKGMAEMMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public BDHEIHALJHA HDEDBHIEHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<BDHEIHALJHA> PEPALCLDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<CBKEAKDLCBB> HLEJCLDEHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x31DC020", Offset = "0x31DA820", VA = "0x1831DC020")]
	public LOCABJIHLHF(string LOIAMCEJAFO, LOCABJIHLHF FAAJOMIIHED)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[FIKNCOOOHID(typeof(KEFOHIEBEBL), new string[] { })]
	[NDHPNMMJOHD(typeof(HistoryService))]
	[IECCMKJMAAC(LAEALBOAPLI.History)]
	public class HistoryService : HNOABDNADGF, IDisposable, KEFOHIEBEBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private enum LHHOIIDPOJH
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private readonly struct EKEPKLPNKNB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly LHHOIIDPOJH FAEKKLOEJGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly HistoryService NDMKBPHJBKB;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x418B650", Offset = "0x4189E50", VA = "0x18418B650")]
			public EKEPKLPNKNB(HistoryService NDMKBPHJBKB, bool LEDNJFDAKOB, uint OGPINCOPHCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x418B620", Offset = "0x4189E20", VA = "0x18418B620", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public class KJFLJLLDNKH
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct GLONCAIKBNG : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private readonly KJFLJLLDNKH EPGENEEAIGN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private readonly bool AKBJFIDFFAN;

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x418DBB0", Offset = "0x418C3B0", VA = "0x18418DBB0")]
				public GLONCAIKBNG(KJFLJLLDNKH EPGENEEAIGN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x4188E10", Offset = "0x4187610", VA = "0x184188E10", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct CHMAELMAIOF : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private readonly KJFLJLLDNKH EPGENEEAIGN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private readonly bool AKBJFIDFFAN;

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x4188E40", Offset = "0x4187640", VA = "0x184188E40")]
				public CHMAELMAIOF(KJFLJLLDNKH EPGENEEAIGN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x4188E10", Offset = "0x4187610", VA = "0x184188E10", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly HistoryService IBBJDCBMJJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private bool BAKJMDKLKHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int PNPJNGGHJOP;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x4190050", Offset = "0x418E850", VA = "0x184190050")]
			public KJFLJLLDNKH(HistoryService IBBJDCBMJJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x418FFD0", Offset = "0x418E7D0", VA = "0x18418FFD0")]
			public bool EGFDEFKEKAB(IOAGKMCGKAI NGPFKAJPHJF, OBIAPIAFCLH GCAANJILJJP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x4190000", Offset = "0x418E800", VA = "0x184190000")]
			public CHMAELMAIOF OLHKKBOOIMC()
			{
				return default(CHMAELMAIOF);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x418FF80", Offset = "0x418E780", VA = "0x18418FF80")]
			public GLONCAIKBNG BKDEJCOJMKK()
			{
				return default(GLONCAIKBNG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class KLNHLIBPPHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public KLNHLIBPPHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x4190230", Offset = "0x418EA30", VA = "0x184190230")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class MNEBPCNFPFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MNEBPCNFPFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x4190E70", Offset = "0x418F670", VA = "0x184190E70")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class OMNDBPGEECD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public OMNDBPGEECD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x4192380", Offset = "0x4190B80", VA = "0x184192380")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly UndoAction BFCFPLNFDPB;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly RedoAction ICOGOEKJBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private JKEBJGCOFKD DPNKOMOLGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ActionBuffer GBLDOCHNNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ActionBuffer JNFNBAPHLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private CLKJBNJKMPE CDGJEMNCAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TransformOwnershipPhase FBCMJKDDCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private PropertyChangeRouterService FFOJFOHBPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private PAPJACKNAPB GMHNJDKPFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private LHHOIIDPOJH OAIFILFNBOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private KJFLJLLDNKH EPGENEEAIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private KDCGOEEADEP HEHMPJJLBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private JHIICGGLBCC JKJEICNLCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private OBIAPIAFCLH KIFKCCLLOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly GatherPropertiesForUndelete IBHNGACLHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private uint EJBMHJNLHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private uint HJLHKBJCDAK;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private KJFLJLLDNKH KDOABCPKFOL
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x6EB770", Offset = "0x6E9F70", VA = "0x1806EB770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool BDGMKJDNHKN
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x31CD800", Offset = "0x31CC000", VA = "0x1831CD800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool JPPGOGMEIKA
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x31CE730", Offset = "0x31CCF30", VA = "0x1831CE730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool ONLNPJCDHEB
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x31CF870", Offset = "0x31CE070", VA = "0x1831CF870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int JNBIKIGKJFM
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x31CEB50", Offset = "0x31CD350", VA = "0x1831CEB50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int OJIKBNLLCNM
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x31CF270", Offset = "0x31CDA70", VA = "0x1831CF270")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool LJLJOKGHCCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x31CE5C0", Offset = "0x31CCDC0", VA = "0x1831CE5C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool MKCNKCHAGGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x31CD8C0", Offset = "0x31CC0C0", VA = "0x1831CD8C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool EOGIGEPAPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x914D30", Offset = "0x913530", VA = "0x180914D30", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x15EC8F0", Offset = "0x15EB0F0", VA = "0x1815EC8F0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer AEELGCKOIFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x31CD7F0", Offset = "0x31CBFF0", VA = "0x1831CD7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action KIENHKHOEGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x31CD490", Offset = "0x31CBC90", VA = "0x1831CD490", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x31CEF10", Offset = "0x31CD710", VA = "0x1831CEF10", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action OPONGCEGJNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x31CE950", Offset = "0x31CD150", VA = "0x1831CE950")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x31CEE30", Offset = "0x31CD630", VA = "0x1831CEE30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x31CD8F0", Offset = "0x31CC0F0", VA = "0x1831CD8F0", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x31CE320", Offset = "0x31CCB20", VA = "0x1831CE320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x31CDE20", Offset = "0x31CC620", VA = "0x1831CDE20")]
		private void DCDPOAALDAJ(IOAGKMCGKAI NGPFKAJPHJF, IFDMHNGCHMF OPJENMMEKFB, bool FHAJJFOBDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x31CF680", Offset = "0x31CDE80", VA = "0x1831CF680")]
		private void OAEMAFHOEMF(IOAGKMCGKAI NGPFKAJPHJF, OBIAPIAFCLH GCAANJILJJP, OJMHOIEICMJ NHKMNNFCEMI, OJMHOIEICMJ PMHHEDOHMIJ, bool FHAJJFOBDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x31CEFB0", Offset = "0x31CD7B0", VA = "0x1831CEFB0")]
		private void KKJJLGAPJFF(IOAGKMCGKAI NGPFKAJPHJF, bool FHAJJFOBDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x31CF2E0", Offset = "0x31CDAE0", VA = "0x1831CF2E0", Slot = "14")]
		public IDisposable NBFPLNKPHMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x31CF810", Offset = "0x31CE010", VA = "0x1831CF810", Slot = "9")]
		public IDisposable ONMHOFINPNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x31CE260", Offset = "0x31CCA60", VA = "0x1831CE260", Slot = "6")]
		public UndoAction DJPBAIPFGNP()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x31CD650", Offset = "0x31CBE50", VA = "0x1831CD650", Slot = "15")]
		public RedoAction AANIMLPCBGK()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x31CED10", Offset = "0x31CD510", VA = "0x1831CED10", Slot = "16")]
		public UndoAction JAAEGNDHOFD()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x31CD530", Offset = "0x31CBD30", VA = "0x1831CD530", Slot = "7")]
		public RedoAction AANIMLPCBGK(UndoAction DJDDCFICJJN)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x31CEBF0", Offset = "0x31CD3F0", VA = "0x1831CEBF0", Slot = "8")]
		public UndoAction JAAEGNDHOFD(RedoAction DJDDCFICJJN)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x31CE6F0", Offset = "0x31CCEF0", VA = "0x1831CE6F0")]
		public bool GBLDKLHMEFE(MJOPOMKBDBI NNLCIDHOOEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x31CF290", Offset = "0x31CDA90", VA = "0x1831CF290", Slot = "17")]
		public void MMLFENDEPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x31CF4D0", Offset = "0x31CDCD0", VA = "0x1831CF4D0")]
		public void NJAIGPBILBM(IOAGKMCGKAI NGPFKAJPHJF, IFDMHNGCHMF OPJENMMEKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x31CF6A0", Offset = "0x31CDEA0", VA = "0x1831CF6A0")]
		public void ODKEDKPOOFI(IOAGKMCGKAI NGPFKAJPHJF, OBIAPIAFCLH GCAANJILJJP, in OJMHOIEICMJ PMHHEDOHMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x31CE7D0", Offset = "0x31CCFD0", VA = "0x1831CE7D0")]
		public void GNBABMNHKMN(IOAGKMCGKAI NGPFKAJPHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x31CEED0", Offset = "0x31CD6D0", VA = "0x1831CEED0")]
		private void JMKFKJJDBII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x31CF8A0", Offset = "0x31CE0A0", VA = "0x1831CF8A0")]
		private void PJHNBBKFEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x31CD8D0", Offset = "0x31CC0D0", VA = "0x1831CD8D0")]
		private void CKFLOCAOJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x31CE5F0", Offset = "0x31CCDF0", VA = "0x1831CE5F0")]
		private IFEHBNIEFGG FELFIKEFGHF()
		{
			return default(IFEHBNIEFGG);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x31CE5D0", Offset = "0x31CCDD0", VA = "0x1831CE5D0")]
		private uint FCKBPFOBLNF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x31CF4B0", Offset = "0x31CDCB0", VA = "0x1831CF4B0")]
		private bool NIAANGNNBAG(out IFEHBNIEFGG BEHJPKINPFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x31CF660", Offset = "0x31CDE60", VA = "0x1831CF660")]
		private bool NNFAEKILAGL(out IFEHBNIEFGG BEHJPKINPFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x31CEDD0", Offset = "0x31CD5D0", VA = "0x1831CEDD0")]
		private RedoAction JIGPAEMBJJA(IFEHBNIEFGG BEHJPKINPFB)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x31CD860", Offset = "0x31CC060", VA = "0x1831CD860")]
		private UndoAction CGAICJAKAJI(IFEHBNIEFGG BEHJPKINPFB)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x31CDFA0", Offset = "0x31CC7A0", VA = "0x1831CDFA0")]
		private IFEHBNIEFGG DDLBDFNLMLC(IFEHBNIEFGG BEHJPKINPFB, ActionBuffer JJBOILKHNIJ, bool LEDNJFDAKOB)
		{
			return default(IFEHBNIEFGG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x31CD710", Offset = "0x31CBF10", VA = "0x1831CD710")]
		private void ABKJDKBEMFN(Action BEHJPKINPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2569B10", Offset = "0x2568310", VA = "0x182569B10")]
		private T ABKJDKBEMFN<T>(Func<T> AINPMMBNHEE)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x31CF7E0", Offset = "0x31CDFE0", VA = "0x1831CF7E0")]
		private EKEPKLPNKNB ONGDEJDLIII(bool LEDNJFDAKOB, uint OGPINCOPHCL)
		{
			return default(EKEPKLPNKNB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x31CFB10", Offset = "0x31CE310", VA = "0x1831CFB10")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x31CF8E0", Offset = "0x31CE0E0", VA = "0x1831CF8E0")]
		[CompilerGenerated]
		private UndoAction POHIMEOEGIF()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x31CF340", Offset = "0x31CDB40", VA = "0x1831CF340")]
		[CompilerGenerated]
		private RedoAction NDBIOBPDEJL()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x31CE9F0", Offset = "0x31CD1F0", VA = "0x1831CE9F0")]
		[CompilerGenerated]
		private UndoAction ICPBBBIDBEH()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class MNGBMAPKJNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<byte> CIMBPHJAHGJ;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int CADKIJKDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BD0", Offset = "0x6D53D0", VA = "0x1806D6BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xCE0D90", Offset = "0xCDF590", VA = "0x180CE0D90")]
	public MNGBMAPKJNB(NativeArray<byte> CIMBPHJAHGJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x289D020", Offset = "0x289B820", VA = "0x18289D020")]
	public static MNGBMAPKJNB AGJOPELLCGM(NativeArray<byte> CIMBPHJAHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public T GAMJKLBHALL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public NativeArray<T> NBJOKEKIECC<T>(int EEOHOPIJABN, Allocator OODGOAPHOCI) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public NativeArray<T> PJPMGJBPJAO<T>(Allocator OODGOAPHOCI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class ENEGPPFEHOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<byte> CIMBPHJAHGJ;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int CADKIJKDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BD0", Offset = "0x6D53D0", VA = "0x1806D6BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0xCE0D90", Offset = "0xCDF590", VA = "0x180CE0D90")]
	public ENEGPPFEHOI(NativeArray<byte> CIMBPHJAHGJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x31BF7C0", Offset = "0x31BDFC0", VA = "0x1831BF7C0")]
	public static ENEGPPFEHOI AGJOPELLCGM(NativeArray<byte> CIMBPHJAHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2851660", Offset = "0x284FE60", VA = "0x182851660")]
	public T GAMJKLBHALL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	public NativeArray<T> NBJOKEKIECC<T>(int EEOHOPIJABN, Allocator OODGOAPHOCI) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class PAADNBCAAHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<byte> CIMBPHJAHGJ;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int CADKIJKDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BD0", Offset = "0x6D53D0", VA = "0x1806D6BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xCE0D90", Offset = "0xCDF590", VA = "0x180CE0D90")]
	public PAADNBCAAHG(NativeArray<byte> CIMBPHJAHGJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x28AE970", Offset = "0x28AD170", VA = "0x1828AE970")]
	public static PAADNBCAAHG AGJOPELLCGM(NativeArray<byte> CIMBPHJAHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2293330", Offset = "0x2291B30", VA = "0x182293330")]
	public void KDAILCDGDKC<T>(in T NPHADDCNBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x2293230", Offset = "0x2291A30", VA = "0x182293230")]
	public void CPKGLHJGLFH<T>(NativeArray<T> OEDLDNKMKMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	public void CJHEJGODMBC<T>(NativeArray<T> NPHADDCNBHE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class JOHHMOGNLGK
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x31D68B0", Offset = "0x31D50B0", VA = "0x1831D68B0")]
	public static Span<byte> PHFIFNLOKJM(this NativeArray<byte> CIMBPHJAHGJ)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x31D66C0", Offset = "0x31D4EC0", VA = "0x1831D66C0")]
	public static ReadOnlySpan<byte> IMDLCJJEHJO(this NativeArray<byte> CIMBPHJAHGJ)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x31D6540", Offset = "0x31D4D40", VA = "0x1831D6540")]
	public static NativeArray<byte> DEEBLNIEIEG(this NativeArray<byte> CIMBPHJAHGJ, int DAOIPFCHFFJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x31D65C0", Offset = "0x31D4DC0", VA = "0x1831D65C0")]
	public static NativeArray<byte> FJLGMGELBHG(this NativeArray<byte> CIMBPHJAHGJ, int FCKFNIPNJCI = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x14A8700", Offset = "0x14A6F00", VA = "0x1814A8700")]
	public static NativeArray<byte> FJLGMGELBHG<T>(this NativeArray<byte> CIMBPHJAHGJ, int FCKFNIPNJCI = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x31D6840", Offset = "0x31D5040", VA = "0x1831D6840")]
	public static NativeArray<byte> KAIKGKGAKFA(this NativeArray<byte> CIMBPHJAHGJ, int FCKFNIPNJCI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x14A9CA0", Offset = "0x14A84A0", VA = "0x1814A9CA0")]
	public static NativeArray<byte> KAIKGKGAKFA<T>(this NativeArray<byte> CIMBPHJAHGJ, int FCKFNIPNJCI = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x31D6640", Offset = "0x31D4E40", VA = "0x1831D6640")]
	public static NativeArray<byte> HNGOPPBMPLG(this NativeArray<byte> CIMBPHJAHGJ, int FCKFNIPNJCI = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x14A8760", Offset = "0x14A6F60", VA = "0x1814A8760")]
	public static NativeArray<byte> HNGOPPBMPLG<T>(this NativeArray<byte> CIMBPHJAHGJ, int FCKFNIPNJCI = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CIKEPFHKCDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeList<byte> HGPMCGJIADE;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xCE0D90", Offset = "0xCDF590", VA = "0x180CE0D90")]
	public CIKEPFHKCDD(NativeList<byte> HGPMCGJIADE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DC70", Offset = "0x2D0C470", VA = "0x182D0DC70")]
	public static CIKEPFHKCDD AGJOPELLCGM(NativeList<byte> CIMBPHJAHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	public void KDAILCDGDKC<T>(in T NPHADDCNBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	public void CPKGLHJGLFH<T>(NativeArray<T> NPHADDCNBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	public void CJHEJGODMBC<T>(NativeArray<T> NPHADDCNBHE) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[FIKNCOOOHID(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.PropertyChanges)]
	public class PropertyChangeNetworkRouter : BGAFKNOHCIN, HNOABDNADGF, KGPEFICHJKL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[EOIIILOBJAK]
		private KILGPHHFBGF IJMHHNEJPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[EOIIILOBJAK]
		private BMIGPDLOFHL AIDEINAMABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[EOIIILOBJAK]
		private NJJMCMLLMLI MEEGLKIELAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[EOIIILOBJAK]
		private PropertyChangeRouterService FFOJFOHBPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private JKEBJGCOFKD FNOCDBPJMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private NHAHJHJPOHB OFCAEEIKNPG;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public JKEBJGCOFKD PJEPDICLPNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x28B57C0", Offset = "0x28B3FC0", VA = "0x1828B57C0")]
		public JKEBJGCOFKD.NAGJMHGKMKK AADANFBDLIK()
		{
			return default(JKEBJGCOFKD.NAGJMHGKMKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x28B5800", Offset = "0x28B4000", VA = "0x1828B5800", Slot = "4")]
		public void CDCHANKPBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x28B5860", Offset = "0x28B4060", VA = "0x1828B5860", Slot = "5")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x28B5BF0", Offset = "0x28B43F0", VA = "0x1828B5BF0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x28B5AE0", Offset = "0x28B42E0", VA = "0x1828B5AE0")]
		public void DJPBAIPFGNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x28B64A0", Offset = "0x28B4CA0", VA = "0x1828B64A0")]
		public void MMLFENDEPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x28B6500", Offset = "0x28B4D00", VA = "0x1828B6500")]
		private void PGEEKGCDENG(IOAGKMCGKAI NGPFKAJPHJF, IFDMHNGCHMF OPJENMMEKFB, bool FHAJJFOBDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x28B5F00", Offset = "0x28B4700", VA = "0x1828B5F00")]
		private void IIPPPKNPFJL(IOAGKMCGKAI NGPFKAJPHJF, OBIAPIAFCLH GCAANJILJJP, OJMHOIEICMJ NHKMNNFCEMI, OJMHOIEICMJ PMHHEDOHMIJ, bool FHAJJFOBDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x28B5ED0", Offset = "0x28B46D0", VA = "0x1828B5ED0")]
		private void IEFMFGNIOCC(IOAGKMCGKAI NGPFKAJPHJF, bool FHAJJFOBDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x28B6070", Offset = "0x28B4870", VA = "0x1828B6070")]
		private void LJAJNMJKLPK(NHAHJHJPOHB KJFIHMLIKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x28B5F40", Offset = "0x28B4740", VA = "0x1828B5F40")]
		private void LEBJPDJJPML(NHAHJHJPOHB KJFIHMLIKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x28B5E10", Offset = "0x28B4610", VA = "0x1828B5E10")]
		private void EOEMBAKPCEP(NHAHJHJPOHB KJFIHMLIKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x28B57E0", Offset = "0x28B3FE0", VA = "0x1828B57E0")]
		private void APHNHAIKJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x28B64C0", Offset = "0x28B4CC0", VA = "0x1828B64C0")]
		private void PEDILBMCKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x28B63B0", Offset = "0x28B4BB0", VA = "0x1828B63B0")]
		private void MJNGAJMCOEE(NHAHJHJPOHB KJFIHMLIKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3A13FB0", Offset = "0x3A127B0", VA = "0x183A13FB0", Slot = "6")]
		private void FFPPLANOFJE<TKey, T>(global::ABJCAJMMMEG<TKey, T> NPCKPCNEDPB, object CDBJCAAPIOD) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[IECCMKJMAAC(LAEALBOAPLI.History)]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[FIKNCOOOHID(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate void AHHDFLOFLMF(IOAGKMCGKAI NGPFKAJPHJF, IFDMHNGCHMF OPJENMMEKFB, bool FHAJJFOBDLK);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate void GPCHONOMBHN(IOAGKMCGKAI NGPFKAJPHJF, OBIAPIAFCLH GCAANJILJJP, OJMHOIEICMJ NHKMNNFCEMI, OJMHOIEICMJ PMHHEDOHMIJ, bool FHAJJFOBDLK);

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public delegate void FHMPIADLHOP(IOAGKMCGKAI NGPFKAJPHJF, bool FHAJJFOBDLK);

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AHHDFLOFLMF OJONNLHFKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public GPCHONOMBHN CFLMHIHNHPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public FHMPIADLHOP FOAPFFHPHEB;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x28B65A0", Offset = "0x28B4DA0", VA = "0x1828B65A0")]
		public void NJAIGPBILBM(IOAGKMCGKAI NGPFKAJPHJF, IFDMHNGCHMF OPJENMMEKFB, bool FHAJJFOBDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x28B65C0", Offset = "0x28B4DC0", VA = "0x1828B65C0")]
		public void ODKEDKPOOFI(IOAGKMCGKAI NGPFKAJPHJF, OBIAPIAFCLH GCAANJILJJP, in OJMHOIEICMJ NHKMNNFCEMI, in OJMHOIEICMJ PMHHEDOHMIJ, bool FHAJJFOBDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x28B6580", Offset = "0x28B4D80", VA = "0x1828B6580")]
		public void GNBABMNHKMN(IOAGKMCGKAI NGPFKAJPHJF, bool FHAJJFOBDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DebuggerTypeProxy(typeof(BAIOGJFNHGK))]
	[IECCMKJMAAC(LAEALBOAPLI.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		internal class BAIOGJFNHGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private readonly ActionBuffer DNLJJNDPNCG;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public int EIFLHBHGPLJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x2C90800", Offset = "0x2C8F000", VA = "0x182C90800")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public LFAHOGCKOAK[] EBLJELKNBFP
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x2C90940", Offset = "0x2C8F140", VA = "0x182C90940")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
			public BAIOGJFNHGK(ActionBuffer EKJOHEFCEGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2C90850", Offset = "0x2C8F050", VA = "0x182C90850")]
			[CompilerGenerated]
			private LFAHOGCKOAK KAAOJJHEJLH(IFEHBNIEFGG BEHJPKINPFB)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		internal class LFAHOGCKOAK : KGPEFICHJKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private readonly ActionBuffer DNLJJNDPNCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly IFEHBNIEFGG BEHJPKINPFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private List<(NHAHJHJPOHB, string, object)> EDCAIOHEHMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private ENEGPPFEHOI AODHOCAKPON;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public int EIFLHBHGPLJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0x2C929D0", Offset = "0x2C911D0", VA = "0x182C929D0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(NHAHJHJPOHB, string, object)> HNAAHKNLCJA
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2C92B20", Offset = "0x2C91320", VA = "0x182C92B20")]
			public LFAHOGCKOAK(ActionBuffer EKJOHEFCEGM, IFEHBNIEFGG BEHJPKINPFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2C92A20", Offset = "0x2C91220", VA = "0x182C92A20")]
			private string FMBPKKFFHDG(NHAHJHJPOHB OFCAEEIKNPG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2C92690", Offset = "0x2C90E90", VA = "0x182C92690")]
			private void AOGHGHFDMOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x2CBEF80", Offset = "0x2CBD780", VA = "0x182CBEF80", Slot = "4")]
			public void FDNHKMLHECH<TKey, T>(global::ABJCAJMMMEG<TKey, T> NPCKPCNEDPB, [Optional] object CDBJCAAPIOD) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NativeList<byte> HIGIGMBKOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Stack<IFEHBNIEFGG> EFBFMCLCMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly GMNGMLHNCEA LDDMMJKOAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly KDCGOEEADEP HEHMPJJLBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly BMIGPDLOFHL AIDEINAMABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly bool LFJAGACCIIG;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public FCHGICBJEPN ILEBONKALNP
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x2D08890", Offset = "0x2D07090", VA = "0x182D08890")]
			get
			{
				return default(FCHGICBJEPN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int EIFLHBHGPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x2D088D0", Offset = "0x2D070D0", VA = "0x182D088D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D09590", Offset = "0x2D07D90", VA = "0x182D09590")]
		public ActionBuffer(KDCGOEEADEP HEHMPJJLBPP, BMIGPDLOFHL AIDEINAMABM, bool LFJAGACCIIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D094B0", Offset = "0x2D07CB0", VA = "0x182D094B0")]
		public bool OAEOACLDMGK(out IFEHBNIEFGG BEHJPKINPFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D09440", Offset = "0x2D07C40", VA = "0x182D09440")]
		public void MMLFENDEPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D08CA0", Offset = "0x2D074A0", VA = "0x182D08CA0")]
		public IFEHBNIEFGG DJPBAIPFGNP(DKMMEBBCBKE EDCAIOHEHMF, PAPJACKNAPB GMHNJDKPFJH, uint DCHCHLKEIGO)
		{
			return default(IFEHBNIEFGG);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D09410", Offset = "0x2D07C10", VA = "0x182D09410")]
		public bool IOADPDHJBFM(uint DCHCHLKEIGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D08FC0", Offset = "0x2D077C0", VA = "0x182D08FC0")]
		public bool GMAIJAGKNAM(uint DCHCHLKEIGO, out IFEHBNIEFGG DJDDCFICJJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D08E50", Offset = "0x2D07650", VA = "0x182D08E50")]
		public void ELHDNLIPKOD(IFEHBNIEFGG DJDDCFICJJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D092D0", Offset = "0x2D07AD0", VA = "0x182D092D0")]
		[Conditional("DEBUG_BUILD")]
		private void HOMIEEBMJPK(IFEHBNIEFGG DJDDCFICJJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D08B90", Offset = "0x2D07390", VA = "0x182D08B90")]
		private void DDLBDFNLMLC(IFEHBNIEFGG ALNAHBCDKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D08910", Offset = "0x2D07110", VA = "0x182D08910")]
		private void DBBGCPAGKJO(ENEGPPFEHOI MADBOLHKBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D091B0", Offset = "0x2D079B0", VA = "0x182D091B0")]
		private void HHIKELJLMCP(IFEHBNIEFGG BEHJPKINPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D09210", Offset = "0x2D07A10", VA = "0x182D09210")]
		private ENEGPPFEHOI HLEBFBKKGEP(IFEHBNIEFGG BEHJPKINPFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D08DE0", Offset = "0x2D075E0", VA = "0x182D08DE0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class GMNGMLHNCEA : KGPEFICHJKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly KDCGOEEADEP HEHMPJJLBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly BMIGPDLOFHL AIDEINAMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private IOAGKMCGKAI NGPFKAJPHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private ENEGPPFEHOI DGFDONAHHCN;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D56E0", Offset = "0x6D3EE0", VA = "0x1806D56E0")]
	public GMNGMLHNCEA(KDCGOEEADEP HEHMPJJLBPP, BMIGPDLOFHL AIDEINAMABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x269E850", Offset = "0x269D050", VA = "0x18269E850", Slot = "4")]
	public void FDNHKMLHECH<TKey, T>(global::ABJCAJMMMEG<TKey, T> MPNNMKMGEEE, [Optional] object CDBJCAAPIOD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x31CA610", Offset = "0x31C8E10", VA = "0x1831CA610")]
	public void NELPADDHGOD(NHAHJHJPOHB OFCAEEIKNPG, ref ENEGPPFEHOI MADBOLHKBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class JKEBJGCOFKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct NAGJMHGKMKK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly JKEBJGCOFKD FAAJOMIIHED;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x4190EF0", Offset = "0x418F6F0", VA = "0x184190EF0")]
		public NAGJMHGKMKK(JKEBJGCOFKD FAAJOMIIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x4190ED0", Offset = "0x418F6D0", VA = "0x184190ED0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	protected DKMMEBBCBKE EDCAIOHEHMF;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public DKMMEBBCBKE HNAAHKNLCJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x3142AD0", Offset = "0x31412D0", VA = "0x183142AD0")]
		get
		{
			return default(DKMMEBBCBKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool EPBOIEALGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x31D5E80", Offset = "0x31D4680", VA = "0x1831D5E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x31D6120", Offset = "0x31D4920", VA = "0x1831D6120")]
	public JKEBJGCOFKD(DKMMEBBCBKE.NANMCBCHAMG DIBPCNNCOOF = DKMMEBBCBKE.NANMCBCHAMG.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x31D5E90", Offset = "0x31D4690", VA = "0x1831D5E90")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x31D5EA0", Offset = "0x31D46A0", VA = "0x1831D5EA0")]
	public void NJAIGPBILBM(IOAGKMCGKAI NGPFKAJPHJF, IFDMHNGCHMF OPJENMMEKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x31D5F90", Offset = "0x31D4790", VA = "0x1831D5F90")]
	public void ODKEDKPOOFI(IOAGKMCGKAI NGPFKAJPHJF, OBIAPIAFCLH GCAANJILJJP, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x31D5DA0", Offset = "0x31D45A0", VA = "0x1831D5DA0")]
	public void GNBABMNHKMN(IOAGKMCGKAI NGPFKAJPHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x31D5C90", Offset = "0x31D4490", VA = "0x1831D5C90")]
	public void APHNHAIKJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x31D6020", Offset = "0x31D4820", VA = "0x1831D6020")]
	public void PEDILBMCKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x31D5D90", Offset = "0x31D4590", VA = "0x1831D5D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x31D5C60", Offset = "0x31D4460", VA = "0x1831D5C60")]
	public NAGJMHGKMKK AADANFBDLIK()
	{
		return default(NAGJMHGKMKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct NHAHJHJPOHB : IComparable<NHAHJHJPOHB>, IEquatable<NHAHJHJPOHB>
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly NHAHJHJPOHB ADEPDEBKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public IOAGKMCGKAI NGPFKAJPHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public OBIAPIAFCLH GCAANJILJJP;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool HOFMIBPEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x289EBD0", Offset = "0x289D3D0", VA = "0x18289EBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F6050", Offset = "0x6F4850", VA = "0x1806F6050")]
	public NHAHJHJPOHB(IOAGKMCGKAI NGPFKAJPHJF, OBIAPIAFCLH GCAANJILJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x289EDA0", Offset = "0x289D5A0", VA = "0x18289EDA0")]
	public void PMDDIJCHOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x289EB90", Offset = "0x289D390", VA = "0x18289EB90", Slot = "4")]
	public int CompareTo(NHAHJHJPOHB HAKPJJGEGOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x289EDB0", Offset = "0x289D5B0", VA = "0x18289EDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x289EC30", Offset = "0x289D430", VA = "0x18289EC30", Slot = "0")]
	public override bool Equals(object BFHAMCLNCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x289EBE0", Offset = "0x289D3E0", VA = "0x18289EBE0", Slot = "5")]
	public bool Equals(NHAHJHJPOHB HAKPJJGEGOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x289ECD0", Offset = "0x289D4D0", VA = "0x18289ECD0")]
	public static bool GLPMECKCBFF(NHAHJHJPOHB EHDPPFDCEJK, NHAHJHJPOHB NPIMFLIIAHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x289ED50", Offset = "0x289D550", VA = "0x18289ED50")]
	public static bool PKJGEKBKGNO(NHAHJHJPOHB EHDPPFDCEJK, NHAHJHJPOHB NPIMFLIIAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x289ED10", Offset = "0x289D510", VA = "0x18289ED10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[IECCMKJMAAC(LAEALBOAPLI.History)]
	public class GatherPropertiesForUndelete : EGMBBKCIEEA
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private KDCGOEEADEP HEHMPJJLBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private IOAGKMCGKAI NGPFKAJPHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HistoryService IBBJDCBMJJD;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x31CA7B0", Offset = "0x31C8FB0", VA = "0x1831CA7B0")]
		public void PGLBLJGLHCJ(IOAGKMCGKAI NGPFKAJPHJF, KDCGOEEADEP HEHMPJJLBPP, HistoryService IBBJDCBMJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x31CA6E0", Offset = "0x31C8EE0", VA = "0x1831CA6E0", Slot = "4")]
		private void BIHDCJHJKKK(BEFHLLMPLPH NPCKPCNEDPB, in OJMHOIEICMJ NPHADDCNBHE, object CDBJCAAPIOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class DJIJGJMCGPA
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C5E0", Offset = "0x2D1ADE0", VA = "0x182D1C5E0")]
	public static void LEBJPDJJPML(DKMMEBBCBKE EDCAIOHEHMF, NHAHJHJPOHB OFCAEEIKNPG, IFDMHNGCHMF OPJENMMEKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C450", Offset = "0x2D1AC50", VA = "0x182D1C450")]
	public static void ENOOGAPHKLP(DKMMEBBCBKE EDCAIOHEHMF, NHAHJHJPOHB OFCAEEIKNPG, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C590", Offset = "0x2D1AD90", VA = "0x182D1C590")]
	public static void EOEMBAKPCEP(DKMMEBBCBKE EDCAIOHEHMF, NHAHJHJPOHB OFCAEEIKNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C780", Offset = "0x2D1AF80", VA = "0x182D1C780")]
	public static void PHDLFHKCCJL(DKMMEBBCBKE EDCAIOHEHMF, NHAHJHJPOHB OFCAEEIKNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C3B0", Offset = "0x2D1ABB0", VA = "0x182D1C3B0")]
	public static IFDMHNGCHMF BHJHOCENFHL(DKMMEBBCBKE EDCAIOHEHMF, NHAHJHJPOHB OFCAEEIKNPG)
	{
		return default(IFDMHNGCHMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2301150", Offset = "0x22FF950", VA = "0x182301150")]
	public static T KDFCLPPFNIL<T>(DKMMEBBCBKE EDCAIOHEHMF, NHAHJHJPOHB OFCAEEIKNPG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2301170", Offset = "0x22FF970", VA = "0x182301170")]
	public static T KDFCLPPFNIL<T>(ref ENEGPPFEHOI LBEMEOBAAJI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C400", Offset = "0x2D1AC00", VA = "0x182D1C400")]
	public static IFDMHNGCHMF BHJHOCENFHL(ref ENEGPPFEHOI LBEMEOBAAJI)
	{
		return default(IFDMHNGCHMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct DKMMEBBCBKE : IEnumerable<NHAHJHJPOHB>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum NANMCBCHAMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct OPEBNFAKHAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly DKMMEBBCBKE HGPMCGJIADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly PAPJACKNAPB GMHNJDKPFJH;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2C942D0", Offset = "0x2C92AD0", VA = "0x182C942D0")]
		public OPEBNFAKHAM(DKMMEBBCBKE HGPMCGJIADE, PAPJACKNAPB GMHNJDKPFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2C93F40", Offset = "0x2C92740", VA = "0x182C93F40")]
		public void KFHCIDINOHI(NativeList<byte> LPIADEMPDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2C93B20", Offset = "0x2C92320", VA = "0x182C93B20")]
		private void FCMPONDMCGH(NHAHJHJPOHB OFCAEEIKNPG, ref PAADNBCAAHG PBNJPEENMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x2C93C60", Offset = "0x2C92460", VA = "0x182C93C60")]
		private void HAENBIDOCEF(NHAHJHJPOHB OFCAEEIKNPG, ref PAADNBCAAHG PBNJPEENMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x2C93B70", Offset = "0x2C92370", VA = "0x182C93B70")]
		private NativeArray<byte> FJFFOAACNDH(NativeList<byte> LPIADEMPDKB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x2C941E0", Offset = "0x2C929E0", VA = "0x182C941E0")]
		private NativeArray<byte> KHIDNGCLDBL(NativeList<byte> LPIADEMPDKB, int EEOHOPIJABN)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x2C93CF0", Offset = "0x2C924F0", VA = "0x182C93CF0")]
		private int JNNGMBKIJMB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x2C939C0", Offset = "0x2C921C0", VA = "0x182C939C0")]
		private bool BHIPKNJDGPO(NHAHJHJPOHB OFCAEEIKNPG, out NativeArray<byte> MADEGGHMPIJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct DDACCGAMGKA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeList<byte> LBEMEOBAAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private DKMMEBBCBKE HGPMCGJIADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly NHAHJHJPOHB KJFIHMLIKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly int DAOIPFCHFFJ;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x2C90C90", Offset = "0x2C8F490", VA = "0x182C90C90")]
		internal DDACCGAMGKA(DKMMEBBCBKE HGPMCGJIADE, NHAHJHJPOHB KJFIHMLIKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x2C90BF0", Offset = "0x2C8F3F0", VA = "0x182C90BF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x2C90A10", Offset = "0x2C8F210", VA = "0x182C90A10")]
		public void PENCANFJOAB(NativeArray<byte> NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2C90C30", Offset = "0x2C8F430", VA = "0x182C90C30")]
		public void LOPMLMMNPDL(NativeArray<byte> NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x2C90C20", Offset = "0x2C8F420", VA = "0x182C90C20")]
		public void HAENBIDOCEF(in OJMHOIEICMJ NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3A70", Offset = "0x2CB2270", VA = "0x182CB3A70")]
		public void HAENBIDOCEF<T>(T NPHADDCNBHE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x2C90B80", Offset = "0x2C8F380", VA = "0x182C90B80")]
		private void AGDHLJDHPPH(int NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x2C90AD0", Offset = "0x2C8F2D0", VA = "0x182C90AD0")]
		private void AGDHLJDHPPH(in OJMHOIEICMJ NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x2C90A70", Offset = "0x2C8F270", VA = "0x182C90A70")]
		private unsafe void AGDHLJDHPPH(void* PMJPDCKBMMK, int EEOHOPIJABN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2C90A10", Offset = "0x2C8F210", VA = "0x182C90A10")]
		private void AGDHLJDHPPH(NativeArray<byte> OEDLDNKMKMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct HHEGFMMPHGA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private DKMMEBBCBKE HGPMCGJIADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<byte> LBEMEOBAAJI;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2C91B20", Offset = "0x2C90320", VA = "0x182C91B20")]
		internal HHEGFMMPHGA(DKMMEBBCBKE HGPMCGJIADE, NativeArray<byte> LBEMEOBAAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2C91860", Offset = "0x2C90060", VA = "0x182C91860", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x2C91970", Offset = "0x2C90170", VA = "0x182C91970")]
		public NativeArray<byte> NBJOKEKIECC(int EEOHOPIJABN)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2C91A30", Offset = "0x2C90230", VA = "0x182C91A30")]
		public NativeArray<byte> PJPMGJBPJAO()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3C00", Offset = "0x2CB2400", VA = "0x182CB3C00")]
		public T GAMJKLBHALL<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2C91870", Offset = "0x2C90070", VA = "0x182C91870")]
		public void GAMJKLBHALL(in KMFGGFFJPFH NPHADDCNBHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct NBLOFLIOFAO : IEnumerator<NHAHJHJPOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly NativeList<NHAHJHJPOHB> CIMBPHJAHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int LHHBOCAHDEE;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public NHAHJHJPOHB ILEBONKALNP
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x2C92FE0", Offset = "0x2C917E0", VA = "0x182C92FE0", Slot = "4")]
			get
			{
				return default(NHAHJHJPOHB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x2C92F90", Offset = "0x2C91790", VA = "0x182C92F90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2C92FD0", Offset = "0x2C917D0", VA = "0x182C92FD0")]
		internal NBLOFLIOFAO(NativeList<NHAHJHJPOHB> OEDLDNKMKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2C92E50", Offset = "0x2C91650", VA = "0x182C92E50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2C92F50", Offset = "0x2C91750", VA = "0x182C92F50", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct OOCEPNGPCPO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int OPCKNGGACCL = 0;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int DDDFCINFBOH = 1;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int HFKHJJMGPFO = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NativeArray<int> LBEMEOBAAJI;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool IMLDPEBIIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x2C938E0", Offset = "0x2C920E0", VA = "0x182C938E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int JDCOFCNIEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x2C93890", Offset = "0x2C92090", VA = "0x182C93890")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x2C93800", Offset = "0x2C92000", VA = "0x182C93800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public NANMCBCHAMG FPCKPKMCJJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x2C937F0", Offset = "0x2C91FF0", VA = "0x182C937F0")]
			get
			{
				return default(NANMCBCHAMG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x2C93850", Offset = "0x2C92050", VA = "0x182C93850")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool EPBOIEALGCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x2C938D0", Offset = "0x2C920D0", VA = "0x182C938D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x2C93920", Offset = "0x2C92120", VA = "0x182C93920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool JEFMELMIDEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x2C938C0", Offset = "0x2C920C0", VA = "0x182C938C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x2C938A0", Offset = "0x2C920A0", VA = "0x182C938A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2C93940", Offset = "0x2C92140", VA = "0x182C93940")]
		public OOCEPNGPCPO(NANMCBCHAMG DIBPCNNCOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2C93860", Offset = "0x2C92060", VA = "0x182C93860")]
		private int HEJAGBNBHFE(int OBHIANFIDPA, int ICFJNEBAAAB = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2C937B0", Offset = "0x2C91FB0", VA = "0x182C937B0")]
		private void BJPKOCBPDKP(int OBHIANFIDPA, int NPHADDCNBHE, int ICFJNEBAAAB = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2C93810", Offset = "0x2C92010", VA = "0x182C93810", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private const int FMHKJHAGJCC = -1;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private const int GOHGNEIADKB = 0;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly NHAHJHJPOHB EALHDLCLGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeHashMap<NHAHJHJPOHB, int> LPMHAFAMOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NativeList<NHAHJHJPOHB> EDCAIOHEHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NativeList<int> HBMPECHPHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NativeList<byte> KJAALNOECGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private NativeList<byte> LBEMEOBAAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private OOCEPNGPCPO NDEGHHCMGIN;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool EPBOIEALGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CFD0", Offset = "0x2D1B7D0", VA = "0x182D1CFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MNMMIHOJOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CFE0", Offset = "0x2D1B7E0", VA = "0x182D1CFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int JDCOFCNIEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D1CED0", Offset = "0x2D1B6D0", VA = "0x182D1CED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int KLBFIHNBDON
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D1D120", Offset = "0x2D1B920", VA = "0x182D1D120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool IMLDPEBIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D1D240", Offset = "0x2D1BA40", VA = "0x182D1D240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D370", Offset = "0x2D1BB70", VA = "0x182D1D370")]
	public static DKMMEBBCBKE OJONNLHFKNA(NANMCBCHAMG DIBPCNNCOOF = NANMCBCHAMG.Last, int LKBLODPNLHF = 16, int BPIBJDDLPLL = 256)
	{
		return default(DKMMEBBCBKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D5A0", Offset = "0x2D1BDA0", VA = "0x182D1D5A0")]
	private DKMMEBBCBKE(NANMCBCHAMG DIBPCNNCOOF, int LKBLODPNLHF, int BPIBJDDLPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C9D0", Offset = "0x2D1B1D0", VA = "0x182D1C9D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D000", Offset = "0x2D1B800", VA = "0x182D1D000")]
	public DDACCGAMGKA LJAJNMJKLPK(NHAHJHJPOHB KJFIHMLIKBG)
	{
		return default(DDACCGAMGKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D090", Offset = "0x2D1B890", VA = "0x182D1D090")]
	public HHEGFMMPHGA LMLOMELKDHP(NHAHJHJPOHB KJFIHMLIKBG)
	{
		return default(HHEGFMMPHGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CAF0", Offset = "0x2D1B2F0", VA = "0x182D1CAF0")]
	public bool GOEDFDNCEGA(NHAHJHJPOHB KJFIHMLIKBG, out HHEGFMMPHGA DJBKFAIICIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C980", Offset = "0x2D1B180", VA = "0x182D1C980")]
	public bool BBCGGCLKLOD(NHAHJHJPOHB KJFIHMLIKBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C8B0", Offset = "0x2D1B0B0", VA = "0x182D1C8B0")]
	public bool ACAINPKNOAB(NHAHJHJPOHB KJFIHMLIKBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D280", Offset = "0x2D1BA80", VA = "0x182D1D280")]
	public void NKBIDKPBOFP(NativeList<byte> LPIADEMPDKB, PAPJACKNAPB GMHNJDKPFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x2301890", Offset = "0x2300090", VA = "0x182301890")]
	public T JCAOJAAFFGN<T>(NHAHJHJPOHB KJFIHMLIKBG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D160", Offset = "0x2D1B960", VA = "0x182D1D160")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CAB0", Offset = "0x2D1B2B0", VA = "0x182D1CAB0")]
	public NBLOFLIOFAO GCCEKDHECEG()
	{
		return default(NBLOFLIOFAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CCE0", Offset = "0x2D1B4E0", VA = "0x182D1CCE0")]
	private void HGDMDFOGBKK(NHAHJHJPOHB KJFIHMLIKBG, int DAOIPFCHFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D3B0", Offset = "0x2D1BBB0", VA = "0x182D1D3B0")]
	private void PMDDIJCHOCN(int FJBDCFOGIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2D1CEE0", Offset = "0x2D1B6E0", VA = "0x182D1CEE0")]
	private void JBDJIAFNLNG(NHAHJHJPOHB KJFIHMLIKBG, int DAOIPFCHFFJ, int EEOHOPIJABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2301810", Offset = "0x2300010", VA = "0x182301810")]
	private static T JCAOJAAFFGN<T>(NativeArray<byte> CIMBPHJAHGJ, int OBHIANFIDPA = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D4E0", Offset = "0x2D1BCE0", VA = "0x182D1D4E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D4A0", Offset = "0x2D1BCA0", VA = "0x182D1D4A0", Slot = "4")]
	private IEnumerator<NHAHJHJPOHB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class ALKDFMEJPHH<T> : FGEMHNBDPAP where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private EntityQuery PPFDACOOOGO;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C7F0", Offset = "0x2E9AFF0", VA = "0x182E9C7F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C880", Offset = "0x2E9B080", VA = "0x182E9C880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C8F0", Offset = "0x2E9B0F0", VA = "0x182E9C8F0")]
	public ALKDFMEJPHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x149BDE0", Offset = "0x149A5E0", VA = "0x18149BDE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	internal class CleanupRigidbodyExImpl : FGEMHNBDPAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private EntityQuery PPFDACOOOGO;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2D10DC0", Offset = "0x2D0F5C0", VA = "0x182D10DC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2D10E60", Offset = "0x2D0F660", VA = "0x182D10E60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[Preserve]
internal class KAEJLCGNBAE : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private EntityQuery IIHCDPEMDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x31D6B50", Offset = "0x31D5350", VA = "0x1831D6B50", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x31D6BA0", Offset = "0x31D53A0", VA = "0x1831D6BA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x31D6C30", Offset = "0x31D5430", VA = "0x1831D6C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public KAEJLCGNBAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
internal class EEDLEDKDOJG : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private PropertyDiffStateService FNCPOGIIBEA;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2D21F00", Offset = "0x2D20700", VA = "0x182D21F00", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2D21F50", Offset = "0x2D20750", VA = "0x182D21F50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public EEDLEDKDOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EntityQuery PPFDACOOOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private SceneService KCPLDCIJMHJ;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F010", Offset = "0x2D1D810", VA = "0x182D1F010", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F060", Offset = "0x2D1D860", VA = "0x182D1F060", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2D1F0F0", Offset = "0x2D1D8F0", VA = "0x182D1F0F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
	[FIKNCOOOHID(typeof(CullingBandService), new string[] { })]
	public class CullingBandService : HNOABDNADGF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<NativeListAsync<AJFHOEGNMCO>> HCAAMEFIBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[EOIIILOBJAK]
		private PNONIBNMECP MOMLDEEAAPM;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2D19DE0", Offset = "0x2D185E0", VA = "0x182D19DE0", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A410", Offset = "0x2D18C10", VA = "0x182D1A410")]
		public void PNHDKNJPDFD(NativeListAsync<AJFHOEGNMCO> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2D19FA0", Offset = "0x2D187A0", VA = "0x182D19FA0")]
		public void KHDDONFMLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2D19E30", Offset = "0x2D18630", VA = "0x182D19E30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A4D0", Offset = "0x2D18CD0", VA = "0x182D1A4D0")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[FIKNCOOOHID(typeof(DJIDKBGCOOE), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	public class PhysicsService : HNOABDNADGF, INBMAMBAHGE, DJIDKBGCOOE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly DELGGOALDMF JGPDJCBKANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EntityManager AIFDIGHJEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private PNONIBNMECP IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private OJCMJJNIHBI HCFJDIJLCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PropertyEventCallbacksService HKNJNCDEHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private global::LEKHCEGJOPN<FKOECJAIHBK> IMNGMCDKGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<FJJPMAIFPPM, FKOECJAIHBK> FPNLIEFNJDN
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x28B3070", Offset = "0x28B1870", VA = "0x1828B3070", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x28B2F10", Offset = "0x28B1710", VA = "0x1828B2F10", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x28B2C90", Offset = "0x28B1490", VA = "0x1828B2C90", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x28B29F0", Offset = "0x28B11F0", VA = "0x1828B29F0", Slot = "5")]
		public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x28B2DB0", Offset = "0x28B15B0", VA = "0x1828B2DB0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x28B31D0", Offset = "0x28B19D0", VA = "0x1828B31D0", Slot = "8")]
		public bool POMDJOFODCL(FJJPMAIFPPM AIOPADAFDKL, out Collider JBCONAAJILG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x28B2FB0", Offset = "0x28B17B0", VA = "0x1828B2FB0")]
		private void KPPFNJHDBNC(Entity DJGIAPPGDDP, OBIAPIAFCLH GCAANJILJJP, OJMHOIEICMJ AHKNGMEFAGI, OJMHOIEICMJ EJDNMJGBJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x28B3110", Offset = "0x28B1910", VA = "0x1828B3110", Slot = "9")]
		public void OKGJIBJNNMP(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	[FIKNCOOOHID(typeof(AMABLJCHDBC), new string[] { })]
	public class RbexService : HNOABDNADGF, AMABLJCHDBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private PNONIBNMECP MOMLDEEAAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private World IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private FGJJBDJMIFL EJICHAAILFK;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private EntityManager NKKGJCLICDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x28B9120", Offset = "0x28B7920", VA = "0x1828B9120")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x28B8A00", Offset = "0x28B7200", VA = "0x1828B8A00", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x28BB0C0", Offset = "0x28B98C0", VA = "0x1828BB0C0", Slot = "6")]
		public CBLFGEBLHGN NPOILOCFPLL(FJJPMAIFPPM AIOPADAFDKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x28B9480", Offset = "0x28B7C80", VA = "0x1828B9480", Slot = "5")]
		public void GDAMGOGLCPO(FJJPMAIFPPM AIOPADAFDKL, CBLFGEBLHGN NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x28BAAA0", Offset = "0x28B92A0", VA = "0x1828BAAA0", Slot = "34")]
		public CollisionDetectionMode NKDKJJGDMHI(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x28BB700", Offset = "0x28B9F00", VA = "0x1828BB700", Slot = "35")]
		public void PJLEDEAJEEF(FJJPMAIFPPM AIOPADAFDKL, CollisionDetectionMode NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x28BA0A0", Offset = "0x28B88A0", VA = "0x1828BA0A0", Slot = "36")]
		public DKBDPMEKDDF JNBJMAEJIOL(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(DKBDPMEKDDF);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x28B9610", Offset = "0x28B7E10", VA = "0x1828B9610", Slot = "37")]
		public void HIHHNBDMBIP(FJJPMAIFPPM AIOPADAFDKL, DKBDPMEKDDF NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x28BB1B0", Offset = "0x28B99B0", VA = "0x1828BB1B0", Slot = "38")]
		public bool OFPAFHODGGC(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x28B8E50", Offset = "0x28B7650", VA = "0x1828B8E50", Slot = "39")]
		public void EBOFHKHKIMN(FJJPMAIFPPM AIOPADAFDKL, bool NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x28BA020", Offset = "0x28B8820", VA = "0x1828BA020", Slot = "40")]
		public FJJPMAIFPPM JKKPEICCMFG(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x28B8AB0", Offset = "0x28B72B0", VA = "0x1828B8AB0", Slot = "41")]
		public void CNJPPPAEDBG(FJJPMAIFPPM AIOPADAFDKL, FJJPMAIFPPM NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x28BB5E0", Offset = "0x28B9DE0", VA = "0x1828BB5E0", Slot = "42")]
		public FJJPMAIFPPM PHLGOOAEONB(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x28B8980", Offset = "0x28B7180", VA = "0x1828B8980", Slot = "43")]
		public void CKPOHKFAFGL(FJJPMAIFPPM AIOPADAFDKL, FJJPMAIFPPM NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x28BA890", Offset = "0x28B9090", VA = "0x1828BA890", Slot = "7")]
		public void NCDGFNDBKNE(FJJPMAIFPPM AIOPADAFDKL, FJJPMAIFPPM NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x28B9830", Offset = "0x28B8030", VA = "0x1828B9830", Slot = "8")]
		public void HKLHHKJFAPK(FJJPMAIFPPM AIOPADAFDKL, FJJPMAIFPPM NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x28BAB00", Offset = "0x28B9300", VA = "0x1828BAB00", Slot = "9")]
		public int NKKPNKDOOCN(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x28B9710", Offset = "0x28B7F10", VA = "0x1828B9710", Slot = "10")]
		public FJJPMAIFPPM HJKEFAKELHJ(FJJPMAIFPPM AIOPADAFDKL, int LHHBOCAHDEE)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x28BA450", Offset = "0x28B8C50", VA = "0x1828BA450", Slot = "11")]
		public void KPBMNAJLOCD(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x28B85A0", Offset = "0x28B6DA0", VA = "0x1828B85A0", Slot = "12")]
		public void BGCKKPBJLIA(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB, FJJPMAIFPPM NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x28B8880", Offset = "0x28B7080", VA = "0x1828B8880", Slot = "13")]
		public void CCDFDCPPGEI(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x28BA270", Offset = "0x28B8A70", VA = "0x1828BA270", Slot = "14")]
		public bool KKGEFBGABAM(FJJPMAIFPPM AIOPADAFDKL, out FJJPMAIFPPM NPHADDCNBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x28B8DD0", Offset = "0x28B75D0", VA = "0x1828B8DD0", Slot = "15")]
		public void EAAOJNPDEGK(FJJPMAIFPPM AIOPADAFDKL, float3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x28B9E60", Offset = "0x28B8660", VA = "0x1828B9E60", Slot = "16")]
		public bool JCBCHJBHPBL(FJJPMAIFPPM AIOPADAFDKL, out float3 NPHADDCNBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x28B8450", Offset = "0x28B6C50", VA = "0x1828B8450", Slot = "17")]
		public void AIEMEMNCHCC(FJJPMAIFPPM AIOPADAFDKL, float3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x28B92C0", Offset = "0x28B7AC0", VA = "0x1828B92C0", Slot = "18")]
		public bool GAFCMLEAPFH(FJJPMAIFPPM AIOPADAFDKL, out float3 NPHADDCNBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x28B8BC0", Offset = "0x28B73C0", VA = "0x1828B8BC0", Slot = "26")]
		public float3 DBHIJIDNBKF(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x28BB370", Offset = "0x28B9B70", VA = "0x1828BB370", Slot = "27")]
		public void OHJFFJEJLOE(FJJPMAIFPPM AIOPADAFDKL, float3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x28BA1B0", Offset = "0x28B89B0", VA = "0x1828BA1B0", Slot = "28")]
		public float KFADFOMNGOB(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x28B95A0", Offset = "0x28B7DA0", VA = "0x1828B95A0", Slot = "29")]
		public void HAOFOPIOLNI(FJJPMAIFPPM AIOPADAFDKL, float NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x28B9FC0", Offset = "0x28B87C0", VA = "0x1828B9FC0", Slot = "30")]
		public float JFMMNELICFK(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x28BAC80", Offset = "0x28B9480", VA = "0x1828BAC80", Slot = "31")]
		public void NMMMGGKDKHM(FJJPMAIFPPM AIOPADAFDKL, float NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x28B8540", Offset = "0x28B6D40", VA = "0x1828B8540", Slot = "32")]
		public bool BCOIILAACDE(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x28BB690", Offset = "0x28B9E90", VA = "0x1828BB690", Slot = "33")]
		public void PIDJMEIBCOB(FJJPMAIFPPM AIOPADAFDKL, bool NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x28BA6B0", Offset = "0x28B8EB0", VA = "0x1828BA6B0", Slot = "19")]
		public void LLKEKALFEGD(FJJPMAIFPPM AIOPADAFDKL, float3 NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x28BACF0", Offset = "0x28B94F0", VA = "0x1828BACF0", Slot = "20")]
		public bool NNAPBLIAKAL(FJJPMAIFPPM AIOPADAFDKL, out float3 NPHADDCNBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x28B84D0", Offset = "0x28B6CD0", VA = "0x1828B84D0", Slot = "21")]
		public void BCBPJCABODO(FJJPMAIFPPM AIOPADAFDKL, quaternion NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x28BB210", Offset = "0x28B9A10", VA = "0x1828BB210", Slot = "22")]
		public bool OHJAMJPKIEK(FJJPMAIFPPM AIOPADAFDKL, out quaternion NPHADDCNBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x28B9A90", Offset = "0x28B8290", VA = "0x1828B9A90", Slot = "23")]
		public bool ILEGLFGIAIF(FJJPMAIFPPM AIOPADAFDKL, out float3 BGMFPGPOCIC, out quaternion IPKKAPIGNMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x28B87B0", Offset = "0x28B6FB0", VA = "0x1828B87B0", Slot = "44")]
		public EFPLNFIMABM BKNHOGMINCC(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(EFPLNFIMABM);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x28B86D0", Offset = "0x28B6ED0", VA = "0x1828B86D0", Slot = "45")]
		public void BGEJBHGHNBC(FJJPMAIFPPM AIOPADAFDKL, EFPLNFIMABM NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x28BB550", Offset = "0x28B9D50", VA = "0x1828BB550", Slot = "72")]
		public void PEBALPOLIOC(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x28BABF0", Offset = "0x28B93F0", VA = "0x1828BABF0", Slot = "73")]
		public void NMIJDOKDNPK(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x28B99A0", Offset = "0x28B81A0", VA = "0x1828B99A0", Slot = "74")]
		public bool IECCJPOCPOF(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x28B9020", Offset = "0x28B7820", VA = "0x1828B9020", Slot = "81")]
		public void EIPIGMIEGOJ(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x28BAEE0", Offset = "0x28B96E0", VA = "0x1828BAEE0", Slot = "82")]
		public void NOEOIHALLLF(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x28BA3D0", Offset = "0x28B8BD0", VA = "0x1828BA3D0", Slot = "83")]
		public bool KNLGMEECKDF(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x28B9140", Offset = "0x28B7940", VA = "0x1828B9140", Slot = "84")]
		public IEnumerable<object> EOCGGNPBEBG(FJJPMAIFPPM AIOPADAFDKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x28BA210", Offset = "0x28B8A10", VA = "0x1828BA210", Slot = "46")]
		public bool KIFHIOFAPND(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x28BB150", Offset = "0x28B9950", VA = "0x1828BB150", Slot = "47")]
		public void ODPBKICIBCL(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x28BB060", Offset = "0x28B9860", VA = "0x1828BB060", Slot = "48")]
		public bool NPGEEAMNPJE(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x28B8810", Offset = "0x28B7010", VA = "0x1828B8810", Slot = "49")]
		public void BOIHBHFPDJD(FJJPMAIFPPM AIOPADAFDKL, bool NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x28B8390", Offset = "0x28B6B90", VA = "0x1828B8390", Slot = "50")]
		public bool AEJOMJDEBLJ(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x28B8910", Offset = "0x28B7110", VA = "0x1828B8910", Slot = "51")]
		public void CIMALDCHEEL(FJJPMAIFPPM AIOPADAFDKL, bool NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x28BA730", Offset = "0x28B8F30", VA = "0x1828BA730", Slot = "52")]
		public RigidbodyConstraints LNPPDKBKFJI(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x28B90B0", Offset = "0x28B78B0", VA = "0x1828B90B0", Slot = "53")]
		public void EJJDLKAECNH(FJJPMAIFPPM AIOPADAFDKL, RigidbodyConstraints NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x28B9940", Offset = "0x28B8140", VA = "0x1828B9940", Slot = "54")]
		public float HNINJECIDOK(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x28BA140", Offset = "0x28B8940", VA = "0x1828BA140", Slot = "55")]
		public void KAOBCPNCJLE(FJJPMAIFPPM AIOPADAFDKL, float NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x28B96B0", Offset = "0x28B7EB0", VA = "0x1828B96B0", Slot = "56")]
		public float HJDONPKHMDF(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x28BA9A0", Offset = "0x28B91A0", VA = "0x1828BA9A0", Slot = "57")]
		public void NCFCAFLOAJH(FJJPMAIFPPM AIOPADAFDKL, float NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x28BB770", Offset = "0x28B9F70", VA = "0x1828BB770", Slot = "58")]
		public bool PNNLACPNNAC(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x28B9530", Offset = "0x28B7D30", VA = "0x1828B9530", Slot = "59")]
		public void GDJBNJFJIBF(FJJPMAIFPPM AIOPADAFDKL, bool NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x28B9420", Offset = "0x28B7C20", VA = "0x1828B9420", Slot = "60")]
		public bool GBDCJEFNINK(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x28B9A20", Offset = "0x28B8220", VA = "0x1828B9A20", Slot = "61")]
		public void IKGCNDNPBKJ(FJJPMAIFPPM AIOPADAFDKL, bool NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x28BA540", Offset = "0x28B8D40", VA = "0x1828BA540", Slot = "62")]
		public int LDGEHBNPOBF(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x28B8740", Offset = "0x28B6F40", VA = "0x1828B8740", Slot = "63")]
		public void BIIMAKJPEEG(FJJPMAIFPPM AIOPADAFDKL, int NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x28BA5A0", Offset = "0x28B8DA0", VA = "0x1828BA5A0", Slot = "64")]
		public Rigidbody LLBBEJCPLIK(FJJPMAIFPPM AIOPADAFDKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x28B9D00", Offset = "0x28B8500", VA = "0x1828B9D00", Slot = "65")]
		public void ILNBOPEPBGE(FJJPMAIFPPM AIOPADAFDKL, Rigidbody NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x28BAF70", Offset = "0x28B9770", VA = "0x1828BAF70", Slot = "75")]
		public void NOJNIOMAGAG(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x28BAE50", Offset = "0x28B9650", VA = "0x1828BAE50", Slot = "76")]
		public void NOBALBHMFMK(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x28B9240", Offset = "0x28B7A40", VA = "0x1828B9240", Slot = "77")]
		public bool FEEHOAEGACG(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x28B8B30", Offset = "0x28B7330", VA = "0x1828B8B30", Slot = "66")]
		public object COBPAFFFCCG(FJJPMAIFPPM AIOPADAFDKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x28B8EC0", Offset = "0x28B76C0", VA = "0x1828B8EC0", Slot = "67")]
		public void EHMBHKNKLEN(FJJPMAIFPPM AIOPADAFDKL, object NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x28BA790", Offset = "0x28B8F90", VA = "0x1828BA790", Slot = "68")]
		public object MFICGEHFHGJ(FJJPMAIFPPM AIOPADAFDKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x28BB3F0", Offset = "0x28B9BF0", VA = "0x1828BB3F0", Slot = "69")]
		public void OHJLCHIFEPM(FJJPMAIFPPM AIOPADAFDKL, object NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x28B83F0", Offset = "0x28B6BF0", VA = "0x1828B83F0", Slot = "70")]
		public float AEODMHLBPEN(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x28BA820", Offset = "0x28B9020", VA = "0x1828BA820", Slot = "71")]
		public void NANFDDILDNP(FJJPMAIFPPM AIOPADAFDKL, float NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x28BAA10", Offset = "0x28B9210", VA = "0x1828BAA10", Slot = "78")]
		public void NCKOMHJKBDP(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x28B8D40", Offset = "0x28B7540", VA = "0x1828B8D40", Slot = "79")]
		public void DPJGCLOPDCP(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x28BA630", Offset = "0x28B8E30", VA = "0x1828BA630", Slot = "80")]
		public bool LLFCBCKLPKG(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x28BB000", Offset = "0x28B9800", VA = "0x1828BB000", Slot = "24")]
		public void NOKGDAILPAN(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x28B8330", Offset = "0x28B6B30", VA = "0x1828B8330", Slot = "25")]
		public void ADPBGOPKJLD(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x3321750", Offset = "0x331FF50", VA = "0x183321750")]
		private void JAMBFMMGPDI<T>(FJJPMAIFPPM AIOPADAFDKL, bool NPHADDCNBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x33216F0", Offset = "0x331FEF0", VA = "0x1833216F0")]
		private bool DEFLEJCEFLP<T>(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x3320D80", Offset = "0x331F580", VA = "0x183320D80")]
		private void ALIFOBNBCOA<T>(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x3321570", Offset = "0x331FD70", VA = "0x183321570")]
		private bool CJHDMOFCHGI<TC, TV>(FJJPMAIFPPM AIOPADAFDKL, Func<TC, TV> AINPMMBNHEE, out TV NPHADDCNBHE) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x33214F0", Offset = "0x331FCF0", VA = "0x1833214F0")]
		private bool CJHDMOFCHGI<T>(FJJPMAIFPPM AIOPADAFDKL, out T NPHADDCNBHE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x3321860", Offset = "0x3320060", VA = "0x183321860")]
		private T OGBFDKOOFME<T>(FJJPMAIFPPM AIOPADAFDKL) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3321D10", Offset = "0x3320510", VA = "0x183321D10")]
		private void PHEIBLJBKNO<T>(FJJPMAIFPPM AIOPADAFDKL, T NPHADDCNBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x3320E90", Offset = "0x331F690", VA = "0x183320E90")]
		private void CCCCBFNEFIJ<T>(FJJPMAIFPPM AIOPADAFDKL, T NPHADDCNBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x33214F0", Offset = "0x331FCF0", VA = "0x1833214F0")]
		private bool CFIADFGCCIJ<T>(FJJPMAIFPPM AIOPADAFDKL, out T NPHADDCNBHE) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x3321CB0", Offset = "0x33204B0", VA = "0x183321CB0")]
		private T OJKIJEOOMGO<T>(FJJPMAIFPPM AIOPADAFDKL) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x33214F0", Offset = "0x331FCF0", VA = "0x1833214F0")]
		private void CDPKIPHFOML<T>(FJJPMAIFPPM AIOPADAFDKL, T NPHADDCNBHE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x3320DE0", Offset = "0x331F5E0", VA = "0x183320DE0")]
		private void BDFPFINICFI<T>(FJJPMAIFPPM AIOPADAFDKL, T NPHADDCNBHE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x28B8D10", Offset = "0x28B7510", VA = "0x1828B8D10")]
		private FJJPMAIFPPM DEHBEEAEBJA(Entity DJGIAPPGDDP)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x28B8C40", Offset = "0x28B7440", VA = "0x1828B8C40")]
		private DynamicBuffer<Entity> DCBEMKGAOHH(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x33217A0", Offset = "0x331FFA0", VA = "0x1833217A0")]
		private void KJOKFMOHMDM<T>(FJJPMAIFPPM AIOPADAFDKL, object NPHADDCNBHE, Func<object, T> AINPMMBNHEE) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		private void AOGHGHFDMOA<T>(ref global::CACIMGOHFBI<T> BPHLNCHBAFC) where T : struct, EPJOCCFBHFH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		private void AOGHGHFDMOA<TC, TV>(ref global::JEKNJGCOJLP<TC, TV> BPHLNCHBAFC) where TC : struct, EPJOCCFBHFH
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
	[FIKNCOOOHID(typeof(KinematicSleepChangeService), new string[] { })]
	public class KinematicSleepChangeService : HNOABDNADGF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class OFDMKAHEIDE : IEnumerable<CBLFGEBLHGN>, IEnumerable, IEnumerator<CBLFGEBLHGN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private CBLFGEBLHGN <>2__current;

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
			private CBLFGEBLHGN System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
			[DebuggerHidden]
			public OFDMKAHEIDE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x4191E80", Offset = "0x4190680", VA = "0x184191E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x4191B40", Offset = "0x4190340", VA = "0x184191B40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x4191F00", Offset = "0x4190700", VA = "0x184191F00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x4191E40", Offset = "0x4190640", VA = "0x184191E40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x4191D90", Offset = "0x4190590", VA = "0x184191D90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CBLFGEBLHGN> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x4191D90", Offset = "0x4190590", VA = "0x184191D90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> JGEMMPOPOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[EOIIILOBJAK]
		private PNONIBNMECP MOMLDEEAAPM;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x31D8260", Offset = "0x31D6A60", VA = "0x1831D8260", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x31D8E60", Offset = "0x31D7660", VA = "0x1831D8E60")]
		public void PNHDKNJPDFD(NativeArray<Entity> NBDCDJJEKHD, bool IEKDEPMILCL, bool DBELNIPDDEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x31D8490", Offset = "0x31D6C90", VA = "0x1831D8490")]
		public void KHDDONFMLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x31D86A0", Offset = "0x31D6EA0", VA = "0x1831D86A0")]
		private void LMMKGLJMCNF(NativeArray<Entity> NBDCDJJEKHD, bool IEKDEPMILCL, bool DBELNIPDDEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x31D82B0", Offset = "0x31D6AB0", VA = "0x1831D82B0")]
		[IteratorStateMachine(typeof(OFDMKAHEIDE))]
		private IEnumerable<CBLFGEBLHGN> DLMDABCNCHB(NativeArray<Entity> NBDCDJJEKHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x31D8340", Offset = "0x31D6B40", VA = "0x1831D8340", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x31D8FD0", Offset = "0x31D77D0", VA = "0x1831D8FD0")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
[FIKNCOOOHID(typeof(JHIICGGLBCC), new string[] { })]
public class MAHKMHFPHKA : JHIICGGLBCC, IEnumerable<PEFKAJGNEDD>, IEnumerable, DAANNPIBALJ, BGAFKNOHCIN, HNOABDNADGF, INBMAMBAHGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[EOIIILOBJAK]
	private MLJPHNOGBJG AIDEINAMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<(Type, string), int> MIAAMELKGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private FGPEBCJAFOD KGPJFFHNKNF;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x31DCEB0", Offset = "0x31DB6B0", VA = "0x1831DCEB0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public PEFKAJGNEDD IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x31DD620", Offset = "0x31DBE20", VA = "0x1831DD620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public PEFKAJGNEDD IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x31DD620", Offset = "0x31DBE20", VA = "0x1831DD620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x31DCED0", Offset = "0x31DB6D0", VA = "0x1831DCED0", Slot = "11")]
	public void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x31DCF20", Offset = "0x31DB720", VA = "0x1831DCF20", Slot = "12")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "13")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x31DCFA0", Offset = "0x31DB7A0", VA = "0x1831DCFA0")]
	private void FCCPFJCGFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x26EF810", Offset = "0x26EE010", VA = "0x1826EF810")]
	private string KPDNKGOLBFG(string LOIAMCEJAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x31DD640", Offset = "0x31DBE40", VA = "0x1831DD640", Slot = "7")]
	public PEFKAJGNEDD OFLHEENCEAD(DMLMOBPCOID OABNINOCHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x31DD370", Offset = "0x31DBB70", VA = "0x1831DD370")]
	private bool KFJCFEEILHM(Type NNANCGDEKIO, string LOIAMCEJAFO, out PEFKAJGNEDD MOMPKBKMCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x31DD240", Offset = "0x31DBA40", VA = "0x1831DD240", Slot = "8")]
	public OBIAPIAFCLH FGBGCFBFCJH(DMLMOBPCOID OABNINOCHNF)
	{
		return default(OBIAPIAFCLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x31DD350", Offset = "0x31DBB50", VA = "0x1831DD350", Slot = "9")]
	public IEnumerator<PEFKAJGNEDD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x31DD350", Offset = "0x31DBB50", VA = "0x1831DD350", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x31DD720", Offset = "0x31DBF20", VA = "0x1831DD720")]
	public MAHKMHFPHKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
[DefaultMember("Item")]
public interface PAPJACKNAPB
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LBDEHHEEIPL(OBIAPIAFCLH MKEJJPNNCOG, out int GIGKIGNPJAP);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
[FIKNCOOOHID(typeof(PAPJACKNAPB), new string[] { })]
public class NJPNLMIBNAC : HNOABDNADGF, INBMAMBAHGE, PAPJACKNAPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[EOIIILOBJAK]
	private BMIGPDLOFHL AIDEINAMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<OBIAPIAFCLH, int> AEBGOIEGAJK;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x289F0E0", Offset = "0x289D8E0", VA = "0x18289F0E0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x289F070", Offset = "0x289D870", VA = "0x18289F070", Slot = "6")]
	public bool LBDEHHEEIPL(OBIAPIAFCLH MKEJJPNNCOG, out int GIGKIGNPJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x289F010", Offset = "0x289D810", VA = "0x18289F010", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x289F000", Offset = "0x289D800", VA = "0x18289F000", Slot = "5")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x289F140", Offset = "0x289D940", VA = "0x18289F140")]
	private void OPBEMPBFAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x289F3B0", Offset = "0x289DBB0", VA = "0x18289F3B0")]
	public NJPNLMIBNAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[FIKNCOOOHID(typeof(BMIGPDLOFHL), new string[] { })]
[DefaultMember("Item")]
public class EOFMEKJFEAO : BMIGPDLOFHL, IEnumerable<OJFEPNOINDA>, IEnumerable, DAANNPIBALJ, BGAFKNOHCIN, HNOABDNADGF, INBMAMBAHGE, KGPEFICHJKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[EOIIILOBJAK]
	private GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[EOIIILOBJAK]
	private JHIICGGLBCC JKJEICNLCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private OJFEPNOINDA[] NFFLPCLEFFL;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x31BF970", Offset = "0x31BE170", VA = "0x1831BF970", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public OJFEPNOINDA IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x31BF980", Offset = "0x31BE180", VA = "0x1831BF980", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public OJFEPNOINDA IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x31BF980", Offset = "0x31BE180", VA = "0x1831BF980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "10")]
	public void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x31BF9C0", Offset = "0x31BE1C0", VA = "0x1831BF9C0", Slot = "11")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "12")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x31BFF50", Offset = "0x31BE750", VA = "0x1831BFF50", Slot = "6")]
	public OJFEPNOINDA OFLHEENCEAD(DMLMOBPCOID OABNINOCHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x31BFDA0", Offset = "0x31BE5A0", VA = "0x1831BFDA0", Slot = "7")]
	public OBIAPIAFCLH FGBGCFBFCJH(DMLMOBPCOID OABNINOCHNF)
	{
		return default(OBIAPIAFCLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x31BFE70", Offset = "0x31BE670", VA = "0x1831BFE70", Slot = "8")]
	public IEnumerator<OJFEPNOINDA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x31C0080", Offset = "0x31BE880", VA = "0x1831C0080", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x28539F0", Offset = "0x28521F0", VA = "0x1828539F0", Slot = "13")]
	public void FDNHKMLHECH<TKey, T>(global::ABJCAJMMMEG<TKey, T> NPCKPCNEDPB, [Optional] object CDBJCAAPIOD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x31BFC60", Offset = "0x31BE460", VA = "0x1831BFC60", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public EOFMEKJFEAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x31BF980", Offset = "0x31BE180", VA = "0x1831BF980")]
	[CompilerGenerated]
	private OJFEPNOINDA CAFJFBDBKPL(int AOKAFHMCMMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
[FIKNCOOOHID(typeof(IOIEJFCEOCP), new string[] { })]
public class FPKFAMFIPIO : IOIEJFCEOCP, IEnumerable<CBKEAKDLCBB>, IEnumerable, HNOABDNADGF, INBMAMBAHGE, KGPEFICHJKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[EOIIILOBJAK]
	private GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[EOIIILOBJAK]
	private JHIICGGLBCC JKJEICNLCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private CBKEAKDLCBB[] NFFLPCLEFFL;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x31C78D0", Offset = "0x31C60D0", VA = "0x1831C78D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CBKEAKDLCBB IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x31C7920", Offset = "0x31C6120", VA = "0x1831C7920", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CBKEAKDLCBB IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x31C7920", Offset = "0x31C6120", VA = "0x1831C7920", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x31C7B90", Offset = "0x31C6390", VA = "0x1831C7B90", Slot = "9")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x31C7930", Offset = "0x31C6130", VA = "0x1831C7930", Slot = "10")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x31C7D70", Offset = "0x31C6570", VA = "0x1831C7D70")]
	private CBKEAKDLCBB GGOHAILIFNK(int LHHBOCAHDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x31C7F60", Offset = "0x31C6760", VA = "0x1831C7F60", Slot = "6")]
	public CBKEAKDLCBB OFLHEENCEAD(DMLMOBPCOID OABNINOCHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x31C7CA0", Offset = "0x31C64A0", VA = "0x1831C7CA0", Slot = "14")]
	public OBIAPIAFCLH FGBGCFBFCJH(DMLMOBPCOID OABNINOCHNF)
	{
		return default(OBIAPIAFCLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x31C7E50", Offset = "0x31C6650", VA = "0x1831C7E50", Slot = "7")]
	public IEnumerator<CBKEAKDLCBB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x31C7E50", Offset = "0x31C6650", VA = "0x1831C7E50", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x268E7A0", Offset = "0x268CFA0", VA = "0x18268E7A0", Slot = "11")]
	public void FDNHKMLHECH<TKey, T>(global::ABJCAJMMMEG<TKey, T> NPCKPCNEDPB, [Optional] object CDBJCAAPIOD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x31C7C00", Offset = "0x31C6400", VA = "0x1831C7C00", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public FPKFAMFIPIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x31C7920", Offset = "0x31C6120", VA = "0x1831C7920")]
	[CompilerGenerated]
	private CBKEAKDLCBB CAFJFBDBKPL(int AOKAFHMCMMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[FIKNCOOOHID(typeof(MLJPHNOGBJG), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
internal class MLJPHNOGBJG : HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private JHIICGGLBCC JKJEICNLCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private IOIEJFCEOCP CONCDNLIGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private BMIGPDLOFHL MPDIHFLKIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private global::APNDKDHFDGE<NDFGOBMDHCC> FIEBNCFJODK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public FGPEBCJAFOD HHBCBPIIECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC590", Offset = "0x6DAD90", VA = "0x1806DC590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x289B130", Offset = "0x2899930", VA = "0x18289B130", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x289B400", Offset = "0x2899C00", VA = "0x18289B400")]
	private void IHNPMJPNMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x24F14E0", Offset = "0x24EFCE0", VA = "0x1824F14E0")]
	public T AOOGJHEDEOM<T>() where T : NDFGOBMDHCC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x289B4F0", Offset = "0x2899CF0", VA = "0x18289B4F0")]
	public PEFKAJGNEDD ODHNKILLIKJ(DMLMOBPCOID LOIAMCEJAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	public global::LEKHCEGJOPN<T> ODHNKILLIKJ<T>(DMLMOBPCOID LOIAMCEJAFO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x289B330", Offset = "0x2899B30", VA = "0x18289B330")]
	public CBKEAKDLCBB GHDPBHOCKBI(DMLMOBPCOID LOIAMCEJAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5CF0", Offset = "0x2AA44F0", VA = "0x182AA5CF0")]
	public global::MNFHHBDNCBA<T> GHDPBHOCKBI<T>(DMLMOBPCOID LOIAMCEJAFO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x289B260", Offset = "0x2899A60", VA = "0x18289B260")]
	public OJFEPNOINDA FPGHMLBIALK(DMLMOBPCOID LOIAMCEJAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	public global::FFNNPMNCCNE<T> FPGHMLBIALK<T>(DMLMOBPCOID LOIAMCEJAFO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public MLJPHNOGBJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class GNDGIFGDNCE
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2557820", Offset = "0x2556020", VA = "0x182557820")]
	public static global::LEKHCEGJOPN<T> ODHNKILLIKJ<T>(this MLJPHNOGBJG GKEOGLHPNDK, global::PNOGAICEIOC<T> LOIAMCEJAFO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	public static global::MNFHHBDNCBA<T> GHDPBHOCKBI<T>(this MLJPHNOGBJG GKEOGLHPNDK, global::PNOGAICEIOC<T> LOIAMCEJAFO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	public static global::FFNNPMNCCNE<T> FPGHMLBIALK<T>(this MLJPHNOGBJG GKEOGLHPNDK, global::PNOGAICEIOC<T> LOIAMCEJAFO) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[FIKNCOOOHID(typeof(NCPJHOCGPKA), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
public class NCPJHOCGPKA : HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private KDCGOEEADEP HEHMPJJLBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private OBIAPIAFCLH[] PALMGFFAAPM;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x289D660", Offset = "0x289BE60", VA = "0x18289D660", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x289D8F0", Offset = "0x289C0F0", VA = "0x18289D8F0")]
	public void PNJLJBCFDNH(IOAGKMCGKAI DGNLFFKHMAE, bool JDHFEMCKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public NCPJHOCGPKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[FIKNCOOOHID(typeof(EBICOJKKKJL), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
public sealed class EBICOJKKKJL : HNOABDNADGF, INBMAMBAHGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class JBHDPGHFAAF : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AE910", VA = "0x1808B0110")]
		[DebuggerHidden]
		public JBHDPGHFAAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x418EEE0", Offset = "0x418D6E0", VA = "0x18418EEE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x418EB30", Offset = "0x418D330", VA = "0x18418EB30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x418EF60", Offset = "0x418D760", VA = "0x18418EF60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x418EEA0", Offset = "0x418D6A0", VA = "0x18418EEA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x418EE10", Offset = "0x418D610", VA = "0x18418EE10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x418EE10", Offset = "0x418D610", VA = "0x18418EE10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string JHNHICMODFJ = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<SerializableGuid, MDILBOGEEOB> JBBNFBCNIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<SerializableGuid> CAFBNIEFHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Dictionary<SerializableGuid, GameObject> HFGBBMMCEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private IOIEJFCEOCP AIDEINAMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private HILDNPBHGOE GHFACKFNNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private FAIAJFOHDOE AOPMIABPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NBDMAOHFKJB JDOIGKNENIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private global::PDGNJHJPBNB<MDILBOGEEOB> CHPCGBPCMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject NPGNFGJFKKE;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2D1FEF0", Offset = "0x2D1E6F0", VA = "0x182D1FEF0", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1FD20", Offset = "0x2D1E520", VA = "0x182D1FD20", Slot = "5")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1FFC0", Offset = "0x2D1E7C0", VA = "0x182D1FFC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2D20340", Offset = "0x2D1EB40", VA = "0x182D20340")]
	private void ILOMAPEOGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F560", Offset = "0x2D1DD60", VA = "0x182D1F560")]
	internal void BFLBEENBGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2D20350", Offset = "0x2D1EB50", VA = "0x182D20350")]
	private void KAMJELAGPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2D20530", Offset = "0x2D1ED30", VA = "0x182D20530")]
	private void KHHFFFNJKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2D20680", Offset = "0x2D1EE80", VA = "0x182D20680")]
	[IteratorStateMachine(typeof(JBHDPGHFAAF))]
	private IEnumerable<RRCustomPropTag> NOLFIHPABHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2D20810", Offset = "0x2D1F010", VA = "0x182D20810")]
	private void PJOHDOMDNCD(FJJPMAIFPPM AIOPADAFDKL, in OJMHOIEICMJ CEOLOJHDIEE, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2D206D0", Offset = "0x2D1EED0", VA = "0x182D206D0")]
	private void OFCCGGLDJKB(SerializableGuid CNMALJMHIOD, GameObject IMPKIJJJHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F990", Offset = "0x2D1E190", VA = "0x182D1F990")]
	private void BHEADNFKENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2D20160", Offset = "0x2D1E960", VA = "0x182D20160")]
	private bool GFAIIBEDLHM(MDILBOGEEOB KDLEIEHGNAD, Transform FAAJOMIIHED, out GameObject HBJDGFDOIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2D20630", Offset = "0x2D1EE30", VA = "0x182D20630")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2D20C90", Offset = "0x2D1F490", VA = "0x182D20C90")]
	public EBICOJKKKJL()
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
		public SerializableGuid AFBALMNBHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x28B8240", Offset = "0x28B6A40", VA = "0x1828B8240")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[FIKNCOOOHID(typeof(KHGMAHBDENG), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
public class KHGMAHBDENG : HNOABDNADGF
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private const string DGAEPEGCFPJ = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private SceneService NHAGBLLKJEL;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x31D7130", Offset = "0x31D5930", VA = "0x1831D7130", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public KHGMAHBDENG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[FIKNCOOOHID(typeof(IILDKGCJKEC), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
public class IILDKGCJKEC : HNOABDNADGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[EOIIILOBJAK]
	private EnableComponentSystemsInScope AICKBHACNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[EOIIILOBJAK]
	private SceneService NHAGBLLKJEL;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x31D1280", Offset = "0x31CFA80", VA = "0x1831D1280", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x31D12F0", Offset = "0x31CFAF0", VA = "0x1831D12F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x31D1330", Offset = "0x31CFB30", VA = "0x1831D1330")]
	private void IMIGJKJIOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x31D1350", Offset = "0x31CFB50", VA = "0x1831D1350")]
	private void KJPHMBPECEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public IILDKGCJKEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[FIKNCOOOHID(typeof(BJFMFKKFIDI), new string[] { })]
public class DDLPCOMFJGN : HNOABDNADGF, INBMAMBAHGE, BJFMFKKFIDI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private HIFGFPBNEMJ GJCNCJNMMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private MDCGDAPEKLJ ODAFCMEFLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PropertyEventCallbacksService HKNJNCDEHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private LocalPlayerScopeSystem HNPEPHNNIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private int JCIPLKKKDOK;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool EIFFKOMINAE
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A5F0", Offset = "0x2D18DF0", VA = "0x182D1A5F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public FJJPMAIFPPM EGLLBKCIMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2D1ABE0", Offset = "0x2D193E0", VA = "0x182D1ABE0", Slot = "9")]
		get
		{
			return default(FJJPMAIFPPM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A550", Offset = "0x2D18D50", VA = "0x182D1A550", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public JPEOKMJCLOL HIFLJJDDLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2D1AD80", Offset = "0x2D19580", VA = "0x182D1AD80", Slot = "11")]
		get
		{
			return default(JPEOKMJCLOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2D1A550", Offset = "0x2D18D50", VA = "0x182D1A550", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public JPEOKMJCLOL KOFJFIOJGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B370", Offset = "0x2D19B70", VA = "0x182D1B370", Slot = "13")]
		get
		{
			return default(JPEOKMJCLOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint MBHJPOKPOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B220", Offset = "0x2D19A20", VA = "0x182D1B220")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event NPLOCFMHAJK ALBEHPNMNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B2D0", Offset = "0x2D19AD0", VA = "0x182D1B2D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2D1ADD0", Offset = "0x2D195D0", VA = "0x182D1ADD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A960", Offset = "0x2D19160", VA = "0x182D1A960", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A630", Offset = "0x2D18E30", VA = "0x182D1A630", Slot = "5")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AB30", Offset = "0x2D19330", VA = "0x182D1AB30", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AE70", Offset = "0x2D19670", VA = "0x182D1AE70")]
	private void IGFHKGMAAAE(Entity DJGIAPPGDDP, OBIAPIAFCLH GCAANJILJJP, OJMHOIEICMJ AHKNGMEFAGI, OJMHOIEICMJ EJDNMJGBJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B110", Offset = "0x2D19910", VA = "0x182D1B110", Slot = "14")]
	public FJJPMAIFPPM MNCLLCOLFLA(FJJPMAIFPPM GFJEHCBMJMC, FJJPMAIFPPM FPIHIJPFEDK)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AA30", Offset = "0x2D19230", VA = "0x182D1AA30", Slot = "15")]
	public bool DGHKOIDPNCJ(FJJPMAIFPPM GFJEHCBMJMC, FJJPMAIFPPM FPIHIJPFEDK, out FJJPMAIFPPM IHHHDHPFGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A7D0", Offset = "0x2D18FD0", VA = "0x182D1A7D0", Slot = "16")]
	public void CMOIFLEAOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B070", Offset = "0x2D19870", VA = "0x182D1B070", Slot = "17")]
	public void JGACEDJABAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AC20", Offset = "0x2D19420", VA = "0x182D1AC20", Slot = "18")]
	public bool GGFGMKFNMJL(FJJPMAIFPPM DJDDCFICJJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2D1A550", Offset = "0x2D18D50", VA = "0x182D1A550")]
	private void CHNEFJFCONP(FJJPMAIFPPM CBONLGCLKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DDLPCOMFJGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[FIKNCOOOHID(typeof(NMPFDHBEMLP), new string[] { })]
public class FOOLLGEDCKD : HNOABDNADGF, NMPFDHBEMLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EntityManager AIFDIGHJEAF;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x31C70D0", Offset = "0x31C58D0", VA = "0x1831C70D0", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x31C7150", Offset = "0x31C5950", VA = "0x1831C7150", Slot = "5")]
	public void DEIJAOMNHDG(FJJPMAIFPPM NGPFKAJPHJF, bool NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x268E6C0", Offset = "0x268CEC0", VA = "0x18268E6C0")]
	private void BJPKOCBPDKP<T>(FJJPMAIFPPM NGPFKAJPHJF, bool NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public FOOLLGEDCKD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[FIKNCOOOHID(typeof(AANGANHCBCA), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.RenderEffects)]
	public class SelectionService : HNOABDNADGF, AANGANHCBCA
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EntityManager AIFDIGHJEAF;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2C980A0", Offset = "0x2C968A0", VA = "0x182C980A0", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2C98190", Offset = "0x2C96990", VA = "0x182C98190", Slot = "5")]
		public void JDOAFJMEEPG(FJJPMAIFPPM NGPFKAJPHJF, bool NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2C98120", Offset = "0x2C96920", VA = "0x182C98120", Slot = "6")]
		public void GCHHIGCJMCO(FJJPMAIFPPM NGPFKAJPHJF, bool NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x268E6C0", Offset = "0x268CEC0", VA = "0x18268E6C0")]
		private void BJPKOCBPDKP<T>(FJJPMAIFPPM NGPFKAJPHJF, bool NPHADDCNBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
[FIKNCOOOHID(typeof(GGJDGBMNFFH), new string[] { })]
internal sealed class GGJDGBMNFFH : HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[EOIIILOBJAK]
	private ObjectEmbodimentService BFLDNFIFFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[EOIIILOBJAK]
	private PNONIBNMECP MOMLDEEAAPM;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x31C9350", Offset = "0x31C7B50", VA = "0x1831C9350", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public GGJDGBMNFFH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[IECCMKJMAAC(LAEALBOAPLI.Serialization)]
	[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
	[FIKNCOOOHID(typeof(WorldSerialization), new string[] { })]
	internal sealed class WorldSerialization : HNOABDNADGF, NIEJGDDPJNF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly DELGGOALDMF DPJGFNOIDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[EOIIILOBJAK]
		private PNONIBNMECP IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[EOIIILOBJAK]
		private JDLGCJBNHOE LFOCCHHNJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[EOIIILOBJAK]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[EOIIILOBJAK]
		private SerializationService AOPMIABPHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[EOIIILOBJAK]
		private OBEIMMOBIBP EDCAIOHEHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[EOIIILOBJAK]
		private DebugWorldsService IGFJFGMJLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[EOIIILOBJAK]
		private BulkInstantiateSceneObjectService DMNIDFIOECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private FEIANFNLNIA BDDMBDBDABJ;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private FMCAGKALAFL NGCFMDOIIDI
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xC2BE50", Offset = "0xC2A650", VA = "0x180C2BE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC720", Offset = "0x2CAAF20", VA = "0x182CAC720", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA IDDAFOIOGGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC870", Offset = "0x2CAB070", VA = "0x182CAC870", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC8A0", Offset = "0x2CAB0A0", VA = "0x182CAC8A0", Slot = "6")]
		public bool EJKHPBEICGB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD230", Offset = "0x2CABA30", VA = "0x182CAD230", Slot = "7")]
		public bool PKANBAPKOLK(IEnumerable<ILMPIIJELKE> EHADBCLKLDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2CACDA0", Offset = "0x2CAB5A0", VA = "0x182CACDA0", Slot = "5")]
		public ByteString IHODHCPGNOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2CACD80", Offset = "0x2CAB580", VA = "0x182CACD80")]
		private void IBCJBLKFPHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC650", Offset = "0x2CAAE50", VA = "0x182CAC650")]
		private void BKLLCDAHFMD(KIDCDCBHCHF BOAFCCFONHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC170", Offset = "0x2CAA970", VA = "0x182CAC170")]
		private void AFFHDMIIFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2CACAA0", Offset = "0x2CAB2A0", VA = "0x182CACAA0")]
		private void HPABPIPJLPG(FEKHKPAALFH BOAFCCFONHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD250", Offset = "0x2CABA50", VA = "0x182CAD250", Slot = "8")]
		public void PMKGKFFMMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2CACA00", Offset = "0x2CAB200", VA = "0x182CACA00")]
		private KIDCDCBHCHF HHEAMFKEIJF(EntityManager OKKBMCGGEHO, EntityManager NFGIFIIHNNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[FIKNCOOOHID(typeof(FPFMGBDGNNO), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
public class FPFMGBDGNNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly Dictionary<FILDKNJLENH, string> PPNPFANHEHH;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x31C71C0", Offset = "0x31C59C0", VA = "0x1831C71C0")]
	public GameObject MCGDAMPPMIJ(FILDKNJLENH JHDFEHHKAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x31C7290", Offset = "0x31C5A90", VA = "0x1831C7290")]
	public FPFMGBDGNNO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[FIKNCOOOHID(typeof(TimeService), new string[] { })]
	public class TimeService : BGAFKNOHCIN, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[EOIIILOBJAK]
		private SingletonComponentService OGLMOGCJGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool GMBDBJBNCCA;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TimeData GBHJKICHLBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x2C9FAC0", Offset = "0x2C9E2C0", VA = "0x182C9FAC0")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x2C9FB30", Offset = "0x2C9E330", VA = "0x182C9FB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool FMKIDEIJOLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8D0", Offset = "0x6EE0D0", VA = "0x1806EF8D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x711000", Offset = "0x70F800", VA = "0x180711000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D860", Offset = "0x1D8C060", VA = "0x181D8D860", Slot = "4")]
		public void CDCHANKPBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F9B0", Offset = "0x2C9E1B0", VA = "0x182C9F9B0", Slot = "5")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FA00", Offset = "0x2C9E200", VA = "0x182C9FA00")]
		public void FFFNLHCILJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[IECCMKJMAAC(LAEALBOAPLI.TransformSyncing)]
	[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
	[FIKNCOOOHID(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	internal class SetTransformParentIfParentPropertyChanges : HNOABDNADGF, INBMAMBAHGE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private HMGEJIKOHBO FLBPGJKFMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private global::LEKHCEGJOPN<Entity> FAAJOMIIHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ObjectEmbodimentService OMHLILNOJHE;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BDA0", Offset = "0x2C9A5A0", VA = "0x182C9BDA0", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BC70", Offset = "0x2C9A470", VA = "0x182C9BC70", Slot = "5")]
		public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BE10", Offset = "0x2C9A610", VA = "0x182C9BE10", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BB30", Offset = "0x2C9A330", VA = "0x182C9BB30")]
		private void AOPLBMDKKIA(Entity DJGIAPPGDDP, in OJMHOIEICMJ CEOLOJHDIEE, in OJMHOIEICMJ PMHHEDOHMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[IECCMKJMAAC(LAEALBOAPLI.Services)]
	[FIKNCOOOHID(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
	public class EnableTransmissionOnlyInLoadInstance : HNOABDNADGF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[EOIIILOBJAK]
		private PNONIBNMECP IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[EOIIILOBJAK]
		private DPOMMEHNOPH KEBPJDOCLJC;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private BCCHBCHHCKK MOBKEFCHADB
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x31C2100", Offset = "0x31C0900", VA = "0x1831C2100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private OJEKHACFHMH LFLFPLBJMAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x31C2150", Offset = "0x31C0950", VA = "0x1831C2150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x31C2060", Offset = "0x31C0860", VA = "0x1831C2060", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x31C20E0", Offset = "0x31C08E0", VA = "0x1831C20E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[FIKNCOOOHID(typeof(NEIOFMAIOEO), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
public class NEIOFMAIOEO : KJMOLFDIMPO, DAANNPIBALJ, BGAFKNOHCIN, HNOABDNADGF, INBMAMBAHGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class JNBAFECIPFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public FEIANFNLNIA services;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public JNBAFECIPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x418F600", Offset = "0x418DE00", VA = "0x18418F600")]
		internal void <InitReferences>b__0(HNOABDNADGF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class DBGADPOIKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public FEIANFNLNIA services;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public DBGADPOIKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x418A240", Offset = "0x4188A40", VA = "0x18418A240")]
		internal void <InitExternal>b__0(INBMAMBAHGE svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[EOIIILOBJAK]
	private PNONIBNMECP MOMLDEEAAPM;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public FABKOFGEAEO IHCFGGOCMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x942020", Offset = "0x940820", VA = "0x180942020", Slot = "4")]
		get
		{
			return default(FABKOFGEAEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private KPAAIPGAPMC BCCOIHBMLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x289DE80", Offset = "0x289C680", VA = "0x18289DE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x289DE30", Offset = "0x289C630", VA = "0x18289DE30", Slot = "5")]
	public void HLHNMHIAHFM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x289DAF0", Offset = "0x289C2F0", VA = "0x18289DAF0", Slot = "6")]
	public void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x289DC20", Offset = "0x289C420", VA = "0x18289DC20", Slot = "7")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x289DA10", Offset = "0x289C210", VA = "0x18289DA10", Slot = "8")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x289DD00", Offset = "0x289C500", VA = "0x18289DD00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x1F21210", Offset = "0x1F1FA10", VA = "0x181F21210")]
	private void AONJLIBMJMI<T>(Action<T> ANBLKGCEOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public NEIOFMAIOEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class CLCIAADDKIP<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly Func<From, To> PLIDKCANPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly Func<To, From> JFMIKHFBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public DynamicBuffer<From> DNLJJNDPNCG;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To IOEJBJHPAFG
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
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool PKHIKMNBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	public CLCIAADDKIP(Func<From, To> PLIDKCANPFF, Func<To, From> JFMIKHFBGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] CIMBPHJAHGJ, int BLCDEHFGKBI)
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
	public int IndexOf(To FNHAIFCEKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int LHHBOCAHDEE, To FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int LHHBOCAHDEE)
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
public class NMFLAMLEGIP<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<From, To> PLIDKCANPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Func<To, From> JFMIKHFBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public List<From> HGPMCGJIADE;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA6C0", Offset = "0x2AF8EC0", VA = "0x182AFA6C0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA720", Offset = "0x2AF8F20", VA = "0x182AFA720", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA690", Offset = "0x2AF8E90", VA = "0x182AFA690", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool PKHIKMNBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x78F190", Offset = "0x78D990", VA = "0x18078F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA600", Offset = "0x2AF8E00", VA = "0x182AFA600")]
	public NMFLAMLEGIP(Func<From, To> PLIDKCANPFF, Func<To, From> JFMIKHFBGLM, bool DICFAHGJIHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA220", Offset = "0x2AF8A20", VA = "0x182AFA220", Slot = "11")]
	public void Add(To FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA280", Offset = "0x2AF8A80", VA = "0x182AFA280", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA2B0", Offset = "0x2AF8AB0", VA = "0x182AFA2B0", Slot = "13")]
	public bool Contains(To FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA310", Offset = "0x2AF8B10", VA = "0x182AFA310", Slot = "14")]
	public void CopyTo(To[] CIMBPHJAHGJ, int BLCDEHFGKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA420", Offset = "0x2AF8C20", VA = "0x182AFA420", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA490", Offset = "0x2AF8C90", VA = "0x182AFA490", Slot = "6")]
	public int IndexOf(To FNHAIFCEKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA4F0", Offset = "0x2AF8CF0", VA = "0x182AFA4F0", Slot = "7")]
	public void Insert(int LHHBOCAHDEE, To FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA5A0", Offset = "0x2AF8DA0", VA = "0x182AFA5A0", Slot = "15")]
	public bool Remove(To FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA570", Offset = "0x2AF8D70", VA = "0x182AFA570", Slot = "8")]
	public void RemoveAt(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x26F9B90", Offset = "0x26F8390", VA = "0x1826F9B90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DefaultMember("Item")]
public class AGHKNFDMGGB<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Func<From, To> PLIDKCANPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly Func<To, From> JFMIKHFBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<From> CIMBPHJAHGJ;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x33AC220", Offset = "0x33AAA20", VA = "0x1833AC220", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x33AC270", Offset = "0x33AAA70", VA = "0x1833AC270", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x33AC1E0", Offset = "0x33AA9E0", VA = "0x1833AC1E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool PKHIKMNBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x25B1330", Offset = "0x25AFB30", VA = "0x1825B1330")]
	public AGHKNFDMGGB(Func<From, To> PLIDKCANPFF, Func<To, From> JFMIKHFBGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x33ABDF0", Offset = "0x33AA5F0", VA = "0x1833ABDF0", Slot = "11")]
	public void Add(To FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x33ABE30", Offset = "0x33AA630", VA = "0x1833ABE30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x33ABE70", Offset = "0x33AA670", VA = "0x1833ABE70", Slot = "13")]
	public bool Contains(To FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x33ABF30", Offset = "0x33AA730", VA = "0x1833ABF30", Slot = "14")]
	public void CopyTo(To[] CIMBPHJAHGJ, int BLCDEHFGKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x33ABFF0", Offset = "0x33AA7F0", VA = "0x1833ABFF0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x33AC0B0", Offset = "0x33AA8B0", VA = "0x1833AC0B0", Slot = "6")]
	public int IndexOf(To FNHAIFCEKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x33AC120", Offset = "0x33AA920", VA = "0x1833AC120", Slot = "7")]
	public void Insert(int LHHBOCAHDEE, To FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x33AC1A0", Offset = "0x33AA9A0", VA = "0x1833AC1A0", Slot = "15")]
	public bool Remove(To FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x33AC160", Offset = "0x33AA960", VA = "0x1833AC160", Slot = "8")]
	public void RemoveAt(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x1814F40", Offset = "0x1813740", VA = "0x181814F40", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public class ILGJKECMOGN<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly Func<From, To> PLIDKCANPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly Func<To, From> JFMIKHFBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeList<From> HGPMCGJIADE;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public To IOEJBJHPAFG
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
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool PKHIKMNBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	public ILGJKECMOGN(Func<From, To> PLIDKCANPFF, Func<To, From> JFMIKHFBGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] CIMBPHJAHGJ, int BLCDEHFGKBI)
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
	public int IndexOf(To FNHAIFCEKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int LHHBOCAHDEE, To FNHAIFCEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int LHHBOCAHDEE)
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
public static class LOMOOENDHMP
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public const string LDANNJCKOKG = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public const string PJLOMBOCDCO = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const string KHNABIMAFHO = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public const string LBCGOCHFILE = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const string IDOCBCIOAGK = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public const string FOLHEPNGPLG = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public const string CJIGNHMLOOD = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public const string HMAIFPEHJNO = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class KKMMDDEMGJI
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class NHABBDJLFCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public FEIANFNLNIA services;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public NHABBDJLFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x4191000", Offset = "0x418F800", VA = "0x184191000")]
		internal void <InitServices>b__1(HNOABDNADGF svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x4191060", Offset = "0x418F860", VA = "0x184191060")]
		internal void <InitServices>b__2(INBMAMBAHGE svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x31D7B40", Offset = "0x31D6340", VA = "0x1831D7B40")]
	public static void DOBPCMFIDJM(this KPAAIPGAPMC IFJKGEPFDIB, FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x14B8120", Offset = "0x14B6920", VA = "0x1814B8120")]
	public static void AONJLIBMJMI<T>(this KPAAIPGAPMC IFJKGEPFDIB, Action<T> ANBLKGCEOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x14B83C0", Offset = "0x14B6BC0", VA = "0x1814B83C0")]
	public static void IGGBNKPKIEB<T>(this KPAAIPGAPMC IFJKGEPFDIB, Action<T> ANBLKGCEOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x14B8560", Offset = "0x14B6D60", VA = "0x1814B8560")]
	public static void KIDLMOODOHD<T>(this KPAAIPGAPMC IFJKGEPFDIB, Action<T> ANBLKGCEOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x14B88C0", Offset = "0x14B70C0", VA = "0x1814B88C0")]
	public static void NMPFHGJLLPJ<T>(this KPAAIPGAPMC IFJKGEPFDIB, Action<T> ANBLKGCEOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x14B8710", Offset = "0x14B6F10", VA = "0x1814B8710")]
	public static void LBIABALCOLA<T>(this KPAAIPGAPMC IFJKGEPFDIB, Action<T> ANBLKGCEOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x14B8250", Offset = "0x14B6A50", VA = "0x1814B8250")]
	public static void IGGBNKPKIEB<T>(IEnumerable<ComponentSystemBase> CPOMNNHFPBO, Action<T> ANBLKGCEOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x14B8190", Offset = "0x14B6990", VA = "0x1814B8190")]
	private static void DCEKCDECPFA<T>(object NDAAFLCINNI, Action<T> ANBLKGCEOIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class GAFJBINAMKD
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class KPPECCMPJMN
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x31D8210", Offset = "0x31D6A10", VA = "0x1831D8210")]
	public static void BFLGAMGOECL(ComponentSystemBase NDAAFLCINNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class HNLNMLPHIDN
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	public static bool AJIPCBEEDJJ<T>(ref T HDPOKDCLGGE, ref T JBKIIGINOKM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class OHPELLBGHID
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class KDGEGBDGNMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public KDGEGBDGNMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x28A0D70", Offset = "0x289F570", VA = "0x1828A0D70")]
	public static string DJOLCLNOCEE(Transform KPFEIMOAGDN, Transform DJDDCFICJJN)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[IECCMKJMAAC(LAEALBOAPLI.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C9AC60", Offset = "0x2C99460", VA = "0x182C9AC60")]
		public static void ICNICBCAKMK(this NGKBJMLOEKJ BDDMBDBDABJ, JPCPGGKPCML DOJAOGGMBHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B160", Offset = "0x2C99960", VA = "0x182C9B160")]
		public static void NOIDPMIJJNB(this NGKBJMLOEKJ BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C9AE90", Offset = "0x2C99690", VA = "0x182C9AE90")]
		public static void ICNICBCAKMK(this NGKBJMLOEKJ BDDMBDBDABJ, [Optional] string[] NNNEIHLDBKK, [Optional] string[] HHEBLGBGMMB, [Optional] string[] HFEBCIHCLPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9ABB0", Offset = "0x2C993B0", VA = "0x182C9ABB0")]
		public static void HHGCAKAIPPM(this NGKBJMLOEKJ BDDMBDBDABJ, params string[] KGKHDGFPCNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A900", Offset = "0x2C99100", VA = "0x182C9A900")]
		public static void AMCLGKAIEMK(this NGKBJMLOEKJ BDDMBDBDABJ, params string[] KGKHDGFPCNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C9A9B0", Offset = "0x2C991B0", VA = "0x182C9A9B0")]
		private static string[] GICICOILDIK(JPCPGGKPCML DOJAOGGMBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C9AFA0", Offset = "0x2C997A0", VA = "0x182C9AFA0")]
		private static bool MMKIHPEDCEB(JPCPGGKPCML DOJAOGGMBHJ, out string[] DFNCCGFDJDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00")]
		private static bool DOCMJPODNBK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class OPIENNGPMIN : GOEAEACHFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly MethodInfo FFBAHLHHGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Type[] OBPCMKOMOOP;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x28A1F50", Offset = "0x28A0750", VA = "0x1828A1F50")]
	public OPIENNGPMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action CNGLECPDNHB();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x28A1D60", Offset = "0x28A0560", VA = "0x1828A1D60")]
	public MethodInfo JKIMGFIKECP(Action BEHJPKINPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x28A1DA0", Offset = "0x28A05A0", VA = "0x1828A1DA0", Slot = "4")]
	public void OFCCGGLDJKB(Type EHPFPOFFCEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class KFCHKCCIAFF : OPIENNGPMIN
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum DBMDNJBOJED
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x31D7010", Offset = "0x31D5810", VA = "0x1831D7010", Slot = "5")]
	public override Action CNGLECPDNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IKMMPOAJLCH<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x31D70A0", Offset = "0x31D58A0", VA = "0x1831D70A0")]
	[Preserve]
	public void KBEFHJJCNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x31D6300", Offset = "0x31D4B00", VA = "0x1831D6300")]
	protected KFCHKCCIAFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class JLLGFEGFPGD : OPIENNGPMIN
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x31D61E0", Offset = "0x31D49E0", VA = "0x1831D61E0", Slot = "5")]
	public override Action CNGLECPDNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void CCLKKGEEFKN<T>() where T : PBIGLOOMCCA;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x31D6270", Offset = "0x31D4A70", VA = "0x1831D6270")]
	[Preserve]
	public void KBEFHJJCNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x31D6300", Offset = "0x31D4B00", VA = "0x1831D6300")]
	protected JLLGFEGFPGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class JPEOLIFBHNJ : OPIENNGPMIN
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x31D6A30", Offset = "0x31D5230", VA = "0x1831D6A30", Slot = "5")]
	public override Action CNGLECPDNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void MPGPBIBLEDK<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x31D6AC0", Offset = "0x31D52C0", VA = "0x1831D6AC0")]
	[Preserve]
	public void KBEFHJJCNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x31D6300", Offset = "0x31D4B00", VA = "0x1831D6300")]
	protected JPEOLIFBHNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class KMHKHLDCCEB
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x31D8030", Offset = "0x31D6830", VA = "0x1831D8030")]
	public static Entity IHFGGMNIJBB(this EntityManager AIFDIGHJEAF)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[IECCMKJMAAC(LAEALBOAPLI.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class PNDPHJCPMLG : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x25BF9A0", Offset = "0x25BE1A0", VA = "0x1825BF9A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4192AB0", Offset = "0x41912B0", VA = "0x184192AB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x418F3C0", Offset = "0x418DBC0", VA = "0x18418F3C0")]
			[DebuggerHidden]
			public PNDPHJCPMLG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x41928E0", Offset = "0x41910E0", VA = "0x1841928E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x4192A70", Offset = "0x4191270", VA = "0x184192A70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x41929C0", Offset = "0x41911C0", VA = "0x1841929C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x41929C0", Offset = "0x41911C0", VA = "0x1841929C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class JFOCGOHAOOO : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x25BF9A0", Offset = "0x25BE1A0", VA = "0x1825BF9A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x418F290", Offset = "0x418DA90", VA = "0x18418F290", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x418F3C0", Offset = "0x418DBC0", VA = "0x18418F3C0")]
			[DebuggerHidden]
			public JFOCGOHAOOO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x418F2E0", Offset = "0x418DAE0", VA = "0x18418F2E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x418EFB0", Offset = "0x418D7B0", VA = "0x18418EFB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x418F370", Offset = "0x418DB70", VA = "0x18418F370")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x418F250", Offset = "0x418DA50", VA = "0x18418F250", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x418F1A0", Offset = "0x418D9A0", VA = "0x18418F1A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x418F1A0", Offset = "0x418D9A0", VA = "0x18418F1A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class NOCAMALCDIH : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x25BF9A0", Offset = "0x25BE1A0", VA = "0x1825BF9A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x41918C0", Offset = "0x41900C0", VA = "0x1841918C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x418F3C0", Offset = "0x418DBC0", VA = "0x18418F3C0")]
			[DebuggerHidden]
			public NOCAMALCDIH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x4191910", Offset = "0x4190110", VA = "0x184191910", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x41914B0", Offset = "0x418FCB0", VA = "0x1841914B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x41919E0", Offset = "0x41901E0", VA = "0x1841919E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x4191A30", Offset = "0x4190230", VA = "0x184191A30")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x4191880", Offset = "0x4190080", VA = "0x184191880", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x41917E0", Offset = "0x418FFE0", VA = "0x1841917E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x41917E0", Offset = "0x418FFE0", VA = "0x1841917E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x31C4CC0", Offset = "0x31C34C0", VA = "0x1831C4CC0")]
		public static Entity CKBPCMFCCKM(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x31C44C0", Offset = "0x31C2CC0", VA = "0x1831C44C0")]
		public static DynamicBuffer<ChildrenData> ADIKLMDJAMJ(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x31C4760", Offset = "0x31C2F60", VA = "0x1831C4760")]
		public static DynamicBuffer<ChildrenData> BGEPLOHJLHD(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x31C50C0", Offset = "0x31C38C0", VA = "0x1831C50C0")]
		public static NativeArray<Entity> GLMHNPDMNKG(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, Allocator OODGOAPHOCI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x31C5C00", Offset = "0x31C4400", VA = "0x1831C5C00")]
		public static bool OPDLFMBJODK(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, Allocator OODGOAPHOCI, out NativeArray<Entity> HDIKCNPCFHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x31C5320", Offset = "0x31C3B20", VA = "0x1831C5320")]
		public static NativeArray<Entity> HOGCDHLJKOE(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x31C51F0", Offset = "0x31C39F0", VA = "0x1831C51F0")]
		public static Entity HJKEFAKELHJ(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, int LHHBOCAHDEE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x31C5890", Offset = "0x31C4090", VA = "0x1831C5890")]
		public static int NKKPNKDOOCN(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x31C47F0", Offset = "0x31C2FF0", VA = "0x1831C47F0")]
		public static void BGLNMFAPMAD(NativeArray<Entity> OJCGOLJENME, NativeArray<Entity> MDNHGAAHKGD, EntityManager AIFDIGHJEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x31C4F80", Offset = "0x31C3780", VA = "0x1831C4F80")]
		public static int FDAPLBODDKK(this EntityManager AIFDIGHJEAF, Entity FAAJOMIIHED, Entity PLIEEOJAEAM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x31C4A50", Offset = "0x31C3250", VA = "0x1831C4A50")]
		public static bool BIPOOOEDCME(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, Entity NAFEMOBEBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x31C4BB0", Offset = "0x31C33B0", VA = "0x1831C4BB0")]
		public static IEnumerable<Entity> BLHBEIDAIFI(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, bool MEEOIIMCDHN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x31C4ED0", Offset = "0x31C36D0", VA = "0x1831C4ED0")]
		public static bool DODOFFOODPK(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, Entity PLIEEOJAEAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x31C5690", Offset = "0x31C3E90", VA = "0x1831C5690")]
		public static bool LEJLCLKDFHJ(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, Entity GFJEHCBMJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x31C4550", Offset = "0x31C2D50", VA = "0x1831C4550")]
		public static NativeList<Entity> AINPGNLGOJC(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, bool MEEOIIMCDHN = false, Allocator OODGOAPHOCI = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x31C5710", Offset = "0x31C3F10", VA = "0x1831C5710")]
		public static IEnumerable<Entity> LNFGNLEGECP(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, bool MEEOIIMCDHN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x31C5510", Offset = "0x31C3D10", VA = "0x1831C5510")]
		public static Entity JKKPEICCMFG(this EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x31C4D30", Offset = "0x31C3530", VA = "0x1831C4D30")]
		public static bool DGHKOIDPNCJ(this EntityManager AIFDIGHJEAF, Entity GFJEHCBMJMC, Entity FPIHIJPFEDK, out Entity IHHHDHPFGFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x31C5A80", Offset = "0x31C4280", VA = "0x1831C5A80")]
		internal static void NPFPDCKOAOH(EntityManager AIFDIGHJEAF, Entity FAAJOMIIHED, Entity PLIEEOJAEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x31C5B00", Offset = "0x31C4300", VA = "0x1831C5B00")]
		internal static void OINDNLMNHEA(EntityManager AIFDIGHJEAF, Entity FAAJOMIIHED, Entity PLIEEOJAEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x31C5030", Offset = "0x31C3830", VA = "0x1831C5030")]
		[IteratorStateMachine(typeof(PNDPHJCPMLG))]
		private static IEnumerable<Entity> GDHCFLGEALC(EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, bool MEEOIIMCDHN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x31C5480", Offset = "0x31C3C80", VA = "0x1831C5480")]
		[IteratorStateMachine(typeof(JFOCGOHAOOO))]
		private static IEnumerable<Entity> JGCNPFHKCGE(EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, bool MEEOIIMCDHN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x31C5610", Offset = "0x31C3E10", VA = "0x1831C5610")]
		[IteratorStateMachine(typeof(NOCAMALCDIH))]
		private static IEnumerable<Entity> LEEIDABFJLP(EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x31C59A0", Offset = "0x31C41A0", VA = "0x1831C59A0")]
		private static bool NKNGOOBGFIM(EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, Entity NAFEMOBEBGH)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[FIKNCOOOHID(typeof(DLNPACLOKII), new string[] { })]
public class BMHEAJDJCPL : DLNPACLOKII, KJMOLFDIMPO, AAHMCPLHFFN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private FEIANFNLNIA BDDMBDBDABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private HILDNPBHGOE GHFACKFNNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private JDLGCJBNHOE LFOCCHHNJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private DOGGHHKGPAD MIJOBBAGFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private HIFGFPBNEMJ GJCNCJNMMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private HMGEJIKOHBO FLBPGJKFMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private JDDNAJGNJBI AOPMIABPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private DMJNNINNIGH PKFHFCLCCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private IOIEJFCEOCP AIDEINAMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private PGEEIKIHOKG JLJMFAIGCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private HFOOAMMJMIJ DJJGDHCOFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private BJFMFKKFIDI DJBKFAIICIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private KEFOHIEBEBL IBBJDCBMJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private DJIDKBGCOOE EJLKDIDLLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private NMPFDHBEMLP EGJOKIKNCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private AANGANHCBCA KLLEJBNBMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private CBKLFNPDDDI CAABEOPHGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private DGNKJNKENBK FPNDPMNLGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private AMABLJCHDBC FFGPAFCOGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public FEIANFNLNIA BNGGOEBDDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public HILDNPBHGOE BDNKJIMKMII
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public PNONIBNMECP BCCOIHBMLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public JDLGCJBNHOE HNBCNIFDCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DOGGHHKGPAD LEGGCOJOJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public GGNOOGMPGOK EBKOGFGEFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public HIFGFPBNEMJ MHHEPELPLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public HMGEJIKOHBO CMGDBGNELLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6D50D0", Offset = "0x6D38D0", VA = "0x1806D50D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public JDDNAJGNJBI PAOMJPJGJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x6EB760", Offset = "0x6E9F60", VA = "0x1806EB760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public DMJNNINNIGH DLHPGCALBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x6D50B0", Offset = "0x6D38B0", VA = "0x1806D50B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IOIEJFCEOCP HLEJCLDEHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x6EB770", Offset = "0x6E9F70", VA = "0x1806EB770", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public PGEEIKIHOKG BNLGBDNKGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x6EB780", Offset = "0x6E9F80", VA = "0x1806EB780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public HFOOAMMJMIJ MLIFOEEEAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x6EB700", Offset = "0x6E9F00", VA = "0x1806EB700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public BJFMFKKFIDI BNGBDOKGELO
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x6EB710", Offset = "0x6E9F10", VA = "0x1806EB710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public KEFOHIEBEBL APADFNIFNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7116D0", Offset = "0x70FED0", VA = "0x1807116D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public DJIDKBGCOOE CKEKPNMHOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x6DBD80", Offset = "0x6DA580", VA = "0x1806DBD80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public NMPFDHBEMLP BDLPBCKGFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE20", Offset = "0x6DA620", VA = "0x1806DBE20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public AANGANHCBCA KEMJAMEHDDD
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x7116A0", Offset = "0x70FEA0", VA = "0x1807116A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public CBKLFNPDDDI FMOECAILBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB720", Offset = "0x6E9F20", VA = "0x1806EB720", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public DGNKJNKENBK KJJHJBCPKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x6EB730", Offset = "0x6E9F30", VA = "0x1806EB730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public AMABLJCHDBC GDJEMCHDJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x6EB750", Offset = "0x6E9F50", VA = "0x1806EB750", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public FABKOFGEAEO IHCFGGOCMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAA0", Offset = "0x6FA2A0", VA = "0x1806FBAA0", Slot = "21")]
		get
		{
			return default(FABKOFGEAEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A710", Offset = "0x2D08F10", VA = "0x182D0A710", Slot = "22")]
	public void HLHNMHIAHFM(FEIANFNLNIA IDDAFOIOGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x1E23560", Offset = "0x1E21D60", VA = "0x181E23560", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A6F0", Offset = "0x2D08EF0", VA = "0x182D0A6F0", Slot = "23")]
	public void ALBEHPNMNIP(FEIANFNLNIA IDDAFOIOGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BMHEAJDJCPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
public class JIBHEGAEPPH : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class MHDOELPKDJE : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public JIBHEGAEPPH <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6EB790", Offset = "0x6E9F90", VA = "0x1806EB790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4190E20", Offset = "0x418F620", VA = "0x184190E20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public MHDOELPKDJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x4190C70", Offset = "0x418F470", VA = "0x184190C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x4190DE0", Offset = "0x418F5E0", VA = "0x184190DE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected const ulong IDDOMOKJHAP = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected const ulong NBPGLIDGLHM = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected const int LAGBKCHBOPO = 8;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected const int AMKIFIBLBBJ = 6;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public const int NACEAMNAEBM = 64;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected const int JLMEJLILALL = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> GINMCGHNKJK;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BD0", Offset = "0x6D53D0", VA = "0x1806D6BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x779430", Offset = "0x777C30", VA = "0x180779430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int GOGJIKAHCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C90", Offset = "0x6EF490", VA = "0x1806F0C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x779340", Offset = "0x777B40", VA = "0x180779340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x31D52F0", Offset = "0x31D3AF0", VA = "0x1831D52F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x31D4C30", Offset = "0x31D3430", VA = "0x1831D4C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x31D5390", Offset = "0x31D3B90", VA = "0x1831D5390")]
	public JIBHEGAEPPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x31D5410", Offset = "0x31D3C10", VA = "0x1831D5410")]
	public JIBHEGAEPPH(int FEGAPCINCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x31D4A50", Offset = "0x31D3250", VA = "0x1831D4A50")]
	public bool FKMGKLAEDML(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x31D4DE0", Offset = "0x31D35E0", VA = "0x1831D4DE0")]
	public bool HIGBJGAOAIC(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x31D46F0", Offset = "0x31D2EF0", VA = "0x1831D46F0")]
	public bool BKLIMEFFKIP(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x31D4ED0", Offset = "0x31D36D0", VA = "0x1831D4ED0")]
	public bool HOFMIBPEMEM(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x31D4B30", Offset = "0x31D3330", VA = "0x1831D4B30")]
	public void GHGLMENIBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x31D4EE0", Offset = "0x31D36E0", VA = "0x1831D4EE0")]
	public void IFNEIMFKBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x31D4600", Offset = "0x31D2E00", VA = "0x1831D4600")]
	public void BJPKOCBPDKP(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x31D51A0", Offset = "0x31D39A0", VA = "0x1831D51A0")]
	public void MMLFENDEPMM(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x31D5110", Offset = "0x31D3910", VA = "0x1831D5110")]
	public bool LNCJBLPDGGH(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x31D4770", Offset = "0x31D2F70", VA = "0x1831D4770")]
	public void BMILDCJJHHF(int OBHIANFIDPA, int FCKFNIPNJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x31D4890", Offset = "0x31D3090", VA = "0x1831D4890")]
	public void FKMAKEADGGF(int AOKNACFHLEG, int LNDILOLNLJO, int FCKFNIPNJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x31D4FD0", Offset = "0x31D37D0", VA = "0x1831D4FD0")]
	public int LGCDELLOPGJ(int FCKFNIPNJCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x31D50A0", Offset = "0x31D38A0", VA = "0x1831D50A0")]
	public int LGCDELLOPGJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x31D52A0", Offset = "0x31D3AA0", VA = "0x1831D52A0")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x31D4BC0", Offset = "0x31D33C0", VA = "0x1831D4BC0", Slot = "4")]
	[IteratorStateMachine(typeof(MHDOELPKDJE))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x31D4BC0", Offset = "0x31D33C0", VA = "0x1831D4BC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class CNDKJGJCNME<T> : global::GFAMLDEKBGC<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	protected global::AOBIBJNMMMD<T> AAJGLFPMKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected global::AAKJFJHDHGM<T> NDMJEPJMHAN;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x1611780", Offset = "0x160FF80", VA = "0x181611780")]
	public CNDKJGJCNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x28D7DE0", Offset = "0x28D65E0", VA = "0x1828D7DE0")]
	public CNDKJGJCNME(global::AOBIBJNMMMD<T> AAJGLFPMKFO, global::AAKJFJHDHGM<T> NDMJEPJMHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x28D7750", Offset = "0x28D5F50", VA = "0x1828D7750", Slot = "11")]
	public override T JFCMHHFNDFE(DBKADJIJCCK EMAFOIGBLAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x28D7AC0", Offset = "0x28D62C0", VA = "0x1828D7AC0", Slot = "12")]
	public override void ODHIHDMAPDF(DBKADJIJCCK EMAFOIGBLAM, T NPHADDCNBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class GODBKKBMBGO
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x25596C0", Offset = "0x2557EC0", VA = "0x1825596C0")]
	public static OBIAPIAFCLH OFCCGGLDJKB<T>(this PDBKNILAINA AIDEINAMABM, global::PNOGAICEIOC<T> LOIAMCEJAFO, global::AOBIBJNMMMD<T> AAJGLFPMKFO, global::AAKJFJHDHGM<T> NDMJEPJMHAN) where T : struct
	{
		return default(OBIAPIAFCLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class GIAPGKPBMDL<T> : global::CNDKJGJCNME<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x272E730", Offset = "0x272CF30", VA = "0x18272E730")]
	public GIAPGKPBMDL(T BPCHPMCLFBF, T HDHNBDLKAPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class HFIHIHKEMAK<T> : global::GFAMLDEKBGC<T> where T : struct, PBIGLOOMCCA
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x3650890", Offset = "0x364F090", VA = "0x183650890", Slot = "11")]
	public override T JFCMHHFNDFE(DBKADJIJCCK EMAFOIGBLAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x36508E0", Offset = "0x364F0E0", VA = "0x1836508E0", Slot = "12")]
	public override void ODHIHDMAPDF(DBKADJIJCCK EMAFOIGBLAM, T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x25B5720", Offset = "0x25B3F20", VA = "0x1825B5720")]
	public HFIHIHKEMAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class MOHIDFFJANP : GMFKPJBCCAH
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public abstract Type IPDMKKMFCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void JFCMHHFNDFE(DBKADJIJCCK EMAFOIGBLAM, in KMFGGFFJPFH NPHADDCNBHE);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void ODHIHDMAPDF(DBKADJIJCCK EMAFOIGBLAM, in OJMHOIEICMJ NPHADDCNBHE);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void NELPADDHGOD(DBKADJIJCCK EMAFOIGBLAM, HNNHEBBENME MPOCBDEMIGO, [Optional] object CDBJCAAPIOD);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	protected MOHIDFFJANP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class GFAMLDEKBGC<T> : MOHIDFFJANP where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public override Type IPDMKKMFCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x2724C70", Offset = "0x2723470", VA = "0x182724C70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T JFCMHHFNDFE(DBKADJIJCCK EMAFOIGBLAM);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void ODHIHDMAPDF(DBKADJIJCCK EMAFOIGBLAM, T NPHADDCNBHE);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x2725780", Offset = "0x2723F80", VA = "0x182725780", Slot = "8")]
	public override void JFCMHHFNDFE(DBKADJIJCCK EMAFOIGBLAM, in KMFGGFFJPFH DJDDCFICJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x2726970", Offset = "0x2725170", VA = "0x182726970", Slot = "9")]
	public override void ODHIHDMAPDF(DBKADJIJCCK EMAFOIGBLAM, in OJMHOIEICMJ KJFIHMLIKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x2725FF0", Offset = "0x27247F0", VA = "0x182725FF0", Slot = "10")]
	public override void NELPADDHGOD(DBKADJIJCCK EMAFOIGBLAM, HNNHEBBENME MPOCBDEMIGO, object CDBJCAAPIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x149BDE0", Offset = "0x149A5E0", VA = "0x18149BDE0")]
	protected GFAMLDEKBGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class EIBBFLHAIJP
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class OBCOMEKPMME
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class HJOCMPBPKKB<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
			public HJOCMPBPKKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x39E9D80", Offset = "0x39E8580", VA = "0x1839E9D80")]
			internal void <RegisterFixedString>b__0(DBKADJIJCCK p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x39E9F00", Offset = "0x39E8700", VA = "0x1839E9F00")]
			internal T <RegisterFixedString>b__1(DBKADJIJCCK p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x4191A80", Offset = "0x4190280", VA = "0x184191A80")]
		public static void DFLJAGFIHHL(ODIPMFPJCCL PEBIPAKLPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x2CC7D30", Offset = "0x2CC6530", VA = "0x182CC7D30")]
		private static void CEDMOAIJEKG<T>(ODIPMFPJCCL PEBIPAKLPML, int HDHNBDLKAPM) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x2CC84A0", Offset = "0x2CC6CA0", VA = "0x182CC84A0")]
		private static void OICGEGBCABM<T>(DBKADJIJCCK LPBINJHCNHK, T BKHPIBPDKLA, int HDHNBDLKAPM) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x2CC7E50", Offset = "0x2CC6650", VA = "0x182CC7E50")]
		private static T CFMBAOLKDCA<T>(DBKADJIJCCK LPBINJHCNHK, int HDHNBDLKAPM) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public OBCOMEKPMME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class PDFADFOCKFE : KFCHKCCIAFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private ODIPMFPJCCL PEBIPAKLPML;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8530", Offset = "0x2CC6D30", VA = "0x182CC8530", Slot = "6")]
		public override void IKMMPOAJLCH<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x4192490", Offset = "0x4190C90", VA = "0x184192490")]
		public static void DFBFEKMANOE(ODIPMFPJCCL PEBIPAKLPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x4192540", Offset = "0x4190D40", VA = "0x184192540")]
		public PDFADFOCKFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2D23D70", Offset = "0x2D22570", VA = "0x182D23D70")]
	public static void KLCPGLEFHNG(ODIPMFPJCCL PEBIPAKLPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x284ACB0", Offset = "0x28494B0", VA = "0x18284ACB0")]
	public static void AMCNBNKILPF<T>(ODIPMFPJCCL PEBIPAKLPML, global::AOBIBJNMMMD<T> AAJGLFPMKFO, global::AAKJFJHDHGM<T> NDMJEPJMHAN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x284AD40", Offset = "0x2849540", VA = "0x18284AD40")]
	public static void NDNGJPLPMBL<T>(ODIPMFPJCCL PPMEKADMLKD) where T : struct, PBIGLOOMCCA
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
public interface ODIPMFPJCCL : global::FPHDAJLOMBM<ODIPMFPJCCL>
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFCCGGLDJKB(Type EHPFPOFFCEJ, GMFKPJBCCAH PPMEKADMLKD);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKBJHBOCHEL(Type EHPFPOFFCEJ, out GMFKPJBCCAH PPMEKADMLKD);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class PENBLOLCNCG
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x28AF0E0", Offset = "0x28AD8E0", VA = "0x1828AF0E0")]
	public static void OFCCGGLDJKB(this ODIPMFPJCCL NDMKBPHJBKB, GMFKPJBCCAH PPMEKADMLKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[FIKNCOOOHID(typeof(PDBKNILAINA), new string[] { })]
public sealed class GEACJJILHKD : PDBKNILAINA, global::FPHDAJLOMBM<PDBKNILAINA>, BGAFKNOHCIN, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly Dictionary<OBIAPIAFCLH, GMFKPJBCCAH> PEBIPAKLPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private ODIPMFPJCCL BFHJKFAJDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private BMIGPDLOFHL AIDEINAMABM;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool MDEABFHMGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x78F190", Offset = "0x78D990", VA = "0x18078F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x31C92D0", Offset = "0x31C7AD0", VA = "0x1831C92D0")]
	public GEACJJILHKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x31C9210", Offset = "0x31C7A10", VA = "0x1831C9210")]
	public GEACJJILHKD(Dictionary<OBIAPIAFCLH, GMFKPJBCCAH> PEBIPAKLPML, bool LIKCOMFEMHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x31C8AD0", Offset = "0x31C72D0", VA = "0x1831C8AD0", Slot = "7")]
	public void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x31C8B30", Offset = "0x31C7330", VA = "0x1831C8B30", Slot = "8")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x31C9050", Offset = "0x31C7850", VA = "0x1831C9050", Slot = "9")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x31C8BB0", Offset = "0x31C73B0", VA = "0x1831C8BB0", Slot = "4")]
	public OBIAPIAFCLH FGBGCFBFCJH(DMLMOBPCOID LOIAMCEJAFO)
	{
		return default(OBIAPIAFCLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x31C90A0", Offset = "0x31C78A0", VA = "0x1831C90A0", Slot = "5")]
	public void OFCCGGLDJKB(OBIAPIAFCLH MKEJJPNNCOG, GMFKPJBCCAH PPMEKADMLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x31C8F10", Offset = "0x31C7710", VA = "0x1831C8F10")]
	[Conditional("DEBUG_BUILD")]
	private void KHINMOFIACI(OBIAPIAFCLH MKEJJPNNCOG, Type EHPFPOFFCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x31C8D60", Offset = "0x31C7560", VA = "0x1831C8D60", Slot = "6")]
	public bool GKBJHBOCHEL(OBIAPIAFCLH MKEJJPNNCOG, out GMFKPJBCCAH PPMEKADMLKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x31C8C80", Offset = "0x31C7480", VA = "0x1831C8C80", Slot = "10")]
	public PDBKNILAINA FPAKHMIGFHO()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[FIKNCOOOHID(typeof(ODIPMFPJCCL), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.TypeSerializer)]
	public sealed class TypeSerializerService : BGAFKNOHCIN, ODIPMFPJCCL, global::FPHDAJLOMBM<ODIPMFPJCCL>
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly Dictionary<Type, GMFKPJBCCAH> PEBIPAKLPML;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool MDEABFHMGIA
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8D0", Offset = "0x6EE0D0", VA = "0x1806EF8D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x711000", Offset = "0x70F800", VA = "0x180711000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA57F0", Offset = "0x2CA3FF0", VA = "0x182CA57F0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5870", Offset = "0x2CA4070", VA = "0x182CA5870")]
		public TypeSerializerService(Dictionary<Type, GMFKPJBCCAH> PEBIPAKLPML, bool LIKCOMFEMHF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5460", Offset = "0x2CA3C60", VA = "0x182CA5460", Slot = "4")]
		public void CDCHANKPBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5680", Offset = "0x2CA3E80", VA = "0x182CA5680", Slot = "5")]
		public void OFCCGGLDJKB(Type EHPFPOFFCEJ, GMFKPJBCCAH PPMEKADMLKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2CA55A0", Offset = "0x2CA3DA0", VA = "0x182CA55A0", Slot = "6")]
		public bool GKBJHBOCHEL(Type EHPFPOFFCEJ, out GMFKPJBCCAH PPMEKADMLKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2CA54C0", Offset = "0x2CA3CC0", VA = "0x182CA54C0", Slot = "7")]
		public ODIPMFPJCCL FPAKHMIGFHO()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[FIKNCOOOHID(typeof(HOECGMOPFDA), new string[] { })]
internal sealed class IOOLDMPIPKO : HOECGMOPFDA, BGAFKNOHCIN, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<OBIAPIAFCLH, ALHBGCAIMEC> HLPNHLOLOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private BMIGPDLOFHL AIDEINAMABM;

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x31D2810", Offset = "0x31D1010", VA = "0x1831D2810", Slot = "6")]
	public void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x31D2860", Offset = "0x31D1060", VA = "0x1831D2860", Slot = "7")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x31D2AC0", Offset = "0x31D12C0", VA = "0x1831D2AC0", Slot = "4")]
	public void OFCCGGLDJKB(OBIAPIAFCLH GCAANJILJJP, Type HODJPMMBLOH, ALHBGCAIMEC AFLHEEMEKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x31D28C0", Offset = "0x31D10C0", VA = "0x1831D28C0", Slot = "5")]
	public bool KBPFHMNGAIE(OBIAPIAFCLH GCAANJILJJP, out ALHBGCAIMEC AFLHEEMEKHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x31D2930", Offset = "0x31D1130", VA = "0x1831D2930")]
	[Conditional("DEBUG_BUILD")]
	private void MBFNHPBPKDL(OBIAPIAFCLH GCAANJILJJP, Type HODJPMMBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x31D2B30", Offset = "0x31D1330", VA = "0x1831D2B30")]
	public IOOLDMPIPKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[FIKNCOOOHID(typeof(JNKLNICJBMH), new string[] { })]
internal sealed class ABDHGHPMJHN : JNKLNICJBMH, DAANNPIBALJ, BGAFKNOHCIN, HNOABDNADGF, INBMAMBAHGE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly JIBHEGAEPPH OPBPMEIBCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly Dictionary<IOAGKMCGKAI, int> KCPCIFBKLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Stack<int> NJMIFNDBMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[EOIIILOBJAK]
	private BMIGPDLOFHL AIDEINAMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[EOIIILOBJAK]
	private GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private int LGIGCHEAIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D063D0", Offset = "0x2D04BD0", VA = "0x182D063D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool NELKOMOKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7A0560", Offset = "0x79ED60", VA = "0x1807A0560", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x936400", Offset = "0x934C00", VA = "0x180936400", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D05F60", Offset = "0x2D04760", VA = "0x182D05F60", Slot = "6")]
	public void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D06070", Offset = "0x2D04870", VA = "0x182D06070", Slot = "7")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D05EB0", Offset = "0x2D046B0", VA = "0x182D05EB0", Slot = "8")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D06420", Offset = "0x2D04C20", VA = "0x182D06420")]
	private void IDNMFIKJGNH(FJJPMAIFPPM AIOPADAFDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D06310", Offset = "0x2D04B10", VA = "0x182D06310", Slot = "4")]
	public bool HBDGCKCHILL(IOAGKMCGKAI DGNLFFKHMAE, OBIAPIAFCLH NPCKPCNEDPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D060F0", Offset = "0x2D048F0", VA = "0x182D060F0", Slot = "5")]
	public void HADOEHFHHMG(IOAGKMCGKAI DGNLFFKHMAE, Span<OBIAPIAFCLH> AIDEINAMABM, bool IBPJMGBOBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D05F60", Offset = "0x2D04760", VA = "0x182D05F60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D064C0", Offset = "0x2D04CC0", VA = "0x182D064C0")]
	public ABDHGHPMJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class CNILLEMPOFH
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E7B0", Offset = "0x2D0CFB0", VA = "0x182D0E7B0")]
	public static void DPBGDFLELKG(this DBKADJIJCCK EMAFOIGBLAM, ReadOnlyMemory<byte> PECKCBMGIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F363B0", Offset = "0x1F34BB0", VA = "0x181F363B0")]
	public static void IGHCIFCIEBF<T>(this DBKADJIJCCK EMAFOIGBLAM, in T NPHADDCNBHE) where T : struct, PBIGLOOMCCA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x1F364E0", Offset = "0x1F34CE0", VA = "0x181F364E0")]
	public static T KMDIDNNBKHC<T>(this DBKADJIJCCK EMAFOIGBLAM) where T : struct, PBIGLOOMCCA
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E830", Offset = "0x2D0D030", VA = "0x182D0E830")]
	public static void IGHCIFCIEBF(this DBKADJIJCCK EMAFOIGBLAM, NDIJCAPJGGJ FPHBPOPDAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E660", Offset = "0x2D0CE60", VA = "0x182D0E660")]
	public static NDIJCAPJGGJ BEACCOPMAFM(this DBKADJIJCCK EMAFOIGBLAM)
	{
		return default(NDIJCAPJGGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E860", Offset = "0x2D0D060", VA = "0x182D0E860")]
	public static void LHGFGMJMMOP(this DBKADJIJCCK IJMHHNEJPMM, uint AHCDGBJNMPH, bool ICEJHAAMMCC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E690", Offset = "0x2D0CE90", VA = "0x182D0E690")]
	public static uint DBBEBDGLFNH(this DBKADJIJCCK AODHOCAKPON, bool ICEJHAAMMCC = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class KKCLPNFJLOL
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class FJCKDPEKNKD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public FJCKDPEKNKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B520", Offset = "0x2C79D20", VA = "0x182C7B520")]
		internal void <GetByteEnumDelegates>b__0(DBKADJIJCCK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B590", Offset = "0x2C79D90", VA = "0x182C7B590")]
		internal T <GetByteEnumDelegates>b__1(DBKADJIJCCK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class OCPCBHOBGEA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public OCPCBHOBGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x36A9960", Offset = "0x36A8160", VA = "0x1836A9960")]
		internal void <GetSByteEnumDelegates>b__0(DBKADJIJCCK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x36A99D0", Offset = "0x36A81D0", VA = "0x1836A99D0")]
		internal T <GetSByteEnumDelegates>b__1(DBKADJIJCCK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class KNGMPCAFPMP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public KNGMPCAFPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A35D50", Offset = "0x2A34550", VA = "0x182A35D50")]
		internal void <GetShortEnumDelegates>b__0(DBKADJIJCCK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A35DC0", Offset = "0x2A345C0", VA = "0x182A35DC0")]
		internal T <GetShortEnumDelegates>b__1(DBKADJIJCCK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class PODDDDEMJFJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public PODDDDEMJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x310A5B0", Offset = "0x3108DB0", VA = "0x18310A5B0")]
		internal void <GetUShortEnumDelegates>b__0(DBKADJIJCCK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x310A620", Offset = "0x3108E20", VA = "0x18310A620")]
		internal T <GetUShortEnumDelegates>b__1(DBKADJIJCCK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class GIHGJOAEDEG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public GIHGJOAEDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x272E950", Offset = "0x272D150", VA = "0x18272E950")]
		internal void <GetIntEnumDelegates>b__0(DBKADJIJCCK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x272E9B0", Offset = "0x272D1B0", VA = "0x18272E9B0")]
		internal T <GetIntEnumDelegates>b__1(DBKADJIJCCK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class OBMMCHEDBAM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public OBMMCHEDBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x36A80F0", Offset = "0x36A68F0", VA = "0x1836A80F0")]
		internal void <GetUIntEnumDelegates>b__0(DBKADJIJCCK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x36A8150", Offset = "0x36A6950", VA = "0x1836A8150")]
		internal T <GetUIntEnumDelegates>b__1(DBKADJIJCCK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x14B7DB0", Offset = "0x14B65B0", VA = "0x1814B7DB0")]
	public static void FIKPFDGJHKB<T>(T BPCHPMCLFBF, T HDHNBDLKAPM, out global::AOBIBJNMMMD<T> BIEGGDLAABK, out global::AAKJFJHDHGM<T> DEJNFOIAMOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x14B7C60", Offset = "0x14B6460", VA = "0x1814B7C60")]
	private static void EDEPKHNCAAI<T>(T BPCHPMCLFBF, T HDHNBDLKAPM, out global::AOBIBJNMMMD<T> BIEGGDLAABK, out global::AAKJFJHDHGM<T> DEJNFOIAMOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x14B7C60", Offset = "0x14B6460", VA = "0x1814B7C60")]
	private static void NPCKJEELFAA<T>(T BPCHPMCLFBF, T HDHNBDLKAPM, out global::AOBIBJNMMMD<T> BIEGGDLAABK, out global::AAKJFJHDHGM<T> DEJNFOIAMOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x14B7B10", Offset = "0x14B6310", VA = "0x1814B7B10")]
	private static void AHKEKAIKHDC<T>(T BPCHPMCLFBF, T HDHNBDLKAPM, out global::AOBIBJNMMMD<T> BIEGGDLAABK, out global::AAKJFJHDHGM<T> DEJNFOIAMOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x14B7B10", Offset = "0x14B6310", VA = "0x1814B7B10")]
	private static void ACCFKDKAADE<T>(T BPCHPMCLFBF, T HDHNBDLKAPM, out global::AOBIBJNMMMD<T> BIEGGDLAABK, out global::AAKJFJHDHGM<T> DEJNFOIAMOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x14B7FD0", Offset = "0x14B67D0", VA = "0x1814B7FD0")]
	private static void IAKPEBDOCKG<T>(T BPCHPMCLFBF, T HDHNBDLKAPM, out global::AOBIBJNMMMD<T> BIEGGDLAABK, out global::AAKJFJHDHGM<T> DEJNFOIAMOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x14B7FD0", Offset = "0x14B67D0", VA = "0x1814B7FD0")]
	private static void GOCLBENJIOJ<T>(T BPCHPMCLFBF, T HDHNBDLKAPM, out global::AOBIBJNMMMD<T> BIEGGDLAABK, out global::AAKJFJHDHGM<T> DEJNFOIAMOM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class EJHMHKJKOIC : FOKEMBEEBHE, INBMAMBAHGE
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x31BF620", Offset = "0x31BDE20", VA = "0x1831BF620", Slot = "4")]
	private void OCBFOIKAAFC(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void PKALPBFOCBJ(PDBKNILAINA AIDEINAMABM);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
	protected EJHMHKJKOIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[IIFGFLKKOJA(typeof(LocalPoseData))]
public sealed class MNKDLBBKMHP : EJHMHKJKOIC
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x289D080", Offset = "0x289B880", VA = "0x18289D080", Slot = "5")]
	protected override void PKALPBFOCBJ(PDBKNILAINA AIDEINAMABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20")]
	public MNKDLBBKMHP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	internal class CopyAuthorityToEntity : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery EINPBMJKBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery DAJNLLEJKIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery BNEOLCEBBOK;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2D16D80", Offset = "0x2D15580", VA = "0x182D16D80", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2D17630", Offset = "0x2D15E30", VA = "0x182D17630", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2D177B0", Offset = "0x2D15FB0", VA = "0x182D177B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2D17780", Offset = "0x2D15F80", VA = "0x182D17780", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2D16960", Offset = "0x2D15160", VA = "0x182D16960")]
		private void AIFAJLBMBDP(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2D16DF0", Offset = "0x2D155F0", VA = "0x182D16DF0")]
		private void GGFFONIJPII(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2D16F90", Offset = "0x2D15790", VA = "0x182D16F90")]
		private void IINJEACHDPA(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2D17270", Offset = "0x2D15A70", VA = "0x182D17270")]
		private void KNFBIHEGIMJ(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2D17420", Offset = "0x2D15C20", VA = "0x182D17420")]
		private void LAECGLFGEPC(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2D16CA0", Offset = "0x2D154A0", VA = "0x182D16CA0")]
		private void BBEMKDLIBFK(FJJPMAIFPPM AIOPADAFDKL, int EBHCCAJEKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class FOCIMJHOCCN : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityQuery PPFDACOOOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private HILDNPBHGOE GHFACKFNNLB;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x31C6610", Offset = "0x31C4E10", VA = "0x1831C6610", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x31C6C40", Offset = "0x31C5440", VA = "0x1831C6C40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x31C6D00", Offset = "0x31C5500", VA = "0x1831C6D00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x31C6660", Offset = "0x31C4E60", VA = "0x1831C6660")]
	private void MMDKBOEPPAB(NativeArray<Entity> NBDCDJJEKHD, NativeList<Entity> HCAAMEFIBOC, ComponentDataFromEntity<FKMMCFMAKDG> AIPLBHNCMMJ, BufferFromEntity<ChildrenData> FKKAIMLDIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public FOCIMJHOCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class MDPNCCEGGBH : ParentSystemBase<AuthoredParentData, KGHDABGCNFM, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2898D30", Offset = "0x2897530", VA = "0x182898D30", Slot = "14")]
	protected override EntityQueryDesc MPBJAOFOCPJ(EntityQueryDesc PPFDACOOOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x7806D0", Offset = "0x77EED0", VA = "0x1807806D0", Slot = "15")]
	protected override EntityQueryDesc JNHFJGGPHFC(EntityQueryDesc PPFDACOOOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2898DF0", Offset = "0x28975F0", VA = "0x182898DF0", Slot = "16")]
	protected override EntityQueryDesc PNODGLAICJC(EntityQueryDesc PPFDACOOOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x2898D70", Offset = "0x2897570", VA = "0x182898D70", Slot = "17")]
	protected override EntityQueryDesc OOBBGHMHNIO(EntityQueryDesc PPFDACOOOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x2898E30", Offset = "0x2897630", VA = "0x182898E30")]
	public MDPNCCEGGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2898DB0", Offset = "0x28975B0", VA = "0x182898DB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class KBAJLJMDEIF : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EntityQuery PPFDACOOOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private object KFNBHJEIAAC;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x31D6C70", Offset = "0x31D5470", VA = "0x1831D6C70", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x31D6CF0", Offset = "0x31D54F0", VA = "0x1831D6CF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x31D6D90", Offset = "0x31D5590", VA = "0x1831D6D90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public KBAJLJMDEIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class OPPAKNNOPNB : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery PPFDACOOOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private object KFNBHJEIAAC;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x28A2000", Offset = "0x28A0800", VA = "0x1828A2000", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x28A2080", Offset = "0x28A0880", VA = "0x1828A2080", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x28A2120", Offset = "0x28A0920", VA = "0x1828A2120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public OPPAKNNOPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(1)]
internal struct ILNPAGFKMHI : ISystemStateBufferElementData, IBufferElementData, IEquatable<ILNPAGFKMHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public HKPBHJBDAGP AEGKMFNDGLH;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x31CD1D0", Offset = "0x31CB9D0", VA = "0x1831CD1D0", Slot = "4")]
	public bool Equals(ILNPAGFKMHI HAKPJJGEGOM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E20", Offset = "0x7F2620", VA = "0x1807F3E20")]
	public static ILNPAGFKMHI AGJOPELLCGM(HKPBHJBDAGP AEGKMFNDGLH)
	{
		return default(ILNPAGFKMHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(4)]
internal struct APAOOHPDOPK : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public HKPBHJBDAGP AEGKMFNDGLH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E20", Offset = "0x7F2620", VA = "0x1807F3E20")]
	public static APAOOHPDOPK AGJOPELLCGM(HKPBHJBDAGP AEGKMFNDGLH)
	{
		return default(APAOOHPDOPK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class MBHKABCGODH : JBMBOANCHEG
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x31DD7A0", Offset = "0x31DBFA0", VA = "0x1831DD7A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x31DD930", Offset = "0x31DC130", VA = "0x1831DD930", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	protected MBHKABCGODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[HCBICNINHAE]
internal abstract class JBMBOANCHEG : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	protected EntityQuery PPFDACOOOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected AMABLJCHDBC FFGPAFCOGJA;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected abstract FDGAMHLOIKI FNKBPEOLDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x31D2EF0", Offset = "0x31D16F0", VA = "0x1831D2EF0", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x31D2F60", Offset = "0x31D1760", VA = "0x1831D2F60")]
	protected void MAADFNPKGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x31D31E0", Offset = "0x31D19E0", VA = "0x1831D31E0")]
	protected void MALBBPJCNCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x31D3460", Offset = "0x31D1C60", VA = "0x1831D3460")]
	protected HPJLDICLHHD MCOHPGNECJD()
	{
		return default(HPJLDICLHHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	protected JBMBOANCHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class OJJMMHFDBAC : JBMBOANCHEG
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F30", Offset = "0x289F730", VA = "0x1828A0F30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x28A10C0", Offset = "0x289F8C0", VA = "0x1828A10C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x289B120", Offset = "0x2899920", VA = "0x18289B120")]
	protected OJJMMHFDBAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class BJFCDMBJHFJ : JBMBOANCHEG
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A4F0", Offset = "0x2D08CF0", VA = "0x182D0A4F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A600", Offset = "0x2D08E00", VA = "0x182D0A600", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x289B120", Offset = "0x2899920", VA = "0x18289B120")]
	protected BJFCDMBJHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class MKMLJMNEAHM : MBHKABCGODH
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override FDGAMHLOIKI FNKBPEOLDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x289B0B0", Offset = "0x28998B0", VA = "0x18289B0B0", Slot = "15")]
		get
		{
			return default(FDGAMHLOIKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x289B120", Offset = "0x2899920", VA = "0x18289B120")]
	public MKMLJMNEAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class LJIPCDOCIHC : OJJMMHFDBAC
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override FDGAMHLOIKI FNKBPEOLDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x31DB910", Offset = "0x31DA110", VA = "0x1831DB910", Slot = "15")]
		get
		{
			return default(FDGAMHLOIKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x31CC040", Offset = "0x31CA840", VA = "0x1831CC040")]
	public LJIPCDOCIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class HHEINAMLOOL : BJFCDMBJHFJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override FDGAMHLOIKI FNKBPEOLDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x31CBFD0", Offset = "0x31CA7D0", VA = "0x1831CBFD0", Slot = "15")]
		get
		{
			return default(FDGAMHLOIKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x31CC040", Offset = "0x31CA840", VA = "0x1831CC040")]
	public HHEINAMLOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class NPLDEKELIAO : MBHKABCGODH
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected override FDGAMHLOIKI FNKBPEOLDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x289F8D0", Offset = "0x289E0D0", VA = "0x18289F8D0", Slot = "15")]
		get
		{
			return default(FDGAMHLOIKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x289B120", Offset = "0x2899920", VA = "0x18289B120")]
	public NPLDEKELIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class HMDIJLCAMBE : OJJMMHFDBAC
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected override FDGAMHLOIKI FNKBPEOLDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x31CD270", Offset = "0x31CBA70", VA = "0x1831CD270", Slot = "15")]
		get
		{
			return default(FDGAMHLOIKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x31CC040", Offset = "0x31CA840", VA = "0x1831CC040")]
	public HMDIJLCAMBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class DGDIFDCIJCN : BJFCDMBJHFJ
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected override FDGAMHLOIKI FNKBPEOLDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B4B0", Offset = "0x2D19CB0", VA = "0x182D1B4B0", Slot = "15")]
		get
		{
			return default(FDGAMHLOIKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x289B120", Offset = "0x2899920", VA = "0x18289B120")]
	public DGDIFDCIJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct HFEAMJLOFMK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct BJAEOIPDACG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct FNBPBJLNGKK : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct FDGAMHLOIKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly ComponentType AALFJMIGODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly ComponentType EPMEOOLFFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly object JPCLKLIDFBB;

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x31C5D90", Offset = "0x31C4590", VA = "0x1831C5D90")]
	public FDGAMHLOIKI(ComponentType AALFJMIGODJ, ComponentType EPMEOOLFFCO, object JPCLKLIDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x268A560", Offset = "0x2688D60", VA = "0x18268A560")]
	public static FDGAMHLOIKI AMBBLJNNNML<TReq, TTag>(object JPCLKLIDFBB)
	{
		return default(FDGAMHLOIKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class PBOEGKDGPIE
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public const string IGJMGIMDBIE = "Parented";

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public const string IJBHNMMKCIG = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly FDGAMHLOIKI KEMJAMEHDDD;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly FDGAMHLOIKI NMDONGIPAEJ;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct HKPBHJBDAGP : global::DOCOAIDEBOB<HKPBHJBDAGP>, NHMOKLKPBCB, IEquatable<HKPBHJBDAGP>
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int FPGJPBIHINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x786DB0", Offset = "0x7855B0", VA = "0x180786DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int JAFPKKDIEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x89E550", Offset = "0x89CD50", VA = "0x18089E550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xDD7530", Offset = "0xDD5D30", VA = "0x180DD7530", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool HOFMIBPEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x31CD190", Offset = "0x31CB990", VA = "0x1831CD190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x31CD1D0", Offset = "0x31CB9D0", VA = "0x1831CD1D0", Slot = "8")]
	public bool Equals(HKPBHJBDAGP HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x31CD220", Offset = "0x31CBA20", VA = "0x1831CD220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[HCBICNINHAE]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.Connectables)]
	public class UpdateConnectableVisuals : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct NHDKOMHCJHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public HKPBHJBDAGP AEGKMFNDGLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public float3 LMLCHIPKJPI;

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x41910E0", Offset = "0x418F8E0", VA = "0x1841910E0")]
			public NHDKOMHCJHG(HKPBHJBDAGP AEGKMFNDGLH, float3 LMLCHIPKJPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x41910C0", Offset = "0x418F8C0", VA = "0x1841910C0")]
			public void NEMBEEBJDEF(out HKPBHJBDAGP AEGKMFNDGLH, out float3 LMLCHIPKJPI)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct BCJPANOEHOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<NHDKOMHCJHG> list;

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
			public BCJPANOEHOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<APAOOHPDOPK> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct GKPDDPLHCAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeList<NHDKOMHCJHG> list;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
			public GKPDDPLHCAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<ILNPAGFKMHI> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct DNECMMLEGEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<NHDKOMHCJHG> list;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
			public DNECMMLEGEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in GMDCJILBHEJ com, in DynamicBuffer<ILNPAGFKMHI> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct CPMAHCFBBBA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct HPEOMGALEGK
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				public struct OBOPPEDOLGK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					public LambdaParameterValueProvider_Entity.Runtime MJCEIKBJNFK;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime LBIMPJDLJCL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public LambdaParameterValueProvider_DynamicBuffer<APAOOHPDOPK>.Runtime KBMJNBOCILB;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CE")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity FICCJLGCPHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002CF")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> KGCIEJECIBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<APAOOHPDOPK> HIKPMGDIKFA;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x418E440", Offset = "0x418CC40", VA = "0x18418E440")]
				public void OFCJMCDBAHD(UpdateConnectableVisuals IFHEBKPGABD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x418E380", Offset = "0x418CB80", VA = "0x18418E380")]
				public OBOPPEDOLGK FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
				{
					return default(OBOPPEDOLGK);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public UpdateConnectableVisuals BBOKJPLALNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public NativeList<NHDKOMHCJHG> HGPMCGJIADE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private HPEOMGALEGK KGMAGAHIKDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HPEOMGALEGK.OBOPPEDOLGK* KCHPJLFDFOM;

			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KJFGNIEDIHO;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x4189F90", Offset = "0x4188790", VA = "0x184189F90")]
			internal void PKEFIBJCKKH(Entity DJGIAPPGDDP, WorldPoseData EBHKJMKLCHM, in DynamicBuffer<APAOOHPDOPK> DMJFIAAGODA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x418A1D0", Offset = "0x41889D0", VA = "0x18418A1D0", Slot = "5")]
			public void ReadFromDisplayClass(ref BCJPANOEHOB NACAPKCDIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x418A200", Offset = "0x4188A00", VA = "0x18418A200", Slot = "6")]
			public void WriteToDisplayClass(ref BCJPANOEHOB NACAPKCDIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x4189D30", Offset = "0x4188530", VA = "0x184189D30", Slot = "4")]
			public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x4189E10", Offset = "0x4188610", VA = "0x184189E10")]
			public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, ref HPEOMGALEGK.OBOPPEDOLGK APIMNOLFLFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x4189F50", Offset = "0x4188750", VA = "0x184189F50")]
			public void OFCJMCDBAHD(UpdateConnectableVisuals IFHEBKPGABD, ref BCJPANOEHOB NACAPKCDIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x4189CC0", Offset = "0x41884C0", VA = "0x184189CC0")]
			public unsafe static void ALMKLGDMEPG(ArchetypeChunkIterator* BNBLIJPHBIB, void* DHBLLJAGKCG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct GBFELKLNDLI : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct HKILPEEHLAN
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct HDGDGDECNOH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime LBIMPJDLJCL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<ILNPAGFKMHI>.Runtime KBMJNBOCILB;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> KGCIEJECIBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<ILNPAGFKMHI> HIKPMGDIKFA;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x418E310", Offset = "0x418CB10", VA = "0x18418E310")]
				public void OFCJMCDBAHD(UpdateConnectableVisuals IFHEBKPGABD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x418E270", Offset = "0x418CA70", VA = "0x18418E270")]
				public HDGDGDECNOH FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
				{
					return default(HDGDGDECNOH);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NativeList<NHDKOMHCJHG> HGPMCGJIADE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private HKILPEEHLAN KGMAGAHIKDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HKILPEEHLAN.HDGDGDECNOH* KCHPJLFDFOM;

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x418D8E0", Offset = "0x418C0E0", VA = "0x18418D8E0")]
			internal void PKEFIBJCKKH(in WorldPoseData EBHKJMKLCHM, in DynamicBuffer<ILNPAGFKMHI> DMJFIAAGODA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x15A2980", Offset = "0x15A1180", VA = "0x1815A2980", Slot = "5")]
			public void ReadFromDisplayClass(ref GKPDDPLHCAH NACAPKCDIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x418D6A0", Offset = "0x418BEA0", VA = "0x18418D6A0", Slot = "4")]
			public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x418D770", Offset = "0x418BF70", VA = "0x18418D770")]
			public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, [NoAlias] ref HKILPEEHLAN.HDGDGDECNOH APIMNOLFLFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x418D840", Offset = "0x418C040", VA = "0x18418D840")]
			public void OFCJMCDBAHD(UpdateConnectableVisuals IFHEBKPGABD, ref GKPDDPLHCAH NACAPKCDIHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LMMJKMLBENC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			private struct CIELLFPOCHO
			{
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				[NoAlias]
				public struct IODPJFNFPFE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime LBIMPJDLJCL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<GMDCJILBHEJ>.Runtime ANDPELNNHBE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002E3")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<ILNPAGFKMHI>.Runtime KBMJNBOCILB;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> KGCIEJECIBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<GMDCJILBHEJ> KHCLIJFDFDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<ILNPAGFKMHI> HIKPMGDIKFA;

				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x4188F50", Offset = "0x4187750", VA = "0x184188F50")]
				public void OFCJMCDBAHD(UpdateConnectableVisuals IFHEBKPGABD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x4188E80", Offset = "0x4187680", VA = "0x184188E80")]
				public IODPJFNFPFE FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
				{
					return default(IODPJFNFPFE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<NHDKOMHCJHG> HGPMCGJIADE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private CIELLFPOCHO KGMAGAHIKDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe CIELLFPOCHO.IODPJFNFPFE* KCHPJLFDFOM;

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x41906D0", Offset = "0x418EED0", VA = "0x1841906D0")]
			internal void PKEFIBJCKKH(in WorldPoseData EBHKJMKLCHM, in GMDCJILBHEJ BBNAFIFIAGE, in DynamicBuffer<ILNPAGFKMHI> DMJFIAAGODA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x15A2980", Offset = "0x15A1180", VA = "0x1815A2980", Slot = "5")]
			public void ReadFromDisplayClass(ref DNECMMLEGEG NACAPKCDIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x41904F0", Offset = "0x418ECF0", VA = "0x1841904F0", Slot = "4")]
			public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x4190570", Offset = "0x418ED70", VA = "0x184190570")]
			public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, [NoAlias] ref CIELLFPOCHO.IODPJFNFPFE APIMNOLFLFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x4190690", Offset = "0x418EE90", VA = "0x184190690")]
			public void OFCJMCDBAHD(UpdateConnectableVisuals IFHEBKPGABD, ref DNECMMLEGEG NACAPKCDIHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery NANCABEILFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery NDDECDFMJHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery FLNLHFFPPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery JHCHLANEAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery OEIALFBDCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery DOKONFKNFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery OIPLPDDJIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery AOBGLHJIJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery EBAJAGDCPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery ANAOIPKFFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private global::IBOAEEDDPMB<HKPBHJBDAGP, DNBMKFELOBN> KLKGEIOHKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private DGNKJNKENBK FPNDPMNLGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private BJFMFKKFIDI DJBKFAIICIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private JCEENFFJBGN DAKCGNKEOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery GOIHNNIHMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ProfilerMarker CPIMNHLBCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery DCOJMGHFJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery HNAACDNAGFJ;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int EIFLHBHGPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2CA6800", Offset = "0x2CA5000", VA = "0x182CA6800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2CA80E0", Offset = "0x2CA68E0", VA = "0x182CA80E0")]
		internal DNBMKFELOBN GBMIMOBCGOJ(HKPBHJBDAGP AEGKMFNDGLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2CA76A0", Offset = "0x2CA5EA0", VA = "0x182CA76A0", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2CA99C0", Offset = "0x2CA81C0", VA = "0x182CA99C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9C40", Offset = "0x2CA8440", VA = "0x182CA9C40", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9DD0", Offset = "0x2CA85D0", VA = "0x182CA9DD0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9C00", Offset = "0x2CA8400", VA = "0x182CA9C00", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8B30", Offset = "0x2CA7330", VA = "0x182CA8B30")]
		private void JBPLJECCPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2CA83C0", Offset = "0x2CA6BC0", VA = "0x182CA83C0")]
		private void INKDIANAONH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7AC0", Offset = "0x2CA62C0", VA = "0x182CA7AC0")]
		private void EIBBEINBEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9E10", Offset = "0x2CA8610", VA = "0x182CA9E10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA68A0", Offset = "0x2CA50A0", VA = "0x182CA68A0")]
		private void CEKLEBHDAHA(EntityQuery EINPBMJKBLI, EntityQuery CKDDIDABPBA, EntityQuery DAJNLLEJKIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5FA0", Offset = "0x2CA47A0", VA = "0x182CA5FA0")]
		private void ALIFOBNBCOA(EntityQuery DAJNLLEJKIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8F30", Offset = "0x2CA7730", VA = "0x182CA8F30")]
		private void NDFKIKFCDFB(NativeArrayAsync<Entity> HNAAEFOPOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA0D0", Offset = "0x2CA88D0", VA = "0x182CAA0D0")]
		private void PIDLACFFKAK(NativeArrayAsync<Entity> BGOKJALEHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA96C0", Offset = "0x2CA7EC0", VA = "0x182CA96C0")]
		private void ODLCOLODLFK(NativeArrayAsync<Entity> IAAJCEMDPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7530", Offset = "0x2CA5D30", VA = "0x182CA7530")]
		private void CJPCIBGDHHH(NativeList<HKPBHJBDAGP> LOCPJDELJCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6D80", Offset = "0x2CA5580", VA = "0x182CA6D80")]
		private NativeList<HKPBHJBDAGP> CIPMCONCFAH(NativeArray<Entity> NBDCDJJEKHD)
		{
			return default(NativeList<HKPBHJBDAGP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8510", Offset = "0x2CA6D10", VA = "0x182CA8510")]
		private void INMKOFAAHLK(NativeArray<Entity> NBDCDJJEKHD, NativeList<HKPBHJBDAGP> LOCPJDELJCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6070", Offset = "0x2CA4870", VA = "0x182CA6070")]
		private void ALKPPDMMIBL(NativeArray<Entity> OBMOMMGGILJ, NativeArray<Entity> BFCODBKMDGL, NativeList<HKPBHJBDAGP> NJMIFNDBMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9210", Offset = "0x2CA7A10", VA = "0x182CA9210")]
		private void NJDCOPDNNJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA1E0", Offset = "0x2CA89E0", VA = "0x182CAA1E0")]
		private NativeListAsync<NHDKOMHCJHG> PJAEIIOMBIO(EntityQuery PPFDACOOOGO, Func<NativeList<NHDKOMHCJHG>, JobHandle> BNEMLKEBNPB)
		{
			return default(NativeListAsync<NHDKOMHCJHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9F40", Offset = "0x2CA8740", VA = "0x182CA9F40")]
		private JobHandle PCLNHOGJOKD(NativeList<NHDKOMHCJHG> HGPMCGJIADE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5E60", Offset = "0x2CA4660", VA = "0x182CA5E60")]
		private JobHandle AAKAPAJAOEK(NativeList<NHDKOMHCJHG> HGPMCGJIADE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8C40", Offset = "0x2CA7440", VA = "0x182CA8C40")]
		private JobHandle KLPJBMEMGMD(NativeList<NHDKOMHCJHG> HGPMCGJIADE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7830", Offset = "0x2CA6030", VA = "0x182CA7830")]
		private void EDGCCFIPBIG(NativeListAsync<NHDKOMHCJHG> HGPMCGJIADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2CA72A0", Offset = "0x2CA5AA0", VA = "0x182CA72A0")]
		private void CJKJFECFMGP(NativeListAsync<NHDKOMHCJHG> HGPMCGJIADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6840", Offset = "0x2CA5040", VA = "0x182CA6840")]
		private bool CEDEOECGCJH(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7760", Offset = "0x2CA5F60", VA = "0x182CA7760")]
		private NativeArray<Entity> EACMFMEDPKP(Entity DJGIAPPGDDP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8D70", Offset = "0x2CA7570", VA = "0x182CA8D70")]
		private HKPBHJBDAGP LMFEKMCPPIJ(NativeList<HKPBHJBDAGP> NJMIFNDBMPN)
		{
			return default(HKPBHJBDAGP);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8130", Offset = "0x2CA6930", VA = "0x182CA8130")]
		private void GGBJLIOBIOG(HKPBHJBDAGP AEGKMFNDGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9860", Offset = "0x2CA8060", VA = "0x182CA9860", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2CA81C0", Offset = "0x2CA69C0", VA = "0x182CA81C0")]
		public static EntityQuery INIEBBFIOFL(ComponentSystemBase IFHEBKPGABD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2CA65A0", Offset = "0x2CA4DA0", VA = "0x182CA65A0")]
		public static EntityQuery BANEMPKJKDE(ComponentSystemBase IFHEBKPGABD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7E70", Offset = "0x2CA6670", VA = "0x182CA7E70")]
		public static EntityQuery FOBOJNDHEDL(ComponentSystemBase IFHEBKPGABD)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[IECCMKJMAAC(LAEALBOAPLI.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery PPFDACOOOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private HIFGFPBNEMJ GJCNCJNMMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private FNAMPKOIMGD OGGLOMHHKHP;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x28B4EF0", Offset = "0x28B36F0", VA = "0x1828B4EF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x28B4E60", Offset = "0x28B3660", VA = "0x1828B4E60", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x28B4FF0", Offset = "0x28B37F0", VA = "0x1828B4FF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class HBANLCIHIJL : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public CAEEJNEMGJH BFLDNFIFFCO;

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public HBANLCIHIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
	public HBANLCIHIJL(CAEEJNEMGJH BFLDNFIFFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x31CAEB0", Offset = "0x31C96B0", VA = "0x1831CAEB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public abstract class EBMHEJDFOEC : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private ObjectEmbodimentService OMHLILNOJHE;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D20D90", Offset = "0x2D1F590", VA = "0x182D20D90", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D20DF0", Offset = "0x2D1F5F0", VA = "0x182D20DF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D20E20", Offset = "0x2D1F620", VA = "0x182D20E20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	protected EBMHEJDFOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class MENKMJCMDCL : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EntityQuery KOCALLLMGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery BPGNEOHPPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery LDOIELHMPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery NHFMAHBIKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private ObjectEmbodimentService CEGOEJLNPAG;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public int NBFPAEBDJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x2899630", Offset = "0x2897E30", VA = "0x182899630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int NDNOILFCJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x2899280", Offset = "0x2897A80", VA = "0x182899280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x28991B0", Offset = "0x28979B0", VA = "0x1828991B0", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x2899640", Offset = "0x2897E40", VA = "0x182899640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x2899840", Offset = "0x2898040", VA = "0x182899840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x2899530", Offset = "0x2897D30", VA = "0x182899530")]
	public int HNMBPADKKBK(SceneTag CHNAEAOJAGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x2899610", Offset = "0x2897E10", VA = "0x182899610")]
	public int LFPEFLNBDGE(SceneTag CHNAEAOJAGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x2898E70", Offset = "0x2897670", VA = "0x182898E70")]
	protected void BMFPJBPEHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x2899420", Offset = "0x2897C20", VA = "0x182899420")]
	protected void HNHKPDOEBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x2899160", Offset = "0x2897960", VA = "0x182899160")]
	public NativeArrayAsync<Entity> CCFILMKLMFB(SceneTag CHNAEAOJAGF, Allocator OODGOAPHOCI = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x28995C0", Offset = "0x2897DC0", VA = "0x1828995C0")]
	public NativeArrayAsync<Entity> KDJDFIIBJDI(SceneTag CHNAEAOJAGF, Allocator OODGOAPHOCI = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x2899330", Offset = "0x2897B30", VA = "0x182899330")]
	public bool GANDEEKMFDH(SceneTag CHNAEAOJAGF, out NativeArrayAsync<Entity> BFLDNFIFFCO, Allocator OODGOAPHOCI = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x28993C0", Offset = "0x2897BC0", VA = "0x1828993C0")]
	public bool HEGEOODMEBB(Entity DJGIAPPGDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x2899550", Offset = "0x2897D50", VA = "0x182899550")]
	public CAEEJNEMGJH JFGKKCJAPKC(Entity DJGIAPPGDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x2899210", Offset = "0x2897A10", VA = "0x182899210")]
	public bool COKDPCHCLPD(Entity DJGIAPPGDDP, out HBANLCIHIJL BFLDNFIFFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x2899290", Offset = "0x2897A90", VA = "0x182899290")]
	public void ECLKJDFNMDP(Entity DJGIAPPGDDP, HBANLCIHIJL BFLDNFIFFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x28992D0", Offset = "0x2897AD0", VA = "0x1828992D0")]
	public bool EJECNJIJHGA(Entity DJGIAPPGDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void LHOODKJJCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public MENKMJCMDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class JCDLAAAGMHK : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery AEAJLHODNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private HILDNPBHGOE GHFACKFNNLB;

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x31D34D0", Offset = "0x31D1CD0", VA = "0x1831D34D0", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x31D3590", Offset = "0x31D1D90", VA = "0x1831D3590", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x31D3650", Offset = "0x31D1E50", VA = "0x1831D3650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x14A4ED0", Offset = "0x14A36D0", VA = "0x1814A4ED0")]
	private bool PLGACPOHIFG<TComponentData>(EntityQuery PPFDACOOOGO, out NativeArray<Entity> NBDCDJJEKHD, out NativeArray<TComponentData> BCACPPJGPOP) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x31D3520", Offset = "0x31D1D20", VA = "0x1831D3520")]
	public CAEEJNEMGJH JFGKKCJAPKC(Entity DJGIAPPGDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public JCDLAAAGMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[IECCMKJMAAC(LAEALBOAPLI.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery GBFNLJHEDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery CEPGPNKEKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery ILPMACMKMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery BNEOLCEBBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B360", Offset = "0x2C99B60", VA = "0x182C9B360", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B780", Offset = "0x2C99F80", VA = "0x182C9B780", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B9B0", Offset = "0x2C9A1B0", VA = "0x182C9B9B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B710", Offset = "0x2C99F10", VA = "0x182C9B710")]
		private void LGCDELLOPGJ(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B2F0", Offset = "0x2C99AF0", VA = "0x182C9B2F0")]
		private void ALIFOBNBCOA(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B940", Offset = "0x2C9A140", VA = "0x182C9B940", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B3B0", Offset = "0x2C99BB0", VA = "0x182C9B3B0")]
		private void IPJJAEKMJNE(EntityQuery PPFDACOOOGO, bool NBJFHLJMABH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal sealed class EDDCMNFKELI : FGEMHNBDPAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct AHHEEMCAGFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public AHHEEMCAGFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FDHDOPALBCI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct FEJPPACHEEL
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct HJHAINMHDGE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime ELPDDKEKIEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime MABBJBPDIPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime COCONHMIDNC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FNCHDIIJOKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> HKHGBEICCLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> DEEBFCOFPKF;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x418BA80", Offset = "0x418A280", VA = "0x18418BA80")]
			public void OFCJMCDBAHD(EDDCMNFKELI IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x418B9C0", Offset = "0x418A1C0", VA = "0x18418B9C0")]
			public HJHAINMHDGE FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
			{
				return default(HJHAINMHDGE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private FEJPPACHEEL KGMAGAHIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FEJPPACHEEL.HJHAINMHDGE* KCHPJLFDFOM;

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x418B960", Offset = "0x418A160", VA = "0x18418B960")]
		internal void PKEFIBJCKKH(Entity EADIPFLIBFM, SplineShapeData OJHEBILAHKN, DynamicBuffer<LinkedEntityGroup> DNLJJNDPNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x418B760", Offset = "0x4189F60", VA = "0x18418B760", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x418B830", Offset = "0x418A030", VA = "0x18418B830")]
		public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, [NoAlias] ref FEJPPACHEEL.HJHAINMHDGE APIMNOLFLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x418B950", Offset = "0x418A150", VA = "0x18418B950")]
		public void OFCJMCDBAHD(EDDCMNFKELI IFHEBKPGABD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CMEACEJDHKC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct NEBHPCECNHH
		{
			[Cpp2IlInjected.Token(Token = "0x20000FB")]
			[NoAlias]
			public struct IDDBKMMKGJB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MADJHIJEIOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400030C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime LHJJHBABLAN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity NNMEAGEDDAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> EBPCJALHOBG;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x4190FA0", Offset = "0x418F7A0", VA = "0x184190FA0")]
			public void OFCJMCDBAHD(EDDCMNFKELI IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x4190F20", Offset = "0x418F720", VA = "0x184190F20")]
			public IDDBKMMKGJB FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
			{
				return default(IDDBKMMKGJB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BufferFromEntity<LinkedEntityGroup> EHKGBBADOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private NEBHPCECNHH KGMAGAHIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NEBHPCECNHH.IDDBKMMKGJB* KCHPJLFDFOM;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x4189C20", Offset = "0x4188420", VA = "0x184189C20")]
		internal void PKEFIBJCKKH(Entity MKJOCAGMBNL, SplinePointParentData MKBKEKIIONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x4189CB0", Offset = "0x41884B0", VA = "0x184189CB0", Slot = "5")]
		public void ReadFromDisplayClass(ref AHHEEMCAGFE NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x4189A40", Offset = "0x4188240", VA = "0x184189A40", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x4189AE0", Offset = "0x41882E0", VA = "0x184189AE0")]
		public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, [NoAlias] ref NEBHPCECNHH.IDDBKMMKGJB APIMNOLFLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x4189B90", Offset = "0x4188390", VA = "0x184189B90")]
		public void OFCJMCDBAHD(EDDCMNFKELI IFHEBKPGABD, ref AHHEEMCAGFE NACAPKCDIHL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private EntityQuery PPFDACOOOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery OFBPIHMEFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery PJPJJGFFKFL;

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D21720", Offset = "0x2D1FF20", VA = "0x182D21720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D217D0", Offset = "0x2D1FFD0", VA = "0x182D217D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public EDDCMNFKELI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D21480", Offset = "0x2D1FC80", VA = "0x182D21480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D212E0", Offset = "0x2D1FAE0", VA = "0x182D212E0")]
	public static EntityQuery JKAJEHJOAED(ComponentSystemBase IFHEBKPGABD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D21180", Offset = "0x2D1F980", VA = "0x182D21180")]
	public static EntityQuery FOIDAJKDNNO(ComponentSystemBase IFHEBKPGABD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
public sealed class KLJKGEDKGIO : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private MGDMBBFBAJB JBLJDFDIDLM;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x31D7FB0", Offset = "0x31D67B0", VA = "0x1831D7FB0", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x31D8010", Offset = "0x31D6810", VA = "0x1831D8010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public KLJKGEDKGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class ONFFCHIOMCL : FGEMHNBDPAP, INBMAMBAHGE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct HKMFBILLNEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<NMHNICEEPMK> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NativeList<AJKPJGJILHO> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NativeList<NMHNICEEPMK> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public HKMFBILLNEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, GNHNGFMKFPI previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
		internal void <OnUpdate>b__2(Entity entity, GNHNGFMKFPI previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct KINEIPOHOHO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct OOLCLDCDADK
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct NNPJOECODDE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400031A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MJCEIKBJNFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400031B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime PBAOEJNAANB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FICCJLGCPHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> EMGEENDKGGJ;

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x4192430", Offset = "0x4190C30", VA = "0x184192430")]
			public void OFCJMCDBAHD(ONFFCHIOMCL IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x41923B0", Offset = "0x4190BB0", VA = "0x1841923B0")]
			public NNPJOECODDE FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
			{
				return default(NNPJOECODDE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeList<NMHNICEEPMK> FBBCFNBDFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private OOLCLDCDADK KGMAGAHIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OOLCLDCDADK.NNPJOECODDE* KCHPJLFDFOM;

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x418FF00", Offset = "0x418E700", VA = "0x18418FF00")]
		internal void PKEFIBJCKKH(Entity DJGIAPPGDDP, ParentData FNOCDBPJMGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x15A2980", Offset = "0x15A1180", VA = "0x1815A2980", Slot = "5")]
		public void ReadFromDisplayClass(ref HKMFBILLNEG NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x418FD20", Offset = "0x418E520", VA = "0x18418FD20", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x418FDC0", Offset = "0x418E5C0", VA = "0x18418FDC0")]
		public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, [NoAlias] ref OOLCLDCDADK.NNPJOECODDE APIMNOLFLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x418FE70", Offset = "0x418E670", VA = "0x18418FE70")]
		public void OFCJMCDBAHD(ONFFCHIOMCL IFHEBKPGABD, ref HKMFBILLNEG NACAPKCDIHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct AKJINKBFJHO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct CKOOPNADGNB
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct AMAHJBBKAID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MJCEIKBJNFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime PBAOEJNAANB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<GNHNGFMKFPI>.Runtime AIHCGKACCHB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FICCJLGCPHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> EMGEENDKGGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<GNHNGFMKFPI> AOHIJELFEFE;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x4189080", Offset = "0x4187880", VA = "0x184189080")]
			public void OFCJMCDBAHD(ONFFCHIOMCL IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x4188FE0", Offset = "0x41877E0", VA = "0x184188FE0")]
			public AMAHJBBKAID FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
			{
				return default(AMAHJBBKAID);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NativeList<AJKPJGJILHO> ENOIEMPKPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private CKOOPNADGNB KGMAGAHIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CKOOPNADGNB.AMAHJBBKAID* KCHPJLFDFOM;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x4187B10", Offset = "0x4186310", VA = "0x184187B10")]
		internal void PKEFIBJCKKH(Entity DJGIAPPGDDP, ParentData FNOCDBPJMGE, GNHNGFMKFPI ICPDCFEOPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x4187BD0", Offset = "0x41863D0", VA = "0x184187BD0", Slot = "5")]
		public void ReadFromDisplayClass(ref HKMFBILLNEG NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x4187920", Offset = "0x4186120", VA = "0x184187920", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x41879F0", Offset = "0x41861F0", VA = "0x1841879F0")]
		public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, [NoAlias] ref CKOOPNADGNB.AMAHJBBKAID APIMNOLFLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x4187AD0", Offset = "0x41862D0", VA = "0x184187AD0")]
		public void OFCJMCDBAHD(ONFFCHIOMCL IFHEBKPGABD, ref HKMFBILLNEG NACAPKCDIHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct IBBCJGOANOF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private struct GEOCBBCIOPD
		{
			[Cpp2IlInjected.Token(Token = "0x2000107")]
			[NoAlias]
			public struct AICLGFGEKJG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MJCEIKBJNFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<GNHNGFMKFPI>.Runtime AIHCGKACCHB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FICCJLGCPHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<GNHNGFMKFPI> AOHIJELFEFE;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x418DA70", Offset = "0x418C270", VA = "0x18418DA70")]
			public void OFCJMCDBAHD(ONFFCHIOMCL IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x418D9F0", Offset = "0x418C1F0", VA = "0x18418D9F0")]
			public AICLGFGEKJG FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
			{
				return default(AICLGFGEKJG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NativeList<NMHNICEEPMK> LCAJEAKHAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private GEOCBBCIOPD KGMAGAHIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GEOCBBCIOPD.AICLGFGEKJG* KCHPJLFDFOM;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x418E6A0", Offset = "0x418CEA0", VA = "0x18418E6A0")]
		internal void PKEFIBJCKKH(Entity DJGIAPPGDDP, GNHNGFMKFPI ICPDCFEOPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x418E720", Offset = "0x418CF20", VA = "0x18418E720", Slot = "5")]
		public void ReadFromDisplayClass(ref HKMFBILLNEG NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x418E4C0", Offset = "0x418CCC0", VA = "0x18418E4C0", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x418E560", Offset = "0x418CD60", VA = "0x18418E560")]
		public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, [NoAlias] ref GEOCBBCIOPD.AICLGFGEKJG APIMNOLFLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x418E610", Offset = "0x418CE10", VA = "0x18418E610")]
		public void OFCJMCDBAHD(ONFFCHIOMCL IFHEBKPGABD, ref HKMFBILLNEG NACAPKCDIHL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private LLOMGAJNLGK LBPHKFCNJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery ECJINAAMDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery MIPOHBJMAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery HHHICIKLIKI;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x28A1360", Offset = "0x289FB60", VA = "0x1828A1360", Slot = "14")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x28A1930", Offset = "0x28A0130", VA = "0x1828A1930", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public ONFFCHIOMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x28A18D0", Offset = "0x28A00D0", VA = "0x1828A18D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x28A1440", Offset = "0x289FC40", VA = "0x1828A1440")]
	public static EntityQuery ELLGEIJPHMO(ComponentSystemBase IFHEBKPGABD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x28A16A0", Offset = "0x289FEA0", VA = "0x1828A16A0")]
	public static EntityQuery JAFIFNGEFAH(ComponentSystemBase IFHEBKPGABD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x28A1160", Offset = "0x289F960", VA = "0x1828A1160")]
	public static EntityQuery ADFLPCAJILG(ComponentSystemBase IFHEBKPGABD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[IECCMKJMAAC(LAEALBOAPLI.Connectables)]
	public class InitializeRigidbodyExHierarchy : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EntityQuery PPFDACOOOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private POLLMCKAGBL GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x31D2C20", Offset = "0x31D1420", VA = "0x1831D2C20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x31D2BB0", Offset = "0x31D13B0", VA = "0x1831D2BB0", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x31D2CB0", Offset = "0x31D14B0", VA = "0x1831D2CB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class GIEKMAGBPEJ : ParentSystemBase<ParentData, GNHNGFMKFPI, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x31C9410", Offset = "0x31C7C10", VA = "0x1831C9410", Slot = "14")]
	protected override EntityQueryDesc MPBJAOFOCPJ(EntityQueryDesc PPFDACOOOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x7806D0", Offset = "0x77EED0", VA = "0x1807806D0", Slot = "15")]
	protected override EntityQueryDesc JNHFJGGPHFC(EntityQueryDesc PPFDACOOOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x31C94D0", Offset = "0x31C7CD0", VA = "0x1831C94D0", Slot = "16")]
	protected override EntityQueryDesc PNODGLAICJC(EntityQueryDesc PPFDACOOOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x31C9450", Offset = "0x31C7C50", VA = "0x1831C9450", Slot = "17")]
	protected override EntityQueryDesc OOBBGHMHNIO(EntityQueryDesc PPFDACOOOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x31C9510", Offset = "0x31C7D10", VA = "0x1831C9510")]
	public GIEKMAGBPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x31C9490", Offset = "0x31C7C90", VA = "0x1831C9490", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : FGEMHNBDPAP where ParentData : struct, IComponentData, NBDNEINNKHP where PreviousParentData : struct, IComponentData, NBDNEINNKHP where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, NBDNEINNKHP
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct CENMDEIKELN : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter BGCMCNALLFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter GGEHOAJMEOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public NativeHashMap<Entity, int>.ParallelWriter HJLJPHAPFJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ArchetypeChunkComponentType<PreviousParentData> JDPGAEEEEKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> COHNMMEBPLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public ArchetypeChunkEntityType PGEMBCFPMKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public uint AGFGNEMMPNN;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x28CA1F0", Offset = "0x28C89F0", VA = "0x1828CA1F0", Slot = "4")]
			public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[BurstCompile]
		private struct JBDLNBKAAKF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> HJLJPHAPFJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> CNMMKCJFKIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public NativeList<Entity> DAGCPBDOMOA;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x33E52D0", Offset = "0x33E3AD0", VA = "0x1833E52D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		private struct HLOAOMHIICD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> BGCMCNALLFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> GGEHOAJMEOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeHashMap<Entity, int> HJLJPHAPFJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BufferFromEntity<ChildrenData> CNMMKCJFKIE;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x39F12C0", Offset = "0x39EFAC0", VA = "0x1839F12C0")]
			private int MMCABMKJFKH(DynamicBuffer<ChildrenData> MDNHGAAHKGD, Entity DJGIAPPGDDP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x39F0B30", Offset = "0x39EF330", VA = "0x1839F0B30")]
			private void AHDGFBFGHKC(Entity FAAJOMIIHED, DynamicBuffer<ChildrenData> MDNHGAAHKGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x39F1080", Offset = "0x39EF880", VA = "0x1839F1080")]
			private void LECLMOPCCHG(Entity FAAJOMIIHED, DynamicBuffer<ChildrenData> MDNHGAAHKGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x39F0DF0", Offset = "0x39EF5F0", VA = "0x1839F0DF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[BurstCompile]
		private struct MPIOAFDBHKE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeArray<Entity> OAEPJGGKOMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public NativeList<Entity> MLJAFDCPLNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public BufferFromEntity<ChildrenData> CNMMKCJFKIE;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x28E7650", Offset = "0x28E5E50", VA = "0x1828E7650", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery KAIGMLODILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery HFFGBBHIDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery DIKJLIIJMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected EntityQuery MIKLDJCHLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker HPEAIBOOAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker BAOCMNGJOGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker OKJPKBKOFNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected ProfilerMarker HCBCPDEDCPB;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x3114110", Offset = "0x3112910", VA = "0x183114110")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x3113D80", Offset = "0x3112580", VA = "0x183113D80")]
		private int MMCABMKJFKH(DynamicBuffer<ChildrenData> MDNHGAAHKGD, Entity DJGIAPPGDDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x3113C20", Offset = "0x3112420", VA = "0x183113C20")]
		private void HGNMMPOFFHK(Entity OHDNGJKAFKH, Entity KFOIBILPJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x7806D0", Offset = "0x77EED0", VA = "0x1807806D0", Slot = "14")]
		protected virtual EntityQueryDesc MPBJAOFOCPJ(EntityQueryDesc PPFDACOOOGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x7806D0", Offset = "0x77EED0", VA = "0x1807806D0", Slot = "15")]
		protected virtual EntityQueryDesc JNHFJGGPHFC(EntityQueryDesc PPFDACOOOGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x7806D0", Offset = "0x77EED0", VA = "0x1807806D0", Slot = "16")]
		protected virtual EntityQueryDesc PNODGLAICJC(EntityQueryDesc PPFDACOOOGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc OOBBGHMHNIO(EntityQueryDesc PPFDACOOOGO);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x3113E70", Offset = "0x3112670", VA = "0x183113E70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x3113180", Offset = "0x3111980", VA = "0x183113180")]
		private void ADHNJEHJHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x3113A60", Offset = "0x3112260", VA = "0x183113A60")]
		private void FDGJMKGEICI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x3113250", Offset = "0x3111A50", VA = "0x183113250")]
		private JobHandle COMLDMJNNJI(JobHandle DHCILENDCIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x3113780", Offset = "0x3111F80", VA = "0x183113780")]
		private void EDPCFMJCCJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD840", Offset = "0x2DCC040", VA = "0x182DCD840", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD810", Offset = "0x2DCC010", VA = "0x182DCD810", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x149BDE0", Offset = "0x149A5E0", VA = "0x18149BDE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[AlwaysUpdateSystem]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
public abstract class EHNKGEPHPFH : FGEMHNBDPAP, INBMAMBAHGE
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct CLJIGACMIGO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> DGCHGHIAPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> HJFIGEPACMI;

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x41894B0", Offset = "0x4187CB0", VA = "0x1841894B0")]
		public CLJIGACMIGO(NativeList<Entity> DGCHGHIAPFC, NativeList<Entity> HJFIGEPACMI, JobHandle DOPBMBDFIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x4189430", Offset = "0x4187C30", VA = "0x184189430")]
		public JobHandle LDOCFDGNCOC(JobHandle DHCILENDCIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x41893A0", Offset = "0x4187BA0", VA = "0x1841893A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct EEDPOBGHGHC : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[Flags]
		public enum BGHPDMPPHGK
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
		public NativeList<Entity> GMJIAAPAMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> BJFNPLCGMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> IPBIBALDFPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> MEOFEJEGDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity GKFOHIGGEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity JKPAEFNKFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> OIIANCDIEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int DGGEANIICEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int NNPBHJECMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private BGHPDMPPHGK BGKKCEPMNCH;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x418AB40", Offset = "0x4189340", VA = "0x18418AB40", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x418ADE0", Offset = "0x41895E0", VA = "0x18418ADE0")]
		private void GIPCNDEKHPD(Entity DJGIAPPGDDP, bool CNCCNBFCJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x418ACD0", Offset = "0x41894D0", VA = "0x18418ACD0")]
		private void FEGGELAINOD(Entity DJGIAPPGDDP, bool CNCCNBFCJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x418B1B0", Offset = "0x41899B0", VA = "0x18418B1B0")]
		public CLJIGACMIGO MMAJBPKCMCD(NativeArray<Entity> DMECHADKKED, JobHandle DHCILENDCIJ)
		{
			return default(CLJIGACMIGO);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x418B230", Offset = "0x4189A30", VA = "0x18418B230")]
		public CLJIGACMIGO ONBAPFAENGA(NativeArray<Entity> DMECHADKKED, JobHandle DHCILENDCIJ)
		{
			return default(CLJIGACMIGO);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x418AE70", Offset = "0x4189670", VA = "0x18418AE70")]
		public CLJIGACMIGO HJGJLLDJDIK(NativeList<NMHNICEEPMK> HGPMCGJIADE, JobHandle DHCILENDCIJ)
		{
			return default(CLJIGACMIGO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x418B2B0", Offset = "0x4189AB0", VA = "0x18418B2B0")]
		public CLJIGACMIGO PBOIAOJFBJO(NativeList<NMHNICEEPMK> HGPMCGJIADE, JobHandle DHCILENDCIJ)
		{
			return default(CLJIGACMIGO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x418AA60", Offset = "0x4189260", VA = "0x18418AA60")]
		public CLJIGACMIGO BCCIGBDHAIF(NativeList<AJKPJGJILHO> HGPMCGJIADE, JobHandle DHCILENDCIJ)
		{
			return default(CLJIGACMIGO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3AC0", Offset = "0x2CB22C0", VA = "0x182CB3AC0")]
		private CLJIGACMIGO LFGDOBGCHBK<T>(NativeList<T> HGPMCGJIADE, int IFIPONFCAGD, int KHKFNLJIGMK, BGHPDMPPHGK BCBFMICMNIP, JobHandle DHCILENDCIJ) where T : struct
		{
			return default(CLJIGACMIGO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x418AF50", Offset = "0x4189750", VA = "0x18418AF50")]
		private CLJIGACMIGO LFGDOBGCHBK(NativeArray<Entity> NBDCDJJEKHD, int IFIPONFCAGD, int KHKFNLJIGMK, BGHPDMPPHGK BCBFMICMNIP, JobHandle DHCILENDCIJ)
		{
			return default(CLJIGACMIGO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly DELGGOALDMF MGFJDFPNJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery PAGFEFDGLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery EJCGOGEGNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private LLOMGAJNLGK GHNOCOALBHC;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected abstract ComponentType IIJMBDGFDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract ComponentType KMLCPOLKELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected abstract ComponentType KDLDBFAPNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x2D23D30", Offset = "0x2D22530", VA = "0x182D23D30")]
	protected EHNKGEPHPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2D22640", Offset = "0x2D20E40", VA = "0x182D22640", Slot = "14")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2D22C90", Offset = "0x2D21490", VA = "0x182D22C90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2D22EC0", Offset = "0x2D216C0", VA = "0x182D22EC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFAA0", Offset = "0x7FE2A0", VA = "0x1807FFAA0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2D22C30", Offset = "0x2D21430", VA = "0x182D22C30")]
	private void OAMPHHNKLMG(NativeArray<Entity> HGPMCGJIADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2D225A0", Offset = "0x2D20DA0", VA = "0x182D225A0")]
	private void BMAEHNFHBPJ(NativeArray<Entity> HGPMCGJIADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2D22AF0", Offset = "0x2D212F0", VA = "0x182D22AF0")]
	private void KJHKNEGJHNF(CLJIGACMIGO OLLKFEFFIDO, string BANLEOIIKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2D229E0", Offset = "0x2D211E0", VA = "0x182D229E0")]
	private void KJHKNEGJHNF(NativeListAsync<Entity> LDPABEJPFOK, string BANLEOIIKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x2D22720", Offset = "0x2D20F20", VA = "0x182D22720")]
	private void DCGJKJOMPBK(CLJIGACMIGO OLLKFEFFIDO, string BANLEOIIKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x2D22860", Offset = "0x2D21060", VA = "0x182D22860")]
	private void DCGJKJOMPBK(NativeListAsync<Entity> LDPABEJPFOK, string BANLEOIIKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2D22970", Offset = "0x2D21170", VA = "0x182D22970")]
	private bool EMKHEFPCFNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
public class COFJIIBFPLP : FGEMHNBDPAP, HNOABDNADGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct JBLFNICGGNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public COFJIIBFPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public JBLFNICGGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct DEOAGNHNGJG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct IDDFFJPMCBA
		{
			[Cpp2IlInjected.Token(Token = "0x2000117")]
			public struct LJAIHMHIDGO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime BFOMKJGEFKG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GPMAFNKAPLE;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x418E740", Offset = "0x418CF40", VA = "0x18418E740")]
			public void OFCJMCDBAHD(COFJIIBFPLP IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x418E730", Offset = "0x418CF30", VA = "0x18418E730")]
			public LJAIHMHIDGO FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
			{
				return default(LJAIHMHIDGO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public COFJIIBFPLP BBOKJPLALNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EntityCommandBuffer BMCEPMKGADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private IDDFFJPMCBA KGMAGAHIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IDDFFJPMCBA.LJAIHMHIDGO* KCHPJLFDFOM;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KJFGNIEDIHO;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x2C90EA0", Offset = "0x2C8F6A0", VA = "0x182C90EA0")]
		internal void PKEFIBJCKKH(Entity ODBOKKABIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x2C90FB0", Offset = "0x2C8F7B0", VA = "0x182C90FB0", Slot = "5")]
		public void ReadFromDisplayClass(ref JBLFNICGGNG NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x2C90FE0", Offset = "0x2C8F7E0", VA = "0x182C90FE0", Slot = "6")]
		public void WriteToDisplayClass(ref JBLFNICGGNG NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x2C90DA0", Offset = "0x2C8F5A0", VA = "0x182C90DA0", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x2C90DF0", Offset = "0x2C8F5F0", VA = "0x182C90DF0")]
		public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, ref IDDFFJPMCBA.LJAIHMHIDGO APIMNOLFLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x2C90E60", Offset = "0x2C8F660", VA = "0x182C90E60")]
		public void OFCJMCDBAHD(COFJIIBFPLP IFHEBKPGABD, ref JBLFNICGGNG NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x2C90D30", Offset = "0x2C8F530", VA = "0x182C90D30")]
		public unsafe static void ALMKLGDMEPG(ArchetypeChunkIterator* BNBLIJPHBIB, void* DHBLLJAGKCG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private AIGDLDKAKGC NBDFDFODBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private OJCMJJNIHBI APPHPFMBIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery BECPNDDIJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private ProfilerMarker MIFAAOJLEEC;

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x2D0ECA0", Offset = "0x2D0D4A0", VA = "0x182D0ECA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EB60", Offset = "0x2D0D360", VA = "0x182D0EB60", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x2D0ED00", Offset = "0x2D0D500", VA = "0x182D0ED00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public COFJIIBFPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EBC0", Offset = "0x2D0D3C0", VA = "0x182D0EBC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EE50", Offset = "0x2D0D650", VA = "0x182D0EE50")]
	public static EntityQuery PNGEHLPGBBN(ComponentSystemBase IFHEBKPGABD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[HCBICNINHAE]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
public class NPDFFKFPPCD : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private OJCMJJNIHBI APPHPFMBIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private SceneService KCPLDCIJMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery PPFDACOOOGO;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x289F470", Offset = "0x289DC70", VA = "0x18289F470", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x289F4E0", Offset = "0x289DCE0", VA = "0x18289F4E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x289F580", Offset = "0x289DD80", VA = "0x18289F580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public NPDFFKFPPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public struct KDPDIABEGNM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public CJIMCAOKHHG AEGKMFNDGLH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x6D5000", Offset = "0x6D3800", VA = "0x1806D5000")]
	public static KDPDIABEGNM AGJOPELLCGM(in CJIMCAOKHHG HLOEEDDANEG)
	{
		return default(KDPDIABEGNM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5000", Offset = "0x6D3800", VA = "0x1806D5000")]
	public static CJIMCAOKHHG AGJOPELLCGM(in KDPDIABEGNM FECKKOMEAGO)
	{
		return default(CJIMCAOKHHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[AlwaysUpdateSystem]
public class AIGDLDKAKGC : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x2D069F0", Offset = "0x2D051F0", VA = "0x182D069F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20")]
	public AIGDLDKAKGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[AlwaysUpdateSystem]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
public class JFBDCDAEFGD : FGEMHNBDPAP, HNOABDNADGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct CELAHLFLIBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public JFBDCDAEFGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public CELAHLFLIBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
		internal void <OnUpdate>b__0(Entity e, KDPDIABEGNM ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FPIFEOJCOFE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct KGFEEDJMFGG
		{
			[Cpp2IlInjected.Token(Token = "0x200011F")]
			public struct OKGDLCPBHDP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				public LambdaParameterValueProvider_Entity.Runtime BFOMKJGEFKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public LambdaParameterValueProvider_IComponentData<KDPDIABEGNM>.Runtime LEHBOOPAGIA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GPMAFNKAPLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<KDPDIABEGNM> EMHCKOFOFOE;

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x418F9D0", Offset = "0x418E1D0", VA = "0x18418F9D0")]
			public void OFCJMCDBAHD(JFBDCDAEFGD IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x418F950", Offset = "0x418E150", VA = "0x18418F950")]
			public OKGDLCPBHDP FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
			{
				return default(OKGDLCPBHDP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public JFBDCDAEFGD BBOKJPLALNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EntityCommandBuffer BMCEPMKGADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private KGFEEDJMFGG KGMAGAHIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KGFEEDJMFGG.OKGDLCPBHDP* KCHPJLFDFOM;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KJFGNIEDIHO;

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x418D420", Offset = "0x418BC20", VA = "0x18418D420")]
		internal void PKEFIBJCKKH(Entity ODBOKKABIBK, KDPDIABEGNM HCCIJDGCLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x2C90FB0", Offset = "0x2C8F7B0", VA = "0x182C90FB0", Slot = "5")]
		public void ReadFromDisplayClass(ref CELAHLFLIBF NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2C90FE0", Offset = "0x2C8F7E0", VA = "0x182C90FE0", Slot = "6")]
		public void WriteToDisplayClass(ref CELAHLFLIBF NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x418D240", Offset = "0x418BA40", VA = "0x18418D240", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x418D2E0", Offset = "0x418BAE0", VA = "0x18418D2E0")]
		public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, ref KGFEEDJMFGG.OKGDLCPBHDP APIMNOLFLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x418D390", Offset = "0x418BB90", VA = "0x18418D390")]
		public void OFCJMCDBAHD(JFBDCDAEFGD IFHEBKPGABD, ref CELAHLFLIBF NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x418D1D0", Offset = "0x418B9D0", VA = "0x18418D1D0")]
		public unsafe static void ALMKLGDMEPG(ArchetypeChunkIterator* BNBLIJPHBIB, void* DHBLLJAGKCG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private AIGDLDKAKGC NBDFDFODBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private OJCMJJNIHBI APPHPFMBIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery ABKGLHFOLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private ProfilerMarker FFFMIJMIDHG;

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x31D4440", Offset = "0x31D2C40", VA = "0x1831D4440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x31D4130", Offset = "0x31D2930", VA = "0x1831D4130", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x31D44A0", Offset = "0x31D2CA0", VA = "0x1831D44A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public JFBDCDAEFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x31D4360", Offset = "0x31D2B60", VA = "0x1831D4360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x31D4190", Offset = "0x31D2990", VA = "0x1831D4190")]
	public static EntityQuery JDCCNJPKKJE(ComponentSystemBase IFHEBKPGABD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct CBJJLLMONEH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public GDIPBBIJEHP FLBPGJKFMKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public NativeHashMap<Entity, HKDLOMPDCOH> NBDCDJJEKHD;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x4188760", Offset = "0x4186F60", VA = "0x184188760")]
			public CBJJLLMONEH(int EBGHKBFPDCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x41886E0", Offset = "0x4186EE0", VA = "0x1841886E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct KJJMCGBDAGJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public NativeArray<Entity> NBDCDJJEKHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> PEOGKCLJAEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> IHGNBHDNNNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> BKKJPMOLNCP;

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x4190090", Offset = "0x418E890", VA = "0x184190090", Slot = "4")]
			public void Execute(int LHHBOCAHDEE, TransformAccess KPFEIMOAGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct KADGJHFMFAG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public NativeArray<Entity> NBDCDJJEKHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> PEOGKCLJAEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> BKKJPMOLNCP;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x418F790", Offset = "0x418DF90", VA = "0x18418F790", Slot = "4")]
			public void Execute(int LHHBOCAHDEE, TransformAccess KPFEIMOAGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private OJCMJJNIHBI APPHPFMBIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery GJKNGDBDJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery PKIPDBJIFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery KDEGINBPDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery NBFEJJFBBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery EGCEHPFMHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private JobHandle BGGAKHJIAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private CBJJLLMONEH DHOFGDLMPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private CBJJLLMONEH LHCDGNHNCAA;

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x28B1580", Offset = "0x28AFD80", VA = "0x1828B1580", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x28B1F40", Offset = "0x28B0740", VA = "0x1828B1F40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x28B1C10", Offset = "0x28B0410", VA = "0x1828B1C10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x28B2200", Offset = "0x28B0A00", VA = "0x1828B2200", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x28B19A0", Offset = "0x28B01A0", VA = "0x1828B19A0")]
		private void KHEJBBEEILE(EntityQuery PPFDACOOOGO, out (NativeArrayAsync<KDPDIABEGNM> handles, NativeArrayAsync<LDAACCNPBBB> bounds) LBEMEOBAAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x28B15E0", Offset = "0x28AFDE0", VA = "0x1828B15E0")]
		private void EONMCDCIIMA((NativeArrayAsync<KDPDIABEGNM> handles, NativeArrayAsync<LDAACCNPBBB> bounds) LBEMEOBAAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x28B1C10", Offset = "0x28B0410", VA = "0x1828B1C10")]
		private void NPNGOBFNPGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x28B1440", Offset = "0x28AFC40", VA = "0x1828B1440")]
		private void AHKLIFGFDNL(EntityQuery PPFDACOOOGO, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<KDPDIABEGNM> handles) LBEMEOBAAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x28B1C50", Offset = "0x28B0450", VA = "0x1828B1C50")]
		private void ODBFOHFAECI((NativeArrayAsync<Entity> entities, NativeArrayAsync<KDPDIABEGNM> handles) LBEMEOBAAJI, CBJJLLMONEH IIAHLGNADOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x28B1840", Offset = "0x28B0040", VA = "0x1828B1840")]
		private JobHandle HGKICHIACLI(CBJJLLMONEH IIAHLGNADOM, ComponentDataFromEntity<WorldPoseData> PEOGKCLJAEA, ComponentDataFromEntity<WorldUniformScaleData> BKKJPMOLNCP, ComponentDataFromEntity<WorldDeformableScaleData> IHGNBHDNNNG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x28B1AE0", Offset = "0x28B02E0", VA = "0x1828B1AE0")]
		private JobHandle NCHLACMFLJC(CBJJLLMONEH IIAHLGNADOM, ComponentDataFromEntity<WorldPoseData> PEOGKCLJAEA, ComponentDataFromEntity<WorldUniformScaleData> BKKJPMOLNCP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct ODELDHCOHFA : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[HCBICNINHAE]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	public class SplineLocalBoundsSystem : FGEMHNBDPAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile]
		private struct JNJLDIGLAPB : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public NativeArray<Entity> FPDKOJEPOCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> BJHJHNAPHAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			[ReadOnly]
			public ComponentDataFromEntity<LDAACCNPBBB> NHEMHHBJGPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[WriteOnly]
			public NativeHashMap<Entity, HKDLOMPDCOH>.ParallelWriter CIFBBKJCEKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter LNMIPFBHPON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter CIKHFGEDKMJ;

			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x418F660", Offset = "0x418DE60", VA = "0x18418F660", Slot = "4")]
			public void Execute(int LHHBOCAHDEE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[BurstCompile]
		private struct ACAFJGAKOCF : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public NativeArray<Entity> LLEMIICDOLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> KOHOJLKNAIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> IKLPENHLCOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> NFKJNIFLDMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LDAACCNPBBB> FJEEHNNAFPH;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x4186D20", Offset = "0x4185520", VA = "0x184186D20", Slot = "4")]
			public void Execute(int LHHBOCAHDEE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery HGPNGNCOMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery KKKBJBBENIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery FOHIMAAMIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery MAMGDKLADEJ;

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DD30", Offset = "0x2C9C530", VA = "0x182C9DD30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DF40", Offset = "0x2C9C740", VA = "0x182C9DF40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DA70", Offset = "0x2C9C270", VA = "0x182C9DA70")]
		private JobHandle NHKFEFNCBDJ(NativeArrayAsync<Entity> CIMBPHJAHGJ, int EEOHOPIJABN, JobHandle DHCILENDCIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DB50", Offset = "0x2C9C350", VA = "0x182C9DB50")]
		private JobHandle NHKFEFNCBDJ(NativeArray<Entity> LIJGLMNPNDN, int EEOHOPIJABN, [Optional] JobHandle DHCILENDCIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E460", Offset = "0x2C9CC60", VA = "0x182C9E460")]
		private NativeArrayAsync<Entity> PIOJMMHOIKF(EntityQuery PPFDACOOOGO)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D060", Offset = "0x2C9B860", VA = "0x182C9D060")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) JGOJPAKPGLE(NativeArrayAsync<Entity> CFMGCBGEHLD)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CFD0", Offset = "0x2C9B7D0", VA = "0x182C9CFD0")]
		private void ICIELHJFBPG(out NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D9E0", Offset = "0x2C9C1E0", VA = "0x182C9D9E0")]
		private void MJEBJKKNKKH(NativeList<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D910", Offset = "0x2C9C110", VA = "0x182C9D910")]
		private void MJEBJKKNKKH(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D7E0", Offset = "0x2C9BFE0", VA = "0x182C9D7E0")]
		private void LLBAOAIIAOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		private static void POCDLOGBACK(int HAMDOPDAPKF, int IENMIPLLAII, int IIKMELNPHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D4B0", Offset = "0x2C9BCB0", VA = "0x182C9D4B0")]
		private static LDAACCNPBBB KCAEDEDBGIF(NativeArray<Entity> PNKGENIHMCK, ComponentDataFromEntity<SplinePointPositionData> IKLPENHLCOC, ComponentDataFromEntity<SplinePointScaleData> NFKJNIFLDMK)
		{
			return default(LDAACCNPBBB);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct DIMJJFIOLAO : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[HCBICNINHAE]
	[IECCMKJMAAC(LAEALBOAPLI.Lifecycle)]
	public class DestroyLocalObjects : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[EOIIILOBJAK]
		private ObjectNetworkToLocalMapService DDLHJELICBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[EOIIILOBJAK]
		private ObjectLifecycleService KPJGDFLAFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private EntityQuery KCFNKLJJDHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery IPMKAJCLDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery BNEOLCEBBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E930", Offset = "0x2D1D130", VA = "0x182D1E930", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D1EDD0", Offset = "0x2D1D5D0", VA = "0x182D1EDD0")]
		public bool PLLLLEJBONE(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D1EC80", Offset = "0x2D1D480", VA = "0x182D1EC80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E8F0", Offset = "0x2D1D0F0", VA = "0x182D1E8F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D1EDB0", Offset = "0x2D1D5B0", VA = "0x182D1EDB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x1BE0FE0", Offset = "0x1BDF7E0", VA = "0x181BE0FE0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E8F0", Offset = "0x2D1D0F0", VA = "0x182D1E8F0")]
		private void BLFEBIOIKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E9A0", Offset = "0x2D1D1A0", VA = "0x182D1E9A0")]
		private void DOLKPPKCEPJ(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D1EE80", Offset = "0x2D1D680", VA = "0x182D1EE80")]
		private void PMJBIOJEPMO(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D1EB70", Offset = "0x2D1D370", VA = "0x182D1EB70")]
		private void NEHFILAMICC(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D1EA50", Offset = "0x2D1D250", VA = "0x182D1EA50")]
		private void HKEANHFENHE(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[IECCMKJMAAC(LAEALBOAPLI.NetworkSend)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	public sealed class EnqueuePropertyDifferenceToNetwork : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private static CNADGMDJLKK[] MFJJMJOADGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private HEFDIEGHAOC BKADCLIGACI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private JHIICGGLBCC LBNFCHBNENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PropertyDiffStateService FGMABDJHGFG;

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x31C3840", Offset = "0x31C2040", VA = "0x1831C3840", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x31C3E80", Offset = "0x31C2680", VA = "0x1831C3E80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x31C38F0", Offset = "0x31C20F0", VA = "0x1831C38F0")]
		private void FFFGDJJMFJH(CNADGMDJLKK MFNNPHEMCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		private void OBDPEAIADHP(Entity DJGIAPPGDDP, IOAGKMCGKAI DGNLFFKHMAE, PEFKAJGNEDD MOMPKBKMCLK, NELJJCBIPGD DNDNLAECNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[IECCMKJMAAC(LAEALBOAPLI.Callbacks)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	public sealed class PropertyEventCallbacks : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private PropertyEventCallbacksService IBNCKKOJDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private PropertyDiffStateService FGMABDJHGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TransformOwnershipPhase MFNNPHEMCDL;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x28B80E0", Offset = "0x28B68E0", VA = "0x1828B80E0", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x28B8170", Offset = "0x28B6970", VA = "0x1828B8170", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[IECCMKJMAAC(LAEALBOAPLI.NetworkSend)]
	internal class TransmitNetworkDataSystem : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private DMJNNINNIGH PKFHFCLCCIJ;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2CA53C0", Offset = "0x2CA3BC0", VA = "0x182CA53C0", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5410", Offset = "0x2CA3C10", VA = "0x182CA5410", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[HCBICNINHAE]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	public class CalculateCullingBandChanges : FGEMHNBDPAP, BGAFKNOHCIN, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct DGDJKBEPEHI : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ArchetypeChunkEntityType LLPKNCODMCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> FDOOPOPOMGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[WriteOnly]
			public NativeList<AJFHOEGNMCO>.ParallelWriter MNKJHPKKAMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public ArchetypeChunkComponentType<JLNMCHPDBFK> JBHNBOKDAEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public float3 DJDDCFICJJN;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private static readonly float4x2 BAHICBAGNOA;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private static readonly float4x2 AGHMCHCPKGI;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private static readonly int4x2 FDJMPMPEJKP;

			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x2C91020", Offset = "0x2C8F820", VA = "0x182C91020", Slot = "4")]
			public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private static DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const int KCMLDILBJBC = 10;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private const double NBCPBBHJBLG = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery IDOEBKCIAHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery EBBPJEGLGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private double GDEHKJEPNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private CullingBandService GJJCCKMAKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TimeService LMENJFALMEE;

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F0A0", Offset = "0x2D0D8A0", VA = "0x182D0F0A0", Slot = "14")]
		public void CDCHANKPBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F0B0", Offset = "0x2D0D8B0", VA = "0x182D0F0B0", Slot = "15")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F4F0", Offset = "0x2D0DCF0", VA = "0x182D0F4F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F640", Offset = "0x2D0DE40", VA = "0x182D0F640", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F480", Offset = "0x2D0DC80", VA = "0x182D0F480")]
		private bool IEPAKDLBHBK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F140", Offset = "0x2D0D940", VA = "0x182D0F140")]
		private void DDBKMFJJOFO(EntityQuery PPFDACOOOGO, float3 FDANGGGCJFI, string LOIAMCEJAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public struct AJFHOEGNMCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Entity DJGIAPPGDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public IKGAHGHFNHM AHKNGMEFAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public IKGAHGHFNHM EJDNMJGBJFF;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	public class ProcessCullingBandChangeCallbacks : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CullingBandService GJJCCKMAKKI;

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x28B4D80", Offset = "0x28B3580", VA = "0x1828B4D80", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x28B4DD0", Offset = "0x28B35D0", VA = "0x1828B4DD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[IECCMKJMAAC(LAEALBOAPLI.Connectables)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	public class UpdateInertialProperties : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery BFJFMDKNBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private CJLNAACEAHN EGNAOPLFOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x2CABDD0", Offset = "0x2CAA5D0", VA = "0x182CABDD0", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x2CABE40", Offset = "0x2CAA640", VA = "0x182CABE40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2CABED0", Offset = "0x2CAA6D0", VA = "0x182CABED0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[HCBICNINHAE]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> AJOFMAGODBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> CCLLAGGAOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> AOMLDPNPLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private KinematicSleepChangeService AEELJHIPONF;

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x31C2440", Offset = "0x31C0C40", VA = "0x1831C2440", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x31C31F0", Offset = "0x31C19F0", VA = "0x1831C31F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x31C2330", Offset = "0x31C0B30", VA = "0x1831C2330")]
		private void AGGNHKOMGIB(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> HGPMCGJIADE, EntityQueryDesc ICLDJCAHCED, bool EBOALLKOFCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x31C21F0", Offset = "0x31C09F0", VA = "0x1831C21F0")]
		private void AGGNHKOMGIB(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> HGPMCGJIADE, EntityQueryDesc ICLDJCAHCED, bool EBOALLKOFCH, bool KDOCAGECAOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x31C3450", Offset = "0x31C1C50", VA = "0x1831C3450", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x31C27C0", Offset = "0x31C0FC0", VA = "0x1831C27C0")]
		private void HMCOBDGBJOH(EntityQuery PPFDACOOOGO, bool JBJPOLGDFHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x31C2CC0", Offset = "0x31C14C0", VA = "0x1831C2CC0")]
		private void LFGBDCCFAGO(EntityQuery PPFDACOOOGO, bool DBELNIPDDEP, bool JBJPOLGDFHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x31C2520", Offset = "0x31C0D20", VA = "0x1831C2520")]
		private void ENJIEEAGBHM(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x31C29B0", Offset = "0x31C11B0", VA = "0x1831C29B0")]
		private void IOILHFHPJPI(NativeList<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x31C30D0", Offset = "0x31C18D0", VA = "0x1831C30D0")]
		private void OHDFKJNBFKM(NativeArray<Entity> NBDCDJJEKHD, bool DBELNIPDDEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x31C2ED0", Offset = "0x31C16D0", VA = "0x1831C2ED0")]
		private NativeList<Entity> NMBABCNBAJH(NativeArray<Entity> NBDCDJJEKHD)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x31C2740", Offset = "0x31C0F40", VA = "0x1831C2740")]
		private NativeList<Entity> FCJIBKKJGIP(NativeArray<Entity> NBDCDJJEKHD)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x31C2780", Offset = "0x31C0F80", VA = "0x1831C2780")]
		private NativeList<Entity> HLCJPLDNMKC(NativeArray<Entity> NBDCDJJEKHD)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x31C2B20", Offset = "0x31C1320", VA = "0x1831C2B20")]
		private NativeList<Entity> KNGBOAJCBGM(NativeArray<Entity> NBDCDJJEKHD, bool AGBAJBBOEFI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x31C2490", Offset = "0x31C0C90", VA = "0x1831C2490")]
		private FNBODMLCCAN DLMDABCNCHB(NativeArray<Entity> NBDCDJJEKHD)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(FNBODMLCCAN);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x31C3770", Offset = "0x31C1F70", VA = "0x1831C3770")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private KinematicSleepChangeService AEELJHIPONF;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x28B4DF0", Offset = "0x28B35F0", VA = "0x1828B4DF0", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x28B4E40", Offset = "0x28B3640", VA = "0x1828B4E40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : LJCGDKNAHPO
	{
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery OELIEBKJMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery BEJBNPIFMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery CGAFEAPGJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery DCINPNKNKCF;

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E560", Offset = "0x2D1CD60", VA = "0x182D1E560", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E720", Offset = "0x2D1CF20", VA = "0x182D1E720", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E320", Offset = "0x2D1CB20", VA = "0x182D1E320")]
		private void OAFPNLNDMLB(EntityQuery PPFDACOOOGO, bool AOKBJAFIAFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D1E0E0", Offset = "0x2D1C8E0", VA = "0x182D1E0E0")]
		private void MJOGFHDJCON(EntityQuery PPFDACOOOGO, bool AOKBJAFIAFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	internal class AssignPlayerIdsSystem : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery CDAMAMHGHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery LANLAJJIMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private SceneService NHAGBLLKJEL;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D099B0", Offset = "0x2D081B0", VA = "0x182D099B0", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A100", Offset = "0x2D08900", VA = "0x182D0A100", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A210", Offset = "0x2D08A10", VA = "0x182D0A210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2D09E80", Offset = "0x2D08680", VA = "0x182D09E80")]
		private void LIJFJIBGEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2D09840", Offset = "0x2D08040", VA = "0x182D09840")]
		private void AJKFBOBCJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D09A20", Offset = "0x2D08220", VA = "0x182D09A20")]
		private void HPFAHOACHPF(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D09D40", Offset = "0x2D08540", VA = "0x182D09D40")]
		private void KFKNFLPHMNP(NativeArray<Entity> NBDCDJJEKHD, int DLLCLLIEMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2D09FF0", Offset = "0x2D087F0", VA = "0x182D09FF0")]
		private void NPBKKAKOGKO(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D09F90", Offset = "0x2D08790", VA = "0x182D09F90")]
		private void MHAKGMCJEOK(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		private static void JNPKPDJCLKK(int EBHCCAJEKMJ, Transform KPFEIMOAGDN, Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class ICEKCPDPDCE
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x31CFB90", Offset = "0x31CE390", VA = "0x1831CFB90")]
	public static bool AELCEFCACBB(this SystemBase NDAAFLCINNI, out Entity DJGIAPPGDDP)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery LDILEJPFBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private BJFMFKKFIDI BAHKIDOHCPG;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2D11210", Offset = "0x2D0FA10", VA = "0x182D11210", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2D11260", Offset = "0x2D0FA60", VA = "0x182D11260", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2D11320", Offset = "0x2D0FB20", VA = "0x182D11320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<CHMADGDCPBI>, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private const string COEEICKJDNC = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private NMPFDHBEMLP EGJOKIKNCMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery PACPCFFNGKJ;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private Entity BPDDHGFGKEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x31DCAF0", Offset = "0x31DB2F0", VA = "0x1831DCAF0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x31DC540", Offset = "0x31DAD40", VA = "0x1831DC540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity EPJFHFPFGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x31DC470", Offset = "0x31DAC70", VA = "0x1831DC470")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public FJJPMAIFPPM NPMILGACLHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x31DC610", Offset = "0x31DAE10", VA = "0x1831DC610")]
			get
			{
				return default(FJJPMAIFPPM);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x31DC5A0", Offset = "0x31DADA0", VA = "0x1831DC5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public FJJPMAIFPPM CKNHHMFKBPH
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x31DCC30", Offset = "0x31DB430", VA = "0x1831DCC30")]
			get
			{
				return default(FJJPMAIFPPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x31DCD00", Offset = "0x31DB500", VA = "0x1831DCD00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x31DC4D0", Offset = "0x31DACD0", VA = "0x1831DC4D0", Slot = "15")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x31DCDA0", Offset = "0x31DB5A0", VA = "0x1831DCDA0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x31DC6A0", Offset = "0x31DAEA0", VA = "0x1831DC6A0", Slot = "14")]
		protected override void IJHFHCLFCKC(NativeArray<Entity> NBDCDJJEKHD, NativeArray<Entity> OPMDEAAPIHM, NativeArray<Entity> HOJONLKCCAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x31DCB50", Offset = "0x31DB350", VA = "0x1831DCB50")]
		private void NGMPNMLHNON(NativeArray<Entity> NBDCDJJEKHD, NativeArray<Entity> HOJONLKCCAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x31DC850", Offset = "0x31DB050", VA = "0x1831DC850")]
		private void LIFDEMLDBJK(Entity DJGIAPPGDDP, Entity KKANPLKEOPE, Entity ECIOLDBENLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x24F1450", Offset = "0x24EFC50", VA = "0x1824F1450")]
		private bool GKBJHBOCHEL<T>(out T NPHADDCNBHE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x24F1390", Offset = "0x24EFB90", VA = "0x1824F1390")]
		private void GGODOINIDBK<T>(T NPHADDCNBHE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x31DC7F0", Offset = "0x31DAFF0", VA = "0x1831DC7F0")]
		public bool LEMELMMPNHG(FJJPMAIFPPM FAMMAINOPDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x31DC440", Offset = "0x31DAC40", VA = "0x1831DC440")]
		private static bool BGBCBOIMLAL(FJJPMAIFPPM JDLNMAPEPMJ, FJJPMAIFPPM GOOFJBAPGCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x31DCE70", Offset = "0x31DB670", VA = "0x1831DCE70")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x31DCCC0", Offset = "0x31DB4C0", VA = "0x1831DCCC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery PPFDACOOOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2D19740", Offset = "0x2D17F40", VA = "0x182D19740", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x2D19790", Offset = "0x2D17F90", VA = "0x182D19790", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x2D19830", Offset = "0x2D18030", VA = "0x182D19830", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2D195F0", Offset = "0x2D17DF0", VA = "0x182D195F0")]
		private NativeArray<Entity> BKKOADCIFFP(int FCKFNIPNJCI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2D19C80", Offset = "0x2D18480", VA = "0x182D19C80")]
		private void PKIIJNFPGHI(NativeArray<Entity> PEGLAHPPHJI, NativeArray<Entity> JEHMHBGGJOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	internal class HideRemotePivotsNotInScope : FGEMHNBDPAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery HFGANGNIIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery PBCJECLGLBI;

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x31CD300", Offset = "0x31CBB00", VA = "0x1831CD300", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x31CD3F0", Offset = "0x31CBBF0", VA = "0x1831CD3F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal static class EDFPKKPNGCF
{
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public const string GHOPNGACBKD = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x230F780", Offset = "0x230DF80", VA = "0x18230F780")]
	public static NativeArray<T> LFGDOBGCHBK<T>(NativeArray<Entity> NBDCDJJEKHD, EntityManager AIFDIGHJEAF) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x2D21C70", Offset = "0x2D20470", VA = "0x182D21C70")]
	public static void NMDCCHFAOMK(EntityQuery PPFDACOOOGO, EntityManager AIFDIGHJEAF, GGNOOGMPGOK KKLJBHKLNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2D21A10", Offset = "0x2D20210", VA = "0x182D21A10")]
	public static void AJANEIEANLG(NativeArray<Entity> PEGLAHPPHJI, GGNOOGMPGOK KKLJBHKLNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x2D21B40", Offset = "0x2D20340", VA = "0x182D21B40")]
	public static void FPJJIFAJBOK(NativeArray<Entity> PEGLAHPPHJI, GGNOOGMPGOK KKLJBHKLNFJ)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery PPFDACOOOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TransformService FLBPGJKFMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ObjectLifecycleService KPJGDFLAFMG;

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA370", Offset = "0x2CA8B70", VA = "0x182CAA370", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2CABCD0", Offset = "0x2CAA4D0", VA = "0x182CABCD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2CABD70", Offset = "0x2CAA570", VA = "0x182CABD70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB3B0", Offset = "0x2CA9BB0", VA = "0x182CAB3B0")]
		private void IDPJJGJADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2CABBC0", Offset = "0x2CAA3C0", VA = "0x182CABBC0")]
		private void OOPCDKPOBBJ(NativeArray<Entity> PEGLAHPPHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2CAAAE0", Offset = "0x2CA92E0", VA = "0x182CAAAE0")]
		private void FOOIBLCEEIK(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA400", Offset = "0x2CA8C00", VA = "0x182CAA400")]
		private void CPGMBMNDKKH(NativeArray<Entity> JEHMHBGGJOD, NativeArray<RigidTransform> CPCAFPNKLLA, NativeArray<RigidTransform> DFAKEODFEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA650", Offset = "0x2CA8E50", VA = "0x182CAA650")]
		private void EPKLJLBOAAN(NativeArray<RigidTransform> DFAKEODFEJN, NativeArray<Entity> JEHMHBGGJOD, NativeList<Entity> NCPHFHNMJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	internal class PostGameplayOnScopeChange : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery LDILEJPFBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery GDGFKPJKDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x28B3330", Offset = "0x28B1B30", VA = "0x1828B3330", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x28B3410", Offset = "0x28B1C10", VA = "0x1828B3410", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x28B3560", Offset = "0x28B1D60", VA = "0x1828B3560", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x28B33A0", Offset = "0x28B1BA0", VA = "0x1828B33A0")]
		private void LNDKDKLNDFG(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	internal class PreventDisembodiedScopesSystem : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EntityQuery BKPAKPBGAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private EntityHierarchyParents OJCGOLJENME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private BJFMFKKFIDI BAHKIDOHCPG;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x28B4A60", Offset = "0x28B3260", VA = "0x1828B4A60", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x28B4C80", Offset = "0x28B3480", VA = "0x1828B4C80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x28B4D20", Offset = "0x28B3520", VA = "0x1828B4D20", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x28B4AF0", Offset = "0x28B32F0", VA = "0x1828B4AF0")]
		private void DINNDDJGBGE(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<LBIOBIKCNNJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x2C960A0", Offset = "0x2C948A0", VA = "0x182C960A0", Slot = "14")]
		protected override void IJHFHCLFCKC(NativeArray<Entity> NBDCDJJEKHD, NativeArray<Entity> OPMDEAAPIHM, NativeArray<Entity> HOJONLKCCAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2C961F0", Offset = "0x2C949F0", VA = "0x182C961F0")]
		[BurstCompile]
		private static void IJHFHCLFCKC(NativeArray<Entity> NBDCDJJEKHD, NativeArray<Entity> HOJONLKCCAJ, ComponentDataFromEntity<global::DHBELJENLBN> KJHCDIMFCAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2C96300", Offset = "0x2C94B00", VA = "0x182C96300")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2C962C0", Offset = "0x2C94AC0", VA = "0x182C962C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[IECCMKJMAAC(LAEALBOAPLI.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : FGEMHNBDPAP where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private EntityQuery ONJIHDJIDIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery FFLIAOKIIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private EntityQuery OINDDAKPDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private EntityQuery FOFCPHDEBFK;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x434FFC0", Offset = "0x434E7C0", VA = "0x18434FFC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x4350390", Offset = "0x434EB90", VA = "0x184350390", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x4350360", Offset = "0x434EB60", VA = "0x184350360", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x434E6C0", Offset = "0x434CEC0", VA = "0x18434E6C0")]
		private void ELHIBPJDFPG(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x434FBD0", Offset = "0x434E3D0", VA = "0x18434FBD0")]
		private void HBIOHMCDGKF(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x434EF40", Offset = "0x434D740", VA = "0x18434EF40")]
		private void EMCKDNCEKML(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void IJHFHCLFCKC(NativeArray<Entity> NBDCDJJEKHD, NativeArray<Entity> OPMDEAAPIHM, NativeArray<Entity> HOJONLKCCAJ);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x2E9C8F0", Offset = "0x2E9B0F0", VA = "0x182E9C8F0")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x149BDE0", Offset = "0x149A5E0", VA = "0x18149BDE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class CBOPDCNFGDM : FGEMHNBDPAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private List<(EntityQuery, ComponentType)> DJNFBFHLKHB;

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CA00", Offset = "0x2D0B200", VA = "0x182D0CA00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CC00", Offset = "0x2D0B400", VA = "0x182D0CC00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CD50", Offset = "0x2D0B550", VA = "0x182D0CD50")]
	public CBOPDCNFGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct HOHOJIAMAED : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public int FPGJPBIHINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public int JAFPKKDIEPK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x31C65E0", Offset = "0x31C4DE0", VA = "0x1831C65E0")]
	public static Entity AGJOPELLCGM(HOHOJIAMAED LBEMEOBAAJI)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x31C65E0", Offset = "0x31C4DE0", VA = "0x1831C65E0")]
	public static HOHOJIAMAED AGJOPELLCGM(Entity DJGIAPPGDDP)
	{
		return default(HOHOJIAMAED);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct MGAINHLHPLF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct NBNOGEGICAL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly ComponentType DPFKFHBMMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly NativeList<int> MMKNKBBOLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly NativeList<int> EPEEBEMGIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly NativeArray<Entity> NBDCDJJEKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly NativeArray<Entity> AHCGOLLMIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NativeArray<byte> ICPDCFEOPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly NativeArray<byte> FNOCDBPJMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public readonly int LALMADLCHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public readonly int MGGKBMBDHNH;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool DDLHFIGOGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x289D3B0", Offset = "0x289BBB0", VA = "0x18289D3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x289D600", Offset = "0x289BE00", VA = "0x18289D600")]
	public NBNOGEGICAL(ComponentType DPFKFHBMMCC, NativeList<int> MMKNKBBOLLG, NativeList<int> EPEEBEMGIBN, NativeArray<Entity> NBDCDJJEKHD, NativeArray<Entity> AHCGOLLMIHA, NativeArray<byte> ICPDCFEOPKL, NativeArray<byte> FNOCDBPJMGE, int LALMADLCHDN, int MGGKBMBDHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x289D4D0", Offset = "0x289BCD0", VA = "0x18289D4D0")]
	private OJMHOIEICMJ PEPOBLOACCB(NativeArray<byte> CIMBPHJAHGJ, int LHHBOCAHDEE)
	{
		return default(OJMHOIEICMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	private T PEPOBLOACCB<T>(NativeArray<byte> CIMBPHJAHGJ, int LHHBOCAHDEE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x289D430", Offset = "0x289BC30", VA = "0x18289D430")]
	public OJMHOIEICMJ GFOIBMBDBHI(int LHHBOCAHDEE)
	{
		return default(OJMHOIEICMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	public T GFOIBMBDBHI<T>(int LHHBOCAHDEE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x289D480", Offset = "0x289BC80", VA = "0x18289D480")]
	public OJMHOIEICMJ IKAJLAOHINN(int LHHBOCAHDEE)
	{
		return default(OJMHOIEICMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	public T IKAJLAOHINN<T>(int LHHBOCAHDEE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x289D2D0", Offset = "0x289BAD0", VA = "0x18289D2D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct CPEHBEDBLME : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public readonly EntityQuery PPFDACOOOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly NativeArray<PGKLFOKBPCK> AIDEINAMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly ComponentType DPFKFHBMMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly int LALMADLCHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly int MGGKBMBDHNH;

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F070", Offset = "0x2D0D870", VA = "0x182D0F070")]
	public CPEHBEDBLME(ComponentType DPFKFHBMMCC, int LALMADLCHDN, int MGGKBMBDHNH, EntityQuery PPFDACOOOGO, NativeArray<PGKLFOKBPCK> AIDEINAMABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F020", Offset = "0x2D0D820", VA = "0x182D0F020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct MNJPHPBBEII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public int LHHBOCAHDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public int ANAMLNPOJBK;

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x6F6050", Offset = "0x6F4850", VA = "0x1806F6050")]
	public MNJPHPBBEII(int LHHBOCAHDEE, int ANAMLNPOJBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct PGKLFOKBPCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly int OBHIANFIDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly int GIGKIGNPJAP;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x6F6050", Offset = "0x6F4850", VA = "0x1806F6050")]
	public PGKLFOKBPCK(int OBHIANFIDPA, int GIGKIGNPJAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct NELJJCBIPGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly OBIAPIAFCLH MKEJJPNNCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int LALMADLCHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private unsafe readonly byte* ICPDCFEOPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private unsafe readonly byte* FNOCDBPJMGE;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool HOFMIBPEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x289E0B0", Offset = "0x289C8B0", VA = "0x18289E0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public OBIAPIAFCLH HJBBBJOEKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40")]
		get
		{
			return default(OBIAPIAFCLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x289DFC0", Offset = "0x289C7C0", VA = "0x18289DFC0")]
	public OJMHOIEICMJ BFOFHKILGCA(Type EHPFPOFFCEJ)
	{
		return default(OJMHOIEICMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x289DED0", Offset = "0x289C6D0", VA = "0x18289DED0")]
	public OJMHOIEICMJ AHKKADAGAJL(Type EHPFPOFFCEJ)
	{
		return default(OJMHOIEICMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x1F212C0", Offset = "0x1F1FAC0", VA = "0x181F212C0")]
	public T BFOFHKILGCA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x1F212A0", Offset = "0x1F1FAA0", VA = "0x181F212A0")]
	public T AHKKADAGAJL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x289E0C0", Offset = "0x289C8C0", VA = "0x18289E0C0")]
	public unsafe NELJJCBIPGD(OBIAPIAFCLH MKEJJPNNCOG, int GIGKIGNPJAP, byte* ICPDCFEOPKL, byte* FNOCDBPJMGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal abstract class LOLHFPDAFAJ : AMLOANEKHPN, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private PropertyDiffStateService FGMABDJHGFG;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected abstract CNADGMDJLKK LMHOGBIJELC
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x31DC120", Offset = "0x31DA920", VA = "0x1831DC120", Slot = "17")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x31DC3B0", Offset = "0x31DABB0", VA = "0x1831DC3B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x31DC170", Offset = "0x31DA970", VA = "0x1831DC170", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	protected LOLHFPDAFAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class OOMBEEPEHNB
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] IDDCJDMIOIN;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[DefaultMember("Item")]
internal class LEDNMBKMJJA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly DELGGOALDMF MGFJDFPNJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly Dictionary<ComponentType, CPEHBEDBLME> PBPIANKJHAM;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public CPEHBEDBLME IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x31D9EC0", Offset = "0x31D86C0", VA = "0x1831D9EC0")]
		get
		{
			return default(CPEHBEDBLME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x31D9530", Offset = "0x31D7D30", VA = "0x1831D9530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x31DA000", Offset = "0x31D8800", VA = "0x1831DA000")]
	public LEDNMBKMJJA(PNONIBNMECP MOMLDEEAAPM, DELGGOALDMF MGFJDFPNJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x31D9960", Offset = "0x31D8160", VA = "0x1831D9960")]
	public bool FEEDILOKHNP(ComponentType DPFKFHBMMCC, out CPEHBEDBLME CDFGNMNLBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x31D99D0", Offset = "0x31D81D0", VA = "0x1831D99D0")]
	public Dictionary<ComponentType, CPEHBEDBLME>.Enumerator GCCEKDHECEG()
	{
		return default(Dictionary<ComponentType, CPEHBEDBLME>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x31D97D0", Offset = "0x31D7FD0", VA = "0x1831D97D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x31D9A60", Offset = "0x31D8260", VA = "0x1831D9A60")]
	private void GHPCOOMFNNH(IEnumerable<NDFGOBMDHCC> AHBGHOCLBDM, EntityManager AIFDIGHJEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x31D9F50", Offset = "0x31D8750", VA = "0x1831D9F50")]
	private static int ODHEBNCKOIK(NDFGOBMDHCC FIEBNCFJODK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x31D9580", Offset = "0x31D7D80", VA = "0x1831D9580")]
	private static NativeArray<PGKLFOKBPCK> CIPMFLMPPPN(NDFGOBMDHCC FIEBNCFJODK, Allocator OODGOAPHOCI = Allocator.Persistent)
	{
		return default(NativeArray<PGKLFOKBPCK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal interface MMBDFNOODFB
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool DDLHFIGOGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	World NGMBKINDIII
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MKLHPHBMANE(out NativeArray<int> KCGIEBMNDPD, Allocator OODGOAPHOCI);

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IDMMEBGCCCJ(ComponentType DPFKFHBMMCC, out NBNOGEGICAL BLKBMKCAFJK, out CPEHBEDBLME NKEIPCKGGAH);

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IDMMEBGCCCJ(ComponentType DPFKFHBMMCC, out NBNOGEGICAL BLKBMKCAFJK);

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NBNOGEGICAL LOJNLNEMANP(ComponentType DPFKFHBMMCC);

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HAJECJBJPCH LKGEMIKGHCM();

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HILFCJKJNOF(JobHandle DOPBMBDFIJE);
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
internal interface KNHPDDPKLHN
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	World NGMBKINDIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	LEDNMBKMJJA LGDDCKFBELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	GDDOIJDAFJG JCGAKCMDMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NativeMultiHashMap<Entity, NELJJCBIPGD> PPKHDKMOGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JobHandle MDAMPHEGKKE
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
	bool AOGHGHFDMOA();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MMLFENDEPMM();

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PIPJFHEJELJ(ComponentType DPFKFHBMMCC, in NBNOGEGICAL MEDLJEFNJBM);

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KFIFLCMOIAI(KCPOKGIHHKK GANNEANJGDH, out Entity ONIHIIPCKEF);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct HAJECJBJPCH
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public struct AIEMDKNLLNB : IEnumerator<NELJJCBIPGD>, IEnumerator, IDisposable, IEnumerable<NELJJCBIPGD>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly NativeMultiHashMap<Entity, NELJJCBIPGD> JFGKCBHLINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly Entity DJGIAPPGDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private NativeMultiHashMapIterator<Entity> DEBKCLEMFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private NELJJCBIPGD FNOCDBPJMGE;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public NELJJCBIPGD ILEBONKALNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0xCCCD30", Offset = "0xCCB530", VA = "0x180CCCD30", Slot = "4")]
			get
			{
				return default(NELJJCBIPGD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x41878B0", Offset = "0x41860B0", VA = "0x1841878B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x4187900", Offset = "0x4186100", VA = "0x184187900")]
		internal AIEMDKNLLNB(NativeMultiHashMap<Entity, NELJJCBIPGD> JFGKCBHLINC, Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x41876A0", Offset = "0x4185EA0", VA = "0x1841876A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x4187670", Offset = "0x4185E70", VA = "0x184187670")]
		public AIEMDKNLLNB GCCEKDHECEG()
		{
			return default(AIEMDKNLLNB);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x4187770", Offset = "0x4185F70", VA = "0x184187770", Slot = "9")]
		private IEnumerator<NELJJCBIPGD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x4187810", Offset = "0x4186010", VA = "0x184187810", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly KNHPDDPKLHN DMJFIAAGODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly JobHandle HHEEEKGGNBJ;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int MKJJMPFEIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x31CADC0", Offset = "0x31C95C0", VA = "0x1831CADC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool IMLDPEBIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x31CACE0", Offset = "0x31C94E0", VA = "0x1831CACE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C7A0", Offset = "0x1C5AFA0", VA = "0x181C5C7A0")]
	public HAJECJBJPCH(KNHPDDPKLHN DMJFIAAGODA, JobHandle HHEEEKGGNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x31CA910", Offset = "0x31C9110", VA = "0x1831CA910")]
	public bool AIOPAEGEKGN(Allocator OODGOAPHOCI, out NativeKeyValueArrays<Entity, NELJJCBIPGD> KGFIMLECODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x31CAB70", Offset = "0x31C9370", VA = "0x1831CAB70")]
	public bool KPBOEEMJIBH(Allocator OODGOAPHOCI, out (NativeArray<Entity> entities, int uniqueCount) KGFIMLECODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x31CAA50", Offset = "0x31C9250", VA = "0x1831CAA50")]
	public AIEMDKNLLNB BCGKJMAFJKB(Entity DJGIAPPGDDP)
	{
		return default(AIEMDKNLLNB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[DefaultMember("Item")]
internal class GDDOIJDAFJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly DELGGOALDMF MGFJDFPNJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly List<CPEHBEDBLME> HGPMCGJIADE;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public CPEHBEDBLME IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x31C85F0", Offset = "0x31C6DF0", VA = "0x1831C85F0")]
		get
		{
			return default(CPEHBEDBLME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x31C8080", Offset = "0x31C6880", VA = "0x1831C8080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x31C8680", Offset = "0x31C6E80", VA = "0x1831C8680")]
	public GDDOIJDAFJG(LEDNMBKMJJA PBPIANKJHAM, PNONIBNMECP MOMLDEEAAPM, DELGGOALDMF MGFJDFPNJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x31C8240", Offset = "0x31C6A40", VA = "0x1831C8240")]
	public List<CPEHBEDBLME>.Enumerator GCCEKDHECEG()
	{
		return default(List<CPEHBEDBLME>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x31C80C0", Offset = "0x31C68C0", VA = "0x1831C80C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x31C82C0", Offset = "0x31C6AC0", VA = "0x1831C82C0")]
	private void GHPCOOMFNNH(LEDNMBKMJJA PBPIANKJHAM, EntityManager AIFDIGHJEAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class MLLAOIOGHCD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly DELGGOALDMF MGFJDFPNJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly ObjectInstantiationService HFGBBMMCEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly global::APNDKDHFDGE<NDFGOBMDHCC> KGPJFFHNKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly World HIOLADDKGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly EntityManager AIFDIGHJEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NativeHashMap<int, Entity> BJKLAFMPFCB;

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x289CF30", Offset = "0x289B730", VA = "0x18289CF30")]
	public MLLAOIOGHCD(ObjectInstantiationService HFGBBMMCEFF, PNONIBNMECP MOMLDEEAAPM, DELGGOALDMF MGFJDFPNJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x289B870", Offset = "0x289A070", VA = "0x18289B870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x289B810", Offset = "0x289A010", VA = "0x18289B810")]
	public bool DHOPAPOFPBP(KCPOKGIHHKK GANNEANJGDH, out Entity ONIHIIPCKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x289C7D0", Offset = "0x289AFD0", VA = "0x18289C7D0")]
	private void PCKBMNEFNAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x289BD30", Offset = "0x289A530", VA = "0x18289BD30")]
	private EntityArchetype HIIGFHILBLE(EntityArchetype OIMBPKHHNIP)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x289C3A0", Offset = "0x289ABA0", VA = "0x18289C3A0")]
	public static void NHJEMPMGNPD(EntityManager OKKBMCGGEHO, EntityManager NFGIFIIHNNG, NativeArray<Entity> MMGHHCCOBFM, NativeArray<EntityArchetype> IBJFIKOEMCN, [Optional] NativeArray<Entity> NPNBNJDDNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x289B6A0", Offset = "0x2899EA0", VA = "0x18289B6A0")]
	[Conditional("DEBUG_BUILD")]
	private static void CGIDJBOBNPF(NativeArray<EntityArchetype> PBAMOBMICPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x289BAF0", Offset = "0x289A2F0", VA = "0x18289BAF0")]
	private static string HGKCPACHNMB(EntityArchetype CGGJCIPGPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x289C260", Offset = "0x289AA60", VA = "0x18289C260")]
	[CompilerGenerated]
	internal static void MBDOEKJHGOJ(ref Span<ComponentType> FHGGFOGIKPD, ComponentType NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x289B940", Offset = "0x289A140", VA = "0x18289B940")]
	[CompilerGenerated]
	internal static void GEBNPKAPMJE(Span<ComponentType> CIMBPHJAHGJ, ref Span<ComponentType> FHGGFOGIKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x289B5C0", Offset = "0x2899DC0", VA = "0x18289B5C0")]
	[CompilerGenerated]
	internal static void BJJMCDOEHDM(Span<ComponentType> CIMBPHJAHGJ, ref Span<ComponentType> FHGGFOGIKPD, ComponentType AALFJMIGODJ)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[IECCMKJMAAC(LAEALBOAPLI.PropertyChanges)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld NLNLAIGMDEM;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D096D0", Offset = "0x2D07ED0", VA = "0x182D096D0", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D09790", Offset = "0x2D07F90", VA = "0x182D09790", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[AlwaysUpdateSystem]
	[IECCMKJMAAC(LAEALBOAPLI.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : FGEMHNBDPAP, HNOABDNADGF, INBMAMBAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct NHFCFLPPIIM : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<byte> KKKAHECKOMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<byte> OIHLJDMJNGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeArray<PGKLFOKBPCK> HLEJCLDEHEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[WriteOnly]
			public NativeList<MNJPHPBBEII>.ParallelWriter MGBBFPPDJFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int AOCJBDHEPIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int JBFHGMGJBMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker EFJBLECIODP;

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x2C930C0", Offset = "0x2C918C0", VA = "0x182C930C0", Slot = "4")]
			public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x2C93030", Offset = "0x2C91830", VA = "0x182C93030")]
			private unsafe int CMNPKJBGIFJ(byte* NPIJOJEOPOF, byte* DMKJFEIEPGB)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[BurstCompile]
		internal struct ELAACCHLMNH : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			[WriteOnly]
			public NativeList<int> MMKNKBBOLLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			[WriteOnly]
			public NativeList<int> NDFPLBBFHNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			[ReadOnly]
			public NativeList<MNJPHPBBEII> HCAAMEFIBOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public ProfilerMarker EFJBLECIODP;

			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0x2C91780", Offset = "0x2C8FF80", VA = "0x182C91780", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[BurstCompile]
		internal struct PKHIGGBLPGJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[WriteOnly]
			public NativeArray<byte> MOCKJKBJEOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			public NativeArray<Entity> NBDCDJJEKHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			[ReadOnly]
			public ComponentDataFromEntity MJBFFGKMMPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int LALMADLCHDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public ProfilerMarker EFJBLECIODP;

			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x2C94410", Offset = "0x2C92C10", VA = "0x182C94410", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[BurstCompile]
		internal struct POIMFPJGCFN : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, NELJJCBIPGD> KAMBEIDAOOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			[ReadOnly]
			public NativeArray<byte> ICPDCFEOPKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			public NativeArray<byte> FNOCDBPJMGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			public NativeArray<Entity> NBDCDJJEKHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			[ReadOnly]
			public NativeArray<PGKLFOKBPCK> IDGJJMNEJFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			[ReadOnly]
			public NativeList<int> EPEEBEMGIBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			[ReadOnly]
			public NativeList<int> MMKNKBBOLLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int KJJAFCOCNBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int MGGKBMBDHNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public ProfilerMarker EFJBLECIODP;

			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x2C949E0", Offset = "0x2C931E0", VA = "0x182C949E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private static readonly ProfilerMarker FOHHLFLPIMM;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private static readonly ProfilerMarker BMGJLEICALG;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private static readonly ProfilerMarker EAMLGJOIONN;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private static readonly ProfilerMarker ICIIDHHDLMN;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private static readonly ProfilerMarker CJHCLPBFGAF;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private static readonly ProfilerMarker OCPHAICOCHL;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private static readonly ProfilerMarker COLOOLLEMOG;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly ProfilerMarker PBGFBCAFKHC;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private static readonly ProfilerMarker HALKGJMPBDN;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private static readonly ProfilerMarker BBPMJBGEIHP;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private static readonly ProfilerMarker DCBHEEBDDOI;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly ProfilerMarker MJFMGNDOPAF;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private static readonly ProfilerMarker CFKJEPNDHBH;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private static readonly ProfilerMarker NDGPOKPDGDL;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly ProfilerMarker JHMBPAAKLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private PropertyDiffStateService FGMABDJHGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private EntityQuery EINPBMJKBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private EntityQuery DAJNLLEJKIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private EntityQuery BNEOLCEBBOK;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		internal World NGMBKINDIII
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x2D144D0", Offset = "0x2D12CD0", VA = "0x182D144D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private KNHPDDPKLHN NHJKHPBNJFH
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x2D12420", Offset = "0x2D10C20", VA = "0x182D12420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D11C60", Offset = "0x2D10460", VA = "0x182D11C60", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "15")]
		public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D141D0", Offset = "0x2D129D0", VA = "0x182D141D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D14390", Offset = "0x2D12B90", VA = "0x182D14390", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D14320", Offset = "0x2D12B20", VA = "0x182D14320", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D11890", Offset = "0x2D10090", VA = "0x182D11890")]
		private void BGIKIHHMLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D12CC0", Offset = "0x2D114C0", VA = "0x182D12CC0")]
		internal void JIPLJPBPFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D124F0", Offset = "0x2D10CF0", VA = "0x182D124F0")]
		private void JIPLJPBPFBB(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D11650", Offset = "0x2D0FE50", VA = "0x182D11650")]
		private void AMMDGOJMAIE(NativeArray<Entity> MMGHHCCOBFM, NativeArray<RRObjectPrefabData> DGHKFCLKHGM, ref NativeArray<Entity> NJBPOLFLKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D12000", Offset = "0x2D10800", VA = "0x182D12000")]
		internal void GELPJFPHJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D12020", Offset = "0x2D10820", VA = "0x182D12020")]
		private void GELPJFPHJKB(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2D12CE0", Offset = "0x2D114E0", VA = "0x182D12CE0")]
		internal void LIANBPFOGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2D13EF0", Offset = "0x2D126F0", VA = "0x182D13EF0")]
		private void OCMLAHMHGNI(KNHPDDPKLHN DMJFIAAGODA, CPEHBEDBLME NKEIPCKGGAH, bool IMEIFLAEAGN, ref JobHandle GFGGHLBDGIL, ref JobHandle GDEFFGCIODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2D13EC0", Offset = "0x2D126C0", VA = "0x182D13EC0")]
		internal bool OAILNJAINLO(in CPEHBEDBLME DMKJFEIEPGB, out JobHandle AEGKMFNDGLH, out NBNOGEGICAL CGOHBKMGJMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D134C0", Offset = "0x2D11CC0", VA = "0x182D134C0")]
		private bool OAILNJAINLO(in CPEHBEDBLME DMKJFEIEPGB, bool IMEIFLAEAGN, out JobHandle AEGKMFNDGLH, out NBNOGEGICAL CGOHBKMGJMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D11CB0", Offset = "0x2D104B0", VA = "0x182D11CB0")]
		internal (NativeList<int>, NativeList<int>) EKECPOHGKOH(NativeList<MNJPHPBBEII> HCAAMEFIBOC, int EBGHKBFPDCN, JobHandle DHCILENDCIJ, out JobHandle DOPBMBDFIJE, Allocator OODGOAPHOCI = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D12440", Offset = "0x2D10C40", VA = "0x182D12440")]
		internal static NativeArray<Entity> IHNHOGKGGNI(EntityQuery PPFDACOOOGO, out JobHandle NGPPDHEHIBJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D13440", Offset = "0x2D11C40", VA = "0x182D13440")]
		internal static NativeArray<byte> LPKGPDEMMGI(int EBBNNMNMLOE, out JobHandle IBDKGKFKJBM)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D11B50", Offset = "0x2D10350", VA = "0x182D11B50")]
		internal static NativeArray<byte> BIGBIEMCLFC(EntityQuery PPFDACOOOGO, int CGPOEJKODDA, out JobHandle IBDKGKFKJBM)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D14590", Offset = "0x2D12D90", VA = "0x182D14590")]
		internal static NativeArray<Entity> PIOJMMHOIKF(EntityQuery PPFDACOOOGO, out JobHandle HIPMIGIJFOP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2D113E0", Offset = "0x2D0FBE0", VA = "0x182D113E0")]
		internal NativeArray<byte> ABOPGDBMJIO(NativeArray<Entity> NBDCDJJEKHD, CPEHBEDBLME NKEIPCKGGAH, JobHandle DHCILENDCIJ, out JobHandle DOPBMBDFIJE, Allocator OODGOAPHOCI = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x2D11E70", Offset = "0x2D10670", VA = "0x182D11E70")]
		internal JobHandle FCMIIMGGGIL(in NBNOGEGICAL LBEMEOBAAJI, in CPEHBEDBLME NKEIPCKGGAH, NativeMultiHashMap<Entity, NELJJCBIPGD> KAMBEIDAOOC, JobHandle DHCILENDCIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1894470", Offset = "0x1892C70", VA = "0x181894470")]
		private JobHandle AIMCJDFGBBL(JobHandle JHBGFJCOIBA, JobHandle OHKDPIEPMFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1894470", Offset = "0x1892C70", VA = "0x181894470")]
		private JobHandle AIMCJDFGBBL(JobHandle JHBGFJCOIBA, JobHandle OHKDPIEPMFP, JobHandle BGBCOCKDKFO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[IECCMKJMAAC(LAEALBOAPLI.RenderEffects)]
	internal class PropagateHoverRootTag : EHNKGEPHPFH
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public struct KGHNGJHIIGL : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType IIJMBDGFDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x28B5660", Offset = "0x28B3E60", VA = "0x1828B5660", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType KMLCPOLKELM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x28B5630", Offset = "0x28B3E30", VA = "0x1828B5630", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType KDLDBFAPNCA
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x28B5600", Offset = "0x28B3E00", VA = "0x1828B5600", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x28B5690", Offset = "0x28B3E90", VA = "0x1828B5690")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[IECCMKJMAAC(LAEALBOAPLI.RenderEffects)]
	internal class PropagateSelectionRootTag : EHNKGEPHPFH
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public struct ONNPPOJHCII : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType IIJMBDGFDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x28B5700", Offset = "0x28B3F00", VA = "0x1828B5700", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType KMLCPOLKELM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x28B56D0", Offset = "0x28B3ED0", VA = "0x1828B56D0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType KDLDBFAPNCA
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x28B56A0", Offset = "0x28B3EA0", VA = "0x1828B56A0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x28B5690", Offset = "0x28B3E90", VA = "0x1828B5690")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[HCBICNINHAE]
public class JCLEPDKDNJG : LJCGDKNAHPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery PPFDACOOOGO;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x31D3930", Offset = "0x31D2130", VA = "0x1831D3930", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x31D39C0", Offset = "0x31D21C0", VA = "0x1831D39C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public JCLEPDKDNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[HCBICNINHAE]
public class AKJDJJAJMAP : LJCGDKNAHPO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct JKMGPCBFKLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public JKMGPCBFKLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct POHFFJPFMOB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct FOEBHAEELLP
		{
			[Cpp2IlInjected.Token(Token = "0x2000161")]
			[NoAlias]
			public struct DJMPDDMEACJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MJCEIKBJNFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000464")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime MLIANKLJDNO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FICCJLGCPHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> ECJHDGCKEDI;

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x418D170", Offset = "0x418B970", VA = "0x18418D170")]
			public void OFCJMCDBAHD(AKJDJJAJMAP IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x418D0F0", Offset = "0x418B8F0", VA = "0x18418D0F0")]
			public DJMPDDMEACJ FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
			{
				return default(DJMPDDMEACJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EntityManager AIFDIGHJEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NativeList<Entity> AGBDNFDCKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private FOEBHAEELLP KGMAGAHIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FOEBHAEELLP.DJMPDDMEACJ* KCHPJLFDFOM;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KJFGNIEDIHO;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KCCEINPEOCO;

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C94950", Offset = "0x2C93150", VA = "0x182C94950")]
		internal void PKEFIBJCKKH(Entity DJGIAPPGDDP, SplinePointParentData JHCOKPMEFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C949C0", Offset = "0x2C931C0", VA = "0x182C949C0", Slot = "5")]
		public void ReadFromDisplayClass(ref JKMGPCBFKLO NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C949D0", Offset = "0x2C931D0", VA = "0x182C949D0", Slot = "6")]
		public void WriteToDisplayClass(ref JKMGPCBFKLO NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C947F0", Offset = "0x2C92FF0", VA = "0x182C947F0", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C94860", Offset = "0x2C93060", VA = "0x182C94860")]
		public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, [NoAlias] ref FOEBHAEELLP.DJMPDDMEACJ APIMNOLFLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C94910", Offset = "0x2C93110", VA = "0x182C94910")]
		public void OFCJMCDBAHD(AKJDJJAJMAP IFHEBKPGABD, ref JKMGPCBFKLO NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C94780", Offset = "0x2C92F80", VA = "0x182C94780")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void ALMKLGDMEPG(ArchetypeChunkIterator* BNBLIJPHBIB, void* DHBLLJAGKCG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery OFBPIHMEFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private ProfilerMarker KFNELIPIKDL;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D08070", Offset = "0x2D06870", VA = "0x182D08070", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public AKJDJJAJMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D07E40", Offset = "0x2D06640", VA = "0x182D07E40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D07CE0", Offset = "0x2D064E0", VA = "0x182D07CE0")]
	public static EntityQuery JKAJEHJOAED(ComponentSystemBase IFHEBKPGABD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[HCBICNINHAE]
public class HIKHFPONMBI : LJCGDKNAHPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityQuery DBLPCOJNLEK;

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x31CD040", Offset = "0x31CB840", VA = "0x1831CD040", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x31CD0D0", Offset = "0x31CB8D0", VA = "0x1831CD0D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public HIKHFPONMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(JCLEPDKDNJG))]
public class PNCPHDBECOI : FGEMHNBDPAP
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x28AF800", Offset = "0x28AE000", VA = "0x1828AF800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public PNCPHDBECOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class CKFGHJLAMDK : LJCGDKNAHPO, HNOABDNADGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct IKFAHHGLHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NativeHashMap<IOAGKMCGKAI, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public IKFAHHGLHKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JNJPFJKJMHP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct GFMIONEJCOK
		{
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			public struct EDGCPFBIGBA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				public LambdaParameterValueProvider_Entity.Runtime MJCEIKBJNFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime EMEPLCHICOO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FICCJLGCPHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CNOJLHAMFEI;

			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x418DB50", Offset = "0x418C350", VA = "0x18418DB50")]
			public void OFCJMCDBAHD(CKFGHJLAMDK IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x418DAD0", Offset = "0x418C2D0", VA = "0x18418DAD0")]
			public EDGCPFBIGBA FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
			{
				return default(EDGCPFBIGBA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NativeHashMap<IOAGKMCGKAI, Entity> JFGKCBHLINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private GFMIONEJCOK KGMAGAHIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GFMIONEJCOK.EDGCPFBIGBA* KCHPJLFDFOM;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KJFGNIEDIHO;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x2C92610", Offset = "0x2C90E10", VA = "0x182C92610")]
		internal void PKEFIBJCKKH(Entity DJGIAPPGDDP, ObjectNetworkIdComponentData NIPIOFELPAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x15A2980", Offset = "0x15A1180", VA = "0x1815A2980", Slot = "5")]
		public void ReadFromDisplayClass(ref IKFAHHGLHKG NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x2093110", Offset = "0x2091910", VA = "0x182093110", Slot = "6")]
		public void WriteToDisplayClass(ref IKFAHHGLHKG NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x2C924B0", Offset = "0x2C90CB0", VA = "0x182C924B0", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x2C92520", Offset = "0x2C90D20", VA = "0x182C92520")]
		public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, ref GFMIONEJCOK.EDGCPFBIGBA APIMNOLFLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x2C925D0", Offset = "0x2C90DD0", VA = "0x182C925D0")]
		public void OFCJMCDBAHD(CKFGHJLAMDK IFHEBKPGABD, ref IKFAHHGLHKG NACAPKCDIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x2C92440", Offset = "0x2C90C40", VA = "0x182C92440")]
		public unsafe static void ALMKLGDMEPG(ArchetypeChunkIterator* BNBLIJPHBIB, void* DHBLLJAGKCG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ObjectNetworkToLocalMapService DDLHJELICBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private EntityQuery OFBPIHMEFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private ProfilerMarker KFNELIPIKDL;

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DCD0", Offset = "0x2D0C4D0", VA = "0x182D0DCD0", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E090", Offset = "0x2D0C890", VA = "0x182D0E090", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public CKFGHJLAMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DE90", Offset = "0x2D0C690", VA = "0x182D0DE90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DD30", Offset = "0x2D0C530", VA = "0x182D0DD30")]
	public static EntityQuery JKAJEHJOAED(ComponentSystemBase IFHEBKPGABD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public class NEPDKPDIJDH : LJCGDKNAHPO, HNOABDNADGF
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PDHLFPDEEDN : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct BJNGNOBAKOE
		{
			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public struct MFFNLJNIIAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				public LambdaParameterValueProvider_Entity.Runtime MJCEIKBJNFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime KJFCMDOABHL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FICCJLGCPHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> KOJOGEAAPJH;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x4188400", Offset = "0x4186C00", VA = "0x184188400")]
			public void OFCJMCDBAHD(NEPDKPDIJDH IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x4188380", Offset = "0x4186B80", VA = "0x184188380")]
			public MFFNLJNIIAK FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
			{
				return default(MFFNLJNIIAK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public NEPDKPDIJDH OJNCFDEBBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private BJNGNOBAKOE KGMAGAHIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BJNGNOBAKOE.MFFNLJNIIAK* KCHPJLFDFOM;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KJFGNIEDIHO;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x4192790", Offset = "0x4190F90", VA = "0x184192790")]
		public void PKEFIBJCKKH(Entity DJGIAPPGDDP, ParentData FHBKLMFKJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x41925C0", Offset = "0x4190DC0", VA = "0x1841925C0", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x4192660", Offset = "0x4190E60", VA = "0x184192660")]
		public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, ref BJNGNOBAKOE.MFFNLJNIIAK APIMNOLFLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x4192710", Offset = "0x4190F10", VA = "0x184192710")]
		public void OFCJMCDBAHD(NEPDKPDIJDH IFHEBKPGABD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x4192550", Offset = "0x4190D50", VA = "0x184192550")]
		public unsafe static void ALMKLGDMEPG(ArchetypeChunkIterator* BNBLIJPHBIB, void* DHBLLJAGKCG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private EntityQuery OFBPIHMEFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private ProfilerMarker KFNELIPIKDL;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x289E0E0", Offset = "0x289C8E0", VA = "0x18289E0E0", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x289E690", Offset = "0x289CE90", VA = "0x18289E690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public NEPDKPDIJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x289E2A0", Offset = "0x289CAA0", VA = "0x18289E2A0")]
	[CompilerGenerated]
	private void NEGMOBEPACO(Entity DJGIAPPGDDP, ParentData FHBKLMFKJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x289E490", Offset = "0x289CC90", VA = "0x18289E490", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x289E140", Offset = "0x289C940", VA = "0x18289E140")]
	public static EntityQuery JKAJEHJOAED(ComponentSystemBase IFHEBKPGABD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class LJCBHLBLBFJ : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private int ONJFMHEBNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery PPFDACOOOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private ObjectPrefabs HFGBBMMCEFF;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x31DB600", Offset = "0x31D9E00", VA = "0x1831DB600", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x31DB650", Offset = "0x31D9E50", VA = "0x1831DB650", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x31DB730", Offset = "0x31D9F30", VA = "0x1831DB730", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x31DB2B0", Offset = "0x31D9AB0", VA = "0x1831DB2B0")]
	private void CJLHPAJLDMD(Entity DJGIAPPGDDP, KCPOKGIHHKK GANNEANJGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public LJCBHLBLBFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[IECCMKJMAAC(LAEALBOAPLI.Serialization)]
	[UpdateBefore(typeof(LJCBHLBLBFJ))]
	public class PostLoadAddSceneTagEntity : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private SceneService NHAGBLLKJEL;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x28B3670", Offset = "0x28B1E70", VA = "0x1828B3670", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x28B36C0", Offset = "0x28B1EC0", VA = "0x1828B36C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[KKJJBJLJHEJ(EKKHFCELHOI.OMRoom)]
	[IECCMKJMAAC(LAEALBOAPLI.Serialization)]
	public class PostLoadInitializeNetworkId : FGEMHNBDPAP, HNOABDNADGF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct MKMBOMGCJCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public NativeHashMap<IOAGKMCGKAI, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
			public MKMBOMGCJCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct NHHOBJDEEJF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000172")]
			private struct LCCJGGNBABI
			{
				[Cpp2IlInjected.Token(Token = "0x2000173")]
				[NoAlias]
				public struct FILPHOCIHME
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000491")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime MJCEIKBJNFK;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000492")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime APMMKMGOCNA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000493")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime EMEPLCHICOO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity FICCJLGCPHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400048F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex EKGKNOJMANI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000490")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CNOJLHAMFEI;

				[Cpp2IlInjected.Token(Token = "0x6000A32")]
				[Cpp2IlInjected.Address(RVA = "0x4190340", Offset = "0x418EB40", VA = "0x184190340")]
				public void OFCJMCDBAHD(PostLoadInitializeNetworkId IFHEBKPGABD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x4190290", Offset = "0x418EA90", VA = "0x184190290")]
				public FILPHOCIHME FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
				{
					return default(FILPHOCIHME);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public NativeHashMap<IOAGKMCGKAI, Entity> JFGKCBHLINC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private LCCJGGNBABI KGMAGAHIKDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe LCCJGGNBABI.FILPHOCIHME* KCHPJLFDFOM;

			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KJFGNIEDIHO;

			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KCCEINPEOCO;

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x41913D0", Offset = "0x418FBD0", VA = "0x1841913D0")]
			internal void PKEFIBJCKKH(Entity DJGIAPPGDDP, int DHJFCKPOIDH, ref ObjectNetworkIdComponentData NIPIOFELPAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x15A2980", Offset = "0x15A1180", VA = "0x1815A2980", Slot = "5")]
			public void ReadFromDisplayClass(ref MKMBOMGCJCG NACAPKCDIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x2093110", Offset = "0x2091910", VA = "0x182093110", Slot = "6")]
			public void WriteToDisplayClass(ref MKMBOMGCJCG NACAPKCDIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x4191170", Offset = "0x418F970", VA = "0x184191170", Slot = "4")]
			public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x4191260", Offset = "0x418FA60", VA = "0x184191260")]
			public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, [NoAlias] ref LCCJGGNBABI.FILPHOCIHME APIMNOLFLFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x4191330", Offset = "0x418FB30", VA = "0x184191330")]
			public void OFCJMCDBAHD(PostLoadInitializeNetworkId IFHEBKPGABD, ref MKMBOMGCJCG NACAPKCDIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x4191100", Offset = "0x418F900", VA = "0x184191100")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void ALMKLGDMEPG(ArchetypeChunkIterator* BNBLIJPHBIB, void* DHBLLJAGKCG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[EOIIILOBJAK]
		private ObjectNetworkToLocalMapService DDLHJELICBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		[EOIIILOBJAK]
		private SceneService KCPLDCIJMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery PPFDACOOOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EntityQuery KMCABFEOLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ProfilerMarker GOAFEIHMMPM;

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x28B38D0", Offset = "0x28B20D0", VA = "0x1828B38D0", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x28B45F0", Offset = "0x28B2DF0", VA = "0x1828B45F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x28B4030", Offset = "0x28B2830", VA = "0x1828B4030", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x28B4030", Offset = "0x28B2830", VA = "0x1828B4030")]
		public void FNOBLBHEKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x28B3940", Offset = "0x28B2140", VA = "0x1828B3940")]
		private void DDEIDGCKKDH(NativeHashMap<IOAGKMCGKAI, Entity> JFGKCBHLINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x28B4100", Offset = "0x28B2900", VA = "0x1828B4100")]
		private void LDJANEPAEPK(NativeHashMap<IOAGKMCGKAI, Entity> JFGKCBHLINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x28B4360", Offset = "0x28B2B60", VA = "0x1828B4360", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x28B3E90", Offset = "0x28B2690", VA = "0x1828B3E90")]
		public static EntityQuery FDDMDOJGFFK(ComponentSystemBase IFHEBKPGABD)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class JLPMPPAMECE : FGEMHNBDPAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery KOCALLLMGNN;

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x31D6310", Offset = "0x31D4B10", VA = "0x1831D6310", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x31D63A0", Offset = "0x31D4BA0", VA = "0x1831D63A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public JLPMPPAMECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public class DIKGCFIGMEK : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::APNDKDHFDGE<KDIEDIBMBFJ> LJDNAPKHBAF;

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B740", Offset = "0x2D19F40", VA = "0x182D1B740", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2D1C0B0", Offset = "0x2D1A8B0", VA = "0x182D1C0B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2D1BF20", Offset = "0x2D1A720", VA = "0x182D1BF20")]
	private void NLEGEFDIPKN(NativeList<EntityArchetype> PBAMOBMICPD, NativeHashMap<int, HKDLOMPDCOH> NLMIGHEKOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B7E0", Offset = "0x2D19FE0", VA = "0x182D1B7E0")]
	private Span<int> EHJMKIBACPL(EntityArchetype CGGJCIPGPCI)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B670", Offset = "0x2D19E70", VA = "0x182D1B670")]
	private bool BALNEBIGCLM(int CGPOEJKODDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x2D1B920", Offset = "0x2D1A120", VA = "0x182D1B920")]
	private void MEEAPJPIPDJ(NativeHashMap<int, HKDLOMPDCOH> NLMIGHEKOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public DIKGCFIGMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[IECCMKJMAAC(LAEALBOAPLI.Serialization)]
	public class PreSerializeRemoveEntities : FGEMHNBDPAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EntityQuery CMHDIJDHDED;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x28B46E0", Offset = "0x28B2EE0", VA = "0x1828B46E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x28B4960", Offset = "0x28B3160", VA = "0x1828B4960", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[IECCMKJMAAC(LAEALBOAPLI.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : FGEMHNBDPAP, HNOABDNADGF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct BACCLOGNAPD
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
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
			public BACCLOGNAPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x2C91C40", Offset = "0x2C90440", VA = "0x182C91C40")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct FGIHLDAGJON : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[ReadOnly]
			public NativeList<int> MMKNKBBOLLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			[ReadOnly]
			public NativeArray<Entity> AHCGOLLMIHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public ComponentDataFromEntity PGJKAONKOPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			[ReadOnly]
			public NativeArray<byte> FNOCDBPJMGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public int LALMADLCHDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public ComponentType DPFKFHBMMCC;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x418BB30", Offset = "0x418A330", VA = "0x18418BB30")]
			internal void PKEFIBJCKKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x418BCF0", Offset = "0x418A4F0", VA = "0x18418BCF0", Slot = "5")]
			public void ReadFromDisplayClass(ref BACCLOGNAPD NACAPKCDIHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x418BB00", Offset = "0x418A300", VA = "0x18418BB00", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x418BB10", Offset = "0x418A310", VA = "0x18418BB10")]
			public void OFCJMCDBAHD(ShadowWorldApplyPropertyDifferencesToShadowWorld IFHEBKPGABD, ref BACCLOGNAPD NACAPKCDIHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private PropertyDiffStateService FGMABDJHGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private JobHandle CCPCHJCKEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JobHandle AEJCGCOFELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private MMBDFNOODFB DMJFIAAGODA;

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BF40", Offset = "0x2C9A740", VA = "0x182C9BF40", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BF00", Offset = "0x2C9A700", VA = "0x182C9BF00")]
		public JobHandle CHMFMCEANBJ(JobHandle DHCILENDCIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C2B0", Offset = "0x2C9AAB0", VA = "0x182C9C2B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x2C9BFA0", Offset = "0x2C9A7A0", VA = "0x182C9BFA0")]
		private bool DPFNJHOIEKD(JobHandle DHCILENDCIJ, int CGPOEJKODDA, out JobHandle FPIJJDOEBAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[OIGNJMDILHE]
[ExecuteAlways]
[UpdateInGroup(typeof(EKGJHMKLBLH))]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
internal sealed class JELOJDAFKAG : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x31D4050", Offset = "0x31D2850", VA = "0x1831D4050", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public JELOJDAFKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[OIGNJMDILHE]
[ExecuteAlways]
[UpdateInGroup(typeof(KFJBGNKENFC))]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
internal sealed class EDPNEEDDFLL : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x2D21DB0", Offset = "0x2D205B0", VA = "0x182D21DB0", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public EDPNEEDDFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[OIGNJMDILHE]
[ExecuteAlways]
[UpdateInGroup(typeof(BGEGPOKDGKJ))]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
internal sealed class HFLKCCNJHCH : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x31CBE80", Offset = "0x31CA680", VA = "0x1831CBE80", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public HFLKCCNJHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[OIGNJMDILHE]
[ExecuteAlways]
[UpdateInGroup(typeof(EBHEOPNGKMN))]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
internal sealed class BCCHBCHHCKK : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A280", Offset = "0x2D08A80", VA = "0x182D0A280", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public BCCHBCHHCKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class JLKBGKOPBJD : LOLHFPDAFAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override CNADGMDJLKK LMHOGBIJELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAA0", Offset = "0x6FA2A0", VA = "0x1806FBAA0", Slot = "18")]
		get
		{
			return default(CNADGMDJLKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public JLKBGKOPBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[OIGNJMDILHE]
[ExecuteAlways]
[UpdateInGroup(typeof(BGDJHFPBMFO))]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
internal sealed class KIEIKNBEBIB : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x31D7320", Offset = "0x31D5B20", VA = "0x1831D7320", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public KIEIKNBEBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class DNDKBCLBAJJ : JHAOANHDNMH
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public DNDKBCLBAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class GAAKEBMGEMH : LOLHFPDAFAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override CNADGMDJLKK LMHOGBIJELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x6DC170", Offset = "0x6DA970", VA = "0x1806DC170", Slot = "18")]
		get
		{
			return default(CNADGMDJLKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public GAAKEBMGEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[OIGNJMDILHE]
[ExecuteAlways]
[UpdateInGroup(typeof(CHMHBHDDDJC))]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
internal sealed class HIAIHHIFFKN : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x31CC050", Offset = "0x31CA850", VA = "0x1831CC050", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public HIAIHHIFFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class KAONGJCOGEG : JHAOANHDNMH
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public KAONGJCOGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class IIPGKEOIBIB : JHAOANHDNMH
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public IIPGKEOIBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class GJMBEIODMKA : FGEMHNBDPAP
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public GJMBEIODMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[HCBICNINHAE]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
public class CADFANEDBKG : FGEMHNBDPAP, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private TimeService LMENJFALMEE;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C990", Offset = "0x2D0B190", VA = "0x182D0C990", Slot = "14")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C9E0", Offset = "0x2D0B1E0", VA = "0x182D0C9E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public CADFANEDBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.TransformSyncing)]
	public class CopyTransformDataFromGameObjects : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct LFNKILNPOPB : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private const float DHPOANBLOBE = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[ReadOnly]
			public NativeArray<Entity> NBDCDJJEKHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> MHHECHAHFGO;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x2C92BE0", Offset = "0x2C913E0", VA = "0x182C92BE0", Slot = "4")]
			public void Execute(int LHHBOCAHDEE, TransformAccess KPFEIMOAGDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x2C92E10", Offset = "0x2C91610", VA = "0x182C92E10")]
			private bool PGCFGCBLAKF(float3 EJDNMJGBJFF, float3 AHKNGMEFAGI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x2C92DA0", Offset = "0x2C915A0", VA = "0x182C92DA0")]
			private bool LEGKBGMHHLP(quaternion EJDNMJGBJFF, quaternion AHKNGMEFAGI)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		private struct PLBAFFFHFPC : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			[ReadOnly]
			public NativeArray<Entity> NBDCDJJEKHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> ADCMLDDALKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> HMJKGHDFCDK;

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x2C94560", Offset = "0x2C92D60", VA = "0x182C94560", Slot = "4")]
			public void Execute(int LHHBOCAHDEE, TransformAccess KPFEIMOAGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly DELGGOALDMF MNHLCOMONNH;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly DELGGOALDMF EFDBPDHALCB;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly DELGGOALDMF HFJGILJBCFL;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly ProfilerMarker FPBHOBIGALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private LAFBPDEGHKC KPEDMBKKANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private PNONIBNMECP MOMLDEEAAPM;

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2D17840", Offset = "0x2D16040", VA = "0x182D17840", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2D178B0", Offset = "0x2D160B0", VA = "0x182D178B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x2D178E0", Offset = "0x2D160E0", VA = "0x182D178E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[IECCMKJMAAC(LAEALBOAPLI.TransformSyncing)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	public class RegisterTransforms : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct BDABBKEMCBM : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct LDOPNHDPLAC
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				public struct BGFIKBNIPHE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004CA")]
					public LambdaParameterValueProvider_Entity.Runtime MJCEIKBJNFK;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004CB")]
					public LambdaParameterValueProvider_IComponentData<MJIDDILELFC>.Runtime FHMAAKHFDBO;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004CC")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime FOIJJOAAIKK;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity FICCJLGCPHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<MJIDDILELFC> NFFBJJCICEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> INLBOFLGLDD;

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x4190470", Offset = "0x418EC70", VA = "0x184190470")]
				public void OFCJMCDBAHD(RegisterTransforms IFHEBKPGABD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x41903B0", Offset = "0x418EBB0", VA = "0x1841903B0")]
				public BGFIKBNIPHE FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
				{
					return default(BGFIKBNIPHE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private LDOPNHDPLAC KGMAGAHIKDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe LDOPNHDPLAC.BGFIKBNIPHE* KCHPJLFDFOM;

			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KJFGNIEDIHO;

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x4188280", Offset = "0x4186A80", VA = "0x184188280")]
			internal void PKEFIBJCKKH(Entity DJGIAPPGDDP, MJIDDILELFC BLCDEHFGKBI, Transform KPFEIMOAGDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x41880A0", Offset = "0x41868A0", VA = "0x1841880A0", Slot = "4")]
			public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x4188190", Offset = "0x4186990", VA = "0x184188190")]
			public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, ref LDOPNHDPLAC.BGFIKBNIPHE APIMNOLFLFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x4188270", Offset = "0x4186A70", VA = "0x184188270")]
			public void OFCJMCDBAHD(RegisterTransforms IFHEBKPGABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x4188030", Offset = "0x4186830", VA = "0x184188030")]
			public unsafe static void ALMKLGDMEPG(ArchetypeChunkIterator* BNBLIJPHBIB, void* DHBLLJAGKCG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct BLOFIAMMALG : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000190")]
			private struct IOMAKOFFFMA
			{
				[Cpp2IlInjected.Token(Token = "0x2000191")]
				[NoAlias]
				public struct HGOJBCAFOKB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004D1")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime MJCEIKBJNFK;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004D2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<MJIDDILELFC>.Runtime FHMAAKHFDBO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004CF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity FICCJLGCPHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004D0")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<MJIDDILELFC> NFFBJJCICEB;

				[Cpp2IlInjected.Token(Token = "0x6000AA3")]
				[Cpp2IlInjected.Address(RVA = "0x41885A0", Offset = "0x4186DA0", VA = "0x1841885A0")]
				public void OFCJMCDBAHD(RegisterTransforms IFHEBKPGABD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x418EAB0", Offset = "0x418D2B0", VA = "0x18418EAB0")]
				public HGOJBCAFOKB FPPFJICNFHP(ref ArchetypeChunk HPGIJEPFCFH, int PGJFDGBJEBE, int HKOOKJMCGHK)
				{
					return default(HGOJBCAFOKB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private IOMAKOFFFMA KGMAGAHIKDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe IOMAKOFFFMA.HGOJBCAFOKB* KCHPJLFDFOM;

			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x4188600", Offset = "0x4186E00", VA = "0x184188600")]
			internal void PKEFIBJCKKH(Entity DJGIAPPGDDP, MJIDDILELFC BLCDEHFGKBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x4188460", Offset = "0x4186C60", VA = "0x184188460", Slot = "4")]
			public void Execute(ArchetypeChunk FMCANOMFDBO, int MIFNFLOKLOO, int EOPFMAFJAJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x41884F0", Offset = "0x4186CF0", VA = "0x1841884F0")]
			public void KDIHKNAKGBG(ref ArchetypeChunk FMCANOMFDBO, [NoAlias] ref IOMAKOFFFMA.HGOJBCAFOKB APIMNOLFLFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x41885A0", Offset = "0x4186DA0", VA = "0x1841885A0")]
			public void OFCJMCDBAHD(RegisterTransforms IFHEBKPGABD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private LAFBPDEGHKC KPEDMBKKANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery OFIEPOLNJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery DIPACDDFFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EntityQuery PDFFLKBODLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private EntityQuery JPKDIHGBJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private EntityQuery PLJMDMMPCNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ProfilerMarker NDMLDJMGGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private EntityQuery BPFJIDKANDN;

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x2C94E30", Offset = "0x2C93630", VA = "0x182C94E30", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x2C95D70", Offset = "0x2C94570", VA = "0x182C95D70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x2C95F80", Offset = "0x2C94780", VA = "0x182C95F80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2C958C0", Offset = "0x2C940C0", VA = "0x182C958C0")]
		private void OMMGCPFLCEG(EntityQuery PPFDACOOOGO, GDIPBBIJEHP PFCJLABLDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x2C95340", Offset = "0x2C93B40", VA = "0x182C95340")]
		private void JHLBIJCOFOD(EntityQuery PPFDACOOOGO, GDIPBBIJEHP PFCJLABLDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x2C95F20", Offset = "0x2C94720", VA = "0x182C95F20", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x2C95020", Offset = "0x2C93820", VA = "0x182C95020")]
		private void IACCEJOAMBC(NativeArray<Entity> NBDCDJJEKHD, GDIPBBIJEHP PFCJLABLDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2C955B0", Offset = "0x2C93DB0", VA = "0x182C955B0")]
		[BurstCompile]
		internal static void LLLEGGILEDG(NativeArray<MJIDDILELFC> EDGGMDNFLLA, ComponentDataFromEntity<MJIDDILELFC> KKHMJBDDAMK, GDIPBBIJEHP PFCJLABLDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		private static void BJPBEMFBPPO(Transform KPFEIMOAGDN, Entity DJGIAPPGDDP, int LHHBOCAHDEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		private static void LNKJPFEAOOB(Entity DJGIAPPGDDP, int LHHBOCAHDEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		private static void IBCLILCPOCM(int LHHBOCAHDEE, GDIPBBIJEHP PFCJLABLDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2C95160", Offset = "0x2C93960", VA = "0x182C95160")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void IGNAHIPFMAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2C95B00", Offset = "0x2C94300", VA = "0x182C95B00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2C94E80", Offset = "0x2C93680", VA = "0x182C94E80")]
		public static EntityQuery HKCDHCNJPJD(ComponentSystemBase IFHEBKPGABD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x2C94C60", Offset = "0x2C93460", VA = "0x182C94C60")]
		public static EntityQuery CHCLJIPNFCB(ComponentSystemBase IFHEBKPGABD)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	[IECCMKJMAAC(LAEALBOAPLI.TransformSyncing)]
	public class CopyTransformDataToGameObjects : FGEMHNBDPAP, HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[BurstCompile]
		private struct HKDEHLBNGFC : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> MHHECHAHFGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public NativeArray<Entity> NBDCDJJEKHD;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x2C91B60", Offset = "0x2C90360", VA = "0x182C91B60", Slot = "4")]
			public void Execute(int LHHBOCAHDEE, TransformAccess KPFEIMOAGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[BurstCompile]
		private struct AFOPCMBOMOD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> ADCMLDDALKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public NativeArray<Entity> NBDCDJJEKHD;

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x2C90760", Offset = "0x2C8EF60", VA = "0x182C90760", Slot = "4")]
			public void Execute(int LHHBOCAHDEE, TransformAccess KPFEIMOAGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct PJPFOCCGOHO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> ADCMLDDALKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> HMJKGHDFCDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			[ReadOnly]
			public NativeArray<Entity> NBDCDJJEKHD;

			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x2C94310", Offset = "0x2C92B10", VA = "0x182C94310", Slot = "4")]
			public void Execute(int LHHBOCAHDEE, TransformAccess KPFEIMOAGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly DELGGOALDMF MNHLCOMONNH;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly DELGGOALDMF EFDBPDHALCB;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static readonly DELGGOALDMF HFJGILJBCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private LAFBPDEGHKC KPEDMBKKANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery FJNMCEAKGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EntityQuery JBIFBNFMAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private EntityQuery PAOOHBPNCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TransformAccessArray LIAINHLMKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TransformAccessArray BKFEHHCCBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TransformAccessArray BICCECCNFHC;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x2D17D90", Offset = "0x2D16590", VA = "0x182D17D90", Slot = "14")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x2D17F60", Offset = "0x2D16760", VA = "0x182D17F60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x2D18150", Offset = "0x2D16950", VA = "0x182D18150", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x2D181E0", Offset = "0x2D169E0", VA = "0x182D181E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x2D18210", Offset = "0x2D16A10", VA = "0x182D18210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x2D17DE0", Offset = "0x2D165E0", VA = "0x182D17DE0")]
		private NativeArray<Entity> KIAEIIMLKKO(NativeArray<MJIDDILELFC> MMKNKBBOLLG, NativeList<Entity> MMGHHCCOBFM, TransformAccessArray GOJOOILKHOG, TransformAccessArray FJOBBMEAJHE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[IECCMKJMAAC(LAEALBOAPLI.TransformSyncing)]
	[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
	public class CopyTransformParentsToGameObjects : FGEMHNBDPAP, INBMAMBAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private MGDMBBFBAJB JBLJDFDIDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private LLOMGAJNLGK MIBMLLHOOBD;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x28B4D20", Offset = "0x28B3520", VA = "0x1828B4D20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x2D18BE0", Offset = "0x2D173E0", VA = "0x182D18BE0", Slot = "14")]
		public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2D18E70", Offset = "0x2D17670", VA = "0x182D18E70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x2D18CF0", Offset = "0x2D174F0", VA = "0x182D18CF0")]
		private static void EIKEHBCKLKB(EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, Entity FAAJOMIIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x2D18B40", Offset = "0x2D17340", VA = "0x182D18B40")]
		private static bool BNKAAADAPEE(EntityManager AIFDIGHJEAF, Entity DJGIAPPGDDP, out Transform KPFEIMOAGDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[IECCMKJMAAC(LAEALBOAPLI.TransformSyncing)]
	public class L2PToL2WHierarchy : FGEMHNBDPAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[BurstCompile]
		private struct EDBFFPNEDDH : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> CNIBOMGEIDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> AJKOAIIFDBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> MEOFEJEGDCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> CKAIIKCAEFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public ArchetypeChunkComponentType<LocalToWorldData> HODLKEPAOBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> ILLBCAFKPGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public uint AGFGNEMMPNN;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x418A990", Offset = "0x4189190", VA = "0x18418A990")]
			[Conditional("DEBUG_BUILD")]
			private void NJLKAAOLGDO(Entity DJGIAPPGDDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x418A2A0", Offset = "0x4188AA0", VA = "0x18418A2A0", Slot = "4")]
			public void Execute(ArchetypeChunk FMCANOMFDBO, int LHHBOCAHDEE, int ODJEMDNCHIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x418A590", Offset = "0x4188D90", VA = "0x18418A590")]
			private void JPPIKJKIPFA(float4x4 NDDLLKCNCKA, Entity DJGIAPPGDDP, bool BLBDGNOAPLH, int LJGHFLLENHO = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery GBCPOGFDAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery EKKJMKACEBE;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x31D9050", Offset = "0x31D7850", VA = "0x1831D9050", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x31D9170", Offset = "0x31D7970", VA = "0x1831D9170", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class POEAADCONDB : OMFHDFNDNKE
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct GADOEHFBLKB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> CNIBOMGEIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ArchetypeChunkComponentType<LocalToWorldData> HODLKEPAOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public uint AGFGNEMMPNN;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x418D5A0", Offset = "0x418BDA0", VA = "0x18418D5A0", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int LHHBOCAHDEE, int ODJEMDNCHIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x418D520", Offset = "0x418BD20", VA = "0x18418D520")]
		public bool AJIPCBEEDJJ(ArchetypeChunk FMCANOMFDBO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery GBCPOGFDAIG;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x28AF910", Offset = "0x28AE110", VA = "0x1828AF910", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x28AFA40", Offset = "0x28AE240", VA = "0x1828AFA40", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle KHCEFIEBFOE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public POEAADCONDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class MJFMCAIMLKO : OMFHDFNDNKE
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct OKEJDJOKOHD : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> KCKPKLMKDAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public ArchetypeChunkComponentType<WorldPoseData> KMHLMPBMHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> LFHNPJMIMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> MJJNGPGAMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public uint AGFGNEMMPNN;

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x4191FD0", Offset = "0x41907D0", VA = "0x184191FD0", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int LHHBOCAHDEE, int ODJEMDNCHIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x4191F50", Offset = "0x4190750", VA = "0x184191F50")]
		public bool AJIPCBEEDJJ(ArchetypeChunk FMCANOMFDBO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery FLBPGJKFMKM;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x289AE30", Offset = "0x2899630", VA = "0x18289AE30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x289AF40", Offset = "0x2899740", VA = "0x18289AF40", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle KHCEFIEBFOE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public MJFMCAIMLKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class AMACOFJGMLK : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct JIADBFJMKCO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> IDGJGAMBMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> AJENPBLFCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> DBOILIBOIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ArchetypeChunkComponentType<LocalToParentData> LOALPNDIIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public uint AGFGNEMMPNN;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x2C91D30", Offset = "0x2C90530", VA = "0x182C91D30", Slot = "4")]
		public void Execute(ArchetypeChunk FMCANOMFDBO, int LHHBOCAHDEE, int ODJEMDNCHIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x2C91C50", Offset = "0x2C90450", VA = "0x182C91C50")]
		public bool AJIPCBEEDJJ(ArchetypeChunk FMCANOMFDBO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery FLBPGJKFMKM;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x2D08330", Offset = "0x2D06B30", VA = "0x182D08330", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x2D08460", Offset = "0x2D06C60", VA = "0x182D08460", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle KHCEFIEBFOE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20")]
	public AMACOFJGMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[IECCMKJMAAC(LAEALBOAPLI.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : EHNKGEPHPFH
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public struct BDDALCCEMOJ : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override ComponentType IIJMBDGFDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x28B5790", Offset = "0x28B3F90", VA = "0x1828B5790", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType KMLCPOLKELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x28B5760", Offset = "0x28B3F60", VA = "0x1828B5760", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType KDLDBFAPNCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x28B5730", Offset = "0x28B3F30", VA = "0x1828B5730", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x28B5690", Offset = "0x28B3E90", VA = "0x1828B5690")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x73CC20", Offset = "0x73B420", VA = "0x18073CC20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[BIHGCNEEIAG(EJBDBMPHFMP.Game)]
public class IMNGLGMGJPM : HOBANIPIPAH
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type BLNKOFGOICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x31D2130", Offset = "0x31D0930", VA = "0x1831D2130", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] LCIOEDLMHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x31D21A0", Offset = "0x31D09A0", VA = "0x1831D21A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public IMNGLGMGJPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[BIHGCNEEIAG(EJBDBMPHFMP.Loading)]
public class DEDHIJALOPC : HOBANIPIPAH
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type BLNKOFGOICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x6DC170", Offset = "0x6DA970", VA = "0x1806DC170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] LCIOEDLMHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2D1B3C0", Offset = "0x2D19BC0", VA = "0x182D1B3C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DEDHIJALOPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class ECNCPNGHNHI : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2D20E40", Offset = "0x2D1F640", VA = "0x182D20E40", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public ECNCPNGHNHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[BIHGCNEEIAG(EJBDBMPHFMP.Saving)]
public class BJBGNCALJOJ : HOBANIPIPAH
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type BLNKOFGOICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x6DC170", Offset = "0x6DA970", VA = "0x1806DC170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] LCIOEDLMHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A400", Offset = "0x2D08C00", VA = "0x182D0A400", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BJBGNCALJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class JJFOLOACBNN : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x31D5A90", Offset = "0x31D4290", VA = "0x1831D5A90", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public JJFOLOACBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[BIHGCNEEIAG(EJBDBMPHFMP.Simulation)]
public class FGOPDOIFBGF : HOBANIPIPAH
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public Type BLNKOFGOICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x31C6000", Offset = "0x31C4800", VA = "0x1831C6000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] LCIOEDLMHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x31C6070", Offset = "0x31C4870", VA = "0x1831C6070", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public FGOPDOIFBGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[FIKNCOOOHID(typeof(EIOKCNDHIDM), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
internal class EIOKCNDHIDM : INBMAMBAHGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private global::DGLIAENEEBO<AuthoredParentData, KGHDABGCNFM, DPDKHEDABKC, AuthoredChildrenData> GEJMJOEFNLB;

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x31BF580", Offset = "0x31BDD80", VA = "0x1831BF580", Slot = "4")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public EIOKCNDHIDM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[FIKNCOOOHID(typeof(EntityHierarchyParents), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.HierarchySystems)]
	internal sealed class EntityHierarchyParents : HNOABDNADGF, INBMAMBAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[EOIIILOBJAK]
		private HMGEJIKOHBO FLBPGJKFMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[EOIIILOBJAK]
		private PropertyChangeNetworkRouter DEGPLMACLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private global::LEKHCEGJOPN<Entity> NPCKPCNEDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private global::DGLIAENEEBO<ParentData, GNHNGFMKFPI, IIILNEJIKFL, ChildrenData> GEJMJOEFNLB;

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x31C4170", Offset = "0x31C2970", VA = "0x1831C4170", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x31C3FD0", Offset = "0x31C27D0", VA = "0x1831C3FD0", Slot = "5")]
		public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x31C4420", Offset = "0x31C2C20", VA = "0x1831C4420")]
		public Entity PHLGOOAEONB(Entity DJGIAPPGDDP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x31C43C0", Offset = "0x31C2BC0", VA = "0x1831C43C0")]
		public bool OLDOCOJJOPA(Entity DJGIAPPGDDP, Entity ILKPJDALDEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x31C40D0", Offset = "0x31C28D0", VA = "0x1831C40D0")]
		public bool CKPOHKFAFGL(Entity DJGIAPPGDDP, Entity ILKPJDALDEG, bool HOGIBHGKCBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x31C41E0", Offset = "0x31C29E0", VA = "0x1831C41E0")]
		private bool DEHFJIHJEPB(Entity DJGIAPPGDDP, Entity ILKPJDALDEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
[FIKNCOOOHID(typeof(IIIGDFLHPJF), new string[] { })]
internal sealed class IIIGDFLHPJF : HNOABDNADGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	[EOIIILOBJAK]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery MLOHGGGCFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EntityManager NKKGJCLICDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x31D0E30", Offset = "0x31CF630", VA = "0x1831D0E30")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x31D09C0", Offset = "0x31CF1C0", VA = "0x1831D09C0", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x31D0E10", Offset = "0x31CF610", VA = "0x1831D0E10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x31D0690", Offset = "0x31CEE90", VA = "0x1831D0690")]
	public bool BIPOOOEDCME(Entity DJGIAPPGDDP, Entity NAFEMOBEBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x31D0750", Offset = "0x31CEF50", VA = "0x1831D0750")]
	public IEnumerable<Entity> BLHBEIDAIFI(Entity DJGIAPPGDDP, bool MEEOIIMCDHN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x31D0CE0", Offset = "0x31CF4E0", VA = "0x1831D0CE0")]
	public bool DODOFFOODPK(Entity DJGIAPPGDDP, Entity PLIEEOJAEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x31D0F80", Offset = "0x31CF780", VA = "0x1831D0F80")]
	public bool LEJLCLKDFHJ(Entity DJGIAPPGDDP, Entity GFJEHCBMJMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x31D05B0", Offset = "0x31CEDB0", VA = "0x1831D05B0")]
	public NativeList<Entity> AINPGNLGOJC(Entity DJGIAPPGDDP, bool MEEOIIMCDHN = false, Allocator OODGOAPHOCI = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x31D1080", Offset = "0x31CF880", VA = "0x1831D1080")]
	public IEnumerable<Entity> LNFGNLEGECP(Entity DJGIAPPGDDP, bool MEEOIIMCDHN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x31D0ED0", Offset = "0x31CF6D0", VA = "0x1831D0ED0")]
	public Entity JKKPEICCMFG(Entity DJGIAPPGDDP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x31D0E80", Offset = "0x31CF680", VA = "0x1831D0E80")]
	public NativeArray<Entity> FDFHFHEFAJP()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x31D0AC0", Offset = "0x31CF2C0", VA = "0x1831D0AC0")]
	public bool DGHKOIDPNCJ(Entity GFJEHCBMJMC, Entity FPIHIJPFEDK, out Entity IHHHDHPFGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x31D08D0", Offset = "0x31CF0D0", VA = "0x1831D08D0")]
	private Entity CKBPCMFCCKM(Entity DJGIAPPGDDP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public IIIGDFLHPJF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[IECCMKJMAAC(LAEALBOAPLI.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x2A274E0", Offset = "0x2A25CE0", VA = "0x182A274E0")]
		public static void AOGHGHFDMOA<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(FEIANFNLNIA BDDMBDBDABJ, global::PNOGAICEIOC<Entity> OABNINOCHNF, out global::DGLIAENEEBO<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> GOFOEDDKEAK) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, NBDNEINNKHP where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, NBDNEINNKHP, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x28AFB40", Offset = "0x28AE340", VA = "0x1828AFB40")]
		public static bool BIJAFCPALCI(JPEOKMJCLOL EADBGDCJMOG)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class DGLIAENEEBO<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, NBDNEINNKHP where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, NBDNEINNKHP, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly DELGGOALDMF MGFJDFPNJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private readonly PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private readonly global::LEKHCEGJOPN<Entity> NPCKPCNEDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private readonly DPEBGGGDMAN CNBPCEHPGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private readonly OJFEPNOINDA FAAJOMIIHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly EntityManager AIFDIGHJEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly LLOMGAJNLGK MIBMLLHOOBD;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x3A99610", Offset = "0x3A97E10", VA = "0x183A99610")]
	public DGLIAENEEBO(FEIANFNLNIA BDDMBDBDABJ, global::PNOGAICEIOC<Entity> OABNINOCHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x3A98E20", Offset = "0x3A97620", VA = "0x183A98E20")]
	private bool KKBOLPADODI(Entity DJGIAPPGDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x3A98E80", Offset = "0x3A97680", VA = "0x183A98E80")]
	private bool MIMBJJHANPM(Entity DJGIAPPGDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x3A99460", Offset = "0x3A97C60", VA = "0x183A99460")]
	public bool OLDOCOJJOPA(Entity DJGIAPPGDDP, in Entity ILKPJDALDEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x3A99310", Offset = "0x3A97B10", VA = "0x183A99310")]
	public bool NBCKLCEBJNH(Entity DJGIAPPGDDP, in Entity ILKPJDALDEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x3A98ED0", Offset = "0x3A976D0", VA = "0x183A98ED0")]
	private bool NBCKLCEBJNH(Entity DJGIAPPGDDP, in Entity ILKPJDALDEG, bool FJIKGIHLFID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private static void PFHGLBJGOMI(Entity DJGIAPPGDDP, in Entity ILKPJDALDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private static void GHAFKDKPKBO(Entity DJGIAPPGDDP, in Entity ILKPJDALDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private static void MJDHBALNEPG(Entity DJGIAPPGDDP, in Entity ILKPJDALDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private static void NFPEFFCFBKI(Entity DJGIAPPGDDP, in Entity ILKPJDALDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private static void ODPFFDGFPHH(Entity DJGIAPPGDDP, in Entity ILKPJDALDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x3A982A0", Offset = "0x3A96AA0", VA = "0x183A982A0")]
	private bool BIPOOOEDCME(Entity DJGIAPPGDDP, Entity NAFEMOBEBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x3A987A0", Offset = "0x3A96FA0", VA = "0x183A987A0")]
	private void DBAPKLADPDJ(Entity DJGIAPPGDDP, in Entity KHANAHCNFDD, in Entity ILKPJDALDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x3A98600", Offset = "0x3A96E00", VA = "0x183A98600")]
	private void CDKNLEACPDK(Entity DJGIAPPGDDP, in Entity KHANAHCNFDD, in Entity ILKPJDALDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x3A98BC0", Offset = "0x3A973C0", VA = "0x183A98BC0")]
	private bool IIGKCPKGBHG(AKAEMFHNGHP HFNKCOKPGDG, in IOAGKMCGKAI POJOJDGOIGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x3A98890", Offset = "0x3A97090", VA = "0x183A98890")]
	private void HKLHHKJFAPK(Entity FAAJOMIIHED, Entity PLIEEOJAEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x3A99340", Offset = "0x3A97B40", VA = "0x183A99340")]
	private void NCDGFNDBKNE(Entity FAAJOMIIHED, Entity PLIEEOJAEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private void IBCLILCPOCM(Entity DJGIAPPGDDP, Entity KHANAHCNFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	private void BJPBEMFBPPO(Entity DJGIAPPGDDP, Entity ILKPJDALDEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct LHLJGIJIFIA : EPJOCCFBHFH, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public BDEOIFFCGBF BIMLGGHFDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x6D5000", Offset = "0x6D3800", VA = "0x1806D5000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BDEOIFFCGBF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x73A420", Offset = "0x738C20", VA = "0x18073A420", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[FIKNCOOOHID(typeof(ObjectEmbodimentService), new string[] { })]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[IECCMKJMAAC(LAEALBOAPLI.Embodiment)]
	internal sealed class ObjectEmbodimentService : DAANNPIBALJ, BGAFKNOHCIN, HNOABDNADGF, INBMAMBAHGE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private ObjectLifecycleService KPJGDFLAFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[EOIIILOBJAK]
		private PNONIBNMECP IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[EOIIILOBJAK]
		private HMGEJIKOHBO FLBPGJKFMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[EOIIILOBJAK]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[EOIIILOBJAK]
		private FAIAJFOHDOE AOPMIABPHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[EOIIILOBJAK]
		private FGJJBDJMIFL NPOGCAGMKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[EOIIILOBJAK]
		private TransformOwnershipPhase MFNNPHEMCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private readonly Dictionary<IOAGKMCGKAI, CAEEJNEMGJH> PJHMAJCADOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private MENKMJCMDCL GJHDDJKKPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager NKKGJCLICDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x28A3440", Offset = "0x28A1C40", VA = "0x1828A3440")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int NBFPAEBDJOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x28A51A0", Offset = "0x28A39A0", VA = "0x1828A51A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int NDNOILFCJEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x28A2D40", Offset = "0x28A1540", VA = "0x1828A2D40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x11A9030", Offset = "0x11A7830", VA = "0x1811A9030", Slot = "4")]
		public void CDCHANKPBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x28A2AA0", Offset = "0x28A12A0", VA = "0x1828A2AA0", Slot = "5")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x28A2D70", Offset = "0x28A1570", VA = "0x1828A2D70")]
		public void DCALDBOBOFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x28A2900", Offset = "0x28A1100", VA = "0x1828A2900", Slot = "6")]
		public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x28A2FF0", Offset = "0x28A17F0", VA = "0x1828A2FF0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x28A4700", Offset = "0x28A2F00", VA = "0x1828A4700")]
		public int HNMBPADKKBK(SceneTag CHNAEAOJAGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x28A5170", Offset = "0x28A3970", VA = "0x1828A5170")]
		public int LFPEFLNBDGE(SceneTag CHNAEAOJAGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x28A2590", Offset = "0x28A0D90", VA = "0x1828A2590")]
		public bool BJEHKHPKLGI(Entity DJGIAPPGDDP, Allocator OODGOAPHOCI, out NativeList<Entity> NAMHEKLLIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x28A56D0", Offset = "0x28A3ED0", VA = "0x1828A56D0")]
		public bool NDLHDGBCFFD(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x28A45F0", Offset = "0x28A2DF0", VA = "0x1828A45F0")]
		public bool HEGEOODMEBB(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x28A2BD0", Offset = "0x28A13D0", VA = "0x1828A2BD0")]
		public bool COKDPCHCLPD(Entity DJGIAPPGDDP, out CAEEJNEMGJH BFLDNFIFFCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x28A2C90", Offset = "0x28A1490", VA = "0x1828A2C90")]
		private bool COKDPCHCLPD(Transform KPFEIMOAGDN, out CAEEJNEMGJH BFLDNFIFFCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x28A31F0", Offset = "0x28A19F0", VA = "0x1828A31F0")]
		private void ECLKJDFNMDP(Entity DJGIAPPGDDP, CAEEJNEMGJH BFLDNFIFFCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x28A33D0", Offset = "0x28A1BD0", VA = "0x1828A33D0")]
		private bool EJECNJIJHGA(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x28A5970", Offset = "0x28A4170", VA = "0x1828A5970")]
		public void OFCCGGLDJKB(IOAGKMCGKAI DGNLFFKHMAE, CAEEJNEMGJH HDELAAJDCEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x28A5270", Offset = "0x28A3A70", VA = "0x1828A5270")]
		public bool MLPCIGCNHBK(Entity DJGIAPPGDDP, object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x28A5D40", Offset = "0x28A4540", VA = "0x1828A5D40")]
		public bool PDIAKNNKHKL(FJJPMAIFPPM AIOPADAFDKL, object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x28A5CF0", Offset = "0x28A44F0", VA = "0x1828A5CF0")]
		public bool PDIAKNNKHKL(Entity DJGIAPPGDDP, [Optional] object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x28A5CD0", Offset = "0x28A44D0", VA = "0x1828A5CD0")]
		public bool PDIAKNNKHKL(CAEEJNEMGJH EADBGDCJMOG, object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x28A3D50", Offset = "0x28A2550", VA = "0x1828A3D50")]
		public bool GOICCLCLKJM(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x28A3D20", Offset = "0x28A2520", VA = "0x1828A3D20")]
		public bool GOICCLCLKJM(CAEEJNEMGJH BFLDNFIFFCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x28A60F0", Offset = "0x28A48F0", VA = "0x1828A60F0")]
		public bool PDIAKNNKHKL(CAEEJNEMGJH BFLDNFIFFCO, [Optional] object JPCLKLIDFBB, bool HMGJFCJOMJC = false, bool OJGLCAIPLIF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x28A3B90", Offset = "0x28A2390", VA = "0x1828A3B90")]
		public Transform FNEGDLIKGHL(Entity DJGIAPPGDDP, [Optional] object JPCLKLIDFBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x28A2830", Offset = "0x28A1030", VA = "0x1828A2830")]
		public bool BNKAAADAPEE(Entity DJGIAPPGDDP, out Transform KPFEIMOAGDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x28A4660", Offset = "0x28A2E60", VA = "0x1828A4660")]
		public CAEEJNEMGJH HIBLLJMNEMO(Entity DJGIAPPGDDP, [Optional] object JPCLKLIDFBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x28A3680", Offset = "0x28A1E80", VA = "0x1828A3680")]
		public void EOABLDLDILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x28A4CE0", Offset = "0x28A34E0", VA = "0x1828A4CE0")]
		public void KMICBCMILDJ(SceneTag CHNAEAOJAGF, bool FBDHBMGOIGL, global::CCPILFHLPCE<int> OCKPOMGJNPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x28A4140", Offset = "0x28A2940", VA = "0x1828A4140")]
		private void GPDFAPFJJLB(Entity DJGIAPPGDDP, bool FBDHBMGOIGL, bool EFNGHJJGOAF, global::CCPILFHLPCE<int> OCKPOMGJNPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x28A5630", Offset = "0x28A3E30", VA = "0x1828A5630")]
		private void MNPGHPCCOLC(Entity DJGIAPPGDDP, CAEEJNEMGJH BFLDNFIFFCO, bool FBDHBMGOIGL, bool EFNGHJJGOAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x28A2A50", Offset = "0x28A1250", VA = "0x1828A2A50")]
		public CAEEJNEMGJH CHJMJBDDFNB(Entity DJGIAPPGDDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x28A23A0", Offset = "0x28A0BA0", VA = "0x1828A23A0")]
		public bool ALHNMHGEKED(Entity DJGIAPPGDDP, object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x28A4A40", Offset = "0x28A3240", VA = "0x1828A4A40")]
		public bool IIJMDCCECDI(Entity DJGIAPPGDDP, object JPCLKLIDFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x28A5100", Offset = "0x28A3900", VA = "0x1828A5100")]
		public bool KNDIAODLPBP(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x28A3360", Offset = "0x28A1B60", VA = "0x1828A3360")]
		public bool EHFOKJPLIKI(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x28A3290", Offset = "0x28A1A90", VA = "0x1828A3290")]
		public bool EHFOKJPLIKI(BDEOIFFCGBF AEGKMFNDGLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void LHOODKJJCDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x28A4730", Offset = "0x28A2F30", VA = "0x1828A4730")]
		private void HPKJKGLGFBD(bool CLLJAFACIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x28A2500", Offset = "0x28A0D00", VA = "0x1828A2500")]
		private bool BIPGCDNMLFG(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x28A51D0", Offset = "0x28A39D0", VA = "0x1828A51D0")]
		private CAEEJNEMGJH MKBFJONLANC(Entity DJGIAPPGDDP, object JPCLKLIDFBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x28A3490", Offset = "0x28A1C90", VA = "0x1828A3490")]
		private CAEEJNEMGJH ENJGMGCKNNK(Entity DJGIAPPGDDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x28A4AC0", Offset = "0x28A32C0", VA = "0x1828A4AC0")]
		private (Vector3, Quaternion, Vector3) KADGEMMPNPM(Entity DJGIAPPGDDP)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x28A2DC0", Offset = "0x28A15C0", VA = "0x1828A2DC0")]
		private void DIFAJGBHLPM(Entity DJGIAPPGDDP, KCPOKGIHHKK GANNEANJGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x28A3CB0", Offset = "0x28A24B0", VA = "0x1828A3CB0")]
		private void GHMMJANIIIK(FJJPMAIFPPM AIOPADAFDKL, CAEEJNEMGJH HDELAAJDCEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x28A5BB0", Offset = "0x28A43B0", VA = "0x1828A5BB0")]
		private void ONAKLIHFHNJ(CAEEJNEMGJH HDELAAJDCEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x28A3930", Offset = "0x28A2130", VA = "0x1828A3930")]
		private void EPNAIKLCKEF(CAEEJNEMGJH BFLDNFIFFCO, Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x28A47F0", Offset = "0x28A2FF0", VA = "0x1828A47F0")]
		private void IGHEPLGPOHJ(Entity DJGIAPPGDDP, CAEEJNEMGJH BFLDNFIFFCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x28A2420", Offset = "0x28A0C20", VA = "0x1828A2420")]
		private void AMCJHOEJLJG(Entity DJGIAPPGDDP, Transform KPFEIMOAGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x289A300", Offset = "0x2898B00", VA = "0x18289A300")]
		private FJJPMAIFPPM PFBJIBLABBA(Entity DJGIAPPGDDP)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x28A64F0", Offset = "0x28A4CF0", VA = "0x1828A64F0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x28A3120", Offset = "0x28A1920", VA = "0x1828A3120")]
		[CompilerGenerated]
		private void EBGBCMBHAKB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class HPJKEFGPEAI
{
	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x31CD2E0", Offset = "0x31CBAE0", VA = "0x1831CD2E0")]
	public static CAEEJNEMGJH HIBLLJMNEMO(this ObjectEmbodimentService OMHLILNOJHE, FJJPMAIFPPM AIOPADAFDKL, [Optional] object JPCLKLIDFBB)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[FIKNCOOOHID(typeof(ObjectLifecycleService), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.Lifecycle)]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	internal sealed class ObjectLifecycleService : HNOABDNADGF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ObjectEmbodimentService BFLDNFIFFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[EOIIILOBJAK]
		private PNONIBNMECP MOMLDEEAAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private HBKPFEBKAOJ MCILAPBKIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DestroyLocalObjects EILFBIIPPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		private EntityManager NKKGJCLICDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x28A7040", Offset = "0x28A5840", VA = "0x1828A7040")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, KCPOKGIHHKK> AMODIEKGJDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x28A79E0", Offset = "0x28A61E0", VA = "0x1828A79E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x28A7AD0", Offset = "0x28A62D0", VA = "0x1828A7AD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> FOFFDDKILHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x28A7550", Offset = "0x28A5D50", VA = "0x1828A7550")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x28A6E80", Offset = "0x28A5680", VA = "0x1828A6E80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x28A6F20", Offset = "0x28A5720", VA = "0x1828A6F20", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x1A03E90", Offset = "0x1A02690", VA = "0x181A03E90", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x28A75F0", Offset = "0x28A5DF0", VA = "0x1828A75F0")]
		public bool JONADHNAPOD(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x28A72F0", Offset = "0x28A5AF0", VA = "0x1828A72F0")]
		internal void FIFMGBLHOMI(Entity DJGIAPPGDDP, KCPOKGIHHKK GANNEANJGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x28A7000", Offset = "0x28A5800", VA = "0x1828A7000")]
		public void EGJAMHDMJIL(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x28A7A80", Offset = "0x28A6280", VA = "0x1828A7A80")]
		public void OHDLADJNGHI(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x28A7870", Offset = "0x28A6070", VA = "0x1828A7870")]
		private bool MAJNLJICCHA(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x28A7350", Offset = "0x28A5B50", VA = "0x1828A7350")]
		public void FOAPFFHPHEB(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x28A6C30", Offset = "0x28A5430", VA = "0x1828A6C30")]
		private bool AJACFFEKFCI(Entity DJGIAPPGDDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x28A6DF0", Offset = "0x28A55F0", VA = "0x1828A6DF0")]
		public void BBJPDKOAPIC(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x28A7930", Offset = "0x28A6130", VA = "0x1828A7930")]
		private void MBMGLMOPIMJ(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x28A7090", Offset = "0x28A5890", VA = "0x1828A7090")]
		private void EONEOBEDHOD(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x28A7990", Offset = "0x28A6190", VA = "0x1828A7990")]
		public void NEHFILAMICC(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		private void EHECFONCIHE(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x28A7670", Offset = "0x28A5E70", VA = "0x1828A7670")]
		private void LGCJGNGOFNB(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[FIKNCOOOHID(typeof(ObjectPrefabs), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.Prefabs)]
	internal class ObjectPrefabs : KACDEIAKJIK, HNOABDNADGF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class KHIFNCDGNAM : IEnumerable<(FILDKNJLENH, KCPOKGIHHKK)>, IEnumerable, IEnumerator<(FILDKNJLENH, KCPOKGIHHKK)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private (FILDKNJLENH primitiveType, KCPOKGIHHKK prefabType) <>2__current;

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
			private (FILDKNJLENH, KCPOKGIHHKK) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B85")]
				[Cpp2IlInjected.Address(RVA = "0x25BF9A0", Offset = "0x25BE1A0", VA = "0x1825BF9A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((FILDKNJLENH, KCPOKGIHHKK));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B87")]
				[Cpp2IlInjected.Address(RVA = "0x418FC10", Offset = "0x418E410", VA = "0x18418FC10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x418F3C0", Offset = "0x418DBC0", VA = "0x18418F3C0")]
			[DebuggerHidden]
			public KHIFNCDGNAM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x418FA30", Offset = "0x418E230", VA = "0x18418FA30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x418FBD0", Offset = "0x418E3D0", VA = "0x18418FBD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x418FB30", Offset = "0x418E330", VA = "0x18418FB30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(FILDKNJLENH, KCPOKGIHHKK)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x418FB30", Offset = "0x418E330", VA = "0x18418FB30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[EOIIILOBJAK]
		private PNONIBNMECP MOMLDEEAAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private World IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly Dictionary<KCPOKGIHHKK, Entity> HFGBBMMCEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<KCPOKGIHHKK, EntityArchetype> PBAMOBMICPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private readonly Dictionary<FILDKNJLENH, KCPOKGIHHKK> PAPBLAPDNKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<MGJGOIMGAFJ, KCPOKGIHHKK> MEEDALPBBAB;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public int EIFLHBHGPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x28AA210", Offset = "0x28A8A10", VA = "0x1828AA210")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager NKKGJCLICDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x28AAAB0", Offset = "0x28A92B0", VA = "0x1828AAAB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x28AA330", Offset = "0x28A8B30", VA = "0x1828AA330", Slot = "5")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x28AA780", Offset = "0x28A8F80", VA = "0x1828AA780", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x28AA260", Offset = "0x28A8A60", VA = "0x1828AA260")]
		internal IEnumerable<Type> BHDBPFFAKKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x28AA2C0", Offset = "0x28A8AC0", VA = "0x1828AA2C0")]
		internal NHALKGIKIBN CGBCEBGJFJC(Type EHPFPOFFCEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x28AAAD0", Offset = "0x28A92D0", VA = "0x1828AAAD0")]
		public EntityArchetype ELLPKDGNMLJ(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x28AB200", Offset = "0x28A9A00", VA = "0x1828AB200")]
		public NativeHashMap<int, EntityArchetype> HMHMIHBBAIJ(Allocator OODGOAPHOCI = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x28AB5B0", Offset = "0x28A9DB0", VA = "0x1828AB5B0")]
		public bool KFKJKBCNGOH(KCPOKGIHHKK GANNEANJGDH, out EntityArchetype CGGJCIPGPCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x28AAF80", Offset = "0x28A9780", VA = "0x1828AAF80", Slot = "4")]
		[IteratorStateMachine(typeof(KHIFNCDGNAM))]
		public IEnumerable<(FILDKNJLENH, KCPOKGIHHKK)> HBBFGAGIIIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x28AB6E0", Offset = "0x28A9EE0", VA = "0x1828AB6E0")]
		public Entity MECJJFBHJKN(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x28AB680", Offset = "0x28A9E80", VA = "0x1828AB680")]
		public KCPOKGIHHKK KMAFHPIEDOJ(MGJGOIMGAFJ EHPFPOFFCEJ)
		{
			return default(KCPOKGIHHKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x28AB620", Offset = "0x28A9E20", VA = "0x1828AB620")]
		public KCPOKGIHHKK KMAFHPIEDOJ(FILDKNJLENH EHPFPOFFCEJ)
		{
			return default(KCPOKGIHHKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x28AB910", Offset = "0x28AA110", VA = "0x1828AB910")]
		public NativeHashMap<int, Entity> PABFBJAPCDD(Allocator OODGOAPHOCI = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x28AB050", Offset = "0x28A9850", VA = "0x1828AB050")]
		public IEnumerable<KCPOKGIHHKK> HFHMPAPBCHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x28AAFF0", Offset = "0x28A97F0", VA = "0x1828AAFF0")]
		public Entity HFHBOGACLNK(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x28AA710", Offset = "0x28A8F10", VA = "0x1828AA710")]
		public bool DHOPAPOFPBP(KCPOKGIHHKK GANNEANJGDH, out Entity ONIHIIPCKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x28AAB30", Offset = "0x28A9330", VA = "0x1828AAB30")]
		private void HAEJAEMOLGH(NHALKGIKIBN LJDOGKCJHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x28AB380", Offset = "0x28A9B80", VA = "0x1828AB380")]
		internal void IGNDOKKFEOP(KCPOKGIHHKK GANNEANJGDH, ComponentTypeList GDAJMPMECGA, KCGENDPLBIB NOJFMAPBEIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x28AB0A0", Offset = "0x28A98A0", VA = "0x1828AB0A0")]
		private void HGFANFPHIPP(KCPOKGIHHKK GANNEANJGDH, ComponentTypeList BCACPPJGPOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x28AB7F0", Offset = "0x28A9FF0", VA = "0x1828AB7F0")]
		internal Entity OPLICKILJJP(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x28ABAD0", Offset = "0x28AA2D0", VA = "0x1828ABAD0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum CNADGMDJLKK
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal interface GBCMIHBOCPG
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World NGMBKINDIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	LEDNMBKMJJA LGDDCKFBELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal class LGELLCGAEIO : KNHPDDPKLHN, MMBDFNOODFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly BJGOJBPGFMJ ICLCDHCJPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly CNADGMDJLKK MFNNPHEMCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly List<NBNOGEGICAL> NKMDCFOBCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private NativeMultiHashMap<Entity, NELJJCBIPGD> GABIHCHCFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NativeHashMap<int, int> KDMEBNKBJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private JobHandle JMGFDAAIEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private JobHandle GKCIBMFMFHG;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private World PJHGIDIFBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x31DA6B0", Offset = "0x31D8EB0", VA = "0x1831DA6B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private LEDNMBKMJJA OKDNKHLEDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD6E0", Offset = "0x2CABEE0", VA = "0x182CAD6E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private GDDOIJDAFJG KAMNMFOJLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9D40", Offset = "0x6E8540", VA = "0x1806E9D40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, NELJJCBIPGD> IOAGACGIFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x6F6030", Offset = "0x6F4830", VA = "0x1806F6030", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, NELJJCBIPGD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle GNAFCDOFILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x1285520", Offset = "0x1283D20", VA = "0x181285520", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x1535F30", Offset = "0x1534730", VA = "0x181535F30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool LOJCHGKBOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x31DB1B0", Offset = "0x31D99B0", VA = "0x1831DB1B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World BIHFEJHPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x31DA470", Offset = "0x31D8C70", VA = "0x1831DA470", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x31DB200", Offset = "0x31D9A00", VA = "0x1831DB200")]
	public LGELLCGAEIO(BJGOJBPGFMJ ICLCDHCJPMF, CNADGMDJLKK MFNNPHEMCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x31DA510", Offset = "0x31D8D10", VA = "0x1831DA510", Slot = "11")]
	private void DGHBFHHPEOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x31DABC0", Offset = "0x31D93C0", VA = "0x1831DABC0", Slot = "10")]
	private bool MACBHDFJANO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x31DA380", Offset = "0x31D8B80", VA = "0x1831DA380", Slot = "12")]
	private void ADIEHIIMOJD(ComponentType DPFKFHBMMCC, in NBNOGEGICAL MEDLJEFNJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x31DA710", Offset = "0x31D8F10", VA = "0x1831DA710", Slot = "13")]
	private bool GHCOIKDMBLN(KCPOKGIHHKK GANNEANJGDH, out Entity ONIHIIPCKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x31DA520", Offset = "0x31D8D20", VA = "0x1831DA520", Slot = "16")]
	private bool DIBAHCHFCGG(out NativeArray<int> KCGIEBMNDPD, Allocator OODGOAPHOCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x31DA870", Offset = "0x31D9070", VA = "0x1831DA870", Slot = "17")]
	private bool IMAIABCOKAJ(ComponentType DPFKFHBMMCC, out NBNOGEGICAL BLKBMKCAFJK, out CPEHBEDBLME NKEIPCKGGAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x31DA740", Offset = "0x31D8F40", VA = "0x1831DA740", Slot = "18")]
	private bool IMAIABCOKAJ(ComponentType DPFKFHBMMCC, out NBNOGEGICAL BLKBMKCAFJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x31DA5C0", Offset = "0x31D8DC0", VA = "0x1831DA5C0", Slot = "19")]
	private NBNOGEGICAL FEFPAENCAOK(ComponentType DPFKFHBMMCC)
	{
		return default(NBNOGEGICAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x31DB1C0", Offset = "0x31D99C0", VA = "0x1831DB1C0", Slot = "20")]
	private HAJECJBJPCH OGCLDPKKNOP()
	{
		return default(HAJECJBJPCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x31DA4D0", Offset = "0x31D8CD0", VA = "0x1831DA4D0", Slot = "21")]
	private void BOCFEGDNKAN(JobHandle DOPBMBDFIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x31DACE0", Offset = "0x31D94E0", VA = "0x1831DACE0")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x31DAF90", Offset = "0x31D9790", VA = "0x1831DAF90")]
	private bool NEOEPGNDNKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x31DAA30", Offset = "0x31D9230", VA = "0x1831DAA30")]
	private int JKOEKIIBKNM()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal class BJGOJBPGFMJ : GBCMIHBOCPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public PNONIBNMECP MOMLDEEAAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ObjectInstantiationService HFGBBMMCEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public LEDNMBKMJJA PBPIANKJHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public GDDOIJDAFJG PLPBKHNFGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public MLLAOIOGHCD BJKLAFMPFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool KFGNFGMLOIE;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public World NGMBKINDIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A690", Offset = "0x2D08E90", VA = "0x182D0A690", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public LEDNMBKMJJA LGDDCKFBELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public BJGOJBPGFMJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[FIKNCOOOHID(typeof(PropertyDiffStateService), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.PropertyChanges)]
	internal class PropertyDiffStateService : HNOABDNADGF, INBMAMBAHGE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal readonly struct PIHMDNGKDOA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private readonly CNADGMDJLKK NPHCBOLHDAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private readonly PropertyDiffStateService NDMKBPHJBKB;

			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0x41927D0", Offset = "0x4190FD0", VA = "0x1841927D0")]
			public PIHMDNGKDOA(PropertyDiffStateService NDMKBPHJBKB, CNADGMDJLKK JHKHNMKEMCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x41927B0", Offset = "0x4190FB0", VA = "0x1841927B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly BJGOJBPGFMJ ICLCDHCJPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly LGELLCGAEIO[] ELDHIAEMBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private CNADGMDJLKK BEDOAKLOOFL;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public GBCMIHBOCPG ICFPNFMJJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public MMBDFNOODFB FHPHEHEKCCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x25F1A70", Offset = "0x25F0270", VA = "0x1825F1A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public KNHPDDPKLHN DDONIFCIJNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x25F1A70", Offset = "0x25F0270", VA = "0x1825F1A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x8A2E60", Offset = "0x8A1660", VA = "0x1808A2E60")]
		public MMBDFNOODFB EFOHPDOELDM(CNADGMDJLKK MFNNPHEMCDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x8A2E60", Offset = "0x8A1660", VA = "0x1808A2E60")]
		public KNHPDDPKLHN KHDAHAHKJKK(CNADGMDJLKK MFNNPHEMCDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x28B69B0", Offset = "0x28B51B0", VA = "0x1828B69B0", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x28B6680", Offset = "0x28B4E80", VA = "0x1828B6680", Slot = "5")]
		public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x28B6BE0", Offset = "0x28B53E0", VA = "0x1828B6BE0")]
		public void MMLFENDEPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x28B6A30", Offset = "0x28B5230", VA = "0x1828B6A30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x28B6C40", Offset = "0x28B5440", VA = "0x1828B6C40")]
		public PIHMDNGKDOA OFIADJAFNFA(CNADGMDJLKK MFNNPHEMCDL)
		{
			return default(PIHMDNGKDOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x28B6CB0", Offset = "0x28B54B0", VA = "0x1828B6CB0")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[IECCMKJMAAC(LAEALBOAPLI.HierarchySystems)]
	[FIKNCOOOHID(typeof(SceneService), new string[] { })]
	internal class SceneService : HNOABDNADGF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly SceneTag EMFNJGKDAEI;

		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public const string IBHAGGLIKPC = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private const string IKCCALNLMMG = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[EOIIILOBJAK]
		private PNONIBNMECP IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[EOIIILOBJAK]
		private JDLGCJBNHOE LFOCCHHNJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[EOIIILOBJAK]
		private ObjectEmbodimentService BFLDNFIFFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[EOIIILOBJAK]
		private DPEBGGGDMAN DJNFBFHLKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[EOIIILOBJAK]
		private SingletonComponentService AKLFBJMLCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[EOIIILOBJAK]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[EOIIILOBJAK]
		private PhotonInstanceCleanupService HKGHDJLNDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery DBGDCDNCNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery OLCKJHEPFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery MAGMJCJMALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private Entity GKICCECGLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public bool GEOGICOFMGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x2C964B0", Offset = "0x2C94CB0", VA = "0x182C964B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> HMNPINLNPKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x1296690", Offset = "0x1294E90", VA = "0x181296690")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9C30", Offset = "0x2BF8430", VA = "0x182BF9C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity GJPPGKPCMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x2C97C50", Offset = "0x2C96450", VA = "0x182C97C50")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag AOEKGAPJIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x2C975D0", Offset = "0x2C95DD0", VA = "0x182C975D0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity EGBNPDHNMEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x2C975D0", Offset = "0x2C95DD0", VA = "0x182C975D0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x2C97FC0", Offset = "0x2C967C0", VA = "0x182C97FC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager NKKGJCLICDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x2C96B00", Offset = "0x2C95300", VA = "0x182C96B00")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2C96830", Offset = "0x2C95030", VA = "0x182C96830", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2C96A50", Offset = "0x2C95250", VA = "0x182C96A50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2C97F80", Offset = "0x2C96780", VA = "0x182C97F80")]
		public void PGJILKPKHNI(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2C97B70", Offset = "0x2C96370", VA = "0x182C97B70")]
		public NativeArray<Entity> MAHONOKJACD(Allocator OODGOAPHOCI = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2C96950", Offset = "0x2C95150", VA = "0x182C96950")]
		public void DLKMIEAMGEI(Entity CHNAEAOJAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2C97AF0", Offset = "0x2C962F0", VA = "0x182C97AF0")]
		public Entity LFDNEKCEKKK(string LOIAMCEJAFO = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2C96800", Offset = "0x2C95000", VA = "0x182C96800")]
		public void CAGPFABOCMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2C975B0", Offset = "0x2C95DB0", VA = "0x182C975B0")]
		public void IMIGJKJIOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2C96AA0", Offset = "0x2C952A0", VA = "0x182C96AA0")]
		public void EDKLMDLPPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2C96820", Offset = "0x2C95020", VA = "0x182C96820")]
		public void CJFMFEFKPNJ(Entity CHNAEAOJAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2C97DA0", Offset = "0x2C965A0", VA = "0x182C97DA0")]
		public bool NCAEKAEHJNG(Entity CHNAEAOJAGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2C97620", Offset = "0x2C95E20", VA = "0x182C97620")]
		public void JFLADPIOLDF(Entity CHNAEAOJAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2C966F0", Offset = "0x2C94EF0", VA = "0x182C966F0")]
		public string BIKMECJAOHB(Entity CHNAEAOJAGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		public void BFNGLCPKKAN(Entity CHNAEAOJAGF, string LOIAMCEJAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x2C97F60", Offset = "0x2C96760", VA = "0x182C97F60")]
		public bool OIPDPDPHFAL(string LOIAMCEJAFO, out Entity CHNAEAOJAGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2C97E50", Offset = "0x2C96650", VA = "0x182C97E50")]
		public void OCGDLHALBHB(Entity CHNAEAOJAGF, bool JAKHLDCMALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2C96D10", Offset = "0x2C95510", VA = "0x182C96D10")]
		public void GPIKMGPCFOL(Entity DJGIAPPGDDP, bool PABBKLGGOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2C96CA0", Offset = "0x2C954A0", VA = "0x182C96CA0")]
		public void GPIKMGPCFOL(NativeArray<Entity> NBDCDJJEKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2C96D90", Offset = "0x2C95590", VA = "0x182C96D90")]
		public void GPIKMGPCFOL(EntityQuery PPFDACOOOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2C97810", Offset = "0x2C96010", VA = "0x182C97810")]
		public void KGLBCKFIJDN(Entity DJGIAPPGDDP, Entity CHNAEAOJAGF, bool PABBKLGGOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2C97630", Offset = "0x2C95E30", VA = "0x182C97630")]
		public void KGLBCKFIJDN(NativeArray<Entity> NBDCDJJEKHD, Entity CHNAEAOJAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2C97A40", Offset = "0x2C96240", VA = "0x182C97A40")]
		public void KGLBCKFIJDN(EntityQuery PPFDACOOOGO, Entity CHNAEAOJAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2C96FB0", Offset = "0x2C957B0", VA = "0x182C96FB0")]
		private void HGNPFBGMLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2C96B90", Offset = "0x2C95390", VA = "0x182C96B90")]
		private void FJCCIEFOJCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2C97C50", Offset = "0x2C96450", VA = "0x182C97C50")]
		private Entity OMJCJEPFODJ()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2C96BF0", Offset = "0x2C953F0", VA = "0x182C96BF0")]
		private void GKFDHBEEKBM(Entity CHNAEAOJAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2C97160", Offset = "0x2C95960", VA = "0x182C97160")]
		private void HIMOKGFGJID(EntityQuery AEBAJFDOAMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2C97230", Offset = "0x2C95A30", VA = "0x182C97230")]
		private void HIMOKGFGJID(NativeArray<Entity> KCPLDCIJMHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2C97BA0", Offset = "0x2C963A0", VA = "0x182C97BA0")]
		private void MDCKBGPMCJN(Entity CHNAEAOJAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2C96E80", Offset = "0x2C95680", VA = "0x182C96E80")]
		private void HGFKEKIIPII(Entity CHNAEAOJAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2C96340", Offset = "0x2C94B40", VA = "0x182C96340")]
		private void AJHDCKFMOJJ(SceneTag POKLMDIKBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2C96B50", Offset = "0x2C95350", VA = "0x182C96B50")]
		private void FANNJHADHNN(SceneTag POKLMDIKBAI, global::CCPILFHLPCE<int> OCKPOMGJNPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x2C96560", Offset = "0x2C94D60", VA = "0x182C96560")]
		private void BDOFKLIGONC(SceneTag POKLMDIKBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x2C97510", Offset = "0x2C95D10", VA = "0x182C97510")]
		private void ILNAMIBHAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x4BFD0E0", Offset = "0x4BFB8E0", VA = "0x184BFD0E0")]
		private void KOOIIINMDHL<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void PCEACOPILAK(SceneTag POKLMDIKBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2C96500", Offset = "0x2C94D00", VA = "0x182C96500")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ANHKCONMECB(EntityQuery PPFDACOOOGO, string LOIAMCEJAFO, SceneTag POKLMDIKBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2C96BC0", Offset = "0x2C953C0", VA = "0x182C96BC0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GGMHDIAHBBK(Entity CHNAEAOJAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void CLPKEAGCLGN(Entity CHNAEAOJAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[LDBLEAFJJLE(EKKHFCELHOI.PhotonRoom)]
	[FIKNCOOOHID(typeof(NIAKDNFBLHC), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.HierarchySystems)]
	internal class UnitySceneService : HNOABDNADGF, NIAKDNFBLHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[EOIIILOBJAK]
		private PNONIBNMECP IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[EOIIILOBJAK]
		private SceneService KCPLDCIJMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private readonly Dictionary<int, Entity> LBPCGEBKDKH;

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager NKKGJCLICDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x2CA5A30", Offset = "0x2CA4230", VA = "0x182CA5A30")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5930", Offset = "0x2CA4130", VA = "0x182CA5930", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5C70", Offset = "0x2CA4470", VA = "0x182CA5C70", Slot = "5")]
		public void PGJILKPKHNI(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5A80", Offset = "0x2CA4280", VA = "0x182CA5A80", Slot = "6")]
		public bool EOGBOAOOOEO(FJJPMAIFPPM AIOPADAFDKL, Transform KPFEIMOAGDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA59C0", Offset = "0x2CA41C0", VA = "0x182CA59C0")]
		private bool DMPCDEKGDDJ(Scene CHNAEAOJAGF, out Entity FECPKBIEKOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5DE0", Offset = "0x2CA45E0", VA = "0x182CA5DE0")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[IECCMKJMAAC(LAEALBOAPLI.ComponentSystemTypes)]
	[FIKNCOOOHID(typeof(SingletonComponentService), new string[] { })]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	internal sealed class SingletonComponentService : HNOABDNADGF, INBMAMBAHGE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[EOIIILOBJAK]
		private PNONIBNMECP IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[EOIIILOBJAK]
		private DPEBGGGDMAN DJNFBFHLKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private Entity DJGIAPPGDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private ComponentTypeList BCACPPJGPOP;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int EIFLHBHGPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0x2C9C840", Offset = "0x2C9B040", VA = "0x182C9C840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity FMGJPDKNJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager NKKGJCLICDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x2C9CB90", Offset = "0x2C9B390", VA = "0x182C9CB90")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE9B0", Offset = "0x4BFD1B0", VA = "0x184BFE9B0")]
		public T HEJAGBNBHFE<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE8E0", Offset = "0x4BFD0E0", VA = "0x184BFE8E0")]
		public void BJPKOCBPDKP<T>(T NPHADDCNBHE) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C850", Offset = "0x2C9B050", VA = "0x182C9C850", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C6A0", Offset = "0x2C9AEA0", VA = "0x182C9C6A0", Slot = "5")]
		public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C6A0", Offset = "0x2C9AEA0", VA = "0x182C9C6A0")]
		private void AEMCJIENPND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9C8C0", Offset = "0x2C9B0C0", VA = "0x182C9C8C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CC80", Offset = "0x2C9B480", VA = "0x182C9CC80")]
		private ComponentTypeList KMLHGCPIOAJ()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		private static void MONOKFBNODA(int FCKFNIPNJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		private static void EAMDNIHIBGH(Type EHPFPOFFCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x2C9CBE0", Offset = "0x2C9B3E0", VA = "0x182C9CBE0")]
		private static void EMDKKBAAJJB(Type EHPFPOFFCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal struct AGMABLILEPA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
[FIKNCOOOHID(typeof(FGJJBDJMIFL), new string[] { })]
internal sealed class FGJJBDJMIFL : HNOABDNADGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	[EOIIILOBJAK]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private global::JEKNJGCOJLP<FBBNFGBBJIN, Entity> EBJHOFHDPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private global::CACIMGOHFBI<CCHCHIKNLHE> DBGHOFOBMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private global::CACIMGOHFBI<CAIBCAEAJKB> IBGFEHNAEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private global::CACIMGOHFBI<JNDHEMEMIPK> AKHGOGLFLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private global::CACIMGOHFBI<KNICGDPAIHJ> PGCPDFALAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private global::CACIMGOHFBI<LHLJGIJIFIA> OMHLILNOJHE;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public global::DFPEFKJKIIK<Entity> HPHKMLDEEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public PBHKOLDMHPC GBHDNMLFHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public PBHKOLDMHPC NCLFLMBEPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public PBHKOLDMHPC CDPDJPFNABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public PBHKOLDMHPC CHIDABCFAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public PBHKOLDMHPC CEJFIDIGAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager NKKGJCLICDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x31C5FB0", Offset = "0x31C47B0", VA = "0x1831C5FB0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x31C5DB0", Offset = "0x31C45B0", VA = "0x1831C5DB0", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x31C5EC0", Offset = "0x31C46C0", VA = "0x1831C5EC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x268BAC0", Offset = "0x268A2C0", VA = "0x18268BAC0")]
	private void AOGHGHFDMOA<T>(ref global::CACIMGOHFBI<T> BPHLNCHBAFC) where T : struct, EPJOCCFBHFH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x268BAC0", Offset = "0x268A2C0", VA = "0x18268BAC0")]
	private void AOGHGHFDMOA<TC, TV>(ref global::JEKNJGCOJLP<TC, TV> BPHLNCHBAFC) where TC : struct, EPJOCCFBHFH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public FGJJBDJMIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[FIKNCOOOHID(typeof(LAFBPDEGHKC), new string[] { })]
[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
internal sealed class LAFBPDEGHKC : BGAFKNOHCIN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private GDIPBBIJEHP MCABFDPPDDB;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public GDIPBBIJEHP EJJPHNBHDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x1C5D8F0", Offset = "0x1C5C0F0", VA = "0x181C5D8F0")]
		get
		{
			return default(GDIPBBIJEHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x31D9490", Offset = "0x31D7C90", VA = "0x1831D9490", Slot = "4")]
	public void CDCHANKPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x31D9520", Offset = "0x31D7D20", VA = "0x1831D9520", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public LAFBPDEGHKC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[FIKNCOOOHID(typeof(TransformOwnershipPhase), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public enum DIIMACOLNJL
		{
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public struct JPNPKKNKMDL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private DIIMACOLNJL OKELPFNDKAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private readonly TransformOwnershipPhase FAAJOMIIHED;

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x418F740", Offset = "0x418DF40", VA = "0x18418F740")]
			public JPNPKKNKMDL(TransformOwnershipPhase FAAJOMIIHED, DIIMACOLNJL MFNNPHEMCDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x418F720", Offset = "0x418DF20", VA = "0x18418F720", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public DIIMACOLNJL MFNNPHEMCDL;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public DIIMACOLNJL OMDHDLBGCOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
			get
			{
				return default(DIIMACOLNJL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F30", Offset = "0x6F4730", VA = "0x1806F5F30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool CKNPKAIAGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xB6F210", Offset = "0xB6DA10", VA = "0x180B6F210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool ABHDFJGPLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x16CFCD0", Offset = "0x16CE4D0", VA = "0x1816CFCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0270", Offset = "0x2C9EA70", VA = "0x182CA0270")]
		public JPNPKKNKMDL MIMLLLFDFBI()
		{
			return default(JPNPKKNKMDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0240", Offset = "0x2C9EA40", VA = "0x182CA0240")]
		public JPNPKKNKMDL EBHFAIKGPEK()
		{
			return default(JPNPKKNKMDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[FIKNCOOOHID(typeof(CBKLFNPDDDI), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.Circuits)]
	public class CircuitsService : HNOABDNADGF, CBKLFNPDDDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		[EOIIILOBJAK]
		private LGNLDKGKOCF GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityManager AIFDIGHJEAF;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FBC0", Offset = "0x2D0E3C0", VA = "0x182D0FBC0", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2D10A00", Offset = "0x2D0F200", VA = "0x182D10A00", Slot = "5")]
		public bool KLBPHHEKEAO(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F8B0", Offset = "0x2D0E0B0", VA = "0x182D0F8B0", Slot = "7")]
		public bool AOAHHMIMHFF(FJJPMAIFPPM AIOPADAFDKL, out Guid JAGMEJBMAOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2D10530", Offset = "0x2D0ED30", VA = "0x182D10530", Slot = "8")]
		public Guid IMBHIDKCBDI(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2D102D0", Offset = "0x2D0EAD0", VA = "0x182D102D0", Slot = "9")]
		public void IGCGGIACCEA(FJJPMAIFPPM AIOPADAFDKL, Guid JAGMEJBMAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2D10B00", Offset = "0x2D0F300", VA = "0x182D10B00", Slot = "10")]
		public bool MDGONFNIFDN(FJJPMAIFPPM AIOPADAFDKL, out Guid NJEPGJCLJHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2D10BF0", Offset = "0x2D0F3F0", VA = "0x182D10BF0", Slot = "11")]
		public Guid NJPBDDPJNGH(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FCB0", Offset = "0x2D0E4B0", VA = "0x182D0FCB0", Slot = "12")]
		public void FKCOPCCBGNO(FJJPMAIFPPM AIOPADAFDKL, Guid NJEPGJCLJHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FC60", Offset = "0x2D0E460", VA = "0x182D0FC60", Slot = "13")]
		public bool EJHPHFDLFOA(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x2D10D00", Offset = "0x2D0F500", VA = "0x182D10D00", Slot = "14")]
		public void OAFCFAONJJK(FJJPMAIFPPM AIOPADAFDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2D10640", Offset = "0x2D0EE40", VA = "0x182D10640", Slot = "15")]
		public void KBBNLLCMJDG(FJJPMAIFPPM DJDDCFICJJN, FJJPMAIFPPM FAAJOMIIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FA50", Offset = "0x2D0E250", VA = "0x182D0FA50")]
		private void CGEKFOGEHDI(NIHFMLOJAFH HPFILGKMLHA, FJJPMAIFPPM FAAJOMIIHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2D10140", Offset = "0x2D0E940", VA = "0x182D10140")]
		private void HMLPGPKODDF(NIHFMLOJAFH HPFILGKMLHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2D0FF10", Offset = "0x2D0E710", VA = "0x182D0FF10")]
		private bool FNMDCFMEFCK(JPEOKMJCLOL BFHAMCLNCKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F9A0", Offset = "0x2D0E1A0", VA = "0x182D0F9A0")]
		private bool CDGHPHNBKJB(JPEOKMJCLOL BFHAMCLNCKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2D100E0", Offset = "0x2D0E8E0", VA = "0x182D100E0", Slot = "6")]
		public bool GIDLFBLGDOH(FJJPMAIFPPM NGPFKAJPHJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[FIKNCOOOHID(typeof(DGNKJNKENBK), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.Connectables)]
	internal class ConnectableService : DGNKJNKENBK, HNOABDNADGF, INBMAMBAHGE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class OAPNOCNAICC : IEnumerable<FJJPMAIFPPM>, IEnumerable, IEnumerator<FJJPMAIFPPM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private FJJPMAIFPPM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			private FJJPMAIFPPM localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public FJJPMAIFPPM <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			private FJJPMAIFPPM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(FJJPMAIFPPM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x2C935F0", Offset = "0x2C91DF0", VA = "0x182C935F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x97CE80", Offset = "0x97B680", VA = "0x18097CE80")]
			[DebuggerHidden]
			public OAPNOCNAICC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x2C93640", Offset = "0x2C91E40", VA = "0x182C93640", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x2C93200", Offset = "0x2C91A00", VA = "0x182C93200", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x2C93710", Offset = "0x2C91F10", VA = "0x182C93710")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x2C93760", Offset = "0x2C91F60", VA = "0x182C93760")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x2C935B0", Offset = "0x2C91DB0", VA = "0x182C935B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x2C93500", Offset = "0x2C91D00", VA = "0x182C93500", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FJJPMAIFPPM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x2C93500", Offset = "0x2C91D00", VA = "0x182C93500", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly DELGGOALDMF JGPDJCBKANB;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public const int HDELOHPHELK = 0;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public const int KPBNNILBADC = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private HMGEJIKOHBO FLBPGJKFMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private PNONIBNMECP IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private HILDNPBHGOE GHFACKFNNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PropertyEventCallbacksService HKNJNCDEHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private global::LEKHCEGJOPN<Entity> BCEIDIBPGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private global::LEKHCEGJOPN<float3> ANJNCONBGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private global::LEKHCEGJOPN<quaternion> JPAFGIAOMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private global::LEKHCEGJOPN<Entity> FAAJOMIIHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private global::LEKHCEGJOPN<float3> GFAGIPAOELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private global::LEKHCEGJOPN<quaternion> DLNPDPAPICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HashSet<Entity> PLPNGFPJAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private HashSet<Entity> BKDEHLEBCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private EntityQuery MLOHGGGCFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private bool KFGNFGMLOIE;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public Func<DNBMKFELOBN> FEEOAGGODBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x6EB750", Offset = "0x6E9F50", VA = "0x1806EB750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x8080C0", Offset = "0x8068C0", VA = "0x1808080C0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<FJJPMAIFPPM, FJJPMAIFPPM> PGLJMNBKMNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x2D16210", Offset = "0x2D14A10", VA = "0x182D16210", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x2D14A40", Offset = "0x2D13240", VA = "0x182D14A40", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<FJJPMAIFPPM, FJJPMAIFPPM> MLPIJBMKJNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x2D15C20", Offset = "0x2D14420", VA = "0x182D15C20", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x2D157B0", Offset = "0x2D13FB0", VA = "0x182D157B0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<FJJPMAIFPPM, FJJPMAIFPPM, FJJPMAIFPPM> KPPMOCLPBBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x2D15CC0", Offset = "0x2D144C0", VA = "0x182D15CC0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x2D16780", Offset = "0x2D14F80", VA = "0x182D16780", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<FJJPMAIFPPM> HBKCDBABFBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x2D15850", Offset = "0x2D14050", VA = "0x182D15850", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2D16680", Offset = "0x2D14E80", VA = "0x182D16680", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x2D151A0", Offset = "0x2D139A0", VA = "0x182D151A0", Slot = "25")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x2D14C00", Offset = "0x2D13400", VA = "0x182D14C00", Slot = "26")]
		public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x2D15550", Offset = "0x2D13D50", VA = "0x182D15550", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x2D16720", Offset = "0x2D14F20", VA = "0x182D16720")]
		private void PGKCAFIHJHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x2D16510", Offset = "0x2D14D10", VA = "0x182D16510")]
		private void PFCMOOKFNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x2D16350", Offset = "0x2D14B50", VA = "0x182D16350")]
		private void PBMCFNABFOH(Entity DJGIAPPGDDP, OBIAPIAFCLH GCAANJILJJP, OJMHOIEICMJ AHKNGMEFAGI, OJMHOIEICMJ EJDNMJGBJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x2D154F0", Offset = "0x2D13CF0", VA = "0x182D154F0")]
		private void DMNGDOPNIGN(Entity DJGIAPPGDDP, OBIAPIAFCLH GCAANJILJJP, OJMHOIEICMJ AHKNGMEFAGI, OJMHOIEICMJ EJDNMJGBJFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x1894470", Offset = "0x1892C70", VA = "0x181894470", Slot = "14")]
		public FJJPMAIFPPM GOJAFAABKMG(FJJPMAIFPPM AIOPADAFDKL, int HPBMKMKGGBN)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x14FE480", Offset = "0x14FCC80", VA = "0x1814FE480", Slot = "15")]
		public Color OLIGECPFNJG(FJJPMAIFPPM AIOPADAFDKL, int HPBMKMKGGBN)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2D15D60", Offset = "0x2D14560", VA = "0x182D15D60", Slot = "16")]
		public float3 LKKBGFIHAPG(FJJPMAIFPPM AIOPADAFDKL, int HPBMKMKGGBN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2D158F0", Offset = "0x2D140F0", VA = "0x182D158F0", Slot = "17")]
		public bool IHAPNDECADG(FJJPMAIFPPM AIOPADAFDKL, FJJPMAIFPPM HMAEKEDAFNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2D15700", Offset = "0x2D13F00", VA = "0x182D15700", Slot = "18")]
		public FJJPMAIFPPM EDHBFMCNOJK(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2D160C0", Offset = "0x2D148C0", VA = "0x182D160C0", Slot = "21")]
		public void MOAPNPOEJEC(FJJPMAIFPPM AIOPADAFDKL, Vector3 DMAGMKCEKNE, Quaternion DCECNIPDBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2D162B0", Offset = "0x2D14AB0", VA = "0x182D162B0", Slot = "23")]
		public float3 OFIECCBOPGF(FDKBLBMEPAG FOPBBNKGEBF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2D14B70", Offset = "0x2D13370", VA = "0x182D14B70", Slot = "24")]
		public quaternion BPGKNCIBPJM(FDKBLBMEPAG FOPBBNKGEBF)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2D150A0", Offset = "0x2D138A0", VA = "0x182D150A0", Slot = "28")]
		public RigidTransform CGOMLHKJEMA(FDKBLBMEPAG FOPBBNKGEBF)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2D15F40", Offset = "0x2D14740", VA = "0x182D15F40", Slot = "22")]
		public bool LLDDCGNHIBC(FJJPMAIFPPM AIOPADAFDKL, out RigidTransform DLPIGOJMOFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2D14AE0", Offset = "0x2D132E0", VA = "0x182D14AE0", Slot = "19")]
		[IteratorStateMachine(typeof(OAPNOCNAICC))]
		public IEnumerable<FJJPMAIFPPM> BIPDDMAKIFM(FJJPMAIFPPM AIOPADAFDKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x2D15AC0", Offset = "0x2D142C0", VA = "0x182D15AC0", Slot = "20")]
		public FJJPMAIFPPM JBOJBKGEGDC(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2D15320", Offset = "0x2D13B20", VA = "0x182D15320", Slot = "29")]
		public void DCJAJPAJJHJ(ref List<FJJPMAIFPPM> DMECHADKKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2D159A0", Offset = "0x2D141A0", VA = "0x182D159A0")]
		private Entity JBOJBKGEGDC(Entity DJGIAPPGDDP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2D168B0", Offset = "0x2D150B0", VA = "0x182D168B0")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[IECCMKJMAAC(LAEALBOAPLI.Prefabs)]
	[FIKNCOOOHID(typeof(ObjectInstantiationService), new string[] { })]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	internal sealed class ObjectInstantiationService : HNOABDNADGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[EOIIILOBJAK]
		private PNONIBNMECP IFJKGEPFDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[EOIIILOBJAK]
		private PPHPGJCMABF LDBJCJEKGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[EOIIILOBJAK]
		private DIFNEHGONLN FGIDJHJPFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[EOIIILOBJAK]
		private ObjectNetworkToLocalMapService DDLHJELICBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[EOIIILOBJAK]
		private ObjectLifecycleService KPJGDFLAFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[EOIIILOBJAK]
		private ObjectPrefabs HFGBBMMCEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[EOIIILOBJAK]
		private IKMHKOPGMMB PNENHGLGIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private HBKPFEBKAOJ MCILAPBKIBA;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public int BEGHFIHPJCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0x28A6B20", Offset = "0x28A5320", VA = "0x1828A6B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x28A66A0", Offset = "0x28A4EA0", VA = "0x1828A66A0", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x28A6B70", Offset = "0x28A5370", VA = "0x1828A6B70")]
		public Entity LFBFJKNANFO(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x28A6570", Offset = "0x28A4D70", VA = "0x1828A6570")]
		public Entity BGCJNDHKFOO(IOAGKMCGKAI DGNLFFKHMAE, KCPOKGIHHKK GANNEANJGDH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x28A6A20", Offset = "0x28A5220", VA = "0x1828A6A20")]
		public Entity NJAIGPBILBM(KCPOKGIHHKK GANNEANJGDH, bool FDKNMDGFIME)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x28A69E0", Offset = "0x28A51E0", VA = "0x1828A69E0")]
		public Entity NJAIGPBILBM(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x28A65D0", Offset = "0x28A4DD0", VA = "0x1828A65D0")]
		public Entity BKIIIKIIBKB()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x28A6830", Offset = "0x28A5030", VA = "0x1828A6830")]
		public Entity FEEOOJENLHP(FILDKNJLENH EHPFPOFFCEJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x28A6610", Offset = "0x28A4E10", VA = "0x1828A6610")]
		public Entity CDILNCFJGNP(MGJGOIMGAFJ EHPFPOFFCEJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x28A6B90", Offset = "0x28A5390", VA = "0x1828A6B90")]
		public NativeArray<(FJJPMAIFPPM, FJJPMAIFPPM)> MECJJFBHJKN(NativeArray<FJJPMAIFPPM> AHCLHKEHEEF, Allocator OODGOAPHOCI)
		{
			return default(NativeArray<(FJJPMAIFPPM, FJJPMAIFPPM)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x28A6AD0", Offset = "0x28A52D0", VA = "0x1828A6AD0")]
		public IEnumerable<KCPOKGIHHKK> HFHMPAPBCHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x28A67D0", Offset = "0x28A4FD0", VA = "0x1828A67D0")]
		public EntityArchetype ELLPKDGNMLJ(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x28A6A70", Offset = "0x28A5270", VA = "0x1828A6A70")]
		public Entity HFHBOGACLNK(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x28A69E0", Offset = "0x28A51E0", VA = "0x1828A69E0")]
		private Entity FMFPFGNNFGN(KCPOKGIHHKK GANNEANJGDH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x28A6A20", Offset = "0x28A5220", VA = "0x1828A6A20")]
		private Entity FMFPFGNNFGN(KCPOKGIHHKK GANNEANJGDH, bool FDKNMDGFIME)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x28A68C0", Offset = "0x28A50C0", VA = "0x1828A68C0")]
		private Entity FMFPFGNNFGN(KCPOKGIHHKK GANNEANJGDH, IOAGKMCGKAI DGNLFFKHMAE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[FIKNCOOOHID(typeof(OJCMJJNIHBI), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.Physics)]
	public sealed class PhysicsSceneColliderService : OJCMJJNIHBI, FDJFKJKIFJL, BGAFKNOHCIN, HNOABDNADGF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private const string JINLKHJMFBA = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private const int JLFDFAHALMJ = -1;

		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private const int CGOKKGKONNH = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[EOIIILOBJAK]
		private FAIAJFOHDOE AOPMIABPHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Collider[] POGODCBMGFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private RaycastHit[] HHCBAGHHCNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private global::IBOAEEDDPMB<CJIMCAOKHHG, BoxCollider> KJMIMAANGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private Scene CHNAEAOJAGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PhysicsScene GFGABPPGFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GameObject ONIHIIPCKEF;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public int PCKMAMLKNIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x28B0920", Offset = "0x28AF120", VA = "0x1828B0920", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x28B06F0", Offset = "0x28AEEF0", VA = "0x1828B06F0", Slot = "9")]
		public void CDCHANKPBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x28B0860", Offset = "0x28AF060", VA = "0x1828B0860", Slot = "10")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x28B0960", Offset = "0x28AF160", VA = "0x1828B0960", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x28B0080", Offset = "0x28AE880", VA = "0x1828B0080", Slot = "4")]
		public CJIMCAOKHHG AOOHNMGOBCD(Entity DJGIAPPGDDP)
		{
			return default(CJIMCAOKHHG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x28B0FA0", Offset = "0x28AF7A0", VA = "0x1828B0FA0", Slot = "5")]
		public void IIKLJGOJBGF(NativeArray<CJIMCAOKHHG> CLIFHNNOFNJ, NativeArray<LDAACCNPBBB> PALKMIEPCME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x28B0AA0", Offset = "0x28AF2A0", VA = "0x1828B0AA0", Slot = "6")]
		public void GADGPENIFED(CJIMCAOKHHG AEGKMFNDGLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x28B1350", Offset = "0x28AFB50", VA = "0x1828B1350", Slot = "7")]
		public bool OMLKKAILDIK(CJIMCAOKHHG AEGKMFNDGLH, out Collider JBCONAAJILG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x28B0C90", Offset = "0x28AF490", VA = "0x1828B0C90")]
		public bool HNABONJCHIG(in float3 INODPFILAHI, in float3 ACGENMPHBIP, float DGBJANBPLCN, Allocator OODGOAPHOCI, out NativeArray<Entity> NBDCDJJEKHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x28B11B0", Offset = "0x28AF9B0", VA = "0x1828B11B0")]
		private void JIPDKOJJOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xC0F5C0", Offset = "0xC0DDC0", VA = "0x180C0F5C0")]
		private void AELICNBNMJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x28B1250", Offset = "0x28AFA50", VA = "0x1828B1250")]
		private void LPJMCFJKKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x979080", Offset = "0x977880", VA = "0x180979080")]
		private void JPILBLHDCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x28B0B70", Offset = "0x28AF370", VA = "0x1828B0B70")]
		private BoxCollider GDGLNHNLMFH(Entity DJGIAPPGDDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x28B12A0", Offset = "0x28AFAA0", VA = "0x1828B12A0")]
		private void NDLALFDGHMD(BoxCollider CFAEDHADOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x28B0A60", Offset = "0x28AF260", VA = "0x1828B0A60")]
		[Conditional("UNITY_EDITOR")]
		private void FNEOIBBDCKE(GameObject IMPKIJJJHKI, Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x28B0500", Offset = "0x28AED00", VA = "0x1828B0500")]
		private void BOHHFFFFKGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x28B03E0", Offset = "0x28AEBE0", VA = "0x1828B03E0")]
		private void BOFGIPDEIAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x28B01D0", Offset = "0x28AE9D0", VA = "0x1828B01D0")]
		private void BCNFCODJFAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x28B1320", Offset = "0x28AFB20", VA = "0x1828B1320")]
		private void NOPEHEJBGKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x28B04F0", Offset = "0x28AECF0", VA = "0x1828B04F0")]
		private void BOFHGLHBOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x28B1200", Offset = "0x28AFA00", VA = "0x1828B1200")]
		private void KCLIFPCGLEB(Scene FCKKPGGMKEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x28B1240", Offset = "0x28AFA40", VA = "0x1828B1240", Slot = "8")]
		private bool KJJMOKFNDDF(in float3 INODPFILAHI, in float3 ACGENMPHBIP, float DGBJANBPLCN, Allocator OODGOAPHOCI, out NativeArray<Entity> NBDCDJJEKHD)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[FIKNCOOOHID(typeof(HFOOAMMJMIJ), new string[] { })]
public sealed class EELJBKFHMPM : HFOOAMMJMIJ, HNOABDNADGF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	private struct GNOJJMAGCAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public float HPMCNMECMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public uint ADJKLOAELAL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private FDJFKJKIFJL AEEMNHKCOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private JAEJCKLADMC MCIOAGFKMCF;

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x2D220A0", Offset = "0x2D208A0", VA = "0x182D220A0", Slot = "5")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x2D22110", Offset = "0x2D20910", VA = "0x182D22110")]
	public bool HNABONJCHIG(in float3 INODPFILAHI, in float3 ACGENMPHBIP, float DGBJANBPLCN, out AJLLBJDMFKJ CBKKNEGKDPM, out Entity PKDLEIGAKGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x2D21FA0", Offset = "0x2D207A0", VA = "0x182D21FA0")]
	public static bool BNJKPDJAGBC(in Span<AJLLBJDMFKJ> KJFELPBAING, float DGBJANBPLCN, out int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x2D21F70", Offset = "0x2D20770", VA = "0x182D21F70")]
	public static float BLEFBJBGNJC(float HPMCNMECMNK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public EELJBKFHMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x2D22590", Offset = "0x2D20D90", VA = "0x182D22590", Slot = "4")]
	private bool LAIEBHLMFDD(in float3 INODPFILAHI, in float3 ACGENMPHBIP, float DGBJANBPLCN, out AJLLBJDMFKJ CBKKNEGKDPM, out Entity PKDLEIGAKGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[FIKNCOOOHID(typeof(JAEJCKLADMC), new string[] { })]
public sealed class MCDIGFAGKHH : JAEJCKLADMC, HNOABDNADGF
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[BurstCompile]
	private struct FMFCGIFJMLO : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<Entity> NBDCDJJEKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[ReadOnly]
		public float3 BMCMOBHBOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[ReadOnly]
		public float3 LGDEFBFEAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> PIIHBBIJMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> PGFJFIAPLAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> KOHOJLKNAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> AHNBJAMDOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> NFKJNIFLDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[WriteOnly]
		public NativeArray<AJLLBJDMFKJ> EFNKMFMFCKP;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private static readonly AJLLBJDMFKJ NNJMJGPNNDE;

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x418BF90", Offset = "0x418A790", VA = "0x18418BF90", Slot = "4")]
		public void Execute(int LHHBOCAHDEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x418CA40", Offset = "0x418B240", VA = "0x18418CA40")]
		private static float3 JKKFKLMJHGN(in float4x4 GPEGHHDPJHK, in float3 LPBINJHCNHK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x418BDD0", Offset = "0x418A5D0", VA = "0x18418BDD0")]
		private static float3 CPNEHJDAFAF(in float4x4 GPEGHHDPJHK, in float3 ECNMDFEDCDP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x418C940", Offset = "0x418B140", VA = "0x18418C940")]
		private static float3 HAHIFIHOEKL(in float4x4 GPEGHHDPJHK, in float3 LPBINJHCNHK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x418CE60", Offset = "0x418B660", VA = "0x18418CE60")]
		private static float3 PEFEINOGCLM(in float4x4 GPEGHHDPJHK, in float3 ECNMDFEDCDP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x418CB10", Offset = "0x418B310", VA = "0x18418CB10")]
		private bool PCMLHJEMFLJ(in float3 INODPFILAHI, in float3 ACGENMPHBIP, in NativeArray<Entity> JOKKINDKFGO, out float3 CBKKNEGKDPM, out float3 KFLGGMKGILC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x418C270", Offset = "0x418AA70", VA = "0x18418C270")]
		public static bool GNOAFPDLNPJ(in float3 NNELOEKCOAO, in float3 HKALLFLPKOO, in float3 ICHHCPKJEPO, in float3 AGIHDOPAGBB, float BEKBCIIHMJL, float CIGALGMDHPG, out float KFEBAJCAAOE, out float3 NAIKDLDMOEM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager AIFDIGHJEAF;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x31DD9D0", Offset = "0x31DC1D0", VA = "0x1831DD9D0", Slot = "5")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x31DDA60", Offset = "0x31DC260", VA = "0x1831DDA60")]
	public void HNABONJCHIG(in NativeArray<Entity> NBDCDJJEKHD, in float3 INODPFILAHI, in float3 ACGENMPHBIP, in NativeArray<AJLLBJDMFKJ> OFJPNJLEKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public MCDIGFAGKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x31DDA50", Offset = "0x31DC250", VA = "0x1831DDA50", Slot = "4")]
	private void FACKGIKGCGD(in NativeArray<Entity> NBDCDJJEKHD, in float3 INODPFILAHI, in float3 ACGENMPHBIP, in NativeArray<AJLLBJDMFKJ> OFJPNJLEKMG)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[IECCMKJMAAC(LAEALBOAPLI.Embodiment)]
	[LDBLEAFJJLE(EKKHFCELHOI.OMRoom)]
	[FIKNCOOOHID(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : HNOABDNADGF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[EOIIILOBJAK]
		private PNONIBNMECP MOMLDEEAAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[EOIIILOBJAK]
		private PPHPGJCMABF BFCELNJDPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[EOIIILOBJAK]
		private DIFNEHGONLN NIAPGKEDFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private GGNOOGMPGOK KKLJBHKLNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NativeHashMap<IOAGKMCGKAI, Entity> FMIPPBDBONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private EntityManager AIFDIGHJEAF;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal NativeHashMap<IOAGKMCGKAI, Entity> GBNLGDHFFAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0xE995E0", Offset = "0xE97DE0", VA = "0x180E995E0")]
			get
			{
				return default(NativeHashMap<IOAGKMCGKAI, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint JMDKFFGCAPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x28A9F60", Offset = "0x28A8760", VA = "0x1828A9F60")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool IFJHKPDANNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D45A0", VA = "0x1808D5DA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0xD1D250", Offset = "0xD1BA50", VA = "0x180D1D250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x28A9A60", Offset = "0x28A8260", VA = "0x1828A9A60", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x28A9B80", Offset = "0x28A8380", VA = "0x1828A9B80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x28A9F90", Offset = "0x28A8790", VA = "0x1828A9F90")]
		public void MMLFENDEPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x28A9BF0", Offset = "0x28A83F0", VA = "0x1828A9BF0")]
		public void GAJMDIPKIGG(IOAGKMCGKAI DGNLFFKHMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x28AA190", Offset = "0x28A8990", VA = "0x1828AA190")]
		private FJJPMAIFPPM PFBJIBLABBA(Entity DJGIAPPGDDP)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x28A9E80", Offset = "0x28A8680", VA = "0x1828A9E80")]
		public FJJPMAIFPPM IINJGBNILBC(IOAGKMCGKAI DGNLFFKHMAE)
		{
			return default(FJJPMAIFPPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x28AA0A0", Offset = "0x28A88A0", VA = "0x1828AA0A0")]
		public IOAGKMCGKAI NLKPEHJCAGC(FJJPMAIFPPM AIOPADAFDKL)
		{
			return default(IOAGKMCGKAI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x28AA010", Offset = "0x28A8810", VA = "0x1828AA010")]
		public void NALIBHDMDFN(Entity DJGIAPPGDDP, IOAGKMCGKAI DGNLFFKHMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x28A9A00", Offset = "0x28A8200", VA = "0x1828A9A00")]
		public void BIFKPOAGFGA(Entity DJGIAPPGDDP, IOAGKMCGKAI DGNLFFKHMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x28AA130", Offset = "0x28A8930", VA = "0x1828AA130")]
		public void OFFDNMAMDCH(Entity DJGIAPPGDDP, IOAGKMCGKAI DGNLFFKHMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x28A9DB0", Offset = "0x28A85B0", VA = "0x1828A9DB0")]
		public void IEFOJIHMDBF(Entity DJGIAPPGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
	[FIKNCOOOHID(typeof(PropertyEventCallbacksService), new string[] { })]
	[IECCMKJMAAC(LAEALBOAPLI.Callbacks)]
	public class PropertyEventCallbacksService : HNOABDNADGF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		private struct GPFJGKEGEGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public CEDANDLCGEB MKOFIMIHGLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public Type EHPFPOFFCEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public int GIGKIGNPJAP;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		private struct EIGEEPIDGCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public GPFJGKEGEGN[] AIDEINAMABM;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		public delegate void CEDANDLCGEB(Entity DJGIAPPGDDP, OBIAPIAFCLH GCAANJILJJP, OJMHOIEICMJ AHKNGMEFAGI, OJMHOIEICMJ EJDNMJGBJFF);

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private static readonly DELGGOALDMF MGFJDFPNJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly Dictionary<OBIAPIAFCLH, CEDANDLCGEB> MHACOBCIKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private readonly Dictionary<int, EIGEEPIDGCH> JHLECMOJCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private JHIICGGLBCC AIDEINAMABM;

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action CFIAIKEGJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x28B7920", Offset = "0x28B6120", VA = "0x1828B7920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x28B79C0", Offset = "0x28B61C0", VA = "0x1828B79C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action FJFCBPLDJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x28B6D50", Offset = "0x28B5550", VA = "0x1828B6D50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x28B6E40", Offset = "0x28B5640", VA = "0x1828B6E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x28B6DF0", Offset = "0x28B55F0", VA = "0x1828B6DF0", Slot = "4")]
		public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x28B6EE0", Offset = "0x28B56E0", VA = "0x1828B6EE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x28B7BE0", Offset = "0x28B63E0", VA = "0x1828B7BE0")]
		public void OFCCGGLDJKB(OBIAPIAFCLH GCAANJILJJP, CEDANDLCGEB MKOFIMIHGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x28B6F70", Offset = "0x28B5770", VA = "0x1828B6F70")]
		public void GEEPOPONKOK(OBIAPIAFCLH GCAANJILJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x28B7690", Offset = "0x28B5E90", VA = "0x1828B7690")]
		internal void KJNCGLMADFN(MMBDFNOODFB DMJFIAAGODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x28B7060", Offset = "0x28B5860", VA = "0x1828B7060")]
		private void JABJPNLGFGD(MMBDFNOODFB DMJFIAAGODA, int CGPOEJKODDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x28B7D50", Offset = "0x28B6550", VA = "0x1828B7D50")]
		private void PGEGNANBFDA(PEFKAJGNEDD MOMPKBKMCLK, KKMMECBGMDP LNOMHFAIIAK, GPFJGKEGEGN EKNLEJGHELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x28B7A60", Offset = "0x28B6260", VA = "0x1828B7A60")]
		private EIGEEPIDGCH NNPCNLABHDM(PEFKAJGNEDD MOMPKBKMCLK, KKMMECBGMDP LNOMHFAIIAK)
		{
			return default(EIGEEPIDGCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x28B75A0", Offset = "0x28B5DA0", VA = "0x1828B75A0")]
		private GPFJGKEGEGN JKJAIAHAGMD(EIGEEPIDGCH NKEIPCKGGAH, PEFKAJGNEDD MOMPKBKMCLK, KKMMECBGMDP LNOMHFAIIAK)
		{
			return default(GPFJGKEGEGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x28B8020", Offset = "0x28B6820", VA = "0x1828B8020")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[FIKNCOOOHID(typeof(PGEEIKIHOKG), new string[] { })]
public class AJFADJHBHEJ : HNOABDNADGF, INBMAMBAHGE, PGEEIKIHOKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	private sealed class DNPAGJGMJDA : IEnumerable<FJJPMAIFPPM>, IEnumerable, IEnumerator<FJJPMAIFPPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private FJJPMAIFPPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public AJFADJHBHEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private FJJPMAIFPPM splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public FJJPMAIFPPM <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		private FJJPMAIFPPM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0x6F6040", Offset = "0x6F4840", VA = "0x1806F6040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(FJJPMAIFPPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0x2C91730", Offset = "0x2C8FF30", VA = "0x182C91730", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x97CE80", Offset = "0x97B680", VA = "0x18097CE80")]
		[DebuggerHidden]
		public DNPAGJGMJDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x2C91580", Offset = "0x2C8FD80", VA = "0x182C91580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x2C916F0", Offset = "0x2C8FEF0", VA = "0x182C916F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x2C91640", Offset = "0x2C8FE40", VA = "0x182C91640", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FJJPMAIFPPM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x2C91640", Offset = "0x2C8FE40", VA = "0x182C91640", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private GGNOOGMPGOK KKLJBHKLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private KCAEMPACMFG CFNMOHJBEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private ObjectInstantiationService HFGBBMMCEFF;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EntityManager NKKGJCLICDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x2D06F20", Offset = "0x2D05720", VA = "0x182D06F20")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private NBDMAOHFKJB AFGIMGNBGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2D07420", Offset = "0x2D05C20", VA = "0x182D07420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2D06DE0", Offset = "0x2D055E0", VA = "0x182D06DE0", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x2D06C20", Offset = "0x2D05420", VA = "0x182D06C20", Slot = "5")]
	public void CDAPNANJPJJ(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x2D06E70", Offset = "0x2D05670", VA = "0x182D06E70", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x2D07470", Offset = "0x2D05C70", VA = "0x182D07470")]
	private void MEBNOEFCNBK(Entity ILHJHGHHOBN, in OJMHOIEICMJ CEOLOJHDIEE, in OJMHOIEICMJ PMHHEDOHMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x2D06BC0", Offset = "0x2D053C0", VA = "0x182D06BC0", Slot = "14")]
	public FJJPMAIFPPM BKIIIKIIBKB()
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x2D076F0", Offset = "0x2D05EF0", VA = "0x182D076F0", Slot = "10")]
	public void MJDJHLONAPF(FJJPMAIFPPM AIOPADAFDKL, EMAHDKOMOHN NDEGHHCMGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2D07110", Offset = "0x2D05910", VA = "0x182D07110", Slot = "9")]
	public EMAHDKOMOHN GNMAHGNPHPK(FJJPMAIFPPM AIOPADAFDKL)
	{
		return default(EMAHDKOMOHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x2D07880", Offset = "0x2D06080", VA = "0x182D07880", Slot = "11")]
	public FJJPMAIFPPM OLHMDGGGMGE(FJJPMAIFPPM EADIPFLIBFM, [Optional] Vector3? LMLCHIPKJPI, [Optional] Quaternion? ILBCPDKFKMC, [Optional] Vector3? NLPGPFFCFFJ)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x2D07290", Offset = "0x2D05A90", VA = "0x182D07290", Slot = "15")]
	public FJJPMAIFPPM JOJDKBEOIIA(FJJPMAIFPPM EEBAGCLDEAJ, int LHHBOCAHDEE, [Optional] Vector3? LMLCHIPKJPI, [Optional] Quaternion? ILBCPDKFKMC, [Optional] Vector3? NLPGPFFCFFJ)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x2D07B80", Offset = "0x2D06380", VA = "0x182D07B80", Slot = "7")]
	public FJJPMAIFPPM PMIOLOIIDEK(FJJPMAIFPPM EEBAGCLDEAJ, int LHHBOCAHDEE)
	{
		return default(FJJPMAIFPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x2D06D20", Offset = "0x2D05520", VA = "0x182D06D20", Slot = "16")]
	public void CMHHLHOAHAB(FJJPMAIFPPM EEBAGCLDEAJ, FJJPMAIFPPM MKJOCAGMBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x2D06A20", Offset = "0x2D05220", VA = "0x182D06A20", Slot = "12")]
	public void AJAEHIGNIOI(FJJPMAIFPPM EEBAGCLDEAJ, int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x2D06F70", Offset = "0x2D05770", VA = "0x182D06F70", Slot = "17")]
	public void FLLOMJCMKGG(FJJPMAIFPPM EEBAGCLDEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x2D077E0", Offset = "0x2D05FE0", VA = "0x182D077E0", Slot = "8")]
	public int OLGPPDKKDJB(FJJPMAIFPPM EEBAGCLDEAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x2D07200", Offset = "0x2D05A00", VA = "0x182D07200", Slot = "6")]
	[IteratorStateMachine(typeof(DNPAGJGMJDA))]
	public IEnumerable<FJJPMAIFPPM> JNOKLNEFIHH(FJJPMAIFPPM EEBAGCLDEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x2D07390", Offset = "0x2D05B90", VA = "0x182D07390")]
	private bool LBCPKMLAGJN(FJJPMAIFPPM EEBAGCLDEAJ, out NativeArray<Entity> MDNHGAAHKGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2D072D0", Offset = "0x2D05AD0", VA = "0x182D072D0")]
	private NativeArray<Entity> KOLMLGDFOID(FJJPMAIFPPM EEBAGCLDEAJ)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public AJFADJHBHEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[LDBLEAFJJLE(EKKHFCELHOI.LoadInstance)]
[FIKNCOOOHID(typeof(CLKJBNJKMPE), new string[] { })]
internal sealed class CLKJBNJKMPE : HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private PNONIBNMECP IFJKGEPFDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformOwnershipPhase FBCMJKDDCBJ;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private KPAAIPGAPMC BCCOIHBMLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x2D0E610", Offset = "0x2D0CE10", VA = "0x182D0E610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E2C0", Offset = "0x2D0CAC0", VA = "0x182D0E2C0", Slot = "4")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E1D0", Offset = "0x2D0C9D0", VA = "0x182D0E1D0")]
	public void AEMBCADEEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x2D0E340", Offset = "0x2D0CB40", VA = "0x182D0E340")]
	public void LNIIPNLFIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public CLKJBNJKMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct AFEMNBEEDKN : IEquatable<AFEMNBEEDKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly int CGPOEJKODDA;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Type ECHKLFAEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x2D068A0", Offset = "0x2D050A0", VA = "0x182D068A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x2D06980", Offset = "0x2D05180", VA = "0x182D06980")]
	public AFEMNBEEDKN(Type EHPFPOFFCEJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x2D067C0", Offset = "0x2D04FC0", VA = "0x182D067C0")]
	public static AFEMNBEEDKN AGJOPELLCGM(Type EHPFPOFFCEJ)
	{
		return default(AFEMNBEEDKN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x2D06770", Offset = "0x2D04F70", VA = "0x182D06770")]
	public static Type AGJOPELLCGM(AFEMNBEEDKN AEGKMFNDGLH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x1371C30", Offset = "0x1370430", VA = "0x181371C30")]
	public static bool GLPMECKCBFF(AFEMNBEEDKN HDPOKDCLGGE, AFEMNBEEDKN JBKIIGINOKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x1371C30", Offset = "0x1370430", VA = "0x181371C30")]
	public static bool PKJGEKBKGNO(AFEMNBEEDKN HDPOKDCLGGE, AFEMNBEEDKN JBKIIGINOKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x87C520", Offset = "0x87AD20", VA = "0x18087C520", Slot = "4")]
	public bool Equals(AFEMNBEEDKN HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x2D06820", Offset = "0x2D05020", VA = "0x182D06820", Slot = "0")]
	public override bool Equals(object BFHAMCLNCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x2D06900", Offset = "0x2D05100", VA = "0x182D06900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public static class PHADFHNPCDG
{
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static Dictionary<Type, int> CKNCNMMAEMH;

	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private static List<Type> EMKIFDBHEPM;

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x28AF690", Offset = "0x28ADE90", VA = "0x1828AF690")]
	static PHADFHNPCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x2A19C90", Offset = "0x2A18490", VA = "0x182A19C90")]
	public static bool LGCDELLOPGJ<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x28AF4B0", Offset = "0x28ADCB0", VA = "0x1828AF4B0")]
	public static bool LGCDELLOPGJ(Type EHPFPOFFCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x28AF520", Offset = "0x28ADD20", VA = "0x1828AF520")]
	private static bool LGCDELLOPGJ(Type EHPFPOFFCEJ, out int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x2A19B60", Offset = "0x2A18360", VA = "0x182A19B60")]
	public static int CJEAEPMIFBE<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x28AF1E0", Offset = "0x28AD9E0", VA = "0x1828AF1E0")]
	public static int CJEAEPMIFBE(Type EHPFPOFFCEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x2A19BF0", Offset = "0x2A183F0", VA = "0x182A19BF0")]
	public static bool GKBJHBOCHEL<T>(out int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x28AF370", Offset = "0x28ADB70", VA = "0x1828AF370")]
	public static bool GKBJHBOCHEL(Type EHPFPOFFCEJ, out int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x28AF410", Offset = "0x28ADC10", VA = "0x1828AF410")]
	public static Type HEJAGBNBHFE(int LHHBOCAHDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x28AF250", Offset = "0x28ADA50", VA = "0x1828AF250")]
	public static bool GKBJHBOCHEL(int LHHBOCAHDEE, out Type EHPFPOFFCEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DefaultMember("Item")]
public struct EFNMHCNBHEM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private T[] LBEMEOBAAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private int EEOHOPIJABN;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int CADKIJKDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F00", Offset = "0x7F4700", VA = "0x1807F5F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x14B6220", Offset = "0x14B4A20", VA = "0x1814B6220")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> JGNKFCPIIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x32AE410", Offset = "0x32ACC10", VA = "0x1832AE410")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool IMLDPEBIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5B0", Offset = "0x8F8DB0", VA = "0x1808FA5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x32AE620", Offset = "0x32ACE20", VA = "0x1832AE620")]
	public EFNMHCNBHEM(int EEOHOPIJABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x32AE570", Offset = "0x32ACD70", VA = "0x1832AE570")]
	public int FDIMGBOHNMI(T NPHADDCNBHE, int DAOIPFCHFFJ, int FCKFNIPNJCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x32AE4B0", Offset = "0x32ACCB0", VA = "0x1832AE4B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DefaultMember("Item")]
public struct JDAFFIMJJKG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private global::EFNMHCNBHEM<T> LBEMEOBAAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private int EEOHOPIJABN;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public T IOEJBJHPAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x33FF4B0", Offset = "0x33FDCB0", VA = "0x1833FF4B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int CADKIJKDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x33FF3A0", Offset = "0x33FDBA0", VA = "0x1833FF3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int LBDHOLBKIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x33FF3F0", Offset = "0x33FDBF0", VA = "0x1833FF3F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x33FED00", Offset = "0x33FD500", VA = "0x1833FED00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool IMLDPEBIIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x33FF420", Offset = "0x33FDC20", VA = "0x1833FF420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> JGNKFCPIIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x33FE410", Offset = "0x33FCC10", VA = "0x1833FE410")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x33FFD40", Offset = "0x33FE540", VA = "0x1833FFD40")]
	public JDAFFIMJJKG(int EEOHOPIJABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x33FF460", Offset = "0x33FDC60", VA = "0x1833FF460")]
	public T NGLPKIGBKIH(int LHHBOCAHDEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x33FEC90", Offset = "0x33FD490", VA = "0x1833FEC90")]
	public void GLHAHMPMGFP(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x33FE560", Offset = "0x33FCD60", VA = "0x1833FE560")]
	public void BDPJFLBJBLP(Span<T> HGPMCGJIADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x33FF290", Offset = "0x33FDA90", VA = "0x1833FF290")]
	public void LGCDELLOPGJ(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x33FF540", Offset = "0x33FDD40", VA = "0x1833FF540")]
	private void NPLLIMOCIME(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x33FF6C0", Offset = "0x33FDEC0", VA = "0x1833FF6C0")]
	public void OGMEKNCJPGN(Span<T> GDAMMKPBIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x33FFC70", Offset = "0x33FE470", VA = "0x1833FFC70")]
	public void PPCLHBMECLP(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x33FEDB0", Offset = "0x33FD5B0", VA = "0x1833FEDB0")]
	public void KGAEFGFAPNC(int CKHFNLBMEBL, int FBIOFODCNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x33FE6D0", Offset = "0x33FCED0", VA = "0x1833FE6D0")]
	public void DCPLCAPJDEC(int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x33FFA60", Offset = "0x33FE260", VA = "0x1833FFA60")]
	public void PEHFPPEEEDM(int CKHFNLBMEBL, int FBIOFODCNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x33FE870", Offset = "0x33FD070", VA = "0x1833FE870")]
	public void DPJNFLJBKCK(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x33FEFD0", Offset = "0x33FD7D0", VA = "0x1833FEFD0")]
	public void KKOGBCLDDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x33FE980", Offset = "0x33FD180", VA = "0x1833FE980")]
	public int FDIMGBOHNMI(T NPHADDCNBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x33FED50", Offset = "0x33FD550", VA = "0x1833FED50")]
	public bool JEBNAOILLLF(T NPHADDCNBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x33FE930", Offset = "0x33FD130", VA = "0x1833FE930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x33FFCD0", Offset = "0x33FE4D0", VA = "0x1833FFCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x33FE3A0", Offset = "0x33FCBA0", VA = "0x1833FE3A0")]
	public static Span<T> AGJOPELLCGM(global::JDAFFIMJJKG<T> HGPMCGJIADE)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x33FEB50", Offset = "0x33FD350", VA = "0x1833FEB50")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void FLHIAAKCMND(int NPHADDCNBHE, int EEOHOPIJABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void OOEIGFCCDBP(int EEOHOPIJABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x33FF900", Offset = "0x33FE100", VA = "0x1833FF900")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void OOEIGFCCDBP(int EEOHOPIJABN, int LHHBOCAHDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x33FEA10", Offset = "0x33FD210", VA = "0x1833FEA10")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void FJCDBOJGBBH(int NPHADDCNBHE, int EEOHOPIJABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x33FF090", Offset = "0x33FD890", VA = "0x1833FF090")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void LDHCIMOJFCO(int CKHFNLBMEBL, int FBIOFODCNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x33FE730", Offset = "0x33FCF30", VA = "0x1833FE730")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DKAOEIGDNDA(int NPHADDCNBHE, int EEOHOPIJABN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public struct GDIPBBIJEHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private const int AILJLBMPMKF = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NativeList<Entity> NBDCDJJEKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private TransformAccessArray FLBPGJKFMKM;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x31C8760", Offset = "0x31C6F60", VA = "0x1831C8760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> CANABFEDLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0xC3D8C0", Offset = "0xC3C0C0", VA = "0x180C3D8C0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray HMNCOABPCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool IFJHKPDANNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x31C8970", Offset = "0x31C7170", VA = "0x1831C8970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x31C8A50", Offset = "0x31C7250", VA = "0x1831C8A50")]
	public GDIPBBIJEHP(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x31C8850", Offset = "0x31C7050", VA = "0x1831C8850")]
	public Entity IMIFFPJMEKI(int LHHBOCAHDEE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x31C8840", Offset = "0x31C7040", VA = "0x1831C8840")]
	public Transform ILPEICCBMJP(int LHHBOCAHDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x31C8770", Offset = "0x31C6F70", VA = "0x1831C8770")]
	public void CAHNMGLFAEN(int EBGHKBFPDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x31C88A0", Offset = "0x31C70A0", VA = "0x1831C88A0")]
	public int LGCDELLOPGJ(Transform KPFEIMOAGDN, Entity DJGIAPPGDDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x31C89D0", Offset = "0x31C71D0", VA = "0x1831C89D0")]
	public int PPCLHBMECLP(int LHHBOCAHDEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x31C87C0", Offset = "0x31C6FC0", VA = "0x1831C87C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x31C8990", Offset = "0x31C7190", VA = "0x1831C8990")]
	private void NLAIBADAEDP(int AJEHGHAKFLB = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class CIIKJDBLDND : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private NativeHashMap<AFEMNBEEDKN, int2> KIANELGFIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private NativeList<byte> DNLJJNDPNCG;

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DBD0", Offset = "0x2D0C3D0", VA = "0x182D0DBD0")]
	public CIIKJDBLDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DAD0", Offset = "0x2D0C2D0", VA = "0x182D0DAD0")]
	public void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	public void BJPKOCBPDKP<T>(T NPHADDCNBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	public T HEJAGBNBHFE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D3F0", Offset = "0x2D0BBF0", VA = "0x182D0D3F0")]
	public void BJPKOCBPDKP(Type EHPFPOFFCEJ, OJMHOIEICMJ NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D840", Offset = "0x2D0C040", VA = "0x182D0D840")]
	public OJMHOIEICMJ HEJAGBNBHFE(Type EHPFPOFFCEJ)
	{
		return default(OJMHOIEICMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DB30", Offset = "0x2D0C330", VA = "0x182D0DB30")]
	private NativeArray<byte> PAKJDJLGFIK(int2 FLIHBAIJMPI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D680", Offset = "0x2D0BE80", VA = "0x182D0D680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D720", Offset = "0x2D0BF20", VA = "0x182D0D720", Slot = "1")]
	~CIIKJDBLDND()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public struct CLHINLIABPJ<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	internal static T PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	public static global::CLHINLIABPJ<T> AGJOPELLCGM(T NPHADDCNBHE)
	{
		return default(global::CLHINLIABPJ<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	public static T AGJOPELLCGM(global::CLHINLIABPJ<T> CMEPDMFEMEH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public static class KKMOIMMOOIB
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly CIIKJDBLDND MLBDIBOHBCJ;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x31D7ED0", Offset = "0x31D66D0", VA = "0x1831D7ED0")]
	internal static void MMLFENDEPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void BJPKOCBPDKP<T>(T NPHADDCNBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x31D7D90", Offset = "0x31D6590", VA = "0x1831D7D90")]
	public static void BJPKOCBPDKP(Type EHPFPOFFCEJ, OJMHOIEICMJ NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T HEJAGBNBHFE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x31D7E30", Offset = "0x31D6630", VA = "0x1831D7E30")]
	public static OJMHOIEICMJ HEJAGBNBHFE(Type EHPFPOFFCEJ)
	{
		return default(OJMHOIEICMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class CDNJBHNHHAI : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public static readonly CDNJBHNHHAI KKHIANFEDKJ;

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CDD0", Offset = "0x2D0B5D0", VA = "0x182D0CDD0", Slot = "4")]
	public bool Equals(LinkedEntityGroup NGMFABJMIHP, LinkedEntityGroup OMDBFFDAOFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CDF0", Offset = "0x2D0B5F0", VA = "0x182D0CDF0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup BFHAMCLNCKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public CDNJBHNHHAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class ACBGKHNOPIB
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void ADJKGMIKDMI(in Vector3 LMLCHIPKJPI, in Quaternion ILBCPDKFKMC, in Vector3 NLPGPFFCFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void IAENDOGJGLI(in Vector3 NOGIFHMFJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void DBNCFPDPDKJ(in Quaternion ILBCPDKFKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void EAJELJAMJKI(in Vector3 JPBBNKFMPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void EMKLCCAAGJL(in Vector3 JPBBNKFMPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void BOAPKPLKKII(in float DFBHCLBJHAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x2D06640", Offset = "0x2D04E40", VA = "0x182D06640")]
	[Conditional("DEBUG_BUILD")]
	public static void FPOGDLKMOIM(in float3 NPHADDCNBHE, string EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void AGHBBGABLPL(in float NPHADDCNBHE, string EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x2D065C0", Offset = "0x2D04DC0", VA = "0x182D065C0")]
	[Conditional("DEBUG_BUILD")]
	public static void AGHBBGABLPL(in Vector3 NPHADDCNBHE, string EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x2D06610", Offset = "0x2D04E10", VA = "0x182D06610")]
	[Conditional("DEBUG_BUILD")]
	public static void AGHBBGABLPL(in Quaternion NPHADDCNBHE, string EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x2D06730", Offset = "0x2D04F30", VA = "0x182D06730")]
	[Conditional("DEBUG_BUILD")]
	public static void JPPLLJFBBHI(in float NPHADDCNBHE, string EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x2D066F0", Offset = "0x2D04EF0", VA = "0x182D066F0")]
	[Conditional("DEBUG_BUILD")]
	public static void JPPLLJFBBHI(in Vector3 NPHADDCNBHE, string EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x2D06740", Offset = "0x2D04F40", VA = "0x182D06740")]
	[Conditional("DEBUG_BUILD")]
	public static void JPPLLJFBBHI(in Quaternion NPHADDCNBHE, string EPAIMCEIMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public ACBGKHNOPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct AJKPJGJILHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public Entity DJGIAPPGDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public Entity KHANAHCNFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public Entity ILKPJDALDEG;

	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2D07CD0", Offset = "0x2D064D0", VA = "0x182D07CD0")]
	public AJKPJGJILHO(Entity DJGIAPPGDDP, Entity KHANAHCNFDD, Entity ILKPJDALDEG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x2D07C70", Offset = "0x2D06470", VA = "0x182D07C70")]
	public static AJKPJGJILHO AGJOPELLCGM((Entity entity, Entity oldParent, Entity newParent) MJMDDOAPHHJ)
	{
		return default(AJKPJGJILHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2D07CB0", Offset = "0x2D064B0", VA = "0x182D07CB0")]
	public void NEMBEEBJDEF(out Entity DJGIAPPGDDP, out Entity KHANAHCNFDD, out Entity ILKPJDALDEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct NMHNICEEPMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public Entity DJGIAPPGDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public Entity FAAJOMIIHED;

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0xE9DF20", Offset = "0xE9C720", VA = "0x180E9DF20")]
	public NMHNICEEPMK(Entity DJGIAPPGDDP, Entity FAAJOMIIHED)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x289F430", Offset = "0x289DC30", VA = "0x18289F430")]
	public static NMHNICEEPMK AGJOPELLCGM((Entity entity, Entity parent) MJMDDOAPHHJ)
	{
		return default(NMHNICEEPMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x289F460", Offset = "0x289DC60", VA = "0x18289F460")]
	public void NEMBEEBJDEF(out Entity DJGIAPPGDDP, out Entity FAAJOMIIHED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct FNCPKGOFHCC<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private GCHandle AEGKMFNDGLH;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public bool PNOHMDBKGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x289EBD0", Offset = "0x289D3D0", VA = "0x18289EBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x2993BD0", Offset = "0x29923D0", VA = "0x182993BD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x2993B10", Offset = "0x2992310", VA = "0x182993B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x2993CA0", Offset = "0x29924A0", VA = "0x182993CA0")]
	public FNCPKGOFHCC(T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x2993C70", Offset = "0x2992470", VA = "0x182993C70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public enum GFMCMGAGLEO
{
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public struct FOAHIHJJOGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public GFMCMGAGLEO AKDHPBGHKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public int FJBDCFOGIOB;

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0x6F6050", Offset = "0x6F4850", VA = "0x1806F6050")]
	public FOAHIHJJOGA(GFMCMGAGLEO AKDHPBGHKBH, int FJBDCFOGIOB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x31C65E0", Offset = "0x31C4DE0", VA = "0x1831C65E0")]
	public static FOAHIHJJOGA AGJOPELLCGM((GFMCMGAGLEO eventType, int eventIndex) NGMFABJMIHP)
	{
		return default(FOAHIHJJOGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x31C6600", Offset = "0x31C4E00", VA = "0x1831C6600")]
	public void NEMBEEBJDEF(out GFMCMGAGLEO AKDHPBGHKBH, out int FJBDCFOGIOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[FIKNCOOOHID(typeof(FDJFKJKIFJL), new string[] { })]
public sealed class IMMPONFEFFG : FDJFKJKIFJL, HNOABDNADGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private OJCMJJNIHBI APPHPFMBIHO;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x31D1FF0", Offset = "0x31D07F0", VA = "0x1831D1FF0", Slot = "5")]
	public void CMOJEMNLLJM(FEIANFNLNIA BDDMBDBDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x31D2040", Offset = "0x31D0840", VA = "0x1831D2040")]
	public bool HNABONJCHIG(in float3 INODPFILAHI, in float3 ACGENMPHBIP, float DGBJANBPLCN, Allocator OODGOAPHOCI, out NativeArray<Entity> NBDCDJJEKHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public IMMPONFEFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x31D2040", Offset = "0x31D0840", VA = "0x1831D2040", Slot = "4")]
	private bool KJJMOKFNDDF(in float3 INODPFILAHI, in float3 ACGENMPHBIP, float DGBJANBPLCN, Allocator OODGOAPHOCI, out NativeArray<Entity> NBDCDJJEKHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[OIGNJMDILHE]
[UpdateInGroup(typeof(CKGMDBLLDEM))]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
internal sealed class CDOGBIMNCDE : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CED0", Offset = "0x2D0B6D0", VA = "0x182D0CED0", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public CDOGBIMNCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[OIGNJMDILHE]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
[UpdateInGroup(typeof(EHJPMOLJHCA))]
public sealed class KNKEOLMMEHJ : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0x31D8130", Offset = "0x31D6930", VA = "0x1831D8130", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public KNKEOLMMEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[OIGNJMDILHE]
[UpdateInGroup(typeof(JAHBOJBAOGH))]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
internal sealed class MCEIJHOOLMA : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0x31DDF40", Offset = "0x31DC740", VA = "0x1831DDF40", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public MCEIJHOOLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class DOGCMCIHMAG : JHAOANHDNMH
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public DOGCMCIHMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[OIGNJMDILHE]
[ExecuteAlways]
[KKJJBJLJHEJ(EKKHFCELHOI.LoadInstance)]
[UpdateInGroup(typeof(NOONHJOANKP))]
internal sealed class OJEKHACFHMH : AMLOANEKHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0x28A0E40", Offset = "0x289F640", VA = "0x1828A0E40", Slot = "16")]
	protected override ComponentSystemBase JIIGMLFDIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F20", Offset = "0x289F720", VA = "0x1828A0F20")]
	public OJEKHACFHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[IGLOFDAMHJI(typeof(AuthoredLocalPoseData))]
public sealed class ENENIPLCLPB : MGLBMFBMFBB
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x31BF820", Offset = "0x31BE020", VA = "0x1831BF820", Slot = "8")]
	protected override bool DGKCGBDJEIM(ReadOnlySpan<AuthoredLocalPoseData> GDAMMKPBIEJ, AFDHGGDCOPP HIGOLFJOLNG, out ReadOnlySpan<byte> GJAPHEDPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x31BF8A0", Offset = "0x31BE0A0", VA = "0x1831BF8A0", Slot = "9")]
	protected override bool GPCMOABGGOK(int OGPINCOPHCL, Span<AuthoredLocalPoseData> GDAMMKPBIEJ, in ReadOnlySpan<byte> GJAPHEDPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x31BF960", Offset = "0x31BE160", VA = "0x1831BF960")]
	public ENENIPLCLPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[IGLOFDAMHJI(typeof(LocalPoseData))]
public sealed class CNKKOGIGFJE : FKALALOAIPE
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EA10", Offset = "0x2D0D210", VA = "0x182D0EA10", Slot = "8")]
	protected override bool DGKCGBDJEIM(ReadOnlySpan<LocalPoseData> GDAMMKPBIEJ, AFDHGGDCOPP HIGOLFJOLNG, out ReadOnlySpan<byte> GJAPHEDPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EA90", Offset = "0x2D0D290", VA = "0x182D0EA90", Slot = "9")]
	protected override bool GPCMOABGGOK(int OGPINCOPHCL, Span<LocalPoseData> GDAMMKPBIEJ, in ReadOnlySpan<byte> GJAPHEDPMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x2D0EB50", Offset = "0x2D0D350", VA = "0x182D0EB50")]
	public CNKKOGIGFJE()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Preserve]
	internal class _RRAssemblyIndex : PMFBNHDKHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD880", Offset = "0x2CAC080", VA = "0x182CAD880", Slot = "6")]
		public sealed override void ICNICBCAKMK(DPEPEONFLCL MKOFIMIHGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x2CAE8A0", Offset = "0x2CAD0A0", VA = "0x182CAE8A0", Slot = "4")]
		public sealed override void JBLIKMGAHBK()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x28AEE00", Offset = "0x28AD600", VA = "0x1828AEE00")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x28AEAB0", Offset = "0x28AD2B0", VA = "0x1828AEAB0")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
