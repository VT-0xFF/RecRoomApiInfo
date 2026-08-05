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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x830DFD0", Offset = "0x830D3D0", VA = "0x18830DFD0", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8319F00", Offset = "0x8319300", VA = "0x188319F00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CANCINPMGJL : KPPCPIFKCKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte ALEBIBNFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] DGCLBIBMELG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NDGAPMJFNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB35CF0", Offset = "0xB350F0", VA = "0x180B35CF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBE45A0", Offset = "0xBE39A0", VA = "0x180BE45A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JBACHKAOKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC69A20", Offset = "0xC68E20", VA = "0x180C69A20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE46E60", Offset = "0xE46260", VA = "0x180E46E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float ODEGOMADFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE58410", Offset = "0xE57810", VA = "0x180E58410", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x11C7260", Offset = "0x11C6660", VA = "0x1811C7260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float FAMEKLILKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBAE4B0", Offset = "0xBAD8B0", VA = "0x180BAE4B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBAE4C0", Offset = "0xBAD8C0", VA = "0x180BAE4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> CBAGMCFJBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8308C10", Offset = "0x8308010", VA = "0x188308C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> IJGIAJJLOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8309070", Offset = "0x8308470", VA = "0x188309070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject HLJCJLLDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99E210", Offset = "0x99D610", VA = "0x18099E210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte CKLHJAIKFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8308DA0", Offset = "0x83081A0", VA = "0x188308DA0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x83090A0", Offset = "0x83084A0", VA = "0x1883090A0")]
	public CANCINPMGJL(List<OOGGOALKCDA> PAKPDBFMJAK, List<OOGGOALKCDA> KCHHJOAGBDN, List<FGCPOOOBBED> HOFLLLMEFDN, Material ANOGJJADLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8308DF0", Offset = "0x83081F0", VA = "0x188308DF0")]
	private int GGBILADAFKN(List<OOGGOALKCDA> CIJMELELIGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8308F10", Offset = "0x8308310", VA = "0x188308F10")]
	private void JKPIFOLOELF(int IOEGCIEAANI, bool HLCLADEIGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8308AC0", Offset = "0x8307EC0", VA = "0x188308AC0")]
	public void BFNGEGLLGHK(Vector3 HNHNFIPFKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8308C60", Offset = "0x8308060", VA = "0x188308C60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8308D60", Offset = "0x8308160", VA = "0x188308D60")]
	public void EGKAMIMFGDG(Transform KHNCMIJFKPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GDHBHPADBLA : KEOOGJDDLAC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LNFPLDBMKNC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GDHBHPADBLA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public LNFPLDBMKNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x830DDE0", Offset = "0x830D1E0", VA = "0x18830DDE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x830D730", Offset = "0x830CB30", VA = "0x18830D730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x830DC90", Offset = "0x830D090", VA = "0x18830DC90")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x830DC40", Offset = "0x830D040", VA = "0x18830DC40")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x830D6E0", Offset = "0x830CAE0", VA = "0x18830D6E0")]
		private void KLNIOFJAILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x830DD90", Offset = "0x830D190", VA = "0x18830DD90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x830DCE0", Offset = "0x830D0E0", VA = "0x18830DCE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x830DCE0", Offset = "0x830D0E0", VA = "0x18830DCE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JDKOCKGKOJM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GDHBHPADBLA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public JDKOCKGKOJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x830D1B0", Offset = "0x830C5B0", VA = "0x18830D1B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x830CCA0", Offset = "0x830C0A0", VA = "0x18830CCA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x830D060", Offset = "0x830C460", VA = "0x18830D060")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x830D010", Offset = "0x830C410", VA = "0x18830D010")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x830D160", Offset = "0x830C560", VA = "0x18830D160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x830D0B0", Offset = "0x830C4B0", VA = "0x18830D0B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x830D0B0", Offset = "0x830C4B0", VA = "0x18830D0B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AAMGODPHIMC MMILFLIJGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<BKKIPANPFKC> FGOGECEFJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> MDDCEFAEIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer KNCPJCPGOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool NFAPCJAJKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool NPCKOPKICNC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<AIOFPJFDDDB> HEJNACNDGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AJJLAFEKENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x830BF80", Offset = "0x830B380", VA = "0x18830BF80", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FGCPOOOBBED JFMJBACEBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x830B810", Offset = "0x830AC10", VA = "0x18830B810", Slot = "8")]
		get
		{
			return default(FGCPOOOBBED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PGNDNCJEALN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x994400", Offset = "0x993800", VA = "0x180994400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x830C250", Offset = "0x830B650", VA = "0x18830C250")]
	private bool ONPPLALGGKL(BKKIPANPFKC KFBPKKLDJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x830BFC0", Offset = "0x830B3C0", VA = "0x18830BFC0")]
	private static bool NMJMIBNPAKK(BKKIPANPFKC KFBPKKLDJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x830C3C0", Offset = "0x830B7C0", VA = "0x18830C3C0")]
	public GDHBHPADBLA(AAMGODPHIMC HPMNBNLACCC, bool HBPLPIBFALL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x830B000", Offset = "0x830A400", VA = "0x18830B000", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x830BA40", Offset = "0x830AE40", VA = "0x18830BA40")]
	public void JJBKLNLGAIJ(BKKIPANPFKC KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x830B8E0", Offset = "0x830ACE0", VA = "0x18830B8E0")]
	public void JEBJOEBLLEI(BKKIPANPFKC KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x830B1F0", Offset = "0x830A5F0", VA = "0x18830B1F0", Slot = "4")]
	public void EAHLDIOCGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x830BFE0", Offset = "0x830B3E0", VA = "0x18830BFE0")]
	public void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x830BD10", Offset = "0x830B110", VA = "0x18830BD10")]
	private void MBOOODDOMBE(List<BKKIPANPFKC> FGOGECEFJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x830B7B0", Offset = "0x830ABB0", VA = "0x18830B7B0")]
	private static Material FOIKKDLIGML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x830BED0", Offset = "0x830B2D0", VA = "0x18830BED0")]
	private void MBOOODDOMBE(BKKIPANPFKC KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x830C2F0", Offset = "0x830B6F0", VA = "0x18830C2F0")]
	private void PMJOEBEIMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x830AA40", Offset = "0x8309E40", VA = "0x18830AA40")]
	public void CILBHAHGNEE(bool LPJNGLCJMLB, bool JNNPLIPIKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x830B6F0", Offset = "0x830AAF0", VA = "0x18830B6F0")]
	protected void EMGJLCIGDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x830C270", Offset = "0x830B670", VA = "0x18830C270")]
	public void PEJCDCNJBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x830BC90", Offset = "0x830B090", VA = "0x18830BC90")]
	[IteratorStateMachine(typeof(LNFPLDBMKNC))]
	public IEnumerable<Renderer> KNAJIDPJPKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x830BC10", Offset = "0x830B010", VA = "0x18830BC10")]
	[IteratorStateMachine(typeof(JDKOCKGKOJM))]
	public IEnumerable<Renderer> KGPKCMKFGNA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class OBPHLGOJBKH : BKKIPANPFKC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct MCJGNDGNALA : DKOAMKOECOP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NPAHDDNJHLF MPJNANLNCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle CNINKJDDJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private AOGKFLEKIMN PGKCGEIFNHH;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x830E120", Offset = "0x830D520", VA = "0x18830E120")]
		public MCJGNDGNALA(NPAHDDNJHLF MPJNANLNCGP, JobHandle CNINKJDDJFJ, AOGKFLEKIMN PGKCGEIFNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x830E0A0", Offset = "0x830D4A0", VA = "0x18830E0A0", Slot = "4")]
		public NPAHDDNJHLF CKDFENAGPAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x830E0D0", Offset = "0x830D4D0", VA = "0x18830E0D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly CAJIMFNGHMB MDNCHCPKOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float PMMIDKOHLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 NAJMJABGGPM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 ELCGNOKCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8310F80", Offset = "0x8310380", VA = "0x188310F80", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8312120", Offset = "0x8311520", VA = "0x188312120")]
	public OBPHLGOJBKH(GDHBHPADBLA BKHMOJGGBFN, CAJIMFNGHMB HPMNBNLACCC, bool HBPLPIBFALL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "18")]
	public override bool MHJHFDDDDHL(FGCPOOOBBED BKHMOJGGBFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8310BF0", Offset = "0x830FFF0", VA = "0x188310BF0", Slot = "19")]
	public override int GGBILADAFKN(ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x83110B0", Offset = "0x83104B0", VA = "0x1883110B0", Slot = "20")]
	public override int LKAIIMFAOFF(ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x83107B0", Offset = "0x830FBB0", VA = "0x1883107B0", Slot = "21")]
	public override HNGCCHGLKLA ABFMHHFLODO()
	{
		return default(HNGCCHGLKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xB73340", Offset = "0xB72740", VA = "0x180B73340", Slot = "22")]
	public override float MJFKKBELHPD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8311B20", Offset = "0x8310F20", VA = "0x188311B20", Slot = "23")]
	public override void OCKBJECCOCD(ICNEIPPCAOC KHCIAPOHNBN, DGAEOBIFNFN MPFLNIDPMNK, int KJNAJBBMMJJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8311A50", Offset = "0x8310E50", VA = "0x188311A50", Slot = "24")]
	public override FGCPOOOBBED MPNBKLHNMPH()
	{
		return default(FGCPOOOBBED);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8310DC0", Offset = "0x83101C0", VA = "0x188310DC0", Slot = "26")]
	public override LAOGPDALMBH GMENIDFFBCM()
	{
		return default(LAOGPDALMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8311280", Offset = "0x8310680", VA = "0x188311280", Slot = "27")]
	public override DKOAMKOECOP LMOAAFKJNLA(ICNEIPPCAOC KHCIAPOHNBN, JobHandle CNINKJDDJFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface CIAMAPMHMNO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GDHBHPADBLA JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BKKIPANPFKC JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CDGLGPHMKPK JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class OGLFPKLANON : BCDHLHGCIBM, IDisposable, CIAMAPMHMNO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GMHBGONBACB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public OGLFPKLANON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x830C4B0", Offset = "0x830B8B0", VA = "0x18830C4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x830CA30", Offset = "0x830BE30", VA = "0x18830CA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IGHFGDGAJBN<OIICOGMNAJO, GDHBHPADBLA> ANGIDLDNFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IGHFGDGAJBN<LCIMFKFFNPO, BKKIPANPFKC> FGOGECEFJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IGHFGDGAJBN<LHCPDKENODA, CDGLGPHMKPK> PFJMEOLLBCA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GDHBHPADBLA JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8312780", Offset = "0x8311B80", VA = "0x188312780", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BKKIPANPFKC JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8312720", Offset = "0x8311B20", VA = "0x188312720", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CDGLGPHMKPK JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83127E0", Offset = "0x8311BE0", VA = "0x1883127E0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PJPDFLJAPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD09A80", Offset = "0xD08E80", VA = "0x180D09A80", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9FECE0", Offset = "0x9FE0E0", VA = "0x1809FECE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x83143F0", Offset = "0x83137F0", VA = "0x1883143F0")]
	public OGLFPKLANON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8313030", Offset = "0x8312430", VA = "0x188313030", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8312710", Offset = "0x8311B10", VA = "0x188312710", Slot = "4")]
	public OIICOGMNAJO BDCGACPGOID(AAMGODPHIMC HPMNBNLACCC)
	{
		return default(OIICOGMNAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8312490", Offset = "0x8311890", VA = "0x188312490", Slot = "5")]
	public OIICOGMNAJO BDCGACPGOID(AAMGODPHIMC HPMNBNLACCC, bool HBPLPIBFALL)
	{
		return default(OIICOGMNAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8312D60", Offset = "0x8312160", VA = "0x188312D60", Slot = "6")]
	public void CLDLMMCILAA(OIICOGMNAJO BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8312A00", Offset = "0x8311E00", VA = "0x188312A00", Slot = "7")]
	public void CEJMBKEPGGA(OIICOGMNAJO BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x83135C0", Offset = "0x83129C0", VA = "0x1883135C0", Slot = "8")]
	public LCIMFKFFNPO GMDPAAENKIG(OIICOGMNAJO BKHMOJGGBFN, JKEFCPMGAAL HPMNBNLACCC)
	{
		return default(LCIMFKFFNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8313F10", Offset = "0x8313310", VA = "0x188313F10", Slot = "9")]
	public LCIMFKFFNPO PIAEENMNGEA(OIICOGMNAJO BKHMOJGGBFN, CAJIMFNGHMB HPMNBNLACCC)
	{
		return default(LCIMFKFFNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8313200", Offset = "0x8312600", VA = "0x188313200", Slot = "11")]
	public void GLMDKGPPDMK(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x83121D0", Offset = "0x83115D0", VA = "0x1883121D0", Slot = "10")]
	public void AIFKHDKINLG(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8313EA0", Offset = "0x83132A0", VA = "0x188313EA0", Slot = "20")]
	public IEnumerable<Renderer> LLLGJLOHBHF(OIICOGMNAJO BKHMOJGGBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8313AA0", Offset = "0x8312EA0", VA = "0x188313AA0", Slot = "12")]
	public LHCPDKENODA IEONHDNNILK(GHAIBLPNJLP HPMNBNLACCC)
	{
		return default(LHCPDKENODA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8312FC0", Offset = "0x83123C0", VA = "0x188312FC0", Slot = "14")]
	public void DKIGEBNPFKE(LHCPDKENODA BKNPBBIMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8312840", Offset = "0x8311C40", VA = "0x188312840", Slot = "16")]
	public Task BKMBIOKHNFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8313C10", Offset = "0x8313010", VA = "0x188313C10", Slot = "17")]
	public Task LCICLGADGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8313DD0", Offset = "0x83131D0", VA = "0x188313DD0", Slot = "18")]
	[AsyncStateMachine(typeof(GMHBGONBACB))]
	public Task LEHGKIFIMMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8313B20", Offset = "0x8312F20", VA = "0x188313B20", Slot = "19")]
	public void JNLLFPJCFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8312430", Offset = "0x8311830", VA = "0x188312430", Slot = "13")]
	public void AKKIODPGMAF(LHCPDKENODA BKNPBBIMBII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class NLECKLHHPEC : BKKIPANPFKC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct MHBPECMEADA : DKOAMKOECOP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private NPAHDDNJHLF MPJNANLNCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> DKNKMOMIJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle CNINKJDDJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private FBADIPMGPKH PGKCGEIFNHH;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x830E280", Offset = "0x830D680", VA = "0x18830E280")]
		public MHBPECMEADA(NPAHDDNJHLF MPJNANLNCGP, NativeArray<int> DKNKMOMIJJH, JobHandle CNINKJDDJFJ, FBADIPMGPKH PGKCGEIFNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x830E180", Offset = "0x830D580", VA = "0x18830E180", Slot = "4")]
		public NPAHDDNJHLF CKDFENAGPAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x830E1E0", Offset = "0x830D5E0", VA = "0x18830E1E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly JKEFCPMGAAL EEHHJHNNGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] FEEFMKCLMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 NAJMJABGGPM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 LHOJACJIOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x830E930", Offset = "0x830DD30", VA = "0x18830E930")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 ELCGNOKCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x830F250", Offset = "0x830E650", VA = "0x18830F250", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8310700", Offset = "0x830FB00", VA = "0x188310700")]
	public NLECKLHHPEC(GDHBHPADBLA BKHMOJGGBFN, JKEFCPMGAAL HPMNBNLACCC, bool DGMGNKHMCHH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x830FC10", Offset = "0x830F010", VA = "0x18830FC10", Slot = "18")]
	public override bool MHJHFDDDDHL(FGCPOOOBBED BKHMOJGGBFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x830E2E0", Offset = "0x830D6E0", VA = "0x18830E2E0", Slot = "21")]
	public override HNGCCHGLKLA ABFMHHFLODO()
	{
		return default(HNGCCHGLKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x830E320", Offset = "0x830D720", VA = "0x18830E320")]
	private HNGCCHGLKLA ABFMHHFLODO(FGCPOOOBBED BKHMOJGGBFN)
	{
		return default(HNGCCHGLKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x830EB60", Offset = "0x830DF60", VA = "0x18830EB60")]
	private BBNNPFMJANI CKGMFDDIJDH([In] UniformTRS PFGIMHAADBH, [In] float3 GGIGFLDDKFE)
	{
		return default(BBNNPFMJANI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x830EFE0", Offset = "0x830E3E0", VA = "0x18830EFE0", Slot = "19")]
	public override int GGBILADAFKN(ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x830F380", Offset = "0x830E780", VA = "0x18830F380", Slot = "20")]
	public override int LKAIIMFAOFF(ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x830FCE0", Offset = "0x830F0E0", VA = "0x18830FCE0", Slot = "22")]
	public override float MJFKKBELHPD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x830ED60", Offset = "0x830E160", VA = "0x18830ED60")]
	private int FNIKOBEDGAO(ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x830FEA0", Offset = "0x830F2A0", VA = "0x18830FEA0", Slot = "23")]
	public override void OCKBJECCOCD(ICNEIPPCAOC KHCIAPOHNBN, DGAEOBIFNFN MPFLNIDPMNK, int KJNAJBBMMJJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x830FDD0", Offset = "0x830F1D0", VA = "0x18830FDD0", Slot = "24")]
	public override FGCPOOOBBED MPNBKLHNMPH()
	{
		return default(FGCPOOOBBED);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x830F090", Offset = "0x830E490", VA = "0x18830F090", Slot = "26")]
	public override LAOGPDALMBH GMENIDFFBCM()
	{
		return default(LAOGPDALMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x830F430", Offset = "0x830E830", VA = "0x18830F430", Slot = "27")]
	public override DKOAMKOECOP LMOAAFKJNLA(ICNEIPPCAOC KHCIAPOHNBN, JobHandle CNINKJDDJFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IBPDFOLLEPB
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFHBLBEJEOO(GPFFCLEGEBK HAFNBBNOLPO, Renderer IDCFNEAMCIG, int FHEGJFMKGAK);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHPLCKKKNPF(Renderer IDCFNEAMCIG, HKJGGLJBOND DPGMLKFBPHP, Vector3 HBNIPOIBKCA, Vector3 EGLCALKIHPA, Vector3 MMCDLCPIFGA, float GELFBGAEFJG, float GHACIECNEBE, float DJNPOBKGIAN = -1f, [Optional] Color? ODFBFMBMBOG, [Optional] IReadOnlyList<Camera> LJMAPECFIFA);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLAMIJENPJM(Renderer IDCFNEAMCIG, int FHEGJFMKGAK);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FEFDNMNPABD();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGABJECGKEI(int CMMPFDEALCN, NIBPFMHDCCB HAFNBBNOLPO, Renderer IDCFNEAMCIG, int FHEGJFMKGAK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BDELEEEGBNG : NGAIKMOOEAO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class JCBEDJGHMGF : NFMCAACLCBK<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x830CC50", Offset = "0x830C050", VA = "0x18830CC50")]
		public JCBEDJGHMGF(string IGEPDAOOLBO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IBPDFOLLEPB ICKBKLOFDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CIAMAPMHMNO ALKJCMLKMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer EJEALFINBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private JCBEDJGHMGF GJILONNHOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool ODKLLHMAJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer OMIAHONDIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private JCBEDJGHMGF JECHEHAIALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool ADKFLANIFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer JICAJBKJGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private JCBEDJGHMGF IDGEMKGJNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool GHHJLFHDLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9A3500", Offset = "0x9A2900", VA = "0x1809A3500")]
	public BDELEEEGBNG(IBPDFOLLEPB LBDEADMEFAB, CIAMAPMHMNO ALKJCMLKMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8306AD0", Offset = "0x8305ED0", VA = "0x188306AD0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8308310", Offset = "0x8307710", VA = "0x188308310")]
	private void MOJKFCJCICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8307C50", Offset = "0x8307050", VA = "0x188307C50", Slot = "4")]
	public void JOIPHILJOMC(OIICOGMNAJO BKHMOJGGBFN, NIBPFMHDCCB DOPPEDALNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8307F60", Offset = "0x8307360", VA = "0x188307F60", Slot = "5")]
	public void JOIPHILJOMC(LCIMFKFFNPO KFBPKKLDJOM, NIBPFMHDCCB DOPPEDALNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8306850", Offset = "0x8305C50", VA = "0x188306850", Slot = "6")]
	public void DGHNIMAGIAA(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8308180", Offset = "0x8307580", VA = "0x188308180", Slot = "7")]
	public void KBEEMENKACM(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x83082D0", Offset = "0x83076D0", VA = "0x1883082D0", Slot = "24")]
	public void LMJOPGHOIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xF9D8E0", Offset = "0xF9CCE0", VA = "0x180F9D8E0", Slot = "8")]
	public void NPDPCNJIEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8307100", Offset = "0x8306500", VA = "0x188307100", Slot = "9")]
	public void GNCHCKBHMNF(NIBPFMHDCCB DOPPEDALNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8307270", Offset = "0x8306670", VA = "0x188307270", Slot = "10")]
	public void HCJFCKKOLGD(OIICOGMNAJO BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8307550", Offset = "0x8306950", VA = "0x188307550", Slot = "11")]
	public void HCJFCKKOLGD(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8305F10", Offset = "0x8305310", VA = "0x188305F10", Slot = "12")]
	public void AKDEIDFIMFK(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x83087F0", Offset = "0x8307BF0", VA = "0x1883087F0", Slot = "13")]
	public void PIIFPNHMFMD(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8308580", Offset = "0x8307980", VA = "0x188308580")]
	private void OHCLILBJFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x11FD530", Offset = "0x11FC930", VA = "0x1811FD530", Slot = "14")]
	public void KEADOEOBNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x83069B0", Offset = "0x8305DB0", VA = "0x1883069B0", Slot = "15")]
	public void DJENGIOOMJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8306D50", Offset = "0x8306150", VA = "0x188306D50", Slot = "16")]
	public void FIPHMFGBKPJ(OIICOGMNAJO BKHMOJGGBFN, GPFFCLEGEBK HAFNBBNOLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8306C80", Offset = "0x8306080", VA = "0x188306C80", Slot = "17")]
	public void FHFNJIFJAMN(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8307030", Offset = "0x8306430", VA = "0x188307030", Slot = "18")]
	public void GKKCDAGJKNE(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xBEC140", Offset = "0xBEB540", VA = "0x180BEC140", Slot = "19")]
	public void NNAOLBPIFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8307B20", Offset = "0x8306F20", VA = "0x188307B20", Slot = "20")]
	public void HNNJHOLJEOG(GPFFCLEGEBK HAFNBBNOLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x83078B0", Offset = "0x8306CB0", VA = "0x1883078B0")]
	private void HNDDLOBNJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8306480", Offset = "0x8305880", VA = "0x188306480", Slot = "21")]
	public void BBPFKMIFFEE(OIICOGMNAJO BKHMOJGGBFN, Vector3 HBNIPOIBKCA, Vector3 EGLCALKIHPA, Vector3 MMCDLCPIFGA, float GELFBGAEFJG, float GHACIECNEBE, IReadOnlyList<Camera> OMEAFEJKMKE, HKJGGLJBOND DPGMLKFBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8305FE0", Offset = "0x83053E0", VA = "0x188305FE0", Slot = "22")]
	public void BBPFKMIFFEE(LHCPDKENODA BKNPBBIMBII, Vector3 HBNIPOIBKCA, Vector3 EGLCALKIHPA, Vector3 MMCDLCPIFGA, float GELFBGAEFJG, float GHACIECNEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class BKKIPANPFKC : BGFHOFOIIDK, AIOFPJFDDDB, JALMHLGFGCD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly GDHBHPADBLA HLJCJLLDIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int MONNMPLLFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds AANKFELLNCM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds ADCNOCOKDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8308AA0", Offset = "0x8307EA0", VA = "0x188308AA0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool NPCKOPKICNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xCD97A0", Offset = "0xCD8BA0", VA = "0x180CD97A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCD97F0", Offset = "0xCD8BF0", VA = "0x180CD97F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 ELCGNOKCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CHLBBMLIAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB1B310", Offset = "0xB1A710", VA = "0x180B1B310", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public PJDFJLBDFNH BNCFFNCKIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x994400", Offset = "0x993800", VA = "0x180994400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BKDABDPFJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xDE26D0", Offset = "0xDE1AD0", VA = "0x180DE26D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	protected BKKIPANPFKC(GDHBHPADBLA BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8308900", Offset = "0x8307D00", VA = "0x188308900", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "18")]
	public virtual bool MHJHFDDDDHL(FGCPOOOBBED BKHMOJGGBFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x83088C0", Offset = "0x8307CC0", VA = "0x1883088C0", Slot = "10")]
	public int ACICHGPPDFD(int KCFHBNJGMFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int GGBILADAFKN(ICNEIPPCAOC KHCIAPOHNBN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int LKAIIMFAOFF(ICNEIPPCAOC KHCIAPOHNBN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract HNGCCHGLKLA ABFMHHFLODO();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float MJFKKBELHPD();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void OCKBJECCOCD(ICNEIPPCAOC KHCIAPOHNBN, DGAEOBIFNFN MPFLNIDPMNK, int KJNAJBBMMJJ = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract FGCPOOOBBED MPNBKLHNMPH();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8308A70", Offset = "0x8307E70", VA = "0x188308A70", Slot = "13")]
	public Hash128 FIDKGFHBMMK(int KHCIAPOHNBN)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract LAOGPDALMBH GMENIDFFBCM();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract DKOAMKOECOP LMOAAFKJNLA(ICNEIPPCAOC KHCIAPOHNBN, JobHandle CNINKJDDJFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x83088D0", Offset = "0x8307CD0", VA = "0x1883088D0", Slot = "12")]
	public DKOAMKOECOP CCPBFMLCJDF(int KHCIAPOHNBN)
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

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8318A50", Offset = "0x8317E50", VA = "0x188318A50")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PDMDMFBGLKP
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HJGEJPHPEAB : IEnumerable<MNAEPDHFLLD>, IEnumerable, IEnumerator<MNAEPDHFLLD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private MNAEPDHFLLD <>2__current;

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
		private MNAEPDHFLLD System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public HJGEJPHPEAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x830CA90", Offset = "0x830BE90", VA = "0x18830CA90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x830CC00", Offset = "0x830C000", VA = "0x18830CC00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x830CB60", Offset = "0x830BF60", VA = "0x18830CB60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MNAEPDHFLLD> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x830CB60", Offset = "0x830BF60", VA = "0x18830CB60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static MNAEPDHFLLD[][] MCCFPJBPDMH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static EPHIBHKBNBB BANENNDLBBM;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig DIAHFLBFLJH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader DLLFMOMEIPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8318350", Offset = "0x8317750", VA = "0x188318350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer OPCBPEFINLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83184C0", Offset = "0x83178C0", VA = "0x1883184C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8318240", Offset = "0x8317640", VA = "0x188318240")]
	[FHKEPBLDBGP]
	internal static void GDCNGOALEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8318420", Offset = "0x8317820", VA = "0x188318420")]
	public static Mesh OFIODFFHGEB(NANCINDJPCK FADEBALCHMH, int KHCIAPOHNBN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8318410", Offset = "0x8317810", VA = "0x188318410")]
	public static int MHBNILNGPLH(NANCINDJPCK FADEBALCHMH, int KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8316E30", Offset = "0x8316230", VA = "0x188316E30")]
	public static EPHIBHKBNBB CEICIGKNDOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x83183B0", Offset = "0x83177B0", VA = "0x1883183B0")]
	[IteratorStateMachine(typeof(HJGEJPHPEAB))]
	private static IEnumerable<MNAEPDHFLLD> LPJOGLECJMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8317050", Offset = "0x8316450", VA = "0x188317050")]
	public static MNAEPDHFLLD DNPGOOMPJCE(NANCINDJPCK FADEBALCHMH, int KHCIAPOHNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8318330", Offset = "0x8317730", VA = "0x188318330")]
	public static bool IBCFAHCMMNE(this NANCINDJPCK FADEBALCHMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8316C80", Offset = "0x8316080", VA = "0x188316C80")]
	public static void CDGGPNAKHMD(NANCINDJPCK FADEBALCHMH, float3 OMKIJJKNFPK, [Out] GBCJNLMIOKP DFHOKIAKIAN, [Out] float3 FJJKOFIKEKO, [Out] float DBDKKAAHGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8317E70", Offset = "0x8317270", VA = "0x188317E70")]
	public static void DOLBEJAIGMI(Vector3 OMKIJJKNFPK, NANCINDJPCK FADEBALCHMH, [Out] Vector3 FJJKOFIKEKO, [Out] float DBDKKAAHGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8316C70", Offset = "0x8316070", VA = "0x188316C70")]
	[KLOGBONICBD(0)]
	[IDEKGKHHECE(MPEIPIAKFID.ExitingPlayMode, 0)]
	private static void BJMOABIBOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8316A90", Offset = "0x8315E90", VA = "0x188316A90")]
	[KLOGBONICBD(0)]
	[IDEKGKHHECE(MPEIPIAKFID.ExitingPlayMode, 0)]
	private static void AMFPFMNLEBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class OIBJNDDFHPO : BCDHLHGCIBM, IDisposable, CIAMAPMHMNO
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly IGHFGDGAJBN<OIICOGMNAJO, GDHBHPADBLA> ANGIDLDNFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IGHFGDGAJBN<LCIMFKFFNPO, BKKIPANPFKC> FGOGECEFJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IGHFGDGAJBN<LHCPDKENODA, CDGLGPHMKPK> PFJMEOLLBCA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GDHBHPADBLA JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8314AC0", Offset = "0x8313EC0", VA = "0x188314AC0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public BKKIPANPFKC JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8314A00", Offset = "0x8313E00", VA = "0x188314A00", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public CDGLGPHMKPK JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8314A60", Offset = "0x8313E60", VA = "0x188314A60", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PJPDFLJAPAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xD09A80", Offset = "0xD08E80", VA = "0x180D09A80", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9FECE0", Offset = "0x9FE0E0", VA = "0x1809FECE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8315370", Offset = "0x8314770", VA = "0x188315370")]
	public OIBJNDDFHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8314D10", Offset = "0x8314110", VA = "0x188314D10", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8314960", Offset = "0x8313D60", VA = "0x188314960", Slot = "4")]
	public OIICOGMNAJO BDCGACPGOID(AAMGODPHIMC HPMNBNLACCC)
	{
		return default(OIICOGMNAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8314960", Offset = "0x8313D60", VA = "0x188314960", Slot = "5")]
	public OIICOGMNAJO BDCGACPGOID(AAMGODPHIMC HPMNBNLACCC, bool HBPLPIBFALL)
	{
		return default(OIICOGMNAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8314C40", Offset = "0x8314040", VA = "0x188314C40", Slot = "6")]
	public void CLDLMMCILAA(OIICOGMNAJO BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8314BC0", Offset = "0x8313FC0", VA = "0x188314BC0", Slot = "7")]
	public void CEJMBKEPGGA(OIICOGMNAJO BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8314E30", Offset = "0x8314230", VA = "0x188314E30", Slot = "8")]
	public LCIMFKFFNPO GMDPAAENKIG(OIICOGMNAJO BKHMOJGGBFN, JKEFCPMGAAL HPMNBNLACCC)
	{
		return default(LCIMFKFFNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x83151A0", Offset = "0x83145A0", VA = "0x1883151A0", Slot = "9")]
	public LCIMFKFFNPO PIAEENMNGEA(OIICOGMNAJO BKHMOJGGBFN, CAJIMFNGHMB HPMNBNLACCC)
	{
		return default(LCIMFKFFNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8314DA0", Offset = "0x83141A0", VA = "0x188314DA0", Slot = "11")]
	public void GLMDKGPPDMK(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x83148A0", Offset = "0x8313CA0", VA = "0x1883148A0", Slot = "10")]
	public void AIFKHDKINLG(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8315130", Offset = "0x8314530", VA = "0x188315130", Slot = "20")]
	public IEnumerable<Renderer> LLLGJLOHBHF(OIICOGMNAJO BKHMOJGGBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8314F70", Offset = "0x8314370", VA = "0x188314F70", Slot = "12")]
	public LHCPDKENODA IEONHDNNILK(GHAIBLPNJLP HPMNBNLACCC)
	{
		return default(LHCPDKENODA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8314CA0", Offset = "0x83140A0", VA = "0x188314CA0", Slot = "14")]
	public void DKIGEBNPFKE(LHCPDKENODA BKNPBBIMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8314B20", Offset = "0x8313F20", VA = "0x188314B20", Slot = "16")]
	public Task BKMBIOKHNFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8314FF0", Offset = "0x83143F0", VA = "0x188314FF0", Slot = "17")]
	public Task LCICLGADGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8315090", Offset = "0x8314490", VA = "0x188315090", Slot = "18")]
	public Task LEHGKIFIMMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x257C9F0", Offset = "0x257BDF0", VA = "0x18257C9F0", Slot = "19")]
	public void JNLLFPJCFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8314900", Offset = "0x8313D00", VA = "0x188314900", Slot = "13")]
	public void AKKIODPGMAF(LHCPDKENODA BKNPBBIMBII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FDGALIPDLDL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool DEJFCDLEOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material PPBDFEKMMCH();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material FOIKKDLIGML();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material MPAKDLLINFL();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int APHAFAKBBIP(HHGCLPMBJBD MEABJLCPOGK);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OFNKFHILHOJ(PDDOBMNCGIK MHANHDANDEL);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCFBPHBCEIL(GameObject BLFGIKOAKOL);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GHCDKHIFNJM(GameObject BLFGIKOAKOL, bool PIIHGGGCKGL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class POPBJJHPLBB
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static FDGALIPDLDL BGCEKLPNCIL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool DEJFCDLEOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8318770", Offset = "0x8317B70", VA = "0x188318770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x83188C0", Offset = "0x8317CC0", VA = "0x1883188C0")]
	public static void HGAGNPOAEEP(FDGALIPDLDL IEGGKIBNECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x83189F0", Offset = "0x8317DF0", VA = "0x1883189F0")]
	public static Material PPBDFEKMMCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x830B7B0", Offset = "0x830ABB0", VA = "0x18830B7B0")]
	public static Material FOIKKDLIGML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8318920", Offset = "0x8317D20", VA = "0x188318920")]
	public static Material MPAKDLLINFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8318620", Offset = "0x8317A20", VA = "0x188318620")]
	public static int APHAFAKBBIP(HHGCLPMBJBD MEABJLCPOGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8318980", Offset = "0x8317D80", VA = "0x188318980")]
	public static int OFNKFHILHOJ(PDDOBMNCGIK MHANHDANDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8318690", Offset = "0x8317A90", VA = "0x188318690")]
	public static void DCFBPHBCEIL(GameObject BLFGIKOAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x83187D0", Offset = "0x8317BD0", VA = "0x1883187D0")]
	public static void GHCDKHIFNJM(GameObject BLFGIKOAKOL, bool PIIHGGGCKGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CDGLGPHMKPK : KEOOGJDDLAC
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KMDOKODNKLK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public CDGLGPHMKPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public KMDOKODNKLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x830D650", Offset = "0x830CA50", VA = "0x18830D650", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x830D2E0", Offset = "0x830C6E0", VA = "0x18830D2E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x830D500", Offset = "0x830C900", VA = "0x18830D500")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x830D600", Offset = "0x830CA00", VA = "0x18830D600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x830D550", Offset = "0x830C950", VA = "0x18830D550", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x830D550", Offset = "0x830C950", VA = "0x18830D550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GHAIBLPNJLP ABMINGKCFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CIAMAPMHMNO ALKJCMLKMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private CANCINPMGJL BNGPAJOHGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<OOGGOALKCDA> ABIKFOCMJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<OOGGOALKCDA> MBAGIPOKLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject ENCIJKGEDAB;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8309EB0", Offset = "0x83092B0", VA = "0x188309EB0")]
	public static CDGLGPHMKPK HPPLDNJIPKP(GHAIBLPNJLP HPMNBNLACCC, CIAMAPMHMNO ALKJCMLKMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x830A760", Offset = "0x8309B60", VA = "0x18830A760")]
	private CDGLGPHMKPK(GHAIBLPNJLP HPMNBNLACCC, CIAMAPMHMNO ALKJCMLKMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x830A080", Offset = "0x8309480", VA = "0x18830A080")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x830A000", Offset = "0x8309400", VA = "0x18830A000")]
	[IteratorStateMachine(typeof(KMDOKODNKLK))]
	public IEnumerable<Renderer> KNAJIDPJPKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x83093F0", Offset = "0x83087F0", VA = "0x1883093F0", Slot = "4")]
	public void EAHLDIOCGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x83093C0", Offset = "0x83087C0", VA = "0x1883093C0")]
	private void CKJECKBJJLE(Vector3 HNHNFIPFKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x830A510", Offset = "0x8309910", VA = "0x18830A510")]
	public void ODNOMLGNGJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OOGGOALKCDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct DHFKBHLELKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DGAEOBIFNFN MEMNHMLCLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public FGCPOOOBBED ECABIDFIDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int PLAEJDEKLNG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ELGOBLKHKLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public OOGGOALKCDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public ICNEIPPCAOC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<DHFKBHLELKG> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NPAHDDNJHLF combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public ELGOBLKHKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x830A9E0", Offset = "0x8309DE0", VA = "0x18830A9E0")]
		internal JobHandle NEKAPODGPIO()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x830A840", Offset = "0x8309C40", VA = "0x18830A840")]
		internal void KEOGAEDPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x830A870", Offset = "0x8309C70", VA = "0x18830A870")]
		internal void LEFCOOHFFKG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] MCOODOEKKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private KPAMOMNGCCD PGBNNHJBEIB;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 AGBEFGBJJEE;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh COEDCAHAAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int PCAIIHPCMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9984C0", Offset = "0x9978C0", VA = "0x1809984C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x99F360", Offset = "0x99E760", VA = "0x18099F360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8316200", Offset = "0x8315600", VA = "0x188316200")]
	public void HDNEOGJIDDL(List<FGCPOOOBBED> JOBKNBKOKBI, Matrix4x4[] FHJAGKDLIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8315B70", Offset = "0x8314F70", VA = "0x188315B70")]
	public static List<OOGGOALKCDA> GNHEPACBJCH(List<GDHBHPADBLA> KODBMJLHDFE, ICNEIPPCAOC KHCIAPOHNBN, Bounds KHEPMHAMELG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8315800", Offset = "0x8314C00", VA = "0x188315800")]
	private JobHandle EIHEBIKEAGF(NPAHDDNJHLF MAKHBJOBFBK, int NOJLKOJNOOE, int EBKIEOFJOIJ, ICNEIPPCAOC KHCIAPOHNBN, List<DHFKBHLELKG> ALAFICJMEBA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x83163F0", Offset = "0x83157F0", VA = "0x1883163F0")]
	private void IKKAEPJKAMH(List<DHFKBHLELKG> ALAFICJMEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8316670", Offset = "0x8315A70", VA = "0x188316670")]
	private OOGGOALKCDA(List<DHFKBHLELKG> ALAFICJMEBA, int NOJLKOJNOOE, int EBKIEOFJOIJ, ICNEIPPCAOC KHCIAPOHNBN, Bounds KHEPMHAMELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8315760", Offset = "0x8314B60", VA = "0x188315760", Slot = "4")]
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
		private MaterialPropertyBlock KDLKIPFCFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private OOGGOALKCDA MPJNANLNCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<FGCPOOOBBED> HOFLLLMEFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture JIPKMNHAELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer PBEKHJNHDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader HAFKBCNHLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] GBAHBPMHFBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int PEELMOIBJHM;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer MONOPGLHCOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int OPDLFIDJKIE
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8319780", Offset = "0x8318B80", VA = "0x188319780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8318AB0", Offset = "0x8317EB0", VA = "0x188318AB0")]
		public static List<SkinnedShapeRenderer> Create(GameObject BKHMOJGGBFN, List<OOGGOALKCDA> CIJMELELIGD, List<FGCPOOOBBED> HOFLLLMEFDN, Material ANOGJJADLNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8319170", Offset = "0x8318570", VA = "0x188319170")]
		public void Init(OOGGOALKCDA MPJNANLNCGP, List<FGCPOOOBBED> HOFLLLMEFDN, Material ANOGJJADLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x83196E0", Offset = "0x8318AE0", VA = "0x1883196E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8319640", Offset = "0x8318A40", VA = "0x188319640")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8319600", Offset = "0x8318A00", VA = "0x188319600")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x83190B0", Offset = "0x83184B0", VA = "0x1883190B0")]
		private void HMKINEPGJLJ(ScriptableRenderContext PCJJKLDOJMD, Camera[] NHFFEEAAFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8318D40", Offset = "0x8318140", VA = "0x188318D40")]
		private void HDNEOGJIDDL(CommandBuffer HJJDDDEIKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
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
