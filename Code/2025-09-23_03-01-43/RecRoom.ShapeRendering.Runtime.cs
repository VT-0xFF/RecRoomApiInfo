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
using Unity.Burst;
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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x90887B0", Offset = "0x9086DB0", VA = "0x1890887B0", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x90909C0", Offset = "0x908EFC0", VA = "0x1890909C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KEDBGFKLMPH : JAJIKLMOMOC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte ENKNBOILONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] DAOJLCEOKNP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IICIEJAAKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAFD490", Offset = "0xAFBA90", VA = "0x180AFD490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NGNMALHLIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC582A0", Offset = "0xC568A0", VA = "0x180C582A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10B1C80", Offset = "0x10B0280", VA = "0x1810B1C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float LCEHPEFNBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x10D9240", Offset = "0x10D7840", VA = "0x1810D9240", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x15FA3E0", Offset = "0x15F89E0", VA = "0x1815FA3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float ELHONMKEDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDD5BD0", Offset = "0xDD41D0", VA = "0x180DD5BD0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDD5BE0", Offset = "0xDD41E0", VA = "0x180DD5BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> NLOHOEABMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9083330", Offset = "0x9081930", VA = "0x189083330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> LFPCDPLANIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9083300", Offset = "0x9081900", VA = "0x189083300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte EOLCKLIAHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9083060", Offset = "0x9081660", VA = "0x189083060", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9083600", Offset = "0x9081C00", VA = "0x189083600")]
	public KEDBGFKLMPH(List<EJGLPIEGMAM> FMNCDJEMLAE, List<EJGLPIEGMAM> FFDKMMOIHIB, List<ACLDACCHLEI> DNOKDGOLJFF, Material PFHPGDKJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9083380", Offset = "0x9081980", VA = "0x189083380")]
	private int NMDDEKKCCME(List<EJGLPIEGMAM> CBLFOFKBKJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x90834A0", Offset = "0x9081AA0", VA = "0x1890834A0")]
	private void PBJJPJDKIEF(int BCHLKEPDMFO, bool KAHLPNCEPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x90831B0", Offset = "0x90817B0", VA = "0x1890831B0")]
	public void FNCHMBOLLJL(Vector3 IAJPGBLEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x90830B0", Offset = "0x90816B0", VA = "0x1890830B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9083020", Offset = "0x9081620", VA = "0x189083020")]
	public void ANAKNBBKGPD(Transform OIEGFLHOMMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DLMKLLKNKBG : PNBHLCAGLCB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class JKNIBMADLBL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DLMKLLKNKBG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public JKNIBMADLBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9082850", Offset = "0x9080E50", VA = "0x189082850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9082240", Offset = "0x9080840", VA = "0x189082240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x90821F0", Offset = "0x90807F0", VA = "0x1890821F0")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9082150", Offset = "0x9080750", VA = "0x189082150")]
		private void FECGMFJNPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x90821A0", Offset = "0x90807A0", VA = "0x1890821A0")]
		private void LJBNFKOLOBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9082800", Offset = "0x9080E00", VA = "0x189082800", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9082750", Offset = "0x9080D50", VA = "0x189082750", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9082750", Offset = "0x9080D50", VA = "0x189082750", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DPCLEFGPKJA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DLMKLLKNKBG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public DPCLEFGPKJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x907D8C0", Offset = "0x907BEC0", VA = "0x18907D8C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x907D450", Offset = "0x907BA50", VA = "0x18907D450", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x907D400", Offset = "0x907BA00", VA = "0x18907D400")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x907D3B0", Offset = "0x907B9B0", VA = "0x18907D3B0")]
		private void FECGMFJNPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x907D870", Offset = "0x907BE70", VA = "0x18907D870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x907D7C0", Offset = "0x907BDC0", VA = "0x18907D7C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x907D7C0", Offset = "0x907BDC0", VA = "0x18907D7C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BGGCMEGDEOC KDCPGEAFOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<EPJNKDNOFOB> DEBLCIECHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> GJPIFGFPDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer OPELEKFKFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool BGBJFIHECBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool BGDPCJBOJAH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<ECMILFBCNGB> DDAOFJIIMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JEOMHLGDGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x907BE20", Offset = "0x907A420", VA = "0x18907BE20", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ACLDACCHLEI PENPPPIDKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x907D190", Offset = "0x907B790", VA = "0x18907D190", Slot = "8")]
		get
		{
			return default(ACLDACCHLEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> OGDNLBNFKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x907BE00", Offset = "0x907A400", VA = "0x18907BE00")]
	private bool FHAHLMPCCDI(EPJNKDNOFOB KOJIMAFGDLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x907BDE0", Offset = "0x907A3E0", VA = "0x18907BDE0")]
	private static bool FDOENMHDKKC(EPJNKDNOFOB KOJIMAFGDLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x907D2C0", Offset = "0x907B8C0", VA = "0x18907D2C0")]
	public DLMKLLKNKBG(BGGCMEGDEOC CDDIADBJAOB, bool NDCFGKJIFDP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x907BBF0", Offset = "0x907A1F0", VA = "0x18907BBF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x907CF00", Offset = "0x907B500", VA = "0x18907CF00")]
	public void MEFAAGOGBHI(EPJNKDNOFOB KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x907BA90", Offset = "0x907A090", VA = "0x18907BA90")]
	public void CBELOMAGFLH(EPJNKDNOFOB KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x907C0D0", Offset = "0x907A6D0", VA = "0x18907C0D0", Slot = "4")]
	public void GIGKCKAEPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x907BE60", Offset = "0x907A460", VA = "0x18907BE60")]
	public void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x907C780", Offset = "0x907AD80", VA = "0x18907C780")]
	private void JKAPLCMDIIC(List<EPJNKDNOFOB> DEBLCIECHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x907D260", Offset = "0x907B860", VA = "0x18907D260")]
	private static Material PMLMGMPGNGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x907C6D0", Offset = "0x907ACD0", VA = "0x18907C6D0")]
	private void JKAPLCMDIIC(EPJNKDNOFOB KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x907B940", Offset = "0x9079F40", VA = "0x18907B940")]
	private void ANIDKFBOPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x907C940", Offset = "0x907AF40", VA = "0x18907C940")]
	public void LKCJOFPHKIJ(bool HNNJDNHHHEF, bool LFHDHDOIOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x907D0D0", Offset = "0x907B6D0", VA = "0x18907D0D0")]
	protected void OAPFFBCHJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x907C650", Offset = "0x907AC50", VA = "0x18907C650")]
	public void JHKGHBOKONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x907BA10", Offset = "0x907A010", VA = "0x18907BA10")]
	[IteratorStateMachine(typeof(JKNIBMADLBL))]
	public IEnumerable<Renderer> BGMOFIAJLBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x907C5D0", Offset = "0x907ABD0", VA = "0x18907C5D0")]
	[IteratorStateMachine(typeof(DPCLEFGPKJA))]
	public IEnumerable<Renderer> HACDJFDGGGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[BurstCompile]
internal class IACIEICHCJN : EPJNKDNOFOB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct BJKFELKEIEF : IIBCCPJOGDJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GKMCCFCPGAH KNHPHEPPGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle BJFLKGBEEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OEBKJMCPJBO NKCIIACHNBH;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x907B8E0", Offset = "0x9079EE0", VA = "0x18907B8E0")]
		public BJKFELKEIEF(GKMCCFCPGAH KNHPHEPPGOL, JobHandle BJFLKGBEEDK, OEBKJMCPJBO NKCIIACHNBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x907B8B0", Offset = "0x9079EB0", VA = "0x18907B8B0", Slot = "4")]
		public GKMCCFCPGAH PNGLJDLMHCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x907B860", Offset = "0x9079E60", VA = "0x18907B860", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public unsafe delegate void FHHPPGGILNG([NoAlias] EAKFAHMLPOO HHPONGBLNBP, int IBKDGNFBBAH, [In][NoAlias] UniformTRS PDIPPFLBMHH, [In][NoAlias] KMFOEBEFONO* KDILADLDOFL);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class NDEHIPPDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x908B880", Offset = "0x9089E80", VA = "0x18908B880")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x908BDF0", Offset = "0x908A3F0", VA = "0x18908BDF0")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x908BD40", Offset = "0x908A340", VA = "0x18908BD40")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x908B9B0", Offset = "0x9089FB0", VA = "0x18908B9B0")]
		public unsafe static void MJPLNPACNDN([NoAlias] EAKFAHMLPOO HHPONGBLNBP, int IBKDGNFBBAH, [In][NoAlias] UniformTRS PDIPPFLBMHH, [In][NoAlias] KMFOEBEFONO* KDILADLDOFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly GHJEGHHKFLP BOGJHIEJAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float NNBEANNIPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 IKIGPNGCJPH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 BJENPBACNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9080040", Offset = "0x907E640", VA = "0x189080040", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9081AB0", Offset = "0x90800B0", VA = "0x189081AB0")]
	public IACIEICHCJN(DLMKLLKNKBG BOCNDANOLJJ, GHJEGHHKFLP CDDIADBJAOB, bool NDCFGKJIFDP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "18")]
	public override bool FGCGJPFDNAA(ACLDACCHLEI BOCNDANOLJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x9081000", Offset = "0x907F600", VA = "0x189081000", Slot = "19")]
	public override int NMDDEKKCCME(PEADBPGCBOF OCNFNIGMAEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x9080BE0", Offset = "0x907F1E0", VA = "0x189080BE0", Slot = "20")]
	public override int IFAPMJBHDDD(PEADBPGCBOF OCNFNIGMAEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x9081840", Offset = "0x907FE40", VA = "0x189081840", Slot = "21")]
	public override EAKFAHMLPOO PLHLMDPAHCF()
	{
		return default(EAKFAHMLPOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9080F80", Offset = "0x907F580", VA = "0x189080F80")]
	[BurstCompile]
	private unsafe static void LKKPIBAEDMI([NoAlias] EAKFAHMLPOO HHPONGBLNBP, int IBKDGNFBBAH, [In][NoAlias] UniformTRS PDIPPFLBMHH, [In][NoAlias] KMFOEBEFONO* KDILADLDOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xC58280", Offset = "0xC56880", VA = "0x180C58280", Slot = "22")]
	public override float AICGHANNLHN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x90811E0", Offset = "0x907F7E0", VA = "0x1890811E0", Slot = "23")]
	public override void OKGFILLIHDI(PEADBPGCBOF OCNFNIGMAEF, LDDJPFHOBHE ICOFCHPJMOA, int AACEFHAGPHE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9081650", Offset = "0x907FC50", VA = "0x189081650")]
	private int PLCDCOLGJHD(PEADBPGCBOF OCNFNIGMAEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x9080360", Offset = "0x907E960", VA = "0x189080360", Slot = "24")]
	public override ACLDACCHLEI HKDJCIOOGCA()
	{
		return default(ACLDACCHLEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9080DC0", Offset = "0x907F3C0", VA = "0x189080DC0", Slot = "26")]
	public override MEGOACLMJMP JMDJKNFFELJ()
	{
		return default(MEGOACLMJMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9080430", Offset = "0x907EA30", VA = "0x189080430", Slot = "27")]
	public override IIBCCPJOGDJ HLPDDCDILJM(PEADBPGCBOF OCNFNIGMAEF, JobHandle BJFLKGBEEDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9080170", Offset = "0x907E770", VA = "0x189080170")]
	[BurstCompile]
	public unsafe static void BNCBCOLNGGP([NoAlias] EAKFAHMLPOO HHPONGBLNBP, int IBKDGNFBBAH, [In][NoAlias] UniformTRS PDIPPFLBMHH, [In][NoAlias] KMFOEBEFONO* KDILADLDOFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public interface LGMGMBGHLBI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DLMKLLKNKBG LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EPJNKDNOFOB LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	POFPAJGJCMO LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public class KMGLENHHJIO : EKBBEBOGNCO, IDisposable, LGMGMBGHLBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct KCOJBFFCHOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public KMGLENHHJIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9082A40", Offset = "0x9081040", VA = "0x189082A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9082FC0", Offset = "0x90815C0", VA = "0x189082FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly BJGPALKLGOJ<HELGAKOMGEN, DLMKLLKNKBG> MGCMECKKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly BJGPALKLGOJ<LEFLGOLACFG, EPJNKDNOFOB> DEBLCIECHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly BJGPALKLGOJ<DLEPDHPKPHM, POFPAJGJCMO> PBMEPIMLGIE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DLMKLLKNKBG LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9085A00", Offset = "0x9084000", VA = "0x189085A00", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public EPJNKDNOFOB LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9085940", Offset = "0x9083F40", VA = "0x189085940", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public POFPAJGJCMO LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x90859A0", Offset = "0x9083FA0", VA = "0x1890859A0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool AMKGHBKHKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC18890", Offset = "0xC16E90", VA = "0x180C18890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9085B40", Offset = "0x9084140", VA = "0x189085B40")]
	public KMGLENHHJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x90843E0", Offset = "0x90829E0", VA = "0x1890843E0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9084A90", Offset = "0x9083090", VA = "0x189084A90", Slot = "4")]
	public HELGAKOMGEN HKHBIEMOHAC(BGGCMEGDEOC CDDIADBJAOB)
	{
		return default(HELGAKOMGEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9084810", Offset = "0x9082E10", VA = "0x189084810", Slot = "5")]
	public HELGAKOMGEN HKHBIEMOHAC(BGGCMEGDEOC CDDIADBJAOB, bool NDCFGKJIFDP)
	{
		return default(HELGAKOMGEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9084180", Offset = "0x9082780", VA = "0x189084180", Slot = "6")]
	public void BNHMMBJGHCD(HELGAKOMGEN BOCNDANOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x90853B0", Offset = "0x90839B0", VA = "0x1890853B0", Slot = "7")]
	public void KEPNHKCKLPD(HELGAKOMGEN BOCNDANOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9083920", Offset = "0x9081F20", VA = "0x189083920", Slot = "8")]
	public LEFLGOLACFG ABIAJMNMDCK(HELGAKOMGEN BOCNDANOLJJ, AEDDAMMOMOG CDDIADBJAOB)
	{
		return default(LEFLGOLACFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9084AA0", Offset = "0x90830A0", VA = "0x189084AA0", Slot = "9")]
	public LEFLGOLACFG HLDNAMJAAJB(HELGAKOMGEN BOCNDANOLJJ, GHJEGHHKFLP CDDIADBJAOB)
	{
		return default(LEFLGOLACFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9084F80", Offset = "0x9083580", VA = "0x189084F80", Slot = "11")]
	public void HPANLJEGOLH(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x90845B0", Offset = "0x9082BB0", VA = "0x1890845B0", Slot = "10")]
	public void HABPOHHHMFI(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x9085710", Offset = "0x9083D10", VA = "0x189085710", Slot = "20")]
	public IEnumerable<Renderer> LHJLFLINPBD(HELGAKOMGEN BOCNDANOLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9085AC0", Offset = "0x90840C0", VA = "0x189085AC0", Slot = "12")]
	public DLEPDHPKPHM POIPAFHJKKG(APMAMGEENID CDDIADBJAOB)
	{
		return default(DLEPDHPKPHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x9085340", Offset = "0x9083940", VA = "0x189085340", Slot = "14")]
	public void JDBGLAIHBID(DLEPDHPKPHM MHEKKPNBJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x9083FC0", Offset = "0x90825C0", VA = "0x189083FC0", Slot = "16")]
	public Task BBBKEKHLLIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9085780", Offset = "0x9083D80", VA = "0x189085780", Slot = "17")]
	public Task LJPLFHBOPFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9083E00", Offset = "0x9082400", VA = "0x189083E00", Slot = "18")]
	[AsyncStateMachine(typeof(KCOJBFFCHOD))]
	public Task AHJMCEPKHFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9083ED0", Offset = "0x90824D0", VA = "0x189083ED0", Slot = "19")]
	public void AIBJECCLJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9085A60", Offset = "0x9084060", VA = "0x189085A60", Slot = "13")]
	public void PHNCPKILALK(DLEPDHPKPHM MHEKKPNBJKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
internal class LLEEGBCAOGD : EPJNKDNOFOB
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private struct POGILAOEJMH : IIBCCPJOGDJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private GKMCCFCPGAH KNHPHEPPGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private NativeArray<int> JMIAKDAMEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private JobHandle BJFLKGBEEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IPNMKCPFHOJ NKCIIACHNBH;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x908F450", Offset = "0x908DA50", VA = "0x18908F450")]
		public POGILAOEJMH(GKMCCFCPGAH KNHPHEPPGOL, NativeArray<int> JMIAKDAMEOH, JobHandle BJFLKGBEEDK, IPNMKCPFHOJ NKCIIACHNBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x908F3F0", Offset = "0x908D9F0", VA = "0x18908F3F0", Slot = "4")]
		public GKMCCFCPGAH PNGLJDLMHCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x908F350", Offset = "0x908D950", VA = "0x18908F350", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void MPGIGMDLCAE([NoAlias] EAKFAHMLPOO HHPONGBLNBP, [In] float3 CCJOGIFAANG, [In][NoAlias] Bounds IIEIAMICBJP, [In][NoAlias] UniformTRS LANFNENIGGG);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class NBKPDNDFCPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr EMPHPJOFCIP;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr AHFENMJENII;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x908B330", Offset = "0x9089930", VA = "0x18908B330")]
		[BurstDiscard]
		private static void KLMFGBGNPPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x908B720", Offset = "0x9089D20", VA = "0x18908B720")]
		private static IntPtr PBPOBBIFOGI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x908B670", Offset = "0x9089C70", VA = "0x18908B670")]
		public static void MKLFPBIBFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public static void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x908B460", Offset = "0x9089A60", VA = "0x18908B460")]
		public static void MJPLNPACNDN([NoAlias] EAKFAHMLPOO HHPONGBLNBP, [In] float3 CCJOGIFAANG, [In][NoAlias] Bounds IIEIAMICBJP, [In][NoAlias] UniformTRS LANFNENIGGG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly AEDDAMMOMOG BJOBNNFAMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int[] HGBMIMMDEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Hash128 IKIGPNGCJPH;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 LAPJIKPKPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9086520", Offset = "0x9084B20", VA = "0x189086520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 BJENPBACNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x90860E0", Offset = "0x90846E0", VA = "0x1890860E0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9088700", Offset = "0x9086D00", VA = "0x189088700")]
	public LLEEGBCAOGD(DLMKLLKNKBG BOCNDANOLJJ, AEDDAMMOMOG CDDIADBJAOB, bool HIAMBHBHGOK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9086210", Offset = "0x9084810", VA = "0x189086210", Slot = "18")]
	public override bool FGCGJPFDNAA(ACLDACCHLEI BOCNDANOLJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x90883E0", Offset = "0x90869E0", VA = "0x1890883E0", Slot = "21")]
	public override EAKFAHMLPOO PLHLMDPAHCF()
	{
		return default(EAKFAHMLPOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x9088420", Offset = "0x9086A20", VA = "0x189088420")]
	private EAKFAHMLPOO PLHLMDPAHCF(ACLDACCHLEI BOCNDANOLJJ)
	{
		return default(EAKFAHMLPOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x90862E0", Offset = "0x90848E0", VA = "0x1890862E0")]
	[BurstCompile]
	private static void FMJMFADLBKK([NoAlias] EAKFAHMLPOO HHPONGBLNBP, [In] float3 CCJOGIFAANG, [In][NoAlias] Bounds IIEIAMICBJP, [In][NoAlias] UniformTRS LANFNENIGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9087270", Offset = "0x9085870", VA = "0x189087270")]
	private MBPPHLHLFNI LJLEPIFGHMF([In] UniformTRS JGAAGHPIAAJ, [In] float3 KAKOAJGKEMH)
	{
		return default(MBPPHLHLFNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x9087850", Offset = "0x9085E50", VA = "0x189087850", Slot = "19")]
	public override int NMDDEKKCCME(PEADBPGCBOF OCNFNIGMAEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x9087000", Offset = "0x9085600", VA = "0x189087000", Slot = "20")]
	public override int IFAPMJBHDDD(PEADBPGCBOF OCNFNIGMAEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9085FF0", Offset = "0x90845F0", VA = "0x189085FF0", Slot = "22")]
	public override float AICGHANNLHN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9087900", Offset = "0x9085F00", VA = "0x189087900")]
	private int OAHBMNBNIJH(PEADBPGCBOF OCNFNIGMAEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9087B80", Offset = "0x9086180", VA = "0x189087B80", Slot = "23")]
	public override void OKGFILLIHDI(PEADBPGCBOF OCNFNIGMAEF, LDDJPFHOBHE ICOFCHPJMOA, int AACEFHAGPHE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x9086750", Offset = "0x9084D50", VA = "0x189086750", Slot = "24")]
	public override ACLDACCHLEI HKDJCIOOGCA()
	{
		return default(ACLDACCHLEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x90870B0", Offset = "0x90856B0", VA = "0x1890870B0", Slot = "26")]
	public override MEGOACLMJMP JMDJKNFFELJ()
	{
		return default(MEGOACLMJMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9086820", Offset = "0x9084E20", VA = "0x189086820", Slot = "27")]
	public override IIBCCPJOGDJ HLPDDCDILJM(PEADBPGCBOF OCNFNIGMAEF, JobHandle BJFLKGBEEDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9087470", Offset = "0x9085A70", VA = "0x189087470")]
	[BurstCompile]
	public static void NIJPCPAOBBK([NoAlias] EAKFAHMLPOO HHPONGBLNBP, [In] float3 CCJOGIFAANG, [In][NoAlias] Bounds IIEIAMICBJP, [In][NoAlias] UniformTRS LANFNENIGGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PIKFBLFDKLN
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HONABAKLPBN(PDPGAAFEJAL GPEIAHGICNA, Renderer MAFJPEPPLNH, int KBOGJJJLGOL);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOOADKKOJCC(Renderer MAFJPEPPLNH, IGODHLECOAD JLKFCEIEICE, Vector3 DJIGLACMLII, Vector3 IMPMKOLFKIF, Vector3 EADEMGGPEAH, float DBMMEDJIKBH, float OCDMHDILEMB, float HCAHCBGHDCF = -1f, [Optional] Color? FPHNLEHIJEM, [Optional] IReadOnlyList<Camera> LAGNPEHIOEG);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FIGCBDDNEIC(Renderer MAFJPEPPLNH, int KBOGJJJLGOL);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HKLFDACINMI();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AAIKIMADPFG(int BKHANGAJFBK, POFMKFJLMNC GPEIAHGICNA, Renderer MAFJPEPPLNH, int KBOGJJJLGOL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MPMHNOHEJLE : DIBJFLJJFNO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private class HAKDDGELLEL : ELPCEDNAOPO<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x907FFF0", Offset = "0x907E5F0", VA = "0x18907FFF0")]
		public HAKDDGELLEL(string NDIENANOGEK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PIKFBLFDKLN OOLOAJDAHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly LGMGMBGHLBI EEENMBAJFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private MeshRenderer MLCJBGLLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private HAKDDGELLEL MECMFADDEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private bool MHHFJAFDIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private MeshRenderer BMIFPILCAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HAKDDGELLEL EMKNFLKGJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool NCCFPILGIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private MeshRenderer LBLFAFFHLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private HAKDDGELLEL IDBKONGLMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private bool IKADKLFEAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool AJNGKKLNKMJ;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xAA7000", Offset = "0xAA5600", VA = "0x180AA7000")]
	public MPMHNOHEJLE(PIKFBLFDKLN ONCPPCGCCMB, LGMGMBGHLBI EEENMBAJFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x9088CE0", Offset = "0x90872E0", VA = "0x189088CE0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x9089C70", Offset = "0x9088270", VA = "0x189089C70")]
	private void JEOKGCFKAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x9089560", Offset = "0x9087B60", VA = "0x189089560", Slot = "4")]
	public void FMHLOPFJDIG(HELGAKOMGEN BOCNDANOLJJ, POFMKFJLMNC BNPFBJAOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x9089340", Offset = "0x9087940", VA = "0x189089340", Slot = "5")]
	public void FMHLOPFJDIG(LEFLGOLACFG KOJIMAFGDLP, POFMKFJLMNC BNPFBJAOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9088A50", Offset = "0x9087050", VA = "0x189088A50", Slot = "6")]
	public void CABFGMGHAHF(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x908A700", Offset = "0x9088D00", VA = "0x18908A700", Slot = "7")]
	public void OMKOMNMJPOM(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x908A6C0", Offset = "0x9088CC0", VA = "0x18908A6C0", Slot = "24")]
	public void OKHNBPMKIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x146D390", Offset = "0x146B990", VA = "0x18146D390", Slot = "8")]
	public void BPGAPMGFKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x90891D0", Offset = "0x90877D0", VA = "0x1890891D0", Slot = "9")]
	public void FCDBBDICNLJ(POFMKFJLMNC BNPFBJAOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x9089EE0", Offset = "0x90884E0", VA = "0x189089EE0", Slot = "10")]
	public void KHEAFGKBLOH(HELGAKOMGEN BOCNDANOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x908A1C0", Offset = "0x90887C0", VA = "0x18908A1C0", Slot = "11")]
	public void KHEAFGKBLOH(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x908A5F0", Offset = "0x9088BF0", VA = "0x18908A5F0", Slot = "12")]
	public void NLEPDEGMLIH(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x9088980", Offset = "0x9086F80", VA = "0x189088980", Slot = "13")]
	public void AMJEEICAALN(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x908B0C0", Offset = "0x90896C0", VA = "0x18908B0C0")]
	private void PPEPKPKNGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x162D470", Offset = "0x162BA70", VA = "0x18162D470", Slot = "14")]
	public void OBBOFIDNJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x9089B50", Offset = "0x9088150", VA = "0x189089B50", Slot = "15")]
	public void HHJOGOEEOCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x9089870", Offset = "0x9087E70", VA = "0x189089870", Slot = "16")]
	public void GENGMPMKLMN(HELGAKOMGEN BOCNDANOLJJ, PDPGAAFEJAL GPEIAHGICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x9088E90", Offset = "0x9087490", VA = "0x189088E90", Slot = "17")]
	public void EPHLNECAEHH(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x908A520", Offset = "0x9088B20", VA = "0x18908A520", Slot = "18")]
	public void MADNCPGMHAB(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xE25820", Offset = "0xE23E20", VA = "0x180E25820", Slot = "19")]
	public void CGMEDPKPFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x9088BB0", Offset = "0x90871B0", VA = "0x189088BB0", Slot = "20")]
	public void CCOBNNELFCL(PDPGAAFEJAL GPEIAHGICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x9088F60", Offset = "0x9087560", VA = "0x189088F60")]
	private void FADNNBKKFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x908A850", Offset = "0x9088E50", VA = "0x18908A850", Slot = "21")]
	public void PBMGMADPIJI(HELGAKOMGEN BOCNDANOLJJ, Vector3 DJIGLACMLII, Vector3 IMPMKOLFKIF, Vector3 EADEMGGPEAH, float DBMMEDJIKBH, float OCDMHDILEMB, IReadOnlyList<Camera> CINBDGIIENA, IGODHLECOAD JLKFCEIEICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x908AC20", Offset = "0x9089220", VA = "0x18908AC20", Slot = "22")]
	public void PBMGMADPIJI(DLEPDHPKPHM MHEKKPNBJKH, Vector3 DJIGLACMLII, Vector3 IMPMKOLFKIF, Vector3 EADEMGGPEAH, float DBMMEDJIKBH, float OCDMHDILEMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class EPJNKDNOFOB : IAKBODPFBIM, ECMILFBCNGB, DDGHFNGCDMO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly DLMKLLKNKBG HMJJONKLDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private int KLABGNPIMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected Bounds PKCCGJGDHPB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds JMPMAGCGBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x907EF10", Offset = "0x907D510", VA = "0x18907EF10", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool BGDPCJBOJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xF28FA0", Offset = "0xF275A0", VA = "0x180F28FA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xF3FBF0", Offset = "0xF3E1F0", VA = "0x180F3FBF0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 BJENPBACNEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HELFCJEODCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xC4FA70", Offset = "0xC4E070", VA = "0x180C4FA70", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public LMLCCIJFHNO MDFAFBCKELH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool DPCMOAJKDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x234D280", Offset = "0x234B880", VA = "0x18234D280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	protected EPJNKDNOFOB(DLMKLLKNKBG BOCNDANOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x907ED70", Offset = "0x907D370", VA = "0x18907ED70", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "18")]
	public virtual bool FGCGJPFDNAA(ACLDACCHLEI BOCNDANOLJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x907ED30", Offset = "0x907D330", VA = "0x18907ED30", Slot = "10")]
	public int ACFMBPDFAGK(int EADGKLNFFKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int NMDDEKKCCME(PEADBPGCBOF OCNFNIGMAEF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int IFAPMJBHDDD(PEADBPGCBOF OCNFNIGMAEF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract EAKFAHMLPOO PLHLMDPAHCF();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float AICGHANNLHN();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void OKGFILLIHDI(PEADBPGCBOF OCNFNIGMAEF, LDDJPFHOBHE ICOFCHPJMOA, int AACEFHAGPHE = -1);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract ACLDACCHLEI HKDJCIOOGCA();

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x907EEE0", Offset = "0x907D4E0", VA = "0x18907EEE0", Slot = "13")]
	public Hash128 KKPBLEHEELE(int OCNFNIGMAEF)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract MEGOACLMJMP JMDJKNFFELJ();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract IIBCCPJOGDJ HLPDDCDILJM(PEADBPGCBOF OCNFNIGMAEF, JobHandle BJFLKGBEEDK);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x907ED40", Offset = "0x907D340", VA = "0x18907ED40", Slot = "12")]
	public IIBCCPJOGDJ DHCJOAALKIA(int OCNFNIGMAEF)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x908F4B0", Offset = "0x908DAB0", VA = "0x18908F4B0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NLJOKHPEJIK
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JALJJDKCKGF : IEnumerable<AEOEFOMGKHL>, IEnumerable, IEnumerator<AEOEFOMGKHL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private AEOEFOMGKHL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private AEOEFOMGKHL System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public JALJJDKCKGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9081F90", Offset = "0x9080590", VA = "0x189081F90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9082100", Offset = "0x9080700", VA = "0x189082100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9082060", Offset = "0x9080660", VA = "0x189082060", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AEOEFOMGKHL> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9082060", Offset = "0x9080660", VA = "0x189082060", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AEOEFOMGKHL[][] OAJPNDEOOBL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static KPEHFCMMJBE ILDALLNJOAN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static ShapeRendererConfig NLINAOIECJE;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader LFMFOCOMDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x908D970", Offset = "0x908BF70", VA = "0x18908D970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer DDIPLICFEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x908D870", Offset = "0x908BE70", VA = "0x18908D870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x908BF60", Offset = "0x908A560", VA = "0x18908BF60")]
	[DIEFPEDLFME]
	internal static void BDBKJLHAGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x908D8D0", Offset = "0x908BED0", VA = "0x18908D8D0")]
	public static Mesh LKHMCOFGIJF(CODBDPNCDGJ LMJAFGLOCHA, int OCNFNIGMAEF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x908C230", Offset = "0x908A830", VA = "0x18908C230")]
	public static int GCAFHHDCNCK(CODBDPNCDGJ LMJAFGLOCHA, int OCNFNIGMAEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x908C2A0", Offset = "0x908A8A0", VA = "0x18908C2A0")]
	public static KPEHFCMMJBE HCKFANBOCBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x908C240", Offset = "0x908A840", VA = "0x18908C240")]
	[IteratorStateMachine(typeof(JALJJDKCKGF))]
	private static IEnumerable<AEOEFOMGKHL> GEGOCEINOBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x908CA60", Offset = "0x908B060", VA = "0x18908CA60")]
	public static AEOEFOMGKHL IPLJDGPGMGF(CODBDPNCDGJ LMJAFGLOCHA, int OCNFNIGMAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x908C4C0", Offset = "0x908AAC0", VA = "0x18908C4C0")]
	public static bool HEKNJMBIJPF(this CODBDPNCDGJ LMJAFGLOCHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x908C8B0", Offset = "0x908AEB0", VA = "0x18908C8B0")]
	public static void ILHLEHOOIGJ(CODBDPNCDGJ LMJAFGLOCHA, float3 CHMCGDFHKPO, [Out] JFMFOJBNGJD KAPLGOAPMGM, [Out] float3 FHEIJGAPPBK, [Out] float NFFNFLKCKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x908C4E0", Offset = "0x908AAE0", VA = "0x18908C4E0")]
	public static void IGPOMMHPIHG(Vector3 CHMCGDFHKPO, CODBDPNCDGJ LMJAFGLOCHA, [Out] Vector3 FHEIJGAPPBK, [Out] float NFFNFLKCKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x908BF50", Offset = "0x908A550", VA = "0x18908BF50")]
	[BNHBIGLBCHM(0)]
	[FEIBEOENFMF(CMFDNLPEHHP.ExitingPlayMode, 0)]
	private static void APALHAODJLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x908C050", Offset = "0x908A650", VA = "0x18908C050")]
	[BNHBIGLBCHM(0)]
	[FEIBEOENFMF(CMFDNLPEHHP.ExitingPlayMode, 0)]
	private static void DOGPLMFMKLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class GGHEOCNAHID : EKBBEBOGNCO, IDisposable, LGMGMBGHLBI
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly BJGPALKLGOJ<HELGAKOMGEN, DLMKLLKNKBG> MGCMECKKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly BJGPALKLGOJ<LEFLGOLACFG, EPJNKDNOFOB> DEBLCIECHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly BJGPALKLGOJ<DLEPDHPKPHM, POFPAJGJCMO> PBMEPIMLGIE;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public DLMKLLKNKBG LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x907F970", Offset = "0x907DF70", VA = "0x18907F970", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EPJNKDNOFOB LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x907FA30", Offset = "0x907E030", VA = "0x18907FA30", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public POFPAJGJCMO LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x907F9D0", Offset = "0x907DFD0", VA = "0x18907F9D0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool AMKGHBKHKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xC18890", Offset = "0xC16E90", VA = "0x180C18890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x907FC00", Offset = "0x907E200", VA = "0x18907FC00")]
	public GGHEOCNAHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x907F410", Offset = "0x907DA10", VA = "0x18907F410", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x907F500", Offset = "0x907DB00", VA = "0x18907F500", Slot = "4")]
	public HELGAKOMGEN HKHBIEMOHAC(BGGCMEGDEOC CDDIADBJAOB)
	{
		return default(HELGAKOMGEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x907F500", Offset = "0x907DB00", VA = "0x18907F500", Slot = "5")]
	public HELGAKOMGEN HKHBIEMOHAC(BGGCMEGDEOC CDDIADBJAOB, bool NDCFGKJIFDP)
	{
		return default(HELGAKOMGEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x907F3B0", Offset = "0x907D9B0", VA = "0x18907F3B0", Slot = "6")]
	public void BNHMMBJGHCD(HELGAKOMGEN BOCNDANOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x907F7E0", Offset = "0x907DDE0", VA = "0x18907F7E0", Slot = "7")]
	public void KEPNHKCKLPD(HELGAKOMGEN BOCNDANOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x907F130", Offset = "0x907D730", VA = "0x18907F130", Slot = "8")]
	public LEFLGOLACFG ABIAJMNMDCK(HELGAKOMGEN BOCNDANOLJJ, AEDDAMMOMOG CDDIADBJAOB)
	{
		return default(LEFLGOLACFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x907F5A0", Offset = "0x907DBA0", VA = "0x18907F5A0", Slot = "9")]
	public LEFLGOLACFG HLDNAMJAAJB(HELGAKOMGEN BOCNDANOLJJ, GHJEGHHKFLP CDDIADBJAOB)
	{
		return default(LEFLGOLACFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x907F6E0", Offset = "0x907DCE0", VA = "0x18907F6E0", Slot = "11")]
	public void HPANLJEGOLH(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x907F4A0", Offset = "0x907DAA0", VA = "0x18907F4A0", Slot = "10")]
	public void HABPOHHHMFI(LEFLGOLACFG KOJIMAFGDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x907F860", Offset = "0x907DE60", VA = "0x18907F860", Slot = "20")]
	public IEnumerable<Renderer> LHJLFLINPBD(HELGAKOMGEN BOCNDANOLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x907FAF0", Offset = "0x907E0F0", VA = "0x18907FAF0", Slot = "12")]
	public DLEPDHPKPHM POIPAFHJKKG(APMAMGEENID CDDIADBJAOB)
	{
		return default(DLEPDHPKPHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x907F770", Offset = "0x907DD70", VA = "0x18907F770", Slot = "14")]
	public void JDBGLAIHBID(DLEPDHPKPHM MHEKKPNBJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x907F310", Offset = "0x907D910", VA = "0x18907F310", Slot = "16")]
	public Task BBBKEKHLLIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x907F8D0", Offset = "0x907DED0", VA = "0x18907F8D0", Slot = "17")]
	public Task LJPLFHBOPFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x907F270", Offset = "0x907D870", VA = "0x18907F270", Slot = "18")]
	public Task AHJMCEPKHFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x29F92C0", Offset = "0x29F78C0", VA = "0x1829F92C0", Slot = "19")]
	public void AIBJECCLJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x907FA90", Offset = "0x907E090", VA = "0x18907FA90", Slot = "13")]
	public void PHNCPKILALK(DLEPDHPKPHM MHEKKPNBJKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KGLMAOAKGPI
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool MDOMKCMONAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material IHDJNAPIPNA();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material PMLMGMPGNGH();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material KDCMLPJEKHJ();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MLEJHKMMAOP(IDOKBCEFAKB HPKPCHHDKMN);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HFIMHAKBIMN(FBDPDFJNLFK IGDGNOPNECP);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AIMIGPAINFE(GameObject MPIDDJPOOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BBFHBMCMPKA(GameObject MPIDDJPOOMJ, bool JHIIJHCCFPH);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class IMAFBNPFAME
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static KGLMAOAKGPI MFNKIFOCMAO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool MDOMKCMONAF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9081D30", Offset = "0x9080330", VA = "0x189081D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x9081EC0", Offset = "0x90804C0", VA = "0x189081EC0")]
	public static void KOFBAMFHELP(KGLMAOAKGPI HMIDMANONEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x9081E00", Offset = "0x9080400", VA = "0x189081E00")]
	public static Material IHDJNAPIPNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x907D260", Offset = "0x907B860", VA = "0x18907D260")]
	public static Material PMLMGMPGNGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9081E60", Offset = "0x9080460", VA = "0x189081E60")]
	public static Material KDCMLPJEKHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9081F20", Offset = "0x9080520", VA = "0x189081F20")]
	public static int MLEJHKMMAOP(IDOKBCEFAKB HPKPCHHDKMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x9081D90", Offset = "0x9080390", VA = "0x189081D90")]
	public static int HFIMHAKBIMN(FBDPDFJNLFK IGDGNOPNECP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x9081B60", Offset = "0x9080160", VA = "0x189081B60")]
	public static void AIMIGPAINFE(GameObject MPIDDJPOOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x9081C40", Offset = "0x9080240", VA = "0x189081C40")]
	public static void BBFHBMCMPKA(GameObject MPIDDJPOOMJ, bool JHIIJHCCFPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class POFPAJGJCMO : PNBHLCAGLCB
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OHPGMJOEAJK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public POFPAJGJCMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public OHPGMJOEAJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x908DE40", Offset = "0x908C440", VA = "0x18908DE40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x908DB20", Offset = "0x908C120", VA = "0x18908DB20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x908DAD0", Offset = "0x908C0D0", VA = "0x18908DAD0")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x908DDF0", Offset = "0x908C3F0", VA = "0x18908DDF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x908DD40", Offset = "0x908C340", VA = "0x18908DD40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x908DD40", Offset = "0x908C340", VA = "0x18908DD40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly APMAMGEENID MCECLDJHGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LGMGMBGHLBI EEENMBAJFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private KEDBGFKLMPH MBOEILNMIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<EJGLPIEGMAM> KPMGDMDNCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private List<EJGLPIEGMAM> OBAFHEOMDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private GameObject CEAMMHJOFFA;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x908E630", Offset = "0x908CC30", VA = "0x18908E630")]
	public static POFPAJGJCMO GCMBKDELCNF(APMAMGEENID CDDIADBJAOB, LGMGMBGHLBI EEENMBAJFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x908F270", Offset = "0x908D870", VA = "0x18908F270")]
	private POFPAJGJCMO(APMAMGEENID CDDIADBJAOB, LGMGMBGHLBI EEENMBAJFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x908DF50", Offset = "0x908C550", VA = "0x18908DF50")]
	public void ELCJDKMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x908DED0", Offset = "0x908C4D0", VA = "0x18908DED0")]
	[IteratorStateMachine(typeof(OHPGMJOEAJK))]
	public IEnumerable<Renderer> BGMOFIAJLBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x908E780", Offset = "0x908CD80", VA = "0x18908E780", Slot = "4")]
	public void GIGKCKAEPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x908F240", Offset = "0x908D840", VA = "0x18908F240")]
	private void OBCNKFGAEPC(Vector3 IAJPGBLEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x908E3E0", Offset = "0x908C9E0", VA = "0x18908E3E0")]
	public void FPGILMIKMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EJGLPIEGMAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct GBOHOFDFMHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LDDJPFHOBHE EALHJPLIMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public ACLDACCHLEI HEJFPKAFFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int JIHCCNKIJNK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GCHNINOMODB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public EJGLPIEGMAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public PEADBPGCBOF lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public List<GBOHOFDFMHL> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public GKMCCFCPGAH combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GCHNINOMODB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x907F0D0", Offset = "0x907D6D0", VA = "0x18907F0D0")]
		internal JobHandle KJLMOGFJHPI()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x907F0A0", Offset = "0x907D6A0", VA = "0x18907F0A0")]
		internal void ICKGOIOHGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x907EF30", Offset = "0x907D530", VA = "0x18907EF30")]
		internal void EJPDBJONMCG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private int[] JPDOAFDMBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private JIOGOAEGDCC IFLHPHPPAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static Matrix4x4 CILKCAMPPBD;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh PHFGECIDFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NMNACDAMGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x907E490", Offset = "0x907CA90", VA = "0x18907E490")]
	public void JBELKHEGJDA(List<ACLDACCHLEI> PCMGCCPDBPB, Matrix4x4[] EHLLMHIBMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x907D9F0", Offset = "0x907BFF0", VA = "0x18907D9F0")]
	public static List<EJGLPIEGMAM> CEAHGFMKGJD(List<DLMKLLKNKBG> ONGFFANPFEG, PEADBPGCBOF OCNFNIGMAEF, Bounds KMJIOHGPLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x907E120", Offset = "0x907C720", VA = "0x18907E120")]
	private JobHandle IIFFPNGLKCF(GKMCCFCPGAH JGBHFLJFKNK, int HDHJMLGDJCC, int PAHLOFNIDEF, PEADBPGCBOF OCNFNIGMAEF, List<GBOHOFDFMHL> HNAAAJHDLOO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x907E680", Offset = "0x907CC80", VA = "0x18907E680")]
	private void LOJIMFNCFCI(List<GBOHOFDFMHL> HNAAAJHDLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x907E900", Offset = "0x907CF00", VA = "0x18907E900")]
	private EJGLPIEGMAM(List<GBOHOFDFMHL> HNAAAJHDLOO, int HDHJMLGDJCC, int PAHLOFNIDEF, PEADBPGCBOF OCNFNIGMAEF, Bounds KMJIOHGPLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x907E080", Offset = "0x907C680", VA = "0x18907E080", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MaterialPropertyBlock MBMJCJMHIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private EJGLPIEGMAM KNHPHEPPGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<ACLDACCHLEI> DNOKDGOLJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private RenderTexture KDPAIHHPLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private ComputeBuffer EBJMDNDMPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private ComputeShader KJGAIGPKOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Matrix4x4[] AHNCJDMEGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int OCMFKCNAGBB;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer MJALDEFIJPP
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int MANNALJLDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x90901E0", Offset = "0x908E7E0", VA = "0x1890901E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x908F510", Offset = "0x908DB10", VA = "0x18908F510")]
		public static List<SkinnedShapeRenderer> Create(GameObject BOCNDANOLJJ, List<EJGLPIEGMAM> CBLFOFKBKJF, List<ACLDACCHLEI> DNOKDGOLJFF, Material PFHPGDKJCCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x908F7A0", Offset = "0x908DDA0", VA = "0x18908F7A0")]
		public void Init(EJGLPIEGMAM KNHPHEPPGOL, List<ACLDACCHLEI> DNOKDGOLJFF, Material PFHPGDKJCCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9090140", Offset = "0x908E740", VA = "0x189090140")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x90900A0", Offset = "0x908E6A0", VA = "0x1890900A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9090060", Offset = "0x908E660", VA = "0x189090060")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x908FFA0", Offset = "0x908E5A0", VA = "0x18908FFA0")]
		private void OIEOFNIHMCE(ScriptableRenderContext JIFPJFGEAIK, Camera[] LECIJIFIMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x908FC30", Offset = "0x908E230", VA = "0x18908FC30")]
		private void JBELKHEGJDA(CommandBuffer DNEIOFKKGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x9090220", Offset = "0x908E820", VA = "0x189090220")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
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
