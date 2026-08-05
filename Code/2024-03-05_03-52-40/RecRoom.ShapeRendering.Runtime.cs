using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.ClusterLODs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Logging.Attributes;
using RecRoom.ShapeRendering;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : OLOBACIMOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x693F8D0", Offset = "0x693E6D0", VA = "0x18693F8D0", Slot = "4")]
		public override void GGPDGFKFIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MAIPEALONKC : NBFGOCIPMPB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte FDKABOFKCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] FGGPPBBDFOK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DDHFELBEGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91FAE0", Offset = "0x91E8E0", VA = "0x18091FAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LLEMPACEMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A10", Offset = "0x7F7810", VA = "0x1807F8A10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F8010", Offset = "0x7F6E10", VA = "0x1807F8010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GKDAKBKAGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x97EE90", Offset = "0x97DC90", VA = "0x18097EE90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x852FC0", VA = "0x1808541C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float LEOCPLJDOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x97E9E0", Offset = "0x97D7E0", VA = "0x18097E9E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97E9C0", Offset = "0x97D7C0", VA = "0x18097E9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> HPHBLEPFMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x693F960", Offset = "0x693E760", VA = "0x18693F960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> EKLMDEAAELG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x693FD30", Offset = "0x693EB30", VA = "0x18693FD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte IOCIDDBBIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x693FEF0", Offset = "0x693ECF0", VA = "0x18693FEF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x693FF40", Offset = "0x693ED40", VA = "0x18693FF40")]
	public MAIPEALONKC(List<IOIHOFJFGOE> LMDCFGENAOO, List<IOIHOFJFGOE> AFKLEFNOFPA, List<BHIFHHDNGPJ> MLGDFMFEFKB, Material NLKDDMHEDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x693FC10", Offset = "0x693EA10", VA = "0x18693FC10")]
	private int JFHNCNFHEFL(List<IOIHOFJFGOE> LMOFJDPLHBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x693FAB0", Offset = "0x693E8B0", VA = "0x18693FAB0")]
	private void GCNEHNCNKIC(int MOHIBHEMDCK, bool OOONCECEHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x693FDA0", Offset = "0x693EBA0", VA = "0x18693FDA0")]
	public void OCOBGOCDFPI(Vector3 NEFNMBAGOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x693F9B0", Offset = "0x693E7B0", VA = "0x18693F9B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x693FD60", Offset = "0x693EB60", VA = "0x18693FD60")]
	public void KIAEICEMIKM(Transform MFBFONHDLBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IHILIPNBOOK : OILBDCJPLFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class OLGPLMGDMBL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IHILIPNBOOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x815510", Offset = "0x814310", VA = "0x180815510")]
		[DebuggerHidden]
		public OLGPLMGDMBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6944720", Offset = "0x6943520", VA = "0x186944720", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69440C0", Offset = "0x6942EC0", VA = "0x1869440C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6944020", Offset = "0x6942E20", VA = "0x186944020")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69445D0", Offset = "0x69433D0", VA = "0x1869445D0")]
		private void PDHPDAEENHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6944070", Offset = "0x6942E70", VA = "0x186944070")]
		private void HIPOIONNBKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69446D0", Offset = "0x69434D0", VA = "0x1869446D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6944620", Offset = "0x6943420", VA = "0x186944620", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6944620", Offset = "0x6943420", VA = "0x186944620", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class HMDIMFJIAHM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IHILIPNBOOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x815510", Offset = "0x814310", VA = "0x180815510")]
		[DebuggerHidden]
		public HMDIMFJIAHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6939620", Offset = "0x6938420", VA = "0x186939620", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6939160", Offset = "0x6937F60", VA = "0x186939160", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6939110", Offset = "0x6937F10", VA = "0x186939110")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69394D0", Offset = "0x69382D0", VA = "0x1869394D0")]
		private void PDHPDAEENHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x69395D0", Offset = "0x69383D0", VA = "0x1869395D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6939520", Offset = "0x6938320", VA = "0x186939520", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6939520", Offset = "0x6938320", VA = "0x186939520", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IGEKPGLEGPC CGHJDAIAFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<KPFFJIMDJON> BLGKJIIOCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> OOGPNMPGMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer CKKKDIGNHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool BNEADJFLAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool JJCNJHIBLON;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<ANBCOICGLMP> LNANGNEAHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BHAHKOEIPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x693BED0", Offset = "0x693ACD0", VA = "0x18693BED0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BHIFHHDNGPJ AIOPGFHLJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x693BD00", Offset = "0x693AB00", VA = "0x18693BD00", Slot = "8")]
		get
		{
			return default(BHIFHHDNGPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> INMEEOFCMIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BE970", Offset = "0x7BD770", VA = "0x1807BE970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x693C710", Offset = "0x693B510", VA = "0x18693C710")]
	private bool OINDHNEMLCE(KPFFJIMDJON EDLOLMEBDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x693B680", Offset = "0x693A480", VA = "0x18693B680")]
	private static bool ENBLHLEPPLK(KPFFJIMDJON EDLOLMEBDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x693CC30", Offset = "0x693BA30", VA = "0x18693CC30")]
	public IHILIPNBOOK(IGEKPGLEGPC EEDANCJJEPL, bool JCEADPOJDAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x693B500", Offset = "0x693A300", VA = "0x18693B500", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x693BA90", Offset = "0x693A890", VA = "0x18693BA90")]
	public void GALNLGNAACN(KPFFJIMDJON EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x693B910", Offset = "0x693A710", VA = "0x18693B910")]
	public void FIJOKOAGLFM(KPFFJIMDJON EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x693C730", Offset = "0x693B530", VA = "0x18693C730", Slot = "4")]
	public void OOGCAHDECCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x693BF10", Offset = "0x693AD10", VA = "0x18693BF10")]
	public void LAGHJNJIPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x693B750", Offset = "0x693A550", VA = "0x18693B750")]
	private void FEKEPGFEHLF(List<KPFFJIMDJON> BLGKJIIOCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x693BA30", Offset = "0x693A830", VA = "0x18693BA30")]
	private static Material GADIDHDNODH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x693B6A0", Offset = "0x693A4A0", VA = "0x18693B6A0")]
	private void FEKEPGFEHLF(KPFFJIMDJON EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x693BC30", Offset = "0x693AA30", VA = "0x18693BC30")]
	private void GDPBFDMBHDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x693C160", Offset = "0x693AF60", VA = "0x18693C160")]
	public void LKDJBHHHFKD(bool NGJIAJMIJNJ, bool BDLNCOPNHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x693B440", Offset = "0x693A240", VA = "0x18693B440")]
	protected void DEHNJLIJNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x693BDD0", Offset = "0x693ABD0", VA = "0x18693BDD0")]
	[IteratorStateMachine(typeof(OLGPLMGDMBL))]
	public IEnumerable<Renderer> HMDDBBEPPOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x693BE50", Offset = "0x693AC50", VA = "0x18693BE50")]
	[IteratorStateMachine(typeof(HMDIMFJIAHM))]
	public IEnumerable<Renderer> IEOCHCLDCKD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class IGNNFMAADCF : KPFFJIMDJON
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct FCDJCCAAFNA : ABCABMPBMEF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MGPLABDHAAM HCHDFAPIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle PHIMPJOOHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MJAAIIDBHAM OCEDIIFPAPA;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x69337B0", Offset = "0x69325B0", VA = "0x1869337B0")]
		public FCDJCCAAFNA(MGPLABDHAAM HCHDFAPIGCD, JobHandle PHIMPJOOHAK, MJAAIIDBHAM OCEDIIFPAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6933780", Offset = "0x6932580", VA = "0x186933780", Slot = "4")]
		public MGPLABDHAAM HOEPGDMFNPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6933730", Offset = "0x6932530", VA = "0x186933730", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MIFIBPJAGCO FGMJODPFBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float AOPNPNMGICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 JHNEIBMDBPD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 GEAFLJJKCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x693B260", Offset = "0x693A060", VA = "0x18693B260", Slot = "23")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x693B390", Offset = "0x693A190", VA = "0x18693B390")]
	public IGNNFMAADCF(IHILIPNBOOK GOKLEGFJHEB, MIFIBPJAGCO EEDANCJJEPL, bool JCEADPOJDAK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "16")]
	public override bool ECHIILLJNHI(BHIFHHDNGPJ GOKLEGFJHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x693A050", Offset = "0x6938E50", VA = "0x18693A050", Slot = "18")]
	public override int JFHNCNFHEFL(LKHLODFBHNK FBJIHPHAKKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6939E80", Offset = "0x6938C80", VA = "0x186939E80", Slot = "19")]
	public override int DBCLBIONAIB(LKHLODFBHNK FBJIHPHAKKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6939750", Offset = "0x6938550", VA = "0x186939750", Slot = "20")]
	public override Bounds AABFFGMDMJB()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x693AB40", Offset = "0x6939940", VA = "0x18693AB40", Slot = "21")]
	public override void MIEEPGFAHAN(LKHLODFBHNK FBJIHPHAKKE, AGIBOIPDIEB MHIFCIEBDFO, int HMKMJMBAOGM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6939DB0", Offset = "0x6938BB0", VA = "0x186939DB0", Slot = "22")]
	public override BHIFHHDNGPJ BCPCDIECLKI()
	{
		return default(BHIFHHDNGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6939C00", Offset = "0x6938A00", VA = "0x186939C00", Slot = "24")]
	public override EIMODFBDHPI BCBAIMCMFGO()
	{
		return default(EIMODFBDHPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x693A220", Offset = "0x6939020", VA = "0x18693A220", Slot = "25")]
	public override ABCABMPBMEF KGJHKFBJBGD(LKHLODFBHNK FBJIHPHAKKE, JobHandle PHIMPJOOHAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface LHHDFELDFKC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IHILIPNBOOK GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KPFFJIMDJON GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MIBMJCGLHOB GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class FKHJJHPMEMI : MJCILEDACOD, IDisposable, LHHDFELDFKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LCLPAPGMFDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FKHJJHPMEMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x693F280", Offset = "0x693E080", VA = "0x18693F280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x693F7A0", Offset = "0x693E5A0", VA = "0x18693F7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly DFCJMEFCGMN<KBPABMBACKE, IHILIPNBOOK> LKNAJAOOJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly DFCJMEFCGMN<FJKBOHLDEOH, KPFFJIMDJON> BLGKJIIOCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly DFCJMEFCGMN<IIMAGJGLOFK, MIBMJCGLHOB> CFAJGFGGDFD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IHILIPNBOOK GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x69346B0", Offset = "0x69334B0", VA = "0x1869346B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public KPFFJIMDJON GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6934650", Offset = "0x6933450", VA = "0x186934650", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MIBMJCGLHOB GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69345F0", Offset = "0x69333F0", VA = "0x1869345F0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool KPCFDHKLADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8E0F00", Offset = "0x8DFD00", VA = "0x1808E0F00", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B9090", Offset = "0x9B7E90", VA = "0x1809B9090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6935920", Offset = "0x6934720", VA = "0x186935920")]
	public FKHJJHPMEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6934000", Offset = "0x6932E00", VA = "0x186934000", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6933D70", Offset = "0x6932B70", VA = "0x186933D70", Slot = "4")]
	public KBPABMBACKE DDAHBMHFJDD(IGEKPGLEGPC EEDANCJJEPL)
	{
		return default(KBPABMBACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6933D80", Offset = "0x6932B80", VA = "0x186933D80", Slot = "5")]
	public KBPABMBACKE DDAHBMHFJDD(IGEKPGLEGPC EEDANCJJEPL, bool JCEADPOJDAK)
	{
		return default(KBPABMBACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69348B0", Offset = "0x69336B0", VA = "0x1869348B0", Slot = "6")]
	public void MCDOCOFDAIA(KBPABMBACKE GOKLEGFJHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6934220", Offset = "0x6933020", VA = "0x186934220", Slot = "7")]
	public void GIJCLGMCNKM(KBPABMBACKE GOKLEGFJHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6933890", Offset = "0x6932690", VA = "0x186933890", Slot = "8")]
	public FJKBOHLDEOH CDGGMPBLIGG(KBPABMBACKE GOKLEGFJHEB, JOCDHEHPMHH EEDANCJJEPL)
	{
		return default(FJKBOHLDEOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6935440", Offset = "0x6934240", VA = "0x186935440", Slot = "9")]
	public FJKBOHLDEOH PGCAHPCBHAP(KBPABMBACKE GOKLEGFJHEB, MIFIBPJAGCO EEDANCJJEPL)
	{
		return default(FJKBOHLDEOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6935080", Offset = "0x6933E80", VA = "0x186935080", Slot = "11")]
	public void PCDGPGFAOAK(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6934E20", Offset = "0x6933C20", VA = "0x186934E20", Slot = "10")]
	public void OGKOAMLBGJN(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6934580", Offset = "0x6933380", VA = "0x186934580", Slot = "20")]
	public IEnumerable<Renderer> HHMJKFFBCGB(KBPABMBACKE GOKLEGFJHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6933810", Offset = "0x6932610", VA = "0x186933810", Slot = "12")]
	public IIMAGJGLOFK CAIBFJCHLOD(ELHKKMMANGJ EEDANCJJEPL)
	{
		return default(IIMAGJGLOFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69347E0", Offset = "0x69335E0", VA = "0x1869347E0", Slot = "14")]
	public void JJBOBCHBGPD(IIMAGJGLOFK DIECHNCAFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6934C90", Offset = "0x6933A90", VA = "0x186934C90", Slot = "16")]
	public Task NEJCEKDJENM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6934B10", Offset = "0x6933910", VA = "0x186934B10", Slot = "17")]
	public Task MPNCGPNPLDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6934710", Offset = "0x6933510", VA = "0x186934710", Slot = "18")]
	[AsyncStateMachine(typeof(LCLPAPGMFDJ))]
	public Task IFDAKKIOEJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6934190", Offset = "0x6932F90", VA = "0x186934190", Slot = "19")]
	public void FEMGEHNGEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6934850", Offset = "0x6933650", VA = "0x186934850", Slot = "13")]
	public void LHAOGEOEDGD(IIMAGJGLOFK DIECHNCAFKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class GKEHKGMONCL : KPFFJIMDJON
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct LGPMHILMBNO : ABCABMPBMEF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private MGPLABDHAAM HCHDFAPIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle PHIMPJOOHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LCOJPKNLEMO OCEDIIFPAPA;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x693F880", Offset = "0x693E680", VA = "0x18693F880")]
		public LGPMHILMBNO(MGPLABDHAAM HCHDFAPIGCD, JobHandle PHIMPJOOHAK, LCOJPKNLEMO OCEDIIFPAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x693F850", Offset = "0x693E650", VA = "0x18693F850", Slot = "4")]
		public MGPLABDHAAM HOEPGDMFNPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x693F800", Offset = "0x693E600", VA = "0x18693F800", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly JOCDHEHPMHH LBOALCIJNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] NBKKMOGMGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 JHNEIBMDBPD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override DBBFKOLNKJN MBPGOFBBJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6937730", Offset = "0x6936530", VA = "0x186937730", Slot = "17")]
		get
		{
			return default(DBBFKOLNKJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private Vector3 MCNPNIMBGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69383D0", Offset = "0x69371D0", VA = "0x1869383D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	protected override Hash128 GEAFLJJKCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6938EE0", Offset = "0x6937CE0", VA = "0x186938EE0", Slot = "23")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6939010", Offset = "0x6937E10", VA = "0x186939010")]
	public GKEHKGMONCL(IHILIPNBOOK GOKLEGFJHEB, JOCDHEHPMHH EEDANCJJEPL, bool FNEPBOLKDCK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6937030", Offset = "0x6935E30", VA = "0x186937030", Slot = "16")]
	public override bool ECHIILLJNHI(BHIFHHDNGPJ GOKLEGFJHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6937AF0", Offset = "0x69368F0", VA = "0x186937AF0", Slot = "18")]
	public override int JFHNCNFHEFL(LKHLODFBHNK FBJIHPHAKKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6936F90", Offset = "0x6935D90", VA = "0x186936F90", Slot = "19")]
	public override int DBCLBIONAIB(LKHLODFBHNK FBJIHPHAKKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6936C90", Offset = "0x6935A90", VA = "0x186936C90", Slot = "20")]
	public override Bounds AABFFGMDMJB()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x69374C0", Offset = "0x69362C0", VA = "0x1869374C0")]
	private int EPBFCHPOOLJ(LKHLODFBHNK FBJIHPHAKKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6938750", Offset = "0x6937550", VA = "0x186938750", Slot = "21")]
	public override void MIEEPGFAHAN(LKHLODFBHNK FBJIHPHAKKE, AGIBOIPDIEB MHIFCIEBDFO, int HMKMJMBAOGM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6936EC0", Offset = "0x6935CC0", VA = "0x186936EC0", Slot = "22")]
	public override BHIFHHDNGPJ BCPCDIECLKI()
	{
		return default(BHIFHHDNGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6936D10", Offset = "0x6935B10", VA = "0x186936D10", Slot = "24")]
	public override EIMODFBDHPI BCBAIMCMFGO()
	{
		return default(EIMODFBDHPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6937B90", Offset = "0x6936990", VA = "0x186937B90", Slot = "25")]
	public override ABCABMPBMEF KGJHKFBJBGD(LKHLODFBHNK FBJIHPHAKKE, JobHandle PHIMPJOOHAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FMJGBKPDFDL
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKKLHFIIMOO(EEDFDLJFDEM LPFFKBBBCBL, Renderer FNMHNENOEME, int EEGKMLOGJJG);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJNJKKDPCIE(Renderer FNMHNENOEME, DLHLPIDNGID APOIDBPNGNC, Vector3 KEDMIBEMIII, Vector3 GIOONJIPEPF, Vector3 GNMBJFHEEBI, float GJLFHMELDAB, float AKOIFHJPBCO, float KPHAPCLJKPN = -1f, [Optional] Color? DNOKCMICDIP, [Optional] IReadOnlyList<Camera> PKOFOPGEEPJ);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGEGDINFHDI(Renderer FNMHNENOEME, int EEGKMLOGJJG);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HMHBIGHOBFK();

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPFMGCPIJEB(int BLOLKFNELIJ, DPIIANELJKL LPFFKBBBCBL, Renderer FNMHNENOEME, int EEGKMLOGJJG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NCHGDOKLOGE : EGMOECHFJNJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class HDJADNKAHIK : KPMFCBKJELL<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69390C0", Offset = "0x6937EC0", VA = "0x1869390C0")]
		public HDJADNKAHIK(string OCCHBLONHPL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FMJGBKPDFDL HMAPFIALJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LHHDFELDFKC DFAOHFGCCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer GHOHIBPDFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private HDJADNKAHIK HAJIAGBBICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool JAPCLEPADGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer GHBHBOECKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private HDJADNKAHIK EMKFAJPHLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool CDMFABAJHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer ILHGLLAKAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private HDJADNKAHIK OPEJPNCFNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool LCJPAJJKEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool OFJKLDDBIOI;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6440", Offset = "0x7C5240", VA = "0x1807C6440")]
	public NCHGDOKLOGE(FMJGBKPDFDL PKHJDGEODIL, LHHDFELDFKC DFAOHFGCCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6941AE0", Offset = "0x69408E0", VA = "0x186941AE0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x69416E0", Offset = "0x69404E0", VA = "0x1869416E0")]
	private void AENAIMMDFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6942EE0", Offset = "0x6941CE0", VA = "0x186942EE0", Slot = "4")]
	public void NMOGHJFJGLL(KBPABMBACKE GOKLEGFJHEB, DPIIANELJKL KJMILHHGBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x69431E0", Offset = "0x6941FE0", VA = "0x1869431E0", Slot = "5")]
	public void NMOGHJFJGLL(FJKBOHLDEOH EDLOLMEBDKG, DPIIANELJKL KJMILHHGBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6941C90", Offset = "0x6940A90", VA = "0x186941C90", Slot = "6")]
	public void FGCAEACNJEG(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6942A60", Offset = "0x6941860", VA = "0x186942A60", Slot = "7")]
	public void JMFMFGPNMDM(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6942630", Offset = "0x6941430", VA = "0x186942630", Slot = "24")]
	public void GGCNANCDPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9357B0", Offset = "0x9345B0", VA = "0x1809357B0", Slot = "8")]
	public void COIMAAAMOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6943CF0", Offset = "0x6942AF0", VA = "0x186943CF0", Slot = "9")]
	public void PCJPMNGGAHN(DPIIANELJKL KJMILHHGBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x69434A0", Offset = "0x69422A0", VA = "0x1869434A0", Slot = "10")]
	public void OLHKDJPOGFM(KBPABMBACKE GOKLEGFJHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6943780", Offset = "0x6942580", VA = "0x186943780", Slot = "11")]
	public void OLHKDJPOGFM(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6943400", Offset = "0x6942200", VA = "0x186943400", Slot = "12")]
	public void OKBEJELIBCD(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6942E50", Offset = "0x6941C50", VA = "0x186942E50", Slot = "13")]
	public void KJGIDBFGFEK(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6943AB0", Offset = "0x69428B0", VA = "0x186943AB0")]
	private void OLLIKNMHOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x108A110", Offset = "0x1088F10", VA = "0x18108A110", Slot = "14")]
	public void DDAGOHPNONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6942940", Offset = "0x6941740", VA = "0x186942940", Slot = "15")]
	public void JANBHEMKAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6942670", Offset = "0x6941470", VA = "0x186942670", Slot = "16")]
	public void IEMIDMLPKCA(KBPABMBACKE GOKLEGFJHEB, EEDFDLJFDEM LPFFKBBBCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6942B70", Offset = "0x6941970", VA = "0x186942B70", Slot = "17")]
	public void KBPFCDOMHKN(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6941A50", Offset = "0x6940850", VA = "0x186941A50", Slot = "18")]
	public void CJOILDNEEIM(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8EA790", Offset = "0x8E9590", VA = "0x1808EA790", Slot = "19")]
	public void MMNFGLLAEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6941920", Offset = "0x6940720", VA = "0x186941920", Slot = "20")]
	public void ALLMHJFHNEN(EEDFDLJFDEM LPFFKBBBCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6942C10", Offset = "0x6941A10", VA = "0x186942C10")]
	private void KENEJHAEAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6942260", Offset = "0x6941060", VA = "0x186942260", Slot = "21")]
	public void GFBLLNHCJDL(KBPABMBACKE GOKLEGFJHEB, Vector3 KEDMIBEMIII, Vector3 GIOONJIPEPF, Vector3 GNMBJFHEEBI, float GJLFHMELDAB, float AKOIFHJPBCO, IReadOnlyList<Camera> FPMGHAGMLNL, DLHLPIDNGID APOIDBPNGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6941DC0", Offset = "0x6940BC0", VA = "0x186941DC0", Slot = "22")]
	public void GFBLLNHCJDL(IIMAGJGLOFK DIECHNCAFKA, Vector3 KEDMIBEMIII, Vector3 GIOONJIPEPF, Vector3 GNMBJFHEEBI, float GJLFHMELDAB, float AKOIFHJPBCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KPFFJIMDJON : CCOOAFICFDN, ANBCOICGLMP, JLNKKJGOOFJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly IHILIPNBOOK IJIEPIJIKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds BGMBAHNGOGA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Bounds FENGACOOJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xE93260", Offset = "0xE92060", VA = "0x180E93260", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public virtual DBBFKOLNKJN MBPGOFBBJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x693EFF0", Offset = "0x693DDF0", VA = "0x18693EFF0", Slot = "17")]
		get
		{
			return default(DBBFKOLNKJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JJCNJHIBLON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x864240", Offset = "0x863040", VA = "0x180864240")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x91FAF0", Offset = "0x91E8F0", VA = "0x18091FAF0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	protected abstract Hash128 GEAFLJJKCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int ODPBDBEENJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x85D750", Offset = "0x85C550", VA = "0x18085D750", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public EDKIIFNJLJO HGKIGPMHGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BE970", Offset = "0x7BD770", VA = "0x1807BE970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool ADNPDLIAGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1245C20", Offset = "0x1244A20", VA = "0x181245C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	protected KPFFJIMDJON(IHILIPNBOOK GOKLEGFJHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x693EE60", Offset = "0x693DC60", VA = "0x18693EE60", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "16")]
	public virtual bool ECHIILLJNHI(BHIFHHDNGPJ GOKLEGFJHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int JFHNCNFHEFL(LKHLODFBHNK FBJIHPHAKKE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int DBCLBIONAIB(LKHLODFBHNK FBJIHPHAKKE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract Bounds AABFFGMDMJB();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract void MIEEPGFAHAN(LKHLODFBHNK FBJIHPHAKKE, AGIBOIPDIEB MHIFCIEBDFO, int HMKMJMBAOGM = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract BHIFHHDNGPJ BCPCDIECLKI();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x693EF90", Offset = "0x693DD90", VA = "0x18693EF90", Slot = "11")]
	public Hash128 EMOKKMFIMOK(int FBJIHPHAKKE)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract EIMODFBDHPI BCBAIMCMFGO();

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract ABCABMPBMEF KGJHKFBJBGD(LKHLODFBHNK FBJIHPHAKKE, JobHandle PHIMPJOOHAK);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x693EFC0", Offset = "0x693DDC0", VA = "0x18693EFC0", Slot = "10")]
	public ABCABMPBMEF FBDHBCJHPGK(int FBJIHPHAKKE)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6944D40", Offset = "0x6943B40", VA = "0x186944D40")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IKOIFIBDLNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NNDIGDGJDIB : IEnumerable<EDPJNOIOHNJ>, IEnumerable, IEnumerator<EDPJNOIOHNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private EDPJNOIOHNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private EDPJNOIOHNJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x815510", Offset = "0x814310", VA = "0x180815510")]
		[DebuggerHidden]
		public NNDIGDGJDIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6943E60", Offset = "0x6942C60", VA = "0x186943E60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6943FD0", Offset = "0x6942DD0", VA = "0x186943FD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6943F30", Offset = "0x6942D30", VA = "0x186943F30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EDPJNOIOHNJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6943F30", Offset = "0x6942D30", VA = "0x186943F30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static EDPJNOIOHNJ[][] PCAODEHEGPE;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static HBIPFJMKGHM BFPJHFFNLON;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static ShapeRendererConfig BJGKNPKIPAG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ComputeShader GJDIICGAIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x693D6C0", Offset = "0x693C4C0", VA = "0x18693D6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static SkinnedShapeRenderer EDAENJFMKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x693CEA0", Offset = "0x693BCA0", VA = "0x18693CEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x693D720", Offset = "0x693C520", VA = "0x18693D720")]
	public static Mesh OIEADOAKBHK(NNJHPHDLDHL GFHMPFHFHLD, int FBJIHPHAKKE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x693D2E0", Offset = "0x693C0E0", VA = "0x18693D2E0")]
	public static int MGDLPICHPHD(NNJHPHDLDHL GFHMPFHFHLD, int FBJIHPHAKKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x693CD30", Offset = "0x693BB30", VA = "0x18693CD30")]
	public static HBIPFJMKGHM AIPELEOMDOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x693CF00", Offset = "0x693BD00", VA = "0x18693CF00")]
	[IteratorStateMachine(typeof(NNDIGDGJDIB))]
	private static IEnumerable<EDPJNOIOHNJ> DDJDKBOIJCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x693D7C0", Offset = "0x693C5C0", VA = "0x18693D7C0")]
	public static EDPJNOIOHNJ PIANBLGPPPK(NNJHPHDLDHL GFHMPFHFHLD, int FBJIHPHAKKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x693CE80", Offset = "0x693BC80", VA = "0x18693CE80")]
	public static bool BJPIIFNBDIG(this NNJHPHDLDHL GFHMPFHFHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x693D130", Offset = "0x693BF30", VA = "0x18693D130")]
	public static void GACKDJKMLFF(NNJHPHDLDHL GFHMPFHFHLD, float3 LJMPJCHBFEM, [Out] JKEPHBBOAEI KFJLDMFHIDK, [Out] float3 ICFDKCFOPML, [Out] float MHOMABNKDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x693D2F0", Offset = "0x693C0F0", VA = "0x18693D2F0")]
	public static void MHJLJLPBHBN(Vector3 LJMPJCHBFEM, NNJHPHDLDHL GFHMPFHFHLD, [Out] Vector3 ICFDKCFOPML, [Out] float MHOMABNKDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x693CD20", Offset = "0x693BB20", VA = "0x18693CD20")]
	[DMMECPONHDJ(JLBMAGLFPON.ExitingPlayMode, 0)]
	[EGFNIGLMFPM(0)]
	private static void ADOFGMIDGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x693CF60", Offset = "0x693BD60", VA = "0x18693CF60")]
	[EGFNIGLMFPM(0)]
	[DMMECPONHDJ(JLBMAGLFPON.ExitingPlayMode, 0)]
	private static void EMDJFLIKMJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class GHHNDFANPGN : MJCILEDACOD, IDisposable, LHHDFELDFKC
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly IIFCCHIKGII KOLDIMNADKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly DFCJMEFCGMN<KBPABMBACKE, IHILIPNBOOK> LKNAJAOOJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly DFCJMEFCGMN<FJKBOHLDEOH, KPFFJIMDJON> BLGKJIIOCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly DFCJMEFCGMN<IIMAGJGLOFK, MIBMJCGLHOB> CFAJGFGGDFD;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IHILIPNBOOK GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6936270", Offset = "0x6935070", VA = "0x186936270", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public KPFFJIMDJON GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6936210", Offset = "0x6935010", VA = "0x186936210", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public MIBMJCGLHOB GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x69361B0", Offset = "0x6934FB0", VA = "0x1869361B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KPCFDHKLADP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8E0F00", Offset = "0x8DFD00", VA = "0x1808E0F00", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9B9090", Offset = "0x9B7E90", VA = "0x1809B9090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x69368A0", Offset = "0x69356A0", VA = "0x1869368A0")]
	public GHHNDFANPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6936030", Offset = "0x6934E30", VA = "0x186936030", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6935F90", Offset = "0x6934D90", VA = "0x186935F90", Slot = "4")]
	public KBPABMBACKE DDAHBMHFJDD(IGEKPGLEGPC EEDANCJJEPL)
	{
		return default(KBPABMBACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6935F90", Offset = "0x6934D90", VA = "0x186935F90", Slot = "5")]
	public KBPABMBACKE DDAHBMHFJDD(IGEKPGLEGPC EEDANCJJEPL, bool JCEADPOJDAK)
	{
		return default(KBPABMBACKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6936440", Offset = "0x6935240", VA = "0x186936440", Slot = "6")]
	public void MCDOCOFDAIA(KBPABMBACKE GOKLEGFJHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69360C0", Offset = "0x6934EC0", VA = "0x1869360C0", Slot = "7")]
	public void GIJCLGMCNKM(KBPABMBACKE GOKLEGFJHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6935E50", Offset = "0x6934C50", VA = "0x186935E50", Slot = "8")]
	public FJKBOHLDEOH CDGGMPBLIGG(KBPABMBACKE GOKLEGFJHEB, JOCDHEHPMHH EEDANCJJEPL)
	{
		return default(FJKBOHLDEOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x69366D0", Offset = "0x69354D0", VA = "0x1869366D0", Slot = "9")]
	public FJKBOHLDEOH PGCAHPCBHAP(KBPABMBACKE GOKLEGFJHEB, MIFIBPJAGCO EEDANCJJEPL)
	{
		return default(FJKBOHLDEOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6936640", Offset = "0x6935440", VA = "0x186936640", Slot = "11")]
	public void PCDGPGFAOAK(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x69365E0", Offset = "0x69353E0", VA = "0x1869365E0", Slot = "10")]
	public void OGKOAMLBGJN(FJKBOHLDEOH EDLOLMEBDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6936140", Offset = "0x6934F40", VA = "0x186936140", Slot = "20")]
	public IEnumerable<Renderer> HHMJKFFBCGB(KBPABMBACKE GOKLEGFJHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6935DD0", Offset = "0x6934BD0", VA = "0x186935DD0", Slot = "12")]
	public IIMAGJGLOFK CAIBFJCHLOD(ELHKKMMANGJ EEDANCJJEPL)
	{
		return default(IIMAGJGLOFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6936370", Offset = "0x6935170", VA = "0x186936370", Slot = "14")]
	public void JJBOBCHBGPD(IIMAGJGLOFK DIECHNCAFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6936540", Offset = "0x6935340", VA = "0x186936540", Slot = "16")]
	public Task NEJCEKDJENM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x69364A0", Offset = "0x69352A0", VA = "0x1869364A0", Slot = "17")]
	public Task MPNCGPNPLDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x69362D0", Offset = "0x69350D0", VA = "0x1869362D0", Slot = "18")]
	public Task IFDAKKIOEJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1CD1010", Offset = "0x1CCFE10", VA = "0x181CD1010", Slot = "19")]
	public void FEMGEHNGEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x69363E0", Offset = "0x69351E0", VA = "0x1869363E0", Slot = "13")]
	public void LHAOGEOEDGD(IIMAGJGLOFK DIECHNCAFKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EHHPBOHOLIE
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HOAGFNDMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material LPPBHOJKDFD();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material GADIDHDNODH();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material HCENOHPPMNE();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FPCGCLJPFBM(JLAJJDNMAMO OKMNGLHIBCE);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DCFBJFIPIEM(FLBMFJMEEOH KBNBJCIIODO);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMPDINNJPBK(GameObject KDHDNCADFDJ);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FJHKDDNIKNF(GameObject KDHDNCADFDJ, bool HCIKOKCCHNK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class ONKGHLJDHEE
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static EHHPBOHOLIE EJHNGBHNBFP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool HOAGFNDMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69449E0", Offset = "0x69437E0", VA = "0x1869449E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6944910", Offset = "0x6943710", VA = "0x186944910")]
	public static void BKFGNNDKKOP(EHHPBOHOLIE PDKAIJCODHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6944CE0", Offset = "0x6943AE0", VA = "0x186944CE0")]
	public static Material LPPBHOJKDFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x693BA30", Offset = "0x693A830", VA = "0x18693BA30")]
	public static Material GADIDHDNODH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6944BA0", Offset = "0x69439A0", VA = "0x186944BA0")]
	public static Material HCENOHPPMNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6944B30", Offset = "0x6943930", VA = "0x186944B30")]
	public static int FPCGCLJPFBM(JLAJJDNMAMO OKMNGLHIBCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6944970", Offset = "0x6943770", VA = "0x186944970")]
	public static int DCFBJFIPIEM(FLBMFJMEEOH KBNBJCIIODO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6944C00", Offset = "0x6943A00", VA = "0x186944C00")]
	public static void JMPDINNJPBK(GameObject KDHDNCADFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6944A40", Offset = "0x6943840", VA = "0x186944A40")]
	public static void FJHKDDNIKNF(GameObject KDHDNCADFDJ, bool HCIKOKCCHNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MIBMJCGLHOB : OILBDCJPLFF
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class ELNMGMHFCPE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public MIBMJCGLHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x815510", Offset = "0x814310", VA = "0x180815510")]
		[DebuggerHidden]
		public ELNMGMHFCPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x69336A0", Offset = "0x69324A0", VA = "0x1869336A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6933380", Offset = "0x6932180", VA = "0x186933380", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6933330", Offset = "0x6932130", VA = "0x186933330")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6933650", Offset = "0x6932450", VA = "0x186933650", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x69335A0", Offset = "0x69323A0", VA = "0x1869335A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x69335A0", Offset = "0x69323A0", VA = "0x1869335A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly ELHKKMMANGJ AAGCOHBFNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly LHHDFELDFKC DFAOHFGCCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private MAIPEALONKC BAEEHKIGNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<IOIHOFJFGOE> CJHHKBPMFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private List<IOIHOFJFGOE> HPNLOKAMNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GameObject LNOJIFFLHPN;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6940250", Offset = "0x693F050", VA = "0x186940250")]
	public static MIBMJCGLHOB BPIAEOIOAIN(ELHKKMMANGJ EEDANCJJEPL, LHHDFELDFKC DFAOHFGCCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6941600", Offset = "0x6940400", VA = "0x186941600")]
	private MIBMJCGLHOB(ELHKKMMANGJ EEDANCJJEPL, LHHDFELDFKC DFAOHFGCCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x69406A0", Offset = "0x693F4A0", VA = "0x1869406A0")]
	public void NCJLPOJPDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x69403D0", Offset = "0x693F1D0", VA = "0x1869403D0")]
	[IteratorStateMachine(typeof(ELNMGMHFCPE))]
	public IEnumerable<Renderer> HMDDBBEPPOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6940B30", Offset = "0x693F930", VA = "0x186940B30", Slot = "4")]
	public void OOGCAHDECCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x69403A0", Offset = "0x693F1A0", VA = "0x1869403A0")]
	private void CMNFPLPAJMP(Vector3 NEFNMBAGOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6940450", Offset = "0x693F250", VA = "0x186940450")]
	public void LAGHJNJIPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IOIHOFJFGOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct PDFAOINMKGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AGIBOIPDIEB BNGEKNAKEJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public BHIFHHDNGPJ CNBDJENEGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int NJLGGMJAFPK;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LAAOHPJJFCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public IOIHOFJFGOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LKHLODFBHNK lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<PDFAOINMKGH> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public MGPLABDHAAM combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public LAAOHPJJFCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x693F220", Offset = "0x693E020", VA = "0x18693F220")]
		internal JobHandle PGMNNJIKNNC()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x693F080", Offset = "0x693DE80", VA = "0x18693F080")]
		internal void DLBEFDMHBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x693F0B0", Offset = "0x693DEB0", VA = "0x18693F0B0")]
		internal void GAKNNLHLEDL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int[] IMFDKPGLIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private DBIPBMMIELF CKHFIFEHIGK;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Matrix4x4 ACJGOAFJPMC;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh NAEHHPHLDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int GEHBAEEJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB30", Offset = "0x7BE930", VA = "0x1807BFB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7C24C0", Offset = "0x7C12C0", VA = "0x1807C24C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x693E5C0", Offset = "0x693D3C0", VA = "0x18693E5C0")]
	public void LLODNDOECHJ(List<BHIFHHDNGPJ> DOEPMDADEGI, Matrix4x4[] AHKKEJIGECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x693DBC0", Offset = "0x693C9C0", VA = "0x18693DBC0")]
	public static List<IOIHOFJFGOE> KNBFKAAGFFE(List<IHILIPNBOOK> EOHCBCGJNBK, LKHLODFBHNK FBJIHPHAKKE, Bounds FDKGJFKELIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x693E250", Offset = "0x693D050", VA = "0x18693E250")]
	private JobHandle LLELCCNCGFJ(MGPLABDHAAM BNNHONNCLIP, int MCFPLAICKOP, int LHBKINCEPEH, LKHLODFBHNK FBJIHPHAKKE, List<PDFAOINMKGH> KPFCCAOBPHH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x693E7B0", Offset = "0x693D5B0", VA = "0x18693E7B0")]
	private void MEHBIOIFGFP(List<PDFAOINMKGH> KPFCCAOBPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x693EA30", Offset = "0x693D830", VA = "0x18693EA30")]
	private IOIHOFJFGOE(List<PDFAOINMKGH> KPFCCAOBPHH, int MCFPLAICKOP, int LHBKINCEPEH, LKHLODFBHNK FBJIHPHAKKE, Bounds FDKGJFKELIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x693DB20", Offset = "0x693C920", VA = "0x18693DB20", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private MaterialPropertyBlock JALJCFDKBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IOIHOFJFGOE HCHDFAPIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private List<BHIFHHDNGPJ> MLGDFMFEFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private RenderTexture BIICBIKCAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeBuffer FJJJAIGCDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ComputeShader CGPDPLNGCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Matrix4x4[] KNEFNODIMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int COAPDIJEJMK;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public MeshRenderer OENMNIIDDKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F50", Offset = "0x7B7D50", VA = "0x1807B8F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int BAKGGOCAJKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x6945A40", Offset = "0x6944840", VA = "0x186945A40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6944D70", Offset = "0x6943B70", VA = "0x186944D70")]
		public static List<SkinnedShapeRenderer> Create(GameObject GOKLEGFJHEB, List<IOIHOFJFGOE> LMOFJDPLHBB, List<BHIFHHDNGPJ> MLGDFMFEFKB, Material NLKDDMHEDOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6945000", Offset = "0x6943E00", VA = "0x186945000")]
		public void Init(IOIHOFJFGOE HCHDFAPIGCD, List<BHIFHHDNGPJ> MLGDFMFEFKB, Material NLKDDMHEDOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x69459A0", Offset = "0x69447A0", VA = "0x1869459A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6945900", Offset = "0x6944700", VA = "0x186945900")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x69458C0", Offset = "0x69446C0", VA = "0x1869458C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6945490", Offset = "0x6944290", VA = "0x186945490")]
		private void JBHKLGPNBGM(ScriptableRenderContext KMABAKEMFMI, Camera[] ACEPFOLKGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6945550", Offset = "0x6944350", VA = "0x186945550")]
		private void LLODNDOECHJ(CommandBuffer BHOCKOPMBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public SkinnedShapeRenderer()
		{
		}
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
