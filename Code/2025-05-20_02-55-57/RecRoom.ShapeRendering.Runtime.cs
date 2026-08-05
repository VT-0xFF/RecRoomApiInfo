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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8772600", Offset = "0x8771800", VA = "0x188772600", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877B8A0", Offset = "0x877AAA0", VA = "0x18877B8A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CODFNAPEACH : KKGGLGBODNN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte LJOONNEGNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] FKKMLDHHANK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PLLPPFGHLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FCNMKAEFJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float HPJCJDBABHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF498C0", Offset = "0xF48AC0", VA = "0x180F498C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1310930", Offset = "0x130FB30", VA = "0x181310930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float KLNGNCOMCLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC5D8B0", Offset = "0xC5CAB0", VA = "0x180C5D8B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC5D8C0", Offset = "0xC5CAC0", VA = "0x180C5D8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> NKNIHDIKJON
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x876D290", Offset = "0x876C490", VA = "0x18876D290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> PGNHKJMHNAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x876D140", Offset = "0x876C340", VA = "0x18876D140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject ADHDCGIKAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte GCOLLFOKGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x876D0B0", Offset = "0x876C2B0", VA = "0x18876D0B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x876D440", Offset = "0x876C640", VA = "0x18876D440")]
	public CODFNAPEACH(List<BMCOLPAPKJG> AKPNEEAPLLC, List<BMCOLPAPKJG> PGBKLDMFGCJ, List<AOECEAGCFFM> ELKOPKMBPKH, Material OHHEKLKCMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x876D170", Offset = "0x876C370", VA = "0x18876D170")]
	private int HGHKKLKFJHK(List<BMCOLPAPKJG> CFEMJPGPPKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x876D2E0", Offset = "0x876C4E0", VA = "0x18876D2E0")]
	private void NNLBILEBMAK(int CNIOLECLLHK, bool GHGDMNBCOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x876CE60", Offset = "0x876C060", VA = "0x18876CE60")]
	public void CBGGKMHNDEA(Vector3 BLPJCJEDNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x876CFB0", Offset = "0x876C1B0", VA = "0x18876CFB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x876D100", Offset = "0x876C300", VA = "0x18876D100")]
	public void HANFKBBNFNL(Transform CDKDGKKKMIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HNALKIGEMDC : LIEJNKNHCHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class FPPNNFPBGIK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HNALKIGEMDC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public FPPNNFPBGIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8770310", Offset = "0x876F510", VA = "0x188770310", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x876FD00", Offset = "0x876EF00", VA = "0x18876FD00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x876FC10", Offset = "0x876EE10", VA = "0x18876FC10")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x876FCB0", Offset = "0x876EEB0", VA = "0x18876FCB0")]
		private void GCCIFBPGOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x876FC60", Offset = "0x876EE60", VA = "0x18876FC60")]
		private void CNKLEPELNJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87702C0", Offset = "0x876F4C0", VA = "0x1887702C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8770210", Offset = "0x876F410", VA = "0x188770210", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8770210", Offset = "0x876F410", VA = "0x188770210", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class APNKAEEJGEH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HNALKIGEMDC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public APNKAEEJGEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x876B9F0", Offset = "0x876ABF0", VA = "0x18876B9F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x876B580", Offset = "0x876A780", VA = "0x18876B580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x876B4E0", Offset = "0x876A6E0", VA = "0x18876B4E0")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x876B530", Offset = "0x876A730", VA = "0x18876B530")]
		private void GCCIFBPGOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x876B9A0", Offset = "0x876ABA0", VA = "0x18876B9A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x876B8F0", Offset = "0x876AAF0", VA = "0x18876B8F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x876B8F0", Offset = "0x876AAF0", VA = "0x18876B8F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NPAJLANHHDD JLIIGFHECCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<ENKIJDMEIBK> NLKOPLKPKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> JPKGGBJHEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer KNOJJLGFHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool IOIDEAPJGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool AJAIMGPMMMJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<IIGOFCLCLJP> ACHJHMGILIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PGNDNPDKBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8772050", Offset = "0x8771250", VA = "0x188772050", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AOECEAGCFFM MOFPKIEEKPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8770AC0", Offset = "0x876FCC0", VA = "0x188770AC0", Slot = "8")]
		get
		{
			return default(AOECEAGCFFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> DIEGAACILJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x87720F0", Offset = "0x87712F0", VA = "0x1887720F0")]
	private bool OEANMIEBICP(ENKIJDMEIBK FDPAKEMBDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8771C60", Offset = "0x8770E60", VA = "0x188771C60")]
	private static bool JDFNKDDKEPC(ENKIJDMEIBK FDPAKEMBDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8772430", Offset = "0x8771630", VA = "0x188772430")]
	public HNALKIGEMDC(NPAJLANHHDD DHAOEHNLNON, bool ICKOPMMOHGJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8770C10", Offset = "0x876FE10", VA = "0x188770C10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8772190", Offset = "0x8771390", VA = "0x188772190")]
	public void OOLDDNFEGEK(ENKIJDMEIBK FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8771C80", Offset = "0x8770E80", VA = "0x188771C80")]
	public void KKKHDEJPLIG(ENKIJDMEIBK FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x87713B0", Offset = "0x87705B0", VA = "0x1887713B0", Slot = "4")]
	public void FOAJFIJGNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x87719F0", Offset = "0x8770BF0", VA = "0x1887719F0")]
	public void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8771E90", Offset = "0x8771090", VA = "0x188771E90")]
	private void KMOCOPNOIPL(List<ENKIJDMEIBK> NLKOPLKPKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8772090", Offset = "0x8771290", VA = "0x188772090")]
	private static Material OCAHNLACFFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8771DE0", Offset = "0x8770FE0", VA = "0x188771DE0")]
	private void KMOCOPNOIPL(ENKIJDMEIBK FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8772360", Offset = "0x8771560", VA = "0x188772360")]
	private void PLGBHNFFLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8770E00", Offset = "0x8770000", VA = "0x188770E00")]
	public void FDGEBLDCHMP(bool ELFLNJJLOCJ, bool ALCEOPDOLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8771930", Offset = "0x8770B30", VA = "0x188771930")]
	protected void HPAAEEKFIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8772110", Offset = "0x8771310", VA = "0x188772110")]
	public void OOJIHNLLDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x87718B0", Offset = "0x8770AB0", VA = "0x1887718B0")]
	[IteratorStateMachine(typeof(FPPNNFPBGIK))]
	public IEnumerable<Renderer> HEIGHHBCDCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8770B90", Offset = "0x876FD90", VA = "0x188770B90")]
	[IteratorStateMachine(typeof(APNKAEEJGEH))]
	public IEnumerable<Renderer> BNICEKJKNHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class MLAFPDDIKPD : ENKIJDMEIBK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct JDAOKEJICCE : ODBHJJIIGMM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PBKMGPOLEJF KHKMPBIDLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle EOJDBKLNAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private FKILFOPFDCP ANCNJNFACCI;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x87725A0", Offset = "0x87717A0", VA = "0x1887725A0")]
		public JDAOKEJICCE(PBKMGPOLEJF KHKMPBIDLPA, JobHandle EOJDBKLNAOP, FKILFOPFDCP ANCNJNFACCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8772520", Offset = "0x8771720", VA = "0x188772520", Slot = "4")]
		public PBKMGPOLEJF BKELOGOOEBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8772550", Offset = "0x8771750", VA = "0x188772550", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly CNEDPOGNDBG OHFHBFGMKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float MMGHNLEKEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 NAPBAPONEDE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 PEMMFBNJIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8773480", Offset = "0x8772680", VA = "0x188773480", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8774010", Offset = "0x8773210", VA = "0x188774010")]
	public MLAFPDDIKPD(HNALKIGEMDC FHPKLENNKKO, CNEDPOGNDBG DHAOEHNLNON, bool ICKOPMMOHGJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "18")]
	public override bool OOHNAFCNJPD(AOECEAGCFFM FHPKLENNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x87735B0", Offset = "0x87727B0", VA = "0x1887735B0", Slot = "19")]
	public override int HGHKKLKFJHK(NNNLBPFEJKG ANANLCFKCEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8773A00", Offset = "0x8772C00", VA = "0x188773A00", Slot = "20")]
	public override int LFMHDEIKMAI(NNNLBPFEJKG ANANLCFKCEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8773BD0", Offset = "0x8772DD0", VA = "0x188773BD0", Slot = "21")]
	public override DEJFKMDCDHJ OOOEDGOLNPL()
	{
		return default(DEJFKMDCDHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC23640", Offset = "0xC22840", VA = "0x180C23640", Slot = "22")]
	public override float FKKLDLJOGCE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8772EA0", Offset = "0x87720A0", VA = "0x188772EA0", Slot = "23")]
	public override void EBLNCBIFKJA(NNNLBPFEJKG ANANLCFKCEG, CCILIPHKBOG NACJJLCOMCL, int DIJAELCBEGJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8773930", Offset = "0x8772B30", VA = "0x188773930", Slot = "24")]
	public override AOECEAGCFFM JKGODJGNFPD()
	{
		return default(AOECEAGCFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8773780", Offset = "0x8772980", VA = "0x188773780", Slot = "26")]
	public override ABNNNHPKFHP HOGFEEMOAGK()
	{
		return default(ABNNNHPKFHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x87726D0", Offset = "0x87718D0", VA = "0x1887726D0", Slot = "27")]
	public override ODBHJJIIGMM BLDKEJFPCPF(NNNLBPFEJKG ANANLCFKCEG, JobHandle EOJDBKLNAOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface NONGDAJBELE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	HNALKIGEMDC JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ENKIJDMEIBK JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	AIBOJDCNENO JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class NECKDMKKGDB : PFOKOKEKMHK, IDisposable, NONGDAJBELE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GBIKJGDADEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NECKDMKKGDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8770500", Offset = "0x876F700", VA = "0x188770500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8770A60", Offset = "0x876FC60", VA = "0x188770A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GNLIPAPECAL<HEJBBJOONEM, HNALKIGEMDC> EGJHKGGNBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly GNLIPAPECAL<FJJNPNKHKFF, ENKIJDMEIBK> NLKOPLKPKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly GNLIPAPECAL<KDKEMAMEJBC, AIBOJDCNENO> NHBLGOLJHAE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public HNALKIGEMDC JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8774520", Offset = "0x8773720", VA = "0x188774520", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ENKIJDMEIBK JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8774580", Offset = "0x8773780", VA = "0x188774580", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AIBOJDCNENO JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x87744C0", Offset = "0x87736C0", VA = "0x1887744C0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MBBFPKAOJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC3460", VA = "0x180DC4260", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAADDE0", Offset = "0xAACFE0", VA = "0x180AADDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8776610", Offset = "0x8775810", VA = "0x188776610")]
	public NECKDMKKGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8774920", Offset = "0x8773B20", VA = "0x188774920", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8774DA0", Offset = "0x8773FA0", VA = "0x188774DA0", Slot = "4")]
	public HEJBBJOONEM FOAPKDBABBO(NPAJLANHHDD DHAOEHNLNON)
	{
		return default(HEJBBJOONEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8774DB0", Offset = "0x8773FB0", VA = "0x188774DB0", Slot = "5")]
	public HEJBBJOONEM FOAPKDBABBO(NPAJLANHHDD DHAOEHNLNON, bool ICKOPMMOHGJ)
	{
		return default(HEJBBJOONEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8774AE0", Offset = "0x8773CE0", VA = "0x188774AE0", Slot = "6")]
	public void FDIEJLHOCJC(HEJBBJOONEM FHPKLENNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x87745E0", Offset = "0x87737E0", VA = "0x1887745E0", Slot = "7")]
	public void DCOMMAACKCB(HEJBBJOONEM FHPKLENNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x87752E0", Offset = "0x87744E0", VA = "0x1887752E0", Slot = "8")]
	public FJJNPNKHKFF JKNBBMHJGMB(HEJBBJOONEM FHPKLENNKKO, CJMNDOAJBNF DHAOEHNLNON)
	{
		return default(FJJNPNKHKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8775BC0", Offset = "0x8774DC0", VA = "0x188775BC0", Slot = "9")]
	public FJJNPNKHKFF NGKNGGAIEJO(HEJBBJOONEM FHPKLENNKKO, CNEDPOGNDBG DHAOEHNLNON)
	{
		return default(FJJNPNKHKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x87757A0", Offset = "0x87749A0", VA = "0x1887757A0", Slot = "11")]
	public void LEDNCMJPDAF(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8775090", Offset = "0x8774290", VA = "0x188775090", Slot = "10")]
	public void GOOJOALDKIC(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8774D30", Offset = "0x8773F30", VA = "0x188774D30", Slot = "20")]
	public IEnumerable<Renderer> FFBJLGFKPOE(HEJBBJOONEM FHPKLENNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8775B40", Offset = "0x8774D40", VA = "0x188775B40", Slot = "12")]
	public KDKEMAMEJBC LHFPEEJOJEA(DKDDHCECMFH DHAOEHNLNON)
	{
		return default(KDKEMAMEJBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8775020", Offset = "0x8774220", VA = "0x188775020", Slot = "14")]
	public void GDIKKHACIEJ(KDKEMAMEJBC NPAJCEMAICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x87763F0", Offset = "0x87755F0", VA = "0x1887763F0", Slot = "16")]
	public Task PMMBLIBENFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8776170", Offset = "0x8775370", VA = "0x188776170", Slot = "17")]
	public Task OGBGMODGACC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8776320", Offset = "0x8775520", VA = "0x188776320", Slot = "18")]
	[AsyncStateMachine(typeof(GBIKJGDADEG))]
	public Task PGJKOFJNLLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8776080", Offset = "0x8775280", VA = "0x188776080", Slot = "19")]
	public void NKBKCEOGLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x87765B0", Offset = "0x87757B0", VA = "0x1887765B0", Slot = "13")]
	public void PNLNEIDOFFC(KDKEMAMEJBC NPAJCEMAICN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class ANHAMLDPKCF : ENKIJDMEIBK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct NNLKLJEJJMC : ODBHJJIIGMM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private PBKMGPOLEJF KHKMPBIDLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> LBMCKOIGNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle EOJDBKLNAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private JMNMBHKOODC ANCNJNFACCI;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8779530", Offset = "0x8778730", VA = "0x188779530")]
		public NNLKLJEJJMC(PBKMGPOLEJF KHKMPBIDLPA, NativeArray<int> LBMCKOIGNJC, JobHandle EOJDBKLNAOP, JMNMBHKOODC ANCNJNFACCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8779430", Offset = "0x8778630", VA = "0x188779430", Slot = "4")]
		public PBKMGPOLEJF BKELOGOOEBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8779490", Offset = "0x8778690", VA = "0x188779490", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly CJMNDOAJBNF ALBEJFPMKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] ABLJJPHLKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 NAPBAPONEDE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 MNMAEGNEGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x876A330", Offset = "0x8769530", VA = "0x18876A330")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 PEMMFBNJIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x876A150", Offset = "0x8769350", VA = "0x18876A150", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x876B430", Offset = "0x876A630", VA = "0x18876B430")]
	public ANHAMLDPKCF(HNALKIGEMDC FHPKLENNKKO, CJMNDOAJBNF DHAOEHNLNON, bool ONJKDFFNLAP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x876AA90", Offset = "0x8769C90", VA = "0x18876AA90", Slot = "18")]
	public override bool OOHNAFCNJPD(AOECEAGCFFM FHPKLENNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x876B170", Offset = "0x876A370", VA = "0x18876B170", Slot = "21")]
	public override DEJFKMDCDHJ OOOEDGOLNPL()
	{
		return default(DEJFKMDCDHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x876AB60", Offset = "0x8769D60", VA = "0x18876AB60")]
	private DEJFKMDCDHJ OOOEDGOLNPL(AOECEAGCFFM FHPKLENNKKO)
	{
		return default(DEJFKMDCDHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x876A710", Offset = "0x8769910", VA = "0x18876A710")]
	private ABCEPEAAFGE JHGANBLPKCF([In] UniformTRS GPNBPJCNPOE, [In] float3 MCNGNFFDHIC)
	{
		return default(ABCEPEAAFGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x876A280", Offset = "0x8769480", VA = "0x18876A280", Slot = "19")]
	public override int HGHKKLKFJHK(NNNLBPFEJKG ANANLCFKCEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x876A9E0", Offset = "0x8769BE0", VA = "0x18876A9E0", Slot = "20")]
	public override int LFMHDEIKMAI(NNNLBPFEJKG ANANLCFKCEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x876A060", Offset = "0x8769260", VA = "0x18876A060", Slot = "22")]
	public override float FKKLDLJOGCE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x876B1B0", Offset = "0x876A3B0", VA = "0x18876B1B0")]
	private int PNKBHOKGBMC(NNNLBPFEJKG ANANLCFKCEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8769810", Offset = "0x8768A10", VA = "0x188769810", Slot = "23")]
	public override void EBLNCBIFKJA(NNNLBPFEJKG ANANLCFKCEG, CCILIPHKBOG NACJJLCOMCL, int DIJAELCBEGJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x876A910", Offset = "0x8769B10", VA = "0x18876A910", Slot = "24")]
	public override AOECEAGCFFM JKGODJGNFPD()
	{
		return default(AOECEAGCFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x876A560", Offset = "0x8769760", VA = "0x18876A560", Slot = "26")]
	public override ABNNNHPKFHP HOGFEEMOAGK()
	{
		return default(ABNNNHPKFHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8769040", Offset = "0x8768240", VA = "0x188769040", Slot = "27")]
	public override ODBHJJIIGMM BLDKEJFPCPF(NNNLBPFEJKG ANANLCFKCEG, JobHandle EOJDBKLNAOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HOIOBAGBILO
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDLPMPFPIGB(CNMFJGBLGMD EDLOHJEBKFM, Renderer JFBIEOOKIGH, int NDOKLPJLKLF);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOLPGAAAJNC(Renderer JFBIEOOKIGH, BEOAGMLPKLB FGFHIDECMGG, Vector3 IHNPJFNBJBE, Vector3 IIOLMPCPGEC, Vector3 FCHLBEBMFED, float NKAKEPANHCF, float KACFJENLELK, float HNOBJIPKFJK = -1f, [Optional] Color? EKKMKLFENBL, [Optional] IReadOnlyList<Camera> ICACIPIBBFN);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OKFKBEIDKFK(Renderer JFBIEOOKIGH, int NDOKLPJLKLF);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PEPINLMDLAF();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGPPEFBIGNL(int HNCEPNBIKOM, LIGLMNBGNIO EDLOHJEBKFM, Renderer JFBIEOOKIGH, int NDOKLPJLKLF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NEDFDJLDHDN : DNOHAGJNPAP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class BEPAGHKEHCH : DNDOMDOGFGI<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x876BB20", Offset = "0x876AD20", VA = "0x18876BB20")]
		public BEPAGHKEHCH(string DGIAFBEDPNJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HOIOBAGBILO LAHGMACNNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NONGDAJBELE OEEIMKOOJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer MNMEJPOKPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private BEPAGHKEHCH OIJNANAGBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool OOADECPAEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer HLMBBBMPFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private BEPAGHKEHCH EPNPINELHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool EJJEHMAIAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer PGNAJODPJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private BEPAGHKEHCH EJPCFENCGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool JJMACMLDCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool KBCJGENOOPH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public NEDFDJLDHDN(HOIOBAGBILO CPALCMBPKAE, NONGDAJBELE OEEIMKOOJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8776CB0", Offset = "0x8775EB0", VA = "0x188776CB0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8776F90", Offset = "0x8776190", VA = "0x188776F90")]
	private void FPMJDPKAEEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8778770", Offset = "0x8777970", VA = "0x188778770", Slot = "4")]
	public void MGGKPPOAIIA(HEJBBJOONEM FHPKLENNKKO, LIGLMNBGNIO CFHFANILNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8778A80", Offset = "0x8777C80", VA = "0x188778A80", Slot = "5")]
	public void MGGKPPOAIIA(FJJNPNKHKFF FDPAKEMBDAE, LIGLMNBGNIO CFHFANILNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x87772D0", Offset = "0x87764D0", VA = "0x1887772D0", Slot = "6")]
	public void GKCGJIGCBCP(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8776B60", Offset = "0x8775D60", VA = "0x188776B60", Slot = "7")]
	public void CBBKHAIBLJG(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8778CA0", Offset = "0x8777EA0", VA = "0x188778CA0", Slot = "24")]
	public void NBHILJAGLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x10ACB50", Offset = "0x10ABD50", VA = "0x1810ACB50", Slot = "8")]
	public void FANPIFGLGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x87776A0", Offset = "0x87768A0", VA = "0x1887776A0", Slot = "9")]
	public void IDHOMLEGDNN(LIGLMNBGNIO CFHFANILNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8779160", Offset = "0x8778360", VA = "0x188779160", Slot = "10")]
	public void OIEIEGNGELK(HEJBBJOONEM FHPKLENNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8778E00", Offset = "0x8778000", VA = "0x188778E00", Slot = "11")]
	public void OIEIEGNGELK(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8777A80", Offset = "0x8776C80", VA = "0x188777A80", Slot = "12")]
	public void JFNBAHJAFOE(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8777B50", Offset = "0x8776D50", VA = "0x188777B50", Slot = "13")]
	public void JHKDKNGOOKC(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8777430", Offset = "0x8776630", VA = "0x188777430")]
	private void HKLKJDOACMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1327F00", Offset = "0x1327100", VA = "0x181327F00", Slot = "14")]
	public void GMOOICOHCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8778CE0", Offset = "0x8777EE0", VA = "0x188778CE0", Slot = "15")]
	public void OIBJGEPCKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8778490", Offset = "0x8777690", VA = "0x188778490", Slot = "16")]
	public void LKCFAPBLOOC(HEJBBJOONEM FHPKLENNKKO, CNMFJGBLGMD EDLOHJEBKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8776A90", Offset = "0x8775C90", VA = "0x188776A90", Slot = "17")]
	public void AFNEIDJJBDC(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8777200", Offset = "0x8776400", VA = "0x188777200", Slot = "18")]
	public void GJGINEAHPPH(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xC9C150", Offset = "0xC9B350", VA = "0x180C9C150", Slot = "19")]
	public void NKMGLFJPNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8776E60", Offset = "0x8776060", VA = "0x188776E60", Slot = "20")]
	public void EBJLNHIMPOL(CNMFJGBLGMD EDLOHJEBKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8777810", Offset = "0x8776A10", VA = "0x188777810")]
	private void IKCGGPHIFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8777C20", Offset = "0x8776E20", VA = "0x188777C20", Slot = "21")]
	public void LFBIPIIFHOG(HEJBBJOONEM FHPKLENNKKO, Vector3 IHNPJFNBJBE, Vector3 IIOLMPCPGEC, Vector3 FCHLBEBMFED, float NKAKEPANHCF, float KACFJENLELK, IReadOnlyList<Camera> KINFPMNFAFA, BEOAGMLPKLB FGFHIDECMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8777FF0", Offset = "0x87771F0", VA = "0x188777FF0", Slot = "22")]
	public void LFBIPIIFHOG(KDKEMAMEJBC NPAJCEMAICN, Vector3 IHNPJFNBJBE, Vector3 IIOLMPCPGEC, Vector3 FCHLBEBMFED, float NKAKEPANHCF, float KACFJENLELK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ENKIJDMEIBK : BOPELHGKDMF, IIGOFCLCLJP, DCICILJLCBN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly HNALKIGEMDC ADHDCGIKAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int PPOLDAOJNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds OILMFIBKOLD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds DEOGGMHPFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x876F9C0", Offset = "0x876EBC0", VA = "0x18876F9C0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool AJAIMGPMMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD724A0", Offset = "0xD716A0", VA = "0x180D724A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD72720", Offset = "0xD71920", VA = "0x180D72720")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 PEMMFBNJIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HNCEECDGBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ILAHDDNCDOC NICLBEPJDDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool NBHNGJLLFPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xEA6760", Offset = "0xEA5960", VA = "0x180EA6760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	protected ENKIJDMEIBK(HNALKIGEMDC FHPKLENNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x876F860", Offset = "0x876EA60", VA = "0x18876F860", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "18")]
	public virtual bool OOHNAFCNJPD(AOECEAGCFFM FHPKLENNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x876FA40", Offset = "0x876EC40", VA = "0x18876FA40", Slot = "10")]
	public int KJKMDOOCPGN(int MDGEGMGLAKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int HGHKKLKFJHK(NNNLBPFEJKG ANANLCFKCEG);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int LFMHDEIKMAI(NNNLBPFEJKG ANANLCFKCEG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract DEJFKMDCDHJ OOOEDGOLNPL();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float FKKLDLJOGCE();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void EBLNCBIFKJA(NNNLBPFEJKG ANANLCFKCEG, CCILIPHKBOG NACJJLCOMCL, int DIJAELCBEGJ = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract AOECEAGCFFM JKGODJGNFPD();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x876FA10", Offset = "0x876EC10", VA = "0x18876FA10", Slot = "13")]
	public Hash128 IFOIOHPAAHL(int ANANLCFKCEG)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract ABNNNHPKFHP HOGFEEMOAGK();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract ODBHJJIIGMM BLDKEJFPCPF(NNNLBPFEJKG ANANLCFKCEG, JobHandle EOJDBKLNAOP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x876F9E0", Offset = "0x876EBE0", VA = "0x18876F9E0", Slot = "12")]
	public ODBHJJIIGMM HGNNJIHFODI(int ANANLCFKCEG)
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
		[Cpp2IlInjected.Address(RVA = "0x877A410", Offset = "0x8779610", VA = "0x18877A410")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DEIDFDNHHOL
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FMKCPANDNGM : IEnumerable<ACEAEPPHAPA>, IEnumerable, IEnumerator<ACEAEPPHAPA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private ACEAEPPHAPA <>2__current;

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
		private ACEAEPPHAPA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public FMKCPANDNGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x876FA50", Offset = "0x876EC50", VA = "0x18876FA50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x876FBC0", Offset = "0x876EDC0", VA = "0x18876FBC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x876FB20", Offset = "0x876ED20", VA = "0x18876FB20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ACEAEPPHAPA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x876FB20", Offset = "0x876ED20", VA = "0x18876FB20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ACEAEPPHAPA[][] ENIDFFBNOPM;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static MNAGEFHMLHN OLBKJDFNLPF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig KHNHMEAEIJM;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader PFNGAJDEAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x876F040", Offset = "0x876E240", VA = "0x18876F040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer GBPJPLNLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x876F110", Offset = "0x876E310", VA = "0x18876F110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x876EDB0", Offset = "0x876DFB0", VA = "0x18876EDB0")]
	[CBBBKCBCELM]
	internal static void ILLMBOBOELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x876D930", Offset = "0x876CB30", VA = "0x18876D930")]
	public static Mesh CHFKECOCAAF(EFDNHOFOELB HMCHHBFEOPH, int ANANLCFKCEG = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x876EDA0", Offset = "0x876DFA0", VA = "0x18876EDA0")]
	public static int GDIEFFAAMFK(EFDNHOFOELB HMCHHBFEOPH, int ANANLCFKCEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x876EBA0", Offset = "0x876DDA0", VA = "0x18876EBA0")]
	public static MNAGEFHMLHN GCKMDLGNOLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x876F0B0", Offset = "0x876E2B0", VA = "0x18876F0B0")]
	[IteratorStateMachine(typeof(FMKCPANDNGM))]
	private static IEnumerable<ACEAEPPHAPA> MPBGKPLANBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x876D9D0", Offset = "0x876CBD0", VA = "0x18876D9D0")]
	public static ACEAEPPHAPA CHKGDONFCOL(EFDNHOFOELB HMCHHBFEOPH, int ANANLCFKCEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x876D750", Offset = "0x876C950", VA = "0x18876D750")]
	public static bool ABIJGMCBNML(this EFDNHOFOELB HMCHHBFEOPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x876EE90", Offset = "0x876E090", VA = "0x18876EE90")]
	public static void KMAIJLMPEHH(EFDNHOFOELB HMCHHBFEOPH, float3 PBGNKLJNPBH, [Out] NHICBHPHDJP IKLPDFABOKJ, [Out] float3 LLDODDKGLAJ, [Out] float DPENCGPPCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x876E7E0", Offset = "0x876D9E0", VA = "0x18876E7E0")]
	public static void FMCHOMCGBKO(Vector3 PBGNKLJNPBH, EFDNHOFOELB HMCHHBFEOPH, [Out] Vector3 LLDODDKGLAJ, [Out] float DPENCGPPCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x876F0A0", Offset = "0x876E2A0", VA = "0x18876F0A0")]
	[IGODPJDLBLN(0)]
	[MPFAIPJMBCK(GGMCIMEHBME.ExitingPlayMode, 0)]
	private static void MNANCHFBAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x876D770", Offset = "0x876C970", VA = "0x18876D770")]
	[IGODPJDLBLN(0)]
	[MPFAIPJMBCK(GGMCIMEHBME.ExitingPlayMode, 0)]
	private static void AJFPIMBCPKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class PJAMFNLLHBP : PFOKOKEKMHK, IDisposable, NONGDAJBELE
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly GNLIPAPECAL<HEJBBJOONEM, HNALKIGEMDC> EGJHKGGNBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly GNLIPAPECAL<FJJNPNKHKFF, ENKIJDMEIBK> NLKOPLKPKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly GNLIPAPECAL<KDKEMAMEJBC, AIBOJDCNENO> NHBLGOLJHAE;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public HNALKIGEMDC JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x87795F0", Offset = "0x87787F0", VA = "0x1887795F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ENKIJDMEIBK JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8779590", Offset = "0x8778790", VA = "0x188779590", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public AIBOJDCNENO JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8779650", Offset = "0x8778850", VA = "0x188779650", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MBBFPKAOJGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC3460", VA = "0x180DC4260", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAADDE0", Offset = "0xAACFE0", VA = "0x180AADDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x877A050", Offset = "0x8779250", VA = "0x18877A050")]
	public PJAMFNLLHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8779730", Offset = "0x8778930", VA = "0x188779730", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8779890", Offset = "0x8778A90", VA = "0x188779890", Slot = "4")]
	public HEJBBJOONEM FOAPKDBABBO(NPAJLANHHDD DHAOEHNLNON)
	{
		return default(HEJBBJOONEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8779890", Offset = "0x8778A90", VA = "0x188779890", Slot = "5")]
	public HEJBBJOONEM FOAPKDBABBO(NPAJLANHHDD DHAOEHNLNON, bool ICKOPMMOHGJ)
	{
		return default(HEJBBJOONEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x87797C0", Offset = "0x87789C0", VA = "0x1887797C0", Slot = "6")]
	public void FDIEJLHOCJC(HEJBBJOONEM FHPKLENNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x87796B0", Offset = "0x87788B0", VA = "0x1887796B0", Slot = "7")]
	public void DCOMMAACKCB(HEJBBJOONEM FHPKLENNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8779A00", Offset = "0x8778C00", VA = "0x188779A00", Slot = "8")]
	public FJJNPNKHKFF JKNBBMHJGMB(HEJBBJOONEM FHPKLENNKKO, CJMNDOAJBNF DHAOEHNLNON)
	{
		return default(FJJNPNKHKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8779C50", Offset = "0x8778E50", VA = "0x188779C50", Slot = "9")]
	public FJJNPNKHKFF NGKNGGAIEJO(HEJBBJOONEM FHPKLENNKKO, CNEDPOGNDBG DHAOEHNLNON)
	{
		return default(FJJNPNKHKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8779B40", Offset = "0x8778D40", VA = "0x188779B40", Slot = "11")]
	public void LEDNCMJPDAF(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x87799A0", Offset = "0x8778BA0", VA = "0x1887799A0", Slot = "10")]
	public void GOOJOALDKIC(FJJNPNKHKFF FDPAKEMBDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8779820", Offset = "0x8778A20", VA = "0x188779820", Slot = "20")]
	public IEnumerable<Renderer> FFBJLGFKPOE(HEJBBJOONEM FHPKLENNKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8779BD0", Offset = "0x8778DD0", VA = "0x188779BD0", Slot = "12")]
	public KDKEMAMEJBC LHFPEEJOJEA(DKDDHCECMFH DHAOEHNLNON)
	{
		return default(KDKEMAMEJBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8779930", Offset = "0x8778B30", VA = "0x188779930", Slot = "14")]
	public void GDIKKHACIEJ(KDKEMAMEJBC NPAJCEMAICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8779ED0", Offset = "0x87790D0", VA = "0x188779ED0", Slot = "16")]
	public Task PMMBLIBENFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8779D90", Offset = "0x8778F90", VA = "0x188779D90", Slot = "17")]
	public Task OGBGMODGACC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8779E30", Offset = "0x8779030", VA = "0x188779E30", Slot = "18")]
	public Task PGJKOFJNLLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x26A3790", Offset = "0x26A2990", VA = "0x1826A3790", Slot = "19")]
	public void NKBKCEOGLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8779F70", Offset = "0x8779170", VA = "0x188779F70", Slot = "13")]
	public void PNLNEIDOFFC(KDKEMAMEJBC NPAJCEMAICN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EBONKKLLDNI
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool IMIIGIJDAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material JNNMMKEFECJ();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material OCAHNLACFFB();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material PGKONIHAPPK();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MGMCNEMDBOA(EPEJMPHDPHB FJMFFNHCKNB);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NHGIEFLHPOG(KBHAGNPMANG HMHMJJABGOD);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGCIJOEOLPA(GameObject DBCLNEGBNLN);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AFALEHGCPGN(GameObject DBCLNEGBNLN, bool CMBIIPEDPDB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MPDPPGOBABC
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static EBONKKLLDNI AHLPFPPNCPD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool IMIIGIJDAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8774400", Offset = "0x8773600", VA = "0x188774400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x87741A0", Offset = "0x87733A0", VA = "0x1887741A0")]
	public static void FCKFLDBFAEE(EBONKKLLDNI PANDBFFKCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x87742C0", Offset = "0x87734C0", VA = "0x1887742C0")]
	public static Material JNNMMKEFECJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8772090", Offset = "0x8771290", VA = "0x188772090")]
	public static Material OCAHNLACFFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8774460", Offset = "0x8773660", VA = "0x188774460")]
	public static Material PGKONIHAPPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8774320", Offset = "0x8773520", VA = "0x188774320")]
	public static int MGMCNEMDBOA(EPEJMPHDPHB FJMFFNHCKNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8774390", Offset = "0x8773590", VA = "0x188774390")]
	public static int NHGIEFLHPOG(KBHAGNPMANG HMHMJJABGOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x87741F0", Offset = "0x87733F0", VA = "0x1887741F0")]
	public static void JGCIJOEOLPA(GameObject DBCLNEGBNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x87740C0", Offset = "0x87732C0", VA = "0x1887740C0")]
	public static void AFALEHGCPGN(GameObject DBCLNEGBNLN, bool CMBIIPEDPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AIBOJDCNENO : LIEJNKNHCHI
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DHHMHDOLKNA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public AIBOJDCNENO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public DHHMHDOLKNA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x876F5D0", Offset = "0x876E7D0", VA = "0x18876F5D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x876F2B0", Offset = "0x876E4B0", VA = "0x18876F2B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x876F260", Offset = "0x876E460", VA = "0x18876F260")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x876F580", Offset = "0x876E780", VA = "0x18876F580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x876F4D0", Offset = "0x876E6D0", VA = "0x18876F4D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x876F4D0", Offset = "0x876E6D0", VA = "0x18876F4D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DKDDHCECMFH AEIFMAHPBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly NONGDAJBELE OEEIMKOOJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private CODFNAPEACH OGDOANHHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<BMCOLPAPKJG> ILODJHNGNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<BMCOLPAPKJG> POJLBGAMLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject IMKPNCFLAMC;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8767C00", Offset = "0x8766E00", VA = "0x188767C00")]
	public static AIBOJDCNENO CBILKPFLPNG(DKDDHCECMFH DHAOEHNLNON, NONGDAJBELE OEEIMKOOJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8768F60", Offset = "0x8768160", VA = "0x188768F60")]
	private AIBOJDCNENO(DKDDHCECMFH DHAOEHNLNON, NONGDAJBELE OEEIMKOOJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x87687E0", Offset = "0x87679E0", VA = "0x1887687E0")]
	public void GNJBDGKPLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8768C60", Offset = "0x8767E60", VA = "0x188768C60")]
	[IteratorStateMachine(typeof(DHHMHDOLKNA))]
	public IEnumerable<Renderer> HEIGHHBCDCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8767D50", Offset = "0x8766F50", VA = "0x188767D50", Slot = "4")]
	public void FOAJFIJGNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8768CE0", Offset = "0x8767EE0", VA = "0x188768CE0")]
	private void INMIIOAGKJO(Vector3 BLPJCJEDNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8768D10", Offset = "0x8767F10", VA = "0x188768D10")]
	public void IOJFMKAPHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BMCOLPAPKJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct CDAJMCLKGGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CCILIPHKBOG MNICACHIJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AOECEAGCFFM DJLDEHHBJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int DMPEMGFBKKF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DKDOEMKBOPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public BMCOLPAPKJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NNNLBPFEJKG lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<CDAJMCLKGGJ> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PBKMGPOLEJF combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DKDOEMKBOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x876F800", Offset = "0x876EA00", VA = "0x18876F800")]
		internal JobHandle MLBJPLDJHGA()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x876F7D0", Offset = "0x876E9D0", VA = "0x18876F7D0")]
		internal void KPEBKPHHGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x876F660", Offset = "0x876E860", VA = "0x18876F660")]
		internal void ALHFACDGBGK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] KEDPOIDEKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ACONLAJOHMK KHCKKFOFMJP;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 EHGDNFANCEL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh GLJCMIIGKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IIHJCLBFMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x876C5F0", Offset = "0x876B7F0", VA = "0x18876C5F0")]
	public void IDBCBANJBDL(List<AOECEAGCFFM> BCMMPKNKFPL, Matrix4x4[] HOCEFBCHNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x876BF60", Offset = "0x876B160", VA = "0x18876BF60")]
	public static List<BMCOLPAPKJG> EAIFKKLDBGP(List<HNALKIGEMDC> DJMGNPJLOPF, NNNLBPFEJKG ANANLCFKCEG, Bounds FNDKJDJMBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x876BB70", Offset = "0x876AD70", VA = "0x18876BB70")]
	private JobHandle CHBIHOJNLDJ(PBKMGPOLEJF EDADNFECCIF, int MKEEMFLOFJJ, int HGFLJHNNBAG, NNNLBPFEJKG ANANLCFKCEG, List<CDAJMCLKGGJ> CLENLMJMLAE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x876C7D0", Offset = "0x876B9D0", VA = "0x18876C7D0")]
	private void NECELFKFCAM(List<CDAJMCLKGGJ> CLENLMJMLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x876CA40", Offset = "0x876BC40", VA = "0x18876CA40")]
	private BMCOLPAPKJG(List<CDAJMCLKGGJ> CLENLMJMLAE, int MKEEMFLOFJJ, int HGFLJHNNBAG, NNNLBPFEJKG ANANLCFKCEG, Bounds FNDKJDJMBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x876BED0", Offset = "0x876B0D0", VA = "0x18876BED0", Slot = "4")]
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
		private MaterialPropertyBlock GCNKBAKNKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private BMCOLPAPKJG KHKMPBIDLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<AOECEAGCFFM> ELKOPKMBPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture MKOGGPNJDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer KBAENNLLLNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader CKECFJOPCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] AGDMNHKOAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int OODDKFLBIOK;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer OLHJOKDIPFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int IAJNGNBOMAC
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x877B140", Offset = "0x877A340", VA = "0x18877B140")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x877A470", Offset = "0x8779670", VA = "0x18877A470")]
		public static List<SkinnedShapeRenderer> Create(GameObject FHPKLENNKKO, List<BMCOLPAPKJG> CFEMJPGPPKM, List<AOECEAGCFFM> ELKOPKMBPKH, Material OHHEKLKCMJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x877AA70", Offset = "0x8779C70", VA = "0x18877AA70")]
		public void Init(BMCOLPAPKJG KHKMPBIDLPA, List<AOECEAGCFFM> ELKOPKMBPKH, Material OHHEKLKCMJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x877B0A0", Offset = "0x877A2A0", VA = "0x18877B0A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x877B000", Offset = "0x877A200", VA = "0x18877B000")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x877AFC0", Offset = "0x877A1C0", VA = "0x18877AFC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x877AF00", Offset = "0x877A100", VA = "0x18877AF00")]
		private void KHLCBMDMGPK(ScriptableRenderContext OPJOIGJBJKN, Camera[] ILMNDABJLBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x877A700", Offset = "0x8779900", VA = "0x18877A700")]
		private void IDBCBANJBDL(CommandBuffer FHKIEMDLHCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
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
