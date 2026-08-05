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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75C5A40", Offset = "0x75C4440", VA = "0x1875C5A40", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HJJBNOPDMKA : MOAMBMMBALK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte IHPIHHNBGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] JEEAMHGBKFO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KCIKJBNFDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x941880", Offset = "0x940280", VA = "0x180941880", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D22F0", Offset = "0x9D0CF0", VA = "0x1809D22F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JOKMOKEKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D79A0", Offset = "0x8D63A0", VA = "0x1808D79A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D70B0", Offset = "0x8D5AB0", VA = "0x1808D70B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float EAHNBEMDIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9CB070", Offset = "0x9C9A70", VA = "0x1809CB070", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC32310", Offset = "0xC30D10", VA = "0x180C32310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CGHEOIKNBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9CB060", Offset = "0x9C9A60", VA = "0x1809CB060", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x151CFC0", Offset = "0x151B9C0", VA = "0x18151CFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> KGCNIGOHDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75BE620", Offset = "0x75BD020", VA = "0x1875BE620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> KIPFDCHFAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75BE920", Offset = "0x75BD320", VA = "0x1875BE920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89D6A0", Offset = "0x89C0A0", VA = "0x18089D6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte FNFDEGAGMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x75BE370", Offset = "0x75BCD70", VA = "0x1875BE370", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x75BE950", Offset = "0x75BD350", VA = "0x1875BE950")]
	public HJJBNOPDMKA(List<LPKFEFGMLPK> KHFJNACDABB, List<LPKFEFGMLPK> PLIGJCPBJDC, List<OLHIMCMANHM> MEDPHPPCKBJ, Material KFGOIEOLDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75BE670", Offset = "0x75BD070", VA = "0x1875BE670")]
	private int GAFHMPPANPN(List<LPKFEFGMLPK> CBLAEIHFGND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75BE3C0", Offset = "0x75BCDC0", VA = "0x1875BE3C0")]
	private void DAKLMLEOHBD(int DDBJFCFNEDA, bool OPPPLDKFPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x75BE790", Offset = "0x75BD190", VA = "0x1875BE790")]
	public void GCNDJDLMOCC(Vector3 PNPNJFAEELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x75BE520", Offset = "0x75BCF20", VA = "0x1875BE520", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x75BE8E0", Offset = "0x75BD2E0", VA = "0x1875BE8E0")]
	public void KPHIGCIGGGM(Transform AGIBDIFBHDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NCFCEOBAOLK : COHIMFBCGOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JHFCFHHHPKN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NCFCEOBAOLK <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public JHFCFHHHPKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x75C1210", Offset = "0x75BFC10", VA = "0x1875C1210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x75C0C00", Offset = "0x75BF600", VA = "0x1875C0C00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x75C0BB0", Offset = "0x75BF5B0", VA = "0x1875C0BB0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75C0B60", Offset = "0x75BF560", VA = "0x1875C0B60")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x75C0B10", Offset = "0x75BF510", VA = "0x1875C0B10")]
		private void HEAHLLHCJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75C11C0", Offset = "0x75BFBC0", VA = "0x1875C11C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75C1110", Offset = "0x75BFB10", VA = "0x1875C1110", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x75C1110", Offset = "0x75BFB10", VA = "0x1875C1110", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class NCFEDCJFIEI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NCFCEOBAOLK <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public NCFEDCJFIEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D40", Offset = "0x75C6740", VA = "0x1875C7D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x75C78D0", Offset = "0x75C62D0", VA = "0x1875C78D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75C7880", Offset = "0x75C6280", VA = "0x1875C7880")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x75C7830", Offset = "0x75C6230", VA = "0x1875C7830")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x75C7CF0", Offset = "0x75C66F0", VA = "0x1875C7CF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x75C7C40", Offset = "0x75C6640", VA = "0x1875C7C40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x75C7C40", Offset = "0x75C6640", VA = "0x1875C7C40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OKDJKDPEEAA NCIIFBLDHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<KCIFMIMPOKI> AMOIFDHOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> AIFDCLFDGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer IGHOGDFOOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool CLEALPKIFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool ADBIMLBNNEM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<AGHAKNFLOIH> KHPOCHJKPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DIPEDKJGOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75C6950", Offset = "0x75C5350", VA = "0x1875C6950", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OLHIMCMANHM PMDGPPHHPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75C6880", Offset = "0x75C5280", VA = "0x1875C6880", Slot = "8")]
		get
		{
			return default(OLHIMCMANHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> GOGCLDKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x899AB0", Offset = "0x8984B0", VA = "0x180899AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75C6CD0", Offset = "0x75C56D0", VA = "0x1875C6CD0")]
	private bool JJINCKBGDFD(KCIFMIMPOKI CICGHDIEJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x75C6CB0", Offset = "0x75C56B0", VA = "0x1875C6CB0")]
	private static bool HKICPDIBELD(KCIFMIMPOKI CICGHDIEJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x75C7740", Offset = "0x75C6140", VA = "0x1875C7740")]
	public NCFCEOBAOLK(OKDJKDPEEAA JGCMECODHDI, bool IHMHDCHOBBE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x75C6990", Offset = "0x75C5390", VA = "0x1875C6990", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x75C6B10", Offset = "0x75C5510", VA = "0x1875C6B10")]
	public void FABNFHGMHGJ(KCIFMIMPOKI CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75C6FC0", Offset = "0x75C59C0", VA = "0x1875C6FC0")]
	public void MBEEDABKNGP(KCIFMIMPOKI CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75C5F40", Offset = "0x75C4940", VA = "0x1875C5F40", Slot = "4")]
	public void ACLMOFJBHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x75C6CF0", Offset = "0x75C56F0", VA = "0x1875C6CF0")]
	public void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75C6590", Offset = "0x75C4F90", VA = "0x1875C6590")]
	private void BBGJCAGOANP(List<KCIFMIMPOKI> AMOIFDHOHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75C5C10", Offset = "0x75C4610", VA = "0x1875C5C10")]
	private static Material JCFJPCDJPFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x75C6750", Offset = "0x75C5150", VA = "0x1875C6750")]
	private void BBGJCAGOANP(KCIFMIMPOKI CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75C6440", Offset = "0x75C4E40", VA = "0x1875C6440")]
	private void AFFJIELFJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75C70E0", Offset = "0x75C5AE0", VA = "0x1875C70E0")]
	public void PEHOAPNMMFD(bool LLOMPKPPNOD, bool HANDODOOGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x75C7680", Offset = "0x75C6080", VA = "0x1875C7680")]
	protected void PLMOAEDEBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x75C6510", Offset = "0x75C4F10", VA = "0x1875C6510")]
	public void AMCJLLEIMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75C6800", Offset = "0x75C5200", VA = "0x1875C6800")]
	[IteratorStateMachine(typeof(JHFCFHHHPKN))]
	public IEnumerable<Renderer> BEDLOOCBPJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75C6F40", Offset = "0x75C5940", VA = "0x1875C6F40")]
	[IteratorStateMachine(typeof(NCFEDCJFIEI))]
	public IEnumerable<Renderer> LDKMBAECKIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class JBBBDCNLBCH : KCIFMIMPOKI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct EMEDBILBMPP : CHKKEPPLFAL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private JOIDBGKONGK CBNKKMIFMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle GDNIAPJJBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private GIOMCMJJKIO GNKLOBOOKMM;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75BBAB0", Offset = "0x75BA4B0", VA = "0x1875BBAB0")]
		public EMEDBILBMPP(JOIDBGKONGK CBNKKMIFMKD, JobHandle GDNIAPJJBPI, GIOMCMJJKIO GNKLOBOOKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x75BBA80", Offset = "0x75BA480", VA = "0x1875BBA80", Slot = "4")]
		public JOIDBGKONGK IKFNBHIKIAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75BBA30", Offset = "0x75BA430", VA = "0x1875BBA30", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly CNNALMNKJOG IOKHNNAFAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float MIBHJOKJAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 OHCCIKLBPGK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 CPMPPIAFANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75C0160", Offset = "0x75BEB60", VA = "0x1875C0160", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x75C0A60", Offset = "0x75BF460", VA = "0x1875C0A60")]
	public JBBBDCNLBCH(NCFCEOBAOLK JPBBEMPIGCM, CNNALMNKJOG JGCMECODHDI, bool IHMHDCHOBBE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "17")]
	public override bool GEAODBDGHOF(OLHIMCMANHM JPBBEMPIGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x75BFF90", Offset = "0x75BE990", VA = "0x1875BFF90", Slot = "18")]
	public override int GAFHMPPANPN(FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x75BF880", Offset = "0x75BE280", VA = "0x1875BF880", Slot = "19")]
	public override int EAAFKICFKMB(FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x75BFA50", Offset = "0x75BE450", VA = "0x1875BFA50", Slot = "20")]
	public override Bounds FGDPBAGOBNJ()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xAEE3B0", Offset = "0xAECDB0", VA = "0x180AEE3B0", Slot = "21")]
	public override float CJEHNCNPENI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x75BF020", Offset = "0x75BDA20", VA = "0x1875BF020", Slot = "22")]
	public override void AEFKNEGFGJM(FDCBHIELGDB CLOHFODGPFM, HKJIDIEMGKL MLDLLLNAJIB, int CPMPGJMHJLF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x75BF7B0", Offset = "0x75BE1B0", VA = "0x1875BF7B0", Slot = "23")]
	public override OLHIMCMANHM DMHODGHFLAG()
	{
		return default(OLHIMCMANHM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x75BF600", Offset = "0x75BE000", VA = "0x1875BF600", Slot = "25")]
	public override NBCIBJODIAO ALDHKLJKAHI()
	{
		return default(NBCIBJODIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x75C0290", Offset = "0x75BEC90", VA = "0x1875C0290", Slot = "26")]
	public override CHKKEPPLFAL POIICKDDDBL(FDCBHIELGDB CLOHFODGPFM, JobHandle GDNIAPJJBPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface DEIMFIKMCNB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NCFCEOBAOLK BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KCIFMIMPOKI BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LFLCJPNELKB BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class OKDMFNOHHLD : JHKJKNJJHAA, IDisposable, DEIMFIKMCNB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CHBINCAOBDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public OKDMFNOHHLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x75BB4D0", Offset = "0x75B9ED0", VA = "0x1875BB4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75BB9D0", Offset = "0x75BA3D0", VA = "0x1875BB9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GPDANAILPAE<CEFBENDABAG, NCFCEOBAOLK> ODMEMABOOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly GPDANAILPAE<PFBKIGNHCNM, KCIFMIMPOKI> AMOIFDHOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly GPDANAILPAE<OLOMCLKAJLN, LFLCJPNELKB> FKGAOKOEEBE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NCFCEOBAOLK BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75CA510", Offset = "0x75C8F10", VA = "0x1875CA510", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public KCIFMIMPOKI BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x75CA570", Offset = "0x75C8F70", VA = "0x1875CA570", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LFLCJPNELKB BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x75CA4B0", Offset = "0x75C8EB0", VA = "0x1875CA4B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LJAEFBAEMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C00", Offset = "0x9C2600", VA = "0x1809C3C00", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xDBB870", Offset = "0xDBA270", VA = "0x180DBB870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x75CC2F0", Offset = "0x75CACF0", VA = "0x1875CC2F0")]
	public OKDMFNOHHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x75CA5D0", Offset = "0x75C8FD0", VA = "0x1875CA5D0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x75CB210", Offset = "0x75C9C10", VA = "0x1875CB210", Slot = "4")]
	public CEFBENDABAG KNMKBFJAJKH(OKDJKDPEEAA JGCMECODHDI)
	{
		return default(CEFBENDABAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x75CAFA0", Offset = "0x75C99A0", VA = "0x1875CAFA0", Slot = "5")]
	public CEFBENDABAG KNMKBFJAJKH(OKDJKDPEEAA JGCMECODHDI, bool IHMHDCHOBBE)
	{
		return default(CEFBENDABAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x75CAD50", Offset = "0x75C9750", VA = "0x1875CAD50", Slot = "6")]
	public void JOLBMFGOJBP(CEFBENDABAG JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x75CAA10", Offset = "0x75C9410", VA = "0x1875CAA10", Slot = "7")]
	public void FLODNCANFJC(CEFBENDABAG JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x75CB7D0", Offset = "0x75CA1D0", VA = "0x1875CB7D0", Slot = "8")]
	public PFBKIGNHCNM NLDGECDOCNG(CEFBENDABAG JPBBEMPIGCM, AHOEJDMJOPP JGCMECODHDI)
	{
		return default(PFBKIGNHCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x75CB220", Offset = "0x75C9C20", VA = "0x1875CB220", Slot = "9")]
	public PFBKIGNHCNM MDGNMILNPAJ(CEFBENDABAG JPBBEMPIGCM, CNNALMNKJOG JGCMECODHDI)
	{
		return default(PFBKIGNHCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x75CBF50", Offset = "0x75CA950", VA = "0x1875CBF50", Slot = "11")]
	public void ONPAEGBAAEO(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x75CBC90", Offset = "0x75CA690", VA = "0x1875CBC90", Slot = "10")]
	public void OAJPFGLFGLA(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x75CA9A0", Offset = "0x75C93A0", VA = "0x1875CA9A0", Slot = "20")]
	public IEnumerable<Renderer> EMEKHHAELFC(CEFBENDABAG JPBBEMPIGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x75CA2B0", Offset = "0x75C8CB0", VA = "0x1875CA2B0", Slot = "12")]
	public OLOMCLKAJLN AODPAKMGMKI(FPCIEBLEOIF JGCMECODHDI)
	{
		return default(OLOMCLKAJLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x75CBEE0", Offset = "0x75CA8E0", VA = "0x1875CBEE0", Slot = "14")]
	public void OCJPAOHBBAG(OLOMCLKAJLN FGDDBCKAJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x75CA820", Offset = "0x75C9220", VA = "0x1875CA820", Slot = "16")]
	public Task EKMBMMBEKFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x75CA330", Offset = "0x75C8D30", VA = "0x1875CA330", Slot = "17")]
	public Task BMJMGCBHIFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x75CA750", Offset = "0x75C9150", VA = "0x1875CA750", Slot = "18")]
	[AsyncStateMachine(typeof(CHBINCAOBDK))]
	public Task ECGGHPDMJDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x75CB740", Offset = "0x75CA140", VA = "0x1875CB740", Slot = "19")]
	public void NILOHBICFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75CB6E0", Offset = "0x75CA0E0", VA = "0x1875CB6E0", Slot = "13")]
	public void NIGEHPCNNOH(OLOMCLKAJLN FGDDBCKAJKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class OBINFJDPFKO : KCIFMIMPOKI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct PDEKKOFDMCA : CHKKEPPLFAL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private JOIDBGKONGK CBNKKMIFMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle GDNIAPJJBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private DFJCJLEBMPC GNKLOBOOKMM;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75CC7F0", Offset = "0x75CB1F0", VA = "0x1875CC7F0")]
		public PDEKKOFDMCA(JOIDBGKONGK CBNKKMIFMKD, JobHandle GDNIAPJJBPI, DFJCJLEBMPC GNKLOBOOKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75CC7C0", Offset = "0x75CB1C0", VA = "0x1875CC7C0", Slot = "4")]
		public JOIDBGKONGK IKFNBHIKIAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x75CC770", Offset = "0x75CB170", VA = "0x1875CC770", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly AHOEJDMJOPP MJHCHFCOEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] NNDJKIHHPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 OHCCIKLBPGK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 GPINHAOOOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x75C9870", Offset = "0x75C8270", VA = "0x1875C9870")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 CPMPPIAFANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x75C9740", Offset = "0x75C8140", VA = "0x1875C9740", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x75CA200", Offset = "0x75C8C00", VA = "0x1875CA200")]
	public OBINFJDPFKO(NCFCEOBAOLK JPBBEMPIGCM, AHOEJDMJOPP JGCMECODHDI, bool OBOCHAKALNO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x75C8E20", Offset = "0x75C7820", VA = "0x1875C8E20", Slot = "17")]
	public override bool GEAODBDGHOF(OLHIMCMANHM JPBBEMPIGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x75C9540", Offset = "0x75C7F40", VA = "0x1875C9540")]
	private KINAFICGJBF ICDEAPOJDJO([In] UniformTRS CLHALGFKHOF, [In] float3 FAKNGOLOPND)
	{
		return default(KINAFICGJBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x75C8D80", Offset = "0x75C7780", VA = "0x1875C8D80", Slot = "18")]
	public override int GAFHMPPANPN(FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x75C89F0", Offset = "0x75C73F0", VA = "0x1875C89F0", Slot = "19")]
	public override int EAAFKICFKMB(FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x75C8D00", Offset = "0x75C7700", VA = "0x1875C8D00", Slot = "20")]
	public override Bounds FGDPBAGOBNJ()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x75C8830", Offset = "0x75C7230", VA = "0x1875C8830", Slot = "21")]
	public override float CJEHNCNPENI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x75C8A90", Offset = "0x75C7490", VA = "0x1875C8A90")]
	private int EIADNCIDPKF(FDCBHIELGDB CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x75C7E70", Offset = "0x75C6870", VA = "0x1875C7E70", Slot = "22")]
	public override void AEFKNEGFGJM(FDCBHIELGDB CLOHFODGPFM, HKJIDIEMGKL MLDLLLNAJIB, int CPMPGJMHJLF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x75C8920", Offset = "0x75C7320", VA = "0x1875C8920", Slot = "23")]
	public override OLHIMCMANHM DMHODGHFLAG()
	{
		return default(OLHIMCMANHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x75C8680", Offset = "0x75C7080", VA = "0x1875C8680", Slot = "25")]
	public override NBCIBJODIAO ALDHKLJKAHI()
	{
		return default(NBCIBJODIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x75C9AA0", Offset = "0x75C84A0", VA = "0x1875C9AA0", Slot = "26")]
	public override CHKKEPPLFAL POIICKDDDBL(FDCBHIELGDB CLOHFODGPFM, JobHandle GDNIAPJJBPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AGICLDGIFGL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOIHEOMCDCO(IMLALIAHABD JLAAKHANEHC, Renderer MGJKLBPNDCE, int MGDHGJGDDPB);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPDLGHDBELJ(Renderer MGJKLBPNDCE, JDEOPKDIACG BAINLMIMOJN, Vector3 LAMFKJDOOGB, Vector3 JJLHPABKFIF, Vector3 HMJIBDEFLEB, float MPBLCNAKEPE, float NHIPNFOIHAM, float CIGHHAIPKID = -1f, [Optional] Color? FEHNKBJAMFH, [Optional] IReadOnlyList<Camera> IMCAJECNAEF);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PNGJCNDPLBH(Renderer MGJKLBPNDCE, int MGDHGJGDDPB);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OGAANAONBDB();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJEBBDEEFNJ(int JENAOFLJOKP, CEKFCLEOOAA JLAAKHANEHC, Renderer MGJKLBPNDCE, int MGDHGJGDDPB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HHFHLHMOKGG : CGKOFOPGADE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class LFJBNAABODP : GGGNMKNBIOM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x75C2410", Offset = "0x75C0E10", VA = "0x1875C2410")]
		public LFJBNAABODP(string KJPHMNNIMDP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AGICLDGIFGL FPMCENHPHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DEIMFIKMCNB MOHEHAEHJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer MMLGJNAKNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private LFJBNAABODP PLJENKBIGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool LOGFGHHAFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer CDJBBCDDCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private LFJBNAABODP FOINCKKLECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool FHOHJBCKPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer JIJLLJEBCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private LFJBNAABODP AGGOILEKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool CNODAACHNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool HFIMBOHAJFI;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x89CB80", Offset = "0x89B580", VA = "0x18089CB80")]
	public HHFHLHMOKGG(AGICLDGIFGL PEOCJAHEBJI, DEIMFIKMCNB MOHEHAEHJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x75BC2B0", Offset = "0x75BACB0", VA = "0x1875BC2B0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x75BD4C0", Offset = "0x75BBEC0", VA = "0x1875BD4C0")]
	private void IOIHECFHDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x75BBFA0", Offset = "0x75BA9A0", VA = "0x1875BBFA0", Slot = "4")]
	public void BNCMMGIEJPP(CEFBENDABAG JPBBEMPIGCM, CEKFCLEOOAA IFNKPCOLBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x75BBD80", Offset = "0x75BA780", VA = "0x1875BBD80", Slot = "5")]
	public void BNCMMGIEJPP(PFBKIGNHCNM CICGHDIEJHI, CEKFCLEOOAA IFNKPCOLBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x75BC590", Offset = "0x75BAF90", VA = "0x1875BC590", Slot = "6")]
	public void EHLCBEDLPBH(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x75BC930", Offset = "0x75BB330", VA = "0x1875BC930", Slot = "7")]
	public void FOBOKDIHOFP(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x75BCAD0", Offset = "0x75BB4D0", VA = "0x1875BCAD0", Slot = "24")]
	public void HHKBPEGGMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xAE2DE0", Offset = "0xAE17E0", VA = "0x180AE2DE0", Slot = "8")]
	public void PFGLHENPNAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x75BD730", Offset = "0x75BC130", VA = "0x1875BD730", Slot = "9")]
	public void JGHHGFFPHCM(CEKFCLEOOAA IFNKPCOLBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x75BCB10", Offset = "0x75BB510", VA = "0x1875BCB10", Slot = "10")]
	public void ICCOFFKHLNE(CEFBENDABAG JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x75BCDF0", Offset = "0x75BB7F0", VA = "0x1875BCDF0", Slot = "11")]
	public void ICCOFFKHLNE(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x75BE2D0", Offset = "0x75BCCD0", VA = "0x1875BE2D0", Slot = "12")]
	public void OLMENNELCKA(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x75BD430", Offset = "0x75BBE30", VA = "0x1875BD430", Slot = "13")]
	public void INHHKJGDFBF(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x75BBB10", Offset = "0x75BA510", VA = "0x1875BBB10")]
	private void BEMOKDOENNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xBC54B0", Offset = "0xBC3EB0", VA = "0x180BC54B0", Slot = "14")]
	public void PCHGFNMLAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x75BD8A0", Offset = "0x75BC2A0", VA = "0x1875BD8A0", Slot = "15")]
	public void KBKBDMECOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x75BD150", Offset = "0x75BBB50", VA = "0x1875BD150", Slot = "16")]
	public void IMBBLJNPHHA(CEFBENDABAG JPBBEMPIGCM, IMLALIAHABD JLAAKHANEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x75BE230", Offset = "0x75BCC30", VA = "0x1875BE230", Slot = "17")]
	public void MJMFHNEJNNC(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x75BCA40", Offset = "0x75BB440", VA = "0x1875BCA40", Slot = "18")]
	public void GIBEPMAGHPI(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xCD3E00", Offset = "0xCD2800", VA = "0x180CD3E00", Slot = "19")]
	public void KBBEIOCICIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x75BC460", Offset = "0x75BAE60", VA = "0x1875BC460", Slot = "20")]
	public void EBNKJFIELNB(IMLALIAHABD JLAAKHANEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x75BC6C0", Offset = "0x75BB0C0", VA = "0x1875BC6C0")]
	private void FNMLCECLIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x75BDE60", Offset = "0x75BC860", VA = "0x1875BDE60", Slot = "21")]
	public void KGAMJEOAINN(CEFBENDABAG JPBBEMPIGCM, Vector3 LAMFKJDOOGB, Vector3 JJLHPABKFIF, Vector3 HMJIBDEFLEB, float MPBLCNAKEPE, float NHIPNFOIHAM, IReadOnlyList<Camera> GOMIOHNDHBK, JDEOPKDIACG BAINLMIMOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x75BD9C0", Offset = "0x75BC3C0", VA = "0x1875BD9C0", Slot = "22")]
	public void KGAMJEOAINN(OLOMCLKAJLN FGDDBCKAJKG, Vector3 LAMFKJDOOGB, Vector3 JJLHPABKFIF, Vector3 HMJIBDEFLEB, float MPBLCNAKEPE, float NHIPNFOIHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class KCIFMIMPOKI : EKCACEEIPAG, AGHAKNFLOIH, EKENLHCAPBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly NCFCEOBAOLK GEBPHFIJDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds ENPJLKHMPCK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds JFPFHENAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x12BF010", Offset = "0x12BDA10", VA = "0x1812BF010", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool ADBIMLBNNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xC46710", Offset = "0xC45110", VA = "0x180C46710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xD234D0", Offset = "0xD21ED0", VA = "0x180D234D0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 CPMPPIAFANH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CIBGOOGHOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x923D80", Offset = "0x922780", VA = "0x180923D80", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BKCLCHMHELJ OIBAJOENEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x899AB0", Offset = "0x8984B0", VA = "0x180899AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool CJKPDLGJGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xCA8780", Offset = "0xCA7180", VA = "0x180CA8780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	protected KCIFMIMPOKI(NCFCEOBAOLK JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x75C22B0", Offset = "0x75C0CB0", VA = "0x1875C22B0", Slot = "16")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "17")]
	public virtual bool GEAODBDGHOF(OLHIMCMANHM JPBBEMPIGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int GAFHMPPANPN(FDCBHIELGDB CLOHFODGPFM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int EAAFKICFKMB(FDCBHIELGDB CLOHFODGPFM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract Bounds FGDPBAGOBNJ();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract float CJEHNCNPENI();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract void AEFKNEGFGJM(FDCBHIELGDB CLOHFODGPFM, HKJIDIEMGKL MLDLLLNAJIB, int CPMPGJMHJLF = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract OLHIMCMANHM DMHODGHFLAG();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x75C23E0", Offset = "0x75C0DE0", VA = "0x1875C23E0", Slot = "12")]
	public Hash128 IEIANCELHGK(int CLOHFODGPFM)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract NBCIBJODIAO ALDHKLJKAHI();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract CHKKEPPLFAL POIICKDDDBL(FDCBHIELGDB CLOHFODGPFM, JobHandle GDNIAPJJBPI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x75C2280", Offset = "0x75C0C80", VA = "0x1875C2280", Slot = "11")]
	public CHKKEPPLFAL CCHDKKMCFLL(int CLOHFODGPFM)
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
		[Cpp2IlInjected.Address(RVA = "0x75CCC40", Offset = "0x75CB640", VA = "0x1875CCC40")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LOKCJOCIDHC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class ILBIPBHMJAB : IEnumerable<GDJEGFEFPKO>, IEnumerable, IEnumerator<GDJEGFEFPKO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private GDJEGFEFPKO <>2__current;

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
		private GDJEGFEFPKO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public ILBIPBHMJAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC60", Offset = "0x75BD660", VA = "0x1875BEC60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x75BEDD0", Offset = "0x75BD7D0", VA = "0x1875BEDD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x75BED30", Offset = "0x75BD730", VA = "0x1875BED30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GDJEGFEFPKO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x75BED30", Offset = "0x75BD730", VA = "0x1875BED30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static GDJEGFEFPKO[][] KJNBEFBEAGI;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static MANEHJEPDED DBDBDCPEMND;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig MJPOMPGCBME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x75C45E0", Offset = "0x75C2FE0", VA = "0x1875C45E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader EKCOBHCFBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x75C4570", Offset = "0x75C2F70", VA = "0x1875C4570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer PIPKODFHBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x75C4500", Offset = "0x75C2F00", VA = "0x1875C4500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x75C4620", Offset = "0x75C3020", VA = "0x1875C4620")]
	public static Mesh NLMLJKHCKCB(DIKIEBBPIBF JBDINOJGNAI, int CLOHFODGPFM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x75C3A90", Offset = "0x75C2490", VA = "0x1875C3A90")]
	public static int ALGFCBEOLBG(DIKIEBBPIBF JBDINOJGNAI, int CLOHFODGPFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x75C3C50", Offset = "0x75C2650", VA = "0x1875C3C50")]
	public static MANEHJEPDED CDPDPIIFMPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x75C3D90", Offset = "0x75C2790", VA = "0x1875C3D90")]
	[IteratorStateMachine(typeof(ILBIPBHMJAB))]
	private static IEnumerable<GDJEGFEFPKO> CLOHMLELKGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x75C3DF0", Offset = "0x75C27F0", VA = "0x1875C3DF0")]
	public static GDJEGFEFPKO FHNFEEIOCAB(DIKIEBBPIBF JBDINOJGNAI, int CLOHFODGPFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x75C44E0", Offset = "0x75C2EE0", VA = "0x1875C44E0")]
	public static bool HENKGHPLAKM(this DIKIEBBPIBF JBDINOJGNAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x75C3AA0", Offset = "0x75C24A0", VA = "0x1875C3AA0")]
	public static void CDAGPGGAALK(DIKIEBBPIBF JBDINOJGNAI, float3 FHCDJLJMHAF, [Out] DFECJDBCKPF FKBEGEAOLBI, [Out] float3 LLLCGLMBOML, [Out] float GNIPIOKOKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x75C4090", Offset = "0x75C2A90", VA = "0x1875C4090")]
	public static void HELLIFAOOFF(Vector3 FHCDJLJMHAF, DIKIEBBPIBF JBDINOJGNAI, [Out] Vector3 LLLCGLMBOML, [Out] float GNIPIOKOKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x75C4610", Offset = "0x75C3010", VA = "0x1875C4610")]
	[MGLPINNJGGC(CLPKIHJHCPA.ExitingPlayMode, 0)]
	[CKNHDJDNBDB(0)]
	private static void LGOHIOFDPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x75C38D0", Offset = "0x75C22D0", VA = "0x1875C38D0")]
	[MGLPINNJGGC(CLPKIHJHCPA.ExitingPlayMode, 0)]
	[CKNHDJDNBDB(0)]
	private static void ABLFLMCGDMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class JKLHCKHHKHE : JHKJKNJJHAA, IDisposable, DEIMFIKMCNB
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly GPDANAILPAE<CEFBENDABAG, NCFCEOBAOLK> ODMEMABOOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly GPDANAILPAE<PFBKIGNHCNM, KCIFMIMPOKI> AMOIFDHOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly GPDANAILPAE<OLOMCLKAJLN, LFLCJPNELKB> FKGAOKOEEBE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public NCFCEOBAOLK BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x75C1520", Offset = "0x75BFF20", VA = "0x1875C1520", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public KCIFMIMPOKI BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x75C15E0", Offset = "0x75BFFE0", VA = "0x1875C15E0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public LFLCJPNELKB BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x75C1580", Offset = "0x75BFF80", VA = "0x1875C1580", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LJAEFBAEMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C00", Offset = "0x9C2600", VA = "0x1809C3C00", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xDBB870", Offset = "0xDBA270", VA = "0x180DBB870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75C1EC0", Offset = "0x75C08C0", VA = "0x1875C1EC0")]
	public JKLHCKHHKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x75C1640", Offset = "0x75C0040", VA = "0x1875C1640", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x75C1960", Offset = "0x75C0360", VA = "0x1875C1960", Slot = "4")]
	public CEFBENDABAG KNMKBFJAJKH(OKDJKDPEEAA JGCMECODHDI)
	{
		return default(CEFBENDABAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x75C1960", Offset = "0x75C0360", VA = "0x1875C1960", Slot = "5")]
	public CEFBENDABAG KNMKBFJAJKH(OKDJKDPEEAA JGCMECODHDI, bool IHMHDCHOBBE)
	{
		return default(CEFBENDABAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x75C1900", Offset = "0x75C0300", VA = "0x1875C1900", Slot = "6")]
	public void JOLBMFGOJBP(CEFBENDABAG JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x75C1880", Offset = "0x75C0280", VA = "0x1875C1880", Slot = "7")]
	public void FLODNCANFJC(CEFBENDABAG JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x75C1BA0", Offset = "0x75C05A0", VA = "0x1875C1BA0", Slot = "8")]
	public PFBKIGNHCNM NLDGECDOCNG(CEFBENDABAG JPBBEMPIGCM, AHOEJDMJOPP JGCMECODHDI)
	{
		return default(PFBKIGNHCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x75C1A00", Offset = "0x75C0400", VA = "0x1875C1A00", Slot = "9")]
	public PFBKIGNHCNM MDGNMILNPAJ(CEFBENDABAG JPBBEMPIGCM, CNNALMNKJOG JGCMECODHDI)
	{
		return default(PFBKIGNHCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x75C1DB0", Offset = "0x75C07B0", VA = "0x1875C1DB0", Slot = "11")]
	public void ONPAEGBAAEO(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x75C1CE0", Offset = "0x75C06E0", VA = "0x1875C1CE0", Slot = "10")]
	public void OAJPFGLFGLA(PFBKIGNHCNM CICGHDIEJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x75C1810", Offset = "0x75C0210", VA = "0x1875C1810", Slot = "20")]
	public IEnumerable<Renderer> EMEKHHAELFC(CEFBENDABAG JPBBEMPIGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x75C1400", Offset = "0x75BFE00", VA = "0x1875C1400", Slot = "12")]
	public OLOMCLKAJLN AODPAKMGMKI(FPCIEBLEOIF JGCMECODHDI)
	{
		return default(OLOMCLKAJLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x75C1D40", Offset = "0x75C0740", VA = "0x1875C1D40", Slot = "14")]
	public void OCJPAOHBBAG(OLOMCLKAJLN FGDDBCKAJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x75C1770", Offset = "0x75C0170", VA = "0x1875C1770", Slot = "16")]
	public Task EKMBMMBEKFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x75C1480", Offset = "0x75BFE80", VA = "0x1875C1480", Slot = "17")]
	public Task BMJMGCBHIFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x75C16D0", Offset = "0x75C00D0", VA = "0x1875C16D0", Slot = "18")]
	public Task ECGGHPDMJDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x205CAB0", Offset = "0x205B4B0", VA = "0x18205CAB0", Slot = "19")]
	public void NILOHBICFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x75C1B40", Offset = "0x75C0540", VA = "0x1875C1B40", Slot = "13")]
	public void NIGEHPCNNOH(OLOMCLKAJLN FGDDBCKAJKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CENFPDPFCFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool JNFBHKLLCPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material KMLJPFGPDGI();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material JCFJPCDJPFG();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material EIKAHOBLEPJ();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NBIHANIOOGK(MNJGJKEDHBM KDLMAHAJHMP);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OEAMMGLNCPN(KLGCHNJKBIE OAHGDGHMOMH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CMIBGCKBBIO(GameObject GHMNBJIOGAM);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMMEDBFNMII(GameObject GHMNBJIOGAM, bool KJBHOGLEKEA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class MEBFDGNGPGI
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static CENFPDPFCFJ BDPEMHOFOHC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool JNFBHKLLCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x75C5C70", Offset = "0x75C4670", VA = "0x1875C5C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x75C5DA0", Offset = "0x75C47A0", VA = "0x1875C5DA0")]
	public static void NKLPCGDJAHO(CENFPDPFCFJ GDFHINAOLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x75C5CD0", Offset = "0x75C46D0", VA = "0x1875C5CD0")]
	public static Material KMLJPFGPDGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x75C5C10", Offset = "0x75C4610", VA = "0x1875C5C10")]
	public static Material JCFJPCDJPFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x75C5BB0", Offset = "0x75C45B0", VA = "0x1875C5BB0")]
	public static Material EIKAHOBLEPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x75C5D30", Offset = "0x75C4730", VA = "0x1875C5D30")]
	public static int NBIHANIOOGK(MNJGJKEDHBM KDLMAHAJHMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x75C5DF0", Offset = "0x75C47F0", VA = "0x1875C5DF0")]
	public static int OEAMMGLNCPN(KLGCHNJKBIE OAHGDGHMOMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x75C5AD0", Offset = "0x75C44D0", VA = "0x1875C5AD0")]
	public static void CMIBGCKBBIO(GameObject GHMNBJIOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x75C5E60", Offset = "0x75C4860", VA = "0x1875C5E60")]
	public static void OMMEDBFNMII(GameObject GHMNBJIOGAM, bool KJBHOGLEKEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LFLCJPNELKB : COHIMFBCGOO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PHCBGJGNJDC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LFLCJPNELKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public PHCBGJGNJDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x75CCBB0", Offset = "0x75CB5B0", VA = "0x1875CCBB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x75CC890", Offset = "0x75CB290", VA = "0x1875CC890", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x75CC840", Offset = "0x75CB240", VA = "0x1875CC840")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x75CCB60", Offset = "0x75CB560", VA = "0x1875CCB60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x75CCAB0", Offset = "0x75CB4B0", VA = "0x1875CCAB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x75CCAB0", Offset = "0x75CB4B0", VA = "0x1875CCAB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly FPCIEBLEOIF OGAGJEGPNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly DEIMFIKMCNB MOHEHAEHJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private HJJBNOPDMKA LBAOMDABJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<LPKFEFGMLPK> MBPDCIFELMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<LPKFEFGMLPK> BFPPJPGLOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject LOHDGLIKHDP;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x75C2460", Offset = "0x75C0E60", VA = "0x1875C2460")]
	public static LFLCJPNELKB ABMJGBLHAPK(FPCIEBLEOIF JGCMECODHDI, DEIMFIKMCNB MOHEHAEHJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x75C37F0", Offset = "0x75C21F0", VA = "0x1875C37F0")]
	private LFLCJPNELKB(FPCIEBLEOIF JGCMECODHDI, DEIMFIKMCNB MOHEHAEHJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x75C3370", Offset = "0x75C1D70", VA = "0x1875C3370")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x75C30A0", Offset = "0x75C1AA0", VA = "0x1875C30A0")]
	[IteratorStateMachine(typeof(PHCBGJGNJDC))]
	public IEnumerable<Renderer> BEDLOOCBPJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x75C25E0", Offset = "0x75C0FE0", VA = "0x1875C25E0", Slot = "4")]
	public void ACLMOFJBHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x75C25B0", Offset = "0x75C0FB0", VA = "0x1875C25B0")]
	private void ACHEFBDCGBE(Vector3 PNPNJFAEELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x75C3120", Offset = "0x75C1B20", VA = "0x1875C3120")]
	public void KOLHFLEMELG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LPKFEFGMLPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct LFDGNNNBKED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public HKJIDIEMGKL ADKGMNILPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public OLHIMCMANHM EEMFEBMIDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int IDBJIDAGBFC;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IPBCABOBGMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LPKFEFGMLPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FDCBHIELGDB lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<LFDGNNNBKED> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public JOIDBGKONGK combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public IPBCABOBGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x75BEFC0", Offset = "0x75BD9C0", VA = "0x1875BEFC0")]
		internal JobHandle KADFCEPNOJB()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x75BEF90", Offset = "0x75BD990", VA = "0x1875BEF90")]
		internal void IFEFHMAMNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x75BEE20", Offset = "0x75BD820", VA = "0x1875BEE20")]
		internal void AEIAPEAHGBN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] EBDHENGLPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private OCGODPNCCPB FMPPJBFEAII;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 HKAPNIMGBOC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh JPMOJDIJBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8A40C0", Offset = "0x8A2AC0", VA = "0x1808A40C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x75C4740", Offset = "0x75C3140", VA = "0x1875C4740")]
	public void ALMALKEDKML(List<OLHIMCMANHM> OKNKEGNKCAD, Matrix4x4[] DABLNAJEGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x75C4D20", Offset = "0x75C3720", VA = "0x1875C4D20")]
	public static List<LPKFEFGMLPK> GMDNOGMNFLF(List<NCFCEOBAOLK> AJOFDDMLMFO, FDCBHIELGDB CLOHFODGPFM, Bounds NPJFCGGHGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x75C4920", Offset = "0x75C3320", VA = "0x1875C4920")]
	private JobHandle AMLFMKNHNOL(JOIDBGKONGK AFCMBJJBHGD, int NPFPKLGDKMF, int DCLJAMBNIMH, FDCBHIELGDB CLOHFODGPFM, List<LFDGNNNBKED> OLGHJFEEACK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x75C53B0", Offset = "0x75C3DB0", VA = "0x1875C53B0")]
	private void KJGEOIJHEJO(List<LFDGNNNBKED> OLGHJFEEACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x75C5620", Offset = "0x75C4020", VA = "0x1875C5620")]
	private LPKFEFGMLPK(List<LFDGNNNBKED> OLGHJFEEACK, int NPFPKLGDKMF, int DCLJAMBNIMH, FDCBHIELGDB CLOHFODGPFM, Bounds NPJFCGGHGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x75C4C80", Offset = "0x75C3680", VA = "0x1875C4C80", Slot = "4")]
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
		private MaterialPropertyBlock PIJDHFGMLNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private LPKFEFGMLPK CBNKKMIFMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<OLHIMCMANHM> MEDPHPPCKBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture OBOBJIJBOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer KMINDBAAGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader JHKDHBPHLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] BBMHBCINKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int GKNBLKBIHPJ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer DNFKLIBBDKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int EGNCMDPIICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x75CD9A0", Offset = "0x75CC3A0", VA = "0x1875CD9A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x75CD010", Offset = "0x75CBA10", VA = "0x1875CD010")]
		public static List<SkinnedShapeRenderer> Create(GameObject JPBBEMPIGCM, List<LPKFEFGMLPK> CBLAEIHFGND, List<OLHIMCMANHM> MEDPHPPCKBJ, Material KFGOIEOLDHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x75CD2C0", Offset = "0x75CBCC0", VA = "0x1875CD2C0")]
		public void Init(LPKFEFGMLPK CBNKKMIFMKD, List<OLHIMCMANHM> MEDPHPPCKBJ, Material KFGOIEOLDHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x75CD900", Offset = "0x75CC300", VA = "0x1875CD900")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x75CD860", Offset = "0x75CC260", VA = "0x1875CD860")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x75CD820", Offset = "0x75CC220", VA = "0x1875CD820")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x75CD760", Offset = "0x75CC160", VA = "0x1875CD760")]
		private void OIGFMFLOAHL(ScriptableRenderContext EIGKPCONJCB, Camera[] EMDKHKKHEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x75CCCA0", Offset = "0x75CB6A0", VA = "0x1875CCCA0")]
		private void ALMALKEDKML(CommandBuffer FMDCOJMFHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
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
