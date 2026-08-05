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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8EF1450", Offset = "0x8EF0250", VA = "0x188EF1450", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EF83B0", Offset = "0x8EF71B0", VA = "0x188EF83B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GDDLGEKMAPB : IHDLDGPOFHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte EILNGFOMKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] BDCCMDDEGKI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PAHFCADBEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HNAMCMGCIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x107E820", Offset = "0x107D620", VA = "0x18107E820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float EALJFAMGJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x10948F0", Offset = "0x10936F0", VA = "0x1810948F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x15A1790", Offset = "0x15A0590", VA = "0x1815A1790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float AEBIHGDLEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDB5D10", Offset = "0xDB4B10", VA = "0x180DB5D10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDB5D20", Offset = "0xDB4B20", VA = "0x180DB5D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> HLBGOJBMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7580", Offset = "0x8EE6380", VA = "0x188EE7580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> NAMNMCFCDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7550", Offset = "0x8EE6350", VA = "0x188EE7550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject CNGEAHLGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte AKAMGECAIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8EE72E0", Offset = "0x8EE60E0", VA = "0x188EE72E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8EE78C0", Offset = "0x8EE66C0", VA = "0x188EE78C0")]
	public GDDLGEKMAPB(List<OGADDNEPDME> BCOCCODMMKF, List<OGADDNEPDME> MGAILFFLJKP, List<FHLDPOMNGOB> ICNOAEFAAMM, Material GKIFPALLDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7430", Offset = "0x8EE6230", VA = "0x188EE7430")]
	private int FJCJGGGAANL(List<OGADDNEPDME> AIIDMPLADMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7720", Offset = "0x8EE6520", VA = "0x188EE7720")]
	private void KNBDMPKCMDG(int OCENGPKHOGM, bool HEPPDGLDFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8EE75D0", Offset = "0x8EE63D0", VA = "0x188EE75D0")]
	public void KFKBIMEJFGE(Vector3 ONBPAFAGNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7330", Offset = "0x8EE6130", VA = "0x188EE7330", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7880", Offset = "0x8EE6680", VA = "0x188EE7880")]
	public void OGPLLGANJNK(Transform NGPJINBABNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HPJCPCKGCID : GKBNJAPIBHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LCOJKLOOKBA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HPJCPCKGCID <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public LCOJKLOOKBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE650", Offset = "0x8EED450", VA = "0x188EEE650", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDFF0", Offset = "0x8EECDF0", VA = "0x188EEDFF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE500", Offset = "0x8EED300", VA = "0x188EEE500")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDF50", Offset = "0x8EECD50", VA = "0x188EEDF50")]
		private void DFGOGGAACMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDFA0", Offset = "0x8EECDA0", VA = "0x188EEDFA0")]
		private void FOBALDLCGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE600", Offset = "0x8EED400", VA = "0x188EEE600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE550", Offset = "0x8EED350", VA = "0x188EEE550", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE550", Offset = "0x8EED350", VA = "0x188EEE550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LDBDEHPMDCP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HPJCPCKGCID <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public LDBDEHPMDCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8EEED50", Offset = "0x8EEDB50", VA = "0x188EEED50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE890", Offset = "0x8EED690", VA = "0x188EEE890", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEC00", Offset = "0x8EEDA00", VA = "0x188EEEC00")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8EEE840", Offset = "0x8EED640", VA = "0x188EEE840")]
		private void DFGOGGAACMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8EEED00", Offset = "0x8EEDB00", VA = "0x188EEED00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEC50", Offset = "0x8EEDA50", VA = "0x188EEEC50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEC50", Offset = "0x8EEDA50", VA = "0x188EEEC50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IAJEINKKMII JAEOGFCKMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<LAMFKLKDHPE> LINKNCPDMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> MNBBJBFPECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer HNAAOMPHCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool PPJJPNKMMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool LIOFMFLKMON;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<BKEEBOFODIO> PFJMBBMHFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HKMBIAJNDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8EE8230", Offset = "0x8EE7030", VA = "0x188EE8230", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FHLDPOMNGOB KHJLLHMEGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE8630", Offset = "0x8EE7430", VA = "0x188EE8630", Slot = "8")]
		get
		{
			return default(FHLDPOMNGOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> ENMJAFIBEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8EE8840", Offset = "0x8EE7640", VA = "0x188EE8840")]
	private bool LIKKALCCIFI(LAMFKLKDHPE ADPIMLAGACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7F20", Offset = "0x8EE6D20", VA = "0x188EE7F20")]
	private static bool BOIMNCHNDNL(LAMFKLKDHPE ADPIMLAGACM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8EE94F0", Offset = "0x8EE82F0", VA = "0x188EE94F0")]
	public HPJCPCKGCID(IAJEINKKMII KANAIIDGHCH, bool NCGNFMOANPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8EE8440", Offset = "0x8EE7240", VA = "0x188EE8440", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8EE8270", Offset = "0x8EE7070", VA = "0x188EE8270")]
	public void DPHJBDIDPOG(LAMFKLKDHPE ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8EE8860", Offset = "0x8EE7660", VA = "0x188EE8860")]
	public void MDNHCHGJFLC(LAMFKLKDHPE ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8EE89C0", Offset = "0x8EE77C0", VA = "0x188EE89C0", Slot = "4")]
	public void OGOIFPONFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7BE0", Offset = "0x8EE69E0", VA = "0x188EE7BE0")]
	public void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7FF0", Offset = "0x8EE6DF0", VA = "0x188EE7FF0")]
	private void CANAHNONOOB(List<LAMFKLKDHPE> LINKNCPDMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5D60", Offset = "0x8EE4B60", VA = "0x188EE5D60")]
	private static Material MDPBDJAEALJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7F40", Offset = "0x8EE6D40", VA = "0x188EE7F40")]
	private void CANAHNONOOB(LAMFKLKDHPE ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7E50", Offset = "0x8EE6C50", VA = "0x188EE7E50")]
	private void BCJADPJAEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8EE8F40", Offset = "0x8EE7D40", VA = "0x188EE8F40")]
	public void OPONDGOFJKN(bool ADHBEGKPDGM, bool COKKGPDEDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8EE8780", Offset = "0x8EE7580", VA = "0x188EE8780")]
	protected void KAOCDPHIFKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8EE8EC0", Offset = "0x8EE7CC0", VA = "0x188EE8EC0")]
	public void ONHALGAJKNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8EE8700", Offset = "0x8EE7500", VA = "0x188EE8700")]
	[IteratorStateMachine(typeof(LCOJKLOOKBA))]
	public IEnumerable<Renderer> HPMEFFCMPJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8EE81B0", Offset = "0x8EE6FB0", VA = "0x188EE81B0")]
	[IteratorStateMachine(typeof(LDBDEHPMDCP))]
	public IEnumerable<Renderer> CNGOHNDDMHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class ILJECMBJMAN : LAMFKLKDHPE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct FGBPPDJHKKA : ECFCCCOIGKH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PGFPLDMFONK PKBJPDPONKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle CNIEIMLLGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OCMHCDFIFIP FDDGDMKLNAP;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6240", Offset = "0x8EE5040", VA = "0x188EE6240")]
		public FGBPPDJHKKA(PGFPLDMFONK PKBJPDPONKJ, JobHandle CNIEIMLLGJC, OCMHCDFIFIP FDDGDMKLNAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6210", Offset = "0x8EE5010", VA = "0x188EE6210", Slot = "4")]
		public PGFPLDMFONK HNMLKBBINMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8EE61C0", Offset = "0x8EE4FC0", VA = "0x188EE61C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly BJPNHFEILJG CCPHLIKJDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float DLNACCOJDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 ADKLDCJGNNN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 LOLCPFLNLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8EEA730", Offset = "0x8EE9530", VA = "0x188EEA730", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8EEB0F0", Offset = "0x8EE9EF0", VA = "0x188EEB0F0")]
	public ILJECMBJMAN(HPJCPCKGCID MMENCBNBOBJ, BJPNHFEILJG KANAIIDGHCH, bool NCGNFMOANPJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "18")]
	public override bool JIAPEJEMOFF(FHLDPOMNGOB MMENCBNBOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8EEA550", Offset = "0x8EE9350", VA = "0x188EEA550", Slot = "19")]
	public override int FJCJGGGAANL(GJNDJKNGBFN GOLHBMLDEPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8EE9AF0", Offset = "0x8EE88F0", VA = "0x188EE9AF0", Slot = "20")]
	public override int CNACINKEGJP(GJNDJKNGBFN GOLHBMLDEPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8EEA860", Offset = "0x8EE9660", VA = "0x188EEA860", Slot = "21")]
	public override OHMNJPKCEIH NCKLBDMOHAM()
	{
		return default(OHMNJPKCEIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC387F0", Offset = "0xC375F0", VA = "0x180C387F0", Slot = "22")]
	public override float FIDEJMDPIGG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8EE95E0", Offset = "0x8EE83E0", VA = "0x188EE95E0", Slot = "23")]
	public override void AAMDGBMFMCJ(GJNDJKNGBFN GOLHBMLDEPN, MCIGJBLBCLF AMBOHHPAFBM, int PCCNFLKIFNO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8EEAD50", Offset = "0x8EE9B50", VA = "0x188EEAD50")]
	private int NNNIFAAIIEF(GJNDJKNGBFN GOLHBMLDEPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8EEA480", Offset = "0x8EE9280", VA = "0x188EEA480", Slot = "24")]
	public override FHLDPOMNGOB EIOANADDEND()
	{
		return default(FHLDPOMNGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8EEAF40", Offset = "0x8EE9D40", VA = "0x188EEAF40", Slot = "26")]
	public override PHMDKAGLNFO OAFDGNFNAJH()
	{
		return default(PHMDKAGLNFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8EE9CD0", Offset = "0x8EE8AD0", VA = "0x188EE9CD0", Slot = "27")]
	public override ECFCCCOIGKH DJBOLMEADNB(GJNDJKNGBFN GOLHBMLDEPN, JobHandle CNIEIMLLGJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface FPJJNHFIGEG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	HPJCPCKGCID ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	LAMFKLKDHPE ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BOOMGOHKJMB ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class LMFOMALNGLC : DBDEJHBHIBB, IDisposable, FPJJNHFIGEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JEGDPECEFCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LMFOMALNGLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB1A0", Offset = "0x8EE9FA0", VA = "0x188EEB1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8EEB700", Offset = "0x8EEA500", VA = "0x188EEB700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MKBANPGEJBM<AIOBPENNHGA, HPJCPCKGCID> KGOGDAAPOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly MKBANPGEJBM<KCPCCONBFEI, LAMFKLKDHPE> LINKNCPDMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly MKBANPGEJBM<JOCJDJNIODG, BOOMGOHKJMB> GDNHKEGFFGM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public HPJCPCKGCID ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEEE0", Offset = "0x8EEDCE0", VA = "0x188EEEEE0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public LAMFKLKDHPE ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEF40", Offset = "0x8EEDD40", VA = "0x188EEEF40", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BOOMGOHKJMB ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8EEEE80", Offset = "0x8EEDC80", VA = "0x188EEEE80", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DEFMFMGHCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC01980", Offset = "0xC00780", VA = "0x180C01980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8EF0FD0", Offset = "0x8EEFDD0", VA = "0x188EF0FD0")]
	public LMFOMALNGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8EEF3C0", Offset = "0x8EEE1C0", VA = "0x188EEF3C0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8EF0ED0", Offset = "0x8EEFCD0", VA = "0x188EF0ED0", Slot = "4")]
	public AIOBPENNHGA OAFJDPCFEBF(IAJEINKKMII KANAIIDGHCH)
	{
		return default(AIOBPENNHGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8EF0C60", Offset = "0x8EEFA60", VA = "0x188EF0C60", Slot = "5")]
	public AIOBPENNHGA OAFJDPCFEBF(IAJEINKKMII KANAIIDGHCH, bool NCGNFMOANPJ)
	{
		return default(AIOBPENNHGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8EF0A10", Offset = "0x8EEF810", VA = "0x188EF0A10", Slot = "6")]
	public void NICKHCPLNGJ(AIOBPENNHGA MMENCBNBOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8EEEFA0", Offset = "0x8EEDDA0", VA = "0x188EEEFA0", Slot = "7")]
	public void AJNDLCBPPOK(AIOBPENNHGA MMENCBNBOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8EEF870", Offset = "0x8EEE670", VA = "0x188EEF870", Slot = "8")]
	public KCPCCONBFEI GNINEJNLKDG(AIOBPENNHGA MMENCBNBOBJ, EFOEIEPCHCP KANAIIDGHCH)
	{
		return default(KCPCCONBFEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8EEFD30", Offset = "0x8EEEB30", VA = "0x188EEFD30", Slot = "9")]
	public KCPCCONBFEI HHHJOLIMKJM(AIOBPENNHGA MMENCBNBOBJ, BJPNHFEILJG KANAIIDGHCH)
	{
		return default(KCPCCONBFEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8EF01F0", Offset = "0x8EEEFF0", VA = "0x188EF01F0", Slot = "11")]
	public void JEFFOACGFOK(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8EF07C0", Offset = "0x8EEF5C0", VA = "0x188EF07C0", Slot = "10")]
	public void MPLGBLJFEKL(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8EF0750", Offset = "0x8EEF550", VA = "0x188EF0750", Slot = "20")]
	public IEnumerable<Renderer> MNKLHPACOBJ(AIOBPENNHGA MMENCBNBOBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8EEF340", Offset = "0x8EEE140", VA = "0x188EEF340", Slot = "12")]
	public JOCJDJNIODG DODPHCCHLBO(ELHKINMILFE KANAIIDGHCH)
	{
		return default(JOCJDJNIODG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8EEF800", Offset = "0x8EEE600", VA = "0x188EEF800", Slot = "14")]
	public void GJNIAJCDKMO(JOCJDJNIODG JGIOJIOGBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8EF0590", Offset = "0x8EEF390", VA = "0x188EF0590", Slot = "16")]
	public Task LNOIOICHMDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8EEF650", Offset = "0x8EEE450", VA = "0x188EEF650", Slot = "17")]
	public Task GCNPHGDCJOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8EEF580", Offset = "0x8EEE380", VA = "0x188EEF580", Slot = "18")]
	[AsyncStateMachine(typeof(JEGDPECEFCM))]
	public Task EJAFGFLEAAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8EF0EE0", Offset = "0x8EEFCE0", VA = "0x188EF0EE0", Slot = "19")]
	public void PPDDGKAGKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8EEF2E0", Offset = "0x8EEE0E0", VA = "0x188EEF2E0", Slot = "13")]
	public void CDIKDFAHGGA(JOCJDJNIODG JGIOJIOGBJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class JOKHNAHFKEP : LAMFKLKDHPE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct KCLAAJDHEEL : ECFCCCOIGKH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private PGFPLDMFONK PKBJPDPONKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> NODHIPEDHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle CNIEIMLLGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private NLNCKOPEPIL FDDGDMKLNAP;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDD00", Offset = "0x8EECB00", VA = "0x188EEDD00")]
		public KCLAAJDHEEL(PGFPLDMFONK PKBJPDPONKJ, NativeArray<int> NODHIPEDHBB, JobHandle CNIEIMLLGJC, NLNCKOPEPIL FDDGDMKLNAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDCA0", Offset = "0x8EECAA0", VA = "0x188EEDCA0", Slot = "4")]
		public PGFPLDMFONK HNMLKBBINMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDC00", Offset = "0x8EECA00", VA = "0x188EEDC00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly EFOEIEPCHCP CFOLCKLFPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] GMPIHNFENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 ADKLDCJGNNN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 BMOPLDGEIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8EECAA0", Offset = "0x8EEB8A0", VA = "0x188EECAA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 LOLCPFLNLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8EECFA0", Offset = "0x8EEBDA0", VA = "0x188EECFA0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8EEDB50", Offset = "0x8EEC950", VA = "0x188EEDB50")]
	public JOKHNAHFKEP(HPJCPCKGCID MMENCBNBOBJ, EFOEIEPCHCP KANAIIDGHCH, bool HALNCDPFNAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8EECED0", Offset = "0x8EEBCD0", VA = "0x188EECED0", Slot = "18")]
	public override bool JIAPEJEMOFF(FHLDPOMNGOB MMENCBNBOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8EED350", Offset = "0x8EEC150", VA = "0x188EED350", Slot = "21")]
	public override OHMNJPKCEIH NCKLBDMOHAM()
	{
		return default(OHMNJPKCEIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8EED390", Offset = "0x8EEC190", VA = "0x188EED390")]
	private OHMNJPKCEIH NCKLBDMOHAM(FHLDPOMNGOB MMENCBNBOBJ)
	{
		return default(OHMNJPKCEIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8EECCD0", Offset = "0x8EEBAD0", VA = "0x188EECCD0")]
	private DLDPDDLPHEE HOAKBBBAEDL([In] UniformTRS GOGCFENDHDJ, [In] float3 PGJHMIHCLNJ)
	{
		return default(DLDPDDLPHEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8EEC9F0", Offset = "0x8EEB7F0", VA = "0x188EEC9F0", Slot = "19")]
	public override int FJCJGGGAANL(GJNDJKNGBFN GOLHBMLDEPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8EEBFB0", Offset = "0x8EEADB0", VA = "0x188EEBFB0", Slot = "20")]
	public override int CNACINKEGJP(GJNDJKNGBFN GOLHBMLDEPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8EEC900", Offset = "0x8EEB700", VA = "0x188EEC900", Slot = "22")]
	public override float FIDEJMDPIGG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8EED0D0", Offset = "0x8EEBED0", VA = "0x188EED0D0")]
	private int KGDFBCENMOH(GJNDJKNGBFN GOLHBMLDEPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8EEB760", Offset = "0x8EEA560", VA = "0x188EEB760", Slot = "23")]
	public override void AAMDGBMFMCJ(GJNDJKNGBFN GOLHBMLDEPN, MCIGJBLBCLF AMBOHHPAFBM, int PCCNFLKIFNO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8EEC830", Offset = "0x8EEB630", VA = "0x188EEC830", Slot = "24")]
	public override FHLDPOMNGOB EIOANADDEND()
	{
		return default(FHLDPOMNGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8EED9A0", Offset = "0x8EEC7A0", VA = "0x188EED9A0", Slot = "26")]
	public override PHMDKAGLNFO OAFDGNFNAJH()
	{
		return default(PHMDKAGLNFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8EEC060", Offset = "0x8EEAE60", VA = "0x188EEC060", Slot = "27")]
	public override ECFCCCOIGKH DJBOLMEADNB(GJNDJKNGBFN GOLHBMLDEPN, JobHandle CNIEIMLLGJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NJCJLLOPKGD
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBNBONHMIGH(IEHEPMCODHJ ADGMECOLKNH, Renderer NNEJGKAIJNN, int PDAJODCOHOK);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEEAKMPLGAD(Renderer NNEJGKAIJNN, EPEOJONAFBI JNPOLDJJOIO, Vector3 BFLEHPDKJDC, Vector3 MIANHKJJJDC, Vector3 FLFKHAKCAHC, float NHKAFPMDINO, float LEPKEOKNGCF, float ONEOPHMNFBK = -1f, [Optional] Color? BGBIPHDMBPB, [Optional] IReadOnlyList<Camera> HFIHHLPGCGK);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECMCKLKANAJ(Renderer NNEJGKAIJNN, int PDAJODCOHOK);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HPBINNAPADM();

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOAMDAMJKCM(int JFDHFALMMAH, EHMIJFGJLBH ADGMECOLKNH, Renderer NNEJGKAIJNN, int PDAJODCOHOK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MOMOEGPNLPN : CNCKGAMCPLB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class PNFDFCKGDPG : IPDPJFOFMFA<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6ED0", Offset = "0x8EF5CD0", VA = "0x188EF6ED0")]
		public PNFDFCKGDPG(string PFLDDMDPCBI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NJCJLLOPKGD ADBIOOCBOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly FPJJNHFIGEG LCMJNPILLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer FLGCODELMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private PNFDFCKGDPG FBONHHFCMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool HIHLNLJOGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer NOHAKPIFAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private PNFDFCKGDPG IHJANMAINMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool FFJOCDFEIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer FANANLLOOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private PNFDFCKGDPG LCDNLNBFIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool JKAFNIAHINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool JAABGCKHGLN;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
	public MOMOEGPNLPN(NJCJLLOPKGD LNCBLGCJBKL, FPJJNHFIGEG LCMJNPILLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8EF21E0", Offset = "0x8EF0FE0", VA = "0x188EF21E0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1A40", Offset = "0x8EF0840", VA = "0x188EF1A40")]
	private void BEHCEHENMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1ED0", Offset = "0x8EF0CD0", VA = "0x188EF1ED0", Slot = "4")]
	public void CJLMNHKBGKI(AIOBPENNHGA MMENCBNBOBJ, EHMIJFGJLBH FNIKNONFPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1CB0", Offset = "0x8EF0AB0", VA = "0x188EF1CB0", Slot = "5")]
	public void CJLMNHKBGKI(KCPCCONBFEI ADPIMLAGACM, EHMIJFGJLBH FNIKNONFPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1670", Offset = "0x8EF0470", VA = "0x188EF1670", Slot = "6")]
	public void AKNCIJEBKDP(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8EF1520", Offset = "0x8EF0320", VA = "0x188EF1520", Slot = "7")]
	public void AEEJFMDOKPC(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8EF3E90", Offset = "0x8EF2C90", VA = "0x188EF3E90", Slot = "24")]
	public void OIIEEOAHGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1428F70", Offset = "0x1427D70", VA = "0x181428F70", Slot = "8")]
	public void CBMOLOOALMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8EF3D20", Offset = "0x8EF2B20", VA = "0x188EF3D20", Slot = "9")]
	public void OEIAGMPBGFB(EHMIJFGJLBH FNIKNONFPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8EF2820", Offset = "0x8EF1620", VA = "0x188EF2820", Slot = "10")]
	public void EKGPCJOGAFH(AIOBPENNHGA MMENCBNBOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8EF24C0", Offset = "0x8EF12C0", VA = "0x188EF24C0", Slot = "11")]
	public void EKGPCJOGAFH(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8EF3100", Offset = "0x8EF1F00", VA = "0x188EF3100", Slot = "12")]
	public void JOLJGCNGIEF(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8EF2E40", Offset = "0x8EF1C40", VA = "0x188EF2E40", Slot = "13")]
	public void IBGIOGNBFJG(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8EF17D0", Offset = "0x8EF05D0", VA = "0x188EF17D0")]
	private void BCMFEOOBMEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x15D4EC0", Offset = "0x15D3CC0", VA = "0x1815D4EC0", Slot = "14")]
	public void MNKBDCNGHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8EF2FE0", Offset = "0x8EF1DE0", VA = "0x188EF2FE0", Slot = "15")]
	public void IPKIFCMFDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8EF3A40", Offset = "0x8EF2840", VA = "0x188EF3A40", Slot = "16")]
	public void MANNKGLPGHM(AIOBPENNHGA MMENCBNBOBJ, IEHEPMCODHJ ADGMECOLKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8EF2D70", Offset = "0x8EF1B70", VA = "0x188EF2D70", Slot = "17")]
	public void GDNDIBDOOPF(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8EF2F10", Offset = "0x8EF1D10", VA = "0x188EF2F10", Slot = "18")]
	public void IEAKBPDAGJB(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xE05600", Offset = "0xE04400", VA = "0x180E05600", Slot = "19")]
	public void FFGIAIJAHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8EF2390", Offset = "0x8EF1190", VA = "0x188EF2390", Slot = "20")]
	public void EAIDDCAECNI(IEHEPMCODHJ ADGMECOLKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8EF2B00", Offset = "0x8EF1900", VA = "0x188EF2B00")]
	private void EPFHEEOJBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8EF3670", Offset = "0x8EF2470", VA = "0x188EF3670", Slot = "21")]
	public void KMBDHGPMMIP(AIOBPENNHGA MMENCBNBOBJ, Vector3 BFLEHPDKJDC, Vector3 MIANHKJJJDC, Vector3 FLFKHAKCAHC, float NHKAFPMDINO, float LEPKEOKNGCF, IReadOnlyList<Camera> DKPDKPBPAPM, EPEOJONAFBI JNPOLDJJOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8EF31D0", Offset = "0x8EF1FD0", VA = "0x188EF31D0", Slot = "22")]
	public void KMBDHGPMMIP(JOCJDJNIODG JGIOJIOGBJM, Vector3 BFLEHPDKJDC, Vector3 MIANHKJJJDC, Vector3 FLFKHAKCAHC, float NHKAFPMDINO, float LEPKEOKNGCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class LAMFKLKDHPE : MHIIGIDBEIK, BKEEBOFODIO, DAICJLPBHOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly HPJCPCKGCID CNGEAHLGPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int BDHODNOHBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds PJLGGPMHKKD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds HNPFEDMHHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8EEDD60", Offset = "0x8EECB60", VA = "0x188EEDD60", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool LIOFMFLKMON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xF01590", Offset = "0xF00390", VA = "0x180F01590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xF17A70", Offset = "0xF16870", VA = "0x180F17A70")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 LOLCPFLNLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MJPEIPMBIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xC21FD0", Offset = "0xC20DD0", VA = "0x180C21FD0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public PKLKMEOFKLC IGDBGOFPADC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HLOPFLAKMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x22DFEA0", Offset = "0x22DECA0", VA = "0x1822DFEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	protected LAMFKLKDHPE(HPJCPCKGCID MMENCBNBOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8EEDD80", Offset = "0x8EECB80", VA = "0x188EEDD80", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "18")]
	public virtual bool JIAPEJEMOFF(FHLDPOMNGOB MMENCBNBOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8EEDEE0", Offset = "0x8EECCE0", VA = "0x188EEDEE0", Slot = "10")]
	public int FDEOJLGGJAJ(int FJPAAGDMDLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int FJCJGGGAANL(GJNDJKNGBFN GOLHBMLDEPN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int CNACINKEGJP(GJNDJKNGBFN GOLHBMLDEPN);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract OHMNJPKCEIH NCKLBDMOHAM();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float FIDEJMDPIGG();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void AAMDGBMFMCJ(GJNDJKNGBFN GOLHBMLDEPN, MCIGJBLBCLF AMBOHHPAFBM, int PCCNFLKIFNO = -1);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract FHLDPOMNGOB EIOANADDEND();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8EEDF20", Offset = "0x8EECD20", VA = "0x188EEDF20", Slot = "13")]
	public Hash128 MLOMKNFOFNC(int GOLHBMLDEPN)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract PHMDKAGLNFO OAFDGNFNAJH();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract ECFCCCOIGKH DJBOLMEADNB(GJNDJKNGBFN GOLHBMLDEPN, JobHandle CNIEIMLLGJC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8EEDEF0", Offset = "0x8EECCF0", VA = "0x188EEDEF0", Slot = "12")]
	public ECFCCCOIGKH HHKCKLJKNAN(int GOLHBMLDEPN)
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
		[Cpp2IlInjected.Address(RVA = "0x8EF6F20", Offset = "0x8EF5D20", VA = "0x188EF6F20")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OLJKPELMBEF
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FPHHOAEGKMJ : IEnumerable<AIKDIMDMDPP>, IEnumerable, IEnumerator<AIKDIMDMDPP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private AIKDIMDMDPP <>2__current;

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
		private AIKDIMDMDPP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public FPHHOAEGKMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7120", Offset = "0x8EE5F20", VA = "0x188EE7120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7290", Offset = "0x8EE6090", VA = "0x188EE7290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8EE71F0", Offset = "0x8EE5FF0", VA = "0x188EE71F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AIKDIMDMDPP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8EE71F0", Offset = "0x8EE5FF0", VA = "0x188EE71F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static AIKDIMDMDPP[][] FIOOKJOLEOO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static DIONDCFLDIE MIPBODBAFIJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig COCIPJEJEFN;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader IDNGHHGHKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6B80", Offset = "0x8EF5980", VA = "0x188EF6B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer ALEAGALCHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8EF51E0", Offset = "0x8EF3FE0", VA = "0x188EF51E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8EF5400", Offset = "0x8EF4200", VA = "0x188EF5400")]
	[NCBGFGMJMIH]
	internal static void IEHCJBEIMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8EF5700", Offset = "0x8EF4500", VA = "0x188EF5700")]
	public static Mesh JEEMGFBAFHH(ALLMNIBKHFE LIOLFALCPLH, int GOLHBMLDEPN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8EF51D0", Offset = "0x8EF3FD0", VA = "0x188EF51D0")]
	public static int DCEMLMABCNE(ALLMNIBKHFE LIOLFALCPLH, int GOLHBMLDEPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8EF54E0", Offset = "0x8EF42E0", VA = "0x188EF54E0")]
	public static DIONDCFLDIE IKLNGMPIMIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8EF57A0", Offset = "0x8EF45A0", VA = "0x188EF57A0")]
	[IteratorStateMachine(typeof(FPHHOAEGKMJ))]
	private static IEnumerable<AIKDIMDMDPP> JKOJJHODIIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8EF5D80", Offset = "0x8EF4B80", VA = "0x188EF5D80")]
	public static AIKDIMDMDPP MHIKBBAEEGA(ALLMNIBKHFE LIOLFALCPLH, int GOLHBMLDEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8EF56E0", Offset = "0x8EF44E0", VA = "0x188EF56E0")]
	public static bool IOANFDMHHHC(this ALLMNIBKHFE LIOLFALCPLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8EF5250", Offset = "0x8EF4050", VA = "0x188EF5250")]
	public static void HLNEABHEINJ(ALLMNIBKHFE LIOLFALCPLH, float3 FBJGOIIDPCA, [Out] AONHONFLELC CEAHEMNLEDA, [Out] float3 MFJGLBNKHHO, [Out] float FHCKLKECAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8EF5800", Offset = "0x8EF4600", VA = "0x188EF5800")]
	public static void JOGGKGMOENI(Vector3 FBJGOIIDPCA, ALLMNIBKHFE LIOLFALCPLH, [Out] Vector3 MFJGLBNKHHO, [Out] float FHCKLKECAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8EF5240", Offset = "0x8EF4040", VA = "0x188EF5240")]
	[CFNGHJFIHMP(0)]
	[NPBBODEJCMJ(NJGOLKIDIIP.ExitingPlayMode, 0)]
	private static void FNGJMOOHGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8EF5BC0", Offset = "0x8EF49C0", VA = "0x188EF5BC0")]
	[CFNGHJFIHMP(0)]
	[NPBBODEJCMJ(NJGOLKIDIIP.ExitingPlayMode, 0)]
	private static void MEHIFLIOEKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class FHCBKHJGPMF : DBDEJHBHIBB, IDisposable, FPJJNHFIGEG
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly MKBANPGEJBM<AIOBPENNHGA, HPJCPCKGCID> KGOGDAAPOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly MKBANPGEJBM<KCPCCONBFEI, LAMFKLKDHPE> LINKNCPDMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly MKBANPGEJBM<JOCJDJNIODG, BOOMGOHKJMB> GDNHKEGFFGM;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public HPJCPCKGCID ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6300", Offset = "0x8EE5100", VA = "0x188EE6300", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public LAMFKLKDHPE ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6360", Offset = "0x8EE5160", VA = "0x188EE6360", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BOOMGOHKJMB ABJADGGNFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8EE62A0", Offset = "0x8EE50A0", VA = "0x188EE62A0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DEFMFMGHCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xC01980", Offset = "0xC00780", VA = "0x180C01980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6D60", Offset = "0x8EE5B60", VA = "0x188EE6D60")]
	public FHCBKHJGPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6520", Offset = "0x8EE5320", VA = "0x188EE6520", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6C40", Offset = "0x8EE5A40", VA = "0x188EE6C40", Slot = "4")]
	public AIOBPENNHGA OAFJDPCFEBF(IAJEINKKMII KANAIIDGHCH)
	{
		return default(AIOBPENNHGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6C40", Offset = "0x8EE5A40", VA = "0x188EE6C40", Slot = "5")]
	public AIOBPENNHGA OAFJDPCFEBF(IAJEINKKMII KANAIIDGHCH, bool NCGNFMOANPJ)
	{
		return default(AIOBPENNHGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6BE0", Offset = "0x8EE59E0", VA = "0x188EE6BE0", Slot = "6")]
	public void NICKHCPLNGJ(AIOBPENNHGA MMENCBNBOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8EE63C0", Offset = "0x8EE51C0", VA = "0x188EE63C0", Slot = "7")]
	public void AJNDLCBPPOK(AIOBPENNHGA MMENCBNBOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6760", Offset = "0x8EE5560", VA = "0x188EE6760", Slot = "8")]
	public KCPCCONBFEI GNINEJNLKDG(AIOBPENNHGA MMENCBNBOBJ, EFOEIEPCHCP KANAIIDGHCH)
	{
		return default(KCPCCONBFEI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8EE68A0", Offset = "0x8EE56A0", VA = "0x188EE68A0", Slot = "9")]
	public KCPCCONBFEI HHHJOLIMKJM(AIOBPENNHGA MMENCBNBOBJ, BJPNHFEILJG KANAIIDGHCH)
	{
		return default(KCPCCONBFEI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8EE69E0", Offset = "0x8EE57E0", VA = "0x188EE69E0", Slot = "11")]
	public void JEFFOACGFOK(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6B80", Offset = "0x8EE5980", VA = "0x188EE6B80", Slot = "10")]
	public void MPLGBLJFEKL(KCPCCONBFEI ADPIMLAGACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6B10", Offset = "0x8EE5910", VA = "0x188EE6B10", Slot = "20")]
	public IEnumerable<Renderer> MNKLHPACOBJ(AIOBPENNHGA MMENCBNBOBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8EE64A0", Offset = "0x8EE52A0", VA = "0x188EE64A0", Slot = "12")]
	public JOCJDJNIODG DODPHCCHLBO(ELHKINMILFE KANAIIDGHCH)
	{
		return default(JOCJDJNIODG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8EE66F0", Offset = "0x8EE54F0", VA = "0x188EE66F0", Slot = "14")]
	public void GJNIAJCDKMO(JOCJDJNIODG JGIOJIOGBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6A70", Offset = "0x8EE5870", VA = "0x188EE6A70", Slot = "16")]
	public Task LNOIOICHMDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6650", Offset = "0x8EE5450", VA = "0x188EE6650", Slot = "17")]
	public Task GCNPHGDCJOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8EE65B0", Offset = "0x8EE53B0", VA = "0x188EE65B0", Slot = "18")]
	public Task EJAFGFLEAAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x296F140", Offset = "0x296DF40", VA = "0x18296F140", Slot = "19")]
	public void PPDDGKAGKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6440", Offset = "0x8EE5240", VA = "0x188EE6440", Slot = "13")]
	public void CDIKDFAHGGA(JOCJDJNIODG JGIOJIOGBJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OPIMAHLJKPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool BALEGGCOMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material GIKEMJBLOEC();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material MDPBDJAEALJ();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material EDIKMLDLGPG();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HGAOACEKMIG(BEIEMLGIDNI HELEFKLFCJL);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ELBAIJBMIAD(PFNNFGPAHBA DNHCFKHCDDL);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCEFIIFGKAD(GameObject ALGAKMGCCLO);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JABJFFKLIIN(GameObject ALGAKMGCCLO, bool BHOKCPJPJFH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CFKMEPPMCOM
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static OPIMAHLJKPJ ICNBLBLHJLK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool BALEGGCOMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5B60", Offset = "0x8EE4960", VA = "0x188EE5B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5D10", Offset = "0x8EE4B10", VA = "0x188EE5D10")]
	public static void MDKLAJHPCHJ(OPIMAHLJKPJ DPGIFJOOCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5B00", Offset = "0x8EE4900", VA = "0x188EE5B00")]
	public static Material GIKEMJBLOEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5D60", Offset = "0x8EE4B60", VA = "0x188EE5D60")]
	public static Material MDPBDJAEALJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5A30", Offset = "0x8EE4830", VA = "0x188EE5A30")]
	public static Material EDIKMLDLGPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5BC0", Offset = "0x8EE49C0", VA = "0x188EE5BC0")]
	public static int HGAOACEKMIG(BEIEMLGIDNI HELEFKLFCJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5A90", Offset = "0x8EE4890", VA = "0x188EE5A90")]
	public static int ELBAIJBMIAD(PFNNFGPAHBA DNHCFKHCDDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5950", Offset = "0x8EE4750", VA = "0x188EE5950")]
	public static void DCEFIIFGKAD(GameObject ALGAKMGCCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5C30", Offset = "0x8EE4A30", VA = "0x188EE5C30")]
	public static void JABJFFKLIIN(GameObject ALGAKMGCCLO, bool BHOKCPJPJFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BOOMGOHKJMB : GKBNJAPIBHJ
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CLCOIKIKPBB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BOOMGOHKJMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public CLCOIKIKPBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6130", Offset = "0x8EE4F30", VA = "0x188EE6130", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5DC0", Offset = "0x8EE4BC0", VA = "0x188EE5DC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8EE5FE0", Offset = "0x8EE4DE0", VA = "0x188EE5FE0")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8EE60E0", Offset = "0x8EE4EE0", VA = "0x188EE60E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6030", Offset = "0x8EE4E30", VA = "0x188EE6030", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE6030", Offset = "0x8EE4E30", VA = "0x188EE6030", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly ELHKINMILFE LNMHLNCFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly FPJJNHFIGEG LCMJNPILLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GDDLGEKMAPB ACEEMFDCCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<OGADDNEPDME> CELPKHIJGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<OGADDNEPDME> EMLJGGAAKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject GBHLGNGFJDF;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8EE4C70", Offset = "0x8EE3A70", VA = "0x188EE4C70")]
	public static BOOMGOHKJMB JOHAOFILDFC(ELHKINMILFE KANAIIDGHCH, FPJJNHFIGEG LCMJNPILLGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5870", Offset = "0x8EE4670", VA = "0x188EE5870")]
	private BOOMGOHKJMB(ELHKINMILFE KANAIIDGHCH, FPJJNHFIGEG LCMJNPILLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8EE4770", Offset = "0x8EE3570", VA = "0x188EE4770")]
	public void FFICDEPBOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8EE4BF0", Offset = "0x8EE39F0", VA = "0x188EE4BF0")]
	[IteratorStateMachine(typeof(CLCOIKIKPBB))]
	public IEnumerable<Renderer> HPMEFFCMPJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8EE4DC0", Offset = "0x8EE3BC0", VA = "0x188EE4DC0", Slot = "4")]
	public void OGOIFPONFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8EE4740", Offset = "0x8EE3540", VA = "0x188EE4740")]
	private void CIBIKHBGHEO(Vector3 ONBPAFAGNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8EE44F0", Offset = "0x8EE32F0", VA = "0x188EE44F0")]
	public void AFCEEABIEMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OGADDNEPDME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct COGDONLHOHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public MCIGJBLBCLF KIOHACEEANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public FHLDPOMNGOB MELPKINFIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int GNCPEAPAKHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PMNKIMPIOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public OGADDNEPDME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public GJNDJKNGBFN lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<COGDONLHOHK> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PGFPLDMFONK combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PMNKIMPIOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6E70", Offset = "0x8EF5C70", VA = "0x188EF6E70")]
		internal JobHandle LHBPIFBKPOF()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6CD0", Offset = "0x8EF5AD0", VA = "0x188EF6CD0")]
		internal void GOIEMHKCLNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6D00", Offset = "0x8EF5B00", VA = "0x188EF6D00")]
		internal void LDCKHOKAJJC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] NHJMKBAOFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JDHPOFCIKGP FOJKAPOFMAC;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 PPMKMFMJCBK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh PGMEGDLHIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int FCGFHPMOEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8EF43B0", Offset = "0x8EF31B0", VA = "0x188EF43B0")]
	public void IAFKHIEHLIM(List<FHLDPOMNGOB> EKLFBAFCBMG, Matrix4x4[] AAHFBFGIEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8EF4590", Offset = "0x8EF3390", VA = "0x188EF4590")]
	public static List<OGADDNEPDME> INIHOJCCLPM(List<HPJCPCKGCID> PNMEJHCNJGL, GJNDJKNGBFN GOLHBMLDEPN, Bounds LGMOAABAAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8EF3ED0", Offset = "0x8EF2CD0", VA = "0x188EF3ED0")]
	private JobHandle BKHOFOJLHGL(PGFPLDMFONK MFAJOPNGHMJ, int DGKBJPHJIGI, int BHCDFJNJKKN, GJNDJKNGBFN GOLHBMLDEPN, List<COGDONLHOHK> BOPJNJDLOAE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8EF42D0", Offset = "0x8EF30D0", VA = "0x188EF42D0")]
	private void FLHCDBNEOAO(List<COGDONLHOHK> BOPJNJDLOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8EF4DB0", Offset = "0x8EF3BB0", VA = "0x188EF4DB0")]
	private OGADDNEPDME(List<COGDONLHOHK> BOPJNJDLOAE, int DGKBJPHJIGI, int BHCDFJNJKKN, GJNDJKNGBFN GOLHBMLDEPN, Bounds LGMOAABAAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8EF4230", Offset = "0x8EF3030", VA = "0x188EF4230", Slot = "4")]
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
		private MaterialPropertyBlock AKPOPFAGDJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private OGADDNEPDME PKBJPDPONKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<FHLDPOMNGOB> ICNOAEFAAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture FFAMJIFGDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer AFPAKEHLHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader BLHKACGNPIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] AIDOPLONIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int EPGHKCBMIIN;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer GNEPJHGPILD
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int JHHBKBIMNLO
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8EF7C50", Offset = "0x8EF6A50", VA = "0x188EF7C50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6F80", Offset = "0x8EF5D80", VA = "0x188EF6F80")]
		public static List<SkinnedShapeRenderer> Create(GameObject MMENCBNBOBJ, List<OGADDNEPDME> AIIDMPLADMN, List<FHLDPOMNGOB> ICNOAEFAAMM, Material GKIFPALLDIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7580", Offset = "0x8EF6380", VA = "0x188EF7580")]
		public void Init(OGADDNEPDME PKBJPDPONKJ, List<FHLDPOMNGOB> ICNOAEFAAMM, Material GKIFPALLDIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7BB0", Offset = "0x8EF69B0", VA = "0x188EF7BB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7B10", Offset = "0x8EF6910", VA = "0x188EF7B10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7AD0", Offset = "0x8EF68D0", VA = "0x188EF7AD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7A10", Offset = "0x8EF6810", VA = "0x188EF7A10")]
		private void JPNFJBLIPMI(ScriptableRenderContext KKBNGKDBMPF, Camera[] EMBBDGPFNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7210", Offset = "0x8EF6010", VA = "0x188EF7210")]
		private void IAFKHIEHLIM(CommandBuffer ELOEPMLDMON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
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
