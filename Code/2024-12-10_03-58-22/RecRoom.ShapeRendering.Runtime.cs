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
using RecRoom.Configs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Foundation.Mathematics;
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
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7604580", Offset = "0x7603180", VA = "0x187604580", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PLALEMDECHJ : HKMECPMNLJN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte DDHCEIGGEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] CKPJNCPMEHC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PJGJLDECMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x921740", Offset = "0x920340", VA = "0x180921740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HLLKPPDFEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DC0", Offset = "0x8C79C0", VA = "0x1808C8DC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C8970", Offset = "0x8C7570", VA = "0x1808C8970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float NKEFLHJAFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x91A540", Offset = "0x919140", VA = "0x18091A540", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB9ABC0", Offset = "0xB997C0", VA = "0x180B9ABC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float GIOHLKDLNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x91A530", Offset = "0x919130", VA = "0x18091A530", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE96860", Offset = "0xE95460", VA = "0x180E96860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> PPNJACNEKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7608D60", Offset = "0x7607960", VA = "0x187608D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> NKOIKFOKIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7608E00", Offset = "0x7607A00", VA = "0x187608E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject JAFALLCEFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8866E0", VA = "0x180887AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte CCJGAGABMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7608DB0", Offset = "0x76079B0", VA = "0x187608DB0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76090E0", Offset = "0x7607CE0", VA = "0x1876090E0")]
	public PLALEMDECHJ(List<DCLFBJABLFP> BEKCFFABNEN, List<DCLFBJABLFP> MCIBCHNOIKC, List<FJFKEFAPLLG> IOMCJDOMECE, Material OFCNJEFMNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7608B00", Offset = "0x7607700", VA = "0x187608B00")]
	private int AKGCKBINIKI(List<DCLFBJABLFP> OOAIDKILIOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7608E30", Offset = "0x7607A30", VA = "0x187608E30")]
	private void IMCIBLNBGBK(int IDNODJDMLPP, bool ACJNCMDHMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7608F90", Offset = "0x7607B90", VA = "0x187608F90")]
	public void IMEDHPPEJBD(Vector3 NLHOLJAFCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7608C20", Offset = "0x7607820", VA = "0x187608C20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7608D20", Offset = "0x7607920", VA = "0x187608D20")]
	public void FCBIAIEAJEE(Transform HIFNPFPJHFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DIGLPKIHEGL : BDLHDHMOENH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class ANMAFCIGMAA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DIGLPKIHEGL <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E1390", Offset = "0x8DFF90", VA = "0x1808E1390")]
		[DebuggerHidden]
		public ANMAFCIGMAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x75F81B0", Offset = "0x75F6DB0", VA = "0x1875F81B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x75F7BA0", Offset = "0x75F67A0", VA = "0x1875F7BA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x75F7B00", Offset = "0x75F6700", VA = "0x1875F7B00")]
		private void GOOHPDHLOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75F7AB0", Offset = "0x75F66B0", VA = "0x1875F7AB0")]
		private void BLMKNMDJMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x75F7B50", Offset = "0x75F6750", VA = "0x1875F7B50")]
		private void KIKCCFDMDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75F8160", Offset = "0x75F6D60", VA = "0x1875F8160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75F80B0", Offset = "0x75F6CB0", VA = "0x1875F80B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x75F80B0", Offset = "0x75F6CB0", VA = "0x1875F80B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class IEAOPHMIPIF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DIGLPKIHEGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8E1390", Offset = "0x8DFF90", VA = "0x1808E1390")]
		[DebuggerHidden]
		public IEAOPHMIPIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76033E0", Offset = "0x7601FE0", VA = "0x1876033E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7602F70", Offset = "0x7601B70", VA = "0x187602F70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7602F20", Offset = "0x7601B20", VA = "0x187602F20")]
		private void GOOHPDHLOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7602ED0", Offset = "0x7601AD0", VA = "0x187602ED0")]
		private void BLMKNMDJMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7603390", Offset = "0x7601F90", VA = "0x187603390", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x76032E0", Offset = "0x7601EE0", VA = "0x1876032E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x76032E0", Offset = "0x7601EE0", VA = "0x1876032E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly PLEFNFBHPPD PJJJPLDPJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<IBMFCJNKKBI> KHENFJHOLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> LACFGGDEADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer BIIOBEJOFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool ECFDBCDIODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool IIIJKMHGFOC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<CDECIPOAKFM> LPKEBKKDNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IJKBDCPIHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75FED60", Offset = "0x75FD960", VA = "0x1875FED60", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FJFKEFAPLLG NHEIECDLBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75FE6F0", Offset = "0x75FD2F0", VA = "0x1875FE6F0", Slot = "8")]
		get
		{
			return default(FJFKEFAPLLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> LBCIDEKKFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88C510", Offset = "0x88B110", VA = "0x18088C510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75FE400", Offset = "0x75FD000", VA = "0x1875FE400")]
	private bool FAALBOLBHAN(IBMFCJNKKBI HMAFPCMGLCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x75FECC0", Offset = "0x75FD8C0", VA = "0x1875FECC0")]
	private static bool PDLKFHFOMPI(IBMFCJNKKBI HMAFPCMGLCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x75FF0E0", Offset = "0x75FDCE0", VA = "0x1875FF0E0")]
	public DIGLPKIHEGL(PLEFNFBHPPD BFLLAIFBMAJ, bool NJKKHHANEJP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x75FE180", Offset = "0x75FCD80", VA = "0x1875FE180", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x75FD9B0", Offset = "0x75FC5B0", VA = "0x1875FD9B0")]
	public void CMCAIIEBGOH(IBMFCJNKKBI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75FD890", Offset = "0x75FC490", VA = "0x1875FD890")]
	public void CEFMELNJEMA(IBMFCJNKKBI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75FE7C0", Offset = "0x75FD3C0", VA = "0x1875FE7C0", Slot = "4")]
	public void PBFFBGCFJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x75FE420", Offset = "0x75FD020", VA = "0x1875FE420")]
	public void HMDNBLCBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75FEE70", Offset = "0x75FDA70", VA = "0x1875FEE70")]
	private void PPFGNNDEJKO(List<IBMFCJNKKBI> KHENFJHOLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75F8540", Offset = "0x75F7140", VA = "0x1875F8540")]
	private static Material BNOCMKAGHNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x75FF030", Offset = "0x75FDC30", VA = "0x1875FF030")]
	private void PPFGNNDEJKO(IBMFCJNKKBI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75FEDA0", Offset = "0x75FD9A0", VA = "0x1875FEDA0")]
	private void POJIKJDILPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75FDB50", Offset = "0x75FC750", VA = "0x1875FDB50")]
	public void CMFCBAIPOPI(bool KCBODJKNEKD, bool GCIMLKBEIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x75FE340", Offset = "0x75FCF40", VA = "0x1875FE340")]
	protected void EDNMJKIAICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x75FE670", Offset = "0x75FD270", VA = "0x1875FE670")]
	public void LMEAMHCIBCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75FECE0", Offset = "0x75FD8E0", VA = "0x1875FECE0")]
	[IteratorStateMachine(typeof(ANMAFCIGMAA))]
	public IEnumerable<Renderer> PLMMIMBADNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75FE100", Offset = "0x75FCD00", VA = "0x1875FE100")]
	[IteratorStateMachine(typeof(IEAOPHMIPIF))]
	public IEnumerable<Renderer> CMPNBGKJOEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class MHPBDMELDNI : IBMFCJNKKBI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct BFOPOFLFHAN : KPNMDEFAGFM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GKPKFCDGCEK OOKDOLDBLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle PJNBMNEECAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ECEHMECGEMA LGGHADPMINA;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75F8420", Offset = "0x75F7020", VA = "0x1875F8420")]
		public BFOPOFLFHAN(GKPKFCDGCEK OOKDOLDBLMJ, JobHandle PJNBMNEECAJ, ECEHMECGEMA LGGHADPMINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x75F83F0", Offset = "0x75F6FF0", VA = "0x1875F83F0", Slot = "4")]
		public GKPKFCDGCEK LIIAHFFMFKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75F83A0", Offset = "0x75F6FA0", VA = "0x1875F83A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly GHIENMFCFMM GGJDDFAHJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float FFLHFGODONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 IECLPKBIHAJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 HCMLBIGIOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7604D70", Offset = "0x7603970", VA = "0x187604D70", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x76060A0", Offset = "0x7604CA0", VA = "0x1876060A0")]
	public MHPBDMELDNI(DIGLPKIHEGL AHFIDHNOIFE, GHIENMFCFMM BFLLAIFBMAJ, bool NJKKHHANEJP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "18")]
	public override bool LBABPHLBNMB(FJFKEFAPLLG AHFIDHNOIFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7604BA0", Offset = "0x76037A0", VA = "0x187604BA0", Slot = "19")]
	public override int AKGCKBINIKI(AGIBEANFPAA LAIJAICKIEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7605C50", Offset = "0x7604850", VA = "0x187605C50", Slot = "20")]
	public override int KMCGGFFAHMD(AGIBEANFPAA LAIJAICKIEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7604660", Offset = "0x7603260", VA = "0x187604660", Slot = "21")]
	public override Bounds ABMGKJIAKHC()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xA30510", Offset = "0xA2F110", VA = "0x180A30510", Slot = "22")]
	public override float BGNCGAJIEND()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7605670", Offset = "0x7604270", VA = "0x187605670", Slot = "23")]
	public override void KABKPBCBNLK(AGIBEANFPAA LAIJAICKIEF, GLHGELOAPKI EIDCADCKEBO, int BPEDNDAGFBB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7605FD0", Offset = "0x7604BD0", VA = "0x187605FD0", Slot = "24")]
	public override FJFKEFAPLLG NFNAAPAAGBN()
	{
		return default(FJFKEFAPLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7605E20", Offset = "0x7604A20", VA = "0x187605E20", Slot = "26")]
	public override BOCMGAIAAHF LFMFOPDLHJE()
	{
		return default(BOCMGAIAAHF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7604EA0", Offset = "0x7603AA0", VA = "0x187604EA0", Slot = "27")]
	public override KPNMDEFAGFM JLAOFFAJMNG(AGIBEANFPAA LAIJAICKIEF, JobHandle PJNBMNEECAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface ABIJDHAEADK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DIGLPKIHEGL CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IBMFCJNKKBI CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DOAKHHLENHC CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class DGIBJDBHKJI : LONHKCPEDHN, IDisposable, ABIJDHAEADK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CBMFJCKNDEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public DGIBJDBHKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x75F9770", Offset = "0x75F8370", VA = "0x1875F9770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75F9C80", Offset = "0x75F8880", VA = "0x1875F9C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly NOKADPMDKJH<HOIMHHIKEDC, DIGLPKIHEGL> LAHMHMDNIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly NOKADPMDKJH<KFAONOJCCPI, IBMFCJNKKBI> KHENFJHOLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly NOKADPMDKJH<KKGDPLMDIPI, DOAKHHLENHC> EEKCNKADLHA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DIGLPKIHEGL CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75FBB40", Offset = "0x75FA740", VA = "0x1875FBB40", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IBMFCJNKKBI CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x75FBBA0", Offset = "0x75FA7A0", VA = "0x1875FBBA0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DOAKHHLENHC CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x75FBAE0", Offset = "0x75FA6E0", VA = "0x1875FBAE0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IHNHCBANPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9157C0", Offset = "0x9143C0", VA = "0x1809157C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xD13460", Offset = "0xD12060", VA = "0x180D13460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x75FD410", Offset = "0x75FC010", VA = "0x1875FD410")]
	public DGIBJDBHKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x75FBC00", Offset = "0x75FA800", VA = "0x1875FBC00", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x75FCFF0", Offset = "0x75FBBF0", VA = "0x1875FCFF0", Slot = "4")]
	public HOIMHHIKEDC PEJDGHNGFPI(PLEFNFBHPPD BFLLAIFBMAJ)
	{
		return default(HOIMHHIKEDC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x75FCD80", Offset = "0x75FB980", VA = "0x1875FCD80", Slot = "5")]
	public HOIMHHIKEDC PEJDGHNGFPI(PLEFNFBHPPD BFLLAIFBMAJ, bool NJKKHHANEJP)
	{
		return default(HOIMHHIKEDC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x75FB3D0", Offset = "0x75F9FD0", VA = "0x1875FB3D0", Slot = "6")]
	public void AFMBCFJOHEE(HOIMHHIKEDC AHFIDHNOIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x75FD000", Offset = "0x75FBC00", VA = "0x1875FD000", Slot = "7")]
	public void PEONJHHMIDL(HOIMHHIKEDC AHFIDHNOIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x75FC210", Offset = "0x75FAE10", VA = "0x1875FC210", Slot = "8")]
	public KFAONOJCCPI KIOCLGBNDCM(HOIMHHIKEDC AHFIDHNOIFE, FIFKKIMGIBH BFLLAIFBMAJ)
	{
		return default(KFAONOJCCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x75FB620", Offset = "0x75FA220", VA = "0x1875FB620", Slot = "9")]
	public KFAONOJCCPI CMJAKKJMJAD(HOIMHHIKEDC AHFIDHNOIFE, GHIENMFCFMM BFLLAIFBMAJ)
	{
		return default(KFAONOJCCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x75FBE00", Offset = "0x75FAA00", VA = "0x1875FBE00", Slot = "11")]
	public void IMNNCDPBJIK(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x75FC9B0", Offset = "0x75FB5B0", VA = "0x1875FC9B0", Slot = "10")]
	public void OCFLCIONDCJ(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x75FC1A0", Offset = "0x75FADA0", VA = "0x1875FC1A0", Slot = "20")]
	public IEnumerable<Renderer> KDJJJEMHEPD(HOIMHHIKEDC AHFIDHNOIFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x75FBD80", Offset = "0x75FA980", VA = "0x1875FBD80", Slot = "12")]
	public KKGDPLMDIPI HCAJGMPCLMO(HOFGPKBKKBF BFLLAIFBMAJ)
	{
		return default(KKGDPLMDIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x75FC760", Offset = "0x75FB360", VA = "0x1875FC760", Slot = "14")]
	public void MBGPDHOPFFD(KKGDPLMDIPI OMNMEBMDOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x75FC7D0", Offset = "0x75FB3D0", VA = "0x1875FC7D0", Slot = "16")]
	public Task MEMOKIGLCBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x75FCC00", Offset = "0x75FB800", VA = "0x1875FCC00", Slot = "17")]
	public Task OFNKOAHJENM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x75FD340", Offset = "0x75FBF40", VA = "0x1875FD340", Slot = "18")]
	[AsyncStateMachine(typeof(CBMFJCKNDEB))]
	public Task PNOIDDCKHGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x75FC6D0", Offset = "0x75FB2D0", VA = "0x1875FC6D0", Slot = "19")]
	public void LKPLJAJBNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75FC950", Offset = "0x75FB550", VA = "0x1875FC950", Slot = "13")]
	public void MIFJJMKPOCO(KKGDPLMDIPI OMNMEBMDOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class GBMPNHPPIHE : IBMFCJNKKBI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct FDNCABEGPFF : KPNMDEFAGFM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private GKPKFCDGCEK OOKDOLDBLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle PJNBMNEECAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private OHNNBJJGFAA LGGHADPMINA;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x76006B0", Offset = "0x75FF2B0", VA = "0x1876006B0")]
		public FDNCABEGPFF(GKPKFCDGCEK OOKDOLDBLMJ, JobHandle PJNBMNEECAJ, OHNNBJJGFAA LGGHADPMINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7600680", Offset = "0x75FF280", VA = "0x187600680", Slot = "4")]
		public GKPKFCDGCEK LIIAHFFMFKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7600630", Offset = "0x75FF230", VA = "0x187600630", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly FIFKKIMGIBH HCNDAPMGMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] OFMBHBCJFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 IECLPKBIHAJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 OPFODLNBPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7600E70", Offset = "0x75FFA70", VA = "0x187600E70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 HCMLBIGIOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7600D40", Offset = "0x75FF940", VA = "0x187600D40", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7602C60", Offset = "0x7601860", VA = "0x187602C60")]
	public GBMPNHPPIHE(DIGLPKIHEGL AHFIDHNOIFE, FIFKKIMGIBH BFLLAIFBMAJ, bool PDPOOPGPEPA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x76020C0", Offset = "0x7600CC0", VA = "0x1876020C0", Slot = "18")]
	public override bool LBABPHLBNMB(FJFKEFAPLLG AHFIDHNOIFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7602990", Offset = "0x7601590", VA = "0x187602990")]
	private NDKIKKDHPNG NEFNLEFJINK([In] UniformTRS COPPBHBKGLJ, [In] float3 OHMHFCBBAFF)
	{
		return default(NDKIKKDHPNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7600940", Offset = "0x75FF540", VA = "0x187600940", Slot = "19")]
	public override int AKGCKBINIKI(AGIBEANFPAA LAIJAICKIEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7602020", Offset = "0x7600C20", VA = "0x187602020", Slot = "20")]
	public override int KMCGGFFAHMD(AGIBEANFPAA LAIJAICKIEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x76008C0", Offset = "0x75FF4C0", VA = "0x1876008C0", Slot = "21")]
	public override Bounds ABMGKJIAKHC()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x76009E0", Offset = "0x75FF5E0", VA = "0x1876009E0", Slot = "22")]
	public override float BGNCGAJIEND()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7600AD0", Offset = "0x75FF6D0", VA = "0x187600AD0")]
	private int CEJADAFDJEN(AGIBEANFPAA LAIJAICKIEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7601800", Offset = "0x7600400", VA = "0x187601800", Slot = "23")]
	public override void KABKPBCBNLK(AGIBEANFPAA LAIJAICKIEF, GLHGELOAPKI EIDCADCKEBO, int BPEDNDAGFBB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7602B90", Offset = "0x7601790", VA = "0x187602B90", Slot = "24")]
	public override FJFKEFAPLLG NFNAAPAAGBN()
	{
		return default(FJFKEFAPLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x76027E0", Offset = "0x76013E0", VA = "0x1876027E0", Slot = "26")]
	public override BOCMGAIAAHF LFMFOPDLHJE()
	{
		return default(BOCMGAIAAHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76010A0", Offset = "0x75FFCA0", VA = "0x1876010A0", Slot = "27")]
	public override KPNMDEFAGFM JLAOFFAJMNG(AGIBEANFPAA LAIJAICKIEF, JobHandle PJNBMNEECAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DMAJHIMFLPP
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLJEGMEMFBN(ODMGODNGJGC FIFJJNIIAPF, Renderer HKFOEGKIJPH, int JFJEICOLDIO);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIOPAGPKAOG(Renderer HKFOEGKIJPH, OLHCOHMJOCC MBHJGKJJEMC, Vector3 MHMCJEFLBCE, Vector3 OGEOFKLJLIO, Vector3 CPMCOPNHLMB, float CNPBDFJFKHO, float MJOLKKCIFEB, float POIHHGEGDAG = -1f, [Optional] Color? NKKLIFIFGAP, [Optional] IReadOnlyList<Camera> BAOECDALKHG);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEJFGHLBEFG(Renderer HKFOEGKIJPH, int JFJEICOLDIO);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CIHACDPDMAF();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNLKNCOPMKG(int LLNNDNPHNGC, BLNKBACJIBE FIFJJNIIAPF, Renderer HKFOEGKIJPH, int JFJEICOLDIO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OANOLBCAGIC : IFIADOEPHCD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class MBLIAJAEMCM : LKMAHMIGHDH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7604610", Offset = "0x7603210", VA = "0x187604610")]
		public MBLIAJAEMCM(string GMBAACDNNFI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DMAJHIMFLPP BHNLEFFAMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly ABIJDHAEADK LGJCJDAHONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer EGNHKMMPOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MBLIAJAEMCM GEIOMBHBGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool KKACLFLCNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer OMAPMBHHCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MBLIAJAEMCM GBDAPPHIKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool KIOFLGBLMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer ONLFDJHHOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MBLIAJAEMCM GOKPFGDFDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool JJPODDLBIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool HINLMPLCGEB;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x887A10", Offset = "0x886610", VA = "0x180887A10")]
	public OANOLBCAGIC(DMAJHIMFLPP FBBOGONGIGH, ABIJDHAEADK LGJCJDAHONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x76072D0", Offset = "0x7605ED0", VA = "0x1876072D0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7606150", Offset = "0x7604D50", VA = "0x187606150")]
	private void BFBHMEKLFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7606E50", Offset = "0x7605A50", VA = "0x187606E50", Slot = "4")]
	public void DBACCIGFECM(HOIMHHIKEDC AHFIDHNOIFE, BLNKBACJIBE PBAGHGLELNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7606C30", Offset = "0x7605830", VA = "0x187606C30", Slot = "5")]
	public void DBACCIGFECM(KFAONOJCCPI HMAFPCMGLCM, BLNKBACJIBE PBAGHGLELNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7606AD0", Offset = "0x76056D0", VA = "0x187606AD0", Slot = "6")]
	public void CODGFEEJBKF(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7607890", Offset = "0x7606490", VA = "0x187607890", Slot = "7")]
	public void IFGCHDCJNMJ(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x76079E0", Offset = "0x76065E0", VA = "0x1876079E0", Slot = "24")]
	public void JEBNMDKKIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA55A30", Offset = "0xA54630", VA = "0x180A55A30", Slot = "8")]
	public void HLBAMHHNCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7607160", Offset = "0x7605D60", VA = "0x187607160", Slot = "9")]
	public void DMHGCCGJOPG(BLNKBACJIBE PBAGHGLELNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7606720", Offset = "0x7605320", VA = "0x187606720", Slot = "10")]
	public void BPNFHBFINBM(HOIMHHIKEDC AHFIDHNOIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x76063C0", Offset = "0x7604FC0", VA = "0x1876063C0", Slot = "11")]
	public void BPNFHBFINBM(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7606A00", Offset = "0x7605600", VA = "0x187606A00", Slot = "12")]
	public void CKCBEBIGPNI(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x76076F0", Offset = "0x76062F0", VA = "0x1876076F0", Slot = "13")]
	public void FBDKJCGAPGG(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7608760", Offset = "0x7607360", VA = "0x187608760")]
	private void MLIOEIMJDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xB2D060", Offset = "0xB2BC60", VA = "0x180B2D060", Slot = "14")]
	public void BNMHDHJIKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7608640", Offset = "0x7607240", VA = "0x187608640", Slot = "15")]
	public void LEIPKAGEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7607A20", Offset = "0x7606620", VA = "0x187607A20", Slot = "16")]
	public void JJAMIHEBPII(HOIMHHIKEDC AHFIDHNOIFE, ODMGODNGJGC FIFJJNIIAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x76077C0", Offset = "0x76063C0", VA = "0x1876077C0", Slot = "17")]
	public void GMAFDBOADCB(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7608570", Offset = "0x7607170", VA = "0x187608570", Slot = "18")]
	public void LEBOBAJOILK(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xC26D40", Offset = "0xC25940", VA = "0x180C26D40", Slot = "19")]
	public void MHENNMHGGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x76089D0", Offset = "0x76075D0", VA = "0x1876089D0", Slot = "20")]
	public void PCMEABMAFJM(ODMGODNGJGC FIFJJNIIAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7607480", Offset = "0x7606080", VA = "0x187607480")]
	private void EDAFAKBHFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7607D00", Offset = "0x7606900", VA = "0x187607D00", Slot = "21")]
	public void KJBBHKAPEEE(HOIMHHIKEDC AHFIDHNOIFE, Vector3 MHMCJEFLBCE, Vector3 OGEOFKLJLIO, Vector3 CPMCOPNHLMB, float CNPBDFJFKHO, float MJOLKKCIFEB, IReadOnlyList<Camera> NCAACGFPPLL, OLHCOHMJOCC MBHJGKJJEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x76080D0", Offset = "0x7606CD0", VA = "0x1876080D0", Slot = "22")]
	public void KJBBHKAPEEE(KKGDPLMDIPI OMNMEBMDOFC, Vector3 MHMCJEFLBCE, Vector3 OGEOFKLJLIO, Vector3 CPMCOPNHLMB, float CNPBDFJFKHO, float MJOLKKCIFEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class IBMFCJNKKBI : HCOOLBLNMPM, CDECIPOAKFM, KKMJGFAKLIB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly DIGLPKIHEGL JAFALLCEFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private int FIEBLHIOLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected Bounds DJPPMLOGJHB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds BJIKMDGJLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7602E50", Offset = "0x7601A50", VA = "0x187602E50", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool IIIJKMHGFOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x91A590", Offset = "0x919190", VA = "0x18091A590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xD1B320", Offset = "0xD19F20", VA = "0x180D1B320")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 HCMLBIGIOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OMEPACLHMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8EA970", Offset = "0x8E9570", VA = "0x1808EA970", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BBDKMOFBNNB LBKBPNMOHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x88C510", Offset = "0x88B110", VA = "0x18088C510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool POCOGIKDFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xBE74B0", Offset = "0xBE60B0", VA = "0x180BE74B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	protected IBMFCJNKKBI(DIGLPKIHEGL AHFIDHNOIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7602D20", Offset = "0x7601920", VA = "0x187602D20", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "18")]
	public virtual bool LBABPHLBNMB(FJFKEFAPLLG AHFIDHNOIFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7602D10", Offset = "0x7601910", VA = "0x187602D10", Slot = "10")]
	public int DFOKGIOLBLB(int CNHGCKFFFON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int AKGCKBINIKI(AGIBEANFPAA LAIJAICKIEF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int KMCGGFFAHMD(AGIBEANFPAA LAIJAICKIEF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract Bounds ABMGKJIAKHC();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float BGNCGAJIEND();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void KABKPBCBNLK(AGIBEANFPAA LAIJAICKIEF, GLHGELOAPKI EIDCADCKEBO, int BPEDNDAGFBB = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract FJFKEFAPLLG NFNAAPAAGBN();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7602EA0", Offset = "0x7601AA0", VA = "0x187602EA0", Slot = "13")]
	public Hash128 PHDPCLMFFMK(int LAIJAICKIEF)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract BOCMGAIAAHF LFMFOPDLHJE();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract KPNMDEFAGFM JLAOFFAJMNG(AGIBEANFPAA LAIJAICKIEF, JobHandle PJNBMNEECAJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7602E70", Offset = "0x7601A70", VA = "0x187602E70", Slot = "12")]
	public KPNMDEFAGFM LHACGACFLLA(int LAIJAICKIEF)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x76093F0", Offset = "0x7607FF0", VA = "0x1876093F0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KJEJPNOEBJD
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class FEOPCOMHMCN : IEnumerable<NNANCKNIAFI>, IEnumerable, IEnumerator<NNANCKNIAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private NNANCKNIAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private NNANCKNIAFI System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8E1390", Offset = "0x8DFF90", VA = "0x1808E1390")]
		[DebuggerHidden]
		public FEOPCOMHMCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7600700", Offset = "0x75FF300", VA = "0x187600700", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7600870", Offset = "0x75FF470", VA = "0x187600870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x76007D0", Offset = "0x75FF3D0", VA = "0x1876007D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NNANCKNIAFI> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x76007D0", Offset = "0x75FF3D0", VA = "0x1876007D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static NNANCKNIAFI[][] HJGNMBPJINC;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static AOBACOBNBPK CPBKODLBMME;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig ELBAGDPDPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7603A10", Offset = "0x7602610", VA = "0x187603A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader GGEGOHMOJPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x76041D0", Offset = "0x7602DD0", VA = "0x1876041D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer PCIPCBLEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7603D10", Offset = "0x7602910", VA = "0x187603D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7603AA0", Offset = "0x76026A0", VA = "0x187603AA0")]
	public static Mesh JKJHBJLLIGG(PKDHLEFJHBK DNOILGBMMBP, int LAIJAICKIEF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7604500", Offset = "0x7603100", VA = "0x187604500")]
	public static int PMMMEFOFFOB(PKDHLEFJHBK DNOILGBMMBP, int LAIJAICKIEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7603710", Offset = "0x7602310", VA = "0x187603710")]
	public static AOBACOBNBPK ACFDAMKBHAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7603A40", Offset = "0x7602640", VA = "0x187603A40")]
	[IteratorStateMachine(typeof(FEOPCOMHMCN))]
	private static IEnumerable<NNANCKNIAFI> ICNHLBNAMAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7604260", Offset = "0x7602E60", VA = "0x187604260")]
	public static NNANCKNIAFI PCCCHHDPCEE(PKDHLEFJHBK DNOILGBMMBP, int LAIJAICKIEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7604240", Offset = "0x7602E40", VA = "0x187604240")]
	public static bool ONEPOKEKGGC(this PKDHLEFJHBK DNOILGBMMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7603860", Offset = "0x7602460", VA = "0x187603860")]
	public static void FCDCAMEGCMC(PKDHLEFJHBK DNOILGBMMBP, float3 LFNBBIFMLLI, [Out] KBFFKOGFIEI HCGBEJEMBCC, [Out] float3 GDNDCELBJFC, [Out] float PDILIGGJLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7603D80", Offset = "0x7602980", VA = "0x187603D80")]
	public static void NNCBIMAFDFC(Vector3 LFNBBIFMLLI, PKDHLEFJHBK DNOILGBMMBP, [Out] Vector3 GDNDCELBJFC, [Out] float PDILIGGJLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7603850", Offset = "0x7602450", VA = "0x187603850")]
	[KLNOBIFDDGO(EFNOLBLLEIH.ExitingPlayMode, 0)]
	[HLOEJOMBKMO(0)]
	private static void CCDAFLDEOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7603B50", Offset = "0x7602750", VA = "0x187603B50")]
	[KLNOBIFDDGO(EFNOLBLLEIH.ExitingPlayMode, 0)]
	[HLOEJOMBKMO(0)]
	private static void LBMCIFNLKDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class BIACGNOOONN : LONHKCPEDHN, IDisposable, ABIJDHAEADK
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly NOKADPMDKJH<HOIMHHIKEDC, DIGLPKIHEGL> LAHMHMDNIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly NOKADPMDKJH<KFAONOJCCPI, IBMFCJNKKBI> KHENFJHOLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly NOKADPMDKJH<KKGDPLMDIPI, DOAKHHLENHC> EEKCNKADLHA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public DIGLPKIHEGL CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x75F8A90", Offset = "0x75F7690", VA = "0x1875F8A90", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IBMFCJNKKBI CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x75F8B50", Offset = "0x75F7750", VA = "0x1875F8B50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public DOAKHHLENHC CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x75F8AF0", Offset = "0x75F76F0", VA = "0x1875F8AF0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IHNHCBANPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9157C0", Offset = "0x9143C0", VA = "0x1809157C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xD13460", Offset = "0xD12060", VA = "0x180D13460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x75F93B0", Offset = "0x75F7FB0", VA = "0x1875F93B0")]
	public BIACGNOOONN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x75F8BB0", Offset = "0x75F77B0", VA = "0x1875F8BB0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x75F9170", Offset = "0x75F7D70", VA = "0x1875F9170", Slot = "4")]
	public HOIMHHIKEDC PEJDGHNGFPI(PLEFNFBHPPD BFLLAIFBMAJ)
	{
		return default(HOIMHHIKEDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x75F9170", Offset = "0x75F7D70", VA = "0x1875F9170", Slot = "5")]
	public HOIMHHIKEDC PEJDGHNGFPI(PLEFNFBHPPD BFLLAIFBMAJ, bool NJKKHHANEJP)
	{
		return default(HOIMHHIKEDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x75F88F0", Offset = "0x75F74F0", VA = "0x1875F88F0", Slot = "6")]
	public void AFMBCFJOHEE(HOIMHHIKEDC AHFIDHNOIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x75F9210", Offset = "0x75F7E10", VA = "0x1875F9210", Slot = "7")]
	public void PEONJHHMIDL(HOIMHHIKEDC AHFIDHNOIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x75F8DC0", Offset = "0x75F79C0", VA = "0x1875F8DC0", Slot = "8")]
	public KFAONOJCCPI KIOCLGBNDCM(HOIMHHIKEDC AHFIDHNOIFE, FIFKKIMGIBH BFLLAIFBMAJ)
	{
		return default(KFAONOJCCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x75F8950", Offset = "0x75F7550", VA = "0x1875F8950", Slot = "9")]
	public KFAONOJCCPI CMJAKKJMJAD(HOIMHHIKEDC AHFIDHNOIFE, GHIENMFCFMM BFLLAIFBMAJ)
	{
		return default(KFAONOJCCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x75F8CC0", Offset = "0x75F78C0", VA = "0x1875F8CC0", Slot = "11")]
	public void IMNNCDPBJIK(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x75F9070", Offset = "0x75F7C70", VA = "0x1875F9070", Slot = "10")]
	public void OCFLCIONDCJ(KFAONOJCCPI HMAFPCMGLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x75F8D50", Offset = "0x75F7950", VA = "0x1875F8D50", Slot = "20")]
	public IEnumerable<Renderer> KDJJJEMHEPD(HOIMHHIKEDC AHFIDHNOIFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x75F8C40", Offset = "0x75F7840", VA = "0x1875F8C40", Slot = "12")]
	public KKGDPLMDIPI HCAJGMPCLMO(HOFGPKBKKBF BFLLAIFBMAJ)
	{
		return default(KKGDPLMDIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x75F8F00", Offset = "0x75F7B00", VA = "0x1875F8F00", Slot = "14")]
	public void MBGPDHOPFFD(KKGDPLMDIPI OMNMEBMDOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x75F8F70", Offset = "0x75F7B70", VA = "0x1875F8F70", Slot = "16")]
	public Task MEMOKIGLCBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x75F90D0", Offset = "0x75F7CD0", VA = "0x1875F90D0", Slot = "17")]
	public Task OFNKOAHJENM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x75F9290", Offset = "0x75F7E90", VA = "0x1875F9290", Slot = "18")]
	public Task PNOIDDCKHGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2067D70", Offset = "0x2066970", VA = "0x182067D70", Slot = "19")]
	public void LKPLJAJBNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x75F9010", Offset = "0x75F7C10", VA = "0x1875F9010", Slot = "13")]
	public void MIFJJMKPOCO(KKGDPLMDIPI OMNMEBMDOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FHKKIMCAHLD
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool PODGIGAANFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material BGHNOKENKIE();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material BNOCMKAGHNN();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material HNHHPNNCBAH();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HHLABEPFPCI(JJGANJGEFFL NHMCIACLKHL);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MBHAPAHEBIB(OICBHJLAMDI GKDBBFMNMKK);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGIKOCGJIJO(GameObject PLAMADMDGIO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CNFNBJEAODA(GameObject PLAMADMDGIO, bool IPKLAGBDMOI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BGLMOIBAPBE
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static FHKKIMCAHLD GMBKDDMMMLD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool PODGIGAANFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x75F8480", Offset = "0x75F7080", VA = "0x1875F8480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x75F8680", Offset = "0x75F7280", VA = "0x1875F8680")]
	public static void FEAKMAOAGML(FHKKIMCAHLD ENJCEIGNAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x75F84E0", Offset = "0x75F70E0", VA = "0x1875F84E0")]
	public static Material BGHNOKENKIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x75F8540", Offset = "0x75F7140", VA = "0x1875F8540")]
	public static Material BNOCMKAGHNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x75F8740", Offset = "0x75F7340", VA = "0x1875F8740")]
	public static Material HNHHPNNCBAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x75F86D0", Offset = "0x75F72D0", VA = "0x1875F86D0")]
	public static int HHLABEPFPCI(JJGANJGEFFL NHMCIACLKHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x75F8880", Offset = "0x75F7480", VA = "0x1875F8880")]
	public static int MBHAPAHEBIB(OICBHJLAMDI GKDBBFMNMKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x75F87A0", Offset = "0x75F73A0", VA = "0x1875F87A0")]
	public static void JGIKOCGJIJO(GameObject PLAMADMDGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x75F85A0", Offset = "0x75F71A0", VA = "0x1875F85A0")]
	public static void CNFNBJEAODA(GameObject PLAMADMDGIO, bool IPKLAGBDMOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DOAKHHLENHC : BDLHDHMOENH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class CDPCPOOFAHM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DOAKHHLENHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8E1390", Offset = "0x8DFF90", VA = "0x1808E1390")]
		[DebuggerHidden]
		public CDPCPOOFAHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x75FA050", Offset = "0x75F8C50", VA = "0x1875FA050", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x75F9D30", Offset = "0x75F8930", VA = "0x1875F9D30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x75F9CE0", Offset = "0x75F88E0", VA = "0x1875F9CE0")]
		private void GOOHPDHLOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x75FA000", Offset = "0x75F8C00", VA = "0x1875FA000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x75F9F50", Offset = "0x75F8B50", VA = "0x1875F9F50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x75F9F50", Offset = "0x75F8B50", VA = "0x1875F9F50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly HOFGPKBKKBF FBGAGDGGCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly ABIJDHAEADK LGJCJDAHONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private PLALEMDECHJ GPCLFMDDIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<DCLFBJABLFP> FANFKMNNJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private List<DCLFBJABLFP> PDOOFEBGLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GameObject MHOKFDPNCNG;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x75FF1D0", Offset = "0x75FDDD0", VA = "0x1875FF1D0")]
	public static DOAKHHLENHC ADGNDGLGGDJ(HOFGPKBKKBF BFLLAIFBMAJ, ABIJDHAEADK LGJCJDAHONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7600550", Offset = "0x75FF150", VA = "0x187600550")]
	private DOAKHHLENHC(HOFGPKBKKBF BFLLAIFBMAJ, ABIJDHAEADK LGJCJDAHONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x75FF5A0", Offset = "0x75FE1A0", VA = "0x1875FF5A0")]
	public void ICJAGPEAKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x76004D0", Offset = "0x75FF0D0", VA = "0x1876004D0")]
	[IteratorStateMachine(typeof(CDPCPOOFAHM))]
	public IEnumerable<Renderer> PLMMIMBADNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x75FFA20", Offset = "0x75FE620", VA = "0x1875FFA20", Slot = "4")]
	public void PBFFBGCFJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x75FF320", Offset = "0x75FDF20", VA = "0x1875FF320")]
	private void AJPFHDANNPN(Vector3 NLHOLJAFCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x75FF350", Offset = "0x75FDF50", VA = "0x1875FF350")]
	public void HMDNBLCBPCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DCLFBJABLFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct PDIPBLHNHDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GLHGELOAPKI MBAOIDNLCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public FJFKEFAPLLG CEOANODHGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int NGMAMDOGBDG;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JALGJFACNBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DCLFBJABLFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AGIBEANFPAA lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<PDIPBLHNHDF> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GKPKFCDGCEK combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public JALGJFACNBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7603540", Offset = "0x7602140", VA = "0x187603540")]
		internal JobHandle LPJHGCEDCFM()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7603510", Offset = "0x7602110", VA = "0x187603510")]
		internal void HGCOEELFGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x76035A0", Offset = "0x76021A0", VA = "0x1876035A0")]
		internal void PLJFDDJABDF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int[] NKJLCCJEAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private DHHOKGNLHPM FABDIGANFHD;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Matrix4x4 HEKMGAICLGA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh JDBCOKDJJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int NCHNHNDHOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8866B0", VA = "0x180887AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x887AD0", Offset = "0x8866D0", VA = "0x180887AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x75FA8E0", Offset = "0x75F94E0", VA = "0x1875FA8E0")]
	public void IKPALHMDAAN(List<FJFKEFAPLLG> KDBLKDBIDOK, Matrix4x4[] JPIJPEKEMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x75FA250", Offset = "0x75F8E50", VA = "0x1875FA250")]
	public static List<DCLFBJABLFP> ELGDCMPCLII(List<DIGLPKIHEGL> CMHOPPLHOAG, AGIBEANFPAA LAIJAICKIEF, Bounds BEPNONAFOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x75FAAC0", Offset = "0x75F96C0", VA = "0x1875FAAC0")]
	private JobHandle LJAEHBKGEHI(GKPKFCDGCEK HEGCFIKCBEB, int CIFNPACPLLO, int HKKEFFAOMMK, AGIBEANFPAA LAIJAICKIEF, List<PDIPBLHNHDF> BIJPKKMDIEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x75FA0E0", Offset = "0x75F8CE0", VA = "0x1875FA0E0")]
	private void AIPLJGAGGJH(List<PDIPBLHNHDF> BIJPKKMDIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x75FAFB0", Offset = "0x75F9BB0", VA = "0x1875FAFB0")]
	private DCLFBJABLFP(List<PDIPBLHNHDF> BIJPKKMDIEK, int CIFNPACPLLO, int HKKEFFAOMMK, AGIBEANFPAA LAIJAICKIEF, Bounds BEPNONAFOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x75FA1C0", Offset = "0x75F8DC0", VA = "0x1875FA1C0", Slot = "4")]
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
		private MaterialPropertyBlock CIDNBBHKDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private DCLFBJABLFP OOKDOLDBLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private List<FJFKEFAPLLG> IOMCJDOMECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private RenderTexture GIJDLGLEAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeBuffer BJENCHDIHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ComputeShader ABDIKBIFGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Matrix4x4[] EAHNNNMHBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int MHMEFOBAFPF;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer GCNEGBCPLCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int DMHHCMHGOLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x760A160", Offset = "0x7608D60", VA = "0x18760A160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7609450", Offset = "0x7608050", VA = "0x187609450")]
		public static List<SkinnedShapeRenderer> Create(GameObject AHFIDHNOIFE, List<DCLFBJABLFP> OOAIDKILIOC, List<FJFKEFAPLLG> IOMCJDOMECE, Material OFCNJEFMNEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7609B30", Offset = "0x7608730", VA = "0x187609B30")]
		public void Init(DCLFBJABLFP OOKDOLDBLMJ, List<FJFKEFAPLLG> IOMCJDOMECE, Material OFCNJEFMNEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x760A0C0", Offset = "0x7608CC0", VA = "0x18760A0C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x760A020", Offset = "0x7608C20", VA = "0x18760A020")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7609FE0", Offset = "0x7608BE0", VA = "0x187609FE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7609700", Offset = "0x7608300", VA = "0x187609700")]
		private void DIBINOBGAHH(ScriptableRenderContext PDMONEGPHPK, Camera[] GGAKPKFNMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x76097C0", Offset = "0x76083C0", VA = "0x1876097C0")]
		private void IKPALHMDAAN(CommandBuffer EKFBBEMKDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
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
