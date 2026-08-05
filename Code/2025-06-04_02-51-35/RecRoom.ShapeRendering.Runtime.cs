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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4630", Offset = "0x8AC2E30", VA = "0x188AC4630", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AC7670", Offset = "0x8AC5E70", VA = "0x188AC7670", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AMOHKGFOIAN : DCJLEKJKGAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte NEJCNHFCHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] BAGEAHKEMPD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HMDKAFFLCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LJNNKFODMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float FMAHMDFACHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF047C0", Offset = "0xF02FC0", VA = "0x180F047C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x13CE520", Offset = "0x13CCD20", VA = "0x1813CE520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float IDLAIJIIGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCD8F80", Offset = "0xCD7780", VA = "0x180CD8F80", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCD8F90", Offset = "0xCD7790", VA = "0x180CD8F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> PJLAMOALBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4180", Offset = "0x8AB2980", VA = "0x188AB4180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> LEBKJEFHFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4030", Offset = "0x8AB2830", VA = "0x188AB4030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject LCHPFLHNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte KEIELLOJGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8AB3D30", Offset = "0x8AB2530", VA = "0x188AB3D30", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8AB41D0", Offset = "0x8AB29D0", VA = "0x188AB41D0")]
	public AMOHKGFOIAN(List<LFLIPPJJJBP> CDHKFJFGLLL, List<LFLIPPJJJBP> IADLOPGALGK, List<HOAIPFDEDJB> HHELPIMKKJE, Material IPKNLMFNGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4060", Offset = "0x8AB2860", VA = "0x188AB4060")]
	private int NCDJJGEGGIE(List<LFLIPPJJJBP> IEIEGKJHFNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8AB3D80", Offset = "0x8AB2580", VA = "0x188AB3D80")]
	private void IJCAPJELJJF(int DJCNKMNKFBC, bool CICNLBIFCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8AB3EE0", Offset = "0x8AB26E0", VA = "0x188AB3EE0")]
	public void KCLBJHKLNBO(Vector3 BCNNFBOLBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8AB3C30", Offset = "0x8AB2430", VA = "0x188AB3C30", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8AB3BF0", Offset = "0x8AB23F0", VA = "0x188AB3BF0")]
	public void BDKJCIDEMGB(Transform IGOEBFONBIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EEIAAAALDHJ : MBCAECIEONI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KCGMBHOJGCP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EEIAAAALDHJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public KCGMBHOJGCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF1A0", Offset = "0x8ABD9A0", VA = "0x188ABF1A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEB90", Offset = "0x8ABD390", VA = "0x188ABEB90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEAF0", Offset = "0x8ABD2F0", VA = "0x188ABEAF0")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEAA0", Offset = "0x8ABD2A0", VA = "0x188ABEAA0")]
		private void CLFKDHFELPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEB40", Offset = "0x8ABD340", VA = "0x188ABEB40")]
		private void GBGEKOEGDJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF150", Offset = "0x8ABD950", VA = "0x188ABF150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF0A0", Offset = "0x8ABD8A0", VA = "0x188ABF0A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF0A0", Offset = "0x8ABD8A0", VA = "0x188ABF0A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GFMOJPAODAP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EEIAAAALDHJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public GFMOJPAODAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC6B0", Offset = "0x8ABAEB0", VA = "0x188ABC6B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC240", Offset = "0x8ABAA40", VA = "0x188ABC240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC1F0", Offset = "0x8ABA9F0", VA = "0x188ABC1F0")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC1A0", Offset = "0x8ABA9A0", VA = "0x188ABC1A0")]
		private void CLFKDHFELPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC660", Offset = "0x8ABAE60", VA = "0x188ABC660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC5B0", Offset = "0x8ABADB0", VA = "0x188ABC5B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC5B0", Offset = "0x8ABADB0", VA = "0x188ABC5B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NKCLKODHAAP PGLDAGHMLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<AHAOBADKPGL> DIPDHIOIFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> FBJAIEELCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer OHGGPIHOFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool JPNPEKFDBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool NMFJBKGGHHA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<MGCOKLMPKHE> LNKFBMFPGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EMCBKINGPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB700", Offset = "0x8AB9F00", VA = "0x188ABB700", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HOAIPFDEDJB KKLDPGINFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABAD80", Offset = "0x8AB9580", VA = "0x188ABAD80", Slot = "8")]
		get
		{
			return default(HOAIPFDEDJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> PKLINFKIJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABB740", Offset = "0x8AB9F40", VA = "0x188ABB740")]
	private bool HJFNKEIKDGL(AHAOBADKPGL GOMGOEKJPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8ABB6E0", Offset = "0x8AB9EE0", VA = "0x188ABB6E0")]
	private static bool HBJHCHOLHPH(AHAOBADKPGL GOMGOEKJPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8ABC0B0", Offset = "0x8ABA8B0", VA = "0x188ABC0B0")]
	public EEIAAAALDHJ(NKCLKODHAAP IMINNNCPCJF, bool DNAHMNCICPA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8ABAF60", Offset = "0x8AB9760", VA = "0x188ABAF60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8ABB510", Offset = "0x8AB9D10", VA = "0x188ABB510")]
	public void GGGBGBDKNKJ(AHAOBADKPGL GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8ABB760", Offset = "0x8AB9F60", VA = "0x188ABB760")]
	public void HKOLMKDGPPH(AHAOBADKPGL GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8ABB8C0", Offset = "0x8ABA0C0", VA = "0x188ABB8C0", Slot = "4")]
	public void IGMGJBAHCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8ABBDC0", Offset = "0x8ABA5C0", VA = "0x188ABBDC0")]
	public void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8ABB220", Offset = "0x8AB9A20", VA = "0x188ABB220")]
	private void FAOBHIPEAMN(List<AHAOBADKPGL> DIPDHIOIFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8ABAF00", Offset = "0x8AB9700", VA = "0x188ABAF00")]
	private static Material DCCPMPJIBPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8ABB3E0", Offset = "0x8AB9BE0", VA = "0x188ABB3E0")]
	private void FAOBHIPEAMN(AHAOBADKPGL GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8ABB150", Offset = "0x8AB9950", VA = "0x188ABB150")]
	private void ENPGEPOOANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8ABA7D0", Offset = "0x8AB8FD0", VA = "0x188ABA7D0")]
	public void BBBOFONNCEF(bool HOGLALOGEFE, bool BBEIEILNLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8ABAE40", Offset = "0x8AB9640", VA = "0x188ABAE40")]
	protected void CLMLCGOKOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8ABB490", Offset = "0x8AB9C90", VA = "0x188ABB490")]
	public void FPKFBMACOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8ABA750", Offset = "0x8AB8F50", VA = "0x188ABA750")]
	[IteratorStateMachine(typeof(KCGMBHOJGCP))]
	public IEnumerable<Renderer> BAIGPKEJIGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABC030", Offset = "0x8ABA830", VA = "0x188ABC030")]
	[IteratorStateMachine(typeof(GFMOJPAODAP))]
	public IEnumerable<Renderer> PKHBIJJHBDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class LFCIBLHOPGM : AHAOBADKPGL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct MDMGNGFGAOA : JDJECDMPGGG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LFBDKLHLLEO MLCGFPJFGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle GGAIACICGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private KMEMBGCHGEP HGFBDDACOMN;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4780", Offset = "0x8AC2F80", VA = "0x188AC4780")]
		public MDMGNGFGAOA(LFBDKLHLLEO MLCGFPJFGFN, JobHandle GGAIACICGIO, KMEMBGCHGEP HGFBDDACOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4700", Offset = "0x8AC2F00", VA = "0x188AC4700", Slot = "4")]
		public LFBDKLHLLEO BFIAMMMMINP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4730", Offset = "0x8AC2F30", VA = "0x188AC4730", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly COKLCAOIGDG KFANBDJPNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float ANFJOJJEKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 EOJFFKLJOEE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 HJPJDMHAHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8AC09C0", Offset = "0x8ABF1C0", VA = "0x188AC09C0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8AC0CB0", Offset = "0x8ABF4B0", VA = "0x188AC0CB0")]
	public LFCIBLHOPGM(EEIAAAALDHJ MJAMEBJFAIN, COKLCAOIGDG IMINNNCPCJF, bool DNAHMNCICPA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "18")]
	public override bool OEAIGAMCFLK(HOAIPFDEDJB MJAMEBJFAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8AC0AE0", Offset = "0x8ABF2E0", VA = "0x188AC0AE0", Slot = "19")]
	public override int NCDJJGEGGIE(MINHAAENPPC MBAOJAPNLMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8ABFA50", Offset = "0x8ABE250", VA = "0x188ABFA50", Slot = "20")]
	public override int DNMANGEJIPF(MINHAAENPPC MBAOJAPNLMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8ABF390", Offset = "0x8ABDB90", VA = "0x188ABF390", Slot = "21")]
	public override IJKAECFHIHL ABLCOOHIHFO()
	{
		return default(IJKAECFHIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xA8E7D0", Offset = "0xA8CFD0", VA = "0x180A8E7D0", Slot = "22")]
	public override float BPGCHGEMJMM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8AC03E0", Offset = "0x8ABEBE0", VA = "0x188AC03E0", Slot = "23")]
	public override void GHDNNMCFGGP(MINHAAENPPC MBAOJAPNLMO, HOIEJGKPIBK DNKMHAFNFJD, int IJPPMNMDMLO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8ABF980", Offset = "0x8ABE180", VA = "0x188ABF980", Slot = "24")]
	public override HOAIPFDEDJB DMLLPLAIBOP()
	{
		return default(HOAIPFDEDJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8ABF7D0", Offset = "0x8ABDFD0", VA = "0x188ABF7D0", Slot = "26")]
	public override FLBFCIJJHNF CNPPEIODOFN()
	{
		return default(FLBFCIJJHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABFC20", Offset = "0x8ABE420", VA = "0x188ABFC20", Slot = "27")]
	public override JDJECDMPGGG FJAKIOBBKKB(MINHAAENPPC MBAOJAPNLMO, JobHandle GGAIACICGIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface PDIGPBCCFIB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EEIAAAALDHJ NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	AHAOBADKPGL NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CKAONPNNIGB NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class LIDNILMDCHD : EKIIKOCIIMI, IDisposable, PDIGPBCCFIB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MEOCCGLNBNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LIDNILMDCHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8AC47E0", Offset = "0x8AC2FE0", VA = "0x188AC47E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4D40", Offset = "0x8AC3540", VA = "0x188AC4D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly NFCEJELNCKA<EHLBOOAPMJF, EEIAAAALDHJ> EECMHPCPPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly NFCEJELNCKA<AOHNGCKJMMB, AHAOBADKPGL> DIPDHIOIFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly NFCEJELNCKA<CNNCIMMAOJA, CKAONPNNIGB> JGCBFLEJMGP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EEIAAAALDHJ NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8AC40F0", Offset = "0x8AC28F0", VA = "0x188AC40F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public AHAOBADKPGL NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4090", Offset = "0x8AC2890", VA = "0x188AC4090", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CKAONPNNIGB NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4150", Offset = "0x8AC2950", VA = "0x188AC4150", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MDPPPPINKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7E0", Offset = "0xA8CFE0", VA = "0x180A8E7E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8CCF0", VA = "0x180A8E4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8AC41B0", Offset = "0x8AC29B0", VA = "0x188AC41B0")]
	public LIDNILMDCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8AC2820", Offset = "0x8AC1020", VA = "0x188AC2820", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8AC2FD0", Offset = "0x8AC17D0", VA = "0x188AC2FD0", Slot = "4")]
	public EHLBOOAPMJF FKECCMDDHAC(NKCLKODHAAP IMINNNCPCJF)
	{
		return default(EHLBOOAPMJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8AC2FE0", Offset = "0x8AC17E0", VA = "0x188AC2FE0", Slot = "5")]
	public EHLBOOAPMJF FKECCMDDHAC(NKCLKODHAAP IMINNNCPCJF, bool DNAHMNCICPA)
	{
		return default(EHLBOOAPMJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8AC3C80", Offset = "0x8AC2480", VA = "0x188AC3C80", Slot = "6")]
	public void NEMKHHHCICC(EHLBOOAPMJF MJAMEBJFAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8AC3780", Offset = "0x8AC1F80", VA = "0x188AC3780", Slot = "7")]
	public void JFMLNNIPKLK(EHLBOOAPMJF MJAMEBJFAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8AC3250", Offset = "0x8AC1A50", VA = "0x188AC3250", Slot = "8")]
	public AOHNGCKJMMB HOEHGAMBHGF(EHLBOOAPMJF MJAMEBJFAIN, FAKJEMFPGGP IMINNNCPCJF)
	{
		return default(AOHNGCKJMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8AC21B0", Offset = "0x8AC09B0", VA = "0x188AC21B0", Slot = "9")]
	public AOHNGCKJMMB DEDHPIODCPL(EHLBOOAPMJF MJAMEBJFAIN, COKLCAOIGDG IMINNNCPCJF)
	{
		return default(AOHNGCKJMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8AC29E0", Offset = "0x8AC11E0", VA = "0x188AC29E0", Slot = "11")]
	public void ECDJEANJOAG(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8AC2D80", Offset = "0x8AC1580", VA = "0x188AC2D80", Slot = "10")]
	public void EEKCNEHHLMI(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8AC3710", Offset = "0x8AC1F10", VA = "0x188AC3710", Slot = "20")]
	public IEnumerable<Renderer> JACNCIEANDG(EHLBOOAPMJF MJAMEBJFAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8AC3C00", Offset = "0x8AC2400", VA = "0x188AC3C00", Slot = "12")]
	public CNNCIMMAOJA MOCDHECPFCD(MFOJNOCHEOF IMINNNCPCJF)
	{
		return default(CNNCIMMAOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8AC3B90", Offset = "0x8AC2390", VA = "0x188AC3B90", Slot = "14")]
	public void MNAENNMCHJO(CNNCIMMAOJA PDAHJDNAJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8AC3ED0", Offset = "0x8AC26D0", VA = "0x188AC3ED0", Slot = "16")]
	public Task NNAODHBMMPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8AC2670", Offset = "0x8AC0E70", VA = "0x188AC2670", Slot = "17")]
	public Task DGLMNBMPBPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8AC3AC0", Offset = "0x8AC22C0", VA = "0x188AC3AC0", Slot = "18")]
	[AsyncStateMachine(typeof(MEOCCGLNBNF))]
	public Task MECLBKMBHFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8AC2060", Offset = "0x8AC0860", VA = "0x188AC2060", Slot = "19")]
	public void BMGODHFIJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8AC2150", Offset = "0x8AC0950", VA = "0x188AC2150", Slot = "13")]
	public void CILNCJJEEBB(CNNCIMMAOJA PDAHJDNAJHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class BCKOPNKLNII : AHAOBADKPGL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct JNEPFHANDPK : JDJECDMPGGG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private LFBDKLHLLEO MLCGFPJFGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> NJFIJFFDFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle GGAIACICGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private DGEFADOOKID HGFBDDACOMN;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE840", Offset = "0x8ABD040", VA = "0x188ABE840")]
		public JNEPFHANDPK(LFBDKLHLLEO MLCGFPJFGFN, NativeArray<int> NJFIJFFDFCO, JobHandle GGAIACICGIO, DGEFADOOKID HGFBDDACOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE740", Offset = "0x8ABCF40", VA = "0x188ABE740", Slot = "4")]
		public LFBDKLHLLEO BFIAMMMMINP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE7A0", Offset = "0x8ABCFA0", VA = "0x188ABE7A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly FAKJEMFPGGP KFMKJLCMCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] MPLHHHGLDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 EOJFFKLJOEE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 LKAHEAKKHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8AB7910", Offset = "0x8AB6110", VA = "0x188AB7910")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 HJPJDMHAHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8B50", Offset = "0x8AB7350", VA = "0x188AB8B50", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8AB9270", Offset = "0x8AB7A70", VA = "0x188AB9270")]
	public BCKOPNKLNII(EEIAAAALDHJ MJAMEBJFAIN, FAKJEMFPGGP IMINNNCPCJF, bool JKHBJCJKCNE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8AB8FA0", Offset = "0x8AB77A0", VA = "0x188AB8FA0", Slot = "18")]
	public override bool OEAIGAMCFLK(HOAIPFDEDJB MJAMEBJFAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8AB6E50", Offset = "0x8AB5650", VA = "0x188AB6E50", Slot = "21")]
	public override IJKAECFHIHL ABLCOOHIHFO()
	{
		return default(IJKAECFHIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8AB6E90", Offset = "0x8AB5690", VA = "0x188AB6E90")]
	private IJKAECFHIHL ABLCOOHIHFO(HOAIPFDEDJB MJAMEBJFAIN)
	{
		return default(IJKAECFHIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8AB9070", Offset = "0x8AB7870", VA = "0x188AB9070")]
	private DPCBJCHLGNC OKPHLJFBEFI([In] UniformTRS HPMKBLJKBGJ, [In] float3 NAFAGKAHDMC)
	{
		return default(DPCBJCHLGNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8AB8EF0", Offset = "0x8AB76F0", VA = "0x188AB8EF0", Slot = "19")]
	public override int NCDJJGEGGIE(MINHAAENPPC MBAOJAPNLMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8AB7860", Offset = "0x8AB6060", VA = "0x188AB7860", Slot = "20")]
	public override int DNMANGEJIPF(MINHAAENPPC MBAOJAPNLMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8AB74F0", Offset = "0x8AB5CF0", VA = "0x188AB74F0", Slot = "22")]
	public override float BPGCHGEMJMM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8AB8C70", Offset = "0x8AB7470", VA = "0x188AB8C70")]
	private int JOJIKBMHNJI(MINHAAENPPC MBAOJAPNLMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8AB8310", Offset = "0x8AB6B10", VA = "0x188AB8310", Slot = "23")]
	public override void GHDNNMCFGGP(MINHAAENPPC MBAOJAPNLMO, HOIEJGKPIBK DNKMHAFNFJD, int IJPPMNMDMLO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8AB7790", Offset = "0x8AB5F90", VA = "0x188AB7790", Slot = "24")]
	public override HOAIPFDEDJB DMLLPLAIBOP()
	{
		return default(HOAIPFDEDJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8AB75E0", Offset = "0x8AB5DE0", VA = "0x188AB75E0", Slot = "26")]
	public override FLBFCIJJHNF CNPPEIODOFN()
	{
		return default(FLBFCIJJHNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8AB7B40", Offset = "0x8AB6340", VA = "0x188AB7B40", Slot = "27")]
	public override JDJECDMPGGG FJAKIOBBKKB(MINHAAENPPC MBAOJAPNLMO, JobHandle GGAIACICGIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GBGHMOLKDJB
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFDHLOOMPNE(FGMEPCABJKL CEPGAJKBPDM, Renderer FKGIDFBJGGD, int IOGAGGHKHLD);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBPACJHDCDD(Renderer FKGIDFBJGGD, PDFIDPLOKGF BGHBIEECDGN, Vector3 NNPFJJPAOHJ, Vector3 IPEEKJCFIOM, Vector3 AHDCMEODNNL, float HEMPAMFAGFP, float EOMACJAECML, float BAKNEJNDOBO = -1f, [Optional] Color? BIKIHAKPCIG, [Optional] IReadOnlyList<Camera> OPGGEKKDNKI);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void APKOBDHKJAD(Renderer FKGIDFBJGGD, int IOGAGGHKHLD);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IJMOBJJJLDP();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHMDDEPJGAL(int IJPCODAKKFM, ELCBLENENFJ CEPGAJKBPDM, Renderer FKGIDFBJGGD, int IOGAGGHKHLD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class APMMHIJBHHI : DBFFJCHPNOI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class JEHOIIACPDE : HKENNNDHEGI<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE2F0", Offset = "0x8ABCAF0", VA = "0x188ABE2F0")]
		public JEHOIIACPDE(string HPANEBBHGAC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GBGHMOLKDJB GEENGBKJMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PDIGPBCCFIB OAEAEMMLEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer FFKKFGOCCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private JEHOIIACPDE INALJLPBIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool ACDBAGIONKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer OBBKDOIMNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private JEHOIIACPDE ACPNFEEICAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool NHCGJGMLMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer LFPGIPBPHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private JEHOIIACPDE FOJIGMPMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool MDEOAEMIMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool LKNCKMOIEPH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	public APMMHIJBHHI(GBGHMOLKDJB PHEFAJKBLLI, PDIGPBCCFIB OAEAEMMLEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8AB53B0", Offset = "0x8AB3BB0", VA = "0x188AB53B0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8AB6900", Offset = "0x8AB5100", VA = "0x188AB6900")]
	private void ODCLNCLKGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8AB64C0", Offset = "0x8AB4CC0", VA = "0x188AB64C0", Slot = "4")]
	public void JNNODKDJLLL(EHLBOOAPMJF MJAMEBJFAIN, ELCBLENENFJ FIPGMBEGOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8AB62A0", Offset = "0x8AB4AA0", VA = "0x188AB62A0", Slot = "5")]
	public void JNNODKDJLLL(AOHNGCKJMMB GOMGOEKJPBC, ELCBLENENFJ FIPGMBEGOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8AB44E0", Offset = "0x8AB2CE0", VA = "0x188AB44E0", Slot = "6")]
	public void APEDOFPOOGK(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8AB47B0", Offset = "0x8AB2FB0", VA = "0x188AB47B0", Slot = "7")]
	public void BKOBFABEMND(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8AB6070", Offset = "0x8AB4870", VA = "0x188AB6070", Slot = "24")]
	public void HLJCBEOGMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x10F3FC0", Offset = "0x10F27C0", VA = "0x1810F3FC0", Slot = "8")]
	public void HKDPJBIDJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4640", Offset = "0x8AB2E40", VA = "0x188AB4640", Slot = "9")]
	public void BKJCHIKDPMO(ELCBLENENFJ FIPGMBEGOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8AB5B30", Offset = "0x8AB4330", VA = "0x188AB5B30", Slot = "10")]
	public void GKONBFKHEBI(EHLBOOAPMJF MJAMEBJFAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8AB57D0", Offset = "0x8AB3FD0", VA = "0x188AB57D0", Slot = "11")]
	public void GKONBFKHEBI(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8AB60B0", Offset = "0x8AB48B0", VA = "0x188AB60B0", Slot = "12")]
	public void IMNIJHDDDAH(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8AB5560", Offset = "0x8AB3D60", VA = "0x188AB5560", Slot = "13")]
	public void EIBDCOMIMAH(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8AB5140", Offset = "0x8AB3940", VA = "0x188AB5140")]
	private void DMGGKOINJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1400D20", Offset = "0x13FF520", VA = "0x181400D20", Slot = "14")]
	public void OGOPIMCNGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8AB6180", Offset = "0x8AB4980", VA = "0x188AB6180", Slot = "15")]
	public void JDABHGFMBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8AB6B70", Offset = "0x8AB5370", VA = "0x188AB6B70", Slot = "16")]
	public void PAFICAGOCNO(EHLBOOAPMJF MJAMEBJFAIN, FGMEPCABJKL CEPGAJKBPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8AB5700", Offset = "0x8AB3F00", VA = "0x188AB5700", Slot = "17")]
	public void GILKGHAGIAK(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8AB5630", Offset = "0x8AB3E30", VA = "0x188AB5630", Slot = "18")]
	public void GGLADHFIFIL(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xD198B0", Offset = "0xD180B0", VA = "0x180D198B0", Slot = "19")]
	public void DANJLJCHJCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8AB67D0", Offset = "0x8AB4FD0", VA = "0x188AB67D0", Slot = "20")]
	public void LAHEMNNJONB(FGMEPCABJKL CEPGAJKBPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8AB5E00", Offset = "0x8AB4600", VA = "0x188AB5E00")]
	private void GOMMOPPEEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4900", Offset = "0x8AB3100", VA = "0x188AB4900", Slot = "21")]
	public void CGKFJNFAINM(EHLBOOAPMJF MJAMEBJFAIN, Vector3 NNPFJJPAOHJ, Vector3 IPEEKJCFIOM, Vector3 AHDCMEODNNL, float HEMPAMFAGFP, float EOMACJAECML, IReadOnlyList<Camera> NHOKMEBJLBF, PDFIDPLOKGF BGHBIEECDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8AB4CC0", Offset = "0x8AB34C0", VA = "0x188AB4CC0", Slot = "22")]
	public void CGKFJNFAINM(CNNCIMMAOJA PDAHJDNAJHM, Vector3 NNPFJJPAOHJ, Vector3 IPEEKJCFIOM, Vector3 AHDCMEODNNL, float HEMPAMFAGFP, float EOMACJAECML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class AHAOBADKPGL : IODHFBEJHLP, MGCOKLMPKHE, MCMGPMJJBFH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly EEIAAAALDHJ LCHPFLHNGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int FJDBPBLKHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds CGMJDGIOELB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds PKFCNMBNNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AB3B90", Offset = "0x8AB2390", VA = "0x188AB3B90", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool NMFJBKGGHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xDF5EA0", Offset = "0xDF46A0", VA = "0x180DF5EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xDF5E80", Offset = "0xDF4680", VA = "0x180DF5E80")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 HJPJDMHAHKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IMLHELCLAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA76E00", Offset = "0xA75600", VA = "0x180A76E00", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public LIFKLOAJLAI IJFEFPJHFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool CNKBKFKLCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF4A770", Offset = "0xF48F70", VA = "0x180F4A770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	protected AHAOBADKPGL(EEIAAAALDHJ MJAMEBJFAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8AB3A30", Offset = "0x8AB2230", VA = "0x188AB3A30", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "18")]
	public virtual bool OEAIGAMCFLK(HOAIPFDEDJB MJAMEBJFAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8AB3BB0", Offset = "0x8AB23B0", VA = "0x188AB3BB0", Slot = "10")]
	public int KFGIEOMGMDL(int NMEJLHIHCCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int NCDJJGEGGIE(MINHAAENPPC MBAOJAPNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int DNMANGEJIPF(MINHAAENPPC MBAOJAPNLMO);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract IJKAECFHIHL ABLCOOHIHFO();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float BPGCHGEMJMM();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void GHDNNMCFGGP(MINHAAENPPC MBAOJAPNLMO, HOIEJGKPIBK DNKMHAFNFJD, int IJPPMNMDMLO = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract HOAIPFDEDJB DMLLPLAIBOP();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8AB3A00", Offset = "0x8AB2200", VA = "0x188AB3A00", Slot = "13")]
	public Hash128 DJNHGKFEPKL(int MBAOJAPNLMO)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract FLBFCIJJHNF CNPPEIODOFN();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract JDJECDMPGGG FJAKIOBBKKB(MINHAAENPPC MBAOJAPNLMO, JobHandle GGAIACICGIO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8AB3BC0", Offset = "0x8AB23C0", VA = "0x188AB3BC0", Slot = "12")]
	public JDJECDMPGGG PCNFLGHIEEK(int MBAOJAPNLMO)
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
		[Cpp2IlInjected.Address(RVA = "0x8AC61E0", Offset = "0x8AC49E0", VA = "0x188AC61E0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GLIINHLHDLB
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OGPJJELKHIJ : IEnumerable<BMMALOLOKAO>, IEnumerable, IEnumerator<BMMALOLOKAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private BMMALOLOKAO <>2__current;

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
		private BMMALOLOKAO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public OGPJJELKHIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6020", Offset = "0x8AC4820", VA = "0x188AC6020", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6190", Offset = "0x8AC4990", VA = "0x188AC6190", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8AC60F0", Offset = "0x8AC48F0", VA = "0x188AC60F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BMMALOLOKAO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8AC60F0", Offset = "0x8AC48F0", VA = "0x188AC60F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static BMMALOLOKAO[][] DLGHKOLONFP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static JJIEIPFPHNJ OGDJNCPHNAG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig DHGFPLKMEFA;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader BNJJOHLICAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC880", Offset = "0x8ABB080", VA = "0x188ABC880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer LEDHCOAEBGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD8D0", Offset = "0x8ABC0D0", VA = "0x188ABD8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8ABD930", Offset = "0x8ABC130", VA = "0x188ABD930")]
	[BDPIALLOKEK]
	internal static void IEAMPCKAMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8ABC7E0", Offset = "0x8ABAFE0", VA = "0x188ABC7E0")]
	public static Mesh ADGPPOAGBMP(GPADGHOFJCI GOGHCHPILHC, int MBAOJAPNLMO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8ABC8F0", Offset = "0x8ABB0F0", VA = "0x188ABC8F0")]
	public static int ALCEICNEFEM(GPADGHOFJCI GOGHCHPILHC, int MBAOJAPNLMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8ABDFA0", Offset = "0x8ABC7A0", VA = "0x188ABDFA0")]
	public static JJIEIPFPHNJ MGGGKCNNKPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE1A0", Offset = "0x8ABC9A0", VA = "0x188ABE1A0")]
	[IteratorStateMachine(typeof(OGPJJELKHIJ))]
	private static IEnumerable<BMMALOLOKAO> MILABEPCIJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8ABCAC0", Offset = "0x8ABB2C0", VA = "0x188ABCAC0")]
	public static BMMALOLOKAO DGHFKCFBOGH(GPADGHOFJCI GOGHCHPILHC, int MBAOJAPNLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8ABDF80", Offset = "0x8ABC780", VA = "0x188ABDF80")]
	public static bool KGDDKECDPLK(this GPADGHOFJCI GOGHCHPILHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8ABDDD0", Offset = "0x8ABC5D0", VA = "0x188ABDDD0")]
	public static void JKICDIFNFEF(GPADGHOFJCI GOGHCHPILHC, float3 AEGEOOIAOLC, [Out] GIIAOJCFHJA EAJFINPIEHP, [Out] float3 CEMNJBHDCDK, [Out] float JCPGEGIJAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8ABDA10", Offset = "0x8ABC210", VA = "0x188ABDA10")]
	public static void JGHNOMEPDMH(Vector3 AEGEOOIAOLC, GPADGHOFJCI GOGHCHPILHC, [Out] Vector3 CEMNJBHDCDK, [Out] float JCPGEGIJAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8ABC8E0", Offset = "0x8ABB0E0", VA = "0x188ABC8E0")]
	[HLGEDPEIDHB(0)]
	[IDECILCAMBG(GNJLFMHIMOJ.ExitingPlayMode, 0)]
	private static void AGOIDDEBGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8ABC900", Offset = "0x8ABB100", VA = "0x188ABC900")]
	[HLGEDPEIDHB(0)]
	[IDECILCAMBG(GNJLFMHIMOJ.ExitingPlayMode, 0)]
	private static void APBLCJMAHCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class NEBPHGBABML : EKIIKOCIIMI, IDisposable, PDIGPBCCFIB
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly NFCEJELNCKA<EHLBOOAPMJF, EEIAAAALDHJ> EECMHPCPPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NFCEJELNCKA<AOHNGCKJMMB, AHAOBADKPGL> DIPDHIOIFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NFCEJELNCKA<CNNCIMMAOJA, CKAONPNNIGB> JGCBFLEJMGP;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public EEIAAAALDHJ NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5780", Offset = "0x8AC3F80", VA = "0x188AC5780", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AHAOBADKPGL NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8AC56C0", Offset = "0x8AC3EC0", VA = "0x188AC56C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public CKAONPNNIGB NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5720", Offset = "0x8AC3F20", VA = "0x188AC5720", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MDPPPPINKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7E0", Offset = "0xA8CFE0", VA = "0x180A8E7E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8CCF0", VA = "0x180A8E4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8AC5860", Offset = "0x8AC4060", VA = "0x188AC5860")]
	public NEBPHGBABML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8AC4FE0", Offset = "0x8AC37E0", VA = "0x188AC4FE0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8AC5160", Offset = "0x8AC3960", VA = "0x188AC5160", Slot = "4")]
	public EHLBOOAPMJF FKECCMDDHAC(NKCLKODHAAP IMINNNCPCJF)
	{
		return default(EHLBOOAPMJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8AC5160", Offset = "0x8AC3960", VA = "0x188AC5160", Slot = "5")]
	public EHLBOOAPMJF FKECCMDDHAC(NKCLKODHAAP IMINNNCPCJF, bool DNAHMNCICPA)
	{
		return default(EHLBOOAPMJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8AC55C0", Offset = "0x8AC3DC0", VA = "0x188AC55C0", Slot = "6")]
	public void NEMKHHHCICC(EHLBOOAPMJF MJAMEBJFAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8AC53B0", Offset = "0x8AC3BB0", VA = "0x188AC53B0", Slot = "7")]
	public void JFMLNNIPKLK(EHLBOOAPMJF MJAMEBJFAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8AC5200", Offset = "0x8AC3A00", VA = "0x188AC5200", Slot = "8")]
	public AOHNGCKJMMB HOEHGAMBHGF(EHLBOOAPMJF MJAMEBJFAIN, FAKJEMFPGGP IMINNNCPCJF)
	{
		return default(AOHNGCKJMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8AC4E00", Offset = "0x8AC3600", VA = "0x188AC4E00", Slot = "9")]
	public AOHNGCKJMMB DEDHPIODCPL(EHLBOOAPMJF MJAMEBJFAIN, COKLCAOIGDG IMINNNCPCJF)
	{
		return default(AOHNGCKJMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8AC5070", Offset = "0x8AC3870", VA = "0x188AC5070", Slot = "11")]
	public void ECDJEANJOAG(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8AC5100", Offset = "0x8AC3900", VA = "0x188AC5100", Slot = "10")]
	public void EEKCNEHHLMI(AOHNGCKJMMB GOMGOEKJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8AC5340", Offset = "0x8AC3B40", VA = "0x188AC5340", Slot = "20")]
	public IEnumerable<Renderer> JACNCIEANDG(EHLBOOAPMJF MJAMEBJFAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8AC5540", Offset = "0x8AC3D40", VA = "0x188AC5540", Slot = "12")]
	public CNNCIMMAOJA MOCDHECPFCD(MFOJNOCHEOF IMINNNCPCJF)
	{
		return default(CNNCIMMAOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8AC54D0", Offset = "0x8AC3CD0", VA = "0x188AC54D0", Slot = "14")]
	public void MNAENNMCHJO(CNNCIMMAOJA PDAHJDNAJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8AC5620", Offset = "0x8AC3E20", VA = "0x188AC5620", Slot = "16")]
	public Task NNAODHBMMPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8AC4F40", Offset = "0x8AC3740", VA = "0x188AC4F40", Slot = "17")]
	public Task DGLMNBMPBPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8AC5430", Offset = "0x8AC3C30", VA = "0x188AC5430", Slot = "18")]
	public Task MECLBKMBHFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x275F460", Offset = "0x275DC60", VA = "0x18275F460", Slot = "19")]
	public void BMGODHFIJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8AC4DA0", Offset = "0x8AC35A0", VA = "0x188AC4DA0", Slot = "13")]
	public void CILNCJJEEBB(CNNCIMMAOJA PDAHJDNAJHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ELGCIOEDKHG
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool EGLFMGIIFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material NFNECLGODMM();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material DCCPMPJIBPI();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material IIHKMOABJCP();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OHPNODBICMI(OCHABKGPDJF BEELNHKBHFN);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FHJMLPNOHMD(MGEEHPEJAKN DJIOHHBLNJE);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EJNNHHGEKDC(GameObject HPLLAPMNIJF);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CDDCEHIMLFF(GameObject HPLLAPMNIJF, bool KJDIKNGGLLC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JKCDBHCJNOP
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static ELGCIOEDKHG DIIOBAFKCCH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool EGLFMGIIFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE5B0", Offset = "0x8ABCDB0", VA = "0x188ABE5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE4F0", Offset = "0x8ABCCF0", VA = "0x188ABE4F0")]
	public static void FBEALMCBKOH(ELGCIOEDKHG GJDBDFBIFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE670", Offset = "0x8ABCE70", VA = "0x188ABE670")]
	public static Material NFNECLGODMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8ABAF00", Offset = "0x8AB9700", VA = "0x188ABAF00")]
	public static Material DCCPMPJIBPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE610", Offset = "0x8ABCE10", VA = "0x188ABE610")]
	public static Material IIHKMOABJCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE6D0", Offset = "0x8ABCED0", VA = "0x188ABE6D0")]
	public static int OHPNODBICMI(OCHABKGPDJF BEELNHKBHFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE540", Offset = "0x8ABCD40", VA = "0x188ABE540")]
	public static int FHJMLPNOHMD(MGEEHPEJAKN DJIOHHBLNJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE420", Offset = "0x8ABCC20", VA = "0x188ABE420")]
	public static void EJNNHHGEKDC(GameObject HPLLAPMNIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE340", Offset = "0x8ABCB40", VA = "0x188ABE340")]
	public static void CDDCEHIMLFF(GameObject HPLLAPMNIJF, bool KJDIKNGGLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CKAONPNNIGB : MBCAECIEONI
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NNEDNJHFJOE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public CKAONPNNIGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public NNEDNJHFJOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5F90", Offset = "0x8AC4790", VA = "0x188AC5F90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5C70", Offset = "0x8AC4470", VA = "0x188AC5C70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5C20", Offset = "0x8AC4420", VA = "0x188AC5C20")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5F40", Offset = "0x8AC4740", VA = "0x188AC5F40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5E90", Offset = "0x8AC4690", VA = "0x188AC5E90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8AC5E90", Offset = "0x8AC4690", VA = "0x188AC5E90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MFOJNOCHEOF IPCCIHNGHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly PDIGPBCCFIB OAEAEMMLEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private AMOHKGFOIAN KKAMPPPJLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<LFLIPPJJJBP> PGGOJPPMFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<LFLIPPJJJBP> HJDEIIFMJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject CCAEHMHCPDN;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8AB93A0", Offset = "0x8AB7BA0", VA = "0x188AB93A0")]
	public static CKAONPNNIGB ELGIPKLGBNG(MFOJNOCHEOF IMINNNCPCJF, PDIGPBCCFIB OAEAEMMLEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8ABA670", Offset = "0x8AB8E70", VA = "0x188ABA670")]
	private CKAONPNNIGB(MFOJNOCHEOF IMINNNCPCJF, PDIGPBCCFIB OAEAEMMLEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8AB9F70", Offset = "0x8AB8770", VA = "0x188AB9F70")]
	public void JGAHMDKPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8AB9320", Offset = "0x8AB7B20", VA = "0x188AB9320")]
	[IteratorStateMachine(typeof(NNEDNJHFJOE))]
	public IEnumerable<Renderer> BAIGPKEJIGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8AB94F0", Offset = "0x8AB7CF0", VA = "0x188AB94F0", Slot = "4")]
	public void IGMGJBAHCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8ABA640", Offset = "0x8AB8E40", VA = "0x188ABA640")]
	private void LHFBCNPCDHE(Vector3 BCNNFBOLBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8ABA3F0", Offset = "0x8AB8BF0", VA = "0x188ABA3F0")]
	public void JNHFKCNMNLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LFLIPPJJJBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct FHDBJAMDCCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public HOIEJGKPIBK MOMDNNMPFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public HOAIPFDEDJB JOJGEOAPPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int AHAFEHIGFCP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JPJEBCHMBGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LFLIPPJJJBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public MINHAAENPPC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<FHDBJAMDCCP> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public LFBDKLHLLEO combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public JPJEBCHMBGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE8A0", Offset = "0x8ABD0A0", VA = "0x188ABE8A0")]
		internal JobHandle CHOMCFDJKME()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEA70", Offset = "0x8ABD270", VA = "0x188ABEA70")]
		internal void GCNDFOALFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE900", Offset = "0x8ABD100", VA = "0x188ABE900")]
		internal void CJIIANAIEJB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] HAPCBLBJONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private LCDJGCOLCKD OFDBEAINBNL;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 HELLMIIMLIO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh AJICNCIPKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KICNGCGAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8AC0D60", Offset = "0x8ABF560", VA = "0x188AC0D60")]
	public void BPMLAEOFNKM(List<HOAIPFDEDJB> OLOPEOLJPIK, Matrix4x4[] AGBCBLNNGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8AC10C0", Offset = "0x8ABF8C0", VA = "0x188AC10C0")]
	public static List<LFLIPPJJJBP> INHDMBAMCNE(List<EEIAAAALDHJ> IMEJGHLFHCO, MINHAAENPPC MBAOJAPNLMO, Bounds PDEEGEAEBNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8AC1750", Offset = "0x8ABFF50", VA = "0x188AC1750")]
	private JobHandle KAHOKDNNDJK(LFBDKLHLLEO MLLBLIJBGOF, int CHDNAOHPMCH, int FJNBBBLENEH, MINHAAENPPC MBAOJAPNLMO, List<FHDBJAMDCCP> LOCBAKBGCPK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8AC0FE0", Offset = "0x8ABF7E0", VA = "0x188AC0FE0")]
	private void IHAAMOKPJDN(List<FHDBJAMDCCP> LOCBAKBGCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8AC1C40", Offset = "0x8AC0440", VA = "0x188AC1C40")]
	private LFLIPPJJJBP(List<FHDBJAMDCCP> LOCBAKBGCPK, int CHDNAOHPMCH, int FJNBBBLENEH, MINHAAENPPC MBAOJAPNLMO, Bounds PDEEGEAEBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8AC0F40", Offset = "0x8ABF740", VA = "0x188AC0F40", Slot = "4")]
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
		private MaterialPropertyBlock KDGGNCPPECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private LFLIPPJJJBP MLCGFPJFGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<HOAIPFDEDJB> HHELPIMKKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture JNCMBCDPEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer ANBDLJHCGIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader NJGKIINCIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] OAGHEJKLDLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int LGCHDOPIOLC;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer CBANEODLMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int PIMEDPOKNCG
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8AC6F10", Offset = "0x8AC5710", VA = "0x188AC6F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6670", Offset = "0x8AC4E70", VA = "0x188AC6670")]
		public static List<SkinnedShapeRenderer> Create(GameObject MJAMEBJFAIN, List<LFLIPPJJJBP> IEIEGKJHFNE, List<HOAIPFDEDJB> HHELPIMKKJE, Material IPKNLMFNGIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6900", Offset = "0x8AC5100", VA = "0x188AC6900")]
		public void Init(LFLIPPJJJBP MLCGFPJFGFN, List<HOAIPFDEDJB> HHELPIMKKJE, Material IPKNLMFNGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6E70", Offset = "0x8AC5670", VA = "0x188AC6E70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6DD0", Offset = "0x8AC55D0", VA = "0x188AC6DD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6D90", Offset = "0x8AC5590", VA = "0x188AC6D90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6240", Offset = "0x8AC4A40", VA = "0x188AC6240")]
		private void AIJLIGDGPCD(ScriptableRenderContext MJAGIMDGJBK, Camera[] GJDADGAKLPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8AC6300", Offset = "0x8AC4B00", VA = "0x188AC6300")]
		private void BPMLAEOFNKM(CommandBuffer CAGFFDPMGEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
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
