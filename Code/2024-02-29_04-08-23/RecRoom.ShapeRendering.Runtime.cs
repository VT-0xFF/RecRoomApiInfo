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
	public class LogRegistrationIndex : KBDNGCLCFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6854420", Offset = "0x6853220", VA = "0x186854420", Slot = "4")]
		public override void NLHDMBJLIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NOMNHKEGMDG : AODIFECAPAH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte JPPNNCKPHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] NJMJNOMMLIP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DNMNIPOPBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDC0", Offset = "0x8CABC0", VA = "0x1808CBDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HGKAABGBKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E8AA0", Offset = "0x7E78A0", VA = "0x1807E8AA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E85E0", Offset = "0x7E73E0", VA = "0x1807E85E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float OMMNAIHFNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x800B20", Offset = "0x7FF920", VA = "0x180800B20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x801030", Offset = "0x7FFE30", VA = "0x180801030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OPJBHOPLJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x800F10", Offset = "0x7FFD10", VA = "0x180800F10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8015F0", Offset = "0x8003F0", VA = "0x1808015F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> OHKFJDMONPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6856660", Offset = "0x6855460", VA = "0x186856660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> GGEECAJCNDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6856390", Offset = "0x6855190", VA = "0x186856390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte OEOLILMFGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6856610", Offset = "0x6855410", VA = "0x186856610", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6856930", Offset = "0x6855730", VA = "0x186856930")]
	public NOMNHKEGMDG(List<KJAJOJDIONN> GFJJLLMHOLM, List<KJAJOJDIONN> JAEAKJLDLLH, List<AMFINDHLENJ> FCGHEMBDHMH, Material CMHHFEPJBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68566B0", Offset = "0x68554B0", VA = "0x1868566B0")]
	private int LNGODMNGKAM(List<KJAJOJDIONN> DCAEHJHBCPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68567D0", Offset = "0x68555D0", VA = "0x1868567D0")]
	private void POPNPIFFEFB(int EBLBIAPAFHM, bool LPLPENEECKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68563C0", Offset = "0x68551C0", VA = "0x1868563C0")]
	public void BMPDGKHOFFE(Vector3 FCOKLDMEDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6856510", Offset = "0x6855310", VA = "0x186856510", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6856350", Offset = "0x6855150", VA = "0x186856350")]
	public void ANEHFJDHCAP(Transform KNALMJBDMEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BNHENNMKCBG : HJOKBFCINBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class POLCJPIEBDI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BNHENNMKCBG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public POLCJPIEBDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x685A090", Offset = "0x6858E90", VA = "0x18685A090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6859A30", Offset = "0x6858830", VA = "0x186859A30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6859F40", Offset = "0x6858D40", VA = "0x186859F40")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6859990", Offset = "0x6858790", VA = "0x186859990")]
		private void AGDCIDILFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68599E0", Offset = "0x68587E0", VA = "0x1868599E0")]
		private void GLAPADLCNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x685A040", Offset = "0x6858E40", VA = "0x18685A040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6859F90", Offset = "0x6858D90", VA = "0x186859F90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6859F90", Offset = "0x6858D90", VA = "0x186859F90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class HOLBALEOGBI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BNHENNMKCBG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public HOLBALEOGBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x684D320", Offset = "0x684C120", VA = "0x18684D320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x684CE60", Offset = "0x684BC60", VA = "0x18684CE60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x684D1D0", Offset = "0x684BFD0", VA = "0x18684D1D0")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x684CE10", Offset = "0x684BC10", VA = "0x18684CE10")]
		private void AGDCIDILFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x684D2D0", Offset = "0x684C0D0", VA = "0x18684D2D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x684D220", Offset = "0x684C020", VA = "0x18684D220", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x684D220", Offset = "0x684C020", VA = "0x18684D220", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OKNHCPJBMCP HHFGPPAPFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<JNALFKOBPAI> JMKCOFMCGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> FLECFILMDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer CLFJKBNOIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool DAGJNKNABEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool HGNEOFOAOIP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<AMAEBDGJKGN> CKJMLEFDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ECHAFLFKEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6849C80", Offset = "0x6848A80", VA = "0x186849C80", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AMFINDHLENJ OAGNIGMKJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6849710", Offset = "0x6848510", VA = "0x186849710", Slot = "8")]
		get
		{
			return default(AMFINDHLENJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> BFDONBFPBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD180", Offset = "0x7ABF80", VA = "0x1807AD180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6848C90", Offset = "0x6847A90", VA = "0x186848C90")]
	private bool AOBIEKDHDOP(JNALFKOBPAI NEOAOHJOLBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x684A240", Offset = "0x6849040", VA = "0x18684A240")]
	private static bool OIMEAPOGEAK(JNALFKOBPAI NEOAOHJOLBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x684A260", Offset = "0x6849060", VA = "0x18684A260")]
	public BNHENNMKCBG(OKNHCPJBMCP OMHIFBJFAGA, bool EFKKAIPDGNI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68494D0", Offset = "0x68482D0", VA = "0x1868494D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6848AF0", Offset = "0x68478F0", VA = "0x186848AF0")]
	public void ANMBPKAMKOK(JNALFKOBPAI NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68497E0", Offset = "0x68485E0", VA = "0x1868497E0")]
	public void JJGPDDBMEBN(JNALFKOBPAI NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6849D40", Offset = "0x6848B40", VA = "0x186849D40", Slot = "4")]
	public void OEGNFOGIFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68499D0", Offset = "0x68487D0", VA = "0x1868499D0")]
	public void LLIADGIKINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6848CB0", Offset = "0x6847AB0", VA = "0x186848CB0")]
	private void APGLMIJPLHF(List<JNALFKOBPAI> JMKCOFMCGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6849C20", Offset = "0x6848A20", VA = "0x186849C20")]
	private static Material MCGMKNIJPBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6848E70", Offset = "0x6847C70", VA = "0x186848E70")]
	private void APGLMIJPLHF(JNALFKOBPAI NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6849900", Offset = "0x6848700", VA = "0x186849900")]
	private void LCGMIOGMFHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6848F20", Offset = "0x6847D20", VA = "0x186848F20")]
	public void BPABKJFIJPA(bool HIJCPEADBMN, bool LGNFOOLKDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6849650", Offset = "0x6848450", VA = "0x186849650")]
	protected void EGINDCAKAKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6848A70", Offset = "0x6847870", VA = "0x186848A70")]
	[IteratorStateMachine(typeof(POLCJPIEBDI))]
	public IEnumerable<Renderer> ANIJLALHOGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6849CC0", Offset = "0x6848AC0", VA = "0x186849CC0")]
	[IteratorStateMachine(typeof(HOLBALEOGBI))]
	public IEnumerable<Renderer> NKFBONEHDNE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class MKNKLPJMLGE : JNALFKOBPAI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct MDLCAPHCBGB : NPAPPPKOBNM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GEAAJBLIKPP CKIIGCAJEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle PHKOIIDBFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OEMNDMDIHBO HGAKDEMPBDG;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6854530", Offset = "0x6853330", VA = "0x186854530")]
		public MDLCAPHCBGB(GEAAJBLIKPP CKIIGCAJEFJ, JobHandle PHKOIIDBFOB, OEMNDMDIHBO HGAKDEMPBDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6854500", Offset = "0x6853300", VA = "0x186854500", Slot = "4")]
		public GEAAJBLIKPP GMFECOINAPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68544B0", Offset = "0x68532B0", VA = "0x1868544B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BLIDLKONCKO BDICEKKCCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float GBDBLJMLDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 EJBMCENPJKE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 LKLJJBKIDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6854660", Offset = "0x6853460", VA = "0x186854660", Slot = "23")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68562A0", Offset = "0x68550A0", VA = "0x1868562A0")]
	public MKNKLPJMLGE(BNHENNMKCBG ADCDJFADKCK, BLIDLKONCKO OMHIFBJFAGA, bool EFKKAIPDGNI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "16")]
	public override bool FCLEPILEDAK(AMFINDHLENJ ADCDJFADKCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68557B0", Offset = "0x68545B0", VA = "0x1868557B0", Slot = "18")]
	public override int LNGODMNGKAM(CDKBKGKLIGO KEIPHEGFNFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6854940", Offset = "0x6853740", VA = "0x186854940", Slot = "19")]
	public override int KKCHBPKNFJL(CDKBKGKLIGO KEIPHEGFNFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6854B10", Offset = "0x6853910", VA = "0x186854B10", Slot = "20")]
	public override Bounds KKELLMEEFEN()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6854FC0", Offset = "0x6853DC0", VA = "0x186854FC0", Slot = "21")]
	public override void KNKONPJCGDA(CDKBKGKLIGO KEIPHEGFNFM, ABPIHCMGHHG BGFOMOFODDE, int AGDIIKOFJHK = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x68556E0", Offset = "0x68544E0", VA = "0x1868556E0", Slot = "22")]
	public override AMFINDHLENJ KPHCHPGBIJP()
	{
		return default(AMFINDHLENJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6854790", Offset = "0x6853590", VA = "0x186854790", Slot = "24")]
	public override JOKLOKBPBNE KJMPPMKBJMP()
	{
		return default(JOKLOKBPBNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6855980", Offset = "0x6854780", VA = "0x186855980", Slot = "25")]
	public override NPAPPPKOBNM POBAFCNOCBO(CDKBKGKLIGO KEIPHEGFNFM, JobHandle PHKOIIDBFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface OJANAILMLJH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BNHENNMKCBG LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JNALFKOBPAI LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DCHOGJLDLKK LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class KNNPMANFJDC : CBBHLNFCBGP, IDisposable, OJANAILMLJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PHFACPAGNFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public KNNPMANFJDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6859410", Offset = "0x6858210", VA = "0x186859410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6859930", Offset = "0x6858730", VA = "0x186859930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly AAJODGJAHGH<JGBEIAHMINN, BNHENNMKCBG> AOGKHGMMHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly AAJODGJAHGH<OCCGANNGJED, JNALFKOBPAI> JMKCOFMCGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly AAJODGJAHGH<NDCEFGIIAAC, DCHOGJLDLKK> OBOCILIMFAC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BNHENNMKCBG LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6852B50", Offset = "0x6851950", VA = "0x186852B50", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public JNALFKOBPAI LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6852AF0", Offset = "0x68518F0", VA = "0x186852AF0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DCHOGJLDLKK LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6852A90", Offset = "0x6851890", VA = "0x186852A90", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PKFCBPGOBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E7F0", VA = "0x18088F9F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x949130", Offset = "0x947F30", VA = "0x180949130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6853F70", Offset = "0x6852D70", VA = "0x186853F70")]
	public KNNPMANFJDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6852180", Offset = "0x6850F80", VA = "0x186852180", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6852670", Offset = "0x6851470", VA = "0x186852670", Slot = "4")]
	public JGBEIAHMINN FPNDGGIIFFN(OKNHCPJBMCP OMHIFBJFAGA)
	{
		return default(JGBEIAHMINN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6852680", Offset = "0x6851480", VA = "0x186852680", Slot = "5")]
	public JGBEIAHMINN FPNDGGIIFFN(OKNHCPJBMCP OMHIFBJFAGA, bool EFKKAIPDGNI)
	{
		return default(JGBEIAHMINN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6853100", Offset = "0x6851F00", VA = "0x186853100", Slot = "6")]
	public void KHPCMFIJDND(JGBEIAHMINN ADCDJFADKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6852310", Offset = "0x6851110", VA = "0x186852310", Slot = "7")]
	public void EFGCBNFCNFI(JGBEIAHMINN ADCDJFADKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6853360", Offset = "0x6852160", VA = "0x186853360", Slot = "8")]
	public OCCGANNGJED NMIIFIFOEJE(JGBEIAHMINN ADCDJFADKCK, DGFHFEOFIHG OMHIFBJFAGA)
	{
		return default(OCCGANNGJED);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6852C20", Offset = "0x6851A20", VA = "0x186852C20", Slot = "9")]
	public OCCGANNGJED KBOGLEIMDKM(JGBEIAHMINN ADCDJFADKCK, BLIDLKONCKO OMHIFBJFAGA)
	{
		return default(OCCGANNGJED);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6853B20", Offset = "0x6852920", VA = "0x186853B20", Slot = "11")]
	public void PDHPCMBENCA(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6853840", Offset = "0x6852640", VA = "0x186853840", Slot = "10")]
	public void OEKOKFLBCOG(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6851EC0", Offset = "0x6850CC0", VA = "0x186851EC0", Slot = "20")]
	public IEnumerable<Renderer> BOIGLDAFAKN(JGBEIAHMINN ADCDJFADKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6853AA0", Offset = "0x68528A0", VA = "0x186853AA0", Slot = "12")]
	public NDCEFGIIAAC PCPHBHDFCJP(ABHGPEPJHAG OMHIFBJFAGA)
	{
		return default(NDCEFGIIAAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6852BB0", Offset = "0x68519B0", VA = "0x186852BB0", Slot = "14")]
	public void IIMOJIAPOEA(NDCEFGIIAAC DPDDHAILJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6852900", Offset = "0x6851700", VA = "0x186852900", Slot = "16")]
	public Task HMMMBOEFEAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6851F30", Offset = "0x6850D30", VA = "0x186851F30", Slot = "17")]
	public Task DDEENKPIPJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68520B0", Offset = "0x6850EB0", VA = "0x1868520B0", Slot = "18")]
	[AsyncStateMachine(typeof(PHFACPAGNFF))]
	public Task DPDJOHHPFCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6853EE0", Offset = "0x6852CE0", VA = "0x186853EE0", Slot = "19")]
	public void PFEGDNCENHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6851E60", Offset = "0x6850C60", VA = "0x186851E60", Slot = "13")]
	public void BLPIBNECHBC(NDCEFGIIAAC DPDDHAILJPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class IDMJPOCLAKO : JNALFKOBPAI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct MHCMPCDFOJE : NPAPPPKOBNM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private GEAAJBLIKPP CKIIGCAJEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle PHKOIIDBFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private BJLIKGPKKHC HGAKDEMPBDG;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6854610", Offset = "0x6853410", VA = "0x186854610")]
		public MHCMPCDFOJE(GEAAJBLIKPP CKIIGCAJEFJ, JobHandle PHKOIIDBFOB, BJLIKGPKKHC HGAKDEMPBDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x68545E0", Offset = "0x68533E0", VA = "0x1868545E0", Slot = "4")]
		public GEAAJBLIKPP GMFECOINAPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6854590", Offset = "0x6853390", VA = "0x186854590", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly DGFHFEOFIHG GHKHBJDIPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] FDBENABBJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 EJBMCENPJKE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override BCEDDLKONIN FHHHEPIEPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x684D450", Offset = "0x684C250", VA = "0x18684D450", Slot = "17")]
		get
		{
			return default(BCEDDLKONIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private Vector3 IGHBCPANCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x684F450", Offset = "0x684E250", VA = "0x18684F450")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	protected override Hash128 LKLJJBKIDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x684D810", Offset = "0x684C610", VA = "0x18684D810", Slot = "23")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x684F7D0", Offset = "0x684E5D0", VA = "0x18684F7D0")]
	public IDMJPOCLAKO(BNHENNMKCBG ADCDJFADKCK, DGFHFEOFIHG OMHIFBJFAGA, bool CMADPJPCCBF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x684D940", Offset = "0x684C740", VA = "0x18684D940", Slot = "16")]
	public override bool FCLEPILEDAK(AMFINDHLENJ ADCDJFADKCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x684E900", Offset = "0x684D700", VA = "0x18684E900", Slot = "18")]
	public override int LNGODMNGKAM(CDKBKGKLIGO KEIPHEGFNFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x684DF80", Offset = "0x684CD80", VA = "0x18684DF80", Slot = "19")]
	public override int KKCHBPKNFJL(CDKBKGKLIGO KEIPHEGFNFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x684E020", Offset = "0x684CE20", VA = "0x18684E020", Slot = "20")]
	public override Bounds KKELLMEEFEN()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x684E9A0", Offset = "0x684D7A0", VA = "0x18684E9A0")]
	private int PAGBJBFHEDP(CDKBKGKLIGO KEIPHEGFNFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x684E0A0", Offset = "0x684CEA0", VA = "0x18684E0A0", Slot = "21")]
	public override void KNKONPJCGDA(CDKBKGKLIGO KEIPHEGFNFM, ABPIHCMGHHG BGFOMOFODDE, int AGDIIKOFJHK = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x684E830", Offset = "0x684D630", VA = "0x18684E830", Slot = "22")]
	public override AMFINDHLENJ KPHCHPGBIJP()
	{
		return default(AMFINDHLENJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x684DDD0", Offset = "0x684CBD0", VA = "0x18684DDD0", Slot = "24")]
	public override JOKLOKBPBNE KJMPPMKBJMP()
	{
		return default(JOKLOKBPBNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x684EC10", Offset = "0x684DA10", VA = "0x18684EC10", Slot = "25")]
	public override NPAPPPKOBNM POBAFCNOCBO(CDKBKGKLIGO KEIPHEGFNFM, JobHandle PHKOIIDBFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PKAFDFDBAHA
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHNAEEKGHDG(OAILCNKFKII HFFNCGFKMBJ, Renderer LAJADMHLOJE, int IPAEBLHPJGP);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOEKDMFGEOH(Renderer LAJADMHLOJE, HAGIEIPOKBM FFBBOKJELDN, Vector3 KBIKDPFLKEO, Vector3 AHPPPOPHFAI, Vector3 ALIFHKFOEGF, float LAMECCBLPGJ, float LOCNLIOAOFL, float CMDIJLBEEGH = -1f, [Optional] Color? OLDELFAHHJB, [Optional] IReadOnlyList<Camera> GBAAIFDJNKM);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHADGJNMCMB(Renderer LAJADMHLOJE, int IPAEBLHPJGP);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DHBHCOFKCPK();

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MENGJBEHDBO(int PAAMBNKPPFF, LPOKNNAKEAE HFFNCGFKMBJ, Renderer LAJADMHLOJE, int IPAEBLHPJGP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PDKECFFJGFL : LKINHOILCBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class OHLMDHEPPPJ : LJGHIGMANCK<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6856C40", Offset = "0x6855A40", VA = "0x186856C40")]
		public OHLMDHEPPPJ(string OHHBGJPCFJD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly PKAFDFDBAHA PLKBLINOOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly OJANAILMLJH EKKNIEKGKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer KHIBDJOJBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private OHLMDHEPPPJ NAIODOEFKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool HHIKHMOECJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer BFBMEDEHMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private OHLMDHEPPPJ MKHEINNJKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool AJCALHDGJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer KAHCBBICJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private OHLMDHEPPPJ GFCMLGNCIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool LLCKCIGDIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool FCGEEBKFDBI;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
	public PDKECFFJGFL(PKAFDFDBAHA EOBNALOHPKA, OJANAILMLJH EKKNIEKGKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6857620", Offset = "0x6856420", VA = "0x186857620", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6856ED0", Offset = "0x6855CD0", VA = "0x186856ED0")]
	private void ADKNNAAKDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6857A20", Offset = "0x6856820", VA = "0x186857A20", Slot = "4")]
	public void FLONGMHEOAM(JGBEIAHMINN ADCDJFADKCK, LPOKNNAKEAE KKDBAKJEPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6857D20", Offset = "0x6856B20", VA = "0x186857D20", Slot = "5")]
	public void FLONGMHEOAM(OCCGANNGJED NEOAOHJOLBD, LPOKNNAKEAE KKDBAKJEPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x68577D0", Offset = "0x68565D0", VA = "0x1868577D0", Slot = "6")]
	public void EKCPKNJGKLG(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6858310", Offset = "0x6857110", VA = "0x186858310", Slot = "7")]
	public void JPLPDMAILMH(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6858C90", Offset = "0x6857A90", VA = "0x186858C90", Slot = "24")]
	public void KPBMDIJMNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8E16E0", Offset = "0x8E04E0", VA = "0x1808E16E0", Slot = "8")]
	public void LBKGEEPANDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6858070", Offset = "0x6856E70", VA = "0x186858070", Slot = "9")]
	public void GHBPAAIAIEM(LPOKNNAKEAE KKDBAKJEPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6859130", Offset = "0x6857F30", VA = "0x186859130", Slot = "10")]
	public void OEIBJJJJBLA(JGBEIAHMINN ADCDJFADKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6858E00", Offset = "0x6857C00", VA = "0x186858E00", Slot = "11")]
	public void OEIBJJJJBLA(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6858270", Offset = "0x6857070", VA = "0x186858270", Slot = "12")]
	public void JJCEOADJPIC(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x68581E0", Offset = "0x6856FE0", VA = "0x1868581E0", Slot = "13")]
	public void ICNOCEDLEPP(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68573E0", Offset = "0x68561E0", VA = "0x1868573E0")]
	private void DLLJOLJMHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1014CA0", Offset = "0x1013AA0", VA = "0x181014CA0", Slot = "14")]
	public void KPCFENJKNMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6857900", Offset = "0x6856700", VA = "0x186857900", Slot = "15")]
	public void FIAEEGAMEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6857110", Offset = "0x6855F10", VA = "0x186857110", Slot = "16")]
	public void DAPNPELKKJF(JGBEIAHMINN ADCDJFADKCK, OAILCNKFKII HFFNCGFKMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6858D60", Offset = "0x6857B60", VA = "0x186858D60", Slot = "17")]
	public void LGFKDLHMOAA(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6858CD0", Offset = "0x6857AD0", VA = "0x186858CD0", Slot = "18")]
	public void LEKCIDMHHNJ(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x89BA50", Offset = "0x89A850", VA = "0x18089BA50", Slot = "19")]
	public void FFFOIDFCMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6857F40", Offset = "0x6856D40", VA = "0x186857F40", Slot = "20")]
	public void FPAHHHMKIEL(OAILCNKFKII HFFNCGFKMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6856C90", Offset = "0x6855A90", VA = "0x186856C90")]
	private void ABHIOAJGBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x68588C0", Offset = "0x68576C0", VA = "0x1868588C0", Slot = "21")]
	public void KJEMMAMIEAD(JGBEIAHMINN ADCDJFADKCK, Vector3 KBIKDPFLKEO, Vector3 AHPPPOPHFAI, Vector3 ALIFHKFOEGF, float LAMECCBLPGJ, float LOCNLIOAOFL, IReadOnlyList<Camera> JOBFIJGPCDF, HAGIEIPOKBM FFBBOKJELDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6858420", Offset = "0x6857220", VA = "0x186858420", Slot = "22")]
	public void KJEMMAMIEAD(NDCEFGIIAAC DPDDHAILJPH, Vector3 KBIKDPFLKEO, Vector3 AHPPPOPHFAI, Vector3 ALIFHKFOEGF, float LAMECCBLPGJ, float LOCNLIOAOFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class JNALFKOBPAI : PGHMEBPCPPA, AMAEBDGJKGN, EMHGMHJPKLP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly BNHENNMKCBG CGOAPMHKIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds EBDBHEHONBO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Bounds JNNCHBENFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xE63CC0", Offset = "0xE62AC0", VA = "0x180E63CC0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public virtual BCEDDLKONIN FHHHEPIEPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6850740", Offset = "0x684F540", VA = "0x186850740", Slot = "17")]
		get
		{
			return default(BCEDDLKONIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HGNEOFOAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x800F00", Offset = "0x7FFD00", VA = "0x180800F00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x800B30", Offset = "0x7FF930", VA = "0x180800B30")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	protected abstract Hash128 LKLJJBKIDDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MECMJFHODDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F52E0", Offset = "0x7F40E0", VA = "0x1807F52E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public JGANCIHBCJL EDDHHMABKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7AD180", Offset = "0x7ABF80", VA = "0x1807AD180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool HGDJCEJKDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x11DAAA0", Offset = "0x11D98A0", VA = "0x1811DAAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	protected JNALFKOBPAI(BNHENNMKCBG ADCDJFADKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x68507D0", Offset = "0x684F5D0", VA = "0x1868507D0", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "16")]
	public virtual bool FCLEPILEDAK(AMFINDHLENJ ADCDJFADKCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int LNGODMNGKAM(CDKBKGKLIGO KEIPHEGFNFM);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int KKCHBPKNFJL(CDKBKGKLIGO KEIPHEGFNFM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract Bounds KKELLMEEFEN();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract void KNKONPJCGDA(CDKBKGKLIGO KEIPHEGFNFM, ABPIHCMGHHG BGFOMOFODDE, int AGDIIKOFJHK = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract AMFINDHLENJ KPHCHPGBIJP();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6850930", Offset = "0x684F730", VA = "0x186850930", Slot = "11")]
	public Hash128 OJALKCGDPNG(int KEIPHEGFNFM)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract JOKLOKBPBNE KJMPPMKBJMP();

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract NPAPPPKOBNM POBAFCNOCBO(CDKBKGKLIGO KEIPHEGFNFM, JobHandle PHKOIIDBFOB);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6850900", Offset = "0x684F700", VA = "0x186850900", Slot = "10")]
	public NPAPPPKOBNM GLEPBOCLPIM(int KEIPHEGFNFM)
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
		[Cpp2IlInjected.Address(RVA = "0x685A280", Offset = "0x6859080", VA = "0x18685A280")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CODFOCGLMCB
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KKEOFANJKMK : IEnumerable<ENPDAEDNAJB>, IEnumerable, IEnumerator<ENPDAEDNAJB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private ENPDAEDNAJB <>2__current;

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
		private ENPDAEDNAJB System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public KKEOFANJKMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6851CA0", Offset = "0x6850AA0", VA = "0x186851CA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6851E10", Offset = "0x6850C10", VA = "0x186851E10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6851D70", Offset = "0x6850B70", VA = "0x186851D70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ENPDAEDNAJB> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6851D70", Offset = "0x6850B70", VA = "0x186851D70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static ENPDAEDNAJB[][] KPLEIPGBHLN;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static HGMJMIMEOBG NABDMAFNDDK;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static ShapeRendererConfig OHALMGHFMEC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ComputeShader GNIFMBFLJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x684A410", Offset = "0x6849210", VA = "0x18684A410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static SkinnedShapeRenderer NEEOJMCMGJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x684A470", Offset = "0x6849270", VA = "0x18684A470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x684A370", Offset = "0x6849170", VA = "0x18684A370")]
	public static Mesh BLPMKNNMCIN(KDDOAEOCBMD DBAAMANCELD, int KEIPHEGFNFM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x684ACB0", Offset = "0x6849AB0", VA = "0x18684ACB0")]
	public static int LOLFJMEKOLL(KDDOAEOCBMD DBAAMANCELD, int KEIPHEGFNFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x684AB60", Offset = "0x6849960", VA = "0x18684AB60")]
	public static HGMJMIMEOBG LHFJIJCADCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x684B040", Offset = "0x6849E40", VA = "0x18684B040")]
	[IteratorStateMachine(typeof(KKEOFANJKMK))]
	private static IEnumerable<ENPDAEDNAJB> PNOJNDGLBGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x684A4D0", Offset = "0x68492D0", VA = "0x18684A4D0")]
	public static ENPDAEDNAJB DGCMMKJMJMM(KDDOAEOCBMD DBAAMANCELD, int KEIPHEGFNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x684A350", Offset = "0x6849150", VA = "0x18684A350")]
	public static bool AIMEGBMDIHL(this KDDOAEOCBMD DBAAMANCELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x684ACC0", Offset = "0x6849AC0", VA = "0x18684ACC0")]
	public static void MCJCNDGDKNG(KDDOAEOCBMD DBAAMANCELD, float3 LJONOFGMDDE, [Out] HFCINMOIJCM CNFGLNIDDKN, [Out] float3 MKMNBLADPLF, [Out] float DIPGEAJPCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x684A790", Offset = "0x6849590", VA = "0x18684A790")]
	public static void KEDCDBOMGJJ(Vector3 LJONOFGMDDE, KDDOAEOCBMD DBAAMANCELD, [Out] Vector3 MKMNBLADPLF, [Out] float DIPGEAJPCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x684A780", Offset = "0x6849580", VA = "0x18684A780")]
	[MKMKKCMJPMD(BAGLMHABOOI.ExitingPlayMode, 0)]
	[CCKCHPCMPCH(0)]
	private static void IMGBIEEKPCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x684AE70", Offset = "0x6849C70", VA = "0x18684AE70")]
	[CCKCHPCMPCH(0)]
	[MKMKKCMJPMD(BAGLMHABOOI.ExitingPlayMode, 0)]
	private static void OGBLFHFCLHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class JKEJBLCBNDG : CBBHLNFCBGP, IDisposable, OJANAILMLJH
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly AAJODGJAHGH<JGBEIAHMINN, BNHENNMKCBG> AOGKHGMMHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly AAJODGJAHGH<OCCGANNGJED, JNALFKOBPAI> JMKCOFMCGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly AAJODGJAHGH<NDCEFGIIAAC, DCHOGJLDLKK> OBOCILIMFAC;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BNHENNMKCBG LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x684FD40", Offset = "0x684EB40", VA = "0x18684FD40", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public JNALFKOBPAI LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x684FDA0", Offset = "0x684EBA0", VA = "0x18684FDA0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public DCHOGJLDLKK LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x684FCE0", Offset = "0x684EAE0", VA = "0x18684FCE0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool PKFCBPGOBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E7F0", VA = "0x18088F9F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x949130", Offset = "0x947F30", VA = "0x180949130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6850350", Offset = "0x684F150", VA = "0x186850350")]
	public JKEJBLCBNDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x684FA90", Offset = "0x684E890", VA = "0x18684FA90", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x684FBA0", Offset = "0x684E9A0", VA = "0x18684FBA0", Slot = "4")]
	public JGBEIAHMINN FPNDGGIIFFN(OKNHCPJBMCP OMHIFBJFAGA)
	{
		return default(JGBEIAHMINN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x684FBA0", Offset = "0x684E9A0", VA = "0x18684FBA0", Slot = "5")]
	public JGBEIAHMINN FPNDGGIIFFN(OKNHCPJBMCP OMHIFBJFAGA, bool EFKKAIPDGNI)
	{
		return default(JGBEIAHMINN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x684FFB0", Offset = "0x684EDB0", VA = "0x18684FFB0", Slot = "6")]
	public void KHPCMFIJDND(JGBEIAHMINN ADCDJFADKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x684FB20", Offset = "0x684E920", VA = "0x18684FB20", Slot = "7")]
	public void EFGCBNFCNFI(JGBEIAHMINN ADCDJFADKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6850010", Offset = "0x684EE10", VA = "0x186850010", Slot = "8")]
	public OCCGANNGJED NMIIFIFOEJE(JGBEIAHMINN ADCDJFADKCK, DGFHFEOFIHG OMHIFBJFAGA)
	{
		return default(OCCGANNGJED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x684FE70", Offset = "0x684EC70", VA = "0x18684FE70", Slot = "9")]
	public OCCGANNGJED KBOGLEIMDKM(JGBEIAHMINN ADCDJFADKCK, BLIDLKONCKO OMHIFBJFAGA)
	{
		return default(OCCGANNGJED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6850230", Offset = "0x684F030", VA = "0x186850230", Slot = "11")]
	public void PDHPCMBENCA(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6850150", Offset = "0x684EF50", VA = "0x186850150", Slot = "10")]
	public void OEKOKFLBCOG(OCCGANNGJED NEOAOHJOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x684F8E0", Offset = "0x684E6E0", VA = "0x18684F8E0", Slot = "20")]
	public IEnumerable<Renderer> BOIGLDAFAKN(JGBEIAHMINN ADCDJFADKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x68501B0", Offset = "0x684EFB0", VA = "0x1868501B0", Slot = "12")]
	public NDCEFGIIAAC PCPHBHDFCJP(ABHGPEPJHAG OMHIFBJFAGA)
	{
		return default(NDCEFGIIAAC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x684FE00", Offset = "0x684EC00", VA = "0x18684FE00", Slot = "14")]
	public void IIMOJIAPOEA(NDCEFGIIAAC DPDDHAILJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x684FC40", Offset = "0x684EA40", VA = "0x18684FC40", Slot = "16")]
	public Task HMMMBOEFEAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x684F950", Offset = "0x684E750", VA = "0x18684F950", Slot = "17")]
	public Task DDEENKPIPJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x684F9F0", Offset = "0x684E7F0", VA = "0x18684F9F0", Slot = "18")]
	public Task DPDJOHHPFCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1CACBB0", Offset = "0x1CAB9B0", VA = "0x181CACBB0", Slot = "19")]
	public void PFEGDNCENHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x684F880", Offset = "0x684E680", VA = "0x18684F880", Slot = "13")]
	public void BLPIBNECHBC(NDCEFGIIAAC DPDDHAILJPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LFJKMGBCNCD
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool KAMDJLEGJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material MOJGLFEPIPD();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MCGMKNIJPBN();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material JGAKPNIGNEM();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DNCODMMABCH(OAEIMDOBIAE EPMAFGOIKLC);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OLLHJIFOEFE(FCKJPJLMAPE OJBGLGMEMLA);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JEBOKIFPPJD(GameObject NHLNHJGAONN);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NGIHKJHCOAG(GameObject NHLNHJGAONN, bool JKPBENANLGN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class DDJPIFBJLNK
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static LFJKMGBCNCD HBHLLIKFPMD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool KAMDJLEGJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x684C5E0", Offset = "0x684B3E0", VA = "0x18684C5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x684C6B0", Offset = "0x684B4B0", VA = "0x18684C6B0")]
	public static void GNDDCGDDBME(LFJKMGBCNCD DHMMAEIPPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x684C850", Offset = "0x684B650", VA = "0x18684C850")]
	public static Material MOJGLFEPIPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6849C20", Offset = "0x6848A20", VA = "0x186849C20")]
	public static Material MCGMKNIJPBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x684C7F0", Offset = "0x684B5F0", VA = "0x18684C7F0")]
	public static Material JGAKPNIGNEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x684C640", Offset = "0x684B440", VA = "0x18684C640")]
	public static int DNCODMMABCH(OAEIMDOBIAE EPMAFGOIKLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x684C9A0", Offset = "0x684B7A0", VA = "0x18684C9A0")]
	public static int OLLHJIFOEFE(FCKJPJLMAPE OJBGLGMEMLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x684C710", Offset = "0x684B510", VA = "0x18684C710")]
	public static void JEBOKIFPPJD(GameObject NHLNHJGAONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x684C8B0", Offset = "0x684B6B0", VA = "0x18684C8B0")]
	public static void NGIHKJHCOAG(GameObject NHLNHJGAONN, bool JKPBENANLGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DCHOGJLDLKK : HJOKBFCINBF
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HOHEHLHBENG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DCHOGJLDLKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public HOHEHLHBENG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x684CD80", Offset = "0x684BB80", VA = "0x18684CD80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x684CA10", Offset = "0x684B810", VA = "0x18684CA10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x684CC30", Offset = "0x684BA30", VA = "0x18684CC30")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x684CD30", Offset = "0x684BB30", VA = "0x18684CD30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x684CC80", Offset = "0x684BA80", VA = "0x18684CC80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x684CC80", Offset = "0x684BA80", VA = "0x18684CC80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly ABHGPEPJHAG DICJPFMLDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly OJANAILMLJH EKKNIEKGKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NOMNHKEGMDG DPPCMJACLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<KJAJOJDIONN> PBMFCILNEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private List<KJAJOJDIONN> DHEMHDJCNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GameObject LFKDOJEHOLC;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x684B8E0", Offset = "0x684A6E0", VA = "0x18684B8E0")]
	public static DCHOGJLDLKK MDFAPJHKFEG(ABHGPEPJHAG OMHIFBJFAGA, OJANAILMLJH EKKNIEKGKDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x684C500", Offset = "0x684B300", VA = "0x18684C500")]
	private DCHOGJLDLKK(ABHGPEPJHAG OMHIFBJFAGA, OJANAILMLJH EKKNIEKGKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x684B200", Offset = "0x684A000", VA = "0x18684B200")]
	public void EMJKKLCOFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x684B150", Offset = "0x6849F50", VA = "0x18684B150")]
	[IteratorStateMachine(typeof(HOHEHLHBENG))]
	public IEnumerable<Renderer> ANIJLALHOGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x684BA30", Offset = "0x684A830", VA = "0x18684BA30", Slot = "4")]
	public void OEGNFOGIFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x684B1D0", Offset = "0x6849FD0", VA = "0x18684B1D0")]
	private void BFBOGLKNOAO(Vector3 FCOKLDMEDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x684B690", Offset = "0x684A490", VA = "0x18684B690")]
	public void LLIADGIKINC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KJAJOJDIONN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct MKJBADCNCGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public ABPIHCMGHHG GEJMCKKPMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AMFINDHLENJ BFACKJFNBDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int NFIEMKBAHBC;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class AEKJMHGJNJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public KJAJOJDIONN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public CDKBKGKLIGO lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<MKJBADCNCGK> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GEAAJBLIKPP combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public AEKJMHGJNJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6848870", Offset = "0x6847670", VA = "0x186848870")]
		internal JobHandle IAAMCOOOKCL()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6848A40", Offset = "0x6847840", VA = "0x186848A40")]
		internal void NIPJHGHIHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x68488D0", Offset = "0x68476D0", VA = "0x1868488D0")]
		internal void IOMBCIGDCHC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int[] JCPIIDBIGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private KCHEIOIHDLB GJCNCDGPCBL;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Matrix4x4 IELGMGEBFFF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh EIGBAIPFFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int APDKACJPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B77F0", Offset = "0x7B65F0", VA = "0x1807B77F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x68514E0", Offset = "0x68502E0", VA = "0x1868514E0")]
	public void JAAAFDOJDEG(List<AMFINDHLENJ> OEEPHILMGFA, Matrix4x4[] PCMBPLOJHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6850E50", Offset = "0x684FC50", VA = "0x186850E50")]
	public static List<KJAJOJDIONN> IKNJBMGGGFK(List<BNHENNMKCBG> EPHOINPIKCO, CDKBKGKLIGO KEIPHEGFNFM, Bounds PPDPHIMAJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6850960", Offset = "0x684F760", VA = "0x186850960")]
	private JobHandle AJIGHBIKLFJ(GEAAJBLIKPP CKACEMJMJMI, int OKCCCLKDDPJ, int EHMJDPLLMJE, CDKBKGKLIGO KEIPHEGFNFM, List<MKJBADCNCGK> GIMMAIADPGA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6850D70", Offset = "0x684FB70", VA = "0x186850D70")]
	private void IIPDKGOIIMN(List<MKJBADCNCGK> GIMMAIADPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6851870", Offset = "0x6850670", VA = "0x186851870")]
	private KJAJOJDIONN(List<MKJBADCNCGK> GIMMAIADPGA, int OKCCCLKDDPJ, int EHMJDPLLMJE, CDKBKGKLIGO KEIPHEGFNFM, Bounds PPDPHIMAJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6850CD0", Offset = "0x684FAD0", VA = "0x186850CD0", Slot = "4")]
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
		private MaterialPropertyBlock IFGMJEBAMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KJAJOJDIONN CKIIGCAJEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private List<AMFINDHLENJ> FCGHEMBDHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private RenderTexture POHLALDHFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeBuffer BGDHFHHAOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ComputeShader KPKIHCMNENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Matrix4x4[] AGHADGEPHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int ACDMBNIBPIL;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public MeshRenderer NCBKGCHGNGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int NAHPPPMGCDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x685AF80", Offset = "0x6859D80", VA = "0x18685AF80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x685A2B0", Offset = "0x68590B0", VA = "0x18685A2B0")]
		public static List<SkinnedShapeRenderer> Create(GameObject ADCDJFADKCK, List<KJAJOJDIONN> DCAEHJHBCPH, List<AMFINDHLENJ> FCGHEMBDHMH, Material CMHHFEPJBNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x685A540", Offset = "0x6859340", VA = "0x18685A540")]
		public void Init(KJAJOJDIONN CKIIGCAJEFJ, List<AMFINDHLENJ> FCGHEMBDHMH, Material CMHHFEPJBNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x685AE20", Offset = "0x6859C20", VA = "0x18685AE20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x685AD80", Offset = "0x6859B80", VA = "0x18685AD80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x685AD40", Offset = "0x6859B40", VA = "0x18685AD40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x685AEC0", Offset = "0x6859CC0", VA = "0x18685AEC0")]
		private void PAKKBDDPPCK(ScriptableRenderContext HOLFPPNPJAH, Camera[] FIGPJABOCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x685A9D0", Offset = "0x68597D0", VA = "0x18685A9D0")]
		private void JAAAFDOJDEG(CommandBuffer GIFEGHAAFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
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
