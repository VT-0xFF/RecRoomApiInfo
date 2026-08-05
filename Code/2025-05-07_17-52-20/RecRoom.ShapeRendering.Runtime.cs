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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8713CB0", Offset = "0x8712CB0", VA = "0x188713CB0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x871D420", Offset = "0x871C420", VA = "0x18871D420", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NPCHOHPGHOL : DKKEIIEJNPK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte IEIEMFEOPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] GDHEBGBAJMD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OBBFBAJIIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LNJGAKGJBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9B0", Offset = "0xCFB9B0", VA = "0x180CFC9B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF0C6F0", Offset = "0xF0B6F0", VA = "0x180F0C6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float EBNNJCOJCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF2D890", Offset = "0xF2C890", VA = "0x180F2D890", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12AA110", Offset = "0x12A9110", VA = "0x1812AA110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JBJNBMCEJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC20B90", Offset = "0xC1FB90", VA = "0x180C20B90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC20BA0", Offset = "0xC1FBA0", VA = "0x180C20BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> PEMGICOPMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8716770", Offset = "0x8715770", VA = "0x188716770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> NBDDHABCFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87168C0", Offset = "0x87158C0", VA = "0x1887168C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte ADEMLIENNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8716720", Offset = "0x8715720", VA = "0x188716720", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8716D00", Offset = "0x8715D00", VA = "0x188716D00")]
	public NPCHOHPGHOL(List<IAIKDIPJMBL> DEANJJFHEMK, List<IAIKDIPJMBL> AKAHLDMCEAM, List<CIPJGNAKHIH> IFACPDBOEIA, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8716BA0", Offset = "0x8715BA0", VA = "0x188716BA0")]
	private int LPKLAPIICAF(List<IAIKDIPJMBL> LHHLMCNOLOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x87168F0", Offset = "0x87158F0", VA = "0x1887168F0")]
	private void IPDCDNCLGNE(int HLIBGEBDNGJ, bool CBHHPIGGAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8716A50", Offset = "0x8715A50", VA = "0x188716A50")]
	public void LBCCKFFLOHK(Vector3 KIBNLFAIDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x87167C0", Offset = "0x87157C0", VA = "0x1887167C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8716CC0", Offset = "0x8715CC0", VA = "0x188716CC0")]
	public void PHANNMLCEHO(Transform KKHEOIBNFBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KHGMKIBFIKG : DCJLPKNHAKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GNCKEJFLOPA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KHGMKIBFIKG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public GNCKEJFLOPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x870E270", Offset = "0x870D270", VA = "0x18870E270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x870DC10", Offset = "0x870CC10", VA = "0x18870DC10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x870DBC0", Offset = "0x870CBC0", VA = "0x18870DBC0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x870E120", Offset = "0x870D120", VA = "0x18870E120")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x870DB70", Offset = "0x870CB70", VA = "0x18870DB70")]
		private void CGHFFBOFAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x870E220", Offset = "0x870D220", VA = "0x18870E220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x870E170", Offset = "0x870D170", VA = "0x18870E170", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x870E170", Offset = "0x870D170", VA = "0x18870E170", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FIMCKIMDHHD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KHGMKIBFIKG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public FIMCKIMDHHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x870D9F0", Offset = "0x870C9F0", VA = "0x18870D9F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x870D530", Offset = "0x870C530", VA = "0x18870D530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x870D4E0", Offset = "0x870C4E0", VA = "0x18870D4E0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x870D8A0", Offset = "0x870C8A0", VA = "0x18870D8A0")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x870D9A0", Offset = "0x870C9A0", VA = "0x18870D9A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x870D8F0", Offset = "0x870C8F0", VA = "0x18870D8F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x870D8F0", Offset = "0x870C8F0", VA = "0x18870D8F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HIOINALINKM GPHGBEGKLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<KNNJCBPNHCB> IJBKMDJICDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> FADFOLEPGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer FFMJKENGIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MGPAHKOONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool FIJGAFAPGND;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<NGPLIHHOGDL> LAPOLAKAPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OIFONFBLFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8712B00", Offset = "0x8711B00", VA = "0x188712B00", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CIPJGNAKHIH BIKCOAMGMAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87127C0", Offset = "0x87117C0", VA = "0x1887127C0", Slot = "8")]
		get
		{
			return default(CIPJGNAKHIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> KLEGNEBJNID
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x87127A0", Offset = "0x87117A0", VA = "0x1887127A0")]
	private bool AOFPPENMDDL(KNNJCBPNHCB HIECCNNOPLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8712D30", Offset = "0x8711D30", VA = "0x188712D30")]
	private static bool FHJCOLKGBCA(KNNJCBPNHCB HIECCNNOPLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x87139C0", Offset = "0x87129C0", VA = "0x1887139C0")]
	public KHGMKIBFIKG(HIOINALINKM APDBNIMCPID, bool BFAJCNNIPLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8712B40", Offset = "0x8711B40", VA = "0x188712B40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8713120", Offset = "0x8712120", VA = "0x188713120")]
	public void IIGLPCDPOEE(KNNJCBPNHCB HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8712D50", Offset = "0x8711D50", VA = "0x188712D50")]
	public void GNAALOCCJEL(KNNJCBPNHCB HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8713440", Offset = "0x8712440", VA = "0x188713440", Slot = "4")]
	public void LODKFBECFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8712EB0", Offset = "0x8711EB0", VA = "0x188712EB0")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8712940", Offset = "0x8711940", VA = "0x188712940")]
	private void CMMDIHBPOIN(List<KNNJCBPNHCB> IJBKMDJICDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x870A280", Offset = "0x8709280", VA = "0x18870A280")]
	private static Material HKOJDKHKMED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8712890", Offset = "0x8711890", VA = "0x188712890")]
	private void CMMDIHBPOIN(KNNJCBPNHCB HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x87132F0", Offset = "0x87122F0", VA = "0x1887132F0")]
	private void JIPKOONHHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8712160", Offset = "0x8711160", VA = "0x188712160")]
	public void AIGIHEFBOPB(bool HHHPLEOKNJL, bool AMBBNPAKHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x87120A0", Offset = "0x87110A0", VA = "0x1887120A0")]
	protected void ACICODFLEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8712720", Offset = "0x8711720", VA = "0x188712720")]
	public void ANGPGLODHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8713940", Offset = "0x8712940", VA = "0x188713940")]
	[IteratorStateMachine(typeof(GNCKEJFLOPA))]
	public IEnumerable<Renderer> MPIPDNBCHBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x87133C0", Offset = "0x87123C0", VA = "0x1887133C0")]
	[IteratorStateMachine(typeof(FIMCKIMDHHD))]
	public IEnumerable<Renderer> KOJKCADIGFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class OAJNMHDDGIP : KNNJCBPNHCB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct IEJGFCEJKBL : KNHDOEOGJOI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OFNFOCEBPOF PEPFHNJFNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle GMNPCPDAADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private FKMOHECEINB KJIJIHOMHHM;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x870F810", Offset = "0x870E810", VA = "0x18870F810")]
		public IEJGFCEJKBL(OFNFOCEBPOF PEPFHNJFNIL, JobHandle GMNPCPDAADC, FKMOHECEINB KJIJIHOMHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x870F7E0", Offset = "0x870E7E0", VA = "0x18870F7E0", Slot = "4")]
		public OFNFOCEBPOF MCMIEJOHGAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x870F790", Offset = "0x870E790", VA = "0x18870F790", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly HFIDGLOEBHF NIDOJEDNAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float AGJKGIKAMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 AAPKOFDNEDG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 NKJLBIDOMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x87177F0", Offset = "0x87167F0", VA = "0x1887177F0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8718980", Offset = "0x8717980", VA = "0x188718980")]
	public OAJNMHDDGIP(KHGMKIBFIKG KNNDNAPJIDP, HFIDGLOEBHF APDBNIMCPID, bool BFAJCNNIPLE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "18")]
	public override bool DFFDHGPHIMM(CIPJGNAKHIH KNNDNAPJIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x87181C0", Offset = "0x87171C0", VA = "0x1887181C0", Slot = "19")]
	public override int LPKLAPIICAF(OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8717D60", Offset = "0x8716D60", VA = "0x188717D60", Slot = "20")]
	public override int GGOEFFEMMHB(OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8717920", Offset = "0x8716920", VA = "0x188717920", Slot = "21")]
	public override KDIOIEALNPI DNNHBCPOLFN()
	{
		return default(KDIOIEALNPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xBFFA10", Offset = "0xBFEA10", VA = "0x180BFFA10", Slot = "22")]
	public override float EBJAGBCCIDO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8718390", Offset = "0x8717390", VA = "0x188718390", Slot = "23")]
	public override void NCNAONCBLEI(OEDNPOAFIDC GKGMDAMJCNF, OGPFNIIHPFO KEIICMNLBCF, int JELELPJBLDG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x87180F0", Offset = "0x87170F0", VA = "0x1887180F0", Slot = "24")]
	public override CIPJGNAKHIH LAOJGEPMLKG()
	{
		return default(CIPJGNAKHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8717F30", Offset = "0x8716F30", VA = "0x188717F30", Slot = "26")]
	public override BJJJCPEHCID KDFCGDBGIAI()
	{
		return default(BJJJCPEHCID);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8717020", Offset = "0x8716020", VA = "0x188717020", Slot = "27")]
	public override KNHDOEOGJOI AMEJLFPKBDJ(OEDNPOAFIDC GKGMDAMJCNF, JobHandle GMNPCPDAADC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface BCFOMFEJOFB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KHGMKIBFIKG OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KNNJCBPNHCB OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DJJLLLMIHIH OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class JEHNOLCFLEF : GDHFOHFFOAJ, IDisposable, BCFOMFEJOFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BKHJIKIKDFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JEHNOLCFLEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8709A70", Offset = "0x8708A70", VA = "0x188709A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8709FF0", Offset = "0x8708FF0", VA = "0x188709FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly PEBNEEMIANK<NCCENBGIEMA, KHGMKIBFIKG> IHIGDICMEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly PEBNEEMIANK<CNEDHOBLNKD, KNNJCBPNHCB> IJBKMDJICDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly PEBNEEMIANK<AENBPOANBNH, DJJLLLMIHIH> IFJDFIDDJNA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public KHGMKIBFIKG OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x870FA20", Offset = "0x870EA20", VA = "0x18870FA20", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public KNNJCBPNHCB OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x870F9C0", Offset = "0x870E9C0", VA = "0x18870F9C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DJJLLLMIHIH OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x870F960", Offset = "0x870E960", VA = "0x18870F960", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NKAMGGLIJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDA98B0", Offset = "0xDA88B0", VA = "0x180DA98B0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA92FB0", Offset = "0xA91FB0", VA = "0x180A92FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8711A90", Offset = "0x8710A90", VA = "0x188711A90")]
	public JEHNOLCFLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x870FA80", Offset = "0x870EA80", VA = "0x18870FA80", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x87104F0", Offset = "0x870F4F0", VA = "0x1887104F0", Slot = "4")]
	public NCCENBGIEMA ICBALKMLPBO(HIOINALINKM APDBNIMCPID)
	{
		return default(NCCENBGIEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8710270", Offset = "0x870F270", VA = "0x188710270", Slot = "5")]
	public NCCENBGIEMA ICBALKMLPBO(HIOINALINKM APDBNIMCPID, bool BFAJCNNIPLE)
	{
		return default(NCCENBGIEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8710010", Offset = "0x870F010", VA = "0x188710010", Slot = "6")]
	public void HMDKGKANJNJ(NCCENBGIEMA KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x870FCB0", Offset = "0x870ECB0", VA = "0x18870FCB0", Slot = "7")]
	public void FGEBAJKBNEL(NCCENBGIEMA KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x87115B0", Offset = "0x87105B0", VA = "0x1887115B0", Slot = "8")]
	public CNEDHOBLNKD PHGOCJBDJLN(NCCENBGIEMA KNNDNAPJIDP, HNGPMGMDPEH APDBNIMCPID)
	{
		return default(CNEDHOBLNKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x87108F0", Offset = "0x870F8F0", VA = "0x1887108F0", Slot = "9")]
	public CNEDHOBLNKD LICHKICBMDJ(NCCENBGIEMA KNNDNAPJIDP, HFIDGLOEBHF APDBNIMCPID)
	{
		return default(CNEDHOBLNKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8711030", Offset = "0x8710030", VA = "0x188711030", Slot = "11")]
	public void NBMOKCEOFAB(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8710DD0", Offset = "0x870FDD0", VA = "0x188710DD0", Slot = "10")]
	public void MKHJAPCOKEG(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x87106C0", Offset = "0x870F6C0", VA = "0x1887106C0", Slot = "20")]
	public IEnumerable<Renderer> IOMLHMCDOLN(NCCENBGIEMA KNNDNAPJIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x87113F0", Offset = "0x87103F0", VA = "0x1887113F0", Slot = "12")]
	public AENBPOANBNH NEBAGIGNLIB(LLFOHOKPBJD APDBNIMCPID)
	{
		return default(AENBPOANBNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8711470", Offset = "0x8710470", VA = "0x188711470", Slot = "14")]
	public void NKIPNHKJMND(AENBPOANBNH GMANNGFCILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8710500", Offset = "0x870F500", VA = "0x188710500", Slot = "16")]
	public Task IDMBEEIPJJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8710730", Offset = "0x870F730", VA = "0x188710730", Slot = "17")]
	public Task LFIICAHNOAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x87114E0", Offset = "0x87104E0", VA = "0x1887114E0", Slot = "18")]
	[AsyncStateMachine(typeof(BKHJIKIKDFI))]
	public Task NLPOMMDGPMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x870F870", Offset = "0x870E870", VA = "0x18870F870", Slot = "19")]
	public void AAKMCACJFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x870FC50", Offset = "0x870EC50", VA = "0x18870FC50", Slot = "13")]
	public void EINCJLOIGBJ(AENBPOANBNH GMANNGFCILJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class PHGMDGNLKCI : KNNJCBPNHCB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct JENGJJELPMP : KNHDOEOGJOI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private OFNFOCEBPOF PEPFHNJFNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> HKGONICFHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle GMNPCPDAADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CJOPLDNPDPH KJIJIHOMHHM;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8712040", Offset = "0x8711040", VA = "0x188712040")]
		public JENGJJELPMP(OFNFOCEBPOF PEPFHNJFNIL, NativeArray<int> HKGONICFHGC, JobHandle GMNPCPDAADC, CJOPLDNPDPH KJIJIHOMHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8711FE0", Offset = "0x8710FE0", VA = "0x188711FE0", Slot = "4")]
		public OFNFOCEBPOF MCMIEJOHGAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8711F40", Offset = "0x8710F40", VA = "0x188711F40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly HNGPMGMDPEH HCNIDPKECHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] PLFHLPEBOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 AAPKOFDNEDG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 DHIHPGKGNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8719F00", Offset = "0x8718F00", VA = "0x188719F00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 NKJLBIDOMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x87193C0", Offset = "0x87183C0", VA = "0x1887193C0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x871B000", Offset = "0x871A000", VA = "0x18871B000")]
	public PHGMDGNLKCI(KHGMKIBFIKG KNNDNAPJIDP, HNGPMGMDPEH APDBNIMCPID, bool FJCHDLBDLGB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x87194F0", Offset = "0x87184F0", VA = "0x1887194F0", Slot = "18")]
	public override bool DFFDHGPHIMM(CIPJGNAKHIH KNNDNAPJIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8719BD0", Offset = "0x8718BD0", VA = "0x188719BD0", Slot = "21")]
	public override KDIOIEALNPI DNNHBCPOLFN()
	{
		return default(KDIOIEALNPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x87195C0", Offset = "0x87185C0", VA = "0x1887195C0")]
	private KDIOIEALNPI DNNHBCPOLFN(CIPJGNAKHIH KNNDNAPJIDP)
	{
		return default(KDIOIEALNPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8719C10", Offset = "0x8718C10", VA = "0x188719C10")]
	private HGNFDNHGFNE EAAKMILDIOF([In] UniformTRS CGDDFJJFMBK, [In] float3 IPGOJHIDCAE)
	{
		return default(HGNFDNHGFNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x871A6F0", Offset = "0x87196F0", VA = "0x18871A6F0", Slot = "19")]
	public override int LPKLAPIICAF(OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x871A3B0", Offset = "0x87193B0", VA = "0x18871A3B0", Slot = "20")]
	public override int GGOEFFEMMHB(OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8719E10", Offset = "0x8718E10", VA = "0x188719E10", Slot = "22")]
	public override float EBJAGBCCIDO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x871A130", Offset = "0x8719130", VA = "0x18871A130")]
	private int FDELAPNEIMD(OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x871A7A0", Offset = "0x87197A0", VA = "0x18871A7A0", Slot = "23")]
	public override void NCNAONCBLEI(OEDNPOAFIDC GKGMDAMJCNF, OGPFNIIHPFO KEIICMNLBCF, int JELELPJBLDG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x871A620", Offset = "0x8719620", VA = "0x18871A620", Slot = "24")]
	public override CIPJGNAKHIH LAOJGEPMLKG()
	{
		return default(CIPJGNAKHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x871A460", Offset = "0x8719460", VA = "0x18871A460", Slot = "26")]
	public override BJJJCPEHCID KDFCGDBGIAI()
	{
		return default(BJJJCPEHCID);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8718BF0", Offset = "0x8717BF0", VA = "0x188718BF0", Slot = "27")]
	public override KNHDOEOGJOI AMEJLFPKBDJ(OEDNPOAFIDC GKGMDAMJCNF, JobHandle GMNPCPDAADC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ONMCMJCBAHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADBLLDHFIGB(LIPCMCBNFNH MLCOGCMJLBB, Renderer CCKFDFMBDLN, int PBPOPGFBMOC);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIKAGDBPDMN(Renderer CCKFDFMBDLN, IEMJHKLDHIK HBODJJIPFAP, Vector3 CICOCLBFIJN, Vector3 LBHIPCKDOOM, Vector3 PFFFPBJFGBL, float AHGBEHNHMIJ, float CDDCDDIFOPG, float ECBMFPJHLOJ = -1f, [Optional] Color? NGGKCKILBNF, [Optional] IReadOnlyList<Camera> NKACJCMOPEG);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEDKNJFKGCI(Renderer CCKFDFMBDLN, int PBPOPGFBMOC);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GBICGHOBEMK();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MINAHBOCICL(int LLEMAIIBMAJ, KIOOHKBHOLJ MLCOGCMJLBB, Renderer CCKFDFMBDLN, int PBPOPGFBMOC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NDGCMIIECGC : LGCPEOGBNJG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class GHHBOPJGPKC : GMHENEKBFCA<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x870DB20", Offset = "0x870CB20", VA = "0x18870DB20")]
		public GHHBOPJGPKC(string NFHOBPDKIPM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly ONMCMJCBAHJ DKFHGHCKDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly BCFOMFEJOFB GBBHIJBKKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer HIMNNKFOBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private GHHBOPJGPKC MIDBKNJBOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool DBGOPCMOELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer NFGEBAGDMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private GHHBOPJGPKC BPOKLOCIAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool KAEKEMOFIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer NHNFOPPNBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private GHHBOPJGPKC ONABLCCKNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool KDJKCJJFMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public NDGCMIIECGC(ONMCMJCBAHJ PAMLFPGMJBA, BCFOMFEJOFB GBBHIJBKKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8714C00", Offset = "0x8713C00", VA = "0x188714C00", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8714750", Offset = "0x8713750", VA = "0x188714750")]
	private void CKFNJNJOFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8713D80", Offset = "0x8712D80", VA = "0x188713D80", Slot = "4")]
	public void AIFCIKAAFBJ(NCCENBGIEMA KNNDNAPJIDP, KIOOHKBHOLJ PNKDOABFNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8714090", Offset = "0x8713090", VA = "0x188714090", Slot = "5")]
	public void AIFCIKAAFBJ(CNEDHOBLNKD HIECCNNOPLP, KIOOHKBHOLJ PNKDOABFNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8715C80", Offset = "0x8714C80", VA = "0x188715C80", Slot = "6")]
	public void KPJOLBDANCE(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8715850", Offset = "0x8714850", VA = "0x188715850", Slot = "7")]
	public void JEHIGPMIFKB(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8714380", Offset = "0x8713380", VA = "0x188714380", Slot = "24")]
	public void BBBKJCKIKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1096630", Offset = "0x1095630", VA = "0x181096630", Slot = "8")]
	public void HICFMCIHOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8714A90", Offset = "0x8713A90", VA = "0x188714A90", Slot = "9")]
	public void DMOALEFLFPG(KIOOHKBHOLJ PNKDOABFNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8715110", Offset = "0x8714110", VA = "0x188715110", Slot = "10")]
	public void ELHEJEFMOHK(NCCENBGIEMA KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8714DB0", Offset = "0x8713DB0", VA = "0x188714DB0", Slot = "11")]
	public void ELHEJEFMOHK(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x87142B0", Offset = "0x87132B0", VA = "0x1887142B0", Slot = "12")]
	public void AOEOCDAGBOE(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8715780", Offset = "0x8714780", VA = "0x188715780", Slot = "13")]
	public void JAOIDAIGMCA(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x87143C0", Offset = "0x87133C0", VA = "0x1887143C0")]
	private void BPMHHKPIGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x12DF210", Offset = "0x12DE210", VA = "0x1812DF210", Slot = "14")]
	public void MONODEMNFCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8714630", Offset = "0x8713630", VA = "0x188714630", Slot = "15")]
	public void CAJHCNBMPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x87159A0", Offset = "0x87149A0", VA = "0x1887159A0", Slot = "16")]
	public void KGGLMOMDALM(NCCENBGIEMA KNNDNAPJIDP, LIPCMCBNFNH MLCOGCMJLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x87149C0", Offset = "0x87139C0", VA = "0x1887149C0", Slot = "17")]
	public void CKHMEHHJLJK(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8716650", Offset = "0x8715650", VA = "0x188716650", Slot = "18")]
	public void OLIFKEGJAAJ(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xC6E610", Offset = "0xC6D610", VA = "0x180C6E610", Slot = "19")]
	public void MFKGDNHBKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8715650", Offset = "0x8714650", VA = "0x188715650", Slot = "20")]
	public void GJBBIKELKDA(LIPCMCBNFNH MLCOGCMJLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x87153E0", Offset = "0x87143E0", VA = "0x1887153E0")]
	private void FJPLBDIBJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8715DE0", Offset = "0x8714DE0", VA = "0x188715DE0", Slot = "21")]
	public void LILAIIIHGCP(NCCENBGIEMA KNNDNAPJIDP, Vector3 CICOCLBFIJN, Vector3 LBHIPCKDOOM, Vector3 PFFFPBJFGBL, float AHGBEHNHMIJ, float CDDCDDIFOPG, IReadOnlyList<Camera> MNHACLNNKJH, IEMJHKLDHIK HBODJJIPFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x87161B0", Offset = "0x87151B0", VA = "0x1887161B0", Slot = "22")]
	public void LILAIIIHGCP(AENBPOANBNH GMANNGFCILJ, Vector3 CICOCLBFIJN, Vector3 LBHIPCKDOOM, Vector3 PFFFPBJFGBL, float AHGBEHNHMIJ, float CDDCDDIFOPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class KNNJCBPNHCB : KCALEPNMMPK, NGPLIHHOGDL, BJHBGAPNKPE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly KHGMKIBFIKG FMDIEJKNFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int NOHNFMLEKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds MGPKDLCCBKN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds NIEGJEKJNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8713AB0", Offset = "0x8712AB0", VA = "0x188713AB0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool FIJGAFAPGND
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD57190", Offset = "0xD56190", VA = "0x180D57190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD57020", Offset = "0xD56020", VA = "0x180D57020")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 NKJLBIDOMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KGOFHLOEILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xBDE1B0", Offset = "0xBDD1B0", VA = "0x180BDE1B0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public LGJOMFGAFNG JADCDEDGOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EKLKNHMHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xE8ADD0", Offset = "0xE89DD0", VA = "0x180E8ADD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	protected KNNJCBPNHCB(KHGMKIBFIKG KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8713AD0", Offset = "0x8712AD0", VA = "0x188713AD0", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "18")]
	public virtual bool DFFDHGPHIMM(CIPJGNAKHIH KNNDNAPJIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8713C70", Offset = "0x8712C70", VA = "0x188713C70", Slot = "10")]
	public int FGFLHJBLLGI(int KDOOLHFKKFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int LPKLAPIICAF(OEDNPOAFIDC GKGMDAMJCNF);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int GGOEFFEMMHB(OEDNPOAFIDC GKGMDAMJCNF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract KDIOIEALNPI DNNHBCPOLFN();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float EBJAGBCCIDO();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void NCNAONCBLEI(OEDNPOAFIDC GKGMDAMJCNF, OGPFNIIHPFO KEIICMNLBCF, int JELELPJBLDG = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract CIPJGNAKHIH LAOJGEPMLKG();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8713C80", Offset = "0x8712C80", VA = "0x188713C80", Slot = "13")]
	public Hash128 KLJNHBBKJDH(int GKGMDAMJCNF)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract BJJJCPEHCID KDFCGDBGIAI();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract KNHDOEOGJOI AMEJLFPKBDJ(OEDNPOAFIDC GKGMDAMJCNF, JobHandle GMNPCPDAADC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8713C40", Offset = "0x8712C40", VA = "0x188713C40", Slot = "12")]
	public KNHDOEOGJOI EDHIDPPEGOP(int GKGMDAMJCNF)
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
		[Cpp2IlInjected.Address(RVA = "0x871BF70", Offset = "0x871AF70", VA = "0x18871BF70")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DBLPBNNEKMA
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OCIGGOEELLL : IEnumerable<EOAHKPEMMBH>, IEnumerable, IEnumerator<EOAHKPEMMBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private EOAHKPEMMBH <>2__current;

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
		private EOAHKPEMMBH System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public OCIGGOEELLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8718A30", Offset = "0x8717A30", VA = "0x188718A30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8718BA0", Offset = "0x8717BA0", VA = "0x188718BA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8718B00", Offset = "0x8717B00", VA = "0x188718B00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EOAHKPEMMBH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8718B00", Offset = "0x8717B00", VA = "0x188718B00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static EOAHKPEMMBH[][] KNLNJIIIIGD;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static HEFAOEOOFNP ABJFAALMLCC;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig EBBFMAFDBDK;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader KNHAMHONONM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x870B0E0", Offset = "0x870A0E0", VA = "0x18870B0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer ELEJGLLHDFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x870ADF0", Offset = "0x8709DF0", VA = "0x18870ADF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x870A8A0", Offset = "0x87098A0", VA = "0x18870A8A0")]
	[FHOLJFNIKPC]
	internal static void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x870B040", Offset = "0x870A040", VA = "0x18870B040")]
	public static Mesh MIBOAMEBEFM(IAMAGEBEBON MKJANMFNLFL, int GKGMDAMJCNF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x870ABC0", Offset = "0x8709BC0", VA = "0x18870ABC0")]
	public static int GBGIBDGGCHJ(IAMAGEBEBON MKJANMFNLFL, int GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x870ABD0", Offset = "0x8709BD0", VA = "0x18870ABD0")]
	public static HEFAOEOOFNP GEAMGNHNJIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x870A990", Offset = "0x8709990", VA = "0x18870A990")]
	[IteratorStateMachine(typeof(OCIGGOEELLL))]
	private static IEnumerable<EOAHKPEMMBH> CAIKJCLBFKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x870B140", Offset = "0x870A140", VA = "0x18870B140")]
	public static EOAHKPEMMBH PLHABHOLBDB(IAMAGEBEBON MKJANMFNLFL, int GKGMDAMJCNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x870A9F0", Offset = "0x87099F0", VA = "0x18870A9F0")]
	public static bool DEHCNJNHHPL(this IAMAGEBEBON MKJANMFNLFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x870AA10", Offset = "0x8709A10", VA = "0x18870AA10")]
	public static void FNCIGLMBLMK(IAMAGEBEBON MKJANMFNLFL, float3 KPNLMCNCJLJ, [Out] EGAMEBEHMLC IPCLJDODAPI, [Out] float3 OIFMNEMBMAF, [Out] float OILNKKOJHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x870A4D0", Offset = "0x87094D0", VA = "0x18870A4D0")]
	public static void AFCCCJEKJJM(Vector3 KPNLMCNCJLJ, IAMAGEBEBON MKJANMFNLFL, [Out] Vector3 OIFMNEMBMAF, [Out] float OILNKKOJHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x870AE50", Offset = "0x8709E50", VA = "0x18870AE50")]
	[OLGIFJNPPLL(0)]
	[FELFDMPPKKE(MGEKOJDDIFB.ExitingPlayMode, 0)]
	private static void IKGADMPEMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x870AE60", Offset = "0x8709E60", VA = "0x18870AE60")]
	[OLGIFJNPPLL(0)]
	[FELFDMPPKKE(MGEKOJDDIFB.ExitingPlayMode, 0)]
	private static void KLKPLLBJAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class PMDFOAPEKEK : GDHFOHFFOAJ, IDisposable, BCFOMFEJOFB
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly PEBNEEMIANK<NCCENBGIEMA, KHGMKIBFIKG> IHIGDICMEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly PEBNEEMIANK<CNEDHOBLNKD, KNNJCBPNHCB> IJBKMDJICDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly PEBNEEMIANK<AENBPOANBNH, DJJLLLMIHIH> IFJDFIDDJNA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public KHGMKIBFIKG OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x871B170", Offset = "0x871A170", VA = "0x18871B170", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public KNNJCBPNHCB OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x871B0B0", Offset = "0x871A0B0", VA = "0x18871B0B0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DJJLLLMIHIH OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x871B110", Offset = "0x871A110", VA = "0x18871B110", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NKAMGGLIJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xDA98B0", Offset = "0xDA88B0", VA = "0x180DA98B0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA92FB0", Offset = "0xA91FB0", VA = "0x180A92FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x871BB80", Offset = "0x871AB80", VA = "0x18871BB80")]
	public PMDFOAPEKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x871B1D0", Offset = "0x871A1D0", VA = "0x18871B1D0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x871B3A0", Offset = "0x871A3A0", VA = "0x18871B3A0", Slot = "4")]
	public NCCENBGIEMA ICBALKMLPBO(HIOINALINKM APDBNIMCPID)
	{
		return default(NCCENBGIEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x871B3A0", Offset = "0x871A3A0", VA = "0x18871B3A0", Slot = "5")]
	public NCCENBGIEMA ICBALKMLPBO(HIOINALINKM APDBNIMCPID, bool BFAJCNNIPLE)
	{
		return default(NCCENBGIEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x871B340", Offset = "0x871A340", VA = "0x18871B340", Slot = "6")]
	public void HMDKGKANJNJ(NCCENBGIEMA KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x871B2C0", Offset = "0x871A2C0", VA = "0x18871B2C0", Slot = "7")]
	public void FGEBAJKBNEL(NCCENBGIEMA KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x871B9B0", Offset = "0x871A9B0", VA = "0x18871B9B0", Slot = "8")]
	public CNEDHOBLNKD PHGOCJBDJLN(NCCENBGIEMA KNNDNAPJIDP, HNGPMGMDPEH APDBNIMCPID)
	{
		return default(CNEDHOBLNKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x871B5F0", Offset = "0x871A5F0", VA = "0x18871B5F0", Slot = "9")]
	public CNEDHOBLNKD LICHKICBMDJ(NCCENBGIEMA KNNDNAPJIDP, HFIDGLOEBHF APDBNIMCPID)
	{
		return default(CNEDHOBLNKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x871B790", Offset = "0x871A790", VA = "0x18871B790", Slot = "11")]
	public void NBMOKCEOFAB(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x871B730", Offset = "0x871A730", VA = "0x18871B730", Slot = "10")]
	public void MKHJAPCOKEG(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x871B4E0", Offset = "0x871A4E0", VA = "0x18871B4E0", Slot = "20")]
	public IEnumerable<Renderer> IOMLHMCDOLN(NCCENBGIEMA KNNDNAPJIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x871B820", Offset = "0x871A820", VA = "0x18871B820", Slot = "12")]
	public AENBPOANBNH NEBAGIGNLIB(LLFOHOKPBJD APDBNIMCPID)
	{
		return default(AENBPOANBNH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x871B8A0", Offset = "0x871A8A0", VA = "0x18871B8A0", Slot = "14")]
	public void NKIPNHKJMND(AENBPOANBNH GMANNGFCILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x871B440", Offset = "0x871A440", VA = "0x18871B440", Slot = "16")]
	public Task IDMBEEIPJJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x871B550", Offset = "0x871A550", VA = "0x18871B550", Slot = "17")]
	public Task LFIICAHNOAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x871B910", Offset = "0x871A910", VA = "0x18871B910", Slot = "18")]
	public Task NLPOMMDGPMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2671910", Offset = "0x2670910", VA = "0x182671910", Slot = "19")]
	public void AAKMCACJFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x871B260", Offset = "0x871A260", VA = "0x18871B260", Slot = "13")]
	public void EINCJLOIGBJ(AENBPOANBNH GMANNGFCILJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DAKKMJBEKAC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool OFPIIIAMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material MMGDGEOPJEF();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material HKOJDKHKMED();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material NENNEAJBHDI();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int AFBKFIGEOHD(IHNAGNCLKBF HNCPHCOBGLB);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CPFJFCHEMHD(MNHJGJHOEHN FCJDJNJLCGN);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJANMMJEPCF(GameObject BOMDCGFKGKF);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FECENGEAFOH(GameObject BOMDCGFKGKF, bool CGMKOCFIGDO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CEHJFDDMFBE
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static DAKKMJBEKAC HCAMONPFOJM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool OFPIIIAMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x870A050", Offset = "0x8709050", VA = "0x18870A050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x870A470", Offset = "0x8709470", VA = "0x18870A470")]
	public static void NFFLMPFOABM(DAKKMJBEKAC KJGCBIGHEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x870A3B0", Offset = "0x87093B0", VA = "0x18870A3B0")]
	public static Material MMGDGEOPJEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x870A280", Offset = "0x8709280", VA = "0x18870A280")]
	public static Material HKOJDKHKMED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x870A410", Offset = "0x8709410", VA = "0x18870A410")]
	public static Material NENNEAJBHDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x870A0B0", Offset = "0x87090B0", VA = "0x18870A0B0")]
	public static int AFBKFIGEOHD(IHNAGNCLKBF HNCPHCOBGLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x870A120", Offset = "0x8709120", VA = "0x18870A120")]
	public static int CPFJFCHEMHD(MNHJGJHOEHN FCJDJNJLCGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x870A2E0", Offset = "0x87092E0", VA = "0x18870A2E0")]
	public static void KJANMMJEPCF(GameObject BOMDCGFKGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x870A190", Offset = "0x8709190", VA = "0x18870A190")]
	public static void FECENGEAFOH(GameObject BOMDCGFKGKF, bool CGMKOCFIGDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DJJLLLMIHIH : DCJLPKNHAKK
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BHNHAKNFLGA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DJJLLLMIHIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public BHNHAKNFLGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x87099E0", Offset = "0x87089E0", VA = "0x1887099E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x87096C0", Offset = "0x87086C0", VA = "0x1887096C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8709670", Offset = "0x8708670", VA = "0x188709670")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8709990", Offset = "0x8708990", VA = "0x188709990", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x87098E0", Offset = "0x87088E0", VA = "0x1887098E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x87098E0", Offset = "0x87088E0", VA = "0x1887098E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LLFOHOKPBJD GAEOIIACNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly BCFOMFEJOFB GBBHIJBKKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NPCHOHPGHOL DAPBLFKLLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<IAIKDIPJMBL> KLIOPPOHKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<IAIKDIPJMBL> EHGAJCJJIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject GEACDIHFBCC;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x870C2E0", Offset = "0x870B2E0", VA = "0x18870C2E0")]
	public static DJJLLLMIHIH JKEADJBGOCC(LLFOHOKPBJD APDBNIMCPID, BCFOMFEJOFB GBBHIJBKKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x870D400", Offset = "0x870C400", VA = "0x18870D400")]
	private DJJLLLMIHIH(LLFOHOKPBJD APDBNIMCPID, BCFOMFEJOFB GBBHIJBKKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x870CF70", Offset = "0x870BF70", VA = "0x18870CF70")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x870CEF0", Offset = "0x870BEF0", VA = "0x18870CEF0")]
	[IteratorStateMachine(typeof(BHNHAKNFLGA))]
	public IEnumerable<Renderer> MPIPDNBCHBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x870C430", Offset = "0x870B430", VA = "0x18870C430", Slot = "4")]
	public void LODKFBECFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x870C2B0", Offset = "0x870B2B0", VA = "0x18870C2B0")]
	private void JHJGDHMGHIC(Vector3 KIBNLFAIDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x870C060", Offset = "0x870B060", VA = "0x18870C060")]
	public void IEKHBJGOAKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IAIKDIPJMBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct OMHCJFAHLLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public OGPFNIIHPFO LBNKACGMIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CIPJGNAKHIH CMEEHMLLMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int FFFPOGEIPEO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class APOGADLLCHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public IAIKDIPJMBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public OEDNPOAFIDC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<OMHCJFAHLLK> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OFNFOCEBPOF combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public APOGADLLCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x87094A0", Offset = "0x87084A0", VA = "0x1887094A0")]
		internal JobHandle GOAGLAFDPGD()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8709470", Offset = "0x8708470", VA = "0x188709470")]
		internal void ABMHHCHGLAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8709500", Offset = "0x8708500", VA = "0x188709500")]
		internal void IGOBIHCJMGM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] NEFHHLHMCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private BDJODDJALBB KHJIGCJMHFP;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 MMKFAOPFKFB;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh LNGKDJGKDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x870EFE0", Offset = "0x870DFE0", VA = "0x18870EFE0")]
	public void IMLDDILJGKI(List<CIPJGNAKHIH> PBGLKODNMBL, Matrix4x4[] EJPNOECLHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x870E5E0", Offset = "0x870D5E0", VA = "0x18870E5E0")]
	public static List<IAIKDIPJMBL> FLLMCNLHKNL(List<KHGMKIBFIKG> OJJLHNIKPEE, OEDNPOAFIDC GKGMDAMJCNF, Bounds HJOECMEGBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x870EC70", Offset = "0x870DC70", VA = "0x18870EC70")]
	private JobHandle IDGKMHEGMEF(OFNFOCEBPOF HEOKEACGJHP, int DIGNHEFBOML, int FNBPJBGCLCH, OEDNPOAFIDC GKGMDAMJCNF, List<OMHCJFAHLLK> JBDNFPBIPPK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x870E460", Offset = "0x870D460", VA = "0x18870E460")]
	private void BGGEHELIDKJ(List<OMHCJFAHLLK> JBDNFPBIPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x870F370", Offset = "0x870E370", VA = "0x18870F370")]
	private IAIKDIPJMBL(List<OMHCJFAHLLK> JBDNFPBIPPK, int DIGNHEFBOML, int FNBPJBGCLCH, OEDNPOAFIDC GKGMDAMJCNF, Bounds HJOECMEGBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x870E540", Offset = "0x870D540", VA = "0x18870E540", Slot = "4")]
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
		private MaterialPropertyBlock BFBOFDJKBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IAIKDIPJMBL PEPFHNJFNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<CIPJGNAKHIH> IFACPDBOEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture BFOAOAKGOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer NAAIGKHHBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader HCJICDKMBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] DDDNLNOBFPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int OPECBNCDLBI;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer IOELNNAIAEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int HBAGIMDFAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x871CCA0", Offset = "0x871BCA0", VA = "0x18871CCA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x871BFD0", Offset = "0x871AFD0", VA = "0x18871BFD0")]
		public static List<SkinnedShapeRenderer> Create(GameObject KNNDNAPJIDP, List<IAIKDIPJMBL> LHHLMCNOLOM, List<CIPJGNAKHIH> IFACPDBOEIA, Material CANJBFKPEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x871C690", Offset = "0x871B690", VA = "0x18871C690")]
		public void Init(IAIKDIPJMBL PEPFHNJFNIL, List<CIPJGNAKHIH> IFACPDBOEIA, Material CANJBFKPEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x871CC00", Offset = "0x871BC00", VA = "0x18871CC00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x871CB60", Offset = "0x871BB60", VA = "0x18871CB60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x871CB20", Offset = "0x871BB20", VA = "0x18871CB20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x871C260", Offset = "0x871B260", VA = "0x18871C260")]
		private void DIOMBHMNIGC(ScriptableRenderContext INLEBAAACKH, Camera[] ECCKNGENJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x871C320", Offset = "0x871B320", VA = "0x18871C320")]
		private void IMLDDILJGKI(CommandBuffer HKEOEPNOEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
