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
public sealed class PKOHCMJPDPB<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class LMFHIDAOKDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::PKOHCMJPDPB<T> PALPKBJBNFE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] MBOCDIOJJOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public LMFHIDAOKDM(global::PKOHCMJPDPB<T> PALPKBJBNFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class ODIEGNHONDD : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::PKOHCMJPDPB<T> <>4__this;

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
		public ODIEGNHONDD(int <>1__state)
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
	private const int HMGJFHCNMCO = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> NJMPLIDCLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int JIDNOKOAONG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T CLGONNHLFJK
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
	private bool DLHPHEPOECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool MFGAEDOGEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool HAEJJANLLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LPHNGEMLJIO
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
	public int HMGCLIBMMBB
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
	public PKOHCMJPDPB(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public PKOHCMJPDPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void IHIHANEDMEJ(int GABJOMFFJAI, T GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void OKDKIIFFNKJ(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] BJNJCKGMKBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void BMJMIKKMFFK(NativeArray<T> OGMMNHCCDJE, int HCDIEBFNKKL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::PKOHCMJPDPB<>.ODIEGNHONDD))]
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
	public int GLKAIEBIFIN(T GABBPODJMBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool GAMANBAONBG(T GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void IGPPPAFFOHG(int JCAPLCCIODC, int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void COKDILDBMGE(int JCAPLCCIODC, int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void OHEOGOIIBOM(int JCAPLCCIODC, int BPNKPMGDGFM, int NDNADCNCIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int NNDOGGNGDAH(int GABJOMFFJAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T AMAJKBAELCI(int GABJOMFFJAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void JIEJHPFEEPM(int GABJOMFFJAI, T GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void ADGGBDJKJFB(int GABJOMFFJAI, T GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void AEALALEHEPK(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int BCEONLIGIAB(int FPLJCBGEJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int HHCAECOBHHB(int FPLJCBGEJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void HMCBAEFCKPD(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void GKMKGOANJLP(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T HFKOLIPEBOP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T OBCFNEBPEIO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void BDBOPKLPJDO(int GABJOMFFJAI, IReadOnlyCollection<T> NBEDLAKOFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void KEHHLHLDIMC(int GABJOMFFJAI, int AEBGJOAEDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void HMPJFJGOKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void IOOKIOOKFLP(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void JNBNDNEOJEJ(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void GBAIENLFEOC(int BPNKPMGDGFM, int NDNADCNCIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T KOGLBDPJBKM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T BDDOBJLLGDB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[ONGHGJGJFIP]
public static class COEOLDJJBAN
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x37DDA20", Offset = "0x37DCE20", VA = "0x1837DDA20")]
	static COEOLDJJBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1EB0", Offset = "0x2CA12B0", VA = "0x182CA1EB0")]
	public static void DPFIAKCAAIL<T>(T KEPPKNDIOGA, ref T MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x37DD9F0", Offset = "0x37DCDF0", VA = "0x1837DD9F0")]
	public static void DPFIAKCAAIL(FixedString32 KEPPKNDIOGA, ref string MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x37DD860", Offset = "0x37DCC60", VA = "0x1837DD860")]
	public static void DPFIAKCAAIL(string KEPPKNDIOGA, ref FixedString32 MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37DD760", Offset = "0x37DCB60", VA = "0x1837DD760")]
	public static void DPFIAKCAAIL(FixedString64 KEPPKNDIOGA, ref string MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37DD790", Offset = "0x37DCB90", VA = "0x1837DD790")]
	public static void DPFIAKCAAIL(string KEPPKNDIOGA, ref FixedString64 MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x37DD950", Offset = "0x37DCD50", VA = "0x1837DD950")]
	public static void DPFIAKCAAIL(ECNIIOOEOPM KEPPKNDIOGA, ref Vector3 MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x37DD8A0", Offset = "0x37DCCA0", VA = "0x1837DD8A0")]
	public static void DPFIAKCAAIL(Vector3 KEPPKNDIOGA, ref ECNIIOOEOPM MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x37DD7F0", Offset = "0x37DCBF0", VA = "0x1837DD7F0")]
	public static void DPFIAKCAAIL(NPBACOCGBGC KEPPKNDIOGA, ref Vector4 MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x37DD6F0", Offset = "0x37DCAF0", VA = "0x1837DD6F0")]
	public static void DPFIAKCAAIL(Vector4 KEPPKNDIOGA, ref NPBACOCGBGC MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x37DD7F0", Offset = "0x37DCBF0", VA = "0x1837DD7F0")]
	public static void DPFIAKCAAIL(NPBACOCGBGC KEPPKNDIOGA, ref Quaternion MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37DD6F0", Offset = "0x37DCAF0", VA = "0x1837DD6F0")]
	public static void DPFIAKCAAIL(Quaternion KEPPKNDIOGA, ref NPBACOCGBGC MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37DD920", Offset = "0x37DCD20", VA = "0x1837DD920")]
	public static void DPFIAKCAAIL(ECNIIOOEOPM KEPPKNDIOGA, ref float3 MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37DD8A0", Offset = "0x37DCCA0", VA = "0x1837DD8A0")]
	public static void DPFIAKCAAIL(float3 KEPPKNDIOGA, ref ECNIIOOEOPM MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x37DD820", Offset = "0x37DCC20", VA = "0x1837DD820")]
	public static void DPFIAKCAAIL(NPBACOCGBGC KEPPKNDIOGA, ref float4 MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x37DD6F0", Offset = "0x37DCAF0", VA = "0x1837DD6F0")]
	public static void DPFIAKCAAIL(float4 KEPPKNDIOGA, ref NPBACOCGBGC MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x37DD820", Offset = "0x37DCC20", VA = "0x1837DD820")]
	public static void DPFIAKCAAIL(NPBACOCGBGC KEPPKNDIOGA, ref quaternion MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x37DD980", Offset = "0x37DCD80", VA = "0x1837DD980")]
	public static void DPFIAKCAAIL(quaternion KEPPKNDIOGA, ref NPBACOCGBGC MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37DD6B0", Offset = "0x37DCAB0", VA = "0x1837DD6B0")]
	public static void DPFIAKCAAIL(Entity KEPPKNDIOGA, ref HMEOPGPJFDC MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37DD900", Offset = "0x37DCD00", VA = "0x1837DD900")]
	public static void DPFIAKCAAIL(HMEOPGPJFDC KEPPKNDIOGA, ref Entity MOGKIAPIIGE, NFOMLMHEAPG HHEIDBCECNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JMGOLFGIKPD]
public class DMHJKPOFDBM : ComponentSystem, NGENPNOGFON
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LODNGHNPONL ECODFCBICCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x762090", VA = "0x180762C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FJFNAPPGKJO KLKODJCENGP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x963B10", Offset = "0x962F10", VA = "0x180963B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x37ECCE0", Offset = "0x37EC0E0", VA = "0x1837ECCE0", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
	public DMHJKPOFDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[JMGOLFGIKPD]
[UpdateInGroup(typeof(HBAPGHAGNNO))]
internal class BHMFNNBLILG : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37D7B40", Offset = "0x37D6F40", VA = "0x1837D7B40", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x37D7AC0", Offset = "0x37D6EC0", VA = "0x1837D7AC0")]
	[Preserve]
	private void BPAEIMDEDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public BHMFNNBLILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[JMGOLFGIKPD]
[UpdateInGroup(typeof(HBAPGHAGNNO))]
internal class HLJPCAHNJNH : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3A686A0", Offset = "0x3A67AA0", VA = "0x183A686A0", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public HLJPCAHNJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x376D280", Offset = "0x376C680", VA = "0x18376D280")]
		public static ObjectModelConfigAsset BHKMBCNGMNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x830720", Offset = "0x82FB20", VA = "0x180830720")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NAPHGBOEKGO(GPIMBHHJLKL.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int CCAIINGOJEF = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly BBHAOFNBCPD CDECIAPNKBP;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4197870", Offset = "0x4196C70", VA = "0x184197870")]
			public static EHNBIOJHEAD CBDLGPIINJH(int HICOICFGNNI)
			{
				return default(EHNBIOJHEAD);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4197C60", Offset = "0x4197060", VA = "0x184197C60")]
			private static void DFPEGAODKME(KJNCFICFIIE ALABMIAECDD, KJNCFICFIIE ALAGOIKNDML, EHNBIOJHEAD DGDIPHPMEJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x41976A0", Offset = "0x4196AA0", VA = "0x1841976A0")]
			public static int AICOPCIKCKP(GameObject CEPEJEHMODM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4197DF0", Offset = "0x41971F0", VA = "0x184197DF0")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void IPKJMJBGMDK(KJNCFICFIIE GNKPFNIMJND, int HICOICFGNNI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static BHKHBEKDAPI CBOODPBIPLK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static GHOBGEJJNGE CBHBKOJKJOB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static BHKHBEKDAPI CIFMMJJOMMN
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x376E280", Offset = "0x376D680", VA = "0x18376E280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x376E1A0", Offset = "0x376D5A0", VA = "0x18376E1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static GHOBGEJJNGE PICBHMCFDHK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x376DDB0", Offset = "0x376D1B0", VA = "0x18376DDB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x376E940", Offset = "0x376DD40", VA = "0x18376E940")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool KBKFCOKPGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x376E2E0", Offset = "0x376D6E0", VA = "0x18376E2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static LODNGHNPONL ECODFCBICCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x376D750", Offset = "0x376CB50", VA = "0x18376D750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static FJFNAPPGKJO KLKODJCENGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x376DF80", Offset = "0x376D380", VA = "0x18376DF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static DFBNDOPHHMN ABEDOKHPDDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x376EBC0", Offset = "0x376DFC0", VA = "0x18376EBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static HADKCCFJPOA BKLGFBKLNMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x376DD30", Offset = "0x376D130", VA = "0x18376DD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static LBIICBANFEM PFPFEJCGPDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x376EC40", Offset = "0x376E040", VA = "0x18376EC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static OBNLPCJMAPP NIAOPJFMOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x376E120", Offset = "0x376D520", VA = "0x18376E120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool MOOFMHLFNPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x376D8E0", Offset = "0x376CCE0", VA = "0x18376D8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool BEJKMNDDLLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x376D380", Offset = "0x376C780", VA = "0x18376D380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool ECELMOEEOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x376DAE0", Offset = "0x376CEE0", VA = "0x18376DAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool IHKECFDFKBM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x376DCD0", Offset = "0x376D0D0", VA = "0x18376DCD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x376D320", Offset = "0x376C720", VA = "0x18376D320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool OHHOIDDBKJF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x376ECC0", Offset = "0x376E0C0", VA = "0x18376ECC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x376E760", Offset = "0x376DB60", VA = "0x18376E760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action JFCBDEPNNFP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x376E660", Offset = "0x376DA60", VA = "0x18376E660")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x376ED20", Offset = "0x376E120", VA = "0x18376ED20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x376D7F0", Offset = "0x376CBF0", VA = "0x18376D7F0")]
		public static KJNCFICFIIE EHPBFPGFMPJ(GameObject CEPEJEHMODM)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x376E520", Offset = "0x376D920", VA = "0x18376E520")]
		public static bool KPHPPPGHLGL(ByteString LFBMPCLHCOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x376E000", Offset = "0x376D400", VA = "0x18376E000")]
		public static NPBAKKOKIOD ICIJFFNHLIF(EHNBIOJHEAD DGDIPHPMEJP)
		{
			return default(NPBAKKOKIOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x376D600", Offset = "0x376CA00", VA = "0x18376D600")]
		public static (ByteString, IDisposable) DGECGJPLFOM()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x376D4B0", Offset = "0x376C8B0", VA = "0x18376D4B0")]
		public static (ByteString, IDisposable) COIIFKNAEJI(IEnumerable<KJNCFICFIIE> PKIIINIFBDJ)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x376EE20", Offset = "0x376E220", VA = "0x18376EE20")]
		public static bool PLIBEFNFKBD(GameObject CEPEJEHMODM, out EHNBIOJHEAD DGDIPHPMEJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x376DED0", Offset = "0x376D2D0", VA = "0x18376DED0")]
		public static bool HNGAOOBPOLC(IEnumerable<CLDNBOMABLC> FMEMBKBFPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x376E580", Offset = "0x376D980", VA = "0x18376E580")]
		public static void LFGHOBEPJKE(bool KHOMHGNHAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x376E7C0", Offset = "0x376DBC0", VA = "0x18376E7C0")]
		public static Task MMKJFOOHLJG(bool KHOMHGNHAAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x376E440", Offset = "0x376D840", VA = "0x18376E440")]
		private static GHOBGEJJNGE KMKBCGDNKGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x376D9C0", Offset = "0x376CDC0", VA = "0x18376D9C0")]
		private static bool EKKKLHEPGIP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x37735B0", Offset = "0x37729B0", VA = "0x1837735B0")]
		public static bool BHJCBIJJGNH(IHNOMGAGHCN OMNGOHLPBHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3773950", Offset = "0x3772D50", VA = "0x183773950")]
		public static IHNOMGAGHCN MHBAMOAJPNP(GameObject CEPEJEHMODM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3773B80", Offset = "0x3772F80", VA = "0x183773B80")]
		public static IHNOMGAGHCN MHBAMOAJPNP(GameObject CEPEJEHMODM, EHNBIOJHEAD DGDIPHPMEJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3773D80", Offset = "0x3773180", VA = "0x183773D80")]
		public static bool PCABENGBNAI(GameObject EBOMDGJFPAB, string OPGDEOIEKEH, bool MIGMPDKECDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3773750", Offset = "0x3772B50", VA = "0x183773750")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void KMPODENAHJH(GameObject EBOMDGJFPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3773660", Offset = "0x3772A60", VA = "0x183773660")]
		[CompilerGenerated]
		internal static string HEEIOGFIPHF((GameObject go, string prefabName) DMNIOKOCJFF)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, GEJNNELHDFI
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool BFCALEBFFJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public KJNCFICFIIE CIMKHMBODDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8291E0", Offset = "0x8285E0", VA = "0x1808291E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(KJNCFICFIIE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x328AC10", Offset = "0x328A010", VA = "0x18328AC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[NAPHGBOEKGO(GPIMBHHJLKL.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, IHNOMGAGHCN, GEJNNELHDFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string CJCIBLEPAGF = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private GPNCDPPBBEI LGKAKPIGKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KJNCFICFIIE LJGIOCJLACK;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public KJNCFICFIIE CIMKHMBODDK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3A5A940", Offset = "0x3A59D40", VA = "0x183A5A940", Slot = "15")]
			get
			{
				return default(KJNCFICFIIE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public NPBAKKOKIOD IKDMAGMHCBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3A5A9F0", Offset = "0x3A59DF0", VA = "0x183A5A9F0", Slot = "6")]
			get
			{
				return default(NPBAKKOKIOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool BFCALEBFFJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3A5A930", Offset = "0x3A59D30", VA = "0x183A5A930", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public GPNCDPPBBEI JMMCFBDLGPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x817800", Offset = "0x816C00", VA = "0x180817800", Slot = "7")]
			get
			{
				return default(GPNCDPPBBEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private FJFNAPPGKJO KLKODJCENGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x3A59FE0", Offset = "0x3A593E0", VA = "0x183A59FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private AOJCNPMLIMB HMGHMDNHOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3A59F80", Offset = "0x3A59380", VA = "0x183A59F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool LFGNKCLIJMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8A81C0", Offset = "0x8A75C0", VA = "0x1808A81C0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8A8250", Offset = "0x8A7650", VA = "0x1808A8250", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> OENIEJELKBO
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3A5A7F0", Offset = "0x3A59BF0", VA = "0x183A5A7F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3A5AA20", Offset = "0x3A59E20", VA = "0x183A5AA20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<IHNOMGAGHCN> MNIFJDJLGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3A5A890", Offset = "0x3A59C90", VA = "0x183A5A890", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3A5AAC0", Offset = "0x3A59EC0", VA = "0x183A5AAC0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3A59CA0", Offset = "0x3A590A0", VA = "0x183A59CA0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A650", Offset = "0x3A59A50", VA = "0x183A5A650", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A300", Offset = "0x3A59700", VA = "0x183A5A300", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A5C0", Offset = "0x3A599C0", VA = "0x183A5A5C0", Slot = "10")]
		public void OnEmbody(CBGJJCKMFCA LIPGMHFIHCI, KJNCFICFIIE LJGIOCJLACK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A640", Offset = "0x3A59A40", VA = "0x183A5A640", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A3B0", Offset = "0x3A597B0", VA = "0x183A5A3B0", Slot = "12")]
		public void OnDisembody(bool FFMELHEDKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3A59E80", Offset = "0x3A59280", VA = "0x183A59E80")]
		private void BJPKDLMEBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3A59C10", Offset = "0x3A59010", VA = "0x183A59C10")]
		private void ACMAGMKBNJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A0C0", Offset = "0x3A594C0", VA = "0x183A5A0C0")]
		private void KBOFFIPEFLE(bool MAJOKBDIHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A2A0", Offset = "0x3A596A0", VA = "0x183A5A2A0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x133C640", Offset = "0x133BA40", VA = "0x18133C640", Slot = "9")]
		private GameObject DKFPEJCJIAM()
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
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[NAPHGBOEKGO(GPIMBHHJLKL.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override AGNBDHNLGKL FFCGEPMMHBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x38AEB30", Offset = "0x38ADF30", VA = "0x1838AEB30", Slot = "6")]
			get
			{
				return default(AGNBDHNLGKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x38AEAD0", Offset = "0x38ADED0", VA = "0x1838AEAD0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[NAPHGBOEKGO(GPIMBHHJLKL.Registration)]
	public class TransformEntity : MonoBehaviour, GEJNNELHDFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private AGNBDHNLGKL prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private KJNCFICFIIE GNKPFNIMJND;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual AGNBDHNLGKL FFCGEPMMHBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0", Slot = "6")]
			get
			{
				return default(AGNBDHNLGKL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x705BB0", Offset = "0x704FB0", VA = "0x180705BB0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public KJNCFICFIIE CIMKHMBODDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x81B480", Offset = "0x81A880", VA = "0x18081B480", Slot = "5")]
			get
			{
				return default(KJNCFICFIIE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BFCALEBFFJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x76D160", Offset = "0x76C560", VA = "0x18076D160", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x76D180", Offset = "0x76C580", VA = "0x18076D180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity KFOGOEMFEMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal LBIICBANFEM PFPFEJCGPDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal AOJCNPMLIMB DHLDNNJJLHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x38BD070", Offset = "0x38BC470", VA = "0x1838BD070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x38BCF70", Offset = "0x38BC370", VA = "0x1838BCF70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x38BCF80", Offset = "0x38BC380", VA = "0x1838BCF80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x38BD0E0", Offset = "0x38BC4E0", VA = "0x1838BD0E0")]
		internal void NPFGFFCDMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x38BD4B0", Offset = "0x38BC8B0", VA = "0x1838BD4B0")]
		private bool PNCDFGBJMOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x38BD3F0", Offset = "0x38BC7F0", VA = "0x1838BD3F0")]
		private void OKPCFIEMNNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x38BCF80", Offset = "0x38BC380", VA = "0x1838BCF80")]
		internal void HDEHBJFBHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x38BD420", Offset = "0x38BC820", VA = "0x1838BD420")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x38BD5A0", Offset = "0x38BC9A0", VA = "0x1838BD5A0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[AOJPGBJKDNL(typeof(GHOBGEJJNGE), new string[] { })]
[APCINEIKDDA(typeof(APLFFAOJOGK))]
public class GDJBKNLFFHN : GHOBGEJJNGE, DIACEKEHMCI, APLFFAOJOGK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NOEEIPFGABG KPGPMPPLGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private FJFNAPPGKJO EIINEJPEGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private PFHNJBGFDIA CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GFLCOPIDGGN NPEAINDGKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private EICPHFONCNF NOGKNHKHMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KOACKKPPGEK NGMBCLGJPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NOEEIPFGABG ECODFCBICCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public PFHNJBGFDIA PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public FJFNAPPGKJO KLKODJCENGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public EICPHFONCNF CDCFEHMDHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KOACKKPPGEK POPLJANONMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PGGMGHNLHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x77DEC0", Offset = "0x77D2C0", VA = "0x18077DEC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool LAFJIBMJEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3A62FF0", Offset = "0x3A623F0", VA = "0x183A62FF0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KGKNKCKDPOC OENHCKDAAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA00970", Offset = "0x9FFD70", VA = "0x180A00970", Slot = "10")]
		get
		{
			return default(KGKNKCKDPOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A62F00", Offset = "0x3A62300", VA = "0x183A62F00")]
	public static GDJBKNLFFHN PELCFOCODBC(NOEEIPFGABG KPGPMPPLGCI, GEDGEKALBHM FAPLMCMDPDI = GEDGEKALBHM.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private static void HJMFJCIJELM(NOEEIPFGABG KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private static void FLHGHLMBKGB(NOEEIPFGABG KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3A62CC0", Offset = "0x3A620C0", VA = "0x183A62CC0", Slot = "11")]
	public void FGMBIJAJIBC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x280A380", Offset = "0x2809780", VA = "0x18280A380")]
	private void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A62E10", Offset = "0x3A62210", VA = "0x183A62E10")]
	private void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3A62C60", Offset = "0x3A62060", VA = "0x183A62C60", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GDJBKNLFFHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JPLOPAMFGLF
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A717C0", Offset = "0x3A70BC0", VA = "0x183A717C0")]
	public static NPBAKKOKIOD AECJHCGBPOI(this GHOBGEJJNGE CBHBKOJKJOB, EHNBIOJHEAD DGDIPHPMEJP, AGNBDHNLGKL LDKBJDPJMKG)
	{
		return default(NPBAKKOKIOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A71900", Offset = "0x3A70D00", VA = "0x183A71900")]
	public static GFKEAGIAJHL BNHDELMCAAP(this GHOBGEJJNGE CBHBKOJKJOB)
	{
		return default(GFKEAGIAJHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3A71A20", Offset = "0x3A70E20", VA = "0x183A71A20")]
	public static KJNCFICFIIE EHPBFPGFMPJ(this GHOBGEJJNGE CBHBKOJKJOB, Entity OOEHGINMJGM)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A71AD0", Offset = "0x3A70ED0", VA = "0x183A71AD0")]
	public static KJNCFICFIIE EHPBFPGFMPJ(this GHOBGEJJNGE CBHBKOJKJOB, EHNBIOJHEAD DGDIPHPMEJP)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A71C00", Offset = "0x3A71000", VA = "0x183A71C00")]
	public static EHNBIOJHEAD IGIFPGJEPFO(this GHOBGEJJNGE CBHBKOJKJOB, KJNCFICFIIE GNKPFNIMJND)
	{
		return default(EHNBIOJHEAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum GEDGEKALBHM
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
[AOJPGBJKDNL(typeof(KOACKKPPGEK), new string[] { })]
public class OFHOIAADOGD : KOACKKPPGEK, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[CPICBLLAMOM]
	private APLFFAOJOGK CGENOKFJBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NOEEIPFGABG KPGPMPPLGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HMKLFLHGJEI NOGKNHKHMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private GFLCOPIDGGN NPEAINDGKBD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OPHBHOBNADA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3765C00", Offset = "0x3765000", VA = "0x183765C00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3765B60", Offset = "0x3764F60", VA = "0x183765B60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3765CE0", Offset = "0x37650E0", VA = "0x183765CE0", Slot = "16")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3765CA0", Offset = "0x37650A0", VA = "0x183765CA0", Slot = "13")]
	public void NKHJFKHALFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "6")]
	public void EKHKEMKCLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3765930", Offset = "0x3764D30", VA = "0x183765930", Slot = "7")]
	public void BDPCGIKOKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3765A80", Offset = "0x3764E80", VA = "0x183765A80", Slot = "8")]
	public void GACCBJIJJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x162BBD0", Offset = "0x162AFD0", VA = "0x18162BBD0", Slot = "9")]
	public void GPACNLPHIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3765A30", Offset = "0x3764E30", VA = "0x183765A30", Slot = "10")]
	public void EMFOMMHHHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3765B00", Offset = "0x3764F00", VA = "0x183765B00", Slot = "11")]
	public bool HNGAOOBPOLC(IEnumerable<CLDNBOMABLC> FMEMBKBFPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3765D90", Offset = "0x3765190", VA = "0x183765D90", Slot = "12")]
	public void PCOJJPFBNDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3765980", Offset = "0x3764D80", VA = "0x183765980", Slot = "14")]
	public void BMAPJCCDEBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x37659D0", Offset = "0x3764DD0", VA = "0x1837659D0", Slot = "15")]
	public void ECBMBGMBEEE(bool NDEMLMNOHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3765900", Offset = "0x3764D00", VA = "0x183765900")]
	private void AGEOGKBIHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public OFHOIAADOGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[AOJPGBJKDNL(typeof(EICPHFONCNF), new string[] { })]
public class LBPEMHHAJMN : EICPHFONCNF, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CPICBLLAMOM]
	private APLFFAOJOGK CGENOKFJBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NOEEIPFGABG KPGPMPPLGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private HMKLFLHGJEI NOGKNHKHMAK;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x375F9B0", Offset = "0x375EDB0", VA = "0x18375F9B0", Slot = "6")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x375F950", Offset = "0x375ED50", VA = "0x18375F950", Slot = "4")]
	public ByteString DGECGJPLFOM(out IDisposable OJOAGJHJNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x375F830", Offset = "0x375EC30", VA = "0x18375F830", Slot = "5")]
	public void AHLFMBEKFNG(ByteString MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public LBPEMHHAJMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class IDCGCHBMIII<T> : global::FJOKIPAAOHE<T>, global::GBIJOAKACLC<EHNBIOJHEAD, T>, global::PDGEDEOMLLK<EHNBIOJHEAD>, BKHPPMHLABI, IDisposable, OFMJLJJKKJK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly global::PDGEDEOMLLK<Entity> JGMFKPLFFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Delegate HPDAHLEBBOO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string LJDFOHKOPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4E30", Offset = "0x3FD4230", VA = "0x183FD4E30", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type NKDMIECPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8C90", Offset = "0x3FC8090", VA = "0x183FC8C90", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public JGGHPLEENKB IFIHLEAFHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0B60", Offset = "0x3FBFF60", VA = "0x183FC0B60", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int NNAMNHAMAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3FC3410", Offset = "0x3FC2810", VA = "0x183FC3410", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public AHHPIJMHCEK NAFADOFDFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4C50", Offset = "0x3FD4050", VA = "0x183FD4C50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x318F410", Offset = "0x318E810", VA = "0x18318F410", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3FD5330", Offset = "0x3FD4730", VA = "0x183FD5330", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::KHLOKGIGPEI<EHNBIOJHEAD> JFCBDEPNNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3FC9920", Offset = "0x3FC8D20", VA = "0x183FC9920", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3FD5AD0", Offset = "0x3FD4ED0", VA = "0x183FD5AD0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3FD9C40", Offset = "0x3FD9040", VA = "0x183FD9C40")]
	public IDCGCHBMIII(global::PDGEDEOMLLK<Entity> JGMFKPLFFDI, LBIICBANFEM PANNLLNEPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3FC7A10", Offset = "0x3FC6E10", VA = "0x183FC7A10")]
	private Entity JNKDJNOGMIC(EHNBIOJHEAD DGDIPHPMEJP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3FC71E0", Offset = "0x3FC65E0", VA = "0x183FC71E0")]
	private EHNBIOJHEAD JNKDJNOGMIC(Entity OOEHGINMJGM)
	{
		return default(EHNBIOJHEAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8270", Offset = "0x3FD7670", VA = "0x183FD8270", Slot = "4")]
	public T PEBNPJONHNJ(EHNBIOJHEAD DGDIPHPMEJP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3FBED90", Offset = "0x3FBE190", VA = "0x183FBED90")]
	public bool CODPHMBGNGD(EHNBIOJHEAD DGDIPHPMEJP, in T OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB310", Offset = "0x3FCA710", VA = "0x183FCB310")]
	public bool MICOEMIFEMG(EHNBIOJHEAD DGDIPHPMEJP, in T OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3FD4270", Offset = "0x3FD3670", VA = "0x183FD4270", Slot = "9")]
	public bool NDBOIIODAJJ(EHNBIOJHEAD DGDIPHPMEJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1170", Offset = "0x3FC0570", VA = "0x183FC1170", Slot = "26")]
	public object FGAFCOJJJBJ(EHNBIOJHEAD DGDIPHPMEJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3170", Offset = "0x3FC2570", VA = "0x183FC3170")]
	public bool ICKDFBPIFDF(EHNBIOJHEAD DGDIPHPMEJP, in object OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3FD7230", Offset = "0x3FD6630", VA = "0x183FD7230")]
	public void PEBNPJONHNJ(EHNBIOJHEAD DGDIPHPMEJP, in IPEAPPMEIFD FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3FBFA50", Offset = "0x3FBEE50", VA = "0x183FBFA50")]
	public bool CODPHMBGNGD(EHNBIOJHEAD DGDIPHPMEJP, in NICFNFKBPKA OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB290", Offset = "0x3FCA690", VA = "0x183FCB290")]
	public bool MICOEMIFEMG(EHNBIOJHEAD DGDIPHPMEJP, in NICFNFKBPKA OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE500", Offset = "0x3FCD900", VA = "0x183FCE500", Slot = "22")]
	public void MNOJECLHCBE(HOINKPMEBEF DKKFHIFLMPL, [Optional] object OEGBAMNPENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3FCF9A0", Offset = "0x3FCEDA0", VA = "0x183FCF9A0", Slot = "15")]
	public void MNOJECLHCBE(EHNBIOJHEAD NPBDKCONLNC, FCIMDOPELEB DKKFHIFLMPL, object OEGBAMNPENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3FC7D40", Offset = "0x3FC7140", VA = "0x183FC7D40", Slot = "14")]
	public bool JOLBHMNFBGF(EHNBIOJHEAD MOGKIAPIIGE, EHNBIOJHEAD KEPPKNDIOGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x32C4300", Offset = "0x32C3700", VA = "0x1832C4300", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3FD9880", Offset = "0x3FD8C80", VA = "0x183FD9880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3FC82B0", Offset = "0x3FC76B0", VA = "0x183FC82B0")]
	public string KGKEEKHPEAN(in NICFNFKBPKA MGOACGLLJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3FBD610", Offset = "0x3FBCA10", VA = "0x183FBD610")]
	private void BMPKFIOANEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD400", Offset = "0x3FCC800", VA = "0x183FCD400")]
	private void MLEHEPFKKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3FD2B40", Offset = "0x3FD1F40", VA = "0x183FD2B40")]
	private void NAMONHHFHNA(Entity OOEHGINMJGM, in NICFNFKBPKA GGPFLMFJFKO, in NICFNFKBPKA OIOCGOCBAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3FCA150", Offset = "0x3FC9550", VA = "0x183FCA150")]
	private void MAHNFHHMIMH(Entity OOEHGINMJGM, in NICFNFKBPKA GGPFLMFJFKO, in NICFNFKBPKA OIOCGOCBAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3FC5760", Offset = "0x3FC4B60", VA = "0x183FC5760")]
	[Conditional("DEBUG_BUILD")]
	private static void JLMGNDOOMOA(Entity OOEHGINMJGM, EHNBIOJHEAD DGDIPHPMEJP, string MLBMAJEOEBG, string APDMEIEJAPF, [CallerMemberName] string FNONJLMLJIE = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x371CF00", Offset = "0x371C300", VA = "0x18371CF00", Slot = "5")]
	private bool HIIMGDIEBGL(EHNBIOJHEAD NPBDKCONLNC, in T OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3971280", Offset = "0x3970680", VA = "0x183971280", Slot = "6")]
	private bool NPPGMJOJJHG(EHNBIOJHEAD NPBDKCONLNC, in T OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x33465F0", Offset = "0x33459F0", VA = "0x1833465F0", Slot = "10")]
	private bool JGICDMKIAEJ(EHNBIOJHEAD NPBDKCONLNC, in object OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3FBC8C0", Offset = "0x3FBBCC0", VA = "0x183FBC8C0", Slot = "11")]
	private void BKACFCFGPFB(EHNBIOJHEAD NPBDKCONLNC, in IPEAPPMEIFD FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3FBC7E0", Offset = "0x3FBBBE0", VA = "0x183FBC7E0", Slot = "12")]
	private bool AAPIBIKADMM(EHNBIOJHEAD NPBDKCONLNC, in NICFNFKBPKA OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1010", Offset = "0x3FC0410", VA = "0x183FC1010", Slot = "13")]
	private bool FAOPOKHDPCI(EHNBIOJHEAD NPBDKCONLNC, in NICFNFKBPKA OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x32203B0", Offset = "0x321F7B0", VA = "0x1832203B0", Slot = "16")]
	private string NHMOBIMALPB(in NICFNFKBPKA FPLJCBGEJAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class KLDCIKDDCHO<T> : global::DDJMMFCDPON<T>, global::GBIJOAKACLC<KJNCFICFIIE, T>, global::PDGEDEOMLLK<KJNCFICFIIE>, BKHPPMHLABI, IDisposable, AEOCECNOIKA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly global::PDGEDEOMLLK<Entity> JGMFKPLFFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Delegate HPDAHLEBBOO;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string LJDFOHKOPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x48A8310", Offset = "0x48A7710", VA = "0x1848A8310", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type NKDMIECPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x489E660", Offset = "0x489DA60", VA = "0x18489E660", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public JGGHPLEENKB IFIHLEAFHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x489BA60", Offset = "0x489AE60", VA = "0x18489BA60", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int NNAMNHAMAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x489DDC0", Offset = "0x489D1C0", VA = "0x18489DDC0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public AHHPIJMHCEK NAFADOFDFFM
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x48A7BE0", Offset = "0x48A6FE0", VA = "0x1848A7BE0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x48984A0", Offset = "0x48978A0", VA = "0x1848984A0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x48A8360", Offset = "0x48A7760", VA = "0x1848A8360", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::KHLOKGIGPEI<KJNCFICFIIE> JFCBDEPNNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x489EA80", Offset = "0x489DE80", VA = "0x18489EA80", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x48A8760", Offset = "0x48A7B60", VA = "0x1848A8760", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3FD9C40", Offset = "0x3FD9040", VA = "0x183FD9C40")]
	public KLDCIKDDCHO(global::PDGEDEOMLLK<Entity> JGMFKPLFFDI, LBIICBANFEM PANNLLNEPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2A41E00", Offset = "0x2A41200", VA = "0x182A41E00")]
	private Entity JNKDJNOGMIC(KJNCFICFIIE GNKPFNIMJND)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x489DEF0", Offset = "0x489D2F0", VA = "0x18489DEF0")]
	private KJNCFICFIIE JNKDJNOGMIC(Entity OOEHGINMJGM)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x48A9E00", Offset = "0x48A9200", VA = "0x1848A9E00", Slot = "4")]
	public T PEBNPJONHNJ(KJNCFICFIIE GNKPFNIMJND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x489B130", Offset = "0x489A530", VA = "0x18489B130")]
	public bool CODPHMBGNGD(KJNCFICFIIE GNKPFNIMJND, in T OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x48A0140", Offset = "0x489F540", VA = "0x1848A0140")]
	public bool MICOEMIFEMG(KJNCFICFIIE GNKPFNIMJND, in T OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x48A7820", Offset = "0x48A6C20", VA = "0x1848A7820", Slot = "9")]
	public bool NDBOIIODAJJ(KJNCFICFIIE GNKPFNIMJND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x489BF90", Offset = "0x489B390", VA = "0x18489BF90", Slot = "26")]
	public object FGAFCOJJJBJ(KJNCFICFIIE GNKPFNIMJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x489C200", Offset = "0x489B600", VA = "0x18489C200")]
	public bool ICKDFBPIFDF(KJNCFICFIIE GNKPFNIMJND, in object OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x48A9060", Offset = "0x48A8460", VA = "0x1848A9060")]
	public void PEBNPJONHNJ(KJNCFICFIIE GNKPFNIMJND, in IPEAPPMEIFD FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x489A870", Offset = "0x4899C70", VA = "0x18489A870")]
	public bool CODPHMBGNGD(KJNCFICFIIE GNKPFNIMJND, in NICFNFKBPKA OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x489FCC0", Offset = "0x489F0C0", VA = "0x18489FCC0")]
	public bool MICOEMIFEMG(KJNCFICFIIE GNKPFNIMJND, in NICFNFKBPKA OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE500", Offset = "0x3FCD900", VA = "0x183FCE500", Slot = "22")]
	public void MNOJECLHCBE(HOINKPMEBEF DKKFHIFLMPL, [Optional] object OEGBAMNPENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x48A3300", Offset = "0x48A2700", VA = "0x1848A3300", Slot = "15")]
	public void MNOJECLHCBE(KJNCFICFIIE NPBDKCONLNC, FCIMDOPELEB DKKFHIFLMPL, object OEGBAMNPENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x489DF20", Offset = "0x489D320", VA = "0x18489DF20", Slot = "14")]
	public bool JOLBHMNFBGF(KJNCFICFIIE MOGKIAPIIGE, KJNCFICFIIE KEPPKNDIOGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4899960", Offset = "0x4898D60", VA = "0x184899960")]
	private void BMPKFIOANEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x48A16E0", Offset = "0x48A0AE0", VA = "0x1848A16E0")]
	private void MLEHEPFKKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x48A7020", Offset = "0x48A6420", VA = "0x1848A7020")]
	private void NAMONHHFHNA(Entity OOEHGINMJGM, in NICFNFKBPKA GGPFLMFJFKO, in NICFNFKBPKA OIOCGOCBAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x489FA50", Offset = "0x489EE50", VA = "0x18489FA50")]
	private void MAHNFHHMIMH(Entity OOEHGINMJGM, in NICFNFKBPKA GGPFLMFJFKO, in NICFNFKBPKA OIOCGOCBAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x489BA30", Offset = "0x489AE30", VA = "0x18489BA30", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x48AB910", Offset = "0x48AAD10", VA = "0x1848AB910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3FC82B0", Offset = "0x3FC76B0", VA = "0x183FC82B0")]
	public string KGKEEKHPEAN(in NICFNFKBPKA MGOACGLLJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x489C180", Offset = "0x489B580", VA = "0x18489C180", Slot = "5")]
	private bool GFIHKEHBLEG(KJNCFICFIIE NPBDKCONLNC, in T OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x489A030", Offset = "0x4899430", VA = "0x18489A030", Slot = "6")]
	private bool CFHPKKHGBMC(KJNCFICFIIE NPBDKCONLNC, in T OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FF50", Offset = "0x3F9F350", VA = "0x183F9FF50", Slot = "10")]
	private bool DFJNEMNDCJO(KJNCFICFIIE NPBDKCONLNC, in object OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4899FF0", Offset = "0x48993F0", VA = "0x184899FF0", Slot = "11")]
	private void CBLOMPFAOAE(KJNCFICFIIE NPBDKCONLNC, in IPEAPPMEIFD FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x489C1C0", Offset = "0x489B5C0", VA = "0x18489C1C0", Slot = "12")]
	private bool HLKNJPICJBH(KJNCFICFIIE NPBDKCONLNC, in NICFNFKBPKA OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x489DEB0", Offset = "0x489D2B0", VA = "0x18489DEB0", Slot = "13")]
	private bool JINFEAOHPDE(KJNCFICFIIE NPBDKCONLNC, in NICFNFKBPKA OIOCGOCBAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x32203B0", Offset = "0x321F7B0", VA = "0x1832203B0", Slot = "16")]
	private string LNKFHFELCAG(in NICFNFKBPKA FPLJCBGEJAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class COPAMGOGEDJ : IDisposable, JAMJFJKLJBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HCJKODLJNNK;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> AGBCAFPCNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2A0", Offset = "0x7ED6A0", VA = "0x1807EE2A0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1698630", Offset = "0x1697A30", VA = "0x181698630")]
	public COPAMGOGEDJ(NativeArray<EntityRemapUtility.EntityRemapInfo> HCJKODLJNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x37DE460", Offset = "0x37DD860", VA = "0x1837DE460", Slot = "6")]
	public KJNCFICFIIE OHAAIJEFIOO(KJNCFICFIIE GNKPFNIMJND)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x37DE4B0", Offset = "0x37DD8B0", VA = "0x1837DE4B0", Slot = "7")]
	public Entity OHAAIJEFIOO(Entity OOEHGINMJGM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x37DE4C0", Offset = "0x37DD8C0", VA = "0x1837DE4C0", Slot = "8")]
	public IEnumerable<KJNCFICFIIE> OHAAIJEFIOO(IEnumerable<KJNCFICFIIE> PKIIINIFBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x37DE400", Offset = "0x37DD800", VA = "0x1837DE400", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly BBHAOFNBCPD BPOEIMLBDKL;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static int OHHIDKNMDII;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static JAMJFJKLJBG DDBBIDIICCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool OMGNHBCCBIN;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> AGBCAFPCNBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x38B55D0", Offset = "0x38B49D0", VA = "0x1838B55D0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool FDLECAKAGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x38B5850", Offset = "0x38B4C50", VA = "0x1838B5850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x38B57F0", Offset = "0x38B4BF0", VA = "0x1838B57F0")]
		public static SerializationRemapScope GJPFFEKIIEM()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x38B5C00", Offset = "0x38B5000", VA = "0x1838B5C00")]
		public SerializationRemapScope(JAMJFJKLJBG GFNIPHMEIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x38B56E0", Offset = "0x38B4AE0", VA = "0x1838B56E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x38B5A10", Offset = "0x38B4E10", VA = "0x1838B5A10")]
		public static KJNCFICFIIE OHAAIJEFIOO(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x38B58E0", Offset = "0x38B4CE0", VA = "0x1838B58E0")]
		public static Entity OHAAIJEFIOO(Entity OOEHGINMJGM)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[PHECHDJFGDG(FPOGPJMGMEG.Application)]
[AOJPGBJKDNL(typeof(GPIFECILMED), new string[] { "Editor" })]
public sealed class GPIFECILMED
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void KGBMMJKLBNG(EHNBIOJHEAD MGNKNMKMHMA, PHPODCGBPLJ MPEBBGJJODN, bool NNEHBDPBLFK);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void IKAKGDJHFFH(EHNBIOJHEAD MGNKNMKMHMA, bool NNEHBDPBLFK);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void MDOCBMJNBLH(EHNBIOJHEAD MGNKNMKMHMA, ODHBKAFBAFM JGMFKPLFFDI, in NICFNFKBPKA FPLJCBGEJAP, bool NNEHBDPBLFK);

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event KGBMMJKLBNG AJMJPKEMMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3A65390", Offset = "0x3A64790", VA = "0x183A65390")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3A65430", Offset = "0x3A64830", VA = "0x183A65430")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event IKAKGDJHFFH CCKBHPPJOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3A65630", Offset = "0x3A64A30", VA = "0x183A65630")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3A654F0", Offset = "0x3A648F0", VA = "0x183A654F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event MDOCBMJNBLH PBJIGMEEBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3A652A0", Offset = "0x3A646A0", VA = "0x183A652A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3A65590", Offset = "0x3A64990", VA = "0x183A65590")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3A654D0", Offset = "0x3A648D0", VA = "0x183A654D0")]
	[Conditional("UNITY_EDITOR")]
	public void IEDNOIFGALF(EHNBIOJHEAD MGNKNMKMHMA, in PHPODCGBPLJ MPEBBGJJODN, bool NNEHBDPBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3A65370", Offset = "0x3A64770", VA = "0x183A65370")]
	[Conditional("UNITY_EDITOR")]
	public void CHJEAHMOEFP(EHNBIOJHEAD MGNKNMKMHMA, bool NNEHBDPBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3A65340", Offset = "0x3A64740", VA = "0x183A65340")]
	[Conditional("UNITY_EDITOR")]
	public void BPDCIPCPDHO(EHNBIOJHEAD MGNKNMKMHMA, ODHBKAFBAFM JGMFKPLFFDI, in NICFNFKBPKA FPLJCBGEJAP, bool NNEHBDPBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GPIFECILMED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[AOJPGBJKDNL(typeof(KEICNAJBANN), new string[] { "Editor" })]
[PHECHDJFGDG(FPOGPJMGMEG.Application)]
public sealed class KEICNAJBANN
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void PIDHHACPHFK(EHNBIOJHEAD DGDIPHPMEJP, PHPODCGBPLJ MPEBBGJJODN, bool NNEHBDPBLFK);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void ONLFHJLFAGA(EHNBIOJHEAD DGDIPHPMEJP, bool NNEHBDPBLFK);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void HCODMMGKFNI(EHNBIOJHEAD DGDIPHPMEJP, ODHBKAFBAFM JGMFKPLFFDI, in NICFNFKBPKA FPLJCBGEJAP, bool NNEHBDPBLFK, bool CIEGHIBGFBG);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void ACMENGAAINH(EHNBIOJHEAD DGDIPHPMEJP, ODHBKAFBAFM JGMFKPLFFDI, in NICFNFKBPKA GGPFLMFJFKO, in NICFNFKBPKA OIOCGOCBAJE);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate void EHAOFILLCMN(JFFFCAFDCNL NPBDKCONLNC, ReadOnlyMemory<byte> OCMDFIDHJDH);

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event Action<World> EMJLFPILNIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3A72FA0", Offset = "0x3A723A0", VA = "0x183A72FA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3A72490", Offset = "0x3A71890", VA = "0x183A72490")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> GPDGNOBDCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3A73130", Offset = "0x3A72530", VA = "0x183A73130")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3A72EE0", Offset = "0x3A722E0", VA = "0x183A72EE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event PIDHHACPHFK AJMJPKEMMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3A72810", Offset = "0x3A71C10", VA = "0x183A72810")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3A72B50", Offset = "0x3A71F50", VA = "0x183A72B50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event ONLFHJLFAGA CCKBHPPJOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3A731F0", Offset = "0x3A725F0", VA = "0x183A731F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3A72E40", Offset = "0x3A72240", VA = "0x183A72E40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event PIDHHACPHFK GJGAKELJENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3A72950", Offset = "0x3A71D50", VA = "0x183A72950")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3A72D30", Offset = "0x3A72130", VA = "0x183A72D30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event ONLFHJLFAGA LLALMOIFAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3A72720", Offset = "0x3A71B20", VA = "0x183A72720")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3A728B0", Offset = "0x3A71CB0", VA = "0x183A728B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event HCODMMGKFNI PBJIGMEEBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3A725E0", Offset = "0x3A719E0", VA = "0x183A725E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3A73060", Offset = "0x3A72460", VA = "0x183A73060")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event ACMENGAAINH DECEOLBMIOC
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3A73330", Offset = "0x3A72730", VA = "0x183A73330")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3A72AB0", Offset = "0x3A71EB0", VA = "0x183A72AB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> FMEBBJDOBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3A72C20", Offset = "0x3A72020", VA = "0x183A72C20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3A73290", Offset = "0x3A72690", VA = "0x183A73290")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event EHAOFILLCMN GHFILBJBMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3A72680", Offset = "0x3A71A80", VA = "0x183A72680")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3A72A10", Offset = "0x3A71E10", VA = "0x183A72A10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3A725B0", Offset = "0x3A719B0", VA = "0x183A725B0")]
	[Conditional("UNITY_EDITOR")]
	public void BFDNHFFCHDL(EHNBIOJHEAD DGDIPHPMEJP, in PHPODCGBPLJ MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3A733D0", Offset = "0x3A727D0", VA = "0x183A733D0")]
	[Conditional("UNITY_EDITOR")]
	public void PCLEOLHDPBC(EHNBIOJHEAD DGDIPHPMEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3A72BF0", Offset = "0x3A71FF0", VA = "0x183A72BF0")]
	[Conditional("UNITY_EDITOR")]
	public void IKFNNDJOHJK(EHNBIOJHEAD DGDIPHPMEJP, in PHPODCGBPLJ MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3A729F0", Offset = "0x3A71DF0", VA = "0x183A729F0")]
	[Conditional("UNITY_EDITOR")]
	public void FFLDIFPMMDD(EHNBIOJHEAD DGDIPHPMEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3A73100", Offset = "0x3A72500", VA = "0x183A73100")]
	[Conditional("UNITY_EDITOR")]
	public void MDHHJNMKMMA(EHNBIOJHEAD DGDIPHPMEJP, ODHBKAFBAFM JGMFKPLFFDI, in NICFNFKBPKA FPLJCBGEJAP, bool CIEGHIBGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3A727F0", Offset = "0x3A71BF0", VA = "0x183A727F0")]
	[Conditional("UNITY_EDITOR")]
	public void DMEKPDFGDHF(EHNBIOJHEAD DGDIPHPMEJP, ODHBKAFBAFM JGMFKPLFFDI, in NICFNFKBPKA GGPFLMFJFKO, in NICFNFKBPKA OIOCGOCBAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3A72550", Offset = "0x3A71950", VA = "0x183A72550")]
	[Conditional("UNITY_EDITOR")]
	public void BALFCMAPMEL(string LBEPPIIBMPA, object OCMDFIDHJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3A727C0", Offset = "0x3A71BC0", VA = "0x183A727C0")]
	[Conditional("UNITY_EDITOR")]
	public void DKGELPJMGPH(JFFFCAFDCNL NPBDKCONLNC, ReadOnlyMemory<byte> OCMDFIDHJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3A72DD0", Offset = "0x3A721D0", VA = "0x183A72DD0")]
	[Conditional("UNITY_EDITOR")]
	public void KMEOAKFPOCG(World LIPGMHFIHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3A72CC0", Offset = "0x3A720C0", VA = "0x183A72CC0")]
	[Conditional("UNITY_EDITOR")]
	public void JNGPIMJBCGL(World LIPGMHFIHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public KEICNAJBANN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[AOJPGBJKDNL(typeof(PAHPMLGHMAG), new string[] { })]
public class NCIICHNMEAE : PAHPMLGHMAG
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3764200", Offset = "0x3763600", VA = "0x183764200", Slot = "5")]
	public void PMDDKPPOEDN(object CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3764110", Offset = "0x3763510", VA = "0x183764110", Slot = "6")]
	public void KBJMCIKIFGO(object CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3764020", Offset = "0x3763420", VA = "0x183764020", Slot = "7")]
	public void CIPCHOCCFOO(object CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3763F00", Offset = "0x3763300", VA = "0x183763F00", Slot = "4")]
	public IDisposable BCAEPNHDNCF(object CIBBLLOHCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NCIICHNMEAE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Serialization)]
	[AOJPGBJKDNL(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	internal class BulkInstantiateSceneObjectService : NGENPNOGFON, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string BIPKFOEPDDL = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[CPICBLLAMOM]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA PEPLIFOGJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[CPICBLLAMOM]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[CPICBLLAMOM]
		private AOJCNPMLIMB KBMLCGACCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EntityQuery MPGJLINHFPI;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EntityManager NPBNPNJJNKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x37D89F0", Offset = "0x37D7DF0", VA = "0x1837D89F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x37D9ED0", Offset = "0x37D92D0", VA = "0x1837D9ED0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x37D89E0", Offset = "0x37D7DE0", VA = "0x1837D89E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x37D92E0", Offset = "0x37D86E0", VA = "0x1837D92E0")]
		public bool HNGAOOBPOLC(IEnumerable<CLDNBOMABLC> DGOOCDBDKAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x37D8700", Offset = "0x37D7B00", VA = "0x1837D8700")]
		public static bool CPLNBJCNLPA(CLDNBOMABLC PJJLMKEBMEE, out EHNBIOJHEAD DGDIPHPMEJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x37D96D0", Offset = "0x37D8AD0", VA = "0x1837D96D0")]
		private void KAAPJPIMACM(Dictionary<EHNBIOJHEAD, CLDNBOMABLC> MJKBPIALMBI, IEnumerable<CLDNBOMABLC> DGOOCDBDKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x37DA3B0", Offset = "0x37D97B0", VA = "0x1837DA3B0")]
		private void POEAPNGKPDE(Dictionary<EHNBIOJHEAD, CLDNBOMABLC> MJKBPIALMBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x37D9A50", Offset = "0x37D8E50", VA = "0x1837D9A50")]
		private void NALNOLAJFMO(Dictionary<EHNBIOJHEAD, CLDNBOMABLC> MJKBPIALMBI, EHNBIOJHEAD DGDIPHPMEJP, string LBEPPIIBMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x37DA050", Offset = "0x37D9450", VA = "0x1837DA050")]
		private void PENCLGBNJJM(Dictionary<EHNBIOJHEAD, CLDNBOMABLC> MJKBPIALMBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x37D8A40", Offset = "0x37D7E40", VA = "0x1837D8A40")]
		private void EEGCKKIFOKM(Dictionary<EHNBIOJHEAD, CLDNBOMABLC> MJKBPIALMBI, List<CLDNBOMABLC> NIPJEADHDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x37D9460", Offset = "0x37D8860", VA = "0x1837D9460")]
		private NativeList<EHNBIOJHEAD> IGAIIDBKKMD(Dictionary<EHNBIOJHEAD, CLDNBOMABLC> MJKBPIALMBI)
		{
			return default(NativeList<EHNBIOJHEAD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x37D8810", Offset = "0x37D7C10", VA = "0x1837D8810")]
		private NativeArray<Entity> DJCEKPPENPD(NativeList<EHNBIOJHEAD> KAAFMIBHJIH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x37D9630", Offset = "0x37D8A30", VA = "0x1837D9630")]
		private static void JBLJHPBJGFO(Dictionary<EHNBIOJHEAD, CLDNBOMABLC> MJKBPIALMBI, EHNBIOJHEAD DGDIPHPMEJP, CLDNBOMABLC PJJLMKEBMEE, string LBEPPIIBMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[PHECHDJFGDG(FPOGPJMGMEG.Application)]
	[AOJPGBJKDNL(typeof(DebugWorldsService), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.Serialization)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static bool LAFJIBMJEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x37F03A0", Offset = "0x37EF7A0", VA = "0x1837F03A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x37F0360", Offset = "0x37EF760", VA = "0x1837F0360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool MCHKEFBICGK
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x37F03E0", Offset = "0x37EF7E0", VA = "0x1837F03E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x37F0320", Offset = "0x37EF720", VA = "0x1837F0320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		public void BHIOFCNGNFF(string LBEPPIIBMPA, EntityManager BOGIEIBMFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		public static void BIEFCABEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[AOJPGBJKDNL(typeof(GFLCOPIDGGN), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.Application)]
internal class GFLCOPIDGGN
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool LAFJIBMJEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x826290", Offset = "0x825690", VA = "0x180826290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8262B0", Offset = "0x8256B0", VA = "0x1808262B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool LBGMGCHDNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8262A0", Offset = "0x8256A0", VA = "0x1808262A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8262C0", Offset = "0x8256C0", VA = "0x1808262C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GFLCOPIDGGN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[AOJPGBJKDNL(typeof(HMKLFLHGJEI), new string[] { })]
	[APCINEIKDDA(typeof(SerializationService))]
	[NAPHGBOEKGO(GPIMBHHJLKL.Serialization)]
	internal class SerializationService : HMKLFLHGJEI, IDisposable, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly BBHAOFNBCPD FEEMOGGLIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[CPICBLLAMOM]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[CPICBLLAMOM]
		private ABMPOHBGIDA HIAJLBHGCPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[CPICBLLAMOM]
		private GFLCOPIDGGN NPEAINDGKBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private BEIPBJLNHID LHGJHLCKAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private PKJGEEJNBPC EKMCIGODCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private SerializationRemapScope OJOAGJHJNPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool? LKICFHOBAEL;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool BIJFPKLJKIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x150C560", Offset = "0x150B960", VA = "0x18150C560", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x38B7870", Offset = "0x38B6C70", VA = "0x1838B7870", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool JFMMGKOBIDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xA9E510", Offset = "0xA9D910", VA = "0x180A9E510", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x761570", Offset = "0x760970", VA = "0x180761570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public PKJGEEJNBPC GGLOKAECBFP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x38B7910", Offset = "0x38B6D10", VA = "0x1838B7910", Slot = "16")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x38B6720", Offset = "0x38B5B20", VA = "0x1838B6720", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x38B7740", Offset = "0x38B6B40", VA = "0x1838B7740")]
		public static bool KPHPPPGHLGL(ByteString LFBMPCLHCOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x963B10", Offset = "0x962F10", VA = "0x180963B10")]
		public void AFFOJMBLFLP(BEIPBJLNHID FFOFGJKMODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x38B6D50", Offset = "0x38B6150", VA = "0x1838B6D50", Slot = "5")]
		public void HBEBDBPPNPA(bool KHOMHGNHAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x38B7880", Offset = "0x38B6C80", VA = "0x1838B7880", Slot = "6")]
		public Task OIPKMNLFJPL(bool KHOMHGNHAAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x38B6640", Offset = "0x38B5A40", VA = "0x1838B6640", Slot = "7")]
		public ByteString DGECGJPLFOM(out IDisposable OJOAGJHJNPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x38B6460", Offset = "0x38B5860", VA = "0x1838B6460", Slot = "19")]
		public ByteString DGECGJPLFOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x38B5CC0", Offset = "0x38B50C0", VA = "0x1838B5CC0", Slot = "9")]
		public bool AHLFMBEKFNG(ByteString DBDKPEIPKLJ, MHBMIDLBIPK FAPLMCMDPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x38B7380", Offset = "0x38B6780", VA = "0x1838B7380")]
		private bool ICLDILAMHJI(ByteString DBDKPEIPKLJ, MHBMIDLBIPK FAPLMCMDPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x38B6B80", Offset = "0x38B5F80", VA = "0x1838B6B80", Slot = "8")]
		public void GMFPKNEMKDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x38B68C0", Offset = "0x38B5CC0", VA = "0x1838B68C0", Slot = "10")]
		public bool EMFOMMHHHOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x38B7110", Offset = "0x38B6510", VA = "0x1838B7110", Slot = "11")]
		public bool HNGAOOBPOLC(IEnumerable<CLDNBOMABLC> FMEMBKBFPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x38B67E0", Offset = "0x38B5BE0", VA = "0x1838B67E0")]
		public bool ELLKDCIGDEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x38B79B0", Offset = "0x38B6DB0", VA = "0x1838B79B0", Slot = "12")]
		public bool PCOJJPFBNDE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x38B6E80", Offset = "0x38B6280", VA = "0x1838B6E80")]
		public void HLDHPKALDMD(PKJGEEJNBPC.OLNLPLCLLNP.PHNKKJCMICL IGALNDDKACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x38B5D20", Offset = "0x38B5120", VA = "0x1838B5D20")]
		private bool BHJEDJAAFJH(ByteString DBDKPEIPKLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x38B6B30", Offset = "0x38B5F30", VA = "0x1838B6B30")]
		private void FFBIGECMELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x38B6E20", Offset = "0x38B6220", VA = "0x1838B6E20")]
		private ByteString HHGBACDHNAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x38B6350", Offset = "0x38B5750", VA = "0x1838B6350")]
		private ByteString CGJPGCJFBAM(ByteString LFBMPCLHCOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x38B76A0", Offset = "0x38B6AA0", VA = "0x1838B76A0")]
		private PKJGEEJNBPC.OLNLPLCLLNP.PHNKKJCMICL INLBLMEAKCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x38B5C90", Offset = "0x38B5090", VA = "0x1838B5C90")]
		private void AAPMNJCCPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x38B6180", Offset = "0x38B5580", VA = "0x1838B6180", Slot = "13")]
		public bool BMAPJCCDEBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x38B6730", Offset = "0x38B5B30", VA = "0x1838B6730", Slot = "14")]
		public void ECBMBGMBEEE(bool NDEMLMNOHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x38B5FB0", Offset = "0x38B53B0", VA = "0x1838B5FB0")]
		private void BIEFCABEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[AOJPGBJKDNL(typeof(AIKEDHOJPPH), new string[] { })]
[APCINEIKDDA(typeof(ABMPOHBGIDA))]
internal class ABMPOHBGIDA : AIKEDHOJPPH
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action BDPCGIKOKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x37D3940", Offset = "0x37D2D40", VA = "0x1837D3940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x37D3800", Offset = "0x37D2C00", VA = "0x1837D3800", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<JAMJFJKLJBG> MGFMOHPLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x37D3760", Offset = "0x37D2B60", VA = "0x1837D3760", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x37D3AD0", Offset = "0x37D2ED0", VA = "0x1837D3AD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action OBMFOCMIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x37D3B70", Offset = "0x37D2F70", VA = "0x1837D3B70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x37D3C10", Offset = "0x37D3010", VA = "0x1837D3C10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action KEAGFOCJLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x37D36C0", Offset = "0x37D2AC0", VA = "0x1837D36C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x37D3620", Offset = "0x37D2A20", VA = "0x1837D3620", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<JAMJFJKLJBG> BHGEGDKOCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x37D38A0", Offset = "0x37D2CA0", VA = "0x1837D38A0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x37D39E0", Offset = "0x37D2DE0", VA = "0x1837D39E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x19C6EC0", Offset = "0x19C62C0", VA = "0x1819C6EC0")]
	public void GMFPKNEMKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1D08810", Offset = "0x1D07C10", VA = "0x181D08810")]
	public void IAOACIJPECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x20CAB60", Offset = "0x20C9F60", VA = "0x1820CAB60")]
	public void NEHEKKHFAIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x37D3CB0", Offset = "0x37D30B0", VA = "0x1837D3CB0")]
	public void NBFOLAHNBIH(JAMJFJKLJBG DDBBIDIICCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x37D3A80", Offset = "0x37D2E80", VA = "0x1837D3A80")]
	public void JJHKPLFHCJM(JAMJFJKLJBG DDBBIDIICCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABMPOHBGIDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[AOJPGBJKDNL(typeof(OBNLPCJMAPP), new string[] { })]
public class KPJFBCDLIBM : OBNLPCJMAPP, HPLECDDPLCA, HIJIFLANIAO, NGENPNOGFON, CJFEEGPLPHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityHierarchyParents ELOPNHNIFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private FEDDPHNAKAK BBLGAIECEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ObjectEmbodimentService KGKPNOEKJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public global::DDJMMFCDPON<KJNCFICFIIE> DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D2590", Offset = "0x6D1990", VA = "0x1806D2590", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x782E50", Offset = "0x782250", VA = "0x180782E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager NPBNPNJJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A75A70", Offset = "0x3A74E70", VA = "0x183A75A70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1E05980", Offset = "0x1E04D80", VA = "0x181E05980", Slot = "14")]
	public void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3A76B70", Offset = "0x3A75F70", VA = "0x183A76B70", Slot = "15")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A75EA0", Offset = "0x3A752A0", VA = "0x183A75EA0", Slot = "16")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1E058B0", Offset = "0x1E04CB0", VA = "0x181E058B0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x37688B0", Offset = "0x3767CB0", VA = "0x1837688B0")]
	private KJNCFICFIIE HONPCNPPAIH(Entity OOEHGINMJGM)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A75840", Offset = "0x3A74C40", VA = "0x183A75840", Slot = "4")]
	public KJNCFICFIIE CFGEIGEDAJC(KJNCFICFIIE GNKPFNIMJND)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3A76430", Offset = "0x3A75830", VA = "0x183A76430", Slot = "19")]
	public void MKFDOPFNJOJ(ref List<KJNCFICFIIE> GMPFLANMHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3A76230", Offset = "0x3A75630", VA = "0x183A76230", Slot = "20")]
	public IEnumerable<KJNCFICFIIE> MICCIAHJHAI(KJNCFICFIIE GNKPFNIMJND, bool CNIDJIFJCJI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A75CD0", Offset = "0x3A750D0", VA = "0x183A75CD0", Slot = "21")]
	public KJNCFICFIIE HBBCLKEHJJL(KJNCFICFIIE GNKPFNIMJND, int GABJOMFFJAI)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A75680", Offset = "0x3A74A80", VA = "0x183A75680", Slot = "22")]
	public int BCPKEGFPJLA(KJNCFICFIIE GNKPFNIMJND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3A76660", Offset = "0x3A75A60", VA = "0x183A76660", Slot = "8")]
	public int MOGIMNPNCEG(KJNCFICFIIE GNKPFNIMJND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3A76800", Offset = "0x3A75C00", VA = "0x183A76800", Slot = "9")]
	public HKMFMMPGOLI NCLMADDLDNK(KJNCFICFIIE GNKPFNIMJND)
	{
		return default(HKMFMMPGOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A769A0", Offset = "0x3A75DA0", VA = "0x183A769A0", Slot = "23")]
	public bool OHDFLJHKCIF(KJNCFICFIIE GNKPFNIMJND, out HKMFMMPGOLI MANJNLBGMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A759A0", Offset = "0x3A74DA0", VA = "0x183A759A0", Slot = "24")]
	public IEnumerable<KJNCFICFIIE> DJKJJBBCCIG(KJNCFICFIIE GNKPFNIMJND, bool CNIDJIFJCJI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3A75C00", Offset = "0x3A75000", VA = "0x183A75C00", Slot = "12")]
	public KJNCFICFIIE FCBFBEJGDDD(KJNCFICFIIE KIKPCHNHCOF, KJNCFICFIIE ACEOMEGCOKM)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A76160", Offset = "0x3A75560", VA = "0x183A76160", Slot = "13")]
	public bool MAHIHPJAEKH(KJNCFICFIIE KIKPCHNHCOF, KJNCFICFIIE ACEOMEGCOKM, out KJNCFICFIIE ACLPGKKPMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A757A0", Offset = "0x3A74BA0", VA = "0x183A757A0", Slot = "5")]
	public KJNCFICFIIE CCHAPKECBLI(KJNCFICFIIE GNKPFNIMJND)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A75F90", Offset = "0x3A75390", VA = "0x183A75F90", Slot = "11")]
	public bool IIGANFODEDB(KJNCFICFIIE GNKPFNIMJND, KJNCFICFIIE OPNIEJJIALI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A75AC0", Offset = "0x3A74EC0", VA = "0x183A75AC0", Slot = "25")]
	public bool ENDIFHCCJBL(KJNCFICFIIE GNKPFNIMJND, KJNCFICFIIE NEICBHGNPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A76050", Offset = "0x3A75450", VA = "0x183A76050", Slot = "10")]
	public bool JJDKPLMOHNG(KJNCFICFIIE GNKPFNIMJND, KJNCFICFIIE KIKPCHNHCOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A768F0", Offset = "0x3A75CF0", VA = "0x183A768F0", Slot = "6")]
	public bool NPKNFKDMNIH(KJNCFICFIIE GNKPFNIMJND, KJNCFICFIIE CNDFBGEJOLI, bool ODKCBCPMGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A75930", Offset = "0x3A74D30", VA = "0x183A75930", Slot = "7")]
	public bool DGGDKMPIBME(KJNCFICFIIE GNKPFNIMJND, KJNCFICFIIE CNDFBGEJOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public KPJFBCDLIBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
[AOJPGBJKDNL(typeof(IGNFHNIPNCL), new string[] { })]
internal class IGNFHNIPNCL : NGENPNOGFON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[CPICBLLAMOM]
	private AECLLFLJBLC FIJECBKDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<int, CGJMICMININ> FGJGJGGFAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D2A0", Offset = "0x3A6C6A0", VA = "0x183A6D2A0", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CDF0", Offset = "0x3A6C1F0", VA = "0x183A6CDF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CF40", Offset = "0x3A6C340", VA = "0x183A6CF40")]
	public CGJMICMININ LPLEKBJNOJC(BFOMGEBLKLE MLBMAJEOEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D150", Offset = "0x3A6C550", VA = "0x183A6D150")]
	public CGJMICMININ LPLEKBJNOJC(ODHBKAFBAFM IIMBCOAEFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CCD0", Offset = "0x3A6C0D0", VA = "0x183A6CCD0")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D2F0", Offset = "0x3A6C6F0", VA = "0x183A6D2F0")]
	public IGNFHNIPNCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class CGJMICMININ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<APKHBOJFNAD> OLNPMIAJFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<IJDNGJCBHJA> JJHFHEKJIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<DJDEPENAIGM> GADNDHBADLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<IJDNGJCBHJA> MJEMEEEACKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<APKHBOJFNAD> MHOPCDOAMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2A0", Offset = "0x7ED6A0", VA = "0x1807EE2A0")]
		get
		{
			return default(NativeList<APKHBOJFNAD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<IJDNGJCBHJA> BKOGLPEBJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x81B480", Offset = "0x81A880", VA = "0x18081B480")]
		get
		{
			return default(NativeList<IJDNGJCBHJA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<DJDEPENAIGM> MPNPMOFHPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x847B30", Offset = "0x846F30", VA = "0x180847B30")]
		get
		{
			return default(NativeList<DJDEPENAIGM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<IJDNGJCBHJA> MJCNCMBPNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1021570", Offset = "0x1020970", VA = "0x181021570")]
		get
		{
			return default(NativeList<IJDNGJCBHJA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle JBJAKIEIHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x81B350", Offset = "0x81A750", VA = "0x18081B350")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB680", Offset = "0x1AAAA80", VA = "0x181AAB680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool PGGMGHNLHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xAD41A0", Offset = "0xAD35A0", VA = "0x180AD41A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool PJJPNMNAOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x37DD340", Offset = "0x37DC740", VA = "0x1837DD340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x37DD3F0", Offset = "0x37DC7F0", VA = "0x1837DD3F0")]
	public CGJMICMININ(Allocator NDJJBKEIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x37DCE60", Offset = "0x37DC260", VA = "0x1837DCE60")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x37DD210", Offset = "0x37DC610", VA = "0x1837DD210")]
	public void IDPLHJEPBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x37DCEF0", Offset = "0x37DC2F0", VA = "0x1837DCEF0")]
	public void BKCAAEBNAMB(Entity OOEHGINMJGM, Entity AABDLCHECIH, Entity HKBAAFCKIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[AOJPGBJKDNL(typeof(HEGMGIIKCAP), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
public class HEGMGIIKCAP : NGENPNOGFON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[CPICBLLAMOM]
	private SceneService OGAOLGJGLCD;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3A67840", Offset = "0x3A66C40", VA = "0x183A67840", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3A67820", Offset = "0x3A66C20", VA = "0x183A67820", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public HEGMGIIKCAP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[AOJPGBJKDNL(typeof(PhotonInstanceCleanupService), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.Lifecycle)]
	[PHECHDJFGDG(FPOGPJMGMEG.PhotonRoom)]
	public class PhotonInstanceCleanupService : NGENPNOGFON, HIJIFLANIAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private KOACKKPPGEK PICNNIBMGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private APLFFAOJOGK CGENOKFJBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeList<int> HICGHEKDIKC;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3776DA0", Offset = "0x37761A0", VA = "0x183776DA0", Slot = "5")]
		public void MPBHMBLFPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3776E00", Offset = "0x3776200", VA = "0x183776E00", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3776CC0", Offset = "0x37760C0", VA = "0x183776CC0")]
		public void IHAPPEEILPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x37769C0", Offset = "0x3775DC0", VA = "0x1837769C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3776AB0", Offset = "0x3775EB0", VA = "0x183776AB0")]
		public void FBKLEMGFCCF(global::PKHGLMKIEOF<int> NAHOBDIELAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3776D60", Offset = "0x3776160", VA = "0x183776D60")]
		public void JGEMHNPAIPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public PhotonInstanceCleanupService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal abstract class MFADOKOFFEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint LPIOKPGLALP;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public abstract uint JHHEKMODIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x953CB0", Offset = "0x9530B0", VA = "0x180953CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x37626C0", Offset = "0x3761AC0", VA = "0x1837626C0")]
	public EHNBIOJHEAD DAKPANLLLLJ()
	{
		return default(EHNBIOJHEAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x3762610", Offset = "0x3761A10", VA = "0x183762610")]
	public void AOMNLFILNLL(EHNBIOJHEAD DGDIPHPMEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA073B0", Offset = "0xA067B0", VA = "0x180A073B0", Slot = "6")]
	public virtual void LMINFOAGFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	protected MFADOKOFFEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
[AOJPGBJKDNL(typeof(LGJBFBKFPLE), new string[] { })]
internal sealed class LGJBFBKFPLE : MFADOKOFFEH, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[CPICBLLAMOM]
	private PFHNJBGFDIA CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint CPILGALONLA;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint JHHEKMODIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x764360", Offset = "0x763760", VA = "0x180764360", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3760680", Offset = "0x375FA80", VA = "0x183760680", Slot = "7")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x37605D0", Offset = "0x375F9D0", VA = "0x1837605D0")]
	private void HLKFFGDIIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3760620", Offset = "0x375FA20", VA = "0x183760620", Slot = "6")]
	public override void LMINFOAGFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public LGJBFBKFPLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[AOJPGBJKDNL(typeof(HMPFLJOECKJ), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
internal sealed class HMPFLJOECKJ : MFADOKOFFEH
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint JHHEKMODIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
	public HMPFLJOECKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
[AOJPGBJKDNL(typeof(KEPBOOFKKIH), new string[] { })]
internal sealed class KEPBOOFKKIH : HPLECDDPLCA, HIJIFLANIAO, NGENPNOGFON, CJFEEGPLPHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[CPICBLLAMOM]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery MLMAPLEGMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery JCBEGJHMIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery EGGIKMPBHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery KFFBLDKLGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery IDFPGKAMBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery PHAKJOMPGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private EntityManager NPBNPNJJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3A735D0", Offset = "0x3A729D0", VA = "0x183A735D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery EFCFCCCBBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8291E0", Offset = "0x8285E0", VA = "0x1808291E0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery LJGPMNINNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7F8700", Offset = "0x7F7B00", VA = "0x1807F8700")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery CADPEGMPHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x78D7C0", Offset = "0x78CBC0", VA = "0x18078D7C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery OEMNDEOIIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x81B350", Offset = "0x81A750", VA = "0x18081B350")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery DGCLIMFCNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x81B440", Offset = "0x81A840", VA = "0x18081B440")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery OHNONNCDFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3A73620", Offset = "0x3A72A20", VA = "0x183A73620")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int NHHJOKKNPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3A73C30", Offset = "0x3A73030", VA = "0x183A73C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int NOMCDGGNAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3A73750", Offset = "0x3A72B50", VA = "0x183A73750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int OGIJJNNCMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3A73CD0", Offset = "0x3A730D0", VA = "0x183A73CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int INKKHGLBCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3A73770", Offset = "0x3A72B70", VA = "0x183A73770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int DJCJGMECMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3A73C50", Offset = "0x3A73050", VA = "0x183A73C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int AFGFOGNJKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3A733F0", Offset = "0x3A727F0", VA = "0x183A733F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "4")]
	public void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3A73CF0", Offset = "0x3A730F0", VA = "0x183A73CF0", Slot = "5")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3A73790", Offset = "0x3A72B90", VA = "0x183A73790", Slot = "6")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3A73C70", Offset = "0x3A73070", VA = "0x183A73C70")]
	private EntityQueryDesc NOKFCGKACFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3A73570", Offset = "0x3A72970", VA = "0x183A73570", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3A73410", Offset = "0x3A72810", VA = "0x183A73410")]
	public EMEBICHCNIH ABIPMKBCDCC(KJNCFICFIIE LJGIOCJLACK)
	{
		return default(EMEBICHCNIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3A734C0", Offset = "0x3A728C0", VA = "0x183A734C0")]
	public EMEBICHCNIH ABIPMKBCDCC(Entity OOEHGINMJGM)
	{
		return default(EMEBICHCNIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3A736A0", Offset = "0x3A72AA0", VA = "0x183A736A0")]
	public AGNBDHNLGKL EJENMGHMFCK(Entity OOEHGINMJGM)
	{
		return default(AGNBDHNLGKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3A73D40", Offset = "0x3A73140", VA = "0x183A73D40")]
	public KEPBOOFKKIH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[NAPHGBOEKGO(GPIMBHHJLKL.All)]
	[AOJPGBJKDNL(typeof(LBIICBANFEM), new string[] { })]
	public class ObjectService : NGENPNOGFON, LBIICBANFEM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly BBHAOFNBCPD PJHEHCMPNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[CPICBLLAMOM]
		private FJFNAPPGKJO EIINEJPEGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[CPICBLLAMOM]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[CPICBLLAMOM]
		private ObjectLifecycleService PHNFNFPBDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[CPICBLLAMOM]
		private ObjectEmbodimentService KGKPNOEKJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[CPICBLLAMOM]
		private ObjectInstantiationService GKKDCEIPLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[CPICBLLAMOM]
		private KEPBOOFKKIH BBLGAIECEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ObjectNetworkToLocalMapService KEENEJEMIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public FJFNAPPGKJO KLKODJCENGP
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int NHHJOKKNPAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x37728A0", Offset = "0x3771CA0", VA = "0x1837728A0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int NOMCDGGNAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x3772590", Offset = "0x3771990", VA = "0x183772590", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int OGIJJNNCMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x37732A0", Offset = "0x37726A0", VA = "0x1837732A0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int INKKHGLBCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x37727E0", Offset = "0x3771BE0", VA = "0x1837727E0", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int DJCJGMECMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x3772CE0", Offset = "0x37720E0", VA = "0x183772CE0", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int AFGFOGNJKGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x37716C0", Offset = "0x3770AC0", VA = "0x1837716C0", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<KJNCFICFIIE, AGNBDHNLGKL> NHJCBLPKGLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x3772740", Offset = "0x3771B40", VA = "0x183772740", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x3772C40", Offset = "0x3772040", VA = "0x183772C40", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<KJNCFICFIIE> BBABCFMEBNE
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x3772EE0", Offset = "0x37722E0", VA = "0x183772EE0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x37724F0", Offset = "0x37718F0", VA = "0x1837724F0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x37732C0", Offset = "0x37726C0", VA = "0x1837732C0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3771F00", Offset = "0x3771300", VA = "0x183771F00", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x37723F0", Offset = "0x37717F0", VA = "0x1837723F0")]
		private void FPKBBNLKKCB(Entity OOEHGINMJGM, AGNBDHNLGKL LDKBJDPJMKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3772AA0", Offset = "0x3771EA0", VA = "0x183772AA0")]
		private void KCEBPBDLDKP(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3772720", Offset = "0x3771B20", VA = "0x183772720")]
		internal KJNCFICFIIE HONPCNPPAIH(Entity OOEHGINMJGM)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x37729B0", Offset = "0x3771DB0", VA = "0x1837729B0", Slot = "41")]
		public HKMFMMPGOLI JKAPELICEAM()
		{
			return default(HKMFMMPGOLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3771E50", Offset = "0x3771250", VA = "0x183771E50", Slot = "42")]
		public HKMFMMPGOLI DLJOIPCAJAK()
		{
			return default(HKMFMMPGOLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3772E20", Offset = "0x3772220", VA = "0x183772E20", Slot = "43")]
		public HKMFMMPGOLI MDFAGMMCEEP()
		{
			return default(HKMFMMPGOLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x37716E0", Offset = "0x3770AE0", VA = "0x1837716E0", Slot = "10")]
		public EMEBICHCNIH ABIPMKBCDCC(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(EMEBICHCNIH);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x37721B0", Offset = "0x37715B0", VA = "0x1837721B0", Slot = "11")]
		public AGNBDHNLGKL EJENMGHMFCK(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(AGNBDHNLGKL);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3771AF0", Offset = "0x3770EF0", VA = "0x183771AF0")]
		private HKMFMMPGOLI BJMMAFFEOBI(EntityQuery FDOFAODBNNC)
		{
			return default(HKMFMMPGOLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x37730A0", Offset = "0x37724A0", VA = "0x1837730A0", Slot = "33")]
		public bool NDBOIIODAJJ(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x37721F0", Offset = "0x37715F0", VA = "0x1837721F0", Slot = "29")]
		public void FBEHGKKMCPK(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3773130", Offset = "0x3772530", VA = "0x183773130", Slot = "30")]
		public void OADODFJBFIO(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3771DB0", Offset = "0x37711B0", VA = "0x183771DB0", Slot = "31")]
		public void CPPBEMAMOOF(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3772630", Offset = "0x3771A30", VA = "0x183772630", Slot = "22")]
		public NPBAKKOKIOD HMFOIELDBON(AGNBDHNLGKL LDKBJDPJMKG, bool LALJKONNGBI)
		{
			return default(NPBAKKOKIOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x37725B0", Offset = "0x37719B0", VA = "0x1837725B0", Slot = "23")]
		public NPBAKKOKIOD HMFOIELDBON(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(NPBAKKOKIOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3772F80", Offset = "0x3772380", VA = "0x183772F80", Slot = "24")]
		public NPBAKKOKIOD MHLLMDPCNMF(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(NPBAKKOKIOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3771780", Offset = "0x3770B80", VA = "0x183771780", Slot = "25")]
		public NPBAKKOKIOD AECJHCGBPOI(EHNBIOJHEAD DGDIPHPMEJP, AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(NPBAKKOKIOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3773230", Offset = "0x3772630", VA = "0x183773230", Slot = "44")]
		public NPBAKKOKIOD OLPAHMLPNHO(int FBBHHKMMFKI, AGNBDHNLGKL LDKBJDPJMKG, GameObject CEPEJEHMODM)
		{
			return default(NPBAKKOKIOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3771BA0", Offset = "0x3770FA0", VA = "0x183771BA0", Slot = "26")]
		public GFKEAGIAJHL BNHDELMCAAP()
		{
			return default(GFKEAGIAJHL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3771950", Offset = "0x3770D50", VA = "0x183771950", Slot = "45")]
		public HIHLFNBNGND BBKFAKNPMLB(COHKEJMMIKI BKGBGEHNCAE)
		{
			return default(HIHLFNBNGND);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x3772B90", Offset = "0x3771F90", VA = "0x183772B90", Slot = "27")]
		public FLKJHOJAALI KHJDHCNKEIA()
		{
			return default(FLKJHOJAALI);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3772D00", Offset = "0x3772100", VA = "0x183772D00", Slot = "28")]
		public BNNLBLBKEAL LIKJNLFLDAN(LGHJFDELFEL BKGBGEHNCAE)
		{
			return default(BNNLBLBKEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3772EC0", Offset = "0x37722C0", VA = "0x183772EC0", Slot = "12")]
		public void MHBAMOAJPNP(EHNBIOJHEAD DGDIPHPMEJP, IHNOMGAGHCN MKNPMJHOLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3771C90", Offset = "0x3771090", VA = "0x183771C90", Slot = "13")]
		public NPBAKKOKIOD COLCJMDGIIA(KJNCFICFIIE GNKPFNIMJND, [Optional] object JCHAGIDHJIB)
		{
			return default(NPBAKKOKIOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3773190", Offset = "0x3772590", VA = "0x183773190", Slot = "14")]
		public bool OENDIKOIADH(KJNCFICFIIE GNKPFNIMJND, out IHNOMGAGHCN CGKNIAMFPAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3772A50", Offset = "0x3771E50", VA = "0x183772A50", Slot = "46")]
		public Transform KCCHIGCAEMK(KJNCFICFIIE GNKPFNIMJND, [Optional] object JCHAGIDHJIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3773050", Offset = "0x3772450", VA = "0x183773050", Slot = "16")]
		public bool NCFBPALOAMF(KJNCFICFIIE GNKPFNIMJND, out Transform GCKJJOINBCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3771C40", Offset = "0x3771040", VA = "0x183771C40", Slot = "17")]
		public bool CINBLFIFJPP(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3772B30", Offset = "0x3771F30", VA = "0x183772B30")]
		public bool KFCNHGCEBIG(IHNOMGAGHCN FPLJCBGEJAP, [Optional] object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3772B60", Offset = "0x3771F60", VA = "0x183772B60", Slot = "47")]
		public bool KFCNHGCEBIG(KJNCFICFIIE GNKPFNIMJND, [Optional] object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3771AD0", Offset = "0x3770ED0", VA = "0x183771AD0", Slot = "48")]
		public void BJCHMCKGHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3772240", Offset = "0x3771640", VA = "0x183772240", Slot = "15")]
		public void FMDJKEFPFCJ(IHNOMGAGHCN JGHFLANLLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x3773010", Offset = "0x3772410", VA = "0x183773010", Slot = "49")]
		public void MPLJCGKOAMJ(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3771A50", Offset = "0x3770E50", VA = "0x183771A50", Slot = "18")]
		public bool BDDOGFOHCPP(Entity OOEHGINMJGM, object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x37728C0", Offset = "0x3771CC0", VA = "0x1837728C0", Slot = "19")]
		public bool JBLNOEGKAGH(Entity OOEHGINMJGM, object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3772940", Offset = "0x3771D40", VA = "0x183772940", Slot = "50")]
		public bool JJJPKOPBCEL(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3771710", Offset = "0x3770B10", VA = "0x183771710", Slot = "51")]
		public bool ADIHCFAHPLE(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3772490", Offset = "0x3771890", VA = "0x183772490", Slot = "32")]
		public NativeArray<(KJNCFICFIIE, KJNCFICFIIE)> GMIKKPABJEA(NativeArray<KJNCFICFIIE> ANCPHOALPDO, Allocator NDJJBKEIGCD)
		{
			return default(NativeArray<(KJNCFICFIIE, KJNCFICFIIE)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3772800", Offset = "0x3771C00", VA = "0x183772800", Slot = "21")]
		public EHNBIOJHEAD IGIFPGJEPFO(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(EHNBIOJHEAD);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x37720C0", Offset = "0x37714C0", VA = "0x1837720C0", Slot = "20")]
		public KJNCFICFIIE EHPBFPGFMPJ(EHNBIOJHEAD DGDIPHPMEJP)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3772080", Offset = "0x3771480", VA = "0x183772080")]
		private void ECLABOCBGBP(AGNBDHNLGKL LDKBJDPJMKG, KJNCFICFIIE GNKPFNIMJND, EHNBIOJHEAD DGDIPHPMEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
[AOJPGBJKDNL(typeof(IBPFNOLDCLO), new string[] { })]
internal sealed class IBPFNOLDCLO : NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private ObjectInstantiationService GKKDCEIPLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[CPICBLLAMOM]
	private KEPBOOFKKIH BBLGAIECEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[CPICBLLAMOM]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x3A6BD40", Offset = "0x3A6B140", VA = "0x183A6BD40", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B5D0", Offset = "0x3A6A9D0", VA = "0x183A6B5D0")]
	public NativeArray<(KJNCFICFIIE, KJNCFICFIIE)> GMIKKPABJEA(NativeArray<KJNCFICFIIE> ANCPHOALPDO, Allocator NDJJBKEIGCD)
	{
		return default(NativeArray<(KJNCFICFIIE, KJNCFICFIIE)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B6D0", Offset = "0x3A6AAD0", VA = "0x183A6B6D0")]
	private void GOLACBOIEMK(NativeMultiHashMap<int, (KJNCFICFIIE src, KJNCFICFIIE dst)> EALCLOKHMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B8B0", Offset = "0x3A6ACB0", VA = "0x183A6B8B0")]
	private void HNEKCBAKCHN(NativeMultiHashMap<int, (KJNCFICFIIE src, KJNCFICFIIE dst)> EALCLOKHMHP, int LDKBJDPJMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B440", Offset = "0x3A6A840", VA = "0x183A6B440")]
	private void ELHKIEELHNF(NativeMultiHashMap<int, (KJNCFICFIIE src, KJNCFICFIIE dst)> EALCLOKHMHP, int LDKBJDPJMKG, AEBPMMDNEJA FIJECBKDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B0E0", Offset = "0x3A6A4E0", VA = "0x183A6B0E0")]
	private NativeMultiHashMap<int, (KJNCFICFIIE, KJNCFICFIIE)> BPJEPMNJOBG(Allocator NDJJBKEIGCD, NativeArray<KJNCFICFIIE> ANCPHOALPDO, out NativeArray<(KJNCFICFIIE src, KJNCFICFIIE dst)> LHINKHEDCIN)
	{
		return default(NativeMultiHashMap<int, (KJNCFICFIIE, KJNCFICFIIE)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public IBPFNOLDCLO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[NAPHGBOEKGO(GPIMBHHJLKL.TransformSyncing)]
	[APCINEIKDDA(typeof(TransformService))]
	[AOJPGBJKDNL(typeof(AOJCNPMLIMB), new string[] { })]
	public class TransformService : AOJCNPMLIMB, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly BBHAOFNBCPD KGHCKNOKLMK;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly BBHAOFNBCPD PPBANKLHCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private LIOPMJFBPIJ POMGNNIENEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private CBGJJCKMFCA LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private OBNLPCJMAPP MDDAOJACOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TransformOwnershipPhase HKJONOKNHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ObjectEmbodimentService NGEDJICHDBC;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private EntityManager NPBNPNJJNKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x38BEBB0", Offset = "0x38BDFB0", VA = "0x1838BEBB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private JIBOBOIGILH NANHEDFHHMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x38BFA30", Offset = "0x38BEE30", VA = "0x1838BFA30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x38C2450", Offset = "0x38C1850", VA = "0x1838C2450", Slot = "33")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x38C1F30", Offset = "0x38C1330", VA = "0x1838C1F30", Slot = "34")]
		public bool OKLNFDNDPMC(Transform GCKJJOINBCJ, out KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x38C1E70", Offset = "0x38C1270", VA = "0x1838C1E70", Slot = "35")]
		public Transform OFPBEMEAOJO(Entity OOEHGINMJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x38C19B0", Offset = "0x38C0DB0", VA = "0x1838C19B0", Slot = "30")]
		public bool NCFBPALOAMF(Entity OOEHGINMJGM, out Transform GCKJJOINBCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x38BEC00", Offset = "0x38BE000", VA = "0x1838BEC00")]
		private void EFBOCJBKEBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x38BE2D0", Offset = "0x38BD6D0", VA = "0x1838BE2D0", Slot = "29")]
		public void DFFJHJHIJDG(Entity OOEHGINMJGM, out Matrix4x4 NFIKAMLOGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x38BD660", Offset = "0x38BCA60", VA = "0x1838BD660", Slot = "4")]
		public void ACMAGMKBNJM(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x38C0520", Offset = "0x38BF920", VA = "0x1838C0520")]
		public void JEENNFDEDLL(Entity OOEHGINMJGM, Vector3 NIAHCGPKDEH, Quaternion KJCIGGBJPKG, Vector3 JLOMPHEPCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x38BFAF0", Offset = "0x38BEEF0", VA = "0x1838BFAF0")]
		public void GFOKOMDPMBC(Entity OOEHGINMJGM, Vector3 NIAHCGPKDEH, Quaternion KJCIGGBJPKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x38BFED0", Offset = "0x38BF2D0", VA = "0x1838BFED0", Slot = "27")]
		public void HLKFOIBHIAI(Entity OOEHGINMJGM, out Matrix4x4 OJJPEECCKCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x38BD920", Offset = "0x38BCD20", VA = "0x1838BD920")]
		public void ALEDKNCBPFH(Entity OOEHGINMJGM, in Matrix4x4 NFIKAMLOGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x38C1C60", Offset = "0x38C1060", VA = "0x1838C1C60")]
		public void NLJIBNJCPEH(Entity OOEHGINMJGM, in Matrix4x4 NFIKAMLOGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x38C1AA0", Offset = "0x38C0EA0", VA = "0x1838C1AA0")]
		public void NIBEMPJGHOA(Entity OOEHGINMJGM, in Matrix4x4 KKGDOJLLPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x38C05F0", Offset = "0x38BF9F0", VA = "0x1838C05F0", Slot = "5")]
		public void JJLDCHCJFEK(Entity OOEHGINMJGM, Vector3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x38BFDC0", Offset = "0x38BF1C0", VA = "0x1838BFDC0", Slot = "6")]
		public Vector3 HCIPMMOOEGI(Entity OOEHGINMJGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x38C0420", Offset = "0x38BF820", VA = "0x1838C0420", Slot = "7")]
		public void JCBOABOLEMG(Entity OOEHGINMJGM, Quaternion FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x38BE0B0", Offset = "0x38BD4B0", VA = "0x1838BE0B0", Slot = "8")]
		public Quaternion CFOKGBIBNOF(Entity OOEHGINMJGM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x38C2560", Offset = "0x38C1960", VA = "0x1838C2560", Slot = "12")]
		public void PFLNKBMJBDP(Entity OOEHGINMJGM, Vector3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x38C18A0", Offset = "0x38C0CA0", VA = "0x1838C18A0", Slot = "11")]
		public Vector3 MAGKBEGBOCN(Entity OOEHGINMJGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x38C23B0", Offset = "0x38C17B0", VA = "0x1838C23B0")]
		public void PALAHEHLMHM(Entity OOEHGINMJGM, Vector3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x38BE010", Offset = "0x38BD410", VA = "0x1838BE010")]
		private Vector3 BPKPIIMAHGJ(Entity OOEHGINMJGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x38BF880", Offset = "0x38BEC80", VA = "0x1838BF880", Slot = "14")]
		public float FHMNJBFAOBH(Entity OOEHGINMJGM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x38BF920", Offset = "0x38BED20", VA = "0x1838BF920", Slot = "13")]
		public void FNEGMPPJEFB(Entity OOEHGINMJGM, float FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x38C0710", Offset = "0x38BFB10", VA = "0x1838C0710")]
		private float JMPKEKMJDBF(Entity OOEHGINMJGM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x38C2320", Offset = "0x38C1720", VA = "0x1838C2320")]
		public void OMPPEGFFOKF(Entity OOEHGINMJGM, float NLKBFGDPAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x38BDCE0", Offset = "0x38BD0E0", VA = "0x1838BDCE0", Slot = "16")]
		public Vector3 AMAAOPDNHFK(Entity OOEHGINMJGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x38BF380", Offset = "0x38BE780", VA = "0x1838BF380", Slot = "15")]
		public void EPNHBPGMKJA(Entity OOEHGINMJGM, Vector3 CEJDOAGPFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x38C02F0", Offset = "0x38BF6F0", VA = "0x1838C02F0")]
		private Vector3 JCBDBCCBOEE(Entity OOEHGINMJGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x38BD850", Offset = "0x38BCC50", VA = "0x1838BD850")]
		public void AIGECKNMNDM(Entity OOEHGINMJGM, Vector3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x38BE420", Offset = "0x38BD820", VA = "0x1838BE420")]
		[Conditional("DEBUG_BUILD")]
		private void DKCJEFDHADH(Entity OOEHGINMJGM, Vector3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x38BDDC0", Offset = "0x38BD1C0", VA = "0x1838BDDC0", Slot = "36")]
		public void BCHKCONEMKJ(Entity OOEHGINMJGM, Vector3 KGJPEGOHADA, Quaternion GCFIGFMOIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x38BFEE0", Offset = "0x38BF2E0", VA = "0x1838BFEE0", Slot = "9")]
		public void IKLPGFCGKKB(Entity OOEHGINMJGM, out Vector3 KGJPEGOHADA, out Quaternion GCFIGFMOIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x38C10C0", Offset = "0x38C04C0", VA = "0x1838C10C0", Slot = "10")]
		public void KDOGBPHMHJK(Entity OOEHGINMJGM, out Vector3 KGJPEGOHADA, out Quaternion GCFIGFMOIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x38C0EA0", Offset = "0x38C02A0", VA = "0x1838C0EA0", Slot = "37")]
		public void KCDFBKKDLKC(Entity OOEHGINMJGM, Vector3 KGJPEGOHADA, Quaternion GCFIGFMOIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x38BFC00", Offset = "0x38BF000", VA = "0x1838BFC00")]
		public void GHCCCIIFAEO(Entity OOEHGINMJGM, Vector3 KGJPEGOHADA, Quaternion GCFIGFMOIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x38C1590", Offset = "0x38C0990", VA = "0x1838C1590", Slot = "17")]
		public void LANALDPODEL(Entity OOEHGINMJGM, Vector3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x38C1D90", Offset = "0x38C1190", VA = "0x1838C1D90", Slot = "18")]
		public Vector3 OAJIHLOMNPH(Entity OOEHGINMJGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x38C00B0", Offset = "0x38BF4B0", VA = "0x1838C00B0", Slot = "19")]
		public void IMHAPCOPANI(Entity OOEHGINMJGM, Quaternion FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x38BDF20", Offset = "0x38BD320", VA = "0x1838BDF20", Slot = "20")]
		public Quaternion BFDBFBILDPM(Entity OOEHGINMJGM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x38BED70", Offset = "0x38BE170", VA = "0x1838BED70", Slot = "22")]
		public void ELMAEAKDPDL(Entity OOEHGINMJGM, Vector3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x38BE5D0", Offset = "0x38BD9D0", VA = "0x1838BE5D0", Slot = "21")]
		public Vector3 EACKGIIJIHL(Entity OOEHGINMJGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x38BF710", Offset = "0x38BEB10", VA = "0x1838BF710", Slot = "23")]
		public void FCGFACADADK(Entity OOEHGINMJGM, float AMABPLMALFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x38BF5F0", Offset = "0x38BE9F0", VA = "0x1838BF5F0", Slot = "24")]
		public float FAKLMKBCDAF(Entity OOEHGINMJGM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x38BE6C0", Offset = "0x38BDAC0", VA = "0x1838BE6C0", Slot = "25")]
		public void EBGFBBCJKEI(Entity OOEHGINMJGM, Vector3 EHDMPCDLGBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x38BF4B0", Offset = "0x38BE8B0", VA = "0x1838BF4B0", Slot = "26")]
		public Vector3 FADAIBMLFPN(Entity OOEHGINMJGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x38C0800", Offset = "0x38BFC00", VA = "0x1838C0800", Slot = "31")]
		public void JPHDHELGPDH(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x38BEC20", Offset = "0x38BE020", VA = "0x1838BEC20")]
		private KJNCFICFIIE ELKHCAGCEIH(Transform GCKJJOINBCJ)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x38C20F0", Offset = "0x38C14F0", VA = "0x1838C20F0")]
		private static TransformEntity OMDKIAAOKHK(AGNBDHNLGKL BKGBGEHNCAE, GameObject EBOMDGJFPAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x38BE1A0", Offset = "0x38BD5A0", VA = "0x1838BE1A0", Slot = "32")]
		public void CIPKAFIBKDO(Entity OOEHGINMJGM, Entity AABDLCHECIH, Entity HKBAAFCKIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x38C0030", Offset = "0x38BF430", VA = "0x1838C0030")]
		private BPGIJHEBJIA IKLPGFCGKKB(Entity OOEHGINMJGM)
		{
			return default(BPGIJHEBJIA);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x38C17C0", Offset = "0x38C0BC0", VA = "0x1838C17C0")]
		private bool LDKFEKLAPME(Entity OOEHGINMJGM, out Entity CNDFBGEJOLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x38BF1D0", Offset = "0x38BE5D0", VA = "0x1838BF1D0")]
		private void ENDMDGIABKF(Entity OOEHGINMJGM, out Matrix4x4 NFIKAMLOGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x38C11F0", Offset = "0x38C05F0", VA = "0x1838C11F0")]
		private void KGJEHLDGCJN(Entity OOEHGINMJGM, out Matrix4x4 KKGDOJLLPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x38BE2C0", Offset = "0x38BD6C0", VA = "0x1838BE2C0", Slot = "28")]
		private void CPPBGNLOOJJ(Entity OOEHGINMJGM, in Matrix4x4 OJJPEECCKCP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
[AOJPGBJKDNL(typeof(POKDCDDNAFG), new string[] { })]
internal sealed class POKDCDDNAFG : NGENPNOGFON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[CPICBLLAMOM]
	private PFHNJBGFDIA CMMLIBKHPCN;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3776820", Offset = "0x3775C20", VA = "0x183776820", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x37767B0", Offset = "0x3775BB0", VA = "0x1837767B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public POKDCDDNAFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
[AOJPGBJKDNL(typeof(KFHNJEDPGGK), new string[] { })]
public class KFHNJEDPGGK
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct HDILOJDDAEO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly KFHNJEDPGGK CNDFBGEJOLI;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x4191930", Offset = "0x4190D30", VA = "0x184191930")]
		public HDILOJDDAEO(KFHNJEDPGGK CNDFBGEJOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x4191910", Offset = "0x4190D10", VA = "0x184191910", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int MKJEGNHHPIP;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool DAEJBPPELJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1CDB9F0", Offset = "0x1CDADF0", VA = "0x181CDB9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action IGHPCLIFOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A73DA0", Offset = "0x3A731A0", VA = "0x183A73DA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A73E40", Offset = "0x3A73240", VA = "0x183A73E40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A73D50", Offset = "0x3A73150", VA = "0x183A73D50")]
	public HDILOJDDAEO CDKOPGOLFNP()
	{
		return default(HDILOJDDAEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xE69560", Offset = "0xE68960", VA = "0x180E69560")]
	public void MMEJEMFEJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A73D80", Offset = "0x3A73180", VA = "0x183A73D80")]
	public void HJABNMJHPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public KFHNJEDPGGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[AOJPGBJKDNL(typeof(GFGNKONFLNK), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
public class GFGNKONFLNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int MKJEGNHHPIP;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool LAFJIBMJEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xD70C00", Offset = "0xD70000", VA = "0x180D70C00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xECBF70", Offset = "0xECB370", VA = "0x180ECBF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GFGNKONFLNK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[AOJPGBJKDNL(typeof(EnableComponentSystemsInScope), new string[] { })]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[NAPHGBOEKGO(GPIMBHHJLKL.ComponentSystemTypes)]
	public class EnableComponentSystemsInScope : NGENPNOGFON, AAHLPGOALAE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct DJNDAODLJAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private NativeArray<int> EAEFCGDBFIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private NativeArray<int> JGPMHBBALKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private Dictionary<ComponentSystemBase, int> BJFICPGCDJA;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x418E0F0", Offset = "0x418D4F0", VA = "0x18418E0F0")]
			public DJNDAODLJAB(NativeArray<int> EAEFCGDBFIF, NativeArray<int> JGPMHBBALKB, Dictionary<ComponentSystemBase, int> BJFICPGCDJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x418DE70", Offset = "0x418D270", VA = "0x18418DE70")]
			public void MONKNDPHDDB(IEnumerable<ComponentSystemBase> EIINEJPEGBG, FPOGPJMGMEG JBGIMDLFJKC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class GDCFLGMJMIF : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
			[DebuggerHidden]
			public GDCFLGMJMIF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x4190AF0", Offset = "0x418FEF0", VA = "0x184190AF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x4190CC0", Offset = "0x41900C0", VA = "0x184190CC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x4190C10", Offset = "0x4190010", VA = "0x184190C10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x4190C10", Offset = "0x4190010", VA = "0x184190C10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const FPOGPJMGMEG BCLDMCBCODL = FPOGPJMGMEG.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly BBHAOFNBCPD PAGGLPJFMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA PEPLIFOGJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private World LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private LODNGHNPONL KPGPMPPLGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeArray<int> OJOIINGKLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NativeArray<int> ONMOALCFJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int IIMAMIPIKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private FPOGPJMGMEG OGGCIMPIOBH;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BB50", Offset = "0x3A5AF50", VA = "0x183A5BB50", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A5ACD0", Offset = "0x3A5A0D0", VA = "0x183A5ACD0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B470", Offset = "0x3A5A870", VA = "0x183A5B470")]
		[IteratorStateMachine(typeof(GDCFLGMJMIF))]
		private IEnumerable<ComponentSystemBase> MIIBKJCFHJF(int GJOFJPHNEOA, int AFEDLJDCGDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AC50", Offset = "0x3A5A050", VA = "0x183A5AC50", Slot = "5")]
		public void DNDHHJNBJKB(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AC50", Offset = "0x3A5A050", VA = "0x183A5AC50")]
		private void MHPLHMBDKHD(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B370", Offset = "0x3A5A770", VA = "0x183A5B370")]
		public void MHPLHMBDKHD(FPOGPJMGMEG ODKOMDFLCPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AED0", Offset = "0x3A5A2D0", VA = "0x183A5AED0")]
		private void GIEDDGBNGLM(FPOGPJMGMEG ODKOMDFLCPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B220", Offset = "0x3A5A620", VA = "0x183A5B220")]
		private void KCHNOEEBFEI(FPOGPJMGMEG ODKOMDFLCPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AE30", Offset = "0x3A5A230", VA = "0x183A5AE30")]
		private void FMLLJBOLILG(FPOGPJMGMEG ODKOMDFLCPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B160", Offset = "0x3A5A560", VA = "0x183A5B160")]
		private void GLMLFFKNNNK(int GJOFJPHNEOA, int AFEDLJDCGDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B2B0", Offset = "0x3A5A6B0", VA = "0x183A5B2B0")]
		private void LFGHOBEPJKE(int GJOFJPHNEOA, int AFEDLJDCGDB, bool KHOMHGNHAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AE10", Offset = "0x3A5A210", VA = "0x183A5AE10")]
		private int FJEJEDHNKNF(FPOGPJMGMEG ODKOMDFLCPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B500", Offset = "0x3A5A900", VA = "0x183A5B500")]
		private bool MMELHOPFBLN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AB60", Offset = "0x3A59F60", VA = "0x183A5AB60")]
		private Dictionary<ComponentSystemBase, int> BEJDHFCIEOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AE90", Offset = "0x3A5A290", VA = "0x183A5AE90")]
		private void GHOGCKIDIPD(NativeArray<int> EAEFCGDBFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AD60", Offset = "0x3A5A160", VA = "0x183A5AD60")]
		private void FBEFGEJGGGL(NativeArray<int> JGPMHBBALKB, NativeArray<int> EAEFCGDBFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BAF0", Offset = "0x3A5AEF0", VA = "0x183A5BAF0")]
		private static FPOGPJMGMEG OEMFLMEHGHG(Type BKGBGEHNCAE, FPOGPJMGMEG IEMLIFLCGLH)
		{
			return default(FPOGPJMGMEG);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BD10", Offset = "0x3A5B110", VA = "0x183A5BD10")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BA90", Offset = "0x3A5AE90", VA = "0x183A5BA90")]
		[CompilerGenerated]
		private void NDOIDBMIEKB(NGENPNOGFON CLJOGGPIGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BC20", Offset = "0x3A5B020", VA = "0x183A5BC20")]
		[CompilerGenerated]
		private void PKBFMBNPHMI(CJFEEGPLPHA CLJOGGPIGLL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[NAPHGBOEKGO(GPIMBHHJLKL.WorldService)]
	[AOJPGBJKDNL(typeof(KGJHIIIKFIO), new string[] { })]
	public class TickService : NGENPNOGFON, KGJHIIIKFIO
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly ProfilerMarker APNGLDMFKNH;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ProfilerMarker NFEFAFFMKAG;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly ProfilerMarker PPKDODGFIKK;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly ProfilerMarker KFLJJOHFGMB;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly ProfilerMarker MJGHIBPMDDP;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly ProfilerMarker FPKFHMEBCLJ;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly ProfilerMarker CFAKEGBNOBB;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly ProfilerMarker PJGOIEOJJEO;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly ProfilerMarker LMAMJHOBNNL;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly ProfilerMarker ELMLHGBOHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA PEPLIFOGJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[CPICBLLAMOM]
		private HMKLFLHGJEI NOGKNHKHMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[CPICBLLAMOM]
		private GFLCOPIDGGN IKCDGDCGBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[CPICBLLAMOM]
		private TransformOwnershipPhase OELDLPPDGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[CPICBLLAMOM]
		private TimeService LECPFPHPAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private AJIJKHGHPDE LIPGMHFIHCI;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool DJPLJKOKOKH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x38BBAF0", Offset = "0x38BAEF0", VA = "0x1838BBAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool JJAONPMLNBO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x38BC3F0", Offset = "0x38BB7F0", VA = "0x1838BC3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool BPGCOLENFLP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x38BBAF0", Offset = "0x38BAEF0", VA = "0x1838BBAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool BMOFCNDABML
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x38BBAF0", Offset = "0x38BAEF0", VA = "0x1838BBAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x38BC920", Offset = "0x38BBD20", VA = "0x1838BC920", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x38BC610", Offset = "0x38BBA10", VA = "0x1838BC610", Slot = "14")]
		public void MLDCKNCHJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x38BC800", Offset = "0x38BBC00", VA = "0x1838BC800", Slot = "15")]
		public void OPMBFJPJNEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x38BC730", Offset = "0x38BBB30", VA = "0x1838BC730", Slot = "5")]
		public void NGJIOEDGFNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x38BBCE0", Offset = "0x38BB0E0", VA = "0x1838BBCE0", Slot = "6")]
		public void EKNBJPKFKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x38BBB60", Offset = "0x38BAF60", VA = "0x1838BBB60", Slot = "7")]
		public void EKJJGKHGHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x38BB970", Offset = "0x38BAD70", VA = "0x1838BB970", Slot = "8")]
		public void DLAAMIFJDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x38BC490", Offset = "0x38BB890", VA = "0x1838BC490", Slot = "9")]
		public void MFFNLDJKLHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x38BBFB0", Offset = "0x38BB3B0", VA = "0x1838BBFB0", Slot = "10")]
		public void KNHDHHNIANM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x38BB8A0", Offset = "0x38BACA0", VA = "0x1838BB8A0", Slot = "11")]
		public void AEELAEPFFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "13")]
		public void BLNFPPHMIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x38BBE60", Offset = "0x38BB260", VA = "0x1838BBE60", Slot = "12")]
		public void JBMABCIJKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[AOJPGBJKDNL(typeof(CBGJJCKMFCA), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.WorldService)]
	public class WorldService : CBGJJCKMFCA, IDisposable, HIJIFLANIAO, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private AJIJKHGHPDE LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private KEICNAJBANN CGKMMOPOBPI;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public AJIJKHGHPDE PHIKONIBLIA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public JIBOBOIGILH NANHEDFHHMK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xEFFF90", Offset = "0xEFF390", VA = "0x180EFFF90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager NPBNPNJJNKA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x38CA8D0", Offset = "0x38C9CD0", VA = "0x1838CA8D0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool PGGMGHNLHNL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x85F6B0", Offset = "0x85EAB0", VA = "0x18085F6B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x38CA910", Offset = "0x38C9D10", VA = "0x1838CA910", Slot = "10")]
		public void MPBHMBLFPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x38CAA20", Offset = "0x38C9E20", VA = "0x1838CAA20", Slot = "11")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x38CAA70", Offset = "0x38C9E70", VA = "0x1838CAA70")]
		private void PELCFOCODBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x38CA6A0", Offset = "0x38C9AA0", VA = "0x1838CA6A0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x38CA8F0", Offset = "0x38C9CF0", VA = "0x1838CA8F0", Slot = "8")]
		public ComponentSystemBase HGFLPEEDEPO(Type BKGBGEHNCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[AOJPGBJKDNL(typeof(MFJGLPLECEJ), new string[] { })]
public sealed class MJGBNHIFOGF : MFJGLPLECEJ, HPLECDDPLCA, HIJIFLANIAO, NGENPNOGFON, CJFEEGPLPHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class LAJHEGCIDDN : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8291E0", Offset = "0x8285E0", VA = "0x1808291E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x41948E0", Offset = "0x4193CE0", VA = "0x1841948E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x829280", Offset = "0x828680", VA = "0x180829280")]
		[DebuggerHidden]
		public LAJHEGCIDDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x41945D0", Offset = "0x41939D0", VA = "0x1841945D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x41948A0", Offset = "0x4193CA0", VA = "0x1841948A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x4194800", Offset = "0x4193C00", VA = "0x184194800", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x4194800", Offset = "0x4193C00", VA = "0x184194800", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[CPICBLLAMOM]
	private MPCADNMEKPJ FIJECBKDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly HHKDKJIEHJC FKKDEAJOEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Dictionary<string, JALDBOOAGKF> KLNPLPIBBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Dictionary<int, EFKIEBEBIKB> MLIJFDDHNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<AEOCECNOIKA> POKLHJPLHOO;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public EFKIEBEBIKB ELJBCLGDIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x3762F40", Offset = "0x3762340", VA = "0x183762F40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<AEOCECNOIKA> MCAKJJKOFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
	public void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3763BB0", Offset = "0x3762FB0", VA = "0x183763BB0", Slot = "8")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3763330", Offset = "0x3762730", VA = "0x183763330", Slot = "9")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3762EB0", Offset = "0x37622B0", VA = "0x183762EB0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x3763430", Offset = "0x3762830", VA = "0x183763430", Slot = "6")]
	public bool JNLOMPAFFLA(AEOCECNOIKA JGMFKPLFFDI, out EFKIEBEBIKB MLMPFJIEGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3762FA0", Offset = "0x37623A0", VA = "0x183762FA0")]
	private void FGNDHJIDOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x37639C0", Offset = "0x3762DC0", VA = "0x1837639C0")]
	private void OHHLKGPFJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3763960", Offset = "0x3762D60", VA = "0x183763960")]
	private JALDBOOAGKF NGHDEAHLGIF(string PFHEIIAHJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3762F40", Offset = "0x3762340", VA = "0x183762F40")]
	private JALDBOOAGKF JBCJDDKCCPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x37634C0", Offset = "0x37628C0", VA = "0x1837634C0")]
	private JALDBOOAGKF KPNEBLPEKDH(string PFHEIIAHJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3762D10", Offset = "0x3762110", VA = "0x183762D10")]
	private JALDBOOAGKF AOPOOJOECNJ(string NMGICKMLDFI, string JCHAGIDHJIB, [Optional] JALDBOOAGKF KNDPBECCJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3763810", Offset = "0x3762C10", VA = "0x183763810")]
	[IteratorStateMachine(typeof(LAJHEGCIDDN))]
	private IEnumerable<(string, string)> LEIIFFDFDMF(string PFHEIIAHJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3763910", Offset = "0x3762D10", VA = "0x183763910")]
	private bool MJMLKFFAHCN(AEOCECNOIKA JGMFKPLFFDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3763730", Offset = "0x3762B30", VA = "0x183763730")]
	private HHKDKJIEHJC LDODCGIAHLG(AEOCECNOIKA JGMFKPLFFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3763B60", Offset = "0x3762F60", VA = "0x183763B60")]
	private HHKDKJIEHJC OKJBPFMMGFP(AEOCECNOIKA JGMFKPLFFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3762E20", Offset = "0x3762220", VA = "0x183762E20")]
	private HHKDKJIEHJC BKGKGALBDML(AEOCECNOIKA JGMFKPLFFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2D87FB0", Offset = "0x2D873B0", VA = "0x182D87FB0")]
	private T AFFIJOBFBAD<T>(AEOCECNOIKA JGMFKPLFFDI) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3763350", Offset = "0x3762750", VA = "0x183763350")]
	private FieldInfo ILLLHGEJFAI(AEOCECNOIKA JGMFKPLFFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3763C10", Offset = "0x3763010", VA = "0x183763C10")]
	public MJGBNHIFOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3763880", Offset = "0x3762C80", VA = "0x183763880")]
	[CompilerGenerated]
	private int LJDEKOHEKNN(AEOCECNOIKA KEPOHMNFLGL, AEOCECNOIKA CFEKEMJOJGA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class JALDBOOAGKF : EFKIEBEBIKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly string EMPIKKGDIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly JALDBOOAGKF KNDPBECCJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly List<JALDBOOAGKF> ABIMKJOIKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly List<AEOCECNOIKA> FIJECBKDHDI;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string EOGNPHKDLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public EFKIEBEBIKB DFHILJHHMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<EFKIEBEBIKB> JACIFFFEGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<AEOCECNOIKA> JPDHPKBIGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F710", Offset = "0x3A6EB10", VA = "0x183A6F710")]
	public JALDBOOAGKF(string LBEPPIIBMPA, JALDBOOAGKF CNDFBGEJOLI)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[AOJPGBJKDNL(typeof(HADKCCFJPOA), new string[] { })]
	[APCINEIKDDA(typeof(HistoryService))]
	[NAPHGBOEKGO(GPIMBHHJLKL.History)]
	public class HistoryService : NGENPNOGFON, IDisposable, HADKCCFJPOA
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private enum DPCOOJMJOHO
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private readonly struct MJCMHHHOIBL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly DPCOOJMJOHO MODGDJDEHHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly HistoryService OCGDPJBGCPH;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x41954D0", Offset = "0x41948D0", VA = "0x1841954D0")]
			public MJCMHHHOIBL(HistoryService OCGDPJBGCPH, bool LMGKCENIKND, uint IIMAMIPIKFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x41954A0", Offset = "0x41948A0", VA = "0x1841954A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public class KJIHEEMJIBA
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct DOKLCJGKIJO : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private readonly KJIHEEMJIBA NGINFEJBBLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private readonly bool BDAIDAAAIFA;

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x418E140", Offset = "0x418D540", VA = "0x18418E140")]
				public DOKLCJGKIJO(KJIHEEMJIBA NGINFEJBBLB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x418E110", Offset = "0x418D510", VA = "0x18418E110", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct MGKDFFAGNBK : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private readonly KJIHEEMJIBA NGINFEJBBLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private readonly bool BDAIDAAAIFA;

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x4195460", Offset = "0x4194860", VA = "0x184195460")]
				public MGKDFFAGNBK(KJIHEEMJIBA NGINFEJBBLB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x418E110", Offset = "0x418D510", VA = "0x18418E110", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly HistoryService NLIOPACJONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private bool BIEGDEKHDFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int AAEHPEIMNKL;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x41942D0", Offset = "0x41936D0", VA = "0x1841942D0")]
			public KJIHEEMJIBA(HistoryService NLIOPACJONE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x4194250", Offset = "0x4193650", VA = "0x184194250")]
			public bool DCDEPHEOFGK(EHNBIOJHEAD LJGIOCJLACK, ODHBKAFBAFM IIMBCOAEFMJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x4194280", Offset = "0x4193680", VA = "0x184194280")]
			public MGKDFFAGNBK LIJFEGGFLKA()
			{
				return default(MGKDFFAGNBK);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x4194200", Offset = "0x4193600", VA = "0x184194200")]
			public DOKLCJGKIJO APLEFPJONHO()
			{
				return default(DOKLCJGKIJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class EFLPEEEBBFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public EFLPEEEBBFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x418EE40", Offset = "0x418E240", VA = "0x18418EE40")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class FLOHEAGFKGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public FLOHEAGFKGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x41901F0", Offset = "0x418F5F0", VA = "0x1841901F0")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class EEKPLDOPBHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public EEKPLDOPBHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x418EAB0", Offset = "0x418DEB0", VA = "0x18418EAB0")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly UndoAction GLOIHNBKNME;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly RedoAction NJMPCMHOJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private FEFKPPJKIMP ALOMLOLIGIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ActionBuffer BBJJHNPGIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ActionBuffer FIFNFNPCHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private CEELHAEJJEO GPLIHACOAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TransformOwnershipPhase OELDLPPDGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private PropertyChangeRouterService NPAHKJAMALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private IHEJJJCBDEN OAKKLNJCHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private DPCOOJMJOHO OIDLAJFCOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private KJIHEEMJIBA NGINFEJBBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private NEKHKMCAINI HJANMLILLMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private AECLLFLJBLC HAKMCAOCJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private ODHBKAFBAFM HAJMLGMJGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly GatherPropertiesForUndelete JOOPMJJPNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private uint MMEDIKPCOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private uint FBOOIBHIJDL;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private KJIHEEMJIBA JNLNJENHPBB
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x845B30", Offset = "0x844F30", VA = "0x180845B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool NLJCBNOJFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x3A6A5E0", Offset = "0x3A699E0", VA = "0x183A6A5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool BNMEHMOGJOC
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x3A69780", Offset = "0x3A68B80", VA = "0x183A69780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool LCGBGMNNGPH
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x3A6A660", Offset = "0x3A69A60", VA = "0x183A6A660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int CNKJDCEBEAG
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x3A6A850", Offset = "0x3A69C50", VA = "0x183A6A850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int FNHCADCDBIA
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3A69FE0", Offset = "0x3A693E0", VA = "0x183A69FE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool MMPCCMIGAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x3A6A690", Offset = "0x3A69A90", VA = "0x183A6A690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool HDAOMHILDOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x3A6A650", Offset = "0x3A69A50", VA = "0x183A6A650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool BNIEDHNOALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0xCF6440", Offset = "0xCF5840", VA = "0x180CF6440", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xCF6500", Offset = "0xCF5900", VA = "0x180CF6500", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer OJOFNKEJBMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x3A69820", Offset = "0x3A68C20", VA = "0x183A69820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action JGEGMGAKCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3A6A0A0", Offset = "0x3A694A0", VA = "0x183A6A0A0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x3A6A540", Offset = "0x3A69940", VA = "0x183A6A540", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action NPDFBIKINHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x3A69830", Offset = "0x3A68C30", VA = "0x183A69830")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x3A68980", Offset = "0x3A67D80", VA = "0x183A68980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A9F0", Offset = "0x3A69DF0", VA = "0x183A6A9F0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3A692A0", Offset = "0x3A686A0", VA = "0x183A692A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x3A68D90", Offset = "0x3A68190", VA = "0x183A68D90")]
		private void CHDLBLMHNHO(EHNBIOJHEAD LJGIOCJLACK, PHPODCGBPLJ MDLEIBAPHAH, bool AKKDGHGGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x3A6AF60", Offset = "0x3A6A360", VA = "0x183A6AF60")]
		private void PHBINGAIBNP(EHNBIOJHEAD LJGIOCJLACK, ODHBKAFBAFM IIMBCOAEFMJ, NICFNFKBPKA JDOPAPFIJME, NICFNFKBPKA OIOCGOCBAJE, bool AKKDGHGGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A280", Offset = "0x3A69680", VA = "0x183A6A280")]
		private void MIGIODBAEHC(EHNBIOJHEAD LJGIOCJLACK, bool AKKDGHGGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A020", Offset = "0x3A69420", VA = "0x183A6A020", Slot = "14")]
		public IDisposable LALHCMDEHBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x3A69990", Offset = "0x3A68D90", VA = "0x183A69990", Slot = "9")]
		public IDisposable HCEJMFEJOAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x3A698D0", Offset = "0x3A68CD0", VA = "0x183A698D0", Slot = "6")]
		public UndoAction GGOCJIFENDN()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x3A68CD0", Offset = "0x3A680D0", VA = "0x183A68CD0", Slot = "15")]
		public RedoAction BNGNIEKBIEE()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x3A68F70", Offset = "0x3A68370", VA = "0x183A68F70", Slot = "16")]
		public UndoAction DFHMPEFHPAM()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x3A68BB0", Offset = "0x3A67FB0", VA = "0x183A68BB0", Slot = "7")]
		public RedoAction BNGNIEKBIEE(UndoAction GMEHFCMOOAG)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x3A69030", Offset = "0x3A68430", VA = "0x183A69030", Slot = "8")]
		public UndoAction DFHMPEFHPAM(RedoAction GMEHFCMOOAG)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x3A68A80", Offset = "0x3A67E80", VA = "0x183A68A80")]
		public bool BGPPHMKNLGN(KFIGAFJEJFN DIDLFAHHCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x3A68AC0", Offset = "0x3A67EC0", VA = "0x183A68AC0", Slot = "17")]
		public void BIEFCABEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x3A699F0", Offset = "0x3A68DF0", VA = "0x183A699F0")]
		public void HMFOIELDBON(EHNBIOJHEAD LJGIOCJLACK, PHPODCGBPLJ MDLEIBAPHAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A140", Offset = "0x3A69540", VA = "0x183A6A140")]
		public void MGKDAJGMJKL(EHNBIOJHEAD LJGIOCJLACK, ODHBKAFBAFM IIMBCOAEFMJ, in NICFNFKBPKA OIOCGOCBAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x3A69B80", Offset = "0x3A68F80", VA = "0x183A69B80")]
		public void IIIFNMOKCCB(EHNBIOJHEAD LJGIOCJLACK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x3A68A40", Offset = "0x3A67E40", VA = "0x183A68A40")]
		private void BFICFHPLALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x3A68B70", Offset = "0x3A67F70", VA = "0x183A68B70")]
		private void BJJCPLKGJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x3A68A20", Offset = "0x3A67E20", VA = "0x183A68A20")]
		private void BECLCECCFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A8F0", Offset = "0x3A69CF0", VA = "0x183A6A8F0")]
		private AEMCHILHJCI OPOPMFHFIEL()
		{
			return default(AEMCHILHJCI);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x3A69D00", Offset = "0x3A69100", VA = "0x183A69D00")]
		private uint IILDOIHDEMP()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A000", Offset = "0x3A69400", VA = "0x183A6A000")]
		private bool KOFKDCFENBC(out AEMCHILHJCI EFFJGLADCMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A080", Offset = "0x3A69480", VA = "0x183A6A080")]
		private bool LOCHLNDPIDD(out AEMCHILHJCI EFFJGLADCMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x3A68B10", Offset = "0x3A67F10", VA = "0x183A68B10")]
		private RedoAction BJHHMEOBGCB(AEMCHILHJCI EFFJGLADCMH)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x3A68F10", Offset = "0x3A68310", VA = "0x183A68F10")]
		private UndoAction DAAACAEKNFF(AEMCHILHJCI EFFJGLADCMH)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x3A69D20", Offset = "0x3A69120", VA = "0x183A69D20")]
		private AEMCHILHJCI JHEJDDHEPGG(AEMCHILHJCI EFFJGLADCMH, ActionBuffer MFKKDPPPHON, bool LMGKCENIKND)
		{
			return default(AEMCHILHJCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3A696A0", Offset = "0x3A68AA0", VA = "0x183A696A0")]
		private void EOGNINJHGCH(Action EFFJGLADCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x3420A70", Offset = "0x341FE70", VA = "0x183420A70")]
		private T EOGNINJHGCH<T>(Func<T> EPHODGMEGPF)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A820", Offset = "0x3A69C20", VA = "0x183A6A820")]
		private MJCMHHHOIBL OCOGFBHNOEM(bool LMGKCENIKND, uint IIMAMIPIKFH)
		{
			return default(MJCMHHHOIBL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B060", Offset = "0x3A6A460", VA = "0x183A6B060")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x3A69150", Offset = "0x3A68550", VA = "0x183A69150")]
		[CompilerGenerated]
		private UndoAction DJHHNOJPMIM()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A6A0", Offset = "0x3A69AA0", VA = "0x183A6A6A0")]
		[CompilerGenerated]
		private RedoAction NOLEEKDJFNE()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x3A69540", Offset = "0x3A68940", VA = "0x183A69540")]
		[CompilerGenerated]
		private UndoAction EHHJMFLIIKB()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class PFFIGEKOCFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<byte> OGMMNHCCDJE;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int FKOLDOEAEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1698630", Offset = "0x1697A30", VA = "0x181698630")]
	public PFFIGEKOCFN(NativeArray<byte> OGMMNHCCDJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3774410", Offset = "0x3773810", VA = "0x183774410")]
	public static PFFIGEKOCFN ABLJGBEPCFM(NativeArray<byte> OGMMNHCCDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public T HKLHCEHKEJJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public NativeArray<T> NJNNIAHBAJE<T>(int DMFMCPNNNLJ, Allocator NDJJBKEIGCD) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public NativeArray<T> DBJIKJJPPEH<T>(Allocator NDJJBKEIGCD) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class DBFPOIBBLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<byte> OGMMNHCCDJE;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int FKOLDOEAEID
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x1698630", Offset = "0x1697A30", VA = "0x181698630")]
	public DBFPOIBBLIN(NativeArray<byte> OGMMNHCCDJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x37EA160", Offset = "0x37E9560", VA = "0x1837EA160")]
	public static DBFPOIBBLIN ABLJGBEPCFM(NativeArray<byte> OGMMNHCCDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x33E2C90", Offset = "0x33E2090", VA = "0x1833E2C90")]
	public T HKLHCEHKEJJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	public NativeArray<T> NJNNIAHBAJE<T>(int DMFMCPNNNLJ, Allocator NDJJBKEIGCD) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class DBANFAHCLJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<byte> OGMMNHCCDJE;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int FKOLDOEAEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x1698630", Offset = "0x1697A30", VA = "0x181698630")]
	public DBANFAHCLJK(NativeArray<byte> OGMMNHCCDJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x37EA100", Offset = "0x37E9500", VA = "0x1837EA100")]
	public static DBANFAHCLJK ABLJGBEPCFM(NativeArray<byte> OGMMNHCCDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x33E16F0", Offset = "0x33E0AF0", VA = "0x1833E16F0")]
	public void JLLLIBGNPNO<T>(in T FPLJCBGEJAP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x33E15F0", Offset = "0x33E09F0", VA = "0x1833E15F0")]
	public void BJNDAHDENBM<T>(NativeArray<T> KEPPKNDIOGA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	public void BDGFKNDNIKK<T>(NativeArray<T> FPLJCBGEJAP) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class MBEBOMGHALM
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x3762430", Offset = "0x3761830", VA = "0x183762430")]
	public static Span<byte> NFFKKEJLJNP(this NativeArray<byte> OGMMNHCCDJE)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x37622B0", Offset = "0x37616B0", VA = "0x1837622B0")]
	public static ReadOnlySpan<byte> MPDDIMFFKPF(this NativeArray<byte> OGMMNHCCDJE)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x3762230", Offset = "0x3761630", VA = "0x183762230")]
	public static NativeArray<byte> HOEPDPACMPA(this NativeArray<byte> OGMMNHCCDJE, int GJOFJPHNEOA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x37620C0", Offset = "0x37614C0", VA = "0x1837620C0")]
	public static NativeArray<byte> ACOKICFABNM(this NativeArray<byte> OGMMNHCCDJE, int NDNADCNCIGM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A350", Offset = "0x2D79750", VA = "0x182D7A350")]
	public static NativeArray<byte> ACOKICFABNM<T>(this NativeArray<byte> OGMMNHCCDJE, int NDNADCNCIGM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3762140", Offset = "0x3761540", VA = "0x183762140")]
	public static NativeArray<byte> AJPKEPIMOJB(this NativeArray<byte> OGMMNHCCDJE, int NDNADCNCIGM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A3B0", Offset = "0x2D797B0", VA = "0x182D7A3B0")]
	public static NativeArray<byte> AJPKEPIMOJB<T>(this NativeArray<byte> OGMMNHCCDJE, int NDNADCNCIGM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x37621B0", Offset = "0x37615B0", VA = "0x1837621B0")]
	public static NativeArray<byte> GHKMEMFPGDG(this NativeArray<byte> OGMMNHCCDJE, int NDNADCNCIGM = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A410", Offset = "0x2D79810", VA = "0x182D7A410")]
	public static NativeArray<byte> GHKMEMFPGDG<T>(this NativeArray<byte> OGMMNHCCDJE, int NDNADCNCIGM = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GPMGAAOCLDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeList<byte> JOLFKOMKBCI;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x1698630", Offset = "0x1697A30", VA = "0x181698630")]
	public GPMGAAOCLDJ(NativeList<byte> JOLFKOMKBCI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3A656D0", Offset = "0x3A64AD0", VA = "0x183A656D0")]
	public static GPMGAAOCLDJ ABLJGBEPCFM(NativeList<byte> OGMMNHCCDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	public void JLLLIBGNPNO<T>(in T FPLJCBGEJAP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	public void BJNDAHDENBM<T>(NativeArray<T> FPLJCBGEJAP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	public void BDGFKNDNIKK<T>(NativeArray<T> FPLJCBGEJAP) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[AOJPGBJKDNL(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.PropertyChanges)]
	public class PropertyChangeNetworkRouter : HIJIFLANIAO, NGENPNOGFON, HOINKPMEBEF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[CPICBLLAMOM]
		private GCGHMPOBOEF CDLKNDDFOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[CPICBLLAMOM]
		private IBKMFFMCCLE FIJECBKDHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[CPICBLLAMOM]
		private KFHNJEDPGGK EHBDCHANGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[CPICBLLAMOM]
		private PropertyChangeRouterService NPAHKJAMALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private FEFKPPJKIMP OGHKGHLKPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private PFCBHMAPOIF CDGOIMCHAOJ;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public FEFKPPJKIMP MHHFDCBLJBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x377C780", Offset = "0x377BB80", VA = "0x18377C780")]
		public FEFKPPJKIMP.CPFJGLKGDCE CDKOPGOLFNP()
		{
			return default(FEFKPPJKIMP.CPFJGLKGDCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x377CF50", Offset = "0x377C350", VA = "0x18377CF50", Slot = "4")]
		public void MPBHMBLFPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x377D100", Offset = "0x377C500", VA = "0x18377D100", Slot = "5")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x377CAF0", Offset = "0x377BEF0", VA = "0x18377CAF0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x377CD10", Offset = "0x377C110", VA = "0x18377CD10")]
		public void GGOCJIFENDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x377C6F0", Offset = "0x377BAF0", VA = "0x18377C6F0")]
		public void BIEFCABEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x377CF00", Offset = "0x377C300", VA = "0x18377CF00")]
		private void MJFHHGHBOGG(EHNBIOJHEAD LJGIOCJLACK, PHPODCGBPLJ MDLEIBAPHAH, bool AKKDGHGGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x377C740", Offset = "0x377BB40", VA = "0x18377C740")]
		private void CBEMPJBIDOD(EHNBIOJHEAD LJGIOCJLACK, ODHBKAFBAFM IIMBCOAEFMJ, NICFNFKBPKA JDOPAPFIJME, NICFNFKBPKA OIOCGOCBAJE, bool AKKDGHGGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x377C710", Offset = "0x377BB10", VA = "0x18377C710")]
		private void BLFLGDGOFJA(EHNBIOJHEAD LJGIOCJLACK, bool AKKDGHGGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x377C7A0", Offset = "0x377BBA0", VA = "0x18377C7A0")]
		private void CEMGMPHJHOF(PFCBHMAPOIF HNJNABPJHCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x377CFB0", Offset = "0x377C3B0", VA = "0x18377CFB0")]
		private void NBPPHIIHMFM(PFCBHMAPOIF HNJNABPJHCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x377CE40", Offset = "0x377C240", VA = "0x18377CE40")]
		private void KDBHFIBDJCK(PFCBHMAPOIF HNJNABPJHCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x377CF30", Offset = "0x377C330", VA = "0x18377CF30")]
		private void MMEJEMFEJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x377CE20", Offset = "0x377C220", VA = "0x18377CE20")]
		private void HJABNMJHPCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x377C600", Offset = "0x377BA00", VA = "0x18377C600")]
		private void BEHMCHBHCNB(PFCBHMAPOIF HNJNABPJHCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4243540", Offset = "0x4242940", VA = "0x184243540", Slot = "6")]
		private void HLBIHONCELH<TKey, T>(global::GBIJOAKACLC<TKey, T> JGMFKPLFFDI, object OEGBAMNPENI) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[NAPHGBOEKGO(GPIMBHHJLKL.History)]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[AOJPGBJKDNL(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate void KGEOHAKODGE(EHNBIOJHEAD LJGIOCJLACK, PHPODCGBPLJ MDLEIBAPHAH, bool AKKDGHGGDLL);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate void JJMCEPHFFJB(EHNBIOJHEAD LJGIOCJLACK, ODHBKAFBAFM IIMBCOAEFMJ, NICFNFKBPKA JDOPAPFIJME, NICFNFKBPKA OIOCGOCBAJE, bool AKKDGHGGDLL);

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public delegate void ADBMEKMJMDJ(EHNBIOJHEAD LJGIOCJLACK, bool AKKDGHGGDLL);

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public KGEOHAKODGE PELCFOCODBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public JJMCEPHFFJB IJNHELLAADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public ADBMEKMJMDJ FBEHGKKMCPK;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x377D3D0", Offset = "0x377C7D0", VA = "0x18377D3D0")]
		public void HMFOIELDBON(EHNBIOJHEAD LJGIOCJLACK, PHPODCGBPLJ MDLEIBAPHAH, bool AKKDGHGGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x377D410", Offset = "0x377C810", VA = "0x18377D410")]
		public void MGKDAJGMJKL(EHNBIOJHEAD LJGIOCJLACK, ODHBKAFBAFM IIMBCOAEFMJ, in NICFNFKBPKA JDOPAPFIJME, in NICFNFKBPKA OIOCGOCBAJE, bool AKKDGHGGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x377D3F0", Offset = "0x377C7F0", VA = "0x18377D3F0")]
		public void IIIFNMOKCCB(EHNBIOJHEAD LJGIOCJLACK, bool AKKDGHGGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DebuggerTypeProxy(typeof(EMHJPFGICIJ))]
	[NAPHGBOEKGO(GPIMBHHJLKL.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		internal class EMHJPFGICIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private readonly ActionBuffer DGPBECDNOKK;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public int HMGCLIBMMBB
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x38AD580", Offset = "0x38AC980", VA = "0x1838AD580")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public FKFHKOCALKC[] HDCGLCLKPFA
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x38AD5D0", Offset = "0x38AC9D0", VA = "0x1838AD5D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
			public EMHJPFGICIJ(ActionBuffer ADFBKCJJNED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x38AD6A0", Offset = "0x38ACAA0", VA = "0x1838AD6A0")]
			[CompilerGenerated]
			private FKFHKOCALKC OPIOOOPPHDI(AEMCHILHJCI EFFJGLADCMH)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		internal class FKFHKOCALKC : HOINKPMEBEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private readonly ActionBuffer DGPBECDNOKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly AEMCHILHJCI EFFJGLADCMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private List<(PFCBHMAPOIF, string, object)> HIAJLBHGCPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private DBFPOIBBLIN LGIEPMOBDDP;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public int HMGCLIBMMBB
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0x38AD790", Offset = "0x38ACB90", VA = "0x1838AD790")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(PFCBHMAPOIF, string, object)> MLEOKMOCBGH
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x38ADC20", Offset = "0x38AD020", VA = "0x1838ADC20")]
			public FKFHKOCALKC(ActionBuffer ADFBKCJJNED, AEMCHILHJCI EFFJGLADCMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x38ADB20", Offset = "0x38ACF20", VA = "0x1838ADB20")]
			private string LBDCFLMFOKA(PFCBHMAPOIF CDGOIMCHAOJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x38AD7E0", Offset = "0x38ACBE0", VA = "0x1838AD7E0")]
			private void HCLJCDJPJCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x365D170", Offset = "0x365C570", VA = "0x18365D170", Slot = "4")]
			public void ALDFGEDDDND<TKey, T>(global::GBIJOAKACLC<TKey, T> JGMFKPLFFDI, [Optional] object OEGBAMNPENI) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NativeList<byte> NACBGCCHDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Stack<AEMCHILHJCI> BIHAJHKODKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly HKAHLLDFPMP GPFFOAJCOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly NEKHKMCAINI HJANMLILLMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly IBKMFFMCCLE FIJECBKDHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly bool MNGCIEEPJIG;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public ALPOBGEBAJB HMAPMKOECOA
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x37D5E70", Offset = "0x37D5270", VA = "0x1837D5E70")]
			get
			{
				return default(ALPOBGEBAJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int HMGCLIBMMBB
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x37D5D30", Offset = "0x37D5130", VA = "0x1837D5D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x37D67F0", Offset = "0x37D5BF0", VA = "0x1837D67F0")]
		public ActionBuffer(NEKHKMCAINI HJANMLILLMC, IBKMFFMCCLE FIJECBKDHDI, bool MNGCIEEPJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x37D6630", Offset = "0x37D5A30", VA = "0x1837D6630")]
		public bool KKJHGFHFBLG(out AEMCHILHJCI EFFJGLADCMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x37D5CC0", Offset = "0x37D50C0", VA = "0x1837D5CC0")]
		public void BIEFCABEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x37D6230", Offset = "0x37D5630", VA = "0x1837D6230")]
		public AEMCHILHJCI GGOCJIFENDN(EDHAHFOJIGG HIAJLBHGCPF, IHEJJJCBDEN OAKKLNJCHEA, uint BHKNBPAPJHF)
		{
			return default(AEMCHILHJCI);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x37D5D70", Offset = "0x37D5170", VA = "0x1837D5D70")]
		public bool DHBBCEAIDOO(uint BHKNBPAPJHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x37D5AD0", Offset = "0x37D4ED0", VA = "0x1837D5AD0")]
		public bool ANLEEOIDKHD(uint BHKNBPAPJHF, out AEMCHILHJCI GMEHFCMOOAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x37D64C0", Offset = "0x37D58C0", VA = "0x1837D64C0")]
		public void KFBLPNNNKOA(AEMCHILHJCI GMEHFCMOOAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x37D5EB0", Offset = "0x37D52B0", VA = "0x1837D5EB0")]
		[Conditional("DEBUG_BUILD")]
		private void FEGKKHIMONI(AEMCHILHJCI GMEHFCMOOAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x37D6370", Offset = "0x37D5770", VA = "0x1837D6370")]
		private void JHEJDDHEPGG(AEMCHILHJCI EDIHJHCNDNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x37D5FF0", Offset = "0x37D53F0", VA = "0x1837D5FF0")]
		private void GALBLDEPLHO(DBFPOIBBLIN HJOBDDHCGNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x37D5E10", Offset = "0x37D5210", VA = "0x1837D5E10")]
		private void EBMILDLEFDC(AEMCHILHJCI EFFJGLADCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x37D66C0", Offset = "0x37D5AC0", VA = "0x1837D66C0")]
		private DBFPOIBBLIN OGDFFCIMFLO(AEMCHILHJCI EFFJGLADCMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x37D5DA0", Offset = "0x37D51A0", VA = "0x1837D5DA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class HKAHLLDFPMP : HOINKPMEBEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly NEKHKMCAINI HJANMLILLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly IBKMFFMCCLE FIJECBKDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private EHNBIOJHEAD LJGIOCJLACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private DBFPOIBBLIN DMNOFMAMPMJ;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x77E010", Offset = "0x77D410", VA = "0x18077E010")]
	public HKAHLLDFPMP(NEKHKMCAINI HJANMLILLMC, IBKMFFMCCLE FIJECBKDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2DD05B0", Offset = "0x2DCF9B0", VA = "0x182DD05B0", Slot = "4")]
	public void ALDFGEDDDND<TKey, T>(global::GBIJOAKACLC<TKey, T> MMHPKJEEDDA, [Optional] object OEGBAMNPENI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x3A685D0", Offset = "0x3A679D0", VA = "0x183A685D0")]
	public void MNOJECLHCBE(PFCBHMAPOIF CDGOIMCHAOJ, ref DBFPOIBBLIN HJOBDDHCGNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class FEFKPPJKIMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct CPFJGLKGDCE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly FEFKPPJKIMP CNDFBGEJOLI;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x418D520", Offset = "0x418C920", VA = "0x18418D520")]
		public CPFJGLKGDCE(FEFKPPJKIMP CNDFBGEJOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x418D500", Offset = "0x418C900", VA = "0x18418D500", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	protected EDHAHFOJIGG HIAJLBHGCPF;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public EDHAHFOJIGG MLEOKMOCBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A609D0", Offset = "0x3A5FDD0", VA = "0x183A609D0")]
		get
		{
			return default(EDHAHFOJIGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool FIOFIHFOBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x3A60A60", Offset = "0x3A5FE60", VA = "0x183A60A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A60ED0", Offset = "0x3A602D0", VA = "0x183A60ED0")]
	public FEFKPPJKIMP(EDHAHFOJIGG.JMKJGMBEMIP MCODHIJIBHD = EDHAHFOJIGG.JMKJGMBEMIP.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A60A10", Offset = "0x3A5FE10", VA = "0x183A60A10")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A60B70", Offset = "0x3A5FF70", VA = "0x183A60B70")]
	public void HMFOIELDBON(EHNBIOJHEAD LJGIOCJLACK, PHPODCGBPLJ MDLEIBAPHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A60D40", Offset = "0x3A60140", VA = "0x183A60D40")]
	public void MGKDAJGMJKL(EHNBIOJHEAD LJGIOCJLACK, ODHBKAFBAFM IIMBCOAEFMJ, in NICFNFKBPKA OIOCGOCBAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A60C60", Offset = "0x3A60060", VA = "0x183A60C60")]
	public void IIIFNMOKCCB(EHNBIOJHEAD LJGIOCJLACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A60DD0", Offset = "0x3A601D0", VA = "0x183A60DD0")]
	public void MMEJEMFEJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A60A70", Offset = "0x3A5FE70", VA = "0x183A60A70")]
	public void HJABNMJHPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A60A50", Offset = "0x3A5FE50", VA = "0x183A60A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A60A20", Offset = "0x3A5FE20", VA = "0x183A60A20")]
	public CPFJGLKGDCE CDKOPGOLFNP()
	{
		return default(CPFJGLKGDCE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct PFCBHMAPOIF : IComparable<PFCBHMAPOIF>, IEquatable<PFCBHMAPOIF>
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly PFCBHMAPOIF CCAIINGOJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public EHNBIOJHEAD LJGIOCJLACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public ODHBKAFBAFM IIMBCOAEFMJ;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool NFDBEOJPGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x32E0BE0", Offset = "0x32DFFE0", VA = "0x1832E0BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x817230", Offset = "0x816630", VA = "0x180817230")]
	public PFCBHMAPOIF(EHNBIOJHEAD LJGIOCJLACK, ODHBKAFBAFM IIMBCOAEFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x37742B0", Offset = "0x37736B0", VA = "0x1837742B0")]
	public void MGNKEOAOBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x3774140", Offset = "0x3773540", VA = "0x183774140", Slot = "4")]
	public int CompareTo(PFCBHMAPOIF FJLHJLAMLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x3774350", Offset = "0x3773750", VA = "0x183774350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3774180", Offset = "0x3773580", VA = "0x183774180", Slot = "0")]
	public override bool Equals(object JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3774220", Offset = "0x3773620", VA = "0x183774220", Slot = "5")]
	public bool Equals(PFCBHMAPOIF FJLHJLAMLMA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x37742C0", Offset = "0x37736C0", VA = "0x1837742C0")]
	public static bool OACFLELFBPC(PFCBHMAPOIF BEOAJHMDOLI, PFCBHMAPOIF CEKIIBILJFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3774300", Offset = "0x3773700", VA = "0x183774300")]
	public static bool OFLJMIEJHAG(PFCBHMAPOIF BEOAJHMDOLI, PFCBHMAPOIF CEKIIBILJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3774270", Offset = "0x3773670", VA = "0x183774270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[NAPHGBOEKGO(GPIMBHHJLKL.History)]
	public class GatherPropertiesForUndelete : FCIMDOPELEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private NEKHKMCAINI HJANMLILLMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private EHNBIOJHEAD LJGIOCJLACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HistoryService NLIOPACJONE;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A65730", Offset = "0x3A64B30", VA = "0x183A65730")]
		public void HMMDEFHEDAE(EHNBIOJHEAD LJGIOCJLACK, NEKHKMCAINI HJANMLILLMC, HistoryService NLIOPACJONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A65840", Offset = "0x3A64C40", VA = "0x183A65840", Slot = "4")]
		private void KDEEFJLMPJE(BKHPPMHLABI JGMFKPLFFDI, in NICFNFKBPKA FPLJCBGEJAP, object OEGBAMNPENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class LNNHMOBANCG
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x3761470", Offset = "0x3760870", VA = "0x183761470")]
	public static void NBPPHIIHMFM(EDHAHFOJIGG HIAJLBHGCPF, PFCBHMAPOIF CDGOIMCHAOJ, PHPODCGBPLJ MDLEIBAPHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x37613B0", Offset = "0x37607B0", VA = "0x1837613B0")]
	public static void MPLFCKCGDHL(EDHAHFOJIGG HIAJLBHGCPF, PFCBHMAPOIF CDGOIMCHAOJ, in NICFNFKBPKA OIOCGOCBAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3761360", Offset = "0x3760760", VA = "0x183761360")]
	public static void KDBHFIBDJCK(EDHAHFOJIGG HIAJLBHGCPF, PFCBHMAPOIF CDGOIMCHAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x37612B0", Offset = "0x37606B0", VA = "0x1837612B0")]
	public static void KAPOGKFDCFB(EDHAHFOJIGG HIAJLBHGCPF, PFCBHMAPOIF CDGOIMCHAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3761570", Offset = "0x3760970", VA = "0x183761570")]
	public static PHPODCGBPLJ OGFBCCMEPMJ(EDHAHFOJIGG HIAJLBHGCPF, PFCBHMAPOIF CDGOIMCHAOJ)
	{
		return default(PHPODCGBPLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2970D40", Offset = "0x2970140", VA = "0x182970D40")]
	public static T DFJJCMGHDPC<T>(EDHAHFOJIGG HIAJLBHGCPF, PFCBHMAPOIF CDGOIMCHAOJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2970D10", Offset = "0x2970110", VA = "0x182970D10")]
	public static T DFJJCMGHDPC<T>(ref DBFPOIBBLIN MPEBBGJJODN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x37615C0", Offset = "0x37609C0", VA = "0x1837615C0")]
	public static PHPODCGBPLJ OGFBCCMEPMJ(ref DBFPOIBBLIN MPEBBGJJODN)
	{
		return default(PHPODCGBPLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct EDHAHFOJIGG : IEnumerable<PFCBHMAPOIF>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum JMKJGMBEMIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct BJNHOHBBLPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly EDHAHFOJIGG JOLFKOMKBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly IHEJJJCBDEN OAKKLNJCHEA;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x418BA60", Offset = "0x418AE60", VA = "0x18418BA60")]
		public BJNHOHBBLPO(EDHAHFOJIGG JOLFKOMKBCI, IHEJJJCBDEN OAKKLNJCHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x418B480", Offset = "0x418A880", VA = "0x18418B480")]
		public void JFMFEKHLOCO(NativeList<byte> LBMMCNGMDLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x418B240", Offset = "0x418A640", VA = "0x18418B240")]
		private void GFKPPIKIFHL(PFCBHMAPOIF CDGOIMCHAOJ, ref DBANFAHCLJK IPBPMPMEKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x418B3F0", Offset = "0x418A7F0", VA = "0x18418B3F0")]
		private void IKEEMFNDOPK(PFCBHMAPOIF CDGOIMCHAOJ, ref DBANFAHCLJK IPBPMPMEKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x418B150", Offset = "0x418A550", VA = "0x18418B150")]
		private NativeArray<byte> FANANMOMNAG(NativeList<byte> LBMMCNGMDLI)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x418B720", Offset = "0x418AB20", VA = "0x18418B720")]
		private NativeArray<byte> MJLEOJEPKCL(NativeList<byte> LBMMCNGMDLI, int DMFMCPNNNLJ)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x418B810", Offset = "0x418AC10", VA = "0x18418B810")]
		private int OADELFBPOLF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x418B290", Offset = "0x418A690", VA = "0x18418B290")]
		private bool IDPJHMICJIJ(PFCBHMAPOIF CDGOIMCHAOJ, out NativeArray<byte> CLGFFLOAMEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct GPHJEEMLEEI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeList<byte> MPEBBGJJODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private EDHAHFOJIGG JOLFKOMKBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly PFCBHMAPOIF HNJNABPJHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly int GJOFJPHNEOA;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x41910D0", Offset = "0x41904D0", VA = "0x1841910D0")]
		internal GPHJEEMLEEI(EDHAHFOJIGG JOLFKOMKBCI, PFCBHMAPOIF HNJNABPJHCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x4190EB0", Offset = "0x41902B0", VA = "0x184190EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x4190EE0", Offset = "0x41902E0", VA = "0x184190EE0")]
		public void HMPGKPEEBEN(NativeArray<byte> FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x4190E50", Offset = "0x4190250", VA = "0x184190E50")]
		public void CAOGLMLAFAE(NativeArray<byte> FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x4190F40", Offset = "0x4190340", VA = "0x184190F40")]
		public void IKEEMFNDOPK(in NICFNFKBPKA FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x3665A60", Offset = "0x3664E60", VA = "0x183665A60")]
		public void IKEEMFNDOPK<T>(T FPLJCBGEJAP) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x4191060", Offset = "0x4190460", VA = "0x184191060")]
		private void MJHGJLOOBJO(int FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x4190FB0", Offset = "0x41903B0", VA = "0x184190FB0")]
		private void MJHGJLOOBJO(in NICFNFKBPKA FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x4190F50", Offset = "0x4190350", VA = "0x184190F50")]
		private unsafe void MJHGJLOOBJO(void* BKKJCFDOCIA, int DMFMCPNNNLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x4190EE0", Offset = "0x41902E0", VA = "0x184190EE0")]
		private void MJHGJLOOBJO(NativeArray<byte> KEPPKNDIOGA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct NIGKMDDPJMC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private EDHAHFOJIGG JOLFKOMKBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<byte> MPEBBGJJODN;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x4195B10", Offset = "0x4194F10", VA = "0x184195B10")]
		internal NIGKMDDPJMC(EDHAHFOJIGG JOLFKOMKBCI, NativeArray<byte> MPEBBGJJODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x4195940", Offset = "0x4194D40", VA = "0x184195940", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x4195A50", Offset = "0x4194E50", VA = "0x184195A50")]
		public NativeArray<byte> NJNNIAHBAJE(int DMFMCPNNNLJ)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x4195850", Offset = "0x4194C50", VA = "0x184195850")]
		public NativeArray<byte> DBJIKJJPPEH()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x366AB30", Offset = "0x3669F30", VA = "0x18366AB30")]
		public T HKLHCEHKEJJ<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x4195950", Offset = "0x4194D50", VA = "0x184195950")]
		public void HKLHCEHKEJJ(in IPEAPPMEIFD FPLJCBGEJAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct NGJKEBFPDFL : IEnumerator<PFCBHMAPOIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly NativeList<PFCBHMAPOIF> OGMMNHCCDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int GABJOMFFJAI;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public PFCBHMAPOIF HMAPMKOECOA
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x41956C0", Offset = "0x4194AC0", VA = "0x1841956C0", Slot = "4")]
			get
			{
				return default(PFCBHMAPOIF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x4195680", Offset = "0x4194A80", VA = "0x184195680", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6AA0", Offset = "0x3AE5EA0", VA = "0x183AE6AA0")]
		internal NGJKEBFPDFL(NativeList<PFCBHMAPOIF> KEPPKNDIOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x4195540", Offset = "0x4194940", VA = "0x184195540", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x4195640", Offset = "0x4194A40", VA = "0x184195640", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct IJBLOPFKICH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int CEKEGLLDNHE = 0;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int ALNBMEFGJDK = 1;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int EOLPMJLBOBG = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NativeArray<int> MPEBBGJJODN;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool OGKFMAGAFDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x4191D70", Offset = "0x4191170", VA = "0x184191D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int JLCFBGHBGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x4191E90", Offset = "0x4191290", VA = "0x184191E90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x4191DF0", Offset = "0x41911F0", VA = "0x184191DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public JMKJGMBEMIP CPNDCMMNPFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x4191E50", Offset = "0x4191250", VA = "0x184191E50")]
			get
			{
				return default(JMKJGMBEMIP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x4191E80", Offset = "0x4191280", VA = "0x184191E80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool FIOFIHFOBFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x4191E40", Offset = "0x4191240", VA = "0x184191E40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x4191E60", Offset = "0x4191260", VA = "0x184191E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool FLBPMDCLBLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x4191EF0", Offset = "0x41912F0", VA = "0x184191EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x4191ED0", Offset = "0x41912D0", VA = "0x184191ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x4191F00", Offset = "0x4191300", VA = "0x184191F00")]
		public IJBLOPFKICH(JMKJGMBEMIP MCODHIJIBHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x4191EA0", Offset = "0x41912A0", VA = "0x184191EA0")]
		private int PEBNPJONHNJ(int BPNKPMGDGFM, int OKILMEFLKKF = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x4191DB0", Offset = "0x41911B0", VA = "0x184191DB0")]
		private void CODPHMBGNGD(int BPNKPMGDGFM, int FPLJCBGEJAP, int OKILMEFLKKF = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x4191E00", Offset = "0x4191200", VA = "0x184191E00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private const int JIJOOOLJIIN = -1;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private const int EHKGBBHEGPJ = 0;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly PFCBHMAPOIF INDOAMNDOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeHashMap<PFCBHMAPOIF, int> GEDOFBFAJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NativeList<PFCBHMAPOIF> HIAJLBHGCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NativeList<int> ONMOALCFJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NativeList<byte> DOHPGANHAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private NativeList<byte> MPEBBGJJODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private IJBLOPFKICH PEEIAPNNFMK;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FIOFIHFOBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x3A57C70", Offset = "0x3A57070", VA = "0x183A57C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool PJJPNMNAOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A57F80", Offset = "0x3A57380", VA = "0x183A57F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int JLCFBGHBGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A582D0", Offset = "0x3A576D0", VA = "0x183A582D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int CONONIEILAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A57B50", Offset = "0x3A56F50", VA = "0x183A57B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool OGKFMAGAFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3A57990", Offset = "0x3A56D90", VA = "0x183A57990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A58370", Offset = "0x3A57770", VA = "0x183A58370")]
	public static EDHAHFOJIGG PELCFOCODBC(JMKJGMBEMIP MCODHIJIBHD = JMKJGMBEMIP.Last, int MJDGAHEAMIG = 16, int MJCFBFFJBDH = 256)
	{
		return default(EDHAHFOJIGG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A584B0", Offset = "0x3A578B0", VA = "0x183A584B0")]
	private EDHAHFOJIGG(JMKJGMBEMIP MCODHIJIBHD, int MJDGAHEAMIG, int MJCFBFFJBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A57B90", Offset = "0x3A56F90", VA = "0x183A57B90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A57AC0", Offset = "0x3A56EC0", VA = "0x183A57AC0")]
	public GPHJEEMLEEI CEMGMPHJHOF(PFCBHMAPOIF HNJNABPJHCC)
	{
		return default(GPHJEEMLEEI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A582E0", Offset = "0x3A576E0", VA = "0x183A582E0")]
	public NIGKMDDPJMC ODEMNOKEHJC(PFCBHMAPOIF HNJNABPJHCC)
	{
		return default(NIGKMDDPJMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A57FF0", Offset = "0x3A573F0", VA = "0x183A57FF0")]
	public bool LCJIMNCGLJO(PFCBHMAPOIF HNJNABPJHCC, out NIGKMDDPJMC AKCKMDEOLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A57FA0", Offset = "0x3A573A0", VA = "0x183A57FA0")]
	public bool KMAPKIMAIKB(PFCBHMAPOIF HNJNABPJHCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A57C80", Offset = "0x3A57080", VA = "0x183A57C80")]
	public bool FKAMKNPGJKP(PFCBHMAPOIF HNJNABPJHCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A579D0", Offset = "0x3A56DD0", VA = "0x183A579D0")]
	public void BONGKGGCIID(NativeList<byte> LBMMCNGMDLI, IHEJJJCBDEN OAKKLNJCHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x33F23D0", Offset = "0x33F17D0", VA = "0x1833F23D0")]
	public T ECDBBAKEJAB<T>(PFCBHMAPOIF HNJNABPJHCC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A577C0", Offset = "0x3A56BC0", VA = "0x183A577C0")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A57F40", Offset = "0x3A57340", VA = "0x183A57F40")]
	public NGJKEBFPDFL IINGNKPPFJF()
	{
		return default(NGJKEBFPDFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A57D50", Offset = "0x3A57150", VA = "0x183A57D50")]
	private void FNIJBIIPFHM(PFCBHMAPOIF HNJNABPJHCC, int GJOFJPHNEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A581E0", Offset = "0x3A575E0", VA = "0x183A581E0")]
	private void MGNKEOAOBAH(int OLLBKGIPIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A578A0", Offset = "0x3A56CA0", VA = "0x183A578A0")]
	private void BINOAALFHJH(PFCBHMAPOIF HNJNABPJHCC, int GJOFJPHNEOA, int DMFMCPNNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x33F2350", Offset = "0x33F1750", VA = "0x1833F2350")]
	private static T ECDBBAKEJAB<T>(NativeArray<byte> OGMMNHCCDJE, int BPNKPMGDGFM = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x3A583F0", Offset = "0x3A577F0", VA = "0x183A583F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x3A583B0", Offset = "0x3A577B0", VA = "0x183A583B0", Slot = "4")]
	private IEnumerator<PFCBHMAPOIF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class EBAEEJCAPIJ<T> : FNIOMAHLONI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private EntityQuery FDOFAODBNNC;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3B60", Offset = "0x3AD2F60", VA = "0x183AD3B60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3C80", Offset = "0x3AD3080", VA = "0x183AD3C80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x396C330", Offset = "0x396B730", VA = "0x18396C330")]
	public EBAEEJCAPIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x25390D0", Offset = "0x25384D0", VA = "0x1825390D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	internal class CleanupRigidbodyExImpl : FNIOMAHLONI
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private EntityQuery FDOFAODBNNC;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x37E0280", Offset = "0x37DF680", VA = "0x1837E0280", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x37E0320", Offset = "0x37DF720", VA = "0x1837E0320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[Preserve]
internal class KDJBOLBMABE : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private EntityQuery BEAMBLCAMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x3A71DF0", Offset = "0x3A711F0", VA = "0x183A71DF0", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x3A71D20", Offset = "0x3A71120", VA = "0x183A71D20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x3A71DB0", Offset = "0x3A711B0", VA = "0x183A71DB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public KDJBOLBMABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
internal class GKKBJKBFCLO : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private PropertyDiffStateService JHCNJJPPIOO;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x3A647E0", Offset = "0x3A63BE0", VA = "0x183A647E0", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x3A647C0", Offset = "0x3A63BC0", VA = "0x183A647C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public GKKBJKBFCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EntityQuery FDOFAODBNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private SceneService POMGNNIENEK;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x3A57320", Offset = "0x3A56720", VA = "0x183A57320", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x3A56E70", Offset = "0x3A56270", VA = "0x183A56E70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x3A56F00", Offset = "0x3A56300", VA = "0x183A56F00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
	[AOJPGBJKDNL(typeof(CullingBandService), new string[] { })]
	public class CullingBandService : NGENPNOGFON, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<NativeListAsync<HNJGDEFJBEJ>> DIGHIDCMLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA PEPLIFOGJAA;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x37E98C0", Offset = "0x37E8CC0", VA = "0x1837E98C0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x37E9850", Offset = "0x37E8C50", VA = "0x1837E9850")]
		public void IILKEDFPCAE(NativeListAsync<HNJGDEFJBEJ> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x37E93E0", Offset = "0x37E87E0", VA = "0x1837E93E0")]
		public void HPCMNFBOMCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x37E9270", Offset = "0x37E8670", VA = "0x1837E9270", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x37E9960", Offset = "0x37E8D60", VA = "0x1837E9960")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[AOJPGBJKDNL(typeof(EBHDABDPCJI), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	public class PhysicsService : NGENPNOGFON, CJFEEGPLPHA, EBHDABDPCJI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly BBHAOFNBCPD DALNHNBGDJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EntityManager BOGIEIBMFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private CBGJJCKMFCA LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private FJEGFCLMACC HJDKMBAHACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PropertyEventCallbacksService ODEGAHCHELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private global::NBILNGMPECD<CNMJOKONFPK> IEILKCOCDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<KJNCFICFIIE, CNMJOKONFPK> OHLDCBPFDCN
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x3779E60", Offset = "0x3779260", VA = "0x183779E60", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x3779A50", Offset = "0x3778E50", VA = "0x183779A50", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x3779F00", Offset = "0x3779300", VA = "0x183779F00", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x3779BC0", Offset = "0x3778FC0", VA = "0x183779BC0", Slot = "5")]
		public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x37798F0", Offset = "0x3778CF0", VA = "0x1837798F0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x3779AF0", Offset = "0x3778EF0", VA = "0x183779AF0", Slot = "8")]
		public bool HHMPMGAPMHE(KJNCFICFIIE GNKPFNIMJND, out Collider ECFBGBALBNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x377A020", Offset = "0x3779420", VA = "0x18377A020")]
		private void PCBJDAMNJPI(Entity OOEHGINMJGM, ODHBKAFBAFM IIMBCOAEFMJ, NICFNFKBPKA AJNJONIBFJA, NICFNFKBPKA IOHONDKAJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x3779830", Offset = "0x3778C30", VA = "0x183779830", Slot = "9")]
		public void ACBBDHFNKHG(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	[AOJPGBJKDNL(typeof(KJFHICGMDLJ), new string[] { })]
	public class RbexService : NGENPNOGFON, KJFHICGMDLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private CBGJJCKMFCA PEPLIFOGJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private World LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private LDJNBNGIACM HHOLHOJEKJA;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private EntityManager NPBNPNJJNKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x38AFC10", Offset = "0x38AF010", VA = "0x1838AFC10")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x38B1C80", Offset = "0x38B1080", VA = "0x1838B1C80", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x38B1630", Offset = "0x38B0A30", VA = "0x1838B1630", Slot = "6")]
		public ENMGKLMFFLD NMGNADAILPE(KJNCFICFIIE GNKPFNIMJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x38B1580", Offset = "0x38B0980", VA = "0x1838B1580", Slot = "5")]
		public void NGKEOLAJNPP(KJNCFICFIIE GNKPFNIMJND, ENMGKLMFFLD FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x38B0B10", Offset = "0x38AFF10", VA = "0x1838B0B10", Slot = "34")]
		public CollisionDetectionMode IIBNEHIBJOH(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x38AFC90", Offset = "0x38AF090", VA = "0x1838AFC90", Slot = "35")]
		public void EHHEOMJMENL(KJNCFICFIIE GNKPFNIMJND, CollisionDetectionMode FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x38AFA30", Offset = "0x38AEE30", VA = "0x1838AFA30", Slot = "36")]
		public CJAGCCPNBHO DOFEEEIKHMB(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(CJAGCCPNBHO);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x38AF7B0", Offset = "0x38AEBB0", VA = "0x1838AF7B0", Slot = "37")]
		public void DDKIHPAEDIC(KJNCFICFIIE GNKPFNIMJND, CJAGCCPNBHO FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x38B16C0", Offset = "0x38B0AC0", VA = "0x1838B16C0", Slot = "38")]
		public bool NOCNPCPAEBI(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x38B11C0", Offset = "0x38B05C0", VA = "0x1838B11C0", Slot = "39")]
		public void LHFJEBMHOKJ(KJNCFICFIIE GNKPFNIMJND, bool FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x38AF550", Offset = "0x38AE950", VA = "0x1838AF550", Slot = "40")]
		public KJNCFICFIIE CFGEIGEDAJC(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x38AEBB0", Offset = "0x38ADFB0", VA = "0x1838AEBB0", Slot = "41")]
		public void ACBEFEDBMGL(KJNCFICFIIE GNKPFNIMJND, KJNCFICFIIE FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x38AF4A0", Offset = "0x38AE8A0", VA = "0x1838AF4A0", Slot = "42")]
		public KJNCFICFIIE CCHAPKECBLI(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x38B1720", Offset = "0x38B0B20", VA = "0x1838B1720", Slot = "43")]
		public void NPKNFKDMNIH(KJNCFICFIIE GNKPFNIMJND, KJNCFICFIIE FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x38B1B10", Offset = "0x38B0F10", VA = "0x1838B1B10", Slot = "7")]
		public void OFOBOCNNGKJ(KJNCFICFIIE GNKPFNIMJND, KJNCFICFIIE FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x38AECA0", Offset = "0x38AE0A0", VA = "0x1838AECA0", Slot = "8")]
		public void ADHHJICHDIC(KJNCFICFIIE GNKPFNIMJND, KJNCFICFIIE FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x38B1490", Offset = "0x38B0890", VA = "0x1838B1490", Slot = "9")]
		public int MOGIMNPNCEG(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x38B01F0", Offset = "0x38AF5F0", VA = "0x1838B01F0", Slot = "10")]
		public KJNCFICFIIE HBBCLKEHJJL(KJNCFICFIIE GNKPFNIMJND, int GABJOMFFJAI)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x38B1D30", Offset = "0x38B1130", VA = "0x1838B1D30", Slot = "11")]
		public void PFGPCEHGCPE(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x38B17A0", Offset = "0x38B0BA0", VA = "0x1838B17A0", Slot = "12")]
		public void OBCAPLGJCKG(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB, KJNCFICFIIE FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x38AF920", Offset = "0x38AED20", VA = "0x1838AF920", Slot = "13")]
		public void DKCFPABBJGG(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x38AF650", Offset = "0x38AEA50", VA = "0x1838AF650", Slot = "14")]
		public bool DDFKCOHLJEH(KJNCFICFIIE GNKPFNIMJND, out KJNCFICFIIE FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x38AF050", Offset = "0x38AE450", VA = "0x1838AF050", Slot = "15")]
		public void BHDKABOHFEF(KJNCFICFIIE GNKPFNIMJND, float3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x38AF0D0", Offset = "0x38AE4D0", VA = "0x1838AF0D0", Slot = "16")]
		public bool BJNNMFPINLP(KJNCFICFIIE GNKPFNIMJND, out float3 FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x38B0D60", Offset = "0x38B0160", VA = "0x1838B0D60", Slot = "17")]
		public void JJKLBNPEACF(KJNCFICFIIE GNKPFNIMJND, float3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x38B0390", Offset = "0x38AF790", VA = "0x1838B0390", Slot = "18")]
		public bool HFDOKFLHKJL(KJNCFICFIIE GNKPFNIMJND, out float3 FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x38AF5D0", Offset = "0x38AE9D0", VA = "0x1838AF5D0", Slot = "26")]
		public float3 DBNJEDHDNKI(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x38B1930", Offset = "0x38B0D30", VA = "0x1838B1930", Slot = "27")]
		public void OCKGBEDIOBF(KJNCFICFIIE GNKPFNIMJND, float3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x38AEE10", Offset = "0x38AE210", VA = "0x1838AEE10", Slot = "28")]
		public float AIFEGJHHHCB(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x38B0180", Offset = "0x38AF580", VA = "0x1838B0180", Slot = "29")]
		public void GPMNBNEDCPK(KJNCFICFIIE GNKPFNIMJND, float FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x38AFEF0", Offset = "0x38AF2F0", VA = "0x1838AFEF0", Slot = "30")]
		public float EOIJKMNIDPD(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x38B0C60", Offset = "0x38B0060", VA = "0x1838B0C60", Slot = "31")]
		public void JCGIGDNDJOK(KJNCFICFIIE GNKPFNIMJND, float FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x38B1E20", Offset = "0x38B1220", VA = "0x1838B1E20", Slot = "32")]
		public bool PGEJBHFJPHP(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x38B0DE0", Offset = "0x38B01E0", VA = "0x1838B0DE0", Slot = "33")]
		public void JLGIHDODKDB(KJNCFICFIIE GNKPFNIMJND, bool FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x38B0BE0", Offset = "0x38AFFE0", VA = "0x1838B0BE0", Slot = "19")]
		public void JAHCCECGPMB(KJNCFICFIIE GNKPFNIMJND, float3 FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x38B19B0", Offset = "0x38B0DB0", VA = "0x1838B19B0", Slot = "20")]
		public bool ODBGPDFPPPP(KJNCFICFIIE GNKPFNIMJND, out float3 FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x38B0110", Offset = "0x38AF510", VA = "0x1838B0110", Slot = "21")]
		public void GOPJACDCGHB(KJNCFICFIIE GNKPFNIMJND, quaternion FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x38AFD30", Offset = "0x38AF130", VA = "0x1838AFD30", Slot = "22")]
		public bool ELHENHJMKGP(KJNCFICFIIE GNKPFNIMJND, out quaternion FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x38AF230", Offset = "0x38AE630", VA = "0x1838AF230", Slot = "23")]
		public bool BPJNBEAOPOP(KJNCFICFIIE GNKPFNIMJND, out float3 BEJHLNNAKMK, out quaternion MIIDNIGPBLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x38B0650", Offset = "0x38AFA50", VA = "0x1838B0650", Slot = "44")]
		public HIHNKPGEDDE HIEGCGJJPMF(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(HIHNKPGEDDE);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x38B1230", Offset = "0x38B0630", VA = "0x1838B1230", Slot = "45")]
		public void LLCEOMDFGKA(KJNCFICFIIE GNKPFNIMJND, HIHNKPGEDDE FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x38AEFC0", Offset = "0x38AE3C0", VA = "0x1838AEFC0", Slot = "72")]
		public void BBDPCCAIKCO(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x38B1F50", Offset = "0x38B1350", VA = "0x1838B1F50", Slot = "73")]
		public void PKJGGCHDBPP(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x38AF9B0", Offset = "0x38AEDB0", VA = "0x1838AF9B0", Slot = "74")]
		public bool DNKCEAHMOBN(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x38B08B0", Offset = "0x38AFCB0", VA = "0x1838B08B0", Slot = "81")]
		public void IBCLEKALBNL(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x38B12A0", Offset = "0x38B06A0", VA = "0x1838B12A0", Slot = "82")]
		public void LLLHLJOPGBD(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x38B0F30", Offset = "0x38B0330", VA = "0x1838B0F30", Slot = "83")]
		public bool KFFNCOBHKNO(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x38B06B0", Offset = "0x38AFAB0", VA = "0x1838B06B0", Slot = "84")]
		public IEnumerable<object> HILLOBHJHPI(KJNCFICFIIE GNKPFNIMJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x38AFC30", Offset = "0x38AF030", VA = "0x1838AFC30", Slot = "46")]
		public bool EGHIBJFOEGL(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x38B1330", Offset = "0x38B0730", VA = "0x1838B1330", Slot = "47")]
		public void LMKCCOGAJHF(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x38B18D0", Offset = "0x38B0CD0", VA = "0x1838B18D0", Slot = "48")]
		public bool OCBOIDNAOOI(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x38B0B70", Offset = "0x38AFF70", VA = "0x1838B0B70", Slot = "49")]
		public void IIEOKLAGDHP(KJNCFICFIIE GNKPFNIMJND, bool FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x38AFB30", Offset = "0x38AEF30", VA = "0x1838AFB30", Slot = "50")]
		public bool EBLAKADDOIE(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x38AEC30", Offset = "0x38AE030", VA = "0x1838AEC30", Slot = "51")]
		public void ACDHLOFNAOH(KJNCFICFIIE GNKPFNIMJND, bool FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x38AEE70", Offset = "0x38AE270", VA = "0x1838AEE70", Slot = "52")]
		public RigidbodyConstraints ANALKPFANPB(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x38B0E50", Offset = "0x38B0250", VA = "0x1838B0E50", Slot = "53")]
		public void JMCMHOANKMG(KJNCFICFIIE GNKPFNIMJND, RigidbodyConstraints FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x38B00B0", Offset = "0x38AF4B0", VA = "0x1838B00B0", Slot = "54")]
		public float FODOJHHKDJB(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x38B07B0", Offset = "0x38AFBB0", VA = "0x1838B07B0", Slot = "55")]
		public void HOEHMODGPKH(KJNCFICFIIE GNKPFNIMJND, float FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x38AEDB0", Offset = "0x38AE1B0", VA = "0x1838AEDB0", Slot = "56")]
		public float AFEBEFLMEHH(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x38AEB40", Offset = "0x38ADF40", VA = "0x1838AEB40", Slot = "57")]
		public void ABPBBOCGHJO(KJNCFICFIIE GNKPFNIMJND, float FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x38B1C20", Offset = "0x38B1020", VA = "0x1838B1C20", Slot = "58")]
		public bool OLKCMHMHGKF(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x38B0AA0", Offset = "0x38AFEA0", VA = "0x1838B0AA0", Slot = "59")]
		public void IEHHMHCBMNE(KJNCFICFIIE GNKPFNIMJND, bool FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x38AEED0", Offset = "0x38AE2D0", VA = "0x1838AEED0", Slot = "60")]
		public bool ANIDGBANJFB(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x38B1390", Offset = "0x38B0790", VA = "0x1838B1390", Slot = "61")]
		public void LOALDBNPGJL(KJNCFICFIIE GNKPFNIMJND, bool FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x38AFAD0", Offset = "0x38AEED0", VA = "0x1838AFAD0", Slot = "62")]
		public int EAPDJNPMICF(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x38AF8B0", Offset = "0x38AECB0", VA = "0x1838AF8B0", Slot = "63")]
		public void DIBJNDALEKM(KJNCFICFIIE GNKPFNIMJND, int FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x38B1040", Offset = "0x38B0440", VA = "0x1838B1040", Slot = "64")]
		public Rigidbody KLIJMIJJHLI(KJNCFICFIIE GNKPFNIMJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x38AFF50", Offset = "0x38AF350", VA = "0x1838AFF50", Slot = "65")]
		public void FLGBJHLHKBB(KJNCFICFIIE GNKPFNIMJND, Rigidbody FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x38B0FB0", Offset = "0x38B03B0", VA = "0x1838B0FB0", Slot = "75")]
		public void KJNFEALIHKF(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x38B1130", Offset = "0x38B0530", VA = "0x1838B1130", Slot = "76")]
		public void LDJAIJEGLEL(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x38B0310", Offset = "0x38AF710", VA = "0x1838B0310", Slot = "77")]
		public bool HCAJFCHPLOG(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x38B0820", Offset = "0x38AFC20", VA = "0x1838B0820", Slot = "66")]
		public object IAMKGAHAEIL(KJNCFICFIIE GNKPFNIMJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x38B0940", Offset = "0x38AFD40", VA = "0x1838B0940", Slot = "67")]
		public void IBHPKNENGBG(KJNCFICFIIE GNKPFNIMJND, object FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x38AEF30", Offset = "0x38AE330", VA = "0x1838AEF30", Slot = "68")]
		public object BAMFMMBIAEL(KJNCFICFIIE GNKPFNIMJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x38B04F0", Offset = "0x38AF8F0", VA = "0x1838B04F0", Slot = "69")]
		public void HGBGNLLLBCB(KJNCFICFIIE GNKPFNIMJND, object FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x38AFE90", Offset = "0x38AF290", VA = "0x1838AFE90", Slot = "70")]
		public float ENAEDPGIFJB(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x38B0EC0", Offset = "0x38B02C0", VA = "0x1838B0EC0", Slot = "71")]
		public void KALOANMLBLG(KJNCFICFIIE GNKPFNIMJND, float FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x38B0CD0", Offset = "0x38B00D0", VA = "0x1838B0CD0", Slot = "78")]
		public void JFAABCDONMN(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x38B1400", Offset = "0x38B0800", VA = "0x1838B1400", Slot = "79")]
		public void MEMAOKJNFFL(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x38AFB90", Offset = "0x38AEF90", VA = "0x1838AFB90", Slot = "80")]
		public bool EDGEPHLOCPH(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x38B10D0", Offset = "0x38B04D0", VA = "0x1838B10D0", Slot = "24")]
		public void LCENCIBFNFO(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x38AF850", Offset = "0x38AEC50", VA = "0x1838AF850", Slot = "25")]
		public void DDLCEFJMGML(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x4B44A60", Offset = "0x4B43E60", VA = "0x184B44A60")]
		private void PPPIANGENNB<T>(KJNCFICFIIE GNKPFNIMJND, bool FPLJCBGEJAP) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x4B44390", Offset = "0x4B43790", VA = "0x184B44390")]
		private bool HKKFLCFAJBC<T>(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x4B43B50", Offset = "0x4B42F50", VA = "0x184B43B50")]
		private void GAMANBAONBG<T>(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4B43BB0", Offset = "0x4B42FB0", VA = "0x184B43BB0")]
		private bool GGNDKOOHHEA<TC, TV>(KJNCFICFIIE GNKPFNIMJND, Func<TC, TV> EPHODGMEGPF, out TV FPLJCBGEJAP) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x4B435D0", Offset = "0x4B429D0", VA = "0x184B435D0")]
		private bool GGNDKOOHHEA<T>(KJNCFICFIIE GNKPFNIMJND, out T FPLJCBGEJAP) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x4B43700", Offset = "0x4B42B00", VA = "0x184B43700")]
		private T FEDEDGCAOFD<T>(KJNCFICFIIE GNKPFNIMJND) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B44510", Offset = "0x4B43910", VA = "0x184B44510")]
		private void OGABAHNFDNF<T>(KJNCFICFIIE GNKPFNIMJND, T FPLJCBGEJAP) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x4B43D30", Offset = "0x4B43130", VA = "0x184B43D30")]
		private void HJFFELOBEGN<T>(KJNCFICFIIE GNKPFNIMJND, T FPLJCBGEJAP) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x4B435D0", Offset = "0x4B429D0", VA = "0x184B435D0")]
		private bool AJBJHLFLJDL<T>(KJNCFICFIIE GNKPFNIMJND, out T FPLJCBGEJAP) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x4B443F0", Offset = "0x4B437F0", VA = "0x184B443F0")]
		private T JGNPEOONPJA<T>(KJNCFICFIIE GNKPFNIMJND) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x4B435D0", Offset = "0x4B429D0", VA = "0x184B435D0")]
		private void KGHJKDMLDFK<T>(KJNCFICFIIE GNKPFNIMJND, T FPLJCBGEJAP) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x4B43650", Offset = "0x4B42A50", VA = "0x184B43650")]
		private void DPKJEEJJKHO<T>(KJNCFICFIIE GNKPFNIMJND, T FPLJCBGEJAP) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x38AFD00", Offset = "0x38AF100", VA = "0x1838AFD00")]
		private KJNCFICFIIE EIBAOMGKPAN(Entity OOEHGINMJGM)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x38B1E80", Offset = "0x38B1280", VA = "0x1838B1E80")]
		private DynamicBuffer<Entity> PJLMONPDHAH(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x4B44450", Offset = "0x4B43850", VA = "0x184B44450")]
		private void LDLIPLECAJO<T>(KJNCFICFIIE GNKPFNIMJND, object FPLJCBGEJAP, Func<object, T> EPHODGMEGPF) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		private void HCLJCDJPJCB<T>(ref global::EIDJKICAODJ<T> ADKIJCPOMNK) where T : struct, IKMGKFNJFNI
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		private void HCLJCDJPJCB<TC, TV>(ref global::EMFAIGONLBB<TC, TV> ADKIJCPOMNK) where TC : struct, IKMGKFNJFNI
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
	[AOJPGBJKDNL(typeof(KinematicSleepChangeService), new string[] { })]
	public class KinematicSleepChangeService : NGENPNOGFON, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class PFHHBHJLLDF : IEnumerable<ENMGKLMFFLD>, IEnumerable, IEnumerator<ENMGKLMFFLD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private ENMGKLMFFLD <>2__current;

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
			private ENMGKLMFFLD System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
			[DebuggerHidden]
			public PFHHBHJLLDF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x4196BE0", Offset = "0x4195FE0", VA = "0x184196BE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x4196900", Offset = "0x4195D00", VA = "0x184196900", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x4196C60", Offset = "0x4196060", VA = "0x184196C60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x4196BA0", Offset = "0x4195FA0", VA = "0x184196BA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x4196AF0", Offset = "0x4195EF0", VA = "0x184196AF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ENMGKLMFFLD> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x4196AF0", Offset = "0x4195EF0", VA = "0x184196AF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> AMHLOIBHBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA PEPLIFOGJAA;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x375F0A0", Offset = "0x375E4A0", VA = "0x18375F0A0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x375EF80", Offset = "0x375E380", VA = "0x18375EF80")]
		public void IILKEDFPCAE(NativeArray<Entity> NMNOLKKCICL, bool BDKJOBDBKOG, bool KDPJJJEFDFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x375ED70", Offset = "0x375E170", VA = "0x18375ED70")]
		public void HPCMNFBOMCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x375E5B0", Offset = "0x375D9B0", VA = "0x18375E5B0")]
		private void FPFKLECDDAO(NativeArray<Entity> NMNOLKKCICL, bool BDKJOBDBKOG, bool KDPJJJEFDFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x375E3D0", Offset = "0x375D7D0", VA = "0x18375E3D0")]
		[IteratorStateMachine(typeof(PFHHBHJLLDF))]
		private IEnumerable<ENMGKLMFFLD> BGLDDDGNFGJ(NativeArray<Entity> NMNOLKKCICL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x375E460", Offset = "0x375D860", VA = "0x18375E460", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x375F140", Offset = "0x375E540", VA = "0x18375F140")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
[AOJPGBJKDNL(typeof(AECLLFLJBLC), new string[] { })]
public class DLKGJJEDDLG : AECLLFLJBLC, IEnumerable<HNBCIHNKHJC>, IEnumerable, HPLECDDPLCA, HIJIFLANIAO, NGENPNOGFON, CJFEEGPLPHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[CPICBLLAMOM]
	private OMKFKACLLIK FIJECBKDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<(Type, string), int> OPLCOBLCBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private MOECLGJCKJP FGEFBMKHCPB;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x37EC410", Offset = "0x37EB810", VA = "0x1837EC410", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public HNBCIHNKHJC CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x37EC3F0", Offset = "0x37EB7F0", VA = "0x1837EC3F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public HNBCIHNKHJC CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x37EC3F0", Offset = "0x37EB7F0", VA = "0x1837EC3F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x37EC9A0", Offset = "0x37EBDA0", VA = "0x1837EC9A0", Slot = "11")]
	public void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x37ECBE0", Offset = "0x37EBFE0", VA = "0x1837ECBE0", Slot = "12")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "13")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x37EC700", Offset = "0x37EBB00", VA = "0x1837EC700")]
	private void LGKCINLEAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x3342430", Offset = "0x3341830", VA = "0x183342430")]
	private string OJJANMEOLFD(string LBEPPIIBMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x37ECB00", Offset = "0x37EBF00", VA = "0x1837ECB00", Slot = "7")]
	public HNBCIHNKHJC NGHIEEMHPLB(BFOMGEBLKLE MLBMAJEOEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x37EC450", Offset = "0x37EB850", VA = "0x1837EC450")]
	private bool JHIGNNOMKPC(Type CLPCALJPBGC, string LBEPPIIBMPA, out HNBCIHNKHJC FBHLIBEOAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x37EC9F0", Offset = "0x37EBDF0", VA = "0x1837EC9F0", Slot = "8")]
	public ODHBKAFBAFM NEDGFNNHBJL(BFOMGEBLKLE MLBMAJEOEBG)
	{
		return default(ODHBKAFBAFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x37EC430", Offset = "0x37EB830", VA = "0x1837EC430", Slot = "9")]
	public IEnumerator<HNBCIHNKHJC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x37EC430", Offset = "0x37EB830", VA = "0x1837EC430", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x37ECC60", Offset = "0x37EC060", VA = "0x1837ECC60")]
	public DLKGJJEDDLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
[DefaultMember("Item")]
public interface IHEJJJCBDEN
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PNGJPPCINDG(ODHBKAFBAFM BJKMNBIBKCI, out int OLGJFEONMLB);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
[AOJPGBJKDNL(typeof(IHEJJJCBDEN), new string[] { })]
public class AKJHPNKDCFO : NGENPNOGFON, CJFEEGPLPHA, IHEJJJCBDEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[CPICBLLAMOM]
	private IBKMFFMCCLE FIJECBKDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<ODHBKAFBAFM, int> BBOKKPKMELD;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x37D3F30", Offset = "0x37D3330", VA = "0x1837D3F30", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x37D4270", Offset = "0x37D3670", VA = "0x1837D4270", Slot = "6")]
	public bool PNGJPPCINDG(ODHBKAFBAFM BJKMNBIBKCI, out int OLGJFEONMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x37D4210", Offset = "0x37D3610", VA = "0x1837D4210", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x37D4200", Offset = "0x37D3600", VA = "0x1837D4200", Slot = "5")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x37D3F90", Offset = "0x37D3390", VA = "0x1837D3F90")]
	private void CAIDAFBPMDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x37D42E0", Offset = "0x37D36E0", VA = "0x1837D42E0")]
	public AKJHPNKDCFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[AOJPGBJKDNL(typeof(IBKMFFMCCLE), new string[] { })]
[DefaultMember("Item")]
public class DAJAOCOGCAP : IBKMFFMCCLE, IEnumerable<OFMJLJJKKJK>, IEnumerable, HPLECDDPLCA, HIJIFLANIAO, NGENPNOGFON, CJFEEGPLPHA, HOINKPMEBEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[CPICBLLAMOM]
	private LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[CPICBLLAMOM]
	private AECLLFLJBLC HAKMCAOCJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private OFMJLJJKKJK[] ABPBCBIBJAH;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x10C5970", Offset = "0x10C4D70", VA = "0x1810C5970", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public OFMJLJJKKJK CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x37E99E0", Offset = "0x37E8DE0", VA = "0x1837E99E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public OFMJLJJKKJK CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x37E99E0", Offset = "0x37E8DE0", VA = "0x1837E99E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "10")]
	public void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x37E9E40", Offset = "0x37E9240", VA = "0x1837E9E40", Slot = "11")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "12")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x37E9D10", Offset = "0x37E9110", VA = "0x1837E9D10", Slot = "6")]
	public OFMJLJJKKJK NGHIEEMHPLB(BFOMGEBLKLE MLBMAJEOEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x37E9C40", Offset = "0x37E9040", VA = "0x1837E9C40", Slot = "7")]
	public ODHBKAFBAFM NEDGFNNHBJL(BFOMGEBLKLE MLBMAJEOEBG)
	{
		return default(ODHBKAFBAFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x37E9B60", Offset = "0x37E8F60", VA = "0x1837E9B60", Slot = "8")]
	public IEnumerator<OFMJLJJKKJK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x37EA0E0", Offset = "0x37E94E0", VA = "0x1837EA0E0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x33D5620", Offset = "0x33D4A20", VA = "0x1833D5620", Slot = "13")]
	public void ALDFGEDDDND<TKey, T>(global::GBIJOAKACLC<TKey, T> JGMFKPLFFDI, [Optional] object OEGBAMNPENI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x37E9A20", Offset = "0x37E8E20", VA = "0x1837E9A20", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DAJAOCOGCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x37E99E0", Offset = "0x37E8DE0", VA = "0x1837E99E0")]
	[CompilerGenerated]
	private OFMJLJJKKJK MCNDMJGNDED(int MDFMPEMHONH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
[AOJPGBJKDNL(typeof(MPCADNMEKPJ), new string[] { })]
public class INEHJEFNEME : MPCADNMEKPJ, IEnumerable<AEOCECNOIKA>, IEnumerable, NGENPNOGFON, CJFEEGPLPHA, HOINKPMEBEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[CPICBLLAMOM]
	private LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[CPICBLLAMOM]
	private AECLLFLJBLC HAKMCAOCJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private AEOCECNOIKA[] ABPBCBIBJAH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x3A6EC10", Offset = "0x3A6E010", VA = "0x183A6EC10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public AEOCECNOIKA CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A6EB20", Offset = "0x3A6DF20", VA = "0x183A6EB20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public AEOCECNOIKA CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x3A6EB20", Offset = "0x3A6DF20", VA = "0x183A6EB20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F260", Offset = "0x3A6E660", VA = "0x183A6F260", Slot = "9")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EE10", Offset = "0x3A6E210", VA = "0x183A6EE10", Slot = "10")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EB30", Offset = "0x3A6DF30", VA = "0x183A6EB30")]
	private AEOCECNOIKA CDJDFAKCAFB(int GABJOMFFJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F140", Offset = "0x3A6E540", VA = "0x183A6F140", Slot = "6")]
	public AEOCECNOIKA NGHIEEMHPLB(BFOMGEBLKLE MLBMAJEOEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F070", Offset = "0x3A6E470", VA = "0x183A6F070", Slot = "14")]
	public ODHBKAFBAFM NEDGFNNHBJL(BFOMGEBLKLE MLBMAJEOEBG)
	{
		return default(ODHBKAFBAFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x3A6ED00", Offset = "0x3A6E100", VA = "0x183A6ED00", Slot = "7")]
	public IEnumerator<AEOCECNOIKA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x3A6ED00", Offset = "0x3A6E100", VA = "0x183A6ED00", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x34377E0", Offset = "0x3436BE0", VA = "0x1834377E0", Slot = "11")]
	public void ALDFGEDDDND<TKey, T>(global::GBIJOAKACLC<TKey, T> JGMFKPLFFDI, [Optional] object OEGBAMNPENI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EC60", Offset = "0x3A6E060", VA = "0x183A6EC60", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public INEHJEFNEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EB20", Offset = "0x3A6DF20", VA = "0x183A6EB20")]
	[CompilerGenerated]
	private AEOCECNOIKA MCNDMJGNDED(int MDFMPEMHONH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[AOJPGBJKDNL(typeof(OMKFKACLLIK), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
internal class OMKFKACLLIK : NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private AECLLFLJBLC HAKMCAOCJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private MPCADNMEKPJ PINCLBAHEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private IBKMFFMCCLE GCEMEDDDAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private global::BNIKHELKNNI<AEBPMMDNEJA> NJGPHEOFKNK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public MOECLGJCKJP AOFAAANBCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x7776A0", Offset = "0x776AA0", VA = "0x1807776A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x3766680", Offset = "0x3765A80", VA = "0x183766680", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x37667B0", Offset = "0x3765BB0", VA = "0x1837667B0")]
	private void PEFDGHDILKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2D79C10", Offset = "0x2D79010", VA = "0x182D79C10")]
	public T ILBIPNNPFFH<T>() where T : AEBPMMDNEJA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x37664E0", Offset = "0x37658E0", VA = "0x1837664E0")]
	public HNBCIHNKHJC FODOLOCHBPJ(BFOMGEBLKLE LBEPPIIBMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	public global::NBILNGMPECD<T> FODOLOCHBPJ<T>(BFOMGEBLKLE LBEPPIIBMPA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x3766410", Offset = "0x3765810", VA = "0x183766410")]
	public AEOCECNOIKA CKDGKAMNBKI(BFOMGEBLKLE LBEPPIIBMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x3B84A30", Offset = "0x3B83E30", VA = "0x183B84A30")]
	public global::KLDCIKDDCHO<T> CKDGKAMNBKI<T>(BFOMGEBLKLE LBEPPIIBMPA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x37665B0", Offset = "0x37659B0", VA = "0x1837665B0")]
	public OFMJLJJKKJK OGFGFKINKGJ(BFOMGEBLKLE LBEPPIIBMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	public global::IDCGCHBMIII<T> OGFGFKINKGJ<T>(BFOMGEBLKLE LBEPPIIBMPA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public OMKFKACLLIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class OKLCIOONENO
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x3217F00", Offset = "0x3217300", VA = "0x183217F00")]
	public static global::NBILNGMPECD<T> FODOLOCHBPJ<T>(this OMKFKACLLIK LFBDLGPFNLK, global::KPNHCHMCPJM<T> LBEPPIIBMPA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	public static global::KLDCIKDDCHO<T> CKDGKAMNBKI<T>(this OMKFKACLLIK LFBDLGPFNLK, global::KPNHCHMCPJM<T> LBEPPIIBMPA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	public static global::IDCGCHBMIII<T> OGFGFKINKGJ<T>(this OMKFKACLLIK LFBDLGPFNLK, global::KPNHCHMCPJM<T> LBEPPIIBMPA) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[AOJPGBJKDNL(typeof(JLPEHKPEKPL), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
public class JLPEHKPEKPL : NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private NEKHKMCAINI HJANMLILLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private ODHBKAFBAFM[] ODGKGGANECG;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x3A71530", Offset = "0x3A70930", VA = "0x183A71530", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x3A71410", Offset = "0x3A70810", VA = "0x183A71410")]
	public void KBOFFIPEFLE(EHNBIOJHEAD DGDIPHPMEJP, bool MAJOKBDIHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public JLPEHKPEKPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[AOJPGBJKDNL(typeof(HAAMHMEJPFH), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
public sealed class HAAMHMEJPFH : NGENPNOGFON, CJFEEGPLPHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class BGHKHEGONML : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
		[DebuggerHidden]
		public BGHKHEGONML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x418AF60", Offset = "0x418A360", VA = "0x18418AF60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x418ABB0", Offset = "0x4189FB0", VA = "0x18418ABB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x418AFE0", Offset = "0x418A3E0", VA = "0x18418AFE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x418AF20", Offset = "0x418A320", VA = "0x18418AF20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x418AE90", Offset = "0x418A290", VA = "0x18418AE90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x418AE90", Offset = "0x418A290", VA = "0x18418AE90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string HIPJKANOLCO = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<SerializableGuid, JBHHOPMKBJL> AEIMKLNEIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<SerializableGuid> ODNLAIGJBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Dictionary<SerializableGuid, GameObject> GKKDCEIPLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private MPCADNMEKPJ FIJECBKDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private PFHNJBGFDIA CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private AIKEDHOJPPH NOGKNHKHMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private JIBOBOIGILH OLBLAKNPIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private global::DDJMMFCDPON<JBHHOPMKBJL> GPFGBFHDKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject FLGOCANKHJG;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x3A66FC0", Offset = "0x3A663C0", VA = "0x183A66FC0", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x3A66540", Offset = "0x3A65940", VA = "0x183A66540", Slot = "5")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x3A65D40", Offset = "0x3A65140", VA = "0x183A65D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x3A66FB0", Offset = "0x3A663B0", VA = "0x183A66FB0")]
	private void OEBFJCCIBLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x3A65EE0", Offset = "0x3A652E0", VA = "0x183A65EE0")]
	internal void EFFAIBPEIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x3A66710", Offset = "0x3A65B10", VA = "0x183A66710")]
	private void LLNDFJJOFNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x3A668F0", Offset = "0x3A65CF0", VA = "0x183A668F0")]
	private void LPPJFDGPBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x3A66310", Offset = "0x3A65710", VA = "0x183A66310")]
	[IteratorStateMachine(typeof(BGHKHEGONML))]
	private IEnumerable<RRCustomPropTag> HEIOEMCBJGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x3A669F0", Offset = "0x3A65DF0", VA = "0x183A669F0")]
	private void MCCFAGPDMGK(KJNCFICFIIE GNKPFNIMJND, in NICFNFKBPKA GGPFLMFJFKO, in NICFNFKBPKA OIOCGOCBAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x3A66E70", Offset = "0x3A66270", VA = "0x183A66E70")]
	private void MHBAMOAJPNP(SerializableGuid CFOLAEKFCNI, GameObject CEPEJEHMODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x3A65960", Offset = "0x3A64D60", VA = "0x183A65960")]
	private void AAGFKFFABGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x3A66360", Offset = "0x3A65760", VA = "0x183A66360")]
	private bool HMMKFFFBDOB(JBHHOPMKBJL CDLJLCDCIGF, Transform CNDFBGEJOLI, out GameObject GLONDIMDLCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x3A65CF0", Offset = "0x3A650F0", VA = "0x183A65CF0")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x3A67090", Offset = "0x3A66490", VA = "0x183A67090")]
	public HAAMHMEJPFH()
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
		public SerializableGuid BKDNHOGFJJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x8291E0", Offset = "0x8285E0", VA = "0x1808291E0")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x38AEA50", Offset = "0x38ADE50", VA = "0x1838AEA50")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[AOJPGBJKDNL(typeof(PPOGONNCNDP), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
public class PPOGONNCNDP : NGENPNOGFON
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private const string GGMFCNNKCCM = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private SceneService OGAOLGJGLCD;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x37768F0", Offset = "0x3775CF0", VA = "0x1837768F0", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public PPOGONNCNDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[AOJPGBJKDNL(typeof(FFEGPDFCCGB), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
public class FFEGPDFCCGB : NGENPNOGFON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[CPICBLLAMOM]
	private EnableComponentSystemsInScope FCMIDLNFKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[CPICBLLAMOM]
	private SceneService OGAOLGJGLCD;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x3A61050", Offset = "0x3A60450", VA = "0x183A61050", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x3A61010", Offset = "0x3A60410", VA = "0x183A61010", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x3A60FF0", Offset = "0x3A603F0", VA = "0x183A60FF0")]
	private void BIJPFBHNAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x3A60FC0", Offset = "0x3A603C0", VA = "0x183A60FC0")]
	private void AABPHFOFDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FFEGPDFCCGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[AOJPGBJKDNL(typeof(DFBNDOPHHMN), new string[] { })]
public class KIAMIMKEMDG : NGENPNOGFON, CJFEEGPLPHA, DFBNDOPHHMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private OBNLPCJMAPP MDDAOJACOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private ODDNNDOCMHE OEBLHFCMDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PropertyEventCallbacksService ODEGAHCHELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private LocalPlayerScopeSystem IKHOPIKGEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private int LDDOOPENEIN;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool MOOFMHLFNPN
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x3A74610", Offset = "0x3A73A10", VA = "0x183A74610", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public KJNCFICFIIE JAIKLNCDEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x3A74520", Offset = "0x3A73920", VA = "0x183A74520", Slot = "9")]
		get
		{
			return default(KJNCFICFIIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x3A74480", Offset = "0x3A73880", VA = "0x183A74480", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public NPBAKKOKIOD BLLKPDHEEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x3A74990", Offset = "0x3A73D90", VA = "0x183A74990", Slot = "11")]
		get
		{
			return default(NPBAKKOKIOD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x3A74480", Offset = "0x3A73880", VA = "0x183A74480", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public NPBAKKOKIOD HJBIIABHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x3A74F20", Offset = "0x3A74320", VA = "0x183A74F20", Slot = "13")]
		get
		{
			return default(NPBAKKOKIOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint KDODPBECFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x3A74F70", Offset = "0x3A74370", VA = "0x183A74F70")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ENBFDEJNAED DNDHHJNBJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x3A743E0", Offset = "0x3A737E0", VA = "0x183A743E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x3A74B80", Offset = "0x3A73F80", VA = "0x183A74B80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x3A75020", Offset = "0x3A74420", VA = "0x183A75020", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x3A749E0", Offset = "0x3A73DE0", VA = "0x183A749E0", Slot = "5")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x3A74560", Offset = "0x3A73960", VA = "0x183A74560", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x3A74D20", Offset = "0x3A74120", VA = "0x183A74D20")]
	private void MDIJLBMACDA(Entity OOEHGINMJGM, ODHBKAFBAFM IIMBCOAEFMJ, NICFNFKBPKA AJNJONIBFJA, NICFNFKBPKA IOHONDKAJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x3A74650", Offset = "0x3A73A50", VA = "0x183A74650", Slot = "14")]
	public KJNCFICFIIE FCBFBEJGDDD(KJNCFICFIIE KIKPCHNHCOF, KJNCFICFIIE ACEOMEGCOKM)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x3A74C20", Offset = "0x3A74020", VA = "0x183A74C20", Slot = "15")]
	public bool MAHIHPJAEKH(KJNCFICFIIE KIKPCHNHCOF, KJNCFICFIIE ACEOMEGCOKM, out KJNCFICFIIE ACLPGKKPMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x3A74800", Offset = "0x3A73C00", VA = "0x183A74800", Slot = "16")]
	public void FPNMBCINONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x3A74760", Offset = "0x3A73B60", VA = "0x183A74760", Slot = "17")]
	public void FGOOFKPFFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x3A74280", Offset = "0x3A73680", VA = "0x183A74280", Slot = "18")]
	public bool AENKPMKMDFL(KJNCFICFIIE GMEHFCMOOAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x3A74480", Offset = "0x3A73880", VA = "0x183A74480")]
	private void BPIFKKMLHKE(KJNCFICFIIE CLLNGAJGLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public KIAMIMKEMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AOJPGBJKDNL(typeof(HKKJODMDCGO), new string[] { })]
public class EBKJBLFOFDH : NGENPNOGFON, HKKJODMDCGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EntityManager BOGIEIBMFCN;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x3A57430", Offset = "0x3A56830", VA = "0x183A57430", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x3A573C0", Offset = "0x3A567C0", VA = "0x183A573C0", Slot = "5")]
	public void CIJPDBONOJP(KJNCFICFIIE LJGIOCJLACK, bool FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x33F22E0", Offset = "0x33F16E0", VA = "0x1833F22E0")]
	private void CODPHMBGNGD<T>(KJNCFICFIIE LJGIOCJLACK, bool FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public EBKJBLFOFDH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[AOJPGBJKDNL(typeof(JCBGDHAMIAG), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.RenderEffects)]
	public class SelectionService : NGENPNOGFON, JCBGDHAMIAG
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EntityManager BOGIEIBMFCN;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x38B5500", Offset = "0x38B4900", VA = "0x1838B5500", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x38B5420", Offset = "0x38B4820", VA = "0x1838B5420", Slot = "5")]
		public void LDPIDGIAALN(KJNCFICFIIE LJGIOCJLACK, bool FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x38B5490", Offset = "0x38B4890", VA = "0x1838B5490", Slot = "6")]
		public void NGIHODHMGBM(KJNCFICFIIE LJGIOCJLACK, bool FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x33F22E0", Offset = "0x33F16E0", VA = "0x1833F22E0")]
		private void CODPHMBGNGD<T>(KJNCFICFIIE LJGIOCJLACK, bool FPLJCBGEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
[AOJPGBJKDNL(typeof(LFPDJLHMILI), new string[] { })]
internal sealed class LFPDJLHMILI : NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[CPICBLLAMOM]
	private ObjectEmbodimentService KGKPNOEKJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[CPICBLLAMOM]
	private CBGJJCKMFCA PEPLIFOGJAA;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x3760150", Offset = "0x375F550", VA = "0x183760150", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public LFPDJLHMILI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Serialization)]
	[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
	[AOJPGBJKDNL(typeof(WorldSerialization), new string[] { })]
	internal sealed class WorldSerialization : NGENPNOGFON, BEIPBJLNHID, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly BBHAOFNBCPD FEEMOGGLIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[CPICBLLAMOM]
		private KGJHIIIKFIO NJJGKMIKDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[CPICBLLAMOM]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[CPICBLLAMOM]
		private SerializationService NOGKNHKHMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[CPICBLLAMOM]
		private ABMPOHBGIDA HIAJLBHGCPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[CPICBLLAMOM]
		private DebugWorldsService AJBPBJGKFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[CPICBLLAMOM]
		private BulkInstantiateSceneObjectService OONJPODFIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private LODNGHNPONL KPGPMPPLGCI;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private PKJGEEJNBPC GGLOKAECBFP
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xAE5880", Offset = "0xAE4C80", VA = "0x180AE5880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x38CA470", Offset = "0x38C9870", VA = "0x1838CA470", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL BINMGLGOIFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x38C9A60", Offset = "0x38C8E60", VA = "0x1838C9A60", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x38CA310", Offset = "0x38C9710", VA = "0x1838CA310", Slot = "6")]
		public bool NMANHDOFIDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x38C9B30", Offset = "0x38C8F30", VA = "0x1838C9B30", Slot = "7")]
		public bool JMPFEMGAKDC(IEnumerable<CLDNBOMABLC> FMEMBKBFPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x38C95B0", Offset = "0x38C89B0", VA = "0x1838C95B0", Slot = "5")]
		public ByteString DKBJOPOHEOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x38C9A40", Offset = "0x38C8E40", VA = "0x1838C9A40")]
		private void DNJCBCEPNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x38C94E0", Offset = "0x38C88E0", VA = "0x1838C94E0")]
		private void BAOFOCALMOA(COPAMGOGEDJ DDBBIDIICCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x38C9E30", Offset = "0x38C9230", VA = "0x1838C9E30")]
		private void MOGLOLDHCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x38C9B50", Offset = "0x38C8F50", VA = "0x1838C9B50")]
		private void KPJAHOJMMKK(JAMJFJKLJBG DDBBIDIICCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x38CA5C0", Offset = "0x38C99C0", VA = "0x1838CA5C0", Slot = "8")]
		public void PCOJJPFBNDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x38C9A90", Offset = "0x38C8E90", VA = "0x1838C9A90")]
		private COPAMGOGEDJ FPPJEODICAP(EntityManager MGLEPHJOMPB, EntityManager GGBBKDCAKNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[AOJPGBJKDNL(typeof(EEBCBPIIBNF), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
public class EEBCBPIIBNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly Dictionary<LGHJFDELFEL, string> EBMEJIHBDHE;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x3A58620", Offset = "0x3A57A20", VA = "0x183A58620")]
	public GameObject KKLBCNICDGF(LGHJFDELFEL KLLFCDIFKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x3A586F0", Offset = "0x3A57AF0", VA = "0x183A586F0")]
	public EEBCBPIIBNF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[AOJPGBJKDNL(typeof(TimeService), new string[] { })]
	public class TimeService : HIJIFLANIAO, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[CPICBLLAMOM]
		private SingletonComponentService LCGAOJJPADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool JLJPOAADGFE;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TimeData BJHMKMKOODD
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x38BCE60", Offset = "0x38BC260", VA = "0x1838BCE60")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x38BCDE0", Offset = "0x38BC1E0", VA = "0x1838BCDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool FDNJJBEAHPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x85F6B0", Offset = "0x85EAB0", VA = "0x18085F6B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x85F6C0", Offset = "0x85EAC0", VA = "0x18085F6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xB841E0", Offset = "0xB835E0", VA = "0x180B841E0", Slot = "4")]
		public void MPBHMBLFPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x38BCED0", Offset = "0x38BC2D0", VA = "0x1838BCED0", Slot = "5")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x38BCD20", Offset = "0x38BC120", VA = "0x1838BCD20")]
		public void JFBLKHCJNML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[NAPHGBOEKGO(GPIMBHHJLKL.TransformSyncing)]
	[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
	[AOJPGBJKDNL(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	internal class SetTransformParentIfParentPropertyChanges : NGENPNOGFON, CJFEEGPLPHA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private AOJCNPMLIMB KBMLCGACCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private global::NBILNGMPECD<Entity> CNDFBGEJOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ObjectEmbodimentService NGEDJICHDBC;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x38B91B0", Offset = "0x38B85B0", VA = "0x1838B91B0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x38B9080", Offset = "0x38B8480", VA = "0x1838B9080", Slot = "5")]
		public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x38B8FE0", Offset = "0x38B83E0", VA = "0x1838B8FE0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x38B8EA0", Offset = "0x38B82A0", VA = "0x1838B8EA0")]
		private void AMDALNAAIAF(Entity OOEHGINMJGM, in NICFNFKBPKA GGPFLMFJFKO, in NICFNFKBPKA OIOCGOCBAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Services)]
	[AOJPGBJKDNL(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
	public class EnableTransmissionOnlyInLoadInstance : NGENPNOGFON, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[CPICBLLAMOM]
		private GFGNKONFLNK KHOMHGNHAAG;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private HJPKCFFIEFK ADCPHPEFHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x3A5BD90", Offset = "0x3A5B190", VA = "0x183A5BD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private OIMECIOIKJL EDAIBCGDNIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x3A5BD40", Offset = "0x3A5B140", VA = "0x183A5BD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BDE0", Offset = "0x3A5B1E0", VA = "0x183A5BDE0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BD20", Offset = "0x3A5B120", VA = "0x183A5BD20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[AOJPGBJKDNL(typeof(PJMCBFDDDHN), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
public class PJMCBFDDDHN : DIACEKEHMCI, HPLECDDPLCA, HIJIFLANIAO, NGENPNOGFON, CJFEEGPLPHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class BGPNKFOHDFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public LODNGHNPONL services;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BGPNKFOHDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x418B030", Offset = "0x418A430", VA = "0x18418B030")]
		internal void <InitReferences>b__0(NGENPNOGFON svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class LGLEDCMLELJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public LODNGHNPONL services;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LGLEDCMLELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x4194930", Offset = "0x4193D30", VA = "0x184194930")]
		internal void <InitExternal>b__0(CJFEEGPLPHA svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[CPICBLLAMOM]
	private CBGJJCKMFCA PEPLIFOGJAA;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public KGKNKCKDPOC OENHCKDAAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xA00970", Offset = "0x9FFD70", VA = "0x180A00970", Slot = "4")]
		get
		{
			return default(KGKNKCKDPOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private AJIJKHGHPDE PHIKONIBLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x3775FF0", Offset = "0x37753F0", VA = "0x183775FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x3775FA0", Offset = "0x37753A0", VA = "0x183775FA0", Slot = "5")]
	public void FGMBIJAJIBC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x3776120", Offset = "0x3775520", VA = "0x183776120", Slot = "6")]
	public void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x3776250", Offset = "0x3775650", VA = "0x183776250", Slot = "7")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x3776040", Offset = "0x3775440", VA = "0x183776040", Slot = "8")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x3775E70", Offset = "0x3775270", VA = "0x183775E70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x3B92C20", Offset = "0x3B92020", VA = "0x183B92C20")]
	private void APBNFABNBPC<T>(Action<T> JBIMBCFPDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public PJMCBFDDDHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class IJADDCIKPBA<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly Func<From, To> MDEPENANODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly Func<To, From> FAAKIAOFDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public DynamicBuffer<From> DGPBECDNOKK;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To CLGONNHLFJK
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
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool HINCDHEAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	public IJADDCIKPBA(Func<From, To> MDEPENANODK, Func<To, From> FAAKIAOFDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] OGMMNHCCDJE, int HCDIEBFNKKL)
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
	public int IndexOf(To GABBPODJMBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int GABJOMFFJAI, To GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int GABJOMFFJAI)
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
public class FJKFICOCLBD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<From, To> MDEPENANODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Func<To, From> FAAKIAOFDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public List<From> JOLFKOMKBCI;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x410CA50", Offset = "0x410BE50", VA = "0x18410CA50", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x410CAB0", Offset = "0x410BEB0", VA = "0x18410CAB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x410CA20", Offset = "0x410BE20", VA = "0x18410CA20", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool HINCDHEAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8A81C0", Offset = "0x8A75C0", VA = "0x1808A81C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A8250", Offset = "0x8A7650", VA = "0x1808A8250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x33C8FA0", Offset = "0x33C83A0", VA = "0x1833C8FA0")]
	public FJKFICOCLBD(Func<From, To> MDEPENANODK, Func<To, From> FAAKIAOFDFO, bool PDFHGGAOKAG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x410C670", Offset = "0x410BA70", VA = "0x18410C670", Slot = "11")]
	public void Add(To GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D95D30", Offset = "0x3D95130", VA = "0x183D95D30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x410C6D0", Offset = "0x410BAD0", VA = "0x18410C6D0", Slot = "13")]
	public bool Contains(To GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x410C730", Offset = "0x410BB30", VA = "0x18410C730", Slot = "14")]
	public void CopyTo(To[] OGMMNHCCDJE, int HCDIEBFNKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x410C840", Offset = "0x410BC40", VA = "0x18410C840", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x410C8B0", Offset = "0x410BCB0", VA = "0x18410C8B0", Slot = "6")]
	public int IndexOf(To GABBPODJMBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x410C910", Offset = "0x410BD10", VA = "0x18410C910", Slot = "7")]
	public void Insert(int GABJOMFFJAI, To GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x410C9C0", Offset = "0x410BDC0", VA = "0x18410C9C0", Slot = "15")]
	public bool Remove(To GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x410C990", Offset = "0x410BD90", VA = "0x18410C990", Slot = "8")]
	public void RemoveAt(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x39B8780", Offset = "0x39B7B80", VA = "0x1839B8780", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DefaultMember("Item")]
public class IEIGJPBPNGM<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Func<From, To> MDEPENANODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly Func<To, From> FAAKIAOFDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<From> OGMMNHCCDJE;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x27EC810", Offset = "0x27EBC10", VA = "0x1827EC810", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x27EC860", Offset = "0x27EBC60", VA = "0x1827EC860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x27EC7D0", Offset = "0x27EBBD0", VA = "0x1827EC7D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool HINCDHEAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x27EC770", Offset = "0x27EBB70", VA = "0x1827EC770")]
	public IEIGJPBPNGM(Func<From, To> MDEPENANODK, Func<To, From> FAAKIAOFDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x27EC350", Offset = "0x27EB750", VA = "0x1827EC350", Slot = "11")]
	public void Add(To GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x27EC390", Offset = "0x27EB790", VA = "0x1827EC390", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x27EC3D0", Offset = "0x27EB7D0", VA = "0x1827EC3D0", Slot = "13")]
	public bool Contains(To GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x27EC490", Offset = "0x27EB890", VA = "0x1827EC490", Slot = "14")]
	public void CopyTo(To[] OGMMNHCCDJE, int HCDIEBFNKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x27EC550", Offset = "0x27EB950", VA = "0x1827EC550", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x27EC610", Offset = "0x27EBA10", VA = "0x1827EC610", Slot = "6")]
	public int IndexOf(To GABBPODJMBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x27EC680", Offset = "0x27EBA80", VA = "0x1827EC680", Slot = "7")]
	public void Insert(int GABJOMFFJAI, To GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x27EC700", Offset = "0x27EBB00", VA = "0x1827EC700", Slot = "15")]
	public bool Remove(To GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x27EC6C0", Offset = "0x27EBAC0", VA = "0x1827EC6C0", Slot = "8")]
	public void RemoveAt(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x27EC740", Offset = "0x27EBB40", VA = "0x1827EC740", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public class ADOIDKIACBE<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly Func<From, To> MDEPENANODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly Func<To, From> FAAKIAOFDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeList<From> JOLFKOMKBCI;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public To CLGONNHLFJK
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
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool HINCDHEAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	public ADOIDKIACBE(Func<From, To> MDEPENANODK, Func<To, From> FAAKIAOFDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] OGMMNHCCDJE, int HCDIEBFNKKL)
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
	public int IndexOf(To GABBPODJMBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int GABJOMFFJAI, To GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int GABJOMFFJAI)
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
public static class MEGKOIDGCEO
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public const string OIJHFLNJHNJ = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public const string JKNICMONFAM = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const string PFFMKPGABCF = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public const string OODOFBGMNBH = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const string MELGEKCFHFD = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public const string KCJBOPCNIJP = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public const string BIEBFCFHOHG = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public const string MEPIGKLHNKB = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class MGPIONKELIB
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class OPJMFEFMBHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public LODNGHNPONL services;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public OPJMFEFMBHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x4196820", Offset = "0x4195C20", VA = "0x184196820")]
		internal void <InitServices>b__1(NGENPNOGFON svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x4196880", Offset = "0x4195C80", VA = "0x184196880")]
		internal void <InitServices>b__2(CJFEEGPLPHA svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x3762AC0", Offset = "0x3761EC0", VA = "0x183762AC0")]
	public static void IIPHCEDLKCL(this AJIJKHGHPDE LIPGMHFIHCI, LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x2D85C80", Offset = "0x2D85080", VA = "0x182D85C80")]
	public static void APBNFABNBPC<T>(this AJIJKHGHPDE LIPGMHFIHCI, Action<T> JBIMBCFPDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x2D860D0", Offset = "0x2D854D0", VA = "0x182D860D0")]
	public static void KALCOFJBABO<T>(this AJIJKHGHPDE LIPGMHFIHCI, Action<T> JBIMBCFPDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D86270", Offset = "0x2D85670", VA = "0x182D86270")]
	public static void MDOAIEOBCML<T>(this AJIJKHGHPDE LIPGMHFIHCI, Action<T> JBIMBCFPDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x2D85DB0", Offset = "0x2D851B0", VA = "0x182D85DB0")]
	public static void CMIMBDEDIEK<T>(this AJIJKHGHPDE LIPGMHFIHCI, Action<T> JBIMBCFPDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D86420", Offset = "0x2D85820", VA = "0x182D86420")]
	public static void PDBGNKKDANB<T>(this AJIJKHGHPDE LIPGMHFIHCI, Action<T> JBIMBCFPDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D85F60", Offset = "0x2D85360", VA = "0x182D85F60")]
	public static void KALCOFJBABO<T>(IEnumerable<ComponentSystemBase> EIINEJPEGBG, Action<T> JBIMBCFPDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D85CF0", Offset = "0x2D850F0", VA = "0x182D85CF0")]
	private static void CHONNEMEJAJ<T>(object AAMAOJJKJKL, Action<T> JBIMBCFPDBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class OADKHJMHOCP
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class EPLLOAHPPNH
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x3A59BC0", Offset = "0x3A58FC0", VA = "0x183A59BC0")]
	public static void NKCJHAOIEOG(ComponentSystemBase AAMAOJJKJKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class HDKDIJGJJBC
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	public static bool LJGOHAGNGNE<T>(ref T KEPOHMNFLGL, ref T CFEKEMJOJGA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class BJKJALGJMOA
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class IGBMBADFPDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public IGBMBADFPDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x37D7D80", Offset = "0x37D7180", VA = "0x1837D7D80")]
	public static string JCEKIDCNJJE(Transform GCKJJOINBCJ, Transform GMEHFCMOOAG)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x38B83A0", Offset = "0x38B77A0", VA = "0x1838B83A0")]
		public static void MOOHCJAEEBD(this NOEEIPFGABG KPGPMPPLGCI, GEDGEKALBHM FAPLMCMDPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x38B7D20", Offset = "0x38B7120", VA = "0x1838B7D20")]
		public static void GALHGKDLCII(this NOEEIPFGABG KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x38B8290", Offset = "0x38B7690", VA = "0x1838B8290")]
		public static void MOOHCJAEEBD(this NOEEIPFGABG KPGPMPPLGCI, [Optional] string[] IDJFKBLKHAG, [Optional] string[] LNBAJAIEJKI, [Optional] string[] ICPHAENMAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x38B7C70", Offset = "0x38B7070", VA = "0x1838B7C70")]
		public static void EALJMCIKCOG(this NOEEIPFGABG KPGPMPPLGCI, params string[] MIHBJPNBFFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x38B7FE0", Offset = "0x38B73E0", VA = "0x1838B7FE0")]
		public static void JKHJLPGDEHL(this NOEEIPFGABG KPGPMPPLGCI, params string[] MIHBJPNBFFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x38B8090", Offset = "0x38B7490", VA = "0x1838B8090")]
		private static string[] LPCIBPOABOB(GEDGEKALBHM FAPLMCMDPDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x38B7E20", Offset = "0x38B7220", VA = "0x1838B7E20")]
		private static bool JBBPEFGAAKI(GEDGEKALBHM FAPLMCMDPDI, out string[] BPPPIHMFIOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0")]
		private static bool GFAFKJDAMKK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class CDHJAMIOEDK : KINDMNCCNKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly MethodInfo CJNGNKDFPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Type[] DMNIOKOCJFF;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x37DC420", Offset = "0x37DB820", VA = "0x1837DC420")]
	public CDHJAMIOEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action GKNBMKFOFBJ();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x37DC230", Offset = "0x37DB630", VA = "0x1837DC230")]
	public MethodInfo EOAPMOOKMMD(Action EFFJGLADCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x37DC270", Offset = "0x37DB670", VA = "0x1837DC270", Slot = "4")]
	public void MHBAMOAJPNP(Type BKGBGEHNCAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class LBKJMHNJNHN : CDHJAMIOEDK
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum ECILMKNLMKC
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x375F790", Offset = "0x375EB90", VA = "0x18375F790", Slot = "5")]
	public override Action GKNBMKFOFBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void NBNGKHCFFNK<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x375F700", Offset = "0x375EB00", VA = "0x18375F700")]
	[Preserve]
	public void DAOKBEAOGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x375F820", Offset = "0x375EC20", VA = "0x18375F820")]
	protected LBKJMHNJNHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class JHBHFLANDHP : CDHJAMIOEDK
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x3A70CA0", Offset = "0x3A700A0", VA = "0x183A70CA0", Slot = "5")]
	public override Action GKNBMKFOFBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void GKBCECCBMJH<T>() where T : HDLMEPPPPDP;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x3A70C10", Offset = "0x3A70010", VA = "0x183A70C10")]
	[Preserve]
	public void DAOKBEAOGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x375F820", Offset = "0x375EC20", VA = "0x18375F820")]
	protected JHBHFLANDHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class MLAMFBDLGCA : CDHJAMIOEDK
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x3763E10", Offset = "0x3763210", VA = "0x183763E10", Slot = "5")]
	public override Action GKNBMKFOFBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void NILFBMDPBOK<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x3763D80", Offset = "0x3763180", VA = "0x183763D80")]
	[Preserve]
	public void DAOKBEAOGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x375F820", Offset = "0x375EC20", VA = "0x18375F820")]
	protected MLAMFBDLGCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class OLCMPHKCGDO
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x3766310", Offset = "0x3765710", VA = "0x183766310")]
	public static Entity LIKOCPIDNKD(this EntityManager BOGIEIBMFCN)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[NAPHGBOEKGO(GPIMBHHJLKL.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class FNBOHBOPMEA : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x332E3E0", Offset = "0x332D7E0", VA = "0x18332E3E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4190420", Offset = "0x418F820", VA = "0x184190420", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x418CD20", Offset = "0x418C120", VA = "0x18418CD20")]
			[DebuggerHidden]
			public FNBOHBOPMEA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x4190250", Offset = "0x418F650", VA = "0x184190250", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x41903E0", Offset = "0x418F7E0", VA = "0x1841903E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x4190330", Offset = "0x418F730", VA = "0x184190330", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x4190330", Offset = "0x418F730", VA = "0x184190330", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class FPICOBLMPJO : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x332E3E0", Offset = "0x332D7E0", VA = "0x18332E3E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4190750", Offset = "0x418FB50", VA = "0x184190750", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x418CD20", Offset = "0x418C120", VA = "0x18418CD20")]
			[DebuggerHidden]
			public FPICOBLMPJO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x41907A0", Offset = "0x418FBA0", VA = "0x1841907A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x4190470", Offset = "0x418F870", VA = "0x184190470", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x4190830", Offset = "0x418FC30", VA = "0x184190830")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x4190710", Offset = "0x418FB10", VA = "0x184190710", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x4190660", Offset = "0x418FA60", VA = "0x184190660", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x4190660", Offset = "0x418FA60", VA = "0x184190660", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class CCGGEKGEPHM : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x332E3E0", Offset = "0x332D7E0", VA = "0x18332E3E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x418CB60", Offset = "0x418BF60", VA = "0x18418CB60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x418CD20", Offset = "0x418C120", VA = "0x18418CD20")]
			[DebuggerHidden]
			public CCGGEKGEPHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x418CBB0", Offset = "0x418BFB0", VA = "0x18418CBB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x418C750", Offset = "0x418BB50", VA = "0x18418C750", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x418CC80", Offset = "0x418C080", VA = "0x18418CC80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x418CCD0", Offset = "0x418C0D0", VA = "0x18418CCD0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x418CB20", Offset = "0x418BF20", VA = "0x18418CB20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x418CA80", Offset = "0x418BE80", VA = "0x18418CA80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x418CA80", Offset = "0x418BE80", VA = "0x18418CA80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E760", Offset = "0x3A5DB60", VA = "0x183A5E760")]
		public static Entity EDPKPOFPNJM(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F690", Offset = "0x3A5EA90", VA = "0x183A5F690")]
		public static DynamicBuffer<ChildrenData> OIBMLMLGCPN(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EAE0", Offset = "0x3A5DEE0", VA = "0x183A5EAE0")]
		public static DynamicBuffer<ChildrenData> HIPLAPBKCAG(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EDD0", Offset = "0x3A5E1D0", VA = "0x183A5EDD0")]
		public static NativeArray<Entity> LPGPKKCBHAJ(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, Allocator NDJJBKEIGCD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E180", Offset = "0x3A5D580", VA = "0x183A5E180")]
		public static bool AOBDBFKFPNM(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, Allocator NDJJBKEIGCD, out NativeArray<Entity> CNACFCEIFNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F530", Offset = "0x3A5E930", VA = "0x183A5F530")]
		public static NativeArray<Entity> ODACCAEJELB(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E930", Offset = "0x3A5DD30", VA = "0x183A5E930")]
		public static Entity HBBCLKEHJJL(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, int GABJOMFFJAI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F1B0", Offset = "0x3A5E5B0", VA = "0x183A5F1B0")]
		public static int MOGIMNPNCEG(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E280", Offset = "0x3A5D680", VA = "0x183A5E280")]
		public static void CAKPAMLBOAC(NativeArray<Entity> ELOPNHNIFCF, NativeArray<Entity> GNLABAOMILF, EntityManager BOGIEIBMFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E7D0", Offset = "0x3A5DBD0", VA = "0x183A5E7D0")]
		public static int EHIKEGGIGBG(this EntityManager BOGIEIBMFCN, Entity CNDFBGEJOLI, Entity NEICBHGNPLE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EB70", Offset = "0x3A5DF70", VA = "0x183A5EB70")]
		public static bool IIGANFODEDB(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, Entity OPNIEJJIALI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F0A0", Offset = "0x3A5E4A0", VA = "0x183A5F0A0")]
		public static IEnumerable<Entity> MICCIAHJHAI(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, bool CNIDJIFJCJI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E880", Offset = "0x3A5DC80", VA = "0x183A5E880")]
		public static bool ENDIFHCCJBL(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, Entity NEICBHGNPLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x3A5ECD0", Offset = "0x3A5E0D0", VA = "0x183A5ECD0")]
		public static bool JJDKPLMOHNG(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, Entity KIKPCHNHCOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F720", Offset = "0x3A5EB20", VA = "0x183A5F720")]
		public static NativeList<Entity> PHAECPIPHPL(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, bool CNIDJIFJCJI = false, Allocator NDJJBKEIGCD = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E5E0", Offset = "0x3A5D9E0", VA = "0x183A5E5E0")]
		public static IEnumerable<Entity> DJKJJBBCCIG(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, bool CNIDJIFJCJI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E4E0", Offset = "0x3A5D8E0", VA = "0x183A5E4E0")]
		public static Entity CFGEIGEDAJC(this EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EF00", Offset = "0x3A5E300", VA = "0x183A5EF00")]
		public static bool MAHIHPJAEKH(this EntityManager BOGIEIBMFCN, Entity KIKPCHNHCOF, Entity ACEOMEGCOKM, out Entity ACLPGKKPMDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x3A5ED50", Offset = "0x3A5E150", VA = "0x183A5ED50")]
		internal static void KCCOFFAPMLN(EntityManager BOGIEIBMFCN, Entity CNDFBGEJOLI, Entity NEICBHGNPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F3A0", Offset = "0x3A5E7A0", VA = "0x183A5F3A0")]
		internal static void NINICJMPHGP(EntityManager BOGIEIBMFCN, Entity CNDFBGEJOLI, Entity NEICBHGNPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F930", Offset = "0x3A5ED30", VA = "0x183A5F930")]
		[IteratorStateMachine(typeof(FNBOHBOPMEA))]
		private static IEnumerable<Entity> PIKGFEDLBAF(EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, bool CNIDJIFJCJI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F4A0", Offset = "0x3A5E8A0", VA = "0x183A5F4A0")]
		[IteratorStateMachine(typeof(FPICOBLMPJO))]
		private static IEnumerable<Entity> NKNLGDPOFOA(EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, bool CNIDJIFJCJI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EA60", Offset = "0x3A5DE60", VA = "0x183A5EA60")]
		[IteratorStateMachine(typeof(CCGGEKGEPHM))]
		private static IEnumerable<Entity> HBGHJOMJLEB(EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x3A5F2C0", Offset = "0x3A5E6C0", VA = "0x183A5F2C0")]
		private static bool NGNNGFKPFKF(EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, Entity OPNIEJJIALI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[AOJPGBJKDNL(typeof(FJFNAPPGKJO), new string[] { })]
public class EDBMMDOKCAG : FJFNAPPGKJO, DIACEKEHMCI, AAHLPGOALAE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private LODNGHNPONL KPGPMPPLGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private PFHNJBGFDIA CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private KGJHIIIKFIO NJJGKMIKDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private GHOBGEJJNGE CBHBKOJKJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private OBNLPCJMAPP MDDAOJACOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private AOJCNPMLIMB KBMLCGACCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private HMKLFLHGJEI NOGKNHKHMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private AHIIJGCPLGM IGDJIEOLHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private MPCADNMEKPJ FIJECBKDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private KGNMEDAKICL APNFBCPFPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private EPMLANJFBCG GIACJDLKPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private DFBNDOPHHMN AKCKMDEOLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private HADKCCFJPOA NLIOPACJONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private EBHDABDPCJI BNBOCENBAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private HKKJODMDCGO KPGCPMFDAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private JCBGDHAMIAG BHBPPIIECMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private HCMIDMOMIFO NACMNJKAKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private KMPDMJCJEEE IGPFOGNKFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private KJFHICGMDLJ ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public LODNGHNPONL ECODFCBICCB
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public PFHNJBGFDIA PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public CBGJJCKMFCA PHIKONIBLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public KGJHIIIKFIO FICFIPEJFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public GHOBGEJJNGE PICBHMCFDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public LBIICBANFEM PFPFEJCGPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public OBNLPCJMAPP NIAOPJFMOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x6D2590", Offset = "0x6D1990", VA = "0x1806D2590", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public AOJCNPMLIMB DHLDNNJJLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6E1530", Offset = "0x6E0930", VA = "0x1806E1530", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public HMKLFLHGJEI CDCFEHMDHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x6E27A0", Offset = "0x6E1BA0", VA = "0x1806E27A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public AHIIJGCPLGM JPGDOGKHOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6E0", Offset = "0x6C9AE0", VA = "0x1806CA6E0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public MPCADNMEKPJ JPDHPKBIGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x845B30", Offset = "0x844F30", VA = "0x180845B30", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public KGNMEDAKICL ALOEHINEEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x845B40", Offset = "0x844F40", VA = "0x180845B40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public EPMLANJFBCG DMJHAGGNJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x75A820", Offset = "0x759C20", VA = "0x18075A820", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public DFBNDOPHHMN ABEDOKHPDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE290", Offset = "0x7ED690", VA = "0x1807EE290", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public HADKCCFJPOA BKLGFBKLNMB
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC630", Offset = "0x8ABA30", VA = "0x1808AC630", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public EBHDABDPCJI ADHOKBGNHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8201E0", Offset = "0x81F5E0", VA = "0x1808201E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public HKKJODMDCGO CBJBFBNMLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x884180", Offset = "0x883580", VA = "0x180884180", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public JCBGDHAMIAG NBDHCMHAEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x795BC0", Offset = "0x794FC0", VA = "0x180795BC0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public HCMIDMOMIFO DBIJFCHEHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x845B50", Offset = "0x844F50", VA = "0x180845B50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public KMPDMJCJEEE GABDCOLIEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x78ADA0", Offset = "0x78A1A0", VA = "0x18078ADA0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public KJFHICGMDLJ IKEDJKKINNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x78AE60", Offset = "0x78A260", VA = "0x18078AE60", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public KGKNKCKDPOC OENHCKDAAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x6C6940", Offset = "0x6C5D40", VA = "0x1806C6940", Slot = "21")]
		get
		{
			return default(KGKNKCKDPOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x3A574D0", Offset = "0x3A568D0", VA = "0x183A574D0", Slot = "22")]
	public void FGMBIJAJIBC(LODNGHNPONL BINMGLGOIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x29363D0", Offset = "0x29357D0", VA = "0x1829363D0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x3A574B0", Offset = "0x3A568B0", VA = "0x183A574B0", Slot = "23")]
	public void DNDHHJNBJKB(LODNGHNPONL BINMGLGOIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public EDBMMDOKCAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
public class GGJAJAPBCHB : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class CIJGGEBIENL : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public GGJAJAPBCHB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7B9670", Offset = "0x7B8A70", VA = "0x1807B9670", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x418D4B0", Offset = "0x418C8B0", VA = "0x18418D4B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8815D0", Offset = "0x8809D0", VA = "0x1808815D0")]
		[DebuggerHidden]
		public CIJGGEBIENL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x418D300", Offset = "0x418C700", VA = "0x18418D300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x418D470", Offset = "0x418C870", VA = "0x18418D470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected const ulong DIJBIPMPNHH = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected const ulong MLKMHLOIPEB = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected const int CMINEDEJAIJ = 8;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected const int DBGHEFJEPCF = 6;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public const int LFFOGGCLOCH = 64;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected const int JCLANEJHLCK = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> NLOMBEPEFEF;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x705BB0", Offset = "0x704FB0", VA = "0x180705BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int LDHGJGEIMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x7B9530", Offset = "0x7B8930", VA = "0x1807B9530")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x859AE0", VA = "0x18085A6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x3A63350", Offset = "0x3A62750", VA = "0x183A63350")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x3A63C30", Offset = "0x3A63030", VA = "0x183A63C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x3A63F60", Offset = "0x3A63360", VA = "0x183A63F60")]
	public GGJAJAPBCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x3A63ED0", Offset = "0x3A632D0", VA = "0x183A63ED0")]
	public GGJAJAPBCHB(int NKILFKIIOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x3A63680", Offset = "0x3A62A80", VA = "0x183A63680")]
	public bool CAELOGMIJLF(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x3A63DE0", Offset = "0x3A631E0", VA = "0x183A63DE0")]
	public bool PPIENHLDDKJ(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x3A63850", Offset = "0x3A62C50", VA = "0x183A63850")]
	public bool DJIDJDFENKN(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x3A63C20", Offset = "0x3A63020", VA = "0x183A63C20")]
	public bool NFDBEOJPGBB(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x3A63B90", Offset = "0x3A62F90", VA = "0x183A63B90")]
	public void MIAGPIHMCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x3A63260", Offset = "0x3A62660", VA = "0x183A63260")]
	public void BAKFMNEDAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x3A63760", Offset = "0x3A62B60", VA = "0x183A63760")]
	public void CODPHMBGNGD(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x3A633F0", Offset = "0x3A627F0", VA = "0x183A633F0")]
	public void BIEFCABEIDG(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x3A63940", Offset = "0x3A62D40", VA = "0x183A63940")]
	public bool JCADDNHHNDG(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x3A63140", Offset = "0x3A62540", VA = "0x183A63140")]
	public void APLKJOMBNBE(int BPNKPMGDGFM, int NDNADCNCIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x3A639D0", Offset = "0x3A62DD0", VA = "0x183A639D0")]
	public void MEEIMOPEFDN(int EAGKIPIDCMM, int MKNAKGGPFHI, int NDNADCNCIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x3A635B0", Offset = "0x3A629B0", VA = "0x183A635B0")]
	public int BKCAAEBNAMB(int NDNADCNCIGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x3A63540", Offset = "0x3A62940", VA = "0x183A63540")]
	public int BKCAAEBNAMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x3A634F0", Offset = "0x3A628F0", VA = "0x183A634F0")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x3A638D0", Offset = "0x3A62CD0", VA = "0x183A638D0", Slot = "4")]
	[IteratorStateMachine(typeof(CIJGGEBIENL))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x3A638D0", Offset = "0x3A62CD0", VA = "0x183A638D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class AFJAPLICIKD<T> : global::HBHFCNDJOGE<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	protected global::KILHOBKHHEE<T> BGJGBACCLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected global::DNPFLMOCAND<T> MBMJEPEFJPJ;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x21AEE40", Offset = "0x21AE240", VA = "0x1821AEE40")]
	public AFJAPLICIKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x321DB40", Offset = "0x321CF40", VA = "0x18321DB40")]
	public AFJAPLICIKD(global::KILHOBKHHEE<T> BGJGBACCLEC, global::DNPFLMOCAND<T> MBMJEPEFJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x321D450", Offset = "0x321C850", VA = "0x18321D450", Slot = "11")]
	public override T AHLFMBEKFNG(DBPKKLEDFIK NOFNKJMDFLE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x321D790", Offset = "0x321CB90", VA = "0x18321D790", Slot = "12")]
	public override void DGECGJPLFOM(DBPKKLEDFIK NOFNKJMDFLE, T FPLJCBGEJAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class AOIEKGLPBLB
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x3823870", Offset = "0x3822C70", VA = "0x183823870")]
	public static ODHBKAFBAFM MHBAMOAJPNP<T>(this NEIJEAAGLGP FIJECBKDHDI, global::KPNHCHMCPJM<T> LBEPPIIBMPA, global::KILHOBKHHEE<T> BGJGBACCLEC, global::DNPFLMOCAND<T> MBMJEPEFJPJ) where T : struct
	{
		return default(ODHBKAFBAFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class FNMLIMGMGHP<T> : global::AFJAPLICIKD<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BA70", Offset = "0x3E9AE70", VA = "0x183E9BA70")]
	public FNMLIMGMGHP(T NEOBGLMFFNI, T OKNLCAAGMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class PCAMBHFNIGM<T> : global::HBHFCNDJOGE<T> where T : struct, HDLMEPPPPDP
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB050", Offset = "0x3FEA450", VA = "0x183FEB050", Slot = "11")]
	public override T AHLFMBEKFNG(DBPKKLEDFIK NOFNKJMDFLE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB0E0", Offset = "0x3FEA4E0", VA = "0x183FEB0E0", Slot = "12")]
	public override void DGECGJPLFOM(DBPKKLEDFIK NOFNKJMDFLE, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x3044320", Offset = "0x3043720", VA = "0x183044320")]
	public PCAMBHFNIGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class CMBEANPKIIJ : CHOEJHEAIHK
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public abstract Type LKCIKFECNNA
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void AHLFMBEKFNG(DBPKKLEDFIK NOFNKJMDFLE, in IPEAPPMEIFD FPLJCBGEJAP);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void DGECGJPLFOM(DBPKKLEDFIK NOFNKJMDFLE, in NICFNFKBPKA FPLJCBGEJAP);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void MNOJECLHCBE(DBPKKLEDFIK NOFNKJMDFLE, EFJDBJPHNDA DKKFHIFLMPL, [Optional] object OEGBAMNPENI);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	protected CMBEANPKIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class HBHFCNDJOGE<T> : CMBEANPKIIJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public override Type LKCIKFECNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x43908F0", Offset = "0x438FCF0", VA = "0x1843908F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T AHLFMBEKFNG(DBPKKLEDFIK NOFNKJMDFLE);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void DGECGJPLFOM(DBPKKLEDFIK NOFNKJMDFLE, T FPLJCBGEJAP);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x438F930", Offset = "0x438ED30", VA = "0x18438F930", Slot = "8")]
	public override void AHLFMBEKFNG(DBPKKLEDFIK NOFNKJMDFLE, in IPEAPPMEIFD GMEHFCMOOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x4390EE0", Offset = "0x43902E0", VA = "0x184390EE0", Slot = "9")]
	public override void DGECGJPLFOM(DBPKKLEDFIK NOFNKJMDFLE, in NICFNFKBPKA HNJNABPJHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x4391440", Offset = "0x4390840", VA = "0x184391440", Slot = "10")]
	public override void MNOJECLHCBE(DBPKKLEDFIK NOFNKJMDFLE, EFJDBJPHNDA DKKFHIFLMPL, object OEGBAMNPENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x25390D0", Offset = "0x25384D0", VA = "0x1825390D0")]
	protected HBHFCNDJOGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class DOIMEDHPHDL
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class BIJBFIMEAHG
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class LEKADHAJFBJ<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
			public LEKADHAJFBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x2E9C5B0", Offset = "0x2E9B9B0", VA = "0x182E9C5B0")]
			internal void <RegisterFixedString>b__0(DBPKKLEDFIK p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x2E9C9D0", Offset = "0x2E9BDD0", VA = "0x182E9C9D0")]
			internal T <RegisterFixedString>b__1(DBPKKLEDFIK p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x418B090", Offset = "0x418A490", VA = "0x18418B090")]
		public static void EDCAMMHLONH(BAMNIKPLIAE DJINGHENHLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x365C4A0", Offset = "0x365B8A0", VA = "0x18365C4A0")]
		private static void AJNBEJJKNDM<T>(BAMNIKPLIAE DJINGHENHLO, int OKNLCAAGMLN) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x365CC10", Offset = "0x365C010", VA = "0x18365CC10")]
		private static void HGCLOCAFJGG<T>(DBPKKLEDFIK KONDPAFENHO, T OLMDMLKDJGG, int OKNLCAAGMLN) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x365C5C0", Offset = "0x365B9C0", VA = "0x18365C5C0")]
		private static T FOLOJBONBLB<T>(DBPKKLEDFIK KONDPAFENHO, int OKNLCAAGMLN) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BIJBFIMEAHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class KNAOFODMBPK : LBKJMHNJNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private BAMNIKPLIAE DJINGHENHLO;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x3669B60", Offset = "0x3668F60", VA = "0x183669B60", Slot = "6")]
		public override void NBNGKHCFFNK<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x41943F0", Offset = "0x41937F0", VA = "0x1841943F0")]
		public static void DBDHMBBJJIH(BAMNIKPLIAE DJINGHENHLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x41944A0", Offset = "0x41938A0", VA = "0x1841944A0")]
		public KNAOFODMBPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x37EDC10", Offset = "0x37ED010", VA = "0x1837EDC10")]
	public static void EBJOJHKEICG(BAMNIKPLIAE DJINGHENHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x33E9F50", Offset = "0x33E9350", VA = "0x1833E9F50")]
	public static void NIBBEJNJOPI<T>(BAMNIKPLIAE DJINGHENHLO, global::KILHOBKHHEE<T> BGJGBACCLEC, global::DNPFLMOCAND<T> MBMJEPEFJPJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x33E9FE0", Offset = "0x33E93E0", VA = "0x1833E9FE0")]
	public static void PHDMJCDNOAE<T>(BAMNIKPLIAE JJCCPFKLFDH) where T : struct, HDLMEPPPPDP
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
public interface BAMNIKPLIAE : global::CALFICILEMO<BAMNIKPLIAE>
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHBAMOAJPNP(Type BKGBGEHNCAE, CHOEJHEAIHK JJCCPFKLFDH);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNEMJPBHGAN(Type BKGBGEHNCAE, out CHOEJHEAIHK JJCCPFKLFDH);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class INJJPPJLEBI
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F2D0", Offset = "0x3A6E6D0", VA = "0x183A6F2D0")]
	public static void MHBAMOAJPNP(this BAMNIKPLIAE OCGDPJBGCPH, CHOEJHEAIHK JJCCPFKLFDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[AOJPGBJKDNL(typeof(NEIJEAAGLGP), new string[] { })]
public sealed class OCCBFEPBDMO : NEIJEAAGLGP, global::CALFICILEMO<NEIJEAAGLGP>, HIJIFLANIAO, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly Dictionary<ODHBKAFBAFM, CHOEJHEAIHK> DJINGHENHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private BAMNIKPLIAE MPIJNBCNOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private IBKMFFMCCLE FIJECBKDHDI;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool KGFDONFCHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x8A81C0", Offset = "0x8A75C0", VA = "0x1808A81C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x8A8250", Offset = "0x8A7650", VA = "0x1808A8250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x37657F0", Offset = "0x3764BF0", VA = "0x1837657F0")]
	public OCCBFEPBDMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x3765730", Offset = "0x3764B30", VA = "0x183765730")]
	public OCCBFEPBDMO(Dictionary<ODHBKAFBAFM, CHOEJHEAIHK> DJINGHENHLO, bool IGCEGHFKJBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x3765440", Offset = "0x3764840", VA = "0x183765440", Slot = "7")]
	public void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x37656B0", Offset = "0x3764AB0", VA = "0x1837656B0", Slot = "8")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x3764FF0", Offset = "0x37643F0", VA = "0x183764FF0", Slot = "9")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x37655E0", Offset = "0x37649E0", VA = "0x1837655E0", Slot = "4")]
	public ODHBKAFBAFM NEDGFNNHBJL(BFOMGEBLKLE LBEPPIIBMPA)
	{
		return default(ODHBKAFBAFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x37652D0", Offset = "0x37646D0", VA = "0x1837652D0", Slot = "5")]
	public void MHBAMOAJPNP(ODHBKAFBAFM BJKMNBIBKCI, CHOEJHEAIHK JJCCPFKLFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x37654A0", Offset = "0x37648A0", VA = "0x1837654A0")]
	[Conditional("DEBUG_BUILD")]
	private void NAONDIOODGK(ODHBKAFBAFM BJKMNBIBKCI, Type BKGBGEHNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x3765120", Offset = "0x3764520", VA = "0x183765120", Slot = "6")]
	public bool KNEMJPBHGAN(ODHBKAFBAFM BJKMNBIBKCI, out CHOEJHEAIHK JJCCPFKLFDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x3765040", Offset = "0x3764440", VA = "0x183765040", Slot = "10")]
	public NEIJEAAGLGP JNDHFKLKEGH()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[AOJPGBJKDNL(typeof(BAMNIKPLIAE), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.TypeSerializer)]
	public sealed class TypeSerializerService : HIJIFLANIAO, BAMNIKPLIAE, global::CALFICILEMO<BAMNIKPLIAE>
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly Dictionary<Type, CHOEJHEAIHK> DJINGHENHLO;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool KGFDONFCHIL
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x85F6B0", Offset = "0x85EAB0", VA = "0x18085F6B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x85F6C0", Offset = "0x85EAC0", VA = "0x18085F6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x38C2B60", Offset = "0x38C1F60", VA = "0x1838C2B60")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x38C2BE0", Offset = "0x38C1FE0", VA = "0x1838C2BE0")]
		public TypeSerializerService(Dictionary<Type, CHOEJHEAIHK> DJINGHENHLO, bool IGCEGHFKJBM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x38C2AB0", Offset = "0x38C1EB0", VA = "0x1838C2AB0", Slot = "4")]
		public void MPBHMBLFPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x38C2990", Offset = "0x38C1D90", VA = "0x1838C2990", Slot = "5")]
		public void MHBAMOAJPNP(Type BKGBGEHNCAE, CHOEJHEAIHK JJCCPFKLFDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x38C28B0", Offset = "0x38C1CB0", VA = "0x1838C28B0", Slot = "6")]
		public bool KNEMJPBHGAN(Type BKGBGEHNCAE, out CHOEJHEAIHK JJCCPFKLFDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x38C27D0", Offset = "0x38C1BD0", VA = "0x1838C27D0", Slot = "7")]
		public BAMNIKPLIAE JNDHFKLKEGH()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[AOJPGBJKDNL(typeof(GBIFJOHCKMP), new string[] { })]
internal sealed class KHIALHAOOAP : GBIFJOHCKMP, HIJIFLANIAO, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<ODHBKAFBAFM, FDAKKAHNGPF> LKJIJIHBOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private IBKMFFMCCLE FIJECBKDHDI;

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A74150", Offset = "0x3A73550", VA = "0x183A74150", Slot = "6")]
	public void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A741A0", Offset = "0x3A735A0", VA = "0x183A741A0", Slot = "7")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A74070", Offset = "0x3A73470", VA = "0x183A74070", Slot = "4")]
	public void MHBAMOAJPNP(ODHBKAFBAFM IIMBCOAEFMJ, Type ECFGKAILADN, FDAKKAHNGPF EBHPPLOKGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A740E0", Offset = "0x3A734E0", VA = "0x183A740E0", Slot = "5")]
	public bool MOFIGDHINIK(ODHBKAFBAFM IIMBCOAEFMJ, out FDAKKAHNGPF EBHPPLOKGNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A73EE0", Offset = "0x3A732E0", VA = "0x183A73EE0")]
	[Conditional("DEBUG_BUILD")]
	private void DABPFDIIMFJ(ODHBKAFBAFM IIMBCOAEFMJ, Type ECFGKAILADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A74200", Offset = "0x3A73600", VA = "0x183A74200")]
	public KHIALHAOOAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[AOJPGBJKDNL(typeof(HEHCADFJNKG), new string[] { })]
internal sealed class GDEPLNCNLHB : HEHCADFJNKG, HPLECDDPLCA, HIJIFLANIAO, NGENPNOGFON, CJFEEGPLPHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly GGJAJAPBCHB HKOKBJPDALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly Dictionary<EHNBIOJHEAD, int> EMGILIFDKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Stack<int> HGIIACEOIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[CPICBLLAMOM]
	private IBKMFFMCCLE FIJECBKDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[CPICBLLAMOM]
	private LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private int NPOCACFPPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x3A62A30", Offset = "0x3A61E30", VA = "0x183A62A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool LAFJIBMJEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x782DE0", Offset = "0x7821E0", VA = "0x180782DE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x782E60", Offset = "0x782260", VA = "0x180782E60", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x3A62310", Offset = "0x3A61710", VA = "0x183A62310", Slot = "6")]
	public void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A62A80", Offset = "0x3A61E80", VA = "0x183A62A80", Slot = "7")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A62840", Offset = "0x3A61C40", VA = "0x183A62840", Slot = "8")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A627A0", Offset = "0x3A61BA0", VA = "0x183A627A0")]
	private void HHECIPEFGHJ(KJNCFICFIIE GNKPFNIMJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A628F0", Offset = "0x3A61CF0", VA = "0x183A628F0", Slot = "4")]
	public bool IODDEEIEDNM(EHNBIOJHEAD DGDIPHPMEJP, ODHBKAFBAFM JGMFKPLFFDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A62450", Offset = "0x3A61850", VA = "0x183A62450", Slot = "5")]
	public void EDJDDNBFHLK(EHNBIOJHEAD DGDIPHPMEJP, Span<ODHBKAFBAFM> FIJECBKDHDI, bool JEPFMIKDHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A62310", Offset = "0x3A61710", VA = "0x183A62310", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x3A62B00", Offset = "0x3A61F00", VA = "0x183A62B00")]
	public GDEPLNCNLHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class MFBLMEJBEGG
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x3762A40", Offset = "0x3761E40", VA = "0x183762A40")]
	public static void NJBDNEDJHCL(this DBPKKLEDFIK NOFNKJMDFLE, ReadOnlyMemory<byte> JGLHHPMNIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D851E0", Offset = "0x2D845E0", VA = "0x182D851E0")]
	public static void DCPECBLCMDK<T>(this DBPKKLEDFIK NOFNKJMDFLE, in T FPLJCBGEJAP) where T : struct, HDLMEPPPPDP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D85310", Offset = "0x2D84710", VA = "0x182D85310")]
	public static T IPPEHHLAJBB<T>(this DBPKKLEDFIK NOFNKJMDFLE) where T : struct, HDLMEPPPPDP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x3762710", Offset = "0x3761B10", VA = "0x183762710")]
	public static void DCPECBLCMDK(this DBPKKLEDFIK NOFNKJMDFLE, MLGPAOMHKKE EENPNEENKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x3762A10", Offset = "0x3761E10", VA = "0x183762A10")]
	public static MLGPAOMHKKE MFKLFPLMNHP(this DBPKKLEDFIK NOFNKJMDFLE)
	{
		return default(MLGPAOMHKKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x3762860", Offset = "0x3761C60", VA = "0x183762860")]
	public static void JKNFCKFLCHE(this DBPKKLEDFIK CDLKNDDFOPH, uint GMLEFJOJLJB, bool HPIKPIPDPCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x3762740", Offset = "0x3761B40", VA = "0x183762740")]
	public static uint FIDCFCHFMFL(this DBPKKLEDFIK LGIEPMOBDDP, bool HPIKPIPDPCJ = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class AOILLCFBFJJ
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class CKOLBPLOPLC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public CKOLBPLOPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x4069FB0", Offset = "0x40693B0", VA = "0x184069FB0")]
		internal void <GetByteEnumDelegates>b__0(DBPKKLEDFIK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x406A020", Offset = "0x4069420", VA = "0x18406A020")]
		internal T <GetByteEnumDelegates>b__1(DBPKKLEDFIK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class JLPIEFEEIGC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public JLPIEFEEIGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x379DB50", Offset = "0x379CF50", VA = "0x18379DB50")]
		internal void <GetSByteEnumDelegates>b__0(DBPKKLEDFIK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x379DBC0", Offset = "0x379CFC0", VA = "0x18379DBC0")]
		internal T <GetSByteEnumDelegates>b__1(DBPKKLEDFIK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class LOLJGHEDAFG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public LOLJGHEDAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x3BF50E0", Offset = "0x3BF44E0", VA = "0x183BF50E0")]
		internal void <GetShortEnumDelegates>b__0(DBPKKLEDFIK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5150", Offset = "0x3BF4550", VA = "0x183BF5150")]
		internal T <GetShortEnumDelegates>b__1(DBPKKLEDFIK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class MAHEKDOMFNP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public MAHEKDOMFNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E56910", Offset = "0x3E55D10", VA = "0x183E56910")]
		internal void <GetUShortEnumDelegates>b__0(DBPKKLEDFIK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E56980", Offset = "0x3E55D80", VA = "0x183E56980")]
		internal T <GetUShortEnumDelegates>b__1(DBPKKLEDFIK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class IEJGEDDEPKL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public IEJGEDDEPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x27EF290", Offset = "0x27EE690", VA = "0x1827EF290")]
		internal void <GetIntEnumDelegates>b__0(DBPKKLEDFIK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x27EF2F0", Offset = "0x27EE6F0", VA = "0x1827EF2F0")]
		internal T <GetIntEnumDelegates>b__1(DBPKKLEDFIK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class HIIMEOKNGAA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public HIIMEOKNGAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x39CEDD0", Offset = "0x39CE1D0", VA = "0x1839CEDD0")]
		internal void <GetUIntEnumDelegates>b__0(DBPKKLEDFIK b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x39CEE30", Offset = "0x39CE230", VA = "0x1839CEE30")]
		internal T <GetUIntEnumDelegates>b__1(DBPKKLEDFIK b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x3823D00", Offset = "0x3823100", VA = "0x183823D00")]
	public static void LNOPJLJBJPJ<T>(T NEOBGLMFFNI, T OKNLCAAGMLN, out global::KILHOBKHHEE<T> JAEHIHDKING, out global::DNPFLMOCAND<T> EJLJNJPENKO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x3823910", Offset = "0x3822D10", VA = "0x183823910")]
	private static void DFHDCDKDHHA<T>(T NEOBGLMFFNI, T OKNLCAAGMLN, out global::KILHOBKHHEE<T> JAEHIHDKING, out global::DNPFLMOCAND<T> EJLJNJPENKO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x3823910", Offset = "0x3822D10", VA = "0x183823910")]
	private static void BPGBCENEGPK<T>(T NEOBGLMFFNI, T OKNLCAAGMLN, out global::KILHOBKHHEE<T> JAEHIHDKING, out global::DNPFLMOCAND<T> EJLJNJPENKO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x3823BB0", Offset = "0x3822FB0", VA = "0x183823BB0")]
	private static void ICFHDNCINJD<T>(T NEOBGLMFFNI, T OKNLCAAGMLN, out global::KILHOBKHHEE<T> JAEHIHDKING, out global::DNPFLMOCAND<T> EJLJNJPENKO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x3823BB0", Offset = "0x3822FB0", VA = "0x183823BB0")]
	private static void NNMPBMNGFGJ<T>(T NEOBGLMFFNI, T OKNLCAAGMLN, out global::KILHOBKHHEE<T> JAEHIHDKING, out global::DNPFLMOCAND<T> EJLJNJPENKO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x3823A60", Offset = "0x3822E60", VA = "0x183823A60")]
	private static void CAJEMLGEKND<T>(T NEOBGLMFFNI, T OKNLCAAGMLN, out global::KILHOBKHHEE<T> JAEHIHDKING, out global::DNPFLMOCAND<T> EJLJNJPENKO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x3823A60", Offset = "0x3822E60", VA = "0x183823A60")]
	private static void IOFBNCKKJIN<T>(T NEOBGLMFFNI, T OKNLCAAGMLN, out global::KILHOBKHHEE<T> JAEHIHDKING, out global::DNPFLMOCAND<T> EJLJNJPENKO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class MNFBGMCBKNK : GJGFLACDHIB, CJFEEGPLPHA
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x3763EA0", Offset = "0x37632A0", VA = "0x183763EA0", Slot = "4")]
	private void HLBPGANEKBK(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void FHCCKNOBLNP(NEIJEAAGLGP FIJECBKDHDI);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
	protected MNFBGMCBKNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[KHBLHPCMBEB(typeof(LocalPoseData))]
public sealed class EMFNGANCGEM : MNFBGMCBKNK
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x3A59220", Offset = "0x3A58620", VA = "0x183A59220", Slot = "5")]
	protected override void FHCCKNOBLNP(NEIJEAAGLGP FIJECBKDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640")]
	public EMFNGANCGEM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	internal class CopyAuthorityToEntity : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery HLHEPPGOKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery OBPCGEMBNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery KLGGHNCMBHH;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x37E6C50", Offset = "0x37E6050", VA = "0x1837E6C50", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x37E6A90", Offset = "0x37E5E90", VA = "0x1837E6A90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x37E6C10", Offset = "0x37E6010", VA = "0x1837E6C10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x37E6BE0", Offset = "0x37E5FE0", VA = "0x1837E6BE0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x37E6110", Offset = "0x37E5510", VA = "0x1837E6110")]
		private void FPJJAFDLIKO(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x37E6810", Offset = "0x37E5C10", VA = "0x1837E6810")]
		private void NAOCAIOCNIA(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x37E5E30", Offset = "0x37E5230", VA = "0x1837E5E30")]
		private void AIJMNIJONBH(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x37E6660", Offset = "0x37E5A60", VA = "0x1837E6660")]
		private void MMGMMGGJDGH(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x37E6450", Offset = "0x37E5850", VA = "0x1837E6450")]
		private void HNEBLJKLOJL(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x37E69B0", Offset = "0x37E5DB0", VA = "0x1837E69B0")]
		private void OIFOFELOIEA(KJNCFICFIIE GNKPFNIMJND, int CPILGALONLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class AMPHNFLDNPF : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityQuery FDOFAODBNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private PFHNJBGFDIA CMMLIBKHPCN;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x37D4DD0", Offset = "0x37D41D0", VA = "0x1837D4DD0", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x37D4940", Offset = "0x37D3D40", VA = "0x1837D4940", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x37D4A00", Offset = "0x37D3E00", VA = "0x1837D4A00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x37D4360", Offset = "0x37D3760", VA = "0x1837D4360")]
	private void IBLALIFKKKF(NativeArray<Entity> NMNOLKKCICL, NativeList<Entity> DIGHIDCMLPJ, ComponentDataFromEntity<BNAIGBHANBK> FDEPAOEDNLF, BufferFromEntity<ChildrenData> JDCHJNENCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public AMPHNFLDNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class PFPIHBGGBGH : ParentSystemBase<AuthoredParentData, PHBKBJJGFLG, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x37744D0", Offset = "0x37738D0", VA = "0x1837744D0", Slot = "14")]
	protected override EntityQueryDesc GDPNCHKMMOA(EntityQueryDesc FDOFAODBNNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x8F39B0", Offset = "0x8F2DB0", VA = "0x1808F39B0", Slot = "15")]
	protected override EntityQueryDesc KKDOCOFCFDD(EntityQueryDesc FDOFAODBNNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x3774510", Offset = "0x3773910", VA = "0x183774510", Slot = "16")]
	protected override EntityQueryDesc GGOHFCKNEMO(EntityQueryDesc FDOFAODBNNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x3774550", Offset = "0x3773950", VA = "0x183774550", Slot = "17")]
	protected override EntityQueryDesc HFNMEGKHBJP(EntityQueryDesc FDOFAODBNNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x37745D0", Offset = "0x37739D0", VA = "0x1837745D0")]
	public PFPIHBGGBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x3774590", Offset = "0x3773990", VA = "0x183774590", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class LGABCEKEEMB : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EntityQuery FDOFAODBNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private object PLJMLACHECO;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x3760550", Offset = "0x375F950", VA = "0x183760550", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x3760230", Offset = "0x375F630", VA = "0x183760230", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x37602D0", Offset = "0x375F6D0", VA = "0x1837602D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public LGABCEKEEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class APNMJOGCCDC : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery FDOFAODBNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private object PLJMLACHECO;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x37D5A50", Offset = "0x37D4E50", VA = "0x1837D5A50", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x37D5730", Offset = "0x37D4B30", VA = "0x1837D5730", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x37D57D0", Offset = "0x37D4BD0", VA = "0x1837D57D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public APNMJOGCCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(1)]
internal struct OFPIKLEHGOD : ISystemStateBufferElementData, IBufferElementData, IEquatable<OFPIKLEHGOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public IJPPMIBNAIE CKELBFAAOKG;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x3765DE0", Offset = "0x37651E0", VA = "0x183765DE0", Slot = "4")]
	public bool Equals(OFPIKLEHGOD FJLHJLAMLMA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
	public static OFPIKLEHGOD ABLJGBEPCFM(IJPPMIBNAIE CKELBFAAOKG)
	{
		return default(OFPIKLEHGOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(4)]
internal struct PONLGIHKLNP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public IJPPMIBNAIE CKELBFAAOKG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
	public static PONLGIHKLNP ABLJGBEPCFM(IJPPMIBNAIE CKELBFAAOKG)
	{
		return default(PONLGIHKLNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class PBFNOBMIBNE : EOPHBMPIONG
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x3773F10", Offset = "0x3773310", VA = "0x183773F10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x37740A0", Offset = "0x37734A0", VA = "0x1837740A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x3764360", Offset = "0x3763760", VA = "0x183764360")]
	protected PBFNOBMIBNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[HKMENKHAJPO]
internal abstract class EOPHBMPIONG : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	protected EntityQuery FDOFAODBNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected KJFHICGMDLJ ANLOJMEANJA;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected abstract OPGAIGJBOPI NKFBEEDMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x3A59B50", Offset = "0x3A58F50", VA = "0x183A59B50", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x3A598D0", Offset = "0x3A58CD0", VA = "0x183A598D0")]
	protected void OPHNBKIGPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x3A595E0", Offset = "0x3A589E0", VA = "0x183A595E0")]
	protected void ADNNPJEBCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x3A59860", Offset = "0x3A58C60", VA = "0x183A59860")]
	protected HKMFMMPGOLI BJMMAFFEOBI()
	{
		return default(HKMFMMPGOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	protected EOPHBMPIONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class IEDLFDBPMKN : EOPHBMPIONG
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C660", Offset = "0x3A6BA60", VA = "0x183A6C660", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C7F0", Offset = "0x3A6BBF0", VA = "0x183A6C7F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	protected IEDLFDBPMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class BMDEFCHJAAC : EOPHBMPIONG
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x37D8470", Offset = "0x37D7870", VA = "0x1837D8470", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x37D8580", Offset = "0x37D7980", VA = "0x1837D8580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x3764360", Offset = "0x3763760", VA = "0x183764360")]
	protected BMDEFCHJAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class FEDOPCKAABL : PBFNOBMIBNE
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override OPGAIGJBOPI NKFBEEDMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x3A60950", Offset = "0x3A5FD50", VA = "0x183A60950", Slot = "15")]
		get
		{
			return default(OPGAIGJBOPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x3A609C0", Offset = "0x3A5FDC0", VA = "0x183A609C0")]
	public FEDOPCKAABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class KLGPIGPDMLN : IEDLFDBPMKN
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override OPGAIGJBOPI NKFBEEDMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x3A750F0", Offset = "0x3A744F0", VA = "0x183A750F0", Slot = "15")]
		get
		{
			return default(OPGAIGJBOPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public KLGPIGPDMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class JDCAEHMDGIG : BMDEFCHJAAC
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override OPGAIGJBOPI NKFBEEDMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x3A6FF60", Offset = "0x3A6F360", VA = "0x183A6FF60", Slot = "15")]
		get
		{
			return default(OPGAIGJBOPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x3A609C0", Offset = "0x3A5FDC0", VA = "0x183A609C0")]
	public JDCAEHMDGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class IFNOFACDKOE : PBFNOBMIBNE
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected override OPGAIGJBOPI NKFBEEDMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x3A6C890", Offset = "0x3A6BC90", VA = "0x183A6C890", Slot = "15")]
		get
		{
			return default(OPGAIGJBOPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x3A609C0", Offset = "0x3A5FDC0", VA = "0x183A609C0")]
	public IFNOFACDKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class NELIDNLGHFH : IEDLFDBPMKN
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected override OPGAIGJBOPI NKFBEEDMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x37642F0", Offset = "0x37636F0", VA = "0x1837642F0", Slot = "15")]
		get
		{
			return default(OPGAIGJBOPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x3764360", Offset = "0x3763760", VA = "0x183764360")]
	public NELIDNLGHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class JBHDACOCEJI : BMDEFCHJAAC
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected override OPGAIGJBOPI NKFBEEDMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F810", Offset = "0x3A6EC10", VA = "0x183A6F810", Slot = "15")]
		get
		{
			return default(OPGAIGJBOPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x3A609C0", Offset = "0x3A5FDC0", VA = "0x183A609C0")]
	public JBHDACOCEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct BGPLDMELKCP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct KGCAJCDNCOH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct PGLJLFDFKFK : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct OPGAIGJBOPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly ComponentType LAGEBBBEFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly ComponentType LEHHFJCNDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly object JCHAGIDHJIB;

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x3767530", Offset = "0x3766930", VA = "0x183767530")]
	public OPGAIGJBOPI(ComponentType LAGEBBBEFCD, ComponentType LEHHFJCNDAM, object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x3B87E50", Offset = "0x3B87250", VA = "0x183B87E50")]
	public static OPGAIGJBOPI JNKDJNOGMIC<TReq, TTag>(object JCHAGIDHJIB)
	{
		return default(OPGAIGJBOPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class PKOBAPEALON
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public const string MAGGLPFBINJ = "Parented";

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public const string ODFFLMNLEII = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly OPGAIGJBOPI NBDHCMHAEGC;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly OPGAIGJBOPI PDFNBEIDICE;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct IJPPMIBNAIE : global::JNPHCKODDEF<IJPPMIBNAIE>, IKDLAGIDJHG, IEquatable<IJPPMIBNAIE>
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int JNPBIMHEMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CB0", Offset = "0x7B90B0", VA = "0x1807B9CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int OABDMKOGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x829550", Offset = "0x828950", VA = "0x180829550", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x829560", Offset = "0x828960", VA = "0x180829560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool NFDBEOJPGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x3A6D480", Offset = "0x3A6C880", VA = "0x183A6D480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D430", Offset = "0x3A6C830", VA = "0x183A6D430", Slot = "8")]
	public bool Equals(IJPPMIBNAIE FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D4C0", Offset = "0x3A6C8C0", VA = "0x183A6D4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[HKMENKHAJPO]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Connectables)]
	public class UpdateConnectableVisuals : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct PHPKHLAFLOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public IJPPMIBNAIE CKELBFAAOKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public float3 KGJPEGOHADA;

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x4196CD0", Offset = "0x41960D0", VA = "0x184196CD0")]
			public PHPKHLAFLOO(IJPPMIBNAIE CKELBFAAOKG, float3 KGJPEGOHADA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x4196CB0", Offset = "0x41960B0", VA = "0x184196CB0")]
			public void MDCEJGDOLPN(out IJPPMIBNAIE CKELBFAAOKG, out float3 KGJPEGOHADA)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct APDJLNCNKFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<PHPKHLAFLOO> list;

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
			public APDJLNCNKFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<PONLGIHKLNP> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct PPEKOCFHIKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeList<PHPKHLAFLOO> list;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
			public PPEKOCFHIKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<OFPIKLEHGOD> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct DMDEAFKGBMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<PHPKHLAFLOO> list;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
			public DMDEAFKGBMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in NJNEHIABPCJ com, in DynamicBuffer<OFPIKLEHGOD> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct KEPPJIMFBON : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct NMOKGAPELAB
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				public struct JGHACFDNJJE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					public LambdaParameterValueProvider_Entity.Runtime CKFEMDBOBAP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MIPBCOGKJJF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public LambdaParameterValueProvider_DynamicBuffer<PONLGIHKLNP>.Runtime JHOBNCJNEIA;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CE")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AGAONOFNEPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002CF")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NPDFMKMGDCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<PONLGIHKLNP> FLEOFCLGBJK;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x41960E0", Offset = "0x41954E0", VA = "0x1841960E0")]
				public void LPLCJMGACAE(UpdateConnectableVisuals MPLOKCCKBBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x4196020", Offset = "0x4195420", VA = "0x184196020")]
				public JGHACFDNJJE CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
				{
					return default(JGHACFDNJJE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public UpdateConnectableVisuals NEPFAMIFFCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public NativeList<PHPKHLAFLOO> JOLFKOMKBCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private NMOKGAPELAB JDAIGOONHKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NMOKGAPELAB.JGHACFDNJJE* LGOHJMGEEGE;

			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HOFJKCPNDEG;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x4193760", Offset = "0x4192B60", VA = "0x184193760")]
			internal void HCEIDPMHCNG(Entity OOEHGINMJGM, WorldPoseData AOBGBEOPKGP, in DynamicBuffer<PONLGIHKLNP> LGKAKPIGKKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x4193B20", Offset = "0x4192F20", VA = "0x184193B20", Slot = "5")]
			public void ReadFromDisplayClass(ref APDJLNCNKFG FNLJKNCMNKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x4193B50", Offset = "0x4192F50", VA = "0x184193B50", Slot = "6")]
			public void WriteToDisplayClass(ref APDJLNCNKFG FNLJKNCMNKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x4193680", Offset = "0x4192A80", VA = "0x184193680", Slot = "4")]
			public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x41939E0", Offset = "0x4192DE0", VA = "0x1841939E0")]
			public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, ref NMOKGAPELAB.JGHACFDNJJE PHHHCCELBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x41939A0", Offset = "0x4192DA0", VA = "0x1841939A0")]
			public void LPLCJMGACAE(UpdateConnectableVisuals MPLOKCCKBBP, ref APDJLNCNKFG FNLJKNCMNKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x4193610", Offset = "0x4192A10", VA = "0x184193610")]
			public unsafe static void DALIELACHGP(ArchetypeChunkIterator* OIGBHKBJFBM, void* KJMAEIHPMEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct CFABAKNCMIH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct NPLCFEKHFJF
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct CEPJKFDCCBP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MIPBCOGKJJF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<OFPIKLEHGOD>.Runtime JHOBNCJNEIA;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NPDFMKMGDCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<OFPIKLEHGOD> FLEOFCLGBJK;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x4196470", Offset = "0x4195870", VA = "0x184196470")]
				public void LPLCJMGACAE(UpdateConnectableVisuals MPLOKCCKBBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x41963D0", Offset = "0x41957D0", VA = "0x1841963D0")]
				public CEPJKFDCCBP CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
				{
					return default(CEPJKFDCCBP);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NativeList<PHPKHLAFLOO> JOLFKOMKBCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private NPLCFEKHFJF JDAIGOONHKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NPLCFEKHFJF.CEPJKFDCCBP* LGOHJMGEEGE;

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x418CE20", Offset = "0x418C220", VA = "0x18418CE20")]
			internal void HCEIDPMHCNG(in WorldPoseData AOBGBEOPKGP, in DynamicBuffer<OFPIKLEHGOD> LGKAKPIGKKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xAE5B30", Offset = "0xAE4F30", VA = "0x180AE5B30", Slot = "5")]
			public void ReadFromDisplayClass(ref PPEKOCFHIKC FNLJKNCMNKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x418CD50", Offset = "0x418C150", VA = "0x18418CD50", Slot = "4")]
			public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x418CFD0", Offset = "0x418C3D0", VA = "0x18418CFD0")]
			public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, [NoAlias] ref NPLCFEKHFJF.CEPJKFDCCBP PHHHCCELBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x418CF30", Offset = "0x418C330", VA = "0x18418CF30")]
			public void LPLCJMGACAE(UpdateConnectableVisuals MPLOKCCKBBP, ref PPEKOCFHIKC FNLJKNCMNKN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LPIPNNJGBKN : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			private struct HHIBGHEHCBB
			{
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				[NoAlias]
				public struct DNMNKPANDBL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MIPBCOGKJJF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<NJNEHIABPCJ>.Runtime LFNHMPGFBOP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002E3")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<OFPIKLEHGOD>.Runtime JHOBNCJNEIA;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> NPDFMKMGDCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<NJNEHIABPCJ> OKNAGLJBFHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<OFPIKLEHGOD> FLEOFCLGBJK;

				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x4191A30", Offset = "0x4190E30", VA = "0x184191A30")]
				public void LPLCJMGACAE(UpdateConnectableVisuals MPLOKCCKBBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x4191960", Offset = "0x4190D60", VA = "0x184191960")]
				public DNMNKPANDBL CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
				{
					return default(DNMNKPANDBL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<PHPKHLAFLOO> JOLFKOMKBCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private HHIBGHEHCBB JDAIGOONHKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HHIBGHEHCBB.DNMNKPANDBL* LGOHJMGEEGE;

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x4194A10", Offset = "0x4193E10", VA = "0x184194A10")]
			internal void HCEIDPMHCNG(in WorldPoseData AOBGBEOPKGP, in NJNEHIABPCJ FEGBMGCIHBD, in DynamicBuffer<OFPIKLEHGOD> LGKAKPIGKKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xAE5B30", Offset = "0xAE4F30", VA = "0x180AE5B30", Slot = "5")]
			public void ReadFromDisplayClass(ref DMDEAFKGBMH FNLJKNCMNKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x4194990", Offset = "0x4193D90", VA = "0x184194990", Slot = "4")]
			public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x4194BB0", Offset = "0x4193FB0", VA = "0x184194BB0")]
			public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, [NoAlias] ref HHIBGHEHCBB.DNMNKPANDBL PHHHCCELBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x4194B70", Offset = "0x4193F70", VA = "0x184194B70")]
			public void LPLCJMGACAE(UpdateConnectableVisuals MPLOKCCKBBP, ref DMDEAFKGBMH FNLJKNCMNKN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery GMGGPICAHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery NJHEBAJPHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery JPMAIIHJJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery FDPELMNPJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery DOMELFLECHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery EKNPPFFGKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery PPLANDJNMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery BCHHGFGEGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery APIHIGFNHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery CAICDCABPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private global::OGHFMFGNANG<IJPPMIBNAIE, NKCGOGCFAON> NOFBMGJAIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private KMPDMJCJEEE IGPFOGNKFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private DFBNDOPHHMN AKCKMDEOLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private ECJKHEGNMEN JOECKLBJJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery HHBKPKKBJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ProfilerMarker DOOAHJPGJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery NEIGHNALEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery LFGBKDPCOAC;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int HMGCLIBMMBB
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x38C3880", Offset = "0x38C2C80", VA = "0x1838C3880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x38C3E50", Offset = "0x38C3250", VA = "0x1838C3E50")]
		internal NKCGOGCFAON ELNFMNCDOJK(IJPPMIBNAIE CKELBFAAOKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x38C7360", Offset = "0x38C6760", VA = "0x1838C7360", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x38C6DE0", Offset = "0x38C61E0", VA = "0x1838C6DE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x38C7060", Offset = "0x38C6460", VA = "0x1838C7060", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x38C71F0", Offset = "0x38C65F0", VA = "0x1838C71F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x38C7020", Offset = "0x38C6420", VA = "0x1838C7020", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x38C4760", Offset = "0x38C3B60", VA = "0x1838C4760")]
		private void FNNDMECOOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x38C3D00", Offset = "0x38C3100", VA = "0x1838C3D00")]
		private void EHJPAOLNAOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x38C68D0", Offset = "0x38C5CD0", VA = "0x1838C68D0")]
		private void OPJNKEPGOPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x38C7230", Offset = "0x38C6630", VA = "0x1838C7230", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x38C5680", Offset = "0x38C4A80", VA = "0x1838C5680")]
		private void LOGJNOLNCGE(EntityQuery HLHEPPGOKEF, EntityQuery AOHMGFJIPGD, EntityQuery OBPCGEMBNDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x38C4980", Offset = "0x38C3D80", VA = "0x1838C4980")]
		private void GAMANBAONBG(EntityQuery OBPCGEMBNDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x38C4AB0", Offset = "0x38C3EB0", VA = "0x1838C4AB0")]
		private void HHAMBKKFJAL(NativeArrayAsync<Entity> MHFPAJJJFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x38C4870", Offset = "0x38C3C70", VA = "0x1838C4870")]
		private void GADFEIOMKMD(NativeArrayAsync<Entity> KIMHNJDEFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x38C5B60", Offset = "0x38C4F60", VA = "0x1838C5B60")]
		private void MHGHEMCFANJ(NativeArrayAsync<Entity> JGFPEDCNFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x38C3A50", Offset = "0x38C2E50", VA = "0x1838C3A50")]
		private void DNHAAHEJGFP(NativeList<IJPPMIBNAIE> EGJJKAOJLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x38C4240", Offset = "0x38C3640", VA = "0x1838C4240")]
		private NativeList<IJPPMIBNAIE> FJLDIBMOMCK(NativeArray<Entity> NMNOLKKCICL)
		{
			return default(NativeList<IJPPMIBNAIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x38C62B0", Offset = "0x38C56B0", VA = "0x1838C62B0")]
		private void OCCHPNMGIHO(NativeArray<Entity> NMNOLKKCICL, NativeList<IJPPMIBNAIE> EGJJKAOJLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x38C4D90", Offset = "0x38C4190", VA = "0x1838C4D90")]
		private void INPDFPAOFJC(NativeArray<Entity> NBONGGOGAEN, NativeArray<Entity> LAHJDCDJFPO, NativeList<IJPPMIBNAIE> HGIIACEOIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x38C31D0", Offset = "0x38C25D0", VA = "0x1838C31D0")]
		private void AAGDAFILGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x38C3BC0", Offset = "0x38C2FC0", VA = "0x1838C3BC0")]
		private NativeListAsync<PHPKHLAFLOO> ECKHAJGEDHF(EntityQuery FDOFAODBNNC, Func<NativeList<PHPKHLAFLOO>, JobHandle> EEDAABMHKDI)
		{
			return default(NativeListAsync<PHPKHLAFLOO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x38C38C0", Offset = "0x38C2CC0", VA = "0x1838C38C0")]
		private JobHandle DJCJFKNEPBA(NativeList<PHPKHLAFLOO> JOLFKOMKBCI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x38C4100", Offset = "0x38C3500", VA = "0x1838C4100")]
		private JobHandle FDPGLBEGBMD(NativeList<PHPKHLAFLOO> JOLFKOMKBCI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x38C52C0", Offset = "0x38C46C0", VA = "0x1838C52C0")]
		private JobHandle KFEHKINCFDD(NativeList<PHPKHLAFLOO> JOLFKOMKBCI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x38C6020", Offset = "0x38C5420", VA = "0x1838C6020")]
		private void NMLFMNOBMFD(NativeListAsync<PHPKHLAFLOO> JOLFKOMKBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x38C5D90", Offset = "0x38C5190", VA = "0x1838C5D90")]
		private void MNEGNDGPGEF(NativeListAsync<PHPKHLAFLOO> JOLFKOMKBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x38C4A50", Offset = "0x38C3E50", VA = "0x1838C4A50")]
		private bool GHOOALDPCKK(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x38C55B0", Offset = "0x38C49B0", VA = "0x1838C55B0")]
		private NativeArray<Entity> LIIJOMLEJIO(Entity OOEHGINMJGM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x38C53F0", Offset = "0x38C47F0", VA = "0x1838C53F0")]
		private IJPPMIBNAIE LBPBDDPIOIG(NativeList<IJPPMIBNAIE> HGIIACEOIFD)
		{
			return default(IJPPMIBNAIE);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x38C5D00", Offset = "0x38C5100", VA = "0x1838C5D00")]
		private void MKNHCJMGKPN(IJPPMIBNAIE CKELBFAAOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x38C6C80", Offset = "0x38C6080", VA = "0x1838C6C80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x38C3680", Offset = "0x38C2A80", VA = "0x1838C3680")]
		public static EntityQuery CNNMPIFKOLN(ComponentSystemBase MPLOKCCKBBP)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x38C3EA0", Offset = "0x38C32A0", VA = "0x1838C3EA0")]
		public static EntityQuery EMJGABGMCOP(ComponentSystemBase MPLOKCCKBBP)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x38C7420", Offset = "0x38C6820", VA = "0x1838C7420")]
		public static EntityQuery PEBHBDMPBMG(ComponentSystemBase MPLOKCCKBBP)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[NAPHGBOEKGO(GPIMBHHJLKL.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery FDOFAODBNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private OBNLPCJMAPP MDDAOJACOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private DKIIFEKMNJN BGBFECNPAIM;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x377BCB0", Offset = "0x377B0B0", VA = "0x18377BCB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x377C370", Offset = "0x377B770", VA = "0x18377C370", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x377BDB0", Offset = "0x377B1B0", VA = "0x18377BDB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class HBCMACKGPFG : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public IHNOMGAGHCN KGKPNOEKJJD;

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public HBCMACKGPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	public HBCMACKGPFG(IHNOMGAGHCN KGKPNOEKJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x3A677B0", Offset = "0x3A66BB0", VA = "0x183A677B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public abstract class IGMOOLJLNAM : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private ObjectEmbodimentService NGEDJICHDBC;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CC70", Offset = "0x3A6C070", VA = "0x183A6CC70", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CC20", Offset = "0x3A6C020", VA = "0x183A6CC20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CC50", Offset = "0x3A6C050", VA = "0x183A6CC50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	protected IGMOOLJLNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class GLNMOFHHLFO : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EntityQuery MFIFMNGKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery NNPEKNFEPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery GILHELBJEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery NNGLNIAPLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private ObjectEmbodimentService HGEJLBCJJCC;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public int HHEHIAJIKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A64B20", Offset = "0x3A63F20", VA = "0x183A64B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int LBDPKIFAENA
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A64AF0", Offset = "0x3A63EF0", VA = "0x183A64AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A65240", Offset = "0x3A64640", VA = "0x183A65240", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A65020", Offset = "0x3A64420", VA = "0x183A65020", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A65220", Offset = "0x3A64620", VA = "0x183A65220", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A64B00", Offset = "0x3A63F00", VA = "0x183A64B00")]
	public int DIPMNADBCCM(SceneTag LKJCHBJAPLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A64F30", Offset = "0x3A64330", VA = "0x183A64F30")]
	public int NNPFLBICEMD(SceneTag LKJCHBJAPLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A64C40", Offset = "0x3A64040", VA = "0x183A64C40")]
	protected void LLNEDMGBNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A64980", Offset = "0x3A63D80", VA = "0x183A64980")]
	protected void BPGOHMGCEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A64BF0", Offset = "0x3A63FF0", VA = "0x183A64BF0")]
	public NativeArrayAsync<Entity> LAPHDAOCEJI(SceneTag LKJCHBJAPLC, Allocator NDJJBKEIGCD = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A64BA0", Offset = "0x3A63FA0", VA = "0x183A64BA0")]
	public NativeArrayAsync<Entity> HEDOHJPGFJL(SceneTag LKJCHBJAPLC, Allocator NDJJBKEIGCD = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A64EA0", Offset = "0x3A642A0", VA = "0x183A64EA0")]
	public bool MOKCCIGDLGC(SceneTag LKJCHBJAPLC, out NativeArrayAsync<Entity> KGKPNOEKJJD, Allocator NDJJBKEIGCD = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A64A90", Offset = "0x3A63E90", VA = "0x183A64A90")]
	public bool CINBLFIFJPP(Entity OOEHGINMJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A64B30", Offset = "0x3A63F30", VA = "0x183A64B30")]
	public IHNOMGAGHCN HDHEPIMGBHH(Entity OOEHGINMJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x3A64F50", Offset = "0x3A64350", VA = "0x183A64F50")]
	public bool OENDIKOIADH(Entity OOEHGINMJGM, out HBCMACKGPFG KGKPNOEKJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A64E60", Offset = "0x3A64260", VA = "0x183A64E60")]
	public void MOEHKCAJIMN(Entity OOEHGINMJGM, HBCMACKGPFG KGKPNOEKJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A64FC0", Offset = "0x3A643C0", VA = "0x183A64FC0")]
	public bool OPGCGCOCLKB(Entity OOEHGINMJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void BGEODALEHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public GLNMOFHHLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class CGGONBFPCNC : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery MMPGHLNHLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private PFHNJBGFDIA CMMLIBKHPCN;

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x37DCE10", Offset = "0x37DC210", VA = "0x1837DCE10", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x37DCA70", Offset = "0x37DBE70", VA = "0x1837DCA70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x37DCB30", Offset = "0x37DBF30", VA = "0x1837DCB30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x32B10D0", Offset = "0x32B04D0", VA = "0x1832B10D0")]
	private bool JDGEPFFLCKD<TComponentData>(EntityQuery FDOFAODBNNC, out NativeArray<Entity> NMNOLKKCICL, out NativeArray<TComponentData> JEMCAABFCAC) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x37DCA00", Offset = "0x37DBE00", VA = "0x1837DCA00")]
	public IHNOMGAGHCN HDHEPIMGBHH(Entity OOEHGINMJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public CGGONBFPCNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery NKBILHAOBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery BMBDOIGKPNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery JCELFANFHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery KLGGHNCMBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x38B8E00", Offset = "0x38B8200", VA = "0x1838B8E00", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x38B8AA0", Offset = "0x38B7EA0", VA = "0x1838B8AA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x38B8CD0", Offset = "0x38B80D0", VA = "0x1838B8CD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x38B8660", Offset = "0x38B7A60", VA = "0x1838B8660")]
		private void BKCAAEBNAMB(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x38B86D0", Offset = "0x38B7AD0", VA = "0x1838B86D0")]
		private void GAMANBAONBG(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x38B8C60", Offset = "0x38B8060", VA = "0x1838B8C60", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x38B8740", Offset = "0x38B7B40", VA = "0x1838B8740")]
		private void OJCJNJLJNNH(EntityQuery FDOFAODBNNC, bool KLHFMFBLIDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal sealed class IEDELMONJEM : FNIOMAHLONI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct OABLFOJMIJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		public OABLFOJMIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PMBPFPIPHCC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct NHJCCBCBBOG
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct CEBGPIHPHMI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LNAKNAEDDNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime JGALBLDLHCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime HDDNGAIMIOI;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity JDCMKCGPJPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> AHDOLMIMKON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> IGEAJAHOFLE;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x41957D0", Offset = "0x4194BD0", VA = "0x1841957D0")]
			public void LPLCJMGACAE(IEDELMONJEM MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x4195710", Offset = "0x4194B10", VA = "0x184195710")]
			public CEBGPIHPHMI CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
			{
				return default(CEBGPIHPHMI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private NHJCCBCBBOG JDAIGOONHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NHJCCBCBBOG.CEBGPIHPHMI* LGOHJMGEEGE;

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x4196E80", Offset = "0x4196280", VA = "0x184196E80")]
		internal void HCEIDPMHCNG(Entity AFJECOEPPAE, SplineShapeData FKBMHFEKLIC, DynamicBuffer<LinkedEntityGroup> DGPBECDNOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x4196DB0", Offset = "0x41961B0", VA = "0x184196DB0", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x4196EF0", Offset = "0x41962F0", VA = "0x184196EF0")]
		public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, [NoAlias] ref NHJCCBCBBOG.CEBGPIHPHMI PHHHCCELBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x4196EE0", Offset = "0x41962E0", VA = "0x184196EE0")]
		public void LPLCJMGACAE(IEDELMONJEM MPLOKCCKBBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FIPLJOFEEAB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct PNDJIOCBPBN
		{
			[Cpp2IlInjected.Token(Token = "0x20000FB")]
			[NoAlias]
			public struct JEDALOOLPIH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime LNIOBEGEMDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400030C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime FGHANPINCIE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CKPEALKPLEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> DAGMKAANKIP;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x4197090", Offset = "0x4196490", VA = "0x184197090")]
			public void LPLCJMGACAE(IEDELMONJEM MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x4197010", Offset = "0x4196410", VA = "0x184197010")]
			public JEDALOOLPIH CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
			{
				return default(JEDALOOLPIH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BufferFromEntity<LinkedEntityGroup> BIFCKCBFOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private PNDJIOCBPBN JDAIGOONHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PNDJIOCBPBN.JEDALOOLPIH* LGOHJMGEEGE;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x418FF20", Offset = "0x418F320", VA = "0x18418FF20")]
		internal void HCEIDPMHCNG(Entity JPMHBKMFPAH, SplinePointParentData NLCAPHFIIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x17D4190", Offset = "0x17D3590", VA = "0x1817D4190", Slot = "5")]
		public void ReadFromDisplayClass(ref OABLFOJMIJN FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x418FE80", Offset = "0x418F280", VA = "0x18418FE80", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x4190040", Offset = "0x418F440", VA = "0x184190040")]
		public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, [NoAlias] ref PNDJIOCBPBN.JEDALOOLPIH PHHHCCELBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x418FFB0", Offset = "0x418F3B0", VA = "0x18418FFB0")]
		public void LPLCJMGACAE(IEDELMONJEM MPLOKCCKBBP, ref OABLFOJMIJN FNLJKNCMNKN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private EntityQuery FDOFAODBNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery LJGOAPACKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery CAAMCMOLGBE;

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C370", Offset = "0x3A6B770", VA = "0x183A6C370", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C420", Offset = "0x3A6B820", VA = "0x183A6C420", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public IEDELMONJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C0D0", Offset = "0x3A6B4D0", VA = "0x183A6C0D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A6BF30", Offset = "0x3A6B330", VA = "0x183A6BF30")]
	public static EntityQuery KIMLNOJJFEF(ComponentSystemBase MPLOKCCKBBP)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A6BDD0", Offset = "0x3A6B1D0", VA = "0x183A6BDD0")]
	public static EntityQuery DPOMOEFHLEB(ComponentSystemBase MPLOKCCKBBP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
public sealed class IHPCGBLIDMI : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private IGNFHNIPNCL CBNBMEGDBOE;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D390", Offset = "0x3A6C790", VA = "0x183A6D390", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D370", Offset = "0x3A6C770", VA = "0x183A6D370", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public IHPCGBLIDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class DBLCMHCNCJG : FNIOMAHLONI, CJFEEGPLPHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct GNJBJDDCLJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<IJDNGJCBHJA> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NativeList<DJDEPENAIGM> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NativeList<IJDNGJCBHJA> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		public GNJBJDDCLJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, FIFLOEKHLJG previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
		internal void <OnUpdate>b__2(Entity entity, FIFLOEKHLJG previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct CFFAKBBDJOK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct KLAJGHIMNIC
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct HAAPMHJCNGB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400031A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime CKFEMDBOBAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400031B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime LKPJKAEOEEN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AGAONOFNEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> NLPHCIKIGLD;

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x4194390", Offset = "0x4193790", VA = "0x184194390")]
			public void LPLCJMGACAE(DBLCMHCNCJG MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x4194310", Offset = "0x4193710", VA = "0x184194310")]
			public HAAPMHJCNGB CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
			{
				return default(HAAPMHJCNGB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeList<IJDNGJCBHJA> JJHFHEKJIMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private KLAJGHIMNIC JDAIGOONHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KLAJGHIMNIC.HAAPMHJCNGB* LGOHJMGEEGE;

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x418D140", Offset = "0x418C540", VA = "0x18418D140")]
		internal void HCEIDPMHCNG(Entity OOEHGINMJGM, ParentData OGHKGHLKPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0xAE5B30", Offset = "0xAE4F30", VA = "0x180AE5B30", Slot = "5")]
		public void ReadFromDisplayClass(ref GNJBJDDCLJO FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x418D0A0", Offset = "0x418C4A0", VA = "0x18418D0A0", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x418D250", Offset = "0x418C650", VA = "0x18418D250")]
		public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, [NoAlias] ref KLAJGHIMNIC.HAAPMHJCNGB PHHHCCELBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x418D1C0", Offset = "0x418C5C0", VA = "0x18418D1C0")]
		public void LPLCJMGACAE(DBLCMHCNCJG MPLOKCCKBBP, ref GNJBJDDCLJO FNLJKNCMNKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct KIENBLMFJAO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct BDCHKJFBOAD
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct GHAIHFBNIOH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime CKFEMDBOBAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime LKPJKAEOEEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<FIFLOEKHLJG>.Runtime EDLKLOAIMJO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AGAONOFNEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> NLPHCIKIGLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<FIFLOEKHLJG> CNOAOOGFJHO;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x418AB30", Offset = "0x4189F30", VA = "0x18418AB30")]
			public void LPLCJMGACAE(DBLCMHCNCJG MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x418AA90", Offset = "0x4189E90", VA = "0x18418AA90")]
			public GHAIHFBNIOH CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
			{
				return default(GHAIHFBNIOH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NativeList<DJDEPENAIGM> GADNDHBADLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private BDCHKJFBOAD JDAIGOONHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BDCHKJFBOAD.GHAIHFBNIOH* LGOHJMGEEGE;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x4194010", Offset = "0x4193410", VA = "0x184194010")]
		internal void HCEIDPMHCNG(Entity OOEHGINMJGM, ParentData OGHKGHLKPIH, FIFLOEKHLJG KCOKIBMLPJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x41941F0", Offset = "0x41935F0", VA = "0x1841941F0", Slot = "5")]
		public void ReadFromDisplayClass(ref GNJBJDDCLJO FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x4193F40", Offset = "0x4193340", VA = "0x184193F40", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x4194110", Offset = "0x4193510", VA = "0x184194110")]
		public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, [NoAlias] ref BDCHKJFBOAD.GHAIHFBNIOH PHHHCCELBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x41940D0", Offset = "0x41934D0", VA = "0x1841940D0")]
		public void LPLCJMGACAE(DBLCMHCNCJG MPLOKCCKBBP, ref GNJBJDDCLJO FNLJKNCMNKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct NNALLMLIAPL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private struct IEPCHNFLOMK
		{
			[Cpp2IlInjected.Token(Token = "0x2000107")]
			[NoAlias]
			public struct KOFBIBOOPPJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime CKFEMDBOBAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<FIFLOEKHLJG>.Runtime EDLKLOAIMJO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AGAONOFNEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<FIFLOEKHLJG> CNOAOOGFJHO;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x4191D10", Offset = "0x4191110", VA = "0x184191D10")]
			public void LPLCJMGACAE(DBLCMHCNCJG MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x4191C90", Offset = "0x4191090", VA = "0x184191C90")]
			public KOFBIBOOPPJ CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
			{
				return default(KOFBIBOOPPJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NativeList<IJDNGJCBHJA> MJEMEEEACKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private IEPCHNFLOMK JDAIGOONHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IEPCHNFLOMK.KOFBIBOOPPJ* LGOHJMGEEGE;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x4196200", Offset = "0x4195600", VA = "0x184196200")]
		internal void HCEIDPMHCNG(Entity OOEHGINMJGM, FIFLOEKHLJG KCOKIBMLPJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x41963C0", Offset = "0x41957C0", VA = "0x1841963C0", Slot = "5")]
		public void ReadFromDisplayClass(ref GNJBJDDCLJO FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x4196160", Offset = "0x4195560", VA = "0x184196160", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x4196310", Offset = "0x4195710", VA = "0x184196310")]
		public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, [NoAlias] ref IEPCHNFLOMK.KOFBIBOOPPJ PHHHCCELBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x4196280", Offset = "0x4195680", VA = "0x184196280")]
		public void LPLCJMGACAE(DBLCMHCNCJG MPLOKCCKBBP, ref GNJBJDDCLJO FNLJKNCMNKN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private CGJMICMININ CCMFOKDAKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery KMLKDJOBPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery ABKKDHOMIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery MGKINMGNIKD;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x37EA620", Offset = "0x37E9A20", VA = "0x1837EA620", Slot = "14")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x37EA990", Offset = "0x37E9D90", VA = "0x1837EA990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public DBLCMHCNCJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x37EA930", Offset = "0x37E9D30", VA = "0x1837EA930", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x37EA1C0", Offset = "0x37E95C0", VA = "0x1837EA1C0")]
	public static EntityQuery AKFOFECOLPH(ComponentSystemBase MPLOKCCKBBP)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x37EA700", Offset = "0x37E9B00", VA = "0x1837EA700")]
	public static EntityQuery KOLJDNDCIGE(ComponentSystemBase MPLOKCCKBBP)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x37EA420", Offset = "0x37E9820", VA = "0x1837EA420")]
	public static EntityQuery HCBJHCPMIKO(ComponentSystemBase MPLOKCCKBBP)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Connectables)]
	public class InitializeRigidbodyExHierarchy : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EntityQuery FDOFAODBNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private BNFMGMHNJKK CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F3D0", Offset = "0x3A6E7D0", VA = "0x183A6F3D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F650", Offset = "0x3A6EA50", VA = "0x183A6F650", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F460", Offset = "0x3A6E860", VA = "0x183A6F460", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class NLLCGCPHIII : ParentSystemBase<ParentData, FIFLOEKHLJG, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x3764DC0", Offset = "0x37641C0", VA = "0x183764DC0", Slot = "14")]
	protected override EntityQueryDesc GDPNCHKMMOA(EntityQueryDesc FDOFAODBNNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x8F39B0", Offset = "0x8F2DB0", VA = "0x1808F39B0", Slot = "15")]
	protected override EntityQueryDesc KKDOCOFCFDD(EntityQueryDesc FDOFAODBNNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x3764E00", Offset = "0x3764200", VA = "0x183764E00", Slot = "16")]
	protected override EntityQueryDesc GGOHFCKNEMO(EntityQueryDesc FDOFAODBNNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x3764E40", Offset = "0x3764240", VA = "0x183764E40", Slot = "17")]
	protected override EntityQueryDesc HFNMEGKHBJP(EntityQueryDesc FDOFAODBNNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x3764EC0", Offset = "0x37642C0", VA = "0x183764EC0")]
	public NLLCGCPHIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x3764E80", Offset = "0x3764280", VA = "0x183764E80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : FNIOMAHLONI where ParentData : struct, IComponentData, JAADDGFLGJN where PreviousParentData : struct, IComponentData, JAADDGFLGJN where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, JAADDGFLGJN
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct HGJFEBAHHDD : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter CIEMGHCBCEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter FGAECCKKCAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public NativeHashMap<Entity, int>.ParallelWriter OHCDGNMEOPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ArchetypeChunkComponentType<PreviousParentData> DMEGDKJIOIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> HOIDFODIEBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public ArchetypeChunkEntityType COJCMKJOCEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public uint JPNHMOJCOKP;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x39CB170", Offset = "0x39CA570", VA = "0x1839CB170", Slot = "4")]
			public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[BurstCompile]
		private struct JGAEJPMNLJB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> OHCDGNMEOPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> KNCEKDMLBBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public NativeList<Entity> LLOOBCHOPMO;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x3280790", Offset = "0x327FB90", VA = "0x183280790", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		private struct PLLNCNLIHCM : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> CIEMGHCBCEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> FGAECCKKCAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeHashMap<Entity, int> OHCDGNMEOPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BufferFromEntity<ChildrenData> KNCEKDMLBBP;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x3D6B780", Offset = "0x3D6AB80", VA = "0x183D6B780")]
			private int CFGAJOAOIHK(DynamicBuffer<ChildrenData> GNLABAOMILF, Entity OOEHGINMJGM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x3D6BCB0", Offset = "0x3D6B0B0", VA = "0x183D6BCB0")]
			private void IJFKBOFHOOK(Entity CNDFBGEJOLI, DynamicBuffer<ChildrenData> GNLABAOMILF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x3D6BF40", Offset = "0x3D6B340", VA = "0x183D6BF40")]
			private void KDKHJPMMAKC(Entity CNDFBGEJOLI, DynamicBuffer<ChildrenData> GNLABAOMILF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x3D6B9F0", Offset = "0x3D6ADF0", VA = "0x183D6B9F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[BurstCompile]
		private struct LBFDABAMNHA : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeArray<Entity> CFGALEMAMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public NativeList<Entity> MKGCJNINDKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public BufferFromEntity<ChildrenData> KNCEKDMLBBP;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x2E8D640", Offset = "0x2E8CA40", VA = "0x182E8D640", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery IEIHKNAOOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery IOIBALJLPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery BJKIPKNAAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected EntityQuery NOHOFICINHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker IEECHAHPDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker GOJHNJODNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker AMPIKNJHOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected ProfilerMarker NMEIIKAODHP;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x32EB7D0", Offset = "0x32EABD0", VA = "0x1832EB7D0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x32E98A0", Offset = "0x32E8CA0", VA = "0x1832E98A0")]
		private int CFGAJOAOIHK(DynamicBuffer<ChildrenData> GNLABAOMILF, Entity OOEHGINMJGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x32EA590", Offset = "0x32E9990", VA = "0x1832EA590")]
		private void IBHJLMFHFCI(Entity PJOCCGGFBPI, Entity FEBFLJKCHLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x8F39B0", Offset = "0x8F2DB0", VA = "0x1808F39B0", Slot = "14")]
		protected virtual EntityQueryDesc GDPNCHKMMOA(EntityQueryDesc FDOFAODBNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x8F39B0", Offset = "0x8F2DB0", VA = "0x1808F39B0", Slot = "15")]
		protected virtual EntityQueryDesc KKDOCOFCFDD(EntityQueryDesc FDOFAODBNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x8F39B0", Offset = "0x8F2DB0", VA = "0x1808F39B0", Slot = "16")]
		protected virtual EntityQueryDesc GGOHFCKNEMO(EntityQueryDesc FDOFAODBNNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc HFNMEGKHBJP(EntityQueryDesc FDOFAODBNNC);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x32EB430", Offset = "0x32EA830", VA = "0x1832EB430", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x32E9990", Offset = "0x32E8D90", VA = "0x1832E9990")]
		private void CLJMNMHJBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x32EAA10", Offset = "0x32E9E10", VA = "0x1832EAA10")]
		private void NPBMCMOBBJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x32E9B30", Offset = "0x32E8F30", VA = "0x1832E9B30")]
		private JobHandle DBHGKNMODLF(JobHandle JJJGGKAKAIG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x32EAEB0", Offset = "0x32EA2B0", VA = "0x1832EAEB0")]
		private void OLOMEJPMFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x32EB700", Offset = "0x32EAB00", VA = "0x1832EB700", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x32EB6D0", Offset = "0x32EAAD0", VA = "0x1832EB6D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x25390D0", Offset = "0x25384D0", VA = "0x1825390D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[AlwaysUpdateSystem]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
public abstract class PJLDPFOODDC : FNIOMAHLONI, CJFEEGPLPHA
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct ODDIEJCJPMB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> LLPFLLLHEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> DGNNPOKKNFE;

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x41965F0", Offset = "0x41959F0", VA = "0x1841965F0")]
		public ODDIEJCJPMB(NativeList<Entity> LLPFLLLHEDB, NativeList<Entity> DGNNPOKKNFE, JobHandle FOMHAOIEGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x4196570", Offset = "0x4195970", VA = "0x184196570")]
		public JobHandle PDMGGILGAFN(JobHandle JJJGGKAKAIG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x41964E0", Offset = "0x41958E0", VA = "0x1841964E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct DPLBCKNBLEO : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[Flags]
		public enum KFAEDAPAHCJ
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
		public NativeList<Entity> FKOBOOOGMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> FFLJJACOMAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> LJHLEIKBCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> AICEEJAGJEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity HDGMEHPEFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity HOJDHFLNAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> KMINMOIKKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int OIFCFLJEFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int CCPDMIANMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private KFAEDAPAHCJ NOJLEBJKKOH;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x418E370", Offset = "0x418D770", VA = "0x18418E370", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x418E940", Offset = "0x418DD40", VA = "0x18418E940")]
		private void NLHGEOPNFEN(Entity OOEHGINMJGM, bool IOMGDNIJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x418E180", Offset = "0x418D580", VA = "0x18418E180")]
		private void AHAILIOEEGE(Entity OOEHGINMJGM, bool IOMGDNIJLNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x418E500", Offset = "0x418D900", VA = "0x18418E500")]
		public ODDIEJCJPMB FHFLCEPAMNK(NativeArray<Entity> GMPFLANMHBL, JobHandle JJJGGKAKAIG)
		{
			return default(ODDIEJCJPMB);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x418E580", Offset = "0x418D980", VA = "0x18418E580")]
		public ODDIEJCJPMB FILEKBOOJGO(NativeArray<Entity> GMPFLANMHBL, JobHandle JJJGGKAKAIG)
		{
			return default(ODDIEJCJPMB);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x418E290", Offset = "0x418D690", VA = "0x18418E290")]
		public ODDIEJCJPMB ALFJJBCFAHD(NativeList<IJDNGJCBHJA> JOLFKOMKBCI, JobHandle JJJGGKAKAIG)
		{
			return default(ODDIEJCJPMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x418E9D0", Offset = "0x418DDD0", VA = "0x18418E9D0")]
		public ODDIEJCJPMB OBNDIIIFKPK(NativeList<IJDNGJCBHJA> JOLFKOMKBCI, JobHandle JJJGGKAKAIG)
		{
			return default(ODDIEJCJPMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x418E600", Offset = "0x418DA00", VA = "0x18418E600")]
		public ODDIEJCJPMB GCBIOHADGAG(NativeList<DJDEPENAIGM> JOLFKOMKBCI, JobHandle JJJGGKAKAIG)
		{
			return default(ODDIEJCJPMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x4079880", Offset = "0x4078C80", VA = "0x184079880")]
		private ODDIEJCJPMB MDJMJOEHHGM<T>(NativeList<T> JOLFKOMKBCI, int KJOHHNLCPJD, int EIJHLNPDKDI, KFAEDAPAHCJ CMBMANJMAFC, JobHandle JJJGGKAKAIG) where T : struct
		{
			return default(ODDIEJCJPMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x418E6E0", Offset = "0x418DAE0", VA = "0x18418E6E0")]
		private ODDIEJCJPMB MDJMJOEHHGM(NativeArray<Entity> NMNOLKKCICL, int KJOHHNLCPJD, int EIJHLNPDKDI, KFAEDAPAHCJ CMBMANJMAFC, JobHandle JJJGGKAKAIG)
		{
			return default(ODDIEJCJPMB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly BBHAOFNBCPD CDECIAPNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery MLANMGFDOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery ABEKNIKMGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private CGJMICMININ DLLGPEONHEL;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected abstract ComponentType PDLPNBGJEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract ComponentType KNLGDFCPAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected abstract ComponentType HENKDJBNGMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x3775E30", Offset = "0x3775230", VA = "0x183775E30")]
	protected PJLDPFOODDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x3774700", Offset = "0x3773B00", VA = "0x183774700", Slot = "14")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x3774D90", Offset = "0x3774190", VA = "0x183774D90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x3774FC0", Offset = "0x37743C0", VA = "0x183774FC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0xC61970", Offset = "0xC60D70", VA = "0x180C61970", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x37746A0", Offset = "0x3773AA0", VA = "0x1837746A0")]
	private void DANEGAMHFNH(NativeArray<Entity> JOLFKOMKBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x37747E0", Offset = "0x3773BE0", VA = "0x1837747E0")]
	private void JLNLPAFFOIK(NativeArray<Entity> JOLFKOMKBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x3774AD0", Offset = "0x3773ED0", VA = "0x183774AD0")]
	private void OHMHJBPKOBF(ODDIEJCJPMB NDGJJFJHLLA, string MMPAOKKMEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x3774C10", Offset = "0x3774010", VA = "0x183774C10")]
	private void OHMHJBPKOBF(NativeListAsync<Entity> CGEAFGHJFAK, string MMPAOKKMEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x3774880", Offset = "0x3773C80", VA = "0x183774880")]
	private void NNBANGENHIN(ODDIEJCJPMB NDGJJFJHLLA, string MMPAOKKMEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x37749C0", Offset = "0x3773DC0", VA = "0x1837749C0")]
	private void NNBANGENHIN(NativeListAsync<Entity> CGEAFGHJFAK, string MMPAOKKMEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x3774D20", Offset = "0x3774120", VA = "0x183774D20")]
	private bool OOMNBABFMMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
public class LDEAABNJGBK : FNIOMAHLONI, NGENPNOGFON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct NLPLMBCFBMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public LDEAABNJGBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		public NLPLMBCFBMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MFMPPOKAHIL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct PBPHMALBBHG
		{
			[Cpp2IlInjected.Token(Token = "0x2000117")]
			public struct HFGCLKBJCLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime IEGFMKOEOHA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity HIDOJODEBLM;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x41968F0", Offset = "0x4195CF0", VA = "0x1841968F0")]
			public void LPLCJMGACAE(LDEAABNJGBK MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x41968E0", Offset = "0x4195CE0", VA = "0x1841968E0")]
			public HFGCLKBJCLJ CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
			{
				return default(HFGCLKBJCLJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public LDEAABNJGBK NEPFAMIFFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EntityCommandBuffer KMMHCKECEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private PBPHMALBBHG JDAIGOONHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PBPHMALBBHG.HFGCLKBJCLJ* LGOHJMGEEGE;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HOFJKCPNDEG;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x41952A0", Offset = "0x41946A0", VA = "0x1841952A0")]
		internal void HCEIDPMHCNG(Entity EPPMCIFCHBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x418FE10", Offset = "0x418F210", VA = "0x18418FE10", Slot = "5")]
		public void ReadFromDisplayClass(ref NLPLMBCFBMG FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x418FE40", Offset = "0x418F240", VA = "0x18418FE40", Slot = "6")]
		public void WriteToDisplayClass(ref NLPLMBCFBMG FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x4195250", Offset = "0x4194650", VA = "0x184195250", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x41953F0", Offset = "0x41947F0", VA = "0x1841953F0")]
		public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, ref PBPHMALBBHG.HFGCLKBJCLJ PHHHCCELBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x41953B0", Offset = "0x41947B0", VA = "0x1841953B0")]
		public void LPLCJMGACAE(LDEAABNJGBK MPLOKCCKBBP, ref NLPLMBCFBMG FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x41951E0", Offset = "0x41945E0", VA = "0x1841951E0")]
		public unsafe static void DALIELACHGP(ArchetypeChunkIterator* OIGBHKBJFBM, void* KJMAEIHPMEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private GJLKIMNMNIH BBFGPJEOGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private FJEGFCLMACC EFPBHJBKLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery JCJDIOPAFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private ProfilerMarker NBCHFPECBEM;

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x375FCF0", Offset = "0x375F0F0", VA = "0x18375FCF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x375FEA0", Offset = "0x375F2A0", VA = "0x18375FEA0", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x375FD50", Offset = "0x375F150", VA = "0x18375FD50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public LDEAABNJGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x375FC10", Offset = "0x375F010", VA = "0x18375FC10", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x375FA40", Offset = "0x375EE40", VA = "0x18375FA40")]
	public static EntityQuery JAHECLKIDGD(ComponentSystemBase MPLOKCCKBBP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[HKMENKHAJPO]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
public class DFDPOMOEMNA : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private FJEGFCLMACC EFPBHJBKLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private SceneService POMGNNIENEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery FDOFAODBNNC;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x37EB040", Offset = "0x37EA440", VA = "0x1837EB040", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x37EAC50", Offset = "0x37EA050", VA = "0x1837EAC50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x37EACF0", Offset = "0x37EA0F0", VA = "0x1837EACF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public DFDPOMOEMNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public struct JCIHEOIDKJN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public HIKBMDMACJE CKELBFAAOKG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900")]
	public static JCIHEOIDKJN ABLJGBEPCFM(in HIKBMDMACJE AGPLDILOLPM)
	{
		return default(JCIHEOIDKJN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900")]
	public static HIKBMDMACJE ABLJGBEPCFM(in JCIHEOIDKJN NHFNHDHDNCI)
	{
		return default(HIKBMDMACJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[AlwaysUpdateSystem]
public class GJLKIMNMNIH : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x3A64790", Offset = "0x3A63B90", VA = "0x183A64790", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640")]
	public GJLKIMNMNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[AlwaysUpdateSystem]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
public class HAHGEDGEAJG : FNIOMAHLONI, NGENPNOGFON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct GCHOPKMJKKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public HAHGEDGEAJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		public GCHOPKMJKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
		internal void <OnUpdate>b__0(Entity e, JCIHEOIDKJN ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FEGNAGMOFDB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct FDJBLPDGGBG
		{
			[Cpp2IlInjected.Token(Token = "0x200011F")]
			public struct MMOFNLHOMIC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				public LambdaParameterValueProvider_Entity.Runtime IEGFMKOEOHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public LambdaParameterValueProvider_IComponentData<JCIHEOIDKJN>.Runtime LIHANJMPGFG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity HIDOJODEBLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<JCIHEOIDKJN> BJIFBMGBOMI;

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x418FA60", Offset = "0x418EE60", VA = "0x18418FA60")]
			public void LPLCJMGACAE(HAHGEDGEAJG MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x418F9E0", Offset = "0x418EDE0", VA = "0x18418F9E0")]
			public MMOFNLHOMIC CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
			{
				return default(MMOFNLHOMIC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public HAHGEDGEAJG NEPFAMIFFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EntityCommandBuffer KMMHCKECEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private FDJBLPDGGBG JDAIGOONHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FDJBLPDGGBG.MMOFNLHOMIC* LGOHJMGEEGE;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HOFJKCPNDEG;

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x418FBD0", Offset = "0x418EFD0", VA = "0x18418FBD0")]
		internal void HCEIDPMHCNG(Entity EPPMCIFCHBF, JCIHEOIDKJN BPFJFNENBNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x418FE10", Offset = "0x418F210", VA = "0x18418FE10", Slot = "5")]
		public void ReadFromDisplayClass(ref GCHOPKMJKKA FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x418FE40", Offset = "0x418F240", VA = "0x18418FE40", Slot = "6")]
		public void WriteToDisplayClass(ref GCHOPKMJKKA FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x418FB30", Offset = "0x418EF30", VA = "0x18418FB30", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x418FD60", Offset = "0x418F160", VA = "0x18418FD60")]
		public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, ref FDJBLPDGGBG.MMOFNLHOMIC PHHHCCELBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x418FCD0", Offset = "0x418F0D0", VA = "0x18418FCD0")]
		public void LPLCJMGACAE(HAHGEDGEAJG MPLOKCCKBBP, ref GCHOPKMJKKA FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x418FAC0", Offset = "0x418EEC0", VA = "0x18418FAC0")]
		public unsafe static void DALIELACHGP(ArchetypeChunkIterator* OIGBHKBJFBM, void* KJMAEIHPMEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private GJLKIMNMNIH BBFGPJEOGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private FJEGFCLMACC EFPBHJBKLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery IPFOHLAMFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private ProfilerMarker PANAOAGAIEO;

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x3A67440", Offset = "0x3A66840", VA = "0x183A67440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x3A67600", Offset = "0x3A66A00", VA = "0x183A67600", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x3A674A0", Offset = "0x3A668A0", VA = "0x183A674A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public HAHGEDGEAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x3A67360", Offset = "0x3A66760", VA = "0x183A67360", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x3A67190", Offset = "0x3A66590", VA = "0x183A67190")]
	public static EntityQuery HJHIJJEEDMO(ComponentSystemBase MPLOKCCKBBP)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct IOKGHPNCNJM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public APDJNEDCAIJ KBMLCGACCJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public NativeHashMap<Entity, HOGMLAALAEJ> NMNOLKKCICL;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x4192240", Offset = "0x4191640", VA = "0x184192240")]
			public IOKGHPNCNJM(int NANBMPFBPOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x41921C0", Offset = "0x41915C0", VA = "0x1841921C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct IMCKFCHHMBI : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public NativeArray<Entity> NMNOLKKCICL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> GHBCKCKFICB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> IJNANAOPHII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> FACCOGIMNFB;

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x4192020", Offset = "0x4191420", VA = "0x184192020", Slot = "4")]
			public void Execute(int GABJOMFFJAI, TransformAccess GCKJJOINBCJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct JKKAHKGBOOM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public NativeArray<Entity> NMNOLKKCICL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> GHBCKCKFICB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> FACCOGIMNFB;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x4192D10", Offset = "0x4192110", VA = "0x184192D10", Slot = "4")]
			public void Execute(int GABJOMFFJAI, TransformAccess GCKJJOINBCJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private FJEGFCLMACC EFPBHJBKLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery CKDLCPNAFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery LGHCGEBCJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery MPGBBIBOJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery FJHJHMDBNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery GMCKGGNDIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private JobHandle HOBDCHBFLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private IOKGHPNCNJM KIJONAOBNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private IOKGHPNCNJM JDMGNDHGIIH;

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x37794E0", Offset = "0x37788E0", VA = "0x1837794E0", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777E80", VA = "0x183778A80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x37787D0", Offset = "0x3777BD0", VA = "0x1837787D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x3778D40", Offset = "0x3778140", VA = "0x183778D40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x3778810", Offset = "0x3777C10", VA = "0x183778810")]
		private void JAJDKBBJLNO(EntityQuery FDOFAODBNNC, out (NativeArrayAsync<JCIHEOIDKJN> handles, NativeArrayAsync<CABEJGFNMCM> bounds) MPEBBGJJODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x3778280", Offset = "0x3777680", VA = "0x183778280")]
		private void COFHJODAHMJ((NativeArrayAsync<JCIHEOIDKJN> handles, NativeArrayAsync<CABEJGFNMCM> bounds) MPEBBGJJODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x37787D0", Offset = "0x3777BD0", VA = "0x1837787D0")]
		private void HOBMAKAINII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x3779540", Offset = "0x3778940", VA = "0x183779540")]
		private void PEJDNNJJHGI(EntityQuery FDOFAODBNNC, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<JCIHEOIDKJN> handles) MPEBBGJJODN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x37784E0", Offset = "0x37778E0", VA = "0x1837784E0")]
		private void HIILHLDMEJL((NativeArrayAsync<Entity> entities, NativeArrayAsync<JCIHEOIDKJN> handles) MPEBBGJJODN, IOKGHPNCNJM HMAHEBBHMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x3779680", Offset = "0x3778A80", VA = "0x183779680")]
		private JobHandle PHKCEJKLFOP(IOKGHPNCNJM HMAHEBBHMNM, ComponentDataFromEntity<WorldPoseData> GHBCKCKFICB, ComponentDataFromEntity<WorldUniformScaleData> FACCOGIMNFB, ComponentDataFromEntity<WorldDeformableScaleData> IJNANAOPHII)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x3778950", Offset = "0x3777D50", VA = "0x183778950")]
		private JobHandle NCAMKIHIJIO(IOKGHPNCNJM HMAHEBBHMNM, ComponentDataFromEntity<WorldPoseData> GHBCKCKFICB, ComponentDataFromEntity<WorldUniformScaleData> FACCOGIMNFB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct FGKFKJJDFHC : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[HKMENKHAJPO]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	public class SplineLocalBoundsSystem : FNIOMAHLONI
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile]
		private struct MEEKPKOHACA : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public NativeArray<Entity> DMFEFOKFBHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> CJJIFPNNGLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			[ReadOnly]
			public ComponentDataFromEntity<CABEJGFNMCM> HPDLPIDADNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[WriteOnly]
			public NativeHashMap<Entity, HOGMLAALAEJ>.ParallelWriter HHJKGBOPMKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter HBOHGOLILBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter IGPKIGLJKAJ;

			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x4195120", Offset = "0x4194520", VA = "0x184195120", Slot = "4")]
			public void Execute(int GABJOMFFJAI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[BurstCompile]
		private struct BMDGAHALOMC : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public NativeArray<Entity> DINCOLMHFKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> GMFPGLDOANE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> JJOHNPFCCJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> PECLAAICEMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<CABEJGFNMCM> MIAOIDNAPMJ;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x418C260", Offset = "0x418B660", VA = "0x18418C260", Slot = "4")]
			public void Execute(int GABJOMFFJAI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery CHFNKCCHOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery MKKLAAOOLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery CFFOBDGCMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery KBGFJFPABAB;

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x38BB120", Offset = "0x38BA520", VA = "0x1838BB120", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x38BB330", Offset = "0x38BA730", VA = "0x1838BB330", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x38BAD00", Offset = "0x38BA100", VA = "0x1838BAD00")]
		private JobHandle LDOAHJJDAED(NativeArrayAsync<Entity> OGMMNHCCDJE, int DMFMCPNNNLJ, JobHandle JJJGGKAKAIG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x38BADE0", Offset = "0x38BA1E0", VA = "0x1838BADE0")]
		private JobHandle LDOAHJJDAED(NativeArray<Entity> IAFILHKCOOH, int DMFMCPNNNLJ, [Optional] JobHandle JJJGGKAKAIG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x38BA790", Offset = "0x38B9B90", VA = "0x1838BA790")]
		private NativeArrayAsync<Entity> DFPGOLGLBMD(EntityQuery FDOFAODBNNC)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x38BA340", Offset = "0x38B9740", VA = "0x1838BA340")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) CLKIIGLPKIG(NativeArrayAsync<Entity> FFLHJJMFPAK)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x38BA940", Offset = "0x38B9D40", VA = "0x1838BA940")]
		private void FCLODLKPEGJ(out NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x38BB090", Offset = "0x38BA490", VA = "0x1838BB090")]
		private void MLBNBALJGJB(NativeList<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x38BAFC0", Offset = "0x38BA3C0", VA = "0x1838BAFC0")]
		private void MLBNBALJGJB(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x38BA810", Offset = "0x38B9C10", VA = "0x1838BA810")]
		private void DLAKGOMGACD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		private static void JCBGLJNDBCJ(int IEMGOJHBECE, int EIEOEFPCKKG, int MMKNBENIKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x38BA9D0", Offset = "0x38B9DD0", VA = "0x1838BA9D0")]
		private static CABEJGFNMCM GDKNHDEEDLK(NativeArray<Entity> JNADGPGFELN, ComponentDataFromEntity<SplinePointPositionData> JJOHNPFCCJG, ComponentDataFromEntity<SplinePointScaleData> PECLAAICEMB)
		{
			return default(CABEJGFNMCM);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct CLGIOKDBKAL : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[HKMENKHAJPO]
	[NAPHGBOEKGO(GPIMBHHJLKL.Lifecycle)]
	public class DestroyLocalObjects : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[CPICBLLAMOM]
		private ObjectNetworkToLocalMapService KEENEJEMIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[CPICBLLAMOM]
		private ObjectLifecycleService PHNFNFPBDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private EntityQuery CCHGGGFCJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery NJBIPMCJOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery KLGGHNCMBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x37F0A80", Offset = "0x37EFE80", VA = "0x1837F0A80", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x37F0880", Offset = "0x37EFC80", VA = "0x1837F0880")]
		public bool OOOFIMOMOCK(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x37F0930", Offset = "0x37EFD30", VA = "0x1837F0930", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x37F0840", Offset = "0x37EFC40", VA = "0x1837F0840", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x37F0A60", Offset = "0x37EFE60", VA = "0x1837F0A60", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x1B46B10", Offset = "0x1B45F10", VA = "0x181B46B10", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x37F0840", Offset = "0x37EFC40", VA = "0x1837F0840")]
		private void OCAAFMAOCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x37F0790", Offset = "0x37EFB90", VA = "0x1837F0790")]
		private void NFJDLBGIPDF(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x37F0650", Offset = "0x37EFA50", VA = "0x1837F0650")]
		private void KOJKJNKALAO(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x37F0540", Offset = "0x37EF940", VA = "0x1837F0540")]
		private void FHCEPNOBCBM(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x37F0420", Offset = "0x37EF820", VA = "0x1837F0420")]
		private void APLDGAOHHCM(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[NAPHGBOEKGO(GPIMBHHJLKL.NetworkSend)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	public sealed class EnqueuePropertyDifferenceToNetwork : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private static GIGIFLGAPJL[] GGMHKBEMENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private HIDDNJAHKHA FCCGKCPMDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private AECLLFLJBLC CBGKJKIPPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PropertyDiffStateService GBGHENNGBGM;

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DB50", Offset = "0x3A5CF50", VA = "0x183A5DB50", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DA90", Offset = "0x3A5CE90", VA = "0x183A5DA90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D500", Offset = "0x3A5C900", VA = "0x183A5D500")]
		private void HJAGJDKMHJB(GIGIFLGAPJL EIONKOPIMNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		private void EBJAFGIDHMP(Entity OOEHGINMJGM, EHNBIOJHEAD DGDIPHPMEJP, HNBCIHNKHJC FBHLIBEOAED, ONPGIKEEJJM EHPGIFDCFEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Callbacks)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	public sealed class PropertyEventCallbacks : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private PropertyEventCallbacksService NBEGMMIIDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private PropertyDiffStateService GBGHENNGBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TransformOwnershipPhase EIONKOPIMNI;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x377EED0", Offset = "0x377E2D0", VA = "0x18377EED0", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x377EE00", Offset = "0x377E200", VA = "0x18377EE00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[NAPHGBOEKGO(GPIMBHHJLKL.NetworkSend)]
	internal class TransmitNetworkDataSystem : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private AHIIJGCPLGM IGDJIEOLHNM;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x38C2780", Offset = "0x38C1B80", VA = "0x1838C2780", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x38C2730", Offset = "0x38C1B30", VA = "0x1838C2730", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[HKMENKHAJPO]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	public class CalculateCullingBandChanges : FNIOMAHLONI, HIJIFLANIAO, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct GFHENHCKOIJ : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ArchetypeChunkEntityType DOCNAKBKHPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> FEIBBOPBEOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[WriteOnly]
			public NativeList<HNJGDEFJBEJ>.ParallelWriter OFNKADDKNLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public ArchetypeChunkComponentType<DLIPPIPENLK> DLDJLMMGPNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public float3 GMEHFCMOOAG;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private static readonly float4x2 JMMOLKBBEEO;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private static readonly float4x2 HKAGGJBMLCC;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private static readonly int4x2 HHDBHLBKLNH;

			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x38ADCE0", Offset = "0x38AD0E0", VA = "0x1838ADCE0", Slot = "4")]
			public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private static BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const int OONDPIFKGGD = 10;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private const double FOFIPBGMAPN = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery PDLCKOFGKMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery NCPGNOMODHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private double EBKCDDMOOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private CullingBandService LAIEIMPGIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TimeService LECPFPHPAAL;

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x37DE910", Offset = "0x37DDD10", VA = "0x1837DE910", Slot = "14")]
		public void MPBHMBLFPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x37DEC90", Offset = "0x37DE090", VA = "0x1837DEC90", Slot = "15")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x37DE920", Offset = "0x37DDD20", VA = "0x1837DE920", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x37DEA70", Offset = "0x37DDE70", VA = "0x1837DEA70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x37DE8A0", Offset = "0x37DDCA0", VA = "0x1837DE8A0")]
		private bool JJEDIKBLDLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x37DE560", Offset = "0x37DD960", VA = "0x1837DE560")]
		private void DNCLAPLLNEO(EntityQuery FDOFAODBNNC, float3 JIHHPOPOECN, string LBEPPIIBMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public struct HNJGDEFJBEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Entity OOEHGINMJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public HCFBDPBEMPC AJNJONIBFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public HCFBDPBEMPC IOHONDKAJKK;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	public class ProcessCullingBandChangeCallbacks : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CullingBandService LAIEIMPGIOH;

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x377BBF0", Offset = "0x377AFF0", VA = "0x18377BBF0", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x377BBD0", Offset = "0x377AFD0", VA = "0x18377BBD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Connectables)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	public class UpdateInertialProperties : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery AKPDFEPOIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private JPGOMJFBJNM PLPJIKJCDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x38C9470", Offset = "0x38C8870", VA = "0x1838C9470", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x38C9140", Offset = "0x38C8540", VA = "0x1838C9140", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x38C91D0", Offset = "0x38C85D0", VA = "0x1838C91D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[HKMENKHAJPO]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> IFIGLADOIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MHMNFNJCKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DHINFJBDIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private KinematicSleepChangeService JEKJCIEIMDD;

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x3A5CFD0", Offset = "0x3A5C3D0", VA = "0x183A5CFD0", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x3A5CAA0", Offset = "0x3A5BEA0", VA = "0x183A5CAA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D2D0", Offset = "0x3A5C6D0", VA = "0x183A5D2D0")]
		private void PLPJJONBJKD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> JOLFKOMKBCI, EntityQueryDesc FKABBMOICPB, bool DFDJIBDBDBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D190", Offset = "0x3A5C590", VA = "0x183A5D190")]
		private void PLPJJONBJKD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> JOLFKOMKBCI, EntityQueryDesc FKABBMOICPB, bool DFDJIBDBDBK, bool LCOAJKBMAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x3A5CD00", Offset = "0x3A5C100", VA = "0x183A5CD00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C8B0", Offset = "0x3A5BCB0", VA = "0x183A5C8B0")]
		private void KENKHKBKEMD(EntityQuery FDOFAODBNNC, bool AGJMDHKFDEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C1A0", Offset = "0x3A5B5A0", VA = "0x183A5C1A0")]
		private void CNOFFDOOHCK(EntityQuery FDOFAODBNNC, bool KDPJJJEFDFC, bool AGJMDHKFDEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BF40", Offset = "0x3A5B340", VA = "0x183A5BF40")]
		private void BJGDNKFKIEH(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D020", Offset = "0x3A5C420", VA = "0x183A5D020")]
		private void PDLIIJABGCJ(NativeList<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C5B0", Offset = "0x3A5B9B0", VA = "0x183A5C5B0")]
		private void HAMDGEKLMIG(NativeArray<Entity> NMNOLKKCICL, bool KDPJJJEFDFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C3B0", Offset = "0x3A5B7B0", VA = "0x183A5C3B0")]
		private NativeList<Entity> DNKKKKELHHJ(NativeArray<Entity> NMNOLKKCICL)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C6D0", Offset = "0x3A5BAD0", VA = "0x183A5C6D0")]
		private NativeList<Entity> JAIEHELPPDL(NativeArray<Entity> NMNOLKKCICL)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C160", Offset = "0x3A5B560", VA = "0x183A5C160")]
		private NativeList<Entity> CIELJGLLFAB(NativeArray<Entity> NMNOLKKCICL)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C710", Offset = "0x3A5BB10", VA = "0x183A5C710")]
		private NativeList<Entity> JPDBIFALPGN(NativeArray<Entity> NMNOLKKCICL, bool APLPDKIDMDE)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x3A5BEB0", Offset = "0x3A5B2B0", VA = "0x183A5BEB0")]
		private MHPJLCLAMGA BGLDDDGNFGJ(NativeArray<Entity> NMNOLKKCICL)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(MHPJLCLAMGA);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D430", Offset = "0x3A5C830", VA = "0x183A5D430")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private KinematicSleepChangeService JEKJCIEIMDD;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x377BC60", Offset = "0x377B060", VA = "0x18377BC60", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x377BC40", Offset = "0x377B040", VA = "0x18377BC40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : LLHDIPFAHAE
	{
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery JNOKLKNMNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery HCJCJNOHILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery HCEICPBJANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery NKDOJDNPNAL;

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x37EFE50", Offset = "0x37EF250", VA = "0x1837EFE50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x37F0010", Offset = "0x37EF410", VA = "0x1837F0010", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x37EFC10", Offset = "0x37EF010", VA = "0x1837EFC10")]
		private void BBEEHGAIIGL(EntityQuery FDOFAODBNNC, bool NBFEHKAOJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x37F0090", Offset = "0x37EF490", VA = "0x1837F0090")]
		private void PJACCPOCHJD(EntityQuery FDOFAODBNNC, bool NBFEHKAOJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	internal class AssignPlayerIdsSystem : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery HMINJLEIIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery GKHMEKLOLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private SceneService OGAOLGJGLCD;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x37D7420", Offset = "0x37D6820", VA = "0x1837D7420", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x37D72F0", Offset = "0x37D66F0", VA = "0x1837D72F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x37D7400", Offset = "0x37D6800", VA = "0x1837D7400", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x37D6BE0", Offset = "0x37D5FE0", VA = "0x1837D6BE0")]
		private void HPGKMOPMNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x37D6E60", Offset = "0x37D6260", VA = "0x1837D6E60")]
		private void LDODELGJKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x37D6FD0", Offset = "0x37D63D0", VA = "0x1837D6FD0")]
		private void OJCACJMLFHA(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x37D6AA0", Offset = "0x37D5EA0", VA = "0x1837D6AA0")]
		private void FJIADPLPMGI(NativeArray<Entity> NMNOLKKCICL, int BOEAEJMABBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x37D6CF0", Offset = "0x37D60F0", VA = "0x1837D6CF0")]
		private void JCJJJKADLLE(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x37D6E00", Offset = "0x37D6200", VA = "0x1837D6E00")]
		private void KJKHKPLMJPL(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		private static void GFIHIFCPJCD(int CPILGALONLA, Transform GCKJJOINBCJ, Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class PGICIFNLLCJ
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x3774610", Offset = "0x3773A10", VA = "0x183774610")]
	public static bool PAFPNLIPNLP(this SystemBase AAMAOJJKJKL, out Entity OOEHGINMJGM)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery DFGCELHIHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private DFBNDOPHHMN DMHKFMBINKP;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x37E0800", Offset = "0x37DFC00", VA = "0x1837E0800", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x37E06D0", Offset = "0x37DFAD0", VA = "0x1837E06D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x37E0790", Offset = "0x37DFB90", VA = "0x1837E0790", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<EOGDNFHHDIJ>, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private const string JEIKJFHBEPK = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private HKKJODMDCGO KPGCPMFDAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery EFKHNINMEBI;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private Entity MLCABOJMJFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x3761880", Offset = "0x3760C80", VA = "0x183761880")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x3761640", Offset = "0x3760A40", VA = "0x183761640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity CHKBDOALBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x3761B40", Offset = "0x3760F40", VA = "0x183761B40")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public KJNCFICFIIE KPBLJFHOECF
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x37616A0", Offset = "0x3760AA0", VA = "0x1837616A0")]
			get
			{
				return default(KJNCFICFIIE);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x3761AD0", Offset = "0x3760ED0", VA = "0x183761AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public KJNCFICFIIE LIOOAJAKFJB
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x37619C0", Offset = "0x3760DC0", VA = "0x1837619C0")]
			get
			{
				return default(KJNCFICFIIE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x3761EA0", Offset = "0x37612A0", VA = "0x183761EA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x3761FC0", Offset = "0x37613C0", VA = "0x183761FC0", Slot = "15")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x3761F40", Offset = "0x3761340", VA = "0x183761F40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x3761730", Offset = "0x3760B30", VA = "0x183761730", Slot = "14")]
		protected override void FDNMEDLFHIP(NativeArray<Entity> NMNOLKKCICL, NativeArray<Entity> MIKDNCKNFMH, NativeArray<Entity> LHBCMLCNEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x37618E0", Offset = "0x3760CE0", VA = "0x1837618E0")]
		private void JLBGIFGLLCP(NativeArray<Entity> NMNOLKKCICL, NativeArray<Entity> LHBCMLCNEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x3761BA0", Offset = "0x3760FA0", VA = "0x183761BA0")]
		private void MHBJOCCPMNE(Entity OOEHGINMJGM, Entity DFIOFNEGIPK, Entity DBEPNNBOGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2D79B80", Offset = "0x2D78F80", VA = "0x182D79B80")]
		private bool KNEMJPBHGAN<T>(out T FPLJCBGEJAP) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2D79AC0", Offset = "0x2D78EC0", VA = "0x182D79AC0")]
		private void BEFBJOMBIMM<T>(T FPLJCBGEJAP) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x3761A50", Offset = "0x3760E50", VA = "0x183761A50")]
		public bool KCPEEOKPBNO(KJNCFICFIIE CIPCHLEOKEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x3761610", Offset = "0x3760A10", VA = "0x183761610")]
		private static bool APFEDFEBBNM(KJNCFICFIIE KEPNHDGGIBD, KJNCFICFIIE HMIPBDHPFNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x3762080", Offset = "0x3761480", VA = "0x183762080")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x3761E60", Offset = "0x3761260", VA = "0x183761E60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery FDOFAODBNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x37E91D0", Offset = "0x37E85D0", VA = "0x1837E91D0", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x37E8CE0", Offset = "0x37E80E0", VA = "0x1837E8CE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x37E8D80", Offset = "0x37E8180", VA = "0x1837E8D80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x37E8B90", Offset = "0x37E7F90", VA = "0x1837E8B90")]
		private NativeArray<Entity> CMFPKFBKEBC(int NDNADCNCIGM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x37E8A80", Offset = "0x37E7E80", VA = "0x1837E8A80")]
		private void BNJJAELLMND(NativeArray<Entity> KKNDFGFOEJI, NativeArray<Entity> CJKABDECIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	internal class HideRemotePivotsNotInScope : FNIOMAHLONI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery KEOPMPMGOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery OPJCIKLLFIG;

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x3A687F0", Offset = "0x3A67BF0", VA = "0x183A687F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x3A688E0", Offset = "0x3A67CE0", VA = "0x183A688E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal static class PKLCCFHNLDH
{
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public const string HNJAMCMMLPG = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x3B93140", Offset = "0x3B92540", VA = "0x183B93140")]
	public static NativeArray<T> MDJMJOEHHGM<T>(NativeArray<Entity> NMNOLKKCICL, EntityManager BOGIEIBMFCN) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x3776460", Offset = "0x3775860", VA = "0x183776460")]
	public static void MBNCECEELMM(EntityQuery FDOFAODBNNC, EntityManager BOGIEIBMFCN, LBIICBANFEM PANNLLNEPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x37765A0", Offset = "0x37759A0", VA = "0x1837765A0")]
	public static void NGJJEIMOJLF(NativeArray<Entity> KKNDFGFOEJI, LBIICBANFEM PANNLLNEPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x3776330", Offset = "0x3775730", VA = "0x183776330")]
	public static void CNOOJKMGOIO(NativeArray<Entity> KKNDFGFOEJI, LBIICBANFEM PANNLLNEPNL)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery FDOFAODBNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TransformService KBMLCGACCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ObjectLifecycleService PHNFNFPBDJN;

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x38C8E10", Offset = "0x38C8210", VA = "0x1838C8E10", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x38C8D60", Offset = "0x38C8160", VA = "0x1838C8D60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x38C8E00", Offset = "0x38C8200", VA = "0x1838C8E00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x38C77F0", Offset = "0x38C6BF0", VA = "0x1838C77F0")]
		private void BOMHJPKDFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x38C76E0", Offset = "0x38C6AE0", VA = "0x1838C76E0")]
		private void ALNENHOLNFP(NativeArray<Entity> KKNDFGFOEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x38C8000", Offset = "0x38C7400", VA = "0x1838C8000")]
		private void GJJPCMDADIH(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x38C8EA0", Offset = "0x38C82A0", VA = "0x1838C8EA0")]
		private void PPPEMEOFFJH(NativeArray<Entity> CJKABDECIJK, NativeArray<RigidTransform> GGMHPLHGLJL, NativeArray<RigidTransform> EIMECFHMKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x38C88D0", Offset = "0x38C7CD0", VA = "0x1838C88D0")]
		private void JNAAEMKMMNF(NativeArray<RigidTransform> EIMECFHMKAG, NativeArray<Entity> CJKABDECIJK, NativeList<Entity> MFKFPOEENAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	internal class PostGameplayOnScopeChange : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery DFGCELHIHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery BGAJAKGAPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x377A3F0", Offset = "0x37797F0", VA = "0x18377A3F0", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x377A1E0", Offset = "0x37795E0", VA = "0x18377A1E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x377A330", Offset = "0x3779730", VA = "0x18377A330", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x377A170", Offset = "0x3779570", VA = "0x18377A170")]
		private void NKNIFBGAIPE(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	internal class PreventDisembodiedScopesSystem : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EntityQuery IOIMPFHBJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private EntityHierarchyParents ELOPNHNIFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private DFBNDOPHHMN DMHKFMBINKP;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x377BAF0", Offset = "0x377AEF0", VA = "0x18377BAF0", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x377BA40", Offset = "0x377AE40", VA = "0x18377BA40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x377BAE0", Offset = "0x377AEE0", VA = "0x18377BAE0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x377B8B0", Offset = "0x377ACB0", VA = "0x18377B8B0")]
		private void DNMKCFAMHAO(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<FEOKHEAJLOH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x38B34F0", Offset = "0x38B28F0", VA = "0x1838B34F0", Slot = "14")]
		protected override void FDNMEDLFHIP(NativeArray<Entity> NMNOLKKCICL, NativeArray<Entity> MIKDNCKNFMH, NativeArray<Entity> LHBCMLCNEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x38B3420", Offset = "0x38B2820", VA = "0x1838B3420")]
		[BurstCompile]
		private static void FDNMEDLFHIP(NativeArray<Entity> NMNOLKKCICL, NativeArray<Entity> LHBCMLCNEME, ComponentDataFromEntity<global::NELHLNDHFHE> GANCDIHOAFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x38B3680", Offset = "0x38B2A80", VA = "0x1838B3680")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x38B3640", Offset = "0x38B2A40", VA = "0x1838B3640", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : FNIOMAHLONI where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private EntityQuery KDLEJHPKDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery CKNFFACOPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private EntityQuery OKPEGHIKLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private EntityQuery IENOLOOFBPB;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x396C0A0", Offset = "0x396B4A0", VA = "0x18396C0A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x396C2A0", Offset = "0x396B6A0", VA = "0x18396C2A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x396C270", Offset = "0x396B670", VA = "0x18396C270", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x396BA90", Offset = "0x396AE90", VA = "0x18396BA90")]
		private void LBCAMPANDDM(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x396A9C0", Offset = "0x3969DC0", VA = "0x18396A9C0")]
		private void CKCHFGIENCG(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x396ADB0", Offset = "0x396A1B0", VA = "0x18396ADB0")]
		private void DIOKGDCKKAJ(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void FDNMEDLFHIP(NativeArray<Entity> NMNOLKKCICL, NativeArray<Entity> MIKDNCKNFMH, NativeArray<Entity> LHBCMLCNEME);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x396C330", Offset = "0x396B730", VA = "0x18396C330")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x25390D0", Offset = "0x25384D0", VA = "0x1825390D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class OOFJOGAAEEK : FNIOMAHLONI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private List<(EntityQuery, ComponentType)> BBLGAIECEEB;

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x3767160", Offset = "0x3766560", VA = "0x183767160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x3767360", Offset = "0x3766760", VA = "0x183767360", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x37674B0", Offset = "0x37668B0", VA = "0x1837674B0")]
	public OOFJOGAAEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct CHODOELLBHI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public int JNPBIMHEMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public int OABDMKOGJHH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x37D5700", Offset = "0x37D4B00", VA = "0x1837D5700")]
	public static Entity ABLJGBEPCFM(CHODOELLBHI MPEBBGJJODN)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x37D5700", Offset = "0x37D4B00", VA = "0x1837D5700")]
	public static CHODOELLBHI ABLJGBEPCFM(Entity OOEHGINMJGM)
	{
		return default(CHODOELLBHI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct JGCIFNFEELN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct EJHDKNLHMKL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly ComponentType ACMABPBDHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly NativeList<int> JGPMHBBALKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly NativeList<int> FMFHLNJDOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly NativeArray<Entity> NMNOLKKCICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly NativeArray<Entity> AHOJPGLOLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NativeArray<byte> KCOKIBMLPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly NativeArray<byte> OGHKGHLKPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public readonly int CIBDDGNAAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public readonly int CEDJANCIBJK;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool IHNGLPDGCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x3A59140", Offset = "0x3A58540", VA = "0x183A59140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x3A591C0", Offset = "0x3A585C0", VA = "0x183A591C0")]
	public EJHDKNLHMKL(ComponentType ACMABPBDHLP, NativeList<int> JGPMHBBALKB, NativeList<int> FMFHLNJDOKG, NativeArray<Entity> NMNOLKKCICL, NativeArray<Entity> AHOJPGLOLOP, NativeArray<byte> KCOKIBMLPJH, NativeArray<byte> OGHKGHLKPIH, int CIBDDGNAAME, int CEDJANCIBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x3A58ED0", Offset = "0x3A582D0", VA = "0x183A58ED0")]
	private NICFNFKBPKA FOLIDEIOGBM(NativeArray<byte> OGMMNHCCDJE, int GABJOMFFJAI)
	{
		return default(NICFNFKBPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	private T FOLIDEIOGBM<T>(NativeArray<byte> OGMMNHCCDJE, int GABJOMFFJAI) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x3A590F0", Offset = "0x3A584F0", VA = "0x183A590F0")]
	public NICFNFKBPKA IDOGFMDMBBG(int GABJOMFFJAI)
	{
		return default(NICFNFKBPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	public T IDOGFMDMBBG<T>(int GABJOMFFJAI) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x3A58E80", Offset = "0x3A58280", VA = "0x183A58E80")]
	public NICFNFKBPKA FHKLJKNGCME(int GABJOMFFJAI)
	{
		return default(NICFNFKBPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	public T FHKLJKNGCME<T>(int GABJOMFFJAI) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x3A58DA0", Offset = "0x3A581A0", VA = "0x183A58DA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct ODEFLDAMAII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public readonly EntityQuery FDOFAODBNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly NativeArray<PJPGKENBMMC> FIJECBKDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly ComponentType ACMABPBDHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly int CIBDDGNAAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly int CEDJANCIBJK;

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x37658C0", Offset = "0x3764CC0", VA = "0x1837658C0")]
	public ODEFLDAMAII(ComponentType ACMABPBDHLP, int CIBDDGNAAME, int CEDJANCIBJK, EntityQuery FDOFAODBNNC, NativeArray<PJPGKENBMMC> FIJECBKDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x3765870", Offset = "0x3764C70", VA = "0x183765870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct JEHOAILNICK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public int GABJOMFFJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public int DPKKONMCMNO;

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x817230", Offset = "0x816630", VA = "0x180817230")]
	public JEHOAILNICK(int GABJOMFFJAI, int DPKKONMCMNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct PJPGKENBMMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly int BPNKPMGDGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly int OLGJFEONMLB;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x817230", Offset = "0x816630", VA = "0x180817230")]
	public PJPGKENBMMC(int BPNKPMGDGFM, int OLGJFEONMLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct ONPGIKEEJJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly ODHBKAFBAFM BJKMNBIBKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int CIBDDGNAAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private unsafe readonly byte* KCOKIBMLPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private unsafe readonly byte* OGHKGHLKPIH;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool NFDBEOJPGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x3766F50", Offset = "0x3766350", VA = "0x183766F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public ODHBKAFBAFM HIIJFIFGFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660")]
		get
		{
			return default(ODHBKAFBAFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x3766F60", Offset = "0x3766360", VA = "0x183766F60")]
	public NICFNFKBPKA OOHMNEKOBFA(Type BKGBGEHNCAE)
	{
		return default(NICFNFKBPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x3767050", Offset = "0x3766450", VA = "0x183767050")]
	public NICFNFKBPKA PBFKHNCKHAE(Type BKGBGEHNCAE)
	{
		return default(NICFNFKBPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x3B84AB0", Offset = "0x3B83EB0", VA = "0x183B84AB0")]
	public T OOHMNEKOBFA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x3B84AD0", Offset = "0x3B83ED0", VA = "0x183B84AD0")]
	public T PBFKHNCKHAE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x3767140", Offset = "0x3766540", VA = "0x183767140")]
	public unsafe ONPGIKEEJJM(ODHBKAFBAFM BJKMNBIBKCI, int OLGJFEONMLB, byte* KCOKIBMLPJH, byte* OGHKGHLKPIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal abstract class IGLLODNDEPO : CPLEAJCINAE, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private PropertyDiffStateService GBGHENNGBGM;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected abstract GIGIFLGAPJL FIFBCIIDDAI
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CBD0", Offset = "0x3A6BFD0", VA = "0x183A6CBD0", Slot = "17")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CB40", Offset = "0x3A6BF40", VA = "0x183A6CB40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C900", Offset = "0x3A6BD00", VA = "0x183A6C900", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	protected IGLLODNDEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class EMKPDGNCHLA
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] KHDGMIPJOCI;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[DefaultMember("Item")]
internal class JGPIIEKKHEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly BBHAOFNBCPD CDECIAPNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly Dictionary<ComponentType, ODEFLDAMAII> NKCBDJGPKBA;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public ODEFLDAMAII CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x3A6FFD0", Offset = "0x3A6F3D0", VA = "0x183A6FFD0")]
		get
		{
			return default(ODEFLDAMAII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x3A70060", Offset = "0x3A6F460", VA = "0x183A70060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x3A70B00", Offset = "0x3A6FF00", VA = "0x183A70B00")]
	public JGPIIEKKHEG(CBGJJCKMFCA PEPLIFOGJAA, BBHAOFNBCPD CDECIAPNKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x3A707E0", Offset = "0x3A6FBE0", VA = "0x183A707E0")]
	public bool MPHIBFICBKB(ComponentType ACMABPBDHLP, out ODEFLDAMAII IGALNDDKACB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x3A706A0", Offset = "0x3A6FAA0", VA = "0x183A706A0")]
	public Dictionary<ComponentType, ODEFLDAMAII>.Enumerator IINGNKPPFJF()
	{
		return default(Dictionary<ComponentType, ODEFLDAMAII>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x3A700B0", Offset = "0x3A6F4B0", VA = "0x183A700B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x3A70240", Offset = "0x3A6F640", VA = "0x183A70240")]
	private void EJKCHCIBEDD(IEnumerable<AEBPMMDNEJA> IJGPCDHOGMJ, EntityManager BOGIEIBMFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x3A70730", Offset = "0x3A6FB30", VA = "0x183A70730")]
	private static int LIIBBKHKEPA(AEBPMMDNEJA NJGPHEOFKNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x3A70850", Offset = "0x3A6FC50", VA = "0x183A70850")]
	private static NativeArray<PJPGKENBMMC> NEGGMLFOIGG(AEBPMMDNEJA NJGPHEOFKNK, Allocator NDJJBKEIGCD = Allocator.Persistent)
	{
		return default(NativeArray<PJPGKENBMMC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal interface JCDAMMIJJIF
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool IHNGLPDGCKK
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	World KMLEAECJLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ADPCHJHDBOB(out NativeArray<int> ENMHBAPKFPB, Allocator NDJJBKEIGCD);

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KENJJOCNIJM(ComponentType ACMABPBDHLP, out EJHDKNLHMKL FAOPMHCCCKH, out ODEFLDAMAII FKIMHPOMHIG);

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KENJJOCNIJM(ComponentType ACMABPBDHLP, out EJHDKNLHMKL FAOPMHCCCKH);

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EJHDKNLHMKL ALNBBADMCFA(ComponentType ACMABPBDHLP);

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DPLGLNFLADJ CKABFCEHFDG();

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CENIEPJPMHJ(JobHandle FOMHAOIEGLJ);
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
internal interface PDOCGLJCFBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	World KMLEAECJLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	JGPIIEKKHEG AJFKMKEPOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	JBMJMBCCJEC OIEHOOLEMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NativeMultiHashMap<Entity, ONPGIKEEJJM> HLDGAPKJJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JobHandle MPMEBOPEKON
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
	bool HCLJCDJPJCB();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BIEFCABEIDG();

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JDJHODAEDMF(ComponentType ACMABPBDHLP, in EJHDKNLHMKL FIFHADHHPBI);

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PEKOCIDPJCF(AGNBDHNLGKL LDKBJDPJMKG, out Entity CCDPGFIPGOA);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct DPLGLNFLADJ
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public struct NJLENCOGEBD : IEnumerator<ONPGIKEEJJM>, IEnumerator, IDisposable, IEnumerable<ONPGIKEEJJM>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly NativeMultiHashMap<Entity, ONPGIKEEJJM> MJKBPIALMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly Entity OOEHGINMJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private NativeMultiHashMapIterator<Entity> MKNLLAIDHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private ONPGIKEEJJM OGHKGHLKPIH;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public ONPGIKEEJJM HMAPMKOECOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x165F850", Offset = "0x165EC50", VA = "0x18165F850", Slot = "4")]
			get
			{
				return default(ONPGIKEEJJM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x4195D90", Offset = "0x4195190", VA = "0x184195D90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x4195DE0", Offset = "0x41951E0", VA = "0x184195DE0")]
		internal NJLENCOGEBD(NativeMultiHashMap<Entity, ONPGIKEEJJM> MJKBPIALMBI, Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x4195B80", Offset = "0x4194F80", VA = "0x184195B80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x4195B50", Offset = "0x4194F50", VA = "0x184195B50")]
		public NJLENCOGEBD IINGNKPPFJF()
		{
			return default(NJLENCOGEBD);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x4195C50", Offset = "0x4195050", VA = "0x184195C50", Slot = "9")]
		private IEnumerator<ONPGIKEEJJM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x4195CF0", Offset = "0x41950F0", VA = "0x184195CF0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly PDOCGLJCFBJ LGKAKPIGKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly JobHandle IFIDKENHJIH;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int JMHOPAPDGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x37EF750", Offset = "0x37EEB50", VA = "0x1837EF750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool OGKFMAGAFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x37EF670", Offset = "0x37EEA70", VA = "0x1837EF670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x2B44950", Offset = "0x2B43D50", VA = "0x182B44950")]
	public DPLGLNFLADJ(PDOCGLJCFBJ LGKAKPIGKKN, JobHandle IFIDKENHJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x37EFAD0", Offset = "0x37EEED0", VA = "0x1837EFAD0")]
	public bool ONNCEGDLAII(Allocator NDJJBKEIGCD, out NativeKeyValueArrays<Entity, ONPGIKEEJJM> CGKNIAMFPAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x37EF840", Offset = "0x37EEC40", VA = "0x1837EF840")]
	public bool GOFPKCDAIHM(Allocator NDJJBKEIGCD, out (NativeArray<Entity> entities, int uniqueCount) CGKNIAMFPAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x37EF9B0", Offset = "0x37EEDB0", VA = "0x1837EF9B0")]
	public NJLENCOGEBD IHEAILBDNEB(Entity OOEHGINMJGM)
	{
		return default(NJLENCOGEBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[DefaultMember("Item")]
internal class JBMJMBCCJEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly BBHAOFNBCPD CDECIAPNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly List<ODEFLDAMAII> JOLFKOMKBCI;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public ODEFLDAMAII CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F880", Offset = "0x3A6EC80", VA = "0x183A6F880")]
		get
		{
			return default(ODEFLDAMAII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F910", Offset = "0x3A6ED10", VA = "0x183A6F910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6FE80", Offset = "0x3A6F280", VA = "0x183A6FE80")]
	public JBMJMBCCJEC(JGPIIEKKHEG NKCBDJGPKBA, CBGJJCKMFCA PEPLIFOGJAA, BBHAOFNBCPD CDECIAPNKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x3A6FE00", Offset = "0x3A6F200", VA = "0x183A6FE00")]
	public List<ODEFLDAMAII>.Enumerator IINGNKPPFJF()
	{
		return default(List<ODEFLDAMAII>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A6F950", Offset = "0x3A6ED50", VA = "0x183A6F950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A6FAD0", Offset = "0x3A6EED0", VA = "0x183A6FAD0")]
	private void EJKCHCIBEDD(JGPIIEKKHEG NKCBDJGPKBA, EntityManager BOGIEIBMFCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class CDEDFPJELEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly BBHAOFNBCPD CDECIAPNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly ObjectInstantiationService GKKDCEIPLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly global::BNIKHELKNNI<AEBPMMDNEJA> FGEFBMKHCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly World JIKCHAEDNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly EntityManager BOGIEIBMFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NativeHashMap<int, Entity> DGBFPMEEDJH;

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x37DC140", Offset = "0x37DB540", VA = "0x1837DC140")]
	public CDEDFPJELEC(ObjectInstantiationService GKKDCEIPLBI, CBGJJCKMFCA PEPLIFOGJAA, BBHAOFNBCPD CDECIAPNKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x37DAA80", Offset = "0x37D9E80", VA = "0x1837DAA80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x37DC0E0", Offset = "0x37DB4E0", VA = "0x1837DC0E0")]
	public bool OKDAKBELADB(AGNBDHNLGKL LDKBJDPJMKG, out Entity CCDPGFIPGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x37DBA80", Offset = "0x37DAE80", VA = "0x1837DBA80")]
	private void LGOHLHLFKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x37DB550", Offset = "0x37DA950", VA = "0x1837DB550")]
	private EntityArchetype KONDJMNLJFB(EntityArchetype PKKNGMBLCLL)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x37DAC30", Offset = "0x37DA030", VA = "0x1837DAC30")]
	public static void GFONOLJPLFI(EntityManager MGLEPHJOMPB, EntityManager GGBBKDCAKNO, NativeArray<Entity> PJGGFOCDOMC, NativeArray<EntityArchetype> AKIHMALJJCE, [Optional] NativeArray<Entity> CHGEJEAILDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x37DB1A0", Offset = "0x37DA5A0", VA = "0x1837DB1A0")]
	[Conditional("DEBUG_BUILD")]
	private static void KBECOLOBHJG(NativeArray<EntityArchetype> ENEONDNLDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x37DB310", Offset = "0x37DA710", VA = "0x1837DB310")]
	private static string KGKEEKHPEAN(EntityArchetype EEONIFNHKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x37DB060", Offset = "0x37DA460", VA = "0x1837DB060")]
	[CompilerGenerated]
	internal static void GHPLOIJBECE(ref Span<ComponentType> NGHAKLJPMAK, ComponentType FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x37DA8D0", Offset = "0x37D9CD0", VA = "0x1837DA8D0")]
	[CompilerGenerated]
	internal static void BGOBHLONKJM(Span<ComponentType> OGMMNHCCDJE, ref Span<ComponentType> NGHAKLJPMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x37DAB50", Offset = "0x37D9F50", VA = "0x1837DAB50")]
	[CompilerGenerated]
	internal static void FOEDCIPLAEL(Span<ComponentType> OGMMNHCCDJE, ref Span<ComponentType> NGHAKLJPMAK, ComponentType LAGEBBBEFCD)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[NAPHGBOEKGO(GPIMBHHJLKL.PropertyChanges)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld IGCCCKEIEFI;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x37D69E0", Offset = "0x37D5DE0", VA = "0x1837D69E0", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x37D6930", Offset = "0x37D5D30", VA = "0x1837D6930", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[AlwaysUpdateSystem]
	[NAPHGBOEKGO(GPIMBHHJLKL.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : FNIOMAHLONI, NGENPNOGFON, CJFEEGPLPHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct IELPFKOPEFK : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<byte> MADJMFNJAOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<byte> NGJJDMNBFII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeArray<PJPGKENBMMC> JPDHPKBIGBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[WriteOnly]
			public NativeList<JEHOAILNICK>.ParallelWriter EJLMPMIANBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int IPPMPLPIBEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int PHHNMININNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker BCFFJGCDDKI;

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x4191AC0", Offset = "0x4190EC0", VA = "0x184191AC0", Slot = "4")]
			public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x4191C00", Offset = "0x4191000", VA = "0x184191C00")]
			private unsafe int JDOKINJPJOF(byte* HJMBLPEIBAG, byte* LFAAOBNJLDK)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[BurstCompile]
		internal struct DHHEEHHAGKI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			[WriteOnly]
			public NativeList<int> JGPMHBBALKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			[WriteOnly]
			public NativeList<int> EIDACLEKEEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			[ReadOnly]
			public NativeList<JEHOAILNICK> DIGHIDCMLPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public ProfilerMarker BCFFJGCDDKI;

			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0x418DD90", Offset = "0x418D190", VA = "0x18418DD90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[BurstCompile]
		internal struct AABJMAPJKPK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[WriteOnly]
			public NativeArray<byte> OFNIOCJLGFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			public NativeArray<Entity> NMNOLKKCICL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			[ReadOnly]
			public ComponentDataFromEntity OOIPBNDAHEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int CIBDDGNAAME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public ProfilerMarker BCFFJGCDDKI;

			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x4189D00", Offset = "0x4189100", VA = "0x184189D00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[BurstCompile]
		internal struct AHOLLDMCHAE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, ONPGIKEEJJM> FHFIDJMMOGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			[ReadOnly]
			public NativeArray<byte> KCOKIBMLPJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			public NativeArray<byte> OGHKGHLKPIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			public NativeArray<Entity> NMNOLKKCICL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			[ReadOnly]
			public NativeArray<PJPGKENBMMC> KIAIIMPFHBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			[ReadOnly]
			public NativeList<int> FMFHLNJDOKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			[ReadOnly]
			public NativeList<int> JGPMHBBALKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int DNHEGKPLGKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int CEDJANCIBJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public ProfilerMarker BCFFJGCDDKI;

			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x418A520", Offset = "0x4189920", VA = "0x18418A520", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private static readonly ProfilerMarker FFDACKPMEFJ;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private static readonly ProfilerMarker GEBCENBDFFM;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private static readonly ProfilerMarker ALNAJNMNNJP;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private static readonly ProfilerMarker KNHECJIEFPG;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private static readonly ProfilerMarker GNCGJCDNDFG;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private static readonly ProfilerMarker JNMHFBJHCBI;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private static readonly ProfilerMarker MPEFNCKOJFJ;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly ProfilerMarker ADKGLMEDCJK;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private static readonly ProfilerMarker LMCMIBBONDM;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private static readonly ProfilerMarker FDPJDNJPFDD;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private static readonly ProfilerMarker CBNIAEJGHPG;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly ProfilerMarker EHIDPOKGPIP;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private static readonly ProfilerMarker ABBEKDDJOBL;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private static readonly ProfilerMarker OGGOGNFMDNB;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly ProfilerMarker CHDDFCMLJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private PropertyDiffStateService GBGHENNGBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private EntityQuery HLHEPPGOKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private EntityQuery OBPCGEMBNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private EntityQuery KLGGHNCMBHH;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		internal World KMLEAECJLDC
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x37E3510", Offset = "0x37E2910", VA = "0x1837E3510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private PDOCGLJCFBJ JMMCFBDLGPG
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x37E1650", Offset = "0x37E0A50", VA = "0x1837E1650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x37E3B10", Offset = "0x37E2F10", VA = "0x1837E3B10", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "15")]
		public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x37E3810", Offset = "0x37E2C10", VA = "0x1837E3810", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x37E39D0", Offset = "0x37E2DD0", VA = "0x1837E39D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x37E3960", Offset = "0x37E2D60", VA = "0x1837E3960", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x37E1670", Offset = "0x37E0A70", VA = "0x1837E1670")]
		private void JJJELPDKAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x37E0BE0", Offset = "0x37DFFE0", VA = "0x1837E0BE0")]
		internal void GANNBAKHJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x37E0C00", Offset = "0x37E0000", VA = "0x1837E0C00")]
		private void GANNBAKHJAC(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x37E35D0", Offset = "0x37E29D0", VA = "0x1837E35D0")]
		private void OFMIDGGHBBL(NativeArray<Entity> PJGGFOCDOMC, NativeArray<RRObjectPrefabData> IMPHKPDDBGC, ref NativeArray<Entity> HHJLKAHGIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x37E1AC0", Offset = "0x37E0EC0", VA = "0x1837E1AC0")]
		internal void LLBBOGEPHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x37E1AE0", Offset = "0x37E0EE0", VA = "0x1837E1AE0")]
		private void LLBBOGEPHML(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x37E2380", Offset = "0x37E1780", VA = "0x1837E2380")]
		internal void NLMHNMNGCLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x37E1F90", Offset = "0x37E1390", VA = "0x1837E1F90")]
		private void NGBOOLNHLAB(PDOCGLJCFBJ LGKAKPIGKKN, ODEFLDAMAII FKIMHPOMHIG, bool ANHKDMJBFIC, ref JobHandle KAPNFBFMFNE, ref JobHandle CMJGJKMHGJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x37E34E0", Offset = "0x37E28E0", VA = "0x1837E34E0")]
		internal bool NPEMLBINCNO(in ODEFLDAMAII LFAAOBNJLDK, out JobHandle CKELBFAAOKG, out EJHDKNLHMKL LNHNIEJPBKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x37E2AE0", Offset = "0x37E1EE0", VA = "0x1837E2AE0")]
		private bool NPEMLBINCNO(in ODEFLDAMAII LFAAOBNJLDK, bool ANHKDMJBFIC, out JobHandle CKELBFAAOKG, out EJHDKNLHMKL LNHNIEJPBKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x37E0A20", Offset = "0x37DFE20", VA = "0x1837E0A20")]
		internal (NativeList<int>, NativeList<int>) EJMDNCKBKOI(NativeList<JEHOAILNICK> DIGHIDCMLPJ, int NANBMPFBPOK, JobHandle JJJGGKAKAIG, out JobHandle FOMHAOIEGLJ, Allocator NDJJBKEIGCD = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x37E1EE0", Offset = "0x37E12E0", VA = "0x1837E1EE0")]
		internal static NativeArray<Entity> MDPKMBBAOEJ(EntityQuery FDOFAODBNNC, out JobHandle NILCPIFOJLK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x37E08A0", Offset = "0x37DFCA0", VA = "0x1837E08A0")]
		internal static NativeArray<byte> AJMOJJDBNIH(int GJDBLJLIDDI, out JobHandle KJCLCFCFDFM)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x37E2270", Offset = "0x37E1670", VA = "0x1837E2270")]
		internal static NativeArray<byte> NJMBLDDMOEB(EntityQuery FDOFAODBNNC, int KCBELKOOOJG, out JobHandle KJCLCFCFDFM)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x37E0920", Offset = "0x37DFD20", VA = "0x1837E0920")]
		internal static NativeArray<Entity> DFPGOLGLBMD(EntityQuery FDOFAODBNNC, out JobHandle FCDOPHKMGGD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x37E13E0", Offset = "0x37E07E0", VA = "0x1837E13E0")]
		internal NativeArray<byte> GHLOKPLLMOD(NativeArray<Entity> NMNOLKKCICL, ODEFLDAMAII FKIMHPOMHIG, JobHandle JJJGGKAKAIG, out JobHandle FOMHAOIEGLJ, Allocator NDJJBKEIGCD = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x37E1930", Offset = "0x37E0D30", VA = "0x1837E1930")]
		internal JobHandle KPEKNKNPEAK(in EJHDKNLHMKL MPEBBGJJODN, in ODEFLDAMAII FKIMHPOMHIG, NativeMultiHashMap<Entity, ONPGIKEEJJM> FHFIDJMMOGP, JobHandle JJJGGKAKAIG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x181CDE0", Offset = "0x181C1E0", VA = "0x18181CDE0")]
		private JobHandle BDLDAACKDOB(JobHandle EJJDDGDGBPA, JobHandle LJAILJDKCPF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x181CDE0", Offset = "0x181C1E0", VA = "0x18181CDE0")]
		private JobHandle BDLDAACKDOB(JobHandle EJJDDGDGBPA, JobHandle LJAILJDKCPF, JobHandle KAEHPPCEIPE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[NAPHGBOEKGO(GPIMBHHJLKL.RenderEffects)]
	internal class PropagateHoverRootTag : PJLDPFOODDC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public struct GECEHKMEFGG : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType PDLPNBGJEOP
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x377C450", Offset = "0x377B850", VA = "0x18377C450", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType KNLGDFCPAFM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x377C4B0", Offset = "0x377B8B0", VA = "0x18377C4B0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType HENKDJBNGMK
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x377C480", Offset = "0x377B880", VA = "0x18377C480", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x3775E30", Offset = "0x3775230", VA = "0x183775E30")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[NAPHGBOEKGO(GPIMBHHJLKL.RenderEffects)]
	internal class PropagateSelectionRootTag : PJLDPFOODDC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public struct KKDKJGCHAKN : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType PDLPNBGJEOP
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x377C4E0", Offset = "0x377B8E0", VA = "0x18377C4E0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType KNLGDFCPAFM
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x377C540", Offset = "0x377B940", VA = "0x18377C540", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType HENKDJBNGMK
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x377C510", Offset = "0x377B910", VA = "0x18377C510", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x3775E30", Offset = "0x3775230", VA = "0x183775E30")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[HKMENKHAJPO]
public class OPPKEEDFANG : LLHDIPFAHAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery FDOFAODBNNC;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x3767550", Offset = "0x3766950", VA = "0x183767550", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x37675E0", Offset = "0x37669E0", VA = "0x1837675E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public OPPKEEDFANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[HKMENKHAJPO]
public class KECMOHNICKN : LLHDIPFAHAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct EFFJFHNNGNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		public EFFJFHNNGNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct AKENDHACEDO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct KDDHFAACJPD
		{
			[Cpp2IlInjected.Token(Token = "0x2000161")]
			[NoAlias]
			public struct JLKGIFOKMEL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime CKFEMDBOBAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000464")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime JCIIDCPFJKO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AGAONOFNEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> DAMNPHOEADF;

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x4193260", Offset = "0x4192660", VA = "0x184193260")]
			public void LPLCJMGACAE(KECMOHNICKN MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x41931E0", Offset = "0x41925E0", VA = "0x1841931E0")]
			public JLKGIFOKMEL CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
			{
				return default(JLKGIFOKMEL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EntityManager BOGIEIBMFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NativeList<Entity> OGJIKOBLOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private KDDHFAACJPD JDAIGOONHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KDDHFAACJPD.JLKGIFOKMEL* LGOHJMGEEGE;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HOFJKCPNDEG;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IELMJPDHLBK;

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x418A8B0", Offset = "0x4189CB0", VA = "0x18418A8B0")]
		internal void HCEIDPMHCNG(Entity OOEHGINMJGM, SplinePointParentData MAPPOODMLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x418AA60", Offset = "0x4189E60", VA = "0x18418AA60", Slot = "5")]
		public void ReadFromDisplayClass(ref EFFJFHNNGNP FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x418AA70", Offset = "0x4189E70", VA = "0x18418AA70", Slot = "6")]
		public void WriteToDisplayClass(ref EFFJFHNNGNP FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x418A810", Offset = "0x4189C10", VA = "0x18418A810", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x418A9B0", Offset = "0x4189DB0", VA = "0x18418A9B0")]
		public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, [NoAlias] ref KDDHFAACJPD.JLKGIFOKMEL PHHHCCELBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x418A920", Offset = "0x4189D20", VA = "0x18418A920")]
		public void LPLCJMGACAE(KECMOHNICKN MPLOKCCKBBP, ref EFFJFHNNGNP FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x418A7A0", Offset = "0x4189BA0", VA = "0x18418A7A0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void DALIELACHGP(ArchetypeChunkIterator* OIGBHKBJFBM, void* KJMAEIHPMEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery LJGOAPACKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private ProfilerMarker HHLPIFCMDEG;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A721D0", Offset = "0x3A715D0", VA = "0x183A721D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public KECMOHNICKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x3A71FA0", Offset = "0x3A713A0", VA = "0x183A71FA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A71E40", Offset = "0x3A71240", VA = "0x183A71E40")]
	public static EntityQuery KIMLNOJJFEF(ComponentSystemBase MPLOKCCKBBP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[HKMENKHAJPO]
public class MBJJIAAFGLE : LLHDIPFAHAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityQuery NOLHEDKDLEO;

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x37624C0", Offset = "0x37618C0", VA = "0x1837624C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x3762550", Offset = "0x3761950", VA = "0x183762550", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public MBJJIAAFGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(OPPKEEDFANG))]
public class NFMPGPNNAJE : FNIOMAHLONI
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x3764590", Offset = "0x3763990", VA = "0x183764590", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public NFMPGPNNAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class HEJHBNMFCGE : LLHDIPFAHAE, NGENPNOGFON
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct HHOKGFOEIOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NativeHashMap<EHNBIOJHEAD, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		public HHOKGFOEIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JFIGHDHHKKA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct HBGNABGNEDM
		{
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			public struct FLBBNDPGJFI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				public LambdaParameterValueProvider_Entity.Runtime CKFEMDBOBAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime DFJCLNDNKCP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AGAONOFNEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> DLHPJBLIODG;

			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x41911F0", Offset = "0x41905F0", VA = "0x1841911F0")]
			public void LPLCJMGACAE(HEJHBNMFCGE MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x4191170", Offset = "0x4190570", VA = "0x184191170")]
			public FLBBNDPGJFI CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
			{
				return default(FLBBNDPGJFI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NativeHashMap<EHNBIOJHEAD, Entity> MJKBPIALMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private HBGNABGNEDM JDAIGOONHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HBGNABGNEDM.FLBBNDPGJFI* LGOHJMGEEGE;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HOFJKCPNDEG;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x41923F0", Offset = "0x41917F0", VA = "0x1841923F0")]
		internal void HCEIDPMHCNG(Entity OOEHGINMJGM, ObjectNetworkIdComponentData BHKDPHKPCGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xAE5B30", Offset = "0xAE4F30", VA = "0x180AE5B30", Slot = "5")]
		public void ReadFromDisplayClass(ref HHOKGFOEIOM FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x2D91180", Offset = "0x2D90580", VA = "0x182D91180", Slot = "6")]
		public void WriteToDisplayClass(ref HHOKGFOEIOM FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x4192350", Offset = "0x4191750", VA = "0x184192350", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x4192500", Offset = "0x4191900", VA = "0x184192500")]
		public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, ref HBGNABGNEDM.FLBBNDPGJFI PHHHCCELBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x4192470", Offset = "0x4191870", VA = "0x184192470")]
		public void LPLCJMGACAE(HEJHBNMFCGE MPLOKCCKBBP, ref HHOKGFOEIOM FNLJKNCMNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x41922E0", Offset = "0x41916E0", VA = "0x1841922E0")]
		public unsafe static void DALIELACHGP(ArchetypeChunkIterator* OIGBHKBJFBM, void* KJMAEIHPMEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ObjectNetworkToLocalMapService KEENEJEMIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private EntityQuery LJGOAPACKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private ProfilerMarker HHLPIFCMDEG;

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A67D30", Offset = "0x3A67130", VA = "0x183A67D30", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A67BF0", Offset = "0x3A66FF0", VA = "0x183A67BF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public HEJHBNMFCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A679F0", Offset = "0x3A66DF0", VA = "0x183A679F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A67890", Offset = "0x3A66C90", VA = "0x183A67890")]
	public static EntityQuery KIMLNOJJFEF(ComponentSystemBase MPLOKCCKBBP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public class HICLHBGNKME : LLHDIPFAHAE, NGENPNOGFON
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BNJIDDKKCJP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct JGGNNLKFPDC
		{
			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public struct MJJGGNALPLN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				public LambdaParameterValueProvider_Entity.Runtime CKFEMDBOBAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime PMFBLGLOLFA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity AGAONOFNEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> LOHICPEALNK;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x4192630", Offset = "0x4191A30", VA = "0x184192630")]
			public void LPLCJMGACAE(HICLHBGNKME MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x41925B0", Offset = "0x41919B0", VA = "0x1841925B0")]
			public MJJGGNALPLN CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
			{
				return default(MJJGGNALPLN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public HICLHBGNKME KPHLEIFDMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private JGGNNLKFPDC JDAIGOONHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JGGNNLKFPDC.MJJGGNALPLN* LGOHJMGEEGE;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HOFJKCPNDEG;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x418C600", Offset = "0x418BA00", VA = "0x18418C600")]
		public void HCEIDPMHCNG(Entity OOEHGINMJGM, ParentData HAMECCHFIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x418C560", Offset = "0x418B960", VA = "0x18418C560", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x418C6A0", Offset = "0x418BAA0", VA = "0x18418C6A0")]
		public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, ref JGGNNLKFPDC.MJJGGNALPLN PHHHCCELBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x418C620", Offset = "0x418BA20", VA = "0x18418C620")]
		public void LPLCJMGACAE(HICLHBGNKME MPLOKCCKBBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x418C4F0", Offset = "0x418B8F0", VA = "0x18418C4F0")]
		public unsafe static void DALIELACHGP(ArchetypeChunkIterator* OIGBHKBJFBM, void* KJMAEIHPMEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private EntityQuery LJGOAPACKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private ProfilerMarker HHLPIFCMDEG;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x3A683F0", Offset = "0x3A677F0", VA = "0x183A683F0", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x3A682E0", Offset = "0x3A676E0", VA = "0x183A682E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public HICLHBGNKME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x3A67D90", Offset = "0x3A67190", VA = "0x183A67D90")]
	[CompilerGenerated]
	private void FAGCGIGAEND(Entity OOEHGINMJGM, ParentData HAMECCHFIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x3A680E0", Offset = "0x3A674E0", VA = "0x183A680E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x3A67F80", Offset = "0x3A67380", VA = "0x183A67F80")]
	public static EntityQuery KIMLNOJJFEF(ComponentSystemBase MPLOKCCKBBP)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class OMLKDAHFKCM : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private int HCALICNLOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery FDOFAODBNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private ObjectPrefabs GKKDCEIPLBI;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x3766F00", Offset = "0x3766300", VA = "0x183766F00", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x3766C40", Offset = "0x3766040", VA = "0x183766C40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x3766D20", Offset = "0x3766120", VA = "0x183766D20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x37668A0", Offset = "0x3765CA0", VA = "0x1837668A0")]
	private void HJMIMOOFJMG(Entity OOEHGINMJGM, AGNBDHNLGKL LDKBJDPJMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public OMLKDAHFKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Serialization)]
	[UpdateBefore(typeof(OMLKDAHFKCM))]
	public class PostLoadAddSceneTagEntity : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private SceneService OGAOLGJGLCD;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x377A670", Offset = "0x3779A70", VA = "0x18377A670", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x377A4B0", Offset = "0x37798B0", VA = "0x18377A4B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[AECGGFPDEPE(FPOGPJMGMEG.OMRoom)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Serialization)]
	public class PostLoadInitializeNetworkId : FNIOMAHLONI, NGENPNOGFON
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct GMBLIOLLEEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public NativeHashMap<EHNBIOJHEAD, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
			public GMBLIOLLEEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct EFGHHEJEMDD : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000172")]
			private struct LAFMAHNBALG
			{
				[Cpp2IlInjected.Token(Token = "0x2000173")]
				[NoAlias]
				public struct OGFNJKMNPJJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000491")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime CKFEMDBOBAP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000492")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime OKGLBHNGHNJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000493")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime DFJCLNDNKCP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AGAONOFNEPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400048F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex NHJKCOAMCKD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000490")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> DLHPJBLIODG;

				[Cpp2IlInjected.Token(Token = "0x6000A32")]
				[Cpp2IlInjected.Address(RVA = "0x4194560", Offset = "0x4193960", VA = "0x184194560")]
				public void LPLCJMGACAE(PostLoadInitializeNetworkId MPLOKCCKBBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x41944B0", Offset = "0x41938B0", VA = "0x1841944B0")]
				public OGFNJKMNPJJ CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
				{
					return default(OGFNJKMNPJJ);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public NativeHashMap<EHNBIOJHEAD, Entity> MJKBPIALMBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private LAFMAHNBALG JDAIGOONHKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe LAFMAHNBALG.OGFNJKMNPJJ* LGOHJMGEEGE;

			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HOFJKCPNDEG;

			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IELMJPDHLBK;

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x418EC40", Offset = "0x418E040", VA = "0x18418EC40")]
			internal void HCEIDPMHCNG(Entity OOEHGINMJGM, int CIAGAFNFHGF, ref ObjectNetworkIdComponentData BHKDPHKPCGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0xAE5B30", Offset = "0xAE4F30", VA = "0x180AE5B30", Slot = "5")]
			public void ReadFromDisplayClass(ref GMBLIOLLEEM FNLJKNCMNKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x2D91180", Offset = "0x2D90580", VA = "0x182D91180", Slot = "6")]
			public void WriteToDisplayClass(ref GMBLIOLLEEM FNLJKNCMNKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x418EB50", Offset = "0x418DF50", VA = "0x18418EB50", Slot = "4")]
			public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x418ED70", Offset = "0x418E170", VA = "0x18418ED70")]
			public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, [NoAlias] ref LAFMAHNBALG.OGFNJKMNPJJ PHHHCCELBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x418ECD0", Offset = "0x418E0D0", VA = "0x18418ECD0")]
			public void LPLCJMGACAE(PostLoadInitializeNetworkId MPLOKCCKBBP, ref GMBLIOLLEEM FNLJKNCMNKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x418EAE0", Offset = "0x418DEE0", VA = "0x18418EAE0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void DALIELACHGP(ArchetypeChunkIterator* OIGBHKBJFBM, void* KJMAEIHPMEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[CPICBLLAMOM]
		private ObjectNetworkToLocalMapService KEENEJEMIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		[CPICBLLAMOM]
		private SceneService POMGNNIENEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery FDOFAODBNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EntityQuery OPAAAOFANBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ProfilerMarker BCOLBGDLMLO;

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x377B470", Offset = "0x377A870", VA = "0x18377B470", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x377B3C0", Offset = "0x377A7C0", VA = "0x18377B3C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x377B460", Offset = "0x377A860", VA = "0x18377B460", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x377AC60", Offset = "0x377A060", VA = "0x18377AC60")]
		public void BOGJAGFCKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x377A710", Offset = "0x3779B10", VA = "0x18377A710")]
		private void AJEJGFAACEG(NativeHashMap<EHNBIOJHEAD, Entity> MJKBPIALMBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x377AD30", Offset = "0x377A130", VA = "0x18377AD30")]
		private void BPCNCPOJENI(NativeHashMap<EHNBIOJHEAD, Entity> MJKBPIALMBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x377B130", Offset = "0x377A530", VA = "0x18377B130", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x377AF90", Offset = "0x377A390", VA = "0x18377AF90")]
		public static EntityQuery EEHPNNFAAOK(ComponentSystemBase MPLOKCCKBBP)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class DJBCLDMCKKA : FNIOMAHLONI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery MFIFMNGKCMD;

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x37EB260", Offset = "0x37EA660", VA = "0x1837EB260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x37EB2F0", Offset = "0x37EA6F0", VA = "0x1837EB2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public DJBCLDMCKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public class ILIOAPJCCEL : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::BNIKHELKNNI<MABHHCIHNCA> DIGFMEDALOI;

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E930", Offset = "0x3A6DD30", VA = "0x183A6E930", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E630", Offset = "0x3A6DA30", VA = "0x183A6E630", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E360", Offset = "0x3A6D760", VA = "0x183A6E360")]
	private void JPPILDFCHMM(NativeList<EntityArchetype> ENEONDNLDLL, NativeHashMap<int, HOGMLAALAEJ> GKEOKLBJOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E4F0", Offset = "0x3A6D8F0", VA = "0x183A6E4F0")]
	private Span<int> NFGHGGJPGAC(EntityArchetype EEONIFNHKKP)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DC90", Offset = "0x3A6D090", VA = "0x183A6DC90")]
	private bool CFCGNKKEDCA(int KCBELKOOOJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DD60", Offset = "0x3A6D160", VA = "0x183A6DD60")]
	private void CKIIEMCCCBF(NativeHashMap<int, HOGMLAALAEJ> GKEOKLBJOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public ILIOAPJCCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Serialization)]
	public class PreSerializeRemoveEntities : FNIOMAHLONI
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EntityQuery JEACLOBDBBD;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x377B530", Offset = "0x377A930", VA = "0x18377B530", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x377B7B0", Offset = "0x377ABB0", VA = "0x18377B7B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[NAPHGBOEKGO(GPIMBHHJLKL.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : FNIOMAHLONI, NGENPNOGFON
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct BALAABBONGD
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
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
			public BALAABBONGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x418AA80", Offset = "0x4189E80", VA = "0x18418AA80")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct DELLKFALBEP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[ReadOnly]
			public NativeList<int> JGPMHBBALKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			[ReadOnly]
			public NativeArray<Entity> AHOJPGLOLOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public ComponentDataFromEntity DABAMMKPIJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			[ReadOnly]
			public NativeArray<byte> OGHKGHLKPIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public int CIBDDGNAAME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public ComponentType ACMABPBDHLP;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x418DB70", Offset = "0x418CF70", VA = "0x18418DB70")]
			internal void HCEIDPMHCNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x418DD50", Offset = "0x418D150", VA = "0x18418DD50", Slot = "5")]
			public void ReadFromDisplayClass(ref BALAABBONGD FNLJKNCMNKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x418DB60", Offset = "0x418CF60", VA = "0x18418DB60", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x418DD30", Offset = "0x418D130", VA = "0x18418DD30")]
			public void LPLCJMGACAE(ShadowWorldApplyPropertyDifferencesToShadowWorld MPLOKCCKBBP, ref BALAABBONGD FNLJKNCMNKN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private PropertyDiffStateService GBGHENNGBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private JobHandle EJGNGBNNDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JobHandle BICENEGMMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private JCDAMMIJJIF LGKAKPIGKKN;

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x38B9960", Offset = "0x38B8D60", VA = "0x1838B9960", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x38B9580", Offset = "0x38B8980", VA = "0x1838B9580")]
		public JobHandle KIMFOMHMCHE(JobHandle JJJGGKAKAIG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x38B95C0", Offset = "0x38B89C0", VA = "0x1838B95C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x38B9270", Offset = "0x38B8670", VA = "0x1838B9270")]
		private bool DBGLIIBFHPE(JobHandle JJJGGKAKAIG, int KCBELKOOOJG, out JobHandle LACOFIHGOKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[JMGOLFGIKPD]
[ExecuteAlways]
[UpdateInGroup(typeof(CMBMNPJPBFO))]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
internal sealed class LKGKDEJNNKA : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x3760F50", Offset = "0x3760350", VA = "0x183760F50", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public LKGKDEJNNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[JMGOLFGIKPD]
[ExecuteAlways]
[UpdateInGroup(typeof(KCEIFHEFILO))]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
internal sealed class HBBOKDFFBAB : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x3A67660", Offset = "0x3A66A60", VA = "0x183A67660", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public HBBOKDFFBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[JMGOLFGIKPD]
[ExecuteAlways]
[UpdateInGroup(typeof(EJJEKNIEJEG))]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
internal sealed class IMMIFCNADDO : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E9D0", Offset = "0x3A6DDD0", VA = "0x183A6E9D0", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public IMMIFCNADDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[JMGOLFGIKPD]
[ExecuteAlways]
[UpdateInGroup(typeof(KEGKPFMPCFC))]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
internal sealed class HJPKCFFIEFK : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x3A68450", Offset = "0x3A67850", VA = "0x183A68450", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public HJPKCFFIEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class OEIBAELADLN : IGLLODNDEPO
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override GIGIFLGAPJL FIFBCIIDDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x6C6940", Offset = "0x6C5D40", VA = "0x1806C6940", Slot = "18")]
		get
		{
			return default(GIGIFLGAPJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x37658F0", Offset = "0x3764CF0", VA = "0x1837658F0")]
	public OEIBAELADLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[JMGOLFGIKPD]
[ExecuteAlways]
[UpdateInGroup(typeof(DAONCNOMFNJ))]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
internal sealed class LIOLOBNICAG : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x3760720", Offset = "0x375FB20", VA = "0x183760720", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public LIOLOBNICAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class NOPEBFMNAHL : PPGAFNDLJLE
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public NOPEBFMNAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class PFBHPPAMKCL : IGLLODNDEPO
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override GIGIFLGAPJL FIFBCIIDDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "18")]
		get
		{
			return default(GIGIFLGAPJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x37658F0", Offset = "0x3764CF0", VA = "0x1837658F0")]
	public PFBHPPAMKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[JMGOLFGIKPD]
[ExecuteAlways]
[UpdateInGroup(typeof(PDJIPGJNAFN))]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
internal sealed class DLBHANFAILG : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x37EB400", Offset = "0x37EA800", VA = "0x1837EB400", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public DLBHANFAILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class CMIMLLOIBPH : PPGAFNDLJLE
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public CMIMLLOIBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class OBFFAPMDCOE : PPGAFNDLJLE
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public OBFFAPMDCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class KLGIPLKAPBN : FNIOMAHLONI
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public KLGIPLKAPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[HKMENKHAJPO]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
public class EHDKFNMCMAB : FNIOMAHLONI, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private TimeService LECPFPHPAAL;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x3A58D50", Offset = "0x3A58150", VA = "0x183A58D50", Slot = "14")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x3A58D30", Offset = "0x3A58130", VA = "0x183A58D30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public EHDKFNMCMAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.TransformSyncing)]
	public class CopyTransformDataFromGameObjects : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct GCALBAPNEHN : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private const float CBKJBEBKJIL = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[ReadOnly]
			public NativeArray<Entity> NMNOLKKCICL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> JMDJFLKIAHG;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x4190880", Offset = "0x418FC80", VA = "0x184190880", Slot = "4")]
			public void Execute(int GABJOMFFJAI, TransformAccess GCKJJOINBCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x4190AB0", Offset = "0x418FEB0", VA = "0x184190AB0")]
			private bool MGPAAELLJNJ(float3 IOHONDKAJKK, float3 AJNJONIBFJA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x4190A40", Offset = "0x418FE40", VA = "0x184190A40")]
			private bool LPACGAKFHKP(quaternion IOHONDKAJKK, quaternion AJNJONIBFJA)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		private struct HCBDGHFOBGG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			[ReadOnly]
			public NativeArray<Entity> NMNOLKKCICL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> NAACMJIOMAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> DKNCCLCOLEA;

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x4191250", Offset = "0x4190650", VA = "0x184191250", Slot = "4")]
			public void Execute(int GABJOMFFJAI, TransformAccess GCKJJOINBCJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly BBHAOFNBCPD BPKJEMIIKPH;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly BBHAOFNBCPD NLKAFEGKELB;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly BBHAOFNBCPD DFHPEPLNDLF;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly ProfilerMarker HIDNBFJJABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private CEOBFGJBIGO OAGEKANNMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private CBGJJCKMFCA PEPLIFOGJAA;

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x37E70B0", Offset = "0x37E64B0", VA = "0x1837E70B0", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x37E6D10", Offset = "0x37E6110", VA = "0x1837E6D10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x37E6D40", Offset = "0x37E6140", VA = "0x1837E6D40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[NAPHGBOEKGO(GPIMBHHJLKL.TransformSyncing)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	public class RegisterTransforms : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct KELFAAIKHFB : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct EIJLHHCOPJI
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				public struct BENIDIEAFFA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004CA")]
					public LambdaParameterValueProvider_Entity.Runtime CKFEMDBOBAP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004CB")]
					public LambdaParameterValueProvider_IComponentData<OEFJJMOOHJE>.Runtime EPMAAEIDCCI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004CC")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime OEAGGGKLMJM;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity AGAONOFNEPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<OEFJJMOOHJE> ODOHLLIOOFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> GBFJCGMCIMM;

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x418F330", Offset = "0x418E730", VA = "0x18418F330")]
				public void LPLCJMGACAE(RegisterTransforms MPLOKCCKBBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x418F270", Offset = "0x418E670", VA = "0x18418F270")]
				public BENIDIEAFFA CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
				{
					return default(BENIDIEAFFA);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private EIJLHHCOPJI JDAIGOONHKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe EIJLHHCOPJI.BENIDIEAFFA* LGOHJMGEEGE;

			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HOFJKCPNDEG;

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x4193420", Offset = "0x4192820", VA = "0x184193420")]
			internal void HCEIDPMHCNG(Entity OOEHGINMJGM, OEFJJMOOHJE HCDIEBFNKKL, Transform GCKJJOINBCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x4193330", Offset = "0x4192730", VA = "0x184193330", Slot = "4")]
			public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x4193530", Offset = "0x4192930", VA = "0x184193530")]
			public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, ref EIJLHHCOPJI.BENIDIEAFFA PHHHCCELBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x4193520", Offset = "0x4192920", VA = "0x184193520")]
			public void LPLCJMGACAE(RegisterTransforms MPLOKCCKBBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x41932C0", Offset = "0x41926C0", VA = "0x1841932C0")]
			public unsafe static void DALIELACHGP(ArchetypeChunkIterator* OIGBHKBJFBM, void* KJMAEIHPMEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct NLGBJJPKJMA : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000190")]
			private struct JNFKBEDELDK
			{
				[Cpp2IlInjected.Token(Token = "0x2000191")]
				[NoAlias]
				public struct EMFGGIOLPPF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004D1")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime CKFEMDBOBAP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004D2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<OEFJJMOOHJE>.Runtime EPMAAEIDCCI;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004CF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity AGAONOFNEPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004D0")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<OEFJJMOOHJE> ODOHLLIOOFO;

				[Cpp2IlInjected.Token(Token = "0x6000AA3")]
				[Cpp2IlInjected.Address(RVA = "0x4193180", Offset = "0x4192580", VA = "0x184193180")]
				public void LPLCJMGACAE(RegisterTransforms MPLOKCCKBBP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x4193100", Offset = "0x4192500", VA = "0x184193100")]
				public EMFGGIOLPPF CHCNMKHOAEB(ref ArchetypeChunk MMKJGDPHNDG, int AHFBOHEMFBP, int NOJFHEHLGKJ)
				{
					return default(EMFGGIOLPPF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private JNFKBEDELDK JDAIGOONHKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JNFKBEDELDK.EMFGGIOLPPF* LGOHJMGEEGE;

			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x4195E90", Offset = "0x4195290", VA = "0x184195E90")]
			internal void HCEIDPMHCNG(Entity OOEHGINMJGM, OEFJJMOOHJE HCDIEBFNKKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x4195E00", Offset = "0x4195200", VA = "0x184195E00", Slot = "4")]
			public void Execute(ArchetypeChunk MMMDCDCMKJM, int CJHNCJBFHIC, int KIKDIPINDBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x4195F70", Offset = "0x4195370", VA = "0x184195F70")]
			public void PFHOPPKONHI(ref ArchetypeChunk MMMDCDCMKJM, [NoAlias] ref JNFKBEDELDK.EMFGGIOLPPF PHHHCCELBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x4193180", Offset = "0x4192580", VA = "0x184193180")]
			public void LPLCJMGACAE(RegisterTransforms MPLOKCCKBBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private CEOBFGJBIGO OAGEKANNMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery DDBBLOCFMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery FCMFADFLKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EntityQuery FFGHBCHIAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private EntityQuery HCIJEMKFGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private EntityQuery IEMOBDFKCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ProfilerMarker HCEMBOICJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private EntityQuery PHCPDPNJHCO;

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x38B3380", Offset = "0x38B2780", VA = "0x1838B3380", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x38B30A0", Offset = "0x38B24A0", VA = "0x1838B30A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x38B32B0", Offset = "0x38B26B0", VA = "0x1838B32B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x38B2840", Offset = "0x38B1C40", VA = "0x1838B2840")]
		private void MCGPFAJFFML(EntityQuery FDOFAODBNNC, APDJNEDCAIJ CMFDDOPDCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x38B2A80", Offset = "0x38B1E80", VA = "0x1838B2A80")]
		private void MGCHGBAHEIP(EntityQuery FDOFAODBNNC, APDJNEDCAIJ CMFDDOPDCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x38B3250", Offset = "0x38B2650", VA = "0x1838B3250", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x38B2CF0", Offset = "0x38B20F0", VA = "0x1838B2CF0")]
		private void NIHCHGPPNLM(NativeArray<Entity> NMNOLKKCICL, APDJNEDCAIJ CMFDDOPDCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x38B1FE0", Offset = "0x38B13E0", VA = "0x1838B1FE0")]
		[BurstCompile]
		internal static void AHOJBMNDDCM(NativeArray<OEFJJMOOHJE> JFPPGGNNCEE, ComponentDataFromEntity<OEFJJMOOHJE> OOIFDKMOIFH, APDJNEDCAIJ CMFDDOPDCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		private static void OIOLMPKJPBB(Transform GCKJJOINBCJ, Entity OOEHGINMJGM, int GABJOMFFJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		private static void GGPJBOOMLBB(Entity OOEHGINMJGM, int GABJOMFFJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		private static void LGHIHLJPPDE(int GABJOMFFJAI, APDJNEDCAIJ CMFDDOPDCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x38B24C0", Offset = "0x38B18C0", VA = "0x1838B24C0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void FIHBHIAPPIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x38B2E30", Offset = "0x38B2230", VA = "0x1838B2E30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x38B26A0", Offset = "0x38B1AA0", VA = "0x1838B26A0")]
		public static EntityQuery HKIMALKJDLF(ComponentSystemBase MPLOKCCKBBP)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x38B22F0", Offset = "0x38B16F0", VA = "0x1838B22F0")]
		public static EntityQuery FEEMPMBFBDH(ComponentSystemBase MPLOKCCKBBP)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	[NAPHGBOEKGO(GPIMBHHJLKL.TransformSyncing)]
	public class CopyTransformDataToGameObjects : FNIOMAHLONI, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[BurstCompile]
		private struct GEAOBIJHFOK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> JMDJFLKIAHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public NativeArray<Entity> NMNOLKKCICL;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x4190D70", Offset = "0x4190170", VA = "0x184190D70", Slot = "4")]
			public void Execute(int GABJOMFFJAI, TransformAccess GCKJJOINBCJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[BurstCompile]
		private struct OFOJJFDCDOG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> NAACMJIOMAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public NativeArray<Entity> NMNOLKKCICL;

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x41966E0", Offset = "0x4195AE0", VA = "0x1841966E0", Slot = "4")]
			public void Execute(int GABJOMFFJAI, TransformAccess GCKJJOINBCJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct FLMJHLKABCM : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> NAACMJIOMAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> DKNCCLCOLEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			[ReadOnly]
			public NativeArray<Entity> NMNOLKKCICL;

			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x41900F0", Offset = "0x418F4F0", VA = "0x1841900F0", Slot = "4")]
			public void Execute(int GABJOMFFJAI, TransformAccess GCKJJOINBCJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly BBHAOFNBCPD BPKJEMIIKPH;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly BBHAOFNBCPD NLKAFEGKELB;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static readonly BBHAOFNBCPD DFHPEPLNDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private CEOBFGJBIGO OAGEKANNMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery IJBEHEDFBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EntityQuery FNJNLMLJJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private EntityQuery KACDPKGEFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TransformAccessArray ACABPMPKOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TransformAccessArray EPOEFEEMMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TransformAccessArray PPIFAMFDGII;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x37E7EB0", Offset = "0x37E72B0", VA = "0x1837E7EB0", Slot = "14")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x37E73E0", Offset = "0x37E67E0", VA = "0x1837E73E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x37E75D0", Offset = "0x37E69D0", VA = "0x1837E75D0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x37E7660", Offset = "0x37E6A60", VA = "0x1837E7660", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x37E7690", Offset = "0x37E6A90", VA = "0x1837E7690", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x37E7260", Offset = "0x37E6660", VA = "0x1837E7260")]
		private NativeArray<Entity> HGPAFLCOHII(NativeArray<OEFJJMOOHJE> JGPMHBBALKB, NativeList<Entity> PJGGFOCDOMC, TransformAccessArray LCAGNNMGOJA, TransformAccessArray JNGCKGMAFDK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[NAPHGBOEKGO(GPIMBHHJLKL.TransformSyncing)]
	[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
	public class CopyTransformParentsToGameObjects : FNIOMAHLONI, CJFEEGPLPHA
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private IGNFHNIPNCL CBNBMEGDBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private CGJMICMININ BICKJDNHDLM;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x377BAE0", Offset = "0x377AEE0", VA = "0x18377BAE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x37E8190", Offset = "0x37E7590", VA = "0x1837E8190", Slot = "14")]
		public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x37E8340", Offset = "0x37E7740", VA = "0x1837E8340", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x37E8010", Offset = "0x37E7410", VA = "0x1837E8010")]
		private static void GOGJOPCBCAL(EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, Entity CNDFBGEJOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x37E82A0", Offset = "0x37E76A0", VA = "0x1837E82A0")]
		private static bool NCFBPALOAMF(EntityManager BOGIEIBMFCN, Entity OOEHGINMJGM, out Transform GCKJJOINBCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[NAPHGBOEKGO(GPIMBHHJLKL.TransformSyncing)]
	public class L2PToL2WHierarchy : FNIOMAHLONI
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[BurstCompile]
		private struct BLFIFEPMHPB : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> JKPABPABGIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> HOOHFOGFEPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> AICEEJAGJEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> AAONBPDBLPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public ArchetypeChunkComponentType<LocalToWorldData> ONPBDMIIFNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> JBCOLKOBIAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public uint JPNHMOJCOKP;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x418BD90", Offset = "0x418B190", VA = "0x18418BD90")]
			[Conditional("DEBUG_BUILD")]
			private void HLFDGKAOAJG(Entity OOEHGINMJGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x418BAA0", Offset = "0x418AEA0", VA = "0x18418BAA0", Slot = "4")]
			public void Execute(ArchetypeChunk MMMDCDCMKJM, int GABJOMFFJAI, int NKKHCJHCHOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x418BE60", Offset = "0x418B260", VA = "0x18418BE60")]
			private void IDNNOLPDABK(float4x4 LGNKONKHCIF, Entity OOEHGINMJGM, bool IPDIGHFHPDI, int CLPHJECJKHN = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery FKLEAJBIIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery EMFBFCLLNHL;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x375F1C0", Offset = "0x375E5C0", VA = "0x18375F1C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x375F2E0", Offset = "0x375E6E0", VA = "0x18375F2E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class ACHIJEDJJFM : IHCOEHCAPMG
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct DMGOFNDGJGP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> JKPABPABGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ArchetypeChunkComponentType<LocalToWorldData> ONPBDMIIFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public uint JPNHMOJCOKP;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x38AD400", Offset = "0x38AC800", VA = "0x1838AD400", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int GABJOMFFJAI, int NKKHCJHCHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x38AD500", Offset = "0x38AC900", VA = "0x1838AD500")]
		public bool LJGOHAGNGNE(ArchetypeChunk MMMDCDCMKJM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery FKLEAJBIIDN;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x37D3D00", Offset = "0x37D3100", VA = "0x1837D3D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x37D3E30", Offset = "0x37D3230", VA = "0x1837D3E30", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle IIKHJPHAMBH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public ACHIJEDJJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class LLFHIECCAJP : IHCOEHCAPMG
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct FCCFKKOKDMH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> KODLANNAEJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public ArchetypeChunkComponentType<WorldPoseData> BNECGEEOHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> HOGDDHOGPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> MCBPJOKIFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public uint JPNHMOJCOKP;

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x418F5B0", Offset = "0x418E9B0", VA = "0x18418F5B0", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int GABJOMFFJAI, int NKKHCJHCHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x418F960", Offset = "0x418ED60", VA = "0x18418F960")]
		public bool LJGOHAGNGNE(ArchetypeChunk MMMDCDCMKJM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery KBMLCGACCJB;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x3761030", Offset = "0x3760430", VA = "0x183761030", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x3761140", Offset = "0x3760540", VA = "0x183761140", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle IIKHJPHAMBH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x1A55680", Offset = "0x1A54A80", VA = "0x181A55680")]
	public LLFHIECCAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class CCNLIDOIIFK : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct OGJMBMKPBNK : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> EEAOPKBMDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> LJMPDIIKADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> HFILIOEPOJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ArchetypeChunkComponentType<LocalToParentData> GJECEMFACBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public uint JPNHMOJCOKP;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x38AE260", Offset = "0x38AD660", VA = "0x1838AE260", Slot = "4")]
		public void Execute(ArchetypeChunk MMMDCDCMKJM, int GABJOMFFJAI, int NKKHCJHCHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x38AE970", Offset = "0x38ADD70", VA = "0x1838AE970")]
		public bool LJGOHAGNGNE(ArchetypeChunk MMMDCDCMKJM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery KBMLCGACCJB;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x37DA630", Offset = "0x37D9A30", VA = "0x1837DA630", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x37DA760", Offset = "0x37D9B60", VA = "0x1837DA760", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle IIKHJPHAMBH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640")]
	public CCNLIDOIIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[NAPHGBOEKGO(GPIMBHHJLKL.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : PJLDPFOODDC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public struct KFHNEBPFGCD : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override ComponentType PDLPNBGJEOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x377C570", Offset = "0x377B970", VA = "0x18377C570", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType KNLGDFCPAFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x377C5D0", Offset = "0x377B9D0", VA = "0x18377C5D0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType HENKDJBNGMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x377C5A0", Offset = "0x377B9A0", VA = "0x18377C5A0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x3775E30", Offset = "0x3775230", VA = "0x183775E30")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[FOLNNMOIIGM(ENNCJJGDJJI.Game)]
public class JJGAIHCJEJL : DBKOLKOPCAB
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type HKPGKBDNMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x3A70D30", Offset = "0x3A70130", VA = "0x183A70D30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] INDKBFDAONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x3A70DA0", Offset = "0x3A701A0", VA = "0x183A70DA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public JJGAIHCJEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[FOLNNMOIIGM(ENNCJJGDJJI.Loading)]
public class BMHEDEKCILA : DBKOLKOPCAB
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type HKPGKBDNMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] INDKBFDAONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x37D8610", Offset = "0x37D7A10", VA = "0x1837D8610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public BMHEDEKCILA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class BAMKNAFOIGF : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x37D7780", Offset = "0x37D6B80", VA = "0x1837D7780", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public BAMKNAFOIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[FOLNNMOIIGM(ENNCJJGDJJI.Saving)]
public class NPIENOMGOJK : DBKOLKOPCAB
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type HKPGKBDNMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] INDKBFDAONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x3764F00", Offset = "0x3764300", VA = "0x183764F00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NPIENOMGOJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class CGPCGPBDDCC : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x37DD4E0", Offset = "0x37DC8E0", VA = "0x1837DD4E0", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public CGPCGPBDDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[FOLNNMOIIGM(ENNCJJGDJJI.Simulation)]
public class OHMLKONFPPG : DBKOLKOPCAB
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public Type HKPGKBDNMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x3765E10", Offset = "0x3765210", VA = "0x183765E10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] INDKBFDAONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x3765E80", Offset = "0x3765280", VA = "0x183765E80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public OHMLKONFPPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[AOJPGBJKDNL(typeof(GGMPOMAFFEK), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
internal class GGMPOMAFFEK : CJFEEGPLPHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private global::MANOKGJJDCF<AuthoredParentData, PHBKBJJGFLG, MNGLDFJNAEC, AuthoredChildrenData> HJAEPGNEMGK;

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x3A63FE0", Offset = "0x3A633E0", VA = "0x183A63FE0", Slot = "4")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GGMPOMAFFEK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[AOJPGBJKDNL(typeof(EntityHierarchyParents), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.HierarchySystems)]
	internal sealed class EntityHierarchyParents : NGENPNOGFON, CJFEEGPLPHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[CPICBLLAMOM]
		private AOJCNPMLIMB KBMLCGACCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[CPICBLLAMOM]
		private PropertyChangeNetworkRouter PDFNGODAECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private global::NBILNGMPECD<Entity> JGMFKPLFFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private global::MANOKGJJDCF<ParentData, FIFLOEKHLJG, AANLLFDJIJG, ChildrenData> HJAEPGNEMGK;

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E0C0", Offset = "0x3A5D4C0", VA = "0x183A5E0C0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DF20", Offset = "0x3A5D320", VA = "0x183A5DF20", Slot = "5")]
		public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DC90", Offset = "0x3A5D090", VA = "0x183A5DC90")]
		public Entity CCHAPKECBLI(Entity OOEHGINMJGM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DCE0", Offset = "0x3A5D0E0", VA = "0x183A5DCE0")]
		public bool DGGDKMPIBME(Entity OOEHGINMJGM, Entity HKBAAFCKIFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E020", Offset = "0x3A5D420", VA = "0x183A5E020")]
		public bool NPKNFKDMNIH(Entity OOEHGINMJGM, Entity HKBAAFCKIFC, bool ODKCBCPMGDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DD40", Offset = "0x3A5D140", VA = "0x183A5DD40")]
		private bool FEAAAGGJHPK(Entity OOEHGINMJGM, Entity HKBAAFCKIFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
[AOJPGBJKDNL(typeof(FEDDPHNAKAK), new string[] { })]
internal sealed class FEDDPHNAKAK : NGENPNOGFON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	[CPICBLLAMOM]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery MHAJAPLNINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EntityManager NPBNPNJJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x3A5FF50", Offset = "0x3A5F350", VA = "0x183A5FF50")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x3A60770", Offset = "0x3A5FB70", VA = "0x183A60770", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FF30", Offset = "0x3A5F330", VA = "0x183A5FF30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x3A601C0", Offset = "0x3A5F5C0", VA = "0x183A601C0")]
	public bool IIGANFODEDB(Entity OOEHGINMJGM, Entity OPNIEJJIALI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x3A605A0", Offset = "0x3A5F9A0", VA = "0x183A605A0")]
	public IEnumerable<Entity> MICCIAHJHAI(Entity OOEHGINMJGM, bool CNIDJIFJCJI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x3A60090", Offset = "0x3A5F490", VA = "0x183A60090")]
	public bool ENDIFHCCJBL(Entity OOEHGINMJGM, Entity NEICBHGNPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x3A60280", Offset = "0x3A5F680", VA = "0x183A60280")]
	public bool JJDKPLMOHNG(Entity OOEHGINMJGM, Entity KIKPCHNHCOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x3A60870", Offset = "0x3A5FC70", VA = "0x183A60870")]
	public NativeList<Entity> PHAECPIPHPL(Entity OOEHGINMJGM, bool CNIDJIFJCJI = false, Allocator NDJJBKEIGCD = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FD30", Offset = "0x3A5F130", VA = "0x183A5FD30")]
	public IEnumerable<Entity> DJKJJBBCCIG(Entity OOEHGINMJGM, bool CNIDJIFJCJI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FC80", Offset = "0x3A5F080", VA = "0x183A5FC80")]
	public Entity CFGEIGEDAJC(Entity OOEHGINMJGM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x3A60720", Offset = "0x3A5FB20", VA = "0x183A60720")]
	public NativeArray<Entity> MKFDOPFNJOJ()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x3A60380", Offset = "0x3A5F780", VA = "0x183A60380")]
	public bool MAHIHPJAEKH(Entity KIKPCHNHCOF, Entity ACEOMEGCOKM, out Entity ACLPGKKPMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FFA0", Offset = "0x3A5F3A0", VA = "0x183A5FFA0")]
	private Entity EDPKPOFPNJM(Entity OOEHGINMJGM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FEDDPHNAKAK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[NAPHGBOEKGO(GPIMBHHJLKL.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x5390670", Offset = "0x538FA70", VA = "0x185390670")]
		public static void HCLJCDJPJCB<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(LODNGHNPONL KPGPMPPLGCI, global::KPNHCHMCPJM<Entity> MLBMAJEOEBG, out global::MANOKGJJDCF<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> DHAGGAIBNIA) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, JAADDGFLGJN where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, JAADDGFLGJN, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x3776980", Offset = "0x3775D80", VA = "0x183776980")]
		public static bool BFOJAHMFIJD(NPBAKKOKIOD FNDIGAAAAOD)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class MANOKGJJDCF<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, JAADDGFLGJN where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, JAADDGFLGJN, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly BBHAOFNBCPD CDECIAPNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private readonly CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private readonly global::NBILNGMPECD<Entity> JGMFKPLFFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private readonly KEPBOOFKKIH ENNEEBHHJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private readonly OFMJLJJKKJK CNDFBGEJOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly EntityManager BOGIEIBMFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly CGJMICMININ BICKJDNHDLM;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x3E5C1D0", Offset = "0x3E5B5D0", VA = "0x183E5C1D0")]
	public MANOKGJJDCF(LODNGHNPONL KPGPMPPLGCI, global::KPNHCHMCPJM<Entity> MLBMAJEOEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B9B0", Offset = "0x3E5ADB0", VA = "0x183E5B9B0")]
	private bool IOBNBDOHCMH(Entity OOEHGINMJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x3E5BA10", Offset = "0x3E5AE10", VA = "0x183E5BA10")]
	private bool KDIDDKNMGAE(Entity OOEHGINMJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AEF0", Offset = "0x3E5A2F0", VA = "0x183E5AEF0")]
	public bool DGGDKMPIBME(Entity OOEHGINMJGM, in Entity HKBAAFCKIFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B320", Offset = "0x3E5A720", VA = "0x183E5B320")]
	public bool HFAMJNILMLH(Entity OOEHGINMJGM, in Entity HKBAAFCKIFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B350", Offset = "0x3E5A750", VA = "0x183E5B350")]
	private bool HFAMJNILMLH(Entity OOEHGINMJGM, in Entity HKBAAFCKIFC, bool ABAIBBEHFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private static void KOFOHNKGOHB(Entity OOEHGINMJGM, in Entity HKBAAFCKIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private static void AONLHLHLDGI(Entity OOEHGINMJGM, in Entity HKBAAFCKIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private static void LPJAKCOIIPH(Entity OOEHGINMJGM, in Entity HKBAAFCKIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private static void MOOIHDGNIHA(Entity OOEHGINMJGM, in Entity HKBAAFCKIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private static void HKCMCPDEMIO(Entity OOEHGINMJGM, in Entity HKBAAFCKIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B870", Offset = "0x3E5AC70", VA = "0x183E5B870")]
	private bool IIGANFODEDB(Entity OOEHGINMJGM, Entity OPNIEJJIALI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AE00", Offset = "0x3E5A200", VA = "0x183E5AE00")]
	private void CENDADEAHMP(Entity OOEHGINMJGM, in Entity AABDLCHECIH, in Entity HKBAAFCKIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AC60", Offset = "0x3E5A060", VA = "0x183E5AC60")]
	private void ANJIIEHEHAK(Entity OOEHGINMJGM, in Entity AABDLCHECIH, in Entity HKBAAFCKIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AF20", Offset = "0x3E5A320", VA = "0x183E5AF20")]
	private bool DPCEDPAPIHA(EOAFCIKDCCH JHHKJKEFJGD, in EHNBIOJHEAD DFNDBNOGPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A990", Offset = "0x3E59D90", VA = "0x183E5A990")]
	private void ADHHJICHDIC(Entity CNDFBGEJOLI, Entity NEICBHGNPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x3E5BAF0", Offset = "0x3E5AEF0", VA = "0x183E5BAF0")]
	private void OFOBOCNNGKJ(Entity CNDFBGEJOLI, Entity NEICBHGNPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private void LGHIHLJPPDE(Entity OOEHGINMJGM, Entity AABDLCHECIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	private void OIOLMPKJPBB(Entity OOEHGINMJGM, Entity HKBAAFCKIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct FDHJLPIBMEF : IKMGKFNJFNI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public NIFOBLJHHEF GONBOMHGDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NIFOBLJHHEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x78D990", Offset = "0x78CD90", VA = "0x18078D990", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[AOJPGBJKDNL(typeof(ObjectEmbodimentService), new string[] { })]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[NAPHGBOEKGO(GPIMBHHJLKL.Embodiment)]
	internal sealed class ObjectEmbodimentService : HPLECDDPLCA, HIJIFLANIAO, NGENPNOGFON, CJFEEGPLPHA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private ObjectLifecycleService PHNFNFPBDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[CPICBLLAMOM]
		private AOJCNPMLIMB KBMLCGACCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[CPICBLLAMOM]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[CPICBLLAMOM]
		private AIKEDHOJPPH NOGKNHKHMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[CPICBLLAMOM]
		private LDJNBNGIACM AMKAHAFKFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[CPICBLLAMOM]
		private TransformOwnershipPhase EIONKOPIMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private readonly Dictionary<EHNBIOJHEAD, IHNOMGAGHCN> GJOHLNEJLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private GLNMOFHHLFO GFNGGLPFMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager NPBNPNJJNKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x3768460", Offset = "0x3767860", VA = "0x183768460")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int HHEHIAJIKKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x37689B0", Offset = "0x3767DB0", VA = "0x1837689B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int LBDPKIFAENA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x37681B0", Offset = "0x37675B0", VA = "0x1837681B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x291C420", Offset = "0x291B820", VA = "0x18291C420", Slot = "4")]
		public void MPBHMBLFPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x376B910", Offset = "0x376AD10", VA = "0x18376B910", Slot = "5")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x37682E0", Offset = "0x37676E0", VA = "0x1837682E0")]
		public void DLAPBAFOGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x3769310", Offset = "0x3768710", VA = "0x183769310", Slot = "6")]
		public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x3768330", Offset = "0x3767730", VA = "0x183768330", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x37682C0", Offset = "0x37676C0", VA = "0x1837682C0")]
		public int DIPMNADBCCM(SceneTag LKJCHBJAPLC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x376B300", Offset = "0x376A700", VA = "0x18376B300")]
		public int NNPFLBICEMD(SceneTag LKJCHBJAPLC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x3769AF0", Offset = "0x3768EF0", VA = "0x183769AF0")]
		public bool KELHKLLFLBA(Entity OOEHGINMJGM, Allocator NDJJBKEIGCD, out NativeList<Entity> PDMLBEMMLLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x3769460", Offset = "0x3768860", VA = "0x183769460")]
		public bool IHIFIDNMMPM(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x3768190", Offset = "0x3767590", VA = "0x183768190")]
		public bool CINBLFIFJPP(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x376B490", Offset = "0x376A890", VA = "0x18376B490")]
		public bool OENDIKOIADH(Entity OOEHGINMJGM, out IHNOMGAGHCN KGKPNOEKJJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x376B3E0", Offset = "0x376A7E0", VA = "0x18376B3E0")]
		private bool OENDIKOIADH(Transform GCKJJOINBCJ, out IHNOMGAGHCN KGKPNOEKJJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x376A990", Offset = "0x3769D90", VA = "0x18376A990")]
		private void MOEHKCAJIMN(Entity OOEHGINMJGM, IHNOMGAGHCN KGKPNOEKJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x376B8F0", Offset = "0x376ACF0", VA = "0x18376B8F0")]
		private bool OPGCGCOCLKB(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x376A790", Offset = "0x3769B90", VA = "0x18376A790")]
		public void MHBAMOAJPNP(EHNBIOJHEAD DGDIPHPMEJP, IHNOMGAGHCN MKNPMJHOLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x3768F70", Offset = "0x3768370", VA = "0x183768F70")]
		public bool IFHCMFKNNCF(Entity OOEHGINMJGM, object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x3769DB0", Offset = "0x37691B0", VA = "0x183769DB0")]
		public bool KFCNHGCEBIG(KJNCFICFIIE GNKPFNIMJND, object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x3769D60", Offset = "0x3769160", VA = "0x183769D60")]
		public bool KFCNHGCEBIG(Entity OOEHGINMJGM, [Optional] object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x3769D40", Offset = "0x3769140", VA = "0x183769D40")]
		public bool KFCNHGCEBIG(IHNOMGAGHCN FNDIGAAAAOD, object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x376AA20", Offset = "0x3769E20", VA = "0x18376AA20")]
		public bool MPLJCGKOAMJ(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x376ADF0", Offset = "0x376A1F0", VA = "0x18376ADF0")]
		public bool MPLJCGKOAMJ(IHNOMGAGHCN KGKPNOEKJJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x376A160", Offset = "0x3769560", VA = "0x18376A160")]
		public bool KFCNHGCEBIG(IHNOMGAGHCN KGKPNOEKJJD, [Optional] object JCHAGIDHJIB, bool MGJBBFOJNFN = false, bool IICBHDHFLNG = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x3769980", Offset = "0x3768D80", VA = "0x183769980")]
		public Transform KCCHIGCAEMK(Entity OOEHGINMJGM, [Optional] object JCHAGIDHJIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x376AE20", Offset = "0x376A220", VA = "0x18376AE20")]
		public bool NCFBPALOAMF(Entity OOEHGINMJGM, out Transform GCKJJOINBCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x37681D0", Offset = "0x37675D0", VA = "0x1837681D0")]
		public IHNOMGAGHCN COLCJMDGIIA(Entity OOEHGINMJGM, [Optional] object JCHAGIDHJIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x3767E20", Offset = "0x3767220", VA = "0x183767E20")]
		public void BJCHMCKGHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x376B500", Offset = "0x376A900", VA = "0x18376B500")]
		public void OPAPJOBNEIC(SceneTag LKJCHBJAPLC, bool OBHMNHHCCDE, global::PKHGLMKIEOF<int> GAKDNEFLBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x37689D0", Offset = "0x3767DD0", VA = "0x1837689D0")]
		private void GIAOCOFBDAA(Entity OOEHGINMJGM, bool OBHMNHHCCDE, bool ANNNEKEPEMF, global::PKHGLMKIEOF<int> GAKDNEFLBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x37686F0", Offset = "0x3767AF0", VA = "0x1837686F0")]
		private void ENLMAINLEHF(Entity OOEHGINMJGM, IHNOMGAGHCN KGKPNOEKJJD, bool OBHMNHHCCDE, bool ANNNEKEPEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x376BA40", Offset = "0x376AE40", VA = "0x18376BA40")]
		public IHNOMGAGHCN PNPDMGPJCIJ(Entity OOEHGINMJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x3767CE0", Offset = "0x37670E0", VA = "0x183767CE0")]
		public bool BDDOGFOHCPP(Entity OOEHGINMJGM, object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x37696B0", Offset = "0x3768AB0", VA = "0x1837696B0")]
		public bool JBLNOEGKAGH(Entity OOEHGINMJGM, object JCHAGIDHJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x3767C70", Offset = "0x3767070", VA = "0x183767C70")]
		public bool ADIHCFAHPLE(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x3769730", Offset = "0x3768B30", VA = "0x183769730")]
		public bool JJJPKOPBCEL(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x37697A0", Offset = "0x3768BA0", VA = "0x1837697A0")]
		public bool JJJPKOPBCEL(NIFOBLJHHEF CKELBFAAOKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void BGEODALEHDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x3767D60", Offset = "0x3767160", VA = "0x183767D60")]
		private void BFODLDIPOHK(bool CLKPGIDAMFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x376A4D0", Offset = "0x37698D0", VA = "0x18376A4D0")]
		private bool LABIFBOMONL(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x3768ED0", Offset = "0x37682D0", VA = "0x183768ED0")]
		private IHNOMGAGHCN HJBLODHLDMC(Entity OOEHGINMJGM, object JCHAGIDHJIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x376AEF0", Offset = "0x376A2F0", VA = "0x18376AEF0")]
		private IHNOMGAGHCN NDHDIPKHDIC(Entity OOEHGINMJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x376B0E0", Offset = "0x376A4E0", VA = "0x18376B0E0")]
		private (Vector3, Quaternion, Vector3) NNJAAPPFCAO(Entity OOEHGINMJGM)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x3769870", Offset = "0x3768C70", VA = "0x183769870")]
		private void JPMDLMGDHLM(Entity OOEHGINMJGM, AGNBDHNLGKL LDKBJDPJMKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x376B320", Offset = "0x376A720", VA = "0x18376B320")]
		private void OCOMDPOFCMF(KJNCFICFIIE GNKPFNIMJND, IHNOMGAGHCN MKNPMJHOLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x3768790", Offset = "0x3767B90", VA = "0x183768790")]
		private void FDPLGPLKOEL(IHNOMGAGHCN MKNPMJHOLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x376A560", Offset = "0x3769960", VA = "0x18376A560")]
		private void LBEHFKMBLHK(IHNOMGAGHCN KGKPNOEKJJD, Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x37684B0", Offset = "0x37678B0", VA = "0x1837684B0")]
		private void EEGDKLCGBAH(Entity OOEHGINMJGM, IHNOMGAGHCN KGKPNOEKJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x37680B0", Offset = "0x37674B0", VA = "0x1837680B0")]
		private void CAHNDEAKLIE(Entity OOEHGINMJGM, Transform GCKJJOINBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x37688B0", Offset = "0x3767CB0", VA = "0x1837688B0")]
		private KJNCFICFIIE FKACDFOHGMO(Entity OOEHGINMJGM)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x376BAE0", Offset = "0x376AEE0", VA = "0x18376BAE0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x37688E0", Offset = "0x3767CE0", VA = "0x1837688E0")]
		[CompilerGenerated]
		private void GCDABFLMPLE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class OGEKMPIOHGI
{
	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x3765DF0", Offset = "0x37651F0", VA = "0x183765DF0")]
	public static IHNOMGAGHCN COLCJMDGIIA(this ObjectEmbodimentService NGEDJICHDBC, KJNCFICFIIE GNKPFNIMJND, [Optional] object JCHAGIDHJIB)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[AOJPGBJKDNL(typeof(ObjectLifecycleService), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.Lifecycle)]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	internal sealed class ObjectLifecycleService : NGENPNOGFON, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ObjectEmbodimentService KGKPNOEKJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA PEPLIFOGJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private KEICNAJBANN CGKMMOPOBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DestroyLocalObjects APAHCGJNCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		private EntityManager NPBNPNJJNKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x376C5E0", Offset = "0x376B9E0", VA = "0x18376C5E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, AGNBDHNLGKL> NHJCBLPKGLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x376C920", Offset = "0x376BD20", VA = "0x18376C920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x376CB70", Offset = "0x376BF70", VA = "0x18376CB70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> NDOBGGFAKNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x376CAD0", Offset = "0x376BED0", VA = "0x18376CAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x376C880", Offset = "0x376BC80", VA = "0x18376C880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x376D150", Offset = "0x376C550", VA = "0x18376D150", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x1E058B0", Offset = "0x1E04CB0", VA = "0x181E058B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x376CED0", Offset = "0x376C2D0", VA = "0x18376CED0")]
		public bool NDBOIIODAJJ(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x376C580", Offset = "0x376B980", VA = "0x18376C580")]
		internal void EDKBENPIFBG(Entity OOEHGINMJGM, AGNBDHNLGKL LDKBJDPJMKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x376D110", Offset = "0x376C510", VA = "0x18376D110")]
		public void OADODFJBFIO(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x376CA80", Offset = "0x376BE80", VA = "0x18376CA80")]
		public void JOCGDFHOLPL(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x376C9C0", Offset = "0x376BDC0", VA = "0x18376C9C0")]
		private bool IFGPBCLHIJO(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x376C630", Offset = "0x376BA30", VA = "0x18376C630")]
		public void FBEHGKKMCPK(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x376CF50", Offset = "0x376C350", VA = "0x18376CF50")]
		private bool NDEACAKKFPA(Entity OOEHGINMJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x376C2F0", Offset = "0x376B6F0", VA = "0x18376C2F0")]
		public void CPPBEMAMOOF(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x376CE70", Offset = "0x376C270", VA = "0x18376CE70")]
		private void MEDHBDDBNKI(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x376CC10", Offset = "0x376C010", VA = "0x18376CC10")]
		private void LMHAENMICAC(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x376C830", Offset = "0x376BC30", VA = "0x18376C830")]
		public void FHCEPNOBCBM(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		private void GONKPHHPLIN(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x376C380", Offset = "0x376B780", VA = "0x18376C380")]
		private void DKCKBNLHFIK(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[AOJPGBJKDNL(typeof(ObjectPrefabs), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.Prefabs)]
	internal class ObjectPrefabs : BJNCPIJMNKN, NGENPNOGFON, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class JMMFMHEBNPG : IEnumerable<(LGHJFDELFEL, AGNBDHNLGKL)>, IEnumerable, IEnumerator<(LGHJFDELFEL, AGNBDHNLGKL)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private (LGHJFDELFEL primitiveType, AGNBDHNLGKL prefabType) <>2__current;

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
			private (LGHJFDELFEL, AGNBDHNLGKL) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B85")]
				[Cpp2IlInjected.Address(RVA = "0x332E3E0", Offset = "0x332D7E0", VA = "0x18332E3E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((LGHJFDELFEL, AGNBDHNLGKL));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B87")]
				[Cpp2IlInjected.Address(RVA = "0x41930B0", Offset = "0x41924B0", VA = "0x1841930B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x418CD20", Offset = "0x418C120", VA = "0x18418CD20")]
			[DebuggerHidden]
			public JMMFMHEBNPG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x4192ED0", Offset = "0x41922D0", VA = "0x184192ED0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x4193070", Offset = "0x4192470", VA = "0x184193070", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x4192FD0", Offset = "0x41923D0", VA = "0x184192FD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(LGHJFDELFEL, AGNBDHNLGKL)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x4192FD0", Offset = "0x41923D0", VA = "0x184192FD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA PEPLIFOGJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private World LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly Dictionary<AGNBDHNLGKL, Entity> GKKDCEIPLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<AGNBDHNLGKL, EntityArchetype> ENEONDNLDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private readonly Dictionary<LGHJFDELFEL, AGNBDHNLGKL> LHOAJMOBPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<COHKEJMMIKI, AGNBDHNLGKL> CMDMNHNPMLO;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public int HMGCLIBMMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x376FA90", Offset = "0x376EE90", VA = "0x18376FA90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager NPBNPNJJNKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x3770120", Offset = "0x376F520", VA = "0x183770120")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x3770CF0", Offset = "0x37700F0", VA = "0x183770CF0", Slot = "5")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x376FDF0", Offset = "0x376F1F0", VA = "0x18376FDF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x3770380", Offset = "0x376F780", VA = "0x183770380")]
		internal IEnumerable<Type> HEKHKCMOIOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x376FD80", Offset = "0x376F180", VA = "0x18376FD80")]
		internal OMLEBPADNKG DOKLIOMJDNC(Type BKGBGEHNCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x37703E0", Offset = "0x376F7E0", VA = "0x1837703E0")]
		public EntityArchetype IMHNPKCCCGE(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x376FC00", Offset = "0x376F000", VA = "0x18376FC00")]
		public NativeHashMap<int, EntityArchetype> DENBIEPHJNM(Allocator NDJJBKEIGCD = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x3770200", Offset = "0x376F600", VA = "0x183770200")]
		public bool FEBKNJCHAMM(AGNBDHNLGKL LDKBJDPJMKG, out EntityArchetype EEONIFNHKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x3770490", Offset = "0x376F890", VA = "0x183770490", Slot = "4")]
		[IteratorStateMachine(typeof(JMMFMHEBNPG))]
		public IEnumerable<(LGHJFDELFEL, AGNBDHNLGKL)> JCOBIMDLMJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x3770270", Offset = "0x376F670", VA = "0x183770270")]
		public Entity GMIKKPABJEA(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x37701A0", Offset = "0x376F5A0", VA = "0x1837701A0")]
		public AGNBDHNLGKL EJENMGHMFCK(COHKEJMMIKI BKGBGEHNCAE)
		{
			return default(AGNBDHNLGKL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x3770140", Offset = "0x376F540", VA = "0x183770140")]
		public AGNBDHNLGKL EJENMGHMFCK(LGHJFDELFEL BKGBGEHNCAE)
		{
			return default(AGNBDHNLGKL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x3770950", Offset = "0x376FD50", VA = "0x183770950")]
		public NativeHashMap<int, Entity> NLCJAPBMOPI(Allocator NDJJBKEIGCD = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x3770440", Offset = "0x376F840", VA = "0x183770440")]
		public IEnumerable<AGNBDHNLGKL> JANHLOPNDCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x3770C20", Offset = "0x3770020", VA = "0x183770C20")]
		public Entity OIFGNHBPMGH(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x3770C80", Offset = "0x3770080", VA = "0x183770C80")]
		public bool OKDAKBELADB(AGNBDHNLGKL LDKBJDPJMKG, out Entity CCDPGFIPGOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x3770500", Offset = "0x376F900", VA = "0x183770500")]
		private void MIBGANMHGBN(OMLEBPADNKG CMBABIGIDMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x376F860", Offset = "0x376EC60", VA = "0x18376F860")]
		internal void CHPHNDDIKDH(AGNBDHNLGKL LDKBJDPJMKG, ComponentTypeList EJMAJLJACOG, FIPKGBJFPGB ACHNLIOGDJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x3770AC0", Offset = "0x376FEC0", VA = "0x183770AC0")]
		private void OENELHOODDM(AGNBDHNLGKL LDKBJDPJMKG, ComponentTypeList JEMCAABFCAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x376FAE0", Offset = "0x376EEE0", VA = "0x18376FAE0")]
		internal Entity CPCFMLKBOEI(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x3771120", Offset = "0x3770520", VA = "0x183771120")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum GIGIFLGAPJL
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal interface PLKIDLDIFKE
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World KMLEAECJLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	JGPIIEKKHEG AJFKMKEPOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal class DMKJBEBCOHF : PDOCGLJCFBJ, JCDAMMIJJIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly PFHEAHIGMHG PCGOBHOPOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly GIGIFLGAPJL EIONKOPIMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly List<EJHDKNLHMKL> JGNJNKJLGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private NativeMultiHashMap<Entity, ONPGIKEEJJM> HMLHNBFGNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NativeHashMap<int, int> OHDCHMHCOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private JobHandle ECMOHBKLBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private JobHandle LFNKJOELNNJ;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private World EEOFHHJIALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x37ED700", Offset = "0x37ECB00", VA = "0x1837ED700", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JGPIIEKKHEG ALNJCIIBKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0xEFFF90", Offset = "0xEFF390", VA = "0x180EFFF90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private JBMJMBCCJEC CAMFICHLGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x892020", Offset = "0x891420", VA = "0x180892020", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, ONPGIKEEJJM> ABPBHDNPNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x7F8700", Offset = "0x7F7B00", VA = "0x1807F8700", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, ONPGIKEEJJM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle OHKDPLPLPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x81B470", Offset = "0x81A870", VA = "0x18081B470", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0xE58740", Offset = "0xE57B40", VA = "0x180E58740", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool GNPBMJBFBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x37ED0F0", Offset = "0x37EC4F0", VA = "0x1837ED0F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World ALDDHLGKCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x37ED5C0", Offset = "0x37EC9C0", VA = "0x1837ED5C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x37EDB60", Offset = "0x37ECF60", VA = "0x1837EDB60")]
	public DMKJBEBCOHF(PFHEAHIGMHG PCGOBHOPOJF, GIGIFLGAPJL EIONKOPIMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x37ED100", Offset = "0x37EC500", VA = "0x1837ED100", Slot = "11")]
	private void EKAOEAGNBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x37ED4D0", Offset = "0x37EC8D0", VA = "0x1837ED4D0", Slot = "10")]
	private bool JDFAMPKIALN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x37ED150", Offset = "0x37EC550", VA = "0x1837ED150", Slot = "12")]
	private void HMFCFNPAIHI(ComponentType ACMABPBDHLP, in EJHDKNLHMKL FIFHADHHPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x37ED460", Offset = "0x37EC860", VA = "0x1837ED460", Slot = "13")]
	private bool ICOAGEHELIO(AGNBDHNLGKL LDKBJDPJMKG, out Entity CCDPGFIPGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x37ED620", Offset = "0x37ECA20", VA = "0x1837ED620", Slot = "16")]
	private bool KMKOGKCEPKJ(out NativeArray<int> ENMHBAPKFPB, Allocator NDJJBKEIGCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x37ED760", Offset = "0x37ECB60", VA = "0x1837ED760", Slot = "17")]
	private bool PCEFGEIMINF(ComponentType ACMABPBDHLP, out EJHDKNLHMKL FAOPMHCCCKH, out ODEFLDAMAII FKIMHPOMHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x37ED8E0", Offset = "0x37ECCE0", VA = "0x1837ED8E0", Slot = "18")]
	private bool PCEFGEIMINF(ComponentType ACMABPBDHLP, out EJHDKNLHMKL FAOPMHCCCKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x37ECD50", Offset = "0x37EC150", VA = "0x1837ECD50", Slot = "19")]
	private EJHDKNLHMKL BCDMENFLLMP(ComponentType ACMABPBDHLP)
	{
		return default(EJHDKNLHMKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x37ED110", Offset = "0x37EC510", VA = "0x1837ED110", Slot = "20")]
	private DPLGLNFLADJ FIPGLPMBEAK()
	{
		return default(DPLGLNFLADJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x37ED6C0", Offset = "0x37ECAC0", VA = "0x1837ED6C0", Slot = "21")]
	private void MJKHDAMMFOO(JobHandle FOMHAOIEGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x37ECE40", Offset = "0x37EC240", VA = "0x1837ECE40")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x37ED240", Offset = "0x37EC640", VA = "0x1837ED240")]
	private bool ICHIPBDJCKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x37EDA10", Offset = "0x37ECE10", VA = "0x1837EDA10")]
	private int PGNFJEBIFIP()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal class PFHEAHIGMHG : PLKIDLDIFKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public CBGJJCKMFCA PEPLIFOGJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ObjectInstantiationService GKKDCEIPLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public JGPIIEKKHEG NKCBDJGPKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public JBMJMBCCJEC HKDELDHKHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public CDEDFPJELEC DGBFPMEEDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public World KMLEAECJLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x3774470", Offset = "0x3773870", VA = "0x183774470", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public JGPIIEKKHEG AJFKMKEPOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public PFHEAHIGMHG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[AOJPGBJKDNL(typeof(PropertyDiffStateService), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.PropertyChanges)]
	internal class PropertyDiffStateService : NGENPNOGFON, CJFEEGPLPHA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal readonly struct JMIDIJKIBCG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private readonly GIGIFLGAPJL OBGBKHJMLFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private readonly PropertyDiffStateService OCGDPJBGCPH;

			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0x4192E80", Offset = "0x4192280", VA = "0x184192E80")]
			public JMIDIJKIBCG(PropertyDiffStateService OCGDPJBGCPH, GIGIFLGAPJL EGCJHANGENE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x4192E60", Offset = "0x4192260", VA = "0x184192E60", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly PFHEAHIGMHG PCGOBHOPOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly DMKJBEBCOHF[] JEIKAEANEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private GIGIFLGAPJL JHFDPOEJPMC;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public PLKIDLDIFKE OABMPMLCIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public JCDAMMIJJIF ADCGGDMINEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x377D630", Offset = "0x377CA30", VA = "0x18377D630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public PDOCGLJCFBJ DHMHFJHECNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x377D630", Offset = "0x377CA30", VA = "0x18377D630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0xE8A940", Offset = "0xE89D40", VA = "0x180E8A940")]
		public JCDAMMIJJIF DCJAAOJDIHG(GIGIFLGAPJL EIONKOPIMNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0xE8A940", Offset = "0xE89D40", VA = "0x180E8A940")]
		public PDOCGLJCFBJ FEGHFKCIAHI(GIGIFLGAPJL EIONKOPIMNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x377D900", Offset = "0x377CD00", VA = "0x18377D900", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x377D670", Offset = "0x377CA70", VA = "0x18377D670", Slot = "5")]
		public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x377D4D0", Offset = "0x377C8D0", VA = "0x18377D4D0")]
		public void BIEFCABEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x377D550", Offset = "0x377C950", VA = "0x18377D550", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x377D530", Offset = "0x377C930", VA = "0x18377D530")]
		public JMIDIJKIBCG CAEOAHIDBNE(GIGIFLGAPJL EIONKOPIMNI)
		{
			return default(JMIDIJKIBCG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x377D9D0", Offset = "0x377CDD0", VA = "0x18377D9D0")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[NAPHGBOEKGO(GPIMBHHJLKL.HierarchySystems)]
	[AOJPGBJKDNL(typeof(SceneService), new string[] { })]
	internal class SceneService : NGENPNOGFON, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly SceneTag DKODEBGKHAB;

		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public const string NNBCBKHPEPD = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private const string JDDHGCALOCL = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[CPICBLLAMOM]
		private KGJHIIIKFIO NJJGKMIKDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[CPICBLLAMOM]
		private ObjectEmbodimentService KGKPNOEKJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[CPICBLLAMOM]
		private KEPBOOFKKIH BBLGAIECEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[CPICBLLAMOM]
		private SingletonComponentService DPCEIKEBBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[CPICBLLAMOM]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[CPICBLLAMOM]
		private PhotonInstanceCleanupService MOMBNKAFLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery LKLJBBIIJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery FNKOLHPMHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery LJDKANGHIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private Entity PPAPHLLIPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public bool OPNEBECHNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x38B4E90", Offset = "0x38B4290", VA = "0x1838B4E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> DDBKLHMGGIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0xB5C2E0", Offset = "0xB5B6E0", VA = "0x180B5C2E0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0xB5C400", Offset = "0xB5B800", VA = "0x180B5C400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity LPOLDHFLKBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x38B4BB0", Offset = "0x38B3FB0", VA = "0x1838B4BB0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag PGBKMPPOFJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x38B36C0", Offset = "0x38B2AC0", VA = "0x1838B36C0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity ONHFPGEBOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x38B36C0", Offset = "0x38B2AC0", VA = "0x1838B36C0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x38B47F0", Offset = "0x38B3BF0", VA = "0x1838B47F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager NPBNPNJJNKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x38B45F0", Offset = "0x38B39F0", VA = "0x1838B45F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x38B5190", Offset = "0x38B4590", VA = "0x1838B5190", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x38B41F0", Offset = "0x38B35F0", VA = "0x1838B41F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x38B4A60", Offset = "0x38B3E60", VA = "0x1838B4A60")]
		public void IIENKJCIGOD(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x38B3D80", Offset = "0x38B3180", VA = "0x1838B3D80")]
		public NativeArray<Entity> CDJEHFFBNAD(Allocator NDJJBKEIGCD = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x38B52B0", Offset = "0x38B46B0", VA = "0x1838B52B0")]
		public void PBJGMODDJAD(Entity LKJCHBJAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x38B4770", Offset = "0x38B3B70", VA = "0x1838B4770")]
		public Entity FDENNAMCNPD(string LBEPPIIBMPA = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x38B48C0", Offset = "0x38B3CC0", VA = "0x1838B48C0")]
		public void HLFFGBHKIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x38B3D60", Offset = "0x38B3160", VA = "0x1838B3D60")]
		public void BIJPFBHNAFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x38B4710", Offset = "0x38B3B10", VA = "0x1838B4710")]
		public void EOKPNHJIEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x38B4A20", Offset = "0x38B3E20", VA = "0x1838B4A20")]
		public void IEEOKHCNFNC(Entity LKJCHBJAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x38B37F0", Offset = "0x38B2BF0", VA = "0x1838B37F0")]
		public bool BBLEJGFEFGM(Entity LKJCHBJAPLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x38B48E0", Offset = "0x38B3CE0", VA = "0x1838B48E0")]
		public void HLKNGJAFFIK(Entity LKJCHBJAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x38B4EE0", Offset = "0x38B42E0", VA = "0x1838B4EE0")]
		public string NDBNBNNLHOE(Entity LKJCHBJAPLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		public void JCPHGHFKIGM(Entity LKJCHBJAPLC, string LBEPPIIBMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x38B46F0", Offset = "0x38B3AF0", VA = "0x1838B46F0")]
		public bool ELLJEHHLHNH(string LBEPPIIBMPA, out Entity LKJCHBJAPLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x38B4AA0", Offset = "0x38B3EA0", VA = "0x1838B4AA0")]
		public void IJJMLOFAKAL(Entity LKJCHBJAPLC, bool FDGCHAPAMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x38B3EA0", Offset = "0x38B32A0", VA = "0x1838B3EA0")]
		public void CGHKBHPJCIB(Entity OOEHGINMJGM, bool DNJHNHEDPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x38B3F20", Offset = "0x38B3320", VA = "0x1838B3F20")]
		public void CGHKBHPJCIB(NativeArray<Entity> NMNOLKKCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x38B3DB0", Offset = "0x38B31B0", VA = "0x1838B3DB0")]
		public void CGHKBHPJCIB(EntityQuery FDOFAODBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x38B38A0", Offset = "0x38B2CA0", VA = "0x1838B38A0")]
		public void BFFCAEPGLOC(Entity OOEHGINMJGM, Entity LKJCHBJAPLC, bool DNJHNHEDPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x38B3B80", Offset = "0x38B2F80", VA = "0x1838B3B80")]
		public void BFFCAEPGLOC(NativeArray<Entity> NMNOLKKCICL, Entity LKJCHBJAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x38B3AD0", Offset = "0x38B2ED0", VA = "0x1838B3AD0")]
		public void BFFCAEPGLOC(EntityQuery FDOFAODBNNC, Entity LKJCHBJAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x38B4040", Offset = "0x38B3440", VA = "0x1838B4040")]
		private void CPPMFFOGAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x38B4A30", Offset = "0x38B3E30", VA = "0x1838B4A30")]
		private void IFMFHNLDJEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x38B4BB0", Offset = "0x38B3FB0", VA = "0x1838B4BB0")]
		private Entity NFKMEPPPJOF()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x38B3F90", Offset = "0x38B3390", VA = "0x1838B3F90")]
		private void CONNFLEGFHI(Entity LKJCHBJAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x38B4520", Offset = "0x38B3920", VA = "0x1838B4520")]
		private void EDBNLPMHMJF(EntityQuery DEMCGNGEPFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x38B4240", Offset = "0x38B3640", VA = "0x1838B4240")]
		private void EDBNLPMHMJF(NativeArray<Entity> POMGNNIENEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x38B4640", Offset = "0x38B3A40", VA = "0x1838B4640")]
		private void EJHKLNJNIHK(Entity LKJCHBJAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x38B48F0", Offset = "0x38B3CF0", VA = "0x1838B48F0")]
		private void HOPDEPNELKD(Entity LKJCHBJAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x38B5020", Offset = "0x38B4420", VA = "0x1838B5020")]
		private void ODKLOJLFGPG(SceneTag PFMCAIJELKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x38B3710", Offset = "0x38B2B10", VA = "0x1838B3710")]
		private void AKONODLBBAB(SceneTag PFMCAIJELKC, global::PKHGLMKIEOF<int> GAKDNEFLBJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x38B4D00", Offset = "0x38B4100", VA = "0x1838B4D00")]
		private void JEMGFPLKCNG(SceneTag PFMCAIJELKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x38B3750", Offset = "0x38B2B50", VA = "0x1838B3750")]
		private void AOLAOBEIOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x40A0920", Offset = "0x409FD20", VA = "0x1840A0920")]
		private void PLJPPMAJIID<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void OKMPIPFGCGO(SceneTag PFMCAIJELKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x38B4860", Offset = "0x38B3C60", VA = "0x1838B4860")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void HCGKMPICALE(EntityQuery FDOFAODBNNC, string LBEPPIIBMPA, SceneTag PFMCAIJELKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x38B4FF0", Offset = "0x38B43F0", VA = "0x1838B4FF0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void NEGGFHHCEJA(Entity LKJCHBJAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void NBAEEMMGGAA(Entity LKJCHBJAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[PHECHDJFGDG(FPOGPJMGMEG.PhotonRoom)]
	[AOJPGBJKDNL(typeof(LIOPMJFBPIJ), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.HierarchySystems)]
	internal class UnitySceneService : NGENPNOGFON, LIOPMJFBPIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[CPICBLLAMOM]
		private SceneService POMGNNIENEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private readonly Dictionary<int, Entity> EPHNGDPONDE;

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager NPBNPNJJNKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x38C2E90", Offset = "0x38C2290", VA = "0x1838C2E90")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x38C30C0", Offset = "0x38C24C0", VA = "0x1838C30C0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x38C2F50", Offset = "0x38C2350", VA = "0x1838C2F50", Slot = "5")]
		public void IIENKJCIGOD(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x38C2CA0", Offset = "0x38C20A0", VA = "0x1838C2CA0", Slot = "6")]
		public bool CIKMMFPMBLK(KJNCFICFIIE GNKPFNIMJND, Transform GCKJJOINBCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x38C2EE0", Offset = "0x38C22E0", VA = "0x1838C2EE0")]
		private bool FNDCMNFFIBG(Scene LKJCHBJAPLC, out Entity ODHJCEFGJPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x38C3150", Offset = "0x38C2550", VA = "0x1838C3150")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[NAPHGBOEKGO(GPIMBHHJLKL.ComponentSystemTypes)]
	[AOJPGBJKDNL(typeof(SingletonComponentService), new string[] { })]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	internal sealed class SingletonComponentService : NGENPNOGFON, CJFEEGPLPHA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[CPICBLLAMOM]
		private KEPBOOFKKIH BBLGAIECEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private Entity OOEHGINMJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private ComponentTypeList JEMCAABFCAC;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int HMGCLIBMMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0x38B9DB0", Offset = "0x38B91B0", VA = "0x1838B9DB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity KFOGOEMFEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager NPBNPNJJNKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x38BA090", Offset = "0x38B9490", VA = "0x1838BA090")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x40A22E0", Offset = "0x40A16E0", VA = "0x1840A22E0")]
		public T PEBNPJONHNJ<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x40A2210", Offset = "0x40A1610", VA = "0x1840A2210")]
		public void CODPHMBGNGD<T>(T FPLJCBGEJAP) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x38BA280", Offset = "0x38B9680", VA = "0x1838BA280", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x38BA0E0", Offset = "0x38B94E0", VA = "0x1838BA0E0", Slot = "5")]
		public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x38BA0E0", Offset = "0x38B94E0", VA = "0x1838BA0E0")]
		private void HOJAJAGGBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x38B9DC0", Offset = "0x38B91C0", VA = "0x1838B9DC0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x38B9A10", Offset = "0x38B8E10", VA = "0x1838B9A10")]
		private ComponentTypeList AFJKABNJNJM()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		private static void GCPAMAJJIED(int NDNADCNCIGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		private static void COMDNOBHLCF(Type BKGBGEHNCAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x38B9D10", Offset = "0x38B9110", VA = "0x1838B9D10")]
		private static void CGDNJLNDNMO(Type BKGBGEHNCAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal struct HBNHBDGGBAF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
[AOJPGBJKDNL(typeof(LDJNBNGIACM), new string[] { })]
internal sealed class LDJNBNGIACM : NGENPNOGFON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	[CPICBLLAMOM]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private global::EMFAIGONLBB<NEAGDLJJMAE, Entity> IBINKBCGOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private global::EIDJKICAODJ<IJOBBGGAIEO> OGGJAKHAHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private global::EIDJKICAODJ<LALAMJAPLNJ> LKPGCEHLIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private global::EIDJKICAODJ<NFBEHOPADBG> PLIAAMNDMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private global::EIDJKICAODJ<KJNANFAKCIO> PGCJHGFGBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private global::EIDJKICAODJ<FDHJLPIBMEF> NGEDJICHDBC;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public global::KBIBONBKFLJ<Entity> AMDGKECPCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public KOGHHCDPOPD GMIJNOPOMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public KOGHHCDPOPD OBGKKFEBGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public KOGHHCDPOPD IDDJAHDLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public KOGHHCDPOPD MGNEDPKGHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public KOGHHCDPOPD PEHFPKKACKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x6D2590", Offset = "0x6D1990", VA = "0x1806D2590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager NPBNPNJJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x375FFF0", Offset = "0x375F3F0", VA = "0x18375FFF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x3760040", Offset = "0x375F440", VA = "0x183760040", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x375FF00", Offset = "0x375F300", VA = "0x18375FF00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x296C550", Offset = "0x296B950", VA = "0x18296C550")]
	private void HCLJCDJPJCB<T>(ref global::EIDJKICAODJ<T> ADKIJCPOMNK) where T : struct, IKMGKFNJFNI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x296C550", Offset = "0x296B950", VA = "0x18296C550")]
	private void HCLJCDJPJCB<TC, TV>(ref global::EMFAIGONLBB<TC, TV> ADKIJCPOMNK) where TC : struct, IKMGKFNJFNI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public LDJNBNGIACM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[AOJPGBJKDNL(typeof(CEOBFGJBIGO), new string[] { })]
[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
internal sealed class CEOBFGJBIGO : HIJIFLANIAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private APDJNEDCAIJ FPKJONNELHN;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public APDJNEDCAIJ EOFOHPFFAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x1294F90", Offset = "0x1294390", VA = "0x181294F90")]
		get
		{
			return default(APDJNEDCAIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x37DC970", Offset = "0x37DBD70", VA = "0x1837DC970", Slot = "4")]
	public void MPBHMBLFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x37DC960", Offset = "0x37DBD60", VA = "0x1837DC960", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public CEOBFGJBIGO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[AOJPGBJKDNL(typeof(TransformOwnershipPhase), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public enum CHFBOPOJOON
		{
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public struct GDFIDMOEMDI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private CHFBOPOJOON FDIOKKLPLOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private readonly TransformOwnershipPhase CNDFBGEJOLI;

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x4190D20", Offset = "0x4190120", VA = "0x184190D20")]
			public GDFIDMOEMDI(TransformOwnershipPhase CNDFBGEJOLI, CHFBOPOJOON EIONKOPIMNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x4190D00", Offset = "0x4190100", VA = "0x184190D00", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public CHFBOPOJOON EIONKOPIMNI;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public CHFBOPOJOON LBMLIBBHAFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780")]
			get
			{
				return default(CHFBOPOJOON);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x75ED00", Offset = "0x75E100", VA = "0x18075ED00")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool OEOPJFIHLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x13FBF10", Offset = "0x13FB310", VA = "0x1813FBF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool CJOOJDICIFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x2925B80", Offset = "0x2924F80", VA = "0x182925B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x38BD5E0", Offset = "0x38BC9E0", VA = "0x1838BD5E0")]
		public GDFIDMOEMDI MKJDJECDKEB()
		{
			return default(GDFIDMOEMDI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x38BD5B0", Offset = "0x38BC9B0", VA = "0x1838BD5B0")]
		public GDFIDMOEMDI HMFMHHDOMPC()
		{
			return default(GDFIDMOEMDI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[AOJPGBJKDNL(typeof(HCMIDMOMIFO), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.Circuits)]
	public class CircuitsService : NGENPNOGFON, HCMIDMOMIFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		[CPICBLLAMOM]
		private HLLMBJEPHHO CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityManager BOGIEIBMFCN;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x37E0000", Offset = "0x37DF400", VA = "0x1837E0000", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x37DEE40", Offset = "0x37DE240", VA = "0x1837DEE40", Slot = "5")]
		public bool CHGIEPEHAFC(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x37DF7A0", Offset = "0x37DEBA0", VA = "0x1837DF7A0", Slot = "7")]
		public bool FPFOGLIFFLF(KJNCFICFIIE GNKPFNIMJND, out Guid CPJCPBMIBBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x37DF690", Offset = "0x37DEA90", VA = "0x1837DF690", Slot = "8")]
		public Guid FFHFJMPBMBB(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x37DFDA0", Offset = "0x37DF1A0", VA = "0x1837DFDA0", Slot = "9")]
		public void OGHNDPLIMGC(KJNCFICFIIE GNKPFNIMJND, Guid CPJCPBMIBBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x37DFCB0", Offset = "0x37DF0B0", VA = "0x1837DFCB0", Slot = "10")]
		public bool NIFLPNJJKEO(KJNCFICFIIE GNKPFNIMJND, out Guid GCBLECOPAGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x37DFBA0", Offset = "0x37DEFA0", VA = "0x1837DFBA0", Slot = "11")]
		public Guid LAJMIIIICIP(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x37DF940", Offset = "0x37DED40", VA = "0x1837DF940", Slot = "12")]
		public void INLJIBMLDMB(KJNCFICFIIE GNKPFNIMJND, Guid GCBLECOPAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x37DF300", Offset = "0x37DE700", VA = "0x1837DF300", Slot = "13")]
		public bool EAJMFFGBIOH(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x37DED70", Offset = "0x37DE170", VA = "0x1837DED70", Slot = "14")]
		public void ANLONBFMHAO(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x37DEF40", Offset = "0x37DE340", VA = "0x1837DEF40", Slot = "15")]
		public void DFICMMNOKKK(KJNCFICFIIE GMEHFCMOOAG, KJNCFICFIIE CNDFBGEJOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x37DF350", Offset = "0x37DE750", VA = "0x1837DF350")]
		private void EFFCIJHAKOM(OKAIJHPNMMP EAHKGPDBADB, KJNCFICFIIE CNDFBGEJOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x37E00A0", Offset = "0x37DF4A0", VA = "0x1837E00A0")]
		private void POLFHHGOGIN(OKAIJHPNMMP EAHKGPDBADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x37DF4C0", Offset = "0x37DE8C0", VA = "0x1837DF4C0")]
		private bool FABDLDEHJKA(NPBAKKOKIOD JGHFLANLLNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x37DF890", Offset = "0x37DEC90", VA = "0x1837DF890")]
		private bool HMEAGIFFMPN(NPBAKKOKIOD JGHFLANLLNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x37DEDE0", Offset = "0x37DE1E0", VA = "0x1837DEDE0", Slot = "6")]
		public bool BOIBLCNADBF(KJNCFICFIIE LJGIOCJLACK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[AOJPGBJKDNL(typeof(KMPDMJCJEEE), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.Connectables)]
	internal class ConnectableService : KMPDMJCJEEE, NGENPNOGFON, CJFEEGPLPHA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class PPIOKLLKIBD : IEnumerable<KJNCFICFIIE>, IEnumerable, IEnumerator<KJNCFICFIIE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private KJNCFICFIIE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			private KJNCFICFIIE localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public KJNCFICFIIE <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			private KJNCFICFIIE System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0x8291E0", Offset = "0x8285E0", VA = "0x1808291E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KJNCFICFIIE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x41974E0", Offset = "0x41968E0", VA = "0x1841974E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x829280", Offset = "0x828680", VA = "0x180829280")]
			[DebuggerHidden]
			public PPIOKLLKIBD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x4197530", Offset = "0x4196930", VA = "0x184197530", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x41970F0", Offset = "0x41964F0", VA = "0x1841970F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x4197600", Offset = "0x4196A00", VA = "0x184197600")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x4197650", Offset = "0x4196A50", VA = "0x184197650")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x41974A0", Offset = "0x41968A0", VA = "0x1841974A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x41973F0", Offset = "0x41967F0", VA = "0x1841973F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KJNCFICFIIE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x41973F0", Offset = "0x41967F0", VA = "0x1841973F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly BBHAOFNBCPD DALNHNBGDJJ;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public const int GHBFELDDBLJ = 0;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public const int LNBHAJKEHPK = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private AOJCNPMLIMB KBMLCGACCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private CBGJJCKMFCA LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private PFHNJBGFDIA CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PropertyEventCallbacksService ODEGAHCHELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private global::NBILNGMPECD<Entity> KGGECLIKGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private global::NBILNGMPECD<float3> GOMLMPMGEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private global::NBILNGMPECD<quaternion> PKPIHNHBMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private global::NBILNGMPECD<Entity> CNDFBGEJOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private global::NBILNGMPECD<float3> NIAHCGPKDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private global::NBILNGMPECD<quaternion> KJCIGGBJPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HashSet<Entity> JLIJHHMHCBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private HashSet<Entity> OGDBAPDLCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private EntityQuery MHAJAPLNINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public Func<NKCGOGCFAON> OMILANLIBMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x78AE60", Offset = "0x78A260", VA = "0x18078AE60", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x78B010", Offset = "0x78A410", VA = "0x18078B010", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<KJNCFICFIIE, KJNCFICFIIE> KOENBPCLLDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x37E5020", Offset = "0x37E4420", VA = "0x1837E5020", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x37E5260", Offset = "0x37E4660", VA = "0x1837E5260", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<KJNCFICFIIE, KJNCFICFIIE> AKEGGGPFFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x37E5300", Offset = "0x37E4700", VA = "0x1837E5300", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x37E50C0", Offset = "0x37E44C0", VA = "0x1837E50C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<KJNCFICFIIE, KJNCFICFIIE, KJNCFICFIIE> LKKHHCJADJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x37E42A0", Offset = "0x37E36A0", VA = "0x1837E42A0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x37E5770", Offset = "0x37E4B70", VA = "0x1837E5770", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<KJNCFICFIIE> ECIPKKGLENB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x37E4A50", Offset = "0x37E3E50", VA = "0x1837E4A50", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x37E43E0", Offset = "0x37E37E0", VA = "0x1837E43E0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x37E5B70", Offset = "0x37E4F70", VA = "0x1837E5B70", Slot = "25")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x37E4B80", Offset = "0x37E3F80", VA = "0x1837E4B80", Slot = "26")]
		public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x37E48A0", Offset = "0x37E3CA0", VA = "0x1837E48A0", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x37E4670", Offset = "0x37E3A70", VA = "0x1837E4670")]
		private void DGHEAHKCICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x37E4130", Offset = "0x37E3530", VA = "0x1837E4130")]
		private void BKHJAFBHKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x37E3F10", Offset = "0x37E3310", VA = "0x1837E3F10")]
		private void AGJCOJCFHBH(Entity OOEHGINMJGM, ODHBKAFBAFM IIMBCOAEFMJ, NICFNFKBPKA AJNJONIBFJA, NICFNFKBPKA IOHONDKAJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x37E40D0", Offset = "0x37E34D0", VA = "0x1837E40D0")]
		private void AIHANIBBFJM(Entity OOEHGINMJGM, ODHBKAFBAFM IIMBCOAEFMJ, NICFNFKBPKA AJNJONIBFJA, NICFNFKBPKA IOHONDKAJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x181CDE0", Offset = "0x181C1E0", VA = "0x18181CDE0", Slot = "14")]
		public KJNCFICFIIE OIOLHOFEJKM(KJNCFICFIIE GNKPFNIMJND, int AMGJGGNCHOK)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x1EAB460", Offset = "0x1EAA860", VA = "0x181EAB460", Slot = "15")]
		public Color KHNDDMFJOEH(KJNCFICFIIE GNKPFNIMJND, int AMGJGGNCHOK)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x37E5810", Offset = "0x37E4C10", VA = "0x1837E5810", Slot = "16")]
		public float3 NLGOIJJEDOH(KJNCFICFIIE GNKPFNIMJND, int AMGJGGNCHOK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x37E4510", Offset = "0x37E3910", VA = "0x1837E4510", Slot = "17")]
		public bool CNBKALIEPPH(KJNCFICFIIE GNKPFNIMJND, KJNCFICFIIE HPJMGHNAGPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x37E45C0", Offset = "0x37E39C0", VA = "0x1837E45C0", Slot = "18")]
		public KJNCFICFIIE CPIDDIOBDJN(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x37E5620", Offset = "0x37E4A20", VA = "0x1837E5620", Slot = "21")]
		public void NJFJMMJKENG(KJNCFICFIIE GNKPFNIMJND, Vector3 MINBMOJAOIJ, Quaternion OMJIHAMGJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x37E4340", Offset = "0x37E3740", VA = "0x1837E4340", Slot = "23")]
		public float3 CCLKPMNAGAA(IMKMPNNNKKA BKDGMAOLNOG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x37E4480", Offset = "0x37E3880", VA = "0x1837E4480", Slot = "24")]
		public quaternion CLNKMOAIPCN(IMKMPNNNKKA BKDGMAOLNOG)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x37E5160", Offset = "0x37E4560", VA = "0x1837E5160", Slot = "28")]
		public RigidTransform KCJEMFDEOGI(IMKMPNNNKKA BKDGMAOLNOG)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x37E59F0", Offset = "0x37E4DF0", VA = "0x1837E59F0", Slot = "22")]
		public bool OPGDDLOABJB(KJNCFICFIIE GNKPFNIMJND, out RigidTransform FJCJFDHIEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x37E4AF0", Offset = "0x37E3EF0", VA = "0x1837E4AF0", Slot = "19")]
		[IteratorStateMachine(typeof(PPIOKLLKIBD))]
		public IEnumerable<KJNCFICFIIE> FPINKMOGICI(KJNCFICFIIE GNKPFNIMJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x37E54C0", Offset = "0x37E48C0", VA = "0x1837E54C0", Slot = "20")]
		public KJNCFICFIIE MGKKMKIHKDI(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x37E46D0", Offset = "0x37E3AD0", VA = "0x1837E46D0", Slot = "29")]
		public void DILOMGMBPDJ(ref List<KJNCFICFIIE> GMPFLANMHBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x37E53A0", Offset = "0x37E47A0", VA = "0x1837E53A0")]
		private Entity MGKKMKIHKDI(Entity OOEHGINMJGM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x37E5D80", Offset = "0x37E5180", VA = "0x1837E5D80")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Prefabs)]
	[AOJPGBJKDNL(typeof(ObjectInstantiationService), new string[] { })]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	internal sealed class ObjectInstantiationService : NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA LIPGMHFIHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[CPICBLLAMOM]
		private HMPFLJOECKJ GOADFDKPJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[CPICBLLAMOM]
		private LGJBFBKFPLE FAIKGMKCEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[CPICBLLAMOM]
		private ObjectNetworkToLocalMapService KEENEJEMIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[CPICBLLAMOM]
		private ObjectLifecycleService PHNFNFPBDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[CPICBLLAMOM]
		private ObjectPrefabs GKKDCEIPLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[CPICBLLAMOM]
		private IBPFNOLDCLO MGPCCJPGHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private KEICNAJBANN CGKMMOPOBPI;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public int NOMCDGGNAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0x376BC90", Offset = "0x376B090", VA = "0x18376BC90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x376C170", Offset = "0x376B570", VA = "0x18376C170", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x376C0F0", Offset = "0x376B4F0", VA = "0x18376C0F0")]
		public Entity MHLLMDPCNMF(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x376BB60", Offset = "0x376AF60", VA = "0x18376BB60")]
		public Entity AECJHCGBPOI(EHNBIOJHEAD DGDIPHPMEJP, AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x376BCF0", Offset = "0x376B0F0", VA = "0x18376BCF0")]
		public Entity HMFOIELDBON(AGNBDHNLGKL LDKBJDPJMKG, bool LALJKONNGBI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x376BCE0", Offset = "0x376B0E0", VA = "0x18376BCE0")]
		public Entity HMFOIELDBON(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x376C060", Offset = "0x376B460", VA = "0x18376C060")]
		public Entity KHJDHCNKEIA()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x376C070", Offset = "0x376B470", VA = "0x18376C070")]
		public Entity LIKJNLFLDAN(LGHJFDELFEL BKGBGEHNCAE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x376BBC0", Offset = "0x376AFC0", VA = "0x18376BBC0")]
		public Entity BBKFAKNPMLB(COHKEJMMIKI BKGBGEHNCAE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x376BC40", Offset = "0x376B040", VA = "0x18376BC40")]
		public NativeArray<(KJNCFICFIIE, KJNCFICFIIE)> GMIKKPABJEA(NativeArray<KJNCFICFIIE> ANCPHOALPDO, Allocator NDJJBKEIGCD)
		{
			return default(NativeArray<(KJNCFICFIIE, KJNCFICFIIE)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x376BDE0", Offset = "0x376B1E0", VA = "0x18376BDE0")]
		public IEnumerable<AGNBDHNLGKL> JANHLOPNDCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x376BD80", Offset = "0x376B180", VA = "0x18376BD80")]
		public EntityArchetype IMHNPKCCCGE(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x376C110", Offset = "0x376B510", VA = "0x18376C110")]
		public Entity OIFGNHBPMGH(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x376BEC0", Offset = "0x376B2C0", VA = "0x18376BEC0")]
		private Entity JKPBMGCKMAB(AGNBDHNLGKL LDKBJDPJMKG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x376BE30", Offset = "0x376B230", VA = "0x18376BE30")]
		private Entity JKPBMGCKMAB(AGNBDHNLGKL LDKBJDPJMKG, bool LALJKONNGBI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x376BF40", Offset = "0x376B340", VA = "0x18376BF40")]
		private Entity JKPBMGCKMAB(AGNBDHNLGKL LDKBJDPJMKG, EHNBIOJHEAD DGDIPHPMEJP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[AOJPGBJKDNL(typeof(FJEGFCLMACC), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	public sealed class PhysicsSceneColliderService : FJEGFCLMACC, LDKJPNAKKFB, HIJIFLANIAO, NGENPNOGFON, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private const string KBAONLKNDDL = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private const int BHFGMDLBAKJ = -1;

		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private const int BHAGGCPDGLN = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[CPICBLLAMOM]
		private AIKEDHOJPPH NOGKNHKHMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Collider[] GIKPJNCBJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private RaycastHit[] MNGNDGHNAON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private global::OGHFMFGNANG<HIKBMDMACJE, BoxCollider> EAAEJIHNGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private Scene LKJCHBJAPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PhysicsScene EMGPFHPCPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GameObject CCDPGFIPGOA;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public int POLOONHNDHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x3777400", Offset = "0x3776800", VA = "0x183777400", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x3777EB0", Offset = "0x37772B0", VA = "0x183777EB0", Slot = "9")]
		public void MPBHMBLFPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x37780A0", Offset = "0x37774A0", VA = "0x1837780A0", Slot = "10")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x37770F0", Offset = "0x37764F0", VA = "0x1837770F0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x3776FA0", Offset = "0x37763A0", VA = "0x183776FA0", Slot = "4")]
		public HIKBMDMACJE DLFACPDNLID(Entity OOEHGINMJGM)
		{
			return default(HIKBMDMACJE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x3777600", Offset = "0x3776A00", VA = "0x183777600", Slot = "5")]
		public void GMFDOGDAIEL(NativeArray<HIKBMDMACJE> LMKEDMFBABP, NativeArray<CABEJGFNMCM> BKEOBLCBLFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x3778160", Offset = "0x3777560", VA = "0x183778160", Slot = "6")]
		public void PGOMMOJHNAI(HIKBMDMACJE CKELBFAAOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x3777440", Offset = "0x3776840", VA = "0x183777440", Slot = "7")]
		public bool FOHHEKKGDGD(HIKBMDMACJE CKELBFAAOKG, out Collider ECFBGBALBNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x3777810", Offset = "0x3776C10", VA = "0x183777810")]
		public bool GNDAEEBMJKP(in float3 NOKNCIPGLOJ, in float3 GPCLDFNJCPC, float DODLNOOJAAB, Allocator NDJJBKEIGCD, out NativeArray<Entity> NMNOLKKCICL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x3776F50", Offset = "0x3776350", VA = "0x183776F50")]
		private void DDKJNMPLPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x78C720", Offset = "0x78BB20", VA = "0x18078C720")]
		private void LGJKHAJPEPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x3777E60", Offset = "0x3777260", VA = "0x183777E60")]
		private void LNOCEHALKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x103AC60", Offset = "0x103A060", VA = "0x18103AC60")]
		private void GPHJMIAGOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x37774E0", Offset = "0x37768E0", VA = "0x1837774E0")]
		private BoxCollider GFNIOEMFLEE(Entity OOEHGINMJGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x3778020", Offset = "0x3777420", VA = "0x183778020")]
		private void NKPEFGMMIEH(BoxCollider EAFFNLCGPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x3776EC0", Offset = "0x37762C0", VA = "0x183776EC0")]
		[Conditional("UNITY_EDITOR")]
		private void ACGOJAIHAOP(GameObject CEPEJEHMODM, Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x3777C70", Offset = "0x3777070", VA = "0x183777C70")]
		private void LJMHONIIJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x3777B20", Offset = "0x3776F20", VA = "0x183777B20")]
		private void HCPAIGLNKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x37771F0", Offset = "0x37765F0", VA = "0x1837771F0")]
		private void EIMEJBGKGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x3777C30", Offset = "0x3777030", VA = "0x183777C30")]
		private void ICNEKHNNNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x3777C60", Offset = "0x3777060", VA = "0x183777C60")]
		private void LJBFOPHKCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x3776F00", Offset = "0x3776300", VA = "0x183776F00")]
		private void ALDNCECIKIG(Scene PBFJADIHOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x3776F40", Offset = "0x3776340", VA = "0x183776F40", Slot = "8")]
		private bool AMLBNGEFADD(in float3 NOKNCIPGLOJ, in float3 GPCLDFNJCPC, float DODLNOOJAAB, Allocator NDJJBKEIGCD, out NativeArray<Entity> NMNOLKKCICL)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[AOJPGBJKDNL(typeof(EPMLANJFBCG), new string[] { })]
public sealed class NHLGHIBIAPC : EPMLANJFBCG, NGENPNOGFON
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	private struct AIKIGBIHOJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public float POMOGMGJPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public uint OHNCDLFJBCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private LDKJPNAKKFB AFOKOJBFAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private FEHPAKLBAEK MGABJAJCHFM;

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x3764D40", Offset = "0x3764140", VA = "0x183764D40", Slot = "5")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x37647C0", Offset = "0x3763BC0", VA = "0x1837647C0")]
	public bool GNDAEEBMJKP(in float3 NOKNCIPGLOJ, in float3 GPCLDFNJCPC, float DODLNOOJAAB, out BFOAICJIPMA MOCLHJNGJBD, out Entity BDICJGKJDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x3764C40", Offset = "0x3764040", VA = "0x183764C40")]
	public static bool KMJAOCMBGNF(in Span<BFOAICJIPMA> OCAFFODBPBP, float DODLNOOJAAB, out int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x3764790", Offset = "0x3763B90", VA = "0x183764790")]
	public static float CLHHCEGJDAN(float POMOGMGJPEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NHLGHIBIAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x3764DB0", Offset = "0x37641B0", VA = "0x183764DB0", Slot = "4")]
	private bool POEFNJLIOME(in float3 NOKNCIPGLOJ, in float3 GPCLDFNJCPC, float DODLNOOJAAB, out BFOAICJIPMA MOCLHJNGJBD, out Entity BDICJGKJDPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[AOJPGBJKDNL(typeof(FEHPAKLBAEK), new string[] { })]
public sealed class AOPJBJNDAPB : FEHPAKLBAEK, NGENPNOGFON
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[BurstCompile]
	private struct BLOHCPMBLML : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<Entity> NMNOLKKCICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[ReadOnly]
		public float3 GALGBMFBDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[ReadOnly]
		public float3 KDNNPCONOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> ELIEDCGHPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> CHMHLIDGIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> GMFPGLDOANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> IDMPIGALJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> PECLAAICEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[WriteOnly]
		public NativeArray<BFOAICJIPMA> MOBCAINLLGB;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private static readonly BFOAICJIPMA BLKNPBFBIEO;

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x38ACE20", Offset = "0x38AC220", VA = "0x1838ACE20", Slot = "4")]
		public void Execute(int GABJOMFFJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x38AD100", Offset = "0x38AC500", VA = "0x1838AD100")]
		private static float3 IFDPJAPOEJP(in float4x4 HKGKDNGGKOB, in float3 KONDPAFENHO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x38AD1D0", Offset = "0x38AC5D0", VA = "0x1838AD1D0")]
		private static float3 JBGFNJNPPNC(in float4x4 HKGKDNGGKOB, in float3 LNJIJCHAAFM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x38ACB00", Offset = "0x38ABF00", VA = "0x1838ACB00")]
		private static float3 BFDEKNCIOEJ(in float4x4 HKGKDNGGKOB, in float3 KONDPAFENHO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x38ACC00", Offset = "0x38AC000", VA = "0x1838ACC00")]
		private static float3 EDAEDBNOHPD(in float4x4 HKGKDNGGKOB, in float3 LNJIJCHAAFM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x38AC0E0", Offset = "0x38AB4E0", VA = "0x1838AC0E0")]
		private bool AJIHHPBGDHG(in float3 NOKNCIPGLOJ, in float3 GPCLDFNJCPC, in NativeArray<Entity> MPLPMKMGBIP, out float3 MOCLHJNGJBD, out float3 FGGPFFJEFOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x38AC430", Offset = "0x38AB830", VA = "0x1838AC430")]
		public static bool BDKBENNFHJK(in float3 DEBJLCJJIFA, in float3 OGAOMEDDPBA, in float3 DMBDADHEPPM, in float3 PNDINOJOEHA, float BPAKGAKLJGM, float EKIGIINNFEP, out float MOGPOAHNFIM, out float3 LJFMCAEAHLP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager BOGIEIBMFCN;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x37D5310", Offset = "0x37D4710", VA = "0x1837D5310", Slot = "5")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x37D4E30", Offset = "0x37D4230", VA = "0x1837D4E30")]
	public void GNDAEEBMJKP(in NativeArray<Entity> NMNOLKKCICL, in float3 NOKNCIPGLOJ, in float3 GPCLDFNJCPC, in NativeArray<BFOAICJIPMA> DAHIPNHCGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public AOPJBJNDAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x37D4E20", Offset = "0x37D4220", VA = "0x1837D4E20", Slot = "4")]
	private void ALMDMKINDKM(in NativeArray<Entity> NMNOLKKCICL, in float3 NOKNCIPGLOJ, in float3 GPCLDFNJCPC, in NativeArray<BFOAICJIPMA> DAHIPNHCGKE)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Embodiment)]
	[PHECHDJFGDG(FPOGPJMGMEG.OMRoom)]
	[AOJPGBJKDNL(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : NGENPNOGFON, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[CPICBLLAMOM]
		private CBGJJCKMFCA PEPLIFOGJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[CPICBLLAMOM]
		private HMPFLJOECKJ PDKLKFKIMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[CPICBLLAMOM]
		private LGJBFBKFPLE LJHINBGJGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private LBIICBANFEM PANNLLNEPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NativeHashMap<EHNBIOJHEAD, Entity> BENDAJBCGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private EntityManager BOGIEIBMFCN;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal NativeHashMap<EHNBIOJHEAD, Entity> HLKBNKGDHKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0x847B30", Offset = "0x846F30", VA = "0x180847B30")]
			get
			{
				return default(NativeHashMap<EHNBIOJHEAD, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint OGCKBDHGFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x376F660", Offset = "0x376EA60", VA = "0x18376F660")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool PGGMGHNLHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x7CE320", Offset = "0x7CD720", VA = "0x1807CE320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0x7CE810", Offset = "0x7CDC10", VA = "0x1807CE810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x376F6F0", Offset = "0x376EAF0", VA = "0x18376F6F0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x376F3F0", Offset = "0x376E7F0", VA = "0x18376F3F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x376F370", Offset = "0x376E770", VA = "0x18376F370")]
		public void BIEFCABEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x376F120", Offset = "0x376E520", VA = "0x18376F120")]
		public void AGDFJPODMNE(EHNBIOJHEAD DGDIPHPMEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x376F540", Offset = "0x376E940", VA = "0x18376F540")]
		private KJNCFICFIIE FKACDFOHGMO(Entity OOEHGINMJGM)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x376F460", Offset = "0x376E860", VA = "0x18376F460")]
		public KJNCFICFIIE EHPBFPGFMPJ(EHNBIOJHEAD DGDIPHPMEJP)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x376F5D0", Offset = "0x376E9D0", VA = "0x18376F5D0")]
		public EHNBIOJHEAD IGIFPGJEPFO(KJNCFICFIIE GNKPFNIMJND)
		{
			return default(EHNBIOJHEAD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x376F2E0", Offset = "0x376E6E0", VA = "0x18376F2E0")]
		public void ANJJEEMIBAH(Entity OOEHGINMJGM, EHNBIOJHEAD DGDIPHPMEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x376F690", Offset = "0x376EA90", VA = "0x18376F690")]
		public void OLAEDDEBBIN(Entity OOEHGINMJGM, EHNBIOJHEAD DGDIPHPMEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x376F570", Offset = "0x376E970", VA = "0x18376F570")]
		public void FNOFLAOPPPL(Entity OOEHGINMJGM, EHNBIOJHEAD DGDIPHPMEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x376F050", Offset = "0x376E450", VA = "0x18376F050")]
		public void ABIGNCLPIDL(Entity OOEHGINMJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
	[AOJPGBJKDNL(typeof(PropertyEventCallbacksService), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.Callbacks)]
	public class PropertyEventCallbacksService : NGENPNOGFON, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		private struct FBKKICJDEHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public DEAAHNIKOLP KCKLDKHBENC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public Type BKGBGEHNCAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public int OLGJFEONMLB;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		private struct JFBHCHAFCMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public FBKKICJDEHD[] FIJECBKDHDI;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		public delegate void DEAAHNIKOLP(Entity OOEHGINMJGM, ODHBKAFBAFM IIMBCOAEFMJ, NICFNFKBPKA AJNJONIBFJA, NICFNFKBPKA IOHONDKAJKK);

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly Dictionary<ODHBKAFBAFM, DEAAHNIKOLP> OBJFPMACGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private readonly Dictionary<int, JFBHCHAFCMJ> OJNHINHGAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private AECLLFLJBLC FIJECBKDHDI;

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action BHJILLABMGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x377E140", Offset = "0x377D540", VA = "0x18377E140")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x377E2D0", Offset = "0x377D6D0", VA = "0x18377E2D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action APMJDEEJBED
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x377E010", Offset = "0x377D410", VA = "0x18377E010")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x377DD00", Offset = "0x377D100", VA = "0x18377DD00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x377ECA0", Offset = "0x377E0A0", VA = "0x18377ECA0", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x377E0B0", Offset = "0x377D4B0", VA = "0x18377E0B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x377E370", Offset = "0x377D770", VA = "0x18377E370")]
		public void MHBAMOAJPNP(ODHBKAFBAFM IIMBCOAEFMJ, DEAAHNIKOLP KCKLDKHBENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x377DDA0", Offset = "0x377D1A0", VA = "0x18377DDA0")]
		public void BHKEMMCNIBE(ODHBKAFBAFM IIMBCOAEFMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x377DA70", Offset = "0x377CE70", VA = "0x18377DA70")]
		internal void AOOEHFBNDJI(JCDAMMIJJIF LGKAKPIGKKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x377E4E0", Offset = "0x377D8E0", VA = "0x18377E4E0")]
		private void OGLDOHBECBK(JCDAMMIJJIF LGKAKPIGKKN, int KCBELKOOOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x377EA20", Offset = "0x377DE20", VA = "0x18377EA20")]
		private void OGPICKIOHDP(HNBCIHNKHJC FBHLIBEOAED, JGGHPLEENKB KOEENPMGLPA, FBKKICJDEHD FPAKGOCGPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x377DE90", Offset = "0x377D290", VA = "0x18377DE90")]
		private JFBHCHAFCMJ BKDAEGHNEJB(HNBCIHNKHJC FBHLIBEOAED, JGGHPLEENKB KOEENPMGLPA)
		{
			return default(JFBHCHAFCMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x377E1E0", Offset = "0x377D5E0", VA = "0x18377E1E0")]
		private FBKKICJDEHD FGKEGKGBKPJ(JFBHCHAFCMJ FKIMHPOMHIG, HNBCIHNKHJC FBHLIBEOAED, JGGHPLEENKB KOEENPMGLPA)
		{
			return default(FBKKICJDEHD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x377ED40", Offset = "0x377E140", VA = "0x18377ED40")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[AOJPGBJKDNL(typeof(KGNMEDAKICL), new string[] { })]
public class GCOLNGCGNNC : NGENPNOGFON, CJFEEGPLPHA, KGNMEDAKICL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	private sealed class ENIDDBPJCOD : IEnumerable<KJNCFICFIIE>, IEnumerable, IEnumerator<KJNCFICFIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private KJNCFICFIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public GCOLNGCGNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private KJNCFICFIIE splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public KJNCFICFIIE <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		private KJNCFICFIIE System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0x8291E0", Offset = "0x8285E0", VA = "0x1808291E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KJNCFICFIIE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0x418F560", Offset = "0x418E960", VA = "0x18418F560", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x829280", Offset = "0x828680", VA = "0x180829280")]
		[DebuggerHidden]
		public ENIDDBPJCOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x418F3B0", Offset = "0x418E7B0", VA = "0x18418F3B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x418F520", Offset = "0x418E920", VA = "0x18418F520", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x418F470", Offset = "0x418E870", VA = "0x18418F470", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KJNCFICFIIE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x418F470", Offset = "0x418E870", VA = "0x18418F470", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private LBIICBANFEM PANNLLNEPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private CPMIMENPODG EHMGELLDDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private ObjectInstantiationService GKKDCEIPLBI;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EntityManager NPBNPNJJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x3A615B0", Offset = "0x3A609B0", VA = "0x183A615B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private JIBOBOIGILH NANHEDFHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x3A61A30", Offset = "0x3A60E30", VA = "0x183A61A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x3A62280", Offset = "0x3A61680", VA = "0x183A62280", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x3A61CE0", Offset = "0x3A610E0", VA = "0x183A61CE0", Slot = "5")]
	public void IHAPPEEILPC(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x3A61500", Offset = "0x3A60900", VA = "0x183A61500", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x3A611B0", Offset = "0x3A605B0", VA = "0x183A611B0")]
	private void BFFPBPCJDFN(Entity GNJBFFIPLAG, in NICFNFKBPKA GGPFLMFJFKO, in NICFNFKBPKA OIOCGOCBAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x3A61DE0", Offset = "0x3A611E0", VA = "0x183A61DE0", Slot = "14")]
	public KJNCFICFIIE KHJDHCNKEIA()
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x3A61FF0", Offset = "0x3A613F0", VA = "0x183A61FF0", Slot = "10")]
	public void OAGBCCKJCAC(KJNCFICFIIE GNKPFNIMJND, JDCGALHMEJB PEEIAPNNFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x3A61E40", Offset = "0x3A61240", VA = "0x183A61E40", Slot = "9")]
	public JDCGALHMEJB LGEIGNMBFCO(KJNCFICFIIE GNKPFNIMJND)
	{
		return default(JDCGALHMEJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x3A61600", Offset = "0x3A60A00", VA = "0x183A61600", Slot = "11")]
	public KJNCFICFIIE EKJPCGAMDAF(KJNCFICFIIE AFJECOEPPAE, [Optional] Vector3? KGJPEGOHADA, [Optional] Quaternion? GCFIGFMOIAL, [Optional] Vector3? AIBLENCNPFJ)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x3A61430", Offset = "0x3A60830", VA = "0x183A61430", Slot = "15")]
	public KJNCFICFIIE DCOEONCHHHE(KJNCFICFIIE LJNOOKFCCIG, int GABJOMFFJAI, [Optional] Vector3? KGJPEGOHADA, [Optional] Quaternion? GCFIGFMOIAL, [Optional] Vector3? AIBLENCNPFJ)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x3A610C0", Offset = "0x3A604C0", VA = "0x183A610C0", Slot = "7")]
	public KJNCFICFIIE BEBFOLEOOEF(KJNCFICFIIE LJNOOKFCCIG, int GABJOMFFJAI)
	{
		return default(KJNCFICFIIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x3A61F30", Offset = "0x3A61330", VA = "0x183A61F30", Slot = "16")]
	public void NKKMCJALEMN(KJNCFICFIIE LJNOOKFCCIG, KJNCFICFIIE JPMHBKMFPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x3A620E0", Offset = "0x3A614E0", VA = "0x183A620E0", Slot = "12")]
	public void OGPGINMFHCP(KJNCFICFIIE LJNOOKFCCIG, int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x3A61B40", Offset = "0x3A60F40", VA = "0x183A61B40", Slot = "17")]
	public void GOFBGHCPODL(KJNCFICFIIE LJNOOKFCCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x3A61990", Offset = "0x3A60D90", VA = "0x183A61990", Slot = "8")]
	public int FMCKNDLLDHK(KJNCFICFIIE LJNOOKFCCIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x3A61470", Offset = "0x3A60870", VA = "0x183A61470", Slot = "6")]
	[IteratorStateMachine(typeof(ENIDDBPJCOD))]
	public IEnumerable<KJNCFICFIIE> DIEIDLLGNKP(KJNCFICFIIE LJNOOKFCCIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x3A61900", Offset = "0x3A60D00", VA = "0x183A61900")]
	private bool FCGCMLMMJGL(KJNCFICFIIE LJNOOKFCCIG, out NativeArray<Entity> GNLABAOMILF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x3A61A80", Offset = "0x3A60E80", VA = "0x183A61A80")]
	private NativeArray<Entity> GAKOEGOCCKK(KJNCFICFIIE LJNOOKFCCIG)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GCOLNGCGNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[PHECHDJFGDG(FPOGPJMGMEG.LoadInstance)]
[AOJPGBJKDNL(typeof(CEELHAEJJEO), new string[] { })]
internal sealed class CEELHAEJJEO : NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private CBGJJCKMFCA LIPGMHFIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformOwnershipPhase OELDLPPDGKI;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private AJIJKHGHPDE PHIKONIBLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x37DC5C0", Offset = "0x37DB9C0", VA = "0x1837DC5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x37DC8E0", Offset = "0x37DBCE0", VA = "0x1837DC8E0", Slot = "4")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x37DC4D0", Offset = "0x37DB8D0", VA = "0x1837DC4D0")]
	public void FHNMFDLKHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x37DC610", Offset = "0x37DBA10", VA = "0x1837DC610")]
	public void MAOHGMPIJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public CEELHAEJJEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct BACKMCCIEGI : IEquatable<BACKMCCIEGI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly int KCBELKOOOJG;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Type NKDMIECPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x37D75B0", Offset = "0x37D69B0", VA = "0x1837D75B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x37D76C0", Offset = "0x37D6AC0", VA = "0x1837D76C0")]
	public BACKMCCIEGI(Type BKGBGEHNCAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x37D74E0", Offset = "0x37D68E0", VA = "0x1837D74E0")]
	public static BACKMCCIEGI ABLJGBEPCFM(Type BKGBGEHNCAE)
	{
		return default(BACKMCCIEGI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x37D7510", Offset = "0x37D6910", VA = "0x1837D7510")]
	public static Type ABLJGBEPCFM(BACKMCCIEGI CKELBFAAOKG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x82AAA0", Offset = "0x829EA0", VA = "0x18082AAA0")]
	public static bool OACFLELFBPC(BACKMCCIEGI KEPOHMNFLGL, BACKMCCIEGI CFEKEMJOJGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x82AAA0", Offset = "0x829EA0", VA = "0x18082AAA0")]
	public static bool OFLJMIEJHAG(BACKMCCIEGI KEPOHMNFLGL, BACKMCCIEGI CFEKEMJOJGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x82A660", Offset = "0x829A60", VA = "0x18082A660", Slot = "4")]
	public bool Equals(BACKMCCIEGI FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x37D7530", Offset = "0x37D6930", VA = "0x1837D7530", Slot = "0")]
	public override bool Equals(object JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x37D7690", Offset = "0x37D6A90", VA = "0x1837D7690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public static class BKIPPCEMFHF
{
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static Dictionary<Type, int> KMCDKFPKDLJ;

	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private static List<Type> JLBDHBPCANF;

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x37D8300", Offset = "0x37D7700", VA = "0x1837D8300")]
	static BKIPPCEMFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x329A0E0", Offset = "0x32994E0", VA = "0x18329A0E0")]
	public static bool BKCAAEBNAMB<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x37D7FC0", Offset = "0x37D73C0", VA = "0x1837D7FC0")]
	public static bool BKCAAEBNAMB(Type BKGBGEHNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x37D7E50", Offset = "0x37D7250", VA = "0x1837D7E50")]
	private static bool BKCAAEBNAMB(Type BKGBGEHNCAE, out int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x329A170", Offset = "0x3299570", VA = "0x18329A170")]
	public static int DEHBMNIIEEG<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x37D8030", Offset = "0x37D7430", VA = "0x1837D8030")]
	public static int DEHBMNIIEEG(Type BKGBGEHNCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x329A200", Offset = "0x3299600", VA = "0x18329A200")]
	public static bool KNEMJPBHGAN<T>(out int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x37D80A0", Offset = "0x37D74A0", VA = "0x1837D80A0")]
	public static bool KNEMJPBHGAN(Type BKGBGEHNCAE, out int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x37D8260", Offset = "0x37D7660", VA = "0x1837D8260")]
	public static Type PEBNPJONHNJ(int GABJOMFFJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x37D8140", Offset = "0x37D7540", VA = "0x1837D8140")]
	public static bool KNEMJPBHGAN(int GABJOMFFJAI, out Type BKGBGEHNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DefaultMember("Item")]
public struct ENIBFFCJEJE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private T[] MPEBBGJJODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private int DMFMCPNNNLJ;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int FKOLDOEAEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E20", Offset = "0x6C6220", VA = "0x1806C6E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x2526180", Offset = "0x2525580", VA = "0x182526180")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> MIHILEIDBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x2526330", Offset = "0x2525730", VA = "0x182526330")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool OGKFMAGAFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x9F9730", Offset = "0x9F8B30", VA = "0x1809F9730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x25263D0", Offset = "0x25257D0", VA = "0x1825263D0")]
	public ENIBFFCJEJE(int DMFMCPNNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x2526280", Offset = "0x2525680", VA = "0x182526280")]
	public int GLKAIEBIFIN(T FPLJCBGEJAP, int GJOFJPHNEOA, int NDNADCNCIGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x25261C0", Offset = "0x25255C0", VA = "0x1825261C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DefaultMember("Item")]
public struct IFNKJPGCMEG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private global::ENIBFFCJEJE<T> MPEBBGJJODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private int DMFMCPNNNLJ;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public T CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x27F0F00", Offset = "0x27F0300", VA = "0x1827F0F00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int FKOLDOEAEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x27F2570", Offset = "0x27F1970", VA = "0x1827F2570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int LPHNGEMLJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x27F1410", Offset = "0x27F0810", VA = "0x1827F1410")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x27F1BD0", Offset = "0x27F0FD0", VA = "0x1827F1BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool OGKFMAGAFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x27F0F90", Offset = "0x27F0390", VA = "0x1827F0F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> MIHILEIDBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x27F1630", Offset = "0x27F0A30", VA = "0x1827F1630")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x27F2690", Offset = "0x27F1A90", VA = "0x1827F2690")]
	public IFNKJPGCMEG(int DMFMCPNNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x27F1780", Offset = "0x27F0B80", VA = "0x1827F1780")]
	public T IOMJAFJLMBD(int GABJOMFFJAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x27F1190", Offset = "0x27F0590", VA = "0x1827F1190")]
	public void FMIABCHEKME(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x27F1C20", Offset = "0x27F1020", VA = "0x1827F1C20")]
	public void LFMBJDAODDG(Span<T> JOLFKOMKBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x27F0FD0", Offset = "0x27F03D0", VA = "0x1827F0FD0")]
	public void BKCAAEBNAMB(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x27F2090", Offset = "0x27F1490", VA = "0x1827F2090")]
	private void NIFIOFPHPOO(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x27F1D90", Offset = "0x27F1190", VA = "0x1827F1D90")]
	public void MNIAAMBKOLF(Span<T> INJMMDAENFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x27F10E0", Offset = "0x27F04E0", VA = "0x1827F10E0")]
	public void DEJGKNCLGHP(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x27F2350", Offset = "0x27F1750", VA = "0x1827F2350")]
	public void NOOFIFPOPHE(int GLOBCEJCJIP, int AFEDLJDCGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x27F25C0", Offset = "0x27F19C0", VA = "0x1827F25C0")]
	public void OKDKIIFFNKJ(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x27F1200", Offset = "0x27F0600", VA = "0x1827F1200")]
	public void GBAIENLFEOC(int GLOBCEJCJIP, int AFEDLJDCGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x27F1910", Offset = "0x27F0D10", VA = "0x1827F1910")]
	public void KHBGADLKMGC(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x27F1FD0", Offset = "0x27F13D0", VA = "0x1827F1FD0")]
	public void NHPDODDAEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x27F1440", Offset = "0x27F0840", VA = "0x1827F1440")]
	public int GLKAIEBIFIN(T FPLJCBGEJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x27F0D60", Offset = "0x27F0160", VA = "0x1827F0D60")]
	public bool AGHBGCOAOGM(T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x27F1140", Offset = "0x27F0540", VA = "0x1827F1140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x27F2620", Offset = "0x27F1A20", VA = "0x1827F2620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x27F0CF0", Offset = "0x27F00F0", VA = "0x1827F0CF0")]
	public static Span<T> ABLJGBEPCFM(global::IFNKJPGCMEG<T> JOLFKOMKBCI)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x27F17D0", Offset = "0x27F0BD0", VA = "0x1827F17D0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void JADBPBGGGBC(int FPLJCBGEJAP, int DMFMCPNNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void HFLDEGGFOCD(int DMFMCPNNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x27F14D0", Offset = "0x27F08D0", VA = "0x1827F14D0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void HFLDEGGFOCD(int DMFMCPNNNLJ, int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x27F0DC0", Offset = "0x27F01C0", VA = "0x1827F0DC0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void AOPLDELDCHI(int FPLJCBGEJAP, int DMFMCPNNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x27F19D0", Offset = "0x27F0DD0", VA = "0x1827F19D0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void KIMAAIBOAPN(int GLOBCEJCJIP, int AFEDLJDCGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x27F2210", Offset = "0x27F1610", VA = "0x1827F2210")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NOHFHPALABD(int FPLJCBGEJAP, int DMFMCPNNNLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public struct APDJNEDCAIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private const int MCIIJDFAKOM = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NativeList<Entity> NMNOLKKCICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private TransformAccessArray KBMLCGACCJB;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x37D5460", Offset = "0x37D4860", VA = "0x1837D5460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> KLKJCLNJEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0x78E450", Offset = "0x78D850", VA = "0x18078E450")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray OFEEPLPKKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool PGGMGHNLHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x37D5570", Offset = "0x37D4970", VA = "0x1837D5570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x37D5680", Offset = "0x37D4A80", VA = "0x1837D5680")]
	public APDJNEDCAIJ(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x37D55D0", Offset = "0x37D49D0", VA = "0x1837D55D0")]
	public Entity LOOJKDPPJCD(int GABJOMFFJAI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x37D5620", Offset = "0x37D4A20", VA = "0x1837D5620")]
	public Transform OFPBEMEAOJO(int GABJOMFFJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x37D5630", Offset = "0x37D4A30", VA = "0x1837D5630")]
	public void ONPFMOHNHPO(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x37D5390", Offset = "0x37D4790", VA = "0x1837D5390")]
	public int BKCAAEBNAMB(Transform GCKJJOINBCJ, Entity OOEHGINMJGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x37D5470", Offset = "0x37D4870", VA = "0x1837D5470")]
	public int DEJGKNCLGHP(int GABJOMFFJAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x37D54F0", Offset = "0x37D48F0", VA = "0x1837D54F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x37D5590", Offset = "0x37D4990", VA = "0x1837D5590")]
	private void LIGPEBOHOLJ(int HEMIKHAAFPJ = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class IKGNFAAKPFD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private NativeHashMap<BACKMCCIEGI, int2> LKMDJFOJHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private NativeList<byte> DGPBECDNOKK;

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DBF0", Offset = "0x3A6CFF0", VA = "0x183A6DBF0")]
	public IKGNFAAKPFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D510", Offset = "0x3A6C910", VA = "0x183A6D510")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	public void CODPHMBGNGD<T>(T FPLJCBGEJAP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	public T PEBNPJONHNJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D570", Offset = "0x3A6C970", VA = "0x183A6D570")]
	public void CODPHMBGNGD(Type BKGBGEHNCAE, NICFNFKBPKA FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D940", Offset = "0x3A6CD40", VA = "0x183A6D940")]
	public NICFNFKBPKA PEBNPJONHNJ(Type BKGBGEHNCAE)
	{
		return default(NICFNFKBPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DB50", Offset = "0x3A6CF50", VA = "0x183A6DB50")]
	private NativeArray<byte> PJNCOLJDLBF(int2 AANFJINJMKC)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D780", Offset = "0x3A6CB80", VA = "0x183A6D780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D820", Offset = "0x3A6CC20", VA = "0x183A6D820", Slot = "1")]
	~IKGNFAAKPFD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public struct ICAPCLMPPAH<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	internal static T EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	public static global::ICAPCLMPPAH<T> ABLJGBEPCFM(T FPLJCBGEJAP)
	{
		return default(global::ICAPCLMPPAH<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	public static T ABLJGBEPCFM(global::ICAPCLMPPAH<T> IEMLIFLCGLH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public static class NFCLJJMPLDG
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly IKGNFAAKPFD CCKICIMMAJK;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x3764370", Offset = "0x3763770", VA = "0x183764370")]
	internal static void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void CODPHMBGNGD<T>(T FPLJCBGEJAP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x37643E0", Offset = "0x37637E0", VA = "0x1837643E0")]
	public static void CODPHMBGNGD(Type BKGBGEHNCAE, NICFNFKBPKA FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T PEBNPJONHNJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x3764480", Offset = "0x3763880", VA = "0x183764480")]
	public static NICFNFKBPKA PEBNPJONHNJ(Type BKGBGEHNCAE)
	{
		return default(NICFNFKBPKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class LBHGHLPFOEF : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public static readonly LBHGHLPFOEF OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x375F600", Offset = "0x375EA00", VA = "0x18375F600", Slot = "4")]
	public bool Equals(LinkedEntityGroup IMDGNLLHHDC, LinkedEntityGroup NJNDPGIDOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x375F620", Offset = "0x375EA20", VA = "0x18375F620", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup JGHFLANLLNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public LBHGHLPFOEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class DHEIEKAJPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("DEBUG_BUILD")]
	public static void JDMDIICBNCD(in Vector3 KGJPEGOHADA, in Quaternion GCFIGFMOIAL, in Vector3 AIBLENCNPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("DEBUG_BUILD")]
	public static void JNNJCEHLMDP(in Vector3 LICNFMNNFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("DEBUG_BUILD")]
	public static void PBLMNEKOEHB(in Quaternion GCFIGFMOIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("DEBUG_BUILD")]
	public static void HILOCKMENGO(in Vector3 BKMPDNMODKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("DEBUG_BUILD")]
	public static void HIOCIMODKPH(in Vector3 BKMPDNMODKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("DEBUG_BUILD")]
	public static void KMGNDGHKEIC(in float HGHMGIPKCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x37EB130", Offset = "0x37EA530", VA = "0x1837EB130")]
	[Conditional("DEBUG_BUILD")]
	public static void MGPAKCCDEEM(in float3 FPLJCBGEJAP, string CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("DEBUG_BUILD")]
	public static void GKBGHKEJGGC(in float FPLJCBGEJAP, string CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x37EB0E0", Offset = "0x37EA4E0", VA = "0x1837EB0E0")]
	[Conditional("DEBUG_BUILD")]
	public static void GKBGHKEJGGC(in Vector3 FPLJCBGEJAP, string CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x37EB0B0", Offset = "0x37EA4B0", VA = "0x1837EB0B0")]
	[Conditional("DEBUG_BUILD")]
	public static void GKBGHKEJGGC(in Quaternion FPLJCBGEJAP, string CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x37EB1E0", Offset = "0x37EA5E0", VA = "0x1837EB1E0")]
	[Conditional("DEBUG_BUILD")]
	public static void OJIEMDONCDM(in float FPLJCBGEJAP, string CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x37EB220", Offset = "0x37EA620", VA = "0x1837EB220")]
	[Conditional("DEBUG_BUILD")]
	public static void OJIEMDONCDM(in Vector3 FPLJCBGEJAP, string CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x37EB1F0", Offset = "0x37EA5F0", VA = "0x1837EB1F0")]
	[Conditional("DEBUG_BUILD")]
	public static void OJIEMDONCDM(in Quaternion FPLJCBGEJAP, string CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DHEIEKAJPCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct DJDEPENAIGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public Entity OOEHGINMJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public Entity AABDLCHECIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public Entity HKBAAFCKIFC;

	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x37EB3F0", Offset = "0x37EA7F0", VA = "0x1837EB3F0")]
	public DJDEPENAIGM(Entity OOEHGINMJGM, Entity AABDLCHECIH, Entity HKBAAFCKIFC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x37EB390", Offset = "0x37EA790", VA = "0x1837EB390")]
	public static DJDEPENAIGM ABLJGBEPCFM((Entity entity, Entity oldParent, Entity newParent) AIPHPODENKF)
	{
		return default(DJDEPENAIGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x37EB3D0", Offset = "0x37EA7D0", VA = "0x1837EB3D0")]
	public void MDCEJGDOLPN(out Entity OOEHGINMJGM, out Entity AABDLCHECIH, out Entity HKBAAFCKIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct IJDNGJCBHJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public Entity OOEHGINMJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public Entity CNDFBGEJOLI;

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x1015600", Offset = "0x1014A00", VA = "0x181015600")]
	public IJDNGJCBHJA(Entity OOEHGINMJGM, Entity CNDFBGEJOLI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D3F0", Offset = "0x3A6C7F0", VA = "0x183A6D3F0")]
	public static IJDNGJCBHJA ABLJGBEPCFM((Entity entity, Entity parent) AIPHPODENKF)
	{
		return default(IJDNGJCBHJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D420", Offset = "0x3A6C820", VA = "0x183A6D420")]
	public void MDCEJGDOLPN(out Entity OOEHGINMJGM, out Entity CNDFBGEJOLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct PNPHECDLMEC<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private GCHandle CKELBFAAOKG;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public bool JANJLAPLCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x32E0BE0", Offset = "0x32DFFE0", VA = "0x1832E0BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x32E0A50", Offset = "0x32DFE50", VA = "0x1832E0A50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x32E0AF0", Offset = "0x32DFEF0", VA = "0x1832E0AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x32E0BF0", Offset = "0x32DFFF0", VA = "0x1832E0BF0")]
	public PNPHECDLMEC(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x32E0BB0", Offset = "0x32DFFB0", VA = "0x1832E0BB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public enum LPINIIJHNJM
{
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public struct APKHBOJFNAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public LPINIIJHNJM BGAACJLPLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public int OLLBKGIPIKM;

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0x817230", Offset = "0x816630", VA = "0x180817230")]
	public APKHBOJFNAD(LPINIIJHNJM BGAACJLPLPA, int OLLBKGIPIKM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x37D5700", Offset = "0x37D4B00", VA = "0x1837D5700")]
	public static APKHBOJFNAD ABLJGBEPCFM((LPINIIJHNJM eventType, int eventIndex) IMDGNLLHHDC)
	{
		return default(APKHBOJFNAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x37D5720", Offset = "0x37D4B20", VA = "0x1837D5720")]
	public void MDCEJGDOLPN(out LPINIIJHNJM BGAACJLPLPA, out int OLLBKGIPIKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[AOJPGBJKDNL(typeof(LDKJPNAKKFB), new string[] { })]
public sealed class GDNMIPOLGBC : LDKJPNAKKFB, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private FJEGFCLMACC EFPBHJBKLCD;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x3A630F0", Offset = "0x3A624F0", VA = "0x183A630F0", Slot = "5")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x3A63000", Offset = "0x3A62400", VA = "0x183A63000")]
	public bool GNDAEEBMJKP(in float3 NOKNCIPGLOJ, in float3 GPCLDFNJCPC, float DODLNOOJAAB, Allocator NDJJBKEIGCD, out NativeArray<Entity> NMNOLKKCICL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GDNMIPOLGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x3A63000", Offset = "0x3A62400", VA = "0x183A63000", Slot = "4")]
	private bool AMLBNGEFADD(in float3 NOKNCIPGLOJ, in float3 GPCLDFNJCPC, float DODLNOOJAAB, Allocator NDJJBKEIGCD, out NativeArray<Entity> NMNOLKKCICL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[JMGOLFGIKPD]
[UpdateInGroup(typeof(FENPKCJMFAI))]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
internal sealed class KNALLOHDJMD : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0x3A75160", Offset = "0x3A74560", VA = "0x183A75160", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public KNALLOHDJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[JMGOLFGIKPD]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
[UpdateInGroup(typeof(FNIMKPCEBGE))]
public sealed class FCDIOCBNAAI : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FA50", Offset = "0x3A5EE50", VA = "0x183A5FA50", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public FCDIOCBNAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[JMGOLFGIKPD]
[UpdateInGroup(typeof(MNKIBFDELDE))]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
internal sealed class GHKMJLIHMBM : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0x3A64080", Offset = "0x3A63480", VA = "0x183A64080", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public GHKMJLIHMBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class MAKNIFHDABP : PPGAFNDLJLE
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public MAKNIFHDABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[JMGOLFGIKPD]
[ExecuteAlways]
[AECGGFPDEPE(FPOGPJMGMEG.LoadInstance)]
[UpdateInGroup(typeof(KPHLIOBCLNG))]
internal sealed class OIMECIOIKJL : CPLEAJCINAE
{
	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0x3766230", Offset = "0x3765630", VA = "0x183766230", Slot = "16")]
	protected override ComponentSystemBase EGHJJGHDALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x3760F40", Offset = "0x3760340", VA = "0x183760F40")]
	public OIMECIOIKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[MKPGKAIPIEH(typeof(AuthoredLocalPoseData))]
public sealed class GLCILFIBHPG : HNDNKHJBNMP
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x3A648F0", Offset = "0x3A63CF0", VA = "0x183A648F0", Slot = "8")]
	protected override bool PJFOMDNPNKF(ReadOnlySpan<AuthoredLocalPoseData> INJMMDAENFI, NFOMLMHEAPG HHEIDBCECNG, out ReadOnlySpan<byte> LFBMPCLHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x3A64830", Offset = "0x3A63C30", VA = "0x183A64830", Slot = "9")]
	protected override bool DCFLACGFEND(int IIMAMIPIKFH, Span<AuthoredLocalPoseData> INJMMDAENFI, in ReadOnlySpan<byte> LFBMPCLHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x3A64970", Offset = "0x3A63D70", VA = "0x183A64970")]
	public GLCILFIBHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[MKPGKAIPIEH(typeof(LocalPoseData))]
public sealed class FCJGDOPNHOM : PNECJJLICLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FBF0", Offset = "0x3A5EFF0", VA = "0x183A5FBF0", Slot = "8")]
	protected override bool PJFOMDNPNKF(ReadOnlySpan<LocalPoseData> INJMMDAENFI, NFOMLMHEAPG HHEIDBCECNG, out ReadOnlySpan<byte> LFBMPCLHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FB30", Offset = "0x3A5EF30", VA = "0x183A5FB30", Slot = "9")]
	protected override bool DCFLACGFEND(int IIMAMIPIKFH, Span<LocalPoseData> INJMMDAENFI, in ReadOnlySpan<byte> LFBMPCLHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FC70", Offset = "0x3A5F070", VA = "0x183A5FC70")]
	public FCJGDOPNHOM()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Preserve]
	internal class _RRAssemblyIndex : AOMBDDGFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x38CB6A0", Offset = "0x38CAAA0", VA = "0x1838CB6A0", Slot = "6")]
		public sealed override void MOOHCJAEEBD(CDEIOGNPKKE KCKLDKHBENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x38CABD0", Offset = "0x38C9FD0", VA = "0x1838CABD0", Slot = "4")]
		public sealed override void IPAAHMOMIKO()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x37D3340", Offset = "0x37D2740", VA = "0x1837D3340")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x37D2FF0", Offset = "0x37D23F0", VA = "0x1837D2FF0")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
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
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
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
