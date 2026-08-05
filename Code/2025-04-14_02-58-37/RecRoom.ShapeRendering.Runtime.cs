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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x839CC60", Offset = "0x839B660", VA = "0x18839CC60", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x839F740", Offset = "0x839E140", VA = "0x18839F740", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EJDJLHLMKLF : MFDJCIGJGOK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte AHKCONPFEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] POEDFLGLPKI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MCANJEJNOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB86090", Offset = "0xB84A90", VA = "0x180B86090", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBFFBB0", Offset = "0xBFE5B0", VA = "0x180BFFBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GFPPDMMJCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC976B0", Offset = "0xC960B0", VA = "0x180C976B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE7FEF0", Offset = "0xE7E8F0", VA = "0x180E7FEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float MJKHFPFLIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE86E80", Offset = "0xE85880", VA = "0x180E86E80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x11FB6A0", Offset = "0x11FA0A0", VA = "0x1811FB6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float ECMDNAOIFIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBBC040", Offset = "0xBBAA40", VA = "0x180BBC040", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBBC050", Offset = "0xBBAA50", VA = "0x180BBC050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> GJGOCMNHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x838FA80", Offset = "0x838E480", VA = "0x18838FA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> FHEFDKIJCCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x838FCF0", Offset = "0x838E6F0", VA = "0x18838FCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject LKAEGJLGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9B5530", Offset = "0x9B3F30", VA = "0x1809B5530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte FACEABAGJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x838F890", Offset = "0x838E290", VA = "0x18838F890", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x838FE70", Offset = "0x838E870", VA = "0x18838FE70")]
	public EJDJLHLMKLF(List<NEEOFFFMBLA> KMHGAENLKJA, List<NEEOFFFMBLA> BONEKHLIALA, List<FJCDPKDIACD> JOOOFLHEIHP, Material GMIALIBEKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x838FBD0", Offset = "0x838E5D0", VA = "0x18838FBD0")]
	private int GKDOONDAAJM(List<NEEOFFFMBLA> IDAOLDLBKHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x838F8E0", Offset = "0x838E2E0", VA = "0x18838F8E0")]
	private void AGPCFKDEEMP(int BPFMCALHNLD, bool BAPBHDNFAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x838FD20", Offset = "0x838E720", VA = "0x18838FD20")]
	public void LALMDDKHPNJ(Vector3 EHPGHOFFHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x838FAD0", Offset = "0x838E4D0", VA = "0x18838FAD0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x838FA40", Offset = "0x838E440", VA = "0x18838FA40")]
	public void CCPGKKAFIAD(Transform BAEMLIKDHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JIPJBIMMBHB : JOCEHKMFLHH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class JOLMIACHIFA : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JIPJBIMMBHB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public JOLMIACHIFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8398550", Offset = "0x8396F50", VA = "0x188398550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8397EF0", Offset = "0x83968F0", VA = "0x188397EF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8397EA0", Offset = "0x83968A0", VA = "0x188397EA0")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8397E50", Offset = "0x8396850", VA = "0x188397E50")]
		private void EKCCALBOGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8398400", Offset = "0x8396E00", VA = "0x188398400")]
		private void OAKMKHAAOGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8398500", Offset = "0x8396F00", VA = "0x188398500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8398450", Offset = "0x8396E50", VA = "0x188398450", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8398450", Offset = "0x8396E50", VA = "0x188398450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GLLFABCLNKG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public JIPJBIMMBHB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public GLLFABCLNKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8392A10", Offset = "0x8391410", VA = "0x188392A10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83925A0", Offset = "0x8390FA0", VA = "0x1883925A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8392550", Offset = "0x8390F50", VA = "0x188392550")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8392500", Offset = "0x8390F00", VA = "0x188392500")]
		private void EKCCALBOGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83929C0", Offset = "0x83913C0", VA = "0x1883929C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8392910", Offset = "0x8391310", VA = "0x188392910", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8392910", Offset = "0x8391310", VA = "0x188392910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CMKEMJONGPA DBAGDLKIHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<CAIBMKBGKCB> IIJOPECEGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> BNBDFJCPNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer GKODEJCKHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool PPBJKPBPCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool NNCEKAKALLN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<DGKAEGLHOAA> AKBMAJBEGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JGLLCHJAHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8397AB0", Offset = "0x83964B0", VA = "0x188397AB0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FJCDPKDIACD IGGGGNAGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83968D0", Offset = "0x83952D0", VA = "0x1883968D0", Slot = "8")]
		get
		{
			return default(FJCDPKDIACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> LHKJEKPLBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDB0", Offset = "0x9AD7B0", VA = "0x1809AEDB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8396990", Offset = "0x8395390", VA = "0x188396990")]
	private bool FEEAEFBOOAP(CAIBMKBGKCB GMLPEGDALHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8396640", Offset = "0x8395040", VA = "0x188396640")]
	private static bool DJIAIGDNHLA(CAIBMKBGKCB GMLPEGDALHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8397D60", Offset = "0x8396760", VA = "0x188397D60")]
	public JIPJBIMMBHB(CMKEMJONGPA DFPGGEDGGGN, bool KBPNEDEKOJD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8396660", Offset = "0x8395060", VA = "0x188396660", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8396BC0", Offset = "0x83955C0", VA = "0x188396BC0")]
	public void HEHCILJMFIP(CAIBMKBGKCB GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8396460", Offset = "0x8394E60", VA = "0x188396460")]
	public void CBCJJMKDJJC(CAIBMKBGKCB GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83975B0", Offset = "0x8395FB0", VA = "0x1883975B0", Slot = "4")]
	public void MPAKAOAIOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8396D90", Offset = "0x8395790", VA = "0x188396D90")]
	public void IPDLKHCHONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8397BA0", Offset = "0x83965A0", VA = "0x188397BA0")]
	private void PNHNPFOGMPN(List<CAIBMKBGKCB> IIJOPECEGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x83904C0", Offset = "0x838EEC0", VA = "0x1883904C0")]
	private static Material KPLHLHGLJGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8397AF0", Offset = "0x83964F0", VA = "0x188397AF0")]
	private void PNHNPFOGMPN(CAIBMKBGKCB GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x83969B0", Offset = "0x83953B0", VA = "0x1883969B0")]
	private void FHOCGIAHGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8397000", Offset = "0x8395A00", VA = "0x188397000")]
	public void LBOGJKFKJKL(bool ADGGJPHFDBG, bool DDDDNAFDAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8396A80", Offset = "0x8395480", VA = "0x188396A80")]
	protected void GDPLEGIHAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8396850", Offset = "0x8395250", VA = "0x188396850")]
	public void EFCNDMKOKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8396B40", Offset = "0x8395540", VA = "0x188396B40")]
	[IteratorStateMachine(typeof(JOLMIACHIFA))]
	public IEnumerable<Renderer> GKEHMMMIADD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x83965C0", Offset = "0x8394FC0", VA = "0x1883965C0")]
	[IteratorStateMachine(typeof(GLLFABCLNKG))]
	public IEnumerable<Renderer> CIOHMAMPEAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class LDKOFCBDHFI : CAIBMKBGKCB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct ONMFICHBFBD : KJICOBOBPDB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IMPFNPPINEK LKDNKMEFADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle GDFPJOCLDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MPBHAGJOADL KCGCOBNFAGK;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x839E250", Offset = "0x839CC50", VA = "0x18839E250")]
		public ONMFICHBFBD(IMPFNPPINEK LKDNKMEFADL, JobHandle GDFPJOCLDKE, MPBHAGJOADL KCGCOBNFAGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x839E1D0", Offset = "0x839CBD0", VA = "0x18839E1D0", Slot = "4")]
		public IMPFNPPINEK CALODJBLNBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x839E200", Offset = "0x839CC00", VA = "0x18839E200", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly KOBGOEHEJAM EIGIKMPAPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float GMPKNONONMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 MHCBDKACNNG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 LOGFGJJONIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83997A0", Offset = "0x83981A0", VA = "0x1883997A0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x839A230", Offset = "0x8398C30", VA = "0x18839A230")]
	public LDKOFCBDHFI(JIPJBIMMBHB MHHKOMDGDID, KOBGOEHEJAM DFPGGEDGGGN, bool KBPNEDEKOJD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "18")]
	public override bool LOCCIPCILJC(FJCDPKDIACD MHHKOMDGDID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8398FC0", Offset = "0x83979C0", VA = "0x188398FC0", Slot = "19")]
	public override int GKDOONDAAJM(LPMFIJMHNCN BJJGMOJDONE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8399190", Offset = "0x8397B90", VA = "0x188399190", Slot = "20")]
	public override int KDELMKPBFIC(LPMFIJMHNCN BJJGMOJDONE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8399360", Offset = "0x8397D60", VA = "0x188399360", Slot = "21")]
	public override PGANDJPMLKL KGMPNMKEPGA()
	{
		return default(PGANDJPMLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xB9B390", Offset = "0xB99D90", VA = "0x180B9B390", Slot = "22")]
	public override float PMBDHEDMOLB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8398900", Offset = "0x8397300", VA = "0x188398900", Slot = "23")]
	public override void EFJJEHHDKHJ(LPMFIJMHNCN BJJGMOJDONE, PFEPNJHHLEN EDMIIEPJACG, int LHEBAIGEAIC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8398EF0", Offset = "0x83978F0", VA = "0x188398EF0", Slot = "24")]
	public override FJCDPKDIACD GFIDGEKBDEF()
	{
		return default(FJCDPKDIACD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x839A080", Offset = "0x8398A80", VA = "0x18839A080", Slot = "26")]
	public override FIDPILACLGN PCAENAFPFBK()
	{
		return default(FIDPILACLGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83998C0", Offset = "0x83982C0", VA = "0x1883998C0", Slot = "27")]
	public override KJICOBOBPDB OBMFFCLOJLN(LPMFIJMHNCN BJJGMOJDONE, JobHandle GDFPJOCLDKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface CLAMBNDFMBB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JIPJBIMMBHB NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CAIBMKBGKCB NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IKNJFGABIBI NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class BFHLCBPPDHL : AMDEOGDAEEI, IDisposable, CLAMBNDFMBB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CPFLLEBHMGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public BFHLCBPPDHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x838E450", Offset = "0x838CE50", VA = "0x18838E450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x838E9B0", Offset = "0x838D3B0", VA = "0x18838E9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MLMAEEAINPM<JBGLFFCNIBO, JIPJBIMMBHB> FBJEDPNIPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly MLMAEEAINPM<LIINPMBBOMO, CAIBMKBGKCB> IIJOPECEGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly MLMAEEAINPM<EEOAKPIHAKE, IKNJFGABIBI> GCLECFCECCO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public JIPJBIMMBHB NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x838C5C0", Offset = "0x838AFC0", VA = "0x18838C5C0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public CAIBMKBGKCB NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x838C560", Offset = "0x838AF60", VA = "0x18838C560", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IKNJFGABIBI NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x838C620", Offset = "0x838B020", VA = "0x18838C620", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool BPLPCAPNGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD34A50", Offset = "0xD33450", VA = "0x180D34A50", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA31440", Offset = "0xA2FE40", VA = "0x180A31440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x838DBE0", Offset = "0x838C5E0", VA = "0x18838DBE0")]
	public BFHLCBPPDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x838C000", Offset = "0x838AA00", VA = "0x18838C000", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x838C680", Offset = "0x838B080", VA = "0x18838C680", Slot = "4")]
	public JBGLFFCNIBO JACMAAFFMME(CMKEMJONGPA DFPGGEDGGGN)
	{
		return default(JBGLFFCNIBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x838C690", Offset = "0x838B090", VA = "0x18838C690", Slot = "5")]
	public JBGLFFCNIBO JACMAAFFMME(CMKEMJONGPA DFPGGEDGGGN, bool KBPNEDEKOJD)
	{
		return default(JBGLFFCNIBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x838CD80", Offset = "0x838B780", VA = "0x18838CD80", Slot = "6")]
	public void KOIOGDKMADA(JBGLFFCNIBO MHHKOMDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x838C900", Offset = "0x838B300", VA = "0x18838C900", Slot = "7")]
	public void JNMKMCANBKC(JBGLFFCNIBO MHHKOMDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x838D500", Offset = "0x838BF00", VA = "0x18838D500", Slot = "8")]
	public LIINPMBBOMO NDBLDGLEHAH(JBGLFFCNIBO MHHKOMDGDID, HFEEEJKKJME DFPGGEDGGGN)
	{
		return default(LIINPMBBOMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x838CFD0", Offset = "0x838B9D0", VA = "0x18838CFD0", Slot = "9")]
	public LIINPMBBOMO KOLNIOBFCAB(JBGLFFCNIBO MHHKOMDGDID, KOBGOEHEJAM DFPGGEDGGGN)
	{
		return default(LIINPMBBOMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x838C1C0", Offset = "0x838ABC0", VA = "0x18838C1C0", Slot = "11")]
	public void ELAMMLBBDKO(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x838BC00", Offset = "0x838A600", VA = "0x18838BC00", Slot = "10")]
	public void BFGFFCPNBOM(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x838CD10", Offset = "0x838B710", VA = "0x18838CD10", Slot = "20")]
	public IEnumerable<Renderer> KKEBEDOFEPP(JBGLFFCNIBO MHHKOMDGDID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x838BA90", Offset = "0x838A490", VA = "0x18838BA90", Slot = "12")]
	public EEOAKPIHAKE ACJOPGMPCNO(IEKLAJFHIFL DFPGGEDGGGN)
	{
		return default(EEOAKPIHAKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x838D490", Offset = "0x838BE90", VA = "0x18838D490", Slot = "14")]
	public void LNHPBAOADFO(EEOAKPIHAKE KFPDJNOIECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x838DA20", Offset = "0x838C420", VA = "0x18838DA20", Slot = "16")]
	public Task OIJHANHOGPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x838BE50", Offset = "0x838A850", VA = "0x18838BE50", Slot = "17")]
	public Task DMDIGDMJNNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x838CC40", Offset = "0x838B640", VA = "0x18838CC40", Slot = "18")]
	[AsyncStateMachine(typeof(CPFLLEBHMGC))]
	public Task KALKJBEFJHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x838BB10", Offset = "0x838A510", VA = "0x18838BB10", Slot = "19")]
	public void AFGIFECOPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x838D9C0", Offset = "0x838C3C0", VA = "0x18838D9C0", Slot = "13")]
	public void NMDBCKLMHCF(EEOAKPIHAKE KFPDJNOIECE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class IHDOOHLNCMC : CAIBMKBGKCB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct OCJMKJGABFF : KJICOBOBPDB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private IMPFNPPINEK LKDNKMEFADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> INBMDHEPEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle GDFPJOCLDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CHHLAPBEABA KCGCOBNFAGK;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x839E170", Offset = "0x839CB70", VA = "0x18839E170")]
		public OCJMKJGABFF(IMPFNPPINEK LKDNKMEFADL, NativeArray<int> INBMDHEPEAH, JobHandle GDFPJOCLDKE, CHHLAPBEABA KCGCOBNFAGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x839E070", Offset = "0x839CA70", VA = "0x18839E070", Slot = "4")]
		public IMPFNPPINEK CALODJBLNBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x839E0D0", Offset = "0x839CAD0", VA = "0x18839E0D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly HFEEEJKKJME LPLAAGCJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] HFFDNEBOHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 MHCBDKACNNG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 DMGCCHHCEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8393ED0", Offset = "0x83928D0", VA = "0x188393ED0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 LOGFGJJONIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8394100", Offset = "0x8392B00", VA = "0x188394100", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8394F60", Offset = "0x8393960", VA = "0x188394F60")]
	public IHDOOHLNCMC(JIPJBIMMBHB MHHKOMDGDID, HFEEEJKKJME DFPGGEDGGGN, bool EIKKNFPDJLC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8394220", Offset = "0x8392C20", VA = "0x188394220", Slot = "18")]
	public override bool LOCCIPCILJC(FJCDPKDIACD MHHKOMDGDID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8393E90", Offset = "0x8392890", VA = "0x188393E90", Slot = "21")]
	public override PGANDJPMLKL KGMPNMKEPGA()
	{
		return default(PGANDJPMLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8393830", Offset = "0x8392230", VA = "0x188393830")]
	private PGANDJPMLKL KGMPNMKEPGA(FJCDPKDIACD MHHKOMDGDID)
	{
		return default(PGANDJPMLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8394AC0", Offset = "0x83934C0", VA = "0x188394AC0")]
	private ABGEAFCLADP OEFBKLNKKJC([In] UniformTRS DJEDBPCNGGB, [In] float3 FCPNAKMBNJM)
	{
		return default(ABGEAFCLADP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8393450", Offset = "0x8391E50", VA = "0x188393450", Slot = "19")]
	public override int GKDOONDAAJM(LPMFIJMHNCN BJJGMOJDONE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8393780", Offset = "0x8392180", VA = "0x188393780", Slot = "20")]
	public override int KDELMKPBFIC(LPMFIJMHNCN BJJGMOJDONE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8394E70", Offset = "0x8393870", VA = "0x188394E70", Slot = "22")]
	public override float PMBDHEDMOLB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8393500", Offset = "0x8391F00", VA = "0x188393500")]
	private int JLBEAPNKFMD(LPMFIJMHNCN BJJGMOJDONE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8392B40", Offset = "0x8391540", VA = "0x188392B40", Slot = "23")]
	public override void EFJJEHHDKHJ(LPMFIJMHNCN BJJGMOJDONE, PFEPNJHHLEN EDMIIEPJACG, int LHEBAIGEAIC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8393380", Offset = "0x8391D80", VA = "0x188393380", Slot = "24")]
	public override FJCDPKDIACD GFIDGEKBDEF()
	{
		return default(FJCDPKDIACD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8394CC0", Offset = "0x83936C0", VA = "0x188394CC0", Slot = "26")]
	public override FIDPILACLGN PCAENAFPFBK()
	{
		return default(FIDPILACLGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x83942F0", Offset = "0x8392CF0", VA = "0x1883942F0", Slot = "27")]
	public override KJICOBOBPDB OBMFFCLOJLN(LPMFIJMHNCN BJJGMOJDONE, JobHandle GDFPJOCLDKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HFNMBIHKOKC
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAODENFIAEA(LCGNEMGJNFI OHCGINPDMEI, Renderer IBNNGOPMLGG, int HBBADHGHIAP);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLGLIAAHEGM(Renderer IBNNGOPMLGG, IAEGPOMMOKC GBNJCPHDBMP, Vector3 ABFAPGIDLBA, Vector3 GPFFOPCNLDB, Vector3 PFFAGBPBCDM, float LCJCFGNBNHB, float CIBCDKJPIEF, float OEBLDEPNCEL = -1f, [Optional] Color? IFFOAMBAJEI, [Optional] IReadOnlyList<Camera> LMLCOENHKBB);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JENINICIOIA(Renderer IBNNGOPMLGG, int HBBADHGHIAP);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HLGFLOJLJCC();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DMCKJHCCCGF(int NKMCNFMPDFG, MPMOFPPLHCF OHCGINPDMEI, Renderer IBNNGOPMLGG, int HBBADHGHIAP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LGOFFNKFNFH : HBJPHKMFDDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class OAJDGHNFEPE : GLDCGDCMCON<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x839E020", Offset = "0x839CA20", VA = "0x18839E020")]
		public OAJDGHNFEPE(string EMLAIMJKHOE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HFNMBIHKOKC PJGHKMNEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CLAMBNDFMBB EOIGIGKJKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer HNFHKIFPKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private OAJDGHNFEPE AMDCPEHGADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool GKPGBCJFNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer FOCONEBEMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private OAJDGHNFEPE PCKHCFKDDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool OFANKMCHNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer KIDIDKCPFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private OAJDGHNFEPE CLJIAOMKONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool NCHNAOEBBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool FIMHNIKAAJI;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BA330", VA = "0x1809BB930")]
	public LGOFFNKFNFH(HFNMBIHKOKC CDCBPHLPNJO, CLAMBNDFMBB EOIGIGKJKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x839AD60", Offset = "0x8399760", VA = "0x18839AD60", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x839B070", Offset = "0x8399A70", VA = "0x18839B070")]
	private void HAOBCAAFEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x839C4C0", Offset = "0x839AEC0", VA = "0x18839C4C0", Slot = "4")]
	public void MKJIGIDGDCL(JBGLFFCNIBO MHHKOMDGDID, MPMOFPPLHCF FGIHDPOHIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x839C2A0", Offset = "0x839ACA0", VA = "0x18839C2A0", Slot = "5")]
	public void MKJIGIDGDCL(LIINPMBBOMO GMLPEGDALHF, MPMOFPPLHCF FGIHDPOHIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x839AF10", Offset = "0x8399910", VA = "0x18839AF10", Slot = "6")]
	public void FGMPBMEMCOB(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x839C7D0", Offset = "0x839B1D0", VA = "0x18839C7D0", Slot = "7")]
	public void MMNHANOIDFN(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x839BEB0", Offset = "0x839A8B0", VA = "0x18839BEB0", Slot = "24")]
	public void KMJFOBIEOCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xFDF080", Offset = "0xFDDA80", VA = "0x180FDF080", Slot = "8")]
	public void MEJBHHDOFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x839A2E0", Offset = "0x8398CE0", VA = "0x18839A2E0", Slot = "9")]
	public void AMCIJBBOOKO(MPMOFPPLHCF FGIHDPOHIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x839BBD0", Offset = "0x839A5D0", VA = "0x18839BBD0", Slot = "10")]
	public void KBADHJNEAKP(JBGLFFCNIBO MHHKOMDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x839B870", Offset = "0x839A270", VA = "0x18839B870", Slot = "11")]
	public void KBADHJNEAKP(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x839C1D0", Offset = "0x839ABD0", VA = "0x18839C1D0", Slot = "12")]
	public void LMLMOIALAIG(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x839B7A0", Offset = "0x839A1A0", VA = "0x18839B7A0", Slot = "13")]
	public void JHPEILPFKMM(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x839C920", Offset = "0x839B320", VA = "0x18839C920")]
	private void OPFJFLIOICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1230610", Offset = "0x122F010", VA = "0x181230610", Slot = "14")]
	public void BKHFIDHIFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x839B550", Offset = "0x8399F50", VA = "0x18839B550", Slot = "15")]
	public void JEIODOKKFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x839BEF0", Offset = "0x839A8F0", VA = "0x18839BEF0", Slot = "16")]
	public void KPHOEBHJOPD(JBGLFFCNIBO MHHKOMDGDID, LCGNEMGJNFI OHCGINPDMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x839AC90", Offset = "0x8399690", VA = "0x18839AC90", Slot = "17")]
	public void CPGNMGALCGD(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x839CB90", Offset = "0x839B590", VA = "0x18839CB90", Slot = "18")]
	public void PBCJBLEEBJB(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xC0A3E0", Offset = "0xC08DE0", VA = "0x180C0A3E0", Slot = "19")]
	public void HKPEBJKCLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x839B670", Offset = "0x839A070", VA = "0x18839B670", Slot = "20")]
	public void JELPAJDKIAL(LCGNEMGJNFI OHCGINPDMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x839B2E0", Offset = "0x8399CE0", VA = "0x18839B2E0")]
	private void IBCJHIFEDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x839A8D0", Offset = "0x83992D0", VA = "0x18839A8D0", Slot = "21")]
	public void BGKEMAEGHOH(JBGLFFCNIBO MHHKOMDGDID, Vector3 ABFAPGIDLBA, Vector3 GPFFOPCNLDB, Vector3 PFFAGBPBCDM, float LCJCFGNBNHB, float CIBCDKJPIEF, IReadOnlyList<Camera> PDLOMEFOCDM, IAEGPOMMOKC GBNJCPHDBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x839A450", Offset = "0x8398E50", VA = "0x18839A450", Slot = "22")]
	public void BGKEMAEGHOH(EEOAKPIHAKE KFPDJNOIECE, Vector3 ABFAPGIDLBA, Vector3 GPFFOPCNLDB, Vector3 PFFAGBPBCDM, float LCJCFGNBNHB, float CIBCDKJPIEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class CAIBMKBGKCB : EDLCHJHOGKN, DGKAEGLHOAA, AFKEJKMHAMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly JIPJBIMMBHB LKAEGJLGAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int OAHNOLFICEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds GFEEFIDLPHA;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds NBADPCBFMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x838E230", Offset = "0x838CC30", VA = "0x18838E230", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool NNCEKAKALLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xCF3EB0", Offset = "0xCF28B0", VA = "0x180CF3EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCF3AD0", Offset = "0xCF24D0", VA = "0x180CF3AD0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 LOGFGJJONIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int DPBJHJBCDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB5E180", Offset = "0xB5CB80", VA = "0x180B5E180", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public KJLIMKEBJFB JNACHLGBBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDB0", Offset = "0x9AD7B0", VA = "0x1809AEDB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool JEGDDGHJLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xE115C0", Offset = "0xE0FFC0", VA = "0x180E115C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	protected CAIBMKBGKCB(JIPJBIMMBHB MHHKOMDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x838E0C0", Offset = "0x838CAC0", VA = "0x18838E0C0", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "18")]
	public virtual bool LOCCIPCILJC(FJCDPKDIACD MHHKOMDGDID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x838E220", Offset = "0x838CC20", VA = "0x18838E220", Slot = "10")]
	public int FHBGJHELLCK(int NDPMJFBCIGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int GKDOONDAAJM(LPMFIJMHNCN BJJGMOJDONE);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int KDELMKPBFIC(LPMFIJMHNCN BJJGMOJDONE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract PGANDJPMLKL KGMPNMKEPGA();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float PMBDHEDMOLB();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void EFJJEHHDKHJ(LPMFIJMHNCN BJJGMOJDONE, PFEPNJHHLEN EDMIIEPJACG, int LHEBAIGEAIC = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract FJCDPKDIACD GFIDGEKBDEF();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x838E060", Offset = "0x838CA60", VA = "0x18838E060", Slot = "13")]
	public Hash128 ADIGJILKDHC(int BJJGMOJDONE)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract FIDPILACLGN PCAENAFPFBK();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract KJICOBOBPDB OBMFFCLOJLN(LPMFIJMHNCN BJJGMOJDONE, JobHandle GDFPJOCLDKE);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x838E090", Offset = "0x838CA90", VA = "0x18838E090", Slot = "12")]
	public KJICOBOBPDB CPOGGCHFJDD(int BJJGMOJDONE)
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
		[Cpp2IlInjected.Address(RVA = "0x839E2B0", Offset = "0x839CCB0", VA = "0x18839E2B0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FJHIIACFMIE
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KGNDFDLHAJF : IEnumerable<NMGGHJOOCNO>, IEnumerable, IEnumerator<NMGGHJOOCNO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private NMGGHJOOCNO <>2__current;

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
		private NMGGHJOOCNO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public KGNDFDLHAJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8398740", Offset = "0x8397140", VA = "0x188398740", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83988B0", Offset = "0x83972B0", VA = "0x1883988B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8398810", Offset = "0x8397210", VA = "0x188398810", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NMGGHJOOCNO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8398810", Offset = "0x8397210", VA = "0x188398810", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static NMGGHJOOCNO[][] AAEHIGDGFMO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static IANPEHHFGCE MGAMKNKOHBL;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig PHLNCPOAOLG;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader AFAKOELJJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83905F0", Offset = "0x838EFF0", VA = "0x1883905F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer EJEDEFFFNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8390BE0", Offset = "0x838F5E0", VA = "0x188390BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x83906F0", Offset = "0x838F0F0", VA = "0x1883906F0")]
	[GPPLJIPNHLO]
	internal static void ELAEPFFNBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x83907D0", Offset = "0x838F1D0", VA = "0x1883907D0")]
	public static Mesh GAPINEOCFHO(BPEIFANGIJA CBJCOKLMLLC, int BJJGMOJDONE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8390660", Offset = "0x838F060", VA = "0x188390660")]
	public static int BOMAGAFODCC(BPEIFANGIJA CBJCOKLMLLC, int BJJGMOJDONE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8390C40", Offset = "0x838F640", VA = "0x188390C40")]
	public static IANPEHHFGCE NJFAIGCBOKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8390670", Offset = "0x838F070", VA = "0x188390670")]
	[IteratorStateMachine(typeof(KGNDFDLHAJF))]
	private static IEnumerable<NMGGHJOOCNO> CFJJINNGBNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8391200", Offset = "0x838FC00", VA = "0x188391200")]
	public static NMGGHJOOCNO PHHMJHINAPO(BPEIFANGIJA CBJCOKLMLLC, int BJJGMOJDONE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x83906D0", Offset = "0x838F0D0", VA = "0x1883906D0")]
	public static bool DGIKDAKLLGH(this BPEIFANGIJA CBJCOKLMLLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8390870", Offset = "0x838F270", VA = "0x188390870")]
	public static void GFDJKDAAHAK(BPEIFANGIJA CBJCOKLMLLC, float3 PNAONCJHBPN, [Out] ILKLJJPGOFI FGNMLCEHDMK, [Out] float3 GKMLEFIELBG, [Out] float OPABHDDDLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8390E40", Offset = "0x838F840", VA = "0x188390E40")]
	public static void PADBAPIPNNK(Vector3 PNAONCJHBPN, BPEIFANGIJA CBJCOKLMLLC, [Out] Vector3 GKMLEFIELBG, [Out] float OPABHDDDLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8390650", Offset = "0x838F050", VA = "0x188390650")]
	[CEPGJFLCDHA(0)]
	[OOFAMMFPHGN(HHCEAPAGKJO.ExitingPlayMode, 0)]
	private static void AEGENKCMCCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8390A20", Offset = "0x838F420", VA = "0x188390A20")]
	[CEPGJFLCDHA(0)]
	[OOFAMMFPHGN(HHCEAPAGKJO.ExitingPlayMode, 0)]
	private static void JNDHAIJMFBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class DLMOCPIEEII : AMDEOGDAEEI, IDisposable, CLAMBNDFMBB
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly MLMAEEAINPM<JBGLFFCNIBO, JIPJBIMMBHB> FBJEDPNIPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly MLMAEEAINPM<LIINPMBBOMO, CAIBMKBGKCB> IIJOPECEGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly MLMAEEAINPM<EEOAKPIHAKE, IKNJFGABIBI> GCLECFCECCO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public JIPJBIMMBHB NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x838ECB0", Offset = "0x838D6B0", VA = "0x18838ECB0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public CAIBMKBGKCB NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x838ED10", Offset = "0x838D710", VA = "0x18838ED10", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IKNJFGABIBI NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x838ED70", Offset = "0x838D770", VA = "0x18838ED70", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BPLPCAPNGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xD34A50", Offset = "0xD33450", VA = "0x180D34A50", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA31440", Offset = "0xA2FE40", VA = "0x180A31440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x838F4D0", Offset = "0x838DED0", VA = "0x18838F4D0")]
	public DLMOCPIEEII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x838EB90", Offset = "0x838D590", VA = "0x18838EB90", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x838EDD0", Offset = "0x838D7D0", VA = "0x18838EDD0", Slot = "4")]
	public JBGLFFCNIBO JACMAAFFMME(CMKEMJONGPA DFPGGEDGGGN)
	{
		return default(JBGLFFCNIBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x838EDD0", Offset = "0x838D7D0", VA = "0x18838EDD0", Slot = "5")]
	public JBGLFFCNIBO JACMAAFFMME(CMKEMJONGPA DFPGGEDGGGN, bool KBPNEDEKOJD)
	{
		return default(JBGLFFCNIBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x838F000", Offset = "0x838DA00", VA = "0x18838F000", Slot = "6")]
	public void KOIOGDKMADA(JBGLFFCNIBO MHHKOMDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x838EE70", Offset = "0x838D870", VA = "0x18838EE70", Slot = "7")]
	public void JNMKMCANBKC(JBGLFFCNIBO MHHKOMDGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x838F210", Offset = "0x838DC10", VA = "0x18838F210", Slot = "8")]
	public LIINPMBBOMO NDBLDGLEHAH(JBGLFFCNIBO MHHKOMDGDID, HFEEEJKKJME DFPGGEDGGGN)
	{
		return default(LIINPMBBOMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x838F060", Offset = "0x838DA60", VA = "0x18838F060", Slot = "9")]
	public LIINPMBBOMO KOLNIOBFCAB(JBGLFFCNIBO MHHKOMDGDID, KOBGOEHEJAM DFPGGEDGGGN)
	{
		return default(LIINPMBBOMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x838EC20", Offset = "0x838D620", VA = "0x18838EC20", Slot = "11")]
	public void ELAMMLBBDKO(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x838EA90", Offset = "0x838D490", VA = "0x18838EA90", Slot = "10")]
	public void BFGFFCPNBOM(LIINPMBBOMO GMLPEGDALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x838EF90", Offset = "0x838D990", VA = "0x18838EF90", Slot = "20")]
	public IEnumerable<Renderer> KKEBEDOFEPP(JBGLFFCNIBO MHHKOMDGDID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x838EA10", Offset = "0x838D410", VA = "0x18838EA10", Slot = "12")]
	public EEOAKPIHAKE ACJOPGMPCNO(IEKLAJFHIFL DFPGGEDGGGN)
	{
		return default(EEOAKPIHAKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x838F1A0", Offset = "0x838DBA0", VA = "0x18838F1A0", Slot = "14")]
	public void LNHPBAOADFO(EEOAKPIHAKE KFPDJNOIECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x838F3B0", Offset = "0x838DDB0", VA = "0x18838F3B0", Slot = "16")]
	public Task OIJHANHOGPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x838EAF0", Offset = "0x838D4F0", VA = "0x18838EAF0", Slot = "17")]
	public Task DMDIGDMJNNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x838EEF0", Offset = "0x838D8F0", VA = "0x18838EEF0", Slot = "18")]
	public Task KALKJBEFJHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x259F4A0", Offset = "0x259DEA0", VA = "0x18259F4A0", Slot = "19")]
	public void AFGIFECOPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x838F350", Offset = "0x838DD50", VA = "0x18838F350", Slot = "13")]
	public void NMDBCKLMHCF(EEOAKPIHAKE KFPDJNOIECE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NAKPJLJPHKN
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool NGPLKPLAFEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material NLNGKPMKKJA();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material KPLHLHGLJGA();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material EHJMDJCLJEC();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LLNBKLDABGE(ADADNEEPCEF DCLAICIICJN);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FJDCGODEJHE(KJDEIJDKCCB DPLGHBDCCNO);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JAOABMHGDDK(GameObject OIIGDBLKEDN);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GKKKAMJBJHI(GameObject OIIGDBLKEDN, bool BNAHPIHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EOANNJIGEJJ
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static NAKPJLJPHKN GBDMJHAPPHC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool NGPLKPLAFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8390180", Offset = "0x838EB80", VA = "0x188390180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x83901E0", Offset = "0x838EBE0", VA = "0x1883901E0")]
	public static void CFDDKPCCGAL(NAKPJLJPHKN AIENBJPBINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8390590", Offset = "0x838EF90", VA = "0x188390590")]
	public static Material NLNGKPMKKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x83904C0", Offset = "0x838EEC0", VA = "0x1883904C0")]
	public static Material KPLHLHGLJGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8390230", Offset = "0x838EC30", VA = "0x188390230")]
	public static Material EHJMDJCLJEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8390520", Offset = "0x838EF20", VA = "0x188390520")]
	public static int LLNBKLDABGE(ADADNEEPCEF DCLAICIICJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8390290", Offset = "0x838EC90", VA = "0x188390290")]
	public static int FJDCGODEJHE(KJDEIJDKCCB DPLGHBDCCNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x83903E0", Offset = "0x838EDE0", VA = "0x1883903E0")]
	public static void JAOABMHGDDK(GameObject OIIGDBLKEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8390300", Offset = "0x838ED00", VA = "0x188390300")]
	public static void GKKKAMJBJHI(GameObject OIIGDBLKEDN, bool BNAHPIHOMCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IKNJFGABIBI : JOCEHKMFLHH
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GGEEHHPHHDO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public IKNJFGABIBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public GGEEHHPHHDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8392470", Offset = "0x8390E70", VA = "0x188392470", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8392150", Offset = "0x8390B50", VA = "0x188392150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8392100", Offset = "0x8390B00", VA = "0x188392100")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8392420", Offset = "0x8390E20", VA = "0x188392420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8392370", Offset = "0x8390D70", VA = "0x188392370", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8392370", Offset = "0x8390D70", VA = "0x188392370", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IEKLAJFHIFL AALFJHIHKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CLAMBNDFMBB EOIGIGKJKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private EJDJLHLMKLF NBKICGCKPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<NEEOFFFMBLA> HHGOGFBMJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<NEEOFFFMBLA> PJFKAJJOIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject FOGELFMLHKO;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8395540", Offset = "0x8393F40", VA = "0x188395540")]
	public static IKNJFGABIBI IGEFFJLKFPE(IEKLAJFHIFL DFPGGEDGGGN, CLAMBNDFMBB EOIGIGKJKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8396380", Offset = "0x8394D80", VA = "0x188396380")]
	private IKNJFGABIBI(IEKLAJFHIFL DFPGGEDGGGN, CLAMBNDFMBB EOIGIGKJKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8395010", Offset = "0x8393A10", VA = "0x188395010")]
	public void CHMHFDMILHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x83954C0", Offset = "0x8393EC0", VA = "0x1883954C0")]
	[IteratorStateMachine(typeof(GGEEHHPHHDO))]
	public IEnumerable<Renderer> GKEHMMMIADD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x83958E0", Offset = "0x83942E0", VA = "0x1883958E0", Slot = "4")]
	public void MPAKAOAIOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8395490", Offset = "0x8393E90", VA = "0x188395490")]
	private void DIGPLBGPLNA(Vector3 EHPGHOFFHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8395690", Offset = "0x8394090", VA = "0x188395690")]
	public void IPDLKHCHONO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NEEOFFFMBLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct KDENMCLLMJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public PFEPNJHHLEN LHALOCABDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public FJCDPKDIACD AOMKDHOLKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int IINEHHADBAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CMHIILBHBNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NEEOFFFMBLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LPMFIJMHNCN lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<KDENMCLLMJF> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IMPFNPPINEK combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CMHIILBHBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x838E3F0", Offset = "0x838CDF0", VA = "0x18838E3F0")]
		internal JobHandle JAOIKODCLIP()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x838E3C0", Offset = "0x838CDC0", VA = "0x18838E3C0")]
		internal void GONOFCIBJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x838E250", Offset = "0x838CC50", VA = "0x18838E250")]
		internal void DHAAJFCDGEF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] ICBEFBJIFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ANGNMMIMHOK DLPOOJHNEMO;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 CGHFPFJCGCP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh PANLIELNABH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int KPJGFPJBEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9B5570", Offset = "0x9B3F70", VA = "0x1809B5570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9B5550", Offset = "0x9B3F50", VA = "0x1809B5550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x839D530", Offset = "0x839BF30", VA = "0x18839D530")]
	public void MMICBDMLBCA(List<FJCDPKDIACD> GOHDCDFDBMG, Matrix4x4[] GPMBFPCMHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x839CEA0", Offset = "0x839B8A0", VA = "0x18839CEA0")]
	public static List<NEEOFFFMBLA> IDEDHGEBOCJ(List<JIPJBIMMBHB> LLALGMJHLIE, LPMFIJMHNCN BJJGMOJDONE, Bounds ALPDMCMHIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x839D710", Offset = "0x839C110", VA = "0x18839D710")]
	private JobHandle NJKNBIBMIGO(IMPFNPPINEK JKJJHBABPHI, int IKGJNBOIAOO, int BKPEACIOBJG, LPMFIJMHNCN BJJGMOJDONE, List<KDENMCLLMJF> OJHONHFCOEO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x839CDC0", Offset = "0x839B7C0", VA = "0x18839CDC0")]
	private void FPCKMFDOJHM(List<KDENMCLLMJF> OJHONHFCOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x839DC00", Offset = "0x839C600", VA = "0x18839DC00")]
	private NEEOFFFMBLA(List<KDENMCLLMJF> OJHONHFCOEO, int IKGJNBOIAOO, int BKPEACIOBJG, LPMFIJMHNCN BJJGMOJDONE, Bounds ALPDMCMHIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x839CD30", Offset = "0x839B730", VA = "0x18839CD30", Slot = "4")]
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
		private MaterialPropertyBlock PFAFNLKCBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private NEEOFFFMBLA LKDNKMEFADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<FJCDPKDIACD> JOOOFLHEIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture FLFCJFAKFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer AEGIDJKBONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader PAHGPMJIHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] EGGJFNJNFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int GELKJKOGFBA;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer PAOHEFKMKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int HOMPKHODPBC
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x839EFE0", Offset = "0x839D9E0", VA = "0x18839EFE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x839E310", Offset = "0x839CD10", VA = "0x18839E310")]
		public static List<SkinnedShapeRenderer> Create(GameObject MHHKOMDGDID, List<NEEOFFFMBLA> IDAOLDLBKHN, List<FJCDPKDIACD> JOOOFLHEIHP, Material GMIALIBEKEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x839E660", Offset = "0x839D060", VA = "0x18839E660")]
		public void Init(NEEOFFFMBLA LKDNKMEFADL, List<FJCDPKDIACD> JOOOFLHEIHP, Material GMIALIBEKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x839EF40", Offset = "0x839D940", VA = "0x18839EF40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x839EEA0", Offset = "0x839D8A0", VA = "0x18839EEA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x839EE60", Offset = "0x839D860", VA = "0x18839EE60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x839E5A0", Offset = "0x839CFA0", VA = "0x18839E5A0")]
		private void DMCIAOLIJDG(ScriptableRenderContext OJFCDDMGKNP, Camera[] PIPJGDHLAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x839EAF0", Offset = "0x839D4F0", VA = "0x18839EAF0")]
		private void MMICBDMLBCA(CommandBuffer FLBFPNANBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
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
