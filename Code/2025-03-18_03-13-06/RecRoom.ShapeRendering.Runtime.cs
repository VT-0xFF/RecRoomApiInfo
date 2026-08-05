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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8073590", Offset = "0x8072790", VA = "0x188073590", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x807D2C0", Offset = "0x807C4C0", VA = "0x18807D2C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MLLNMNFNJAO : IOMFBDBLEKI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte FEPKMCBHIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] KAFPEFJIMHE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JCOLFCGLFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB96CB0", Offset = "0xB95EB0", VA = "0x180B96CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BJJDKBNADPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC156D0", Offset = "0xC148D0", VA = "0x180C156D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDB4A90", Offset = "0xDB3C90", VA = "0x180DB4A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JJHPAEKFJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDEFA00", Offset = "0xDEEC00", VA = "0x180DEFA00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x108E200", Offset = "0x108D400", VA = "0x18108E200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float IEKCIKFNIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB5B280", Offset = "0xB5A480", VA = "0x180B5B280", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB5B290", Offset = "0xB5A490", VA = "0x180B5B290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> MGNIHJJJPDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80742A0", Offset = "0x80734A0", VA = "0x1880742A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> OJPHNANKEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8074440", Offset = "0x8073640", VA = "0x188074440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject GMOCPPMLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x968CE0", Offset = "0x967EE0", VA = "0x180968CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte GOJKJINDPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80743F0", Offset = "0x80735F0", VA = "0x1880743F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8074610", Offset = "0x8073810", VA = "0x188074610")]
	public MLLNMNFNJAO(List<GAJABJOBPAC> DOGGCONBPMB, List<GAJABJOBPAC> EAEJNIKCFPB, List<MOCOMOJHGBP> GILMLJNJOPM, Material MDMIJJAMBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8074180", Offset = "0x8073380", VA = "0x188074180")]
	private int CCKGGKEPFHP(List<GAJABJOBPAC> CHFILKKILHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80744B0", Offset = "0x80736B0", VA = "0x1880744B0")]
	private void LFGMNPPILGH(int GKGMGNDMMAC, bool NNBKKFCHIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8074030", Offset = "0x8073230", VA = "0x188074030")]
	public void BEJBPBNJOLE(Vector3 FFCOKGHPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80742F0", Offset = "0x80734F0", VA = "0x1880742F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8074470", Offset = "0x8073670", VA = "0x188074470")]
	public void IENOBOIHNON(Transform DLKMKOPHELE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PEKOBBONACI : EIFEHEJKCMG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MIOILJLACAE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PEKOBBONACI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public MIOILJLACAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8073D60", Offset = "0x8072F60", VA = "0x188073D60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8073700", Offset = "0x8072900", VA = "0x188073700", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8073C10", Offset = "0x8072E10", VA = "0x188073C10")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80736B0", Offset = "0x80728B0", VA = "0x1880736B0")]
		private void HEIMKCGCNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8073660", Offset = "0x8072860", VA = "0x188073660")]
		private void CABLHNEOALI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8073D10", Offset = "0x8072F10", VA = "0x188073D10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8073C60", Offset = "0x8072E60", VA = "0x188073C60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8073C60", Offset = "0x8072E60", VA = "0x188073C60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FNGANHBDPLP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PEKOBBONACI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public FNGANHBDPLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x806A550", Offset = "0x8069750", VA = "0x18806A550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x806A090", Offset = "0x8069290", VA = "0x18806A090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x806A400", Offset = "0x8069600", VA = "0x18806A400")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x806A040", Offset = "0x8069240", VA = "0x18806A040")]
		private void HEIMKCGCNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x806A500", Offset = "0x8069700", VA = "0x18806A500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x806A450", Offset = "0x8069650", VA = "0x18806A450", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x806A450", Offset = "0x8069650", VA = "0x18806A450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OCMFLIKNIPB FILBIOEHLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<IOMAKAMPLJM> NDDDNBMFFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> POHJDNJBMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer KNPBNFDIKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool JCGOFGCBCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool BBNDJJNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<NCDFOHJIFEI> FDEOPLCEAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IAMAPDPIMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8076560", Offset = "0x8075760", VA = "0x188076560", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MOCOMOJHGBP BPFNJJABFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8076A80", Offset = "0x8075C80", VA = "0x188076A80", Slot = "8")]
		get
		{
			return default(MOCOMOJHGBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> DJPKKIFLLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x964F40", Offset = "0x964140", VA = "0x180964F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8076C40", Offset = "0x8075E40", VA = "0x188076C40")]
	private bool LCGIFBNHLKJ(IOMAKAMPLJM ADJAHFEDDPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8076B50", Offset = "0x8075D50", VA = "0x188076B50")]
	private static bool JIKHDIMNHPK(IOMAKAMPLJM ADJAHFEDDPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8077280", Offset = "0x8076480", VA = "0x188077280")]
	public PEKOBBONACI(OCMFLIKNIPB LJELDKAOCJM, bool BGDBGAENBAC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8076810", Offset = "0x8075A10", VA = "0x188076810", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8076ED0", Offset = "0x80760D0", VA = "0x188076ED0")]
	public void OFEFHMDJLMD(IOMAKAMPLJM ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x80770A0", Offset = "0x80762A0", VA = "0x1880770A0")]
	public void OGPGHNCGHLC(IOMAKAMPLJM ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8075970", Offset = "0x8074B70", VA = "0x188075970", Slot = "4")]
	public void BADAGFACFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x80765A0", Offset = "0x80757A0", VA = "0x1880765A0")]
	public void DJHAIOPCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8076D10", Offset = "0x8075F10", VA = "0x188076D10")]
	private void OEAKHNJFDCM(List<IOMAKAMPLJM> NDDDNBMFFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80699B0", Offset = "0x8068BB0", VA = "0x1880699B0")]
	private static Material OCONPOJGHAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8076C60", Offset = "0x8075E60", VA = "0x188076C60")]
	private void OEAKHNJFDCM(IOMAKAMPLJM ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8076B70", Offset = "0x8075D70", VA = "0x188076B70")]
	private void KLELPFKGCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8075EF0", Offset = "0x80750F0", VA = "0x188075EF0")]
	public void BNGKLPOBKCC(bool AABPFIPJJPI, bool IFOMMBILMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80764A0", Offset = "0x80756A0", VA = "0x1880764A0")]
	protected void CFCEDIACJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8076A00", Offset = "0x8075C00", VA = "0x188076A00")]
	public void FKEAMCPMAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8077200", Offset = "0x8076400", VA = "0x188077200")]
	[IteratorStateMachine(typeof(MIOILJLACAE))]
	public IEnumerable<Renderer> PEEDFFIEFMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8075E70", Offset = "0x8075070", VA = "0x188075E70")]
	[IteratorStateMachine(typeof(FNGANHBDPLP))]
	public IEnumerable<Renderer> BAHFNCDJALE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class JENHMDCABCK : IOMAKAMPLJM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct MKKOBAKOEMH : ONLMDMENCJE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MKEMNAEEJEC CJONLLGJGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle IBAHKKADFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private GFNDLNHDHCN CCELFLJNBAJ;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8073FD0", Offset = "0x80731D0", VA = "0x188073FD0")]
		public MKKOBAKOEMH(MKEMNAEEJEC CJONLLGJGEO, JobHandle IBAHKKADFPN, GFNDLNHDHCN CCELFLJNBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8073FA0", Offset = "0x80731A0", VA = "0x188073FA0", Slot = "4")]
		public MKEMNAEEJEC EBLGNCPCOGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8073F50", Offset = "0x8073150", VA = "0x188073F50", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly FLIGGIIDKOK OOJPBDBOOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float ALPAFJMKJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 NEDMJCKKPGL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 JLBFNBABIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8071660", Offset = "0x8070860", VA = "0x188071660", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8071F40", Offset = "0x8071140", VA = "0x188071F40")]
	public JENHMDCABCK(PEKOBBONACI BFPPPKIAFBG, FLIGGIIDKOK LJELDKAOCJM, bool BGDBGAENBAC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "18")]
	public override bool CJGPDLEEOMH(MOCOMOJHGBP BFPPPKIAFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8070DE0", Offset = "0x806FFE0", VA = "0x188070DE0", Slot = "19")]
	public override int CCKGGKEPFHP(NKGLGKDLFIP KADDNMPDABI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8071790", Offset = "0x8070990", VA = "0x188071790", Slot = "20")]
	public override int HNEFFPBLFJE(NKGLGKDLFIP KADDNMPDABI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8071B10", Offset = "0x8070D10", VA = "0x188071B10", Slot = "21")]
	public override GCAMAGHAEJE PFHEEDALGLJ()
	{
		return default(GCAMAGHAEJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xB08D00", Offset = "0xB07F00", VA = "0x180B08D00", Slot = "22")]
	public override float GDAPDPPJOFF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8071080", Offset = "0x8070280", VA = "0x188071080", Slot = "23")]
	public override void EGMAGOLIPIP(NKGLGKDLFIP KADDNMPDABI, KEEBJKJHOAM LHDEBLCKCJF, int IEKMPJOCCEL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8070FB0", Offset = "0x80701B0", VA = "0x188070FB0", Slot = "24")]
	public override MOCOMOJHGBP CMKHMOFPIMB()
	{
		return default(MOCOMOJHGBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8071960", Offset = "0x8070B60", VA = "0x188071960", Slot = "26")]
	public override LEODOLMIKLM NHFEAPLIMCI()
	{
		return default(LEODOLMIKLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8070610", Offset = "0x806F810", VA = "0x188070610", Slot = "27")]
	public override ONLMDMENCJE BLAHLCHDBHM(NKGLGKDLFIP KADDNMPDABI, JobHandle IBAHKKADFPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface GGFEFPBMHJM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PEKOBBONACI EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IOMAKAMPLJM EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JNENAAGMFJF EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class POALPGOGJAJ : IGEBAHMFCMN, IDisposable, GGFEFPBMHJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EODMHLBHEHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public POALPGOGJAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8069A80", Offset = "0x8068C80", VA = "0x188069A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8069FE0", Offset = "0x80691E0", VA = "0x188069FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly CPHCCEMMPHG<OMLFPKHBOMD, PEKOBBONACI> KAOPDPDGEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly CPHCCEMMPHG<OKPBHDAFLPP, IOMAKAMPLJM> NDDDNBMFFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly CPHCCEMMPHG<HGPFMFLDJEH, JNENAAGMFJF> KKNGDKEPCFH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PEKOBBONACI EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x807AC10", Offset = "0x8079E10", VA = "0x18807AC10", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IOMAKAMPLJM EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x807ABB0", Offset = "0x8079DB0", VA = "0x18807ABB0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public JNENAAGMFJF EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x807AB50", Offset = "0x8079D50", VA = "0x18807AB50", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool JKLDHBHJCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xCE51A0", Offset = "0xCE43A0", VA = "0x180CE51A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCE50A0", Offset = "0xCE42A0", VA = "0x180CE50A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x807B9B0", Offset = "0x807ABB0", VA = "0x18807B9B0")]
	public POALPGOGJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x807A1A0", Offset = "0x80793A0", VA = "0x18807A1A0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8079860", Offset = "0x8078A60", VA = "0x188079860", Slot = "4")]
	public OMLFPKHBOMD ABBCFMKPBKO(OCMFLIKNIPB LJELDKAOCJM)
	{
		return default(OMLFPKHBOMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8079870", Offset = "0x8078A70", VA = "0x188079870", Slot = "5")]
	public OMLFPKHBOMD ABBCFMKPBKO(OCMFLIKNIPB LJELDKAOCJM, bool BGDBGAENBAC)
	{
		return default(OMLFPKHBOMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x807A820", Offset = "0x8079A20", VA = "0x18807A820", Slot = "6")]
	public void FBLAEKMLOEE(OMLFPKHBOMD BFPPPKIAFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x807B2A0", Offset = "0x807A4A0", VA = "0x18807B2A0", Slot = "7")]
	public void JJCJNEOEFMF(OMLFPKHBOMD BFPPPKIAFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x807ADE0", Offset = "0x8079FE0", VA = "0x18807ADE0", Slot = "8")]
	public OKPBHDAFLPP JDCNKDOGFOH(OMLFPKHBOMD BFPPPKIAFBG, GFCAFNBKIEB LJELDKAOCJM)
	{
		return default(OKPBHDAFLPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x807A360", Offset = "0x8079560", VA = "0x18807A360", Slot = "9")]
	public OKPBHDAFLPP EIJIOAPGKPK(OMLFPKHBOMD BFPPPKIAFBG, FLIGGIIDKOK LJELDKAOCJM)
	{
		return default(OKPBHDAFLPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8079BB0", Offset = "0x8078DB0", VA = "0x188079BB0", Slot = "11")]
	public void CJNJNOKHKHF(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8079F50", Offset = "0x8079150", VA = "0x188079F50", Slot = "10")]
	public void DBEHDJLLJEC(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x807AAE0", Offset = "0x8079CE0", VA = "0x18807AAE0", Slot = "20")]
	public IEnumerable<Renderer> FKFFBGEDOFF(OMLFPKHBOMD BFPPPKIAFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x807AD60", Offset = "0x8079F60", VA = "0x18807AD60", Slot = "12")]
	public HGPFMFLDJEH HINNLDNELEH(GJMABJMFAAN LJELDKAOCJM)
	{
		return default(HGPFMFLDJEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x807AA70", Offset = "0x8079C70", VA = "0x18807AA70", Slot = "14")]
	public void FJNCIFNBJGG(HGPFMFLDJEH CBNFLPCLLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x807B790", Offset = "0x807A990", VA = "0x18807B790", Slot = "16")]
	public Task LHPHDJJAMEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x807B5E0", Offset = "0x807A7E0", VA = "0x18807B5E0", Slot = "17")]
	public Task LAALFNOGJED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8079AE0", Offset = "0x8078CE0", VA = "0x188079AE0", Slot = "18")]
	[AsyncStateMachine(typeof(EODMHLBHEHI))]
	public Task BMPNONCIEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x807AC70", Offset = "0x8079E70", VA = "0x18807AC70", Slot = "19")]
	public void GEIIKOIIOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x807B950", Offset = "0x807AB50", VA = "0x18807B950", Slot = "13")]
	public void NBMHBACALHN(HGPFMFLDJEH CBNFLPCLLMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class PLHPFELPDDH : IOMAKAMPLJM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct LAPHODAIIEO : ONLMDMENCJE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private MKEMNAEEJEC CJONLLGJGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> FKKKJCBOMFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle IBAHKKADFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EFMKJKDFNHD CCELFLJNBAJ;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8073530", Offset = "0x8072730", VA = "0x188073530")]
		public LAPHODAIIEO(MKEMNAEEJEC CJONLLGJGEO, NativeArray<int> FKKKJCBOMFH, JobHandle IBAHKKADFPN, EFMKJKDFNHD CCELFLJNBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x80734D0", Offset = "0x80726D0", VA = "0x1880734D0", Slot = "4")]
		public MKEMNAEEJEC EBLGNCPCOGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8073430", Offset = "0x8072630", VA = "0x188073430", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly GFCAFNBKIEB GGCAPNOPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] HFDACJOEDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 NEDMJCKKPGL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 CJCLLAFOFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8078900", Offset = "0x8077B00", VA = "0x188078900")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 JLBFNBABIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8078630", Offset = "0x8077830", VA = "0x188078630", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x80797B0", Offset = "0x80789B0", VA = "0x1880797B0")]
	public PLHPFELPDDH(PEKOBBONACI BFPPPKIAFBG, GFCAFNBKIEB LJELDKAOCJM, bool BCFNPNOHNLD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8077C40", Offset = "0x8076E40", VA = "0x188077C40", Slot = "18")]
	public override bool CJGPDLEEOMH(MOCOMOJHGBP BFPPPKIAFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8079160", Offset = "0x8078360", VA = "0x188079160", Slot = "21")]
	public override GCAMAGHAEJE PFHEEDALGLJ()
	{
		return default(GCAMAGHAEJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x80791A0", Offset = "0x80783A0", VA = "0x1880791A0")]
	private GCAMAGHAEJE PFHEEDALGLJ(MOCOMOJHGBP BFPPPKIAFBG)
	{
		return default(GCAMAGHAEJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8078CE0", Offset = "0x8077EE0", VA = "0x188078CE0")]
	private IJEDPHLJICC NIHGMGDJCMD([In] UniformTRS MAGNLICGBHA, [In] float3 ABLGNOAHALN)
	{
		return default(IJEDPHLJICC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8077B90", Offset = "0x8076D90", VA = "0x188077B90", Slot = "19")]
	public override int CCKGGKEPFHP(NKGLGKDLFIP KADDNMPDABI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8078850", Offset = "0x8077A50", VA = "0x188078850", Slot = "20")]
	public override int HNEFFPBLFJE(NKGLGKDLFIP KADDNMPDABI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8078760", Offset = "0x8077960", VA = "0x188078760", Slot = "22")]
	public override float GDAPDPPJOFF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8078EE0", Offset = "0x80780E0", VA = "0x188078EE0")]
	private int PBDNCJJHGAA(NKGLGKDLFIP KADDNMPDABI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8077DE0", Offset = "0x8076FE0", VA = "0x188077DE0", Slot = "23")]
	public override void EGMAGOLIPIP(NKGLGKDLFIP KADDNMPDABI, KEEBJKJHOAM LHDEBLCKCJF, int IEKMPJOCCEL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8077D10", Offset = "0x8076F10", VA = "0x188077D10", Slot = "24")]
	public override MOCOMOJHGBP CMKHMOFPIMB()
	{
		return default(MOCOMOJHGBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8078B30", Offset = "0x8077D30", VA = "0x188078B30", Slot = "26")]
	public override LEODOLMIKLM NHFEAPLIMCI()
	{
		return default(LEODOLMIKLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x80773C0", Offset = "0x80765C0", VA = "0x1880773C0", Slot = "27")]
	public override ONLMDMENCJE BLAHLCHDBHM(NKGLGKDLFIP KADDNMPDABI, JobHandle IBAHKKADFPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GKFHAJDKILG
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFILNKOFEAG(MPMHJLBLEOI NNILCBOLNDI, Renderer MONNLFCGBEF, int MLFAKLFKEMH);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODPEDFNNKPA(Renderer MONNLFCGBEF, FCKLGKBKHEJ JNIGJFGCALI, Vector3 LADLHKPOKJJ, Vector3 ADIHKOHOOAG, Vector3 IHPACCCNOBB, float ACGFEFKGPLC, float FEPPBOCNOBP, float APKMHOEPIAO = -1f, [Optional] Color? JLNFDAODDKP, [Optional] IReadOnlyList<Camera> MDDCGLEIEOG);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COMCMNNOEJG(Renderer MONNLFCGBEF, int MLFAKLFKEMH);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FLCAEJIOCOE();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPOFGDGEKKO(int JHHMIIBBKIF, GIHAKHDNNJF NNILCBOLNDI, Renderer MONNLFCGBEF, int MLFAKLFKEMH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GNEAODLBCDA : FDBJDLMKNEH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class PELIOHCIHLD : AIDDNBBNFBL<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8077370", Offset = "0x8076570", VA = "0x188077370")]
		public PELIOHCIHLD(string MBDFMCIDAOB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GKFHAJDKILG ILGFBLNOEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly GGFEFPBMHJM MIJGDNEILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer AGLCKPFJOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private PELIOHCIHLD KFKCBHCGKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool HMEHOENDEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer FHAJGBNIIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private PELIOHCIHLD KGJJMHLNDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool FEIJANFCLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer MDLFPKNGOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private PELIOHCIHLD IOMFOECFLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool CMFIMKGOEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool JPJEOEDAIGH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
	public GNEAODLBCDA(GKFHAJDKILG OEFACHFNBFD, GGFEFPBMHJM MIJGDNEILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x806C8D0", Offset = "0x806BAD0", VA = "0x18806C8D0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x806D9A0", Offset = "0x806CBA0", VA = "0x18806D9A0")]
	private void KIKLJNPIJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x806C4F0", Offset = "0x806B6F0", VA = "0x18806C4F0", Slot = "4")]
	public void CHFANENDHEH(OMLFPKHBOMD BFPPPKIAFBG, GIHAKHDNNJF JPGPAIHLKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x806C2D0", Offset = "0x806B4D0", VA = "0x18806C2D0", Slot = "5")]
	public void CHFANENDHEH(OKPBHDAFLPP ADJAHFEDDPI, GIHAKHDNNJF JPGPAIHLKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x806DC10", Offset = "0x806CE10", VA = "0x18806DC10", Slot = "6")]
	public void KLBJNEJEHMA(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x806CED0", Offset = "0x806C0D0", VA = "0x18806CED0", Slot = "7")]
	public void HDKLAGKLDHJ(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x806D890", Offset = "0x806CA90", VA = "0x18806D890", Slot = "24")]
	public void IJKDIBFDFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xF27700", Offset = "0xF26900", VA = "0x180F27700", Slot = "8")]
	public void KPJKJIBPIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x806CD60", Offset = "0x806BF60", VA = "0x18806CD60", Slot = "9")]
	public void GNAJOEJMNHL(GIHAKHDNNJF JPGPAIHLKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x806BED0", Offset = "0x806B0D0", VA = "0x18806BED0", Slot = "10")]
	public void AJDMHKAAIBJ(OMLFPKHBOMD BFPPPKIAFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x806BB70", Offset = "0x806AD70", VA = "0x18806BB70", Slot = "11")]
	public void AJDMHKAAIBJ(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x806D8D0", Offset = "0x806CAD0", VA = "0x18806D8D0", Slot = "12")]
	public void IMHHABOJOHH(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x806DD70", Offset = "0x806CF70", VA = "0x18806DD70", Slot = "13")]
	public void MFGEDGNIONC(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x806DE40", Offset = "0x806D040", VA = "0x18806DE40")]
	private void MGNLLKFOHKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1188FB0", Offset = "0x11881B0", VA = "0x181188FB0", Slot = "14")]
	public void GKCCLGPGLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x806E3F0", Offset = "0x806D5F0", VA = "0x18806E3F0", Slot = "15")]
	public void OJLGJONMPED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x806CA80", Offset = "0x806BC80", VA = "0x18806CA80", Slot = "16")]
	public void EHJANGAOIGE(OMLFPKHBOMD BFPPPKIAFBG, MPMHJLBLEOI NNILCBOLNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x806C800", Offset = "0x806BA00", VA = "0x18806C800", Slot = "17")]
	public void DOLIKBLJMJN(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x806E0B0", Offset = "0x806D2B0", VA = "0x18806E0B0", Slot = "18")]
	public void NAKKFLLHCAC(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xB98920", Offset = "0xB97B20", VA = "0x180B98920", Slot = "19")]
	public void FHCIODANJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x806C1A0", Offset = "0x806B3A0", VA = "0x18806C1A0", Slot = "20")]
	public void BPLNBPBDMAK(MPMHJLBLEOI NNILCBOLNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x806E180", Offset = "0x806D380", VA = "0x18806E180")]
	private void NBOMPKDONAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x806D4C0", Offset = "0x806C6C0", VA = "0x18806D4C0", Slot = "21")]
	public void IIFFDPEPJHI(OMLFPKHBOMD BFPPPKIAFBG, Vector3 LADLHKPOKJJ, Vector3 ADIHKOHOOAG, Vector3 IHPACCCNOBB, float ACGFEFKGPLC, float FEPPBOCNOBP, IReadOnlyList<Camera> IMBNIDJELNM, FCKLGKBKHEJ JNIGJFGCALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x806D020", Offset = "0x806C220", VA = "0x18806D020", Slot = "22")]
	public void IIFFDPEPJHI(HGPFMFLDJEH CBNFLPCLLMK, Vector3 LADLHKPOKJJ, Vector3 ADIHKOHOOAG, Vector3 IHPACCCNOBB, float ACGFEFKGPLC, float FEPPBOCNOBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class IOMAKAMPLJM : JMHDLIIPFJC, NCDFOHJIFEI, PACHPOJLGPB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly PEKOBBONACI GMOCPPMLGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int JAAGKGNOEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds AFPNCDPCOCA;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds NFCFEJOIDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x80705C0", Offset = "0x806F7C0", VA = "0x1880705C0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool BBNDJJNJFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC59600", Offset = "0xC58800", VA = "0x180C59600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC59360", Offset = "0xC58560", VA = "0x180C59360")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 JLBFNBABIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HKFJPOLONEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAD2CC0", Offset = "0xAD1EC0", VA = "0x180AD2CC0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public PKLIGHDGFAI FBJKILJKPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x964F40", Offset = "0x964140", VA = "0x180964F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BHJCFPGLGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xD929A0", Offset = "0xD91BA0", VA = "0x180D929A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	protected IOMAKAMPLJM(PEKOBBONACI BFPPPKIAFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8070420", Offset = "0x806F620", VA = "0x188070420", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "18")]
	public virtual bool CJGPDLEEOMH(MOCOMOJHGBP BFPPPKIAFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x80705B0", Offset = "0x806F7B0", VA = "0x1880705B0", Slot = "10")]
	public int LFECPBHFEHA(int GNFIFCJHNLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int CCKGGKEPFHP(NKGLGKDLFIP KADDNMPDABI);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int HNEFFPBLFJE(NKGLGKDLFIP KADDNMPDABI);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract GCAMAGHAEJE PFHEEDALGLJ();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float GDAPDPPJOFF();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void EGMAGOLIPIP(NKGLGKDLFIP KADDNMPDABI, KEEBJKJHOAM LHDEBLCKCJF, int IEKMPJOCCEL = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract MOCOMOJHGBP CMKHMOFPIMB();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8070580", Offset = "0x806F780", VA = "0x188070580", Slot = "13")]
	public Hash128 KHKNDEFBPEA(int KADDNMPDABI)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract LEODOLMIKLM NHFEAPLIMCI();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract ONLMDMENCJE BLAHLCHDBHM(NKGLGKDLFIP KADDNMPDABI, JobHandle IBAHKKADFPN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80705E0", Offset = "0x806F7E0", VA = "0x1880705E0", Slot = "12")]
	public ONLMDMENCJE OCPOOJOJNAJ(int KADDNMPDABI)
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
		[Cpp2IlInjected.Address(RVA = "0x807BE30", Offset = "0x807B030", VA = "0x18807BE30")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HIDCNPPLPLO
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NGPDHKLGOBG : IEnumerable<APOLEJPELMG>, IEnumerable, IEnumerator<APOLEJPELMG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private APOLEJPELMG <>2__current;

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
		private APOLEJPELMG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public NGPDHKLGOBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8074930", Offset = "0x8073B30", VA = "0x188074930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8074AA0", Offset = "0x8073CA0", VA = "0x188074AA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8074A00", Offset = "0x8073C00", VA = "0x188074A00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<APOLEJPELMG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8074A00", Offset = "0x8073C00", VA = "0x188074A00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static APOLEJPELMG[][] IILJNBJBGKA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static BOJBLBPGPJK NFLLLLEDMDC;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig LKFFKGOHFNC;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader BLOGDGOFNKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x806FC10", Offset = "0x806EE10", VA = "0x18806FC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer GDBGFDONAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x806E6C0", Offset = "0x806D8C0", VA = "0x18806E6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x806FE30", Offset = "0x806F030", VA = "0x18806FE30")]
	[AEGEAJMGHGA]
	internal static void PDAIGIIELDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x806E720", Offset = "0x806D920", VA = "0x18806E720")]
	public static Mesh CGAAKHGDOHE(PGANNLEBPBC PDHMKAFDCIO, int KADDNMPDABI = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x806EB80", Offset = "0x806DD80", VA = "0x18806EB80")]
	public static int ENPCPIPFMIF(PGANNLEBPBC PDHMKAFDCIO, int KADDNMPDABI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x806EBF0", Offset = "0x806DDF0", VA = "0x18806EBF0")]
	public static BOJBLBPGPJK GFNBIGGOHEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x806EB90", Offset = "0x806DD90", VA = "0x18806EB90")]
	[IteratorStateMachine(typeof(NGPDHKLGOBG))]
	private static IEnumerable<APOLEJPELMG> GAGFIFBICGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x806EDF0", Offset = "0x806DFF0", VA = "0x18806EDF0")]
	public static APOLEJPELMG IDIMDOFKDGE(PGANNLEBPBC PDHMKAFDCIO, int KADDNMPDABI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x806FF10", Offset = "0x806F110", VA = "0x18806FF10")]
	public static bool PMLBACMPINF(this PGANNLEBPBC PDHMKAFDCIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x806E510", Offset = "0x806D710", VA = "0x18806E510")]
	public static void ALCAJFPOEPP(PGANNLEBPBC PDHMKAFDCIO, float3 KNPKHDGBFFC, [Out] JJKFFKPCHPF NIKJGECCBAB, [Out] float3 MNDONIEGNNL, [Out] float LLCDBCLDIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x806E7C0", Offset = "0x806D9C0", VA = "0x18806E7C0")]
	public static void DEIEELBPOEH(Vector3 KNPKHDGBFFC, PGANNLEBPBC PDHMKAFDCIO, [Out] Vector3 MNDONIEGNNL, [Out] float LLCDBCLDIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x806FC00", Offset = "0x806EE00", VA = "0x18806FC00")]
	[KDIIHLCCKEP(0)]
	[GHGPNDCMIJI(EIBKBHOJJHA.ExitingPlayMode, 0)]
	private static void OBHNAPPBFMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x806FC70", Offset = "0x806EE70", VA = "0x18806FC70")]
	[KDIIHLCCKEP(0)]
	[GHGPNDCMIJI(EIBKBHOJJHA.ExitingPlayMode, 0)]
	private static void PAGDPLNGNNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class NLDFHMAMLAF : IGEBAHMFCMN, IDisposable, GGFEFPBMHJM
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly CPHCCEMMPHG<OMLFPKHBOMD, PEKOBBONACI> KAOPDPDGEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly CPHCCEMMPHG<OKPBHDAFLPP, IOMAKAMPLJM> NDDDNBMFFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly CPHCCEMMPHG<HGPFMFLDJEH, JNENAAGMFJF> KKNGDKEPCFH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public PEKOBBONACI EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8075090", Offset = "0x8074290", VA = "0x188075090", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IOMAKAMPLJM EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8075030", Offset = "0x8074230", VA = "0x188075030", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public JNENAAGMFJF EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x80750F0", Offset = "0x80742F0", VA = "0x1880750F0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool JKLDHBHJCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xCE51A0", Offset = "0xCE43A0", VA = "0x180CE51A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xCE50A0", Offset = "0xCE42A0", VA = "0x180CE50A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x80755B0", Offset = "0x80747B0", VA = "0x1880755B0")]
	public NLDFHMAMLAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8074D20", Offset = "0x8073F20", VA = "0x188074D20", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8074AF0", Offset = "0x8073CF0", VA = "0x188074AF0", Slot = "4")]
	public OMLFPKHBOMD ABBCFMKPBKO(OCMFLIKNIPB LJELDKAOCJM)
	{
		return default(OMLFPKHBOMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8074AF0", Offset = "0x8073CF0", VA = "0x188074AF0", Slot = "5")]
	public OMLFPKHBOMD ABBCFMKPBKO(OCMFLIKNIPB LJELDKAOCJM, bool BGDBGAENBAC)
	{
		return default(OMLFPKHBOMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8074EF0", Offset = "0x80740F0", VA = "0x188074EF0", Slot = "6")]
	public void FBLAEKMLOEE(OMLFPKHBOMD BFPPPKIAFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8075310", Offset = "0x8074510", VA = "0x188075310", Slot = "7")]
	public void JJCJNEOEFMF(OMLFPKHBOMD BFPPPKIAFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x80751D0", Offset = "0x80743D0", VA = "0x1880751D0", Slot = "8")]
	public OKPBHDAFLPP JDCNKDOGFOH(OMLFPKHBOMD BFPPPKIAFBG, GFCAFNBKIEB LJELDKAOCJM)
	{
		return default(OKPBHDAFLPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8074DB0", Offset = "0x8073FB0", VA = "0x188074DB0", Slot = "9")]
	public OKPBHDAFLPP EIJIOAPGKPK(OMLFPKHBOMD BFPPPKIAFBG, FLIGGIIDKOK LJELDKAOCJM)
	{
		return default(OKPBHDAFLPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8074C30", Offset = "0x8073E30", VA = "0x188074C30", Slot = "11")]
	public void CJNJNOKHKHF(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8074CC0", Offset = "0x8073EC0", VA = "0x188074CC0", Slot = "10")]
	public void DBEHDJLLJEC(OKPBHDAFLPP ADJAHFEDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8074FC0", Offset = "0x80741C0", VA = "0x188074FC0", Slot = "20")]
	public IEnumerable<Renderer> FKFFBGEDOFF(OMLFPKHBOMD BFPPPKIAFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8075150", Offset = "0x8074350", VA = "0x188075150", Slot = "12")]
	public HGPFMFLDJEH HINNLDNELEH(GJMABJMFAAN LJELDKAOCJM)
	{
		return default(HGPFMFLDJEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8074F50", Offset = "0x8074150", VA = "0x188074F50", Slot = "14")]
	public void FJNCIFNBJGG(HGPFMFLDJEH CBNFLPCLLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8075430", Offset = "0x8074630", VA = "0x188075430", Slot = "16")]
	public Task LHPHDJJAMEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8075390", Offset = "0x8074590", VA = "0x188075390", Slot = "17")]
	public Task LAALFNOGJED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8074B90", Offset = "0x8073D90", VA = "0x188074B90", Slot = "18")]
	public Task BMPNONCIEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x24C1D20", Offset = "0x24C0F20", VA = "0x1824C1D20", Slot = "19")]
	public void GEIIKOIIOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x80754D0", Offset = "0x80746D0", VA = "0x1880754D0", Slot = "13")]
	public void NBMHBACALHN(HGPFMFLDJEH CBNFLPCLLMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HAMFLLOGPIB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool BPFGGMBLCNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material ELKOMJBMPHE();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material OCONPOJGHAP();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material NGLHANLJKMH();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IDEMBKMODOJ(EOGPNGFBHLD MGCBFMBNMKL);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int PFLIIOHGIHC(FAKFOCBMCDN CPLLOLGLILC);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMIJLONHHGB(GameObject ONELFPFEALD);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DHKGFKKJALL(GameObject ONELFPFEALD, bool IIMJMEJDKFG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EHJCFDKGEOK
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static HAMFLLOGPIB PIJKIPKKMLF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool BPFGGMBLCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x80697B0", Offset = "0x80689B0", VA = "0x1880697B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8069620", Offset = "0x8068820", VA = "0x188069620")]
	public static void BNGCJBJMJHP(HAMFLLOGPIB MMHFMGLHIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8069750", Offset = "0x8068950", VA = "0x188069750")]
	public static Material ELKOMJBMPHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x80699B0", Offset = "0x8068BB0", VA = "0x1880699B0")]
	public static Material OCONPOJGHAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8069950", Offset = "0x8068B50", VA = "0x188069950")]
	public static Material NGLHANLJKMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8069810", Offset = "0x8068A10", VA = "0x188069810")]
	public static int IDEMBKMODOJ(EOGPNGFBHLD MGCBFMBNMKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8069A10", Offset = "0x8068C10", VA = "0x188069A10")]
	public static int PFLIIOHGIHC(FAKFOCBMCDN CPLLOLGLILC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8069880", Offset = "0x8068A80", VA = "0x188069880")]
	public static void JMIJLONHHGB(GameObject ONELFPFEALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8069670", Offset = "0x8068870", VA = "0x188069670")]
	public static void DHKGFKKJALL(GameObject ONELFPFEALD, bool IIMJMEJDKFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JNENAAGMFJF : EIFEHEJKCMG
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HNLLIFOPAIF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JNENAAGMFJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public HNLLIFOPAIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8070390", Offset = "0x806F590", VA = "0x188070390", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8070020", Offset = "0x806F220", VA = "0x188070020", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8070240", Offset = "0x806F440", VA = "0x188070240")]
		private void PIKGOAEJJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8070340", Offset = "0x806F540", VA = "0x188070340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8070290", Offset = "0x806F490", VA = "0x188070290", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8070290", Offset = "0x806F490", VA = "0x188070290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GJMABJMFAAN KDEALBJMOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GGFEFPBMHJM MIJGDNEILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private MLLNMNFNJAO POPLLHLNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<GAJABJOBPAC> GJBICOLIJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<GAJABJOBPAC> IFBAHLLGELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject EMCLKNMIFCN;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8073180", Offset = "0x8072380", VA = "0x188073180")]
	public static JNENAAGMFJF NOPJGNCLMKI(GJMABJMFAAN LJELDKAOCJM, GGFEFPBMHJM MIJGDNEILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8073350", Offset = "0x8072550", VA = "0x188073350")]
	private JNENAAGMFJF(GJMABJMFAAN LJELDKAOCJM, GGFEFPBMHJM MIJGDNEILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8072D00", Offset = "0x8071F00", VA = "0x188072D00")]
	public void GNPGDFFJFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x80732D0", Offset = "0x80724D0", VA = "0x1880732D0")]
	[IteratorStateMachine(typeof(HNLLIFOPAIF))]
	public IEnumerable<Renderer> PEEDFFIEFMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8071FF0", Offset = "0x80711F0", VA = "0x188071FF0", Slot = "4")]
	public void BADAGFACFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8072A80", Offset = "0x8071C80", VA = "0x188072A80")]
	private void BFHGEIOKFMF(Vector3 FFCOKGHPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8072AB0", Offset = "0x8071CB0", VA = "0x188072AB0")]
	public void DJHAIOPCIPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GAJABJOBPAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct FAOJOFMFFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public KEEBJKJHOAM AKONOANKENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MOCOMOJHGBP KHJNFKNIDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int KJGAPAJMABF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GJDKBFEFHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public GAJABJOBPAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NKGLGKDLFIP lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<FAOJOFMFFAG> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public MKEMNAEEJEC combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GJDKBFEFHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x806B9A0", Offset = "0x806ABA0", VA = "0x18806B9A0")]
		internal JobHandle GGGHCEFPACF()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x806B970", Offset = "0x806AB70", VA = "0x18806B970")]
		internal void APDJFGMMCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x806BA00", Offset = "0x806AC00", VA = "0x18806BA00")]
		internal void MJJBMKMOGHO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] DJJIJMDIPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private MGEDABJOFLJ INPEEMKJKKJ;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 PIOGFNAONBB;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh LANFBIGAGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int JADECHANHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x96C060", Offset = "0x96B260", VA = "0x18096C060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x806A680", Offset = "0x8069880", VA = "0x18806A680")]
	public void AHPKBCJAHBF(List<MOCOMOJHGBP> BBJAHEBJFCA, Matrix4x4[] OILCIINAHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x806AC50", Offset = "0x8069E50", VA = "0x18806AC50")]
	public static List<GAJABJOBPAC> JENMMFKNHKF(List<PEKOBBONACI> OHAHAOFDFAE, NKGLGKDLFIP KADDNMPDABI, Bounds DAJDGGKLOPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x806A860", Offset = "0x8069A60", VA = "0x18806A860")]
	private JobHandle DMJBMNGIKFC(MKEMNAEEJEC EPBEFNFNJHB, int OJANLPEGPIK, int KDHPHLPMJBB, NKGLGKDLFIP KADDNMPDABI, List<FAOJOFMFFAG> INJCMIAJEEE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x806B2E0", Offset = "0x806A4E0", VA = "0x18806B2E0")]
	private void LPFODMJDFEC(List<FAOJOFMFFAG> INJCMIAJEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x806B550", Offset = "0x806A750", VA = "0x18806B550")]
	private GAJABJOBPAC(List<FAOJOFMFFAG> INJCMIAJEEE, int OJANLPEGPIK, int KDHPHLPMJBB, NKGLGKDLFIP KADDNMPDABI, Bounds DAJDGGKLOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x806ABC0", Offset = "0x8069DC0", VA = "0x18806ABC0", Slot = "4")]
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
		private MaterialPropertyBlock KJMCDDDEPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private GAJABJOBPAC CJONLLGJGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<MOCOMOJHGBP> GILMLJNJOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture NGAEBNGJCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer EALAOMABDLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader IMOOMJBKEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] FFGGOLKKHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int MNDJBKLNGCJ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer LAFJBEFPLAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int AHHEBIIIJCH
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x807CB60", Offset = "0x807BD60", VA = "0x18807CB60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x807C2C0", Offset = "0x807B4C0", VA = "0x18807C2C0")]
		public static List<SkinnedShapeRenderer> Create(GameObject BFPPPKIAFBG, List<GAJABJOBPAC> CHFILKKILHC, List<MOCOMOJHGBP> GILMLJNJOPM, Material MDMIJJAMBMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x807C550", Offset = "0x807B750", VA = "0x18807C550")]
		public void Init(GAJABJOBPAC CJONLLGJGEO, List<MOCOMOJHGBP> GILMLJNJOPM, Material MDMIJJAMBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x807CAC0", Offset = "0x807BCC0", VA = "0x18807CAC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x807CA20", Offset = "0x807BC20", VA = "0x18807CA20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x807C9E0", Offset = "0x807BBE0", VA = "0x18807C9E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x807C200", Offset = "0x807B400", VA = "0x18807C200")]
		private void BCGNFFCLIMB(ScriptableRenderContext IBLIOEFMDMM, Camera[] GDGCIEIFADF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x807BE90", Offset = "0x807B090", VA = "0x18807BE90")]
		private void AHPKBCJAHBF(CommandBuffer PONKKEBLNAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
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
