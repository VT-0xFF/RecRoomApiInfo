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
		[Cpp2IlInjected.Address(RVA = "0x86FA4E0", Offset = "0x86F8AE0", VA = "0x1886FA4E0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8703BA0", Offset = "0x87021A0", VA = "0x188703BA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LNJGAKGJBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float EBNNJCOJCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF3EEC0", Offset = "0xF3D4C0", VA = "0x180F3EEC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12FC720", Offset = "0x12FAD20", VA = "0x1812FC720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JBJNBMCEJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC55210", Offset = "0xC53810", VA = "0x180C55210", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC55220", Offset = "0xC53820", VA = "0x180C55220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> PEMGICOPMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86FCFA0", Offset = "0x86FB5A0", VA = "0x1886FCFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> NBDDHABCFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86FD0F0", Offset = "0x86FB6F0", VA = "0x1886FD0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte ADEMLIENNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86FCF50", Offset = "0x86FB550", VA = "0x1886FCF50", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x86FD530", Offset = "0x86FBB30", VA = "0x1886FD530")]
	public NPCHOHPGHOL(List<IAIKDIPJMBL> DEANJJFHEMK, List<IAIKDIPJMBL> AKAHLDMCEAM, List<CIPJGNAKHIH> IFACPDBOEIA, Material CANJBFKPEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x86FD3D0", Offset = "0x86FB9D0", VA = "0x1886FD3D0")]
	private int LPKLAPIICAF(List<IAIKDIPJMBL> LHHLMCNOLOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x86FD120", Offset = "0x86FB720", VA = "0x1886FD120")]
	private void IPDCDNCLGNE(int HLIBGEBDNGJ, bool CBHHPIGGAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x86FD280", Offset = "0x86FB880", VA = "0x1886FD280")]
	public void LBCCKFFLOHK(Vector3 KIBNLFAIDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86FCFF0", Offset = "0x86FB5F0", VA = "0x1886FCFF0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x86FD4F0", Offset = "0x86FBAF0", VA = "0x1886FD4F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public GNCKEJFLOPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86F4C00", Offset = "0x86F3200", VA = "0x1886F4C00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x86F45A0", Offset = "0x86F2BA0", VA = "0x1886F45A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x86F4550", Offset = "0x86F2B50", VA = "0x1886F4550")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86F4AB0", Offset = "0x86F30B0", VA = "0x1886F4AB0")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86F4500", Offset = "0x86F2B00", VA = "0x1886F4500")]
		private void CGHFFBOFAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86F4BB0", Offset = "0x86F31B0", VA = "0x1886F4BB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86F4B00", Offset = "0x86F3100", VA = "0x1886F4B00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86F4B00", Offset = "0x86F3100", VA = "0x1886F4B00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public FIMCKIMDHHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86F4380", Offset = "0x86F2980", VA = "0x1886F4380", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86F3EC0", Offset = "0x86F24C0", VA = "0x1886F3EC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86F3E70", Offset = "0x86F2470", VA = "0x1886F3E70")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86F4230", Offset = "0x86F2830", VA = "0x1886F4230")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86F4330", Offset = "0x86F2930", VA = "0x1886F4330", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86F4280", Offset = "0x86F2880", VA = "0x1886F4280", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86F4280", Offset = "0x86F2880", VA = "0x1886F4280", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OIFONFBLFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86F9340", Offset = "0x86F7940", VA = "0x1886F9340", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CIPJGNAKHIH BIKCOAMGMAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86F9000", Offset = "0x86F7600", VA = "0x1886F9000", Slot = "8")]
		get
		{
			return default(CIPJGNAKHIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> KLEGNEBJNID
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86F8FE0", Offset = "0x86F75E0", VA = "0x1886F8FE0")]
	private bool AOFPPENMDDL(KNNJCBPNHCB HIECCNNOPLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x86F9570", Offset = "0x86F7B70", VA = "0x1886F9570")]
	private static bool FHJCOLKGBCA(KNNJCBPNHCB HIECCNNOPLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x86FA200", Offset = "0x86F8800", VA = "0x1886FA200")]
	public KHGMKIBFIKG(HIOINALINKM APDBNIMCPID, bool BFAJCNNIPLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x86F9380", Offset = "0x86F7980", VA = "0x1886F9380", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x86F9960", Offset = "0x86F7F60", VA = "0x1886F9960")]
	public void IIGLPCDPOEE(KNNJCBPNHCB HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x86F9590", Offset = "0x86F7B90", VA = "0x1886F9590")]
	public void GNAALOCCJEL(KNNJCBPNHCB HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x86F9C80", Offset = "0x86F8280", VA = "0x1886F9C80", Slot = "4")]
	public void LODKFBECFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x86F96F0", Offset = "0x86F7CF0", VA = "0x1886F96F0")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86F9180", Offset = "0x86F7780", VA = "0x1886F9180")]
	private void CMMDIHBPOIN(List<KNNJCBPNHCB> IJBKMDJICDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x86F0CE0", Offset = "0x86EF2E0", VA = "0x1886F0CE0")]
	private static Material HKOJDKHKMED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x86F90D0", Offset = "0x86F76D0", VA = "0x1886F90D0")]
	private void CMMDIHBPOIN(KNNJCBPNHCB HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x86F9B30", Offset = "0x86F8130", VA = "0x1886F9B30")]
	private void JIPKOONHHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x86F89B0", Offset = "0x86F6FB0", VA = "0x1886F89B0")]
	public void AIGIHEFBOPB(bool HHHPLEOKNJL, bool AMBBNPAKHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x86F88F0", Offset = "0x86F6EF0", VA = "0x1886F88F0")]
	protected void ACICODFLEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86F8F60", Offset = "0x86F7560", VA = "0x1886F8F60")]
	public void ANGPGLODHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86FA180", Offset = "0x86F8780", VA = "0x1886FA180")]
	[IteratorStateMachine(typeof(GNCKEJFLOPA))]
	public IEnumerable<Renderer> MPIPDNBCHBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x86F9C00", Offset = "0x86F8200", VA = "0x1886F9C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x86F6160", Offset = "0x86F4760", VA = "0x1886F6160")]
		public IEJGFCEJKBL(OFNFOCEBPOF PEPFHNJFNIL, JobHandle GMNPCPDAADC, FKMOHECEINB KJIJIHOMHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86F6130", Offset = "0x86F4730", VA = "0x1886F6130", Slot = "4")]
		public OFNFOCEBPOF MCMIEJOHGAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86F60E0", Offset = "0x86F46E0", VA = "0x1886F60E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FE010", Offset = "0x86FC610", VA = "0x1886FE010", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86FF180", Offset = "0x86FD780", VA = "0x1886FF180")]
	public OAJNMHDDGIP(KHGMKIBFIKG KNNDNAPJIDP, HFIDGLOEBHF APDBNIMCPID, bool BFAJCNNIPLE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "18")]
	public override bool DFFDHGPHIMM(CIPJGNAKHIH KNNDNAPJIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x86FE9D0", Offset = "0x86FCFD0", VA = "0x1886FE9D0", Slot = "19")]
	public override int LPKLAPIICAF(OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86FE580", Offset = "0x86FCB80", VA = "0x1886FE580", Slot = "20")]
	public override int GGOEFFEMMHB(OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x86FE140", Offset = "0x86FC740", VA = "0x1886FE140", Slot = "21")]
	public override KDIOIEALNPI DNNHBCPOLFN()
	{
		return default(KDIOIEALNPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC1B080", Offset = "0xC19680", VA = "0x180C1B080", Slot = "22")]
	public override float EBJAGBCCIDO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86FEBA0", Offset = "0x86FD1A0", VA = "0x1886FEBA0", Slot = "23")]
	public override void NCNAONCBLEI(OEDNPOAFIDC GKGMDAMJCNF, OGPFNIIHPFO KEIICMNLBCF, int JELELPJBLDG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x86FE900", Offset = "0x86FCF00", VA = "0x1886FE900", Slot = "24")]
	public override CIPJGNAKHIH LAOJGEPMLKG()
	{
		return default(CIPJGNAKHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x86FE750", Offset = "0x86FCD50", VA = "0x1886FE750", Slot = "26")]
	public override BJJJCPEHCID KDFCGDBGIAI()
	{
		return default(BJJJCPEHCID);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86FD840", Offset = "0x86FBE40", VA = "0x1886FD840", Slot = "27")]
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
		[Cpp2IlInjected.Address(RVA = "0x86F0500", Offset = "0x86EEB00", VA = "0x1886F0500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86F0A60", Offset = "0x86EF060", VA = "0x1886F0A60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86F6370", Offset = "0x86F4970", VA = "0x1886F6370", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public KNNJCBPNHCB OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x86F6310", Offset = "0x86F4910", VA = "0x1886F6310", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DJJLLLMIHIH OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x86F62B0", Offset = "0x86F48B0", VA = "0x1886F62B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NKAMGGLIJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAA4630", Offset = "0xAA2C30", VA = "0x180AA4630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x86F8310", Offset = "0x86F6910", VA = "0x1886F8310")]
	public JEHNOLCFLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x86F63D0", Offset = "0x86F49D0", VA = "0x1886F63D0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x86F6DF0", Offset = "0x86F53F0", VA = "0x1886F6DF0", Slot = "4")]
	public NCCENBGIEMA ICBALKMLPBO(HIOINALINKM APDBNIMCPID)
	{
		return default(NCCENBGIEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x86F6B80", Offset = "0x86F5180", VA = "0x1886F6B80", Slot = "5")]
	public NCCENBGIEMA ICBALKMLPBO(HIOINALINKM APDBNIMCPID, bool BFAJCNNIPLE)
	{
		return default(NCCENBGIEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x86F6930", Offset = "0x86F4F30", VA = "0x1886F6930", Slot = "6")]
	public void HMDKGKANJNJ(NCCENBGIEMA KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x86F65F0", Offset = "0x86F4BF0", VA = "0x1886F65F0", Slot = "7")]
	public void FGEBAJKBNEL(NCCENBGIEMA KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x86F7E50", Offset = "0x86F6450", VA = "0x1886F7E50", Slot = "8")]
	public CNEDHOBLNKD PHGOCJBDJLN(NCCENBGIEMA KNNDNAPJIDP, HNGPMGMDPEH APDBNIMCPID)
	{
		return default(CNEDHOBLNKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x86F71E0", Offset = "0x86F57E0", VA = "0x1886F71E0", Slot = "9")]
	public CNEDHOBLNKD LICHKICBMDJ(NCCENBGIEMA KNNDNAPJIDP, HFIDGLOEBHF APDBNIMCPID)
	{
		return default(CNEDHOBLNKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x86F78F0", Offset = "0x86F5EF0", VA = "0x1886F78F0", Slot = "11")]
	public void NBMOKCEOFAB(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x86F76A0", Offset = "0x86F5CA0", VA = "0x1886F76A0", Slot = "10")]
	public void MKHJAPCOKEG(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x86F6FC0", Offset = "0x86F55C0", VA = "0x1886F6FC0", Slot = "20")]
	public IEnumerable<Renderer> IOMLHMCDOLN(NCCENBGIEMA KNNDNAPJIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x86F7C90", Offset = "0x86F6290", VA = "0x1886F7C90", Slot = "12")]
	public AENBPOANBNH NEBAGIGNLIB(LLFOHOKPBJD APDBNIMCPID)
	{
		return default(AENBPOANBNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x86F7D10", Offset = "0x86F6310", VA = "0x1886F7D10", Slot = "14")]
	public void NKIPNHKJMND(AENBPOANBNH GMANNGFCILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x86F6E00", Offset = "0x86F5400", VA = "0x1886F6E00", Slot = "16")]
	public Task IDMBEEIPJJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x86F7030", Offset = "0x86F5630", VA = "0x1886F7030", Slot = "17")]
	public Task LFIICAHNOAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x86F7D80", Offset = "0x86F6380", VA = "0x1886F7D80", Slot = "18")]
	[AsyncStateMachine(typeof(BKHJIKIKDFI))]
	public Task NLPOMMDGPMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x86F61C0", Offset = "0x86F47C0", VA = "0x1886F61C0", Slot = "19")]
	public void AAKMCACJFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x86F6590", Offset = "0x86F4B90", VA = "0x1886F6590", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x86F8890", Offset = "0x86F6E90", VA = "0x1886F8890")]
		public JENGJJELPMP(OFNFOCEBPOF PEPFHNJFNIL, NativeArray<int> HKGONICFHGC, JobHandle GMNPCPDAADC, CJOPLDNPDPH KJIJIHOMHHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86F8830", Offset = "0x86F6E30", VA = "0x1886F8830", Slot = "4")]
		public OFNFOCEBPOF MCMIEJOHGAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x86F8790", Offset = "0x86F6D90", VA = "0x1886F8790", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8700700", Offset = "0x86FED00", VA = "0x188700700")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 NKJLBIDOMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x86FFBC0", Offset = "0x86FE1C0", VA = "0x1886FFBC0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x87017E0", Offset = "0x86FFDE0", VA = "0x1887017E0")]
	public PHGMDGNLKCI(KHGMKIBFIKG KNNDNAPJIDP, HNGPMGMDPEH APDBNIMCPID, bool FJCHDLBDLGB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x86FFCF0", Offset = "0x86FE2F0", VA = "0x1886FFCF0", Slot = "18")]
	public override bool DFFDHGPHIMM(CIPJGNAKHIH KNNDNAPJIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x87003D0", Offset = "0x86FE9D0", VA = "0x1887003D0", Slot = "21")]
	public override KDIOIEALNPI DNNHBCPOLFN()
	{
		return default(KDIOIEALNPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x86FFDC0", Offset = "0x86FE3C0", VA = "0x1886FFDC0")]
	private KDIOIEALNPI DNNHBCPOLFN(CIPJGNAKHIH KNNDNAPJIDP)
	{
		return default(KDIOIEALNPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8700410", Offset = "0x86FEA10", VA = "0x188700410")]
	private HGNFDNHGFNE EAAKMILDIOF([In] UniformTRS CGDDFJJFMBK, [In] float3 IPGOJHIDCAE)
	{
		return default(HGNFDNHGFNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8700EE0", Offset = "0x86FF4E0", VA = "0x188700EE0", Slot = "19")]
	public override int LPKLAPIICAF(OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8700BB0", Offset = "0x86FF1B0", VA = "0x188700BB0", Slot = "20")]
	public override int GGOEFFEMMHB(OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8700610", Offset = "0x86FEC10", VA = "0x188700610", Slot = "22")]
	public override float EBJAGBCCIDO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8700930", Offset = "0x86FEF30", VA = "0x188700930")]
	private int FDELAPNEIMD(OEDNPOAFIDC GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8700F90", Offset = "0x86FF590", VA = "0x188700F90", Slot = "23")]
	public override void NCNAONCBLEI(OEDNPOAFIDC GKGMDAMJCNF, OGPFNIIHPFO KEIICMNLBCF, int JELELPJBLDG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8700E10", Offset = "0x86FF410", VA = "0x188700E10", Slot = "24")]
	public override CIPJGNAKHIH LAOJGEPMLKG()
	{
		return default(CIPJGNAKHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8700C60", Offset = "0x86FF260", VA = "0x188700C60", Slot = "26")]
	public override BJJJCPEHCID KDFCGDBGIAI()
	{
		return default(BJJJCPEHCID);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x86FF3F0", Offset = "0x86FD9F0", VA = "0x1886FF3F0", Slot = "27")]
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
		[Cpp2IlInjected.Address(RVA = "0x86F44B0", Offset = "0x86F2AB0", VA = "0x1886F44B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public NDGCMIIECGC(ONMCMJCBAHJ PAMLFPGMJBA, BCFOMFEJOFB GBBHIJBKKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x86FB430", Offset = "0x86F9A30", VA = "0x1886FB430", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x86FAF80", Offset = "0x86F9580", VA = "0x1886FAF80")]
	private void CKFNJNJOFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x86FA5B0", Offset = "0x86F8BB0", VA = "0x1886FA5B0", Slot = "4")]
	public void AIFCIKAAFBJ(NCCENBGIEMA KNNDNAPJIDP, KIOOHKBHOLJ PNKDOABFNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x86FA8C0", Offset = "0x86F8EC0", VA = "0x1886FA8C0", Slot = "5")]
	public void AIFCIKAAFBJ(CNEDHOBLNKD HIECCNNOPLP, KIOOHKBHOLJ PNKDOABFNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x86FC4B0", Offset = "0x86FAAB0", VA = "0x1886FC4B0", Slot = "6")]
	public void KPJOLBDANCE(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x86FC080", Offset = "0x86FA680", VA = "0x1886FC080", Slot = "7")]
	public void JEHIGPMIFKB(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x86FABB0", Offset = "0x86F91B0", VA = "0x1886FABB0", Slot = "24")]
	public void BBBKJCKIKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x10AA9D0", Offset = "0x10A8FD0", VA = "0x1810AA9D0", Slot = "8")]
	public void HICFMCIHOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x86FB2C0", Offset = "0x86F98C0", VA = "0x1886FB2C0", Slot = "9")]
	public void DMOALEFLFPG(KIOOHKBHOLJ PNKDOABFNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x86FB940", Offset = "0x86F9F40", VA = "0x1886FB940", Slot = "10")]
	public void ELHEJEFMOHK(NCCENBGIEMA KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x86FB5E0", Offset = "0x86F9BE0", VA = "0x1886FB5E0", Slot = "11")]
	public void ELHEJEFMOHK(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x86FAAE0", Offset = "0x86F90E0", VA = "0x1886FAAE0", Slot = "12")]
	public void AOEOCDAGBOE(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x86FBFB0", Offset = "0x86FA5B0", VA = "0x1886FBFB0", Slot = "13")]
	public void JAOIDAIGMCA(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x86FABF0", Offset = "0x86F91F0", VA = "0x1886FABF0")]
	private void BPMHHKPIGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x13157F0", Offset = "0x1313DF0", VA = "0x1813157F0", Slot = "14")]
	public void MONODEMNFCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x86FAE60", Offset = "0x86F9460", VA = "0x1886FAE60", Slot = "15")]
	public void CAJHCNBMPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x86FC1D0", Offset = "0x86FA7D0", VA = "0x1886FC1D0", Slot = "16")]
	public void KGGLMOMDALM(NCCENBGIEMA KNNDNAPJIDP, LIPCMCBNFNH MLCOGCMJLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x86FB1F0", Offset = "0x86F97F0", VA = "0x1886FB1F0", Slot = "17")]
	public void CKHMEHHJLJK(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x86FCE80", Offset = "0x86FB480", VA = "0x1886FCE80", Slot = "18")]
	public void OLIFKEGJAAJ(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xC93AC0", Offset = "0xC920C0", VA = "0x180C93AC0", Slot = "19")]
	public void MFKGDNHBKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x86FBE80", Offset = "0x86FA480", VA = "0x1886FBE80", Slot = "20")]
	public void GJBBIKELKDA(LIPCMCBNFNH MLCOGCMJLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x86FBC10", Offset = "0x86FA210", VA = "0x1886FBC10")]
	private void FJPLBDIBJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x86FC610", Offset = "0x86FAC10", VA = "0x1886FC610", Slot = "21")]
	public void LILAIIIHGCP(NCCENBGIEMA KNNDNAPJIDP, Vector3 CICOCLBFIJN, Vector3 LBHIPCKDOOM, Vector3 PFFFPBJFGBL, float AHGBEHNHMIJ, float CDDCDDIFOPG, IReadOnlyList<Camera> MNHACLNNKJH, IEMJHKLDHIK HBODJJIPFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x86FC9E0", Offset = "0x86FAFE0", VA = "0x1886FC9E0", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FA2F0", Offset = "0x86F88F0", VA = "0x1886FA2F0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool FIJGAFAPGND
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD69F20", Offset = "0xD68520", VA = "0x180D69F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD69DB0", Offset = "0xD683B0", VA = "0x180D69DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBEDFB0", Offset = "0xBEC5B0", VA = "0x180BEDFB0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public LGJOMFGAFNG JADCDEDGOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EKLKNHMHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xE9C240", Offset = "0xE9A840", VA = "0x180E9C240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	protected KNNJCBPNHCB(KHGMKIBFIKG KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x86FA310", Offset = "0x86F8910", VA = "0x1886FA310", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "18")]
	public virtual bool DFFDHGPHIMM(CIPJGNAKHIH KNNDNAPJIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x86FA4A0", Offset = "0x86F8AA0", VA = "0x1886FA4A0", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x86FA4B0", Offset = "0x86F8AB0", VA = "0x1886FA4B0", Slot = "13")]
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
	[Cpp2IlInjected.Address(RVA = "0x86FA470", Offset = "0x86F8A70", VA = "0x1886FA470", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x8702710", Offset = "0x8700D10", VA = "0x188702710")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public OCIGGOEELLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x86FF230", Offset = "0x86FD830", VA = "0x1886FF230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x86FF3A0", Offset = "0x86FD9A0", VA = "0x1886FF3A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x86FF300", Offset = "0x86FD900", VA = "0x1886FF300", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EOAHKPEMMBH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x86FF300", Offset = "0x86FD900", VA = "0x1886FF300", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86F1AD0", Offset = "0x86F00D0", VA = "0x1886F1AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer ELEJGLLHDFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x86F1800", Offset = "0x86EFE00", VA = "0x1886F1800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x86F12E0", Offset = "0x86EF8E0", VA = "0x1886F12E0")]
	[FHOLJFNIKPC]
	internal static void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x86F1A30", Offset = "0x86F0030", VA = "0x1886F1A30")]
	public static Mesh MIBOAMEBEFM(IAMAGEBEBON MKJANMFNLFL, int GKGMDAMJCNF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x86F15F0", Offset = "0x86EFBF0", VA = "0x1886F15F0")]
	public static int GBGIBDGGCHJ(IAMAGEBEBON MKJANMFNLFL, int GKGMDAMJCNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x86F1600", Offset = "0x86EFC00", VA = "0x1886F1600")]
	public static HEFAOEOOFNP GEAMGNHNJIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x86F13C0", Offset = "0x86EF9C0", VA = "0x1886F13C0")]
	[IteratorStateMachine(typeof(OCIGGOEELLL))]
	private static IEnumerable<EOAHKPEMMBH> CAIKJCLBFKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x86F1B30", Offset = "0x86F0130", VA = "0x1886F1B30")]
	public static EOAHKPEMMBH PLHABHOLBDB(IAMAGEBEBON MKJANMFNLFL, int GKGMDAMJCNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x86F1420", Offset = "0x86EFA20", VA = "0x1886F1420")]
	public static bool DEHCNJNHHPL(this IAMAGEBEBON MKJANMFNLFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x86F1440", Offset = "0x86EFA40", VA = "0x1886F1440")]
	public static void FNCIGLMBLMK(IAMAGEBEBON MKJANMFNLFL, float3 KPNLMCNCJLJ, [Out] EGAMEBEHMLC IPCLJDODAPI, [Out] float3 OIFMNEMBMAF, [Out] float OILNKKOJHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x86F0F20", Offset = "0x86EF520", VA = "0x1886F0F20")]
	public static void AFCCCJEKJJM(Vector3 KPNLMCNCJLJ, IAMAGEBEBON MKJANMFNLFL, [Out] Vector3 OIFMNEMBMAF, [Out] float OILNKKOJHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x86F1860", Offset = "0x86EFE60", VA = "0x1886F1860")]
	[OLGIFJNPPLL(0)]
	[FELFDMPPKKE(MGEKOJDDIFB.ExitingPlayMode, 0)]
	private static void IKGADMPEMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x86F1870", Offset = "0x86EFE70", VA = "0x1886F1870")]
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
		[Cpp2IlInjected.Address(RVA = "0x8701950", Offset = "0x86FFF50", VA = "0x188701950", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public KNNJCBPNHCB OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8701890", Offset = "0x86FFE90", VA = "0x188701890", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DJJLLLMIHIH OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x87018F0", Offset = "0x86FFEF0", VA = "0x1887018F0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NKAMGGLIJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAA4630", Offset = "0xAA2C30", VA = "0x180AA4630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8702350", Offset = "0x8700950", VA = "0x188702350")]
	public PMDFOAPEKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x87019B0", Offset = "0x86FFFB0", VA = "0x1887019B0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8701B80", Offset = "0x8700180", VA = "0x188701B80", Slot = "4")]
	public NCCENBGIEMA ICBALKMLPBO(HIOINALINKM APDBNIMCPID)
	{
		return default(NCCENBGIEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8701B80", Offset = "0x8700180", VA = "0x188701B80", Slot = "5")]
	public NCCENBGIEMA ICBALKMLPBO(HIOINALINKM APDBNIMCPID, bool BFAJCNNIPLE)
	{
		return default(NCCENBGIEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8701B20", Offset = "0x8700120", VA = "0x188701B20", Slot = "6")]
	public void HMDKGKANJNJ(NCCENBGIEMA KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8701AA0", Offset = "0x87000A0", VA = "0x188701AA0", Slot = "7")]
	public void FGEBAJKBNEL(NCCENBGIEMA KNNDNAPJIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8702190", Offset = "0x8700790", VA = "0x188702190", Slot = "8")]
	public CNEDHOBLNKD PHGOCJBDJLN(NCCENBGIEMA KNNDNAPJIDP, HNGPMGMDPEH APDBNIMCPID)
	{
		return default(CNEDHOBLNKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8701DD0", Offset = "0x87003D0", VA = "0x188701DD0", Slot = "9")]
	public CNEDHOBLNKD LICHKICBMDJ(NCCENBGIEMA KNNDNAPJIDP, HFIDGLOEBHF APDBNIMCPID)
	{
		return default(CNEDHOBLNKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8701F70", Offset = "0x8700570", VA = "0x188701F70", Slot = "11")]
	public void NBMOKCEOFAB(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8701F10", Offset = "0x8700510", VA = "0x188701F10", Slot = "10")]
	public void MKHJAPCOKEG(CNEDHOBLNKD HIECCNNOPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8701CC0", Offset = "0x87002C0", VA = "0x188701CC0", Slot = "20")]
	public IEnumerable<Renderer> IOMLHMCDOLN(NCCENBGIEMA KNNDNAPJIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8702000", Offset = "0x8700600", VA = "0x188702000", Slot = "12")]
	public AENBPOANBNH NEBAGIGNLIB(LLFOHOKPBJD APDBNIMCPID)
	{
		return default(AENBPOANBNH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8702080", Offset = "0x8700680", VA = "0x188702080", Slot = "14")]
	public void NKIPNHKJMND(AENBPOANBNH GMANNGFCILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8701C20", Offset = "0x8700220", VA = "0x188701C20", Slot = "16")]
	public Task IDMBEEIPJJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8701D30", Offset = "0x8700330", VA = "0x188701D30", Slot = "17")]
	public Task LFIICAHNOAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x87020F0", Offset = "0x87006F0", VA = "0x1887020F0", Slot = "18")]
	public Task NLPOMMDGPMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2673CE0", Offset = "0x26722E0", VA = "0x182673CE0", Slot = "19")]
	public void AAKMCACJFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8701A40", Offset = "0x8700040", VA = "0x188701A40", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x86F0AC0", Offset = "0x86EF0C0", VA = "0x1886F0AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x86F0ED0", Offset = "0x86EF4D0", VA = "0x1886F0ED0")]
	public static void NFFLMPFOABM(DAKKMJBEKAC KJGCBIGHEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x86F0E10", Offset = "0x86EF410", VA = "0x1886F0E10")]
	public static Material MMGDGEOPJEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x86F0CE0", Offset = "0x86EF2E0", VA = "0x1886F0CE0")]
	public static Material HKOJDKHKMED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x86F0E70", Offset = "0x86EF470", VA = "0x1886F0E70")]
	public static Material NENNEAJBHDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x86F0B20", Offset = "0x86EF120", VA = "0x1886F0B20")]
	public static int AFBKFIGEOHD(IHNAGNCLKBF HNCPHCOBGLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x86F0B90", Offset = "0x86EF190", VA = "0x1886F0B90")]
	public static int CPFJFCHEMHD(MNHJGJHOEHN FCJDJNJLCGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x86F0D40", Offset = "0x86EF340", VA = "0x1886F0D40")]
	public static void KJANMMJEPCF(GameObject BOMDCGFKGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x86F0C00", Offset = "0x86EF200", VA = "0x1886F0C00")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public BHNHAKNFLGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x86F0470", Offset = "0x86EEA70", VA = "0x1886F0470", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x86F0150", Offset = "0x86EE750", VA = "0x1886F0150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x86F0100", Offset = "0x86EE700", VA = "0x1886F0100")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x86F0420", Offset = "0x86EEA20", VA = "0x1886F0420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x86F0370", Offset = "0x86EE970", VA = "0x1886F0370", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x86F0370", Offset = "0x86EE970", VA = "0x1886F0370", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x86F2CB0", Offset = "0x86F12B0", VA = "0x1886F2CB0")]
	public static DJJLLLMIHIH JKEADJBGOCC(LLFOHOKPBJD APDBNIMCPID, BCFOMFEJOFB GBBHIJBKKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x86F3D90", Offset = "0x86F2390", VA = "0x1886F3D90")]
	private DJJLLLMIHIH(LLFOHOKPBJD APDBNIMCPID, BCFOMFEJOFB GBBHIJBKKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x86F3910", Offset = "0x86F1F10", VA = "0x1886F3910")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x86F3890", Offset = "0x86F1E90", VA = "0x1886F3890")]
	[IteratorStateMachine(typeof(BHNHAKNFLGA))]
	public IEnumerable<Renderer> MPIPDNBCHBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x86F2E00", Offset = "0x86F1400", VA = "0x1886F2E00", Slot = "4")]
	public void LODKFBECFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x86F2C80", Offset = "0x86F1280", VA = "0x1886F2C80")]
	private void JHJGDHMGHIC(Vector3 KIBNLFAIDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x86F2A30", Offset = "0x86F1030", VA = "0x1886F2A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public APOGADLLCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x86EFF30", Offset = "0x86EE530", VA = "0x1886EFF30")]
		internal JobHandle GOAGLAFDPGD()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x86EFF00", Offset = "0x86EE500", VA = "0x1886EFF00")]
		internal void ABMHHCHGLAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x86EFF90", Offset = "0x86EE590", VA = "0x1886EFF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DCHGDNOGAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x86F5950", Offset = "0x86F3F50", VA = "0x1886F5950")]
	public void IMLDDILJGKI(List<CIPJGNAKHIH> PBGLKODNMBL, Matrix4x4[] EJPNOECLHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x86F4F60", Offset = "0x86F3560", VA = "0x1886F4F60")]
	public static List<IAIKDIPJMBL> FLLMCNLHKNL(List<KHGMKIBFIKG> OJJLHNIKPEE, OEDNPOAFIDC GKGMDAMJCNF, Bounds HJOECMEGBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x86F55F0", Offset = "0x86F3BF0", VA = "0x1886F55F0")]
	private JobHandle IDGKMHEGMEF(OFNFOCEBPOF HEOKEACGJHP, int DIGNHEFBOML, int FNBPJBGCLCH, OEDNPOAFIDC GKGMDAMJCNF, List<OMHCJFAHLLK> JBDNFPBIPPK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x86F4DF0", Offset = "0x86F33F0", VA = "0x1886F4DF0")]
	private void BGGEHELIDKJ(List<OMHCJFAHLLK> JBDNFPBIPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x86F5CC0", Offset = "0x86F42C0", VA = "0x1886F5CC0")]
	private IAIKDIPJMBL(List<OMHCJFAHLLK> JBDNFPBIPPK, int DIGNHEFBOML, int FNBPJBGCLCH, OEDNPOAFIDC GKGMDAMJCNF, Bounds HJOECMEGBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x86F4ED0", Offset = "0x86F34D0", VA = "0x1886F4ED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int HBAGIMDFAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8703440", Offset = "0x8701A40", VA = "0x188703440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8702770", Offset = "0x8700D70", VA = "0x188702770")]
		public static List<SkinnedShapeRenderer> Create(GameObject KNNDNAPJIDP, List<IAIKDIPJMBL> LHHLMCNOLOM, List<CIPJGNAKHIH> IFACPDBOEIA, Material CANJBFKPEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8702E30", Offset = "0x8701430", VA = "0x188702E30")]
		public void Init(IAIKDIPJMBL PEPFHNJFNIL, List<CIPJGNAKHIH> IFACPDBOEIA, Material CANJBFKPEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x87033A0", Offset = "0x87019A0", VA = "0x1887033A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8703300", Offset = "0x8701900", VA = "0x188703300")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x87032C0", Offset = "0x87018C0", VA = "0x1887032C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8702A00", Offset = "0x8701000", VA = "0x188702A00")]
		private void DIOMBHMNIGC(ScriptableRenderContext INLEBAAACKH, Camera[] ECCKNGENJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8702AC0", Offset = "0x87010C0", VA = "0x188702AC0")]
		private void IMLDDILJGKI(CommandBuffer HKEOEPNOEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
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
