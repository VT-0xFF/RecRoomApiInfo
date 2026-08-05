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
using RecRoom.ShapeRendering;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JOMHLHBEIHM : PAELJEGHIJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte AEOJKKABOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] OEBBPOIGCDD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HPFNCKKNAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89AF10", Offset = "0x899710", VA = "0x18089AF10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x89AF20", Offset = "0x899720", VA = "0x18089AF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FLHOJEFLHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B2FA0", Offset = "0x7B17A0", VA = "0x1807B2FA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B2690", Offset = "0x7B0E90", VA = "0x1807B2690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float BHJFBAILKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C8590", Offset = "0x7C6D90", VA = "0x1807C8590", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C8AF0", Offset = "0x7C72F0", VA = "0x1807C8AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float MNJHDMEPOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C6DA0", VA = "0x1807C85A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C8830", Offset = "0x7C7030", VA = "0x1807C8830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> KIMEFAKGFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6525FA0", Offset = "0x65247A0", VA = "0x186525FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> BIHBGPJKDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6525FF0", Offset = "0x65247F0", VA = "0x186525FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject NJGNBOOOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x773B70", Offset = "0x772370", VA = "0x180773B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte IEKHHOONGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6525B60", Offset = "0x6524360", VA = "0x186525B60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6526140", Offset = "0x6524940", VA = "0x186526140")]
	public JOMHLHBEIHM(List<CJGFBJNOGPF> LPJDFBIEAFA, List<CJGFBJNOGPF> EKKIKBOHILC, List<BNGKBJDCOCA> LNOFNMFJMAA, Material ECIAJACKHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6526020", Offset = "0x6524820", VA = "0x186526020")]
	private int OBBKCAHJEDO(List<CJGFBJNOGPF> IOMLGAIJLNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6525E40", Offset = "0x6524640", VA = "0x186525E40")]
	private void KKDFMILBJFH(int NKLOAJMPKPL, bool HCLEBKKJGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6525BB0", Offset = "0x65243B0", VA = "0x186525BB0")]
	public void DLMOAJFLMGM(Vector3 FLLOPKACEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6525D00", Offset = "0x6524500", VA = "0x186525D00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6525E00", Offset = "0x6524600", VA = "0x186525E00")]
	public void EFJNFFOABAM(Transform LFDHECMPNFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HCPOGMCMDHN : JPGEPNLINKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class BGHAEKPOILN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HCPOGMCMDHN <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public BGHAEKPOILN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x651AA80", Offset = "0x6519280", VA = "0x18651AA80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x651A420", Offset = "0x6518C20", VA = "0x18651A420", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x651A380", Offset = "0x6518B80", VA = "0x18651A380")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x651A930", Offset = "0x6519130", VA = "0x18651A930")]
		private void PHMELMLAGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x651A3D0", Offset = "0x6518BD0", VA = "0x18651A3D0")]
		private void MDIHJEHHKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x651AA30", Offset = "0x6519230", VA = "0x18651AA30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x651A980", Offset = "0x6519180", VA = "0x18651A980", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x651A980", Offset = "0x6519180", VA = "0x18651A980", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class OJLIAOLOLAM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HCPOGMCMDHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public OJLIAOLOLAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x65293B0", Offset = "0x6527BB0", VA = "0x1865293B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6528EF0", Offset = "0x65276F0", VA = "0x186528EF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6528EA0", Offset = "0x65276A0", VA = "0x186528EA0")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6529260", Offset = "0x6527A60", VA = "0x186529260")]
		private void PHMELMLAGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6529360", Offset = "0x6527B60", VA = "0x186529360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x65292B0", Offset = "0x6527AB0", VA = "0x1865292B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x65292B0", Offset = "0x6527AB0", VA = "0x1865292B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CMBDHOFMMDB AMGOOELDKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<ENDCNFEIIBE> JLMICLILLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> JCHBDMLFIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer IPALPPAMMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MMALDANPDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool EABGDJNAFHM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<HPIGNGKGJJE> LAGOKNLGOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LDAILDHIEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x65246B0", Offset = "0x6522EB0", VA = "0x1865246B0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BNGKBJDCOCA KMAALHJBLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6525570", Offset = "0x6523D70", VA = "0x186525570", Slot = "8")]
		get
		{
			return default(BNGKBJDCOCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PEFIHHGBPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x778B40", Offset = "0x777340", VA = "0x180778B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77D860", Offset = "0x77C060", VA = "0x18077D860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6525300", Offset = "0x6523B00", VA = "0x186525300")]
	private bool NNBFMDKLHHK(ENDCNFEIIBE ALKNPJBKLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6523EE0", Offset = "0x65226E0", VA = "0x186523EE0")]
	private static bool AOJPLNELAOE(ENDCNFEIIBE ALKNPJBKLCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6525640", Offset = "0x6523E40", VA = "0x186525640")]
	public HCPOGMCMDHN(CMBDHOFMMDB FCHBDAMJEHN, bool FEDFDOLICOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6523F80", Offset = "0x6522780", VA = "0x186523F80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6524910", Offset = "0x6523110", VA = "0x186524910")]
	public void INCGBOEKEGG(ENDCNFEIIBE ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x65246F0", Offset = "0x6522EF0", VA = "0x1865246F0")]
	public void FMCALLKJEMI(ENDCNFEIIBE ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6524BD0", Offset = "0x65233D0", VA = "0x186524BD0", Slot = "4")]
	public void MEDDCFNEDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6525320", Offset = "0x6523B20", VA = "0x186525320")]
	public void OMANMGAMPNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6525170", Offset = "0x6523970", VA = "0x186525170")]
	private void NAOJNIPGNFN(List<ENDCNFEIIBE> JLMICLILLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6524B70", Offset = "0x6523370", VA = "0x186524B70")]
	private static Material KFNMCIKACEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x65250D0", Offset = "0x65238D0", VA = "0x1865250D0")]
	private void NAOJNIPGNFN(ENDCNFEIIBE ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6524AB0", Offset = "0x65232B0", VA = "0x186524AB0")]
	private void JGKJNOCKOPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6524100", Offset = "0x6522900", VA = "0x186524100")]
	public void ENIOMDNMHNK(bool BBINKDOPJCJ, bool HCLEINNMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6524810", Offset = "0x6523010", VA = "0x186524810")]
	protected void GONBCEIGGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6523F00", Offset = "0x6522700", VA = "0x186523F00")]
	[IteratorStateMachine(typeof(BGHAEKPOILN))]
	public IEnumerable<Renderer> BNNCAGPEDBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6524890", Offset = "0x6523090", VA = "0x186524890")]
	[IteratorStateMachine(typeof(OJLIAOLOLAM))]
	public IEnumerable<Renderer> IGLHIPCIDJH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class FCCKLDKGMPL : ENDCNFEIIBE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct DKNBECHFPJD : HNDEFOGKKMF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KHBPKJNGAIG OPJNLFOIMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle JPBBNPJNGBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private CEFGKEOOKDP MLKGPGLHHHO;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x651C030", Offset = "0x651A830", VA = "0x18651C030")]
		public DKNBECHFPJD(KHBPKJNGAIG OPJNLFOIMJC, JobHandle JPBBNPJNGBC, CEFGKEOOKDP MLKGPGLHHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x651C000", Offset = "0x651A800", VA = "0x18651C000", Slot = "4")]
		public KHBPKJNGAIG NJFDFAHEDCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x651BFB0", Offset = "0x651A7B0", VA = "0x18651BFB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KGDLNMOLGPB FODEEGOBDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float OPPEDNAELNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 BEDICBILNEN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 OGEBPOAILJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6522470", Offset = "0x6520C70", VA = "0x186522470", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6523A30", Offset = "0x6522230", VA = "0x186523A30")]
	public FCCKLDKGMPL(HCPOGMCMDHN PHEKGOFMNOB, KGDLNMOLGPB FCHBDAMJEHN, bool FEDFDOLICOF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "15")]
	public override bool FBDMEEDADON(BNGKBJDCOCA PHEKGOFMNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6523790", Offset = "0x6521F90", VA = "0x186523790", Slot = "17")]
	public override int OBBKCAHJEDO(HOJOLHIILFP PLAHBEAKHNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65222A0", Offset = "0x6520AA0", VA = "0x1865222A0", Slot = "18")]
	public override int CHBHCEDFNND(HOJOLHIILFP PLAHBEAKHNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6523070", Offset = "0x6521870", VA = "0x186523070", Slot = "19")]
	public override void LKKCPFKFMEL(HOJOLHIILFP PLAHBEAKHNI, INJAPEPBNEN DKEJEJCCNLA, int MHNCAGMILEN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6523960", Offset = "0x6522160", VA = "0x186523960", Slot = "20")]
	public override BNGKBJDCOCA PDHELGINLPE()
	{
		return default(BNGKBJDCOCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6522EC0", Offset = "0x65216C0", VA = "0x186522EC0", Slot = "22")]
	public override FMMAKLCCMAN HBOLFFCKJFF()
	{
		return default(FMMAKLCCMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x65225A0", Offset = "0x6520DA0", VA = "0x1865225A0", Slot = "23")]
	public override HNDEFOGKKMF DBFHLCCAKPJ(HOJOLHIILFP PLAHBEAKHNI, JobHandle JPBBNPJNGBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DefaultMember("Item")]
public interface LOANDCBGBBE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	HCPOGMCMDHN OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ENDCNFEIIBE OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EHHMIFOJKEP OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class DMGNCCEMGJI : IFFDDCGEFNF, IDisposable, LOANDCBGBBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct PKMOEKKKKBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public DMGNCCEMGJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x652A3A0", Offset = "0x6528BA0", VA = "0x18652A3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x652A8C0", Offset = "0x65290C0", VA = "0x18652A8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly JECOOJODPDK<EDOKGBMMIIL, HCPOGMCMDHN> IOKMKDGJOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly JECOOJODPDK<KHGLBCCDCCI, ENDCNFEIIBE> JLMICLILLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly JECOOJODPDK<NJAIEPKGFJP, EHHMIFOJKEP> HDEDAHEBIKJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public HCPOGMCMDHN OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x651E140", Offset = "0x651C940", VA = "0x18651E140", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ENDCNFEIIBE OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x651E080", Offset = "0x651C880", VA = "0x18651E080", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public EHHMIFOJKEP OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x651E0E0", Offset = "0x651C8E0", VA = "0x18651E0E0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DLOMBDCEOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x854330", Offset = "0x852B30", VA = "0x180854330", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x90C880", Offset = "0x90B080", VA = "0x18090C880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x651E1A0", Offset = "0x651C9A0", VA = "0x18651E1A0")]
	public DMGNCCEMGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x651CD10", Offset = "0x651B510", VA = "0x18651CD10", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x651D670", Offset = "0x651BE70", VA = "0x18651D670", Slot = "4")]
	public EDOKGBMMIIL JLPACEBCCHB(CMBDHOFMMDB FCHBDAMJEHN)
	{
		return default(EDOKGBMMIIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x651D680", Offset = "0x651BE80", VA = "0x18651D680", Slot = "5")]
	public EDOKGBMMIIL JLPACEBCCHB(CMBDHOFMMDB FCHBDAMJEHN, bool FEDFDOLICOF)
	{
		return default(EDOKGBMMIIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x651CAB0", Offset = "0x651B2B0", VA = "0x18651CAB0", Slot = "6")]
	public void CCFHANAFCAL(EDOKGBMMIIL PHEKGOFMNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x651D180", Offset = "0x651B980", VA = "0x18651D180", Slot = "7")]
	public void IAAKHDCPJKF(EDOKGBMMIIL PHEKGOFMNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x651C450", Offset = "0x651AC50", VA = "0x18651C450", Slot = "8")]
	public KHGLBCCDCCI BDDAEBOBHLC(EDOKGBMMIIL PHEKGOFMNOB, PDDFOIOEICK FCHBDAMJEHN)
	{
		return default(KHGLBCCDCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x651D9D0", Offset = "0x651C1D0", VA = "0x18651D9D0", Slot = "9")]
	public KHGLBCCDCCI LHNINLMKNAE(EDOKGBMMIIL PHEKGOFMNOB, KGDLNMOLGPB FCHBDAMJEHN)
	{
		return default(KHGLBCCDCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x651C090", Offset = "0x651A890", VA = "0x18651C090", Slot = "11")]
	public void ACBEGADNFKM(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x651CEA0", Offset = "0x651B6A0", VA = "0x18651CEA0", Slot = "10")]
	public void GIMDMNMOPCC(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x651E010", Offset = "0x651C810", VA = "0x18651E010", Slot = "20")]
	public IEnumerable<Renderer> OAGFBJNNHDF(EDOKGBMMIIL PHEKGOFMNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x651D100", Offset = "0x651B900", VA = "0x18651D100", Slot = "12")]
	public NJAIEPKGFJP GPOIADHIPFL(BOLBBANBFLK FCHBDAMJEHN)
	{
		return default(NJAIEPKGFJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x651DFA0", Offset = "0x651C7A0", VA = "0x18651DFA0", Slot = "14")]
	public void NIOHGKNIKFA(NJAIEPKGFJP GPAFFEGFMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x651D4E0", Offset = "0x651BCE0", VA = "0x18651D4E0", Slot = "16")]
	public Task JGCBBOLOBOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x651C930", Offset = "0x651B130", VA = "0x18651C930", Slot = "17")]
	public Task CBIPMAHGOJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x651D900", Offset = "0x651C100", VA = "0x18651D900", Slot = "18")]
	[AsyncStateMachine(typeof(PKMOEKKKKBD))]
	public Task LCMAGAPNHAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x651DEB0", Offset = "0x651C6B0", VA = "0x18651DEB0", Slot = "19")]
	public void NCLMBBKHAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x651DF40", Offset = "0x651C740", VA = "0x18651DF40", Slot = "13")]
	public void NICLHJKKEFL(NJAIEPKGFJP GPAFFEGFMCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class EFLCFKFPJGB : ENDCNFEIIBE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct KCKJEGGKLKP : HNDEFOGKKMF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private KHBPKJNGAIG OPJNLFOIMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle JPBBNPJNGBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LFKJJJJNBAF MLKGPGLHHHO;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x65264D0", Offset = "0x6524CD0", VA = "0x1865264D0")]
		public KCKJEGGKLKP(KHBPKJNGAIG OPJNLFOIMJC, JobHandle JPBBNPJNGBC, LFKJJJJNBAF MLKGPGLHHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x65264A0", Offset = "0x6524CA0", VA = "0x1865264A0", Slot = "4")]
		public KHBPKJNGAIG NJFDFAHEDCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6526450", Offset = "0x6524C50", VA = "0x186526450", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly PDDFOIOEICK GKMCBGMNDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] HHJGDOPHBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 BEDICBILNEN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override FNCHJLMBGAH BEPFNPDJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x65204A0", Offset = "0x651ECA0", VA = "0x1865204A0", Slot = "16")]
		get
		{
			return default(FNCHJLMBGAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private Vector3 FIFFALIEKBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x651F2B0", Offset = "0x651DAB0", VA = "0x18651F2B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	protected override Hash128 OGEBPOAILJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x651E6F0", Offset = "0x651CEF0", VA = "0x18651E6F0", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6520930", Offset = "0x651F130", VA = "0x186520930")]
	public EFLCFKFPJGB(HCPOGMCMDHN PHEKGOFMNOB, PDDFOIOEICK FCHBDAMJEHN, bool DMPDECECAED = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x651F630", Offset = "0x651DE30", VA = "0x18651F630", Slot = "15")]
	public override bool FBDMEEDADON(BNGKBJDCOCA PHEKGOFMNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6520400", Offset = "0x651EC00", VA = "0x186520400", Slot = "17")]
	public override int OBBKCAHJEDO(HOJOLHIILFP PLAHBEAKHNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x651E650", Offset = "0x651CE50", VA = "0x18651E650", Slot = "18")]
	public override int CHBHCEDFNND(HOJOLHIILFP PLAHBEAKHNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x651E820", Offset = "0x651D020", VA = "0x18651E820")]
	private int DAOCMECCIGB(HOJOLHIILFP PLAHBEAKHNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x651FC70", Offset = "0x651E470", VA = "0x18651FC70", Slot = "19")]
	public override void LKKCPFKFMEL(HOJOLHIILFP PLAHBEAKHNI, INJAPEPBNEN DKEJEJCCNLA, int MHNCAGMILEN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6520860", Offset = "0x651F060", VA = "0x186520860", Slot = "20")]
	public override BNGKBJDCOCA PDHELGINLPE()
	{
		return default(BNGKBJDCOCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x651FAC0", Offset = "0x651E2C0", VA = "0x18651FAC0", Slot = "22")]
	public override FMMAKLCCMAN HBOLFFCKJFF()
	{
		return default(FMMAKLCCMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x651EA70", Offset = "0x651D270", VA = "0x18651EA70", Slot = "23")]
	public override HNDEFOGKKMF DBFHLCCAKPJ(HOJOLHIILFP PLAHBEAKHNI, JobHandle JPBBNPJNGBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MHJFGDKEOMC
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHOFNKAACGB(JDKCICHPOHA HJNJPNKDEFH, Renderer NOLODDJEKPD, int EMBIGFKDPFL);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEJFMNAPGOE(Renderer NOLODDJEKPD, GGJNPCIDLFP GDNPDHMMELP, Vector3 OLHNAODINFK, Vector3 DFFJNCJMIBF, Vector3 JDNIMODKGNF, float FBMBALGAMCD, float KLLJACKIIKJ, float DOBFLHNBLCB = -1f, [Optional] Color? NGHDCCDAAOH, [Optional] IReadOnlyList<Camera> PEOKOIILPLN);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EAKKLMPKIGA(Renderer NOLODDJEKPD, int EMBIGFKDPFL);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NOBMGFBNCLI();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DMHIBPFJKFB(int FFPHPLKKMPO, OECNPGLBOAO HJNJPNKDEFH, Renderer NOLODDJEKPD, int EMBIGFKDPFL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NHMMMFICHAH : HNJLFENHCNO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class ENHNGGALLIF : FGHGDDDIBLD<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6522090", Offset = "0x6520890", VA = "0x186522090")]
		public ENHNGGALLIF(string PMDCAPIFBIP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly MHJFGDKEOMC LIELJHPHJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LOANDCBGBBE OLHFLINIMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer MJJIDFLHCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private ENHNGGALLIF BPKCKLHHFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool ILKHMKELCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer LODAAAGJLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private ENHNGGALLIF HDNNJCKDHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool OOEHGJFKAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer GAIBMAGKLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private ENHNGGALLIF OMEBIGDHBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool JBDHFFAIMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool HDNMPGDBKCJ;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x77D5B0", Offset = "0x77BDB0", VA = "0x18077D5B0")]
	public NHMMMFICHAH(MHJFGDKEOMC LJDIDCOABDN, LOANDCBGBBE OLHFLINIMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x65279A0", Offset = "0x65261A0", VA = "0x1865279A0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6527F60", Offset = "0x6526760", VA = "0x186527F60")]
	private void IKMGOFOBLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6527480", Offset = "0x6525C80", VA = "0x186527480", Slot = "4")]
	public void CFBDEDGIGAK(EDOKGBMMIIL PHEKGOFMNOB, OECNPGLBOAO LOFOCAHJJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6527780", Offset = "0x6525F80", VA = "0x186527780", Slot = "5")]
	public void CFBDEDGIGAK(KHGLBCCDCCI ALKNPJBKLCB, OECNPGLBOAO LOFOCAHJJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6527C80", Offset = "0x6526480", VA = "0x186527C80", Slot = "6")]
	public void GGGFCCNDGOI(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6527DB0", Offset = "0x65265B0", VA = "0x186527DB0", Slot = "7")]
	public void HFJFMGMGPEC(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6528D30", Offset = "0x6527530", VA = "0x186528D30", Slot = "24")]
	public void OOAKOMHJNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8A2D40", Offset = "0x8A1540", VA = "0x1808A2D40", Slot = "8")]
	public void BADLNNMKEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6528350", Offset = "0x6526B50", VA = "0x186528350", Slot = "9")]
	public void LBIJMPGMJPL(OECNPGLBOAO LOFOCAHJJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6526A50", Offset = "0x6525250", VA = "0x186526A50", Slot = "10")]
	public void AGDHJFNMMHK(EDOKGBMMIIL PHEKGOFMNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6526720", Offset = "0x6524F20", VA = "0x186526720", Slot = "11")]
	public void AGDHJFNMMHK(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6527EC0", Offset = "0x65266C0", VA = "0x186527EC0", Slot = "12")]
	public void ICMPNAJMMLG(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6527BF0", Offset = "0x65263F0", VA = "0x186527BF0", Slot = "13")]
	public void GEHOGJIHPPH(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6526D30", Offset = "0x6525530", VA = "0x186526D30")]
	private void ALILNDIMPPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xF9CED0", Offset = "0xF9B6D0", VA = "0x180F9CED0", Slot = "14")]
	public void KCHEEHMJKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x65281A0", Offset = "0x65269A0", VA = "0x1865281A0", Slot = "15")]
	public void JMBOGIKCFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x65271B0", Offset = "0x65259B0", VA = "0x1865271B0", Slot = "16")]
	public void AOFMLJEPJMG(EDOKGBMMIIL PHEKGOFMNOB, JDKCICHPOHA HJNJPNKDEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6527B50", Offset = "0x6526350", VA = "0x186527B50", Slot = "17")]
	public void EMGJGBBHHFD(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x65282C0", Offset = "0x6526AC0", VA = "0x1865282C0", Slot = "18")]
	public void KHJPPKNOGCH(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8600A0", Offset = "0x85E8A0", VA = "0x1808600A0", Slot = "19")]
	public void FGJFHIBFIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6528D70", Offset = "0x6527570", VA = "0x186528D70", Slot = "20")]
	public void PNLIPILLILC(JDKCICHPOHA HJNJPNKDEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6526F70", Offset = "0x6525770", VA = "0x186526F70")]
	private void ANNCNHLGPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6528960", Offset = "0x6527160", VA = "0x186528960", Slot = "21")]
	public void NELDIMNGMCP(EDOKGBMMIIL PHEKGOFMNOB, Vector3 OLHNAODINFK, Vector3 DFFJNCJMIBF, Vector3 JDNIMODKGNF, float FBMBALGAMCD, float KLLJACKIIKJ, IReadOnlyList<Camera> LFLCOCHJOBB, GGJNPCIDLFP GDNPDHMMELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x65284C0", Offset = "0x6526CC0", VA = "0x1865284C0", Slot = "22")]
	public void NELDIMNGMCP(NJAIEPKGFJP GPAFFEGFMCM, Vector3 OLHNAODINFK, Vector3 DFFJNCJMIBF, Vector3 JDNIMODKGNF, float FBMBALGAMCD, float KLLJACKIIKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class ENDCNFEIIBE : IMDAKHKLEEC, HPIGNGKGJJE, AHNNLIAHKDO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly HCPOGMCMDHN NJGNBOOOJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds LKLDELMDJDL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Bounds LDFMEOKKMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xDFAB30", Offset = "0xDF9330", VA = "0x180DFAB30", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public virtual FNCHJLMBGAH BEPFNPDJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6521FD0", Offset = "0x65207D0", VA = "0x186521FD0", Slot = "16")]
		get
		{
			return default(FNCHJLMBGAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EABGDJNAFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D60", Offset = "0x7C7560", VA = "0x1807C8D60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C8BD0", Offset = "0x7C73D0", VA = "0x1807C8BD0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	protected abstract Hash128 OGEBPOAILJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int FLEFLHEMNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x869250", Offset = "0x867A50", VA = "0x180869250", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public PJIPGLJMBKN EMIMLNNGPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x778B40", Offset = "0x777340", VA = "0x180778B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x77D860", Offset = "0x77C060", VA = "0x18077D860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool NPGGIIABOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x117E8B0", Offset = "0x117D0B0", VA = "0x18117E8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	protected ENDCNFEIIBE(HCPOGMCMDHN PHEKGOFMNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6521EA0", Offset = "0x65206A0", VA = "0x186521EA0", Slot = "14")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "15")]
	public virtual bool FBDMEEDADON(BNGKBJDCOCA PHEKGOFMNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract int OBBKCAHJEDO(HOJOLHIILFP PLAHBEAKHNI);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int CHBHCEDFNND(HOJOLHIILFP PLAHBEAKHNI);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void LKKCPFKFMEL(HOJOLHIILFP PLAHBEAKHNI, INJAPEPBNEN DKEJEJCCNLA, int MHNCAGMILEN = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract BNGKBJDCOCA PDHELGINLPE();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6522060", Offset = "0x6520860", VA = "0x186522060", Slot = "10")]
	public Hash128 PFBEDHMPDOA(int PLAHBEAKHNI)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract FMMAKLCCMAN HBOLFFCKJFF();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract HNDEFOGKKMF DBFHLCCAKPJ(HOJOLHIILFP PLAHBEAKHNI, JobHandle JPBBNPJNGBC);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6521E70", Offset = "0x6520670", VA = "0x186521E70", Slot = "9")]
	public HNDEFOGKKMF DHEMFEIFCPO(int PLAHBEAKHNI)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x652A920", Offset = "0x6529120", VA = "0x18652A920")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BCEJEEIMAPO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EOHICGPPIJE : IEnumerable<AGGFALKPHPP>, IEnumerable, IEnumerator<AGGFALKPHPP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private AGGFALKPHPP <>2__current;

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
		private AGGFALKPHPP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public EOHICGPPIJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x65220E0", Offset = "0x65208E0", VA = "0x1865220E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6522250", Offset = "0x6520A50", VA = "0x186522250", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x65221B0", Offset = "0x65209B0", VA = "0x1865221B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AGGFALKPHPP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x65221B0", Offset = "0x65209B0", VA = "0x1865221B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static AGGFALKPHPP[][] CMCAOAKKKAI;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static MLLFIMANBLE AODCNCJNIJP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static ShapeRendererConfig MEDBDOMNLLE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ComputeShader LIEMPEEKCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6519590", Offset = "0x6517D90", VA = "0x186519590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static SkinnedShapeRenderer HJFMKBLLPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6519DD0", Offset = "0x65185D0", VA = "0x186519DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x651A200", Offset = "0x6518A00", VA = "0x18651A200")]
	public static Mesh NEBAIMDDPDC(NGGLFEEIIDF NDPNGHGOJDJ, int PLAHBEAKHNI = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x651A2A0", Offset = "0x6518AA0", VA = "0x18651A2A0")]
	public static int NHMBNMGANMI(NGGLFEEIIDF NDPNGHGOJDJ, int PLAHBEAKHNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6519C80", Offset = "0x6518480", VA = "0x186519C80")]
	public static MLLFIMANBLE KDDFHLCDIFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x65195F0", Offset = "0x6517DF0", VA = "0x1865195F0")]
	[IteratorStateMachine(typeof(EOHICGPPIJE))]
	private static IEnumerable<AGGFALKPHPP> DJNLDAACHDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6519650", Offset = "0x6517E50", VA = "0x186519650")]
	public static AGGFALKPHPP ENMJEKKHEEP(NGGLFEEIIDF NDPNGHGOJDJ, int PLAHBEAKHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x651A2B0", Offset = "0x6518AB0", VA = "0x18651A2B0")]
	public static bool ODECELFGFCF(this NGGLFEEIIDF NDPNGHGOJDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6519900", Offset = "0x6518100", VA = "0x186519900")]
	public static void IIGHEMBKDLD(NGGLFEEIIDF NDPNGHGOJDJ, float3 CMHAKNNBEJA, [Out] CGNJMLIHFAB DNPJNJCADJG, [Out] float3 OOIAJOMEFMG, [Out] float ONKIDOJBKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6519E30", Offset = "0x6518630", VA = "0x186519E30")]
	public static void LKLILILCCLJ(Vector3 CMHAKNNBEJA, NGGLFEEIIDF NDPNGHGOJDJ, [Out] Vector3 OOIAJOMEFMG, [Out] float ONKIDOJBKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6519580", Offset = "0x6517D80", VA = "0x186519580")]
	[BDLCJDMJIJC(JPHNAFLMPCK.ExitingPlayMode, 0)]
	[HCFNPCBNIJK(0)]
	private static void BIDIGJOLGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6519AB0", Offset = "0x65182B0", VA = "0x186519AB0")]
	[BDLCJDMJIJC(JPHNAFLMPCK.ExitingPlayMode, 0)]
	[HCFNPCBNIJK(0)]
	private static void JAGJFJAJPHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class PFOHNGGCDPD : IFFDDCGEFNF, IDisposable, LOANDCBGBBE
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly JECOOJODPDK<EDOKGBMMIIL, HCPOGMCMDHN> IOKMKDGJOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly JECOOJODPDK<KHGLBCCDCCI, ENDCNFEIIBE> JLMICLILLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly JECOOJODPDK<NJAIEPKGFJP, EHHMIFOJKEP> HDEDAHEBIKJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HCPOGMCMDHN OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6529E00", Offset = "0x6528600", VA = "0x186529E00", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ENDCNFEIIBE OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6529E60", Offset = "0x6528660", VA = "0x186529E60", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public EHHMIFOJKEP OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6529EC0", Offset = "0x65286C0", VA = "0x186529EC0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DLOMBDCEOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x854330", Offset = "0x852B30", VA = "0x180854330", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x90C880", Offset = "0x90B080", VA = "0x18090C880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6529FB0", Offset = "0x65287B0", VA = "0x186529FB0")]
	public PFOHNGGCDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x65297B0", Offset = "0x6527FB0", VA = "0x1865297B0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6529A40", Offset = "0x6528240", VA = "0x186529A40", Slot = "4")]
	public EDOKGBMMIIL JLPACEBCCHB(CMBDHOFMMDB FCHBDAMJEHN)
	{
		return default(EDOKGBMMIIL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6529A40", Offset = "0x6528240", VA = "0x186529A40", Slot = "5")]
	public EDOKGBMMIIL JLPACEBCCHB(CMBDHOFMMDB FCHBDAMJEHN, bool FEDFDOLICOF)
	{
		return default(EDOKGBMMIIL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6529750", Offset = "0x6527F50", VA = "0x186529750", Slot = "6")]
	public void CCFHANAFCAL(EDOKGBMMIIL PHEKGOFMNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6529920", Offset = "0x6528120", VA = "0x186529920", Slot = "7")]
	public void IAAKHDCPJKF(EDOKGBMMIIL PHEKGOFMNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6529570", Offset = "0x6527D70", VA = "0x186529570", Slot = "8")]
	public KHGLBCCDCCI BDDAEBOBHLC(EDOKGBMMIIL PHEKGOFMNOB, PDDFOIOEICK FCHBDAMJEHN)
	{
		return default(KHGLBCCDCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6529B80", Offset = "0x6528380", VA = "0x186529B80", Slot = "9")]
	public KHGLBCCDCCI LHNINLMKNAE(EDOKGBMMIIL PHEKGOFMNOB, KGDLNMOLGPB FCHBDAMJEHN)
	{
		return default(KHGLBCCDCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x65294E0", Offset = "0x6527CE0", VA = "0x1865294E0", Slot = "11")]
	public void ACBEGADNFKM(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6529840", Offset = "0x6528040", VA = "0x186529840", Slot = "10")]
	public void GIMDMNMOPCC(KHGLBCCDCCI ALKNPJBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6529D90", Offset = "0x6528590", VA = "0x186529D90", Slot = "20")]
	public IEnumerable<Renderer> OAGFBJNNHDF(EDOKGBMMIIL PHEKGOFMNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x65298A0", Offset = "0x65280A0", VA = "0x1865298A0", Slot = "12")]
	public NJAIEPKGFJP GPOIADHIPFL(BOLBBANBFLK FCHBDAMJEHN)
	{
		return default(NJAIEPKGFJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6529D20", Offset = "0x6528520", VA = "0x186529D20", Slot = "14")]
	public void NIOHGKNIKFA(NJAIEPKGFJP GPAFFEGFMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x65299A0", Offset = "0x65281A0", VA = "0x1865299A0", Slot = "16")]
	public Task JGCBBOLOBOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x65296B0", Offset = "0x6527EB0", VA = "0x1865296B0", Slot = "17")]
	public Task CBIPMAHGOJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6529AE0", Offset = "0x65282E0", VA = "0x186529AE0", Slot = "18")]
	public Task LCMAGAPNHAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1BFD2E0", Offset = "0x1BFBAE0", VA = "0x181BFD2E0", Slot = "19")]
	public void NCLMBBKHAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6529CC0", Offset = "0x65284C0", VA = "0x186529CC0", Slot = "13")]
	public void NICLHJKKEFL(NJAIEPKGFJP GPAFFEGFMCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OMEDIFNFENL
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool PLJDGAAGJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material FGMHPCIKMHF();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material KFNMCIKACEA();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material HIDJBIHEJJB();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FHHFCCKMAHC(COINANOKBFO MCFHGLDCBAH);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NBEEPLGKIAE(FDNDCPGLHNO APJLCKOCOJL);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGEICMDJLNK(GameObject BEKFGDCEJDH);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BMFEFBHAINH(GameObject BEKFGDCEJDH, bool OCKNDBIIHIK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HGLEOKAIFND
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static OMEDIFNFENL EGAILLJGEID;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool PLJDGAAGJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6525900", Offset = "0x6524100", VA = "0x186525900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6525A90", Offset = "0x6524290", VA = "0x186525A90")]
	public static void HPFFAGOPMEK(OMEDIFNFENL OINCOHBBDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6525960", Offset = "0x6524160", VA = "0x186525960")]
	public static Material FGMHPCIKMHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6524B70", Offset = "0x6523370", VA = "0x186524B70")]
	public static Material KFNMCIKACEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6525A30", Offset = "0x6524230", VA = "0x186525A30")]
	public static Material HIDJBIHEJJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x65259C0", Offset = "0x65241C0", VA = "0x1865259C0")]
	public static int FHHFCCKMAHC(COINANOKBFO MCFHGLDCBAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6525AF0", Offset = "0x65242F0", VA = "0x186525AF0")]
	public static int NBEEPLGKIAE(FDNDCPGLHNO APJLCKOCOJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6525730", Offset = "0x6523F30", VA = "0x186525730")]
	public static void BGEICMDJLNK(GameObject BEKFGDCEJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6525810", Offset = "0x6524010", VA = "0x186525810")]
	public static void BMFEFBHAINH(GameObject BEKFGDCEJDH, bool OCKNDBIIHIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EHHMIFOJKEP : JPGEPNLINKD
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FDDKHNEDNJO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EHHMIFOJKEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public FDDKHNEDNJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6523E50", Offset = "0x6522650", VA = "0x186523E50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6523B30", Offset = "0x6522330", VA = "0x186523B30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6523AE0", Offset = "0x65222E0", VA = "0x186523AE0")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6523E00", Offset = "0x6522600", VA = "0x186523E00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6523D50", Offset = "0x6522550", VA = "0x186523D50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6523D50", Offset = "0x6522550", VA = "0x186523D50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly BOLBBANBFLK PBBLIKMPDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly LOANDCBGBBE OLHFLINIMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private JOMHLHBEIHM IPDJPOCGCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<CJGFBJNOGPF> FILPCKOEAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private List<CJGFBJNOGPF> FLEEMEEOFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GameObject FJELGKHMLMP;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6520F20", Offset = "0x651F720", VA = "0x186520F20")]
	public static EHHMIFOJKEP FPDDFHDEAAN(BOLBBANBFLK FCHBDAMJEHN, LOANDCBGBBE OLHFLINIMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6521D90", Offset = "0x6520590", VA = "0x186521D90")]
	private EHHMIFOJKEP(BOLBBANBFLK FCHBDAMJEHN, LOANDCBGBBE OLHFLINIMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x65209E0", Offset = "0x651F1E0", VA = "0x1865209E0")]
	public void ALEHCMDHAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6520E70", Offset = "0x651F670", VA = "0x186520E70")]
	[IteratorStateMachine(typeof(FDDKHNEDNJO))]
	public IEnumerable<Renderer> BNNCAGPEDBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6521070", Offset = "0x651F870", VA = "0x186521070", Slot = "4")]
	public void MEDDCFNEDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6520EF0", Offset = "0x651F6F0", VA = "0x186520EF0")]
	private void EMDGHIOMCNM(Vector3 FLLOPKACEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6521B40", Offset = "0x6520340", VA = "0x186521B40")]
	public void OMANMGAMPNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CJGFBJNOGPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct DIAEDGMPGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public INJAPEPBNEN PDMJOOBPMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public BNGKBJDCOCA AMCGPJOBBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int NMNPHHACKCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MEKLFFGBIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CJGFBJNOGPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public HOJOLHIILFP lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<DIAEDGMPGLG> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KHBPKJNGAIG combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public MEKLFFGBIFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6526690", Offset = "0x6524E90", VA = "0x186526690")]
		internal JobHandle KBIKAAMEJFK()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x65266F0", Offset = "0x6524EF0", VA = "0x1865266F0")]
		internal void LJNHPGHCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6526520", Offset = "0x6524D20", VA = "0x186526520")]
		internal void BLLHPMOHCPA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int[] GDFCNKABHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private GCDFHLAGHFL EOGDLMMFPDH;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Matrix4x4 OIIPFOEGBPK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh JAPLHMMCHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int JFKDLKFKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x773AF0", Offset = "0x7722F0", VA = "0x180773AF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x773B50", Offset = "0x772350", VA = "0x180773B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x651B080", Offset = "0x6519880", VA = "0x18651B080")]
	public void JOHDBEBDLNM(List<BNGKBJDCOCA> HMNILENDNOP, Matrix4x4[] LPGKJMMLHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x651B350", Offset = "0x6519B50", VA = "0x18651B350")]
	public static List<CJGFBJNOGPF> OEONKPJDENI(List<HCPOGMCMDHN> ANFKBDDGMAE, HOJOLHIILFP PLAHBEAKHNI, Bounds GBPNIILDPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x651AC70", Offset = "0x6519470", VA = "0x18651AC70")]
	private JobHandle BLLPFHNMKJK(KHBPKJNGAIG FIKGKKDAOOJ, int JDADEDOLDOE, int LINJKMOAEOP, HOJOLHIILFP PLAHBEAKHNI, List<DIAEDGMPGLG> MPEDHOFFENP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x651B270", Offset = "0x6519A70", VA = "0x18651B270")]
	private void NMNCGCCJLHG(List<DIAEDGMPGLG> MPEDHOFFENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x651BB80", Offset = "0x651A380", VA = "0x18651BB80")]
	private CJGFBJNOGPF(List<DIAEDGMPGLG> MPEDHOFFENP, int JDADEDOLDOE, int LINJKMOAEOP, HOJOLHIILFP PLAHBEAKHNI, Bounds GBPNIILDPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x651AFE0", Offset = "0x65197E0", VA = "0x18651AFE0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private MaterialPropertyBlock OKHNHFBJIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private CJGFBJNOGPF OPJNLFOIMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private List<BNGKBJDCOCA> LNOFNMFJMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private RenderTexture FJJMAHCHNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeBuffer FPLALLCKJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ComputeShader ICKKJKNMCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Matrix4x4[] HCIBGEDCOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int GCPOGJABMGE;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public MeshRenderer CINJMKGGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773780", VA = "0x180774F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int BNLEDHALMLC
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x652B620", Offset = "0x6529E20", VA = "0x18652B620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x652A950", Offset = "0x6529150", VA = "0x18652A950")]
		public static List<SkinnedShapeRenderer> Create(GameObject PHEKGOFMNOB, List<CJGFBJNOGPF> IOMLGAIJLNB, List<BNGKBJDCOCA> LNOFNMFJMAA, Material ECIAJACKHCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x652ACA0", Offset = "0x65294A0", VA = "0x18652ACA0")]
		public void Init(CJGFBJNOGPF OPJNLFOIMJC, List<BNGKBJDCOCA> LNOFNMFJMAA, Material ECIAJACKHCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x652B580", Offset = "0x6529D80", VA = "0x18652B580")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x652B4E0", Offset = "0x6529CE0", VA = "0x18652B4E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x652B4A0", Offset = "0x6529CA0", VA = "0x18652B4A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x652ABE0", Offset = "0x65293E0", VA = "0x18652ABE0")]
		private void DDHJLGELCLJ(ScriptableRenderContext LFDLOIPEDMO, Camera[] OGAJNOMGPLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x652B130", Offset = "0x6529930", VA = "0x18652B130")]
		private void JOHDBEBDLNM(CommandBuffer AJKDCNAPJCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7721F0", Offset = "0x7709F0", VA = "0x1807721F0")]
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
