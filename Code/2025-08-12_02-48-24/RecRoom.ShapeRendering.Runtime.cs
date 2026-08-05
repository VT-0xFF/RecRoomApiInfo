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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6CD0", Offset = "0x8FE52D0", VA = "0x188FE6CD0", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8FEB7E0", Offset = "0x8FE9DE0", VA = "0x188FEB7E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BNHAJJFNALD : PECDBKHLDGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte BEEDEMELNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] GBPPIJINKJN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FKOJGIBHHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BBGPLHBGNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float OCMHPBMOBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x109BE00", Offset = "0x109A400", VA = "0x18109BE00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x15ACBD0", Offset = "0x15AB1D0", VA = "0x1815ACBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CKEENBEELKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDB9260", Offset = "0xDB7860", VA = "0x180DB9260", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDB9270", Offset = "0xDB7870", VA = "0x180DB9270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> POGMPNEHAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8FD9050", Offset = "0x8FD7650", VA = "0x188FD9050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> LAEEEIPGKIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD9020", Offset = "0x8FD7620", VA = "0x188FD9020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject KFENKPOKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte COCJJPHHPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8FD9450", Offset = "0x8FD7A50", VA = "0x188FD9450", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9600", Offset = "0x8FD7C00", VA = "0x188FD9600")]
	public BNHAJJFNALD(List<PKMCDKHMKMA> NPPIFNDBBPG, List<PKMCDKHMKMA> AFDFPGNPMGP, List<HGOECGDMDII> KGGMFKPKBNC, Material JKDFAJLFBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8FD90A0", Offset = "0x8FD76A0", VA = "0x188FD90A0")]
	private int CJGPHCCPIEA(List<PKMCDKHMKMA> AFMMHMEHFMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8FD94A0", Offset = "0x8FD7AA0", VA = "0x188FD94A0")]
	private void LAFBDAHHOCC(int EKKLFMLOHEL, bool LHMEEOHCMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8FD91C0", Offset = "0x8FD77C0", VA = "0x188FD91C0")]
	public void CMKCLCIGMID(Vector3 IAOFCONEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9350", Offset = "0x8FD7950", VA = "0x188FD9350", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9310", Offset = "0x8FD7910", VA = "0x188FD9310")]
	public void DOIMMOIFCJK(Transform HOOFJNNBEPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PHMEFGAKKMP : MOCGLBDJAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LGDONOLIGNA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PHMEFGAKKMP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public LGDONOLIGNA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6AE0", Offset = "0x8FE50E0", VA = "0x188FE6AE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6480", Offset = "0x8FE4A80", VA = "0x188FE6480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6990", Offset = "0x8FE4F90", VA = "0x188FE6990")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6430", Offset = "0x8FE4A30", VA = "0x188FE6430")]
		private void LGNDDFAIONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8FE63E0", Offset = "0x8FE49E0", VA = "0x188FE63E0")]
		private void DKNJDMKKGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6A90", Offset = "0x8FE5090", VA = "0x188FE6A90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8FE69E0", Offset = "0x8FE4FE0", VA = "0x188FE69E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8FE69E0", Offset = "0x8FE4FE0", VA = "0x188FE69E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PEABBLOBJGL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PHMEFGAKKMP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public PEABBLOBJGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE74C0", Offset = "0x8FE5AC0", VA = "0x188FE74C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7000", Offset = "0x8FE5600", VA = "0x188FE7000", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7370", Offset = "0x8FE5970", VA = "0x188FE7370")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6FB0", Offset = "0x8FE55B0", VA = "0x188FE6FB0")]
		private void LGNDDFAIONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7470", Offset = "0x8FE5A70", VA = "0x188FE7470", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8FE73C0", Offset = "0x8FE59C0", VA = "0x188FE73C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8FE73C0", Offset = "0x8FE59C0", VA = "0x188FE73C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BGNDGMGKLOG HHLHDOFBMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<EJNEODLGIID> IIAOGHHEBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> ANKBJJEPICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer EMEJIFHGFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool DMECLOPPHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool FGHKPHADDJN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<EFJMOLMIFDJ> FBGBECFBCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AHIPFFJFGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8C70", Offset = "0x8FE7270", VA = "0x188FE8C70", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HGOECGDMDII IKIOJPIHHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7990", Offset = "0x8FE5F90", VA = "0x188FE7990", Slot = "8")]
		get
		{
			return default(HGOECGDMDII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> FKGKOGAPIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE7D40", Offset = "0x8FE6340", VA = "0x188FE7D40")]
	private bool FLLOOMMBCNC(EJNEODLGIID NDLHPLKACFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8FE75F0", Offset = "0x8FE5BF0", VA = "0x188FE75F0")]
	private static bool AJPDPNLJPNJ(EJNEODLGIID NDLHPLKACFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8FE8F00", Offset = "0x8FE7500", VA = "0x188FE8F00")]
	public PHMEFGAKKMP(BGNDGMGKLOG DAJAOHIJHHL, bool IFMPCDPOCJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8FE76E0", Offset = "0x8FE5CE0", VA = "0x188FE76E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8FE8CB0", Offset = "0x8FE72B0", VA = "0x188FE8CB0")]
	public void KMLBEHGKDFG(EJNEODLGIID NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8FE7D60", Offset = "0x8FE6360", VA = "0x188FE7D60")]
	public void HCDNAOEAAEJ(EJNEODLGIID NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8FE86F0", Offset = "0x8FE6CF0", VA = "0x188FE86F0", Slot = "4")]
	public void IOHLBIAFPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8FE7AD0", Offset = "0x8FE60D0", VA = "0x188FE7AD0")]
	public void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8FE8530", Offset = "0x8FE6B30", VA = "0x188FE8530")]
	private void IGNPLMMLJMI(List<EJNEODLGIID> IIAOGHHEBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8FE14A0", Offset = "0x8FDFAA0", VA = "0x188FE14A0")]
	private static Material KDFMMEICFKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8FE8480", Offset = "0x8FE6A80", VA = "0x188FE8480")]
	private void IGNPLMMLJMI(EJNEODLGIID NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8FE7610", Offset = "0x8FE5C10", VA = "0x188FE7610")]
	private void DIPGPDPOLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8FE7EC0", Offset = "0x8FE64C0", VA = "0x188FE7EC0")]
	public void HMOOGJEBLOO(bool CGLEICACONB, bool KODBIGCHGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE78D0", Offset = "0x8FE5ED0", VA = "0x188FE78D0")]
	protected void EBPGIBKODJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE8BF0", Offset = "0x8FE71F0", VA = "0x188FE8BF0")]
	public void JAOFKDCMLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8FE8E80", Offset = "0x8FE7480", VA = "0x188FE8E80")]
	[IteratorStateMachine(typeof(LGDONOLIGNA))]
	public IEnumerable<Renderer> LNJNGOCNLEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE7A50", Offset = "0x8FE6050", VA = "0x188FE7A50")]
	[IteratorStateMachine(typeof(PEABBLOBJGL))]
	public IEnumerable<Renderer> FBAIEIGCAFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class CDLAIECPKBL : EJNEODLGIID
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct DIIADHEOMJG : NHFEFALFGMD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KGBENKDOKKC LJNJDNJBNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle ELCAJJNPFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private LHPBPADBCFL PDINMCPKHOG;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD3A0", Offset = "0x8FDB9A0", VA = "0x188FDD3A0")]
		public DIIADHEOMJG(KGBENKDOKKC LJNJDNJBNIE, JobHandle ELCAJJNPFBB, LHPBPADBCFL PDINMCPKHOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD370", Offset = "0x8FDB970", VA = "0x188FDD370", Slot = "4")]
		public KGBENKDOKKC IMDIPNPDNOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD320", Offset = "0x8FDB920", VA = "0x188FDD320", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly FOCDFGPPKDG JBCOMLELOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float EJMLAHNODFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 PAMDMMFDLIA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 NLKPPNBHMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8FDB3D0", Offset = "0x8FD99D0", VA = "0x188FDB3D0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8FDB4F0", Offset = "0x8FD9AF0", VA = "0x188FDB4F0")]
	public CDLAIECPKBL(PHMEFGAKKMP PPOKNBNEDHM, FOCDFGPPKDG DAJAOHIJHHL, bool IFMPCDPOCJF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "18")]
	public override bool CDFCBJDHLHL(HGOECGDMDII PPOKNBNEDHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9E90", Offset = "0x8FD8490", VA = "0x188FD9E90", Slot = "19")]
	public override int CJGPHCCPIEA(ICFDOFGDKLP EEPEOPEEIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8FDB1F0", Offset = "0x8FD97F0", VA = "0x188FDB1F0", Slot = "20")]
	public override int OBHAKBCDEKD(ICFDOFGDKLP EEPEOPEEIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8FD9920", Offset = "0x8FD7F20", VA = "0x188FD9920", Slot = "21")]
	public override GLGFFNDJOPA ACBAGFKJEHC()
	{
		return default(GLGFFNDJOPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC3A780", Offset = "0xC38D80", VA = "0x180C3A780", Slot = "22")]
	public override float DIDCKMEMGLJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA070", Offset = "0x8FD8670", VA = "0x188FDA070", Slot = "23")]
	public override void DCKEJCDHPAA(ICFDOFGDKLP EEPEOPEEIMF, NFHBMFGADGC LHLGMDKHPPH, int FFODKKIHDLN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8FDAE40", Offset = "0x8FD9440", VA = "0x188FDAE40")]
	private int NNAJFAOCHJB(ICFDOFGDKLP EEPEOPEEIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA5C0", Offset = "0x8FD8BC0", VA = "0x188FDA5C0", Slot = "24")]
	public override HGOECGDMDII DPJMNCKNNHF()
	{
		return default(HGOECGDMDII);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8FDB030", Offset = "0x8FD9630", VA = "0x188FDB030", Slot = "26")]
	public override APGLOIBBEMN NNAJOJAAOLD()
	{
		return default(APGLOIBBEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8FDA690", Offset = "0x8FD8C90", VA = "0x188FDA690", Slot = "27")]
	public override NHFEFALFGMD MJHABLBJGML(ICFDOFGDKLP EEPEOPEEIMF, JobHandle ELCAJJNPFBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface NLDMEBHDACL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PHMEFGAKKMP BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EJNEODLGIID BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	AOFJCEPPDBM BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class ELMFABLCBLL : IPGDEIOBDCB, IDisposable, NLDMEBHDACL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AKOBECBEECF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ELMFABLCBLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8FD75C0", Offset = "0x8FD5BC0", VA = "0x188FD75C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7B40", Offset = "0x8FD6140", VA = "0x188FD7B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly OKNHHPCOKDF<MOELEHFPCPE, PHMEFGAKKMP> JKIOKCNIJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly OKNHHPCOKDF<IFOKEJDEOGF, EJNEODLGIID> IIAOGHHEBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly OKNHHPCOKDF<AMGLFNOLFKB, AOFJCEPPDBM> IGCEAMAPNFG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PHMEFGAKKMP BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8FDF6A0", Offset = "0x8FDDCA0", VA = "0x188FDF6A0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public EJNEODLGIID BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8FDF5E0", Offset = "0x8FDDBE0", VA = "0x188FDF5E0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AOFJCEPPDBM BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8FDF640", Offset = "0x8FDDC40", VA = "0x188FDF640", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IHJNEAHJLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC00D60", Offset = "0xBFF360", VA = "0x180C00D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE0C40", Offset = "0x8FDF240", VA = "0x188FE0C40")]
	public ELMFABLCBLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8FDEE60", Offset = "0x8FDD460", VA = "0x188FDEE60", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8FDFAF0", Offset = "0x8FDE0F0", VA = "0x188FDFAF0", Slot = "4")]
	public MOELEHFPCPE JAPOBCDIJPN(BGNDGMGKLOG DAJAOHIJHHL)
	{
		return default(MOELEHFPCPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8FDF870", Offset = "0x8FDDE70", VA = "0x188FDF870", Slot = "5")]
	public MOELEHFPCPE JAPOBCDIJPN(BGNDGMGKLOG DAJAOHIJHHL, bool IFMPCDPOCJF)
	{
		return default(MOELEHFPCPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8FE09E0", Offset = "0x8FDEFE0", VA = "0x188FE09E0", Slot = "6")]
	public void PFICJPMALCG(MOELEHFPCPE PPOKNBNEDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8FDEA90", Offset = "0x8FDD090", VA = "0x188FDEA90", Slot = "7")]
	public void DDCMCGKHKIJ(MOELEHFPCPE PPOKNBNEDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8FDFF80", Offset = "0x8FDE580", VA = "0x188FDFF80", Slot = "8")]
	public IFOKEJDEOGF LDFKKLCMFAF(MOELEHFPCPE PPOKNBNEDHM, KINPHOMJCLM DAJAOHIJHHL)
	{
		return default(IFOKEJDEOGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8FDF100", Offset = "0x8FDD700", VA = "0x188FDF100", Slot = "9")]
	public IFOKEJDEOGF ELIGFFJCPJP(MOELEHFPCPE PPOKNBNEDHM, FOCDFGPPKDG DAJAOHIJHHL)
	{
		return default(IFOKEJDEOGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8FE0620", Offset = "0x8FDEC20", VA = "0x188FE0620", Slot = "11")]
	public void OGHMMCDDPLB(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8FDFB60", Offset = "0x8FDE160", VA = "0x188FDFB60", Slot = "10")]
	public void KMABDPIPIJB(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8FDEDF0", Offset = "0x8FDD3F0", VA = "0x188FDEDF0", Slot = "20")]
	public IEnumerable<Renderer> DDIOPHDLELO(MOELEHFPCPE PPOKNBNEDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8FDF700", Offset = "0x8FDDD00", VA = "0x188FDF700", Slot = "12")]
	public AMGLFNOLFKB HLAGGKFHIGL(MDPFJBPFLFJ DAJAOHIJHHL)
	{
		return default(AMGLFNOLFKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8FDEA20", Offset = "0x8FDD020", VA = "0x188FDEA20", Slot = "14")]
	public void CHMOEIADNAC(AMGLFNOLFKB HDJAEIGPJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8FE0460", Offset = "0x8FDEA60", VA = "0x188FE0460", Slot = "16")]
	public Task MGOOPPEMAMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8FDFDC0", Offset = "0x8FDE3C0", VA = "0x188FDFDC0", Slot = "17")]
	public Task LAJCOBFKHFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8FDF030", Offset = "0x8FDD630", VA = "0x188FDF030", Slot = "18")]
	[AsyncStateMachine(typeof(AKOBECBEECF))]
	public Task EBDDJIEOMCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8FDF780", Offset = "0x8FDDD80", VA = "0x188FDF780", Slot = "19")]
	public void IAPMGJPPHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8FDFB00", Offset = "0x8FDE100", VA = "0x188FDFB00", Slot = "13")]
	public void KKNJMOJANLF(AMGLFNOLFKB HDJAEIGPJHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class GPEJEOKHCHO : EJNEODLGIID
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct DKHNIMFFBOO : NHFEFALFGMD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private KGBENKDOKKC LJNJDNJBNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> GLOCNPOOCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle ELCAJJNPFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EDKJGEHIKFD PDINMCPKHOG;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD900", Offset = "0x8FDBF00", VA = "0x188FDD900")]
		public DKHNIMFFBOO(KGBENKDOKKC LJNJDNJBNIE, NativeArray<int> GLOCNPOOCMI, JobHandle ELCAJJNPFBB, EDKJGEHIKFD PDINMCPKHOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD8A0", Offset = "0x8FDBEA0", VA = "0x188FDD8A0", Slot = "4")]
		public KGBENKDOKKC IMDIPNPDNOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD800", Offset = "0x8FDBE00", VA = "0x188FDD800", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly KINPHOMJCLM AIJFAAIOPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] HFIMIEJCLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 PAMDMMFDLIA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 PMBBNJOHGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8FE4590", Offset = "0x8FE2B90", VA = "0x188FE4590")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 NLKPPNBHMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6210", Offset = "0x8FE4810", VA = "0x188FE6210", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8FE6330", Offset = "0x8FE4930", VA = "0x188FE6330")]
	public GPEJEOKHCHO(PHMEFGAKKMP PPOKNBNEDHM, KINPHOMJCLM DAJAOHIJHHL, bool NEHIALOFDPM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8FE47C0", Offset = "0x8FE2DC0", VA = "0x188FE47C0", Slot = "18")]
	public override bool CDFCBJDHLHL(HGOECGDMDII PPOKNBNEDHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8FE3EF0", Offset = "0x8FE24F0", VA = "0x188FE3EF0", Slot = "21")]
	public override GLGFFNDJOPA ACBAGFKJEHC()
	{
		return default(GLGFFNDJOPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8FE3F30", Offset = "0x8FE2530", VA = "0x188FE3F30")]
	private GLGFFNDJOPA ACBAGFKJEHC(HGOECGDMDII PPOKNBNEDHM)
	{
		return default(GLGFFNDJOPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8FE5350", Offset = "0x8FE3950", VA = "0x188FE5350")]
	private DMHDLBKHGBK HANFKACIGAI([In] UniformTRS LOOBJEFNKFF, [In] float3 JLENBJDEIJA)
	{
		return default(DMHDLBKHGBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8FE4890", Offset = "0x8FE2E90", VA = "0x188FE4890", Slot = "19")]
	public override int CJGPHCCPIEA(ICFDOFGDKLP EEPEOPEEIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8FE6160", Offset = "0x8FE4760", VA = "0x188FE6160", Slot = "20")]
	public override int OBHAKBCDEKD(ICFDOFGDKLP EEPEOPEEIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8FE5190", Offset = "0x8FE3790", VA = "0x188FE5190", Slot = "22")]
	public override float DIDCKMEMGLJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8FE5D20", Offset = "0x8FE4320", VA = "0x188FE5D20")]
	private int NBCIIKJPADC(ICFDOFGDKLP EEPEOPEEIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8FE4940", Offset = "0x8FE2F40", VA = "0x188FE4940", Slot = "23")]
	public override void DCKEJCDHPAA(ICFDOFGDKLP EEPEOPEEIMF, NFHBMFGADGC LHLGMDKHPPH, int FFODKKIHDLN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE5280", Offset = "0x8FE3880", VA = "0x188FE5280", Slot = "24")]
	public override HGOECGDMDII DPJMNCKNNHF()
	{
		return default(HGOECGDMDII);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8FE5FA0", Offset = "0x8FE45A0", VA = "0x188FE5FA0", Slot = "26")]
	public override APGLOIBBEMN NNAJOJAAOLD()
	{
		return default(APGLOIBBEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE5550", Offset = "0x8FE3B50", VA = "0x188FE5550", Slot = "27")]
	public override NHFEFALFGMD MJHABLBJGML(ICFDOFGDKLP EEPEOPEEIMF, JobHandle ELCAJJNPFBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MPOCNBDONOC
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNFKOBLAGDF(BFKHDCBEHIE EHLAHNIAPLD, Renderer PHHDHBAFNEH, int LFLAEEJPDNO);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHICCBPFOLA(Renderer PHHDHBAFNEH, GKHANICHKNM KCBMGJBFEDC, Vector3 HMAEOJELIFN, Vector3 LCHHDDILKNF, Vector3 OHFMCOFKEEH, float APELLKBPHOD, float OMLMLHNGAPG, float BOOILILJILB = -1f, [Optional] Color? ONDGBPEOGJF, [Optional] IReadOnlyList<Camera> MGBBDOHDOCC);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLEJHCMJDOF(Renderer PHHDHBAFNEH, int LFLAEEJPDNO);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PEOOLNBEEGN();

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GMCKBFODPGE(int AALNODBMDHM, HPNEHHPMAMF EHLAHNIAPLD, Renderer PHHDHBAFNEH, int LFLAEEJPDNO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FODKIDHHACJ : KPOKAGBLPPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class NMPJEJBINDL : KNILPDPOFCI<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6F60", Offset = "0x8FE5560", VA = "0x188FE6F60")]
		public NMPJEJBINDL(string DJFMCHMDHGK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MPOCNBDONOC MIBHLEPFDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NLDMEBHDACL PFBFOMFGDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer FCGNLDAGIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private NMPJEJBINDL DMKHDECOLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool HILIOBOJADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer NNMOIMPCKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NMPJEJBINDL IKDLJFPHKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool ALKCJKJKMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer PAPKKKDCNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private NMPJEJBINDL NLEINPMPIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool GAGBIOGKPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool OPDBEINFGEH;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA94D60", Offset = "0xA93360", VA = "0x180A94D60")]
	public FODKIDHHACJ(MPOCNBDONOC OKHELEAHJMF, NLDMEBHDACL PFBFOMFGDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8FE17B0", Offset = "0x8FDFDB0", VA = "0x188FE17B0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8FE2CA0", Offset = "0x8FE12A0", VA = "0x188FE2CA0")]
	private void KPNGENNHJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8FE2520", Offset = "0x8FE0B20", VA = "0x188FE2520", Slot = "4")]
	public void HOFNGBLGAKP(MOELEHFPCPE PPOKNBNEDHM, HPNEHHPMAMF OOEPNBCGDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE2300", Offset = "0x8FE0900", VA = "0x188FE2300", Slot = "5")]
	public void HOFNGBLGAKP(IFOKEJDEOGF NDLHPLKACFL, HPNEHHPMAMF OOEPNBCGDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE2F10", Offset = "0x8FE1510", VA = "0x188FE2F10", Slot = "6")]
	public void LCMBNEGKMKG(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8FE19A0", Offset = "0x8FDFFA0", VA = "0x188FE19A0", Slot = "7")]
	public void ENJDKJGFBBO(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1960", Offset = "0x8FDFF60", VA = "0x188FE1960", Slot = "24")]
	public void EBGMDNGHEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1432980", Offset = "0x1430F80", VA = "0x181432980", Slot = "8")]
	public void BKKGGEKCFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1570", Offset = "0x8FDFB70", VA = "0x188FE1570", Slot = "9")]
	public void BDBNHDIKLDG(HPNEHHPMAMF OOEPNBCGDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8FE3C10", Offset = "0x8FE2210", VA = "0x188FE3C10", Slot = "10")]
	public void PBBKBFLAFJG(MOELEHFPCPE PPOKNBNEDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8FE38B0", Offset = "0x8FE1EB0", VA = "0x188FE38B0", Slot = "11")]
	public void PBBKBFLAFJG(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8FE2BD0", Offset = "0x8FE11D0", VA = "0x188FE2BD0", Slot = "12")]
	public void JPHGIJCJLNH(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1AF0", Offset = "0x8FE00F0", VA = "0x188FE1AF0", Slot = "13")]
	public void FBHOHOBMPFA(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8FE2960", Offset = "0x8FE0F60", VA = "0x188FE2960")]
	private void IMNHLMPDKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x15E01B0", Offset = "0x15DE7B0", VA = "0x1815E01B0", Slot = "14")]
	public void AAOGGAPGAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8FE21E0", Offset = "0x8FE07E0", VA = "0x188FE21E0", Slot = "15")]
	public void HIMKJKBMKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1C90", Offset = "0x8FE0290", VA = "0x188FE1C90", Slot = "16")]
	public void FFGDMFIGIHN(MOELEHFPCPE PPOKNBNEDHM, BFKHDCBEHIE EHLAHNIAPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1BC0", Offset = "0x8FE01C0", VA = "0x188FE1BC0", Slot = "17")]
	public void FDDFMHGLBKO(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8FE16E0", Offset = "0x8FDFCE0", VA = "0x188FE16E0", Slot = "18")]
	public void BIEAPFGADJJ(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xE08F40", Offset = "0xE07540", VA = "0x180E08F40", Slot = "19")]
	public void KPCOLBPPHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8FE2830", Offset = "0x8FE0E30", VA = "0x188FE2830", Slot = "20")]
	public void IKBNLFKPABL(BFKHDCBEHIE EHLAHNIAPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1F70", Offset = "0x8FE0570", VA = "0x188FE1F70")]
	private void GLPDKDMBIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8FE3070", Offset = "0x8FE1670", VA = "0x188FE3070", Slot = "21")]
	public void MECPHOOMCEM(MOELEHFPCPE PPOKNBNEDHM, Vector3 HMAEOJELIFN, Vector3 LCHHDDILKNF, Vector3 OHFMCOFKEEH, float APELLKBPHOD, float OMLMLHNGAPG, IReadOnlyList<Camera> FBHOBMBNCDL, GKHANICHKNM KCBMGJBFEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8FE3430", Offset = "0x8FE1A30", VA = "0x188FE3430", Slot = "22")]
	public void MECPHOOMCEM(AMGLFNOLFKB HDJAEIGPJHD, Vector3 HMAEOJELIFN, Vector3 LCHHDDILKNF, Vector3 OHFMCOFKEEH, float APELLKBPHOD, float OMLMLHNGAPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class EJNEODLGIID : JMOFFHJENDF, EFJMOLMIFDJ, DNJHNKFPKBM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly PHMEFGAKKMP KFENKPOKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int LIKFKAHEJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds KPFEKCPBBGG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds IBOBLEPGBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8FDE9F0", Offset = "0x8FDCFF0", VA = "0x188FDE9F0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool FGHKPHADDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xF07180", Offset = "0xF05780", VA = "0x180F07180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xF191C0", Offset = "0xF177C0", VA = "0x180F191C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 NLKPPNBHMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GCGHNNMHFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xC21180", Offset = "0xC1F780", VA = "0x180C21180", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public EOBJAEIIOPA MMJOILEHEHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OAPGOEENMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x22F7A70", Offset = "0x22F6070", VA = "0x1822F7A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	protected EJNEODLGIID(PHMEFGAKKMP PPOKNBNEDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8FDE820", Offset = "0x8FDCE20", VA = "0x188FDE820", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "18")]
	public virtual bool CDFCBJDHLHL(HGOECGDMDII PPOKNBNEDHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8FDEA10", Offset = "0x8FDD010", VA = "0x188FDEA10", Slot = "10")]
	public int LHHANFMHICJ(int BENJACCDJMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int CJGPHCCPIEA(ICFDOFGDKLP EEPEOPEEIMF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int OBHAKBCDEKD(ICFDOFGDKLP EEPEOPEEIMF);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract GLGFFNDJOPA ACBAGFKJEHC();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float DIDCKMEMGLJ();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void DCKEJCDHPAA(ICFDOFGDKLP EEPEOPEEIMF, NFHBMFGADGC LHLGMDKHPPH, int FFODKKIHDLN = -1);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract HGOECGDMDII DPJMNCKNNHF();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8FDE9C0", Offset = "0x8FDCFC0", VA = "0x188FDE9C0", Slot = "13")]
	public Hash128 FIHPIGMFPJJ(int EEPEOPEEIMF)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract APGLOIBBEMN NNAJOJAAOLD();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract NHFEFALFGMD MJHABLBJGML(ICFDOFGDKLP EEPEOPEEIMF, JobHandle ELCAJJNPFBB);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8FDE990", Offset = "0x8FDCF90", VA = "0x188FDE990", Slot = "12")]
	public NHFEFALFGMD FIBJHKEMEHO(int EEPEOPEEIMF)
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
		[Cpp2IlInjected.Address(RVA = "0x8FEA330", Offset = "0x8FE8930", VA = "0x188FEA330")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CPJKEIAIPGE
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NFJJCEPGDED : IEnumerable<FPPJEGJEEIP>, IEnumerable, IEnumerator<FPPJEGJEEIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private FPPJEGJEEIP <>2__current;

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
		private FPPJEGJEEIP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public NFJJCEPGDED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6DA0", Offset = "0x8FE53A0", VA = "0x188FE6DA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6F10", Offset = "0x8FE5510", VA = "0x188FE6F10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6E70", Offset = "0x8FE5470", VA = "0x188FE6E70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FPPJEGJEEIP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6E70", Offset = "0x8FE5470", VA = "0x188FE6E70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static FPPJEGJEEIP[][] ENAHEEONDFI;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static KFHJFFDPCKK CPEEADDPPNF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig MIHJJBLABMH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader EBGMFLHHJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8FDC9D0", Offset = "0x8FDAFD0", VA = "0x188FDC9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer DFMKEFMJLJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FDBB60", Offset = "0x8FDA160", VA = "0x188FDBB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8FDCA90", Offset = "0x8FDB090", VA = "0x188FDCA90")]
	[KAMEFMADCPE]
	internal static void LJDCNOCKLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8FDCBB0", Offset = "0x8FDB1B0", VA = "0x188FDCBB0")]
	public static Mesh PFHGLHEBNAF(DAKFOMKEJOH DEODIMOGECH, int EEPEOPEEIMF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8FDCB80", Offset = "0x8FDB180", VA = "0x188FDCB80")]
	public static int MDHLAPPKJFF(DAKFOMKEJOH DEODIMOGECH, int EEPEOPEEIMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8FDB790", Offset = "0x8FD9D90", VA = "0x188FDB790")]
	public static KFHJFFDPCKK DLMALMEOKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8FDCA30", Offset = "0x8FDB030", VA = "0x188FDCA30")]
	[IteratorStateMachine(typeof(NFJJCEPGDED))]
	private static IEnumerable<FPPJEGJEEIP> JCIJHMLNBJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8FDBBC0", Offset = "0x8FDA1C0", VA = "0x188FDBBC0")]
	public static FPPJEGJEEIP GCFCFGHDAND(DAKFOMKEJOH DEODIMOGECH, int EEPEOPEEIMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8FDCB90", Offset = "0x8FDB190", VA = "0x188FDCB90")]
	public static bool PCINIJCPJBK(this DAKFOMKEJOH DEODIMOGECH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8FDB9B0", Offset = "0x8FD9FB0", VA = "0x188FDB9B0")]
	public static void ENLHAKABJLF(DAKFOMKEJOH DEODIMOGECH, float3 DNMIEGGPIJE, [Out] EBALBEPPDDF DILPAPBCKNO, [Out] float3 OLGCEEPGKJO, [Out] float GDINHEKPBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8FDCC50", Offset = "0x8FDB250", VA = "0x188FDCC50")]
	public static void PKLHHMGKICG(Vector3 DNMIEGGPIJE, DAKFOMKEJOH DEODIMOGECH, [Out] Vector3 OLGCEEPGKJO, [Out] float GDINHEKPBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8FDB5A0", Offset = "0x8FD9BA0", VA = "0x188FDB5A0")]
	[MGBPHBFMPDH(0)]
	[FGLGCOAFHPJ(DAODBNEOINB.ExitingPlayMode, 0)]
	private static void BCMCMLNBELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8FDB5B0", Offset = "0x8FD9BB0", VA = "0x188FDB5B0")]
	[MGBPHBFMPDH(0)]
	[FGLGCOAFHPJ(DAODBNEOINB.ExitingPlayMode, 0)]
	private static void CEDNNIAMELF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class DOCCBPFHEEN : IPGDEIOBDCB, IDisposable, NLDMEBHDACL
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly OKNHHPCOKDF<MOELEHFPCPE, PHMEFGAKKMP> JKIOKCNIJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly OKNHHPCOKDF<IFOKEJDEOGF, EJNEODLGIID> IIAOGHHEBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly OKNHHPCOKDF<AMGLFNOLFKB, AOFJCEPPDBM> IGCEAMAPNFG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public PHMEFGAKKMP BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8FDDD90", Offset = "0x8FDC390", VA = "0x188FDDD90", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EJNEODLGIID BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8FDDD30", Offset = "0x8FDC330", VA = "0x188FDDD30", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public AOFJCEPPDBM BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8FDDDF0", Offset = "0x8FDC3F0", VA = "0x188FDDDF0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IHJNEAHJLCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xC00D60", Offset = "0xBFF360", VA = "0x180C00D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8FDE430", Offset = "0x8FDCA30", VA = "0x188FDE430")]
	public DOCCBPFHEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8FDDAC0", Offset = "0x8FDC0C0", VA = "0x188FDDAC0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8FDDED0", Offset = "0x8FDC4D0", VA = "0x188FDDED0", Slot = "4")]
	public MOELEHFPCPE JAPOBCDIJPN(BGNDGMGKLOG DAJAOHIJHHL)
	{
		return default(MOELEHFPCPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8FDDED0", Offset = "0x8FDC4D0", VA = "0x188FDDED0", Slot = "5")]
	public MOELEHFPCPE JAPOBCDIJPN(BGNDGMGKLOG DAJAOHIJHHL, bool IFMPCDPOCJF)
	{
		return default(MOELEHFPCPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8FDE340", Offset = "0x8FDC940", VA = "0x188FDE340", Slot = "6")]
	public void PFICJPMALCG(MOELEHFPCPE PPOKNBNEDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8FDD9D0", Offset = "0x8FDBFD0", VA = "0x188FDD9D0", Slot = "7")]
	public void DDCMCGKHKIJ(MOELEHFPCPE PPOKNBNEDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8FDE0D0", Offset = "0x8FDC6D0", VA = "0x188FDE0D0", Slot = "8")]
	public IFOKEJDEOGF LDFKKLCMFAF(MOELEHFPCPE PPOKNBNEDHM, KINPHOMJCLM DAJAOHIJHHL)
	{
		return default(IFOKEJDEOGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8FDDBF0", Offset = "0x8FDC1F0", VA = "0x188FDDBF0", Slot = "9")]
	public IFOKEJDEOGF ELIGFFJCPJP(MOELEHFPCPE PPOKNBNEDHM, FOCDFGPPKDG DAJAOHIJHHL)
	{
		return default(IFOKEJDEOGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8FDE2B0", Offset = "0x8FDC8B0", VA = "0x188FDE2B0", Slot = "11")]
	public void OGHMMCDDPLB(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8FDDFD0", Offset = "0x8FDC5D0", VA = "0x188FDDFD0", Slot = "10")]
	public void KMABDPIPIJB(IFOKEJDEOGF NDLHPLKACFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8FDDA50", Offset = "0x8FDC050", VA = "0x188FDDA50", Slot = "20")]
	public IEnumerable<Renderer> DDIOPHDLELO(MOELEHFPCPE PPOKNBNEDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8FDDE50", Offset = "0x8FDC450", VA = "0x188FDDE50", Slot = "12")]
	public AMGLFNOLFKB HLAGGKFHIGL(MDPFJBPFLFJ DAJAOHIJHHL)
	{
		return default(AMGLFNOLFKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8FDD960", Offset = "0x8FDBF60", VA = "0x188FDD960", Slot = "14")]
	public void CHMOEIADNAC(AMGLFNOLFKB HDJAEIGPJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8FDE210", Offset = "0x8FDC810", VA = "0x188FDE210", Slot = "16")]
	public Task MGOOPPEMAMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8FDE030", Offset = "0x8FDC630", VA = "0x188FDE030", Slot = "17")]
	public Task LAJCOBFKHFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8FDDB50", Offset = "0x8FDC150", VA = "0x188FDDB50", Slot = "18")]
	public Task EBDDJIEOMCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x298E4D0", Offset = "0x298CAD0", VA = "0x18298E4D0", Slot = "19")]
	public void IAPMGJPPHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8FDDF70", Offset = "0x8FDC570", VA = "0x188FDDF70", Slot = "13")]
	public void KKNJMOJANLF(AMGLFNOLFKB HDJAEIGPJHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CKLBAFCCKCC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool LJCBOAHFDLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material HNAADFBBDPA();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material KDFMMEICFKP();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material JIAOGAOBJNK();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EOMOAGKHEFM(JHJALLMJIFB FCGLIALLIEL);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KLGIDKKMCML(CKIILNPNIGK ILIGFFPICHG);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BMPOGNCKCEM(GameObject NDBJJGOPOFO);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BJIAAIOPIDG(GameObject NDBJJGOPOFO, bool MLANINELIDJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FGOKKPPEPBO
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static CKLBAFCCKCC FCFHEFKEJPB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool LJCBOAHFDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8FE12B0", Offset = "0x8FDF8B0", VA = "0x188FE12B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1310", Offset = "0x8FDF910", VA = "0x188FE1310")]
	public static void DBBPBICGAIC(CKLBAFCCKCC NKIAHHHFFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8FE13E0", Offset = "0x8FDF9E0", VA = "0x188FE13E0")]
	public static Material HNAADFBBDPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8FE14A0", Offset = "0x8FDFAA0", VA = "0x188FE14A0")]
	public static Material KDFMMEICFKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1440", Offset = "0x8FDFA40", VA = "0x188FE1440")]
	public static Material JIAOGAOBJNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1370", Offset = "0x8FDF970", VA = "0x188FE1370")]
	public static int EOMOAGKHEFM(JHJALLMJIFB FCGLIALLIEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8FE1500", Offset = "0x8FDFB00", VA = "0x188FE1500")]
	public static int KLGIDKKMCML(CKIILNPNIGK ILIGFFPICHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8FE11D0", Offset = "0x8FDF7D0", VA = "0x188FE11D0")]
	public static void BMPOGNCKCEM(GameObject NDBJJGOPOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE10F0", Offset = "0x8FDF6F0", VA = "0x188FE10F0")]
	public static void BJIAAIOPIDG(GameObject NDBJJGOPOFO, bool MLANINELIDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AOFJCEPPDBM : MOCGLBDJAJN
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DKGIHCMKLEL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public AOFJCEPPDBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public DKGIHCMKLEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD770", Offset = "0x8FDBD70", VA = "0x188FDD770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD400", Offset = "0x8FDBA00", VA = "0x188FDD400", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD620", Offset = "0x8FDBC20", VA = "0x188FDD620")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD720", Offset = "0x8FDBD20", VA = "0x188FDD720", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD670", Offset = "0x8FDBC70", VA = "0x188FDD670", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD670", Offset = "0x8FDBC70", VA = "0x188FDD670", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MDPFJBPFLFJ DLKJOJJGPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly NLDMEBHDACL PFBFOMFGDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private BNHAJJFNALD NDEGHEMDJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<PKMCDKHMKMA> NNHFIIKPOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<PKMCDKHMKMA> KKIOHIFDDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject AFFIMCCKKIH;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8280", Offset = "0x8FD6880", VA = "0x188FD8280")]
	public static AOFJCEPPDBM ILICKDCFOEF(MDPFJBPFLFJ DAJAOHIJHHL, NLDMEBHDACL PFBFOMFGDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8F40", Offset = "0x8FD7540", VA = "0x188FD8F40")]
	private AOFJCEPPDBM(MDPFJBPFLFJ DAJAOHIJHHL, NLDMEBHDACL PFBFOMFGDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8FD7BA0", Offset = "0x8FD61A0", VA = "0x188FD7BA0")]
	public void CKBKAMMKCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8E90", Offset = "0x8FD7490", VA = "0x188FD8E90")]
	[IteratorStateMachine(typeof(DKGIHCMKLEL))]
	public IEnumerable<Renderer> LNJNGOCNLEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8FD83D0", Offset = "0x8FD69D0", VA = "0x188FD83D0", Slot = "4")]
	public void IOHLBIAFPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8F10", Offset = "0x8FD7510", VA = "0x188FD8F10")]
	private void NCOJLILILLN(Vector3 IAOFCONEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8030", Offset = "0x8FD6630", VA = "0x188FD8030")]
	public void FLHPFKIPOFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PKMCDKHMKMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct ELCFKFMFOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NFHBMFGADGC DGAABOPCBDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public HGOECGDMDII EFJGCNJMLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int PLKCPCCLNDM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DAAACEOIKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public PKMCDKHMKMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public ICFDOFGDKLP lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<ELCFKFMFOEG> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public KGBENKDOKKC combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public DAAACEOIKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD2C0", Offset = "0x8FDB8C0", VA = "0x188FDD2C0")]
		internal JobHandle KHGBLAEHIPK()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD290", Offset = "0x8FDB890", VA = "0x188FDD290")]
		internal void DEMBJFOIDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8FDD120", Offset = "0x8FDB720", VA = "0x188FDD120")]
		internal void CIKMLNEEFOF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] AHIGMNKLDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JPJHHOMMBKM LHPFPGGPPNG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 IOCKPOCPJBL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh AMIAAEAIPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MHODMACGMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8FE9A90", Offset = "0x8FE8090", VA = "0x188FE9A90")]
	public void KGOHFACAEOH(List<HGOECGDMDII> EPBFJJACMHE, Matrix4x4[] CLHMPKNGEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8FE9090", Offset = "0x8FE7690", VA = "0x188FE9090")]
	public static List<PKMCDKHMKMA> EEPJBIPIECL(List<PHMEFGAKKMP> GANGAIGEFCM, ICFDOFGDKLP EEPEOPEEIMF, Bounds FBDMHHADOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8FE9720", Offset = "0x8FE7D20", VA = "0x188FE9720")]
	private JobHandle IMJFOODPBDE(KGBENKDOKKC AEINBJHJKFH, int KOOADCCLMIG, int MCHFPDKIKIK, ICFDOFGDKLP EEPEOPEEIMF, List<ELCFKFMFOEG> OFDBJIALPMI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8FE9C80", Offset = "0x8FE8280", VA = "0x188FE9C80")]
	private void LJHDPIKCOFB(List<ELCFKFMFOEG> OFDBJIALPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8FE9F00", Offset = "0x8FE8500", VA = "0x188FE9F00")]
	private PKMCDKHMKMA(List<ELCFKFMFOEG> OFDBJIALPMI, int KOOADCCLMIG, int MCHFPDKIKIK, ICFDOFGDKLP EEPEOPEEIMF, Bounds FBDMHHADOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8FE8FF0", Offset = "0x8FE75F0", VA = "0x188FE8FF0", Slot = "4")]
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
		private MaterialPropertyBlock PPMEMDAPBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private PKMCDKHMKMA LJNJDNJBNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<HGOECGDMDII> KGGMFKPKBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture BILGNCDFCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer LIFJCMMKBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader MMHABBCEDJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] MNBMBDHFPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int MIPELAAKNBE;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer KPOPHIAJCEB
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int PANJMICONFN
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB060", Offset = "0x8FE9660", VA = "0x188FEB060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA390", Offset = "0x8FE8990", VA = "0x188FEA390")]
		public static List<SkinnedShapeRenderer> Create(GameObject PPOKNBNEDHM, List<PKMCDKHMKMA> AFMMHMEHFMK, List<HGOECGDMDII> KGGMFKPKBNC, Material JKDFAJLFBEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA6E0", Offset = "0x8FE8CE0", VA = "0x188FEA6E0")]
		public void Init(PKMCDKHMKMA LJNJDNJBNIE, List<HGOECGDMDII> KGGMFKPKBNC, Material JKDFAJLFBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8FEAFC0", Offset = "0x8FE95C0", VA = "0x188FEAFC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8FEAF20", Offset = "0x8FE9520", VA = "0x188FEAF20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8FEAEE0", Offset = "0x8FE94E0", VA = "0x188FEAEE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA620", Offset = "0x8FE8C20", VA = "0x188FEA620")]
		private void HHFPPMHJIOM(ScriptableRenderContext HHPFOCCGJIF, Camera[] JLPCDCKMOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8FEAB70", Offset = "0x8FE9170", VA = "0x188FEAB70")]
		private void KGOHFACAEOH(CommandBuffer PCKGIGGFIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
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
