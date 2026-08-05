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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9084450", Offset = "0x9082E50", VA = "0x189084450", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x908A0F0", Offset = "0x9088AF0", VA = "0x18908A0F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DLJALPJMCKB : GLNOAJCIDHL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte DGLCMHBLKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] ICIEJKEJMMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BLNPGNJLDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FLNKNOJBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float CCLOHMEFLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x10DF360", Offset = "0x10DDD60", VA = "0x1810DF360", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x15FEFB0", Offset = "0x15FD9B0", VA = "0x1815FEFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float FCGHPLJLJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDDC030", Offset = "0xDDAA30", VA = "0x180DDC030", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDDC040", Offset = "0xDDAA40", VA = "0x180DDC040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> FIHLMIKEAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9078940", Offset = "0x9077340", VA = "0x189078940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> MEGDIFDAGJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9078BB0", Offset = "0x90775B0", VA = "0x189078BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject GLKLCNOCKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte BJNDHIBFHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9078ED0", Offset = "0x90778D0", VA = "0x189078ED0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9078F20", Offset = "0x9077920", VA = "0x189078F20")]
	public DLJALPJMCKB(List<DKBCJMNNPAO> MBIPOMCDPAF, List<DKBCJMNNPAO> BOLJMKLPCCG, List<ALEFPCAPAGF> IDHPHJINHBB, Material PJPBFBIEGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9078A90", Offset = "0x9077490", VA = "0x189078A90")]
	private int GFNMLHOEIGJ(List<DKBCJMNNPAO> PIHGOJDOLKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9078BE0", Offset = "0x90775E0", VA = "0x189078BE0")]
	private void KPHAEFIPNIJ(int HHCKNKMLEGO, bool JNNEMJKMKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9078D80", Offset = "0x9077780", VA = "0x189078D80")]
	public void OJHBMJKFGFN(Vector3 BLJMDNLILHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9078990", Offset = "0x9077390", VA = "0x189078990", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9078D40", Offset = "0x9077740", VA = "0x189078D40")]
	public void MJMIEKMKHOF(Transform MDNPBLILMCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LEPGFHMAPGB : HKHKFNBJJMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class BHBECGKPENL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LEPGFHMAPGB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public BHBECGKPENL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9076880", Offset = "0x9075280", VA = "0x189076880", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9076220", Offset = "0x9074C20", VA = "0x189076220", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x90761D0", Offset = "0x9074BD0", VA = "0x1890761D0")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9076730", Offset = "0x9075130", VA = "0x189076730")]
		private void OCOHJFDHCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9076180", Offset = "0x9074B80", VA = "0x189076180")]
		private void KOABKPNHEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9076830", Offset = "0x9075230", VA = "0x189076830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9076780", Offset = "0x9075180", VA = "0x189076780", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9076780", Offset = "0x9075180", VA = "0x189076780", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DCDLHHHCEMK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public LEPGFHMAPGB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public DCDLHHHCEMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9076F80", Offset = "0x9075980", VA = "0x189076F80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9076AC0", Offset = "0x90754C0", VA = "0x189076AC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9076A70", Offset = "0x9075470", VA = "0x189076A70")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9076E30", Offset = "0x9075830", VA = "0x189076E30")]
		private void OCOHJFDHCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9076F30", Offset = "0x9075930", VA = "0x189076F30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9076E80", Offset = "0x9075880", VA = "0x189076E80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9076E80", Offset = "0x9075880", VA = "0x189076E80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly DDAHMJKENKG EIEEKKOLFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<LMJFCIMAEOJ> DCLCADNMNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> FOJDPFPMKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer DNAEBNOKKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool HKLMIPFOFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool IGGOMHODCAG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<EGGKHJMOLHG> JKABEDNGLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CNCODGKCMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9082B50", Offset = "0x9081550", VA = "0x189082B50", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ALEFPCAPAGF LODCNPLICHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90835B0", Offset = "0x9081FB0", VA = "0x1890835B0", Slot = "8")]
		get
		{
			return default(ALEFPCAPAGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> HJONIDLAKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x9083670", Offset = "0x9082070", VA = "0x189083670")]
	private bool JDHPGAEDADP(LMJFCIMAEOJ ENDDNPPKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x90827F0", Offset = "0x90811F0", VA = "0x1890827F0")]
	private static bool ACNDEODDCOA(LMJFCIMAEOJ ENDDNPPKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9084160", Offset = "0x9082B60", VA = "0x189084160")]
	public LEPGFHMAPGB(DDAHMJKENKG BLPDDGCLNPE, bool AJPHGHDFKLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9082B90", Offset = "0x9081590", VA = "0x189082B90", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x90833E0", Offset = "0x9081DE0", VA = "0x1890833E0")]
	public void HMDNMGBNKIA(LMJFCIMAEOJ ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9083690", Offset = "0x9082090", VA = "0x189083690")]
	public void MCKODPOBNPM(LMJFCIMAEOJ ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9082E00", Offset = "0x9081800", VA = "0x189082E00", Slot = "4")]
	public void EPKKEKBGPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9082810", Offset = "0x9081210", VA = "0x189082810")]
	public void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x90837F0", Offset = "0x90821F0", VA = "0x1890837F0")]
	private void NNOAIKOCPGK(List<LMJFCIMAEOJ> DCLCADNMNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9083380", Offset = "0x9081D80", VA = "0x189083380")]
	private static Material HIKKLFCBPAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x90839B0", Offset = "0x90823B0", VA = "0x1890839B0")]
	private void NNOAIKOCPGK(LMJFCIMAEOJ ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9082A80", Offset = "0x9081480", VA = "0x189082A80")]
	private void DHMAHGOINKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x9083A60", Offset = "0x9082460", VA = "0x189083A60")]
	public void OCIMECOKPKM(bool COHINIOLDFO, bool BJPDLOCLDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9084020", Offset = "0x9082A20", VA = "0x189084020")]
	protected void OCMJNLAKEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x90840E0", Offset = "0x9082AE0", VA = "0x1890840E0")]
	public void PEFOGPBIHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x9083300", Offset = "0x9081D00", VA = "0x189083300")]
	[IteratorStateMachine(typeof(BHBECGKPENL))]
	public IEnumerable<Renderer> FBIEILKLHEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x9082D80", Offset = "0x9081780", VA = "0x189082D80")]
	[IteratorStateMachine(typeof(DCDLHHHCEMK))]
	public IEnumerable<Renderer> EDEDDFGAJKJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[BurstCompile]
internal class JNNKLLAPHDM : LMJFCIMAEOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct FMIOOHDOIJO : BAOJAHODAGC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private CIJLFCMKEEG KGGOMLADPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle EDFFJEFOFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private DAFNEBACFMA NDNGJFNKLFJ;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x907B420", Offset = "0x9079E20", VA = "0x18907B420")]
		public FMIOOHDOIJO(CIJLFCMKEEG KGGOMLADPBD, JobHandle EDFFJEFOFGN, DAFNEBACFMA NDNGJFNKLFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x907B3F0", Offset = "0x9079DF0", VA = "0x18907B3F0", Slot = "4")]
		public CIJLFCMKEEG IBGIFICHJPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x907B3A0", Offset = "0x9079DA0", VA = "0x18907B3A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public unsafe delegate void NJCHGHDINAJ([NoAlias] CBHMNJPAKOH BLJPCDFFOJP, int OJKEAFJGLAK, [In][NoAlias] UniformTRS FPHHDIIPPFE, [In][NoAlias] CMNLAHEDKFC* FLBODJDICMA);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class HFJHIFDMHNE
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x907DF90", Offset = "0x907C990", VA = "0x18907DF90")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x907E0C0", Offset = "0x907CAC0", VA = "0x18907E0C0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x907DB50", Offset = "0x907C550", VA = "0x18907DB50")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x907DC00", Offset = "0x907C600", VA = "0x18907DC00")]
		public unsafe static void KDMGDDCNHFD([NoAlias] CBHMNJPAKOH BLJPCDFFOJP, int OJKEAFJGLAK, [In][NoAlias] UniformTRS FPHHDIIPPFE, [In][NoAlias] CMNLAHEDKFC* FLBODJDICMA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly LJNNCBOFJHI JEIMLNFDLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float GMCAFBCPOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 OJHFFKMGCCJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 CCNGGNMJOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9080D80", Offset = "0x907F780", VA = "0x189080D80", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9082740", Offset = "0x9081140", VA = "0x189082740")]
	public JNNKLLAPHDM(LEPGFHMAPGB FAIGKPPBFHA, LJNNCBOFJHI BLPDDGCLNPE, bool AJPHGHDFKLB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "18")]
	public override bool CCDCLLODADJ(ALEFPCAPAGF FAIGKPPBFHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x9081090", Offset = "0x907FA90", VA = "0x189081090", Slot = "19")]
	public override int GFNMLHOEIGJ(OHKEILMIKJL ODNGOEPLNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x9080BA0", Offset = "0x907F5A0", VA = "0x189080BA0", Slot = "20")]
	public override int BADKDKIMODJ(OHKEILMIKJL ODNGOEPLNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x9081270", Offset = "0x907FC70", VA = "0x189081270", Slot = "21")]
	public override CBHMNJPAKOH GONPAKLMHDD()
	{
		return default(CBHMNJPAKOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9081540", Offset = "0x907FF40", VA = "0x189081540")]
	[BurstCompile]
	private unsafe static void ICKBLLEDMPM([NoAlias] CBHMNJPAKOH BLJPCDFFOJP, int OJKEAFJGLAK, [In][NoAlias] UniformTRS FPHHDIIPPFE, [In][NoAlias] CMNLAHEDKFC* FLBODJDICMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xC5E950", Offset = "0xC5D350", VA = "0x180C5E950", Slot = "22")]
	public override float KIDLNIDIFJE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9081970", Offset = "0x9080370", VA = "0x189081970", Slot = "23")]
	public override void NCCHLLHIJGC(OHKEILMIKJL ODNGOEPLNNM, CAKHJMCNAJB HKAFIKHDBOI, int CPMOIFGEIFJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x90815C0", Offset = "0x907FFC0", VA = "0x1890815C0")]
	private int IDDCJADPPLI(OHKEILMIKJL ODNGOEPLNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x9082670", Offset = "0x9081070", VA = "0x189082670", Slot = "24")]
	public override ALEFPCAPAGF PDBHLGODJNG()
	{
		return default(ALEFPCAPAGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x90817B0", Offset = "0x90801B0", VA = "0x1890817B0", Slot = "26")]
	public override JGPEMNPGJHA JPLDHOAEKNA()
	{
		return default(JGPEMNPGJHA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9081EC0", Offset = "0x90808C0", VA = "0x189081EC0", Slot = "27")]
	public override BAOJAHODAGC NGBLJAAHNIM(OHKEILMIKJL ODNGOEPLNNM, JobHandle EDFFJEFOFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9080EA0", Offset = "0x907F8A0", VA = "0x189080EA0")]
	[BurstCompile]
	public unsafe static void EBCCIJILHPI([NoAlias] CBHMNJPAKOH BLJPCDFFOJP, int OJKEAFJGLAK, [In][NoAlias] UniformTRS FPHHDIIPPFE, [In][NoAlias] CMNLAHEDKFC* FLBODJDICMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
public interface KJIHGKEMDBD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LEPGFHMAPGB PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	LMJFCIMAEOJ PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OOHEDAGFEFB PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public class GNDIAMJCPOB : JOGKHOGLCCH, IDisposable, KJIHGKEMDBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EGPBCFGBEOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public GNDIAMJCPOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x907ADC0", Offset = "0x90797C0", VA = "0x18907ADC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x907B340", Offset = "0x9079D40", VA = "0x18907B340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IHFJNMPAEIO<CFEOEFPPCFO, LEPGFHMAPGB> DMBHIBNBMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly IHFJNMPAEIO<CJHDFOMFPMP, LMJFCIMAEOJ> DCLCADNMNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly IHFJNMPAEIO<APGNDEGCDDB, OOHEDAGFEFB> INFMOKDBGPH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public LEPGFHMAPGB PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x907C5D0", Offset = "0x907AFD0", VA = "0x18907C5D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public LMJFCIMAEOJ PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x907C510", Offset = "0x907AF10", VA = "0x18907C510", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OOHEDAGFEFB PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x907C570", Offset = "0x907AF70", VA = "0x18907C570", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LFMJKHOAEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC1EBD0", Offset = "0xC1D5D0", VA = "0x180C1EBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x907D6A0", Offset = "0x907C0A0", VA = "0x18907D6A0")]
	public GNDIAMJCPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x907BFC0", Offset = "0x907A9C0", VA = "0x18907BFC0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x907C190", Offset = "0x907AB90", VA = "0x18907C190", Slot = "4")]
	public CFEOEFPPCFO EMEBMMFNIBC(DDAHMJKENKG BLPDDGCLNPE)
	{
		return default(CFEOEFPPCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x907C1A0", Offset = "0x907ABA0", VA = "0x18907C1A0", Slot = "5")]
	public CFEOEFPPCFO EMEBMMFNIBC(DDAHMJKENKG BLPDDGCLNPE, bool AJPHGHDFKLB)
	{
		return default(CFEOEFPPCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x907B480", Offset = "0x9079E80", VA = "0x18907B480", Slot = "6")]
	public void AINJNCHCMLC(CFEOEFPPCFO FAIGKPPBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x907D340", Offset = "0x907BD40", VA = "0x18907D340", Slot = "7")]
	public void PCIDKBNDJDA(CFEOEFPPCFO FAIGKPPBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x907B920", Offset = "0x907A320", VA = "0x18907B920", Slot = "8")]
	public CJHDFOMFPMP BMIPOKOFEKC(CFEOEFPPCFO FAIGKPPBFHA, GIJGHJAGFLM BLPDDGCLNPE)
	{
		return default(CJHDFOMFPMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x907CE60", Offset = "0x907B860", VA = "0x18907CE60", Slot = "9")]
	public CJHDFOMFPMP OEMEAONJDGE(CFEOEFPPCFO FAIGKPPBFHA, LJNNCBOFJHI BLPDDGCLNPE)
	{
		return default(CJHDFOMFPMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x907CAA0", Offset = "0x907B4A0", VA = "0x18907CAA0", Slot = "11")]
	public void OBLGNLPLHNH(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x907C700", Offset = "0x907B100", VA = "0x18907C700", Slot = "10")]
	public void LBJIADNIOMJ(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x907CA30", Offset = "0x907B430", VA = "0x18907CA30", Slot = "20")]
	public IEnumerable<Renderer> LOBBMGBPELP(CFEOEFPPCFO FAIGKPPBFHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x907B6E0", Offset = "0x907A0E0", VA = "0x18907B6E0", Slot = "12")]
	public APGNDEGCDDB AKNHHBNCKCI(KLMHLMDLEBF BLPDDGCLNPE)
	{
		return default(APGNDEGCDDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x907C630", Offset = "0x907B030", VA = "0x18907C630", Slot = "14")]
	public void HIDAABKAKPB(APGNDEGCDDB HNLKOBGPMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x907BE00", Offset = "0x907A800", VA = "0x18907BE00", Slot = "16")]
	public Task DEEHCAMBIMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x907B760", Offset = "0x907A160", VA = "0x18907B760", Slot = "17")]
	public Task AONLINMMHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x907C960", Offset = "0x907B360", VA = "0x18907C960", Slot = "18")]
	[AsyncStateMachine(typeof(EGPBCFGBEOB))]
	public Task LGADFEHDDIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x907C420", Offset = "0x907AE20", VA = "0x18907C420", Slot = "19")]
	public void GCLEPGMNIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x907C6A0", Offset = "0x907B0A0", VA = "0x18907C6A0", Slot = "13")]
	public void KNFFJNPKIPF(APGNDEGCDDB HNLKOBGPMLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
internal class MDEEBKHNECN : LMJFCIMAEOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private struct PPIPBMLHLMI : BAOJAHODAGC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private CIJLFCMKEEG KGGOMLADPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private NativeArray<int> KKECKBFLBAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private JobHandle EDFFJEFOFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private LDOJFKOCFLP NDNGJFNKLFJ;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9088B80", Offset = "0x9087580", VA = "0x189088B80")]
		public PPIPBMLHLMI(CIJLFCMKEEG KGGOMLADPBD, NativeArray<int> KKECKBFLBAA, JobHandle EDFFJEFOFGN, LDOJFKOCFLP NDNGJFNKLFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9088B20", Offset = "0x9087520", VA = "0x189088B20", Slot = "4")]
		public CIJLFCMKEEG IBGIFICHJPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9088A80", Offset = "0x9087480", VA = "0x189088A80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void PBLLJMHKMMF([NoAlias] CBHMNJPAKOH BLJPCDFFOJP, [In] float3 JBHNOBCPJPM, [In][NoAlias] Bounds AIGJHBHFGKK, [In][NoAlias] UniformTRS DDKADFANAON);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class DGBJKJPHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr ONOBDDHAMHP;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr BEKGKEFCMFG;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9077370", Offset = "0x9075D70", VA = "0x189077370")]
		[BurstDiscard]
		private static void MGFINNOLPID(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x90774A0", Offset = "0x9075EA0", VA = "0x1890774A0")]
		private static IntPtr ONLKMKAFHCO()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x90770B0", Offset = "0x9075AB0", VA = "0x1890770B0")]
		public static void FAPJKNNDICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		public static void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9077160", Offset = "0x9075B60", VA = "0x189077160")]
		public static void KDMGDDCNHFD([NoAlias] CBHMNJPAKOH BLJPCDFFOJP, [In] float3 JBHNOBCPJPM, [In][NoAlias] Bounds AIGJHBHFGKK, [In][NoAlias] UniformTRS DDKADFANAON)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly GIJGHJAGFLM AMLFHELBNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int[] HFMKPMLGLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Hash128 OJHFFKMGCCJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 APKLDMCBBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9084BA0", Offset = "0x90835A0", VA = "0x189084BA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 CCNGGNMJOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x90846A0", Offset = "0x90830A0", VA = "0x1890846A0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9086C70", Offset = "0x9085670", VA = "0x189086C70")]
	public MDEEBKHNECN(LEPGFHMAPGB FAIGKPPBFHA, GIJGHJAGFLM BLPDDGCLNPE, bool AJLPHNOJAAA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x90845D0", Offset = "0x9082FD0", VA = "0x1890845D0", Slot = "18")]
	public override bool CCDCLLODADJ(ALEFPCAPAGF FAIGKPPBFHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9084E80", Offset = "0x9083880", VA = "0x189084E80", Slot = "21")]
	public override CBHMNJPAKOH GONPAKLMHDD()
	{
		return default(CBHMNJPAKOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x9084EC0", Offset = "0x90838C0", VA = "0x189084EC0")]
	private CBHMNJPAKOH GONPAKLMHDD(ALEFPCAPAGF FAIGKPPBFHA)
	{
		return default(CBHMNJPAKOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x9085410", Offset = "0x9083E10", VA = "0x189085410")]
	[BurstCompile]
	private static void JPCDCPIBKEK([NoAlias] CBHMNJPAKOH BLJPCDFFOJP, [In] float3 JBHNOBCPJPM, [In][NoAlias] Bounds AIGJHBHFGKK, [In][NoAlias] UniformTRS DDKADFANAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9085210", Offset = "0x9083C10", VA = "0x189085210")]
	private NMADFFPCCPM ILEKGNGOEOP([In] UniformTRS KDNINACCBIG, [In] float3 MLLKGODGLGG)
	{
		return default(NMADFFPCCPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x9084DD0", Offset = "0x90837D0", VA = "0x189084DD0", Slot = "19")]
	public override int GFNMLHOEIGJ(OHKEILMIKJL ODNGOEPLNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x9084520", Offset = "0x9082F20", VA = "0x189084520", Slot = "20")]
	public override int BADKDKIMODJ(OHKEILMIKJL ODNGOEPLNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9085A90", Offset = "0x9084490", VA = "0x189085A90", Slot = "22")]
	public override float KIDLNIDIFJE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9085810", Offset = "0x9084210", VA = "0x189085810")]
	private int KCGOOLLPAHG(OHKEILMIKJL ODNGOEPLNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9085B80", Offset = "0x9084580", VA = "0x189085B80", Slot = "23")]
	public override void NCCHLLHIJGC(OHKEILMIKJL ODNGOEPLNNM, CAKHJMCNAJB HKAFIKHDBOI, int CPMOIFGEIFJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x9086BA0", Offset = "0x90855A0", VA = "0x189086BA0", Slot = "24")]
	public override ALEFPCAPAGF PDBHLGODJNG()
	{
		return default(ALEFPCAPAGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9085650", Offset = "0x9084050", VA = "0x189085650", Slot = "26")]
	public override JGPEMNPGJHA JPLDHOAEKNA()
	{
		return default(JGPEMNPGJHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x90863D0", Offset = "0x9084DD0", VA = "0x1890863D0", Slot = "27")]
	public override BAOJAHODAGC NGBLJAAHNIM(OHKEILMIKJL ODNGOEPLNNM, JobHandle EDFFJEFOFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x90847C0", Offset = "0x90831C0", VA = "0x1890847C0")]
	[BurstCompile]
	public static void FDCFJJFOEKL([NoAlias] CBHMNJPAKOH BLJPCDFFOJP, [In] float3 JBHNOBCPJPM, [In][NoAlias] Bounds AIGJHBHFGKK, [In][NoAlias] UniformTRS DDKADFANAON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BILBHONJCKG
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPEOPALANCA(IKEGDKKKDKI DGNODDPLLPC, Renderer ALKNEOONPNG, int IPGENHHGOEO);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACDDDFMMLLN(Renderer ALKNEOONPNG, ELJEIINLLPG EPGEKJPNEHG, Vector3 CMMPHLCGHGJ, Vector3 CPMDBFEDMBI, Vector3 ACCEIAEFMLC, float EPGMBNKMDHC, float LEJEMPEJOJG, float LMNMNPIFEPB = -1f, [Optional] Color? EOGEFFOIIOP, [Optional] IReadOnlyList<Camera> DPNKHMCNHAA);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMKJHJGGPFH(Renderer ALKNEOONPNG, int IPGENHHGOEO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HONOGGNPOAH();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGKBOBFHBLN(int HDMBLHBHLBB, KBICEEBHCID DGNODDPLLPC, Renderer ALKNEOONPNG, int IPGENHHGOEO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IACKICJKNJC : ONEMHINNGHH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private class AKBILBMEJAC : PFBDIMCADPH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9075270", Offset = "0x9073C70", VA = "0x189075270")]
		public AKBILBMEJAC(string IELIBBNCJAC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BILBHONJCKG DCAOMLGIJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KJIHGKEMDBD OPBFMGDLIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private MeshRenderer DKLHHHGDLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private AKBILBMEJAC BBFAIDHBDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private bool MCGMNNFOEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private MeshRenderer ILIMOGDHMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private AKBILBMEJAC BKEBNOMIPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool KHCGIBNLDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private MeshRenderer AMFMDDODIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private AKBILBMEJAC LOOKLFFAMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private bool MJMNHJNHHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool JPNPFIIDGCJ;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
	public IACKICJKNJC(BILBHONJCKG HKAIOBBCBGO, KJIHGKEMDBD OPBFMGDLIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x907F7F0", Offset = "0x907E1F0", VA = "0x18907F7F0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x907F9A0", Offset = "0x907E3A0", VA = "0x18907F9A0")]
	private void EKPHMMIPJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x907F030", Offset = "0x907DA30", VA = "0x18907F030", Slot = "4")]
	public void BMGFLNNAMCN(CFEOEFPPCFO FAIGKPPBFHA, KBICEEBHCID NNFDIFDOFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x907EE10", Offset = "0x907D810", VA = "0x18907EE10", Slot = "5")]
	public void BMGFLNNAMCN(CJHDFOMFPMP ENDDNPPKCPO, KBICEEBHCID NNFDIFDOFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x907FC10", Offset = "0x907E610", VA = "0x18907FC10", Slot = "6")]
	public void FJAEIDOPADB(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x90807E0", Offset = "0x907F1E0", VA = "0x1890807E0", Slot = "7")]
	public void MIEEOPPOCBO(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x907FE40", Offset = "0x907E840", VA = "0x18907FE40", Slot = "24")]
	public void IGKAKGJABFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1472950", Offset = "0x1471350", VA = "0x181472950", Slot = "8")]
	public void BALDCMFLBMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x907F340", Offset = "0x907DD40", VA = "0x18907F340", Slot = "9")]
	public void BNJPCIHFNKB(KBICEEBHCID NNFDIFDOFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x9080080", Offset = "0x907EA80", VA = "0x189080080", Slot = "10")]
	public void MAEJMJMEIND(CFEOEFPPCFO FAIGKPPBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x9080360", Offset = "0x907ED60", VA = "0x189080360", Slot = "11")]
	public void MAEJMJMEIND(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x907FD70", Offset = "0x907E770", VA = "0x18907FD70", Slot = "12")]
	public void IEGHLFNFLED(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x907F4B0", Offset = "0x907DEB0", VA = "0x18907F4B0", Slot = "13")]
	public void DBPFPHGHGAF(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x9080930", Offset = "0x907F330", VA = "0x189080930")]
	private void OJFNBDLEOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x16324D0", Offset = "0x1630ED0", VA = "0x1816324D0", Slot = "14")]
	public void HCLCGLGOAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x90806C0", Offset = "0x907F0C0", VA = "0x1890806C0", Slot = "15")]
	public void MBLMHOGMAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x907EB30", Offset = "0x907D530", VA = "0x18907EB30", Slot = "16")]
	public void BKIDOPCBAMN(CFEOEFPPCFO FAIGKPPBFHA, IKEGDKKKDKI DGNODDPLLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x907EA60", Offset = "0x907D460", VA = "0x18907EA60", Slot = "17")]
	public void BBDLBOCHEMM(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x907FFB0", Offset = "0x907E9B0", VA = "0x18907FFB0", Slot = "18")]
	public void KFJPCMENGOA(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xE2BB10", Offset = "0xE2A510", VA = "0x180E2BB10", Slot = "19")]
	public void BIKLPKEHGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x907FE80", Offset = "0x907E880", VA = "0x18907FE80", Slot = "20")]
	public void JKINODOBCKK(IKEGDKKKDKI DGNODDPLLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x907F580", Offset = "0x907DF80", VA = "0x18907F580")]
	private void DCEFAHDGOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x907E6A0", Offset = "0x907D0A0", VA = "0x18907E6A0", Slot = "21")]
	public void AACIELIEBNA(CFEOEFPPCFO FAIGKPPBFHA, Vector3 CMMPHLCGHGJ, Vector3 CPMDBFEDMBI, Vector3 ACCEIAEFMLC, float EPGMBNKMDHC, float LEJEMPEJOJG, IReadOnlyList<Camera> GMMFFGBHFFI, ELJEIINLLPG EPGEKJPNEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x907E220", Offset = "0x907CC20", VA = "0x18907E220", Slot = "22")]
	public void AACIELIEBNA(APGNDEGCDDB HNLKOBGPMLG, Vector3 CMMPHLCGHGJ, Vector3 CPMDBFEDMBI, Vector3 ACCEIAEFMLC, float EPGMBNKMDHC, float LEJEMPEJOJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class LMJFCIMAEOJ : IOEDLKGKACJ, EGGKHJMOLHG, CAPPDBPPNCC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly LEPGFHMAPGB GLKLCNOCKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private int DHPCKHAKOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected Bounds OJAMNJHGFHC;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds BDGMNCLMGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x90843D0", Offset = "0x9082DD0", VA = "0x1890843D0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool IGGOMHODCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xF2C990", Offset = "0xF2B390", VA = "0x180F2C990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xF46860", Offset = "0xF45260", VA = "0x180F46860")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 CCNGGNMJOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int AKIPJCMMDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xC43520", Offset = "0xC41F20", VA = "0x180C43520", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public AHIJLHMFMJG BDJFMKKPECO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MMMJOLLACKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x23516C0", Offset = "0x23500C0", VA = "0x1823516C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	protected LMJFCIMAEOJ(LEPGFHMAPGB FAIGKPPBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x9084250", Offset = "0x9082C50", VA = "0x189084250", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "18")]
	public virtual bool CCDCLLODADJ(ALEFPCAPAGF FAIGKPPBFHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x90843C0", Offset = "0x9082DC0", VA = "0x1890843C0", Slot = "10")]
	public int FLEBLNMPDBF(int IPJOJDBILDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int GFNMLHOEIGJ(OHKEILMIKJL ODNGOEPLNNM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int BADKDKIMODJ(OHKEILMIKJL ODNGOEPLNNM);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract CBHMNJPAKOH GONPAKLMHDD();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float KIDLNIDIFJE();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void NCCHLLHIJGC(OHKEILMIKJL ODNGOEPLNNM, CAKHJMCNAJB HKAFIKHDBOI, int CPMOIFGEIFJ = -1);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract ALEFPCAPAGF PDBHLGODJNG();

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x9084420", Offset = "0x9082E20", VA = "0x189084420", Slot = "13")]
	public Hash128 OFMBKNEAOEA(int ODNGOEPLNNM)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract JGPEMNPGJHA JPLDHOAEKNA();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract BAOJAHODAGC NGBLJAAHNIM(OHKEILMIKJL ODNGOEPLNNM, JobHandle EDFFJEFOFGN);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x90843F0", Offset = "0x9082DF0", VA = "0x1890843F0", Slot = "12")]
	public BAOJAHODAGC HBOMAHJJMEA(int ODNGOEPLNNM)
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
		[Cpp2IlInjected.Address(RVA = "0x9088BE0", Offset = "0x90875E0", VA = "0x189088BE0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class EAFILINGEML
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OOKEACBNGNJ : IEnumerable<GNLFIFFJMFH>, IEnumerable, IEnumerator<GNLFIFFJMFH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private GNLFIFFJMFH <>2__current;

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
		private GNLFIFFJMFH System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public OOKEACBNGNJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x90887C0", Offset = "0x90871C0", VA = "0x1890887C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9088930", Offset = "0x9087330", VA = "0x189088930", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9088890", Offset = "0x9087290", VA = "0x189088890", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GNLFIFFJMFH> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9088890", Offset = "0x9087290", VA = "0x189088890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static GNLFIFFJMFH[][] PFKNLIDPLAA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static IHEOFMLIHGE JAJGIPJCIPJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static ShapeRendererConfig CLBEDCLAFKO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader HJOMCNEENJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x907ABE0", Offset = "0x90795E0", VA = "0x18907ABE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer MLPELLJBFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x907AC40", Offset = "0x9079640", VA = "0x18907AC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x9079620", Offset = "0x9078020", VA = "0x189079620")]
	[IPFIKIDBFAK]
	internal static void GFALNPPLGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x9079D20", Offset = "0x9078720", VA = "0x189079D20")]
	public static Mesh MBHEADPDEKH(FNINIENCAIO PELCLMCNOCO, int ODNGOEPLNNM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x907ABD0", Offset = "0x90795D0", VA = "0x18907ABD0")]
	public static int MKFKNPHJFNC(FNINIENCAIO PELCLMCNOCO, int ODNGOEPLNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x9079710", Offset = "0x9078110", VA = "0x189079710")]
	public static IHEOFMLIHGE HDCNNMDAEOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9079B10", Offset = "0x9078510", VA = "0x189079B10")]
	[IteratorStateMachine(typeof(OOKEACBNGNJ))]
	private static IEnumerable<GNLFIFFJMFH> KLCMNEEBJBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x9079DC0", Offset = "0x90787C0", VA = "0x189079DC0")]
	public static GNLFIFFJMFH MHEOFAJOJDN(FNINIENCAIO PELCLMCNOCO, int ODNGOEPLNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x907ACA0", Offset = "0x90796A0", VA = "0x18907ACA0")]
	public static bool PKKCBBEHNMD(this FNINIENCAIO PELCLMCNOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x9079B70", Offset = "0x9078570", VA = "0x189079B70")]
	public static void KMGKFAAPIDC(FNINIENCAIO PELCLMCNOCO, float3 HJBEJPMABGC, [Out] NKIPOMMBBHD NACJKJKFKPN, [Out] float3 KOMGKOFOEOH, [Out] float FJGBNHHMAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x9079250", Offset = "0x9077C50", VA = "0x189079250")]
	public static void CFLOGJPBEMP(Vector3 HJBEJPMABGC, FNINIENCAIO PELCLMCNOCO, [Out] Vector3 KOMGKOFOEOH, [Out] float FJGBNHHMAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x9079240", Offset = "0x9077C40", VA = "0x189079240")]
	[IBHMBBHMEHH(0)]
	[JHMKPHPKHPJ(NPKHJKBGLFH.ExitingPlayMode, 0)]
	private static void AIBBGILMEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x9079930", Offset = "0x9078330", VA = "0x189079930")]
	[IBHMBBHMEHH(0)]
	[JHMKPHPKHPJ(NPKHJKBGLFH.ExitingPlayMode, 0)]
	private static void JCBBNONDGDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class BCFKOMFOFFL : JOGKHOGLCCH, IDisposable, KJIHGKEMDBD
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IHFJNMPAEIO<CFEOEFPPCFO, LEPGFHMAPGB> DMBHIBNBMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly IHFJNMPAEIO<CJHDFOMFPMP, LMJFCIMAEOJ> DCLCADNMNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly IHFJNMPAEIO<APGNDEGCDDB, OOHEDAGFEFB> INFMOKDBGPH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public LEPGFHMAPGB PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9075810", Offset = "0x9074210", VA = "0x189075810", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public LMJFCIMAEOJ PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9075750", Offset = "0x9074150", VA = "0x189075750", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public OOHEDAGFEFB PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x90757B0", Offset = "0x90741B0", VA = "0x1890757B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LFMJKHOAEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xC1EBD0", Offset = "0xC1D5D0", VA = "0x180C1EBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x9075D90", Offset = "0x9074790", VA = "0x189075D90")]
	public BCFKOMFOFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x9075620", Offset = "0x9074020", VA = "0x189075620", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x90756B0", Offset = "0x90740B0", VA = "0x1890756B0", Slot = "4")]
	public CFEOEFPPCFO EMEBMMFNIBC(DDAHMJKENKG BLPDDGCLNPE)
	{
		return default(CFEOEFPPCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x90756B0", Offset = "0x90740B0", VA = "0x1890756B0", Slot = "5")]
	public CFEOEFPPCFO EMEBMMFNIBC(DDAHMJKENKG BLPDDGCLNPE, bool AJPHGHDFKLB)
	{
		return default(CFEOEFPPCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x90752C0", Offset = "0x9073CC0", VA = "0x1890752C0", Slot = "6")]
	public void AINJNCHCMLC(CFEOEFPPCFO FAIGKPPBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x9075C80", Offset = "0x9074680", VA = "0x189075C80", Slot = "7")]
	public void PCIDKBNDJDA(CFEOEFPPCFO FAIGKPPBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x9075440", Offset = "0x9073E40", VA = "0x189075440", Slot = "8")]
	public CJHDFOMFPMP BMIPOKOFEKC(CFEOEFPPCFO FAIGKPPBFHA, GIJGHJAGFLM BLPDDGCLNPE)
	{
		return default(CJHDFOMFPMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x9075B40", Offset = "0x9074540", VA = "0x189075B40", Slot = "9")]
	public CJHDFOMFPMP OEMEAONJDGE(CFEOEFPPCFO FAIGKPPBFHA, LJNNCBOFJHI BLPDDGCLNPE)
	{
		return default(CJHDFOMFPMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x9075AB0", Offset = "0x90744B0", VA = "0x189075AB0", Slot = "11")]
	public void OBLGNLPLHNH(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x9075940", Offset = "0x9074340", VA = "0x189075940", Slot = "10")]
	public void LBJIADNIOMJ(CJHDFOMFPMP ENDDNPPKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9075A40", Offset = "0x9074440", VA = "0x189075A40", Slot = "20")]
	public IEnumerable<Renderer> LOBBMGBPELP(CFEOEFPPCFO FAIGKPPBFHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9075320", Offset = "0x9073D20", VA = "0x189075320", Slot = "12")]
	public APGNDEGCDDB AKNHHBNCKCI(KLMHLMDLEBF BLPDDGCLNPE)
	{
		return default(APGNDEGCDDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x9075870", Offset = "0x9074270", VA = "0x189075870", Slot = "14")]
	public void HIDAABKAKPB(APGNDEGCDDB HNLKOBGPMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x9075580", Offset = "0x9073F80", VA = "0x189075580", Slot = "16")]
	public Task DEEHCAMBIMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x90753A0", Offset = "0x9073DA0", VA = "0x1890753A0", Slot = "17")]
	public Task AONLINMMHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x90759A0", Offset = "0x90743A0", VA = "0x1890759A0", Slot = "18")]
	public Task LGADFEHDDIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x29FC000", Offset = "0x29FAA00", VA = "0x1829FC000", Slot = "19")]
	public void GCLEPGMNIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x90758E0", Offset = "0x90742E0", VA = "0x1890758E0", Slot = "13")]
	public void KNFFJNPKIPF(APGNDEGCDDB HNLKOBGPMLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PJNFADFFNNL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool DLPLOJFHKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material HHJDKJHHIBD();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material HIKKLFCBPAK();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material FOBDGBMFFEL();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int AJPGEDGEKHL(FIHNPCHPOKM GKNNJOIGPFH);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DEFLPKIKHNG(MFJKGLKLLDL IOBGELNGNKC);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FEAAHCIOGEO(GameObject PMNHIPACJLN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GOMAPJPGGNL(GameObject PMNHIPACJLN, bool DNHGIAHLIHF);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class NAJEEGIGKKD
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static PJNFADFFNNL FDMAPEJEBGO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool DLPLOJFHKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x90870E0", Offset = "0x9085AE0", VA = "0x1890870E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x9087080", Offset = "0x9085A80", VA = "0x189087080")]
	public static void KEOCFIJIGNA(PJNFADFFNNL HKAIKIOLHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x9087020", Offset = "0x9085A20", VA = "0x189087020")]
	public static Material HHJDKJHHIBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9083380", Offset = "0x9081D80", VA = "0x189083380")]
	public static Material HIKKLFCBPAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9086EE0", Offset = "0x90858E0", VA = "0x189086EE0")]
	public static Material FOBDGBMFFEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9086D20", Offset = "0x9085720", VA = "0x189086D20")]
	public static int AJPGEDGEKHL(FIHNPCHPOKM GKNNJOIGPFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x9086D90", Offset = "0x9085790", VA = "0x189086D90")]
	public static int DEFLPKIKHNG(MFJKGLKLLDL IOBGELNGNKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x9086E00", Offset = "0x9085800", VA = "0x189086E00")]
	public static void FEAAHCIOGEO(GameObject PMNHIPACJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x9086F40", Offset = "0x9085940", VA = "0x189086F40")]
	public static void GOMAPJPGGNL(GameObject PMNHIPACJLN, bool DNHGIAHLIHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OOHEDAGFEFB : HKHKFNBJJMM
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AALBBCGGIAN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public OOHEDAGFEFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public AALBBCGGIAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x90751E0", Offset = "0x9073BE0", VA = "0x1890751E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9074EC0", Offset = "0x90738C0", VA = "0x189074EC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9074E70", Offset = "0x9073870", VA = "0x189074E70")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9075190", Offset = "0x9073B90", VA = "0x189075190", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x90750E0", Offset = "0x9073AE0", VA = "0x1890750E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x90750E0", Offset = "0x9073AE0", VA = "0x1890750E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly KLMHLMDLEBF LJKFGDDCMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly KJIHGKEMDBD OPBFMGDLIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private DLJALPJMCKB OBMPIMNEAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<DKBCJMNNPAO> AINMGLLJFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private List<DKBCJMNNPAO> ALNNPCKJCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private GameObject MFFNCEEDKLK;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x9087340", Offset = "0x9085D40", VA = "0x189087340")]
	public static OOHEDAGFEFB DAIOHPBCHFM(KLMHLMDLEBF BLPDDGCLNPE, KJIHGKEMDBD OPBFMGDLIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x90886E0", Offset = "0x90870E0", VA = "0x1890886E0")]
	private OOHEDAGFEFB(KLMHLMDLEBF BLPDDGCLNPE, KJIHGKEMDBD OPBFMGDLIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x9088250", Offset = "0x9086C50", VA = "0x189088250")]
	public void OKCDDGFOJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x90881A0", Offset = "0x9086BA0", VA = "0x1890881A0")]
	[IteratorStateMachine(typeof(AALBBCGGIAN))]
	public IEnumerable<Renderer> FBIEILKLHEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x90876E0", Offset = "0x90860E0", VA = "0x1890876E0", Slot = "4")]
	public void EPKKEKBGPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9088220", Offset = "0x9086C20", VA = "0x189088220")]
	private void JKIKFOHINCD(Vector3 BLJMDNLILHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x9087490", Offset = "0x9085E90", VA = "0x189087490")]
	public void DBIPLKHEHMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DKBCJMNNPAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct OPBICGALAKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CAKHJMCNAJB CFKFHHGEDFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public ALEFPCAPAGF GBDBPHBLAKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int PFLJDEJMPHN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OHDCEGOLLCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public DKBCJMNNPAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public OHKEILMIKJL lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public List<OPBICGALAKC> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CIJLFCMKEEG combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OHDCEGOLLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9087170", Offset = "0x9085B70", VA = "0x189087170")]
		internal JobHandle DFKCOOJLNMK()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9087140", Offset = "0x9085B40", VA = "0x189087140")]
		internal void AFLDGJHNCCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x90871D0", Offset = "0x9085BD0", VA = "0x1890871D0")]
		internal void LLGIDFHFBGD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private int[] IEAPDEBOPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private MCDHBODNOIF NCJMKCPMICP;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static Matrix4x4 LNJMPJICCOO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh OLDNMECOABP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BHPFPDOJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x9077600", Offset = "0x9076000", VA = "0x189077600")]
	public void DIKMCCMLBPK(List<ALEFPCAPAGF> HGOFGOEILBJ, Matrix4x4[] PIGPGDLLALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x9077CE0", Offset = "0x90766E0", VA = "0x189077CE0")]
	public static List<DKBCJMNNPAO> MLAHKGEEKLJ(List<LEPGFHMAPGB> LBNPGIJINCL, OHKEILMIKJL ODNGOEPLNNM, Bounds KAKALMLAPHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x9077890", Offset = "0x9076290", VA = "0x189077890")]
	private JobHandle FBPHKLCAGDM(CIJLFCMKEEG FNCBDBPAEMO, int NAADNDJPCJF, int MIOAPJGCBLG, OHKEILMIKJL ODNGOEPLNNM, List<OPBICGALAKC> BCAICNHBCOO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x9077C00", Offset = "0x9076600", VA = "0x189077C00")]
	private void JAPJBMDJOBE(List<OPBICGALAKC> BCAICNHBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x9078510", Offset = "0x9076F10", VA = "0x189078510")]
	private DKBCJMNNPAO(List<OPBICGALAKC> BCAICNHBCOO, int NAADNDJPCJF, int MIOAPJGCBLG, OHKEILMIKJL ODNGOEPLNNM, Bounds KAKALMLAPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x90777F0", Offset = "0x90761F0", VA = "0x1890777F0", Slot = "4")]
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
		private MaterialPropertyBlock FCCLOGLCHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private DKBCJMNNPAO KGGOMLADPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<ALEFPCAPAGF> IDHPHJINHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private RenderTexture MMIINBNGNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private ComputeBuffer LKDGLAHONBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private ComputeShader GMFOPFDDGIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Matrix4x4[] LCLHHOECAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int PJBILNDHAPP;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer IPIJLGJBILK
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int KELLCJOFAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x9089910", Offset = "0x9088310", VA = "0x189089910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9088C40", Offset = "0x9087640", VA = "0x189088C40")]
		public static List<SkinnedShapeRenderer> Create(GameObject FAIGKPPBFHA, List<DKBCJMNNPAO> PIHGOJDOLKM, List<ALEFPCAPAGF> IDHPHJINHBB, Material PJPBFBIEGMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9089300", Offset = "0x9087D00", VA = "0x189089300")]
		public void Init(DKBCJMNNPAO KGGOMLADPBD, List<ALEFPCAPAGF> IDHPHJINHBB, Material PJPBFBIEGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9089870", Offset = "0x9088270", VA = "0x189089870")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x90897D0", Offset = "0x90881D0", VA = "0x1890897D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9089790", Offset = "0x9088190", VA = "0x189089790")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9089240", Offset = "0x9087C40", VA = "0x189089240")]
		private void IKEODLFBAKH(ScriptableRenderContext IJNPIDPIBFP, Camera[] PDGANMOMPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9088ED0", Offset = "0x90878D0", VA = "0x189088ED0")]
		private void DIKMCCMLBPK(CommandBuffer GNJOLAHHMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x9089950", Offset = "0x9088350", VA = "0x189089950")]
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
