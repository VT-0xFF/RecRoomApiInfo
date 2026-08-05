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
public class HPAFAHEHPKF : NOPDMENEPGJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte ICAONPPJINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] MAEANLNDHBF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NMBIOGDKMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EF630", Offset = "0x7EEA30", VA = "0x1807EF630", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EF600", Offset = "0x7EEA00", VA = "0x1807EF600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MNJDPOGGEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A3F30", Offset = "0x7A3330", VA = "0x1807A3F30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A3BA0", Offset = "0x7A2FA0", VA = "0x1807A3BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float OAGHBPBMDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B78F0", Offset = "0x7B6CF0", VA = "0x1807B78F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B7D10", Offset = "0x7B7110", VA = "0x1807B7D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CPCFKFHFCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B7BF0", Offset = "0x7B6FF0", VA = "0x1807B7BF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B8530", Offset = "0x7B7930", VA = "0x1807B8530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> BDLLGBFJFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6379790", Offset = "0x6378B90", VA = "0x186379790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> MLODJKLMGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6379240", Offset = "0x6378640", VA = "0x186379240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject BFOGAKMAJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A830", VA = "0x18076B430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte EAJFEADHKBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63794D0", Offset = "0x63788D0", VA = "0x1863794D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x63797E0", Offset = "0x6378BE0", VA = "0x1863797E0")]
	public HPAFAHEHPKF(List<GLOECPIKCOM> ADHGDBHPAOD, List<GLOECPIKCOM> EEANKPKJPKC, List<NOGOGGHJDHE> FHIDFHNBHKP, Material CFMOAHBPGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6379520", Offset = "0x6378920", VA = "0x186379520")]
	private int KPDBGGNKPCD(List<GLOECPIKCOM> ODELHDLNMCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6379270", Offset = "0x6378670", VA = "0x186379270")]
	private void DLGCILLIDBJ(int LNCIFHEKJJM, bool NGEFJHDPCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6379640", Offset = "0x6378A40", VA = "0x186379640")]
	public void MFJEFIPMCIG(Vector3 DNCJOLLEEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63793D0", Offset = "0x63787D0", VA = "0x1863793D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6379200", Offset = "0x6378600", VA = "0x186379200")]
	public void AOICNEOHCEN(Transform KGNLAINDHBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OMNBKIKJAJE : IGMGEPKIFLL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class ALMJIDDILCG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public OMNBKIKJAJE <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public ALMJIDDILCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6373EC0", Offset = "0x63732C0", VA = "0x186373EC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6373810", Offset = "0x6372C10", VA = "0x186373810", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6373D20", Offset = "0x6373120", VA = "0x186373D20")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6373D70", Offset = "0x6373170", VA = "0x186373D70")]
		private void POMJOEIOKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63737C0", Offset = "0x6372BC0", VA = "0x1863737C0")]
		private void MILPNFLMIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6373E70", Offset = "0x6373270", VA = "0x186373E70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6373DC0", Offset = "0x63731C0", VA = "0x186373DC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6373DC0", Offset = "0x63731C0", VA = "0x186373DC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class LFAKHNCCJKN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public OMNBKIKJAJE <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public LFAKHNCCJKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x637C830", Offset = "0x637BC30", VA = "0x18637C830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x637C320", Offset = "0x637B720", VA = "0x18637C320", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x637C690", Offset = "0x637BA90", VA = "0x18637C690")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x637C6E0", Offset = "0x637BAE0", VA = "0x18637C6E0")]
		private void POMJOEIOKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x637C7E0", Offset = "0x637BBE0", VA = "0x18637C7E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x637C730", Offset = "0x637BB30", VA = "0x18637C730", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x637C730", Offset = "0x637BB30", VA = "0x18637C730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OOFILFLGHMJ FCLGCMFKGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<IIHKKGDDCOA> DAKIECBAOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> CBBICPDKLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer BCCEOHLOEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool AEHCCJFKAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool BIBMGJCMEAO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<KABNOBNGCIP> LPNJNDOLKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EOLIMCONNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6380C30", Offset = "0x6380030", VA = "0x186380C30", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NOGOGGHJDHE GAOGGLCOCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6380890", Offset = "0x637FC90", VA = "0x186380890", Slot = "8")]
		get
		{
			return default(NOGOGGHJDHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> ABMPIEDBLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x767760", Offset = "0x766B60", VA = "0x180767760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63807F0", Offset = "0x637FBF0", VA = "0x1863807F0")]
	private bool JIPFCFBOCHE(IIHKKGDDCOA OAKMFADMPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x637FBE0", Offset = "0x637EFE0", VA = "0x18637FBE0")]
	private static bool DHOEELPFIHH(IIHKKGDDCOA OAKMFADMPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6380D30", Offset = "0x6380130", VA = "0x186380D30")]
	public OMNBKIKJAJE(OOFILFLGHMJ OOIBMCBCEPD, bool LNJNLMKFJCG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x637FC00", Offset = "0x637F000", VA = "0x18637FC00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6380030", Offset = "0x637F430", VA = "0x186380030")]
	public void GIHKKMKIIOJ(IIHKKGDDCOA OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63801D0", Offset = "0x637F5D0", VA = "0x1863801D0")]
	public void HFJFDMFKDND(IIHKKGDDCOA OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63802F0", Offset = "0x637F6F0", VA = "0x1863802F0", Slot = "4")]
	public void HMOOIDMHPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6380960", Offset = "0x637FD60", VA = "0x186380960")]
	public void MCPJDCOFDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x637FE20", Offset = "0x637F220", VA = "0x18637FE20")]
	private void FIPFLLAGLDP(List<IIHKKGDDCOA> DAKIECBAOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6374390", Offset = "0x6373790", VA = "0x186374390")]
	private static Material JGDCGPPFABP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x637FD80", Offset = "0x637F180", VA = "0x18637FD80")]
	private void FIPFLLAGLDP(IIHKKGDDCOA OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6380C70", Offset = "0x6380070", VA = "0x186380C70")]
	private void OHHFKGCDHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x637F630", Offset = "0x637EA30", VA = "0x18637F630")]
	public void BJGGJMDOFCJ(bool BGFCIFNMIAJ, bool NPGDOELKPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6380810", Offset = "0x637FC10", VA = "0x186380810")]
	protected void KFNFCCIIOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6380BB0", Offset = "0x637FFB0", VA = "0x186380BB0")]
	[IteratorStateMachine(typeof(ALMJIDDILCG))]
	public IEnumerable<Renderer> MKMBHCOPEFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x637FFB0", Offset = "0x637F3B0", VA = "0x18637FFB0")]
	[IteratorStateMachine(typeof(LFAKHNCCJKN))]
	public IEnumerable<Renderer> FPFMGCPPDEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class MKAEHBEFKJL : IIHKKGDDCOA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct CHHOEJFJMNE : IOHGIIIEMGJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private EGDAGDGMKBL PFHPDAMABCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle HDIPEJPBMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private BCFIGDHEHAN PFJLAMMIMCH;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63745C0", Offset = "0x63739C0", VA = "0x1863745C0")]
		public CHHOEJFJMNE(EGDAGDGMKBL PFHPDAMABCN, JobHandle HDIPEJPBMFJ, BCFIGDHEHAN PFJLAMMIMCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6374590", Offset = "0x6373990", VA = "0x186374590", Slot = "4")]
		public EGDAGDGMKBL GIKDBELLELC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6374540", Offset = "0x6373940", VA = "0x186374540", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LCIHMMNBHBM CKKBCLFOBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float ALFKMEKLOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 FKMKIJBEMEF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 IPHAACKGHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x637CA30", Offset = "0x637BE30", VA = "0x18637CA30", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x637E0F0", Offset = "0x637D4F0", VA = "0x18637E0F0")]
	public MKAEHBEFKJL(OMNBKIKJAJE JMNDOLBKAMN, LCIHMMNBHBM OOIBMCBCEPD, bool LNJNLMKFJCG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "15")]
	public override bool NNGMJLJBJLC(NOGOGGHJDHE JMNDOLBKAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x637D630", Offset = "0x637CA30", VA = "0x18637D630", Slot = "17")]
	public override int KPDBGGNKPCD(DBDIAOLDDNA EHGKCDIPOOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x637D800", Offset = "0x637CC00", VA = "0x18637D800", Slot = "18")]
	public override int LPFIILLGGLJ(DBDIAOLDDNA EHGKCDIPOOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x637D9D0", Offset = "0x637CDD0", VA = "0x18637D9D0", Slot = "19")]
	public override void PCCGFKCMGDE(DBDIAOLDDNA EHGKCDIPOOP, LNOOBNFAKHJ PNEKIAGPCAB, int ILNOGDBNHOD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x637C960", Offset = "0x637BD60", VA = "0x18637C960", Slot = "20")]
	public override NOGOGGHJDHE DDPLAOKCOEG()
	{
		return default(NOGOGGHJDHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x637D480", Offset = "0x637C880", VA = "0x18637D480", Slot = "22")]
	public override GEIIPKFGDHC JADMKGMICJO()
	{
		return default(GEIIPKFGDHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x637CB60", Offset = "0x637BF60", VA = "0x18637CB60", Slot = "23")]
	public override IOHGIIIEMGJ HJDHNDEPGGA(DBDIAOLDDNA EHGKCDIPOOP, JobHandle HDIPEJPBMFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DefaultMember("Item")]
public interface PGHAOOKFNDD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	OMNBKIKJAJE ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IIHKKGDDCOA ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MLLFGPPALCJ ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class LBFPLFIBOLA : MIKJKBLJLIL, IDisposable, PGHAOOKFNDD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct EAMDOHIIOFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LBFPLFIBOLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63769B0", Offset = "0x6375DB0", VA = "0x1863769B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6376ED0", Offset = "0x63762D0", VA = "0x186376ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly PECODDLLAOH<FHFCKFMDLFN, OMNBKIKJAJE> OGKCPJAEDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly PECODDLLAOH<BKCIFCGPBKB, IIHKKGDDCOA> DAKIECBAOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly PECODDLLAOH<ANNDCDNBKND, MLLFGPPALCJ> DKKBFJFDDJP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public OMNBKIKJAJE ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x637A2B0", Offset = "0x63796B0", VA = "0x18637A2B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IIHKKGDDCOA ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x637A370", Offset = "0x6379770", VA = "0x18637A370", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MLLFGPPALCJ ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x637A310", Offset = "0x6379710", VA = "0x18637A310", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool JHDCIAPPNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7E06E0", Offset = "0x7DFAE0", VA = "0x1807E06E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8520D0", Offset = "0x8514D0", VA = "0x1808520D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x637BE70", Offset = "0x637B270", VA = "0x18637BE70")]
	public LBFPLFIBOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x637A450", Offset = "0x6379850", VA = "0x18637A450", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x637A860", Offset = "0x6379C60", VA = "0x18637A860", Slot = "4")]
	public FHFCKFMDLFN EOJGOMEANIM(OOFILFLGHMJ OOIBMCBCEPD)
	{
		return default(FHFCKFMDLFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x637A5E0", Offset = "0x63799E0", VA = "0x18637A5E0", Slot = "5")]
	public FHFCKFMDLFN EOJGOMEANIM(OOFILFLGHMJ OOIBMCBCEPD, bool LNJNLMKFJCG)
	{
		return default(FHFCKFMDLFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x637ADF0", Offset = "0x637A1F0", VA = "0x18637ADF0", Slot = "6")]
	public void IHKFCGNEDFL(FHFCKFMDLFN JMNDOLBKAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x637B050", Offset = "0x637A450", VA = "0x18637B050", Slot = "7")]
	public void JDMOOKCGIHN(FHFCKFMDLFN JMNDOLBKAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x637B3B0", Offset = "0x637A7B0", VA = "0x18637B3B0", Slot = "8")]
	public BKCIFCGPBKB KGFKHIPHIMC(FHFCKFMDLFN JMNDOLBKAMN, EKKPLHGPBED OOIBMCBCEPD)
	{
		return default(BKCIFCGPBKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x637B900", Offset = "0x637AD00", VA = "0x18637B900", Slot = "9")]
	public BKCIFCGPBKB LCACLLEBEEC(FHFCKFMDLFN JMNDOLBKAMN, LCIHMMNBHBM OOIBMCBCEPD)
	{
		return default(BKCIFCGPBKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6379D60", Offset = "0x6379160", VA = "0x186379D60", Slot = "11")]
	public void CEELMOEJDKP(BKCIFCGPBKB OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x637AA50", Offset = "0x6379E50", VA = "0x18637AA50", Slot = "10")]
	public void FGMJNEDPGIA(BKCIFCGPBKB OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x637B890", Offset = "0x637AC90", VA = "0x18637B890", Slot = "20")]
	public IEnumerable<Renderer> KLHPFIBPBCD(FHFCKFMDLFN JMNDOLBKAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x637A3D0", Offset = "0x63797D0", VA = "0x18637A3D0", Slot = "12")]
	public ANNDCDNBKND DFNFDIBHDAG(FEDJFGFPPAN OOIBMCBCEPD)
	{
		return default(ANNDCDNBKND);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x637ACB0", Offset = "0x637A0B0", VA = "0x18637ACB0", Slot = "14")]
	public void FNAGJBNFMGJ(ANNDCDNBKND NPDHEADHGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x637A120", Offset = "0x6379520", VA = "0x18637A120", Slot = "16")]
	public Task CMDGFNNMGJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x637A870", Offset = "0x6379C70", VA = "0x18637A870", Slot = "17")]
	public Task FBDOBMDOPDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x637AD20", Offset = "0x637A120", VA = "0x18637AD20", Slot = "18")]
	[AsyncStateMachine(typeof(EAMDOHIIOFO))]
	public Task HKPDMALOAJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x637BDE0", Offset = "0x637B1E0", VA = "0x18637BDE0", Slot = "19")]
	public void LIGGBLJEKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x637A9F0", Offset = "0x6379DF0", VA = "0x18637A9F0", Slot = "13")]
	public void FCPFBHHFMHI(ANNDCDNBKND NPDHEADHGND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class CMJIEJIOGFG : IIHKKGDDCOA
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct GNIIDDIOGPG : IOHGIIIEMGJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private EGDAGDGMKBL PFHPDAMABCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle HDIPEJPBMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private PPBHHHNGEKG PFJLAMMIMCH;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x63791B0", Offset = "0x63785B0", VA = "0x1863791B0")]
		public GNIIDDIOGPG(EGDAGDGMKBL PFHPDAMABCN, JobHandle HDIPEJPBMFJ, PPBHHHNGEKG PFJLAMMIMCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6379180", Offset = "0x6378580", VA = "0x186379180", Slot = "4")]
		public EGDAGDGMKBL GIKDBELLELC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6379130", Offset = "0x6378530", VA = "0x186379130", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly EKKPLHGPBED GJGGJKOHCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] IHBGPDDFPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 FKMKIJBEMEF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override CLFPGGIMCNE OCICAOIFLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6374A70", Offset = "0x6373E70", VA = "0x186374A70", Slot = "16")]
		get
		{
			return default(CLFPGGIMCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private Vector3 FMLJANJGGBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6374620", Offset = "0x6373A20", VA = "0x186374620")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	protected override Hash128 IPHAACKGHEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6374E30", Offset = "0x6374230", VA = "0x186374E30", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6376900", Offset = "0x6375D00", VA = "0x186376900")]
	public CMJIEJIOGFG(OMNBKIKJAJE JMNDOLBKAMN, EKKPLHGPBED OOIBMCBCEPD, bool LEEDGNDGDIP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6375CE0", Offset = "0x63750E0", VA = "0x186375CE0", Slot = "15")]
	public override bool NNGMJLJBJLC(NOGOGGHJDHE JMNDOLBKAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6375BA0", Offset = "0x6374FA0", VA = "0x186375BA0", Slot = "17")]
	public override int KPDBGGNKPCD(DBDIAOLDDNA EHGKCDIPOOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6375C40", Offset = "0x6375040", VA = "0x186375C40", Slot = "18")]
	public override int LPFIILLGGLJ(DBDIAOLDDNA EHGKCDIPOOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x63757A0", Offset = "0x6374BA0", VA = "0x1863757A0")]
	private int IDIDIIHFCAB(DBDIAOLDDNA EHGKCDIPOOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6376170", Offset = "0x6375570", VA = "0x186376170", Slot = "19")]
	public override void PCCGFKCMGDE(DBDIAOLDDNA EHGKCDIPOOP, LNOOBNFAKHJ PNEKIAGPCAB, int ILNOGDBNHOD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x63749A0", Offset = "0x6373DA0", VA = "0x1863749A0", Slot = "20")]
	public override NOGOGGHJDHE DDPLAOKCOEG()
	{
		return default(NOGOGGHJDHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x63759F0", Offset = "0x6374DF0", VA = "0x1863759F0", Slot = "22")]
	public override GEIIPKFGDHC JADMKGMICJO()
	{
		return default(GEIIPKFGDHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6374F60", Offset = "0x6374360", VA = "0x186374F60", Slot = "23")]
	public override IOHGIIIEMGJ HJDHNDEPGGA(DBDIAOLDDNA EHGKCDIPOOP, JobHandle HDIPEJPBMFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AJHDKGIDGIN
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKDBGMBKMMM(OEDAPBKPHMN DJMKKNDNCBM, Renderer HOOHFMEGECM, int JDPHCMFPCPH);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDFFMOINFKM(Renderer HOOHFMEGECM, BHILLCOFFCH PCOEBGIMJEO, Vector3 BCHLEDBLOIN, Vector3 KGPMIOBLMPI, Vector3 LPAHAJMOGAE, float HKMJBLGHAHC, float IKHNAOINDAI, float OLIMPMJKECP = -1f, [Optional] Color? KKBAHNFNJMK, [Optional] IReadOnlyList<Camera> KMFCEMEIODE);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFAMHDHHBPL(Renderer HOOHFMEGECM, int JDPHCMFPCPH);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ICAOBCCGFCA();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CENAHDDCNHC(int BCFENJKKALP, HKEOIHFAMCC DJMKKNDNCBM, Renderer HOOHFMEGECM, int JDPHCMFPCPH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PLCBHBJDIFD : LICBIGCJLJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class IGCHCGFLJNN : EIIKFLADMAM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6379AF0", Offset = "0x6378EF0", VA = "0x186379AF0")]
		public IGCHCGFLJNN(string DKFEAPHKBMP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AJHDKGIDGIN GHIHGBCPDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly PGHAOOKFNDD ICCJEGDDKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer IGHCPHJGOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private IGCHCGFLJNN FBOGHBKIEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool EHKCLOOMKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer FGCGGCBJOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private IGCHCGFLJNN NKINKMAJJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool FBPNPHHDOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer AJMABGLNNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private IGCHCGFLJNN JOKAHCCPFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool LDCMHPNHJNB;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x769080", Offset = "0x768480", VA = "0x180769080")]
	public PLCBHBJDIFD(AJHDKGIDGIN HDDLMOLGKGF, PGHAOOKFNDD ICCJEGDDKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6382760", Offset = "0x6381B60", VA = "0x186382760", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6383B70", Offset = "0x6382F70", VA = "0x186383B70")]
	private void JACKMBFDKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6382910", Offset = "0x6381D10", VA = "0x186382910", Slot = "4")]
	public void EALIOGOFLMG(FHFCKFMDLFN JMNDOLBKAMN, HKEOIHFAMCC FJGJCFHIBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6382C10", Offset = "0x6382010", VA = "0x186382C10", Slot = "5")]
	public void EALIOGOFLMG(BKCIFCGPBKB OAKMFADMPMH, HKEOIHFAMCC FJGJCFHIBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6383A00", Offset = "0x6382E00", VA = "0x186383A00", Slot = "6")]
	public void HGHKANOAPCO(BKCIFCGPBKB OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6383440", Offset = "0x6382840", VA = "0x186383440", Slot = "7")]
	public void FGMAFOHOONF(BKCIFCGPBKB OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6383FC0", Offset = "0x63833C0", VA = "0x186383FC0", Slot = "21")]
	public void PFGMJIDFJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7FBE80", Offset = "0x7FB280", VA = "0x1807FBE80", Slot = "8")]
	public void NMIMLELLLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6383DB0", Offset = "0x63831B0", VA = "0x186383DB0", Slot = "9")]
	public void LBCDFGGCIBI(HKEOIHFAMCC FJGJCFHIBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6383160", Offset = "0x6382560", VA = "0x186383160", Slot = "10")]
	public void FDCHEKOFJNM(FHFCKFMDLFN JMNDOLBKAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6382E30", Offset = "0x6382230", VA = "0x186382E30", Slot = "11")]
	public void FDCHEKOFJNM(BKCIFCGPBKB OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6383730", Offset = "0x6382B30", VA = "0x186383730", Slot = "12")]
	public void GDCDLNCGHPL(FHFCKFMDLFN JMNDOLBKAMN, OEDAPBKPHMN DJMKKNDNCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6383550", Offset = "0x6382950", VA = "0x186383550", Slot = "13")]
	public void GDCDLNCGHPL(BKCIFCGPBKB OAKMFADMPMH, OEDAPBKPHMN DJMKKNDNCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6383B30", Offset = "0x6382F30", VA = "0x186383B30", Slot = "22")]
	public void HKHNHFDIOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6383F20", Offset = "0x6383320", VA = "0x186383F20", Slot = "14")]
	public void LCBJJCFGIAD(BKCIFCGPBKB OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6381C20", Offset = "0x6381020", VA = "0x186381C20", Slot = "15")]
	public void AEDBINPIKFO(BKCIFCGPBKB OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1586C40", Offset = "0x1586040", VA = "0x181586C40", Slot = "16")]
	public void BIACCODMFDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6384000", Offset = "0x6383400", VA = "0x186384000", Slot = "17")]
	public void PKPBEBHFFJD(OEDAPBKPHMN DJMKKNDNCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6381CB0", Offset = "0x63810B0", VA = "0x186381CB0")]
	private void AIICAOAGECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6381EF0", Offset = "0x63812F0", VA = "0x186381EF0", Slot = "18")]
	public void BMOMMAEIIHA(FHFCKFMDLFN JMNDOLBKAMN, Vector3 BCHLEDBLOIN, Vector3 KGPMIOBLMPI, Vector3 LPAHAJMOGAE, float HKMJBLGHAHC, float IKHNAOINDAI, IReadOnlyList<Camera> DJPGEDGACCC, BHILLCOFFCH PCOEBGIMJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63822C0", Offset = "0x63816C0", VA = "0x1863822C0", Slot = "19")]
	public void BMOMMAEIIHA(ANNDCDNBKND NPDHEADHGND, Vector3 BCHLEDBLOIN, Vector3 KGPMIOBLMPI, Vector3 LPAHAJMOGAE, float HKMJBLGHAHC, float IKHNAOINDAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class IIHKKGDDCOA : KLFFPBMFANB, KABNOBNGCIP, DBFGPEMCLHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly OMNBKIKJAJE BFOGAKMAJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected Bounds DILCPGHAOCI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Bounds JEMOJBPGJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xD23080", Offset = "0xD22480", VA = "0x180D23080", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public virtual CLFPGGIMCNE OCICAOIFLCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6379CA0", Offset = "0x63790A0", VA = "0x186379CA0", Slot = "16")]
		get
		{
			return default(CLFPGGIMCNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BIBMGJCMEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B8540", Offset = "0x7B7940", VA = "0x1807B8540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B7D20", Offset = "0x7B7120", VA = "0x1807B7D20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	protected abstract Hash128 IPHAACKGHEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HENIADMKNHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8015E0", Offset = "0x8009E0", VA = "0x1808015E0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public NDOINKNOHDD AECLFAFMOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x767760", Offset = "0x766B60", VA = "0x180767760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool FHGDKKIHEIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x108B3A0", Offset = "0x108A7A0", VA = "0x18108B3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	protected IIHKKGDDCOA(OMNBKIKJAJE JMNDOLBKAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6379B70", Offset = "0x6378F70", VA = "0x186379B70", Slot = "14")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "15")]
	public virtual bool NNGMJLJBJLC(NOGOGGHJDHE JMNDOLBKAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract int KPDBGGNKPCD(DBDIAOLDDNA EHGKCDIPOOP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int LPFIILLGGLJ(DBDIAOLDDNA EHGKCDIPOOP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void PCCGFKCMGDE(DBDIAOLDDNA EHGKCDIPOOP, LNOOBNFAKHJ PNEKIAGPCAB, int ILNOGDBNHOD = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract NOGOGGHJDHE DDPLAOKCOEG();

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6379B40", Offset = "0x6378F40", VA = "0x186379B40", Slot = "10")]
	public Hash128 DBKDNAPPANK(int EHGKCDIPOOP)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract GEIIPKFGDHC JADMKGMICJO();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract IOHGIIIEMGJ HJDHNDEPGGA(DBDIAOLDDNA EHGKCDIPOOP, JobHandle HDIPEJPBMFJ);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6379D30", Offset = "0x6379130", VA = "0x186379D30", Slot = "9")]
	public IOHGIIIEMGJ JHGDAFJFKBH(int EHGKCDIPOOP)
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
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6384130", Offset = "0x6383530", VA = "0x186384130")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ONFBBCBKGBK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class AEKLHNHNMPL : IEnumerable<GLGBHKGHEMF>, IEnumerable, IEnumerator<GLGBHKGHEMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private GLGBHKGHEMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private GLGBHKGHEMF System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public AEKLHNHNMPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6373400", Offset = "0x6372800", VA = "0x186373400", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6373570", Offset = "0x6372970", VA = "0x186373570", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x63734D0", Offset = "0x63728D0", VA = "0x1863734D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GLGBHKGHEMF> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x63734D0", Offset = "0x63728D0", VA = "0x1863734D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static GLGBHKGHEMF[][] LAMCJNLANFI;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static DDMAKFBHEHF FBIFBMJKEME;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static ShapeRendererConfig KEADAFBNHKF;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ComputeShader JHNCIMBHEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6381030", Offset = "0x6380430", VA = "0x186381030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static SkinnedShapeRenderer PHIONBFCJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x63819C0", Offset = "0x6380DC0", VA = "0x1863819C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6381920", Offset = "0x6380D20", VA = "0x186381920")]
	public static Mesh LJFNJAAAFDM(OIBIFCJLEDH IGIAEFADHKI, int EHGKCDIPOOP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6381260", Offset = "0x6380660", VA = "0x186381260")]
	public static int FPCDNCOAGPM(OIBIFCJLEDH IGIAEFADHKI, int EHGKCDIPOOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6381A20", Offset = "0x6380E20", VA = "0x186381A20")]
	public static DDMAKFBHEHF PGMPGGOBPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6380FD0", Offset = "0x63803D0", VA = "0x186380FD0")]
	[IteratorStateMachine(typeof(AEKLHNHNMPL))]
	private static IEnumerable<GLGBHKGHEMF> CNBGKCBHAJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6381670", Offset = "0x6380A70", VA = "0x186381670")]
	public static GLGBHKGHEMF LGAIDLBDEOJ(OIBIFCJLEDH IGIAEFADHKI, int EHGKCDIPOOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6381650", Offset = "0x6380A50", VA = "0x186381650")]
	public static bool LBAMDKBKNEI(this OIBIFCJLEDH IGIAEFADHKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6380E20", Offset = "0x6380220", VA = "0x186380E20")]
	public static void AFPNFNODODK(OIBIFCJLEDH IGIAEFADHKI, float3 PILMODFCIGD, [Out] NOEGBMCPIIK MBNPOBMPAAG, [Out] float3 HLGGFLIIBKF, [Out] float KHLFCHNMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6381270", Offset = "0x6380670", VA = "0x186381270")]
	public static void IHHGIMAMHFI(Vector3 PILMODFCIGD, OIBIFCJLEDH IGIAEFADHKI, [Out] Vector3 HLGGFLIIBKF, [Out] float KHLFCHNMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6381640", Offset = "0x6380A40", VA = "0x186381640")]
	[EHPPELLEMKJ(BNMAFOGGIIG.ExitingPlayMode, 0)]
	private static void JHEJLJDMIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6381090", Offset = "0x6380490", VA = "0x186381090")]
	[EHPPELLEMKJ(BNMAFOGGIIG.ExitingPlayMode, 0)]
	private static void FEGGPPINCEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class EKANJDHMFHJ : MIKJKBLJLIL, IDisposable, PGHAOOKFNDD
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly FJOGIBEAJHF AABDFOONPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly PECODDLLAOH<FHFCKFMDLFN, OMNBKIKJAJE> OGKCPJAEDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly PECODDLLAOH<BKCIFCGPBKB, IIHKKGDDCOA> DAKIECBAOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly PECODDLLAOH<ANNDCDNBKND, MLLFGPPALCJ> DKKBFJFDDJP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public OMNBKIKJAJE ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6377060", Offset = "0x6376460", VA = "0x186377060", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IIHKKGDDCOA ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6377120", Offset = "0x6376520", VA = "0x186377120", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public MLLFGPPALCJ ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x63770C0", Offset = "0x63764C0", VA = "0x1863770C0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JHDCIAPPNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E06E0", Offset = "0x7DFAE0", VA = "0x1807E06E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8520D0", Offset = "0x8514D0", VA = "0x1808520D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6377A00", Offset = "0x6376E00", VA = "0x186377A00")]
	public EKANJDHMFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6377200", Offset = "0x6376600", VA = "0x186377200", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6377290", Offset = "0x6376690", VA = "0x186377290", Slot = "4")]
	public FHFCKFMDLFN EOJGOMEANIM(OOFILFLGHMJ OOIBMCBCEPD)
	{
		return default(FHFCKFMDLFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6377290", Offset = "0x6376690", VA = "0x186377290", Slot = "5")]
	public FHFCKFMDLFN EOJGOMEANIM(OOFILFLGHMJ OOIBMCBCEPD, bool LNJNLMKFJCG)
	{
		return default(FHFCKFMDLFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x63775A0", Offset = "0x63769A0", VA = "0x1863775A0", Slot = "6")]
	public void IHKFCGNEDFL(FHFCKFMDLFN JMNDOLBKAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6377600", Offset = "0x6376A00", VA = "0x186377600", Slot = "7")]
	public void JDMOOKCGIHN(FHFCKFMDLFN JMNDOLBKAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6377680", Offset = "0x6376A80", VA = "0x186377680", Slot = "8")]
	public BKCIFCGPBKB KGFKHIPHIMC(FHFCKFMDLFN JMNDOLBKAMN, EKKPLHGPBED OOIBMCBCEPD)
	{
		return default(BKCIFCGPBKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6377830", Offset = "0x6376C30", VA = "0x186377830", Slot = "9")]
	public BKCIFCGPBKB LCACLLEBEEC(FHFCKFMDLFN JMNDOLBKAMN, LCIHMMNBHBM OOIBMCBCEPD)
	{
		return default(BKCIFCGPBKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6376F30", Offset = "0x6376330", VA = "0x186376F30", Slot = "11")]
	public void CEELMOEJDKP(BKCIFCGPBKB OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6377430", Offset = "0x6376830", VA = "0x186377430", Slot = "10")]
	public void FGMJNEDPGIA(BKCIFCGPBKB OAKMFADMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x63777C0", Offset = "0x6376BC0", VA = "0x1863777C0", Slot = "20")]
	public IEnumerable<Renderer> KLHPFIBPBCD(FHFCKFMDLFN JMNDOLBKAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6377180", Offset = "0x6376580", VA = "0x186377180", Slot = "12")]
	public ANNDCDNBKND DFNFDIBHDAG(FEDJFGFPPAN OOIBMCBCEPD)
	{
		return default(ANNDCDNBKND);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6377490", Offset = "0x6376890", VA = "0x186377490", Slot = "14")]
	public void FNAGJBNFMGJ(ANNDCDNBKND NPDHEADHGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6376FC0", Offset = "0x63763C0", VA = "0x186376FC0", Slot = "16")]
	public Task CMDGFNNMGJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6377330", Offset = "0x6376730", VA = "0x186377330", Slot = "17")]
	public Task FBDOBMDOPDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6377500", Offset = "0x6376900", VA = "0x186377500", Slot = "18")]
	public Task HKPDMALOAJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1B5B6C0", Offset = "0x1B5AAC0", VA = "0x181B5B6C0", Slot = "19")]
	public void LIGGBLJEKOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x63773D0", Offset = "0x63767D0", VA = "0x1863773D0", Slot = "13")]
	public void FCPFBHHFMHI(ANNDCDNBKND NPDHEADHGND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LCKBGEENONB
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool PPDAIDNNDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material DOPCHOPKKHF();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material JGDCGPPFABP();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material DPALFODMGDH();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IOCILDKCDCK(NCILIAGLIJH OJBINANJOEJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NGFOGPOIFFI(JLNMGILEGED CAOMFJCHDCJ);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NNCJOEBPCHP(GameObject IBBNLILJNEB);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FCKGJKAJGCO(GameObject IBBNLILJNEB, bool NNCIKCKHNON);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class BJJNNIPBMMJ
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static LCKBGEENONB GHADCFDOJAA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool PPDAIDNNDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x63740B0", Offset = "0x63734B0", VA = "0x1863740B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6374110", Offset = "0x6373510", VA = "0x186374110")]
	public static void BPCMNFMICIN(LCKBGEENONB NJEGINBHFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6374170", Offset = "0x6373570", VA = "0x186374170")]
	public static Material DOPCHOPKKHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6374390", Offset = "0x6373790", VA = "0x186374390")]
	public static Material JGDCGPPFABP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x63741D0", Offset = "0x63735D0", VA = "0x1863741D0")]
	public static Material DPALFODMGDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6374320", Offset = "0x6373720", VA = "0x186374320")]
	public static int IOCILDKCDCK(NCILIAGLIJH OJBINANJOEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x63743F0", Offset = "0x63737F0", VA = "0x1863743F0")]
	public static int NGFOGPOIFFI(JLNMGILEGED CAOMFJCHDCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6374460", Offset = "0x6373860", VA = "0x186374460")]
	public static void NNCJOEBPCHP(GameObject IBBNLILJNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6374230", Offset = "0x6373630", VA = "0x186374230")]
	public static void FCKGJKAJGCO(GameObject IBBNLILJNEB, bool NNCIKCKHNON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MLLFGPPALCJ : IGMGEPKIFLL
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ACCNOEEDFII : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public MLLFGPPALCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public ACCNOEEDFII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6373370", Offset = "0x6372770", VA = "0x186373370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6373000", Offset = "0x6372400", VA = "0x186373000", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6373220", Offset = "0x6372620", VA = "0x186373220")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6373320", Offset = "0x6372720", VA = "0x186373320", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6373270", Offset = "0x6372670", VA = "0x186373270", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6373270", Offset = "0x6372670", VA = "0x186373270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly FEDJFGFPPAN NJCAJNFDBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly PGHAOOKFNDD ICCJEGDDKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private HPAFAHEHPKF HCGKBAPDDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<GLOECPIKCOM> GAHGLOKONMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<GLOECPIKCOM> DPIMPMFLENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject DJDINJGNNBL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x637E1D0", Offset = "0x637D5D0", VA = "0x18637E1D0")]
	public static MLLFGPPALCJ HHAAALFGEDH(FEDJFGFPPAN OOIBMCBCEPD, PGHAOOKFNDD ICCJEGDDKLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x637F550", Offset = "0x637E950", VA = "0x18637F550")]
	private MLLFGPPALCJ(FEDJFGFPPAN OOIBMCBCEPD, PGHAOOKFNDD ICCJEGDDKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x637F0C0", Offset = "0x637E4C0", VA = "0x18637F0C0")]
	public void OCOEOHNAACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x637F040", Offset = "0x637E440", VA = "0x18637F040")]
	[IteratorStateMachine(typeof(ACCNOEEDFII))]
	public IEnumerable<Renderer> MKMBHCOPEFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x637E320", Offset = "0x637D720", VA = "0x18637E320", Slot = "4")]
	public void HMOOIDMHPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x637E1A0", Offset = "0x637D5A0", VA = "0x18637E1A0")]
	private void GOAODNPLLKB(Vector3 DNCJOLLEEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x637EDF0", Offset = "0x637E1F0", VA = "0x18637EDF0")]
	public void MCPJDCOFDHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GLOECPIKCOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct KHCIJMNPMOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public LNOOBNFAKHJ EDKECAKAJBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public NOGOGGHJDHE JNMFHNGLPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int CECDEEFEPKA;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AKKKCBAHNKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public GLOECPIKCOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DBDIAOLDDNA lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<KHCIJMNPMOP> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public EGDAGDGMKBL combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public AKKKCBAHNKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x63735C0", Offset = "0x63729C0", VA = "0x1863735C0")]
		internal JobHandle KAFCKKHAIGB()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6373790", Offset = "0x6372B90", VA = "0x186373790")]
		internal void PKPHNOABFCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6373620", Offset = "0x6372A20", VA = "0x186373620")]
		internal void LFKFGILDLND()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] NLPHEIMDDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private GDFDKLIEOIC EJJEBLJBNHB;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 IPCDCFJFGJF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh JCEAEGADHED
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x764460", Offset = "0x763860", VA = "0x180764460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int POLGGJALALP
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76B440", Offset = "0x76A840", VA = "0x18076B440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6377E90", Offset = "0x6377290", VA = "0x186377E90")]
	public void IAEHAJJHDOK(List<NOGOGGHJDHE> COLFLHOFFEE, Matrix4x4[] OLMLPKKLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x63784D0", Offset = "0x63778D0", VA = "0x1863784D0")]
	public static List<GLOECPIKCOM> PJBIIEEDKDI(List<OMNBKIKJAJE> EACHILKEABF, DBDIAOLDDNA EHGKCDIPOOP, Bounds AKLEIOCDFMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6378080", Offset = "0x6377480", VA = "0x186378080")]
	private JobHandle JJNDEBEFHIN(EGDAGDGMKBL MGBIGDJADFD, int JEMJGHABLLM, int OLFKDJLEDLM, DBDIAOLDDNA EHGKCDIPOOP, List<KHCIJMNPMOP> HGCJHCINBHC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x63783F0", Offset = "0x63777F0", VA = "0x1863783F0")]
	private void OGKLFFGNMGN(List<KHCIJMNPMOP> HGCJHCINBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6378D00", Offset = "0x6378100", VA = "0x186378D00")]
	private GLOECPIKCOM(List<KHCIJMNPMOP> HGCJHCINBHC, int JEMJGHABLLM, int OLFKDJLEDLM, DBDIAOLDDNA EHGKCDIPOOP, Bounds AKLEIOCDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6377DF0", Offset = "0x63771F0", VA = "0x186377DF0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private MaterialPropertyBlock COKAIFIBHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private GLOECPIKCOM PFHPDAMABCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<NOGOGGHJDHE> FHIDFHNBHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture GHAMKAOOJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer GHIMIBPIJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader PCCPLJMJELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] FFBOMACEBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int OMCGFLFBMGD;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public MeshRenderer BGKAPPFHLJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x7644F0", VA = "0x1807650F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int IMKGLFDHGEG
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x6384E30", Offset = "0x6384230", VA = "0x186384E30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6384160", Offset = "0x6383560", VA = "0x186384160")]
		public static List<SkinnedShapeRenderer> Create(GameObject JMNDOLBKAMN, List<GLOECPIKCOM> ODELHDLNMCM, List<NOGOGGHJDHE> FHIDFHNBHKP, Material CFMOAHBPGNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6384820", Offset = "0x6383C20", VA = "0x186384820")]
		public void Init(GLOECPIKCOM PFHPDAMABCN, List<NOGOGGHJDHE> FHIDFHNBHKP, Material CFMOAHBPGNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6384D90", Offset = "0x6384190", VA = "0x186384D90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6384CF0", Offset = "0x63840F0", VA = "0x186384CF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6384CB0", Offset = "0x63840B0", VA = "0x186384CB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x63843F0", Offset = "0x63837F0", VA = "0x1863843F0")]
		private void DBALFEKDEMF(ScriptableRenderContext CNKGFJIJGPA, Camera[] HPJMMDPFAIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x63844B0", Offset = "0x63838B0", VA = "0x1863844B0")]
		private void IAEHAJJHDOK(CommandBuffer HPNDNFPAJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
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
