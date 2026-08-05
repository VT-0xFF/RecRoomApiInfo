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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C0DFB0", Offset = "0x8C0CDB0", VA = "0x188C0DFB0", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C13CA0", Offset = "0x8C12AA0", VA = "0x188C13CA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BCPDGLEBGGM : CDOEEOGNIKC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte AMMJIAHFFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] LEPDFIEAIIC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FENMNCOPBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA60", Offset = "0xAAD860", VA = "0x180AAEA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DCHGONLKLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xABC820", Offset = "0xABB620", VA = "0x180ABC820", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xFF7DA0", Offset = "0xFF6BA0", VA = "0x180FF7DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float FOEJDEPIAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xFA7260", Offset = "0xFA6060", VA = "0x180FA7260", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x14F3320", Offset = "0x14F2120", VA = "0x1814F3320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float NKMKFOBDLCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD618B0", Offset = "0xD606B0", VA = "0x180D618B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD618C0", Offset = "0xD606C0", VA = "0x180D618C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> JFBINHMHEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C00910", Offset = "0x8BFF710", VA = "0x188C00910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> HIDMKHIGECE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C00960", Offset = "0x8BFF760", VA = "0x188C00960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject KBGGJKBKACF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte FOFIPBPPEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8C00510", Offset = "0x8BFF310", VA = "0x188C00510", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8C00AF0", Offset = "0x8BFF8F0", VA = "0x188C00AF0")]
	public BCPDGLEBGGM(List<CNBBJKLOIGC> BNGFHJGBNIC, List<CNBBJKLOIGC> FDPLHPPKCPL, List<GKKGCGDMMHN> HHNJKGDJJAI, Material KKBOKCGIENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8C009D0", Offset = "0x8BFF7D0", VA = "0x188C009D0")]
	private int PAFCGKIFPFB(List<CNBBJKLOIGC> APIAOCPINLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8C00660", Offset = "0x8BFF460", VA = "0x188C00660")]
	private void ENIGILMPGIJ(int FPANEINMEDI, bool BAMJEJIELLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8C007C0", Offset = "0x8BFF5C0", VA = "0x188C007C0")]
	public void HMDDJAFHGKD(Vector3 KIJFFLMIFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8C00560", Offset = "0x8BFF360", VA = "0x188C00560", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8C00990", Offset = "0x8BFF790", VA = "0x188C00990")]
	public void NKAJHKLNHGN(Transform EKAIEGLJILK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DJGEMLONNFC : KCPKDJMFOLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class JCCGCFJGKLC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DJGEMLONNFC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public JCCGCFJGKLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B440", Offset = "0x8C0A240", VA = "0x188C0B440", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8C0AE30", Offset = "0x8C09C30", VA = "0x188C0AE30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8C0ADE0", Offset = "0x8C09BE0", VA = "0x188C0ADE0")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8C0AD90", Offset = "0x8C09B90", VA = "0x188C0AD90")]
		private void ICJNGMGPPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8C0AD40", Offset = "0x8C09B40", VA = "0x188C0AD40")]
		private void CFICJJPCPHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B3F0", Offset = "0x8C0A1F0", VA = "0x188C0B3F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B340", Offset = "0x8C0A140", VA = "0x188C0B340", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B340", Offset = "0x8C0A140", VA = "0x188C0B340", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class AMJIEIJAJGK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public DJGEMLONNFC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public AMJIEIJAJGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8C00390", Offset = "0x8BFF190", VA = "0x188C00390", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFF20", Offset = "0x8BFED20", VA = "0x188BFFF20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFED0", Offset = "0x8BFECD0", VA = "0x188BFFED0")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFE80", Offset = "0x8BFEC80", VA = "0x188BFFE80")]
		private void ICJNGMGPPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8C00340", Offset = "0x8BFF140", VA = "0x188C00340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8C00290", Offset = "0x8BFF090", VA = "0x188C00290", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C00290", Offset = "0x8BFF090", VA = "0x188C00290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LCOLNOMHDFM DOEAAJHELBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<MKIAEJPFFHB> BFHCGLEOCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> HNCKMPHDJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer EBHDNBILNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool EBNJKLHGDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool OOFCNNGJJIO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<FLGADMIBPOE> LDOFENBHBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LAEGKOJFKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C04A10", Offset = "0x8C03810", VA = "0x188C04A10", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GKKGCGDMMHN FPBCANKJELH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8C05530", Offset = "0x8C04330", VA = "0x188C05530", Slot = "8")]
		get
		{
			return default(GKKGCGDMMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> HBCKCFFIEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA604F0", Offset = "0xA5F2F0", VA = "0x180A604F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8C05140", Offset = "0x8C03F40", VA = "0x188C05140")]
	private bool HBGIBFFOHNM(MKIAEJPFFHB KDLDDCCMAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8C05160", Offset = "0x8C03F60", VA = "0x188C05160")]
	private static bool JAMMIFBEHCD(MKIAEJPFFHB KDLDDCCMAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8C05E80", Offset = "0x8C04C80", VA = "0x188C05E80")]
	public DJGEMLONNFC(LCOLNOMHDFM BOIPFNOKGBJ, bool PHODPIOFMIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8C04A50", Offset = "0x8C03850", VA = "0x188C04A50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8C056F0", Offset = "0x8C044F0", VA = "0x188C056F0")]
	public void OLHPIGGMIDE(MKIAEJPFFHB KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8C04C40", Offset = "0x8C03A40", VA = "0x188C04C40")]
	public void EBNLHEFHMEO(MKIAEJPFFHB KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8C04510", Offset = "0x8C03310", VA = "0x188C04510", Slot = "4")]
	public void BJPBMKMNNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8C04E00", Offset = "0x8C03C00", VA = "0x188C04E00")]
	public void FLCGEBIGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8C05200", Offset = "0x8C04000", VA = "0x188C05200")]
	private void KLHLCLKNAGC(List<MKIAEJPFFHB> BFHCGLEOCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8C04DA0", Offset = "0x8C03BA0", VA = "0x188C04DA0")]
	private static Material EFPPCCJKAHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8C053C0", Offset = "0x8C041C0", VA = "0x188C053C0")]
	private void KLHLCLKNAGC(MKIAEJPFFHB KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8C05070", Offset = "0x8C03E70", VA = "0x188C05070")]
	private void GOCDGBKAPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8C058C0", Offset = "0x8C046C0", VA = "0x188C058C0")]
	public void PBDIJOCOGGG(bool LOFEKLHGBFJ, bool AHJNPBDJBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8C05470", Offset = "0x8C04270", VA = "0x188C05470")]
	protected void KPOEAOLLLJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8C05670", Offset = "0x8C04470", VA = "0x188C05670")]
	public void NGPAHAHFMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8C05180", Offset = "0x8C03F80", VA = "0x188C05180")]
	[IteratorStateMachine(typeof(JCCGCFJGKLC))]
	public IEnumerable<Renderer> KHEOBLFIKNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8C055F0", Offset = "0x8C043F0", VA = "0x188C055F0")]
	[IteratorStateMachine(typeof(AMJIEIJAJGK))]
	public IEnumerable<Renderer> LMEJCCIKCLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class CHBDKKCHGON : MKIAEJPFFHB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct MKAMECNKPPA : DIGDBPFFFLM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private JDKBCJCKCFH JLPONKINLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle BNNGADNDJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ODHOPNCBALO FPIHCFFNCNE;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8C0E100", Offset = "0x8C0CF00", VA = "0x188C0E100")]
		public MKAMECNKPPA(JDKBCJCKCFH JLPONKINLEO, JobHandle BNNGADNDJHP, ODHOPNCBALO FPIHCFFNCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8C0E080", Offset = "0x8C0CE80", VA = "0x188C0E080", Slot = "4")]
		public JDKBCJCKCFH AOLFNABIKLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8C0E0B0", Offset = "0x8C0CEB0", VA = "0x188C0E0B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly HDAFBNCPEAH LNJLPIKPAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float ILPHILAIAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 DMPHBNJFNNM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 BCKOPEBHBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C02290", Offset = "0x8C01090", VA = "0x188C02290", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8C02740", Offset = "0x8C01540", VA = "0x188C02740")]
	public CHBDKKCHGON(DJGEMLONNFC EGPDFGOHLFM, HDAFBNCPEAH BOIPFNOKGBJ, bool PHODPIOFMIE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "18")]
	public override bool BOEEBJJEFMG(GKKGCGDMMHN EGPDFGOHLFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8C02570", Offset = "0x8C01370", VA = "0x188C02570", Slot = "19")]
	public override int PAFCGKIFPFB(HNMFKBFJGMN IAOFFAAOAHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8C01AD0", Offset = "0x8C008D0", VA = "0x188C01AD0", Slot = "20")]
	public override int FFKCBFMMKMG(HNMFKBFJGMN IAOFFAAOAHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8C015D0", Offset = "0x8C003D0", VA = "0x188C015D0", Slot = "21")]
	public override HNHGONDNKLH CIELFOJAOFH()
	{
		return default(HNHGONDNKLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xABC800", Offset = "0xABB600", VA = "0x180ABC800", Slot = "22")]
	public override float BJHAFEKCBPP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8C01CA0", Offset = "0x8C00AA0", VA = "0x188C01CA0", Slot = "23")]
	public override void LEDPNKNACHC(HNMFKBFJGMN IAOFFAAOAHE, BPEFGPHLBBF CILAJCPACLF, int MGAJKFOGGML = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8C01A00", Offset = "0x8C00800", VA = "0x188C01A00", Slot = "24")]
	public override GKKGCGDMMHN CLLOEOHCKEH()
	{
		return default(GKKGCGDMMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8C023B0", Offset = "0x8C011B0", VA = "0x188C023B0", Slot = "26")]
	public override KNAIDINHAAN OIJOBPJJKEJ()
	{
		return default(KNAIDINHAAN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8C00E10", Offset = "0x8BFFC10", VA = "0x188C00E10", Slot = "27")]
	public override DIGDBPFFFLM CHPIBINFBOK(HNMFKBFJGMN IAOFFAAOAHE, JobHandle BNNGADNDJHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface PKIHFJPJOKF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DJGEMLONNFC CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MKIAEJPFFHB CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GJKAGIGKJPA CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class EPPINJAMGDK : JLDCHECNAIA, IDisposable, PKIHFJPJOKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DHECOFPBBGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public EPPINJAMGDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8C03F30", Offset = "0x8C02D30", VA = "0x188C03F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8C044B0", Offset = "0x8C032B0", VA = "0x188C044B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly AFCMBNCMNCF<IFKLBEEHLLN, DJGEMLONNFC> PFLNIKFOEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly AFCMBNCMNCF<DDJIEOGAMGL, MKIAEJPFFHB> BFHCGLEOCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly AFCMBNCMNCF<PLMBKMDHFEK, GJKAGIGKJPA> JKLEILKJICL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DJGEMLONNFC CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8C06F90", Offset = "0x8C05D90", VA = "0x188C06F90", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MKIAEJPFFHB CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8C07050", Offset = "0x8C05E50", VA = "0x188C07050", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public GJKAGIGKJPA CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8C06FF0", Offset = "0x8C05DF0", VA = "0x188C06FF0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NFJLGBBJHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xABC810", Offset = "0xABB610", VA = "0x180ABC810", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xABC540", Offset = "0xABB340", VA = "0x180ABC540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8C08390", Offset = "0x8C07190", VA = "0x188C08390")]
	public EPPINJAMGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8C06B60", Offset = "0x8C05960", VA = "0x188C06B60", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8C07D40", Offset = "0x8C06B40", VA = "0x188C07D40", Slot = "4")]
	public IFKLBEEHLLN KPNDHBBFOEN(LCOLNOMHDFM BOIPFNOKGBJ)
	{
		return default(IFKLBEEHLLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8C07D50", Offset = "0x8C06B50", VA = "0x188C07D50", Slot = "5")]
	public IFKLBEEHLLN KPNDHBBFOEN(LCOLNOMHDFM BOIPFNOKGBJ, bool PHODPIOFMIE)
	{
		return default(IFKLBEEHLLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8C06740", Offset = "0x8C05540", VA = "0x188C06740", Slot = "6")]
	public void DDEMKELICHA(IFKLBEEHLLN EGPDFGOHLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8C07660", Offset = "0x8C06460", VA = "0x188C07660", Slot = "7")]
	public void HFEPLEMBKCE(IFKLBEEHLLN EGPDFGOHLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8C07110", Offset = "0x8C05F10", VA = "0x188C07110", Slot = "8")]
	public DDJIEOGAMGL HCPNIHGNADO(IFKLBEEHLLN EGPDFGOHLFM, KCFGAJKDIOC BOIPFNOKGBJ)
	{
		return default(DDJIEOGAMGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8C06260", Offset = "0x8C05060", VA = "0x188C06260", Slot = "9")]
	public DDJIEOGAMGL BLNICLLKDFE(IFKLBEEHLLN EGPDFGOHLFM, HDAFBNCPEAH BOIPFNOKGBJ)
	{
		return default(DDJIEOGAMGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8C07FD0", Offset = "0x8C06DD0", VA = "0x188C07FD0", Slot = "11")]
	public void MLIPPHGPOJM(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8C06D30", Offset = "0x8C05B30", VA = "0x188C06D30", Slot = "10")]
	public void ECGHONJNKFF(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8C075F0", Offset = "0x8C063F0", VA = "0x188C075F0", Slot = "20")]
	public IEnumerable<Renderer> HEKFIJHIJMJ(IFKLBEEHLLN EGPDFGOHLFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8C079C0", Offset = "0x8C067C0", VA = "0x188C079C0", Slot = "12")]
	public PLMBKMDHFEK IBBIKOGMEAI(JKPIFGALOOA BOIPFNOKGBJ)
	{
		return default(PLMBKMDHFEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8C07CD0", Offset = "0x8C06AD0", VA = "0x188C07CD0", Slot = "14")]
	public void KIPNCNCMONH(PLMBKMDHFEK BKFEEEDBEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8C07B10", Offset = "0x8C06910", VA = "0x188C07B10", Slot = "16")]
	public Task KCMKNIMGKEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8C069A0", Offset = "0x8C057A0", VA = "0x188C069A0", Slot = "17")]
	public Task DJDHPHGMGOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8C07A40", Offset = "0x8C06840", VA = "0x188C07A40", Slot = "18")]
	[AsyncStateMachine(typeof(DHECOFPBBGG))]
	public Task ICFDIPJMBML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8C06170", Offset = "0x8C04F70", VA = "0x188C06170", Slot = "19")]
	public void BCHENKEKDPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8C070B0", Offset = "0x8C05EB0", VA = "0x188C070B0", Slot = "13")]
	public void EPIGPEOMJDE(PLMBKMDHFEK BKFEEEDBEMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class POKGOFKECKM : MKIAEJPFFHB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct ADHECHEOJMD : DIGDBPFFFLM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private JDKBCJCKCFH JLPONKINLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> OKEKJJMNEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle BNNGADNDJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CKOCHAKIKBH FPIHCFFNCNE;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFE20", Offset = "0x8BFEC20", VA = "0x188BFFE20")]
		public ADHECHEOJMD(JDKBCJCKCFH JLPONKINLEO, NativeArray<int> OKEKJJMNEKD, JobHandle BNNGADNDJHP, CKOCHAKIKBH FPIHCFFNCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFD20", Offset = "0x8BFEB20", VA = "0x188BFFD20", Slot = "4")]
		public JDKBCJCKCFH AOLFNABIKLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFFD80", Offset = "0x8BFEB80", VA = "0x188BFFD80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly KCFGAJKDIOC HBHDBEHHINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] NCHFEKCAKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 DMPHBNJFNNM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 IPOLPNMDFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8C11730", Offset = "0x8C10530", VA = "0x188C11730")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 BCKOPEBHBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8C123B0", Offset = "0x8C111B0", VA = "0x188C123B0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8C12740", Offset = "0x8C11540", VA = "0x188C12740")]
	public POKGOFKECKM(DJGEMLONNFC EGPDFGOHLFM, KCFGAJKDIOC BOIPFNOKGBJ, bool HLOCFLFBGJH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8C10670", Offset = "0x8C0F470", VA = "0x188C10670", Slot = "18")]
	public override bool BOEEBJJEFMG(GKKGCGDMMHN EGPDFGOHLFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8C11570", Offset = "0x8C10370", VA = "0x188C11570", Slot = "21")]
	public override HNHGONDNKLH CIELFOJAOFH()
	{
		return default(HNHGONDNKLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8C10F10", Offset = "0x8C0FD10", VA = "0x188C10F10")]
	private HNHGONDNKLH CIELFOJAOFH(GKKGCGDMMHN EGPDFGOHLFM)
	{
		return default(HNHGONDNKLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8C121B0", Offset = "0x8C10FB0", VA = "0x188C121B0")]
	private LHLGEBINKDK NBBOLIGPJPB([In] UniformTRS MBPKFFDBGKB, [In] float3 JMHOIIFJGPL)
	{
		return default(LHLGEBINKDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8C12690", Offset = "0x8C11490", VA = "0x188C12690", Slot = "19")]
	public override int PAFCGKIFPFB(HNMFKBFJGMN IAOFFAAOAHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8C11680", Offset = "0x8C10480", VA = "0x188C11680", Slot = "20")]
	public override int FFKCBFMMKMG(HNMFKBFJGMN IAOFFAAOAHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8C10300", Offset = "0x8C0F100", VA = "0x188C10300", Slot = "22")]
	public override float BJHAFEKCBPP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8C103F0", Offset = "0x8C0F1F0", VA = "0x188C103F0")]
	private int BKFFGBGOGDH(HNMFKBFJGMN IAOFFAAOAHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8C11960", Offset = "0x8C10760", VA = "0x188C11960", Slot = "23")]
	public override void LEDPNKNACHC(HNMFKBFJGMN IAOFFAAOAHE, BPEFGPHLBBF CILAJCPACLF, int MGAJKFOGGML = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8C115B0", Offset = "0x8C103B0", VA = "0x188C115B0", Slot = "24")]
	public override GKKGCGDMMHN CLLOEOHCKEH()
	{
		return default(GKKGCGDMMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8C124D0", Offset = "0x8C112D0", VA = "0x188C124D0", Slot = "26")]
	public override KNAIDINHAAN OIJOBPJJKEJ()
	{
		return default(KNAIDINHAAN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8C10740", Offset = "0x8C0F540", VA = "0x188C10740", Slot = "27")]
	public override DIGDBPFFFLM CHPIBINFBOK(HNMFKBFJGMN IAOFFAAOAHE, JobHandle BNNGADNDJHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NNIBBECMELG
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGBELFHOLKD(HMDPDMKPOCJ DGPNPBEKOOD, Renderer MIFBMDMJHAH, int BIJHOPPEGBP);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKEGIIKJFPD(Renderer MIFBMDMJHAH, IKKGENNIEIK OPMILLGOOOM, Vector3 PBBIMOLCJHL, Vector3 LDCEFMAJMOB, Vector3 LMPIOOGBHJE, float LELKNDGNJHD, float EMEKMNBIBCM, float GNPKKJNNIOA = -1f, [Optional] Color? PFKMCINIKNC, [Optional] IReadOnlyList<Camera> BJIMEDACCAF);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIBJEHLMCMM(Renderer MIFBMDMJHAH, int BIJHOPPEGBP);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DCDDPHPNDAJ();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGEKHIGLBIK(int NDCAIOFNDOF, CKJLKPAHMFI DGPNPBEKOOD, Renderer MIFBMDMJHAH, int BIJHOPPEGBP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KMIJJIICDLI : CHEKCMOLHDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class ANENKHMLOKD : FILBMKOFHMB<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8C004C0", Offset = "0x8BFF2C0", VA = "0x188C004C0")]
		public ANENKHMLOKD(string GGDFKFACHGG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NNIBBECMELG HJBJPHCLHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PKIHFJPJOKF LBIHDPDLPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer GKNFINIFKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private ANENKHMLOKD AHINBADCILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool NFJBIGBJPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer EHACJCNOAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private ANENKHMLOKD NDLNPDNBBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool BEKJBLHCJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer ADBHCEJDPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private ANENKHMLOKD PLEMFOJKAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool EOBJANNBHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool HDGGIMAAJCJ;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA639A0", Offset = "0xA627A0", VA = "0x180A639A0")]
	public KMIJJIICDLI(NNIBBECMELG NLNEAKEMABF, PKIHFJPJOKF LBIHDPDLPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8C0C560", Offset = "0x8C0B360", VA = "0x188C0C560", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8C0C8B0", Offset = "0x8C0B6B0", VA = "0x188C0C8B0")]
	private void IEOPIMNGKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8C0DA10", Offset = "0x8C0C810", VA = "0x188C0DA10", Slot = "4")]
	public void ONCLCDAHIIA(IFKLBEEHLLN EGPDFGOHLFM, CKJLKPAHMFI KMKJPPGBBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D7F0", Offset = "0x8C0C5F0", VA = "0x188C0D7F0", Slot = "5")]
	public void ONCLCDAHIIA(DDJIEOGAMGL KDLDDCCMAJC, CKJLKPAHMFI KMKJPPGBBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D500", Offset = "0x8C0C300", VA = "0x188C0D500", Slot = "6")]
	public void LJFIKDKBGPK(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D660", Offset = "0x8C0C460", VA = "0x188C0D660", Slot = "7")]
	public void NDBCIOCFBBG(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D7B0", Offset = "0x8C0C5B0", VA = "0x188C0D7B0", Slot = "24")]
	public void OHEAFLEDHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x11C8FF0", Offset = "0x11C7DF0", VA = "0x1811C8FF0", Slot = "8")]
	public void MGKOHFDFEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8C0DE40", Offset = "0x8C0CC40", VA = "0x188C0DE40", Slot = "9")]
	public void PLJMAEPEJNB(CKJLKPAHMFI KMKJPPGBBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8C0BC40", Offset = "0x8C0AA40", VA = "0x188C0BC40", Slot = "10")]
	public void DIOCCIDHHBM(IFKLBEEHLLN EGPDFGOHLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8C0BF20", Offset = "0x8C0AD20", VA = "0x188C0BF20", Slot = "11")]
	public void DIOCCIDHHBM(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D430", Offset = "0x8C0C230", VA = "0x188C0D430", Slot = "12")]
	public void LEKJDPOBBFD(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C0C710", Offset = "0x8C0B510", VA = "0x188C0C710", Slot = "13")]
	public void FDDOPICLLAG(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B9D0", Offset = "0x8C0A7D0", VA = "0x188C0B9D0")]
	private void CMFDNBDLDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1526660", Offset = "0x1525460", VA = "0x181526660", Slot = "14")]
	public void MDAEKAHGOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8C0DD20", Offset = "0x8C0CB20", VA = "0x188C0DD20", Slot = "15")]
	public void PCLFALFNMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8C0C280", Offset = "0x8C0B080", VA = "0x188C0C280", Slot = "16")]
	public void DJNOCPAIADL(IFKLBEEHLLN EGPDFGOHLFM, HMDPDMKPOCJ DGPNPBEKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8C0D360", Offset = "0x8C0C160", VA = "0x188C0D360", Slot = "17")]
	public void KOMIMFMKMAP(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8C0C7E0", Offset = "0x8C0B5E0", VA = "0x188C0C7E0", Slot = "18")]
	public void FDLDIFOGGDP(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xDB6B40", Offset = "0xDB5940", VA = "0x180DB6B40", Slot = "19")]
	public void KCGHPKPECDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B630", Offset = "0x8C0A430", VA = "0x188C0B630", Slot = "20")]
	public void ALKHDBDPABN(HMDPDMKPOCJ DGPNPBEKOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B760", Offset = "0x8C0A560", VA = "0x188C0B760")]
	private void BOAAGGBMBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8C0CFA0", Offset = "0x8C0BDA0", VA = "0x188C0CFA0", Slot = "21")]
	public void JINFDJEFPDC(IFKLBEEHLLN EGPDFGOHLFM, Vector3 PBBIMOLCJHL, Vector3 LDCEFMAJMOB, Vector3 LMPIOOGBHJE, float LELKNDGNJHD, float EMEKMNBIBCM, IReadOnlyList<Camera> CFGPGBNFLMI, IKKGENNIEIK OPMILLGOOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8C0CB20", Offset = "0x8C0B920", VA = "0x188C0CB20", Slot = "22")]
	public void JINFDJEFPDC(PLMBKMDHFEK BKFEEEDBEMD, Vector3 PBBIMOLCJHL, Vector3 LDCEFMAJMOB, Vector3 LMPIOOGBHJE, float LELKNDGNJHD, float EMEKMNBIBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class MKIAEJPFFHB : EDFFAFGGICA, FLGADMIBPOE, CIKBLNPANNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly DJGEMLONNFC KBGGJKBKACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int LFNMCPALGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds KGIBLGHPGNO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds DFMGIKNBIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C0E310", Offset = "0x8C0D110", VA = "0x188C0E310", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool OOFCNNGJJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE82DE0", Offset = "0xE81BE0", VA = "0x180E82DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xE82F50", Offset = "0xE81D50", VA = "0x180E82F50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 BCKOPEBHBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CGHOMEPBHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAB4B10", Offset = "0xAB3910", VA = "0x180AB4B10", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public IBKODJOLAHA CDEHCOFFDMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA604F0", Offset = "0xA5F2F0", VA = "0x180A604F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool LNFMDPLMBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xFD7B50", Offset = "0xFD6950", VA = "0x180FD7B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	protected MKIAEJPFFHB(DJGEMLONNFC EGPDFGOHLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C0E170", Offset = "0x8C0CF70", VA = "0x188C0E170", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "18")]
	public virtual bool BOEEBJJEFMG(GKKGCGDMMHN EGPDFGOHLFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8C0E160", Offset = "0x8C0CF60", VA = "0x188C0E160", Slot = "10")]
	public int BFKBICOKAMG(int ALADHEOHJIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int PAFCGKIFPFB(HNMFKBFJGMN IAOFFAAOAHE);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int FFKCBFMMKMG(HNMFKBFJGMN IAOFFAAOAHE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract HNHGONDNKLH CIELFOJAOFH();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float BJHAFEKCBPP();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void LEDPNKNACHC(HNMFKBFJGMN IAOFFAAOAHE, BPEFGPHLBBF CILAJCPACLF, int MGAJKFOGGML = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract GKKGCGDMMHN CLLOEOHCKEH();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8C0E330", Offset = "0x8C0D130", VA = "0x188C0E330", Slot = "13")]
	public Hash128 LBMIKJFMMMI(int IAOFFAAOAHE)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract KNAIDINHAAN OIJOBPJJKEJ();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract DIGDBPFFFLM CHPIBINFBOK(HNMFKBFJGMN IAOFFAAOAHE, JobHandle BNNGADNDJHP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8C0E2E0", Offset = "0x8C0D0E0", VA = "0x188C0E2E0", Slot = "12")]
	public DIGDBPFFFLM IHBCEOCAINM(int IAOFFAAOAHE)
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
		[Cpp2IlInjected.Address(RVA = "0x8C127F0", Offset = "0x8C115F0", VA = "0x188C127F0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NLCKGHAEIME
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HCFGMHLHPKF : IEnumerable<DIHOICIHHKI>, IEnumerable, IEnumerator<DIHOICIHHKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private DIHOICIHHKI <>2__current;

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
		private DIHOICIHHKI System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public HCFGMHLHPKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C09CC0", Offset = "0x8C08AC0", VA = "0x188C09CC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C09E30", Offset = "0x8C08C30", VA = "0x188C09E30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C09D90", Offset = "0x8C08B90", VA = "0x188C09D90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DIHOICIHHKI> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C09D90", Offset = "0x8C08B90", VA = "0x188C09D90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static DIHOICIHHKI[][] IIFNHGHBPCD;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static ANKKABNCLLL BHEFOONGCAO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig HENDIAJFCNO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader EDIOALFHIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C0F270", Offset = "0x8C0E070", VA = "0x188C0F270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer AMCJLLAHNGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C0FCB0", Offset = "0x8C0EAB0", VA = "0x188C0FCB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F180", Offset = "0x8C0DF80", VA = "0x188C0F180")]
	[ODKIEBDNNBP]
	internal static void DGPDNICIDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FD10", Offset = "0x8C0EB10", VA = "0x188C0FD10")]
	public static Mesh MMDGCPCFBFD(LBBOFCAGNFJ HGNGGLLAGOO, int IAOFFAAOAHE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F170", Offset = "0x8C0DF70", VA = "0x188C0F170")]
	public static int DCMMLHICJDD(LBBOFCAGNFJ HGNGGLLAGOO, int IAOFFAAOAHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FA90", Offset = "0x8C0E890", VA = "0x188C0FA90")]
	public static ANKKABNCLLL LJNCBJJPOBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F6A0", Offset = "0x8C0E4A0", VA = "0x188C0F6A0")]
	[IteratorStateMachine(typeof(HCFGMHLHPKF))]
	private static IEnumerable<DIHOICIHHKI> GHAMOFCHIJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8C0E360", Offset = "0x8C0D160", VA = "0x188C0E360")]
	public static DIHOICIHHKI BPPKJGBCNIP(LBBOFCAGNFJ HGNGGLLAGOO, int IAOFFAAOAHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FDB0", Offset = "0x8C0EBB0", VA = "0x188C0FDB0")]
	public static bool MPADGPMBNCF(this LBBOFCAGNFJ HGNGGLLAGOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F700", Offset = "0x8C0E500", VA = "0x188C0F700")]
	public static void GICKKHCMLCL(LBBOFCAGNFJ HGNGGLLAGOO, float3 HBHKALHEAKN, [Out] BHMPFOJFNNH BFOPBIFFKKH, [Out] float3 GGOMHNEIGGA, [Out] float OKKLHHAKNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F2D0", Offset = "0x8C0E0D0", VA = "0x188C0F2D0")]
	public static void GEGHFJFGOFI(Vector3 HBHKALHEAKN, LBBOFCAGNFJ HGNGGLLAGOO, [Out] Vector3 GGOMHNEIGGA, [Out] float OKKLHHAKNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FDD0", Offset = "0x8C0EBD0", VA = "0x188C0FDD0")]
	[CDLPEHGFEKB(0)]
	[KHKJFPPHBKK(IGGCGDAJNBL.ExitingPlayMode, 0)]
	private static void OANGPBKHJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8C0F8B0", Offset = "0x8C0E6B0", VA = "0x188C0F8B0")]
	[CDLPEHGFEKB(0)]
	[KHKJFPPHBKK(IGGCGDAJNBL.ExitingPlayMode, 0)]
	private static void LDOCPMACAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class HGKIPEEGNBM : JLDCHECNAIA, IDisposable, PKIHFJPJOKF
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly AFCMBNCMNCF<IFKLBEEHLLN, DJGEMLONNFC> PFLNIKFOEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AFCMBNCMNCF<DDJIEOGAMGL, MKIAEJPFFHB> BFHCGLEOCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly AFCMBNCMNCF<PLMBKMDHFEK, GJKAGIGKJPA> JKLEILKJICL;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public DJGEMLONNFC CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A270", Offset = "0x8C09070", VA = "0x188C0A270", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MKIAEJPFFHB CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A210", Offset = "0x8C09010", VA = "0x188C0A210", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public GJKAGIGKJPA CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A1B0", Offset = "0x8C08FB0", VA = "0x188C0A1B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NFJLGBBJHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xABC810", Offset = "0xABB610", VA = "0x180ABC810", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xABC540", Offset = "0xABB340", VA = "0x180ABC540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A950", Offset = "0x8C09750", VA = "0x188C0A950")]
	public HGKIPEEGNBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A0C0", Offset = "0x8C08EC0", VA = "0x188C0A0C0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A790", Offset = "0x8C09590", VA = "0x188C0A790", Slot = "4")]
	public IFKLBEEHLLN KPNDHBBFOEN(LCOLNOMHDFM BOIPFNOKGBJ)
	{
		return default(IFKLBEEHLLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A790", Offset = "0x8C09590", VA = "0x188C0A790", Slot = "5")]
	public IFKLBEEHLLN KPNDHBBFOEN(LCOLNOMHDFM BOIPFNOKGBJ, bool PHODPIOFMIE)
	{
		return default(IFKLBEEHLLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8C09FC0", Offset = "0x8C08DC0", VA = "0x188C09FC0", Slot = "6")]
	public void DDEMKELICHA(IFKLBEEHLLN EGPDFGOHLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A4E0", Offset = "0x8C092E0", VA = "0x188C0A4E0", Slot = "7")]
	public void HFEPLEMBKCE(IFKLBEEHLLN EGPDFGOHLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A330", Offset = "0x8C09130", VA = "0x188C0A330", Slot = "8")]
	public DDJIEOGAMGL HCPNIHGNADO(IFKLBEEHLLN EGPDFGOHLFM, KCFGAJKDIOC BOIPFNOKGBJ)
	{
		return default(DDJIEOGAMGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8C09E80", Offset = "0x8C08C80", VA = "0x188C09E80", Slot = "9")]
	public DDJIEOGAMGL BLNICLLKDFE(IFKLBEEHLLN EGPDFGOHLFM, HDAFBNCPEAH BOIPFNOKGBJ)
	{
		return default(DDJIEOGAMGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A830", Offset = "0x8C09630", VA = "0x188C0A830", Slot = "11")]
	public void MLIPPHGPOJM(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A150", Offset = "0x8C08F50", VA = "0x188C0A150", Slot = "10")]
	public void ECGHONJNKFF(DDJIEOGAMGL KDLDDCCMAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A470", Offset = "0x8C09270", VA = "0x188C0A470", Slot = "20")]
	public IEnumerable<Renderer> HEKFIJHIJMJ(IFKLBEEHLLN EGPDFGOHLFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A560", Offset = "0x8C09360", VA = "0x188C0A560", Slot = "12")]
	public PLMBKMDHFEK IBBIKOGMEAI(JKPIFGALOOA BOIPFNOKGBJ)
	{
		return default(PLMBKMDHFEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A720", Offset = "0x8C09520", VA = "0x188C0A720", Slot = "14")]
	public void KIPNCNCMONH(PLMBKMDHFEK BKFEEEDBEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A680", Offset = "0x8C09480", VA = "0x188C0A680", Slot = "16")]
	public Task KCMKNIMGKEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A020", Offset = "0x8C08E20", VA = "0x188C0A020", Slot = "17")]
	public Task DJDHPHGMGOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A5E0", Offset = "0x8C093E0", VA = "0x188C0A5E0", Slot = "18")]
	public Task ICFDIPJMBML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x289D5B0", Offset = "0x289C3B0", VA = "0x18289D5B0", Slot = "19")]
	public void BCHENKEKDPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8C0A2D0", Offset = "0x8C090D0", VA = "0x188C0A2D0", Slot = "13")]
	public void EPIGPEOMJDE(PLMBKMDHFEK BKFEEEDBEMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ANHIBBCMEBE
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool NHFEBNIAFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material NPLGOKNNIAD();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material EFPPCCJKAHJ();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material CJPBLOGKLGJ();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ANCAEIJEBPD(AOKFBPFAEAA MJHKIJLGCOG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CNEIEOMKMMA(PLHKBDHNDHI ODADEEAHHEA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FFIJKAOFIHJ(GameObject MKPNGAKJFMP);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JIJGDKLMJIK(GameObject MKPNGAKJFMP, bool BDIDEBAFFBP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class NLCMBJFBBFA
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static ANHIBBCMEBE HJPGLGOFFHP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool NHFEBNIAFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8C10160", Offset = "0x8C0EF60", VA = "0x188C10160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8C10020", Offset = "0x8C0EE20", VA = "0x188C10020")]
	public static void FBGJEJKJIIH(ANHIBBCMEBE DDMNLOEFPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8C102A0", Offset = "0x8C0F0A0", VA = "0x188C102A0")]
	public static Material NPLGOKNNIAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8C04DA0", Offset = "0x8C03BA0", VA = "0x188C04DA0")]
	public static Material EFPPCCJKAHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FF50", Offset = "0x8C0ED50", VA = "0x188C0FF50")]
	public static Material CJPBLOGKLGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FEE0", Offset = "0x8C0ECE0", VA = "0x188C0FEE0")]
	public static int ANCAEIJEBPD(AOKFBPFAEAA MJHKIJLGCOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8C0FFB0", Offset = "0x8C0EDB0", VA = "0x188C0FFB0")]
	public static int CNEIEOMKMMA(PLHKBDHNDHI ODADEEAHHEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8C10080", Offset = "0x8C0EE80", VA = "0x188C10080")]
	public static void FFIJKAOFIHJ(GameObject MKPNGAKJFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8C101C0", Offset = "0x8C0EFC0", VA = "0x188C101C0")]
	public static void JIJGDKLMJIK(GameObject MKPNGAKJFMP, bool BDIDEBAFFBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GJKAGIGKJPA : KCPKDJMFOLP
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CNCLINBFNAM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GJKAGIGKJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public CNCLINBFNAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8C03EA0", Offset = "0x8C02CA0", VA = "0x188C03EA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8C03B80", Offset = "0x8C02980", VA = "0x188C03B80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8C03B30", Offset = "0x8C02930", VA = "0x188C03B30")]
		private void KHMMOEFKMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8C03E50", Offset = "0x8C02C50", VA = "0x188C03E50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8C03DA0", Offset = "0x8C02BA0", VA = "0x188C03DA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8C03DA0", Offset = "0x8C02BA0", VA = "0x188C03DA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JKPIFGALOOA KCHKMNBOIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly PKIHFJPJOKF LBIHDPDLPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private BCPDGLEBGGM GFNIJIDDJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<CNBBJKLOIGC> GIMDKHIBDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<CNBBJKLOIGC> NMLHKNBHBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject HGCDJKCGBAI;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8C09A90", Offset = "0x8C08890", VA = "0x188C09A90")]
	public static GJKAGIGKJPA MGGKBLKHAKA(JKPIFGALOOA BOIPFNOKGBJ, PKIHFJPJOKF LBIHDPDLPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8C09BE0", Offset = "0x8C089E0", VA = "0x188C09BE0")]
	private GJKAGIGKJPA(JKPIFGALOOA BOIPFNOKGBJ, PKIHFJPJOKF LBIHDPDLPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8C09600", Offset = "0x8C08400", VA = "0x188C09600")]
	public void LEFDKMKGENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8C09580", Offset = "0x8C08380", VA = "0x188C09580")]
	[IteratorStateMachine(typeof(CNCLINBFNAM))]
	public IEnumerable<Renderer> KHEOBLFIKNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8C08840", Offset = "0x8C07640", VA = "0x188C08840", Slot = "4")]
	public void BJPBMKMNNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8C09550", Offset = "0x8C08350", VA = "0x188C09550")]
	private void HMKMNEGJKJM(Vector3 KIJFFLMIFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8C09300", Offset = "0x8C08100", VA = "0x188C09300")]
	public void FLCGEBIGNJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CNBBJKLOIGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct DIIIHLCDCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public BPEFGPHLBBF KKFKLBNLDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GKKGCGDMMHN BACADDICFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int HCIMDCJJIMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EAAGLDNIDIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public CNBBJKLOIGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public HNMFKBFJGMN lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<DIIIHLCDCDC> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JDKBCJCKCFH combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EAAGLDNIDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8C05F70", Offset = "0x8C04D70", VA = "0x188C05F70")]
		internal JobHandle CABKDCOCKPB()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8C05FD0", Offset = "0x8C04DD0", VA = "0x188C05FD0")]
		internal void HGLEAMJBNCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8C06000", Offset = "0x8C04E00", VA = "0x188C06000")]
		internal void PBGINCOJLCE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] KDBIMPMGGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JJMODHFNJLA DIKMIJDLAPN;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 NMNIOOHHEFH;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh PKCFGBJDDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KOJBEOFPENK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E630", Offset = "0xA5D430", VA = "0x180A5E630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8C027F0", Offset = "0x8C015F0", VA = "0x188C027F0")]
	public void BMFBMCFNEEM(List<GKKGCGDMMHN> LBGPKADNGDM, Matrix4x4[] PBNFBMDFCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8C02ED0", Offset = "0x8C01CD0", VA = "0x188C02ED0")]
	public static List<CNBBJKLOIGC> LDFHHMLGJNG(List<DJGEMLONNFC> PJBNOKNBMOH, HNMFKBFJGMN IAOFFAAOAHE, Bounds NHFILKMEGHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8C02A80", Offset = "0x8C01880", VA = "0x188C02A80")]
	private JobHandle GGIPJBPEPPA(JDKBCJCKCFH KKGKPOMPOEJ, int NGLPFAHDCAG, int KEAPCBAFJDC, HNMFKBFJGMN IAOFFAAOAHE, List<DIIIHLCDCDC> ANIFGDMFBCK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8C02DF0", Offset = "0x8C01BF0", VA = "0x188C02DF0")]
	private void HPKFGCMMOJG(List<DIIIHLCDCDC> ANIFGDMFBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8C03700", Offset = "0x8C02500", VA = "0x188C03700")]
	private CNBBJKLOIGC(List<DIIIHLCDCDC> ANIFGDMFBCK, int NGLPFAHDCAG, int KEAPCBAFJDC, HNMFKBFJGMN IAOFFAAOAHE, Bounds NHFILKMEGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8C029E0", Offset = "0x8C017E0", VA = "0x188C029E0", Slot = "4")]
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
		private MaterialPropertyBlock LGKIDBKPILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private CNBBJKLOIGC JLPONKINLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<GKKGCGDMMHN> HHNJKGDJJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture JNLMCOIOHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer IEBHCMNDHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader CLFELBFJMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] JJGELJMIFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int AJJBFNIMNHD;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer OOAJEHPMDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int ICGPOMBEAIN
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8C13520", Offset = "0x8C12320", VA = "0x188C13520")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8C12BC0", Offset = "0x8C119C0", VA = "0x188C12BC0")]
		public static List<SkinnedShapeRenderer> Create(GameObject EGPDFGOHLFM, List<CNBBJKLOIGC> APIAOCPINLL, List<GKKGCGDMMHN> HHNJKGDJJAI, Material KKBOKCGIENM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8C12F10", Offset = "0x8C11D10", VA = "0x188C12F10")]
		public void Init(CNBBJKLOIGC JLPONKINLEO, List<GKKGCGDMMHN> HHNJKGDJJAI, Material KKBOKCGIENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8C13480", Offset = "0x8C12280", VA = "0x188C13480")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8C133E0", Offset = "0x8C121E0", VA = "0x188C133E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8C133A0", Offset = "0x8C121A0", VA = "0x188C133A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8C12E50", Offset = "0x8C11C50", VA = "0x188C12E50")]
		private void IIHELBNDIFF(ScriptableRenderContext IEOOLFDDEEF, Camera[] ABKGDJJCDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8C12850", Offset = "0x8C11650", VA = "0x188C12850")]
		private void BMFBMCFNEEM(CommandBuffer NFNJLJCKIKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
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
