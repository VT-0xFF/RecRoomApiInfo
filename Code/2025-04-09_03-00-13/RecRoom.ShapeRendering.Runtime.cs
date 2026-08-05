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
		[Cpp2IlInjected.Address(RVA = "0x8358840", Offset = "0x8357C40", VA = "0x188358840", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x83644F0", Offset = "0x83638F0", VA = "0x1883644F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3D410", Offset = "0xB3C810", VA = "0x180B3D410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBEB2C0", Offset = "0xBEA6C0", VA = "0x180BEB2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JBACHKAOKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC6FB60", Offset = "0xC6EF60", VA = "0x180C6FB60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE4ACB0", Offset = "0xE4A0B0", VA = "0x180E4ACB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float ODEGOMADFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE5C2C0", Offset = "0xE5B6C0", VA = "0x180E5C2C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x11CC860", Offset = "0x11CBC60", VA = "0x1811CC860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float FAMEKLILKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBB5860", Offset = "0xBB4C60", VA = "0x180BB5860", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBB5870", Offset = "0xBB4C70", VA = "0x180BB5870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> CBAGMCFJBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8353500", Offset = "0x8352900", VA = "0x188353500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> IJGIAJJLOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8353960", Offset = "0x8352D60", VA = "0x188353960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject HLJCJLLDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte CKLHJAIKFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8353690", Offset = "0x8352A90", VA = "0x188353690", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8353990", Offset = "0x8352D90", VA = "0x188353990")]
	public CANCINPMGJL(List<OOGGOALKCDA> PAKPDBFMJAK, List<OOGGOALKCDA> KCHHJOAGBDN, List<FGCPOOOBBED> HOFLLLMEFDN, Material ANOGJJADLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83536E0", Offset = "0x8352AE0", VA = "0x1883536E0")]
	private int GGBILADAFKN(List<OOGGOALKCDA> CIJMELELIGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8353800", Offset = "0x8352C00", VA = "0x188353800")]
	private void JKPIFOLOELF(int IOEGCIEAANI, bool HLCLADEIGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x83533B0", Offset = "0x83527B0", VA = "0x1883533B0")]
	public void BFNGEGLLGHK(Vector3 HNHNFIPFKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8353550", Offset = "0x8352950", VA = "0x188353550", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8353650", Offset = "0x8352A50", VA = "0x188353650")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public LNFPLDBMKNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8358650", Offset = "0x8357A50", VA = "0x188358650", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8357FA0", Offset = "0x83573A0", VA = "0x188357FA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8358500", Offset = "0x8357900", VA = "0x188358500")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83584B0", Offset = "0x83578B0", VA = "0x1883584B0")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8357F50", Offset = "0x8357350", VA = "0x188357F50")]
		private void KLNIOFJAILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8358600", Offset = "0x8357A00", VA = "0x188358600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8358550", Offset = "0x8357950", VA = "0x188358550", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8358550", Offset = "0x8357950", VA = "0x188358550", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public JDKOCKGKOJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8357A20", Offset = "0x8356E20", VA = "0x188357A20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8357510", Offset = "0x8356910", VA = "0x188357510", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83578D0", Offset = "0x8356CD0", VA = "0x1883578D0")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8357880", Offset = "0x8356C80", VA = "0x188357880")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83579D0", Offset = "0x8356DD0", VA = "0x1883579D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8357920", Offset = "0x8356D20", VA = "0x188357920", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8357920", Offset = "0x8356D20", VA = "0x188357920", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AJJLAFEKENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8356810", Offset = "0x8355C10", VA = "0x188356810", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FGCPOOOBBED JFMJBACEBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83560B0", Offset = "0x83554B0", VA = "0x1883560B0", Slot = "8")]
		get
		{
			return default(FGCPOOOBBED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PGNDNCJEALN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3D0", Offset = "0x9A97D0", VA = "0x1809AA3D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8356AE0", Offset = "0x8355EE0", VA = "0x188356AE0")]
	private bool ONPPLALGGKL(BKKIPANPFKC KFBPKKLDJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8356850", Offset = "0x8355C50", VA = "0x188356850")]
	private static bool NMJMIBNPAKK(BKKIPANPFKC KFBPKKLDJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8356C50", Offset = "0x8356050", VA = "0x188356C50")]
	public GDHBHPADBLA(AAMGODPHIMC HPMNBNLACCC, bool HBPLPIBFALL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83558A0", Offset = "0x8354CA0", VA = "0x1883558A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x83562D0", Offset = "0x83556D0", VA = "0x1883562D0")]
	public void JJBKLNLGAIJ(BKKIPANPFKC KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8356170", Offset = "0x8355570", VA = "0x188356170")]
	public void JEBJOEBLLEI(BKKIPANPFKC KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8355A90", Offset = "0x8354E90", VA = "0x188355A90", Slot = "4")]
	public void EAHLDIOCGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8356870", Offset = "0x8355C70", VA = "0x188356870")]
	public void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x83565A0", Offset = "0x83559A0", VA = "0x1883565A0")]
	private void MBOOODDOMBE(List<BKKIPANPFKC> FGOGECEFJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8356050", Offset = "0x8355450", VA = "0x188356050")]
	private static Material FOIKKDLIGML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8356760", Offset = "0x8355B60", VA = "0x188356760")]
	private void MBOOODDOMBE(BKKIPANPFKC KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8356B80", Offset = "0x8355F80", VA = "0x188356B80")]
	private void PMJOEBEIMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x83552F0", Offset = "0x83546F0", VA = "0x1883552F0")]
	public void CILBHAHGNEE(bool LPJNGLCJMLB, bool JNNPLIPIKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8355F90", Offset = "0x8355390", VA = "0x188355F90")]
	protected void EMGJLCIGDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8356B00", Offset = "0x8355F00", VA = "0x188356B00")]
	public void PEJCDCNJBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8356520", Offset = "0x8355920", VA = "0x188356520")]
	[IteratorStateMachine(typeof(LNFPLDBMKNC))]
	public IEnumerable<Renderer> KNAJIDPJPKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x83564A0", Offset = "0x83558A0", VA = "0x1883564A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8358990", Offset = "0x8357D90", VA = "0x188358990")]
		public MCJGNDGNALA(NPAHDDNJHLF MPJNANLNCGP, JobHandle CNINKJDDJFJ, AOGKFLEKIMN PGKCGEIFNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8358910", Offset = "0x8357D10", VA = "0x188358910", Slot = "4")]
		public NPAHDDNJHLF CKDFENAGPAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8358940", Offset = "0x8357D40", VA = "0x188358940", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x835B7E0", Offset = "0x835ABE0", VA = "0x18835B7E0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x835C950", Offset = "0x835BD50", VA = "0x18835C950")]
	public OBPHLGOJBKH(GDHBHPADBLA BKHMOJGGBFN, CAJIMFNGHMB HPMNBNLACCC, bool HBPLPIBFALL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "18")]
	public override bool MHJHFDDDDHL(FGCPOOOBBED BKHMOJGGBFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x835B460", Offset = "0x835A860", VA = "0x18835B460", Slot = "19")]
	public override int GGBILADAFKN(ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x835B900", Offset = "0x835AD00", VA = "0x18835B900", Slot = "20")]
	public override int LKAIIMFAOFF(ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x835B020", Offset = "0x835A420", VA = "0x18835B020", Slot = "21")]
	public override HNGCCHGLKLA ABFMHHFLODO()
	{
		return default(HNGCCHGLKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xB630E0", Offset = "0xB624E0", VA = "0x180B630E0", Slot = "22")]
	public override float MJFKKBELHPD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x835C360", Offset = "0x835B760", VA = "0x18835C360", Slot = "23")]
	public override void OCKBJECCOCD(ICNEIPPCAOC KHCIAPOHNBN, DGAEOBIFNFN MPFLNIDPMNK, int KJNAJBBMMJJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x835C290", Offset = "0x835B690", VA = "0x18835C290", Slot = "24")]
	public override FGCPOOOBBED MPNBKLHNMPH()
	{
		return default(FGCPOOOBBED);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x835B630", Offset = "0x835AA30", VA = "0x18835B630", Slot = "26")]
	public override LAOGPDALMBH GMENIDFFBCM()
	{
		return default(LAOGPDALMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x835BAD0", Offset = "0x835AED0", VA = "0x18835BAD0", Slot = "27")]
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
		[Cpp2IlInjected.Address(RVA = "0x8356D40", Offset = "0x8356140", VA = "0x188356D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83572A0", Offset = "0x83566A0", VA = "0x1883572A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x835CF90", Offset = "0x835C390", VA = "0x18835CF90", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BKKIPANPFKC JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x835CF30", Offset = "0x835C330", VA = "0x18835CF30", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CDGLGPHMKPK JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x835CFF0", Offset = "0x835C3F0", VA = "0x18835CFF0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PJPDFLJAPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD0E7C0", Offset = "0xD0DBC0", VA = "0x180D0E7C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA2A290", Offset = "0xA29690", VA = "0x180A2A290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x835EB50", Offset = "0x835DF50", VA = "0x18835EB50")]
	public OGLFPKLANON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x835D810", Offset = "0x835CC10", VA = "0x18835D810", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x835CF20", Offset = "0x835C320", VA = "0x18835CF20", Slot = "4")]
	public OIICOGMNAJO BDCGACPGOID(AAMGODPHIMC HPMNBNLACCC)
	{
		return default(OIICOGMNAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x835CCB0", Offset = "0x835C0B0", VA = "0x18835CCB0", Slot = "5")]
	public OIICOGMNAJO BDCGACPGOID(AAMGODPHIMC HPMNBNLACCC, bool HBPLPIBFALL)
	{
		return default(OIICOGMNAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x835D550", Offset = "0x835C950", VA = "0x18835D550", Slot = "6")]
	public void CLDLMMCILAA(OIICOGMNAJO BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x835D210", Offset = "0x835C610", VA = "0x18835D210", Slot = "7")]
	public void CEJMBKEPGGA(OIICOGMNAJO BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x835DD70", Offset = "0x835D170", VA = "0x18835DD70", Slot = "8")]
	public LCIMFKFFNPO GMDPAAENKIG(OIICOGMNAJO BKHMOJGGBFN, JKEFCPMGAAL HPMNBNLACCC)
	{
		return default(LCIMFKFFNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x835E690", Offset = "0x835DA90", VA = "0x18835E690", Slot = "9")]
	public LCIMFKFFNPO PIAEENMNGEA(OIICOGMNAJO BKHMOJGGBFN, CAJIMFNGHMB HPMNBNLACCC)
	{
		return default(LCIMFKFFNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x835D9D0", Offset = "0x835CDD0", VA = "0x18835D9D0", Slot = "11")]
	public void GLMDKGPPDMK(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x835CA00", Offset = "0x835BE00", VA = "0x18835CA00", Slot = "10")]
	public void AIFKHDKINLG(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x835E620", Offset = "0x835DA20", VA = "0x18835E620", Slot = "20")]
	public IEnumerable<Renderer> LLLGJLOHBHF(OIICOGMNAJO BKHMOJGGBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x835E230", Offset = "0x835D630", VA = "0x18835E230", Slot = "12")]
	public LHCPDKENODA IEONHDNNILK(GHAIBLPNJLP HPMNBNLACCC)
	{
		return default(LHCPDKENODA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x835D7A0", Offset = "0x835CBA0", VA = "0x18835D7A0", Slot = "14")]
	public void DKIGEBNPFKE(LHCPDKENODA BKNPBBIMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x835D050", Offset = "0x835C450", VA = "0x18835D050", Slot = "16")]
	public Task BKMBIOKHNFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x835E3A0", Offset = "0x835D7A0", VA = "0x18835E3A0", Slot = "17")]
	public Task LCICLGADGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x835E550", Offset = "0x835D950", VA = "0x18835E550", Slot = "18")]
	[AsyncStateMachine(typeof(GMHBGONBACB))]
	public Task LEHGKIFIMMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x835E2B0", Offset = "0x835D6B0", VA = "0x18835E2B0", Slot = "19")]
	public void JNLLFPJCFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x835CC50", Offset = "0x835C050", VA = "0x18835CC50", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x8358AF0", Offset = "0x8357EF0", VA = "0x188358AF0")]
		public MHBPECMEADA(NPAHDDNJHLF MPJNANLNCGP, NativeArray<int> DKNKMOMIJJH, JobHandle CNINKJDDJFJ, FBADIPMGPKH PGKCGEIFNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83589F0", Offset = "0x8357DF0", VA = "0x1883589F0", Slot = "4")]
		public NPAHDDNJHLF CKDFENAGPAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8358A50", Offset = "0x8357E50", VA = "0x188358A50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x83591F0", Offset = "0x83585F0", VA = "0x1883591F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 ELCGNOKCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8359B00", Offset = "0x8358F00", VA = "0x188359B00", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x835AF70", Offset = "0x835A370", VA = "0x18835AF70")]
	public NLECKLHHPEC(GDHBHPADBLA BKHMOJGGBFN, JKEFCPMGAAL HPMNBNLACCC, bool DGMGNKHMCHH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x835A4A0", Offset = "0x83598A0", VA = "0x18835A4A0", Slot = "18")]
	public override bool MHJHFDDDDHL(FGCPOOOBBED BKHMOJGGBFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8358B50", Offset = "0x8357F50", VA = "0x188358B50", Slot = "21")]
	public override HNGCCHGLKLA ABFMHHFLODO()
	{
		return default(HNGCCHGLKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8358B90", Offset = "0x8357F90", VA = "0x188358B90")]
	private HNGCCHGLKLA ABFMHHFLODO(FGCPOOOBBED BKHMOJGGBFN)
	{
		return default(HNGCCHGLKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8359420", Offset = "0x8358820", VA = "0x188359420")]
	private BBNNPFMJANI CKGMFDDIJDH([In] UniformTRS PFGIMHAADBH, [In] float3 GGIGFLDDKFE)
	{
		return default(BBNNPFMJANI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x83598A0", Offset = "0x8358CA0", VA = "0x1883598A0", Slot = "19")]
	public override int GGBILADAFKN(ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8359C20", Offset = "0x8359020", VA = "0x188359C20", Slot = "20")]
	public override int LKAIIMFAOFF(ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x835A570", Offset = "0x8359970", VA = "0x18835A570", Slot = "22")]
	public override float MJFKKBELHPD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8359620", Offset = "0x8358A20", VA = "0x188359620")]
	private int FNIKOBEDGAO(ICNEIPPCAOC KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x835A730", Offset = "0x8359B30", VA = "0x18835A730", Slot = "23")]
	public override void OCKBJECCOCD(ICNEIPPCAOC KHCIAPOHNBN, DGAEOBIFNFN MPFLNIDPMNK, int KJNAJBBMMJJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x835A660", Offset = "0x8359A60", VA = "0x18835A660", Slot = "24")]
	public override FGCPOOOBBED MPNBKLHNMPH()
	{
		return default(FGCPOOOBBED);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8359950", Offset = "0x8358D50", VA = "0x188359950", Slot = "26")]
	public override LAOGPDALMBH GMENIDFFBCM()
	{
		return default(LAOGPDALMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8359CD0", Offset = "0x83590D0", VA = "0x188359CD0", Slot = "27")]
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
		[Cpp2IlInjected.Address(RVA = "0x83574C0", Offset = "0x83568C0", VA = "0x1883574C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9B9340", Offset = "0x9B8740", VA = "0x1809B9340")]
	public BDELEEEGBNG(IBPDFOLLEPB LBDEADMEFAB, CIAMAPMHMNO ALKJCMLKMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x83513D0", Offset = "0x83507D0", VA = "0x1883513D0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8352C10", Offset = "0x8352010", VA = "0x188352C10")]
	private void MOJKFCJCICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8352550", Offset = "0x8351950", VA = "0x188352550", Slot = "4")]
	public void JOIPHILJOMC(OIICOGMNAJO BKHMOJGGBFN, NIBPFMHDCCB DOPPEDALNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8352860", Offset = "0x8351C60", VA = "0x188352860", Slot = "5")]
	public void JOIPHILJOMC(LCIMFKFFNPO KFBPKKLDJOM, NIBPFMHDCCB DOPPEDALNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8351150", Offset = "0x8350550", VA = "0x188351150", Slot = "6")]
	public void DGHNIMAGIAA(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8352A80", Offset = "0x8351E80", VA = "0x188352A80", Slot = "7")]
	public void KBEEMENKACM(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8352BD0", Offset = "0x8351FD0", VA = "0x188352BD0", Slot = "24")]
	public void LMJOPGHOIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xFB38A0", Offset = "0xFB2CA0", VA = "0x180FB38A0", Slot = "8")]
	public void NPDPCNJIEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8351A00", Offset = "0x8350E00", VA = "0x188351A00", Slot = "9")]
	public void GNCHCKBHMNF(NIBPFMHDCCB DOPPEDALNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8351B70", Offset = "0x8350F70", VA = "0x188351B70", Slot = "10")]
	public void HCJFCKKOLGD(OIICOGMNAJO BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8351E50", Offset = "0x8351250", VA = "0x188351E50", Slot = "11")]
	public void HCJFCKKOLGD(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8350840", Offset = "0x834FC40", VA = "0x188350840", Slot = "12")]
	public void AKDEIDFIMFK(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x83530F0", Offset = "0x83524F0", VA = "0x1883530F0", Slot = "13")]
	public void PIIFPNHMFMD(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8352E80", Offset = "0x8352280", VA = "0x188352E80")]
	private void OHCLILBJFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x12027C0", Offset = "0x1201BC0", VA = "0x1812027C0", Slot = "14")]
	public void KEADOEOBNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x83512B0", Offset = "0x83506B0", VA = "0x1883512B0", Slot = "15")]
	public void DJENGIOOMJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8351650", Offset = "0x8350A50", VA = "0x188351650", Slot = "16")]
	public void FIPHMFGBKPJ(OIICOGMNAJO BKHMOJGGBFN, GPFFCLEGEBK HAFNBBNOLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8351580", Offset = "0x8350980", VA = "0x188351580", Slot = "17")]
	public void FHFNJIFJAMN(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8351930", Offset = "0x8350D30", VA = "0x188351930", Slot = "18")]
	public void GKKCDAGJKNE(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xBF3000", Offset = "0xBF2400", VA = "0x180BF3000", Slot = "19")]
	public void NNAOLBPIFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8352420", Offset = "0x8351820", VA = "0x188352420", Slot = "20")]
	public void HNNJHOLJEOG(GPFFCLEGEBK HAFNBBNOLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x83521B0", Offset = "0x83515B0", VA = "0x1883521B0")]
	private void HNDDLOBNJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8350D90", Offset = "0x8350190", VA = "0x188350D90", Slot = "21")]
	public void BBPFKMIFFEE(OIICOGMNAJO BKHMOJGGBFN, Vector3 HBNIPOIBKCA, Vector3 EGLCALKIHPA, Vector3 MMCDLCPIFGA, float GELFBGAEFJG, float GHACIECNEBE, IReadOnlyList<Camera> OMEAFEJKMKE, HKJGGLJBOND DPGMLKFBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8350910", Offset = "0x834FD10", VA = "0x188350910", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x8353390", Offset = "0x8352790", VA = "0x188353390", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool NPCKOPKICNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xCC3480", Offset = "0xCC2880", VA = "0x180CC3480")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCC34D0", Offset = "0xCC28D0", VA = "0x180CC34D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB232D0", Offset = "0xB226D0", VA = "0x180B232D0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public PJDFJLBDFNH BNCFFNCKIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3D0", Offset = "0x9A97D0", VA = "0x1809AA3D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BKDABDPFJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xDE6F80", Offset = "0xDE6380", VA = "0x180DE6F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	protected BKKIPANPFKC(GDHBHPADBLA BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8353200", Offset = "0x8352600", VA = "0x188353200", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "18")]
	public virtual bool MHJHFDDDDHL(FGCPOOOBBED BKHMOJGGBFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x83531C0", Offset = "0x83525C0", VA = "0x1883531C0", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x8353360", Offset = "0x8352760", VA = "0x188353360", Slot = "13")]
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
	[Cpp2IlInjected.Address(RVA = "0x83531D0", Offset = "0x83525D0", VA = "0x1883531D0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x8363060", Offset = "0x8362460", VA = "0x188363060")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public HJGEJPHPEAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8357300", Offset = "0x8356700", VA = "0x188357300", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8357470", Offset = "0x8356870", VA = "0x188357470", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x83573D0", Offset = "0x83567D0", VA = "0x1883573D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MNAEPDHFLLD> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x83573D0", Offset = "0x83567D0", VA = "0x1883573D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8362990", Offset = "0x8361D90", VA = "0x188362990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer OPCBPEFINLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8362B00", Offset = "0x8361F00", VA = "0x188362B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8362890", Offset = "0x8361C90", VA = "0x188362890")]
	[FHKEPBLDBGP]
	internal static void GDCNGOALEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8362A60", Offset = "0x8361E60", VA = "0x188362A60")]
	public static Mesh OFIODFFHGEB(NANCINDJPCK FADEBALCHMH, int KHCIAPOHNBN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8362A50", Offset = "0x8361E50", VA = "0x188362A50")]
	public static int MHBNILNGPLH(NANCINDJPCK FADEBALCHMH, int KHCIAPOHNBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x83614C0", Offset = "0x83608C0", VA = "0x1883614C0")]
	public static EPHIBHKBNBB CEICIGKNDOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x83629F0", Offset = "0x8361DF0", VA = "0x1883629F0")]
	[IteratorStateMachine(typeof(HJGEJPHPEAB))]
	private static IEnumerable<MNAEPDHFLLD> LPJOGLECJMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x83616C0", Offset = "0x8360AC0", VA = "0x1883616C0")]
	public static MNAEPDHFLLD DNPGOOMPJCE(NANCINDJPCK FADEBALCHMH, int KHCIAPOHNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8362970", Offset = "0x8361D70", VA = "0x188362970")]
	public static bool IBCFAHCMMNE(this NANCINDJPCK FADEBALCHMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8361310", Offset = "0x8360710", VA = "0x188361310")]
	public static void CDGGPNAKHMD(NANCINDJPCK FADEBALCHMH, float3 OMKIJJKNFPK, [Out] GBCJNLMIOKP DFHOKIAKIAN, [Out] float3 FJJKOFIKEKO, [Out] float DBDKKAAHGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x83624D0", Offset = "0x83618D0", VA = "0x1883624D0")]
	public static void DOLBEJAIGMI(Vector3 OMKIJJKNFPK, NANCINDJPCK FADEBALCHMH, [Out] Vector3 FJJKOFIKEKO, [Out] float DBDKKAAHGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8361300", Offset = "0x8360700", VA = "0x188361300")]
	[KLOGBONICBD(0)]
	[IDEKGKHHECE(MPEIPIAKFID.ExitingPlayMode, 0)]
	private static void BJMOABIBOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8361140", Offset = "0x8360540", VA = "0x188361140")]
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
		[Cpp2IlInjected.Address(RVA = "0x835F1F0", Offset = "0x835E5F0", VA = "0x18835F1F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public BKKIPANPFKC JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x835F130", Offset = "0x835E530", VA = "0x18835F130", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public CDGLGPHMKPK JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x835F190", Offset = "0x835E590", VA = "0x18835F190", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PJPDFLJAPAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xD0E7C0", Offset = "0xD0DBC0", VA = "0x180D0E7C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA2A290", Offset = "0xA29690", VA = "0x180A2A290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x835FA90", Offset = "0x835EE90", VA = "0x18835FA90")]
	public OIBJNDDFHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x835F440", Offset = "0x835E840", VA = "0x18835F440", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x835F090", Offset = "0x835E490", VA = "0x18835F090", Slot = "4")]
	public OIICOGMNAJO BDCGACPGOID(AAMGODPHIMC HPMNBNLACCC)
	{
		return default(OIICOGMNAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x835F090", Offset = "0x835E490", VA = "0x18835F090", Slot = "5")]
	public OIICOGMNAJO BDCGACPGOID(AAMGODPHIMC HPMNBNLACCC, bool HBPLPIBFALL)
	{
		return default(OIICOGMNAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x835F370", Offset = "0x835E770", VA = "0x18835F370", Slot = "6")]
	public void CLDLMMCILAA(OIICOGMNAJO BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x835F2F0", Offset = "0x835E6F0", VA = "0x18835F2F0", Slot = "7")]
	public void CEJMBKEPGGA(OIICOGMNAJO BKHMOJGGBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x835F560", Offset = "0x835E960", VA = "0x18835F560", Slot = "8")]
	public LCIMFKFFNPO GMDPAAENKIG(OIICOGMNAJO BKHMOJGGBFN, JKEFCPMGAAL HPMNBNLACCC)
	{
		return default(LCIMFKFFNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x835F8D0", Offset = "0x835ECD0", VA = "0x18835F8D0", Slot = "9")]
	public LCIMFKFFNPO PIAEENMNGEA(OIICOGMNAJO BKHMOJGGBFN, CAJIMFNGHMB HPMNBNLACCC)
	{
		return default(LCIMFKFFNPO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x835F4D0", Offset = "0x835E8D0", VA = "0x18835F4D0", Slot = "11")]
	public void GLMDKGPPDMK(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x835EFD0", Offset = "0x835E3D0", VA = "0x18835EFD0", Slot = "10")]
	public void AIFKHDKINLG(LCIMFKFFNPO KFBPKKLDJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x835F860", Offset = "0x835EC60", VA = "0x18835F860", Slot = "20")]
	public IEnumerable<Renderer> LLLGJLOHBHF(OIICOGMNAJO BKHMOJGGBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x835F6A0", Offset = "0x835EAA0", VA = "0x18835F6A0", Slot = "12")]
	public LHCPDKENODA IEONHDNNILK(GHAIBLPNJLP HPMNBNLACCC)
	{
		return default(LHCPDKENODA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x835F3D0", Offset = "0x835E7D0", VA = "0x18835F3D0", Slot = "14")]
	public void DKIGEBNPFKE(LHCPDKENODA BKNPBBIMBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x835F250", Offset = "0x835E650", VA = "0x18835F250", Slot = "16")]
	public Task BKMBIOKHNFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x835F720", Offset = "0x835EB20", VA = "0x18835F720", Slot = "17")]
	public Task LCICLGADGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x835F7C0", Offset = "0x835EBC0", VA = "0x18835F7C0", Slot = "18")]
	public Task LEHGKIFIMMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x25814A0", Offset = "0x25808A0", VA = "0x1825814A0", Slot = "19")]
	public void JNLLFPJCFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x835F030", Offset = "0x835E430", VA = "0x18835F030", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x8362DA0", Offset = "0x83621A0", VA = "0x188362DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8362EE0", Offset = "0x83622E0", VA = "0x188362EE0")]
	public static void HGAGNPOAEEP(FDGALIPDLDL IEGGKIBNECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8363000", Offset = "0x8362400", VA = "0x188363000")]
	public static Material PPBDFEKMMCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8356050", Offset = "0x8355450", VA = "0x188356050")]
	public static Material FOIKKDLIGML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8362F30", Offset = "0x8362330", VA = "0x188362F30")]
	public static Material MPAKDLLINFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8362C50", Offset = "0x8362050", VA = "0x188362C50")]
	public static int APHAFAKBBIP(HHGCLPMBJBD MEABJLCPOGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8362F90", Offset = "0x8362390", VA = "0x188362F90")]
	public static int OFNKFHILHOJ(PDDOBMNCGIK MHANHDANDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8362CC0", Offset = "0x83620C0", VA = "0x188362CC0")]
	public static void DCFBPHBCEIL(GameObject BLFGIKOAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8362E00", Offset = "0x8362200", VA = "0x188362E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xDEB050", Offset = "0xDEA450", VA = "0x180DEB050")]
		[DebuggerHidden]
		public KMDOKODNKLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8357EC0", Offset = "0x83572C0", VA = "0x188357EC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8357B50", Offset = "0x8356F50", VA = "0x188357B50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8357D70", Offset = "0x8357170", VA = "0x188357D70")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8357E70", Offset = "0x8357270", VA = "0x188357E70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8357DC0", Offset = "0x83571C0", VA = "0x188357DC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8357DC0", Offset = "0x83571C0", VA = "0x188357DC0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x8354770", Offset = "0x8353B70", VA = "0x188354770")]
	public static CDGLGPHMKPK HPPLDNJIPKP(GHAIBLPNJLP HPMNBNLACCC, CIAMAPMHMNO ALKJCMLKMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8355010", Offset = "0x8354410", VA = "0x188355010")]
	private CDGLGPHMKPK(GHAIBLPNJLP HPMNBNLACCC, CIAMAPMHMNO ALKJCMLKMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8354940", Offset = "0x8353D40", VA = "0x188354940")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x83548C0", Offset = "0x8353CC0", VA = "0x1883548C0")]
	[IteratorStateMachine(typeof(KMDOKODNKLK))]
	public IEnumerable<Renderer> KNAJIDPJPKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8353CD0", Offset = "0x83530D0", VA = "0x188353CD0", Slot = "4")]
	public void EAHLDIOCGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8353CA0", Offset = "0x83530A0", VA = "0x188353CA0")]
	private void CKJECKBJJLE(Vector3 HNHNFIPFKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8354DC0", Offset = "0x83541C0", VA = "0x188354DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ELGOBLKHKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8355290", Offset = "0x8354690", VA = "0x188355290")]
		internal JobHandle NEKAPODGPIO()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x83550F0", Offset = "0x83544F0", VA = "0x1883550F0")]
		internal void KEOGAEDPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8355120", Offset = "0x8354520", VA = "0x188355120")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int PCAIIHPCMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9B51D0", Offset = "0x9B45D0", VA = "0x1809B51D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x83608D0", Offset = "0x835FCD0", VA = "0x1883608D0")]
	public void HDNEOGJIDDL(List<FGCPOOOBBED> JOBKNBKOKBI, Matrix4x4[] FHJAGKDLIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8360240", Offset = "0x835F640", VA = "0x188360240")]
	public static List<OOGGOALKCDA> GNHEPACBJCH(List<GDHBHPADBLA> KODBMJLHDFE, ICNEIPPCAOC KHCIAPOHNBN, Bounds KHEPMHAMELG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x835FEE0", Offset = "0x835F2E0", VA = "0x18835FEE0")]
	private JobHandle EIHEBIKEAGF(NPAHDDNJHLF MAKHBJOBFBK, int NOJLKOJNOOE, int EBKIEOFJOIJ, ICNEIPPCAOC KHCIAPOHNBN, List<DHFKBHLELKG> ALAFICJMEBA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8360AB0", Offset = "0x835FEB0", VA = "0x188360AB0")]
	private void IKKAEPJKAMH(List<DHFKBHLELKG> ALAFICJMEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8360D20", Offset = "0x8360120", VA = "0x188360D20")]
	private OOGGOALKCDA(List<DHFKBHLELKG> ALAFICJMEBA, int NOJLKOJNOOE, int EBKIEOFJOIJ, ICNEIPPCAOC KHCIAPOHNBN, Bounds KHEPMHAMELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x835FE50", Offset = "0x835F250", VA = "0x18835FE50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int OPDLFIDJKIE
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8363D90", Offset = "0x8363190", VA = "0x188363D90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x83630C0", Offset = "0x83624C0", VA = "0x1883630C0")]
		public static List<SkinnedShapeRenderer> Create(GameObject BKHMOJGGBFN, List<OOGGOALKCDA> CIJMELELIGD, List<FGCPOOOBBED> HOFLLLMEFDN, Material ANOGJJADLNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8363780", Offset = "0x8362B80", VA = "0x188363780")]
		public void Init(OOGGOALKCDA MPJNANLNCGP, List<FGCPOOOBBED> HOFLLLMEFDN, Material ANOGJJADLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8363CF0", Offset = "0x83630F0", VA = "0x188363CF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8363C50", Offset = "0x8363050", VA = "0x188363C50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8363C10", Offset = "0x8363010", VA = "0x188363C10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x83636C0", Offset = "0x8362AC0", VA = "0x1883636C0")]
		private void HMKINEPGJLJ(ScriptableRenderContext PCJJKLDOJMD, Camera[] NHFFEEAAFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8363350", Offset = "0x8362750", VA = "0x188363350")]
		private void HDNEOGJIDDL(CommandBuffer HJJDDDEIKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
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
