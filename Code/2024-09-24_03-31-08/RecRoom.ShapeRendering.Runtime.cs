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
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x750D170", Offset = "0x750BB70", VA = "0x18750D170", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FDHDGODFIDB : JHBBLHAJILM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte FMPOIGPFGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] OMMDAGLCJDD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MHAJFLPIEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BE080", Offset = "0x9BCA80", VA = "0x1809BE080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ABGAOOMDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C4080", Offset = "0x8C2A80", VA = "0x1808C4080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C3670", Offset = "0x8C2070", VA = "0x1808C3670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float NGAABAANDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB0", Offset = "0x9B57B0", VA = "0x1809B6DB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC1E4C0", Offset = "0xC1CEC0", VA = "0x180C1E4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CFKJGANPPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DA0", Offset = "0x9B57A0", VA = "0x1809B6DA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1508490", Offset = "0x1506E90", VA = "0x181508490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> NDBHIMBLLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75041D0", Offset = "0x7502BD0", VA = "0x1875041D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> OINBLOKFJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7503F30", Offset = "0x7502930", VA = "0x187503F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CHMOOKFGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte BGNFDILHNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7503C80", Offset = "0x7502680", VA = "0x187503C80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7504260", Offset = "0x7502C60", VA = "0x187504260")]
	public FDHDGODFIDB(List<PGKDLFIPKCJ> LLABDNBJMKD, List<PGKDLFIPKCJ> MPOBBDMEDDM, List<FGHMMAJOCCM> OBOIFLJENCP, Material PPFNGNPGEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75040B0", Offset = "0x7502AB0", VA = "0x1875040B0")]
	private int LLPGLDJILPJ(List<PGKDLFIPKCJ> IKMOMJBBJBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7503CD0", Offset = "0x75026D0", VA = "0x187503CD0")]
	private void BPKJABFKADE(int EHBCJHNIJAD, bool GJHDHJFGOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7503F60", Offset = "0x7502960", VA = "0x187503F60")]
	public void KFKEKGBCIJG(Vector3 DFMBNKCOHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7503E30", Offset = "0x7502830", VA = "0x187503E30", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7504220", Offset = "0x7502C20", VA = "0x187504220")]
	public void PPDILJCHLBJ(Transform KNENIENMDDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PPALFEOCFIA : GFIJFEOJDDC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class KFFELEINKMD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PPALFEOCFIA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public KFFELEINKMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7509CB0", Offset = "0x75086B0", VA = "0x187509CB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x75096A0", Offset = "0x75080A0", VA = "0x1875096A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7509650", Offset = "0x7508050", VA = "0x187509650")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75095B0", Offset = "0x7507FB0", VA = "0x1875095B0")]
		private void EEFNKGAPPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7509600", Offset = "0x7508000", VA = "0x187509600")]
		private void FKONHGMENGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7509C60", Offset = "0x7508660", VA = "0x187509C60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7509BB0", Offset = "0x75085B0", VA = "0x187509BB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7509BB0", Offset = "0x75085B0", VA = "0x187509BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class HOMKGJOADHM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PPALFEOCFIA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public HOMKGJOADHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7504E80", Offset = "0x7503880", VA = "0x187504E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7504A10", Offset = "0x7503410", VA = "0x187504A10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75049C0", Offset = "0x75033C0", VA = "0x1875049C0")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7504970", Offset = "0x7503370", VA = "0x187504970")]
		private void EEFNKGAPPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7504E30", Offset = "0x7503830", VA = "0x187504E30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7504D80", Offset = "0x7503780", VA = "0x187504D80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7504D80", Offset = "0x7503780", VA = "0x187504D80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MBPFKDDNMLH JEEJGNKFMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<ADFLCGLNPGH> CIDMCPPMNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> CGCEJMBMMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer EENGIPOJMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool EBGLDECCGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool PNHNONJOFJA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<LFILPOBKFEH> LJAFMFIEJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ELAPIMEFJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7512040", Offset = "0x7510A40", VA = "0x187512040", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FGHMMAJOCCM FKLAFGFHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7511B20", Offset = "0x7510520", VA = "0x187511B20", Slot = "8")]
		get
		{
			return default(FGHMMAJOCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> FICLIDBJDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88B260", Offset = "0x889C60", VA = "0x18088B260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75131A0", Offset = "0x7511BA0", VA = "0x1875131A0")]
	private bool NEIFOIPIHDF(ADFLCGLNPGH NLBIOBEAIBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7511B00", Offset = "0x7510500", VA = "0x187511B00")]
	private static bool BKLMLHBOBAD(ADFLCGLNPGH NLBIOBEAIBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7513240", Offset = "0x7511C40", VA = "0x187513240")]
	public PPALFEOCFIA(MBPFKDDNMLH LNCKNHNHHDF, bool PEPFCFILDJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7511C70", Offset = "0x7510670", VA = "0x187511C70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x75122E0", Offset = "0x7510CE0", VA = "0x1875122E0")]
	public void KDCHLCHLBCK(ADFLCGLNPGH NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7512080", Offset = "0x7510A80", VA = "0x187512080")]
	public void GDFNAHCIADO(ADFLCGLNPGH NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7512480", Offset = "0x7510E80", VA = "0x187512480", Slot = "4")]
	public void KNJBAHAGIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7511DF0", Offset = "0x75107F0", VA = "0x187511DF0")]
	public void EOBPLEKHDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7512FE0", Offset = "0x75119E0", VA = "0x187512FE0")]
	private void LDGOHOOCOKA(List<ADFLCGLNPGH> CIDMCPPMNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7503790", Offset = "0x7502190", VA = "0x187503790")]
	private static Material BLHCPAIJJIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7512F30", Offset = "0x7511930", VA = "0x187512F30")]
	private void LDGOHOOCOKA(ADFLCGLNPGH NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7511A30", Offset = "0x7510430", VA = "0x187511A30")]
	private void AHNBHEOOBIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7512980", Offset = "0x7511380", VA = "0x187512980")]
	public void KNJFCCNOBLK(bool JDCPBPEKDBB, bool IBIBJFIBOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7512220", Offset = "0x7510C20", VA = "0x187512220")]
	protected void JKBOGCODPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x75121A0", Offset = "0x7510BA0", VA = "0x1875121A0")]
	public void IBMLLPJFOKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75131C0", Offset = "0x7511BC0", VA = "0x1875131C0")]
	[IteratorStateMachine(typeof(KFFELEINKMD))]
	public IEnumerable<Renderer> NONHJODLFJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7511BF0", Offset = "0x75105F0", VA = "0x187511BF0")]
	[IteratorStateMachine(typeof(HOMKGJOADHM))]
	public IEnumerable<Renderer> DPJLMJPNKPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class IAEOOMFGLHI : ADFLCGLNPGH
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct DIPFFGDHDIO : INLKNLOKEBI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private CCDNCOACIDM LDNHICGPCIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle AJLOAOCOAJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private IBFNBBNHNKM CENFCNEDLCH;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7503C20", Offset = "0x7502620", VA = "0x187503C20")]
		public DIPFFGDHDIO(CCDNCOACIDM LDNHICGPCIN, JobHandle AJLOAOCOAJH, IBFNBBNHNKM CENFCNEDLCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7503BF0", Offset = "0x75025F0", VA = "0x187503BF0", Slot = "4")]
		public CCDNCOACIDM EKAOOMEJNOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7503BA0", Offset = "0x75025A0", VA = "0x187503BA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly PIFHFJIMKBG PDDJBAFAFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float KGOGMCOCEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 PEEKFKBLDIL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 JCCBGGGLFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7505850", Offset = "0x7504250", VA = "0x187505850", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7506BE0", Offset = "0x75055E0", VA = "0x187506BE0")]
	public IAEOOMFGLHI(PPALFEOCFIA BAFHJDFHJHD, PIFHFJIMKBG LNCKNHNHHDF, bool PEPFCFILDJI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "17")]
	public override bool DEDFNMCPJPJ(FGHMMAJOCCM BAFHJDFHJHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7505D00", Offset = "0x7504700", VA = "0x187505D00", Slot = "18")]
	public override int LLPGLDJILPJ(BMENCFGGDHJ PDJBKOAOLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7505B30", Offset = "0x7504530", VA = "0x187505B30", Slot = "19")]
	public override int LIOFLIMODLJ(BMENCFGGDHJ PDJBKOAOLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x75066A0", Offset = "0x75050A0", VA = "0x1875066A0", Slot = "20")]
	public override Bounds LOFPOCMJDLC()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xAD59F0", Offset = "0xAD43F0", VA = "0x180AD59F0", Slot = "21")]
	public override float FBEJCKCDMKJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x75051B0", Offset = "0x7503BB0", VA = "0x1875051B0", Slot = "22")]
	public override void DANDGDJPKDJ(BMENCFGGDHJ PDJBKOAOLLN, ENAKOAFNLIC MPPLAHJJFFO, int JJCECAFOBMP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7505780", Offset = "0x7504180", VA = "0x187505780", Slot = "23")]
	public override FGHMMAJOCCM IHADEMBOOIB()
	{
		return default(FGHMMAJOCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7505980", Offset = "0x7504380", VA = "0x187505980", Slot = "25")]
	public override NMDMIIDOBCA JMBDMLDBOLB()
	{
		return default(NMDMIIDOBCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7505ED0", Offset = "0x75048D0", VA = "0x187505ED0", Slot = "26")]
	public override INLKNLOKEBI LMAKHEOJPJF(BMENCFGGDHJ PDJBKOAOLLN, JobHandle AJLOAOCOAJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface FOKHDAMMMLG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PPALFEOCFIA BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ADFLCGLNPGH BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BAADICDJGPD BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class MPPIJEIBKHE : GAFDHANDCAD, IDisposable, FOKHDAMMMLG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AKFHCPNCIPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public MPPIJEIBKHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7501DA0", Offset = "0x75007A0", VA = "0x187501DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75022A0", Offset = "0x7500CA0", VA = "0x1875022A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HJLLEKJMPAN<POMPLEGKFCO, PPALFEOCFIA> MNDOEKDFJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HJLLEKJMPAN<JHJMOICONME, ADFLCGLNPGH> CIDMCPPMNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HJLLEKJMPAN<CNNHDBNJNBD, BAADICDJGPD> GFBIDLBHBND;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PPALFEOCFIA BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x750F170", Offset = "0x750DB70", VA = "0x18750F170", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ADFLCGLNPGH BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x750F110", Offset = "0x750DB10", VA = "0x18750F110", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BAADICDJGPD BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x750F0B0", Offset = "0x750DAB0", VA = "0x18750F0B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DHEFFKBHKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B00", Offset = "0x9A5500", VA = "0x1809A6B00", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xDA7090", Offset = "0xDA5A90", VA = "0x180DA7090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x750F240", Offset = "0x750DC40", VA = "0x18750F240")]
	public MPPIJEIBKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x750D890", Offset = "0x750C290", VA = "0x18750D890", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x750D470", Offset = "0x750BE70", VA = "0x18750D470", Slot = "4")]
	public POMPLEGKFCO AGGALJMIAJL(MBPFKDDNMLH LNCKNHNHHDF)
	{
		return default(POMPLEGKFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x750D200", Offset = "0x750BC00", VA = "0x18750D200", Slot = "5")]
	public POMPLEGKFCO AGGALJMIAJL(MBPFKDDNMLH LNCKNHNHHDF, bool PEPFCFILDJI)
	{
		return default(POMPLEGKFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x750EC60", Offset = "0x750D660", VA = "0x18750EC60", Slot = "6")]
	public void LOFKDPGNCEF(POMPLEGKFCO BAFHJDFHJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x750D480", Offset = "0x750BE80", VA = "0x18750D480", Slot = "7")]
	public void DDDCCBDGOKN(POMPLEGKFCO BAFHJDFHJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x750DE40", Offset = "0x750C840", VA = "0x18750DE40", Slot = "8")]
	public JHJMOICONME FLMIIBLAEEF(POMPLEGKFCO BAFHJDFHJHD, GDFFHEGJACA LNCKNHNHHDF)
	{
		return default(JHJMOICONME);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x750E7A0", Offset = "0x750D1A0", VA = "0x18750E7A0", Slot = "9")]
	public JHJMOICONME JHKINFPMGDP(POMPLEGKFCO BAFHJDFHJHD, PIFHFJIMKBG LNCKNHNHHDF)
	{
		return default(JHJMOICONME);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x750E300", Offset = "0x750CD00", VA = "0x18750E300", Slot = "11")]
	public void FMPEJEMNINO(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x750DB90", Offset = "0x750C590", VA = "0x18750DB90", Slot = "10")]
	public void FFKGOFOAMGP(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x750E6A0", Offset = "0x750D0A0", VA = "0x18750E6A0", Slot = "20")]
	public IEnumerable<Renderer> HGEPIAMGEAE(POMPLEGKFCO BAFHJDFHJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x750EEB0", Offset = "0x750D8B0", VA = "0x18750EEB0", Slot = "12")]
	public CNNHDBNJNBD MANCHLCINKO(JPGEPNHCBAE LNCKNHNHHDF)
	{
		return default(CNNHDBNJNBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x750F1D0", Offset = "0x750DBD0", VA = "0x18750F1D0", Slot = "14")]
	public void OJKJCCNBPKD(CNNHDBNJNBD OLJDDPHJDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x750DA10", Offset = "0x750C410", VA = "0x18750DA10", Slot = "16")]
	public Task ELOAIGLEPFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x750EF30", Offset = "0x750D930", VA = "0x18750EF30", Slot = "17")]
	public Task NABMKIKMIPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x750D7C0", Offset = "0x750C1C0", VA = "0x18750D7C0", Slot = "18")]
	[AsyncStateMachine(typeof(AKFHCPNCIPJ))]
	public Task DJNMFMAHJDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x750E710", Offset = "0x750D110", VA = "0x18750E710", Slot = "19")]
	public void IIHIIHOBGFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x750DDE0", Offset = "0x750C7E0", VA = "0x18750DDE0", Slot = "13")]
	public void FJCGMAEEIGA(CNNHDBNJNBD OLJDDPHJDKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class LJBIDNCJGOE : ADFLCGLNPGH
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct JKEDPNMMDPJ : INLKNLOKEBI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private CCDNCOACIDM LDNHICGPCIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle AJLOAOCOAJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private PCOCLEGEFAO CENFCNEDLCH;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7506D10", Offset = "0x7505710", VA = "0x187506D10")]
		public JKEDPNMMDPJ(CCDNCOACIDM LDNHICGPCIN, JobHandle AJLOAOCOAJH, PCOCLEGEFAO CENFCNEDLCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7506CE0", Offset = "0x75056E0", VA = "0x187506CE0", Slot = "4")]
		public CCDNCOACIDM EKAOOMEJNOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7506C90", Offset = "0x7505690", VA = "0x187506C90", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly GDFFHEGJACA EIPGALGMOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] MMPJNJFAACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 PEEKFKBLDIL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 BCDOCCNACJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x750AED0", Offset = "0x75098D0", VA = "0x18750AED0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 JCCBGGGLFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x750B1D0", Offset = "0x7509BD0", VA = "0x18750B1D0", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x750C240", Offset = "0x750AC40", VA = "0x18750C240")]
	public LJBIDNCJGOE(PPALFEOCFIA BAFHJDFHJHD, GDFFHEGJACA LNCKNHNHHDF, bool JIFBDEDKFLM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x750A6C0", Offset = "0x75090C0", VA = "0x18750A6C0", Slot = "17")]
	public override bool DEDFNMCPJPJ(FGHMMAJOCCM BAFHJDFHJHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x750C040", Offset = "0x750AA40", VA = "0x18750C040")]
	private JPGICEJAGBI NHIPMCGKDKI([In] UniformTRS KBMKCPHKDCP, [In] float3 AKOIILICDNL)
	{
		return default(JPGICEJAGBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x750B7C0", Offset = "0x750A1C0", VA = "0x18750B7C0", Slot = "18")]
	public override int LLPGLDJILPJ(BMENCFGGDHJ PDJBKOAOLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x750B720", Offset = "0x750A120", VA = "0x18750B720", Slot = "19")]
	public override int LIOFLIMODLJ(BMENCFGGDHJ PDJBKOAOLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x750BFC0", Offset = "0x750A9C0", VA = "0x18750BFC0", Slot = "20")]
	public override Bounds LOFPOCMJDLC()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x750ADE0", Offset = "0x75097E0", VA = "0x18750ADE0", Slot = "21")]
	public override float FBEJCKCDMKJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x750B4B0", Offset = "0x7509EB0", VA = "0x18750B4B0")]
	private int KPFPHDFPFND(BMENCFGGDHJ PDJBKOAOLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7509EA0", Offset = "0x75088A0", VA = "0x187509EA0", Slot = "22")]
	public override void DANDGDJPKDJ(BMENCFGGDHJ PDJBKOAOLLN, ENAKOAFNLIC MPPLAHJJFFO, int JJCECAFOBMP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x750B100", Offset = "0x7509B00", VA = "0x18750B100", Slot = "23")]
	public override FGHMMAJOCCM IHADEMBOOIB()
	{
		return default(FGHMMAJOCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x750B300", Offset = "0x7509D00", VA = "0x18750B300", Slot = "25")]
	public override NMDMIIDOBCA JMBDMLDBOLB()
	{
		return default(NMDMIIDOBCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x750B860", Offset = "0x750A260", VA = "0x18750B860", Slot = "26")]
	public override INLKNLOKEBI LMAKHEOJPJF(BMENCFGGDHJ PDJBKOAOLLN, JobHandle AJLOAOCOAJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AHIHMPPPDJO
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGDAAKLMDOE(AGNEHGOBOAO AOGCIMANLIJ, Renderer DGLLFNJJPBO, int GAGFPIDDCBK);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LANLNACDNLJ(Renderer DGLLFNJJPBO, GFCMMAOCIGI IOGDAIKBAOH, Vector3 NCNNFDJBEEG, Vector3 JMKKCMMDLHN, Vector3 CGAJKJIDDPM, float IGLOBBLFBLJ, float NOOBIJPGEGH, float IEHPMMBLBDD = -1f, [Optional] Color? BJCIGJMGMBG, [Optional] IReadOnlyList<Camera> LMKJCOEIGAJ);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHLFFPHFAPP(Renderer DGLLFNJJPBO, int GAGFPIDDCBK);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NGAMABNJIDA();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HMMJEPAPAHD(int IKILNBCOJJN, OHFCNPENGBB AOGCIMANLIJ, Renderer DGLLFNJJPBO, int GAGFPIDDCBK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JLJCMOEIAAB : KOEBEDLCMKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class PDKLELIBIFC : NOJJNEBIABE<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7510530", Offset = "0x750EF30", VA = "0x187510530")]
		public PDKLELIBIFC(string DDDMPLCOGIM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AHIHMPPPDJO FMBLHFNEALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FOKHDAMMMLG KEOJBOFGGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer FPJKPEOPMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private PDKLELIBIFC JADABHOONAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool PPGGANGHCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer MKMNDBLBLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private PDKLELIBIFC NIPHOGELNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool LJDAOGCLKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer FBMCHJLIMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private PDKLELIBIFC ILPLPKHJEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool MFEGJLLOBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool NMOEEADIFFA;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x887590", Offset = "0x885F90", VA = "0x180887590")]
	public JLJCMOEIAAB(AHIHMPPPDJO CDNGDGIHDCC, FOKHDAMMMLG KEOJBOFGGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7507820", Offset = "0x7506220", VA = "0x187507820", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7507B00", Offset = "0x7506500", VA = "0x187507B00")]
	private void EGAMLANICOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7508310", Offset = "0x7506D10", VA = "0x187508310", Slot = "4")]
	public void HLIOGABGHGA(POMPLEGKFCO BAFHJDFHJHD, OHFCNPENGBB NNKPOGBBDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x75080F0", Offset = "0x7506AF0", VA = "0x1875080F0", Slot = "5")]
	public void HLIOGABGHGA(JHJMOICONME NLBIOBEAIBN, OHFCNPENGBB NNKPOGBBDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7509210", Offset = "0x7507C10", VA = "0x187509210", Slot = "6")]
	public void OBJLBPNMKBF(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7508D70", Offset = "0x7507770", VA = "0x187508D70", Slot = "7")]
	public void KOMIJEDALMD(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x75075D0", Offset = "0x7505FD0", VA = "0x1875075D0", Slot = "24")]
	public void AGGGKAIAHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xACFDF0", Offset = "0xACE7F0", VA = "0x180ACFDF0", Slot = "8")]
	public void CDDODELOONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x75076B0", Offset = "0x75060B0", VA = "0x1875076B0", Slot = "9")]
	public void BOFODNKJLHF(OHFCNPENGBB NNKPOGBBDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7508980", Offset = "0x7507380", VA = "0x187508980", Slot = "10")]
	public void JDFNHDKIBAC(POMPLEGKFCO BAFHJDFHJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7508620", Offset = "0x7507020", VA = "0x187508620", Slot = "11")]
	public void JDFNHDKIBAC(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7507610", Offset = "0x7506010", VA = "0x187507610", Slot = "12")]
	public void BHNDGMJFJOD(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7508E80", Offset = "0x7507880", VA = "0x187508E80", Slot = "13")]
	public void MINBBJLEGDC(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7509340", Offset = "0x7507D40", VA = "0x187509340")]
	private void ONPGIFMDBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xBB09C0", Offset = "0xBAF3C0", VA = "0x180BB09C0", Slot = "14")]
	public void FCLLJAEBHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7508C50", Offset = "0x7507650", VA = "0x187508C50", Slot = "15")]
	public void JLHGJJPBNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7507D70", Offset = "0x7506770", VA = "0x187507D70", Slot = "16")]
	public void EPPJIOCIOIB(POMPLEGKFCO BAFHJDFHJHD, AGNEHGOBOAO AOGCIMANLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7508050", Offset = "0x7506A50", VA = "0x187508050", Slot = "17")]
	public void FOGKECAHPMG(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7509180", Offset = "0x7507B80", VA = "0x187509180", Slot = "18")]
	public void NJBDPCOCNAI(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xCC6DF0", Offset = "0xCC57F0", VA = "0x180CC6DF0", Slot = "19")]
	public void DFFHKEBMJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x75079D0", Offset = "0x75063D0", VA = "0x1875079D0", Slot = "20")]
	public void EDBPGCIGGEN(AGNEHGOBOAO AOGCIMANLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7508F10", Offset = "0x7507910", VA = "0x187508F10")]
	private void MNLJOJCHNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7507200", Offset = "0x7505C00", VA = "0x187507200", Slot = "21")]
	public void ACLHFEEGAPA(POMPLEGKFCO BAFHJDFHJHD, Vector3 NCNNFDJBEEG, Vector3 JMKKCMMDLHN, Vector3 CGAJKJIDDPM, float IGLOBBLFBLJ, float NOOBIJPGEGH, IReadOnlyList<Camera> FFCIDODLBLL, GFCMMAOCIGI IOGDAIKBAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7506D60", Offset = "0x7505760", VA = "0x187506D60", Slot = "22")]
	public void ACLHFEEGAPA(CNNHDBNJNBD OLJDDPHJDKD, Vector3 NCNNFDJBEEG, Vector3 JMKKCMMDLHN, Vector3 CGAJKJIDDPM, float IGLOBBLFBLJ, float NOOBIJPGEGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class ADFLCGLNPGH : AGFEKKBFFCK, LFILPOBKFEH, FMGLELNEAOE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly PPALFEOCFIA CHMOOKFGBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds OGEGCILJPFB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds CMLGOLDEFML
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x12AA330", Offset = "0x12A8D30", VA = "0x1812AA330", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool PNHNONJOFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xC320D0", Offset = "0xC30AD0", VA = "0x180C320D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xD12ED0", Offset = "0xD118D0", VA = "0x180D12ED0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 JCCBGGGLFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PHOGOKMBCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x913B40", Offset = "0x912540", VA = "0x180913B40", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ODMIIBLNLBB MLDFNDHJFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x88B260", Offset = "0x889C60", VA = "0x18088B260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool JEFALMJDJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xC8F430", Offset = "0xC8DE30", VA = "0x180C8F430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	protected ADFLCGLNPGH(PPALFEOCFIA BAFHJDFHJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7501C10", Offset = "0x7500610", VA = "0x187501C10", Slot = "16")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "17")]
	public virtual bool DEDFNMCPJPJ(FGHMMAJOCCM BAFHJDFHJHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int LLPGLDJILPJ(BMENCFGGDHJ PDJBKOAOLLN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int LIOFLIMODLJ(BMENCFGGDHJ PDJBKOAOLLN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract Bounds LOFPOCMJDLC();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract float FBEJCKCDMKJ();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract void DANDGDJPKDJ(BMENCFGGDHJ PDJBKOAOLLN, ENAKOAFNLIC MPPLAHJJFFO, int JJCECAFOBMP = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract FGHMMAJOCCM IHADEMBOOIB();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7501D70", Offset = "0x7500770", VA = "0x187501D70", Slot = "12")]
	public Hash128 KMBIJGBPLOA(int PDJBKOAOLLN)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract NMDMIIDOBCA JMBDMLDBOLB();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract INLKNLOKEBI LMAKHEOJPJF(BMENCFGGDHJ PDJBKOAOLLN, JobHandle AJLOAOCOAJH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7501D40", Offset = "0x7500740", VA = "0x187501D40", Slot = "11")]
	public INLKNLOKEBI HNCIDHGDPLM(int PDJBKOAOLLN)
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

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7513330", Offset = "0x7511D30", VA = "0x187513330")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NKBFEJHPINL
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PFBCHLGJIEB : IEnumerable<LKCDLPHPLGK>, IEnumerable, IEnumerator<LKCDLPHPLGK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private LKCDLPHPLGK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private LKCDLPHPLGK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public PFBCHLGJIEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7510580", Offset = "0x750EF80", VA = "0x187510580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x75106F0", Offset = "0x750F0F0", VA = "0x1875106F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7510650", Offset = "0x750F050", VA = "0x187510650", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LKCDLPHPLGK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7510650", Offset = "0x750F050", VA = "0x187510650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static LKCDLPHPLGK[][] CPFLMIPIMFG;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static NAHHJEPLBBI OLONLFHCDMB;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig PBBAIDEEIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x750F7E0", Offset = "0x750E1E0", VA = "0x18750F7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader DJAGDJACGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x750F6C0", Offset = "0x750E0C0", VA = "0x18750F6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer CAHOBKDENII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7510290", Offset = "0x750EC90", VA = "0x187510290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x750F730", Offset = "0x750E130", VA = "0x18750F730")]
	public static Mesh EBJPKGDELNH(KHEAFOBJNAC JCDAIKBCMOB, int PDJBKOAOLLN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x75100C0", Offset = "0x750EAC0", VA = "0x1875100C0")]
	public static int MLGHBOOMHMF(KHEAFOBJNAC JCDAIKBCMOB, int PDJBKOAOLLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x750FC60", Offset = "0x750E660", VA = "0x18750FC60")]
	public static NAHHJEPLBBI IAFCCCCPOJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7510040", Offset = "0x750EA40", VA = "0x187510040")]
	[IteratorStateMachine(typeof(PFBCHLGJIEB))]
	private static IEnumerable<LKCDLPHPLGK> JLMCHOMJICB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x750FDA0", Offset = "0x750E7A0", VA = "0x18750FDA0")]
	public static LKCDLPHPLGK IELANJLKCGP(KHEAFOBJNAC JCDAIKBCMOB, int PDJBKOAOLLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x75100A0", Offset = "0x750EAA0", VA = "0x1875100A0")]
	public static bool LKLOLKLEHDE(this KHEAFOBJNAC JCDAIKBCMOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7510300", Offset = "0x750ED00", VA = "0x187510300")]
	public static void PGHKBGKPLOA(KHEAFOBJNAC JCDAIKBCMOB, float3 DFLOKCMEOAB, [Out] BPANGNGAEKC MHMAJFPNKPE, [Out] float3 ALDKFCHPPPL, [Out] float NAGFKGIMJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x750F810", Offset = "0x750E210", VA = "0x18750F810")]
	public static void HJGNGEOMIDA(Vector3 DFLOKCMEOAB, KHEAFOBJNAC JCDAIKBCMOB, [Out] Vector3 ALDKFCHPPPL, [Out] float NAGFKGIMJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x75104B0", Offset = "0x750EEB0", VA = "0x1875104B0")]
	[IPMEGJEKNFO(DBODMODMHMH.ExitingPlayMode, 0)]
	[JAEIDIAJKJB(0)]
	private static void PPPDAKGIILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x75100D0", Offset = "0x750EAD0", VA = "0x1875100D0")]
	[IPMEGJEKNFO(DBODMODMHMH.ExitingPlayMode, 0)]
	[JAEIDIAJKJB(0)]
	private static void NNIAFHCLDLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class LLPJMJEBBHH : GAFDHANDCAD, IDisposable, FOKHDAMMMLG
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly HJLLEKJMPAN<POMPLEGKFCO, PPALFEOCFIA> MNDOEKDFJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly HJLLEKJMPAN<JHJMOICONME, ADFLCGLNPGH> CIDMCPPMNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly HJLLEKJMPAN<CNNHDBNJNBD, BAADICDJGPD> GFBIDLBHBND;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public PPALFEOCFIA BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x750CBA0", Offset = "0x750B5A0", VA = "0x18750CBA0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ADFLCGLNPGH BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x750CC60", Offset = "0x750B660", VA = "0x18750CC60", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public BAADICDJGPD BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x750CC00", Offset = "0x750B600", VA = "0x18750CC00", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DHEFFKBHKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9A6B00", Offset = "0x9A5500", VA = "0x1809A6B00", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xDA7090", Offset = "0xDA5A90", VA = "0x180DA7090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x750CDB0", Offset = "0x750B7B0", VA = "0x18750CDB0")]
	public LLPJMJEBBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x750C4B0", Offset = "0x750AEB0", VA = "0x18750C4B0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x750C2F0", Offset = "0x750ACF0", VA = "0x18750C2F0", Slot = "4")]
	public POMPLEGKFCO AGGALJMIAJL(MBPFKDDNMLH LNCKNHNHHDF)
	{
		return default(POMPLEGKFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x750C2F0", Offset = "0x750ACF0", VA = "0x18750C2F0", Slot = "5")]
	public POMPLEGKFCO AGGALJMIAJL(MBPFKDDNMLH LNCKNHNHHDF, bool PEPFCFILDJI)
	{
		return default(POMPLEGKFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x750CA20", Offset = "0x750B420", VA = "0x18750CA20", Slot = "6")]
	public void LOFKDPGNCEF(POMPLEGKFCO BAFHJDFHJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x750C390", Offset = "0x750AD90", VA = "0x18750C390", Slot = "7")]
	public void DDDCCBDGOKN(POMPLEGKFCO BAFHJDFHJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x750C6A0", Offset = "0x750B0A0", VA = "0x18750C6A0", Slot = "8")]
	public JHJMOICONME FLMIIBLAEEF(POMPLEGKFCO BAFHJDFHJHD, GDFFHEGJACA LNCKNHNHHDF)
	{
		return default(JHJMOICONME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x750C8E0", Offset = "0x750B2E0", VA = "0x18750C8E0", Slot = "9")]
	public JHJMOICONME JHKINFPMGDP(POMPLEGKFCO BAFHJDFHJHD, PIFHFJIMKBG LNCKNHNHHDF)
	{
		return default(JHJMOICONME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x750C7E0", Offset = "0x750B1E0", VA = "0x18750C7E0", Slot = "11")]
	public void FMPEJEMNINO(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x750C5E0", Offset = "0x750AFE0", VA = "0x18750C5E0", Slot = "10")]
	public void FFKGOFOAMGP(JHJMOICONME NLBIOBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x750C870", Offset = "0x750B270", VA = "0x18750C870", Slot = "20")]
	public IEnumerable<Renderer> HGEPIAMGEAE(POMPLEGKFCO BAFHJDFHJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x750CA80", Offset = "0x750B480", VA = "0x18750CA80", Slot = "12")]
	public CNNHDBNJNBD MANCHLCINKO(JPGEPNHCBAE LNCKNHNHHDF)
	{
		return default(CNNHDBNJNBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x750CCC0", Offset = "0x750B6C0", VA = "0x18750CCC0", Slot = "14")]
	public void OJKJCCNBPKD(CNNHDBNJNBD OLJDDPHJDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x750C540", Offset = "0x750AF40", VA = "0x18750C540", Slot = "16")]
	public Task ELOAIGLEPFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x750CB00", Offset = "0x750B500", VA = "0x18750CB00", Slot = "17")]
	public Task NABMKIKMIPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x750C410", Offset = "0x750AE10", VA = "0x18750C410", Slot = "18")]
	public Task DJNMFMAHJDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x20452A0", Offset = "0x2043CA0", VA = "0x1820452A0", Slot = "19")]
	public void IIHIIHOBGFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x750C640", Offset = "0x750B040", VA = "0x18750C640", Slot = "13")]
	public void FJCGMAEEIGA(CNNHDBNJNBD OLJDDPHJDKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IIOOJHLEJHP
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NGNCHOBIJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material NPBIHDDAMGD();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material BLHCPAIJJIA();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material GBIBPEDEJIG();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KHKKICNJGED(ILGMMPAEBOD NAKAEDDMOMP);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DKOJEJBCLAC(FHMDBDPAHKN IJFBOFJDIDB);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMBAEBABJML(GameObject FHFDEAHMMBI);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PJJKBNMBEGD(GameObject FHFDEAHMMBI, bool CMGNEIENLDO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BHIIPKNJPPF
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static IIOOJHLEJHP KCEPABIAINB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool NGNCHOBIJOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7503930", Offset = "0x7502330", VA = "0x187503930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7503740", Offset = "0x7502140", VA = "0x187503740")]
	public static void BEPMNFAAGGO(IIOOJHLEJHP IBLBAJGJBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7503A60", Offset = "0x7502460", VA = "0x187503A60")]
	public static Material NPBIHDDAMGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7503790", Offset = "0x7502190", VA = "0x187503790")]
	public static Material BLHCPAIJJIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7503860", Offset = "0x7502260", VA = "0x187503860")]
	public static Material GBIBPEDEJIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x75038C0", Offset = "0x75022C0", VA = "0x1875038C0")]
	public static int KHKKICNJGED(ILGMMPAEBOD NAKAEDDMOMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x75037F0", Offset = "0x75021F0", VA = "0x1875037F0")]
	public static int DKOJEJBCLAC(FHMDBDPAHKN IJFBOFJDIDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7503990", Offset = "0x7502390", VA = "0x187503990")]
	public static void NMBAEBABJML(GameObject FHFDEAHMMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7503AC0", Offset = "0x75024C0", VA = "0x187503AC0")]
	public static void PJJKBNMBEGD(GameObject FHFDEAHMMBI, bool CMGNEIENLDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BAADICDJGPD : GFIJFEOJDDC
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GNIDDBJMGLL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BAADICDJGPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public GNIDDBJMGLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x75048E0", Offset = "0x75032E0", VA = "0x1875048E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x75045C0", Offset = "0x7502FC0", VA = "0x1875045C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7504570", Offset = "0x7502F70", VA = "0x187504570")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7504890", Offset = "0x7503290", VA = "0x187504890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x75047E0", Offset = "0x75031E0", VA = "0x1875047E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x75047E0", Offset = "0x75031E0", VA = "0x1875047E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly JPGEPNHCBAE BGBBFCLNPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly FOKHDAMMMLG KEOJBOFGGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private FDHDGODFIDB GCBIFDMFEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<PGKDLFIPKCJ> PJBOLJCMLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<PGKDLFIPKCJ> OAPNCBHIJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject EFNLOGODGPN;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7502580", Offset = "0x7500F80", VA = "0x187502580")]
	public static BAADICDJGPD KKEFOMLJAOL(JPGEPNHCBAE LNCKNHNHHDF, FOKHDAMMMLG KEOJBOFGGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7503660", Offset = "0x7502060", VA = "0x187503660")]
	private BAADICDJGPD(JPGEPNHCBAE LNCKNHNHHDF, FOKHDAMMMLG KEOJBOFGGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7503160", Offset = "0x7501B60", VA = "0x187503160")]
	public void NEECMKACHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x75035E0", Offset = "0x7501FE0", VA = "0x1875035E0")]
	[IteratorStateMachine(typeof(GNIDDBJMGLL))]
	public IEnumerable<Renderer> NONHJODLFJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x75026D0", Offset = "0x75010D0", VA = "0x1875026D0", Slot = "4")]
	public void KNJBAHAGIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7502550", Offset = "0x7500F50", VA = "0x187502550")]
	private void IPPLIIJBNBE(Vector3 DFMBNKCOHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7502300", Offset = "0x7500D00", VA = "0x187502300")]
	public void EOBPLEKHDDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PGKDLFIPKCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct LPHHHILNJEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public ENAKOAFNLIC MNBJGLNDFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FGHMMAJOCCM GDLELHJHEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int GMHDFHLBDOF;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HPMPDKBIEOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PGKDLFIPKCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public BMENCFGGDHJ lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<LPHHHILNJEA> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CCDNCOACIDM combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HPMPDKBIEOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7504FE0", Offset = "0x75039E0", VA = "0x187504FE0")]
		internal JobHandle HNJIKPCIEHG()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7504FB0", Offset = "0x75039B0", VA = "0x187504FB0")]
		internal void BPPEMKOAMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7505040", Offset = "0x7503A40", VA = "0x187505040")]
		internal void KDFDJOOJLOI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] FOCDIPCMCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private MCKIGKLAMJJ NNGKLKALHAI;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 BKHLCAOPIJA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh HPOAHBCFCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int PDIJFBBJBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x885600", Offset = "0x884000", VA = "0x180885600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7510E60", Offset = "0x750F860", VA = "0x187510E60")]
	public void JNIOLHACICM(List<FGHMMAJOCCM> PKLODKJOICD, Matrix4x4[] IDCBBOHAHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x75107D0", Offset = "0x750F1D0", VA = "0x1875107D0")]
	public static List<PGKDLFIPKCJ> EMJKOLAJLFI(List<PPALFEOCFIA> OAMMJCMIPFM, BMENCFGGDHJ PDJBKOAOLLN, Bounds OBOMBLGEGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7511040", Offset = "0x750FA40", VA = "0x187511040")]
	private JobHandle MIGADDOLOOA(CCDNCOACIDM FMMJEHGMAMD, int FBOKOPMOEJK, int AJEDNCMAFDC, BMENCFGGDHJ PDJBKOAOLLN, List<LPHHHILNJEA> NELHKNBDBFE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x75113A0", Offset = "0x750FDA0", VA = "0x1875113A0")]
	private void PALFBDNAKJJ(List<LPHHHILNJEA> NELHKNBDBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7511610", Offset = "0x7510010", VA = "0x187511610")]
	private PGKDLFIPKCJ(List<LPHHHILNJEA> NELHKNBDBFE, int FBOKOPMOEJK, int AJEDNCMAFDC, BMENCFGGDHJ PDJBKOAOLLN, Bounds OBOMBLGEGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7510740", Offset = "0x750F140", VA = "0x187510740", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private MaterialPropertyBlock GJMFAHCDGNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private PGKDLFIPKCJ LDNHICGPCIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<FGHMMAJOCCM> OBOIFLJENCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture IPNAJEGILKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer HOJJDCENFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader LNPNMOMBEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] NAGCGFLPGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int OCLHPBAHDHI;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer JPIOJLFCGHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int CABAHIILHMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x75140A0", Offset = "0x7512AA0", VA = "0x1875140A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7513390", Offset = "0x7511D90", VA = "0x187513390")]
		public static List<SkinnedShapeRenderer> Create(GameObject BAFHJDFHJHD, List<PGKDLFIPKCJ> IKMOMJBBJBO, List<FGHMMAJOCCM> OBOIFLJENCP, Material PPFNGNPGEKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7513700", Offset = "0x7512100", VA = "0x187513700")]
		public void Init(PGKDLFIPKCJ LDNHICGPCIN, List<FGHMMAJOCCM> OBOIFLJENCP, Material PPFNGNPGEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7514000", Offset = "0x7512A00", VA = "0x187514000")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7513F60", Offset = "0x7512960", VA = "0x187513F60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7513F20", Offset = "0x7512920", VA = "0x187513F20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7513640", Offset = "0x7512040", VA = "0x187513640")]
		private void GGIFNKMLJKM(ScriptableRenderContext MPOBGCPIOEI, Camera[] LCFCGENIKIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7513BB0", Offset = "0x75125B0", VA = "0x187513BB0")]
		private void JNIOLHACICM(CommandBuffer KIDNBOFHEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
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
