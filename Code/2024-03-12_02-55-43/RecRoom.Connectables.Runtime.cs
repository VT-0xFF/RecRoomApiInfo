using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : DBDHBFHEAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x60B9300", Offset = "0x60B8500", VA = "0x1860B9300", Slot = "4")]
		public override void MPIFNDMAGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AMNHIIEBCBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private OJGDPFKAHDB bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private OJGDPFKAHDB bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60C3260", Offset = "0x60C2460", VA = "0x1860C3260", Slot = "5")]
		public override void APEIOLGPCIE(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60C3750", Offset = "0x60C2950", VA = "0x1860C3750")]
		private void KEDGCOJNHLP(KDIFPPHEFOM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60C35E0", Offset = "0x60C27E0", VA = "0x1860C35E0")]
		private void EKFAEJONIPL(KDIFPPHEFOM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60C32A0", Offset = "0x60C24A0", VA = "0x1860C32A0", Slot = "6")]
		public override void CJKBHHFMNOL(KDIFPPHEFOM registry, [In] NFFDBJIPBDD filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "8")]
		public override void ILDOOKAPLMG(LNNICLBDLGC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60C38C0", Offset = "0x60C2AC0", VA = "0x1860C38C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class MMNFDGPKLPM : ACKBPNEOKDH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class KPNCKLGFKKJ : IEnumerable<IAOJDFOOKKM>, IEnumerable, IEnumerator<IAOJDFOOKKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IAOJDFOOKKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private HOKEHDIBKGC localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public HOKEHDIBKGC <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MMNFDGPKLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private EMDJHPPKMJA <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KJCKOLEAFGK.BKNKOCHJNHK <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IAOJDFOOKKM System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x807710", Offset = "0x806910", VA = "0x180807710")]
		[DebuggerHidden]
		public KPNCKLGFKKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60B73A0", Offset = "0x60B65A0", VA = "0x1860B73A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60B6EE0", Offset = "0x60B60E0", VA = "0x1860B6EE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60B6EC0", Offset = "0x60B60C0", VA = "0x1860B6EC0")]
		private void EBDKPHOBLLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60B7350", Offset = "0x60B6550", VA = "0x1860B7350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60B72A0", Offset = "0x60B64A0", VA = "0x1860B72A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IAOJDFOOKKM> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60B72A0", Offset = "0x60B64A0", VA = "0x1860B72A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly DNCJPFEBFGD COBKBPPCGME;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly DNCJPFEBFGD GEGPANMIJPA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly DNCJPFEBFGD DDPGHAECIIA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly DNCJPFEBFGD KFHMDOABEJG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly DNCJPFEBFGD KNFCDBMPCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private IPKMMHOILKH DAPJGHMNFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GJKAGFILKDE ILIHAOMANEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private IPDDJJNMLLE BPNCPPCJDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LBBLKOODKKO NJKFJGHCCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private HNGFMHLMMCN PIKOMEEEOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly OFPPFLGNKNE IKNBEMPINKO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BINBACMBECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CD420", Offset = "0x7CC620", VA = "0x1807CD420", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7CCEF0", Offset = "0x7CC0F0", VA = "0x1807CCEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<IAOJDFOOKKM, IAOJDFOOKKM> KAHCOKMFCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60BB670", Offset = "0x60BA870", VA = "0x1860BB670", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60BC240", Offset = "0x60BB440", VA = "0x1860BC240", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<IAOJDFOOKKM, IAOJDFOOKKM> DAOJDAEDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60BC700", Offset = "0x60BB900", VA = "0x1860BC700", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60BA3B0", Offset = "0x60B95B0", VA = "0x1860BA3B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<IAOJDFOOKKM, IAOJDFOOKKM, IAOJDFOOKKM> IFOBBFPNBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60B9A70", Offset = "0x60B8C70", VA = "0x1860B9A70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60BC7B0", Offset = "0x60BB9B0", VA = "0x1860BC7B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60BDBF0", Offset = "0x60BCDF0", VA = "0x1860BDBF0")]
	public MMNFDGPKLPM(IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60B97A0", Offset = "0x60B89A0", VA = "0x1860B97A0", Slot = "11")]
	public void AKCGAJHNOGB(GameObject JLBELLDLMIF, PLOJGIJGGPN BCEAEHFLDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60BA570", Offset = "0x60B9770", VA = "0x1860BA570", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60B5F20", Offset = "0x60B5120", VA = "0x1860B5F20", Slot = "21")]
	public bool OMNGFPJAGEG(MBICFHCMLGE MEADHOGLMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60B9CE0", Offset = "0x60B8EE0", VA = "0x1860B9CE0")]
	private void CDGLIGIHPBO(HOKEHDIBKGC FEFENDELIHK, HOKEHDIBKGC MLFEOKMJPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60BBE90", Offset = "0x60BB090", VA = "0x1860BBE90")]
	private void KJIKBJMBIIA(HOKEHDIBKGC FEFENDELIHK, HOKEHDIBKGC LGACOMJPFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60BB340", Offset = "0x60BA540", VA = "0x1860BB340")]
	private void FIKOAAIFHOI(HOKEHDIBKGC FEFENDELIHK, HOKEHDIBKGC LGACOMJPFGH, HOKEHDIBKGC MLFEOKMJPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60BB7F0", Offset = "0x60BA9F0", VA = "0x1860BB7F0")]
	private void HPIEFHPIOOC(HOKEHDIBKGC FEFENDELIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "12")]
	public void HIJKAFNAKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60BC3F0", Offset = "0x60BB5F0", VA = "0x1860BC3F0", Slot = "13")]
	public void MPIFNDMAGPL(IAOJDFOOKKM AOCNAKFENOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "14")]
	public void JFGGIOGIHDH(IAOJDFOOKKM AOCNAKFENOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60B9640", Offset = "0x60B8840", VA = "0x1860B9640", Slot = "16")]
	public void ACFIBINKLDG(IAOJDFOOKKM AOCNAKFENOF, IAOJDFOOKKM KAHNGDAIILP, Vector3 FFOFALOECNI, Quaternion CPDEPCOMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60B9500", Offset = "0x60B8700", VA = "0x1860B9500")]
	public void ACFIBINKLDG(HOKEHDIBKGC HLNBFGHFDID, HOKEHDIBKGC KAHNGDAIILP, Vector3 FFOFALOECNI, Quaternion CPDEPCOMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60BD9F0", Offset = "0x60BCBF0", VA = "0x1860BD9F0")]
	public void PJPPAEBMHMC(IAOJDFOOKKM AOCNAKFENOF, float HAOEDLHEEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60BA080", Offset = "0x60B9280", VA = "0x1860BA080", Slot = "17")]
	public void CHHAINLNAIO(IAOJDFOOKKM ALFKNEDFOMP, int JODCDJMLBDB, IAOJDFOOKKM MEBMODKBLMJ, int LMIOCJGPBKN, Vector3 FFOFALOECNI, Quaternion CPDEPCOMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60BB5C0", Offset = "0x60BA7C0", VA = "0x1860BB5C0")]
	private float GBAJEPLEHOO(HOKEHDIBKGC HLNBFGHFDID, HOKEHDIBKGC DMKJLMNBOME)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60B9EF0", Offset = "0x60B90F0", VA = "0x1860B9EF0")]
	public void CHHAINLNAIO(HOKEHDIBKGC HLNBFGHFDID, HOKEHDIBKGC DMKJLMNBOME, Vector3 FFOFALOECNI, Quaternion CPDEPCOMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60BA020", Offset = "0x60B9220", VA = "0x1860BA020")]
	public void CHHAINLNAIO(HOKEHDIBKGC HLNBFGHFDID, HOKEHDIBKGC DMKJLMNBOME, Vector3 FFOFALOECNI, Quaternion CPDEPCOMBII, float HAOEDLHEEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60BA1D0", Offset = "0x60B93D0", VA = "0x1860BA1D0", Slot = "18")]
	public void CKDEILGJDGD(IAOJDFOOKKM AOCNAKFENOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60BB0B0", Offset = "0x60BA2B0", VA = "0x1860BB0B0")]
	public bool FHAEFBLGCFC(HOKEHDIBKGC EJFJDAKPAHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60BBC80", Offset = "0x60BAE80", VA = "0x1860BBC80", Slot = "15")]
	public void ICCINPMJGMK(IAOJDFOOKKM AOCNAKFENOF, HashSet<IAOJDFOOKKM> AFMJMBPJHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "19")]
	public GDGHHGOMGAP MNPCEBMABPB(bool IKIOPJMFBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "20")]
	public GDGHHGOMGAP BBBEGLHOJHB(HashSet<Guid> JLHODLGIEHP, bool IKIOPJMFBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60BC2F0", Offset = "0x60BB4F0", VA = "0x1860BC2F0", Slot = "22")]
	public void LJMEGBHCLMB(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60BA340", Offset = "0x60B9540", VA = "0x1860BA340", Slot = "23")]
	public void CNGFDOFNFAF(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60BA760", Offset = "0x60B9960", VA = "0x1860BA760", Slot = "24")]
	public void EEFJHDOLMIE(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60BC860", Offset = "0x60BBA60", VA = "0x1860BC860")]
	private void NKDMOJOCOMG(HOKEHDIBKGC HLNBFGHFDID, HOKEHDIBKGC DMKJLMNBOME, Vector3 FFOFALOECNI, Quaternion CPDEPCOMBII, float HAOEDLHEEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60BD5E0", Offset = "0x60BC7E0", VA = "0x1860BD5E0")]
	private void PAOANHPBCIK(HOKEHDIBKGC HLNBFGHFDID, HOKEHDIBKGC IKEECPHGAFL, Vector3 FFOFALOECNI, Quaternion CPDEPCOMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60BB720", Offset = "0x60BA920", VA = "0x1860BB720")]
	private void GJNGGIIGGBA(HOKEHDIBKGC HLNBFGHFDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60BC360", Offset = "0x60BB560", VA = "0x1860BC360")]
	[IteratorStateMachine(typeof(KPNCKLGFKKJ))]
	public IEnumerable<IAOJDFOOKKM> MDMANDGFAOH(HOKEHDIBKGC EJFJDAKPAHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60BA780", Offset = "0x60B9980", VA = "0x1860BA780")]
	internal IAOJDFOOKKM EHECJMEHKMP(HOKEHDIBKGC EJFJDAKPAHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60B9C10", Offset = "0x60B8E10", VA = "0x1860B9C10")]
	internal HOKEHDIBKGC CBNBMAIDLIA(IAOJDFOOKKM AOCNAKFENOF)
	{
		return default(HOKEHDIBKGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60BCBC0", Offset = "0x60BBDC0", VA = "0x1860BCBC0")]
	private bool NOMDNOHEOFG(MBICFHCMLGE MEADHOGLMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60B9A10", Offset = "0x60B8C10", VA = "0x1860B9A10")]
	private bool BECCGNPAABG(MBICFHCMLGE MEADHOGLMCH, [Out] IAOJDFOOKKM DMKJLMNBOME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60BA8C0", Offset = "0x60B9AC0", VA = "0x1860BA8C0")]
	private IAOJDFOOKKM EHECJMEHKMP(MBICFHCMLGE MEADHOGLMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60BAC00", Offset = "0x60B9E00", VA = "0x1860BAC00")]
	private IAOJDFOOKKM EIFIKEIDALO(MBICFHCMLGE MEADHOGLMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60BD190", Offset = "0x60BC390", VA = "0x1860BD190")]
	private IAOJDFOOKKM OLEKENEOODK(MBICFHCMLGE MEADHOGLMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60AFF20", Offset = "0x60AF120", VA = "0x1860AFF20")]
	private static Guid OCJLHBHJBJA(MBICFHCMLGE MEADHOGLMCH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60B9B20", Offset = "0x60B8D20", VA = "0x1860B9B20")]
	private string BJFDEHKNDKG(MBICFHCMLGE MEADHOGLMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60BAF20", Offset = "0x60BA120", VA = "0x1860BAF20")]
	private void FEIBILNEOGL(IAOJDFOOKKM HLNBFGHFDID, IAOJDFOOKKM IKEECPHGAFL, RigidTransform CHNDIIFEDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60BAD90", Offset = "0x60B9F90", VA = "0x1860BAD90")]
	private void EJMBKJJPMIA(IAOJDFOOKKM IKEECPHGAFL, IAOJDFOOKKM HLNBFGHFDID, RigidTransform CHNDIIFEDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60BB790", Offset = "0x60BA990", VA = "0x1860BB790")]
	private void GOACIEAJLCI(IAOJDFOOKKM LNHLHMFAGMG, IAOJDFOOKKM HLNBFGHFDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60BC0B0", Offset = "0x60BB2B0", VA = "0x1860BC0B0")]
	private void LBNJEEJCJBO(IAOJDFOOKKM HLNBFGHFDID, IAOJDFOOKKM DMKJLMNBOME, RigidTransform CHNDIIFEDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60BA460", Offset = "0x60B9660", VA = "0x1860BA460")]
	private void DGDDCADKFPH(HOKEHDIBKGC EJFJDAKPAHL, IAOJDFOOKKM AOCNAKFENOF, HOKEHDIBKGC LGACOMJPFGH, HOKEHDIBKGC MLFEOKMJPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60BD300", Offset = "0x60BC500", VA = "0x1860BD300")]
	private void ONCAFKFJPNJ(HOKEHDIBKGC EJFJDAKPAHL, IAOJDFOOKKM AOCNAKFENOF, IAOJDFOOKKM ENMJNEHIPIF, IAOJDFOOKKM IPCGHMHOPBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GJAGGAODAII
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FJIBCPHIPAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IAIHJGNDPNA container;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public FJIBCPHIPAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60B3300", Offset = "0x60B2500", VA = "0x1860B3300")]
		internal MMNFDGPKLPM IJLOMFCICEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x60B42D0", Offset = "0x60B34D0", VA = "0x1860B42D0")]
	public static void CHCGCJKPKIM(IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60B4450", Offset = "0x60B3650", VA = "0x1860B4450")]
	public static void GKEHBGFKHIF(IAIHJGNDPNA DEFANHHPGKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class APLJGHIDODO : NMIDOBPPEGG, EHFGPHIAIHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly RigidbodyEx DMHIFOLACBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MMNFDGPKLPM MKPOAJFBNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly EJGPBINEJMK PNFMDINJCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly FODHCFGBKAJ NJKFJGHCCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly NIBEAADCHGG[] HBGONLAGOKJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HOKEHDIBKGC LBCEOFPCMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(HOKEHDIBKGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IAOJDFOOKKM GHPBNHENAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60B25E0", Offset = "0x60B17E0", VA = "0x1860B25E0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IAOJDFOOKKM HIAFGLDCCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x60B0D10", Offset = "0x60AFF10", VA = "0x1860B0D10", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 JOACALEEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x60B0BC0", Offset = "0x60AFDC0", VA = "0x1860B0BC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion LCENIHEGHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x60B1550", Offset = "0x60B0750", VA = "0x1860B1550", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool OKOMNIOFKPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x60B1CB0", Offset = "0x60B0EB0", VA = "0x1860B1CB0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<IAOJDFOOKKM> IJHDOGJABLE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60B1B60", Offset = "0x60B0D60", VA = "0x1860B1B60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool GOADDCALFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8847C0", Offset = "0x8839C0", VA = "0x1808847C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8848E0", Offset = "0x883AE0", VA = "0x1808848E0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform CNPCIAFGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60B27F0", Offset = "0x60B19F0", VA = "0x1860B27F0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject DECAMNDLNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x226FD20", Offset = "0x226EF20", VA = "0x18226FD20", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string IHKMJLPGIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60B2510", Offset = "0x60B1710", VA = "0x1860B2510", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid NNEFGGFFFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60B2640", Offset = "0x60B1840", VA = "0x1860B2640", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EEHGOJJPLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60B2720", Offset = "0x60B1920", VA = "0x1860B2720", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool IGCOANJFBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool JCEADOAPIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x60B0F10", Offset = "0x60B0110", VA = "0x1860B0F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JJAEGLGNMJA JGINDJMMCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60B0C50", Offset = "0x60AFE50", VA = "0x1860B0C50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60B0B60", Offset = "0x60AFD60", VA = "0x1860B0B60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JJAEGLGNMJA IDOPFOMBCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60B12F0", Offset = "0x60B04F0", VA = "0x1860B12F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60B0CB0", Offset = "0x60AFEB0", VA = "0x1860B0CB0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JJAEGLGNMJA DIHGKIHCIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60B1290", Offset = "0x60B0490", VA = "0x1860B1290", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60B1D20", Offset = "0x60B0F20", VA = "0x1860B1D20", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event CKFGHHNONIF CBBAFPKADDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60B15B0", Offset = "0x60B07B0", VA = "0x1860B15B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60B0E70", Offset = "0x60B0070", VA = "0x1860B0E70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60B2410", Offset = "0x60B1610", VA = "0x1860B2410")]
	public APLJGHIDODO(HOKEHDIBKGC BBAGHOBJDIB, RigidbodyEx DMHIFOLACBC, EJGPBINEJMK PNFMDINJCCC, NIBEAADCHGG[] HBGONLAGOKJ, FODHCFGBKAJ NJKFJGHCCPD, ACKBPNEOKDH MKPOAJFBNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60B0C20", Offset = "0x60AFE20", VA = "0x1860B0C20", Slot = "19")]
	public void ADDAPIJFNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "21")]
	public void PMPAMMDLKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F30800", Offset = "0x5F2FA00", VA = "0x185F30800", Slot = "22")]
	public void BCOGOPMIICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60B0E20", Offset = "0x60B0020", VA = "0x1860B0E20", Slot = "20")]
	public void DDALJGFIKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60B21E0", Offset = "0x60B13E0", VA = "0x1860B21E0", Slot = "25")]
	public void PFMLKDICJCA(int CDOJPCACMLI, IAOJDFOOKKM MEBMODKBLMJ, int ADABEOJGFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60B1B90", Offset = "0x60B0D90", VA = "0x1860B1B90", Slot = "26")]
	public void ILGBMFALLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60B0FB0", Offset = "0x60B01B0", VA = "0x1860B0FB0", Slot = "27")]
	public void ECBDEPBEMBD(int CDOJPCACMLI, IAOJDFOOKKM ALFKNEDFOMP, int DNBAOFPJHDM, [Optional] Vector3? NFLJEBOHHJC, [Optional] Quaternion? MLKLKFAFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60B0AE0", Offset = "0x60AFCE0", VA = "0x1860B0AE0", Slot = "28")]
	public void ABEHKDMBHLB(IAOJDFOOKKM ALFKNEDFOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60B1DD0", Offset = "0x60B0FD0", VA = "0x1860B1DD0", Slot = "31")]
	public void PCGDKNGEAOM(Vector3 FAMAJHDMHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x60B1650", Offset = "0x60B0850", VA = "0x1860B1650", Slot = "29")]
	public void HDDKGOBOEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60B1960", Offset = "0x60B0B60", VA = "0x1860B1960", Slot = "30")]
	public void IKBCIIBHGAM(int ILNNGHKJMBD, Vector3 MFLOBHGAOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60B1480", Offset = "0x60B0680", VA = "0x1860B1480", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int CDOJPCACMLI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60B1350", Offset = "0x60B0550", VA = "0x1860B1350", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int CDOJPCACMLI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x846EC0", Offset = "0x8460C0", VA = "0x180846EC0", Slot = "42")]
	public Color GetConnectionSlotColor(int CDOJPCACMLI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60B0D80", Offset = "0x60AFF80", VA = "0x1860B0D80", Slot = "43")]
	public bool CanConnectTo(int CDOJPCACMLI, IAOJDFOOKKM OLOPDNLHMMA, int AGGIHEBMHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "44")]
	public void ParentChanged(int CDOJPCACMLI, IAOJDFOOKKM OGKOECBAHIN, int FODLFOPEJKB, Vector3 BLFJHOAJBPN, Quaternion KCAFAGNGDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "45")]
	public void ChildAdded(int CDOJPCACMLI, IAOJDFOOKKM BGACPJHBMOP, int LGGNJAKDPGA, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "46")]
	public void ChildRemoved(int CDOJPCACMLI, IAOJDFOOKKM JCPOPABHKJG, int DFNEHFOCPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "47")]
	public void ConnectionModified(int CDOJPCACMLI, IAOJDFOOKKM MEBMODKBLMJ, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60B23F0", Offset = "0x60B15F0", VA = "0x1860B23F0", Slot = "48")]
	public void RootChanged(IAOJDFOOKKM CMNEIKGBAMH, IAOJDFOOKKM CDKBGOFKBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60B1D80", Offset = "0x60B0F80", VA = "0x1860B1D80", Slot = "23")]
	public void OCMJMEPLKGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60B0F60", Offset = "0x60B0160", VA = "0x1860B0F60", Slot = "24")]
	public void EBFFLDHFPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60B1C60", Offset = "0x60B0E60", VA = "0x1860B1C60")]
	private void KILNHHAONFH(bool MAPJANLBGBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[KGDBDLGNBOK(typeof(BJMPGFIKAND), new string[] { })]
public class OGAGEMPHIHC : BJMPGFIKAND, IMCONFKMEBH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NLEJNFDJBGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public OGAGEMPHIHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public KJCKOLEAFGK localIds;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public NLEJNFDJBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60C2CF0", Offset = "0x60C1EF0", VA = "0x1860C2CF0")]
		internal void GOIGNNDFBJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly DNCJPFEBFGD COBKBPPCGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[MKKNIMGKFBH]
	private EJEGOHNOJBJ NKDHCPOIGEJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object COGGCEAJAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x60C2F00", Offset = "0x60C2100", VA = "0x1860C2F00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60C2F90", Offset = "0x60C2190", VA = "0x1860C2F90", Slot = "6")]
	public void InitReferences(JPALHOCNDEE IKNBEMPINKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60C2FE0", Offset = "0x60C21E0", VA = "0x1860C2FE0", Slot = "5")]
	public void PNDEONIKDNI(KJCKOLEAFGK GLAKBLMCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public OGAGEMPHIHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KGDBDLGNBOK(typeof(ACKBPNEOKDH), new string[] { "Ignore", "Mock" })]
public class EMFNAEHAKPG : ACKBPNEOKDH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BINBACMBECC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<IAOJDFOOKKM, IAOJDFOOKKM> KAHCOKMFCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60B2F80", Offset = "0x60B2180", VA = "0x1860B2F80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x60B3030", Offset = "0x60B2230", VA = "0x1860B3030", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<IAOJDFOOKKM, IAOJDFOOKKM> DAOJDAEDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x60B30E0", Offset = "0x60B22E0", VA = "0x1860B30E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60B2ED0", Offset = "0x60B20D0", VA = "0x1860B2ED0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<IAOJDFOOKKM, IAOJDFOOKKM, IAOJDFOOKKM> IFOBBFPNBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x60B2E20", Offset = "0x60B2020", VA = "0x1860B2E20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x60B3190", Offset = "0x60B2390", VA = "0x1860B3190", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "11")]
	public void AKCGAJHNOGB(GameObject JLBELLDLMIF, PLOJGIJGGPN BCEAEHFLDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "12")]
	public void HIJKAFNAKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "13")]
	public void MPIFNDMAGPL(IAOJDFOOKKM AOCNAKFENOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "14")]
	public void JFGGIOGIHDH(IAOJDFOOKKM AOCNAKFENOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "15")]
	public void ICCINPMJGMK(IAOJDFOOKKM AOCNAKFENOF, HashSet<IAOJDFOOKKM> AFMJMBPJHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "16")]
	public void ACFIBINKLDG(IAOJDFOOKKM AOCNAKFENOF, IAOJDFOOKKM KAHNGDAIILP, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "17")]
	public void CHHAINLNAIO(IAOJDFOOKKM AOCNAKFENOF, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "18")]
	public void CKDEILGJDGD(IAOJDFOOKKM AOCNAKFENOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "19")]
	public GDGHHGOMGAP MNPCEBMABPB(bool IKIOPJMFBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "20")]
	public GDGHHGOMGAP BBBEGLHOJHB(HashSet<Guid> JLHODLGIEHP, bool IKIOPJMFBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "21")]
	public bool OMNGFPJAGEG(MBICFHCMLGE MEADHOGLMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "22")]
	public void LJMEGBHCLMB(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "23")]
	public void CNGFDOFNFAF(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "24")]
	public void EEFJHDOLMIE(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public EMFNAEHAKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IAOJDFOOKKM : EHFGPHIAIHJ, IEquatable<IAOJDFOOKKM>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EHFGPHIAIHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IAOJDFOOKKM GHPBNHENAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform CNPCIAFGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GameObject DECAMNDLNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string IHKMJLPGIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Guid NNEFGGFFFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int EEHGOJJPLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	HOKEHDIBKGC LBCEOFPCMAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool IGCOANJFBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int CDOJPCACMLI);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int CDOJPCACMLI);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int CDOJPCACMLI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int CDOJPCACMLI, IAOJDFOOKKM OLOPDNLHMMA, int KIKKIKHDJOB);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int CDOJPCACMLI, IAOJDFOOKKM OGKOECBAHIN, int FODLFOPEJKB, Vector3 BLFJHOAJBPN, Quaternion KCAFAGNGDAO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int CDOJPCACMLI, IAOJDFOOKKM BGACPJHBMOP, int LGGNJAKDPGA, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int CDOJPCACMLI, IAOJDFOOKKM JCPOPABHKJG, int DFNEHFOCPNO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int CDOJPCACMLI, IAOJDFOOKKM MEBMODKBLMJ, int NBMKENACNNB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(IAOJDFOOKKM CMNEIKGBAMH, IAOJDFOOKKM CDKBGOFKBBA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[CLCNDOBGJIN(EFJALHABEDM.OMRoom)]
public interface ACKBPNEOKDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BINBACMBECC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<IAOJDFOOKKM, IAOJDFOOKKM> KAHCOKMFCCL;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<IAOJDFOOKKM, IAOJDFOOKKM> DAOJDAEDNGF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<IAOJDFOOKKM, IAOJDFOOKKM, IAOJDFOOKKM> IFOBBFPNBOE;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AKCGAJHNOGB(GameObject JLBELLDLMIF, PLOJGIJGGPN BCEAEHFLDFP);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HIJKAFNAKDI();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MPIFNDMAGPL(IAOJDFOOKKM AOCNAKFENOF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JFGGIOGIHDH(IAOJDFOOKKM AOCNAKFENOF);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ICCINPMJGMK(IAOJDFOOKKM AOCNAKFENOF, HashSet<IAOJDFOOKKM> AFMJMBPJHEF);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ACFIBINKLDG(IAOJDFOOKKM AOCNAKFENOF, IAOJDFOOKKM KAHNGDAIILP, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CHHAINLNAIO(IAOJDFOOKKM AOCNAKFENOF, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CKDEILGJDGD(IAOJDFOOKKM AOCNAKFENOF);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GDGHHGOMGAP MNPCEBMABPB(bool IKIOPJMFBOI);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GDGHHGOMGAP BBBEGLHOJHB(HashSet<Guid> JLHODLGIEHP, bool IKIOPJMFBOI);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool OMNGFPJAGEG(MBICFHCMLGE MEADHOGLMCH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LJMEGBHCLMB(GDGHHGOMGAP MJIPOIHPELF);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CNGFDOFNFAF(GDGHHGOMGAP MJIPOIHPELF);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EEFJHDOLMIE(GDGHHGOMGAP MJIPOIHPELF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LBBLKOODKKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FHKJMHOOCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IAOJDFOOKKM OLEKENEOODK(int NKBIAPBCPPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IAOJDFOOKKM EIFIKEIDALO(Guid APAGADNNCLF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MMJCCFIAJAG(IAOJDFOOKKM AOCNAKFENOF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GPGLCNBMNCH();

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HANLDOKGDEN(IAOJDFOOKKM PNFMDINJCCC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CLCNDOBGJIN(EFJALHABEDM.Application)]
public interface FODHCFGBKAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JCEADOAPIIJ(EJGPBINEJMK PNFMDINJCCC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHAGNEOOMGK(EJGPBINEJMK PNFMDINJCCC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string APPLPIEIJAO(EJGPBINEJMK PNFMDINJCCC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid GBCALNJLGFA(EJGPBINEJMK PNFMDINJCCC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JDGCIMCDCKG(EJGPBINEJMK PNFMDINJCCC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCDCGDLMGLJ(EJGPBINEJMK PNFMDINJCCC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void JJAEGLGNMJA(IAOJDFOOKKM ALFKNEDFOMP, int EEDELNLHPEE, IAOJDFOOKKM MEBMODKBLMJ, int CMPBDGKFHBH, [Optional] Vector3? NFLJEBOHHJC, [Optional] Quaternion? MLKLKFAFGOA);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void CKFGHHNONIF(IAOJDFOOKKM CMNEIKGBAMH, IAOJDFOOKKM CDKBGOFKBBA);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EJGPBINEJMK : IAOJDFOOKKM, EHFGPHIAIHJ, IEquatable<IAOJDFOOKKM>
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NMIDOBPPEGG : EHFGPHIAIHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IAOJDFOOKKM HIAFGLDCCGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IEnumerable<IAOJDFOOKKM> IJHDOGJABLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Vector3 JOACALEEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	Quaternion LCENIHEGHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool OKOMNIOFKPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool GOADDCALFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event JJAEGLGNMJA JGINDJMMCJB;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event JJAEGLGNMJA IDOPFOMBCDF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event JJAEGLGNMJA DIHGKIHCIGP;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event CKFGHHNONIF CBBAFPKADDE;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ADDAPIJFNFE();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DDALJGFIKBD();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PMPAMMDLKGK();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BCOGOPMIICO();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OCMJMEPLKGN();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EBFFLDHFPGP();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PFMLKDICJCA(int CDOJPCACMLI, IAOJDFOOKKM MEBMODKBLMJ, int ADABEOJGFOM);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ILGBMFALLHN();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ECBDEPBEMBD(int CDOJPCACMLI, IAOJDFOOKKM ALFKNEDFOMP, int DNBAOFPJHDM, [Optional] Vector3? NFLJEBOHHJC, [Optional] Quaternion? MLKLKFAFGOA);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ABEHKDMBHLB(IAOJDFOOKKM ALFKNEDFOMP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HDDKGOBOEFG();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IKBCIIBHGAM(int ILNNGHKJMBD, Vector3 MFLOBHGAOMJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PCGDKNGEAOM(Vector3 FAMAJHDMHPB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NIBEAADCHGG
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 FCCOBDCCDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PLOJGIJGGPN
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool DPPDKIHAAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	JNALEALJDPP OPIAEKMOLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ConnectableConfigData : ScriptableObject, PLOJGIJGGPN
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x82CC20", Offset = "0x82BE20", VA = "0x18082CC20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public JNALEALJDPP LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60B2950", Offset = "0x60B1B50", VA = "0x1860B2950")]
		public static ConnectableConfigData FNCKBANFEBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60B2A00", Offset = "0x60B1C00", VA = "0x1860B2A00")]
		public ConnectableConfigData(LegacyConnectableLinkVisual MPDLIBAEJDG, bool BCLAFKHLPIH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct AENGMBBNOAE : IEquatable<AENGMBBNOAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IAOJDFOOKKM AOCNAKFENOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int ADJODDIMGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int NBMKENACNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Vector3 NFLJEBOHHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Quaternion MLKLKFAFGOA;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x60B0A80", Offset = "0x60AFC80", VA = "0x1860B0A80")]
	public AENGMBBNOAE(IAOJDFOOKKM AOCNAKFENOF, int ADJODDIMGCL, int NBMKENACNNB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x60B0950", Offset = "0x60AFB50", VA = "0x1860B0950")]
	public AENGMBBNOAE(IAOJDFOOKKM AOCNAKFENOF, int ADJODDIMGCL, int NBMKENACNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x60B09F0", Offset = "0x60AFBF0", VA = "0x1860B09F0")]
	public AENGMBBNOAE(IAOJDFOOKKM AOCNAKFENOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x60B04E0", Offset = "0x60AF6E0", VA = "0x1860B04E0", Slot = "4")]
	public bool Equals(AENGMBBNOAE NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x60B0590", Offset = "0x60AF790", VA = "0x1860B0590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[UnityEngine.Scripting.Preserve]
public class NLPEBNKHIKM : ICJJDHGOHEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform ABJBIFMIENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private JNALEALJDPP KCIIJCIAMDE;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5BD5750", Offset = "0x5BD4950", VA = "0x185BD5750", Slot = "4")]
	public void AKCGAJHNOGB(Transform ABJBIFMIENO, JNALEALJDPP KCIIJCIAMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x60C2DE0", Offset = "0x60C1FE0", VA = "0x1860C2DE0", Slot = "5")]
	public JNALEALJDPP EACENENGOHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x60C2EB0", Offset = "0x60C20B0", VA = "0x1860C2EB0", Slot = "6")]
	public void EEHIMDHDPDN(JNALEALJDPP LONFFAADIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public NLPEBNKHIKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal class MNKHMAFLAKI : IDisposable, AEOCFDCHBKG
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FIFKCNIMJGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public IAOJDFOOKKM oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IAOJDFOOKKM newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public FIFKCNIMJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x60B3240", Offset = "0x60B2440", VA = "0x1860B3240")]
		internal bool JKGLFICPOMM(DKKHFGFOFHA node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly FLHGGMBBFFL LFDKMBMHAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private CNPNCHGFIJM PLFDHHDNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NAMLBCILDCH PEJADMGELMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool BCLAFKHLPIH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public DKKHFGFOFHA EJPDLJOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x60BF360", Offset = "0x60BE560", VA = "0x1860BF360")]
	public bool HHAODCIIFMF([In] CJKPBIMOIMB GKNJGNIHLDH, bool CDBJFNDMNNL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60C0010", Offset = "0x60BF210", VA = "0x1860C0010")]
	private bool LBPNEDGNMIN([In] CJKPBIMOIMB GKNJGNIHLDH, bool CDBJFNDMNNL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x60C28C0", Offset = "0x60C1AC0", VA = "0x1860C28C0")]
	public MNKHMAFLAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x60BDEE0", Offset = "0x60BD0E0", VA = "0x1860BDEE0", Slot = "5")]
	public void AKCGAJHNOGB(ACKBPNEOKDH HOHFFEHOKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x60C06D0", Offset = "0x60BF8D0", VA = "0x1860C06D0", Slot = "17")]
	public void MLCLHMDAHML(AIDLIHOBHAI FPMNHFJNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x60BF760", Offset = "0x60BE960", VA = "0x1860BF760", Slot = "12")]
	public void IDBAAODNHMH(Func<IAOJDFOOKKM, bool> MMHKCPEIAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60BF770", Offset = "0x60BE970", VA = "0x1860BF770")]
	private void IDBAAODNHMH(FLHGGMBBFFL DEBAEMIFHOC, Func<IAOJDFOOKKM, bool> MMHKCPEIAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60C1AA0", Offset = "0x60C0CA0", VA = "0x1860C1AA0", Slot = "11")]
	public void OCMNAPDNCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60BEDF0", Offset = "0x60BDFF0", VA = "0x1860BEDF0", Slot = "8")]
	public bool FJMHIPPMPMG(IAOJDFOOKKM EAFJACPHBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x60C1130", Offset = "0x60C0330", VA = "0x1860C1130")]
	private bool NJKOEMKPPCM(IAOJDFOOKKM MMGPCJIPIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60BDC60", Offset = "0x60BCE60", VA = "0x1860BDC60")]
	private static bool AAALHMOOALL(IAOJDFOOKKM MMGPCJIPIFO, FLHGGMBBFFL OJNKOGECBJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60C0700", Offset = "0x60BF900", VA = "0x1860C0700")]
	private void MMEIOEFAMPP(Transform LHBNEBCIIJL, FLHGGMBBFFL LIELADIKHOK, FLHGGMBBFFL[] DGEPGABHGPK, IAOJDFOOKKM CNLOJGEBGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60BDF70", Offset = "0x60BD170", VA = "0x1860BDF70")]
	private AENGMBBNOAE AMFGCHHOGIP(Transform AMFFGDPJKMM, AENGMBBNOAE GPHAIMODKKB)
	{
		return default(AENGMBBNOAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x60C1800", Offset = "0x60C0A00", VA = "0x1860C1800")]
	private static bool NOFMIAJDGDL(FLHGGMBBFFL OJNKOGECBJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x60BE0C0", Offset = "0x60BD2C0", VA = "0x1860BE0C0")]
	private string APPLPIEIJAO(IAOJDFOOKKM AOCNAKFENOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x60BFA60", Offset = "0x60BEC60", VA = "0x1860BFA60")]
	private string JDGCIMCDCKG(IAOJDFOOKKM AOCNAKFENOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60BE410", Offset = "0x60BD610", VA = "0x1860BE410")]
	private void CBACNIAAJKN([In] CJKPBIMOIMB GKNJGNIHLDH, bool MGGIINCHPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60BDD10", Offset = "0x60BCF10", VA = "0x1860BDD10")]
	private void ABEOCJOPJGO(IAOJDFOOKKM HLNBFGHFDID, bool MGGIINCHPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x60C1D60", Offset = "0x60C0F60", VA = "0x1860C1D60")]
	private void PGEFINGLGHA(IAOJDFOOKKM DIFNGOGOJCN, int DNBAOFPJHDM, IAOJDFOOKKM IKEECPHGAFL, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA, bool MGGIINCHPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x60C0AF0", Offset = "0x60BFCF0", VA = "0x1860C0AF0")]
	private void MOFAGLDCDAI(IAOJDFOOKKM CGBHDJDEMMI, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA, bool KLNMJLFJPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x60C19C0", Offset = "0x60C0BC0", VA = "0x1860C19C0", Slot = "9")]
	public bool OCKBNLDINHC(IAOJDFOOKKM CGBHDJDEMMI, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x60BFDE0", Offset = "0x60BEFE0", VA = "0x1860BFDE0")]
	private bool KAGNIOOCOOG(IAOJDFOOKKM CGBHDJDEMMI, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60BEA30", Offset = "0x60BDC30", VA = "0x1860BEA30")]
	private static void DNEOCBPFDGE(IAOJDFOOKKM CGBHDJDEMMI, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA, FLHGGMBBFFL FOPBOIDMMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x60BECD0", Offset = "0x60BDED0", VA = "0x1860BECD0")]
	private void FEIBILNEOGL(IAOJDFOOKKM DIFNGOGOJCN, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x60BF030", Offset = "0x60BE230", VA = "0x1860BF030")]
	private void FMLFHKPEHHA(FLHGGMBBFFL DEBAEMIFHOC, IAOJDFOOKKM ENMJNEHIPIF, IAOJDFOOKKM IPCGHMHOPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60BEFC0", Offset = "0x60BE1C0", VA = "0x1860BEFC0")]
	private void FMLFHKPEHHA(IAOJDFOOKKM AOCNAKFENOF, IAOJDFOOKKM ENMJNEHIPIF, IAOJDFOOKKM IPCGHMHOPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60C1BF0", Offset = "0x60C0DF0", VA = "0x1860C1BF0")]
	private void ONCAFKFJPNJ(IAOJDFOOKKM AOCNAKFENOF, IAOJDFOOKKM ENMJNEHIPIF, IAOJDFOOKKM IPCGHMHOPBO, bool AMNEJFLDELB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x60C1C60", Offset = "0x60C0E60", VA = "0x1860C1C60")]
	private void ONCAFKFJPNJ(FLHGGMBBFFL EAMCHADGEIB, IAOJDFOOKKM CNLOJGEBGEH, IAOJDFOOKKM CDKBGOFKBBA, bool AMNEJFLDELB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x60BEBB0", Offset = "0x60BDDB0", VA = "0x1860BEBB0")]
	private void EJMBKJJPMIA(IAOJDFOOKKM HLNBFGHFDID, int DNBAOFPJHDM, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x60BF0A0", Offset = "0x60BE2A0", VA = "0x1860BF0A0")]
	private void GOACIEAJLCI(DKKHFGFOFHA DMKJLMNBOME, DKKHFGFOFHA OICGBOBKFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x60BF200", Offset = "0x60BE400", VA = "0x1860BF200", Slot = "18")]
	public IAOJDFOOKKM HACDAEGLIKI(IAOJDFOOKKM AOCNAKFENOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60BF3B0", Offset = "0x60BE5B0", VA = "0x1860BF3B0", Slot = "13")]
	public void ICCINPMJGMK(IAOJDFOOKKM AOCNAKFENOF, HashSet<IAOJDFOOKKM> PEKKODHIAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x60BFAD0", Offset = "0x60BECD0", VA = "0x1860BFAD0", Slot = "14")]
	public List<IAOJDFOOKKM> JEGEODMDJDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60BE2A0", Offset = "0x60BD4A0", VA = "0x1860BE2A0")]
	protected DKKHFGFOFHA BENLGFEBBKI(DKKHFGFOFHA DEBAEMIFHOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60BE370", Offset = "0x60BD570", VA = "0x1860BE370")]
	protected FLHGGMBBFFL[] BGBHOHMLKJE(FLHGGMBBFFL OJNKOGECBJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60BE190", Offset = "0x60BD390", VA = "0x1860BE190")]
	protected bool BAODHKMFGOL(IAOJDFOOKKM AOCNAKFENOF, [Out] FLHGGMBBFFL DEBAEMIFHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x60C1AC0", Offset = "0x60C0CC0", VA = "0x1860C1AC0", Slot = "15")]
	public bool ODIEDLMANEG(IAOJDFOOKKM AOCNAKFENOF, [Out] AENGMBBNOAE EDLMNIKMOBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x60C10F0", Offset = "0x60C02F0", VA = "0x1860C10F0")]
	protected FLHGGMBBFFL NHBIDFAOJBK(AENGMBBNOAE KAPEKNPLMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x60C05E0", Offset = "0x60BF7E0", VA = "0x1860C05E0", Slot = "10")]
	public bool LJJNKPBBGFF(IAOJDFOOKKM DIFNGOGOJCN, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x60C2330", Offset = "0x60C1530", VA = "0x1860C2330")]
	private bool PGEOFDCLNGM(IAOJDFOOKKM DIFNGOGOJCN, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x60BFD10", Offset = "0x60BEF10", VA = "0x1860BFD10")]
	private static bool JHBLNIEHNML(FLHGGMBBFFL FIEOJNPNHDF, AENGMBBNOAE PHNBGMPPHCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x60BF360", Offset = "0x60BE560", VA = "0x1860BF360", Slot = "7")]
	private bool NMAGGDFDFKL([In] CJKPBIMOIMB GKNJGNIHLDH, bool CDBJFNDMNNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[UnityEngine.Scripting.Preserve]
internal class JCOAJGAFJJE : ACKBPNEOKDH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly IAIHJGNDPNA DEFANHHPGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly NAMLBCILDCH PEJADMGELMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly DBJHJAJCNPA BCAOBIECMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly AEDNAFAFIMG DNGPCONFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly AEOCFDCHBKG MJIPOIHPELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal OFANCJFEEBL NJKFJGHCCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal BBLPCNBOHLK CEKLKFPPGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal CNPNCHGFIJM JDNOCMOCIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal bool BCLAFKHLPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool BALPIGAEMDB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool KKLMCNGKKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1726620", Offset = "0x1725820", VA = "0x181726620")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1726640", Offset = "0x1725840", VA = "0x181726640")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool BINBACMBECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1726600", Offset = "0x1725800", VA = "0x181726600", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x17265F0", Offset = "0x17257F0", VA = "0x1817265F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<IAOJDFOOKKM, IAOJDFOOKKM> KAHCOKMFCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x60B5800", Offset = "0x60B4A00", VA = "0x1860B5800", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x60B5BE0", Offset = "0x60B4DE0", VA = "0x1860B5BE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<IAOJDFOOKKM, IAOJDFOOKKM> DAOJDAEDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x60B5D10", Offset = "0x60B4F10", VA = "0x1860B5D10", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x60B5520", Offset = "0x60B4720", VA = "0x1860B5520", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<IAOJDFOOKKM, IAOJDFOOKKM, IAOJDFOOKKM> IFOBBFPNBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x60B4F20", Offset = "0x60B4120", VA = "0x1860B4F20", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x60B5D70", Offset = "0x60B4F70", VA = "0x1860B5D70", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x60B5FC0", Offset = "0x60B51C0", VA = "0x1860B5FC0")]
	public JCOAJGAFJJE(IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x60B4930", Offset = "0x60B3B30", VA = "0x1860B4930", Slot = "11")]
	public void AKCGAJHNOGB(GameObject JLBELLDLMIF, PLOJGIJGGPN BCEAEHFLDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x60B5580", Offset = "0x60B4780", VA = "0x1860B5580", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x60B58C0", Offset = "0x60B4AC0", VA = "0x1860B58C0", Slot = "12")]
	public void HIJKAFNAKDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x60B5CF0", Offset = "0x60B4EF0", VA = "0x1860B5CF0", Slot = "13")]
	public void MPIFNDMAGPL(IAOJDFOOKKM AOCNAKFENOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x60B5860", Offset = "0x60B4A60", VA = "0x1860B5860", Slot = "14")]
	public void JFGGIOGIHDH(IAOJDFOOKKM AOCNAKFENOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x60B5F20", Offset = "0x60B5120", VA = "0x1860B5F20", Slot = "21")]
	public bool OMNGFPJAGEG(MBICFHCMLGE MEADHOGLMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x60B5B20", Offset = "0x60B4D20", VA = "0x1860B5B20")]
	internal bool LBPNEDGNMIN([In] CJKPBIMOIMB GKNJGNIHLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x60B5F30", Offset = "0x60B5130", VA = "0x1860B5F30")]
	internal bool PGEOFDCLNGM([In] CJKPBIMOIMB GKNJGNIHLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x60B5660", Offset = "0x60B4860", VA = "0x1860B5660")]
	internal bool FDGGFAABEKM([In] CJKPBIMOIMB GKNJGNIHLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x60B5DD0", Offset = "0x60B4FD0", VA = "0x1860B5DD0")]
	internal bool NLNODGLHNOA([In] CJKPBIMOIMB GKNJGNIHLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x60B4F80", Offset = "0x60B4180", VA = "0x1860B4F80")]
	internal void BNNCBIDDAKA(IAOJDFOOKKM AOCNAKFENOF, int EIEBBKIGHFG, bool CDBJFNDMNNL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x60B5860", Offset = "0x60B4A60", VA = "0x1860B5860")]
	internal bool GPPJJLDMBOJ(IAOJDFOOKKM JFCKOKDKNDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x60B56C0", Offset = "0x60B48C0", VA = "0x1860B56C0")]
	internal bool FLKCAADCEEA(IAOJDFOOKKM CGBHDJDEMMI, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x60B5910", Offset = "0x60B4B10", VA = "0x1860B5910", Slot = "15")]
	public void ICCINPMJGMK(IAOJDFOOKKM AOCNAKFENOF, HashSet<IAOJDFOOKKM> AFMJMBPJHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x60B4720", Offset = "0x60B3920", VA = "0x1860B4720", Slot = "16")]
	public void ACFIBINKLDG(IAOJDFOOKKM CGBHDJDEMMI, IAOJDFOOKKM KAHNGDAIILP, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x60B5160", Offset = "0x60B4360", VA = "0x1860B5160", Slot = "17")]
	public void CHHAINLNAIO(IAOJDFOOKKM DIFNGOGOJCN, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x60B52A0", Offset = "0x60B44A0", VA = "0x1860B52A0", Slot = "18")]
	public void CKDEILGJDGD(IAOJDFOOKKM DIFNGOGOJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x60B5A10", Offset = "0x60B4C10", VA = "0x1860B5A10")]
	public void ICLHBADHJHO([Optional] JDIKGCGDGPK DEGEGABMEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x60B5C40", Offset = "0x60B4E40", VA = "0x1860B5C40", Slot = "22")]
	public void LJMEGBHCLMB(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x60B5CD0", Offset = "0x60B4ED0", VA = "0x1860B5CD0", Slot = "19")]
	public GDGHHGOMGAP MNPCEBMABPB(bool IKIOPJMFBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x60B4F00", Offset = "0x60B4100", VA = "0x1860B4F00", Slot = "20")]
	public GDGHHGOMGAP BBBEGLHOJHB(HashSet<Guid> JLHODLGIEHP, bool IKIOPJMFBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x60B5620", Offset = "0x60B4820", VA = "0x1860B5620", Slot = "24")]
	public void EEFJHDOLMIE(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x60B5470", Offset = "0x60B4670", VA = "0x1860B5470", Slot = "23")]
	public void CNGFDOFNFAF(GDGHHGOMGAP MJIPOIHPELF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class NAMLBCILDCH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly KIDGADDAONM<IAOJDFOOKKM, IAOJDFOOKKM> KAHCOKMFCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly KIDGADDAONM<IAOJDFOOKKM, IAOJDFOOKKM> DAOJDAEDNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly HHNANIHJCKD<IAOJDFOOKKM, IAOJDFOOKKM, IAOJDFOOKKM> IFOBBFPNBOE;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x60C2BD0", Offset = "0x60C1DD0", VA = "0x1860C2BD0")]
	public NAMLBCILDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
	public void AKCGAJHNOGB(JCOAJGAFJJE HOHFFEHOKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x60C2B70", Offset = "0x60C1D70", VA = "0x1860C2B70")]
	public void GCEJBDPAIAF(IAOJDFOOKKM DMKJLMNBOME, IAOJDFOOKKM HLNBFGHFDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x60C2A90", Offset = "0x60C1C90", VA = "0x1860C2A90")]
	public void DHHBOLLNGJA(IAOJDFOOKKM DMKJLMNBOME, IAOJDFOOKKM HLNBFGHFDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x60C2AF0", Offset = "0x60C1CF0", VA = "0x1860C2AF0")]
	public void FJPGAPOGGEM(IAOJDFOOKKM LNHLHMFAGMG, IAOJDFOOKKM IKEECPHGAFL, IAOJDFOOKKM HLNBFGHFDID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class DBJHJAJCNPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private JCOAJGAFJJE HOHFFEHOKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private BBLPCNBOHLK CEKLKFPPGJA;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public DBJHJAJCNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x60B2A50", Offset = "0x60B1C50", VA = "0x1860B2A50")]
	public void AKCGAJHNOGB(JCOAJGAFJJE HOHFFEHOKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x60B2C80", Offset = "0x60B1E80", VA = "0x1860B2C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x60B2C90", Offset = "0x60B1E90", VA = "0x1860B2C90")]
	private void LIICBCCABGL(JDIKGCGDGPK DONKKIJPHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x60B2DB0", Offset = "0x60B1FB0", VA = "0x1860B2DB0")]
	private void PDACGPFNHEL(JDIKGCGDGPK MEPAJIJBEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x60B2CB0", Offset = "0x60B1EB0", VA = "0x1860B2CB0")]
	public void NEIHJCOFAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x60B2B80", Offset = "0x60B1D80", VA = "0x1860B2B80")]
	public void DMLBCMMEDMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class HFNFHMDBFDM
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JMLNLBICADD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IAIHJGNDPNA container;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public JMLNLBICADD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x60B6570", Offset = "0x60B5770", VA = "0x1860B6570")]
		internal JCOAJGAFJJE IJLOMFCICEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x60B44A0", Offset = "0x60B36A0", VA = "0x1860B44A0")]
	public static void CHCGCJKPKIM(IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x60B46A0", Offset = "0x60B38A0", VA = "0x1860B46A0")]
	public static void GKEHBGFKHIF(IAIHJGNDPNA DEFANHHPGKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[UnityEngine.Scripting.Preserve]
internal class ABKELDGIJHM : IDisposable, CNPNCHGFIJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Dictionary<int, JNALEALJDPP> GOAIFNFEGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly AIDLIHOBHAI GPOIGCFHCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private ICJJDHGOHEA NPFLMAIICPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private AEOCFDCHBKG MJIPOIHPELF;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x60AD5A0", Offset = "0x60AC7A0", VA = "0x1860AD5A0")]
	public ABKELDGIJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x60ACA20", Offset = "0x60ABC20", VA = "0x1860ACA20", Slot = "7")]
	public void AKCGAJHNOGB(AEOCFDCHBKG MJIPOIHPELF, ICJJDHGOHEA NPFLMAIICPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x60AD360", Offset = "0x60AC560", VA = "0x1860AD360", Slot = "5")]
	public void PEIHKPMIANF(DKKHFGFOFHA DGKJFLMMOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x60ACDB0", Offset = "0x60ABFB0", VA = "0x1860ACDB0", Slot = "9")]
	public void HHKBDMMNEGF(DKKHFGFOFHA MNFOBBFNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x60ACF20", Offset = "0x60AC120", VA = "0x1860ACF20", Slot = "8")]
	public void LLEAAIKBBJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x60ACA60", Offset = "0x60ABC60", VA = "0x1860ACA60", Slot = "10")]
	public void CFOIHEPNNLA(DKKHFGFOFHA MCKLONCFMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x60AD0E0", Offset = "0x60AC2E0", VA = "0x1860AD0E0", Slot = "11")]
	public void OBONMFIBLKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x60AD1B0", Offset = "0x60AC3B0", VA = "0x1860AD1B0")]
	private bool ODGBGJLGAGL(DKKHFGFOFHA GCKJNKIBEKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class AEDNAFAFIMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct KOPJALOLLDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly FLHGGMBBFFL LEDDLOMFIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly HashSet<Guid> JLHODLGIEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly MBICFHCMLGE NKKELMCHNEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly MBICFHCMLGE PACOJENLPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly bool IKIOPJMFBOI;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool GGGCDJOPFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x60B6910", Offset = "0x60B5B10", VA = "0x1860B6910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x60B6E50", Offset = "0x60B6050", VA = "0x1860B6E50")]
		public KOPJALOLLDP(FLHGGMBBFFL LEDDLOMFIKC, HashSet<Guid> JLHODLGIEHP, bool IKIOPJMFBOI, [Optional] MBICFHCMLGE NKKELMCHNEG, [Optional] MBICFHCMLGE PACOJENLPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x60B67A0", Offset = "0x60B59A0", VA = "0x1860B67A0")]
		public MBICFHCMLGE CJMGAEMJONM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x60B6D90", Offset = "0x60B5F90", VA = "0x1860B6D90")]
		private MBICFHCMLGE ONAGGJFBFKI([Out] MBICFHCMLGE JEDDFDCHNDJ, [Out] MBICFHCMLGE EJILNEOJLIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x60B6A30", Offset = "0x60B5C30", VA = "0x1860B6A30")]
		private MBICFHCMLGE JPELHGGNAJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x60B6C20", Offset = "0x60B5E20", VA = "0x1860B6C20")]
		private void NOANIPJAGLH(MBICFHCMLGE NJMFCKFPGLO, MBICFHCMLGE NKEKDDCHNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x60B65E0", Offset = "0x60B57E0", VA = "0x1860B65E0")]
		private void CJGEGMFLGGM(MBICFHCMLGE JEDDFDCHNDJ, MBICFHCMLGE EJILNEOJLIC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private JCOAJGAFJJE HOHFFEHOKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private AEOCFDCHBKG MJIPOIHPELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private CNPNCHGFIJM PLFDHHDNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private BBLPCNBOHLK CEKLKFPPGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool FKBAJFFGGLL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private bool PIJJPOBIDBC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x60AEC20", Offset = "0x60ADE20", VA = "0x1860AEC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private bool KKLMCNGKKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x60AD680", Offset = "0x60AC880", VA = "0x1860AD680")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x60AEC00", Offset = "0x60ADE00", VA = "0x1860AEC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x60AD6A0", Offset = "0x60AC8A0", VA = "0x1860AD6A0")]
	public void AKCGAJHNOGB(JCOAJGAFJJE HOHFFEHOKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x60AF150", Offset = "0x60AE350", VA = "0x1860AF150")]
	public GDGHHGOMGAP MNPCEBMABPB(bool IKIOPJMFBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x60AD710", Offset = "0x60AC910", VA = "0x1860AD710")]
	public GDGHHGOMGAP BBBEGLHOJHB(HashSet<Guid> JLHODLGIEHP, bool IKIOPJMFBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x60AF0C0", Offset = "0x60AE2C0", VA = "0x1860AF0C0")]
	public void LJMEGBHCLMB(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x60ADFD0", Offset = "0x60AD1D0", VA = "0x1860ADFD0")]
	public void CNGFDOFNFAF(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x60ADE40", Offset = "0x60AD040", VA = "0x1860ADE40")]
	public void BKELCMJFIDC(GDGHHGOMGAP MJIPOIHPELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x60AE550", Offset = "0x60AD750", VA = "0x1860AE550")]
	private void DOANJHNGHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x60AEC70", Offset = "0x60ADE70", VA = "0x1860AEC70")]
	private MBICFHCMLGE ICDMAGBKJPK(FLHGGMBBFFL DEBAEMIFHOC, bool IKIOPJMFBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x60AE070", Offset = "0x60AD270", VA = "0x1860AE070")]
	private static void DHMBECPHJDA(FLHGGMBBFFL DEBAEMIFHOC, bool IKIOPJMFBOI, MBICFHCMLGE MEADHOGLMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x60AFD00", Offset = "0x60AEF00", VA = "0x1860AFD00")]
	private void NPKFHOPDNDF(FLHGGMBBFFL DEBAEMIFHOC, bool IKIOPJMFBOI, MBICFHCMLGE MEADHOGLMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x60B0450", Offset = "0x60AF650", VA = "0x1860B0450")]
	private MBICFHCMLGE PEIHAEFAMJJ(FLHGGMBBFFL LEDDLOMFIKC, HashSet<Guid> JLHODLGIEHP, bool IKIOPJMFBOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x60AE2C0", Offset = "0x60AD4C0", VA = "0x1860AE2C0")]
	private bool DNJEEKIGPBL(GDGHHGOMGAP IMPOCMBGPLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x60AF690", Offset = "0x60AE890", VA = "0x1860AF690")]
	private bool NOMDNOHEOFG(MBICFHCMLGE MEADHOGLMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x60AEBE0", Offset = "0x60ADDE0", VA = "0x1860AEBE0")]
	private bool GFOKBGNLALA(GDGHHGOMGAP MJIPOIHPELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x60B00E0", Offset = "0x60AF2E0", VA = "0x1860B00E0")]
	private static bool OLPLAOIMCGB(MBICFHCMLGE MEADHOGLMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x60B0200", Offset = "0x60AF400", VA = "0x1860B0200")]
	public static bool OMNGFPJAGEG(MBICFHCMLGE MEADHOGLMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x60AE740", Offset = "0x60AD940", VA = "0x1860AE740")]
	private IAOJDFOOKKM EHECJMEHKMP(MBICFHCMLGE MEADHOGLMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x60AFF60", Offset = "0x60AF160", VA = "0x1860AFF60")]
	private IAOJDFOOKKM OLEKENEOODK(MBICFHCMLGE MEADHOGLMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x60AEA70", Offset = "0x60ADC70", VA = "0x1860AEA70")]
	private IAOJDFOOKKM GDBGJNLLOOJ(MBICFHCMLGE MEADHOGLMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x60AFF20", Offset = "0x60AF120", VA = "0x1860AFF20")]
	private static Guid OCJLHBHJBJA(MBICFHCMLGE MEADHOGLMCH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x60ADD50", Offset = "0x60ACF50", VA = "0x1860ADD50")]
	private string BJFDEHKNDKG(MBICFHCMLGE MEADHOGLMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x60ADE70", Offset = "0x60AD070", VA = "0x1860ADE70")]
	private bool CLHKNGMLOFL(FLHGGMBBFFL DEBAEMIFHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x60AEE60", Offset = "0x60AE060", VA = "0x1860AEE60")]
	private static void JIPEPELCIDI(FLHGGMBBFFL LEDDLOMFIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public AEDNAFAFIMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct CJKPBIMOIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public IAOJDFOOKKM HLNBFGHFDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IAOJDFOOKKM DMKJLMNBOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int DNBAOFPJHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int ADABEOJGFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector3 NFLJEBOHHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Quaternion MLKLKFAFGOA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public AENGMBBNOAE CKHDMADBMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x60B2810", Offset = "0x60B1A10", VA = "0x1860B2810")]
		get
		{
			return default(AENGMBBNOAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public AENGMBBNOAE COAKHCMIFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x60B28B0", Offset = "0x60B1AB0", VA = "0x1860B28B0")]
		get
		{
			return default(AENGMBBNOAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x60B28E0", Offset = "0x60B1AE0", VA = "0x1860B28E0")]
	public CJKPBIMOIMB(IAOJDFOOKKM HLNBFGHFDID, IAOJDFOOKKM DMKJLMNBOME, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface AEOCFDCHBKG
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DKKHFGFOFHA EJPDLJOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKCGAJHNOGB(ACKBPNEOKDH HOHFFEHOKPA);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HHAODCIIFMF([In] CJKPBIMOIMB GKNJGNIHLDH, bool CDBJFNDMNNL = true);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FJMHIPPMPMG(IAOJDFOOKKM EAFJACPHBEK);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OCKBNLDINHC(IAOJDFOOKKM CGBHDJDEMMI, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LJJNKPBBGFF(IAOJDFOOKKM DIFNGOGOJCN, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCMNAPDNCEL();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IDBAAODNHMH(Func<IAOJDFOOKKM, bool> MMHKCPEIAGI);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ICCINPMJGMK(IAOJDFOOKKM AOCNAKFENOF, HashSet<IAOJDFOOKKM> PEKKODHIAGH);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<IAOJDFOOKKM> JEGEODMDJDI();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ODIEDLMANEG(IAOJDFOOKKM AOCNAKFENOF, [Out] AENGMBBNOAE EDLMNIKMOBH);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MLCLHMDAHML(AIDLIHOBHAI FPMNHFJNBFL);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal delegate bool AIDLIHOBHAI(DKKHFGFOFHA DEBAEMIFHOC);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface DKKHFGFOFHA
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IAOJDFOOKKM JANMGLPKDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	DKKHFGFOFHA KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	AENGMBBNOAE OKDJHACIFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool AAHANIIIIGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface JNALEALJDPP
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIODBADEDMB(IAOJDFOOKKM MEBMODKBLMJ, AENGMBBNOAE HLNBFGHFDID);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODEMJONLENM(IAOJDFOOKKM MEBMODKBLMJ, AENGMBBNOAE HLNBFGHFDID);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPENAIBPLCG(IAOJDFOOKKM MEBMODKBLMJ, AENGMBBNOAE HLNBFGHFDID);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBKFEENBHIJ(IAOJDFOOKKM MEBMODKBLMJ, AENGMBBNOAE HLNBFGHFDID);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JNALEALJDPP Instantiate(Transform ABJBIFMIENO);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNJLPFFCJBK();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface ICJJDHGOHEA
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKCGAJHNOGB(Transform ABJBIFMIENO, JNALEALJDPP KCIIJCIAMDE);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JNALEALJDPP EACENENGOHH();

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEHIMDHDPDN(JNALEALJDPP LONFFAADIHA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OFANCJFEEBL : LBBLKOODKKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMJLOEGDBOG(Guid PHPJOOIDLLB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface CNPNCHGFIJM
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEIHKPMIANF(DKKHFGFOFHA DGKJFLMMOFI);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKCGAJHNOGB(AEOCFDCHBKG MJIPOIHPELF, ICJJDHGOHEA FMPPBCCMMEN);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LLEAAIKBBJJ();

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHKBDMMNEGF(DKKHFGFOFHA MNFOBBFNMOK);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFOIHEPNNLA(DKKHFGFOFHA MCKLONCFMGM);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OBONMFIBLKF();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class FLHGGMBBFFL : DKKHFGFOFHA
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MMMBEINPKDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AENGMBBNOAE nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public FLHGGMBBFFL foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public MMMBEINPKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x60B93D0", Offset = "0x60B85D0", VA = "0x1860B93D0")]
		internal bool COPHNBCKBKC(DKKHFGFOFHA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private AENGMBBNOAE EDLMNIKMOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LinkedList<FLHGGMBBFFL> OHCDJJMBAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private FLHGGMBBFFL KKAEDGHCIGB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public AENGMBBNOAE OKDJHACIFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x332AA10", Offset = "0x3329C10", VA = "0x18332AA10", Slot = "6")]
		get
		{
			return default(AENGMBBNOAE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x60B41F0", Offset = "0x60B33F0", VA = "0x1860B41F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private FLHGGMBBFFL DMKJLMNBOME
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D40", Offset = "0x7C0F40", VA = "0x1807C1D40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x60B3700", Offset = "0x60B2900", VA = "0x1860B3700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DKKHFGFOFHA KDMGGCGDEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D40", Offset = "0x7C0F40", VA = "0x1807C1D40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public IAOJDFOOKKM JANMGLPKDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AAHANIIIIGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x60B3580", Offset = "0x60B2780", VA = "0x1860B3580", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool LMLODKNJONF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x60B33B0", Offset = "0x60B25B0", VA = "0x1860B33B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	protected FLHGGMBBFFL EAMCHADGEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x60B36E0", Offset = "0x60B28E0", VA = "0x1860B36E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x60B4220", Offset = "0x60B3420", VA = "0x1860B4220")]
	public FLHGGMBBFFL(AENGMBBNOAE OEBAIJMLOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x60B3890", Offset = "0x60B2A90", VA = "0x1860B3890")]
	public FLHGGMBBFFL LNMODEGKMKK(AENGMBBNOAE EDFFPBPIPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x60B3400", Offset = "0x60B2600", VA = "0x1860B3400")]
	public FLHGGMBBFFL CFIHPKJMAGG(AENGMBBNOAE DEDGMJNEONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x60B4010", Offset = "0x60B3210", VA = "0x1860B4010")]
	public FLHGGMBBFFL PADFOOPDKDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x60B3590", Offset = "0x60B2790", VA = "0x1860B3590")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x60B37E0", Offset = "0x60B29E0", VA = "0x1860B37E0")]
	public FLHGGMBBFFL LAIIKKNMIPC(AENGMBBNOAE IKEECPHGAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x60B39E0", Offset = "0x60B2BE0", VA = "0x1860B39E0")]
	private static void MLCLHMDAHML(FLHGGMBBFFL LPKHJJGAANA, AIDLIHOBHAI ECMAAOKDBON, bool HNJPBFOCGJK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x60B3B40", Offset = "0x60B2D40", VA = "0x1860B3B40", Slot = "9")]
	public void MLCLHMDAHML(AIDLIHOBHAI FPMNHFJNBFL, bool AMNEJFLDELB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x60B3C50", Offset = "0x60B2E50", VA = "0x1860B3C50")]
	public static string NHFMJHOHPEA(FLHGGMBBFFL LPKHJJGAANA, int IIEPAMEGCBJ = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x60B3B50", Offset = "0x60B2D50", VA = "0x1860B3B50")]
	public static FLHGGMBBFFL NHBIDFAOJBK(FLHGGMBBFFL LPKHJJGAANA, AENGMBBNOAE ANPKHOMKIKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface BBLPCNBOHLK
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool PIJJPOBIDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool FHKJMHOOCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<JDIKGCGDGPK> LIICBCCABGL;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<JDIKGCGDGPK> PDACGPFNHEL;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(JCOAJGAFJJE HOHFFEHOKPA);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(IAOJDFOOKKM CGBHDJDEMMI, IAOJDFOOKKM KAHNGDAIILP, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(IAOJDFOOKKM DIFNGOGOJCN, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(GDGHHGOMGAP JEGAHBHJKCK, [Optional] JDIKGCGDGPK DEGEGABMEKK);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, BBLPCNBOHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private JCOAJGAFJJE HOHFFEHOKPA;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool PIJJPOBIDBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x60B9100", Offset = "0x60B8300", VA = "0x1860B9100", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool FHKJMHOOCHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x60B9160", Offset = "0x60B8360", VA = "0x1860B9160", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<JDIKGCGDGPK> LIICBCCABGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x60B9050", Offset = "0x60B8250", VA = "0x1860B9050", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x60B9250", Offset = "0x60B8450", VA = "0x1860B9250", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<JDIKGCGDGPK> PDACGPFNHEL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x60B8FA0", Offset = "0x60B81A0", VA = "0x1860B8FA0", Slot = "17")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x60B91A0", Offset = "0x60B83A0", VA = "0x1860B91A0", Slot = "18")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D70", Offset = "0x7C0F70", VA = "0x1807C1D70", Slot = "21")]
		public void SetManager(JCOAJGAFJJE HOHFFEHOKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x60B8F70", Offset = "0x60B8170", VA = "0x1860B8F70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x60B7CF0", Offset = "0x60B6EF0", VA = "0x1860B7CF0", Slot = "25")]
		public void RequestMasterConnectNodes(IAOJDFOOKKM ALFKNEDFOMP, int DNBAOFPJHDM, IAOJDFOOKKM MEBMODKBLMJ, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x60B7E20", Offset = "0x60B7020", VA = "0x1860B7E20", Slot = "26")]
		public void RequestMasterDisconnectNode(IAOJDFOOKKM EAFJACPHBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x60B7EE0", Offset = "0x60B70E0", VA = "0x1860B7EE0", Slot = "22")]
		public void RequestMasterModifyNode(IAOJDFOOKKM CGBHDJDEMMI, IAOJDFOOKKM KAHNGDAIILP, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x60B8010", Offset = "0x60B7210", VA = "0x1860B8010", Slot = "23")]
		public void RequestMasterReparentNodes(IAOJDFOOKKM DIFNGOGOJCN, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x60B8140", Offset = "0x60B7340", VA = "0x1860B8140", Slot = "27")]
		public void RequestMasterReparentToRoot(IAOJDFOOKKM DIFNGOGOJCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x60B7BC0", Offset = "0x60B6DC0", VA = "0x1860B7BC0", Slot = "24")]
		public void RequestDeserializeConnectableGraph(GDGHHGOMGAP JEGAHBHJKCK, [Optional] JDIKGCGDGPK DEGEGABMEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x60B8520", Offset = "0x60B7720", VA = "0x1860B8520")]
		[PGMNNMLHHAN]
		private void RpcMasterConnectNodes(IAOJDFOOKKM ALFKNEDFOMP, int DNBAOFPJHDM, IAOJDFOOKKM MEBMODKBLMJ, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x60B87E0", Offset = "0x60B79E0", VA = "0x1860B87E0")]
		[PGMNNMLHHAN]
		private void RpcMasterDisconnectNode(IAOJDFOOKKM EAFJACPHBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x60B8B20", Offset = "0x60B7D20", VA = "0x1860B8B20")]
		[PGMNNMLHHAN]
		private void RpcMasterReparentNodes(IAOJDFOOKKM DIFNGOGOJCN, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x60B8920", Offset = "0x60B7B20", VA = "0x1860B8920")]
		[PGMNNMLHHAN]
		private void RpcMasterModifyNode(IAOJDFOOKKM CGBHDJDEMMI, IAOJDFOOKKM KAHNGDAIILP, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x60B8310", Offset = "0x60B7510", VA = "0x1860B8310")]
		[PGMNNMLHHAN]
		private void RpcConnectNodes(IAOJDFOOKKM ALFKNEDFOMP, int DNBAOFPJHDM, IAOJDFOOKKM MEBMODKBLMJ, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA, KIHHJOPIBFL GEMAFAFKINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x60B8490", Offset = "0x60B7690", VA = "0x1860B8490")]
		[PGMNNMLHHAN]
		private void RpcDisconnectNode(IAOJDFOOKKM EAFJACPHBEK, KIHHJOPIBFL GEMAFAFKINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x60B8E70", Offset = "0x60B8070", VA = "0x1860B8E70")]
		[PGMNNMLHHAN]
		private void RpcReparentNodes(IAOJDFOOKKM DIFNGOGOJCN, int OKJFFJBKKLP, IAOJDFOOKKM IKEECPHGAFL, int FODLFOPEJKB, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA, KIHHJOPIBFL GEMAFAFKINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x60B8DB0", Offset = "0x60B7FB0", VA = "0x1860B8DB0")]
		[PGMNNMLHHAN]
		private void RpcModifyNode(IAOJDFOOKKM CGBHDJDEMMI, int DNBAOFPJHDM, int ADABEOJGFOM, Vector3 NFLJEBOHHJC, Quaternion MLKLKFAFGOA, KIHHJOPIBFL GEMAFAFKINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x60B8450", Offset = "0x60B7650", VA = "0x1860B8450")]
		[PGMNNMLHHAN]
		private void RpcDeserializeConnectableGraph(GDGHHGOMGAP MJIPOIHPELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7D8080", Offset = "0x7D7280", VA = "0x1807D8080")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, JNALEALJDPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x60B7930", Offset = "0x60B6B30", VA = "0x1860B7930", Slot = "4")]
		private void LGDIKJDOKGE(IAOJDFOOKKM MEBMODKBLMJ, AENGMBBNOAE HLNBFGHFDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x60B7460", Offset = "0x60B6660", VA = "0x1860B7460", Slot = "5")]
		private void GPBEHOAIGCC(IAOJDFOOKKM MEBMODKBLMJ, AENGMBBNOAE HLNBFGHFDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x60B7AB0", Offset = "0x60B6CB0", VA = "0x1860B7AB0", Slot = "6")]
		private void NGAHLDJAANK(IAOJDFOOKKM MEBMODKBLMJ, AENGMBBNOAE HLNBFGHFDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x60B7740", Offset = "0x60B6940", VA = "0x1860B7740", Slot = "7")]
		private void KNOLAFFLKGN(IAOJDFOOKKM MEBMODKBLMJ, AENGMBBNOAE HLNBFGHFDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x60B76D0", Offset = "0x60B68D0", VA = "0x1860B76D0", Slot = "8")]
		private JNALEALJDPP IAJADOBAKGJ(Transform ABJBIFMIENO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x60B7400", Offset = "0x60B6600", VA = "0x1860B7400", Slot = "9")]
		private void DDIHNLOJLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EDCCGCGLKHK
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2636D50", Offset = "0x2635F50", VA = "0x182636D50")]
	public static PEDKIINMPFI<T> GOEEBGJEMJK<T>(this IAIHJGNDPNA DEFANHHPGKO)
	{
		return null;
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
