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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8061B20", Offset = "0x8060F20", VA = "0x188061B20", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x80670F0", Offset = "0x80664F0", VA = "0x1880670F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LHODCLDBEKK : GFODLDDLLPB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte MBBKCIKJKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] MEHCCGGOKAF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PMDDAGLHCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB8DA00", Offset = "0xB8CE00", VA = "0x180B8DA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KGHLIBCHGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC15360", Offset = "0xC14760", VA = "0x180C15360", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDBE660", Offset = "0xDBDA60", VA = "0x180DBE660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JMCJLBGIGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDEF010", Offset = "0xDEE410", VA = "0x180DEF010", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1091010", Offset = "0x1090410", VA = "0x181091010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JAKMMKDBCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB5DB00", Offset = "0xB5CF00", VA = "0x180B5DB00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB5DB10", Offset = "0xB5CF10", VA = "0x180B5DB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> BBFGLENBHEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8061510", Offset = "0x8060910", VA = "0x188061510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> EMKONNCFPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8061260", Offset = "0x8060660", VA = "0x188061260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject JMIAMIHOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x969460", Offset = "0x968860", VA = "0x180969460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte BPOEFBPDNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8061210", Offset = "0x8060610", VA = "0x188061210", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x80616B0", Offset = "0x8060AB0", VA = "0x1880616B0")]
	public LHODCLDBEKK(List<PKEOOIJCENC> GBNGDMINEJL, List<PKEOOIJCENC> IFLPJMFEMJB, List<ANJIJJGNKJL> LKGFMADIEBG, Material GIEDFKFHBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8061290", Offset = "0x8060690", VA = "0x188061290")]
	private int KOMNDCOPLDE(List<PKEOOIJCENC> GFBBPBMKJOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80613B0", Offset = "0x80607B0", VA = "0x1880613B0")]
	private void LLEEDFDNPPH(int OPAMIENFAPI, bool CJIJMMBOCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8061560", Offset = "0x8060960", VA = "0x188061560")]
	public void NNMKHHIOFAH(Vector3 EPBKMLAGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8061110", Offset = "0x8060510", VA = "0x188061110", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80610D0", Offset = "0x80604D0", VA = "0x1880610D0")]
	public void DOCJOJMCMNA(Transform HGGKBABEJOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DGPMOENBFJK : LHEMOFOIEIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class CLPCEFLOJGP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DGPMOENBFJK <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public CLPCEFLOJGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8058450", Offset = "0x8057850", VA = "0x188058450", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8057E40", Offset = "0x8057240", VA = "0x188057E40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8057DF0", Offset = "0x80571F0", VA = "0x188057DF0")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8057DA0", Offset = "0x80571A0", VA = "0x188057DA0")]
		private void GADEEDGNJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8057D50", Offset = "0x8057150", VA = "0x188057D50")]
		private void ECNNCPAJLDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8058400", Offset = "0x8057800", VA = "0x188058400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8058350", Offset = "0x8057750", VA = "0x188058350", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8058350", Offset = "0x8057750", VA = "0x188058350", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class CJHCMJLELCI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DGPMOENBFJK <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public CJHCMJLELCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8057C20", Offset = "0x8057020", VA = "0x188057C20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80577B0", Offset = "0x8056BB0", VA = "0x1880577B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8057760", Offset = "0x8056B60", VA = "0x188057760")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8057710", Offset = "0x8056B10", VA = "0x188057710")]
		private void GADEEDGNJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8057BD0", Offset = "0x8056FD0", VA = "0x188057BD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8057B20", Offset = "0x8056F20", VA = "0x188057B20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8057B20", Offset = "0x8056F20", VA = "0x188057B20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BLGBNPJNFFP GIODPLCOFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<CBBGPDAGOGB> FFJJJBEKFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> COHALNJOPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer FPAJPOLPGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool HGNHOOKJNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool NKHFLDIJHIH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<IPGEDPACKLG> MOMNJLCEDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ADKGJPFCHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8059990", Offset = "0x8058D90", VA = "0x188059990", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ANJIJJGNKJL PEGAHLJGGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x80599D0", Offset = "0x8058DD0", VA = "0x1880599D0", Slot = "8")]
		get
		{
			return default(ANJIJJGNKJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> HDNCBHBLPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x96A710", Offset = "0x969B10", VA = "0x18096A710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8059170", Offset = "0x8058570", VA = "0x188059170")]
	private bool JNOMHNHNIME(CBBGPDAGOGB JEMGJFMDIND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8059F80", Offset = "0x8059380", VA = "0x188059F80")]
	private static bool PMFMEAIFBEE(CBBGPDAGOGB JEMGJFMDIND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8059FA0", Offset = "0x80593A0", VA = "0x188059FA0")]
	public DGPMOENBFJK(BLGBNPJNFFP MJFOKKFMONL, bool HBCMPNAMACH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8058930", Offset = "0x8057D30", VA = "0x188058930", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8059190", Offset = "0x8058590", VA = "0x188059190")]
	public void KAAHFJDOOLK(CBBGPDAGOGB JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8059BB0", Offset = "0x8058FB0", VA = "0x188059BB0")]
	public void PBIACPFCCPC(CBBGPDAGOGB JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8058B20", Offset = "0x8057F20", VA = "0x188058B20", Slot = "4")]
	public void GDDHOJIPIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8059D10", Offset = "0x8059110", VA = "0x188059D10")]
	public void PCKKFECIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8058770", Offset = "0x8057B70", VA = "0x188058770")]
	private void DHGMMDJGPBG(List<CBBGPDAGOGB> FFJJJBEKFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8059A90", Offset = "0x8058E90", VA = "0x188059A90")]
	private static Material ONFGFGHMFOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x80586C0", Offset = "0x8057AC0", VA = "0x1880586C0")]
	private void DHGMMDJGPBG(CBBGPDAGOGB JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8059020", Offset = "0x8058420", VA = "0x188059020")]
	private void GEGOIIODEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x80593E0", Offset = "0x80587E0", VA = "0x1880593E0")]
	public void LHPLMBPBKNM(bool GHKFHELONJK, bool FEBGKNNHEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8059AF0", Offset = "0x8058EF0", VA = "0x188059AF0")]
	protected void PAMJNBADHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8058640", Offset = "0x8057A40", VA = "0x188058640")]
	public void BCAHDBHNLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80590F0", Offset = "0x80584F0", VA = "0x1880590F0")]
	[IteratorStateMachine(typeof(CLPCEFLOJGP))]
	public IEnumerable<Renderer> IEILCOMPNGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8059360", Offset = "0x8058760", VA = "0x188059360")]
	[IteratorStateMachine(typeof(CJHCMJLELCI))]
	public IEnumerable<Renderer> KGDEPGIGFBO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class IFDJGNIFHHE : CBBGPDAGOGB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct MKHMLOILOFO : HAMNGLMBBJH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OKOIGPENJNE HLHLPCAMLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle EJAJPPCPDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MKBFCKIBLPC NBJDMIBGICM;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x80630C0", Offset = "0x80624C0", VA = "0x1880630C0")]
		public MKHMLOILOFO(OKOIGPENJNE HLHLPCAMLJN, JobHandle EJAJPPCPDCM, MKBFCKIBLPC NBJDMIBGICM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8063090", Offset = "0x8062490", VA = "0x188063090", Slot = "4")]
		public OKOIGPENJNE JGMHMMHEKDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8063040", Offset = "0x8062440", VA = "0x188063040", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly OMEBILIEOAO HEDKDOAFOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float BGNFKEPIOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 EGHOPEIPLPL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 MGLOMDGPPNE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x805DC60", Offset = "0x805D060", VA = "0x18805DC60", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x805EB50", Offset = "0x805DF50", VA = "0x18805EB50")]
	public IFDJGNIFHHE(DGPMOENBFJK HAIKBOLEOOP, OMEBILIEOAO MJFOKKFMONL, bool HBCMPNAMACH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "18")]
	public override bool IMHELJHPPDG(ANJIJJGNKJL HAIKBOLEOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x805E980", Offset = "0x805DD80", VA = "0x18805E980", Slot = "19")]
	public override int KOMNDCOPLDE(JLKBKLGADML AKKLJPLLNIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x805DD80", Offset = "0x805D180", VA = "0x18805DD80", Slot = "20")]
	public override int FDKDAJHLDFK(JLKBKLGADML AKKLJPLLNIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x805E540", Offset = "0x805D940", VA = "0x18805E540", Slot = "21")]
	public override EPLOOFBMDBN IBPNCDEBOAE()
	{
		return default(EPLOOFBMDBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xB0B7F0", Offset = "0xB0ABF0", VA = "0x180B0B7F0", Slot = "22")]
	public override float ALJHELHIICJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x805DF50", Offset = "0x805D350", VA = "0x18805DF50", Slot = "23")]
	public override void GCHMPCJBLLH(JLKBKLGADML AKKLJPLLNIC, LBELKFKMIMK CNOEOJELLFI, int PILCDAKKLEI = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x805D9E0", Offset = "0x805CDE0", VA = "0x18805D9E0", Slot = "24")]
	public override ANJIJJGNKJL APOELNNLKOH()
	{
		return default(ANJIJJGNKJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x805DAB0", Offset = "0x805CEB0", VA = "0x18805DAB0", Slot = "26")]
	public override KNKIIAALNID DAMJGICHFEJ()
	{
		return default(KNKIIAALNID);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x805D220", Offset = "0x805C620", VA = "0x18805D220", Slot = "27")]
	public override HAMNGLMBBJH AAKCEMIBGIP(JLKBKLGADML AKKLJPLLNIC, JobHandle EJAJPPCPDCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface JOIEPDNOAMM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DGPMOENBFJK BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CBBGPDAGOGB BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MFJIIBKCBCN BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class ALMOAMOPBNH : FKAMLBHGFOI, IDisposable, JOIEPDNOAMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HIEJOFKAFLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ALMOAMOPBNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x805CC60", Offset = "0x805C060", VA = "0x18805CC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x805D1C0", Offset = "0x805C5C0", VA = "0x18805D1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly AACEAIAOALM<AKCJCIIMEDH, DGPMOENBFJK> ALKOAEMBAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly AACEAIAOALM<NPNDLLJKHLE, CBBGPDAGOGB> FFJJJBEKFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly AACEAIAOALM<DODOBBJGFOD, MFJIIBKCBCN> HKJPNAFNCJO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DGPMOENBFJK BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8054230", Offset = "0x8053630", VA = "0x188054230", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public CBBGPDAGOGB BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8054290", Offset = "0x8053690", VA = "0x188054290", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MFJIIBKCBCN BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x80541D0", Offset = "0x80535D0", VA = "0x1880541D0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ICNJALFIDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xCEB360", Offset = "0xCEA760", VA = "0x180CEB360", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCEB250", Offset = "0xCEA650", VA = "0x180CEB250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8055590", Offset = "0x8054990", VA = "0x188055590")]
	public ALMOAMOPBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8053900", Offset = "0x8052D00", VA = "0x188053900", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8054AD0", Offset = "0x8053ED0", VA = "0x188054AD0", Slot = "4")]
	public AKCJCIIMEDH KHBIHIAEFBP(BLGBNPJNFFP MJFOKKFMONL)
	{
		return default(AKCJCIIMEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8054AE0", Offset = "0x8053EE0", VA = "0x188054AE0", Slot = "5")]
	public AKCJCIIMEDH KHBIHIAEFBP(BLGBNPJNFFP MJFOKKFMONL, bool HBCMPNAMACH)
	{
		return default(AKCJCIIMEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8055340", Offset = "0x8054740", VA = "0x188055340", Slot = "6")]
	public void PJOMAOFCNKE(AKCJCIIMEDH HAIKBOLEOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8054D50", Offset = "0x8054150", VA = "0x188054D50", Slot = "7")]
	public void LJKCEDHHAOD(AKCJCIIMEDH HAIKBOLEOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8053440", Offset = "0x8052840", VA = "0x188053440", Slot = "8")]
	public NPNDLLJKHLE CNOHJDJGOCE(AKCJCIIMEDH HAIKBOLEOOP, DPDHDNPDHKE MJFOKKFMONL)
	{
		return default(NPNDLLJKHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8053AC0", Offset = "0x8052EC0", VA = "0x188053AC0", Slot = "9")]
	public NPNDLLJKHLE EJACKLDNAML(AKCJCIIMEDH HAIKBOLEOOP, OMEBILIEOAO MJFOKKFMONL)
	{
		return default(NPNDLLJKHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80542F0", Offset = "0x80536F0", VA = "0x1880542F0", Slot = "11")]
	public void HCMDNCOGDAF(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8053F80", Offset = "0x8053380", VA = "0x188053F80", Slot = "10")]
	public void EMCKNEJKDDO(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80552D0", Offset = "0x80546D0", VA = "0x1880552D0", Slot = "20")]
	public IEnumerable<Renderer> OJNPHIMBDOP(AKCJCIIMEDH HAIKBOLEOOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8055250", Offset = "0x8054650", VA = "0x188055250", Slot = "12")]
	public DODOBBJGFOD NDEEMECMEGC(EDLJHIFFFPK MJFOKKFMONL)
	{
		return default(DODOBBJGFOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x80547E0", Offset = "0x8053BE0", VA = "0x1880547E0", Slot = "14")]
	public void HNHICPLIDKJ(DODOBBJGFOD FEICGOKBKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8055090", Offset = "0x8054490", VA = "0x188055090", Slot = "16")]
	public Task MHCBKAPHMPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8054850", Offset = "0x8053C50", VA = "0x188054850", Slot = "17")]
	public Task IJCECJKCGFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8054A00", Offset = "0x8053E00", VA = "0x188054A00", Slot = "18")]
	[AsyncStateMachine(typeof(HIEJOFKAFLG))]
	public Task INCACHKKJJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80546F0", Offset = "0x8053AF0", VA = "0x1880546F0", Slot = "19")]
	public void HIMCACAACKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8054690", Offset = "0x8053A90", VA = "0x188054690", Slot = "13")]
	public void HEKDHBNFIJH(DODOBBJGFOD FEICGOKBKOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class JNJIECOHNEC : CBBGPDAGOGB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct LKCBMMGKJNF : HAMNGLMBBJH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private OKOIGPENJNE HLHLPCAMLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> ODPKHOFFMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle EJAJPPCPDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private ALKMKIAAKCL NBJDMIBGICM;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8061AC0", Offset = "0x8060EC0", VA = "0x188061AC0")]
		public LKCBMMGKJNF(OKOIGPENJNE HLHLPCAMLJN, NativeArray<int> ODPKHOFFMAH, JobHandle EJAJPPCPDCM, ALKMKIAAKCL NBJDMIBGICM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8061A60", Offset = "0x8060E60", VA = "0x188061A60", Slot = "4")]
		public OKOIGPENJNE JGMHMMHEKDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x80619C0", Offset = "0x8060DC0", VA = "0x1880619C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly DPDHDNPDHKE IDIBBHDGOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] ELPMHCLGHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 EGHOPEIPLPL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 PGAHADODEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x805F740", Offset = "0x805EB40", VA = "0x18805F740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 MGLOMDGPPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x805F970", Offset = "0x805ED70", VA = "0x18805F970", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8061020", Offset = "0x8060420", VA = "0x188061020")]
	public JNJIECOHNEC(DGPMOENBFJK HAIKBOLEOOP, DPDHDNPDHKE MJFOKKFMONL, bool LJFMCCLMAJL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8060C20", Offset = "0x8060020", VA = "0x188060C20", Slot = "18")]
	public override bool IMHELJHPPDG(ANJIJJGNKJL HAIKBOLEOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8060BE0", Offset = "0x805FFE0", VA = "0x188060BE0", Slot = "21")]
	public override EPLOOFBMDBN IBPNCDEBOAE()
	{
		return default(EPLOOFBMDBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8060580", Offset = "0x805F980", VA = "0x188060580")]
	private EPLOOFBMDBN IBPNCDEBOAE(ANJIJJGNKJL HAIKBOLEOOP)
	{
		return default(EPLOOFBMDBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x805FA90", Offset = "0x805EE90", VA = "0x18805FA90")]
	private KNJJAAJAKBD DKHENEDLINB([In] UniformTRS FPENMKCJLMB, [In] float3 OHCIJMLLFKI)
	{
		return default(KNJJAAJAKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8060CF0", Offset = "0x80600F0", VA = "0x188060CF0", Slot = "19")]
	public override int KOMNDCOPLDE(JLKBKLGADML AKKLJPLLNIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x805FC90", Offset = "0x805F090", VA = "0x18805FC90", Slot = "20")]
	public override int FDKDAJHLDFK(JLKBKLGADML AKKLJPLLNIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x805F3D0", Offset = "0x805E7D0", VA = "0x18805F3D0", Slot = "22")]
	public override float ALJHELHIICJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8060DA0", Offset = "0x80601A0", VA = "0x188060DA0")]
	private int NHBIPAFGMDA(JLKBKLGADML AKKLJPLLNIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x805FD40", Offset = "0x805F140", VA = "0x18805FD40", Slot = "23")]
	public override void GCHMPCJBLLH(JLKBKLGADML AKKLJPLLNIC, LBELKFKMIMK CNOEOJELLFI, int PILCDAKKLEI = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x805F4C0", Offset = "0x805E8C0", VA = "0x18805F4C0", Slot = "24")]
	public override ANJIJJGNKJL APOELNNLKOH()
	{
		return default(ANJIJJGNKJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x805F590", Offset = "0x805E990", VA = "0x18805F590", Slot = "26")]
	public override KNKIIAALNID DAMJGICHFEJ()
	{
		return default(KNKIIAALNID);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x805EC00", Offset = "0x805E000", VA = "0x18805EC00", Slot = "27")]
	public override HAMNGLMBBJH AAKCEMIBGIP(JLKBKLGADML AKKLJPLLNIC, JobHandle EJAJPPCPDCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MPHGGPMCMHC
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBIAHCEHPPJ(OPHICPAGLCD ANONBNLNHHL, Renderer CJJNPFGBHFH, int HEFNJIFCGHM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJNCPLCNJAL(Renderer CJJNPFGBHFH, GPHMAOOCDBD IBLPGGJBLLJ, Vector3 MCJBMGDADNO, Vector3 CEPGAHEEDED, Vector3 AGACFJHPJFM, float KLAFAOEPLMC, float GHGDGFGCMAG, float JEKKFFJMHAN = -1f, [Optional] Color? MLLLJKFOPGI, [Optional] IReadOnlyList<Camera> LJOLDGCCDNE);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBEOOGCCILJ(Renderer CJJNPFGBHFH, int HEFNJIFCGHM);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LDNIPNCDDJA();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EFOGCMPNGNE(int GHLBICADIPG, MOCNBIDPOEK ANONBNLNHHL, Renderer CJJNPFGBHFH, int HEFNJIFCGHM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GCNEALGAFHC : NCIAIDEDLKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class EGAAKKFOMBL : APCOCPGHOPM<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x805A090", Offset = "0x8059490", VA = "0x18805A090")]
		public EGAAKKFOMBL(string OGOCCCFKJPG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MPHGGPMCMHC LCJIMEFJNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly JOIEPDNOAMM KEGBDBFDKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer MOKCNJIBHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EGAAKKFOMBL JOBAGHIPNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool OMHOLFNDGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer EEJNKJOCBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EGAAKKFOMBL BOJPBDJHEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool EAEIFLOPACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer OIDJAHKHDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EGAAKKFOMBL GAHIAHCILGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool CHGGKLFHHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool MPODDHPAEGG;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x96FAD0", Offset = "0x96EED0", VA = "0x18096FAD0")]
	public GCNEALGAFHC(MPHGGPMCMHC BEAPNCHBCFJ, JOIEPDNOAMM KEGBDBFDKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x805A960", Offset = "0x8059D60", VA = "0x18805A960", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x805AB10", Offset = "0x8059F10", VA = "0x18805AB10")]
	private void EMCDALEGBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x805BD90", Offset = "0x805B190", VA = "0x18805BD90", Slot = "4")]
	public void NOHCHJIMCNC(AKCJCIIMEDH HAIKBOLEOOP, MOCNBIDPOEK BCKCGEMHPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x805C0A0", Offset = "0x805B4A0", VA = "0x18805C0A0", Slot = "5")]
	public void NOHCHJIMCNC(NPNDLLJKHLE JEMGJFMDIND, MOCNBIDPOEK BCKCGEMHPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x805CB00", Offset = "0x805BF00", VA = "0x18805CB00", Slot = "6")]
	public void PPPNNGNBGIE(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x805A4D0", Offset = "0x80598D0", VA = "0x18805A4D0", Slot = "7")]
	public void APHJCKJIFNO(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x805BAE0", Offset = "0x805AEE0", VA = "0x18805BAE0", Slot = "24")]
	public void LOJNBKFEPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xF262A0", Offset = "0xF256A0", VA = "0x180F262A0", Slot = "8")]
	public void PKNIALHLKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x805AD80", Offset = "0x805A180", VA = "0x18805AD80", Slot = "9")]
	public void FGJHBLNOFPK(MOCNBIDPOEK BCKCGEMHPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x805B450", Offset = "0x805A850", VA = "0x18805B450", Slot = "10")]
	public void GJAPAAFFKMF(AKCJCIIMEDH HAIKBOLEOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x805B0F0", Offset = "0x805A4F0", VA = "0x18805B0F0", Slot = "11")]
	public void GJAPAAFFKMF(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x805A400", Offset = "0x8059800", VA = "0x18805A400", Slot = "12")]
	public void AJLIBEPJKCP(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x805AEF0", Offset = "0x805A2F0", VA = "0x18805AEF0", Slot = "13")]
	public void FKPBGHFPLAE(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x805A620", Offset = "0x8059A20", VA = "0x18805A620")]
	private void BJJOELNBJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x11878B0", Offset = "0x1186CB0", VA = "0x1811878B0", Slot = "14")]
	public void IEJAIBIFINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x805A2E0", Offset = "0x80596E0", VA = "0x18805A2E0", Slot = "15")]
	public void ADLHKJOFDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x805B730", Offset = "0x805AB30", VA = "0x18805B730", Slot = "16")]
	public void HIPJBGHHGKE(AKCJCIIMEDH HAIKBOLEOOP, OPHICPAGLCD ANONBNLNHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x805BA10", Offset = "0x805AE10", VA = "0x18805BA10", Slot = "17")]
	public void HLGMGMJHNIH(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x805A890", Offset = "0x8059C90", VA = "0x18805A890", Slot = "18")]
	public void BNOCODEDENH(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xB9B6B0", Offset = "0xB9AAB0", VA = "0x180B9B6B0", Slot = "19")]
	public void EHENCFPJEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x805AFC0", Offset = "0x805A3C0", VA = "0x18805AFC0", Slot = "20")]
	public void GGJDHNKMNCP(OPHICPAGLCD ANONBNLNHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x805BB20", Offset = "0x805AF20", VA = "0x18805BB20")]
	private void NJHELNDPNJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x805C2C0", Offset = "0x805B6C0", VA = "0x18805C2C0", Slot = "21")]
	public void ODLHNDOMIFJ(AKCJCIIMEDH HAIKBOLEOOP, Vector3 MCJBMGDADNO, Vector3 CEPGAHEEDED, Vector3 AGACFJHPJFM, float KLAFAOEPLMC, float GHGDGFGCMAG, IReadOnlyList<Camera> NFKPNJENAHI, GPHMAOOCDBD IBLPGGJBLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x805C680", Offset = "0x805BA80", VA = "0x18805C680", Slot = "22")]
	public void ODLHNDOMIFJ(DODOBBJGFOD FEICGOKBKOM, Vector3 MCJBMGDADNO, Vector3 CEPGAHEEDED, Vector3 AGACFJHPJFM, float KLAFAOEPLMC, float GHGDGFGCMAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class CBBGPDAGOGB : KHBALLLOIMA, IPGEDPACKLG, CBOPLDMAPOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly DGPMOENBFJK JMIAMIHOFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int JMIKDDPPJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds BIBKAAFHKOA;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds LFMCDGOGEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x80576F0", Offset = "0x8056AF0", VA = "0x1880576F0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool NKHFLDIJHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC52B90", Offset = "0xC51F90", VA = "0x180C52B90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC52BC0", Offset = "0xC51FC0", VA = "0x180C52BC0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 MGLOMDGPPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MELLOCBOCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xACC550", Offset = "0xACB950", VA = "0x180ACC550", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public HMFBONHMKGH KOBPBHMLBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x96A710", Offset = "0x969B10", VA = "0x18096A710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EACJLOHIJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xD93E60", Offset = "0xD93260", VA = "0x180D93E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	protected CBBGPDAGOGB(DGPMOENBFJK HAIKBOLEOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8057560", Offset = "0x8056960", VA = "0x188057560", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "18")]
	public virtual bool IMHELJHPPDG(ANJIJJGNKJL HAIKBOLEOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8057550", Offset = "0x8056950", VA = "0x188057550", Slot = "10")]
	public int DGHGFLJGHLC(int JBKBGCIEHAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int KOMNDCOPLDE(JLKBKLGADML AKKLJPLLNIC);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int FDKDAJHLDFK(JLKBKLGADML AKKLJPLLNIC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract EPLOOFBMDBN IBPNCDEBOAE();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float ALJHELHIICJ();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void GCHMPCJBLLH(JLKBKLGADML AKKLJPLLNIC, LBELKFKMIMK CNOEOJELLFI, int PILCDAKKLEI = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract ANJIJJGNKJL APOELNNLKOH();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80576C0", Offset = "0x8056AC0", VA = "0x1880576C0", Slot = "13")]
	public Hash128 LLNOGEDFBGH(int AKKLJPLLNIC)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract KNKIIAALNID DAMJGICHFEJ();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract HAMNGLMBBJH AAKCEMIBGIP(JLKBKLGADML AKKLJPLLNIC, JobHandle EJAJPPCPDCM);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8057520", Offset = "0x8056920", VA = "0x188057520", Slot = "12")]
	public HAMNGLMBBJH BCHPEGEPLLO(int AKKLJPLLNIC)
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
		[Cpp2IlInjected.Address(RVA = "0x8065C60", Offset = "0x8065060", VA = "0x188065C60")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BPDLNMNOLNI
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NGCMOFCGLHJ : IEnumerable<PFMMKFKJGEG>, IEnumerable, IEnumerator<PFMMKFKJGEG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private PFMMKFKJGEG <>2__current;

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
		private PFMMKFKJGEG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public NGCMOFCGLHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8063120", Offset = "0x8062520", VA = "0x188063120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8063290", Offset = "0x8062690", VA = "0x188063290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x80631F0", Offset = "0x80625F0", VA = "0x1880631F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PFMMKFKJGEG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x80631F0", Offset = "0x80625F0", VA = "0x1880631F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static PFMMKFKJGEG[][] PCNIEHHHDGA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static EGOCLFNMCCF ECEEENMKMFH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig HMCPOOODJEC;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader IBIJKBOKCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8055CB0", Offset = "0x80550B0", VA = "0x188055CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer PCLMCFBCHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8055BD0", Offset = "0x8054FD0", VA = "0x188055BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8056EF0", Offset = "0x80562F0", VA = "0x188056EF0")]
	[BOHPIAAADDL]
	internal static void OBBALIPJEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8056FD0", Offset = "0x80563D0", VA = "0x188056FD0")]
	public static Mesh PHJKBEGAKOD(HFCKMPNMIEL GGAFKFLEJMK, int AKKLJPLLNIC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8056CE0", Offset = "0x80560E0", VA = "0x188056CE0")]
	public static int LFHMFEKOHCP(HFCKMPNMIEL GGAFKFLEJMK, int AKKLJPLLNIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8056CF0", Offset = "0x80560F0", VA = "0x188056CF0")]
	public static EGOCLFNMCCF NNDOHJCGCGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8055C30", Offset = "0x8055030", VA = "0x188055C30")]
	[IteratorStateMachine(typeof(NGCMOFCGLHJ))]
	private static IEnumerable<PFMMKFKJGEG> EHEFDFPAGDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8055ED0", Offset = "0x80552D0", VA = "0x188055ED0")]
	public static PFMMKFKJGEG KOILIAENKKF(HFCKMPNMIEL GGAFKFLEJMK, int AKKLJPLLNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8055C90", Offset = "0x8055090", VA = "0x188055C90")]
	public static bool FOBDOPADFGI(this HFCKMPNMIEL GGAFKFLEJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8055A10", Offset = "0x8054E10", VA = "0x188055A10")]
	public static void AIGJPNDKOHB(HFCKMPNMIEL GGAFKFLEJMK, float3 OIPNDEBNICF, [Out] ACNMBINJMCH BPPFJFOHMGN, [Out] float3 DKAMFONMIEI, [Out] float PKIKFOPIINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8057070", Offset = "0x8056470", VA = "0x188057070")]
	public static void PJNJNGMNKPL(Vector3 OIPNDEBNICF, HFCKMPNMIEL GGAFKFLEJMK, [Out] Vector3 DKAMFONMIEI, [Out] float PKIKFOPIINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8055BC0", Offset = "0x8054FC0", VA = "0x188055BC0")]
	[PODNEJJPPCP(0)]
	[HKOIOMMKCJI(PPIOLDHAHGF.ExitingPlayMode, 0)]
	private static void EFBFPIBAFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8055D10", Offset = "0x8055110", VA = "0x188055D10")]
	[PODNEJJPPCP(0)]
	[HKOIOMMKCJI(PPIOLDHAHGF.ExitingPlayMode, 0)]
	private static void KFOBEAJFKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class NHEJKOANNLD : FKAMLBHGFOI, IDisposable, JOIEPDNOAMM
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly AACEAIAOALM<AKCJCIIMEDH, DGPMOENBFJK> ALKOAEMBAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AACEAIAOALM<NPNDLLJKHLE, CBBGPDAGOGB> FFJJJBEKFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly AACEAIAOALM<DODOBBJGFOD, MFJIIBKCBCN> HKJPNAFNCJO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public DGPMOENBFJK BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8063650", Offset = "0x8062A50", VA = "0x188063650", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public CBBGPDAGOGB BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8063710", Offset = "0x8062B10", VA = "0x188063710", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public MFJIIBKCBCN BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x80636B0", Offset = "0x8062AB0", VA = "0x1880636B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ICNJALFIDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xCEB360", Offset = "0xCEA760", VA = "0x180CEB360", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xCEB250", Offset = "0xCEA650", VA = "0x180CEB250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8063DA0", Offset = "0x80631A0", VA = "0x188063DA0")]
	public NHEJKOANNLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8063420", Offset = "0x8062820", VA = "0x188063420", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8063A10", Offset = "0x8062E10", VA = "0x188063A10", Slot = "4")]
	public AKCJCIIMEDH KHBIHIAEFBP(BLGBNPJNFFP MJFOKKFMONL)
	{
		return default(AKCJCIIMEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8063A10", Offset = "0x8062E10", VA = "0x188063A10", Slot = "5")]
	public AKCJCIIMEDH KHBIHIAEFBP(BLGBNPJNFFP MJFOKKFMONL, bool HBCMPNAMACH)
	{
		return default(AKCJCIIMEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8063CC0", Offset = "0x80630C0", VA = "0x188063CC0", Slot = "6")]
	public void PJOMAOFCNKE(AKCJCIIMEDH HAIKBOLEOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8063AB0", Offset = "0x8062EB0", VA = "0x188063AB0", Slot = "7")]
	public void LJKCEDHHAOD(AKCJCIIMEDH HAIKBOLEOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x80632E0", Offset = "0x80626E0", VA = "0x1880632E0", Slot = "8")]
	public NPNDLLJKHLE CNOHJDJGOCE(AKCJCIIMEDH HAIKBOLEOOP, DPDHDNPDHKE MJFOKKFMONL)
	{
		return default(NPNDLLJKHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x80634B0", Offset = "0x80628B0", VA = "0x1880634B0", Slot = "9")]
	public NPNDLLJKHLE EJACKLDNAML(AKCJCIIMEDH HAIKBOLEOOP, OMEBILIEOAO MJFOKKFMONL)
	{
		return default(NPNDLLJKHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8063770", Offset = "0x8062B70", VA = "0x188063770", Slot = "11")]
	public void HCMDNCOGDAF(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x80635F0", Offset = "0x80629F0", VA = "0x1880635F0", Slot = "10")]
	public void EMCKNEJKDDO(NPNDLLJKHLE JEMGJFMDIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8063C50", Offset = "0x8063050", VA = "0x188063C50", Slot = "20")]
	public IEnumerable<Renderer> OJNPHIMBDOP(AKCJCIIMEDH HAIKBOLEOOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8063BD0", Offset = "0x8062FD0", VA = "0x188063BD0", Slot = "12")]
	public DODOBBJGFOD NDEEMECMEGC(EDLJHIFFFPK MJFOKKFMONL)
	{
		return default(DODOBBJGFOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8063860", Offset = "0x8062C60", VA = "0x188063860", Slot = "14")]
	public void HNHICPLIDKJ(DODOBBJGFOD FEICGOKBKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8063B30", Offset = "0x8062F30", VA = "0x188063B30", Slot = "16")]
	public Task MHCBKAPHMPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x80638D0", Offset = "0x8062CD0", VA = "0x1880638D0", Slot = "17")]
	public Task IJCECJKCGFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8063970", Offset = "0x8062D70", VA = "0x188063970", Slot = "18")]
	public Task INCACHKKJJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x24BFB60", Offset = "0x24BEF60", VA = "0x1824BFB60", Slot = "19")]
	public void HIMCACAACKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8063800", Offset = "0x8062C00", VA = "0x188063800", Slot = "13")]
	public void HEKDHBNFIJH(DODOBBJGFOD FEICGOKBKOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BAGKAFABCAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool APPNMMKKBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material JBGINGPPKCB();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material ONFGFGHMFOB();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material MLJAPFNBNHI();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NJAFCEEKNKO(KJLMKLABEMK NPJNOPHGDLF);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LAFGHONNIGM(KOCPEJPPMDN LBPCIPMFHLK);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LFPOFIFAGAP(GameObject NBAMGPFDMIB);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ALBPNJKFAGJ(GameObject NBAMGPFDMIB, bool ONKLHDKJGPC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class NKIGGFDOPLE
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static BAGKAFABCAJ FBFIKJCNBGP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool APPNMMKKBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8064440", Offset = "0x8063840", VA = "0x188064440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8064240", Offset = "0x8063640", VA = "0x188064240")]
	public static void DENCLCAJOKB(BAGKAFABCAJ GLFILGKIHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8064290", Offset = "0x8063690", VA = "0x188064290")]
	public static Material JBGINGPPKCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8059A90", Offset = "0x8058E90", VA = "0x188059A90")]
	public static Material ONFGFGHMFOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x80644A0", Offset = "0x80638A0", VA = "0x1880644A0")]
	public static Material MLJAPFNBNHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8064500", Offset = "0x8063900", VA = "0x188064500")]
	public static int NJAFCEEKNKO(KJLMKLABEMK NPJNOPHGDLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x80642F0", Offset = "0x80636F0", VA = "0x1880642F0")]
	public static int LAFGHONNIGM(KOCPEJPPMDN LBPCIPMFHLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8064360", Offset = "0x8063760", VA = "0x188064360")]
	public static void LFPOFIFAGAP(GameObject NBAMGPFDMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8064160", Offset = "0x8063560", VA = "0x188064160")]
	public static void ALBPNJKFAGJ(GameObject NBAMGPFDMIB, bool ONKLHDKJGPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MFJIIBKCBCN : LHEMOFOIEIL
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class PPEMHBFPOAP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public MFJIIBKCBCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xD752B0", Offset = "0xD746B0", VA = "0x180D752B0")]
		[DebuggerHidden]
		public PPEMHBFPOAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8065BD0", Offset = "0x8064FD0", VA = "0x188065BD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x80658B0", Offset = "0x8064CB0", VA = "0x1880658B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8065860", Offset = "0x8064C60", VA = "0x188065860")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8065B80", Offset = "0x8064F80", VA = "0x188065B80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8065AD0", Offset = "0x8064ED0", VA = "0x188065AD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8065AD0", Offset = "0x8064ED0", VA = "0x188065AD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly EDLJHIFFFPK GMNMCFGJFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JOIEPDNOAMM KEGBDBFDKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private LHODCLDBEKK CELHGFODINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<PKEOOIJCENC> ADOCNAEGLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<PKEOOIJCENC> NMMMGLMCAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject KNKDPCMCHON;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8062BC0", Offset = "0x8061FC0", VA = "0x188062BC0")]
	public static MFJIIBKCBCN OFKDFFFHCHB(EDLJHIFFFPK MJFOKKFMONL, JOIEPDNOAMM KEGBDBFDKDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8062F60", Offset = "0x8062360", VA = "0x188062F60")]
	private MFJIIBKCBCN(EDLJHIFFFPK MJFOKKFMONL, JOIEPDNOAMM KEGBDBFDKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8061BF0", Offset = "0x8060FF0", VA = "0x188061BF0")]
	public void AICKIPOBPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8062B40", Offset = "0x8061F40", VA = "0x188062B40")]
	[IteratorStateMachine(typeof(PPEMHBFPOAP))]
	public IEnumerable<Renderer> IEILCOMPNGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x80620A0", Offset = "0x80614A0", VA = "0x1880620A0", Slot = "4")]
	public void GDDHOJIPIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8062070", Offset = "0x8061470", VA = "0x188062070")]
	private void FINFNNLHJPO(Vector3 EPBKMLAGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8062D10", Offset = "0x8062110", VA = "0x188062D10")]
	public void PCKKFECIKBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PKEOOIJCENC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct DFHINIONNHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public LBELKFKMIMK FOFHHCFNLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public ANJIJJGNKJL NOEDAFDJMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int NHMODNICGJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FKFCGONJCGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public PKEOOIJCENC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public JLKBKLGADML lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<DFHINIONNHE> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OKOIGPENJNE combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public FKFCGONJCGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x805A280", Offset = "0x8059680", VA = "0x18805A280")]
		internal JobHandle NEJCHNJLNGK()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x805A0E0", Offset = "0x80594E0", VA = "0x18805A0E0")]
		internal void CCMBIMPLJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x805A110", Offset = "0x8059510", VA = "0x18805A110")]
		internal void GMFPKKDOMDH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] NLOGEHHJDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JOKGMIEEFIB CIHPBEHMOLC;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 KBLGEGCBFIK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh IMOIEBPDDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GBCINHEPGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9712B0", Offset = "0x9706B0", VA = "0x1809712B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x973060", Offset = "0x972460", VA = "0x180973060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8064570", Offset = "0x8063970", VA = "0x188064570")]
	public void BEGBCBPMBFI(List<ANJIJJGNKJL> DCBKBNHCHPE, Matrix4x4[] FJHCADAAALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8064B40", Offset = "0x8063F40", VA = "0x188064B40")]
	public static List<PKEOOIJCENC> GEEFBNOOFMP(List<DGPMOENBFJK> FLLCNKHHBDH, JLKBKLGADML AKKLJPLLNIC, Bounds LDBFAINHFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x80647E0", Offset = "0x8063BE0", VA = "0x1880647E0")]
	private JobHandle FIIHPCFJHJO(OKOIGPENJNE BBNIBPJJHAB, int LCPGFLACIDA, int DECGKKKBKLG, JLKBKLGADML AKKLJPLLNIC, List<DFHINIONNHE> PJCMABOIPEH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x80651D0", Offset = "0x80645D0", VA = "0x1880651D0")]
	private void OMOFNGHAKOC(List<DFHINIONNHE> PJCMABOIPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8065440", Offset = "0x8064840", VA = "0x188065440")]
	private PKEOOIJCENC(List<DFHINIONNHE> PJCMABOIPEH, int LCPGFLACIDA, int DECGKKKBKLG, JLKBKLGADML AKKLJPLLNIC, Bounds LDBFAINHFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8064750", Offset = "0x8063B50", VA = "0x188064750", Slot = "4")]
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
		private MaterialPropertyBlock NEKEFHFDFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private PKEOOIJCENC HLHLPCAMLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<ANJIJJGNKJL> LKGFMADIEBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture DCLIGJMLBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer ILDENMICFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader LJLPDHHHHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] LOBPCJPBAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int CDHKJLKLPEJ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer BHBEDMMNDGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int HDBCFKDBFDB
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8066990", Offset = "0x8065D90", VA = "0x188066990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8066030", Offset = "0x8065430", VA = "0x188066030")]
		public static List<SkinnedShapeRenderer> Create(GameObject HAIKBOLEOOP, List<PKEOOIJCENC> GFBBPBMKJOM, List<ANJIJJGNKJL> LKGFMADIEBG, Material GIEDFKFHBFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x80662C0", Offset = "0x80656C0", VA = "0x1880662C0")]
		public void Init(PKEOOIJCENC HLHLPCAMLJN, List<ANJIJJGNKJL> LKGFMADIEBG, Material GIEDFKFHBFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x80668F0", Offset = "0x8065CF0", VA = "0x1880668F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8066850", Offset = "0x8065C50", VA = "0x188066850")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8066810", Offset = "0x8065C10", VA = "0x188066810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8066750", Offset = "0x8065B50", VA = "0x188066750")]
		private void LMGOGOBHICN(ScriptableRenderContext MEBLJIBNLCL, Camera[] BDJFEHOLOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8065CC0", Offset = "0x80650C0", VA = "0x188065CC0")]
		private void BEGBCBPMBFI(CommandBuffer AMIFMKNCGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
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
