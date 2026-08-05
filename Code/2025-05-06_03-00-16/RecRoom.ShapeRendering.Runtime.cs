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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85C45D0", Offset = "0x85C2DD0", VA = "0x1885C45D0", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CD320", Offset = "0x85CBB20", VA = "0x1885CD320", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OHPCCPOLGKH : CGFFCPGNCDD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte OACHFMOJDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] BIACAOKDIKH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PFKAEFMFGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CJFHANOBAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float EKCGADMOOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF14BE0", Offset = "0xF133E0", VA = "0x180F14BE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x128EFC0", Offset = "0x128D7C0", VA = "0x18128EFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float INHOAPMJJND
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC0C9E0", Offset = "0xC0B1E0", VA = "0x180C0C9E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC0C9F0", Offset = "0xC0B1F0", VA = "0x180C0C9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> HKGKAEPEBOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85CB400", Offset = "0x85C9C00", VA = "0x1885CB400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> PNGGGJHBCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85CB490", Offset = "0x85C9C90", VA = "0x1885CB490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject DFJAHCLMMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte FONCEKCBMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85CB3B0", Offset = "0x85C9BB0", VA = "0x1885CB3B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85CB620", Offset = "0x85C9E20", VA = "0x1885CB620")]
	public OHPCCPOLGKH(List<DJMEFCGLKFL> AOCDPFCCOIO, List<DJMEFCGLKFL> EPNMBEPELOP, List<AIFAFFNBDPH> HODLOHLIOFK, Material OALKCGACMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85CB290", Offset = "0x85C9A90", VA = "0x1885CB290")]
	private int HFOBGJGPENH(List<DJMEFCGLKFL> EPEHJJONMPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85CB4C0", Offset = "0x85C9CC0", VA = "0x1885CB4C0")]
	private void MDOFEAAMLOJ(int IPENMNDECHB, bool AKADIMLNNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85CB140", Offset = "0x85C9940", VA = "0x1885CB140")]
	public void EDDCAHDMPMM(Vector3 GLHGJLEIGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85CB040", Offset = "0x85C9840", VA = "0x1885CB040", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85CB450", Offset = "0x85C9C50", VA = "0x1885CB450")]
	public void JOCFEKIEELD(Transform PMDGEHAHECH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IKNKBIOOKPB : FPHLGDMJCNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class BBOCEGMABEH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public IKNKBIOOKPB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public BBOCEGMABEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85B9D80", Offset = "0x85B8580", VA = "0x1885B9D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85B9770", Offset = "0x85B7F70", VA = "0x1885B9770", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85B9680", Offset = "0x85B7E80", VA = "0x1885B9680")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85B9720", Offset = "0x85B7F20", VA = "0x1885B9720")]
		private void LGFFOGMDBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85B96D0", Offset = "0x85B7ED0", VA = "0x1885B96D0")]
		private void KDAFPJOJFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85B9D30", Offset = "0x85B8530", VA = "0x1885B9D30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85B9C80", Offset = "0x85B8480", VA = "0x1885B9C80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85B9C80", Offset = "0x85B8480", VA = "0x1885B9C80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JAFILLPCJLN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public IKNKBIOOKPB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public JAFILLPCJLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85C27D0", Offset = "0x85C0FD0", VA = "0x1885C27D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85C2360", Offset = "0x85C0B60", VA = "0x1885C2360", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85C22C0", Offset = "0x85C0AC0", VA = "0x1885C22C0")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85C2310", Offset = "0x85C0B10", VA = "0x1885C2310")]
		private void LGFFOGMDBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85C2780", Offset = "0x85C0F80", VA = "0x1885C2780", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85C26D0", Offset = "0x85C0ED0", VA = "0x1885C26D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85C26D0", Offset = "0x85C0ED0", VA = "0x1885C26D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OFIGCCKINJH EIJIJJNENOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<NKFNACHBGEN> MEGAPCILOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> COLIPAOGJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer BNKAHDMCGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MBBHBLEANDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool MAMNKPMIDBL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<PPIHHPOBLHH> PABFLLCLOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KABLANAIIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85C0D60", Offset = "0x85BF560", VA = "0x1885C0D60", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AIFAFFNBDPH IBIMAIDMLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85C09C0", Offset = "0x85BF1C0", VA = "0x1885C09C0", Slot = "8")]
		get
		{
			return default(AIFAFFNBDPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> BIMLFCFGKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85C0A90", Offset = "0x85BF290", VA = "0x1885C0A90")]
	private bool CMEPNKMNCFJ(NKFNACHBGEN AAMAJMKCBNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85C0F70", Offset = "0x85BF770", VA = "0x1885C0F70")]
	private static bool IHKDDKJIHGH(NKFNACHBGEN AAMAJMKCBNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85C21D0", Offset = "0x85C09D0", VA = "0x1885C21D0")]
	public IKNKBIOOKPB(OFIGCCKINJH NFNBKNAJBPN, bool AABHJMBCKOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85C0B70", Offset = "0x85BF370", VA = "0x1885C0B70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85C12E0", Offset = "0x85BFAE0", VA = "0x1885C12E0")]
	public void OIHLAKEIFNH(NKFNACHBGEN AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x85C0860", Offset = "0x85BF060", VA = "0x1885C0860")]
	public void AHELLINFOCL(NKFNACHBGEN AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x85C1A60", Offset = "0x85C0260", VA = "0x1885C1A60", Slot = "4")]
	public void OLDDACJNMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85C1070", Offset = "0x85BF870", VA = "0x1885C1070")]
	public void MAEEPMKIKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85C2010", Offset = "0x85C0810", VA = "0x1885C2010")]
	private void PDDIOKGNAJB(List<NKFNACHBGEN> MEGAPCILOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85C1010", Offset = "0x85BF810", VA = "0x1885C1010")]
	private static Material KANKIAPAKFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85C1F60", Offset = "0x85C0760", VA = "0x1885C1F60")]
	private void PDDIOKGNAJB(NKFNACHBGEN AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x85C0EA0", Offset = "0x85BF6A0", VA = "0x1885C0EA0")]
	private void HLPIKIHMGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x85C14B0", Offset = "0x85BFCB0", VA = "0x1885C14B0")]
	public void OLBAONOMGBA(bool KLHFCEPDDJC, bool JIPAPNEIPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85C0AB0", Offset = "0x85BF2B0", VA = "0x1885C0AB0")]
	protected void COMFMFLALHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85C0DA0", Offset = "0x85BF5A0", VA = "0x1885C0DA0")]
	public void FBALGLGMEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85C0E20", Offset = "0x85BF620", VA = "0x1885C0E20")]
	[IteratorStateMachine(typeof(BBOCEGMABEH))]
	public IEnumerable<Renderer> GAIEOENACNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85C0F90", Offset = "0x85BF790", VA = "0x1885C0F90")]
	[IteratorStateMachine(typeof(JAFILLPCJLN))]
	public IEnumerable<Renderer> IJNDFNEHDGF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class HADAIDALHEK : NKFNACHBGEN
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct ODBHLMBEGJJ : AABPLJEMGFP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PKKNLFDDHKF ABAPBBKNPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle OHHKLKBFKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private GCKLBHCDKPL JPCHALMJIGP;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85CAFE0", Offset = "0x85C97E0", VA = "0x1885CAFE0")]
		public ODBHLMBEGJJ(PKKNLFDDHKF ABAPBBKNPBC, JobHandle OHHKLKBFKLA, GCKLBHCDKPL JPCHALMJIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85CAFB0", Offset = "0x85C97B0", VA = "0x1885CAFB0", Slot = "4")]
		public PKKNLFDDHKF OOJHFJBDPKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85CAF60", Offset = "0x85C9760", VA = "0x1885CAF60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly CILFHMBDFBH MCKGIMFPMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float HBHGDNPLPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 CIAIELLJJFC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 MFDMBFBPJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85BDEE0", Offset = "0x85BC6E0", VA = "0x1885BDEE0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85BF170", Offset = "0x85BD970", VA = "0x1885BF170")]
	public HADAIDALHEK(IKNKBIOOKPB PNDCHGJLEGG, CILFHMBDFBH NFNBKNAJBPN, bool AABHJMBCKOF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "18")]
	public override bool DOJIANLPNBL(AIFAFFNBDPH PNDCHGJLEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x85BE010", Offset = "0x85BC810", VA = "0x1885BE010", Slot = "19")]
	public override int HFOBGJGPENH(IBLMMLLPHCM BIPGHKPGBAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85BEB60", Offset = "0x85BD360", VA = "0x1885BEB60", Slot = "20")]
	public override int KLHKGOCDODI(IBLMMLLPHCM BIPGHKPGBAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85BED30", Offset = "0x85BD530", VA = "0x1885BED30", Slot = "21")]
	public override EMKIDKCECNG MMJKADEILOI()
	{
		return default(EMKIDKCECNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xBEBD00", Offset = "0xBEA500", VA = "0x180BEBD00", Slot = "22")]
	public override float NEGBPGDPJPH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85BD830", Offset = "0x85BC030", VA = "0x1885BD830", Slot = "23")]
	public override void AIAIAKLCEEF(IBLMMLLPHCM BIPGHKPGBAC, HHMLJOBPGPN AAEEGKJJJMM, int DCLEFLOOHJB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x85BDE10", Offset = "0x85BC610", VA = "0x1885BDE10", Slot = "24")]
	public override AIFAFFNBDPH CJMHOGGLPLM()
	{
		return default(AIFAFFNBDPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x85BE9B0", Offset = "0x85BD1B0", VA = "0x1885BE9B0", Slot = "26")]
	public override EHNFNFAJIED KEAAMMIGINA()
	{
		return default(EHNFNFAJIED);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85BE1E0", Offset = "0x85BC9E0", VA = "0x1885BE1E0", Slot = "27")]
	public override AABPLJEMGFP IBDNCEIMBON(IBLMMLLPHCM BIPGHKPGBAC, JobHandle OHHKLKBFKLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface PMCFAMBCEKM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IKNKBIOOKPB EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NKFNACHBGEN EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OBCHDMBBFMC EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class FOJGPIHGAGI : OBHDPEBCHIG, IDisposable, PMCFAMBCEKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HDEOCLNFMDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FOJGPIHGAGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85BF220", Offset = "0x85BDA20", VA = "0x1885BF220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85BF780", Offset = "0x85BDF80", VA = "0x1885BF780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly AEHEJFJGOCI<NKPCNGHCBDP, IKNKBIOOKPB> ALEGENKODGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly AEHEJFJGOCI<DLGAKKGEPKP, NKFNACHBGEN> MEGAPCILOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly AEHEJFJGOCI<OPEKOKNPEII, OBCHDMBBFMC> LGJBBOALKDK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IKNKBIOOKPB EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85BB7F0", Offset = "0x85B9FF0", VA = "0x1885BB7F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public NKFNACHBGEN EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x85BB850", Offset = "0x85BA050", VA = "0x1885BB850", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OBCHDMBBFMC EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85BB8B0", Offset = "0x85BA0B0", VA = "0x1885BB8B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IOGELKMDLDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD83850", Offset = "0xD82050", VA = "0x180D83850", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA82330", Offset = "0xA80B30", VA = "0x180A82330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85BD3B0", Offset = "0x85BBBB0", VA = "0x1885BD3B0")]
	public FOJGPIHGAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85BBDB0", Offset = "0x85BA5B0", VA = "0x1885BBDB0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85BBB30", Offset = "0x85BA330", VA = "0x1885BBB30", Slot = "4")]
	public NKPCNGHCBDP DBHINNIFLOM(OFIGCCKINJH NFNBKNAJBPN)
	{
		return default(NKPCNGHCBDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85BBB40", Offset = "0x85BA340", VA = "0x1885BBB40", Slot = "5")]
	public NKPCNGHCBDP DBHINNIFLOM(OFIGCCKINJH NFNBKNAJBPN, bool AABHJMBCKOF)
	{
		return default(NKPCNGHCBDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85BCE00", Offset = "0x85BB600", VA = "0x1885BCE00", Slot = "6")]
	public void JCMAEMPGBHB(NKPCNGHCBDP PNDCHGJLEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85BB4B0", Offset = "0x85B9CB0", VA = "0x1885BB4B0", Slot = "7")]
	public void BCJLNEGODED(NKPCNGHCBDP PNDCHGJLEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85BBFF0", Offset = "0x85BA7F0", VA = "0x1885BBFF0", Slot = "8")]
	public DLGAKKGEPKP FKDABEFHEFH(NKPCNGHCBDP PNDCHGJLEGG, FMOLHEJODCJ NFNBKNAJBPN)
	{
		return default(DLGAKKGEPKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x85BC4B0", Offset = "0x85BACB0", VA = "0x1885BC4B0", Slot = "9")]
	public DLGAKKGEPKP GPBMEECDPHG(NKPCNGHCBDP PNDCHGJLEGG, CILFHMBDFBH NFNBKNAJBPN)
	{
		return default(DLGAKKGEPKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85BCA60", Offset = "0x85BB260", VA = "0x1885BCA60", Slot = "11")]
	public void HEBBDCKEFCL(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85BB260", Offset = "0x85B9A60", VA = "0x1885BB260", Slot = "10")]
	public void ANDFNFFLMBA(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85BD050", Offset = "0x85BB850", VA = "0x1885BD050", Slot = "20")]
	public IEnumerable<Renderer> KNKDOBDIOJL(NKPCNGHCBDP PNDCHGJLEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85BBF70", Offset = "0x85BA770", VA = "0x1885BBF70", Slot = "12")]
	public OPEKOKNPEII EADLLAIDPBL(DDGPKKHCANB NFNBKNAJBPN)
	{
		return default(OPEKOKNPEII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85BBAC0", Offset = "0x85BA2C0", VA = "0x1885BBAC0", Slot = "14")]
	public void DAHADFMMGIE(OPEKOKNPEII IAONCFHKNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85BD1F0", Offset = "0x85BB9F0", VA = "0x1885BD1F0", Slot = "16")]
	public Task PKGHJCAGLGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85BB910", Offset = "0x85BA110", VA = "0x1885BB910", Slot = "17")]
	public Task CIPLINGPNAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85BD0C0", Offset = "0x85BB8C0", VA = "0x1885BD0C0", Slot = "18")]
	[AsyncStateMachine(typeof(HDEOCLNFMDB))]
	public Task MANBKHJLJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x85BC970", Offset = "0x85BB170", VA = "0x1885BC970", Slot = "19")]
	public void HAGGOPNBHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x85BD190", Offset = "0x85BB990", VA = "0x1885BD190", Slot = "13")]
	public void MFJDKIKFGHI(OPEKOKNPEII IAONCFHKNEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class MOMBFKJAAAG : NKFNACHBGEN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct PPHHOGABKDB : AABPLJEMGFP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private PKKNLFDDHKF ABAPBBKNPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> ONGIIHDANEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle OHHKLKBFKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private BMKLKEJKGJM JPCHALMJIGP;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x85CBE30", Offset = "0x85CA630", VA = "0x1885CBE30")]
		public PPHHOGABKDB(PKKNLFDDHKF ABAPBBKNPBC, NativeArray<int> ONGIIHDANEJ, JobHandle OHHKLKBFKLA, BMKLKEJKGJM JPCHALMJIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x85CBDD0", Offset = "0x85CA5D0", VA = "0x1885CBDD0", Slot = "4")]
		public PKKNLFDDHKF OOJHFJBDPKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x85CBD30", Offset = "0x85CA530", VA = "0x1885CBD30", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly FMOLHEJODCJ BADLMALNNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] JJHJNMMNNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 CIAIELLJJFC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 HAAOADJFMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85C6520", Offset = "0x85C4D20", VA = "0x1885C6520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 MFDMBFBPJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x85C5490", Offset = "0x85C3C90", VA = "0x1885C5490", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x85C6E90", Offset = "0x85C5690", VA = "0x1885C6E90")]
	public MOMBFKJAAAG(IKNKBIOOKPB PNDCHGJLEGG, FMOLHEJODCJ NFNBKNAJBPN, bool GFMNCFEDGMN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x85C53C0", Offset = "0x85C3BC0", VA = "0x1885C53C0", Slot = "18")]
	public override bool DOJIANLPNBL(AIFAFFNBDPH PNDCHGJLEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x85C6D60", Offset = "0x85C5560", VA = "0x1885C6D60", Slot = "21")]
	public override EMKIDKCECNG MMJKADEILOI()
	{
		return default(EMKIDKCECNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x85C6750", Offset = "0x85C4F50", VA = "0x1885C6750")]
	private EMKIDKCECNG MMJKADEILOI(AIFAFFNBDPH PNDCHGJLEGG)
	{
		return default(EMKIDKCECNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x85C55C0", Offset = "0x85C3DC0", VA = "0x1885C55C0")]
	private CJAEGNMKJDM GDHBIHKJOKP([In] UniformTRS MGNHPEMIKIF, [In] float3 JDMHKICIBAK)
	{
		return default(CJAEGNMKJDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x85C57C0", Offset = "0x85C3FC0", VA = "0x1885C57C0", Slot = "19")]
	public override int HFOBGJGPENH(IBLMMLLPHCM BIPGHKPGBAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x85C6470", Offset = "0x85C4C70", VA = "0x1885C6470", Slot = "20")]
	public override int KLHKGOCDODI(IBLMMLLPHCM BIPGHKPGBAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x85C6DA0", Offset = "0x85C55A0", VA = "0x1885C6DA0", Slot = "22")]
	public override float NEGBPGDPJPH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x85C6040", Offset = "0x85C4840", VA = "0x1885C6040")]
	private int IDDFFNGHOKE(IBLMMLLPHCM BIPGHKPGBAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x85C4AA0", Offset = "0x85C32A0", VA = "0x1885C4AA0", Slot = "23")]
	public override void AIAIAKLCEEF(IBLMMLLPHCM BIPGHKPGBAC, HHMLJOBPGPN AAEEGKJJJMM, int DCLEFLOOHJB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x85C52F0", Offset = "0x85C3AF0", VA = "0x1885C52F0", Slot = "24")]
	public override AIFAFFNBDPH CJMHOGGLPLM()
	{
		return default(AIFAFFNBDPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x85C62C0", Offset = "0x85C4AC0", VA = "0x1885C62C0", Slot = "26")]
	public override EHNFNFAJIED KEAAMMIGINA()
	{
		return default(EHNFNFAJIED);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x85C5870", Offset = "0x85C4070", VA = "0x1885C5870", Slot = "27")]
	public override AABPLJEMGFP IBDNCEIMBON(IBLMMLLPHCM BIPGHKPGBAC, JobHandle OHHKLKBFKLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OJBFLJNAGBM
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIEJJEEHGPK(KKHCPEKNJIC PIJHKCJDAHO, Renderer JGPHFKDOCBN, int INIIOOMPJIO);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGOKJJHHIJB(Renderer JGPHFKDOCBN, GBCBAFBJFMP NOGCCJNOPLG, Vector3 HOPGOBDNJKN, Vector3 FPIEKCNILGJ, Vector3 DIGACAJBFJH, float MLBOJHFBHPC, float CCABDFEMEFP, float ILPJFOFDPOM = -1f, [Optional] Color? AGNHOOELDII, [Optional] IReadOnlyList<Camera> OINBJGNIOFF);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKGFPIIAGGG(Renderer JGPHFKDOCBN, int INIIOOMPJIO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PFJNAKAPDIL();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AJHHKFDMJLD(int OJALKFKPAAE, HFLHFCIMFNP PIJHKCJDAHO, Renderer JGPHFKDOCBN, int INIIOOMPJIO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NKPIDMPFCFL : OJMGMPCIMIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class NDECBNMNEEC : PLJPDLJPLMM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85C6F40", Offset = "0x85C5740", VA = "0x1885C6F40")]
		public NDECBNMNEEC(string GLGOHIJMLFB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly OJBFLJNAGBM KFFFFMKJELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PMCFAMBCEKM GPHMAIEDFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer OAIKPKGIGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private NDECBNMNEEC LJMEDGLNIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool HMGCPCCJJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer FBPNBLLOFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NDECBNMNEEC PKBBBMPELGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool DGMMCKIDLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer DPGMCKCJOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private NDECBNMNEEC APDGMPAAIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool CHKAMJFOLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool IHDAJILAEEC;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public NKPIDMPFCFL(OJBFLJNAGBM BMAPFFOALKH, PMCFAMBCEKM GPHMAIEDFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x85C85D0", Offset = "0x85C6DD0", VA = "0x1885C85D0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x85C8850", Offset = "0x85C7050", VA = "0x1885C8850")]
	private void FECPOMEHCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x85C7C50", Offset = "0x85C6450", VA = "0x1885C7C50", Slot = "4")]
	public void BNDKBEJMECG(NKPCNGHCBDP PNDCHGJLEGG, HFLHFCIMFNP POCCMBPNGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x85C7A30", Offset = "0x85C6230", VA = "0x1885C7A30", Slot = "5")]
	public void BNDKBEJMECG(DLGAKKGEPKP AAMAJMKCBNJ, HFLHFCIMFNP POCCMBPNGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x85C8C60", Offset = "0x85C7460", VA = "0x1885C8C60", Slot = "6")]
	public void HOCMKCIEPFE(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x85C8FC0", Offset = "0x85C77C0", VA = "0x1885C8FC0", Slot = "7")]
	public void LJHAAMOJNIN(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x85C7180", Offset = "0x85C5980", VA = "0x1885C7180", Slot = "24")]
	public void AONPKCHOGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x107BBD0", Offset = "0x107A3D0", VA = "0x18107BBD0", Slot = "8")]
	public void FJCDONKPCBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x85C9380", Offset = "0x85C7B80", VA = "0x1885C9380", Slot = "9")]
	public void NPCPIHNPPAH(HFLHFCIMFNP POCCMBPNGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x85C9850", Offset = "0x85C8050", VA = "0x1885C9850", Slot = "10")]
	public void OALPPKEDEIN(NKPCNGHCBDP PNDCHGJLEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x85C94F0", Offset = "0x85C7CF0", VA = "0x1885C94F0", Slot = "11")]
	public void OALPPKEDEIN(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x85C8B90", Offset = "0x85C7390", VA = "0x1885C8B90", Slot = "12")]
	public void HNAIKFEKJCG(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x85C8DC0", Offset = "0x85C75C0", VA = "0x1885C8DC0", Slot = "13")]
	public void KGHKBABFLEO(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x85C9110", Offset = "0x85C7910", VA = "0x1885C9110")]
	private void NBIHEOEEEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x12C35A0", Offset = "0x12C1DA0", VA = "0x1812C35A0", Slot = "14")]
	public void PIIPMMMIKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x85C8240", Offset = "0x85C6A40", VA = "0x1885C8240", Slot = "15")]
	public void DKGIKPCJCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x85C7F60", Offset = "0x85C6760", VA = "0x1885C7F60", Slot = "16")]
	public void DCIDHDCNDGG(NKPCNGHCBDP PNDCHGJLEGG, KKHCPEKNJIC PIJHKCJDAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x85C8780", Offset = "0x85C6F80", VA = "0x1885C8780", Slot = "17")]
	public void FAIFNMFDLBC(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x85C8AC0", Offset = "0x85C72C0", VA = "0x1885C8AC0", Slot = "18")]
	public void GPIOODEMIEL(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xC59E20", Offset = "0xC58620", VA = "0x180C59E20", Slot = "19")]
	public void OLHJAEAPBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x85C8E90", Offset = "0x85C7690", VA = "0x1885C8E90", Slot = "20")]
	public void KPGLHJCLEHN(KKHCPEKNJIC PIJHKCJDAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x85C8360", Offset = "0x85C6B60", VA = "0x1885C8360")]
	private void DOJPDDFLIOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x85C7660", Offset = "0x85C5E60", VA = "0x1885C7660", Slot = "21")]
	public void BLFHBMAMAMM(NKPCNGHCBDP PNDCHGJLEGG, Vector3 HOPGOBDNJKN, Vector3 FPIEKCNILGJ, Vector3 DIGACAJBFJH, float MLBOJHFBHPC, float CCABDFEMEFP, IReadOnlyList<Camera> GEAMDJLLILA, GBCBAFBJFMP NOGCCJNOPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x85C71C0", Offset = "0x85C59C0", VA = "0x1885C71C0", Slot = "22")]
	public void BLFHBMAMAMM(OPEKOKNPEII IAONCFHKNEM, Vector3 HOPGOBDNJKN, Vector3 FPIEKCNILGJ, Vector3 DIGACAJBFJH, float MLBOJHFBHPC, float CCABDFEMEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class NKFNACHBGEN : LJDBIPFMDJO, PPIHHPOBLHH, JPAAENCCKEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly IKNKBIOOKPB DFJAHCLMMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int NMHCGPLOHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds ICEEEEKAICK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds EAHAOONHMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x85C7160", Offset = "0x85C5960", VA = "0x1885C7160", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool MAMNKPMIDBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD4B290", Offset = "0xD49A90", VA = "0x180D4B290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD4B790", Offset = "0xD49F90", VA = "0x180D4B790")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 MFDMBFBPJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int LLABJPCMKNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public PIPELENMMAH JAMJJKHHHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HBDPEHLINEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xE71CC0", Offset = "0xE704C0", VA = "0x180E71CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	protected NKFNACHBGEN(IKNKBIOOKPB PNDCHGJLEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x85C6FD0", Offset = "0x85C57D0", VA = "0x1885C6FD0", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "18")]
	public virtual bool DOJIANLPNBL(AIFAFFNBDPH PNDCHGJLEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x85C6FC0", Offset = "0x85C57C0", VA = "0x1885C6FC0", Slot = "10")]
	public int DPKDDIAPKBD(int PFGMLEPOBMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int HFOBGJGPENH(IBLMMLLPHCM BIPGHKPGBAC);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int KLHKGOCDODI(IBLMMLLPHCM BIPGHKPGBAC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract EMKIDKCECNG MMJKADEILOI();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float NEGBPGDPJPH();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void AIAIAKLCEEF(IBLMMLLPHCM BIPGHKPGBAC, HHMLJOBPGPN AAEEGKJJJMM, int DCLEFLOOHJB = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract AIFAFFNBDPH CJMHOGGLPLM();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x85C6F90", Offset = "0x85C5790", VA = "0x1885C6F90", Slot = "13")]
	public Hash128 AAPOGCKAEOL(int BIPGHKPGBAC)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract EHNFNFAJIED KEAAMMIGINA();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract AABPLJEMGFP IBDNCEIMBON(IBLMMLLPHCM BIPGHKPGBAC, JobHandle OHHKLKBFKLA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x85C7130", Offset = "0x85C5930", VA = "0x1885C7130", Slot = "12")]
	public AABPLJEMGFP GAFOJDCPHKL(int BIPGHKPGBAC)
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
		[Cpp2IlInjected.Address(RVA = "0x85CBE90", Offset = "0x85CA690", VA = "0x1885CBE90")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JJENLDOEMAO
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KJLKHINDEFE : IEnumerable<OKGKCPLKBHN>, IEnumerable, IEnumerator<OKGKCPLKBHN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private OKGKCPLKBHN <>2__current;

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
		private OKGKCPLKBHN System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public KJLKHINDEFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x85C4410", Offset = "0x85C2C10", VA = "0x1885C4410", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85C4580", Offset = "0x85C2D80", VA = "0x1885C4580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x85C44E0", Offset = "0x85C2CE0", VA = "0x1885C44E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OKGKCPLKBHN> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x85C44E0", Offset = "0x85C2CE0", VA = "0x1885C44E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static OKGKCPLKBHN[][] FEBJGOIJEGB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static EJNEKDLJOBA KHELJICHOJJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig GLMIGNENGOA;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader CIDNFOCPPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x85C2900", Offset = "0x85C1100", VA = "0x1885C2900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer AJPPNGEPNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x85C39F0", Offset = "0x85C21F0", VA = "0x1885C39F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x85C3E00", Offset = "0x85C2600", VA = "0x1885C3E00")]
	[KBINEFBNEHG]
	internal static void NPIOKLMMDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x85C3950", Offset = "0x85C2150", VA = "0x1885C3950")]
	public static Mesh FACMENLBOOB(PFDGIOAKAOJ EGJNAKBFAKK, int BIPGHKPGBAC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x85C2B20", Offset = "0x85C1320", VA = "0x1885C2B20")]
	public static int DGIDJACAOOJ(PFDGIOAKAOJ EGJNAKBFAKK, int BIPGHKPGBAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x85C3C00", Offset = "0x85C2400", VA = "0x1885C3C00")]
	public static EJNEKDLJOBA MGMMIFEALNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x85C42C0", Offset = "0x85C2AC0", VA = "0x1885C42C0")]
	[IteratorStateMachine(typeof(KJLKHINDEFE))]
	private static IEnumerable<OKGKCPLKBHN> PMOJAMLJBAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x85C2B40", Offset = "0x85C1340", VA = "0x1885C2B40")]
	public static OKGKCPLKBHN EBMCHACBNDH(PFDGIOAKAOJ EGJNAKBFAKK, int BIPGHKPGBAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x85C42A0", Offset = "0x85C2AA0", VA = "0x1885C42A0")]
	public static bool PABFGDKDMHF(this PFDGIOAKAOJ EGJNAKBFAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x85C3A50", Offset = "0x85C2250", VA = "0x1885C3A50")]
	public static void KKHHPMNCFGA(PFDGIOAKAOJ EGJNAKBFAKK, float3 KDMMCJDFBNE, [Out] NGMFIBACAJD NFJJEJOIMNF, [Out] float3 EGAHNBGEPLC, [Out] float FOOBHFBFBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x85C3EE0", Offset = "0x85C26E0", VA = "0x1885C3EE0")]
	public static void OJNAMILNEAI(Vector3 KDMMCJDFBNE, PFDGIOAKAOJ EGJNAKBFAKK, [Out] Vector3 EGAHNBGEPLC, [Out] float FOOBHFBFBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x85C2B30", Offset = "0x85C1330", VA = "0x1885C2B30")]
	[FKDGBBMDBHO(0)]
	[BOGLAMPKNMP(EGMDMPGLLBP.ExitingPlayMode, 0)]
	private static void DJPBAHJIBMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x85C2960", Offset = "0x85C1160", VA = "0x1885C2960")]
	[FKDGBBMDBHO(0)]
	[BOGLAMPKNMP(EGMDMPGLLBP.ExitingPlayMode, 0)]
	private static void COFFKAJPFCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class IFEGHMECBCK : OBHDPEBCHIG, IDisposable, PMCFAMBCEKM
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly AEHEJFJGOCI<NKPCNGHCBDP, IKNKBIOOKPB> ALEGENKODGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AEHEJFJGOCI<DLGAKKGEPKP, NKFNACHBGEN> MEGAPCILOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly AEHEJFJGOCI<OPEKOKNPEII, OBCHDMBBFMC> LGJBBOALKDK;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IKNKBIOOKPB EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x85BFB80", Offset = "0x85BE380", VA = "0x1885BFB80", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public NKFNACHBGEN EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x85BFAC0", Offset = "0x85BE2C0", VA = "0x1885BFAC0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public OBCHDMBBFMC EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x85BFB20", Offset = "0x85BE320", VA = "0x1885BFB20", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IOGELKMDLDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xD83850", Offset = "0xD82050", VA = "0x180D83850", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA82330", Offset = "0xA80B30", VA = "0x180A82330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x85C04A0", Offset = "0x85BECA0", VA = "0x1885C04A0")]
	public IFEGHMECBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x85BFD90", Offset = "0x85BE590", VA = "0x1885BFD90", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x85BFCF0", Offset = "0x85BE4F0", VA = "0x1885BFCF0", Slot = "4")]
	public NKPCNGHCBDP DBHINNIFLOM(OFIGCCKINJH NFNBKNAJBPN)
	{
		return default(NKPCNGHCBDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x85BFCF0", Offset = "0x85BE4F0", VA = "0x1885BFCF0", Slot = "5")]
	public NKPCNGHCBDP DBHINNIFLOM(OFIGCCKINJH NFNBKNAJBPN, bool AABHJMBCKOF)
	{
		return default(NKPCNGHCBDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x85C01B0", Offset = "0x85BE9B0", VA = "0x1885C01B0", Slot = "6")]
	public void JCMAEMPGBHB(NKPCNGHCBDP PNDCHGJLEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x85BFA40", Offset = "0x85BE240", VA = "0x1885BFA40", Slot = "7")]
	public void BCJLNEGODED(NKPCNGHCBDP PNDCHGJLEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x85BFEA0", Offset = "0x85BE6A0", VA = "0x1885BFEA0", Slot = "8")]
	public DLGAKKGEPKP FKDABEFHEFH(NKPCNGHCBDP PNDCHGJLEGG, FMOLHEJODCJ NFNBKNAJBPN)
	{
		return default(DLGAKKGEPKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x85BFFE0", Offset = "0x85BE7E0", VA = "0x1885BFFE0", Slot = "9")]
	public DLGAKKGEPKP GPBMEECDPHG(NKPCNGHCBDP PNDCHGJLEGG, CILFHMBDFBH NFNBKNAJBPN)
	{
		return default(DLGAKKGEPKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x85C0120", Offset = "0x85BE920", VA = "0x1885C0120", Slot = "11")]
	public void HEBBDCKEFCL(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x85BF9E0", Offset = "0x85BE1E0", VA = "0x1885BF9E0", Slot = "10")]
	public void ANDFNFFLMBA(DLGAKKGEPKP AAMAJMKCBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x85C0210", Offset = "0x85BEA10", VA = "0x1885C0210", Slot = "20")]
	public IEnumerable<Renderer> KNKDOBDIOJL(NKPCNGHCBDP PNDCHGJLEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x85BFE20", Offset = "0x85BE620", VA = "0x1885BFE20", Slot = "12")]
	public OPEKOKNPEII EADLLAIDPBL(DDGPKKHCANB NFNBKNAJBPN)
	{
		return default(OPEKOKNPEII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x85BFC80", Offset = "0x85BE480", VA = "0x1885BFC80", Slot = "14")]
	public void DAHADFMMGIE(OPEKOKNPEII IAONCFHKNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x85C0380", Offset = "0x85BEB80", VA = "0x1885C0380", Slot = "16")]
	public Task PKGHJCAGLGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x85BFBE0", Offset = "0x85BE3E0", VA = "0x1885BFBE0", Slot = "17")]
	public Task CIPLINGPNAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x85C0280", Offset = "0x85BEA80", VA = "0x1885C0280", Slot = "18")]
	public Task MANBKHJLJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2640C20", Offset = "0x263F420", VA = "0x182640C20", Slot = "19")]
	public void HAGGOPNBHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x85C0320", Offset = "0x85BEB20", VA = "0x1885C0320", Slot = "13")]
	public void MFJDKIKFGHI(OPEKOKNPEII IAONCFHKNEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MAPEBJLHPLG
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool NHCPFKGPOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material FJDDBKHEJKG();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material KANKIAPAKFL();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material IJEOFOCDDMK();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EICDAPMMMKK(CGKMKJEAANA CBCOGLOFHMD);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IEAJLELLHGA(KLEDGCGHKKL MDPLGNFGFGG);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IKBPIPGNOCK(GameObject PNHCNFOFAFI);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LKEAFHNDFMO(GameObject PNHCNFOFAFI, bool COBPEGFBKDE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MKLDDFFHFPF
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static MAPEBJLHPLG JLPKBNIJDEI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool NHCPFKGPOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x85C4A40", Offset = "0x85C3240", VA = "0x1885C4A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x85C49F0", Offset = "0x85C31F0", VA = "0x1885C49F0")]
	public static void LLKCFIHDEBP(MAPEBJLHPLG LDJGGOJPEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x85C4710", Offset = "0x85C2F10", VA = "0x1885C4710")]
	public static Material FJDDBKHEJKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x85C1010", Offset = "0x85BF810", VA = "0x1885C1010")]
	public static Material KANKIAPAKFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x85C47E0", Offset = "0x85C2FE0", VA = "0x1885C47E0")]
	public static Material IJEOFOCDDMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x85C46A0", Offset = "0x85C2EA0", VA = "0x1885C46A0")]
	public static int EICDAPMMMKK(CGKMKJEAANA CBCOGLOFHMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x85C4770", Offset = "0x85C2F70", VA = "0x1885C4770")]
	public static int IEAJLELLHGA(KLEDGCGHKKL MDPLGNFGFGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x85C4840", Offset = "0x85C3040", VA = "0x1885C4840")]
	public static void IKBPIPGNOCK(GameObject PNHCNFOFAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x85C4910", Offset = "0x85C3110", VA = "0x1885C4910")]
	public static void LKEAFHNDFMO(GameObject PNHCNFOFAFI, bool COBPEGFBKDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OBCHDMBBFMC : FPHLGDMJCNB
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class OMLEAOIDBIP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public OBCHDMBBFMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public OMLEAOIDBIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x85CBCA0", Offset = "0x85CA4A0", VA = "0x1885CBCA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x85CB980", Offset = "0x85CA180", VA = "0x1885CB980", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x85CB930", Offset = "0x85CA130", VA = "0x1885CB930")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x85CBC50", Offset = "0x85CA450", VA = "0x1885CBC50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x85CBBA0", Offset = "0x85CA3A0", VA = "0x1885CBBA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x85CBBA0", Offset = "0x85CA3A0", VA = "0x1885CBBA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DDGPKKHCANB JLIOEILECPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly PMCFAMBCEKM GPHMAIEDFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private OHPCCPOLGKH LEOJOPLKLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<DJMEFCGLKFL> DCGGIMGFAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<DJMEFCGLKFL> EBOHLNCIPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject NDBFPEOHNOM;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x85C9E20", Offset = "0x85C8620", VA = "0x1885C9E20")]
	public static OBCHDMBBFMC MJELHMOCMNL(DDGPKKHCANB NFNBKNAJBPN, PMCFAMBCEKM GPHMAIEDFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x85CAE80", Offset = "0x85C9680", VA = "0x1885CAE80")]
	private OBCHDMBBFMC(DDGPKKHCANB NFNBKNAJBPN, PMCFAMBCEKM GPHMAIEDFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x85C9F70", Offset = "0x85C8770", VA = "0x1885C9F70")]
	public void OCOBEACFBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x85C9B50", Offset = "0x85C8350", VA = "0x1885C9B50")]
	[IteratorStateMachine(typeof(OMLEAOIDBIP))]
	public IEnumerable<Renderer> GAIEOENACNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x85CA3F0", Offset = "0x85C8BF0", VA = "0x1885CA3F0", Slot = "4")]
	public void OLDDACJNMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x85C9B20", Offset = "0x85C8320", VA = "0x1885C9B20")]
	private void AMFAEBFKHGM(Vector3 GLHGJLEIGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x85C9BD0", Offset = "0x85C83D0", VA = "0x1885C9BD0")]
	public void MAEEPMKIKNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DJMEFCGLKFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct PFJFGHCJIMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public HHMLJOBPGPN NPEMLKPLPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AIFAFFNBDPH IKBNMCHOEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int HMBNJGCEGPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HHFNKFIAIGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public DJMEFCGLKFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public IBLMMLLPHCM lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<PFJFGHCJIMJ> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PKKNLFDDHKF combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HHFNKFIAIGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x85BF980", Offset = "0x85BE180", VA = "0x1885BF980")]
		internal JobHandle GJLCNIACNFJ()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x85BF950", Offset = "0x85BE150", VA = "0x1885BF950")]
		internal void BEKBLGGLCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x85BF7E0", Offset = "0x85BDFE0", VA = "0x1885BF7E0")]
		internal void AIMDPCECPKJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] IIONFLKAFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private CAHHPALBCPE NJCHCPCFIBJ;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 ONMGGOOIPKJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh ECLDOGPLLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int ADDMENBCPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x85BA770", Offset = "0x85B8F70", VA = "0x1885BA770")]
	public void OEFABNHLEBI(List<AIFAFFNBDPH> KLHGEOPIOKH, Matrix4x4[] BFJBKCEBNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x85BA0E0", Offset = "0x85B88E0", VA = "0x1885BA0E0")]
	public static List<DJMEFCGLKFL> NKIHIDGHACP(List<IKNKBIOOKPB> FOAGJIKGKNK, IBLMMLLPHCM BIPGHKPGBAC, Bounds KBODAPIGKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x85BA950", Offset = "0x85B9150", VA = "0x1885BA950")]
	private JobHandle OOBCPFEBIIC(PKKNLFDDHKF FDJMCEONHFP, int JCDJHOHOPJC, int HFGIBGEKDDK, IBLMMLLPHCM BIPGHKPGBAC, List<PFJFGHCJIMJ> GGKMMMCINKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x85BA000", Offset = "0x85B8800", VA = "0x1885BA000")]
	private void NBHPJDPKGBN(List<PFJFGHCJIMJ> GGKMMMCINKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x85BAE40", Offset = "0x85B9640", VA = "0x1885BAE40")]
	private DJMEFCGLKFL(List<PFJFGHCJIMJ> GGKMMMCINKK, int JCDJHOHOPJC, int HFGIBGEKDDK, IBLMMLLPHCM BIPGHKPGBAC, Bounds KBODAPIGKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x85B9F70", Offset = "0x85B8770", VA = "0x1885B9F70", Slot = "4")]
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
		private MaterialPropertyBlock KFBAIGJGEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private DJMEFCGLKFL ABAPBBKNPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<AIFAFFNBDPH> HODLOHLIOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture FGHFLKFHNBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer KOGOOKFJLGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader JPPDOJBOCCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] IHAMNHKADNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int AMMHFFBAIMM;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer EPHPBABEEEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int AMJMEGJOAFD
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x85CCBC0", Offset = "0x85CB3C0", VA = "0x1885CCBC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x85CBFB0", Offset = "0x85CA7B0", VA = "0x1885CBFB0")]
		public static List<SkinnedShapeRenderer> Create(GameObject PNDCHGJLEGG, List<DJMEFCGLKFL> EPEHJJONMPA, List<AIFAFFNBDPH> HODLOHLIOFK, Material OALKCGACMLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x85CC240", Offset = "0x85CAA40", VA = "0x1885CC240")]
		public void Init(DJMEFCGLKFL ABAPBBKNPBC, List<AIFAFFNBDPH> HODLOHLIOFK, Material OALKCGACMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x85CCB20", Offset = "0x85CB320", VA = "0x1885CCB20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x85CCA80", Offset = "0x85CB280", VA = "0x1885CCA80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x85CCA40", Offset = "0x85CB240", VA = "0x1885CCA40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x85CBEF0", Offset = "0x85CA6F0", VA = "0x1885CBEF0")]
		private void BMOFMGPKANK(ScriptableRenderContext KLNHOILIBHH, Camera[] GLNJPAOKPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x85CC6D0", Offset = "0x85CAED0", VA = "0x1885CC6D0")]
		private void OEFABNHLEBI(CommandBuffer NOACLCGHLMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
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
