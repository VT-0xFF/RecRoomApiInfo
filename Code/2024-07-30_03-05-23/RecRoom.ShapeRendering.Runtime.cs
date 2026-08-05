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
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ShapeRendering;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : PBLCGONKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7361600", Offset = "0x735FC00", VA = "0x187361600", Slot = "4")]
		public override void NECNOABNHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FIIPEIIOMED : JAFKFBDBLEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte CDPJHPKAELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] IMLHNAOJEGO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ABKDPNKJLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F0910", Offset = "0x8EEF10", VA = "0x1808F0910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FJKLKILFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A5C50", Offset = "0x8A4250", VA = "0x1808A5C50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A5800", Offset = "0x8A3E00", VA = "0x1808A5800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float HKLEIBILCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F76E0", Offset = "0x8F5CE0", VA = "0x1808F76E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA08240", Offset = "0xA06840", VA = "0x180A08240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float DMNDJANPJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F76F0", Offset = "0x8F5CF0", VA = "0x1808F76F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1EE70", Offset = "0xA1D470", VA = "0x180A1EE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> IHEGHDPHMIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x735AC40", Offset = "0x7359240", VA = "0x18735AC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> LMBDKIDCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x735ABC0", Offset = "0x73591C0", VA = "0x18735ABC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject DBCKFKNELBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x868240", Offset = "0x866840", VA = "0x180868240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte COONGHLOPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x735ABF0", Offset = "0x73591F0", VA = "0x18735ABF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x735B1A0", Offset = "0x73597A0", VA = "0x18735B1A0")]
	public FIIPEIIOMED(List<GOPFBDMAOLI> EAALCLIPFHI, List<GOPFBDMAOLI> KLCBLJDINLJ, List<ANOGDKLDLNH> BOJAJHMAICH, Material OLKLLNJBJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x735ADE0", Offset = "0x73593E0", VA = "0x18735ADE0")]
	private int CNBPJBALINA(List<GOPFBDMAOLI> INKJCILNAFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x735B000", Offset = "0x7359600", VA = "0x18735B000")]
	private void FPMGEKAKPBG(int EDKJLNGJMKD, bool HBGFFBOKCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x735AC90", Offset = "0x7359290", VA = "0x18735AC90")]
	public void CEHBNLAIAAG(Vector3 IMKGEEMJCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x735AF00", Offset = "0x7359500", VA = "0x18735AF00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x735B160", Offset = "0x7359760", VA = "0x18735B160")]
	public void MEKGJNMHMOP(Transform JMANKKLPIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EFNLKGLPBNG : DLNMIJBDDHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class CBDACNBPCID : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EFNLKGLPBNG <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BEBB0", Offset = "0x8BD1B0", VA = "0x1808BEBB0")]
		[DebuggerHidden]
		public CBDACNBPCID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7355D90", Offset = "0x7354390", VA = "0x187355D90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7355730", Offset = "0x7353D30", VA = "0x187355730", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x73556E0", Offset = "0x7353CE0", VA = "0x1873556E0")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7355690", Offset = "0x7353C90", VA = "0x187355690")]
		private void DLKKNIILKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7355C40", Offset = "0x7354240", VA = "0x187355C40")]
		private void OLFHDMELMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7355D40", Offset = "0x7354340", VA = "0x187355D40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7355C90", Offset = "0x7354290", VA = "0x187355C90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7355C90", Offset = "0x7354290", VA = "0x187355C90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class OOPOHGBLHGH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public EFNLKGLPBNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8BEBB0", Offset = "0x8BD1B0", VA = "0x1808BEBB0")]
		[DebuggerHidden]
		public OOPOHGBLHGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7364650", Offset = "0x7362C50", VA = "0x187364650", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x73641E0", Offset = "0x73627E0", VA = "0x1873641E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7364190", Offset = "0x7362790", VA = "0x187364190")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7364140", Offset = "0x7362740", VA = "0x187364140")]
		private void DLKKNIILKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7364600", Offset = "0x7362C00", VA = "0x187364600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7364550", Offset = "0x7362B50", VA = "0x187364550", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7364550", Offset = "0x7362B50", VA = "0x187364550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NBCFOMAMNIJ GEIBOHFEECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<DNIBBDPGHFE> MFLMPDLIMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> EANHFOAGMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer CFIDMPNOOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool PIEIDKKLCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool AHLGMCIHCEJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<IGGMCOMIHMK> KMJBCLDMOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PAPADDIADFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7357EA0", Offset = "0x73564A0", VA = "0x187357EA0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ANOGDKLDLNH NJIAEDMFBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x73579C0", Offset = "0x7355FC0", VA = "0x1873579C0", Slot = "8")]
		get
		{
			return default(ANOGDKLDLNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> IIAAHHHACML
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x868CD0", Offset = "0x8672D0", VA = "0x180868CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7357BB0", Offset = "0x73561B0", VA = "0x187357BB0")]
	private bool JAGLPPNDEMD(DNIBBDPGHFE ALHKJMBLFMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7358490", Offset = "0x7356A90", VA = "0x187358490")]
	private static bool LEGDPALAHDJ(DNIBBDPGHFE ALHKJMBLFMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7358FD0", Offset = "0x73575D0", VA = "0x187358FD0")]
	public EFNLKGLPBNG(NBCFOMAMNIJ MMDLBEBNCGC, bool HFJLIEOFLEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7357840", Offset = "0x7355E40", VA = "0x187357840", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x73584B0", Offset = "0x7356AB0", VA = "0x1873584B0")]
	public void LHEPNGLDBLI(DNIBBDPGHFE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7357A90", Offset = "0x7356090", VA = "0x187357A90")]
	public void HHOKGKJNBNI(DNIBBDPGHFE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7358990", Offset = "0x7356F90", VA = "0x187358990", Slot = "4")]
	public void OPIEDINIMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7357C50", Offset = "0x7356250", VA = "0x187357C50")]
	public void JPIODFAGAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7358720", Offset = "0x7356D20", VA = "0x187358720")]
	private void ODMKDMALKII(List<DNIBBDPGHFE> MFLMPDLIMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7357030", Offset = "0x7355630", VA = "0x187357030")]
	private static Material DACJGEPOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x73588E0", Offset = "0x7356EE0", VA = "0x1873588E0")]
	private void ODMKDMALKII(DNIBBDPGHFE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7358650", Offset = "0x7356C50", VA = "0x187358650")]
	private void MJJGFLGFJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7357EE0", Offset = "0x73564E0", VA = "0x187357EE0")]
	public void LDACDHAFAIE(bool HPAGJMPIPAL, bool DBHFBPLFCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7358E90", Offset = "0x7357490", VA = "0x187358E90")]
	protected void PIGICJKDOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7358F50", Offset = "0x7357550", VA = "0x187358F50")]
	[IteratorStateMachine(typeof(CBDACNBPCID))]
	public IEnumerable<Renderer> PNPGGGAHFIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7357BD0", Offset = "0x73561D0", VA = "0x187357BD0")]
	[IteratorStateMachine(typeof(OOPOHGBLHGH))]
	public IEnumerable<Renderer> JNIDLDAFKGM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class EOLGHEDMFOH : DNIBBDPGHFE
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct LODBLJMOEFB : NOOKLLFGOEC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OMKOMDIKKEA CKFPIMAMAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle KDEMNIPNNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ILEDHHPLJDK DBEKDCHDJGH;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x73615A0", Offset = "0x735FBA0", VA = "0x1873615A0")]
		public LODBLJMOEFB(OMKOMDIKKEA CKFPIMAMAKM, JobHandle KDEMNIPNNKE, ILEDHHPLJDK DBEKDCHDJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7361570", Offset = "0x735FB70", VA = "0x187361570", Slot = "4")]
		public OMKOMDIKKEA OBILMPBHNMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7361520", Offset = "0x735FB20", VA = "0x187361520", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly JBDKBGHIKJK JKNJNJCNJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float JABHJBKOLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 HFKOABDACFP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 AICFLOAANKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x735A9E0", Offset = "0x7358FE0", VA = "0x18735A9E0", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x735AB10", Offset = "0x7359110", VA = "0x18735AB10")]
	public EOLGHEDMFOH(EFNLKGLPBNG OPJBDKMKMOF, JBDKBGHIKJK MMDLBEBNCGC, bool HFJLIEOFLEI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "17")]
	public override bool HGHEIMJCAFL(ANOGDKLDLNH OPJBDKMKMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7359600", Offset = "0x7357C00", VA = "0x187359600", Slot = "18")]
	public override int CNBPJBALINA(FBANJHDKKJI HEPMKAJPNDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x735A220", Offset = "0x7358820", VA = "0x18735A220", Slot = "19")]
	public override int IIAIHJCEFGF(FBANJHDKKJI HEPMKAJPNDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x73590C0", Offset = "0x73576C0", VA = "0x1873590C0", Slot = "20")]
	public override Bounds BFNPFABLBEC()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x9FD450", Offset = "0x9FBA50", VA = "0x1809FD450", Slot = "21")]
	public override float FIIIGANAIOH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x735A3F0", Offset = "0x73589F0", VA = "0x18735A3F0", Slot = "22")]
	public override void JHJIMEDJMNL(FBANJHDKKJI HEPMKAJPNDG, HEAFCDEBBOK MLDFLCHLFPO, int JMOEGHALLJA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x73597D0", Offset = "0x7357DD0", VA = "0x1873597D0", Slot = "23")]
	public override ANOGDKLDLNH EEBMMMJDODL()
	{
		return default(ANOGDKLDLNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x73598A0", Offset = "0x7357EA0", VA = "0x1873598A0", Slot = "25")]
	public override DGLDHLPMLHH EOINAEDJIJF()
	{
		return default(DGLDHLPMLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7359A50", Offset = "0x7358050", VA = "0x187359A50", Slot = "26")]
	public override NOOKLLFGOEC HAKKNOMABEO(FBANJHDKKJI HEPMKAJPNDG, JobHandle KDEMNIPNNKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface KCJLDABJCDL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EFNLKGLPBNG CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DNIBBDPGHFE CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IJIJAIBOHGB CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class LFOKHNGFHJE : ABMGIHGABKH, IDisposable, KCJLDABJCDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct MMAKEDNDODC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LFOKHNGFHJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7361690", Offset = "0x735FC90", VA = "0x187361690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7361BB0", Offset = "0x73601B0", VA = "0x187361BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly PAFELJNLCII<KNLOLEOJCHI, EFNLKGLPBNG> IBJDGNAKNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly PAFELJNLCII<IBHAMOLJEBE, DNIBBDPGHFE> MFLMPDLIMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly PAFELJNLCII<FBIOJGOPNMA, IJIJAIBOHGB> NMOOIDHBFMI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EFNLKGLPBNG CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7360B30", Offset = "0x735F130", VA = "0x187360B30", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DNIBBDPGHFE CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7360AD0", Offset = "0x735F0D0", VA = "0x187360AD0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IJIJAIBOHGB CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7360B90", Offset = "0x735F190", VA = "0x187360B90", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool INEHBGLMMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAA5760", Offset = "0xAA3D60", VA = "0x180AA5760", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xB9CB80", Offset = "0xB9B180", VA = "0x180B9CB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7360E70", Offset = "0x735F470", VA = "0x187360E70")]
	public LFOKHNGFHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x735F8F0", Offset = "0x735DEF0", VA = "0x18735F8F0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x735F880", Offset = "0x735DE80", VA = "0x18735F880", Slot = "4")]
	public KNLOLEOJCHI CHCNLPLPKFI(NBCFOMAMNIJ MMDLBEBNCGC)
	{
		return default(KNLOLEOJCHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x735F600", Offset = "0x735DC00", VA = "0x18735F600", Slot = "5")]
	public KNLOLEOJCHI CHCNLPLPKFI(NBCFOMAMNIJ MMDLBEBNCGC, bool HFJLIEOFLEI)
	{
		return default(KNLOLEOJCHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x735FAF0", Offset = "0x735E0F0", VA = "0x18735FAF0", Slot = "6")]
	public void FINNPDBADIG(KNLOLEOJCHI OPJBDKMKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x735FD50", Offset = "0x735E350", VA = "0x18735FD50", Slot = "7")]
	public void GIKHBDGNGEJ(KNLOLEOJCHI OPJBDKMKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7360310", Offset = "0x735E910", VA = "0x187360310", Slot = "8")]
	public IBHAMOLJEBE HMFBNACJIEC(KNLOLEOJCHI OPJBDKMKMOF, GNPIAAGDACE MMDLBEBNCGC)
	{
		return default(IBHAMOLJEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x735F120", Offset = "0x735D720", VA = "0x18735F120", Slot = "9")]
	public IBHAMOLJEBE CEBKMEAPKNP(KNLOLEOJCHI OPJBDKMKMOF, JBDKBGHIKJK MMDLBEBNCGC)
	{
		return default(IBHAMOLJEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x735ED60", Offset = "0x735D360", VA = "0x18735ED60", Slot = "11")]
	public void CBGHOGADMEI(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x73607F0", Offset = "0x735EDF0", VA = "0x1873607F0", Slot = "10")]
	public void KGEJFDPKPAC(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x735FA80", Offset = "0x735E080", VA = "0x18735FA80", Slot = "20")]
	public IEnumerable<Renderer> EGCBAOEFPJF(KNLOLEOJCHI OPJBDKMKMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7360A50", Offset = "0x735F050", VA = "0x187360A50", Slot = "12")]
	public FBIOJGOPNMA MDEAEJELEND(KLFJCCFEKBH MMDLBEBNCGC)
	{
		return default(FBIOJGOPNMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7360D70", Offset = "0x735F370", VA = "0x187360D70", Slot = "14")]
	public void NNMBHKKPODP(FBIOJGOPNMA FNMFEDNONDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73600B0", Offset = "0x735E6B0", VA = "0x1873600B0", Slot = "16")]
	public Task GMMCKNIJNJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7360BF0", Offset = "0x735F1F0", VA = "0x187360BF0", Slot = "17")]
	public Task MOECCPAFMME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7360240", Offset = "0x735E840", VA = "0x187360240", Slot = "18")]
	[AsyncStateMachine(typeof(MMAKEDNDODC))]
	public Task HKLPHGFDOEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7360DE0", Offset = "0x735F3E0", VA = "0x187360DE0", Slot = "19")]
	public void PGLLIJJODNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x735F890", Offset = "0x735DE90", VA = "0x18735F890", Slot = "13")]
	public void DNHABAIBNDP(FBIOJGOPNMA FNMFEDNONDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class NGLIHPKIOJD : DNIBBDPGHFE
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct NHIOCPAFAKH : NOOKLLFGOEC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private OMKOMDIKKEA CKFPIMAMAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle KDEMNIPNNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LHDDFFBHCJI DBEKDCHDJGH;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x73640F0", Offset = "0x73626F0", VA = "0x1873640F0")]
		public NHIOCPAFAKH(OMKOMDIKKEA CKFPIMAMAKM, JobHandle KDEMNIPNNKE, LHDDFFBHCJI DBEKDCHDJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x73640C0", Offset = "0x73626C0", VA = "0x1873640C0", Slot = "4")]
		public OMKOMDIKKEA OBILMPBHNMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7364070", Offset = "0x7362670", VA = "0x187364070", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly GNPIAAGDACE GDPGJFHLHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] OKJABFGEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 HFKOABDACFP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 NPEMCOPMOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7361C90", Offset = "0x7360290", VA = "0x187361C90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 AICFLOAANKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7363E90", Offset = "0x7362490", VA = "0x187363E90", Slot = "24")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7363FC0", Offset = "0x73625C0", VA = "0x187363FC0")]
	public NGLIHPKIOJD(EFNLKGLPBNG OPJBDKMKMOF, GNPIAAGDACE MMDLBEBNCGC, bool IANIGDFGBCD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7362C40", Offset = "0x7361240", VA = "0x187362C40", Slot = "17")]
	public override bool HGHEIMJCAFL(ANOGDKLDLNH OPJBDKMKMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7362030", Offset = "0x7360630", VA = "0x187362030")]
	private IJHLPEHFBCN EIAIBNGJOBH([In] UniformTRS MPBNAGNOHIA, [In] float3 FGNPIHKJIMG)
	{
		return default(IJHLPEHFBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7361EC0", Offset = "0x73604C0", VA = "0x187361EC0", Slot = "18")]
	public override int CNBPJBALINA(FBANJHDKKJI HEPMKAJPNDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7363360", Offset = "0x7361960", VA = "0x187363360", Slot = "19")]
	public override int IIAIHJCEFGF(FBANJHDKKJI HEPMKAJPNDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7361C10", Offset = "0x7360210", VA = "0x187361C10", Slot = "20")]
	public override Bounds BFNPFABLBEC()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x73623E0", Offset = "0x73609E0", VA = "0x1873623E0", Slot = "21")]
	public override float FIIIGANAIOH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7363400", Offset = "0x7361A00", VA = "0x187363400")]
	private int ILABFIJHOCD(FBANJHDKKJI HEPMKAJPNDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7363670", Offset = "0x7361C70", VA = "0x187363670", Slot = "22")]
	public override void JHJIMEDJMNL(FBANJHDKKJI HEPMKAJPNDG, HEAFCDEBBOK MLDFLCHLFPO, int JMOEGHALLJA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7361F60", Offset = "0x7360560", VA = "0x187361F60", Slot = "23")]
	public override ANOGDKLDLNH EEBMMMJDODL()
	{
		return default(ANOGDKLDLNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7362230", Offset = "0x7360830", VA = "0x187362230", Slot = "25")]
	public override DGLDHLPMLHH EOINAEDJIJF()
	{
		return default(DGLDHLPMLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x73624D0", Offset = "0x7360AD0", VA = "0x1873624D0", Slot = "26")]
	public override NOOKLLFGOEC HAKKNOMABEO(FBANJHDKKJI HEPMKAJPNDG, JobHandle KDEMNIPNNKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface POOKBJMMCNH
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KELHJIMHFMJ(PLKHJBLGPPN GOAECDHCJMK, Renderer PGOGAFFEFPG, int KOBKNGCNKLC);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGLOPDADMFL(Renderer PGOGAFFEFPG, NKECLOJAIJH CKOHCOOHOGL, Vector3 DFKPGAPPDLE, Vector3 GBBJPJGHFJG, Vector3 JIOCCNNHCIN, float ICJACLOBGDH, float BNMDCPKMKOB, float MEMCCLMLPDM = -1f, [Optional] Color? PHHAMGLLFIF, [Optional] IReadOnlyList<Camera> NCLNGLENPHM);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPELLJOHJOB(Renderer PGOGAFFEFPG, int KOBKNGCNKLC);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NKPAEJNKCMC();

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HOGBGCGPDIE(int KCHNENGECMD, IAHLCGIKAIA GOAECDHCJMK, Renderer PGOGAFFEFPG, int KOBKNGCNKLC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PNGPDMFADCP : HCJAEIACLKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class JCEIKCLOEEL : OOOHMFBJDDP<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x735ED10", Offset = "0x735D310", VA = "0x18735ED10")]
		public JCEIKCLOEEL(string GJEDHMJMNJA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly POOKBJMMCNH EOAJAKMOCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly KCJLDABJCDL KNLICNOIPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer KNJPHNPGIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private JCEIKCLOEEL KFBPDLCFGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool LJEPKHPECMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer GGPEIFOJIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private JCEIKCLOEEL PEHIODMODEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool HLGIBEJMJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer MHOCIKDMCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private JCEIKCLOEEL IHKDMBHBFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool HHPOBMFAKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool DALIKEFGADH;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x872E80", Offset = "0x871480", VA = "0x180872E80")]
	public PNGPDMFADCP(POOKBJMMCNH LECMHIHADPE, KCJLDABJCDL KNLICNOIPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x73654F0", Offset = "0x7363AF0", VA = "0x1873654F0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7366D00", Offset = "0x7365300", VA = "0x187366D00")]
	private void OHMFODODBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x73648F0", Offset = "0x7362EF0", VA = "0x1873648F0", Slot = "4")]
	public void CIFDDOKBOEB(KNLOLEOJCHI OPJBDKMKMOF, IAHLCGIKAIA KLJCIEFJLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7364BF0", Offset = "0x73631F0", VA = "0x187364BF0", Slot = "5")]
	public void CIFDDOKBOEB(IBHAMOLJEBE ALHKJMBLFMK, IAHLCGIKAIA KLJCIEFJLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x73656A0", Offset = "0x7363CA0", VA = "0x1873656A0", Slot = "6")]
	public void FMNBIKKCMFI(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x73657D0", Offset = "0x7363DD0", VA = "0x1873657D0", Slot = "7")]
	public void JCDGLMMENHB(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x73658E0", Offset = "0x7363EE0", VA = "0x1873658E0", Slot = "24")]
	public void JOJMJMCNLIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8E72C0", Offset = "0x8E58C0", VA = "0x1808E72C0", Slot = "8")]
	public void KCFCHEGPCOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7364780", Offset = "0x7362D80", VA = "0x187364780", Slot = "9")]
	public void CHHDMILIHPA(IAHLCGIKAIA KLJCIEFJLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7365920", Offset = "0x7363F20", VA = "0x187365920", Slot = "10")]
	public void MLEFCLEKAIF(KNLOLEOJCHI OPJBDKMKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7365C00", Offset = "0x7364200", VA = "0x187365C00", Slot = "11")]
	public void MLEFCLEKAIF(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7366A10", Offset = "0x7365010", VA = "0x187366A10", Slot = "12")]
	public void OCHDOANNLJL(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7365100", Offset = "0x7363700", VA = "0x187365100", Slot = "13")]
	public void DFBJKHIGILD(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7365F50", Offset = "0x7364550", VA = "0x187365F50")]
	private void NEEKAKAKFNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x99C0B0", Offset = "0x99A6B0", VA = "0x18099C0B0", Slot = "14")]
	public void NGJIBDLDDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7364FE0", Offset = "0x73635E0", VA = "0x187364FE0", Slot = "15")]
	public void DDIKHOHJHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7365220", Offset = "0x7363820", VA = "0x187365220", Slot = "16")]
	public void DMNMILHOHLD(KNLOLEOJCHI OPJBDKMKMOF, PLKHJBLGPPN GOAECDHCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7364F40", Offset = "0x7363540", VA = "0x187364F40", Slot = "17")]
	public void COLCHGAADHO(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7365190", Offset = "0x7363790", VA = "0x187365190", Slot = "18")]
	public void DJCNENEIPNM(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xAAF940", Offset = "0xAADF40", VA = "0x180AAF940", Slot = "19")]
	public void NECFHJJCCJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7364E10", Offset = "0x7363410", VA = "0x187364E10", Slot = "20")]
	public void CILMJDMLHPN(PLKHJBLGPPN GOAECDHCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7366AB0", Offset = "0x73650B0", VA = "0x187366AB0")]
	private void OHEEGEOCAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x73661A0", Offset = "0x73647A0", VA = "0x1873661A0", Slot = "21")]
	public void NNEFBHOPHFM(KNLOLEOJCHI OPJBDKMKMOF, Vector3 DFKPGAPPDLE, Vector3 GBBJPJGHFJG, Vector3 JIOCCNNHCIN, float ICJACLOBGDH, float BNMDCPKMKOB, IReadOnlyList<Camera> HADPDJKOLDC, NKECLOJAIJH CKOHCOOHOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7366570", Offset = "0x7364B70", VA = "0x187366570", Slot = "22")]
	public void NNEFBHOPHFM(FBIOJGOPNMA FNMFEDNONDJ, Vector3 DFKPGAPPDLE, Vector3 GBBJPJGHFJG, Vector3 JIOCCNNHCIN, float ICJACLOBGDH, float BNMDCPKMKOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class DNIBBDPGHFE : JAOCEBIHNHP, IGGMCOMIHMK, OFCJLJNJKMA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly EFNLKGLPBNG DBCKFKNELBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected Bounds MKPCFIKHCFJ;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds NLLABJIDJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x10AFAF0", Offset = "0x10AE0F0", VA = "0x1810AFAF0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool AHLGMCIHCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C60", Offset = "0x9F5260", VA = "0x1809F6C60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA1E7F0", Offset = "0xA1CDF0", VA = "0x180A1E7F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 AICFLOAANKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IKIKHGHIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8F3C30", Offset = "0x8F2230", VA = "0x1808F3C30", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BIMFFKCCPBN LBOGNBOFEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x868CD0", Offset = "0x8672D0", VA = "0x180868CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool LAPNDKJDPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x147E970", Offset = "0x147CF70", VA = "0x18147E970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	protected DNIBBDPGHFE(EFNLKGLPBNG OPJBDKMKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x73576E0", Offset = "0x7355CE0", VA = "0x1873576E0", Slot = "16")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "17")]
	public virtual bool HGHEIMJCAFL(ANOGDKLDLNH OPJBDKMKMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int CNBPJBALINA(FBANJHDKKJI HEPMKAJPNDG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int IIAIHJCEFGF(FBANJHDKKJI HEPMKAJPNDG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract Bounds BFNPFABLBEC();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract float FIIIGANAIOH();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract void JHJIMEDJMNL(FBANJHDKKJI HEPMKAJPNDG, HEAFCDEBBOK MLDFLCHLFPO, int JMOEGHALLJA = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract ANOGDKLDLNH EEBMMMJDODL();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x73576B0", Offset = "0x7355CB0", VA = "0x1873576B0", Slot = "12")]
	public Hash128 BDMFLIFKCGI(int HEPMKAJPNDG)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract DGLDHLPMLHH EOINAEDJIJF();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract NOOKLLFGOEC HAKKNOMABEO(FBANJHDKKJI HEPMKAJPNDG, JobHandle KDEMNIPNNKE);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7357810", Offset = "0x7355E10", VA = "0x187357810", Slot = "11")]
	public NOOKLLFGOEC IOLKHHHPIKD(int HEPMKAJPNDG)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7366F50", Offset = "0x7365550", VA = "0x187366F50")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CNDLNLGEIOL
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IHMIKKAAFOD : IEnumerable<HKAPPCKHMBE>, IEnumerable, IEnumerator<HKAPPCKHMBE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private HKAPPCKHMBE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private HKAPPCKHMBE System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8BEBB0", Offset = "0x8BD1B0", VA = "0x1808BEBB0")]
		[DebuggerHidden]
		public IHMIKKAAFOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x735D6C0", Offset = "0x735BCC0", VA = "0x18735D6C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x735D830", Offset = "0x735BE30", VA = "0x18735D830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x735D790", Offset = "0x735BD90", VA = "0x18735D790", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HKAPPCKHMBE> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x735D790", Offset = "0x735BD90", VA = "0x18735D790", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static HKAPPCKHMBE[][] ENIEODEKLND;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static EJCCJHONJOD JPCKKOLLELN;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig AKPPGCICGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7356440", Offset = "0x7354A40", VA = "0x187356440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader BDNCOEGEBED
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7355F80", Offset = "0x7354580", VA = "0x187355F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer GCKALHKOIDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x73568E0", Offset = "0x7354EE0", VA = "0x1873568E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7356640", Offset = "0x7354C40", VA = "0x187356640")]
	public static Mesh DPPJKJDMJPO(KBIAPBKPMCM FIGFJHMAAGA, int HEPMKAJPNDG = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7356470", Offset = "0x7354A70", VA = "0x187356470")]
	public static int BOAEPKAJDHI(KBIAPBKPMCM FIGFJHMAAGA, int HEPMKAJPNDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x73569B0", Offset = "0x7354FB0", VA = "0x1873569B0")]
	public static EJCCJHONJOD KLGHOMAFIPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7356950", Offset = "0x7354F50", VA = "0x187356950")]
	[IteratorStateMachine(typeof(IHMIKKAAFOD))]
	private static IEnumerable<HKAPPCKHMBE> KLEKHHNCINA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7356B00", Offset = "0x7355100", VA = "0x187356B00")]
	public static HKAPPCKHMBE KMEMKIPNACB(KBIAPBKPMCM FIGFJHMAAGA, int HEPMKAJPNDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x73568C0", Offset = "0x7354EC0", VA = "0x1873568C0")]
	public static bool EOEEACIKMHM(this KBIAPBKPMCM FIGFJHMAAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7356480", Offset = "0x7354A80", VA = "0x187356480")]
	public static void DEJAPMJNJMK(KBIAPBKPMCM FIGFJHMAAGA, float3 DIPNIBMMODM, [Out] NMOCELICNOP DICHFGAOFND, [Out] float3 DGGIBEGEDBD, [Out] float KALLMBGLALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7355FF0", Offset = "0x73545F0", VA = "0x187355FF0")]
	public static void AJGNIPOFAIN(Vector3 DIPNIBMMODM, KBIAPBKPMCM FIGFJHMAAGA, [Out] Vector3 DGGIBEGEDBD, [Out] float KALLMBGLALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7356630", Offset = "0x7354C30", VA = "0x187356630")]
	[AKHHACKKOPD(AIIPENBHOND.ExitingPlayMode, 0)]
	[OAHKODIBNHK(0)]
	private static void DPALNPFJNHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x73566F0", Offset = "0x7354CF0", VA = "0x1873566F0")]
	[AKHHACKKOPD(AIIPENBHOND.ExitingPlayMode, 0)]
	[OAHKODIBNHK(0)]
	private static void ELPEAMCDMCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class HMJJGJMCLAK : ABMGIHGABKH, IDisposable, KCJLDABJCDL
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly PAFELJNLCII<KNLOLEOJCHI, EFNLKGLPBNG> IBJDGNAKNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly PAFELJNLCII<IBHAMOLJEBE, DNIBBDPGHFE> MFLMPDLIMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly PAFELJNLCII<FBIOJGOPNMA, IJIJAIBOHGB> NMOOIDHBFMI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EFNLKGLPBNG CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x735D0D0", Offset = "0x735B6D0", VA = "0x18735D0D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public DNIBBDPGHFE CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x735D070", Offset = "0x735B670", VA = "0x18735D070", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IJIJAIBOHGB CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x735D010", Offset = "0x735B610", VA = "0x18735D010", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool INEHBGLMMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA5760", Offset = "0xAA3D60", VA = "0x180AA5760", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xB9CB80", Offset = "0xB9B180", VA = "0x180B9CB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x735D2D0", Offset = "0x735B8D0", VA = "0x18735D2D0")]
	public HMJJGJMCLAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x735CAD0", Offset = "0x735B0D0", VA = "0x18735CAD0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x735C9D0", Offset = "0x735AFD0", VA = "0x18735C9D0", Slot = "4")]
	public KNLOLEOJCHI CHCNLPLPKFI(NBCFOMAMNIJ MMDLBEBNCGC)
	{
		return default(KNLOLEOJCHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x735C9D0", Offset = "0x735AFD0", VA = "0x18735C9D0", Slot = "5")]
	public KNLOLEOJCHI CHCNLPLPKFI(NBCFOMAMNIJ MMDLBEBNCGC, bool HFJLIEOFLEI)
	{
		return default(KNLOLEOJCHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x735CBD0", Offset = "0x735B1D0", VA = "0x18735CBD0", Slot = "6")]
	public void FINNPDBADIG(KNLOLEOJCHI OPJBDKMKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x735CC30", Offset = "0x735B230", VA = "0x18735CC30", Slot = "7")]
	public void GIKHBDGNGEJ(KNLOLEOJCHI OPJBDKMKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x735CDF0", Offset = "0x735B3F0", VA = "0x18735CDF0", Slot = "8")]
	public IBHAMOLJEBE HMFBNACJIEC(KNLOLEOJCHI OPJBDKMKMOF, GNPIAAGDACE MMDLBEBNCGC)
	{
		return default(IBHAMOLJEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x735C890", Offset = "0x735AE90", VA = "0x18735C890", Slot = "9")]
	public IBHAMOLJEBE CEBKMEAPKNP(KNLOLEOJCHI OPJBDKMKMOF, JBDKBGHIKJK MMDLBEBNCGC)
	{
		return default(IBHAMOLJEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x735C800", Offset = "0x735AE00", VA = "0x18735C800", Slot = "11")]
	public void CBGHOGADMEI(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x735CF30", Offset = "0x735B530", VA = "0x18735CF30", Slot = "10")]
	public void KGEJFDPKPAC(IBHAMOLJEBE ALHKJMBLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x735CB60", Offset = "0x735B160", VA = "0x18735CB60", Slot = "20")]
	public IEnumerable<Renderer> EGCBAOEFPJF(KNLOLEOJCHI OPJBDKMKMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x735CF90", Offset = "0x735B590", VA = "0x18735CF90", Slot = "12")]
	public FBIOJGOPNMA MDEAEJELEND(KLFJCCFEKBH MMDLBEBNCGC)
	{
		return default(FBIOJGOPNMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x735D1D0", Offset = "0x735B7D0", VA = "0x18735D1D0", Slot = "14")]
	public void NNMBHKKPODP(FBIOJGOPNMA FNMFEDNONDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x735CCB0", Offset = "0x735B2B0", VA = "0x18735CCB0", Slot = "16")]
	public Task GMMCKNIJNJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x735D130", Offset = "0x735B730", VA = "0x18735D130", Slot = "17")]
	public Task MOECCPAFMME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x735CD50", Offset = "0x735B350", VA = "0x18735CD50", Slot = "18")]
	public Task HKLPHGFDOEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1EFEC20", Offset = "0x1EFD220", VA = "0x181EFEC20", Slot = "19")]
	public void PGLLIJJODNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x735CA70", Offset = "0x735B070", VA = "0x18735CA70", Slot = "13")]
	public void DNHABAIBNDP(FBIOJGOPNMA FNMFEDNONDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FPAGLHCCDFP
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool JLONODLEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material LFHDEOPACHB();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material DACJGEPOLPH();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material AGLFONOCHPC();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FPPJNGEOILP(LKAPLOLHAAI NBBKLPGFGFD);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BLEKMKCLIIA(EEFKMEOHOJA CDKNEIJCBNB);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CNIMHFOJFKC(GameObject NJKKPOFFNNJ);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HCIEAOEEGAK(GameObject NJKKPOFFNNJ, bool ELNAMFFPEDP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CODEAOAJMCP
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static FPAGLHCCDFP AKLCDEBLEOF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool JLONODLEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7356E20", Offset = "0x7355420", VA = "0x187356E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7357250", Offset = "0x7355850", VA = "0x187357250")]
	public static void PKBJAEJMCAL(FPAGLHCCDFP IGBPINLBBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x73571F0", Offset = "0x73557F0", VA = "0x1873571F0")]
	public static Material LFHDEOPACHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7357030", Offset = "0x7355630", VA = "0x187357030")]
	public static Material DACJGEPOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7356E80", Offset = "0x7355480", VA = "0x187356E80")]
	public static Material AGLFONOCHPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7357090", Offset = "0x7355690", VA = "0x187357090")]
	public static int FPPJNGEOILP(LKAPLOLHAAI NBBKLPGFGFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7356EE0", Offset = "0x73554E0", VA = "0x187356EE0")]
	public static int BLEKMKCLIIA(EEFKMEOHOJA CDKNEIJCBNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7356F50", Offset = "0x7355550", VA = "0x187356F50")]
	public static void CNIMHFOJFKC(GameObject NJKKPOFFNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7357100", Offset = "0x7355700", VA = "0x187357100")]
	public static void HCIEAOEEGAK(GameObject NJKKPOFFNNJ, bool ELNAMFFPEDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IJIJAIBOHGB : DLNMIJBDDHF
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DFBEMOBCJLA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IJIJAIBOHGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8BEBB0", Offset = "0x8BD1B0", VA = "0x1808BEBB0")]
		[DebuggerHidden]
		public DFBEMOBCJLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7357620", Offset = "0x7355C20", VA = "0x187357620", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7357300", Offset = "0x7355900", VA = "0x187357300", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x73572B0", Offset = "0x73558B0", VA = "0x1873572B0")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x73575D0", Offset = "0x7355BD0", VA = "0x1873575D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7357520", Offset = "0x7355B20", VA = "0x187357520", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7357520", Offset = "0x7355B20", VA = "0x187357520", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly KLFJCCFEKBH IFMMOGEPNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly KCJLDABJCDL KNLICNOIPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private FIIPEIIOMED JPKABPCGLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<GOPFBDMAOLI> ENLPHMPECBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<GOPFBDMAOLI> CCLDMCBEMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject FHGAFPNCFEI;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x735D880", Offset = "0x735BE80", VA = "0x18735D880")]
	public static IJIJAIBOHGB DDEEEFCNPGL(KLFJCCFEKBH MMDLBEBNCGC, KCJLDABJCDL KNLICNOIPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x735EC30", Offset = "0x735D230", VA = "0x18735EC30")]
	private IJIJAIBOHGB(KLFJCCFEKBH MMDLBEBNCGC, KCJLDABJCDL KNLICNOIPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x735D9D0", Offset = "0x735BFD0", VA = "0x18735D9D0")]
	public void EKANILNIIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x735EBB0", Offset = "0x735D1B0", VA = "0x18735EBB0")]
	[IteratorStateMachine(typeof(DFBEMOBCJLA))]
	public IEnumerable<Renderer> PNPGGGAHFIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x735E0E0", Offset = "0x735C6E0", VA = "0x18735E0E0", Slot = "4")]
	public void OPIEDINIMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x735E0B0", Offset = "0x735C6B0", VA = "0x18735E0B0")]
	private void LPAGMCLPLNL(Vector3 IMKGEEMJCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x735DE60", Offset = "0x735C460", VA = "0x18735DE60")]
	public void JPIODFAGAAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GOPFBDMAOLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct PFFEFKMPLIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public HEAFCDEBBOK MODNJMIFDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public ANOGDKLDLNH BLJKIEGACIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int FPMNJICDMKM;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LNKOCJKODLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public GOPFBDMAOLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FBANJHDKKJI lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<PFFEFKMPLIJ> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public OMKOMDIKKEA combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public LNKOCJKODLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x73614C0", Offset = "0x735FAC0", VA = "0x1873614C0")]
		internal JobHandle HJPMHDMMJFA()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7361320", Offset = "0x735F920", VA = "0x187361320")]
		internal void DHFPJFNBGCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7361350", Offset = "0x735F950", VA = "0x187361350")]
		internal void HIIMNLLEHJP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] GJLOKNEACCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private LIHEKKALPMD OEIEFMAIFIJ;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 ENCBJEIDAHC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh LOGLHJINEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int DJEJONINPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x86C7E0", Offset = "0x86ADE0", VA = "0x18086C7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x86E8E0", Offset = "0x86CEE0", VA = "0x18086E8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x735BCD0", Offset = "0x735A2D0", VA = "0x18735BCD0")]
	public void JKPLAJMDDHM(List<ANOGDKLDLNH> BPJCFKLCOAI, Matrix4x4[] KOGNHAMEDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x735B4C0", Offset = "0x7359AC0", VA = "0x18735B4C0")]
	public static List<GOPFBDMAOLI> BBHPEKFPBBP(List<EFNLKGLPBNG> KKCEGHAEGCB, FBANJHDKKJI HEPMKAJPNDG, Bounds MCJIPIBOJBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x735BEC0", Offset = "0x735A4C0", VA = "0x18735BEC0")]
	private JobHandle LKENELEKCGL(OMKOMDIKKEA DILNHMMNHGC, int KPGHDFKJEPO, int IEKNLKKGAIM, FBANJHDKKJI HEPMKAJPNDG, List<PFFEFKMPLIJ> GOKDPCFCBKE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x735BBF0", Offset = "0x735A1F0", VA = "0x18735BBF0")]
	private void FDFMHOANPGF(List<PFFEFKMPLIJ> GOKDPCFCBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x735C3D0", Offset = "0x735A9D0", VA = "0x18735C3D0")]
	private GOPFBDMAOLI(List<PFFEFKMPLIJ> GOKDPCFCBKE, int KPGHDFKJEPO, int IEKNLKKGAIM, FBANJHDKKJI HEPMKAJPNDG, Bounds MCJIPIBOJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x735BB50", Offset = "0x735A150", VA = "0x18735BB50", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private MaterialPropertyBlock OGCPFNAPOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private GOPFBDMAOLI CKFPIMAMAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<ANOGDKLDLNH> BOJAJHMAICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture PNINJKEDJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer FAGEJIJPNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader KGMLEBIIPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] PLPICNMJKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int KPLMFMDLJIK;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer OFJHBGOMIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int CIONIJKFHBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7367CB0", Offset = "0x73662B0", VA = "0x187367CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7366FB0", Offset = "0x73655B0", VA = "0x187366FB0")]
		public static List<SkinnedShapeRenderer> Create(GameObject OPJBDKMKMOF, List<GOPFBDMAOLI> INKJCILNAFO, List<ANOGDKLDLNH> BOJAJHMAICH, Material OLKLLNJBJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7367260", Offset = "0x7365860", VA = "0x187367260")]
		public void Init(GOPFBDMAOLI CKFPIMAMAKM, List<ANOGDKLDLNH> BOJAJHMAICH, Material OLKLLNJBJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7367C10", Offset = "0x7366210", VA = "0x187367C10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7367B70", Offset = "0x7366170", VA = "0x187367B70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7367B30", Offset = "0x7366130", VA = "0x187367B30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7367A70", Offset = "0x7366070", VA = "0x187367A70")]
		private void MOKEDAMBAPC(ScriptableRenderContext CAMDIODFJJE, Camera[] KOBIICIIINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7367700", Offset = "0x7365D00", VA = "0x187367700")]
		private void JKPLAJMDDHM(CommandBuffer MGGOHHEBAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
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
