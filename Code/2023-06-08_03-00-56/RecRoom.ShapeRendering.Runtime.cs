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
using RecRoom.Core.Creation.Shapes;
using RecRoom.ShapeRendering;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
public interface MCBAIFHBCBG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KJGONOBNAKH MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BGKFGGGHFMO MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CLABJLDJBIO MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PLHIMPMCJAG : JOOGMEDDJFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const byte IHEOKHJDFCF = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private byte EIHKEGKDBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly List<SkinnedShapeRenderer>[] IMPIFMPJGHB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BOFKKJGOHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x838BF0", Offset = "0x8379F0", VA = "0x180838BF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F63A0", Offset = "0x7F51A0", VA = "0x1807F63A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FIGONOOKAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x93BE30", Offset = "0x93AC30", VA = "0x18093BE30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x952E20", Offset = "0x951C20", VA = "0x180952E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float PNBCPGPIEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB9CFF0", Offset = "0xB9BDF0", VA = "0x180B9CFF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9E91F0", Offset = "0x9E7FF0", VA = "0x1809E91F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float OBADPPCKOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB89D10", Offset = "0xB88B10", VA = "0x180B89D10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB89D30", Offset = "0xB88B30", VA = "0x180B89D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public List<SkinnedShapeRenderer> DPHFOAHCCPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62019E0", Offset = "0x62007E0", VA = "0x1862019E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<SkinnedShapeRenderer> HECEHIDFADM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1760DB0", Offset = "0x175FBB0", VA = "0x181760DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GameObject EDOHGCDFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x952E30", Offset = "0x951C30", VA = "0x180952E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte GACGJFOBBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6201760", Offset = "0x6200560", VA = "0x186201760", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6201B50", Offset = "0x6200950", VA = "0x186201B50")]
	public PLHIMPMCJAG(List<MNOFKCEHHIH> GCIJEAPILFB, List<MNOFKCEHHIH> MKFOKMHGEOM, List<OKJPIDOHDOO> CKKOBEGDDNI, Material DMHFIODFBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6201A40", Offset = "0x6200840", VA = "0x186201A40")]
	private int LGCAKMNPMPN(List<MNOFKCEHHIH> OCNOFFLDFGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62017B0", Offset = "0x62005B0", VA = "0x1862017B0")]
	private void GLFAOAOFCCK(int BIFJNJPGJCE, bool EOJJCIJDILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6201940", Offset = "0x6200740", VA = "0x186201940")]
	public void IDCHBNPBJPM(Vector3 IGKKJDCLMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6201630", Offset = "0x6200430", VA = "0x186201630", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6201900", Offset = "0x6200700", VA = "0x186201900")]
	public void HKAOBNKEOHD(Transform CDCBKPFGLDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class FPJOEKKPMHC : BGKFGGGHFMO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct AIIJICENFJD : EGBGHEPHCBF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JIAHFJAFHAI GFNFNFOOGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JobHandle DPDOHIMELGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KEHCGCCKJOM JIEAEBCDMOK;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x61F4040", Offset = "0x61F2E40", VA = "0x1861F4040")]
		public AIIJICENFJD(JIAHFJAFHAI GFNFNFOOGBL, JobHandle DPDOHIMELGE, KEHCGCCKJOM JIEAEBCDMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4397B40", Offset = "0x4396940", VA = "0x184397B40")]
		public bool JKEFCNHAJAB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x61F4010", Offset = "0x61F2E10", VA = "0x1861F4010", Slot = "4")]
		public JIAHFJAFHAI NMCJFPPLLME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x61F3FC0", Offset = "0x61F2DC0", VA = "0x1861F3FC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly HKIABLCGFLA DKPMKJNEILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int[] NDOIOEEIFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float CEPCJHIFMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Hash128 KIAJNFDAEEK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override CDDOBLPOFHM DJMBKNPBBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x61FB1C0", Offset = "0x61F9FC0", VA = "0x1861FB1C0", Slot = "17")]
		get
		{
			return default(CDDOBLPOFHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Vector3 DKMPGFFNDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x61FA010", Offset = "0x61F8E10", VA = "0x1861FA010")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override Hash128 BIOJEBJMGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x61F9220", Offset = "0x61F8020", VA = "0x1861F9220", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61FB590", Offset = "0x61FA390", VA = "0x1861FB590")]
	public FPJOEKKPMHC(KJGONOBNAKH BHODGDEIEBD, HKIABLCGFLA FAJCHBCCGOJ, bool DOFCMHOGCEP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61F9350", Offset = "0x61F8150", VA = "0x1861F9350", Slot = "16")]
	public override bool BFKMOPNBCIF(OKJPIDOHDOO BHODGDEIEBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61FAEF0", Offset = "0x61F9CF0", VA = "0x1861FAEF0", Slot = "18")]
	public override int LGCAKMNPMPN(AOMHNDBGAED MNODNKMNJDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61FA370", Offset = "0x61F9170", VA = "0x1861FA370", Slot = "19")]
	public override int DIAEOPBNAHO(AOMHNDBGAED MNODNKMNJDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61FAC40", Offset = "0x61F9A40", VA = "0x1861FAC40")]
	private int KMMDKCNDIOK(AOMHNDBGAED MNODNKMNJDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61F9880", Offset = "0x61F8680", VA = "0x1861F9880", Slot = "20")]
	public override void CJAIIEKCIKD(AOMHNDBGAED MNODNKMNJDN, OGCJDFNDACA DNGMPAADFAG, int BBLMKCECEOO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61F97B0", Offset = "0x61F85B0", VA = "0x1861F97B0", Slot = "21")]
	public override OKJPIDOHDOO BGHMNEIEBLC()
	{
		return default(OKJPIDOHDOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61FAFA0", Offset = "0x61F9DA0", VA = "0x1861FAFA0", Slot = "23")]
	public override BLCNPGKNBKK ONFLIDOACPH()
	{
		return default(BLCNPGKNBKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61FA420", Offset = "0x61F9220", VA = "0x1861FA420", Slot = "24")]
	public override EGBGHEPHCBF JHLGNAIDOLE(AOMHNDBGAED MNODNKMNJDN, JobHandle DPDOHIMELGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KJGONOBNAKH : HONKIBAEKII, LHLDMBFLJIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BOPCLEINHCD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KJGONOBNAKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<ClusterMeshRenderer>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private ClusterMeshRenderer <c>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private IEnumerator<Renderer> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Renderer <r>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IEnumerator<MeshRenderer> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private MeshRenderer <b>5__6;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
		[DebuggerHidden]
		public BOPCLEINHCD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x61F4A30", Offset = "0x61F3830", VA = "0x1861F4A30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x61F4480", Offset = "0x61F3280", VA = "0x1861F4480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x61F43E0", Offset = "0x61F31E0", VA = "0x1861F43E0")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x61F4390", Offset = "0x61F3190", VA = "0x1861F4390")]
		private void HMDILAAEAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x61F4430", Offset = "0x61F3230", VA = "0x1861F4430")]
		private void LMJBDCOCADE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x61F49F0", Offset = "0x61F37F0", VA = "0x1861F49F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x61F4950", Offset = "0x61F3750", VA = "0x1861F4950", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x61F4950", Offset = "0x61F3750", VA = "0x1861F4950", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HKFILLOBNHF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KJGONOBNAKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private IEnumerator<Renderer> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Renderer <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<SkinnedShapeRenderer>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private SkinnedShapeRenderer <b>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
		[DebuggerHidden]
		public HKFILLOBNHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x61FBAF0", Offset = "0x61FA8F0", VA = "0x1861FBAF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61FB6E0", Offset = "0x61FA4E0", VA = "0x1861FB6E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x61FB690", Offset = "0x61FA490", VA = "0x1861FB690")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x61FB640", Offset = "0x61FA440", VA = "0x1861FB640")]
		private void HMDILAAEAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x61FBAB0", Offset = "0x61FA8B0", VA = "0x1861FBAB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x61FBA10", Offset = "0x61FA810", VA = "0x1861FBA10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x61FBA10", Offset = "0x61FA810", VA = "0x1861FBA10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MOOAJDGKIHG JLBOPAOFHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<BGKFGGGHFMO> AFLMEEGCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<ClusterMeshRenderer> GCAFKGGINGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BatchedMeshRenderer OFBBMHOLNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool JHCHFCDPDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly bool EEGPKJPDNFG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<NFHDJEMLONG> GNHHFAHILEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BMBNCHEKNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61FD0D0", Offset = "0x61FBED0", VA = "0x1861FD0D0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OKJPIDOHDOO NLIMJFKPLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61FCC40", Offset = "0x61FBA40", VA = "0x1861FCC40", Slot = "7")]
		get
		{
			return default(OKJPIDOHDOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<SkinnedShapeRenderer> PDFGLODHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x916A30", Offset = "0x915830", VA = "0x180916A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x61FC210", Offset = "0x61FB010", VA = "0x1861FC210")]
	private bool FDPFLLEFCML(BGKFGGGHFMO MGNBGAKGHBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61FD110", Offset = "0x61FBF10", VA = "0x1861FD110")]
	private static bool NFCNHMBDHFM(BGKFGGGHFMO MGNBGAKGHBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61FD6E0", Offset = "0x61FC4E0", VA = "0x1861FD6E0")]
	public KJGONOBNAKH(MOOAJDGKIHG FAJCHBCCGOJ, bool MLBNACLMJEJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61FC090", Offset = "0x61FAE90", VA = "0x1861FC090", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x61FCEC0", Offset = "0x61FBCC0", VA = "0x1861FCEC0")]
	public void IMFFJGIMDFG(BGKFGGGHFMO MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61FD5B0", Offset = "0x61FC3B0", VA = "0x1861FD5B0")]
	public void OIPPMFBKPAM(BGKFGGGHFMO MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61FC7A0", Offset = "0x61FB5A0", VA = "0x1861FC7A0", Slot = "4")]
	public void HBIINFGFJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x61FD130", Offset = "0x61FBF30", VA = "0x1861FD130")]
	public void OAHLJJFNGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61FD420", Offset = "0x61FC220", VA = "0x1861FD420")]
	private void OGAHHMPCCEN(List<BGKFGGGHFMO> AFLMEEGCHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61FC030", Offset = "0x61FAE30", VA = "0x1861FC030")]
	private static Material BFPMAPEMKBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61FD380", Offset = "0x61FC180", VA = "0x1861FD380")]
	private void OGAHHMPCCEN(BGKFGGGHFMO MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61FCDF0", Offset = "0x61FBBF0", VA = "0x1861FCDF0")]
	private void IGFLLCMCABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x61FC240", Offset = "0x61FB040", VA = "0x1861FC240")]
	public void FHAHIEAICLM(bool CDFANMKFFPO, bool ACPGLCNEAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61FBFA0", Offset = "0x61FADA0", VA = "0x1861FBFA0")]
	protected void AKNDBIKFIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61FCD10", Offset = "0x61FBB10", VA = "0x1861FCD10")]
	[IteratorStateMachine(typeof(BOPCLEINHCD))]
	public IEnumerable<Renderer> HJGGAMFNPMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61FCD80", Offset = "0x61FBB80", VA = "0x1861FCD80")]
	[IteratorStateMachine(typeof(HKFILLOBNHF))]
	public IEnumerable<Renderer> IEHCEOHDFAL()
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6204C40", Offset = "0x6203A40", VA = "0x186204C40")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class NBMFKDLDAPO : DFDMNPNGDBP, IDisposable, MCBAIFHBCBG
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly IBKLHAEEEEI EKFPDHJKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DKBOIHGJGOH<KBJIGIFLBPE, KJGONOBNAKH> FOLHHANEEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DKBOIHGJGOH<LBHGLABJFEP, BGKFGGGHFMO> AFLMEEGCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly DKBOIHGJGOH<HGLINNPEOAN, CLABJLDJBIO> BBAOIBCPMBF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public KJGONOBNAKH MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61FF220", Offset = "0x61FE020", VA = "0x1861FF220", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BGKFGGGHFMO MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x61FF160", Offset = "0x61FDF60", VA = "0x1861FF160", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public CLABJLDJBIO MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x61FF1C0", Offset = "0x61FDFC0", VA = "0x1861FF1C0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool PCJDAPMCEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9D2F60", Offset = "0x9D1D60", VA = "0x1809D2F60", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9D30A0", Offset = "0x9D1EA0", VA = "0x1809D30A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x61FFA00", Offset = "0x61FE800", VA = "0x1861FFA00")]
	public NBMFKDLDAPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61FEE60", Offset = "0x61FDC60", VA = "0x1861FEE60", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61FF790", Offset = "0x61FE590", VA = "0x1861FF790", Slot = "4")]
	public KBJIGIFLBPE MMIOJCPDNCP(MOOAJDGKIHG FAJCHBCCGOJ)
	{
		return default(KBJIGIFLBPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61FF790", Offset = "0x61FE590", VA = "0x1861FF790", Slot = "5")]
	public KBJIGIFLBPE MMIOJCPDNCP(MOOAJDGKIHG FAJCHBCCGOJ, bool MLBNACLMJEJ)
	{
		return default(KBJIGIFLBPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61FEEF0", Offset = "0x61FDCF0", VA = "0x1861FEEF0", Slot = "6")]
	public void GHNAKHJOHLG(KBJIGIFLBPE BHODGDEIEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61FF080", Offset = "0x61FDE80", VA = "0x1861FF080", Slot = "7")]
	public void ILKKONNJNFO(KBJIGIFLBPE BHODGDEIEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61FED30", Offset = "0x61FDB30", VA = "0x1861FED30", Slot = "8")]
	public LBHGLABJFEP CNKPGFAEMMH(KBJIGIFLBPE BHODGDEIEBD, HKIABLCGFLA FAJCHBCCGOJ)
	{
		return default(LBHGLABJFEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61FEBF0", Offset = "0x61FD9F0", VA = "0x1861FEBF0", Slot = "9")]
	public LBHGLABJFEP AKGNMJGGKBP(KBJIGIFLBPE BHODGDEIEBD, DONBKONECPJ FAJCHBCCGOJ)
	{
		return default(LBHGLABJFEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x61FF680", Offset = "0x61FE480", VA = "0x1861FF680", Slot = "11")]
	public void LMKLOFHOKKO(LBHGLABJFEP MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61FF100", Offset = "0x61FDF00", VA = "0x1861FF100", Slot = "10")]
	public void ILOCBBDADHG(LBHGLABJFEP MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x61FEF50", Offset = "0x61FDD50", VA = "0x1861FEF50", Slot = "20")]
	public IEnumerable<Renderer> GOLBIEDKAHN(KBJIGIFLBPE BHODGDEIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x61FF710", Offset = "0x61FE510", VA = "0x1861FF710", Slot = "12")]
	public HGLINNPEOAN MBMDPLPNMJI(KGOHMAFCOHC FAJCHBCCGOJ)
	{
		return default(HGLINNPEOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x61FF8A0", Offset = "0x61FE6A0", VA = "0x1861FF8A0", Slot = "14")]
	public void OONILFAMIJK(HGLINNPEOAN GEMFDDAIOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x61FF910", Offset = "0x61FE710", VA = "0x1861FF910", Slot = "16")]
	public Task PFMGLJNDCLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61FEFC0", Offset = "0x61FDDC0", VA = "0x1861FEFC0", Slot = "17")]
	public Task HBNMJIPMPGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x61FF020", Offset = "0x61FDE20", VA = "0x1861FF020", Slot = "18")]
	public Task IHKMCGGBPDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9D3200", Offset = "0x9D2000", VA = "0x1809D3200", Slot = "19")]
	public void JPNPHPGCFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61FEB90", Offset = "0x61FD990", VA = "0x1861FEB90", Slot = "13")]
	public void AFJJFPJHLOG(HGLINNPEOAN GEMFDDAIOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61FF280", Offset = "0x61FE080", VA = "0x1861FF280", Slot = "25")]
	public FAODENCLCHB LFDOEOPNCNK(OKJPIDOHDOO GEDCKAADLAM, IEnumerable<LBHGLABJFEP> AFLMEEGCHPC, int IPCPJEMBHMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HOPKKLEDJJB
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKGGGOCCGDN(AIOMGFAEFNO LKLFHGBOOLP, Renderer BMFFGJEAEEP, int NGGPINDLEPD);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POOPIDKCIAE(Renderer BMFFGJEAEEP, LFKJEEKJNGG NAHOGGCJJHI, Vector3 EOIONKBKIHC, Vector3 PFIGELHECFB, Vector3 GOCNPPLONCL, float MDFMBDPHIDE, float DCDGPHDMBKN, float GECKILHPIID = -1f, [Optional] Color? OPEMNAAFCJM, [Optional] IReadOnlyList<Camera> BDMPPDGPPDD);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLBAKMHJIPP(Renderer BMFFGJEAEEP, int NGGPINDLEPD);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CJAFCBPIBNI();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AAFJCLFDFBJ(int DEBKMLOOAGD, HJNMAIFKPEK LKLFHGBOOLP, Renderer BMFFGJEAEEP, int NGGPINDLEPD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DECFOCCDNFO : FKDMEDAGIAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class KMJAPOBFAOE : PGNEAPINPCH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x61FD7D0", Offset = "0x61FC5D0", VA = "0x1861FD7D0")]
		public KMJAPOBFAOE(string PPPOJKMOIGD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HOPKKLEDJJB LONDGFKDBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly MCBAIFHBCBG FFHOPBCLFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private MeshRenderer JNKGFIFJJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private KMJAPOBFAOE EIFMAKBFBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool EKCAJPOCBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer HNBJFOJIDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private KMJAPOBFAOE AIOADABHIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool GLFLGLIHNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer DALPBIAAILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private KMJAPOBFAOE ICBELJGHHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool GIFMINJHMEH;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x61F8B60", Offset = "0x61F7960", VA = "0x1861F8B60")]
	public DECFOCCDNFO(HOPKKLEDJJB IOMELMCKHGA, MCBAIFHBCBG FFHOPBCLFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x61F7440", Offset = "0x61F6240", VA = "0x1861F7440", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61F8840", Offset = "0x61F7640", VA = "0x1861F8840")]
	private void NANDNOEGCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61F7960", Offset = "0x61F6760", VA = "0x1861F7960", Slot = "4")]
	public void FDGPFEJCDEK(KBJIGIFLBPE BHODGDEIEBD, HJNMAIFKPEK ONIEAMHCLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61F7740", Offset = "0x61F6540", VA = "0x1861F7740", Slot = "5")]
	public void FDGPFEJCDEK(LBHGLABJFEP MGNBGAKGHBH, HJNMAIFKPEK ONIEAMHCLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61F7610", Offset = "0x61F6410", VA = "0x1861F7610", Slot = "6")]
	public void EALJJEPABJH(LBHGLABJFEP MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61F7C90", Offset = "0x61F6A90", VA = "0x1861F7C90", Slot = "7")]
	public void KAPAJGLKIEA(LBHGLABJFEP MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61F7DB0", Offset = "0x61F6BB0", VA = "0x1861F7DB0", Slot = "21")]
	public void MCNIIAOAGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2233F70", Offset = "0x2232D70", VA = "0x182233F70", Slot = "8")]
	public void KKALMHKDNOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61F7DF0", Offset = "0x61F6BF0", VA = "0x1861F7DF0", Slot = "9")]
	public void MHINPOJDEJO(HJNMAIFKPEK ONIEAMHCLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61F6A90", Offset = "0x61F5890", VA = "0x1861F6A90", Slot = "10")]
	public void CPGGDGECPJG(KBJIGIFLBPE BHODGDEIEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61F6740", Offset = "0x61F5540", VA = "0x1861F6740", Slot = "11")]
	public void CPGGDGECPJG(LBHGLABJFEP MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61F6C40", Offset = "0x61F5A40", VA = "0x1861F6C40", Slot = "12")]
	public void DAPGBCFFBON(KBJIGIFLBPE BHODGDEIEBD, AIOMGFAEFNO LKLFHGBOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x61F6E00", Offset = "0x61F5C00", VA = "0x1861F6E00", Slot = "13")]
	public void DAPGBCFFBON(LBHGLABJFEP MGNBGAKGHBH, AIOMGFAEFNO LKLFHGBOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61F7400", Offset = "0x61F6200", VA = "0x1861F7400", Slot = "22")]
	public void DCONLAFIMMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61F7B60", Offset = "0x61F6960", VA = "0x1861F7B60", Slot = "14")]
	public void HKHCBGAIALH(LBHGLABJFEP MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61F7C00", Offset = "0x61F6A00", VA = "0x1861F7C00", Slot = "15")]
	public void IPODIOENNIA(LBHGLABJFEP MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x195BC90", Offset = "0x195AA90", VA = "0x18195BC90", Slot = "16")]
	public void EEPEEHCCIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61F8700", Offset = "0x61F7500", VA = "0x1861F8700", Slot = "17")]
	public void MIFDDCINKKD(AIOMGFAEFNO LKLFHGBOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61F71B0", Offset = "0x61F5FB0", VA = "0x1861F71B0")]
	private void DCBJCGKMELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61F6FF0", Offset = "0x61F5DF0", VA = "0x1861F6FF0")]
	public void DAPGBCFFBON(LBHGLABJFEP MGNBGAKGHBH, AIOMGFAEFNO LKLFHGBOOLP, bool GDOHCPMOOII = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61F8A90", Offset = "0x61F7890", VA = "0x1861F8A90")]
	private void NKGGGOCCGDN(AIOMGFAEFNO LKLFHGBOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61F8380", Offset = "0x61F7180", VA = "0x1861F8380", Slot = "18")]
	public void MIEGMHBMHGC(KBJIGIFLBPE BHODGDEIEBD, Vector3 EOIONKBKIHC, Vector3 PFIGELHECFB, Vector3 GOCNPPLONCL, float MDFMBDPHIDE, float DCDGPHDMBKN, IReadOnlyList<Camera> BHJLCAGCKHB, LFKJEEKJNGG NAHOGGCJJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x61F7F60", Offset = "0x61F6D60", VA = "0x1861F7F60", Slot = "19")]
	public void MIEGMHBMHGC(HGLINNPEOAN GEMFDDAIOCB, Vector3 EOIONKBKIHC, Vector3 PFIGELHECFB, Vector3 GOCNPPLONCL, float MDFMBDPHIDE, float DCDGPHDMBKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ACBJLPDEDFI
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DGGBBCOODJB : IEnumerable<HNOFKBAKALF>, IEnumerable, IEnumerator<HNOFKBAKALF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private HNOFKBAKALF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int <p>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <l>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private HNOFKBAKALF System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
		[DebuggerHidden]
		public DGGBBCOODJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x61F8BB0", Offset = "0x61F79B0", VA = "0x1861F8BB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61F8D20", Offset = "0x61F7B20", VA = "0x1861F8D20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x61F8C90", Offset = "0x61F7A90", VA = "0x1861F8C90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HNOFKBAKALF> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x61F8C90", Offset = "0x61F7A90", VA = "0x1861F8C90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int DPGPKEKBHKP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static HNOFKBAKALF[][] JHNCCPCGJJH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static DHAKIFECBBE MGGAMLEOBNO;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static ShapeRendererConfig MEHMHNCKMBK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static ComputeShader MBCKKKPOGND
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x61F3DE0", Offset = "0x61F2BE0", VA = "0x1861F3DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static SkinnedShapeRenderer FCHAODHGHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x61F3940", Offset = "0x61F2740", VA = "0x1861F3940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61F3E60", Offset = "0x61F2C60", VA = "0x1861F3E60")]
	public static Mesh OELIFFJGNHC(PJJDOAFIHOH CBKDKFCEAGO, int MNODNKMNJDN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61F3E50", Offset = "0x61F2C50", VA = "0x1861F3E50")]
	public static int NJKDFIAOACB(PJJDOAFIHOH CBKDKFCEAGO, int MNODNKMNJDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61F3090", Offset = "0x61F1E90", VA = "0x1861F3090")]
	public static DHAKIFECBBE CIHPPOCPCED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x61F39C0", Offset = "0x61F27C0", VA = "0x1861F39C0")]
	[IteratorStateMachine(typeof(DGGBBCOODJB))]
	private static IEnumerable<HNOFKBAKALF> JHNAKNHDPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x61F33A0", Offset = "0x61F21A0", VA = "0x1861F33A0")]
	public static HNOFKBAKALF CPPKLJHANBF(PJJDOAFIHOH CBKDKFCEAGO, int MNODNKMNJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x61F3700", Offset = "0x61F2500", VA = "0x1861F3700")]
	public static bool ECDMJDIMIAB(this PJJDOAFIHOH CBKDKFCEAGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61F31F0", Offset = "0x61F1FF0", VA = "0x1861F31F0")]
	public static void CNJAOFPCJGP(PJJDOAFIHOH CBKDKFCEAGO, float3 NDPNJGFMMLL, out HBMLENJKLON CPOMLCEAFBO, out float3 HAMDBOBANNI, out float HKFFEEGGOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x61F3A20", Offset = "0x61F2820", VA = "0x1861F3A20")]
	public static void JJEHMMBJHOO(Vector3 NDPNJGFMMLL, PJJDOAFIHOH CBKDKFCEAGO, out Vector3 HAMDBOBANNI, out float HKFFEEGGOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61F39B0", Offset = "0x61F27B0", VA = "0x1861F39B0")]
	[KBOEOFKMKLB(GPKAGPMLHII.ExitingPlayMode, 0)]
	private static void HCHAHBODAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x61F3720", Offset = "0x61F2520", VA = "0x1861F3720")]
	[KBOEOFKMKLB(GPKAGPMLHII.ExitingPlayMode, 0)]
	private static void EJIGKMGHLPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class BGKFGGGHFMO : MKAMPBGAEOG, NFHDJEMLONG, PMADNKLIJMC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly KJGONOBNAKH EDOHGCDFIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected Bounds NADGGIBEMBH;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Bounds JKKGFEPHIKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1B8A920", Offset = "0x1B89720", VA = "0x181B8A920", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public virtual CDDOBLPOFHM DJMBKNPBBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x61F4300", Offset = "0x61F3100", VA = "0x1861F4300", Slot = "17")]
		get
		{
			return default(CDDOBLPOFHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool EEGPKJPDNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x91A1F0", Offset = "0x918FF0", VA = "0x18091A1F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x90DA70", Offset = "0x90C870", VA = "0x18090DA70")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	protected abstract Hash128 BIOJEBJMGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int JPCNIIPEAOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x81BC70", Offset = "0x81AA70", VA = "0x18081BC70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public EODFBPNMFMP BGOAIKICJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x916A30", Offset = "0x915830", VA = "0x180916A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool DHCDOMEJMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA4E720", Offset = "0xA4D520", VA = "0x180A4E720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	protected BGKFGGGHFMO(KJGONOBNAKH BHODGDEIEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x61F4170", Offset = "0x61F2F70", VA = "0x1861F4170", Slot = "15")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x81CAB0", Offset = "0x81B8B0", VA = "0x18081CAB0", Slot = "16")]
	public virtual bool BFKMOPNBCIF(OKJPIDOHDOO BHODGDEIEBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int LGCAKMNPMPN(AOMHNDBGAED MNODNKMNJDN);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int DIAEOPBNAHO(AOMHNDBGAED MNODNKMNJDN);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract void CJAIIEKCIKD(AOMHNDBGAED MNODNKMNJDN, OGCJDFNDACA DNGMPAADFAG, int BBLMKCECEOO = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract OKJPIDOHDOO BGHMNEIEBLC();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x61F42A0", Offset = "0x61F30A0", VA = "0x1861F42A0", Slot = "11")]
	public Hash128 KCPGDDFACBP(int MNODNKMNJDN)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract BLCNPGKNBKK ONFLIDOACPH();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract EGBGHEPHCBF JHLGNAIDOLE(AOMHNDBGAED MNODNKMNJDN, JobHandle DPDOHIMELGE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61F42D0", Offset = "0x61F30D0", VA = "0x1861F42D0", Slot = "10")]
	public EGBGHEPHCBF LFDOEOPNCNK(int MNODNKMNJDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class NGODKAMHDCF : BGKFGGGHFMO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct BDHOCAGHHIN : EGBGHEPHCBF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private JIAHFJAFHAI GFNFNFOOGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JobHandle DPDOHIMELGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private HOLIBHCMOML JIEAEBCDMOK;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x61F4110", Offset = "0x61F2F10", VA = "0x1861F4110")]
		public BDHOCAGHHIN(JIAHFJAFHAI GFNFNFOOGBL, JobHandle DPDOHIMELGE, HOLIBHCMOML JIEAEBCDMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4397B40", Offset = "0x4396940", VA = "0x184397B40")]
		public bool JKEFCNHAJAB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x61F40E0", Offset = "0x61F2EE0", VA = "0x1861F40E0", Slot = "4")]
		public JIAHFJAFHAI NMCJFPPLLME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x61F4090", Offset = "0x61F2E90", VA = "0x1861F4090", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly DONBKONECPJ OABIBHDBMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private float CEPCJHIFMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Hash128 KIAJNFDAEEK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	protected override Hash128 BIOJEBJMGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x61FFDE0", Offset = "0x61FEBE0", VA = "0x1861FFDE0", Slot = "22")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6201580", Offset = "0x6200380", VA = "0x186201580")]
	public NGODKAMHDCF(KJGONOBNAKH BHODGDEIEBD, DONBKONECPJ FAJCHBCCGOJ, bool MLBNACLMJEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x81CAB0", Offset = "0x81B8B0", VA = "0x18081CAB0", Slot = "16")]
	public override bool BFKMOPNBCIF(OKJPIDOHDOO BHODGDEIEBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6201170", Offset = "0x61FFF70", VA = "0x186201170", Slot = "18")]
	public override int LGCAKMNPMPN(AOMHNDBGAED MNODNKMNJDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x62006C0", Offset = "0x61FF4C0", VA = "0x1862006C0", Slot = "19")]
	public override int DIAEOPBNAHO(AOMHNDBGAED MNODNKMNJDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x61FFFE0", Offset = "0x61FEDE0", VA = "0x1861FFFE0", Slot = "20")]
	public override void CJAIIEKCIKD(AOMHNDBGAED MNODNKMNJDN, OGCJDFNDACA DNGMPAADFAG, int BBLMKCECEOO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x61FFF10", Offset = "0x61FED10", VA = "0x1861FFF10", Slot = "21")]
	public override OKJPIDOHDOO BGHMNEIEBLC()
	{
		return default(OKJPIDOHDOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6201360", Offset = "0x6200160", VA = "0x186201360", Slot = "23")]
	public override BLCNPGKNBKK ONFLIDOACPH()
	{
		return default(BLCNPGKNBKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x62008B0", Offset = "0x61FF6B0", VA = "0x1862008B0", Slot = "24")]
	public override EGBGHEPHCBF JHLGNAIDOLE(AOMHNDBGAED MNODNKMNJDN, JobHandle DPDOHIMELGE)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private MaterialPropertyBlock IFIFHOIEHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private MNOFKCEHHIH GFNFNFOOGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private List<OKJPIDOHDOO> CKKOBEGDDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private RenderTexture OJANKIKJGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private ComputeBuffer EMBCKJMIEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ComputeShader GLCCJCLCDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Matrix4x4[] BCOIAHBMNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int BIDJKBADPFE;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MeshRenderer FJJDJLNFLHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int AFAPIGDCCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6205900", Offset = "0x6204700", VA = "0x186205900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6205060", Offset = "0x6203E60", VA = "0x186205060")]
		public static List<SkinnedShapeRenderer> Create(GameObject BHODGDEIEBD, List<MNOFKCEHHIH> OCNOFFLDFGP, List<OKJPIDOHDOO> CKKOBEGDDNI, Material DMHFIODFBBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x62052B0", Offset = "0x62040B0", VA = "0x1862052B0")]
		public void Init(MNOFKCEHHIH GFNFNFOOGBL, List<OKJPIDOHDOO> CKKOBEGDDNI, Material DMHFIODFBBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6205850", Offset = "0x6204650", VA = "0x186205850")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x62057A0", Offset = "0x62045A0", VA = "0x1862057A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6205760", Offset = "0x6204560", VA = "0x186205760")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6204E30", Offset = "0x6203C30", VA = "0x186204E30")]
		private void AICDLGMFGPI(ScriptableRenderContext CNBGAPJABKP, Camera[] DKNGHJBBEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6204C70", Offset = "0x6203A70", VA = "0x186204C70")]
		private void AENMJKFIGCK(CommandBuffer LHKPOPIFCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AMOBIGGIKGF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool HNJCMJEIFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material IHKFFAKNLJM();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material BFPMAPEMKBD();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material LLFFEBAGHBC();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LDHMHBEDPLN(DMKFAHLEAKG BCFBMKOFBAH);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GHHHJPALEGK(FPMADANDHIO JMPGDNFCJBD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BNBFMOGAGOO(GameObject GNOEFMFMEOO);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JMFJBOAHGCA(GameObject GNOEFMFMEOO, bool MPEBNLMNFMB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CDPJIMJBIAA
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AMOBIGGIKGF MLPNLAGGHNI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool HNJCMJEIFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61F4E20", Offset = "0x61F3C20", VA = "0x1861F4E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x61F4F50", Offset = "0x61F3D50", VA = "0x1861F4F50")]
	public static void PGIOPKOGNJC(AMOBIGGIKGF AIEFPHDCKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x61F4CD0", Offset = "0x61F3AD0", VA = "0x1861F4CD0")]
	public static Material IHKFFAKNLJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x61F4B30", Offset = "0x61F3930", VA = "0x1861F4B30")]
	public static Material BFPMAPEMKBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x61F4EF0", Offset = "0x61F3CF0", VA = "0x1861F4EF0")]
	public static Material LLFFEBAGHBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x61F4E80", Offset = "0x61F3C80", VA = "0x1861F4E80")]
	public static int LDHMHBEDPLN(DMKFAHLEAKG BCFBMKOFBAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x61F4C60", Offset = "0x61F3A60", VA = "0x1861F4C60")]
	public static int GHHHJPALEGK(FPMADANDHIO JMPGDNFCJBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61F4B90", Offset = "0x61F3990", VA = "0x1861F4B90")]
	public static void BNBFMOGAGOO(GameObject GNOEFMFMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x61F4D30", Offset = "0x61F3B30", VA = "0x1861F4D30")]
	public static void JMFJBOAHGCA(GameObject GNOEFMFMEOO, bool MPEBNLMNFMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class PNMHIMOKGOE : DFDMNPNGDBP, IDisposable, MCBAIFHBCBG
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EAALICIANFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public PNMHIMOKGOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EAALICIANFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x61F8D60", Offset = "0x61F7B60", VA = "0x1861F8D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly DKBOIHGJGOH<KBJIGIFLBPE, KJGONOBNAKH> FOLHHANEEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly DKBOIHGJGOH<LBHGLABJFEP, BGKFGGGHFMO> AFLMEEGCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DKBOIHGJGOH<HGLINNPEOAN, CLABJLDJBIO> BBAOIBCPMBF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public KJGONOBNAKH MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6203720", Offset = "0x6202520", VA = "0x186203720", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public BGKFGGGHFMO MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6203780", Offset = "0x6202580", VA = "0x186203780", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public CLABJLDJBIO MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x62037E0", Offset = "0x62025E0", VA = "0x1862037E0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool PCJDAPMCEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9D2F60", Offset = "0x9D1D60", VA = "0x1809D2F60", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9D30A0", Offset = "0x9D1EA0", VA = "0x1809D30A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6204780", Offset = "0x6203580", VA = "0x186204780")]
	public PNMHIMOKGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6202970", Offset = "0x6201770", VA = "0x186202970", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6204590", Offset = "0x6203390", VA = "0x186204590", Slot = "4")]
	public KBJIGIFLBPE MMIOJCPDNCP(MOOAJDGKIHG FAJCHBCCGOJ)
	{
		return default(KBJIGIFLBPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x62042F0", Offset = "0x62030F0", VA = "0x1862042F0", Slot = "5")]
	public KBJIGIFLBPE MMIOJCPDNCP(MOOAJDGKIHG FAJCHBCCGOJ, bool MLBNACLMJEJ)
	{
		return default(KBJIGIFLBPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6202B10", Offset = "0x6201910", VA = "0x186202B10", Slot = "6")]
	public void GHNAKHJOHLG(KBJIGIFLBPE BHODGDEIEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6203080", Offset = "0x6201E80", VA = "0x186203080", Slot = "7")]
	public void ILKKONNJNFO(KBJIGIFLBPE BHODGDEIEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6202470", Offset = "0x6201270", VA = "0x186202470", Slot = "8")]
	public LBHGLABJFEP CNKPGFAEMMH(KBJIGIFLBPE BHODGDEIEBD, HKIABLCGFLA FAJCHBCCGOJ)
	{
		return default(LBHGLABJFEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6201F70", Offset = "0x6200D70", VA = "0x186201F70", Slot = "9")]
	public LBHGLABJFEP AKGNMJGGKBP(KBJIGIFLBPE BHODGDEIEBD, DONBKONECPJ FAJCHBCCGOJ)
	{
		return default(LBHGLABJFEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6203E70", Offset = "0x6202C70", VA = "0x186203E70", Slot = "11")]
	public void LMKLOFHOKKO(LBHGLABJFEP MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6203410", Offset = "0x6202210", VA = "0x186203410", Slot = "10")]
	public void ILOCBBDADHG(LBHGLABJFEP MGNBGAKGHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6202D90", Offset = "0x6201B90", VA = "0x186202D90", Slot = "20")]
	public IEnumerable<Renderer> GOLBIEDKAHN(KBJIGIFLBPE BHODGDEIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6204270", Offset = "0x6203070", VA = "0x186204270", Slot = "12")]
	public HGLINNPEOAN MBMDPLPNMJI(KGOHMAFCOHC FAJCHBCCGOJ)
	{
		return default(HGLINNPEOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x62045A0", Offset = "0x62033A0", VA = "0x1862045A0", Slot = "14")]
	public void OONILFAMIJK(HGLINNPEOAN GEMFDDAIOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6204610", Offset = "0x6203410", VA = "0x186204610", Slot = "16")]
	public Task PFMGLJNDCLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6202E00", Offset = "0x6201C00", VA = "0x186202E00", Slot = "17")]
	public Task HBNMJIPMPGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6202F60", Offset = "0x6201D60", VA = "0x186202F60", Slot = "18")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EAALICIANFG))]
	public Task IHKMCGGBPDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6203690", Offset = "0x6202490", VA = "0x186203690", Slot = "19")]
	public void JPNPHPGCFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6201F10", Offset = "0x6200D10", VA = "0x186201F10", Slot = "13")]
	public void AFJJFPJHLOG(HGLINNPEOAN GEMFDDAIOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6203840", Offset = "0x6202640", VA = "0x186203840", Slot = "25")]
	public FAODENCLCHB LFDOEOPNCNK(OKJPIDOHDOO GEDCKAADLAM, IEnumerable<LBHGLABJFEP> AFLMEEGCHPC, int IPCPJEMBHMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MNOFKCEHHIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private struct HHNFNNIFIJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public OGCJDFNDACA CJKFPOKKCKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public OKJPIDOHDOO BEEKCCPBKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int DEIFPCPBBEA;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FEIOBNNKAOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public MNOFKCEHHIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AOMHNDBGAED lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public List<HHNFNNIFIJH> boneMeshInfos;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FEIOBNNKAOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CJDEPDOACMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public JIAHFJAFHAI combinedMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public FEIOBNNKAOB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CJDEPDOACMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x61F4FA0", Offset = "0x61F3DA0", VA = "0x1861F4FA0")]
		internal JobHandle GDMKBDPCNLA()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x61F5180", Offset = "0x61F3F80", VA = "0x1861F5180")]
		internal void OCHOGLINPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x61F5010", Offset = "0x61F3E10", VA = "0x1861F5010")]
		internal void LIFPEAGGINF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private int[] LAFPKPELCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private OLGPNINBMIG AFIGMMOBDFP;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static Matrix4x4 NOHIDEODFML;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh GEIJEKOFJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B90", Offset = "0x7F0990", VA = "0x1807F1B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NAEBGGCKKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x86DAD0", Offset = "0x86C8D0", VA = "0x18086DAD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B10", Offset = "0x7F0910", VA = "0x1807F1B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x61FD820", Offset = "0x61FC620", VA = "0x1861FD820")]
	public void AENMJKFIGCK(List<OKJPIDOHDOO> GPDNCPJNJGC, Matrix4x4[] DLONAFFKNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x61FDC00", Offset = "0x61FCA00", VA = "0x1861FDC00")]
	public static List<MNOFKCEHHIH> FLOGCKGNDEE(List<KJGONOBNAKH> MKKGMLAGHOC, AOMHNDBGAED MNODNKMNJDN, Bounds INLPHPEDOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x61FE240", Offset = "0x61FD040", VA = "0x1861FE240")]
	private JobHandle NBNFEEAINLH(JIAHFJAFHAI IPFCFLIIFHJ, int CFGPFNEKOCA, int POAKEOJICOM, AOMHNDBGAED MNODNKMNJDN, List<HHNFNNIFIJH> COOMKLJMCIM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x61FDA80", Offset = "0x61FC880", VA = "0x1861FDA80")]
	private void CNMEMLJPHMN(List<HHNFNNIFIJH> COOMKLJMCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x61FE760", Offset = "0x61FD560", VA = "0x1861FE760")]
	private MNOFKCEHHIH(List<HHNFNNIFIJH> COOMKLJMCIM, int CFGPFNEKOCA, int POAKEOJICOM, AOMHNDBGAED MNODNKMNJDN, Bounds INLPHPEDOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x61FDB90", Offset = "0x61FC990", VA = "0x1861FDB90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CLABJLDJBIO : HONKIBAEKII
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class INKIHMJELAJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CLABJLDJBIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<SkinnedShapeRenderer>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private SkinnedShapeRenderer <r>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xD2EFB0", Offset = "0xD2DDB0", VA = "0x180D2EFB0")]
		[DebuggerHidden]
		public INKIHMJELAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x61FBF20", Offset = "0x61FAD20", VA = "0x1861FBF20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x61FBC20", Offset = "0x61FAA20", VA = "0x1861FBC20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x61FBBD0", Offset = "0x61FA9D0", VA = "0x1861FBBD0")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x61FBEE0", Offset = "0x61FACE0", VA = "0x1861FBEE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x61FBE40", Offset = "0x61FAC40", VA = "0x1861FBE40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x61FBE40", Offset = "0x61FAC40", VA = "0x1861FBE40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly KGOHMAFCOHC DMIOHFCCAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MCBAIFHBCBG FFHOPBCLFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private PLHIMPMCJAG NLOELMHHLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private List<MNOFKCEHHIH> HIHBHCHGEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private List<MNOFKCEHHIH> MMGFFEELKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GameObject BHDFKPKFDAJ;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x61F64D0", Offset = "0x61F52D0", VA = "0x1861F64D0")]
	public static CLABJLDJBIO PDKCIMLOIFD(KGOHMAFCOHC FAJCHBCCGOJ, MCBAIFHBCBG FFHOPBCLFDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x61F6640", Offset = "0x61F5440", VA = "0x1861F6640")]
	private CLABJLDJBIO(KGOHMAFCOHC FAJCHBCCGOJ, MCBAIFHBCBG FFHOPBCLFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x61F5CE0", Offset = "0x61F4AE0", VA = "0x1861F5CE0")]
	public void LLJCJCMKKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x61F5C70", Offset = "0x61F4A70", VA = "0x1861F5C70")]
	[IteratorStateMachine(typeof(INKIHMJELAJ))]
	public IEnumerable<Renderer> HJGGAMFNPMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x61F51C0", Offset = "0x61F3FC0", VA = "0x1861F51C0", Slot = "4")]
	public void HBIINFGFJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x61F61F0", Offset = "0x61F4FF0", VA = "0x1861F61F0")]
	private void MDHDPJGPCKF(Vector3 IGKKJDCLMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x61F6290", Offset = "0x61F5090", VA = "0x1861F6290")]
	public void OAHLJJFNGDE()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
