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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C300", Offset = "0x8C6AF00", VA = "0x188C6C300", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C71EE0", Offset = "0x8C70AE0", VA = "0x188C71EE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HEEJLFKKOOA : DOLPBMMGGGC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte BLDNOPOFIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] EGHIHCEELMF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KLKLCJBNICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAB6800", Offset = "0xAB5400", VA = "0x180AB6800", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAB6880", Offset = "0xAB5480", VA = "0x180AB6880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int IJKNCFGJDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B60", Offset = "0xABF760", VA = "0x180AC0B60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10131E0", Offset = "0x1011DE0", VA = "0x1810131E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float ODLDFNAHNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF9EEB0", Offset = "0xF9DAB0", VA = "0x180F9EEB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x150C7A0", Offset = "0x150B3A0", VA = "0x18150C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float KKHJHNFGKIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD679E0", Offset = "0xD665E0", VA = "0x180D679E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD679F0", Offset = "0xD665F0", VA = "0x180D679F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> LOMLPFBNEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C68E30", Offset = "0x8C67A30", VA = "0x188C68E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> NBFKJAIJDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C68D00", Offset = "0x8C67900", VA = "0x188C68D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject AMCBICJEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte OELCLIALPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8C69130", Offset = "0x8C67D30", VA = "0x188C69130", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8C692E0", Offset = "0x8C67EE0", VA = "0x188C692E0")]
	public HEEJLFKKOOA(List<IHFECKGDNNN> PPLLANDOFPE, List<IHFECKGDNNN> AEFFCNIKAAP, List<MFFDCMMCMLL> EFBCPLLDMDA, Material CIBNABIMGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8C691C0", Offset = "0x8C67DC0", VA = "0x188C691C0")]
	private int NNCPPFFEFMN(List<IHFECKGDNNN> PCGDPIHLPGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8C68FD0", Offset = "0x8C67BD0", VA = "0x188C68FD0")]
	private void FHEIHCNIGJA(int MPGKHIPDICK, bool MOFPHEHMCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8C68E80", Offset = "0x8C67A80", VA = "0x188C68E80")]
	public void FANKAJCOFDM(Vector3 JJEPJKKKBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8C68D30", Offset = "0x8C67930", VA = "0x188C68D30", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8C69180", Offset = "0x8C67D80", VA = "0x188C69180")]
	public void KMNEHCLMIOK(Transform KNEJLNHAINE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FAPNOCLGFMC : MGIEEOHCBMD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MNELGCGNGAK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public FAPNOCLGFMC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public MNELGCGNGAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6E650", Offset = "0x8C6D250", VA = "0x188C6E650", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8C6E040", Offset = "0x8C6CC40", VA = "0x188C6E040", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8C6DF50", Offset = "0x8C6CB50", VA = "0x188C6DF50")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8C6DFF0", Offset = "0x8C6CBF0", VA = "0x188C6DFF0")]
		private void KBNMMFGEPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8C6DFA0", Offset = "0x8C6CBA0", VA = "0x188C6DFA0")]
		private void DELCEHAKPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8C6E600", Offset = "0x8C6D200", VA = "0x188C6E600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C6E550", Offset = "0x8C6D150", VA = "0x188C6E550", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8C6E550", Offset = "0x8C6D150", VA = "0x188C6E550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PKLPIGKGMOC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public FAPNOCLGFMC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public PKLPIGKGMOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8C708A0", Offset = "0x8C6F4A0", VA = "0x188C708A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8C70430", Offset = "0x8C6F030", VA = "0x188C70430", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8C70390", Offset = "0x8C6EF90", VA = "0x188C70390")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8C703E0", Offset = "0x8C6EFE0", VA = "0x188C703E0")]
		private void KBNMMFGEPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8C70850", Offset = "0x8C6F450", VA = "0x188C70850", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8C707A0", Offset = "0x8C6F3A0", VA = "0x188C707A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C707A0", Offset = "0x8C6F3A0", VA = "0x188C707A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CEIOAGBLDNK EHDILJIPCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<CBFNMJJLHND> GLGEEEILHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> OCFPEDEMNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer MFNFJBOALGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool OKIIOKLFIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool PJAFHNFDEEL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<FBDGJFDLGBN> PMABEGPOAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JIAAHJFFMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C64DC0", Offset = "0x8C639C0", VA = "0x188C64DC0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MFFDCMMCMLL DLBJKMABFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8C653A0", Offset = "0x8C63FA0", VA = "0x188C653A0", Slot = "8")]
		get
		{
			return default(MFFDCMMCMLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> LOFJLFMBFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5D0", Offset = "0xA5A1D0", VA = "0x180A5B5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8C65150", Offset = "0x8C63D50", VA = "0x188C65150")]
	private bool GGOAAFCHOBN(CBFNMJJLHND MIEJLCKINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8C647E0", Offset = "0x8C633E0", VA = "0x188C647E0")]
	private static bool CCDKDBCBAFF(CBFNMJJLHND MIEJLCKINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8C65F60", Offset = "0x8C64B60", VA = "0x188C65F60")]
	public FAPNOCLGFMC(CEIOAGBLDNK CBCNBAPLLJM, bool PDJPEPFGNDE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8C64E00", Offset = "0x8C63A00", VA = "0x188C64E00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8C656E0", Offset = "0x8C642E0", VA = "0x188C656E0")]
	public void NDGLNAHKHEG(CBFNMJJLHND MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8C64FF0", Offset = "0x8C63BF0", VA = "0x188C64FF0")]
	public void ENKPLOICKCM(CBFNMJJLHND MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8C659E0", Offset = "0x8C645E0", VA = "0x188C659E0", Slot = "4")]
	public void NLBEDIKOMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8C65470", Offset = "0x8C64070", VA = "0x188C65470")]
	public void MONBEGLCAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8C64620", Offset = "0x8C63220", VA = "0x188C64620")]
	private void ALIDOFHNEDI(List<CBFNMJJLHND> GLGEEEILHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8C65270", Offset = "0x8C63E70", VA = "0x188C65270")]
	private static Material IHKBOGJIBIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8C64570", Offset = "0x8C63170", VA = "0x188C64570")]
	private void ALIDOFHNEDI(CBFNMJJLHND MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8C652D0", Offset = "0x8C63ED0", VA = "0x188C652D0")]
	private void JNJIAHFBAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8C64800", Offset = "0x8C63400", VA = "0x188C64800")]
	public void CFPFDGBCEGF(bool IHPHGDPENIM, bool CMDDHFPAFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8C65920", Offset = "0x8C64520", VA = "0x188C65920")]
	protected void NGGCBBEKLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8C65170", Offset = "0x8C63D70", VA = "0x188C65170")]
	public void IDBIHCKPAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8C65EE0", Offset = "0x8C64AE0", VA = "0x188C65EE0")]
	[IteratorStateMachine(typeof(MNELGCGNGAK))]
	public IEnumerable<Renderer> OMGOJGOIINC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8C651F0", Offset = "0x8C63DF0", VA = "0x188C651F0")]
	[IteratorStateMachine(typeof(PKLPIGKGMOC))]
	public IEnumerable<Renderer> IGLJHPKBCOM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class PIONNHAMJAI : CBFNMJJLHND
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct KAKGFOGCHPP : NCKCCKOPMIM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NBEBPMPJHKD MOGMOMKEFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle GPAFPAOOIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JBKJPLMKKMD LEACCINCOPI;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6ADD0", Offset = "0x8C699D0", VA = "0x188C6ADD0")]
		public KAKGFOGCHPP(NBEBPMPJHKD MOGMOMKEFJC, JobHandle GPAFPAOOIJM, JBKJPLMKKMD LEACCINCOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AD50", Offset = "0x8C69950", VA = "0x188C6AD50", Slot = "4")]
		public NBEBPMPJHKD ABBFFCPOGNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AD80", Offset = "0x8C69980", VA = "0x188C6AD80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly FGNJANJHMFN OAAOPJJJOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float HMAHELOENHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 JABOPKABKMM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 OFDOLOIKMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C6F150", Offset = "0x8C6DD50", VA = "0x188C6F150", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8C702E0", Offset = "0x8C6EEE0", VA = "0x188C702E0")]
	public PIONNHAMJAI(FAPNOCLGFMC OLIIIAEGOLD, FGNJANJHMFN CBCNBAPLLJM, bool PDJPEPFGNDE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "18")]
	public override bool KOIMLNHKFPO(MFFDCMMCMLL OLIIIAEGOLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8C6F870", Offset = "0x8C6E470", VA = "0x188C6F870", Slot = "19")]
	public override int NNCPPFFEFMN(OKCIAHPLDOO LGKJAMKLNMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8C6F6A0", Offset = "0x8C6E2A0", VA = "0x188C6F6A0", Slot = "20")]
	public override int MDHFAHEMFIJ(OKCIAHPLDOO LGKJAMKLNMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8C6F280", Offset = "0x8C6DE80", VA = "0x188C6F280", Slot = "21")]
	public override KIKCGFOKPNE LNMOFBDOGDM()
	{
		return default(KIKCGFOKPNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xAC0B40", Offset = "0xABF740", VA = "0x180AC0B40", Slot = "22")]
	public override float AKNLJJEENEI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8C6E9A0", Offset = "0x8C6D5A0", VA = "0x188C6E9A0", Slot = "23")]
	public override void CABNKONIGGK(OKCIAHPLDOO LGKJAMKLNMC, APFMFPKGCBO DMKILMEJEPN, int EGMDMPPEDOO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8C70210", Offset = "0x8C6EE10", VA = "0x188C70210", Slot = "24")]
	public override MFFDCMMCMLL OCIKOEPKLEE()
	{
		return default(MFFDCMMCMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6EF90", Offset = "0x8C6DB90", VA = "0x188C6EF90", Slot = "26")]
	public override DIABLMANLMF FNELMMOMJFN()
	{
		return default(DIABLMANLMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8C6FA40", Offset = "0x8C6E640", VA = "0x188C6FA40", Slot = "27")]
	public override NCKCCKOPMIM NPGBAMCAOAJ(OKCIAHPLDOO LGKJAMKLNMC, JobHandle GPAFPAOOIJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface PKLJOGIBMIC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FAPNOCLGFMC KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CBFNMJJLHND KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DAFOKIHJLNA KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class HAKFNNMBHBI : CDDCNNEAHAH, IDisposable, PKLJOGIBMIC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FPKFAOJPDEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public HAKFNNMBHBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8C66050", Offset = "0x8C64C50", VA = "0x188C66050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8C665D0", Offset = "0x8C651D0", VA = "0x188C665D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly NMMCJMDOANO<ILKDGFHCBCG, FAPNOCLGFMC> GHMLACDKLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly NMMCJMDOANO<IFPPNNMCBNN, CBFNMJJLHND> GLGEEEILHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly NMMCJMDOANO<ACNEEOBLODC, DAFOKIHJLNA> EOBMGMJOMJB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public FAPNOCLGFMC KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8C678E0", Offset = "0x8C664E0", VA = "0x188C678E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public CBFNMJJLHND KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8C679A0", Offset = "0x8C665A0", VA = "0x188C679A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DAFOKIHJLNA KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8C67940", Offset = "0x8C66540", VA = "0x188C67940", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MKGPMLFADPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B50", Offset = "0xABF750", VA = "0x180AC0B50", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAC0880", Offset = "0xABF480", VA = "0x180AC0880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8C68850", Offset = "0x8C67450", VA = "0x188C68850")]
	public HAKFNNMBHBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8C669E0", Offset = "0x8C655E0", VA = "0x188C669E0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8C67290", Offset = "0x8C65E90", VA = "0x188C67290", Slot = "4")]
	public ILKDGFHCBCG IMPJDKAHLOH(CEIOAGBLDNK CBCNBAPLLJM)
	{
		return default(ILKDGFHCBCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8C672A0", Offset = "0x8C65EA0", VA = "0x188C672A0", Slot = "5")]
	public ILKDGFHCBCG IMPJDKAHLOH(CEIOAGBLDNK CBCNBAPLLJM, bool PDJPEPFGNDE)
	{
		return default(ILKDGFHCBCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8C67BC0", Offset = "0x8C667C0", VA = "0x188C67BC0", Slot = "6")]
	public void LBLHPCMMBLL(ILKDGFHCBCG OLIIIAEGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8C66D70", Offset = "0x8C65970", VA = "0x188C66D70", Slot = "7")]
	public void HCHJFIJKDAI(ILKDGFHCBCG OLIIIAEGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8C68300", Offset = "0x8C66F00", VA = "0x188C68300", Slot = "8")]
	public IFPPNNMCBNN MGAGOGOANIC(ILKDGFHCBCG OLIIIAEGOLD, IEBKPDHAODJ CBCNBAPLLJM)
	{
		return default(IFPPNNMCBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8C67E20", Offset = "0x8C66A20", VA = "0x188C67E20", Slot = "9")]
	public IFPPNNMCBNN LPAAANKKBDH(ILKDGFHCBCG OLIIIAEGOLD, FGNJANJHMFN CBCNBAPLLJM)
	{
		return default(IFPPNNMCBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8C67520", Offset = "0x8C66120", VA = "0x188C67520", Slot = "11")]
	public void JBADAFPIKID(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8C66630", Offset = "0x8C65230", VA = "0x188C66630", Slot = "10")]
	public void AOAPGNIDBKG(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8C66890", Offset = "0x8C65490", VA = "0x188C66890", Slot = "20")]
	public IEnumerable<Renderer> BCNCHGFCNJI(ILKDGFHCBCG OLIIIAEGOLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8C66960", Offset = "0x8C65560", VA = "0x188C66960", Slot = "12")]
	public ACNEEOBLODC DIPMKNAEDAC(GCKIODIAKBG CBCNBAPLLJM)
	{
		return default(ACNEEOBLODC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8C687E0", Offset = "0x8C673E0", VA = "0x188C687E0", Slot = "14")]
	public void NPDCOHKLKLN(ACNEEOBLODC JMLBNACNELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8C670D0", Offset = "0x8C65CD0", VA = "0x188C670D0", Slot = "16")]
	public Task HIKDFPLPGBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8C67A00", Offset = "0x8C66600", VA = "0x188C67A00", Slot = "17")]
	public Task KLJCIGNFFHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8C66BB0", Offset = "0x8C657B0", VA = "0x188C66BB0", Slot = "18")]
	[AsyncStateMachine(typeof(FPKFAOJPDEO))]
	public Task FPAPPGGLEMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8C66C80", Offset = "0x8C65880", VA = "0x188C66C80", Slot = "19")]
	public void GJFFFCBEHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8C66900", Offset = "0x8C65500", VA = "0x188C66900", Slot = "13")]
	public void BPBOHHLMHAB(ACNEEOBLODC JMLBNACNELK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class EBDJHIHKELC : CBFNMJJLHND
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct OAGACCICICE : NCKCCKOPMIM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private NBEBPMPJHKD MOGMOMKEFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> HDCMEDPIGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle GPAFPAOOIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private ICOJBFABPBC LEACCINCOPI;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6E940", Offset = "0x8C6D540", VA = "0x188C6E940")]
		public OAGACCICICE(NBEBPMPJHKD MOGMOMKEFJC, NativeArray<int> HDCMEDPIGEL, JobHandle GPAFPAOOIJM, ICOJBFABPBC LEACCINCOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6E840", Offset = "0x8C6D440", VA = "0x188C6E840", Slot = "4")]
		public NBEBPMPJHKD ABBFFCPOGNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6E8A0", Offset = "0x8C6D4A0", VA = "0x188C6E8A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly IEBKPDHAODJ OHABHFNOKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] EEIKHGLIKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 JABOPKABKMM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 LAHMHFOBFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8C63940", Offset = "0x8C62540", VA = "0x188C63940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 OFDOLOIKMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8C63040", Offset = "0x8C61C40", VA = "0x188C63040", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8C644C0", Offset = "0x8C630C0", VA = "0x188C644C0")]
	public EBDJHIHKELC(FAPNOCLGFMC OLIIIAEGOLD, IEBKPDHAODJ CBCNBAPLLJM, bool MDEBLJHBACM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8C63170", Offset = "0x8C61D70", VA = "0x188C63170", Slot = "18")]
	public override bool KOIMLNHKFPO(MFFDCMMCMLL OLIIIAEGOLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8C63850", Offset = "0x8C62450", VA = "0x188C63850", Slot = "21")]
	public override KIKCGFOKPNE LNMOFBDOGDM()
	{
		return default(KIKCGFOKPNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8C63240", Offset = "0x8C61E40", VA = "0x188C63240")]
	private KIKCGFOKPNE LNMOFBDOGDM(MFFDCMMCMLL OLIIIAEGOLD)
	{
		return default(KIKCGFOKPNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8C62C80", Offset = "0x8C61880", VA = "0x188C62C80")]
	private JFHFAPGFGMD FIPHLMGCCJF([In] UniformTRS CGLBHIKNDNH, [In] float3 LEDEKGCGNFK)
	{
		return default(JFHFAPGFGMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8C63B70", Offset = "0x8C62770", VA = "0x188C63B70", Slot = "19")]
	public override int NNCPPFFEFMN(OKCIAHPLDOO LGKJAMKLNMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8C63890", Offset = "0x8C62490", VA = "0x188C63890", Slot = "20")]
	public override int MDHFAHEMFIJ(OKCIAHPLDOO LGKJAMKLNMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8C620B0", Offset = "0x8C60CB0", VA = "0x188C620B0", Slot = "22")]
	public override float AKNLJJEENEI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8C62A00", Offset = "0x8C61600", VA = "0x188C62A00")]
	private int DBBAACHLENI(OKCIAHPLDOO LGKJAMKLNMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8C621A0", Offset = "0x8C60DA0", VA = "0x188C621A0", Slot = "23")]
	public override void CABNKONIGGK(OKCIAHPLDOO LGKJAMKLNMC, APFMFPKGCBO DMKILMEJEPN, int EGMDMPPEDOO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8C643F0", Offset = "0x8C62FF0", VA = "0x188C643F0", Slot = "24")]
	public override MFFDCMMCMLL OCIKOEPKLEE()
	{
		return default(MFFDCMMCMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8C62E80", Offset = "0x8C61A80", VA = "0x188C62E80", Slot = "26")]
	public override DIABLMANLMF FNELMMOMJFN()
	{
		return default(DIABLMANLMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8C63C20", Offset = "0x8C62820", VA = "0x188C63C20", Slot = "27")]
	public override NCKCCKOPMIM NPGBAMCAOAJ(OKCIAHPLDOO LGKJAMKLNMC, JobHandle GPAFPAOOIJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BFCHHFMHLDN
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHKNPDJGDFN(KEFCOOGBPIF MDCDODCGNEK, Renderer NMGNJGPOFCI, int HFJCJGKLCAH);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAABGALGCIK(Renderer NMGNJGPOFCI, PGIDKEHBCFN HPKPAJMIMBN, Vector3 EHGGEFBPAKP, Vector3 OOGFCPJNKHC, Vector3 LJBDBKJKCPJ, float MNGDAKKKENJ, float EOBEEFICDAI, float EBCDCLDBJFI = -1f, [Optional] Color? MGBNCENPLKH, [Optional] IReadOnlyList<Camera> HOPFLDCEMAC);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POEJLHBOOKF(Renderer NMGNJGPOFCI, int HFJCJGKLCAH);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OBHDDBKBMAH();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADFCBIPEDHD(int OLMOGNFMJDL, HEODKAOIMMP MDCDODCGNEK, Renderer NMGNJGPOFCI, int HFJCJGKLCAH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DHOIJMJACNK : ANFGPDFLLEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class KDGCDJMKFKO : DMMLPNPFBMG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AFF0", Offset = "0x8C69BF0", VA = "0x188C6AFF0")]
		public KDGCDJMKFKO(string BKILENEPEEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly BFCHHFMHLDN EPNPJAEILFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PKLJOGIBMIC KAAEJLCPMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer ENHHGJCJHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private KDGCDJMKFKO HFANFBAALHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool PPAIOPMIGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer JKBEIEFONLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private KDGCDJMKFKO NGMNAMFBJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool LILONCHLABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer MMLOJFNPEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private KDGCDJMKFKO NEBAPKCNLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool CIBICKDAHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool BNHFKKOIPKI;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA67BC0", Offset = "0xA667C0", VA = "0x180A67BC0")]
	public DHOIJMJACNK(BFCHHFMHLDN GPPOCCBIKEF, PKLJOGIBMIC KAAEJLCPMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8C5FAD0", Offset = "0x8C5E6D0", VA = "0x188C5FAD0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8C5FC80", Offset = "0x8C5E880", VA = "0x188C5FC80")]
	private void EIJAILBBODI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8C61CD0", Offset = "0x8C608D0", VA = "0x188C61CD0", Slot = "4")]
	public void PHHBEMJKJDP(ILKDGFHCBCG OLIIIAEGOLD, HEODKAOIMMP AFOHEDFHHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8C61AB0", Offset = "0x8C606B0", VA = "0x188C61AB0", Slot = "5")]
	public void PHHBEMJKJDP(IFPPNNMCBNN MIEJLCKINFM, HEODKAOIMMP AFOHEDFHHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5F8A0", Offset = "0x8C5E4A0", VA = "0x188C5F8A0", Slot = "6")]
	public void BOPDBMDPLPN(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8C5F710", Offset = "0x8C5E310", VA = "0x188C5F710", Slot = "7")]
	public void ADLNNGHKOKC(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8C5F860", Offset = "0x8C5E460", VA = "0x188C5F860", Slot = "24")]
	public void BBDLNNBAIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x11D71B0", Offset = "0x11D5DB0", VA = "0x1811D71B0", Slot = "8")]
	public void KGGHFIPCAPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8C60D20", Offset = "0x8C5F920", VA = "0x188C60D20", Slot = "9")]
	public void LOEDBEBHALB(HEODKAOIMMP AFOHEDFHHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8C604C0", Offset = "0x8C5F0C0", VA = "0x188C604C0", Slot = "10")]
	public void HHMAHDIHKDM(ILKDGFHCBCG OLIIIAEGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8C60160", Offset = "0x8C5ED60", VA = "0x188C60160", Slot = "11")]
	public void HHMAHDIHKDM(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8C61FE0", Offset = "0x8C60BE0", VA = "0x188C61FE0", Slot = "12")]
	public void PKGENKHHLBH(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C619E0", Offset = "0x8C605E0", VA = "0x188C619E0", Slot = "13")]
	public void NHBGBDKPJCC(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C5FEF0", Offset = "0x8C5EAF0", VA = "0x188C5FEF0")]
	private void HHJBOBBIIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x153FC50", Offset = "0x153E850", VA = "0x18153FC50", Slot = "14")]
	public void EJFBLFNNMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8C60790", Offset = "0x8C5F390", VA = "0x188C60790", Slot = "15")]
	public void JGDKIBECFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8C61700", Offset = "0x8C60300", VA = "0x188C61700", Slot = "16")]
	public void NENAFNPCGOP(ILKDGFHCBCG OLIIIAEGOLD, KEFCOOGBPIF MDCDODCGNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8C60C50", Offset = "0x8C5F850", VA = "0x188C60C50", Slot = "17")]
	public void KBEDNJEIEBB(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8C5FA00", Offset = "0x8C5E600", VA = "0x188C5FA00", Slot = "18")]
	public void BPKMMFFCMHJ(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xDBCE40", Offset = "0xDBBA40", VA = "0x180DBCE40", Slot = "19")]
	public void GOGKNFBMBNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8C608B0", Offset = "0x8C5F4B0", VA = "0x188C608B0", Slot = "20")]
	public void JIHBPEBFBDG(KEFCOOGBPIF MDCDODCGNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8C609E0", Offset = "0x8C5F5E0", VA = "0x188C609E0")]
	private void JIKAGAABJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8C61330", Offset = "0x8C5FF30", VA = "0x188C61330", Slot = "21")]
	public void NBDDCEMKDLC(ILKDGFHCBCG OLIIIAEGOLD, Vector3 EHGGEFBPAKP, Vector3 OOGFCPJNKHC, Vector3 LJBDBKJKCPJ, float MNGDAKKKENJ, float EOBEEFICDAI, IReadOnlyList<Camera> FEBDNCKKAFK, PGIDKEHBCFN HPKPAJMIMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8C60E90", Offset = "0x8C5FA90", VA = "0x188C60E90", Slot = "22")]
	public void NBDDCEMKDLC(ACNEEOBLODC JMLBNACNELK, Vector3 EHGGEFBPAKP, Vector3 OOGFCPJNKHC, Vector3 LJBDBKJKCPJ, float MNGDAKKKENJ, float EOBEEFICDAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class CBFNMJJLHND : DANPMOAJAJJ, FBDGJFDLGBN, AEIFENEDGGE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly FAPNOCLGFMC AMCBICJEEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int BBKEDIFIGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds HAIJEHKNCEK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds APDNKBOPLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C5E270", Offset = "0x8C5CE70", VA = "0x188C5E270", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool PJAFHNFDEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE8E870", Offset = "0xE8D470", VA = "0x180E8E870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xEB2320", Offset = "0xEB0F20", VA = "0x180EB2320")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 OFDOLOIKMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GJIPLMGMIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D40", Offset = "0xAB1940", VA = "0x180AB2D40", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public MJBALHOLBAB INCHFBMHHPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5D0", Offset = "0xA5A1D0", VA = "0x180A5B5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool LCNEKDMBCOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xFF3DF0", Offset = "0xFF29F0", VA = "0x180FF3DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	protected CBFNMJJLHND(FAPNOCLGFMC OLIIIAEGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E0A0", Offset = "0x8C5CCA0", VA = "0x188C5E0A0", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "18")]
	public virtual bool KOIMLNHKFPO(MFFDCMMCMLL OLIIIAEGOLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E090", Offset = "0x8C5CC90", VA = "0x188C5E090", Slot = "10")]
	public int BPDFCMDMHJI(int OBOKPMHDPGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int NNCPPFFEFMN(OKCIAHPLDOO LGKJAMKLNMC);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int MDHFAHEMFIJ(OKCIAHPLDOO LGKJAMKLNMC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract KIKCGFOKPNE LNMOFBDOGDM();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float AKNLJJEENEI();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void CABNKONIGGK(OKCIAHPLDOO LGKJAMKLNMC, APFMFPKGCBO DMKILMEJEPN, int EGMDMPPEDOO = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract MFFDCMMCMLL OCIKOEPKLEE();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E240", Offset = "0x8C5CE40", VA = "0x188C5E240", Slot = "13")]
	public Hash128 IKOOFLBAMID(int LGKJAMKLNMC)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract DIABLMANLMF FNELMMOMJFN();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract NCKCCKOPMIM NPGBAMCAOAJ(OKCIAHPLDOO LGKJAMKLNMC, JobHandle GPAFPAOOIJM);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E210", Offset = "0x8C5CE10", VA = "0x188C5E210", Slot = "12")]
	public NCKCCKOPMIM HOFEGPGLLDH(int LGKJAMKLNMC)
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
		[Cpp2IlInjected.Address(RVA = "0x8C709D0", Offset = "0x8C6F5D0", VA = "0x188C709D0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MGPDMIMOCMM
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KBGBMLKJPFN : IEnumerable<NLPPMKHGDOM>, IEnumerable, IEnumerator<NLPPMKHGDOM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private NLPPMKHGDOM <>2__current;

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
		private NLPPMKHGDOM System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public KBGBMLKJPFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AE30", Offset = "0x8C69A30", VA = "0x188C6AE30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AFA0", Offset = "0x8C69BA0", VA = "0x188C6AFA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AF00", Offset = "0x8C69B00", VA = "0x188C6AF00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NLPPMKHGDOM> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AF00", Offset = "0x8C69B00", VA = "0x188C6AF00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static NLPPMKHGDOM[][] IDEFFBLLABP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static JIHHKCJGNLO MKMAGNNIBAO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig NHKKNDCDHKO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader FHFKCPPNHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C6F0", Offset = "0x8C6B2F0", VA = "0x188C6C6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer MDMAAFOENFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C940", Offset = "0x8C6B540", VA = "0x188C6C940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8C6C3F0", Offset = "0x8C6AFF0", VA = "0x188C6C3F0")]
	[BDMFNNIICLO]
	internal static void BFHPBJMBKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8C6CD80", Offset = "0x8C6B980", VA = "0x188C6CD80")]
	public static Mesh NDIMOBEGOIG(GKNAEPKFNMA KIOMCIELFGC, int LGKJAMKLNMC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8C6CD70", Offset = "0x8C6B970", VA = "0x188C6CD70")]
	public static int LPOBFHKDEIO(GKNAEPKFNMA KIOMCIELFGC, int LGKJAMKLNMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8C6CE20", Offset = "0x8C6BA20", VA = "0x188C6CE20")]
	public static JIHHKCJGNLO NLIPELDAPAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8C6C4E0", Offset = "0x8C6B0E0", VA = "0x188C6C4E0")]
	[IteratorStateMachine(typeof(KBGBMLKJPFN))]
	private static IEnumerable<NLPPMKHGDOM> BFLHHHNJBJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D040", Offset = "0x8C6BC40", VA = "0x188C6D040")]
	public static NLPPMKHGDOM ODGGBJEIMIK(GKNAEPKFNMA KIOMCIELFGC, int LGKJAMKLNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8C6C3D0", Offset = "0x8C6AFD0", VA = "0x188C6C3D0")]
	public static bool BAKOPLKGIGG(this GKNAEPKFNMA KIOMCIELFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8C6C540", Offset = "0x8C6B140", VA = "0x188C6C540")]
	public static void DPCAEJOMFMB(GKNAEPKFNMA KIOMCIELFGC, float3 IGNHFFMBOBK, [Out] AEMFOLEIIBF GEENCLLFCIJ, [Out] float3 NGOGDONKELE, [Out] float OLGCEBOCAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8C6C9A0", Offset = "0x8C6B5A0", VA = "0x188C6C9A0")]
	public static void LECKLEPEDKA(Vector3 IGNHFFMBOBK, GKNAEPKFNMA KIOMCIELFGC, [Out] Vector3 NGOGDONKELE, [Out] float OLGCEBOCAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8C6C930", Offset = "0x8C6B530", VA = "0x188C6C930")]
	[CIKMCEEPFOC(0)]
	[POMCFIKNKFG(JPJKPLJPMPJ.ExitingPlayMode, 0)]
	private static void KBNKODMHBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8C6C750", Offset = "0x8C6B350", VA = "0x188C6C750")]
	[CIKMCEEPFOC(0)]
	[POMCFIKNKFG(JPJKPLJPMPJ.ExitingPlayMode, 0)]
	private static void HMIEJBBAJLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class KHMGNIOJMLL : CDDCNNEAHAH, IDisposable, PKLJOGIBMIC
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly NMMCJMDOANO<ILKDGFHCBCG, FAPNOCLGFMC> GHMLACDKLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NMMCJMDOANO<IFPPNNMCBNN, CBFNMJJLHND> GLGEEEILHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NMMCJMDOANO<ACNEEOBLODC, DAFOKIHJLNA> EOBMGMJOMJB;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public FAPNOCLGFMC KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B630", Offset = "0x8C6A230", VA = "0x188C6B630", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public CBFNMJJLHND KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B570", Offset = "0x8C6A170", VA = "0x188C6B570", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DAFOKIHJLNA KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B5D0", Offset = "0x8C6A1D0", VA = "0x188C6B5D0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MKGPMLFADPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B50", Offset = "0xABF750", VA = "0x180AC0B50", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAC0880", Offset = "0xABF480", VA = "0x180AC0880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB10", Offset = "0x8C6A710", VA = "0x188C6BB10")]
	public KHMGNIOJMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B1F0", Offset = "0x8C69DF0", VA = "0x188C6B1F0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B440", Offset = "0x8C6A040", VA = "0x188C6B440", Slot = "4")]
	public ILKDGFHCBCG IMPJDKAHLOH(CEIOAGBLDNK CBCNBAPLLJM)
	{
		return default(ILKDGFHCBCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B440", Offset = "0x8C6A040", VA = "0x188C6B440", Slot = "5")]
	public ILKDGFHCBCG IMPJDKAHLOH(CEIOAGBLDNK CBCNBAPLLJM, bool PDJPEPFGNDE)
	{
		return default(ILKDGFHCBCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B730", Offset = "0x8C6A330", VA = "0x188C6B730", Slot = "6")]
	public void LBLHPCMMBLL(ILKDGFHCBCG OLIIIAEGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B320", Offset = "0x8C69F20", VA = "0x188C6B320", Slot = "7")]
	public void HCHJFIJKDAI(ILKDGFHCBCG OLIIIAEGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B8D0", Offset = "0x8C6A4D0", VA = "0x188C6B8D0", Slot = "8")]
	public IFPPNNMCBNN MGAGOGOANIC(ILKDGFHCBCG OLIIIAEGOLD, IEBKPDHAODJ CBCNBAPLLJM)
	{
		return default(IFPPNNMCBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B790", Offset = "0x8C6A390", VA = "0x188C6B790", Slot = "9")]
	public IFPPNNMCBNN LPAAANKKBDH(ILKDGFHCBCG OLIIIAEGOLD, FGNJANJHMFN CBCNBAPLLJM)
	{
		return default(IFPPNNMCBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B4E0", Offset = "0x8C6A0E0", VA = "0x188C6B4E0", Slot = "11")]
	public void JBADAFPIKID(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B040", Offset = "0x8C69C40", VA = "0x188C6B040", Slot = "10")]
	public void AOAPGNIDBKG(IFPPNNMCBNN MIEJLCKINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B0A0", Offset = "0x8C69CA0", VA = "0x188C6B0A0", Slot = "20")]
	public IEnumerable<Renderer> BCNCHGFCNJI(ILKDGFHCBCG OLIIIAEGOLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B170", Offset = "0x8C69D70", VA = "0x188C6B170", Slot = "12")]
	public ACNEEOBLODC DIPMKNAEDAC(GCKIODIAKBG CBCNBAPLLJM)
	{
		return default(ACNEEOBLODC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BA10", Offset = "0x8C6A610", VA = "0x188C6BA10", Slot = "14")]
	public void NPDCOHKLKLN(ACNEEOBLODC JMLBNACNELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B3A0", Offset = "0x8C69FA0", VA = "0x188C6B3A0", Slot = "16")]
	public Task HIKDFPLPGBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B690", Offset = "0x8C6A290", VA = "0x188C6B690", Slot = "17")]
	public Task KLJCIGNFFHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B280", Offset = "0x8C69E80", VA = "0x188C6B280", Slot = "18")]
	public Task FPAPPGGLEMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x28E1BD0", Offset = "0x28E07D0", VA = "0x1828E1BD0", Slot = "19")]
	public void GJFFFCBEHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B110", Offset = "0x8C69D10", VA = "0x188C6B110", Slot = "13")]
	public void BPBOHHLMHAB(ACNEEOBLODC JMLBNACNELK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LHBMLIGLEAI
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool PIACEKJEEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material AIHPJHJGLGM();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material IHKBOGJIBIO();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material LIIMLEILPED();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int AHEIFIEJBLI(HEEBNBDCPDH GNNJAKNCLCC);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BCDHPPJHGNL(BNIMJFMEDEA PGGKCHFCEHH);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GIJDNOBKGFJ(GameObject KOJLNGLNBMH);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HOLANJIPDKO(GameObject KOJLNGLNBMH, bool NHPENFAKNNN);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class HMMNGDKHKPN
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static LHBMLIGLEAI EIFNOCFPPHB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool PIACEKJEEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8C69960", Offset = "0x8C68560", VA = "0x188C69960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8C69740", Offset = "0x8C68340", VA = "0x188C69740")]
	public static void BDMMGMNKNHN(LHBMLIGLEAI MDHJJCILMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8C69670", Offset = "0x8C68270", VA = "0x188C69670")]
	public static Material AIHPJHJGLGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8C65270", Offset = "0x8C63E70", VA = "0x188C65270")]
	public static Material IHKBOGJIBIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8C699C0", Offset = "0x8C685C0", VA = "0x188C699C0")]
	public static Material LIIMLEILPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8C69600", Offset = "0x8C68200", VA = "0x188C69600")]
	public static int AHEIFIEJBLI(HEEBNBDCPDH GNNJAKNCLCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8C696D0", Offset = "0x8C682D0", VA = "0x188C696D0")]
	public static int BCDHPPJHGNL(BNIMJFMEDEA PGGKCHFCEHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8C697A0", Offset = "0x8C683A0", VA = "0x188C697A0")]
	public static void GIJDNOBKGFJ(GameObject KOJLNGLNBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8C69870", Offset = "0x8C68470", VA = "0x188C69870")]
	public static void HOLANJIPDKO(GameObject KOJLNGLNBMH, bool NHPENFAKNNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DAFOKIHJLNA : MGIEEOHCBMD
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class LDNCNEOCGIH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DAFOKIHJLNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public LDNCNEOCGIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C270", Offset = "0x8C6AE70", VA = "0x188C6C270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8C6BF50", Offset = "0x8C6AB50", VA = "0x188C6BF50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8C6BF00", Offset = "0x8C6AB00", VA = "0x188C6BF00")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C220", Offset = "0x8C6AE20", VA = "0x188C6C220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C170", Offset = "0x8C6AD70", VA = "0x188C6C170", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8C6C170", Offset = "0x8C6AD70", VA = "0x188C6C170", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GCKIODIAKBG NPAGPLPJOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly PKLJOGIBMIC KAAEJLCPMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private HEEJLFKKOOA CGFJBLHFEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<IHFECKGDNNN> IEMGLOPCPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<IHFECKGDNNN> NNLBKMDEBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject EINOIADAFKB;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E290", Offset = "0x8C5CE90", VA = "0x188C5E290")]
	public static DAFOKIHJLNA CAOCDLCCOPC(GCKIODIAKBG CBCNBAPLLJM, PKLJOGIBMIC KAAEJLCPMCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8C5F630", Offset = "0x8C5E230", VA = "0x188C5F630")]
	private DAFOKIHJLNA(GCKIODIAKBG CBCNBAPLLJM, PKLJOGIBMIC KAAEJLCPMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E410", Offset = "0x8C5D010", VA = "0x188C5E410")]
	public void EDJAHJBIEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8C5F5B0", Offset = "0x8C5E1B0", VA = "0x188C5F5B0")]
	[IteratorStateMachine(typeof(LDNCNEOCGIH))]
	public IEnumerable<Renderer> OMGOJGOIINC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8C5EAF0", Offset = "0x8C5D6F0", VA = "0x188C5EAF0", Slot = "4")]
	public void NLBEDIKOMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E3E0", Offset = "0x8C5CFE0", VA = "0x188C5E3E0")]
	private void CNHCKBHJPGA(Vector3 JJEPJKKKBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E8A0", Offset = "0x8C5D4A0", VA = "0x188C5E8A0")]
	public void MONBEGLCAAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IHFECKGDNNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct FAJJPNBDLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public APFMFPKGCBO BEFLHBFGKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MFFDCMMCMLL MLAIDABMILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int NOGFGDPMNAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AAKMGGHOION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public IHFECKGDNNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public OKCIAHPLDOO lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<FAJJPNBDLIP> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NBEBPMPJHKD combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AAKMGGHOION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8C5E030", Offset = "0x8C5CC30", VA = "0x188C5E030")]
		internal JobHandle GEHOIAPHLML()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8C5DE90", Offset = "0x8C5CA90", VA = "0x188C5DE90")]
		internal void EAALGDEJIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8C5DEC0", Offset = "0x8C5CAC0", VA = "0x188C5DEC0")]
		internal void EMMPMFOEEPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] JDIFMJFIECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JGFDDBDHNNC BHDOIOMINEO;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 ELFEDLCOHAD;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh FFKMDKFBNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int PGAGAJGEJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCA0", Offset = "0xA5E8A0", VA = "0x180A5FCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8C6A5A0", Offset = "0x8C691A0", VA = "0x188C6A5A0")]
	public void PKCLMCKKKCJ(List<MFFDCMMCMLL> KHFCCBJOOIB, Matrix4x4[] OJMHCCHIMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8C69E30", Offset = "0x8C68A30", VA = "0x188C69E30")]
	public static List<IHFECKGDNNN> FOGKIHKKOLG(List<FAPNOCLGFMC> IGLDLPEJMLE, OKCIAHPLDOO LGKJAMKLNMC, Bounds NLJLEJAEPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8C69AC0", Offset = "0x8C686C0", VA = "0x188C69AC0")]
	private JobHandle FIMIHNCAHPI(NBEBPMPJHKD FOCMHIHDJMF, int FGNHPKKNDCF, int LHNAJOMDMME, OKCIAHPLDOO LGKJAMKLNMC, List<FAJJPNBDLIP> BIKGKMGGKKL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8C6A4C0", Offset = "0x8C690C0", VA = "0x188C6A4C0")]
	private void KKIBBFIFCMP(List<FAJJPNBDLIP> BIKGKMGGKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8C6A930", Offset = "0x8C69530", VA = "0x188C6A930")]
	private IHFECKGDNNN(List<FAJJPNBDLIP> BIKGKMGGKKL, int FGNHPKKNDCF, int LHNAJOMDMME, OKCIAHPLDOO LGKJAMKLNMC, Bounds NLJLEJAEPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8C69A20", Offset = "0x8C68620", VA = "0x188C69A20", Slot = "4")]
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
		private MaterialPropertyBlock PMNNKJEDBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IHFECKGDNNN MOGMOMKEFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<MFFDCMMCMLL> EFBCPLLDMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture JDJMILDMGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer NLONBCOLPOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader MMEGDAAKJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] NOHNOFEJCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int LHAOGFMAOHH;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer GPMMAGCFGEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int FOPHNEDFIBI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8C71760", Offset = "0x8C70360", VA = "0x188C71760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8C70A30", Offset = "0x8C6F630", VA = "0x188C70A30")]
		public static List<SkinnedShapeRenderer> Create(GameObject OLIIIAEGOLD, List<IHFECKGDNNN> PCGDPIHLPGE, List<MFFDCMMCMLL> EFBCPLLDMDA, Material CIBNABIMGCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8C70DE0", Offset = "0x8C6F9E0", VA = "0x188C70DE0")]
		public void Init(IHFECKGDNNN MOGMOMKEFJC, List<MFFDCMMCMLL> EFBCPLLDMDA, Material CIBNABIMGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8C71350", Offset = "0x8C6FF50", VA = "0x188C71350")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8C712B0", Offset = "0x8C6FEB0", VA = "0x188C712B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8C71270", Offset = "0x8C6FE70", VA = "0x188C71270")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8C70D20", Offset = "0x8C6F920", VA = "0x188C70D20")]
		private void FEOJLLDIJOP(ScriptableRenderContext PBHLPKLGFAP, Camera[] EHPKGGHMDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8C713F0", Offset = "0x8C6FFF0", VA = "0x188C713F0")]
		private void PKCLMCKKKCJ(CommandBuffer KPMAELAGKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
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
