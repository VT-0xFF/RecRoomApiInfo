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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AFABB0", Offset = "0x8AF91B0", VA = "0x188AFABB0", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B01C80", Offset = "0x8B00280", VA = "0x188B01C80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EHOCOLKHLCD : BNNOANOOJCE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte NNHCBNGKPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] GHBAAEFKLCI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ADDJLGEIHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HGMIJMOFHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAB10B0", Offset = "0xAAF6B0", VA = "0x180AB10B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xFA8E10", Offset = "0xFA7410", VA = "0x180FA8E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GLLEGIIFOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF4CDB0", Offset = "0xF4B3B0", VA = "0x180F4CDB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x147BDF0", Offset = "0x147A3F0", VA = "0x18147BDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OFAGIIODHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD089C0", Offset = "0xD06FC0", VA = "0x180D089C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD089D0", Offset = "0xD06FD0", VA = "0x180D089D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GAIIBLELMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3BA0", Offset = "0x8AF21A0", VA = "0x188AF3BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> DNPLKKGAIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF40C0", Offset = "0x8AF26C0", VA = "0x188AF40C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject JOCLBAADBME
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte AEEAPAHCIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3B50", Offset = "0x8AF2150", VA = "0x188AF3B50", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8AF4130", Offset = "0x8AF2730", VA = "0x188AF4130")]
	public EHOCOLKHLCD(List<BEKMEGNLPIO> ECCFNOKBEBN, List<BEKMEGNLPIO> OFJGBMJJGLG, List<MBBBIPMPPEE> OCLGKPPKKKB, Material KKIOJDIOKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3BF0", Offset = "0x8AF21F0", VA = "0x188AF3BF0")]
	private int DGFCOHNBGDJ(List<BEKMEGNLPIO> GPHJGCKMMMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3F60", Offset = "0x8AF2560", VA = "0x188AF3F60")]
	private void JPIOBIINMJJ(int FADKJAPBMPM, bool FHAKDPIOOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3E10", Offset = "0x8AF2410", VA = "0x188AF3E10")]
	public void IBKLIAPPOEN(Vector3 KMCDOJDOLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3D10", Offset = "0x8AF2310", VA = "0x188AF3D10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8AF40F0", Offset = "0x8AF26F0", VA = "0x188AF40F0")]
	public void OLDOAFPFKHN(Transform GGELFJKILGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BGKPLICJPGC : PMOIGKCOEBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LBDCKFJCOKI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BGKPLICJPGC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public LBDCKFJCOKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA3E0", Offset = "0x8AF89E0", VA = "0x188AFA3E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9D80", Offset = "0x8AF8380", VA = "0x188AF9D80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9CE0", Offset = "0x8AF82E0", VA = "0x188AF9CE0")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA290", Offset = "0x8AF8890", VA = "0x188AFA290")]
		private void NECCDOCMECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9D30", Offset = "0x8AF8330", VA = "0x188AF9D30")]
		private void DFDOEBCCHJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA390", Offset = "0x8AF8990", VA = "0x188AFA390", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA2E0", Offset = "0x8AF88E0", VA = "0x188AFA2E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA2E0", Offset = "0x8AF88E0", VA = "0x188AFA2E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class KGLFEFBELFI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public BGKPLICJPGC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public KGLFEFBELFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9BB0", Offset = "0x8AF81B0", VA = "0x188AF9BB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF96F0", Offset = "0x8AF7CF0", VA = "0x188AF96F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF96A0", Offset = "0x8AF7CA0", VA = "0x188AF96A0")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9A60", Offset = "0x8AF8060", VA = "0x188AF9A60")]
		private void NECCDOCMECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9B60", Offset = "0x8AF8160", VA = "0x188AF9B60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9AB0", Offset = "0x8AF80B0", VA = "0x188AF9AB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9AB0", Offset = "0x8AF80B0", VA = "0x188AF9AB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BJELADJEHBH BONGIIPGEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<IJCMMHKHOMI> KNCFBCFANON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> MJKBHOKLBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer DDLJBEFPKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool EGGMKLHFGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool PIEBCNOFACH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<BBFFBKDDGCJ> ILOJGFKOLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AEGNMKJLEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF880", Offset = "0x8AEDE80", VA = "0x188AEF880", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MBBBIPMPPEE PECJOOHKABO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF7C0", Offset = "0x8AEDDC0", VA = "0x188AEF7C0", Slot = "8")]
		get
		{
			return default(MBBBIPMPPEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> NGLKGIJJMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8AEF8C0", Offset = "0x8AEDEC0", VA = "0x188AEF8C0")]
	private bool DCLDGHAINAK(IJCMMHKHOMI LPCNJBGEJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8AEFB50", Offset = "0x8AEE150", VA = "0x188AEFB50")]
	private static bool GMGELBLIAGK(IJCMMHKHOMI LPCNJBGEJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0BC0", Offset = "0x8AEF1C0", VA = "0x188AF0BC0")]
	public BGKPLICJPGC(BJELADJEHBH ACJFHCNBBBO, bool DIEHPMAEIHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8AEF8E0", Offset = "0x8AEDEE0", VA = "0x188AEF8E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8AF08A0", Offset = "0x8AEEEA0", VA = "0x188AF08A0")]
	public void JDPCENHCAFL(IJCMMHKHOMI LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8AEF5A0", Offset = "0x8AEDBA0", VA = "0x188AEF5A0")]
	public void BAFGFGCDOJB(IJCMMHKHOMI LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8AEFB70", Offset = "0x8AEE170", VA = "0x188AEFB70", Slot = "4")]
	public void GPJAGPJLLDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0630", Offset = "0x8AEEC30", VA = "0x188AF0630")]
	public void IEMAIHNOLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8AEF380", Offset = "0x8AED980", VA = "0x188AEF380")]
	private void AKIHJNPINBM(List<IJCMMHKHOMI> KNCFBCFANON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8AEF540", Offset = "0x8AEDB40", VA = "0x188AEF540")]
	private static Material AKKMBIIFNPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8AEF2D0", Offset = "0x8AED8D0", VA = "0x188AEF2D0")]
	private void AKIHJNPINBM(IJCMMHKHOMI LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0A70", Offset = "0x8AEF070", VA = "0x188AF0A70")]
	private void JJOBJCOCPJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0070", Offset = "0x8AEE670", VA = "0x188AF0070")]
	public void HOGHKCPDCDL(bool NOJCHAGEKBP, bool PJPAILLKPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8AEF700", Offset = "0x8AEDD00", VA = "0x188AEF700")]
	protected void BFNHOGPGPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0B40", Offset = "0x8AEF140", VA = "0x188AF0B40")]
	public void OGNCNANGLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8AEFAD0", Offset = "0x8AEE0D0", VA = "0x188AEFAD0")]
	[IteratorStateMachine(typeof(LBDCKFJCOKI))]
	public IEnumerable<Renderer> EJLDNENLIBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8AEF250", Offset = "0x8AED850", VA = "0x188AEF250")]
	[IteratorStateMachine(typeof(KGLFEFBELFI))]
	public IEnumerable<Renderer> AGCFPNFCOAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class EDEMBENACON : IJCMMHKHOMI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct PKKGNMGBECN : OOCBAIOIGAC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private JOHNDGNODKM IDMOPPBKAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle JNHDFACBLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private FBLPICJIPDL CJMFGEDFBJN;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8B001F0", Offset = "0x8AFE7F0", VA = "0x188B001F0")]
		public PKKGNMGBECN(JOHNDGNODKM IDMOPPBKAAO, JobHandle JNHDFACBLOI, FBLPICJIPDL CJMFGEDFBJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B001C0", Offset = "0x8AFE7C0", VA = "0x188B001C0", Slot = "4")]
		public JOHNDGNODKM EMDPKKLLFMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8B00170", Offset = "0x8AFE770", VA = "0x188B00170", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly MGNNCINACHN DGJOKBMGEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float LGECACBKGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 JDOMDJIMPFI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 DJDDFJGMNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2370", Offset = "0x8AF0970", VA = "0x188AF2370", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8AF36A0", Offset = "0x8AF1CA0", VA = "0x188AF36A0")]
	public EDEMBENACON(BGKPLICJPGC CMAFOEIBEKN, MGNNCINACHN ACJFHCNBBBO, bool DIEHPMAEIHE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "18")]
	public override bool FMDJKFBEANK(MBBBIPMPPEE CMAFOEIBEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1D70", Offset = "0x8AF0370", VA = "0x188AF1D70", Slot = "19")]
	public override int DGFCOHNBGDJ(PNMMMGBOHFL CLFLCICHDCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8AF34D0", Offset = "0x8AF1AD0", VA = "0x188AF34D0", Slot = "20")]
	public override int OJNHFFBCLEH(PNMMMGBOHFL CLFLCICHDCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1F40", Offset = "0x8AF0540", VA = "0x188AF1F40", Slot = "21")]
	public override CBGPOBEFNJF DKKCIACPPJL()
	{
		return default(CBGPOBEFNJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xAB1090", Offset = "0xAAF690", VA = "0x180AB1090", Slot = "22")]
	public override float GFOGEHGAENO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8AF2C50", Offset = "0x8AF1250", VA = "0x188AF2C50", Slot = "23")]
	public override void HPIODMKADEO(PNMMMGBOHFL CLFLCICHDCN, AKEMDMPFBPH HPJLKKGBLCO, int ELMBLIGGLCN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3400", Offset = "0x8AF1A00", VA = "0x188AF3400", Slot = "24")]
	public override MBBBIPMPPEE MGMBFBFIKJF()
	{
		return default(MBBBIPMPPEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3240", Offset = "0x8AF1840", VA = "0x188AF3240", Slot = "26")]
	public override FECEFLHHGDF LLLFEMFGDGG()
	{
		return default(FECEFLHHGDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF2490", Offset = "0x8AF0A90", VA = "0x188AF2490", Slot = "27")]
	public override OOCBAIOIGAC FHGOKEJIABM(PNMMMGBOHFL CLFLCICHDCN, JobHandle JNHDFACBLOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface JOPCEBNPKDF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BGKPLICJPGC FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IJCMMHKHOMI FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MKNPMCEMEAN FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class GPMGHKNJEBD : FCDPDINJFJB, IDisposable, JOPCEBNPKDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LEOFICELPKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public GPMGHKNJEBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA5D0", Offset = "0x8AF8BD0", VA = "0x188AFA5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAB50", Offset = "0x8AF9150", VA = "0x188AFAB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly JPLMPFLKABL<OMKHNGNFNIM, BGKPLICJPGC> NPCCECFDGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly JPLMPFLKABL<FINIDNMFGON, IJCMMHKHOMI> KNCFBCFANON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly JPLMPFLKABL<DNIGNMGAIOJ, MKNPMCEMEAN> CMHKBFFCOLL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BGKPLICJPGC FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8180", Offset = "0x8AF6780", VA = "0x188AF8180", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IJCMMHKHOMI FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8AF81E0", Offset = "0x8AF67E0", VA = "0x188AF81E0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MKNPMCEMEAN FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8240", Offset = "0x8AF6840", VA = "0x188AF8240", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IHOPMGCPIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAB10A0", Offset = "0xAAF6A0", VA = "0x180AB10A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAB0E60", Offset = "0xAAF460", VA = "0x180AB0E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8FF0", Offset = "0x8AF75F0", VA = "0x188AF8FF0")]
	public GPMGHKNJEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF76E0", Offset = "0x8AF5CE0", VA = "0x188AF76E0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7F10", Offset = "0x8AF6510", VA = "0x188AF7F10", Slot = "4")]
	public OMKHNGNFNIM HNLJMALFHDJ(BJELADJEHBH ACJFHCNBBBO)
	{
		return default(OMKHNGNFNIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7C90", Offset = "0x8AF6290", VA = "0x188AF7C90", Slot = "5")]
	public OMKHNGNFNIM HNLJMALFHDJ(BJELADJEHBH ACJFHCNBBBO, bool DIEHPMAEIHE)
	{
		return default(OMKHNGNFNIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8D20", Offset = "0x8AF7320", VA = "0x188AF8D20", Slot = "6")]
	public void OJIHJIFKELI(OMKHNGNFNIM CMAFOEIBEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF89C0", Offset = "0x8AF6FC0", VA = "0x188AF89C0", Slot = "7")]
	public void NMPEKCFEAIE(OMKHNGNFNIM CMAFOEIBEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6DD0", Offset = "0x8AF53D0", VA = "0x188AF6DD0", Slot = "8")]
	public FINIDNMFGON BMIKBDNKEKF(OMKHNGNFNIM CMAFOEIBEKN, HLGMNJHBLBJ ACJFHCNBBBO)
	{
		return default(FINIDNMFGON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8460", Offset = "0x8AF6A60", VA = "0x188AF8460", Slot = "9")]
	public FINIDNMFGON MDNMIGAGAJF(OMKHNGNFNIM CMAFOEIBEKN, MGNNCINACHN ACJFHCNBBBO)
	{
		return default(FINIDNMFGON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8AF72B0", Offset = "0x8AF58B0", VA = "0x188AF72B0", Slot = "11")]
	public void DFNOINOOGBK(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7F20", Offset = "0x8AF6520", VA = "0x188AF7F20", Slot = "10")]
	public void INNCJCIOLBH(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7670", Offset = "0x8AF5C70", VA = "0x188AF7670", Slot = "20")]
	public IEnumerable<Renderer> DIJNBKAOGFA(OMKHNGNFNIM CMAFOEIBEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8940", Offset = "0x8AF6F40", VA = "0x188AF8940", Slot = "12")]
	public DNIGNMGAIOJ MHFGAGNKELN(PJCCMEMFCMA ACJFHCNBBBO)
	{
		return default(DNIGNMGAIOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8F80", Offset = "0x8AF7580", VA = "0x188AF8F80", Slot = "14")]
	public void PFKJMCFNFPJ(DNIGNMGAIOJ CAGADNOIPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8AF82A0", Offset = "0x8AF68A0", VA = "0x188AF82A0", Slot = "16")]
	public Task KCOFEHFFNLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8AF79A0", Offset = "0x8AF5FA0", VA = "0x188AF79A0", Slot = "17")]
	public Task GJKFAKHHKBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7B60", Offset = "0x8AF6160", VA = "0x188AF7B60", Slot = "18")]
	[AsyncStateMachine(typeof(LEOFICELPKN))]
	public Task GOLICPLOKFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8AF78B0", Offset = "0x8AF5EB0", VA = "0x188AF78B0", Slot = "19")]
	public void EMHPKFOLEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7C30", Offset = "0x8AF6230", VA = "0x188AF7C30", Slot = "13")]
	public void HDBHNJJIACH(DNIGNMGAIOJ CAGADNOIPEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class PEOJHIIKFND : IJCMMHKHOMI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct PNMEMKIJLEN : OOCBAIOIGAC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private JOHNDGNODKM IDMOPPBKAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> GHCCLGENBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle JNHDFACBLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private AOAACPPODAJ CJMFGEDFBJN;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8B00770", Offset = "0x8AFED70", VA = "0x188B00770")]
		public PNMEMKIJLEN(JOHNDGNODKM IDMOPPBKAAO, NativeArray<int> GHCCLGENBFP, JobHandle JNHDFACBLOI, AOAACPPODAJ CJMFGEDFBJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8B00710", Offset = "0x8AFED10", VA = "0x188B00710", Slot = "4")]
		public JOHNDGNODKM EMDPKKLLFMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8B00670", Offset = "0x8AFEC70", VA = "0x188B00670", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly HLGMNJHBLBJ IKFGCCPLOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] MMFMANOFEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 JDOMDJIMPFI;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 EECLELIBNJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCBF0", Offset = "0x8AFB1F0", VA = "0x188AFCBF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 DJDDFJGMNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCAD0", Offset = "0x8AFB0D0", VA = "0x188AFCAD0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8AFE540", Offset = "0x8AFCB40", VA = "0x188AFE540")]
	public PEOJHIIKFND(BGKPLICJPGC CMAFOEIBEKN, HLGMNJHBLBJ ACJFHCNBBBO, bool HINKBNDCJOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8AFD5F0", Offset = "0x8AFBBF0", VA = "0x188AFD5F0", Slot = "18")]
	public override bool FMDJKFBEANK(MBBBIPMPPEE CMAFOEIBEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8AFC430", Offset = "0x8AFAA30", VA = "0x188AFC430", Slot = "21")]
	public override CBGPOBEFNJF DKKCIACPPJL()
	{
		return default(CBGPOBEFNJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8AFC470", Offset = "0x8AFAA70", VA = "0x188AFC470")]
	private CBGPOBEFNJF DKKCIACPPJL(MBBBIPMPPEE CMAFOEIBEKN)
	{
		return default(CBGPOBEFNJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8AFE290", Offset = "0x8AFC890", VA = "0x188AFE290")]
	private OMIDOJNADAI MNCLCLPDCGO([In] UniformTRS PJKLFNKLDGL, [In] float3 NNACFDDJPBG)
	{
		return default(OMIDOJNADAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8AFC380", Offset = "0x8AFA980", VA = "0x188AFC380", Slot = "19")]
	public override int DGFCOHNBGDJ(PNMMMGBOHFL CLFLCICHDCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8AFE490", Offset = "0x8AFCA90", VA = "0x188AFE490", Slot = "20")]
	public override int OJNHFFBCLEH(PNMMMGBOHFL CLFLCICHDCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8AFD6C0", Offset = "0x8AFBCC0", VA = "0x188AFD6C0", Slot = "22")]
	public override float GFOGEHGAENO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8AFC100", Offset = "0x8AFA700", VA = "0x188AFC100")]
	private int CCHAEOJPLNH(PNMMMGBOHFL CLFLCICHDCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8AFD7B0", Offset = "0x8AFBDB0", VA = "0x188AFD7B0", Slot = "23")]
	public override void HPIODMKADEO(PNMMMGBOHFL CLFLCICHDCN, AKEMDMPFBPH HPJLKKGBLCO, int ELMBLIGGLCN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8AFE1C0", Offset = "0x8AFC7C0", VA = "0x188AFE1C0", Slot = "24")]
	public override MBBBIPMPPEE MGMBFBFIKJF()
	{
		return default(MBBBIPMPPEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8AFE000", Offset = "0x8AFC600", VA = "0x188AFE000", Slot = "26")]
	public override FECEFLHHGDF LLLFEMFGDGG()
	{
		return default(FECEFLHHGDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8AFCE20", Offset = "0x8AFB420", VA = "0x188AFCE20", Slot = "27")]
	public override OOCBAIOIGAC FHGOKEJIABM(PNMMMGBOHFL CLFLCICHDCN, JobHandle JNHDFACBLOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PKAHJHKAJAL
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJDFOHJJGAK(MNGEOBFFJGB JLPANLJHHFI, Renderer ILMDPGBOCFL, int CEJIDDGGNHL);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMACMFAFODI(Renderer ILMDPGBOCFL, LHFILGGMHAL BIHFHFIFIHD, Vector3 OIDJJFFMDDF, Vector3 BCBAKMNONHC, Vector3 AFDKHLLGKCL, float ICDJLLAPFOK, float GJMLJNFKPJO, float PNFGLGHNONC = -1f, [Optional] Color? HFIMNHFKOFL, [Optional] IReadOnlyList<Camera> FAPIBFMCHKD);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCAINENNNHA(Renderer ILMDPGBOCFL, int CEJIDDGGNHL);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OBFLAMPKEPK();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBEAIEKNPGD(int FCNCCFAECGH, CPCDDMBJLPC JLPANLJHHFI, Renderer ILMDPGBOCFL, int CEJIDDGGNHL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FDPOIAMNMHM : GIELKEINIAC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class AFFANNODCCN : MJOBIJEHAPD<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AEDD00", Offset = "0x8AEC300", VA = "0x188AEDD00")]
		public AFFANNODCCN(string IEDAJGLJHNI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly PKAHJHKAJAL CEKNEKCFMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly JOPCEBNPKDF LDDCNIBHMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer FMGPKPMLOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private AFFANNODCCN KGPALKDIMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool LEPLHFEIIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer DIEICCPGKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private AFFANNODCCN IAKEALFPCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool OEKJCIFCNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer FKCPKLCHNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private AFFANNODCCN AAKKNIAMOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool JICMLGGKNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool DNDJADKEJII;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
	public FDPOIAMNMHM(PKAHJHKAJAL LMPCNNDDJCA, JOPCEBNPKDF LDDCNIBHMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8AF5290", Offset = "0x8AF3890", VA = "0x188AF5290", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8AF4450", Offset = "0x8AF2A50", VA = "0x188AF4450")]
	private void ABLFHCKBANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8AF5B30", Offset = "0x8AF4130", VA = "0x188AF5B30", Slot = "4")]
	public void JGGNDFLPOII(OMKHNGNFNIM CMAFOEIBEKN, CPCDDMBJLPC INCEDNPHADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8AF5E40", Offset = "0x8AF4440", VA = "0x188AF5E40", Slot = "5")]
	public void JGGNDFLPOII(FINIDNMFGON LPCNJBGEJJI, CPCDDMBJLPC INCEDNPHADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6C70", Offset = "0x8AF5270", VA = "0x188AF6C70", Slot = "6")]
	public void PEPEBNDIMDD(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF60A0", Offset = "0x8AF46A0", VA = "0x188AF60A0", Slot = "7")]
	public void KGEKPCJOKDC(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6060", Offset = "0x8AF4660", VA = "0x188AF6060", Slot = "24")]
	public void KGDLMKLEBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1170910", Offset = "0x116EF10", VA = "0x181170910", Slot = "8")]
	public void CCALJCOFIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF61F0", Offset = "0x8AF47F0", VA = "0x188AF61F0", Slot = "9")]
	public void KNCJBCDGDJJ(CPCDDMBJLPC INCEDNPHADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6630", Offset = "0x8AF4C30", VA = "0x188AF6630", Slot = "10")]
	public void OBJFDFLHPIE(OMKHNGNFNIM CMAFOEIBEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6910", Offset = "0x8AF4F10", VA = "0x188AF6910", Slot = "11")]
	public void OBJFDFLHPIE(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6560", Offset = "0x8AF4B60", VA = "0x188AF6560", Slot = "12")]
	public void NBAGEGILJND(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8AF5510", Offset = "0x8AF3B10", VA = "0x188AF5510", Slot = "13")]
	public void FFLHHNMGJCK(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8AF46C0", Offset = "0x8AF2CC0", VA = "0x188AF46C0")]
	private void AMNENOHBGNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x14AED60", Offset = "0x14AD360", VA = "0x1814AED60", Slot = "14")]
	public void JJOEPNNAEIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8AF4930", Offset = "0x8AF2F30", VA = "0x188AF4930", Slot = "15")]
	public void BIFGKHHAFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8AF55E0", Offset = "0x8AF3BE0", VA = "0x188AF55E0", Slot = "16")]
	public void GOJGFBMGHEJ(OMKHNGNFNIM CMAFOEIBEKN, MNGEOBFFJGB JLPANLJHHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6490", Offset = "0x8AF4A90", VA = "0x188AF6490", Slot = "17")]
	public void MMPEEPDHHJF(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8AF5440", Offset = "0x8AF3A40", VA = "0x188AF5440", Slot = "18")]
	public void EJBGCJCCMMF(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xD43C80", Offset = "0xD42280", VA = "0x180D43C80", Slot = "19")]
	public void LBHJEIOJIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6360", Offset = "0x8AF4960", VA = "0x188AF6360", Slot = "20")]
	public void LFHOEBGEHEG(MNGEOBFFJGB JLPANLJHHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8AF58C0", Offset = "0x8AF3EC0", VA = "0x188AF58C0")]
	private void IDNNLIGNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8AF4ED0", Offset = "0x8AF34D0", VA = "0x188AF4ED0", Slot = "21")]
	public void CDCMBKBGGDJ(OMKHNGNFNIM CMAFOEIBEKN, Vector3 OIDJJFFMDDF, Vector3 BCBAKMNONHC, Vector3 AFDKHLLGKCL, float ICDJLLAPFOK, float GJMLJNFKPJO, IReadOnlyList<Camera> PIBGGMOOKAC, LHFILGGMHAL BIHFHFIFIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8AF4A50", Offset = "0x8AF3050", VA = "0x188AF4A50", Slot = "22")]
	public void CDCMBKBGGDJ(DNIGNMGAIOJ CAGADNOIPEK, Vector3 OIDJJFFMDDF, Vector3 BCBAKMNONHC, Vector3 AFDKHLLGKCL, float ICDJLLAPFOK, float GJMLJNFKPJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class IJCMMHKHOMI : HLBJOGMMCCI, BBFFBKDDGCJ, ADPDKPABDDL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly BGKPLICJPGC JOCLBAADBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int NCGJNDHNGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds PMCBJAICIGE;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds NKCKKAMBGIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9670", Offset = "0x8AF7C70", VA = "0x188AF9670", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool PIEBCNOFACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE34390", Offset = "0xE32990", VA = "0x180E34390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xE342D0", Offset = "0xE328D0", VA = "0x180E342D0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 DJDDFJGMNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HGKMAFLKDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA9EFC0", Offset = "0xA9D5C0", VA = "0x180A9EFC0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public HADHAAMCBLK INEPJHFEELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PNFFPBBJMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF80210", Offset = "0xF7E810", VA = "0x180F80210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	protected IJCMMHKHOMI(BGKPLICJPGC CMAFOEIBEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8AF94D0", Offset = "0x8AF7AD0", VA = "0x188AF94D0", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "18")]
	public virtual bool FMDJKFBEANK(MBBBIPMPPEE CMAFOEIBEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9690", Offset = "0x8AF7C90", VA = "0x188AF9690", Slot = "10")]
	public int MAAEJLDCBGJ(int HBMDOMBIDIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int DGFCOHNBGDJ(PNMMMGBOHFL CLFLCICHDCN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int OJNHFFBCLEH(PNMMMGBOHFL CLFLCICHDCN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract CBGPOBEFNJF DKKCIACPPJL();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float GFOGEHGAENO();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void HPIODMKADEO(PNMMMGBOHFL CLFLCICHDCN, AKEMDMPFBPH HPJLKKGBLCO, int ELMBLIGGLCN = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract MBBBIPMPPEE MGMBFBFIKJF();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9640", Offset = "0x8AF7C40", VA = "0x188AF9640", Slot = "13")]
	public Hash128 ECHILGPGPHJ(int CLFLCICHDCN)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract FECEFLHHGDF LLLFEMFGDGG();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract OOCBAIOIGAC FHGOKEJIABM(PNMMMGBOHFL CLFLCICHDCN, JobHandle JNHDFACBLOI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8AF94A0", Offset = "0x8AF7AA0", VA = "0x188AF94A0", Slot = "12")]
	public OOCBAIOIGAC DPGOKLFOEEK(int CLFLCICHDCN)
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
		[Cpp2IlInjected.Address(RVA = "0x8B007D0", Offset = "0x8AFEDD0", VA = "0x188B007D0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PHELFIAJHJN
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BFCKLFDJKPM : IEnumerable<OGHJCIFIOAO>, IEnumerable, IEnumerator<OGHJCIFIOAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private OGHJCIFIOAO <>2__current;

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
		private OGHJCIFIOAO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public BFCKLFDJKPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF090", Offset = "0x8AED690", VA = "0x188AEF090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF200", Offset = "0x8AED800", VA = "0x188AEF200", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF160", Offset = "0x8AED760", VA = "0x188AEF160", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OGHJCIFIOAO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF160", Offset = "0x8AED760", VA = "0x188AEF160", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static OGHJCIFIOAO[][] JEOECPDPNPB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static GDMABCGDCIE EKNPHHIGNNF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig LOCAALBGGJL;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader DJOIPDIADBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE600", Offset = "0x8AFCC00", VA = "0x188AFE600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer DGDIINAJGFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE660", Offset = "0x8AFCC60", VA = "0x188AFE660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8AFED50", Offset = "0x8AFD350", VA = "0x188AFED50")]
	[LDNNADOHHJB]
	internal static void FLMOPKJJIJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8AFECB0", Offset = "0x8AFD2B0", VA = "0x188AFECB0")]
	public static Mesh FGCBPPGBIOC(ACIKMAHKONI KHNBINJDLAH, int CLFLCICHDCN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8AFF1D0", Offset = "0x8AFD7D0", VA = "0x188AFF1D0")]
	public static int JEIIGFCKALK(ACIKMAHKONI KHNBINJDLAH, int CLFLCICHDCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8AFE6C0", Offset = "0x8AFCCC0", VA = "0x188AFE6C0")]
	public static GDMABCGDCIE DBEPGHNJPJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8AFF1E0", Offset = "0x8AFD7E0", VA = "0x188AFF1E0")]
	[IteratorStateMachine(typeof(BFCKLFDJKPM))]
	private static IEnumerable<OGHJCIFIOAO> NDDAGHOPLAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8AFF260", Offset = "0x8AFD860", VA = "0x188AFF260")]
	public static OGHJCIFIOAO PKKGAPHIEEC(ACIKMAHKONI KHNBINJDLAH, int CLFLCICHDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8AFF240", Offset = "0x8AFD840", VA = "0x188AFF240")]
	public static bool OLMCPMOIHPK(this ACIKMAHKONI KHNBINJDLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8AFF020", Offset = "0x8AFD620", VA = "0x188AFF020")]
	public static void JCCAGCLFBLC(ACIKMAHKONI KHNBINJDLAH, float3 JDOFMBIFOFM, [Out] DDEGPPICJGJ LCDMHEBCDBL, [Out] float3 FPABNANKOEH, [Out] float IFGGDEDJJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8AFE8E0", Offset = "0x8AFCEE0", VA = "0x188AFE8E0")]
	public static void FAAAFFPEEAA(Vector3 JDOFMBIFOFM, ACIKMAHKONI KHNBINJDLAH, [Out] Vector3 FPABNANKOEH, [Out] float IFGGDEDJJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8AFE5F0", Offset = "0x8AFCBF0", VA = "0x188AFE5F0")]
	[NKGCGBJADIK(0)]
	[IEDOGDIKGGL(DEKJCOCACDG.ExitingPlayMode, 0)]
	private static void ACDKMOJLHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8AFEE40", Offset = "0x8AFD440", VA = "0x188AFEE40")]
	[NKGCGBJADIK(0)]
	[IEDOGDIKGGL(DEKJCOCACDG.ExitingPlayMode, 0)]
	private static void FPMLDBNHHOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class DAEKBLOFKML : FCDPDINJFJB, IDisposable, JOPCEBNPKDF
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly JPLMPFLKABL<OMKHNGNFNIM, BGKPLICJPGC> NPCCECFDGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly JPLMPFLKABL<FINIDNMFGON, IJCMMHKHOMI> KNCFBCFANON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly JPLMPFLKABL<DNIGNMGAIOJ, MKNPMCEMEAN> CMHKBFFCOLL;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public BGKPLICJPGC FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8AF14E0", Offset = "0x8AEFAE0", VA = "0x188AF14E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IJCMMHKHOMI FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1420", Offset = "0x8AEFA20", VA = "0x188AF1420", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public MKNPMCEMEAN FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1480", Offset = "0x8AEFA80", VA = "0x188AF1480", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IHOPMGCPIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xAB10A0", Offset = "0xAAF6A0", VA = "0x180AB10A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAB0E60", Offset = "0xAAF460", VA = "0x180AB0E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1980", Offset = "0x8AEFF80", VA = "0x188AF1980")]
	public DAEKBLOFKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8AF10F0", Offset = "0x8AEF6F0", VA = "0x188AF10F0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1320", Offset = "0x8AEF920", VA = "0x188AF1320", Slot = "4")]
	public OMKHNGNFNIM HNLJMALFHDJ(BJELADJEHBH ACJFHCNBBBO)
	{
		return default(OMKHNGNFNIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1320", Offset = "0x8AEF920", VA = "0x188AF1320", Slot = "5")]
	public OMKHNGNFNIM HNLJMALFHDJ(BJELADJEHBH ACJFHCNBBBO, bool DIEHPMAEIHE)
	{
		return default(OMKHNGNFNIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1820", Offset = "0x8AEFE20", VA = "0x188AF1820", Slot = "6")]
	public void OJIHJIFKELI(OMKHNGNFNIM CMAFOEIBEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8AF17A0", Offset = "0x8AEFDA0", VA = "0x188AF17A0", Slot = "7")]
	public void NMPEKCFEAIE(OMKHNGNFNIM CMAFOEIBEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0EB0", Offset = "0x8AEF4B0", VA = "0x188AF0EB0", Slot = "8")]
	public FINIDNMFGON BMIKBDNKEKF(OMKHNGNFNIM CMAFOEIBEKN, HLGMNJHBLBJ ACJFHCNBBBO)
	{
		return default(FINIDNMFGON);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8AF15E0", Offset = "0x8AEFBE0", VA = "0x188AF15E0", Slot = "9")]
	public FINIDNMFGON MDNMIGAGAJF(OMKHNGNFNIM CMAFOEIBEKN, MGNNCINACHN ACJFHCNBBBO)
	{
		return default(FINIDNMFGON);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0FF0", Offset = "0x8AEF5F0", VA = "0x188AF0FF0", Slot = "11")]
	public void DFNOINOOGBK(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8AF13C0", Offset = "0x8AEF9C0", VA = "0x188AF13C0", Slot = "10")]
	public void INNCJCIOLBH(FINIDNMFGON LPCNJBGEJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1080", Offset = "0x8AEF680", VA = "0x188AF1080", Slot = "20")]
	public IEnumerable<Renderer> DIJNBKAOGFA(OMKHNGNFNIM CMAFOEIBEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1720", Offset = "0x8AEFD20", VA = "0x188AF1720", Slot = "12")]
	public DNIGNMGAIOJ MHFGAGNKELN(PJCCMEMFCMA ACJFHCNBBBO)
	{
		return default(DNIGNMGAIOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1880", Offset = "0x8AEFE80", VA = "0x188AF1880", Slot = "14")]
	public void PFKJMCFNFPJ(DNIGNMGAIOJ CAGADNOIPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1540", Offset = "0x8AEFB40", VA = "0x188AF1540", Slot = "16")]
	public Task KCOFEHFFNLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1180", Offset = "0x8AEF780", VA = "0x188AF1180", Slot = "17")]
	public Task GJKFAKHHKBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1220", Offset = "0x8AEF820", VA = "0x188AF1220", Slot = "18")]
	public Task GOLICPLOKFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x285B290", Offset = "0x2859890", VA = "0x18285B290", Slot = "19")]
	public void EMHPKFOLEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8AF12C0", Offset = "0x8AEF8C0", VA = "0x188AF12C0", Slot = "13")]
	public void HDBHNJJIACH(DNIGNMGAIOJ CAGADNOIPEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CMPGJIPLOGF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool NBMKIGCEPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material LHOAHCIMPMN();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material AKKMBIIFNPB();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material DBNEMIEHIKD();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PJNIGNIPGNM(NGNKOEFODLB PKHIBHGLMED);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OOGOKCMOCJD(FFLLKLIPNGD LCDJNLHGEMP);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OAJGMFINPAG(GameObject ODCICEDDLMB);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ICIHPJNGFJF(GameObject ODCICEDDLMB, bool FPNBLBKHFDG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PKKMNKEMEDJ
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static CMPGJIPLOGF FIAONBPCJJK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool NBMKIGCEPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8B00450", Offset = "0x8AFEA50", VA = "0x188B00450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8B00250", Offset = "0x8AFE850", VA = "0x188B00250")]
	public static void CGAAOMCEFEP(CMPGJIPLOGF MMJKOEHAOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8B003F0", Offset = "0x8AFE9F0", VA = "0x188B003F0")]
	public static Material LHOAHCIMPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8AEF540", Offset = "0x8AEDB40", VA = "0x188AEF540")]
	public static Material AKKMBIIFNPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8B002B0", Offset = "0x8AFE8B0", VA = "0x188B002B0")]
	public static Material DBNEMIEHIKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8B00600", Offset = "0x8AFEC00", VA = "0x188B00600")]
	public static int PJNIGNIPGNM(NGNKOEFODLB PKHIBHGLMED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8B00590", Offset = "0x8AFEB90", VA = "0x188B00590")]
	public static int OOGOKCMOCJD(FFLLKLIPNGD LCDJNLHGEMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8B004B0", Offset = "0x8AFEAB0", VA = "0x188B004B0")]
	public static void OAJGMFINPAG(GameObject ODCICEDDLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8B00310", Offset = "0x8AFE910", VA = "0x188B00310")]
	public static void ICIHPJNGFJF(GameObject ODCICEDDLMB, bool FPNBLBKHFDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MKNPMCEMEAN : PMOIGKCOEBM
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EFIOFIKIJOD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public MKNPMCEMEAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public EFIOFIKIJOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3AC0", Offset = "0x8AF20C0", VA = "0x188AF3AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8AF37A0", Offset = "0x8AF1DA0", VA = "0x188AF37A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3750", Offset = "0x8AF1D50", VA = "0x188AF3750")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3A70", Offset = "0x8AF2070", VA = "0x188AF3A70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8AF39C0", Offset = "0x8AF1FC0", VA = "0x188AF39C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8AF39C0", Offset = "0x8AF1FC0", VA = "0x188AF39C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PJCCMEMFCMA IGALLLOPECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JOPCEBNPKDF LDDCNIBHMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private EHOCOLKHLCD KKEFFOLPMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<BEKMEGNLPIO> JKDDLEDKJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<BEKMEGNLPIO> JJBFOOKAODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject IMGALHLGBFJ;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8AFBED0", Offset = "0x8AFA4D0", VA = "0x188AFBED0")]
	public static MKNPMCEMEAN LDGPJLJDJHD(PJCCMEMFCMA ACJFHCNBBBO, JOPCEBNPKDF LDDCNIBHMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8AFC020", Offset = "0x8AFA620", VA = "0x188AFC020")]
	private MKNPMCEMEAN(PJCCMEMFCMA ACJFHCNBBBO, JOPCEBNPKDF LDDCNIBHMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8AFAC80", Offset = "0x8AF9280", VA = "0x188AFAC80")]
	public void DIGOPEEDGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB110", Offset = "0x8AF9710", VA = "0x188AFB110")]
	[IteratorStateMachine(typeof(EFIOFIKIJOD))]
	public IEnumerable<Renderer> EJLDNENLIBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB1C0", Offset = "0x8AF97C0", VA = "0x188AFB1C0", Slot = "4")]
	public void GPJAGPJLLDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB190", Offset = "0x8AF9790", VA = "0x188AFB190")]
	private void FCNEHHBIKEG(Vector3 KMCDOJDOLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8AFBC80", Offset = "0x8AFA280", VA = "0x188AFBC80")]
	public void IEMAIHNOLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BEKMEGNLPIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct ACPFFGABOFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AKEMDMPFBPH MBDFBEFEGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MBBBIPMPPEE CPFOFOGEIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int BDHMAAEGHGD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BIGAOFONHGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public BEKMEGNLPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public PNMMMGBOHFL lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<ACPFFGABOFB> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JOHNDGNODKM combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BIGAOFONHGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0E50", Offset = "0x8AEF450", VA = "0x188AF0E50")]
		internal JobHandle NFGNFMIJEJA()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0E20", Offset = "0x8AEF420", VA = "0x188AF0E20")]
		internal void FFKCNBPCPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0CB0", Offset = "0x8AEF2B0", VA = "0x188AF0CB0")]
		internal void ALELCJHCDKL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] HHCLJKADMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private EGGLDELOPFF JNBLLOGGCJO;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 FECJFPFKNDL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh GAMNJOHBFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int FPAGOELIBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8AEE240", Offset = "0x8AEC840", VA = "0x188AEE240")]
	public void LGMNBEHDLEG(List<MBBBIPMPPEE> GJLILJOFEOF, Matrix4x4[] ILBGOOCIPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8AEE430", Offset = "0x8AECA30", VA = "0x188AEE430")]
	public static List<BEKMEGNLPIO> MMBKOMPANAO(List<BGKPLICJPGC> AEBCBFMLEFP, PNMMMGBOHFL CLFLCICHDCN, Bounds ACMLBEHJCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8AEDDF0", Offset = "0x8AEC3F0", VA = "0x188AEDDF0")]
	private JobHandle EOBPLPEDEFO(JOHNDGNODKM ANIIKMMNHMF, int MNAPDCDOKHC, int IGENIDBBLGE, PNMMMGBOHFL CLFLCICHDCN, List<ACPFFGABOFB> OGBIOLLLCNO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8AEE160", Offset = "0x8AEC760", VA = "0x188AEE160")]
	private void GOCAIIDKAPL(List<ACPFFGABOFB> OGBIOLLLCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8AEEC60", Offset = "0x8AED260", VA = "0x188AEEC60")]
	private BEKMEGNLPIO(List<ACPFFGABOFB> OGBIOLLLCNO, int MNAPDCDOKHC, int IGENIDBBLGE, PNMMMGBOHFL CLFLCICHDCN, Bounds ACMLBEHJCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8AEDD50", Offset = "0x8AEC350", VA = "0x188AEDD50", Slot = "4")]
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
		private MaterialPropertyBlock BPAKNPHJGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private BEKMEGNLPIO IDMOPPBKAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<MBBBIPMPPEE> OCLGKPPKKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture EIGJCIHLJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer KAGMOBPHPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader NMNJCFCLHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] KFJBDKMBFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int BHHACPPHDFJ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer KIBKJKNEALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int LGPLNAMDGFP
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8B01500", Offset = "0x8AFFB00", VA = "0x188B01500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8B00830", Offset = "0x8AFEE30", VA = "0x188B00830")]
		public static List<SkinnedShapeRenderer> Create(GameObject CMAFOEIBEKN, List<BEKMEGNLPIO> GPHJGCKMMMI, List<MBBBIPMPPEE> OCLGKPPKKKB, Material KKIOJDIOKCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8B00B80", Offset = "0x8AFF180", VA = "0x188B00B80")]
		public void Init(BEKMEGNLPIO IDMOPPBKAAO, List<MBBBIPMPPEE> OCLGKPPKKKB, Material KKIOJDIOKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8B01460", Offset = "0x8AFFA60", VA = "0x188B01460")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8B013C0", Offset = "0x8AFF9C0", VA = "0x188B013C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8B01380", Offset = "0x8AFF980", VA = "0x188B01380")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8B00AC0", Offset = "0x8AFF0C0", VA = "0x188B00AC0")]
		private void FEKLLMOJKIK(ScriptableRenderContext HILCMKALFIH, Camera[] BDPKBKFAADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8B01010", Offset = "0x8AFF610", VA = "0x188B01010")]
		private void LGMNBEHDLEG(CommandBuffer FFKNKOEBEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
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
