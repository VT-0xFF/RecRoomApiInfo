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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8E71F10", Offset = "0x8E70910", VA = "0x188E71F10", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E783E0", Offset = "0x8E76DE0", VA = "0x188E783E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CIFOAINPAOO : DMMMHJLIOBO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte IEENKGDNHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] KDNJBDMEDKN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JDIDICNNOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAE0110", Offset = "0xADEB10", VA = "0x180AE0110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ABKAKIGBDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC33060", Offset = "0xC31A60", VA = "0x180C33060", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1058A60", Offset = "0x1057460", VA = "0x181058A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float HGFIBGEPCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1083F70", Offset = "0x1082970", VA = "0x181083F70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x155DD60", Offset = "0x155C760", VA = "0x18155DD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float GICLEIBPGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD796D0", Offset = "0xD780D0", VA = "0x180D796D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD796E0", Offset = "0xD780E0", VA = "0x180D796E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> DMPGHFNMAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8E675E0", Offset = "0x8E65FE0", VA = "0x188E675E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> KHGKMAHAEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8E675B0", Offset = "0x8E65FB0", VA = "0x188E675B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte OFFDMJOKLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E67630", Offset = "0x8E66030", VA = "0x188E67630", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8E67680", Offset = "0x8E66080", VA = "0x188E67680")]
	public CIFOAINPAOO(List<FIFHOLAILHO> OOMPGCAJCFM, List<FIFHOLAILHO> NHNPLGGBGBG, List<JFHFHCDHJDD> GBBPMBIJIHO, Material POCHLMCAOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8E67330", Offset = "0x8E65D30", VA = "0x188E67330")]
	private int GMFJDEHBKAM(List<FIFHOLAILHO> MGNEELNALPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8E67450", Offset = "0x8E65E50", VA = "0x188E67450")]
	private void IJNOKCBFILN(int HONFCGAOGEB, bool FJOBDLEAALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8E671E0", Offset = "0x8E65BE0", VA = "0x188E671E0")]
	public void FMMFBBIFOON(Vector3 ACDENENFBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8E670E0", Offset = "0x8E65AE0", VA = "0x188E670E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8E670A0", Offset = "0x8E65AA0", VA = "0x188E670A0")]
	public void CNCDLELIAPP(Transform MKBAFLLJCNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JJILBLDKFFK : MPODEJOJOCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PNHHAKOHMDK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JJILBLDKFFK <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public PNHHAKOHMDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E76D40", Offset = "0x8E75740", VA = "0x188E76D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8E766E0", Offset = "0x8E750E0", VA = "0x188E766E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E76640", Offset = "0x8E75040", VA = "0x188E76640")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8E76BF0", Offset = "0x8E755F0", VA = "0x188E76BF0")]
		private void NADPDCNBFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8E76690", Offset = "0x8E75090", VA = "0x188E76690")]
		private void JANEBMGIMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8E76CF0", Offset = "0x8E756F0", VA = "0x188E76CF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8E76C40", Offset = "0x8E75640", VA = "0x188E76C40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8E76C40", Offset = "0x8E75640", VA = "0x188E76C40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GKPEELJMIKP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JJILBLDKFFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public GKPEELJMIKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BBB0", Offset = "0x8E6A5B0", VA = "0x188E6BBB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8E6B6F0", Offset = "0x8E6A0F0", VA = "0x188E6B6F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E6B6A0", Offset = "0x8E6A0A0", VA = "0x188E6B6A0")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BA60", Offset = "0x8E6A460", VA = "0x188E6BA60")]
		private void NADPDCNBFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BB60", Offset = "0x8E6A560", VA = "0x188E6BB60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BAB0", Offset = "0x8E6A4B0", VA = "0x188E6BAB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BAB0", Offset = "0x8E6A4B0", VA = "0x188E6BAB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly ABLIKGNMCAG MLEOHCPNBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<MBBENIOKGGB> IBPOPKFJEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> ECJALPACCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer FDHBJKHFHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool LJBJPAADOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool LKOCNHOLBGH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<LDKLHGLOLBH> IGBEFPGJENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EPIKAGJABDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E6F500", Offset = "0x8E6DF00", VA = "0x188E6F500", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JFHFHCDHJDD DHDODHIPJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E6F140", Offset = "0x8E6DB40", VA = "0x188E6F140", Slot = "8")]
		get
		{
			return default(JFHFHCDHJDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> KOAJGNLKABP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8E6F540", Offset = "0x8E6DF40", VA = "0x188E6F540")]
	private bool GNDKIPEHELH(MBBENIOKGGB EBOPBDPOAOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8E6FEA0", Offset = "0x8E6E8A0", VA = "0x188E6FEA0")]
	private static bool MNBAJCCCEPP(MBBENIOKGGB EBOPBDPOAOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8E6FF40", Offset = "0x8E6E940", VA = "0x188E6FF40")]
	public JJILBLDKFFK(ABLIKGNMCAG GPCDCFCPGFK, bool EGLLAMHJFAB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8E6F290", Offset = "0x8E6DC90", VA = "0x188E6F290", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8E6FCD0", Offset = "0x8E6E6D0", VA = "0x188E6FCD0")]
	public void MJGPLOFFIKO(MBBENIOKGGB EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8E6EA20", Offset = "0x8E6D420", VA = "0x188E6EA20")]
	public void BBOPECIHIDA(MBBENIOKGGB EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8E6F560", Offset = "0x8E6DF60", VA = "0x188E6F560", Slot = "4")]
	public void HJNCIDGCKKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E6F0", Offset = "0x8E6D0F0", VA = "0x188E6E6F0")]
	public void AIICKBIOPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8E6FA60", Offset = "0x8E6E460", VA = "0x188E6FA60")]
	private void LCLLLBDKMKN(List<MBBENIOKGGB> IBPOPKFJEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E290", Offset = "0x8E6CC90", VA = "0x188E6E290")]
	private static Material GOLCIJINNFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8E6FC20", Offset = "0x8E6E620", VA = "0x188E6FC20")]
	private void LCLLLBDKMKN(MBBENIOKGGB EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E620", Offset = "0x8E6D020", VA = "0x188E6E620")]
	private void ADOIALEFHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8E6EB80", Offset = "0x8E6D580", VA = "0x188E6EB80")]
	public void BPAMECOKNAD(bool EJCBDIMAFKJ, bool NFGEHPGPHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E960", Offset = "0x8E6D360", VA = "0x188E6E960")]
	protected void AMELBBGCAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8E6F480", Offset = "0x8E6DE80", VA = "0x188E6F480")]
	public void FHPBEOCAHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8E6F210", Offset = "0x8E6DC10", VA = "0x188E6F210")]
	[IteratorStateMachine(typeof(PNHHAKOHMDK))]
	public IEnumerable<Renderer> DMCMPJBOHFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8E6FEC0", Offset = "0x8E6E8C0", VA = "0x188E6FEC0")]
	[IteratorStateMachine(typeof(GKPEELJMIKP))]
	public IEnumerable<Renderer> OPBIJFGGCJK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class MENKKCJNMDB : MBBENIOKGGB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct EBGMNLBGDCA : NBCKEEJANFB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NPBFOENPDFA HFCMFMCGELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle HADFHMENAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private FFPNEEOJIAB FELFNDLDBFC;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8E67C30", Offset = "0x8E66630", VA = "0x188E67C30")]
		public EBGMNLBGDCA(NPBFOENPDFA HFCMFMCGELA, JobHandle HADFHMENAPG, FFPNEEOJIAB FELFNDLDBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8E67BB0", Offset = "0x8E665B0", VA = "0x188E67BB0", Slot = "4")]
		public NPBFOENPDFA BEPFEFDFKFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8E67BE0", Offset = "0x8E665E0", VA = "0x188E67BE0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly MOIJMHAFLGA FFPPPNOKDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float BPJEENNDGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 DGMBGNMINED;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 ADKAHEELHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8E72DF0", Offset = "0x8E717F0", VA = "0x188E72DF0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8E73C70", Offset = "0x8E72670", VA = "0x188E73C70")]
	public MENKKCJNMDB(JJILBLDKFFK PJFDNMGHMBL, MOIJMHAFLGA GPCDCFCPGFK, bool EGLLAMHJFAB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "18")]
	public override bool CGIDAIGCCHE(JFHFHCDHJDD PJFDNMGHMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8E72C10", Offset = "0x8E71610", VA = "0x188E72C10", Slot = "19")]
	public override int GMFJDEHBKAM(EIHDKHJAFNC JLNNLJBBHIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8E72F20", Offset = "0x8E71920", VA = "0x188E72F20", Slot = "20")]
	public override int KIIPKGIHLGM(EIHDKHJAFNC JLNNLJBBHIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8E721E0", Offset = "0x8E70BE0", VA = "0x188E721E0", Slot = "21")]
	public override HAJHFGJIFIH DHOAJIKCFHC()
	{
		return default(HAJHFGJIFIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC33040", Offset = "0xC31A40", VA = "0x180C33040", Slot = "22")]
	public override float AELJODHFHDM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8E727A0", Offset = "0x8E711A0", VA = "0x188E727A0", Slot = "23")]
	public override void GCMONHLHILI(EIHDKHJAFNC JLNNLJBBHIC, PHBEGBLLIGG IEJPPIMPMNP, int DAPCCMEPEKO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8E73A80", Offset = "0x8E72480", VA = "0x188E73A80")]
	private int NKHANBNHJPL(EIHDKHJAFNC JLNNLJBBHIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8E726D0", Offset = "0x8E710D0", VA = "0x188E726D0", Slot = "24")]
	public override JFHFHCDHJDD EMALHCDNNKN()
	{
		return default(JFHFHCDHJDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8E738C0", Offset = "0x8E722C0", VA = "0x188E738C0", Slot = "26")]
	public override MNLEJMLLDFH NCDOABGEFFM()
	{
		return default(MNLEJMLLDFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8E73100", Offset = "0x8E71B00", VA = "0x188E73100", Slot = "27")]
	public override NBCKEEJANFB MECFAILKLBC(EIHDKHJAFNC JLNNLJBBHIC, JobHandle HADFHMENAPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface AEKOKCOEIFP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JJILBLDKFFK EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MBBENIOKGGB EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PGEPFCNCBPC EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class FMHAMAEEMAD : LMLNMMEOLDH, IDisposable, AEKOKCOEIFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NJFMNAGJDEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FMHAMAEEMAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8E73D20", Offset = "0x8E72720", VA = "0x188E73D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8E742A0", Offset = "0x8E72CA0", VA = "0x188E742A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HFFCNCDJFNA<ELNDNCAALDE, JJILBLDKFFK> EHMJPBHEOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HFFCNCDJFNA<HGCANMCBGMK, MBBENIOKGGB> IBPOPKFJEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HFFCNCDJFNA<NKNKHJPNKGK, PGEPFCNCBPC> NBJAAPFCHDE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public JJILBLDKFFK EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A5C0", Offset = "0x8E68FC0", VA = "0x188E6A5C0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MBBENIOKGGB EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A620", Offset = "0x8E69020", VA = "0x188E6A620", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public PGEPFCNCBPC EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A680", Offset = "0x8E69080", VA = "0x188E6A680", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool GIMGGOOEJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC33050", Offset = "0xC31A50", VA = "0x180C33050", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xBDAFA0", Offset = "0xBD99A0", VA = "0x180BDAFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8E6B1F0", Offset = "0x8E69BF0", VA = "0x188E6B1F0")]
	public FMHAMAEEMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8E695F0", Offset = "0x8E67FF0", VA = "0x188E695F0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8E6AE80", Offset = "0x8E69880", VA = "0x188E6AE80", Slot = "4")]
	public ELNDNCAALDE MGAOAKPBLLC(ABLIKGNMCAG GPCDCFCPGFK)
	{
		return default(ELNDNCAALDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8E6AC00", Offset = "0x8E69600", VA = "0x188E6AC00", Slot = "5")]
	public ELNDNCAALDE MGAOAKPBLLC(ABLIKGNMCAG GPCDCFCPGFK, bool EGLLAMHJFAB)
	{
		return default(ELNDNCAALDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8E6A6E0", Offset = "0x8E690E0", VA = "0x188E6A6E0", Slot = "6")]
	public void KODFPGOLINM(ELNDNCAALDE PJFDNMGHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8E6AE90", Offset = "0x8E69890", VA = "0x188E6AE90", Slot = "7")]
	public void MJBLAANBAIP(ELNDNCAALDE PJFDNMGHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8E69110", Offset = "0x8E67B10", VA = "0x188E69110", Slot = "8")]
	public HGCANMCBGMK CGOCNGJCFMP(ELNDNCAALDE PJFDNMGHMBL, KJNPACCILEH GPCDCFCPGFK)
	{
		return default(HGCANMCBGMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8E69D20", Offset = "0x8E68720", VA = "0x188E69D20", Slot = "9")]
	public HGCANMCBGMK IBNHJENLHFC(ELNDNCAALDE PJFDNMGHMBL, MOIJMHAFLGA GPCDCFCPGFK)
	{
		return default(HGCANMCBGMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8E6A200", Offset = "0x8E68C00", VA = "0x188E6A200", Slot = "11")]
	public void JLAONONEBFD(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8E6A9A0", Offset = "0x8E693A0", VA = "0x188E6A9A0", Slot = "10")]
	public void MEPHFHFGBLO(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8E690A0", Offset = "0x8E67AA0", VA = "0x188E690A0", Slot = "20")]
	public IEnumerable<Renderer> CDKGEAMHJFM(ELNDNCAALDE PJFDNMGHMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8E69AE0", Offset = "0x8E684E0", VA = "0x188E69AE0", Slot = "12")]
	public NKNKHJPNKGK HJPPNFEPIAF(BJJLDEADPIL GPCDCFCPGFK)
	{
		return default(NKNKHJPNKGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8E69A70", Offset = "0x8E68470", VA = "0x188E69A70", Slot = "14")]
	public void FADCEDHHMBC(NKNKHJPNKGK DCGKNMIIMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8E69B60", Offset = "0x8E68560", VA = "0x188E69B60", Slot = "16")]
	public Task IAMCJCPHNIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8E697C0", Offset = "0x8E681C0", VA = "0x188E697C0", Slot = "17")]
	public Task EFICBJGBNAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8E68FD0", Offset = "0x8E679D0", VA = "0x188E68FD0", Slot = "18")]
	[AsyncStateMachine(typeof(NJFMNAGJDEM))]
	public Task ALGDPIJCIBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8E69980", Offset = "0x8E68380", VA = "0x188E69980", Slot = "19")]
	public void EJNJNHIINBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8E6A940", Offset = "0x8E69340", VA = "0x188E6A940", Slot = "13")]
	public void LEBHJEJBILC(NKNKHJPNKGK DCGKNMIIMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class IEFEPIGDOOH : MBBENIOKGGB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct KCFHMFMIDOB : NBCKEEJANFB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private NPBFOENPDFA HFCMFMCGELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> KDGMFGDJOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle HADFHMENAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private NNNNGEMDLNF FELFNDLDBFC;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8E70130", Offset = "0x8E6EB30", VA = "0x188E70130")]
		public KCFHMFMIDOB(NPBFOENPDFA HFCMFMCGELA, NativeArray<int> KDGMFGDJOMC, JobHandle HADFHMENAPG, NNNNGEMDLNF FELFNDLDBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8E70030", Offset = "0x8E6EA30", VA = "0x188E70030", Slot = "4")]
		public NPBFOENPDFA BEPFEFDFKFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8E70090", Offset = "0x8E6EA90", VA = "0x188E70090", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly KJNPACCILEH AKBOOJDMDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] OAJOHMONEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 DGMBGNMINED;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 IBIDMKDEGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DC40", Offset = "0x8E6C640", VA = "0x188E6DC40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 ADKAHEELHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8E6D0D0", Offset = "0x8E6BAD0", VA = "0x188E6D0D0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E0F0", Offset = "0x8E6CAF0", VA = "0x188E6E0F0")]
	public IEFEPIGDOOH(JJILBLDKFFK PJFDNMGHMBL, KJNPACCILEH GPCDCFCPGFK, bool IGIFOMJENCD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8E6BDD0", Offset = "0x8E6A7D0", VA = "0x188E6BDD0", Slot = "18")]
	public override bool CGIDAIGCCHE(JFHFHCDHJDD PJFDNMGHMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8E6BEA0", Offset = "0x8E6A8A0", VA = "0x188E6BEA0", Slot = "21")]
	public override HAJHFGJIFIH DHOAJIKCFHC()
	{
		return default(HAJHFGJIFIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8E6BEE0", Offset = "0x8E6A8E0", VA = "0x188E6BEE0")]
	private HAJHFGJIFIH DHOAJIKCFHC(JFHFHCDHJDD PJFDNMGHMBL)
	{
		return default(HAJHFGJIFIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8E6CED0", Offset = "0x8E6B8D0", VA = "0x188E6CED0")]
	private BKBDBPLDCHI JNDIHEBOBCF([In] UniformTRS OEPAHHKILEM, [In] float3 MJPFPFEKNPP)
	{
		return default(BKBDBPLDCHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8E6CE20", Offset = "0x8E6B820", VA = "0x188E6CE20", Slot = "19")]
	public override int GMFJDEHBKAM(EIHDKHJAFNC JLNNLJBBHIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8E6D200", Offset = "0x8E6BC00", VA = "0x188E6D200", Slot = "20")]
	public override int KIIPKGIHLGM(EIHDKHJAFNC JLNNLJBBHIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8E6BCE0", Offset = "0x8E6A6E0", VA = "0x188E6BCE0", Slot = "22")]
	public override float AELJODHFHDM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8E6DE70", Offset = "0x8E6C870", VA = "0x188E6DE70")]
	private int PBFIHAIGMFL(EIHDKHJAFNC JLNNLJBBHIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8E6C5C0", Offset = "0x8E6AFC0", VA = "0x188E6C5C0", Slot = "23")]
	public override void GCMONHLHILI(EIHDKHJAFNC JLNNLJBBHIC, PHBEGBLLIGG IEJPPIMPMNP, int DAPCCMEPEKO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8E6C4F0", Offset = "0x8E6AEF0", VA = "0x188E6C4F0", Slot = "24")]
	public override JFHFHCDHJDD EMALHCDNNKN()
	{
		return default(JFHFHCDHJDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8E6DA80", Offset = "0x8E6C480", VA = "0x188E6DA80", Slot = "26")]
	public override MNLEJMLLDFH NCDOABGEFFM()
	{
		return default(MNLEJMLLDFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8E6D2B0", Offset = "0x8E6BCB0", VA = "0x188E6D2B0", Slot = "27")]
	public override NBCKEEJANFB MECFAILKLBC(EIHDKHJAFNC JLNNLJBBHIC, JobHandle HADFHMENAPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CMDKAPDKEHN
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOAGHAJACEN(DDEBPFHMGEL AEOGKDPPBBE, Renderer BDBIAPPPJPF, int JDBAIKHDBCH);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCPMPIMPKNA(Renderer BDBIAPPPJPF, FHMHDKGBBFJ DPNGPEJBLGB, Vector3 OBBGOKANJLG, Vector3 GEMNIMFHBBK, Vector3 BNGLDIIGCFH, float OHCAFKODECK, float BHKOMGFEGJM, float PIDHPENADNN = -1f, [Optional] Color? EDNHAEBPHJD, [Optional] IReadOnlyList<Camera> AMFMFCJKPJO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LDGMGFJBFFD(Renderer BDBIAPPPJPF, int JDBAIKHDBCH);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HNAEBGIKBCL();

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKDIOLCMAFF(int BOEGGCBHLAF, BCPAHBIDOOE AEOGKDPPBBE, Renderer BDBIAPPPJPF, int JDBAIKHDBCH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AOKPLEJEBJN : JJOBGHILALB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class DJHPCGAMMHK : NHCDBALPMGJ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8E67B60", Offset = "0x8E66560", VA = "0x188E67B60")]
		public DJHPCGAMMHK(string FLBFBHGDBLM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly CMDKAPDKEHN LHJGPFDLPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly AEKOKCOEIFP OBGABCMEEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer MDDPDCHLIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private DJHPCGAMMHK IKPGGGJCCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool JLDEDHAPEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer HHAFBAOJLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private DJHPCGAMMHK EAJJPLGNBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool KLAGCLCIAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer CDCGIAGPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private DJHPCGAMMHK MBBMOFACFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool INHAAGKFFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool JAFNIEKLOJN;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
	public AOKPLEJEBJN(CMDKAPDKEHN GACDMLEAKAP, AEKOKCOEIFP OBGABCMEEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8E64CA0", Offset = "0x8E636A0", VA = "0x188E64CA0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8E656C0", Offset = "0x8E640C0", VA = "0x188E656C0")]
	private void KAAMFPKEKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8E65190", Offset = "0x8E63B90", VA = "0x188E65190", Slot = "4")]
	public void JNNOJFMDGFM(ELNDNCAALDE PJFDNMGHMBL, BCPAHBIDOOE MDAJNMHNCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8E654A0", Offset = "0x8E63EA0", VA = "0x188E654A0", Slot = "5")]
	public void JNNOJFMDGFM(HGCANMCBGMK EBOPBDPOAOK, BCPAHBIDOOE MDAJNMHNCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8E64E50", Offset = "0x8E63850", VA = "0x188E64E50", Slot = "6")]
	public void FPLJCMJFHAK(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8E662F0", Offset = "0x8E64CF0", VA = "0x188E662F0", Slot = "7")]
	public void MCPOOFLHIBH(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8E65080", Offset = "0x8E63A80", VA = "0x188E65080", Slot = "24")]
	public void IKIIKDGPDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x13F9650", Offset = "0x13F8050", VA = "0x1813F9650", Slot = "8")]
	public void CICEGLEPHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8E66A60", Offset = "0x8E65460", VA = "0x188E66A60", Slot = "9")]
	public void OBLLBLLKNGK(BCPAHBIDOOE MDAJNMHNCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8E65BA0", Offset = "0x8E645A0", VA = "0x188E65BA0", Slot = "10")]
	public void KJHPEEODILL(ELNDNCAALDE PJFDNMGHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8E65E70", Offset = "0x8E64870", VA = "0x188E65E70", Slot = "11")]
	public void KJHPEEODILL(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8E650C0", Offset = "0x8E63AC0", VA = "0x188E650C0", Slot = "12")]
	public void JIBNIECBDEL(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8E66BD0", Offset = "0x8E655D0", VA = "0x188E66BD0", Slot = "13")]
	public void OIFLMNFPPNO(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8E65930", Offset = "0x8E64330", VA = "0x188E65930")]
	private void KCLPKFPLOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x15910A0", Offset = "0x158FAA0", VA = "0x1815910A0", Slot = "14")]
	public void KLEOCGFOGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8E661D0", Offset = "0x8E64BD0", VA = "0x188E661D0", Slot = "15")]
	public void MBDLPDJMNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8E66510", Offset = "0x8E64F10", VA = "0x188E66510", Slot = "16")]
	public void NLCABEMFHBP(ELNDNCAALDE PJFDNMGHMBL, DDEBPFHMGEL AEOGKDPPBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8E64FB0", Offset = "0x8E639B0", VA = "0x188E64FB0", Slot = "17")]
	public void GDKDGMECEAP(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8E66440", Offset = "0x8E64E40", VA = "0x188E66440", Slot = "18")]
	public void NHPDEDMDPHH(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xDDFD50", Offset = "0xDDE750", VA = "0x180DDFD50", Slot = "19")]
	public void ECNHMMOLPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8E64300", Offset = "0x8E62D00", VA = "0x188E64300", Slot = "20")]
	public void CILFBEFFNDH(DDEBPFHMGEL AEOGKDPPBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8E667F0", Offset = "0x8E651F0", VA = "0x188E667F0")]
	private void NMELOLOCFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8E64430", Offset = "0x8E62E30", VA = "0x188E64430", Slot = "21")]
	public void COOFCCGHEMP(ELNDNCAALDE PJFDNMGHMBL, Vector3 OBBGOKANJLG, Vector3 GEMNIMFHBBK, Vector3 BNGLDIIGCFH, float OHCAFKODECK, float BHKOMGFEGJM, IReadOnlyList<Camera> PGLAELDJFDK, FHMHDKGBBFJ DPNGPEJBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8E64800", Offset = "0x8E63200", VA = "0x188E64800", Slot = "22")]
	public void COOFCCGHEMP(NKNKHJPNKGK DCGKNMIIMOP, Vector3 OBBGOKANJLG, Vector3 GEMNIMFHBBK, Vector3 BNGLDIIGCFH, float OHCAFKODECK, float BHKOMGFEGJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class MBBENIOKGGB : HGJMBBNIBNL, LDKLHGLOLBH, COGBNOAGCDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly JJILBLDKFFK BDILIHENIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int BBBKFNOFOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds IBPNOJAJIDD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds CMGNLEPOLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8E71FE0", Offset = "0x8E709E0", VA = "0x188E71FE0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool LKOCNHOLBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xEBDB60", Offset = "0xEBC560", VA = "0x180EBDB60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xEF2790", Offset = "0xEF1190", VA = "0x180EF2790")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 ADKAHEELHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OKBELGNDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xC325B0", Offset = "0xC30FB0", VA = "0x180C325B0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public NBLJOKDCJAA CKGABIKJCON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool KLFLANLHPAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x103E1D0", Offset = "0x103CBD0", VA = "0x18103E1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	protected MBBENIOKGGB(JJILBLDKFFK PJFDNMGHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8E72010", Offset = "0x8E70A10", VA = "0x188E72010", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "18")]
	public virtual bool CGIDAIGCCHE(JFHFHCDHJDD PJFDNMGHMBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8E72000", Offset = "0x8E70A00", VA = "0x188E72000", Slot = "10")]
	public int DCKHPGIEMKN(int ICJNCLFKFIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int GMFJDEHBKAM(EIHDKHJAFNC JLNNLJBBHIC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int KIIPKGIHLGM(EIHDKHJAFNC JLNNLJBBHIC);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract HAJHFGJIFIH DHOAJIKCFHC();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float AELJODHFHDM();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void GCMONHLHILI(EIHDKHJAFNC JLNNLJBBHIC, PHBEGBLLIGG IEJPPIMPMNP, int DAPCCMEPEKO = -1);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract JFHFHCDHJDD EMALHCDNNKN();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8E72180", Offset = "0x8E70B80", VA = "0x188E72180", Slot = "13")]
	public Hash128 JDIHCNBBCGI(int JLNNLJBBHIC)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract MNLEJMLLDFH NCDOABGEFFM();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract NBCKEEJANFB MECFAILKLBC(EIHDKHJAFNC JLNNLJBBHIC, JobHandle HADFHMENAPG);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8E721B0", Offset = "0x8E70BB0", VA = "0x188E721B0", Slot = "12")]
	public NBCKEEJANFB NPHCPGFICMA(int JLNNLJBBHIC)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8E76F30", Offset = "0x8E75930", VA = "0x188E76F30")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LOEMIGJLAAM
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DCHCICECMKH : IEnumerable<PPPFGKCNENM>, IEnumerable, IEnumerator<PPPFGKCNENM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private PPPFGKCNENM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private PPPFGKCNENM System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public DCHCICECMKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8E679A0", Offset = "0x8E663A0", VA = "0x188E679A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8E67B10", Offset = "0x8E66510", VA = "0x188E67B10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E67A70", Offset = "0x8E66470", VA = "0x188E67A70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PPPFGKCNENM> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E67A70", Offset = "0x8E66470", VA = "0x188E67A70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static PPPFGKCNENM[][] ICNNHMKPMLB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static PCILIPBHGCE KMOEMDEEELG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig DHOHCDLADBK;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader AJIIBHKPFKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8E71720", Offset = "0x8E70120", VA = "0x188E71720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer AIENHMMLKBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8E71780", Offset = "0x8E70180", VA = "0x188E71780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8E717F0", Offset = "0x8E701F0", VA = "0x188E717F0")]
	[MNIIDFGFPJH]
	internal static void ICNIAFDKEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8E718E0", Offset = "0x8E702E0", VA = "0x188E718E0")]
	public static Mesh IJHACMLLJLI(DCKPNKNDMML FBEOKEICMMK, int JLNNLJBBHIC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8E71BC0", Offset = "0x8E705C0", VA = "0x188E71BC0")]
	public static int MOMAOAGEPMO(DCKPNKNDMML FBEOKEICMMK, int JLNNLJBBHIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8E71BF0", Offset = "0x8E705F0", VA = "0x188E71BF0")]
	public static PCILIPBHGCE PMCEPAPLGLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8E71980", Offset = "0x8E70380", VA = "0x188E71980")]
	[IteratorStateMachine(typeof(DCHCICECMKH))]
	private static IEnumerable<PPPFGKCNENM> ILIINKCHENB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8E70910", Offset = "0x8E6F310", VA = "0x188E70910")]
	public static PPPFGKCNENM CNCFADJFLKM(DCKPNKNDMML FBEOKEICMMK, int JLNNLJBBHIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8E71BD0", Offset = "0x8E705D0", VA = "0x188E71BD0")]
	public static bool OEJIHCGIPMF(this DCKPNKNDMML FBEOKEICMMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8E70760", Offset = "0x8E6F160", VA = "0x188E70760")]
	public static void CBEIECANFLE(DCKPNKNDMML FBEOKEICMMK, float3 ENKALCFOMHE, [Out] NOJJBFFOEDG FNNGDFEMNHO, [Out] float3 HLCNMFEOBHF, [Out] float JGCGFBMGDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8E70390", Offset = "0x8E6ED90", VA = "0x188E70390")]
	public static void ACNPFONHDJP(Vector3 ENKALCFOMHE, DCKPNKNDMML FBEOKEICMMK, [Out] Vector3 HLCNMFEOBHF, [Out] float JGCGFBMGDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8E717E0", Offset = "0x8E701E0", VA = "0x188E717E0")]
	[OJPHJMGCGJB(0)]
	[GGDENAMAEIG(DEFFNBOPPKN.ExitingPlayMode, 0)]
	private static void HNOIEKEJKGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8E719E0", Offset = "0x8E703E0", VA = "0x188E719E0")]
	[OJPHJMGCGJB(0)]
	[GGDENAMAEIG(DEFFNBOPPKN.ExitingPlayMode, 0)]
	private static void LBIOMAKBPDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class PCKJLKICLEL : LMLNMMEOLDH, IDisposable, AEKOKCOEIFP
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly HFFCNCDJFNA<ELNDNCAALDE, JJILBLDKFFK> EHMJPBHEOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HFFCNCDJFNA<HGCANMCBGMK, MBBENIOKGGB> IBPOPKFJEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HFFCNCDJFNA<NKNKHJPNKGK, PGEPFCNCBPC> NBJAAPFCHDE;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public JJILBLDKFFK EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8E749E0", Offset = "0x8E733E0", VA = "0x188E749E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MBBENIOKGGB EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E74AA0", Offset = "0x8E734A0", VA = "0x188E74AA0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public PGEPFCNCBPC EFLOLIACEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8E74A40", Offset = "0x8E73440", VA = "0x188E74A40", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GIMGGOOEJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC33050", Offset = "0xC31A50", VA = "0x180C33050", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xBDAFA0", Offset = "0xBD99A0", VA = "0x180BDAFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8E74DD0", Offset = "0x8E737D0", VA = "0x188E74DD0")]
	public PCKJLKICLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8E74550", Offset = "0x8E72F50", VA = "0x188E74550", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8E74C20", Offset = "0x8E73620", VA = "0x188E74C20", Slot = "4")]
	public ELNDNCAALDE MGAOAKPBLLC(ABLIKGNMCAG GPCDCFCPGFK)
	{
		return default(ELNDNCAALDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8E74C20", Offset = "0x8E73620", VA = "0x188E74C20", Slot = "5")]
	public ELNDNCAALDE MGAOAKPBLLC(ABLIKGNMCAG GPCDCFCPGFK, bool EGLLAMHJFAB)
	{
		return default(ELNDNCAALDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8E74B00", Offset = "0x8E73500", VA = "0x188E74B00", Slot = "6")]
	public void KODFPGOLINM(ELNDNCAALDE PJFDNMGHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8E74CC0", Offset = "0x8E736C0", VA = "0x188E74CC0", Slot = "7")]
	public void MJBLAANBAIP(ELNDNCAALDE PJFDNMGHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8E74410", Offset = "0x8E72E10", VA = "0x188E74410", Slot = "8")]
	public HGCANMCBGMK CGOCNGJCFMP(ELNDNCAALDE PJFDNMGHMBL, KJNPACCILEH GPCDCFCPGFK)
	{
		return default(HGCANMCBGMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8E74810", Offset = "0x8E73210", VA = "0x188E74810", Slot = "9")]
	public HGCANMCBGMK IBNHJENLHFC(ELNDNCAALDE PJFDNMGHMBL, MOIJMHAFLGA GPCDCFCPGFK)
	{
		return default(HGCANMCBGMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8E74950", Offset = "0x8E73350", VA = "0x188E74950", Slot = "11")]
	public void JLAONONEBFD(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8E74BC0", Offset = "0x8E735C0", VA = "0x188E74BC0", Slot = "10")]
	public void MEPHFHFGBLO(HGCANMCBGMK EBOPBDPOAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8E743A0", Offset = "0x8E72DA0", VA = "0x188E743A0", Slot = "20")]
	public IEnumerable<Renderer> CDKGEAMHJFM(ELNDNCAALDE PJFDNMGHMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8E746F0", Offset = "0x8E730F0", VA = "0x188E746F0", Slot = "12")]
	public NKNKHJPNKGK HJPPNFEPIAF(BJJLDEADPIL GPCDCFCPGFK)
	{
		return default(NKNKHJPNKGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8E74680", Offset = "0x8E73080", VA = "0x188E74680", Slot = "14")]
	public void FADCEDHHMBC(NKNKHJPNKGK DCGKNMIIMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8E74770", Offset = "0x8E73170", VA = "0x188E74770", Slot = "16")]
	public Task IAMCJCPHNIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8E745E0", Offset = "0x8E72FE0", VA = "0x188E745E0", Slot = "17")]
	public Task EFICBJGBNAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8E74300", Offset = "0x8E72D00", VA = "0x188E74300", Slot = "18")]
	public Task ALGDPIJCIBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2934DF0", Offset = "0x29337F0", VA = "0x182934DF0", Slot = "19")]
	public void EJNJNHIINBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8E74B60", Offset = "0x8E73560", VA = "0x188E74B60", Slot = "13")]
	public void LEBHJEJBILC(NKNKHJPNKGK DCGKNMIIMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NFLOBNJJDLI
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool JLHEBAPKPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material MLPJBHPDCCD();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material GOLCIJINNFB();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material IOHJPBHFDDK();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HNEBGIPAHNC(KJCFHBDBFJC CFDNNOLAADO);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IJEJHMEJMIL(GFPBOOEDAHD MMDPIFHBFBP);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JIGDALCJLFE(GameObject CEFJEHJNIAP);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GGDLNIDJLDB(GameObject CEFJEHJNIAP, bool DDHLAGIDGKI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JIOOIJBGOLM
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static NFLOBNJJDLI JDFAIEBLNPJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool JLHEBAPKPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E5C0", Offset = "0x8E6CFC0", VA = "0x188E6E5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E500", Offset = "0x8E6CF00", VA = "0x188E6E500")]
	public static void KPJBHNKNLNN(NFLOBNJJDLI HEKMLGOLPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E560", Offset = "0x8E6CF60", VA = "0x188E6E560")]
	public static Material MLPJBHPDCCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E290", Offset = "0x8E6CC90", VA = "0x188E6E290")]
	public static Material GOLCIJINNFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E3D0", Offset = "0x8E6CDD0", VA = "0x188E6E3D0")]
	public static Material IOHJPBHFDDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E2F0", Offset = "0x8E6CCF0", VA = "0x188E6E2F0")]
	public static int HNEBGIPAHNC(KJCFHBDBFJC CFDNNOLAADO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E360", Offset = "0x8E6CD60", VA = "0x188E6E360")]
	public static int IJEJHMEJMIL(GFPBOOEDAHD MMDPIFHBFBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E430", Offset = "0x8E6CE30", VA = "0x188E6E430")]
	public static void JIGDALCJLFE(GameObject CEFJEHJNIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8E6E1A0", Offset = "0x8E6CBA0", VA = "0x188E6E1A0")]
	public static void GGDLNIDJLDB(GameObject CEFJEHJNIAP, bool DDHLAGIDGKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PGEPFCNCBPC : MPODEJOJOCE
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BHGOGOHFHFC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PGEPFCNCBPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public BHGOGOHFHFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8E67010", Offset = "0x8E65A10", VA = "0x188E67010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8E66CF0", Offset = "0x8E656F0", VA = "0x188E66CF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8E66CA0", Offset = "0x8E656A0", VA = "0x188E66CA0")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8E66FC0", Offset = "0x8E659C0", VA = "0x188E66FC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8E66F10", Offset = "0x8E65910", VA = "0x188E66F10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8E66F10", Offset = "0x8E65910", VA = "0x188E66F10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BJJLDEADPIL ODIDCDBCHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly AEKOKCOEIFP OBGABCMEEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private CIFOAINPAOO DPOPNGIKNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<FIFHOLAILHO> LJHIEIECABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<FIFHOLAILHO> ADIHCKAODGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject EBDHPAONMIB;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8E75410", Offset = "0x8E73E10", VA = "0x188E75410")]
	public static PGEPFCNCBPC CBCHBKMMBEF(BJJLDEADPIL GPCDCFCPGFK, AEKOKCOEIFP OBGABCMEEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8E76560", Offset = "0x8E74F60", VA = "0x188E76560")]
	private PGEPFCNCBPC(BJJLDEADPIL GPCDCFCPGFK, AEKOKCOEIFP OBGABCMEEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8E760A0", Offset = "0x8E74AA0", VA = "0x188E760A0")]
	public void MEOELJAGFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8E75560", Offset = "0x8E73F60", VA = "0x188E75560")]
	[IteratorStateMachine(typeof(BHGOGOHFHFC))]
	public IEnumerable<Renderer> DMCMPJBOHFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8E755E0", Offset = "0x8E73FE0", VA = "0x188E755E0", Slot = "4")]
	public void HJNCIDGCKKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8E76530", Offset = "0x8E74F30", VA = "0x188E76530")]
	private void PBJGLJBKBHK(Vector3 ACDENENFBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8E751C0", Offset = "0x8E73BC0", VA = "0x188E751C0")]
	public void AIICKBIOPNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FIFHOLAILHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct FIDPIGMHHJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public PHBEGBLLIGG BJCNMHFMPDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JFHFHCDHJDD OBMKFKEIAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int FDNDJABNENL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LFAKAGLMKNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public FIFHOLAILHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public EIHDKHJAFNC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<FIDPIGMHHJA> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NPBFOENPDFA combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LFAKAGLMKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8E701C0", Offset = "0x8E6EBC0", VA = "0x188E701C0")]
		internal JobHandle OKDDNCMJJLP()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8E70190", Offset = "0x8E6EB90", VA = "0x188E70190")]
		internal void CNDDJOKCEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8E70220", Offset = "0x8E6EC20", VA = "0x188E70220")]
		internal void POMKBKDKEAF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] FKPMACLKDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private DBHJBANDBMG FCBJPLEKFPK;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 DLMJAOKBOFG;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh OHLAJAADLAK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MCBFPBEPDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8CFD0", VA = "0x180A8E5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8E67D30", Offset = "0x8E66730", VA = "0x188E67D30")]
	public void IJLBENMELEI(List<JFHFHCDHJDD> PJOMBHJAFED, Matrix4x4[] JFMAPIPEGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8E68370", Offset = "0x8E66D70", VA = "0x188E68370")]
	public static List<FIFHOLAILHO> OIDBKGGJJLH(List<JJILBLDKFFK> MDPNHDEKAMM, EIHDKHJAFNC JLNNLJBBHIC, Bounds CFBABAKNBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8E67F20", Offset = "0x8E66920", VA = "0x188E67F20")]
	private JobHandle KJLCFCJJMCH(NPBFOENPDFA CMPLIOMLBJK, int LKJMNDHCNEM, int FAGHJGOAPIK, EIHDKHJAFNC JLNNLJBBHIC, List<FIDPIGMHHJA> FENPLMDGKPF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8E68290", Offset = "0x8E66C90", VA = "0x188E68290")]
	private void LCKHDCMAGDF(List<FIDPIGMHHJA> FENPLMDGKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8E68BA0", Offset = "0x8E675A0", VA = "0x188E68BA0")]
	private FIFHOLAILHO(List<FIDPIGMHHJA> FENPLMDGKPF, int LKJMNDHCNEM, int FAGHJGOAPIK, EIHDKHJAFNC JLNNLJBBHIC, Bounds CFBABAKNBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8E67C90", Offset = "0x8E66690", VA = "0x188E67C90", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private MaterialPropertyBlock KBLHKCKFEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private FIFHOLAILHO HFCMFMCGELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<JFHFHCDHJDD> GBBPMBIJIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture DEKNIMHBCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer GEMKDPLGHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader HKPJIOBPDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] CFDCPLLJMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int DAMHJDCBJEN;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer LGBPBBCHGFP
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int DNJLIMDEEIB
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8E77C60", Offset = "0x8E76660", VA = "0x188E77C60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8E76F90", Offset = "0x8E75990", VA = "0x188E76F90")]
		public static List<SkinnedShapeRenderer> Create(GameObject PJFDNMGHMBL, List<FIFHOLAILHO> MGNEELNALPL, List<JFHFHCDHJDD> GBBPMBIJIHO, Material POCHLMCAOAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8E77650", Offset = "0x8E76050", VA = "0x188E77650")]
		public void Init(FIFHOLAILHO HFCMFMCGELA, List<JFHFHCDHJDD> GBBPMBIJIHO, Material POCHLMCAOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8E77BC0", Offset = "0x8E765C0", VA = "0x188E77BC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8E77B20", Offset = "0x8E76520", VA = "0x188E77B20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8E77AE0", Offset = "0x8E764E0", VA = "0x188E77AE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8E77220", Offset = "0x8E75C20", VA = "0x188E77220")]
		private void EADGOJBCFDO(ScriptableRenderContext HCLPHJDKMCA, Camera[] CPMILDCOLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8E772E0", Offset = "0x8E75CE0", VA = "0x188E772E0")]
		private void IJLBENMELEI(CommandBuffer CMGFLLGDENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
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
