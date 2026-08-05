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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8780510", Offset = "0x877F710", VA = "0x188780510", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8786590", Offset = "0x8785790", VA = "0x188786590", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GFGBEDMLANO : PENGHGJLNKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte HFDJKOKCJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] OMMFMMGIJGA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OPDLCLPJPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA67480", Offset = "0xA66680", VA = "0x180A67480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCEC9C0", Offset = "0xCEBBC0", VA = "0x180CEC9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ELMFBGFOPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA674B0", Offset = "0xA666B0", VA = "0x180A674B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF45280", Offset = "0xF44480", VA = "0x180F45280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float HLNBNEGAPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEE8830", Offset = "0xEE7A30", VA = "0x180EE8830", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x13D2FC0", Offset = "0x13D21C0", VA = "0x1813D2FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OKGODJNJNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCB52B0", Offset = "0xCB44B0", VA = "0x180CB52B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCB52C0", Offset = "0xCB44C0", VA = "0x180CB52C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> BPBPLIDMHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8778D00", Offset = "0x8777F00", VA = "0x188778D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> NBKOLJKMIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8778BD0", Offset = "0x8777DD0", VA = "0x188778BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject LHGFIGHCCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte ONMOPHIIAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8778D90", Offset = "0x8777F90", VA = "0x188778D90", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x87791B0", Offset = "0x87783B0", VA = "0x1887791B0")]
	public GFGBEDMLANO(List<AFOMEKIHFAH> IPFGCGGBNDC, List<AFOMEKIHFAH> DJNFCJGMKEJ, List<DONKIJIPKJK> NEHDPDMMIDH, Material ADKDGJDNNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8778F40", Offset = "0x8778140", VA = "0x188778F40")]
	private int NBFOPEBCFOD(List<AFOMEKIHFAH> ECMMPHFCBLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8778DE0", Offset = "0x8777FE0", VA = "0x188778DE0")]
	private void KIGCABEJHAB(int FKJLGEMGDEN, bool GOGLCIFAFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8779060", Offset = "0x8778260", VA = "0x188779060")]
	public void OAFBCKFLFAF(Vector3 NOCFMOGCNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8778C00", Offset = "0x8777E00", VA = "0x188778C00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8778D50", Offset = "0x8777F50", VA = "0x188778D50")]
	public void IBOBJKPIDCI(Transform PLJENHKACFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NBENBDBGFFH : JMKDBBNBJDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class IIKJJILJGOO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NBENBDBGFFH <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public IIKJJILJGOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x877EBE0", Offset = "0x877DDE0", VA = "0x18877EBE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x877E580", Offset = "0x877D780", VA = "0x18877E580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x877E4E0", Offset = "0x877D6E0", VA = "0x18877E4E0")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x877E530", Offset = "0x877D730", VA = "0x18877E530")]
		private void GHEPLDLLGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x877EA90", Offset = "0x877DC90", VA = "0x18877EA90")]
		private void NBPOMKPLLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x877EB90", Offset = "0x877DD90", VA = "0x18877EB90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x877EAE0", Offset = "0x877DCE0", VA = "0x18877EAE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x877EAE0", Offset = "0x877DCE0", VA = "0x18877EAE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GGJJEMKGELJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public NBENBDBGFFH <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public GGJJEMKGELJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8779E50", Offset = "0x8779050", VA = "0x188779E50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87799E0", Offset = "0x8778BE0", VA = "0x1887799E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8779940", Offset = "0x8778B40", VA = "0x188779940")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8779990", Offset = "0x8778B90", VA = "0x188779990")]
		private void GHEPLDLLGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8779E00", Offset = "0x8779000", VA = "0x188779E00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8779D50", Offset = "0x8778F50", VA = "0x188779D50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8779D50", Offset = "0x8778F50", VA = "0x188779D50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JOPFHDFGJHL LOKNLHCGCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<POMCAIEIBMK> LMPMIJLIIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> MJBHLCFKDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer IIPBCJBFEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool OOCFFMKLMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool LCJBOMJKDEF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<GAPLKABMPAJ> DCGJANNMMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OEIFNBOEEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8780D30", Offset = "0x877FF30", VA = "0x188780D30", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DONKIJIPKJK GLGPGPOKHED
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8780D70", Offset = "0x877FF70", VA = "0x188780D70", Slot = "8")]
		get
		{
			return default(DONKIJIPKJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> LICDAGFKABM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3E0", Offset = "0xA0C5E0", VA = "0x180A0D3E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8780EC0", Offset = "0x87800C0", VA = "0x188780EC0")]
	private bool IFGNKONCOKO(POMCAIEIBMK GEPHAPCMEAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8780AA0", Offset = "0x877FCA0", VA = "0x188780AA0")]
	private static bool DPKEOELHDCI(POMCAIEIBMK GEPHAPCMEAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8782360", Offset = "0x8781560", VA = "0x188782360")]
	public NBENBDBGFFH(JOPFHDFGJHL CAIGHLKIDBF, bool IFGPLEMDGBL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8780AC0", Offset = "0x877FCC0", VA = "0x188780AC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8781720", Offset = "0x8780920", VA = "0x188781720")]
	public void LHOMNBOIMGH(POMCAIEIBMK GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8782200", Offset = "0x8781400", VA = "0x188782200")]
	public void PKCJOLGDFLO(POMCAIEIBMK GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8780EE0", Offset = "0x87800E0", VA = "0x188780EE0", Slot = "4")]
	public void JCPEFEFFAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x87814B0", Offset = "0x87806B0", VA = "0x1887814B0")]
	public void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8781F90", Offset = "0x8781190", VA = "0x188781F90")]
	private void NHNDCEDAANN(List<POMCAIEIBMK> LMPMIJLIIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8779620", Offset = "0x8778820", VA = "0x188779620")]
	private static Material IHMEECKAOED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8782150", Offset = "0x8781350", VA = "0x188782150")]
	private void NHNDCEDAANN(POMCAIEIBMK GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x87813E0", Offset = "0x87805E0", VA = "0x1887813E0")]
	private void KIJJDLPEHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8781960", Offset = "0x8780B60", VA = "0x188781960")]
	public void LLHEPNICLLN(bool BFLEMNKOJLP, bool EDHAMPCNFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x87809E0", Offset = "0x877FBE0", VA = "0x1887809E0")]
	protected void AAGCKCNMCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8780E40", Offset = "0x8780040", VA = "0x188780E40")]
	public void GMPMMAIFCJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8780CB0", Offset = "0x877FEB0", VA = "0x188780CB0")]
	[IteratorStateMachine(typeof(IIKJJILJGOO))]
	public IEnumerable<Renderer> EGAMJJGAIJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8781F10", Offset = "0x8781110", VA = "0x188781F10")]
	[IteratorStateMachine(typeof(GGJJEMKGELJ))]
	public IEnumerable<Renderer> LNHIGJMMLAI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class HEANGCEFNAL : POMCAIEIBMK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct LEEEKLGKAJD : OELIJBPGFDF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OBIAGGAMNIO CGGHHEJPJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle KHHGIDEGAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private BAFEAOEGIPH ODOFDLIOKAM;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x87804B0", Offset = "0x877F6B0", VA = "0x1887804B0")]
		public LEEEKLGKAJD(OBIAGGAMNIO CGGHHEJPJND, JobHandle KHHGIDEGAOE, BAFEAOEGIPH ODOFDLIOKAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8780480", Offset = "0x877F680", VA = "0x188780480", Slot = "4")]
		public OBIAGGAMNIO NMBGHNGELPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8780430", Offset = "0x877F630", VA = "0x188780430", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly EABGNPNGALB JCMFFOIBGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float AKEPAAFCIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 CEHLMBNOMMG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 JHHHBMDAPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8779F80", Offset = "0x8779180", VA = "0x188779F80", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x877B8C0", Offset = "0x877AAC0", VA = "0x18877B8C0")]
	public HEANGCEFNAL(NBENBDBGFFH OLEJNEHCCLF, EABGNPNGALB CAIGHLKIDBF, bool IFGPLEMDGBL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "18")]
	public override bool EMNMEHILNGL(DONKIJIPKJK OLEJNEHCCLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x877B020", Offset = "0x877A220", VA = "0x18877B020", Slot = "19")]
	public override int NBFOPEBCFOD(JFHEFEBDPBL AEABCPDILIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x877B1F0", Offset = "0x877A3F0", VA = "0x18877B1F0", Slot = "20")]
	public override int NJAOEBNGOEG(JFHEFEBDPBL AEABCPDILIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x877B3C0", Offset = "0x877A5C0", VA = "0x18877B3C0", Slot = "21")]
	public override DJNIFEMIMBD PJILNBLKJJJ()
	{
		return default(DJNIFEMIMBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xA67490", Offset = "0xA66690", VA = "0x180A67490", Slot = "22")]
	public override float MCEBCKIHEPA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x877A0B0", Offset = "0x87792B0", VA = "0x18877A0B0", Slot = "23")]
	public override void FKIIKKCMDOD(JFHEFEBDPBL AEABCPDILIB, ABBAFNICANG MMLCEMNKICA, int POPPFCECMBF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x877B7F0", Offset = "0x877A9F0", VA = "0x18877B7F0", Slot = "24")]
	public override DONKIJIPKJK PLJKDDBHHMP()
	{
		return default(DONKIJIPKJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x877A6A0", Offset = "0x87798A0", VA = "0x18877A6A0", Slot = "26")]
	public override FLAOEOGDHHC FOJMHMIFGEN()
	{
		return default(FLAOEOGDHHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x877A850", Offset = "0x8779A50", VA = "0x18877A850", Slot = "27")]
	public override OELIJBPGFDF JHGIJJPMDAK(JFHEFEBDPBL AEABCPDILIB, JobHandle KHHGIDEGAOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface GIALDAKICKE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NBENBDBGFFH HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	POMCAIEIBMK HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KFJNDEGFOEK HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class CIJLAGEADDP : NBLECBFEIMG, IDisposable, GIALDAKICKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NDMGEICILJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CIJLAGEADDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8782450", Offset = "0x8781650", VA = "0x188782450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x87829B0", Offset = "0x8781BB0", VA = "0x1887829B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KJOGDKEPJKC<GPGLHFGDHFI, NBENBDBGFFH> IJBPFFPCLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly KJOGDKEPJKC<BGBEOAFDOPH, POMCAIEIBMK> LMPMIJLIIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly KJOGDKEPJKC<KLOAHGNEGEC, KFJNDEGFOEK> OLFMLAHCHCC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NBENBDBGFFH HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8774DB0", Offset = "0x8773FB0", VA = "0x188774DB0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public POMCAIEIBMK HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8774E70", Offset = "0x8774070", VA = "0x188774E70", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public KFJNDEGFOEK HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8774E10", Offset = "0x8774010", VA = "0x188774E10", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CJGHPAFALAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA674A0", Offset = "0xA666A0", VA = "0x180A674A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA671B0", Offset = "0xA663B0", VA = "0x180A671B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8775C70", Offset = "0x8774E70", VA = "0x188775C70")]
	public CIJLAGEADDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8774010", Offset = "0x8773210", VA = "0x188774010", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x87747E0", Offset = "0x87739E0", VA = "0x1887747E0", Slot = "4")]
	public GPGLHFGDHFI HEAIGKKBKEH(JOPFHDFGJHL CAIGHLKIDBF)
	{
		return default(GPGLHFGDHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8774570", Offset = "0x8773770", VA = "0x188774570", Slot = "5")]
	public GPGLHFGDHFI HEAIGKKBKEH(JOPFHDFGJHL CAIGHLKIDBF, bool IFGPLEMDGBL)
	{
		return default(GPGLHFGDHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8775A20", Offset = "0x8774C20", VA = "0x188775A20", Slot = "6")]
	public void PLGLAOJHHDH(GPGLHFGDHFI OLEJNEHCCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8773CD0", Offset = "0x8772ED0", VA = "0x188773CD0", Slot = "7")]
	public void DJIGJBBHLPC(GPGLHFGDHFI OLEJNEHCCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x87754F0", Offset = "0x87746F0", VA = "0x1887754F0", Slot = "8")]
	public BGBEOAFDOPH PFHGFNIBAKG(GPGLHFGDHFI OLEJNEHCCLF, FBCEMHOLLKI CAIGHLKIDBF)
	{
		return default(BGBEOAFDOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8775030", Offset = "0x8774230", VA = "0x188775030", Slot = "9")]
	public BGBEOAFDOPH OPLCOGOINLJ(GPGLHFGDHFI OLEJNEHCCLF, EABGNPNGALB CAIGHLKIDBF)
	{
		return default(BGBEOAFDOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x87741D0", Offset = "0x87733D0", VA = "0x1887741D0", Slot = "11")]
	public void FGACNJJFDFN(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x87749A0", Offset = "0x8773BA0", VA = "0x1887749A0", Slot = "10")]
	public void IAHIPDIKFKB(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8774FC0", Offset = "0x87741C0", VA = "0x188774FC0", Slot = "20")]
	public IEnumerable<Renderer> OBGMBKIHBEN(GPGLHFGDHFI OLEJNEHCCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8773B20", Offset = "0x8772D20", VA = "0x188773B20", Slot = "12")]
	public KLOAHGNEGEC AFPDDIDKPBO(MFHLEMCNGOL CAIGHLKIDBF)
	{
		return default(KLOAHGNEGEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x87759B0", Offset = "0x8774BB0", VA = "0x1887759B0", Slot = "14")]
	public void PLEHBIJBNGH(KLOAHGNEGEC KJPGEMOEAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8774BF0", Offset = "0x8773DF0", VA = "0x188774BF0", Slot = "16")]
	public Task JLIGKJHKJEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x87747F0", Offset = "0x87739F0", VA = "0x1887747F0", Slot = "17")]
	public Task HIFMMODDNKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8773C00", Offset = "0x8772E00", VA = "0x188773C00", Slot = "18")]
	[AsyncStateMachine(typeof(NDMGEICILJD))]
	public Task BFNOJOEBBDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8774ED0", Offset = "0x87740D0", VA = "0x188774ED0", Slot = "19")]
	public void NAIJEIJMPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8773BA0", Offset = "0x8772DA0", VA = "0x188773BA0", Slot = "13")]
	public void AMAGGGEHMJE(KLOAHGNEGEC KJPGEMOEAPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class NINMFODJKHH : POMCAIEIBMK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct FDFJFPGMHAB : OELIJBPGFDF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private OBIAGGAMNIO CGGHHEJPJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> PGFICLGDFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle KHHGIDEGAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private JAEJCBEBFHK ODOFDLIOKAM;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8778B70", Offset = "0x8777D70", VA = "0x188778B70")]
		public FDFJFPGMHAB(OBIAGGAMNIO CGGHHEJPJND, NativeArray<int> PGFICLGDFEK, JobHandle KHHGIDEGAOE, JAEJCBEBFHK ODOFDLIOKAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8778B10", Offset = "0x8777D10", VA = "0x188778B10", Slot = "4")]
		public OBIAGGAMNIO NMBGHNGELPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8778A70", Offset = "0x8777C70", VA = "0x188778A70", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly FBCEMHOLLKI OCEAHOAJAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] KFOGLIOCHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 CEHLMBNOMMG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 GKEOIBDJOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x87844B0", Offset = "0x87836B0", VA = "0x1887844B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 JHHHBMDAPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8782C10", Offset = "0x8781E10", VA = "0x188782C10", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8784E00", Offset = "0x8784000", VA = "0x188784E00")]
	public NINMFODJKHH(NBENBDBGFFH OLEJNEHCCLF, FBCEMHOLLKI CAIGHLKIDBF, bool OBKPHIJGHAE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8782FC0", Offset = "0x87821C0", VA = "0x188782FC0", Slot = "18")]
	public override bool EMNMEHILNGL(DONKIJIPKJK OLEJNEHCCLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x87846E0", Offset = "0x87838E0", VA = "0x1887846E0", Slot = "21")]
	public override DJNIFEMIMBD PJILNBLKJJJ()
	{
		return default(DJNIFEMIMBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8784720", Offset = "0x8783920", VA = "0x188784720")]
	private DJNIFEMIMBD PJILNBLKJJJ(DONKIJIPKJK OLEJNEHCCLF)
	{
		return default(DJNIFEMIMBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8782A10", Offset = "0x8781C10", VA = "0x188782A10")]
	private OKNHCIOHHKH BIMAMKEDOLE([In] UniformTRS INNEJOHAJBN, [In] float3 OJKDLNLPBGA)
	{
		return default(OKNHCIOHHKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8784350", Offset = "0x8783550", VA = "0x188784350", Slot = "19")]
	public override int NBFOPEBCFOD(JFHEFEBDPBL AEABCPDILIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8784400", Offset = "0x8783600", VA = "0x188784400", Slot = "20")]
	public override int NJAOEBNGOEG(JFHEFEBDPBL AEABCPDILIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8784260", Offset = "0x8783460", VA = "0x188784260", Slot = "22")]
	public override float MCEBCKIHEPA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8782D40", Offset = "0x8781F40", VA = "0x188782D40")]
	private int DPJDBNKFMEF(JFHEFEBDPBL AEABCPDILIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8783090", Offset = "0x8782290", VA = "0x188783090", Slot = "23")]
	public override void FKIIKKCMDOD(JFHEFEBDPBL AEABCPDILIB, ABBAFNICANG MMLCEMNKICA, int POPPFCECMBF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8784D30", Offset = "0x8783F30", VA = "0x188784D30", Slot = "24")]
	public override DONKIJIPKJK PLJKDDBHHMP()
	{
		return default(DONKIJIPKJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x87838E0", Offset = "0x8782AE0", VA = "0x1887838E0", Slot = "26")]
	public override FLAOEOGDHHC FOJMHMIFGEN()
	{
		return default(FLAOEOGDHHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8783A90", Offset = "0x8782C90", VA = "0x188783A90", Slot = "27")]
	public override OELIJBPGFDF JHGIJJPMDAK(JFHEFEBDPBL AEABCPDILIB, JobHandle KHHGIDEGAOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IGGBHHJOPKP
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIANCHLGPEE(MFEDJIKCLFM GDHKDBJPDLG, Renderer HLIOBIEFOPB, int DGBOLPEDFEE);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIHKCMOLIIA(Renderer HLIOBIEFOPB, NBOEAIAAPLF CBCPLGKAOIC, Vector3 FKFLJICHCAL, Vector3 JBKMANIFODD, Vector3 EJAHENKHIMI, float JBKJMEDDIGO, float CKMCMMNCBCC, float NGLDKBJKIOB = -1f, [Optional] Color? NEMIFEKMDAI, [Optional] IReadOnlyList<Camera> HDOLKJCLECC);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGGGHOIDNMO(Renderer HLIOBIEFOPB, int DGBOLPEDFEE);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LGDFAIMILJG();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBFHIPDJMPP(int FFPPOHFBAIK, CHMGPECIKJJ GDHKDBJPDLG, Renderer HLIOBIEFOPB, int DGBOLPEDFEE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ICMCGKMDPIL : BJOOKMNONND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class CBLDLDLCDJA : JMHDDKBEMIH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8773AD0", Offset = "0x8772CD0", VA = "0x188773AD0")]
		public CBLDLDLCDJA(string GBOCGPJOEEK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IGGBHHJOPKP AKGMPNEFCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly GIALDAKICKE LBAFLICJMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer LGELMMLLNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private CBLDLDLCDJA HPPDCKAHLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool LIMFEIELAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer BIOAOIFCIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private CBLDLDLCDJA INLIHOHCDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool LNFCHMIIGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer BBMMDJDOFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private CBLDLDLCDJA DPBCGPPGNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool NICMFFJBGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool JDKAOICAPKG;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
	public ICMCGKMDPIL(IGGBHHJOPKP OJIKLDMECAE, GIALDAKICKE LBAFLICJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x877C310", Offset = "0x877B510", VA = "0x18877C310", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x877DF30", Offset = "0x877D130", VA = "0x18877DF30")]
	private void MHADACEEFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x877D140", Offset = "0x877C340", VA = "0x18877D140", Slot = "4")]
	public void GMPABNEGPNP(GPGLHFGDHFI OLEJNEHCCLF, CHMGPECIKJJ LANBPNACLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x877CF20", Offset = "0x877C120", VA = "0x18877CF20", Slot = "5")]
	public void GMPABNEGPNP(BGBEOAFDOPH GEPHAPCMEAA, CHMGPECIKJJ LANBPNACLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x877C170", Offset = "0x877B370", VA = "0x18877C170", Slot = "6")]
	public void CNHAOMJCEPD(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x877C5E0", Offset = "0x877B7E0", VA = "0x18877C5E0", Slot = "7")]
	public void EGBPMPEGGGG(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x877C2D0", Offset = "0x877B4D0", VA = "0x18877C2D0", Slot = "24")]
	public void DNFJCLMAOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x10CFAC0", Offset = "0x10CECC0", VA = "0x1810CFAC0", Slot = "8")]
	public void EDCILGFLIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x877CC80", Offset = "0x877BE80", VA = "0x18877CC80", Slot = "9")]
	public void GEILHJKOGKE(CHMGPECIKJJ LANBPNACLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x877BB30", Offset = "0x877AD30", VA = "0x18877BB30", Slot = "10")]
	public void BJOFINNNIDL(GPGLHFGDHFI OLEJNEHCCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x877BE10", Offset = "0x877B010", VA = "0x18877BE10", Slot = "11")]
	public void BJOFINNNIDL(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x877D520", Offset = "0x877C720", VA = "0x18877D520", Slot = "12")]
	public void HNEDAJEDEPA(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x877D450", Offset = "0x877C650", VA = "0x18877D450", Slot = "13")]
	public void HKLLAFOKFDM(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x877C730", Offset = "0x877B930", VA = "0x18877C730")]
	private void EIHOFDMIFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1409F20", Offset = "0x1409120", VA = "0x181409F20", Slot = "14")]
	public void HKLONCLDPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x877C4C0", Offset = "0x877B6C0", VA = "0x18877C4C0", Slot = "15")]
	public void EDPBACDFANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x877C9A0", Offset = "0x877BBA0", VA = "0x18877C9A0", Slot = "16")]
	public void FBJGGOEPNMH(GPGLHFGDHFI OLEJNEHCCLF, MFEDJIKCLFM GDHKDBJPDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x877E410", Offset = "0x877D610", VA = "0x18877E410", Slot = "17")]
	public void OKLNLMGMPCG(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x877D5F0", Offset = "0x877C7F0", VA = "0x18877D5F0", Slot = "18")]
	public void IICKABDAKGM(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xCF62D0", Offset = "0xCF54D0", VA = "0x180CF62D0", Slot = "19")]
	public void BPPLGIMMIFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x877CDF0", Offset = "0x877BFF0", VA = "0x18877CDF0", Slot = "20")]
	public void GHJFJKAANEA(MFEDJIKCLFM GDHKDBJPDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x877E1A0", Offset = "0x877D3A0", VA = "0x18877E1A0")]
	private void NCBMJDIEECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x877DB60", Offset = "0x877CD60", VA = "0x18877DB60", Slot = "21")]
	public void KNILFOFLEJI(GPGLHFGDHFI OLEJNEHCCLF, Vector3 FKFLJICHCAL, Vector3 JBKMANIFODD, Vector3 EJAHENKHIMI, float JBKJMEDDIGO, float CKMCMMNCBCC, IReadOnlyList<Camera> NLPIHPFJJMF, NBOEAIAAPLF CBCPLGKAOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x877D6C0", Offset = "0x877C8C0", VA = "0x18877D6C0", Slot = "22")]
	public void KNILFOFLEJI(KLOAHGNEGEC KJPGEMOEAPM, Vector3 FKFLJICHCAL, Vector3 JBKMANIFODD, Vector3 EJAHENKHIMI, float JBKJMEDDIGO, float CKMCMMNCBCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class POMCAIEIBMK : LHKGDGIKFCG, GAPLKABMPAJ, HMAGCMGJDEE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly NBENBDBGFFH LHGFIGHCCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int HLAEJJGNANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds NDNIMAMIOKF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds HKKFFKOAOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8785010", Offset = "0x8784210", VA = "0x188785010", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool LCJBOMJKDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xDD1570", Offset = "0xDD0770", VA = "0x180DD1570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xDD1230", Offset = "0xDD0430", VA = "0x180DD1230")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 JHHHBMDAPJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GFKHDAHPLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA4FC30", Offset = "0xA4EE30", VA = "0x180A4FC30", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public NJMMCDLNMND AOJIALDJENB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3E0", Offset = "0xA0C5E0", VA = "0x180A0D3E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HFMEJHLKOFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF230C0", Offset = "0xF222C0", VA = "0x180F230C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	protected POMCAIEIBMK(NBENBDBGFFH OLEJNEHCCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8784EB0", Offset = "0x87840B0", VA = "0x188784EB0", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "18")]
	public virtual bool EMNMEHILNGL(DONKIJIPKJK OLEJNEHCCLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8785030", Offset = "0x8784230", VA = "0x188785030", Slot = "10")]
	public int FKDNLIODKMM(int MJPFOOCBDKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int NBFOPEBCFOD(JFHEFEBDPBL AEABCPDILIB);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int NJAOEBNGOEG(JFHEFEBDPBL AEABCPDILIB);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract DJNIFEMIMBD PJILNBLKJJJ();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float MCEBCKIHEPA();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void FKIIKKCMDOD(JFHEFEBDPBL AEABCPDILIB, ABBAFNICANG MMLCEMNKICA, int POPPFCECMBF = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract DONKIJIPKJK PLJKDDBHHMP();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8785040", Offset = "0x8784240", VA = "0x188785040", Slot = "13")]
	public Hash128 IBADHDKCCFI(int AEABCPDILIB)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract FLAOEOGDHHC FOJMHMIFGEN();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract OELIJBPGFDF JHGIJJPMDAK(JFHEFEBDPBL AEABCPDILIB, JobHandle KHHGIDEGAOE);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8785070", Offset = "0x8784270", VA = "0x188785070", Slot = "12")]
	public OELIJBPGFDF IPFELFHBLJG(int AEABCPDILIB)
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
		[Cpp2IlInjected.Address(RVA = "0x87850A0", Offset = "0x87842A0", VA = "0x1887850A0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FAMPOHOHKBF
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HPBDDNEFPCE : IEnumerable<NGHGHDFAFLN>, IEnumerable, IEnumerator<NGHGHDFAFLN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private NGHGHDFAFLN <>2__current;

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
		private NGHGHDFAFLN System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public HPBDDNEFPCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x877B970", Offset = "0x877AB70", VA = "0x18877B970", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x877BAE0", Offset = "0x877ACE0", VA = "0x18877BAE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x877BA40", Offset = "0x877AC40", VA = "0x18877BA40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NGHGHDFAFLN> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x877BA40", Offset = "0x877AC40", VA = "0x18877BA40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static NGHGHDFAFLN[][] ELACICMCHNJ;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static BHLPMLOGOAA AMAEJCBNDBO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig NAJEMHLCPFE;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader MDLBLEDIKNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x87784F0", Offset = "0x87776F0", VA = "0x1887784F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer KAMOLMJPKEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8777F00", Offset = "0x8777100", VA = "0x188777F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8776F70", Offset = "0x8776170", VA = "0x188776F70")]
	[AMFDJJKGJPA]
	internal static void AFLILFPIJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8777E50", Offset = "0x8777050", VA = "0x188777E50")]
	public static Mesh CKAPPHLIBLL(CALBLPNDMED CCCIMGKLFMJ, int AEABCPDILIB = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8778120", Offset = "0x8777320", VA = "0x188778120")]
	public static int HHLCDMOHOCJ(CALBLPNDMED CCCIMGKLFMJ, int AEABCPDILIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8778760", Offset = "0x8777960", VA = "0x188778760")]
	public static BHLPMLOGOAA MMHILMLMFBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8778700", Offset = "0x8777900", VA = "0x188778700")]
	[IteratorStateMachine(typeof(HPBDDNEFPCE))]
	private static IEnumerable<NGHGHDFAFLN> MALOCGHCLLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8777050", Offset = "0x8776250", VA = "0x188777050")]
	public static NGHGHDFAFLN BCGDBNCLHIF(CALBLPNDMED CCCIMGKLFMJ, int AEABCPDILIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8778960", Offset = "0x8777B60", VA = "0x188778960")]
	public static bool OCMOAENMHBA(this CALBLPNDMED CCCIMGKLFMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8778550", Offset = "0x8777750", VA = "0x188778550")]
	public static void JMLBHCBGEBK(CALBLPNDMED CCCIMGKLFMJ, float3 PFFJLPOEONF, [Out] CMKNEAGFBCH EGKBFLKHJBL, [Out] float3 HBNPDCGODLD, [Out] float BDMLFFHHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8778130", Offset = "0x8777330", VA = "0x188778130")]
	public static void HMNJIILJJPB(Vector3 PFFJLPOEONF, CALBLPNDMED CCCIMGKLFMJ, [Out] Vector3 HBNPDCGODLD, [Out] float BDMLFFHHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8777EF0", Offset = "0x87770F0", VA = "0x188777EF0")]
	[MPHEBJBEOGE(0)]
	[DHCHJGMMEBK(GCHHJKKLOFC.ExitingPlayMode, 0)]
	private static void CNCDBDAJAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8777F60", Offset = "0x8777160", VA = "0x188777F60")]
	[MPHEBJBEOGE(0)]
	[DHCHJGMMEBK(GCHHJKKLOFC.ExitingPlayMode, 0)]
	private static void ECMKLEAKHGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class DOHJKBLILEL : NBLECBFEIMG, IDisposable, GIALDAKICKE
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly KJOGDKEPJKC<GPGLHFGDHFI, NBENBDBGFFH> IJBPFFPCLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly KJOGDKEPJKC<BGBEOAFDOPH, POMCAIEIBMK> LMPMIJLIIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly KJOGDKEPJKC<KLOAHGNEGEC, KFJNDEGFOEK> OLFMLAHCHCC;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public NBENBDBGFFH HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8776650", Offset = "0x8775850", VA = "0x188776650", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public POMCAIEIBMK HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x87766B0", Offset = "0x87758B0", VA = "0x1887766B0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public KFJNDEGFOEK HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8776710", Offset = "0x8775910", VA = "0x188776710", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CJGHPAFALAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA674A0", Offset = "0xA666A0", VA = "0x180A674A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA671B0", Offset = "0xA663B0", VA = "0x180A671B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8776BB0", Offset = "0x8775DB0", VA = "0x188776BB0")]
	public DOHJKBLILEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x87762F0", Offset = "0x87754F0", VA = "0x1887762F0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8776410", Offset = "0x8775610", VA = "0x188776410", Slot = "4")]
	public GPGLHFGDHFI HEAIGKKBKEH(JOPFHDFGJHL CAIGHLKIDBF)
	{
		return default(GPGLHFGDHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8776410", Offset = "0x8775610", VA = "0x188776410", Slot = "5")]
	public GPGLHFGDHFI HEAIGKKBKEH(JOPFHDFGJHL CAIGHLKIDBF, bool IFGPLEMDGBL)
	{
		return default(GPGLHFGDHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8776AD0", Offset = "0x8775CD0", VA = "0x188776AD0", Slot = "6")]
	public void PLGLAOJHHDH(GPGLHFGDHFI OLEJNEHCCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8776270", Offset = "0x8775470", VA = "0x188776270", Slot = "7")]
	public void DJIGJBBHLPC(GPGLHFGDHFI OLEJNEHCCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8776920", Offset = "0x8775B20", VA = "0x188776920", Slot = "8")]
	public BGBEOAFDOPH PFHGFNIBAKG(GPGLHFGDHFI OLEJNEHCCLF, FBCEMHOLLKI CAIGHLKIDBF)
	{
		return default(BGBEOAFDOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x87767E0", Offset = "0x87759E0", VA = "0x1887767E0", Slot = "9")]
	public BGBEOAFDOPH OPLCOGOINLJ(GPGLHFGDHFI OLEJNEHCCLF, EABGNPNGALB CAIGHLKIDBF)
	{
		return default(BGBEOAFDOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8776380", Offset = "0x8775580", VA = "0x188776380", Slot = "11")]
	public void FGACNJJFDFN(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8776550", Offset = "0x8775750", VA = "0x188776550", Slot = "10")]
	public void IAHIPDIKFKB(BGBEOAFDOPH GEPHAPCMEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8776770", Offset = "0x8775970", VA = "0x188776770", Slot = "20")]
	public IEnumerable<Renderer> OBGMBKIHBEN(GPGLHFGDHFI OLEJNEHCCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x87760F0", Offset = "0x87752F0", VA = "0x1887760F0", Slot = "12")]
	public KLOAHGNEGEC AFPDDIDKPBO(MFHLEMCNGOL CAIGHLKIDBF)
	{
		return default(KLOAHGNEGEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8776A60", Offset = "0x8775C60", VA = "0x188776A60", Slot = "14")]
	public void PLEHBIJBNGH(KLOAHGNEGEC KJPGEMOEAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x87765B0", Offset = "0x87757B0", VA = "0x1887765B0", Slot = "16")]
	public Task JLIGKJHKJEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x87764B0", Offset = "0x87756B0", VA = "0x1887764B0", Slot = "17")]
	public Task HIFMMODDNKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x87761D0", Offset = "0x87753D0", VA = "0x1887761D0", Slot = "18")]
	public Task BFNOJOEBBDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2779560", Offset = "0x2778760", VA = "0x182779560", Slot = "19")]
	public void NAIJEIJMPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8776170", Offset = "0x8775370", VA = "0x188776170", Slot = "13")]
	public void AMAGGGEHMJE(KLOAHGNEGEC KJPGEMOEAPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GFDAPINAFPG
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool DOBMFBLKJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material OFCBDOKOMCG();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material IHMEECKAOED();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material NCEDNHPPJIE();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IOLHMEJOEHP(IPAPAOLOGOE MBFCBBCCMKE);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FCBPDLLLCPG(JMKIOIDBFKN NIHAIKKHHEK);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPHCNAJMLCC(GameObject KFMNDOMPAMC);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOCCBFLPBEC(GameObject KFMNDOMPAMC, bool GHJCMHIHLFK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class GGAHOBFFGCN
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static GFDAPINAFPG IBLPGPPBNHF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool DOBMFBLKJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8779740", Offset = "0x8778940", VA = "0x188779740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x87796F0", Offset = "0x87788F0", VA = "0x1887796F0")]
	public static void JEBKLPDACGH(GFDAPINAFPG CDDIGKPPLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x87798E0", Offset = "0x8778AE0", VA = "0x1887798E0")]
	public static Material OFCBDOKOMCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8779620", Offset = "0x8778820", VA = "0x188779620")]
	public static Material IHMEECKAOED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8779880", Offset = "0x8778A80", VA = "0x188779880")]
	public static Material NCEDNHPPJIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8779680", Offset = "0x8778880", VA = "0x188779680")]
	public static int IOLHMEJOEHP(IPAPAOLOGOE MBFCBBCCMKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x87795B0", Offset = "0x87787B0", VA = "0x1887795B0")]
	public static int FCBPDLLLCPG(JMKIOIDBFKN NIHAIKKHHEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x87797A0", Offset = "0x87789A0", VA = "0x1887797A0")]
	public static void KPHCNAJMLCC(GameObject KFMNDOMPAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x87794D0", Offset = "0x87786D0", VA = "0x1887794D0")]
	public static void EOCCBFLPBEC(GameObject KFMNDOMPAMC, bool GHJCMHIHLFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KFJNDEGFOEK : JMKDBBNBJDD
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MKKOLENPKPB : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public KFJNDEGFOEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public MKKOLENPKPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8780950", Offset = "0x877FB50", VA = "0x188780950", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8780630", Offset = "0x877F830", VA = "0x188780630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x87805E0", Offset = "0x877F7E0", VA = "0x1887805E0")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8780900", Offset = "0x877FB00", VA = "0x188780900", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8780850", Offset = "0x877FA50", VA = "0x188780850", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8780850", Offset = "0x877FA50", VA = "0x188780850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MFHLEMCNGOL GFMOOECBEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GIALDAKICKE LBAFLICJMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GFGBEDMLANO JGGBNJFHLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<AFOMEKIHFAH> COEEELGHMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<AFOMEKIHFAH> NPJJEALILJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject LMKKCCHGFHL;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x877EFD0", Offset = "0x877E1D0", VA = "0x18877EFD0")]
	public static KFJNDEGFOEK AEDOHGOANOE(MFHLEMCNGOL CAIGHLKIDBF, GIALDAKICKE LBAFLICJMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8780350", Offset = "0x877F550", VA = "0x188780350")]
	private KFJNDEGFOEK(MFHLEMCNGOL CAIGHLKIDBF, GIALDAKICKE LBAFLICJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x877F120", Offset = "0x877E320", VA = "0x18877F120")]
	public void BHPGJKNEABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x877F5A0", Offset = "0x877E7A0", VA = "0x18877F5A0")]
	[IteratorStateMachine(typeof(MKKOLENPKPB))]
	public IEnumerable<Renderer> EGAMJJGAIJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x877F620", Offset = "0x877E820", VA = "0x18877F620", Slot = "4")]
	public void JCPEFEFFAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8780320", Offset = "0x877F520", VA = "0x188780320")]
	private void MIILCNKNJHD(Vector3 NOCFMOGCNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x87800D0", Offset = "0x877F2D0", VA = "0x1887800D0")]
	public void KJFMNLEBHBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AFOMEKIHFAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct EEFJBLPDFBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public ABBAFNICANG MNLGAHKKPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DONKIJIPKJK PCOBHPCKNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int EGGNLKEIEIF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JLPDLGGMGPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AFOMEKIHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public JFHEFEBDPBL lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<EEFJBLPDFBA> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OBIAGGAMNIO combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public JLPDLGGMGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x877EF40", Offset = "0x877E140", VA = "0x18877EF40")]
		internal JobHandle GDFIBKODBPE()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x877EFA0", Offset = "0x877E1A0", VA = "0x18877EFA0")]
		internal void ONLPHOONMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x877EDD0", Offset = "0x877DFD0", VA = "0x18877EDD0")]
		internal void FILIBIPPPAM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] IAMKGDECFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private PHMAAGBCMMK HBAHOADKOEG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 LLMJBIDNDJK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh OBJAHFCONND
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KKHPKCBJJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA09780", Offset = "0xA08980", VA = "0x180A09780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8773340", Offset = "0x8772540", VA = "0x188773340")]
	public void NHKFIBFOLLJ(List<DONKIJIPKJK> KAGBMAGLHOF, Matrix4x4[] FJELOGIKABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x87727E0", Offset = "0x87719E0", VA = "0x1887727E0")]
	public static List<AFOMEKIHFAH> DBJJOAFKEPP(List<NBENBDBGFFH> HHPNINBCJHE, JFHEFEBDPBL AEABCPDILIB, Bounds CMJBIEKALPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8772FE0", Offset = "0x87721E0", VA = "0x188772FE0")]
	private JobHandle MNBFNFHPCOC(OBIAGGAMNIO ALBIMMKGKII, int GJODKHLCBNE, int AEKPCFCEKPO, JFHEFEBDPBL AEABCPDILIB, List<EEFJBLPDFBA> MMGPKGAENPJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8772F00", Offset = "0x8772100", VA = "0x188772F00")]
	private void JEPAAGIMGBH(List<EEFJBLPDFBA> MMGPKGAENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x87736B0", Offset = "0x87728B0", VA = "0x1887736B0")]
	private AFOMEKIHFAH(List<EEFJBLPDFBA> MMGPKGAENPJ, int GJODKHLCBNE, int AEKPCFCEKPO, JFHEFEBDPBL AEABCPDILIB, Bounds CMJBIEKALPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8772E70", Offset = "0x8772070", VA = "0x188772E70", Slot = "4")]
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
		private MaterialPropertyBlock FDBGOGINECP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private AFOMEKIHFAH CGGHHEJPJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<DONKIJIPKJK> NEHDPDMMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture NKGDIIKGDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer NLMNIIHLNGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader CKCBILCCGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] NGJHAACGHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int JHELCABMMIP;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer DFDJIHPKFIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int DHPHIMBIFHN
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8785E30", Offset = "0x8785030", VA = "0x188785E30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8785100", Offset = "0x8784300", VA = "0x188785100")]
		public static List<SkinnedShapeRenderer> Create(GameObject OLEJNEHCCLF, List<AFOMEKIHFAH> ECMMPHFCBLK, List<DONKIJIPKJK> NEHDPDMMIDH, Material ADKDGJDNNAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x87854B0", Offset = "0x87846B0", VA = "0x1887854B0")]
		public void Init(AFOMEKIHFAH CGGHHEJPJND, List<DONKIJIPKJK> NEHDPDMMIDH, Material ADKDGJDNNAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8785D90", Offset = "0x8784F90", VA = "0x188785D90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8785CF0", Offset = "0x8784EF0", VA = "0x188785CF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8785CB0", Offset = "0x8784EB0", VA = "0x188785CB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x87853F0", Offset = "0x87845F0", VA = "0x1887853F0")]
		private void FOBPDNEILBB(ScriptableRenderContext BKDMJHGCDEA, Camera[] HEIMLAFDAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8785940", Offset = "0x8784B40", VA = "0x188785940")]
		private void NHKFIBFOLLJ(CommandBuffer MNOPFHLOEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
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
