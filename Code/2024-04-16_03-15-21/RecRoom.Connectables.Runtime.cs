using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : JICBOCPMGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6099D10", Offset = "0x6098F10", VA = "0x186099D10", Slot = "4")]
		public override void OEPCKJDAMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : BHGNIPDAAHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private PLDKANGDDDP bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private PLDKANGDDDP bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60A3EE0", Offset = "0x60A30E0", VA = "0x1860A3EE0", Slot = "5")]
		public override void NFPDFNDEAED(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60A3D70", Offset = "0x60A2F70", VA = "0x1860A3D70")]
		private void LFIGPBIMHMM(NFPJJEAKHFP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60A3C00", Offset = "0x60A2E00", VA = "0x1860A3C00")]
		private void DDIJAKNIHON(NFPJJEAKHFP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60A3F20", Offset = "0x60A3120", VA = "0x1860A3F20", Slot = "6")]
		public override void PLBJNCNNDBL(NFPJJEAKHFP registry, [In] MFEOBGFJEOO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "8")]
		public override void AKMCFODBHPA(AJJICLPDKOG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60A4260", Offset = "0x60A3460", VA = "0x1860A4260")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class MCHHENPDALC : EIHDFIIPGIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class HMLNNNEMDAB : IEnumerable<HCIPGPHIAME>, IEnumerable, IEnumerator<HCIPGPHIAME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HCIPGPHIAME <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private AGNLOFKLMDO localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AGNLOFKLMDO <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MCHHENPDALC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private MMHEDGNKOFC <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private BECPEMBNPON.OKKAKKFPOAD <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HCIPGPHIAME System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80AF90", Offset = "0x80A190", VA = "0x18080AF90")]
		[DebuggerHidden]
		public HMLNNNEMDAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6095A50", Offset = "0x6094C50", VA = "0x186095A50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6095590", Offset = "0x6094790", VA = "0x186095590", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6095570", Offset = "0x6094770", VA = "0x186095570")]
		private void KNOPPBKNOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6095A00", Offset = "0x6094C00", VA = "0x186095A00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6095950", Offset = "0x6094B50", VA = "0x186095950", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HCIPGPHIAME> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6095950", Offset = "0x6094B50", VA = "0x186095950", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IOBNAOMELJK AOBMECMACLL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly IOBNAOMELJK DGKLONJNBDH;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly IOBNAOMELJK PMAEGBCEDFG;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly IOBNAOMELJK PEMGNBLPCIH;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IOBNAOMELJK CMGBHPBIJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private ICJJEBPEMBG HLAOCOMOEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EGKJBCGMGIF BDJFCJPIEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private PLFDPOJPHML KOENMOPFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MAPIANJJCDK CHEOCJAKLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CBAJJGAKEPF LNPJHELDICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CGMAJAEAEJJ HHEDJECGCCM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OIOOJDHLJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C6450", Offset = "0x7C5650", VA = "0x1807C6450", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C60D0", Offset = "0x7C52D0", VA = "0x1807C60D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AEEKHJFGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<HCIPGPHIAME, HCIPGPHIAME> JNFOAJFANJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x609C3B0", Offset = "0x609B5B0", VA = "0x18609C3B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x609DBC0", Offset = "0x609CDC0", VA = "0x18609DBC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<HCIPGPHIAME, HCIPGPHIAME> BPFEDIEBKFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x609E6A0", Offset = "0x609D8A0", VA = "0x18609E6A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x609E4C0", Offset = "0x609D6C0", VA = "0x18609E4C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<HCIPGPHIAME, HCIPGPHIAME, HCIPGPHIAME> LFINGJBEDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x609C110", Offset = "0x609B310", VA = "0x18609C110", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x609C460", Offset = "0x609B660", VA = "0x18609C460", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x609ED10", Offset = "0x609DF10", VA = "0x18609ED10")]
	public MCHHENPDALC(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x609DF20", Offset = "0x609D120", VA = "0x18609DF20", Slot = "12")]
	public void MEJEOBIHPJE(GameObject CHIOFKOKCNE, FEPCKAFNNNP GGNALOBOPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x609C1C0", Offset = "0x609B3C0", VA = "0x18609C1C0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x608F9F0", Offset = "0x608EBF0", VA = "0x18608F9F0", Slot = "22")]
	public bool NNOFNPJOBPO(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x609CCD0", Offset = "0x609BED0", VA = "0x18609CCD0")]
	private void GGGEAPKKHNB(AGNLOFKLMDO HDMHICGLKND, AGNLOFKLMDO FHAIJBADANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x609DD00", Offset = "0x609CF00", VA = "0x18609DD00")]
	private void LIJALCKAJBE(AGNLOFKLMDO HDMHICGLKND, AGNLOFKLMDO GOJHKLOFOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x609E190", Offset = "0x609D390", VA = "0x18609E190")]
	private void MLGDCJHMNHK(AGNLOFKLMDO HDMHICGLKND, AGNLOFKLMDO GOJHKLOFOOA, AGNLOFKLMDO FHAIJBADANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x609B9F0", Offset = "0x609ABF0", VA = "0x18609B9F0")]
	private void DANBACNFDJB(AGNLOFKLMDO HDMHICGLKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "13")]
	public void MOLHGBBEJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x609E750", Offset = "0x609D950", VA = "0x18609E750", Slot = "14")]
	public void OEPCKJDAMHI(HCIPGPHIAME LJBKINELJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "15")]
	public void CIPMPDGKPOP(HCIPGPHIAME LJBKINELJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x609BFB0", Offset = "0x609B1B0", VA = "0x18609BFB0", Slot = "17")]
	public void DJAPAEPAIME(HCIPGPHIAME LJBKINELJNM, HCIPGPHIAME NPBLALLIKJP, Vector3 OCBBPFAEPEN, Quaternion IKIEOLKACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x609BE70", Offset = "0x609B070", VA = "0x18609BE70")]
	public void DJAPAEPAIME(AGNLOFKLMDO MMGOAMJJJHK, AGNLOFKLMDO NPBLALLIKJP, Vector3 OCBBPFAEPEN, Quaternion IKIEOLKACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x609D3B0", Offset = "0x609C5B0", VA = "0x18609D3B0")]
	public void IELGPKHBENG(HCIPGPHIAME LJBKINELJNM, float MMALJBFNOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x609C6A0", Offset = "0x609B8A0", VA = "0x18609C6A0", Slot = "18")]
	public void ELLECJMEDNJ(HCIPGPHIAME FEGENNPGEII, int MOFOKGONDBM, HCIPGPHIAME OKALFKBCAJB, int JGJBKGLINOO, Vector3 OCBBPFAEPEN, Quaternion IKIEOLKACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x609D170", Offset = "0x609C370", VA = "0x18609D170")]
	private float IDACEFBBMJD(AGNLOFKLMDO MMGOAMJJJHK, AGNLOFKLMDO DLAKBCKOLFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x609C570", Offset = "0x609B770", VA = "0x18609C570")]
	public void ELLECJMEDNJ(AGNLOFKLMDO MMGOAMJJJHK, AGNLOFKLMDO DLAKBCKOLFN, Vector3 OCBBPFAEPEN, Quaternion IKIEOLKACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x609C510", Offset = "0x609B710", VA = "0x18609C510")]
	public void ELLECJMEDNJ(AGNLOFKLMDO MMGOAMJJJHK, AGNLOFKLMDO DLAKBCKOLFN, Vector3 OCBBPFAEPEN, Quaternion IKIEOLKACCC, float MMALJBFNOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x609D4A0", Offset = "0x609C6A0", VA = "0x18609D4A0", Slot = "19")]
	public void ILLIAMENDFN(HCIPGPHIAME LJBKINELJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x609CEE0", Offset = "0x609C0E0", VA = "0x18609CEE0")]
	public bool ICKIEIFODFM(AGNLOFKLMDO NAJMDMAIPJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x609AA00", Offset = "0x6099C00", VA = "0x18609AA00", Slot = "16")]
	public void BBKPDPGCCKO(HCIPGPHIAME LJBKINELJNM, HashSet<HCIPGPHIAME> AAHNLOKJEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "20")]
	public KAJMFBHLNPJ BCOFCCOCJCL(bool DNPDOKCHPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "21")]
	public KAJMFBHLNPJ EEHHNALMEPB(HashSet<Guid> CPPLHEPLDPB, bool DNPDOKCHPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x609D670", Offset = "0x609C870", VA = "0x18609D670", Slot = "23")]
	public void JCPMBFEICFP(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x609D9C0", Offset = "0x609CBC0", VA = "0x18609D9C0", Slot = "24")]
	public void JNKBHBJLNGD(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x609E570", Offset = "0x609D770", VA = "0x18609E570", Slot = "25")]
	public void NLIPNHKIFDN(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x609A6B0", Offset = "0x60998B0", VA = "0x18609A6B0")]
	private void AHAOJMPKCHE(AGNLOFKLMDO MMGOAMJJJHK, AGNLOFKLMDO DLAKBCKOLFN, Vector3 OCBBPFAEPEN, Quaternion IKIEOLKACCC, float MMALJBFNOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x609AC10", Offset = "0x6099E10", VA = "0x18609AC10")]
	private void BIFCGIHFHHH(AGNLOFKLMDO MMGOAMJJJHK, AGNLOFKLMDO EBKJLIBKJMN, Vector3 OCBBPFAEPEN, Quaternion IKIEOLKACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x609CC60", Offset = "0x609BE60", VA = "0x18609CC60")]
	private void FNDABNCIOAH(AGNLOFKLMDO MMGOAMJJJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x609DC70", Offset = "0x609CE70", VA = "0x18609DC70")]
	[IteratorStateMachine(typeof(HMLNNNEMDAB))]
	public IEnumerable<HCIPGPHIAME> KMGAMHHPMHB(AGNLOFKLMDO NAJMDMAIPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x609C7F0", Offset = "0x609B9F0", VA = "0x18609C7F0")]
	internal HCIPGPHIAME FIKKKGBOBGD(AGNLOFKLMDO NAJMDMAIPJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x609E3F0", Offset = "0x609D5F0", VA = "0x18609E3F0")]
	internal AGNLOFKLMDO NHLKPLAOBED(HCIPGPHIAME LJBKINELJNM)
	{
		return default(AGNLOFKLMDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x609B1A0", Offset = "0x609A3A0", VA = "0x18609B1A0")]
	private bool CKOHJOJGNNI(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x609D440", Offset = "0x609C640", VA = "0x18609D440")]
	private bool IEOEDABEBFE(KDHAEKBIJNF AFEJHPJDDFE, [Out] HCIPGPHIAME DLAKBCKOLFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x609C920", Offset = "0x609BB20", VA = "0x18609C920")]
	private HCIPGPHIAME FIKKKGBOBGD(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x609B020", Offset = "0x609A220", VA = "0x18609B020")]
	private HCIPGPHIAME BLGMLBFNOCK(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x609EA50", Offset = "0x609DC50", VA = "0x18609EA50")]
	private HCIPGPHIAME OIPBEMNBJCH(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6092D70", Offset = "0x6091F70", VA = "0x186092D70")]
	private static Guid BMEJFDMJBPK(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x609B770", Offset = "0x609A970", VA = "0x18609B770")]
	private string CMBGLKGHKJF(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x609B860", Offset = "0x609AA60", VA = "0x18609B860")]
	private void CPKFAINHBNA(HCIPGPHIAME MMGOAMJJJHK, HCIPGPHIAME EBKJLIBKJMN, RigidTransform JDAELFCGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x609DA30", Offset = "0x609CC30", VA = "0x18609DA30")]
	private void JOHLNADADIM(HCIPGPHIAME EBKJLIBKJMN, HCIPGPHIAME MMGOAMJJJHK, RigidTransform JDAELFCGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x609D610", Offset = "0x609C810", VA = "0x18609D610")]
	private void ILOCAOCACEB(HCIPGPHIAME OEIDFPFMBNF, HCIPGPHIAME MMGOAMJJJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x609D220", Offset = "0x609C420", VA = "0x18609D220")]
	private void IEDBBHLPHAL(HCIPGPHIAME MMGOAMJJJHK, HCIPGPHIAME DLAKBCKOLFN, RigidTransform JDAELFCGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x609E590", Offset = "0x609D790", VA = "0x18609E590")]
	private void OACCGAHGGHB(AGNLOFKLMDO NAJMDMAIPJN, HCIPGPHIAME LJBKINELJNM, AGNLOFKLMDO GOJHKLOFOOA, AGNLOFKLMDO FHAIJBADANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x609D6E0", Offset = "0x609C8E0", VA = "0x18609D6E0")]
	private void JIHCEBLFMLK(AGNLOFKLMDO NAJMDMAIPJN, HCIPGPHIAME LJBKINELJNM, HCIPGPHIAME DNPEEDPFKON, HCIPGPHIAME JEPODBIJBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DJAGBGKPOAC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LBGALFBKAIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JGBEMAKPOMJ container;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public LBGALFBKAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6097DA0", Offset = "0x6096FA0", VA = "0x186097DA0")]
		internal MCHHENPDALC NGINENBJFBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6090830", Offset = "0x608FA30", VA = "0x186090830")]
	public static void OKLAJENNLIO(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60907E0", Offset = "0x608F9E0", VA = "0x1860907E0")]
	public static void LOGLIDHMHFA(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class EHAMEEMCCLP : KEMPMJBFBED, BLDMKAJAHHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly RigidbodyEx IFDOJINLLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MCHHENPDALC NPPOBNKIBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CKJAAFPCBCA CHGDCHHOLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly JEKKBECMHML CHEOCJAKLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly GBBGDCCNHGF[] FFPNMGGCCGA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(AGNLOFKLMDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HCIPGPHIAME OLKNHMBIOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6092490", Offset = "0x6091690", VA = "0x186092490", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HCIPGPHIAME JFFPPMKBHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6091CC0", Offset = "0x6090EC0", VA = "0x186091CC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 PPJDCEKKIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6091C60", Offset = "0x6090E60", VA = "0x186091C60", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion DNJNKDAAGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6091BA0", Offset = "0x6090DA0", VA = "0x186091BA0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OIJBDEBPNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60915F0", Offset = "0x60907F0", VA = "0x1860915F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<HCIPGPHIAME> KGNPKHKFINM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6091B70", Offset = "0x6090D70", VA = "0x186091B70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool KLMNEMKCMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x87F490", Offset = "0x87E690", VA = "0x18087F490", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x87F5B0", Offset = "0x87E7B0", VA = "0x18087F5B0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6092690", Offset = "0x6091890", VA = "0x186092690", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject MCONHIMIFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x233EB40", Offset = "0x233DD40", VA = "0x18233EB40", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60923D0", Offset = "0x60915D0", VA = "0x1860923D0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid OAKPAJHGACL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60924F0", Offset = "0x60916F0", VA = "0x1860924F0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FAKGILKPOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x60925D0", Offset = "0x60917D0", VA = "0x1860925D0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool KPEFBHEFFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JGHPEOAFCLE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60909B0", Offset = "0x608FBB0", VA = "0x1860909B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event IFBDAFNPONB DIBNMCMMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6091F70", Offset = "0x6091170", VA = "0x186091F70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6090C40", Offset = "0x608FE40", VA = "0x186090C40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event IFBDAFNPONB CJFMKCMKJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6090E20", Offset = "0x6090020", VA = "0x186090E20", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6091C00", Offset = "0x6090E00", VA = "0x186091C00", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event IFBDAFNPONB FNBNCHOFBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6091950", Offset = "0x6090B50", VA = "0x186091950", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6090CA0", Offset = "0x608FEA0", VA = "0x186090CA0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event JLPLMCKMEPL AMBHMMKCGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60919B0", Offset = "0x6090BB0", VA = "0x1860919B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60918B0", Offset = "0x6090AB0", VA = "0x1860918B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60922D0", Offset = "0x60914D0", VA = "0x1860922D0")]
	public EHAMEEMCCLP(AGNLOFKLMDO HPEEIPMMJAC, RigidbodyEx IFDOJINLLBE, CKJAAFPCBCA CHGDCHHOLPL, GBBGDCCNHGF[] FFPNMGGCCGA, JEKKBECMHML CHEOCJAKLBN, EIHDFIIPGIF NPPOBNKIBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6091F40", Offset = "0x6091140", VA = "0x186091F40", Slot = "19")]
	public void NLCNDFBLMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "21")]
	public void DGDFFJJDOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5F0E790", Offset = "0x5F0D990", VA = "0x185F0E790", Slot = "22")]
	public void ODIONKGABBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60915A0", Offset = "0x60907A0", VA = "0x1860915A0", Slot = "20")]
	public void EOFOFFHJEOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6091D30", Offset = "0x6090F30", VA = "0x186091D30", Slot = "25")]
	public void NJPFEILDBHE(int HDIDPBFFDAK, HCIPGPHIAME OKALFKBCAJB, int DGKMHPIAHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6091A50", Offset = "0x6090C50", VA = "0x186091A50", Slot = "26")]
	public void JPIAMKBHOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6091FD0", Offset = "0x60911D0", VA = "0x186091FD0", Slot = "27")]
	public void PCOJPBEJPOI(int HDIDPBFFDAK, HCIPGPHIAME FEGENNPGEII, int PLPLNPOIJIE, [Optional] Vector3? DBNJPCOJKJH, [Optional] Quaternion? MJHGCDJKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6090D00", Offset = "0x608FF00", VA = "0x186090D00", Slot = "28")]
	public void BLGGJFDEPIO(HCIPGPHIAME FEGENNPGEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6091190", Offset = "0x6090390", VA = "0x186091190", Slot = "31")]
	public void EMKIHHDADBE(Vector3 BOECMGJHDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6090E80", Offset = "0x6090080", VA = "0x186090E80", Slot = "29")]
	public void DFHFKLHIOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6090A00", Offset = "0x608FC00", VA = "0x186090A00", Slot = "30")]
	public void BBLLLCAEBDN(int MBGANDEDPDN, Vector3 CCDONDNKELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60917E0", Offset = "0x60909E0", VA = "0x1860917E0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int HDIDPBFFDAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x60916B0", Offset = "0x60908B0", VA = "0x1860916B0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int HDIDPBFFDAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x83E4B0", Offset = "0x83D6B0", VA = "0x18083E4B0", Slot = "42")]
	public Color GetConnectionSlotColor(int HDIDPBFFDAK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6090D80", Offset = "0x608FF80", VA = "0x186090D80", Slot = "43")]
	public bool CanConnectTo(int HDIDPBFFDAK, HCIPGPHIAME BACCKADKGEO, int NBHAGIEFGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "44")]
	public void ParentChanged(int HDIDPBFFDAK, HCIPGPHIAME PNBHIMGPJAF, int PPBPBNPIBIO, Vector3 NCNFEPBGDBA, Quaternion CHOPAKEIOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "45")]
	public void ChildAdded(int HDIDPBFFDAK, HCIPGPHIAME NPOGCEAKDPH, int BBNOBLDNLBM, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "46")]
	public void ChildRemoved(int HDIDPBFFDAK, HCIPGPHIAME BCKDIGNEINI, int CHNKCNKFCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "47")]
	public void ConnectionModified(int HDIDPBFFDAK, HCIPGPHIAME OKALFKBCAJB, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60922B0", Offset = "0x60914B0", VA = "0x1860922B0", Slot = "48")]
	public void RootChanged(HCIPGPHIAME IDNIEPKIDIK, HCIPGPHIAME HKDLHCGLGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6090BF0", Offset = "0x608FDF0", VA = "0x186090BF0", Slot = "23")]
	public void BCCCNJEOACA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6091B20", Offset = "0x6090D20", VA = "0x186091B20", Slot = "24")]
	public void LBNPMCKFANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6091660", Offset = "0x6090860", VA = "0x186091660")]
	private void GBPGLFPDIIG(bool LNLOGKBGCIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[GENMAJFODJG(typeof(MIAKDELDJJK), new string[] { })]
public class BAKMOGHNLFJ : MIAKDELDJJK, BFELDJAKDCH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FIAMFILGMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public BAKMOGHNLFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public BECPEMBNPON localIds;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public FIAMFILGMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6092830", Offset = "0x6091A30", VA = "0x186092830")]
		internal void APMPMJBOHFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly IOBNAOMELJK AOBMECMACLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[POCNIOGLKOO]
	private HFDCOAPGKMP DPHCKILALEN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object DCMEICJBPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x608DD60", Offset = "0x608CF60", VA = "0x18608DD60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x608DD10", Offset = "0x608CF10", VA = "0x18608DD10", Slot = "6")]
	public void InitReferences(NKHDFGLOEFE HHEDJECGCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x608DBA0", Offset = "0x608CDA0", VA = "0x18608DBA0", Slot = "5")]
	public void FDLCLEHGAKB(BECPEMBNPON BFPFIMOOKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BAKMOGHNLFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[GENMAJFODJG(typeof(EIHDFIIPGIF), new string[] { "Ignore", "Mock" })]
public class AGGPKHJNKMO : EIHDFIIPGIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OIOOJDHLJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AEEKHJFGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<HCIPGPHIAME, HCIPGPHIAME> JNFOAJFANJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x608D830", Offset = "0x608CA30", VA = "0x18608D830", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x608D990", Offset = "0x608CB90", VA = "0x18608D990", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<HCIPGPHIAME, HCIPGPHIAME> BPFEDIEBKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x608DAF0", Offset = "0x608CCF0", VA = "0x18608DAF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x608DA40", Offset = "0x608CC40", VA = "0x18608DA40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<HCIPGPHIAME, HCIPGPHIAME, HCIPGPHIAME> LFINGJBEDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x608D780", Offset = "0x608C980", VA = "0x18608D780", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x608D8E0", Offset = "0x608CAE0", VA = "0x18608D8E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "12")]
	public void MEJEOBIHPJE(GameObject CHIOFKOKCNE, FEPCKAFNNNP GGNALOBOPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "13")]
	public void MOLHGBBEJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "14")]
	public void OEPCKJDAMHI(HCIPGPHIAME LJBKINELJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "15")]
	public void CIPMPDGKPOP(HCIPGPHIAME LJBKINELJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "16")]
	public void BBKPDPGCCKO(HCIPGPHIAME LJBKINELJNM, HashSet<HCIPGPHIAME> AAHNLOKJEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "17")]
	public void DJAPAEPAIME(HCIPGPHIAME LJBKINELJNM, HCIPGPHIAME NPBLALLIKJP, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "18")]
	public void ELLECJMEDNJ(HCIPGPHIAME LJBKINELJNM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "19")]
	public void ILLIAMENDFN(HCIPGPHIAME LJBKINELJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "20")]
	public KAJMFBHLNPJ BCOFCCOCJCL(bool DNPDOKCHPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "21")]
	public KAJMFBHLNPJ EEHHNALMEPB(HashSet<Guid> CPPLHEPLDPB, bool DNPDOKCHPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "22")]
	public bool NNOFNPJOBPO(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "23")]
	public void JCPMBFEICFP(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "24")]
	public void JNKBHBJLNGD(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "25")]
	public void NLIPNHKIFDN(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public AGGPKHJNKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HCIPGPHIAME : BLDMKAJAHHH, IEquatable<HCIPGPHIAME>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BLDMKAJAHHH
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HCIPGPHIAME OLKNHMBIOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject MCONHIMIFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string FLDBLPHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid OAKPAJHGACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int FAKGILKPOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	AGNLOFKLMDO PKFAHLINCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KPEFBHEFFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int HDIDPBFFDAK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int HDIDPBFFDAK);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int HDIDPBFFDAK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int HDIDPBFFDAK, HCIPGPHIAME BACCKADKGEO, int FKDIGCBCHOA);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int HDIDPBFFDAK, HCIPGPHIAME PNBHIMGPJAF, int PPBPBNPIBIO, Vector3 NCNFEPBGDBA, Quaternion CHOPAKEIOEB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int HDIDPBFFDAK, HCIPGPHIAME NPOGCEAKDPH, int BBNOBLDNLBM, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int HDIDPBFFDAK, HCIPGPHIAME BCKDIGNEINI, int CHNKCNKFCIM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int HDIDPBFFDAK, HCIPGPHIAME OKALFKBCAJB, int FKDMGFIILMK, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(HCIPGPHIAME IDNIEPKIDIK, HCIPGPHIAME HKDLHCGLGFK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ILGOHFDJPOE(GDOPADDLIHF.OMRoom)]
public interface EIHDFIIPGIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool OIOOJDHLJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool AEEKHJFGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HCIPGPHIAME, HCIPGPHIAME> JNFOAJFANJB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HCIPGPHIAME, HCIPGPHIAME> BPFEDIEBKFM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<HCIPGPHIAME, HCIPGPHIAME, HCIPGPHIAME> LFINGJBEDFJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MEJEOBIHPJE(GameObject CHIOFKOKCNE, FEPCKAFNNNP GGNALOBOPON);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MOLHGBBEJOJ();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OEPCKJDAMHI(HCIPGPHIAME LJBKINELJNM);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CIPMPDGKPOP(HCIPGPHIAME LJBKINELJNM);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BBKPDPGCCKO(HCIPGPHIAME LJBKINELJNM, HashSet<HCIPGPHIAME> AAHNLOKJEKK);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DJAPAEPAIME(HCIPGPHIAME LJBKINELJNM, HCIPGPHIAME NPBLALLIKJP, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ELLECJMEDNJ(HCIPGPHIAME LJBKINELJNM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ILLIAMENDFN(HCIPGPHIAME LJBKINELJNM);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KAJMFBHLNPJ BCOFCCOCJCL(bool DNPDOKCHPHN);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	KAJMFBHLNPJ EEHHNALMEPB(HashSet<Guid> CPPLHEPLDPB, bool DNPDOKCHPHN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NNOFNPJOBPO(KDHAEKBIJNF AFEJHPJDDFE);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JCPMBFEICFP(KAJMFBHLNPJ AOFKLCLPNLP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JNKBHBJLNGD(KAJMFBHLNPJ AOFKLCLPNLP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NLIPNHKIFDN(KAJMFBHLNPJ AOFKLCLPNLP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MAPIANJJCDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MPGNAPCPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HCIPGPHIAME OIPBEMNBJCH(int IGODBLNLJAI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HCIPGPHIAME BLGMLBFNOCK(Guid CJKAJLAIGAP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OPECMJJJBAK(HCIPGPHIAME LJBKINELJNM);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KPJPFGFAHAE();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AEAALOGLOLE(HCIPGPHIAME CHGDCHHOLPL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
public interface JEKKBECMHML
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGHPEOAFCLE(CKJAAFPCBCA CHGDCHHOLPL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GHLKLMOPIHB(CKJAAFPCBCA CHGDCHHOLPL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string EFGBMFABOJN(CKJAAFPCBCA CHGDCHHOLPL);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid NPHAFDJNKLK(CKJAAFPCBCA CHGDCHHOLPL);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int APLDGJHNNLN(CKJAAFPCBCA CHGDCHHOLPL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DGCGKFHIIJD(CKJAAFPCBCA CHGDCHHOLPL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void IFBDAFNPONB(HCIPGPHIAME FEGENNPGEII, int KPLPIBIMJJF, HCIPGPHIAME OKALFKBCAJB, int LDLPDELOKEC, [Optional] Vector3? DBNJPCOJKJH, [Optional] Quaternion? MJHGCDJKELD);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void JLPLMCKMEPL(HCIPGPHIAME IDNIEPKIDIK, HCIPGPHIAME HKDLHCGLGFK);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CKJAAFPCBCA : HCIPGPHIAME, BLDMKAJAHHH, IEquatable<HCIPGPHIAME>
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KEMPMJBFBED : BLDMKAJAHHH
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HCIPGPHIAME JFFPPMKBHED
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<HCIPGPHIAME> KGNPKHKFINM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 PPJDCEKKIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion DNJNKDAAGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool OIJBDEBPNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool KLMNEMKCMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event IFBDAFNPONB DIBNMCMMCAF;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event IFBDAFNPONB CJFMKCMKJFL;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event IFBDAFNPONB FNBNCHOFBFP;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event JLPLMCKMEPL AMBHMMKCGPB;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NLCNDFBLMIC();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EOFOFFHJEOJ();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DGDFFJJDOJG();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ODIONKGABBI();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BCCCNJEOACA();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LBNPMCKFANC();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NJPFEILDBHE(int HDIDPBFFDAK, HCIPGPHIAME OKALFKBCAJB, int DGKMHPIAHDD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JPIAMKBHOAN();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PCOJPBEJPOI(int HDIDPBFFDAK, HCIPGPHIAME FEGENNPGEII, int PLPLNPOIJIE, [Optional] Vector3? DBNJPCOJKJH, [Optional] Quaternion? MJHGCDJKELD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BLGGJFDEPIO(HCIPGPHIAME FEGENNPGEII);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void DFHFKLHIOLP();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BBLLLCAEBDN(int MBGANDEDPDN, Vector3 CCDONDNKELE);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EMKIHHDADBE(Vector3 BOECMGJHDAM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GBBGDCCNHGF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 DBFEHMGGBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FEPCKAFNNNP
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MLBDBAAIBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JOEBNFCNLPI ONOLDMOJBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ConnectableConfigData : ScriptableObject, FEPCKAFNNNP
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x82DA00", Offset = "0x82CC00", VA = "0x18082DA00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JOEBNFCNLPI LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x60906E0", Offset = "0x608F8E0", VA = "0x1860906E0")]
		public static ConnectableConfigData ELGACDLOOKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6090790", Offset = "0x608F990", VA = "0x186090790")]
		public ConnectableConfigData(LegacyConnectableLinkVisual CNEGMBNMAGB, bool ACOBIAAOLPJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CELJGLDLLOJ : IEquatable<CELJGLDLLOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public HCIPGPHIAME LJBKINELJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int JAHEMDLBNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int FKDMGFIILMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Vector3 DBNJPCOJKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Quaternion MJHGCDJKELD;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x60905E0", Offset = "0x608F7E0", VA = "0x1860905E0")]
	public CELJGLDLLOJ(HCIPGPHIAME LJBKINELJNM, int JAHEMDLBNNH, int FKDMGFIILMK, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6090640", Offset = "0x608F840", VA = "0x186090640")]
	public CELJGLDLLOJ(HCIPGPHIAME LJBKINELJNM, int JAHEMDLBNNH, int FKDMGFIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6090560", Offset = "0x608F760", VA = "0x186090560")]
	public CELJGLDLLOJ(HCIPGPHIAME LJBKINELJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x60900F0", Offset = "0x608F2F0", VA = "0x1860900F0", Slot = "4")]
	public bool Equals(CELJGLDLLOJ MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x60901A0", Offset = "0x608F3A0", VA = "0x1860901A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[UnityEngine.Scripting.Preserve]
public class ELIEMEBKCAK : BEIOFMPMCDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform DIFJEPLFOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private JOEBNFCNLPI IHEGPKNHGPP;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5BBCFE0", Offset = "0x5BBC1E0", VA = "0x185BBCFE0", Slot = "4")]
	public void MEJEOBIHPJE(Transform DIFJEPLFOKN, JOEBNFCNLPI IHEGPKNHGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x60926B0", Offset = "0x60918B0", VA = "0x1860926B0", Slot = "5")]
	public JOEBNFCNLPI BCFGAKHLHAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6092770", Offset = "0x6091970", VA = "0x186092770", Slot = "6")]
	public void FHLPKJPMOEO(JOEBNFCNLPI JBAPINAHMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public ELIEMEBKCAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal class OGLDCNFIPOE : IDisposable, FLHDNOMJBLH
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JEOCINCLDAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public HCIPGPHIAME oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HCIPGPHIAME newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public JEOCINCLDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x60968C0", Offset = "0x6095AC0", VA = "0x1860968C0")]
		internal bool LGOPMAIEHJG(AEJBFFDENKG node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly KBJDFFPAKLE CHAMLGPGOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private AFOPDCHMJHO IJNHBBPLFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BDBIBMENDAB ODLGFLFNMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool ACOBIAAOLPJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public AEJBFFDENKG NECEBBLCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x60A1ED0", Offset = "0x60A10D0", VA = "0x1860A1ED0")]
	public bool MGBLPLCHOBG([In] BPJDBMEKNAN MJGHOBDIDHD, bool KBCHMAIMKIH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x60A14B0", Offset = "0x60A06B0", VA = "0x1860A14B0")]
	private bool GNCMJIOFCNA([In] BPJDBMEKNAN MJGHOBDIDHD, bool KBCHMAIMKIH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x60A39A0", Offset = "0x60A2BA0", VA = "0x1860A39A0")]
	public OGLDCNFIPOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60A2A50", Offset = "0x60A1C50", VA = "0x1860A2A50", Slot = "5")]
	public void MEJEOBIHPJE(EIHDFIIPGIF JPFNBECBJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60A2610", Offset = "0x60A1810", VA = "0x1860A2610", Slot = "17")]
	public void KGMOECPLKDM(HGFMJOLDDID CMMPHMKBCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x60A2080", Offset = "0x60A1280", VA = "0x1860A2080", Slot = "12")]
	public void IPHEMBHEMMB(Func<HCIPGPHIAME, bool> DFNCBOLPMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60A2090", Offset = "0x60A1290", VA = "0x1860A2090")]
	private void IPHEMBHEMMB(KBJDFFPAKLE JCCACJKHFKB, Func<HCIPGPHIAME, bool> DFNCBOLPMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x60A1490", Offset = "0x60A0690", VA = "0x1860A1490", Slot = "11")]
	public void GJGECGGEJDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60A06A0", Offset = "0x609F8A0", VA = "0x1860A06A0", Slot = "8")]
	public bool EBCNEPNPBOA(HCIPGPHIAME HFPKLKPMFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60A2CD0", Offset = "0x60A1ED0", VA = "0x1860A2CD0")]
	private bool NAFLIDCDHCL(HCIPGPHIAME ONNDIPAFNHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x60A1E20", Offset = "0x60A1020", VA = "0x1860A1E20")]
	private static bool IIIEIAIEDHL(HCIPGPHIAME ONNDIPAFNHA, KBJDFFPAKLE IIDPMGLMGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x60A0F30", Offset = "0x60A0130", VA = "0x1860A0F30")]
	private void FDLINKHKEBO(Transform ABKEODBPMFK, KBJDFFPAKLE BKLOINJBBEA, KBJDFFPAKLE[] FLKILDNNACA, HCIPGPHIAME FBPCHADAODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x609ED80", Offset = "0x609DF80", VA = "0x18609ED80")]
	private CELJGLDLLOJ ADGGEOJEMOA(Transform JCIJJFDCLHD, CELJGLDLLOJ LLKHLIHHJDH)
	{
		return default(CELJGLDLLOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60A33A0", Offset = "0x60A25A0", VA = "0x1860A33A0")]
	private static bool NCPEHJPLCOB(KBJDFFPAKLE IIDPMGLMGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60A0870", Offset = "0x609FA70", VA = "0x1860A0870")]
	private string EFGBMFABOJN(HCIPGPHIAME LJBKINELJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x609EED0", Offset = "0x609E0D0", VA = "0x18609EED0")]
	private string APLDGJHNNLN(HCIPGPHIAME LJBKINELJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x60A0080", Offset = "0x609F280", VA = "0x1860A0080")]
	private void EACPMAEMBMO([In] BPJDBMEKNAN MJGHOBDIDHD, bool AKGAGOOFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x60A2880", Offset = "0x60A1A80", VA = "0x1860A2880")]
	private void MBADCAEJHHN(HCIPGPHIAME MMGOAMJJJHK, bool AKGAGOOFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x609FAB0", Offset = "0x609ECB0", VA = "0x18609FAB0")]
	private void DFGGPBIAINI(HCIPGPHIAME CELCDPKAGKM, int PLPLNPOIJIE, HCIPGPHIAME EBKJLIBKJMN, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD, bool AKGAGOOFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60A0940", Offset = "0x609FB40", VA = "0x1860A0940")]
	private void EJKMJDPKCJB(HCIPGPHIAME KMHBBEABLLL, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD, bool NFCLEJNDPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x60A2AE0", Offset = "0x60A1CE0", VA = "0x1860A2AE0", Slot = "9")]
	public bool MHHFJKKLDKE(HCIPGPHIAME KMHBBEABLLL, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x60A3560", Offset = "0x60A2760", VA = "0x1860A3560")]
	private bool NHDNGMCLHDP(HCIPGPHIAME KMHBBEABLLL, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60A1A70", Offset = "0x60A0C70", VA = "0x1860A1A70")]
	private static void GPAEIAPAGME(HCIPGPHIAME KMHBBEABLLL, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD, KBJDFFPAKLE HNOIHOLHCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x609F860", Offset = "0x609EA60", VA = "0x18609F860")]
	private void CPKFAINHBNA(HCIPGPHIAME CELCDPKAGKM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x60A3930", Offset = "0x60A2B30", VA = "0x1860A3930")]
	private void PJGOKGAFALM(KBJDFFPAKLE JCCACJKHFKB, HCIPGPHIAME DNPEEDPFKON, HCIPGPHIAME JEPODBIJBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x60A38C0", Offset = "0x60A2AC0", VA = "0x1860A38C0")]
	private void PJGOKGAFALM(HCIPGPHIAME LJBKINELJNM, HCIPGPHIAME DNPEEDPFKON, HCIPGPHIAME JEPODBIJBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x60A2480", Offset = "0x60A1680", VA = "0x1860A2480")]
	private void JIHCEBLFMLK(HCIPGPHIAME LJBKINELJNM, HCIPGPHIAME DNPEEDPFKON, HCIPGPHIAME JEPODBIJBKG, bool KDEPPDBHNNN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x60A2380", Offset = "0x60A1580", VA = "0x1860A2380")]
	private void JIHCEBLFMLK(KBJDFFPAKLE MFIBAFBMCBA, HCIPGPHIAME FBPCHADAODN, HCIPGPHIAME HKDLHCGLGFK, bool KDEPPDBHNNN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60A24F0", Offset = "0x60A16F0", VA = "0x1860A24F0")]
	private void JOHLNADADIM(HCIPGPHIAME MMGOAMJJJHK, int PLPLNPOIJIE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x60A1F20", Offset = "0x60A1120", VA = "0x1860A1F20")]
	private void ILOCAOCACEB(AEJBFFDENKG DLAKBCKOLFN, AEJBFFDENKG GBPGMIMHGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60A1BF0", Offset = "0x60A0DF0", VA = "0x1860A1BF0", Slot = "18")]
	public HCIPGPHIAME HAMIJKAKGPP(HCIPGPHIAME LJBKINELJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x609EF40", Offset = "0x609E140", VA = "0x18609EF40", Slot = "13")]
	public void BBKPDPGCCKO(HCIPGPHIAME LJBKINELJNM, HashSet<HCIPGPHIAME> MIJNHBMLFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60A2640", Offset = "0x60A1840", VA = "0x1860A2640", Slot = "14")]
	public List<HCIPGPHIAME> KKIFLHHKCBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x60A1D50", Offset = "0x60A0F50", VA = "0x1860A1D50")]
	protected AEJBFFDENKG IAGNLONBGCC(AEJBFFDENKG JCCACJKHFKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x60A13F0", Offset = "0x60A05F0", VA = "0x1860A13F0")]
	protected KBJDFFPAKLE[] GBMHLOLFMAD(KBJDFFPAKLE IIDPMGLMGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x60A2BC0", Offset = "0x60A1DC0", VA = "0x1860A2BC0")]
	protected bool MJLENIAKIPE(HCIPGPHIAME LJBKINELJNM, [Out] KBJDFFPAKLE JCCACJKHFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x60A3790", Offset = "0x60A2990", VA = "0x1860A3790", Slot = "15")]
	public bool OKKNDMJOGAN(HCIPGPHIAME LJBKINELJNM, [Out] CELJGLDLLOJ ABJHGNMPHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x609FA70", Offset = "0x609EC70", VA = "0x18609FA70")]
	protected KBJDFFPAKLE DELAJJDCAPL(CELJGLDLLOJ PPAHFDLHECJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x609F980", Offset = "0x609EB80", VA = "0x18609F980", Slot = "10")]
	public bool DDNLCNNFINH(HCIPGPHIAME CELCDPKAGKM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x609F2E0", Offset = "0x609E4E0", VA = "0x18609F2E0")]
	private bool CBABCFMLNFJ(HCIPGPHIAME CELCDPKAGKM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x60A1320", Offset = "0x60A0520", VA = "0x1860A1320")]
	private static bool FMBDNHCIAGD(KBJDFFPAKLE INHGAHHNMIE, CELJGLDLLOJ ODHBIHDFKBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x60A1ED0", Offset = "0x60A10D0", VA = "0x1860A1ED0", Slot = "7")]
	private bool IKMHEKKEEKH([In] BPJDBMEKNAN MJGHOBDIDHD, bool KBCHMAIMKIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[UnityEngine.Scripting.Preserve]
internal class BMNJNCHOLEP : EIHDFIIPGIF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly JGBEMAKPOMJ BIBKBFDHJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly BDBIBMENDAB ODLGFLFNMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly JNGMEMBJFBC LPNOLILMDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly GFHGAAKPMPC DAOIADBHOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly FLHDNOMJBLH AOFKLCLPNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal LPGBPLAJKDB CHEOCJAKLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal EMNAHCCBAJB ELJPPKLMOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal AFOPDCHMJHO HDJDIOHIMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal bool ACOBIAAOLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool BPFDFJLMFLG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool ELDBOEHPCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x17551A0", Offset = "0x17543A0", VA = "0x1817551A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x17551C0", Offset = "0x17543C0", VA = "0x1817551C0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OIOOJDHLJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1755180", Offset = "0x1754380", VA = "0x181755180", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x17551B0", Offset = "0x17543B0", VA = "0x1817551B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool AEEKHJFGJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HCIPGPHIAME, HCIPGPHIAME> JNFOAJFANJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x608E720", Offset = "0x608D920", VA = "0x18608E720", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x608EEE0", Offset = "0x608E0E0", VA = "0x18608EEE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HCIPGPHIAME, HCIPGPHIAME> BPFEDIEBKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x608FA00", Offset = "0x608EC00", VA = "0x18608FA00", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x608F950", Offset = "0x608EB50", VA = "0x18608F950", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HCIPGPHIAME, HCIPGPHIAME, HCIPGPHIAME> LFINGJBEDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x608E620", Offset = "0x608D820", VA = "0x18608E620", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x608E780", Offset = "0x608D980", VA = "0x18608E780", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x608FBC0", Offset = "0x608EDC0", VA = "0x18608FBC0")]
	public BMNJNCHOLEP(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x608F1E0", Offset = "0x608E3E0", VA = "0x18608F1E0", Slot = "12")]
	public void MEJEOBIHPJE(GameObject CHIOFKOKCNE, FEPCKAFNNNP GGNALOBOPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x608E680", Offset = "0x608D880", VA = "0x18608E680", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x608F7B0", Offset = "0x608E9B0", VA = "0x18608F7B0", Slot = "13")]
	public void MOLHGBBEJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x608FBA0", Offset = "0x608EDA0", VA = "0x18608FBA0", Slot = "14")]
	public void OEPCKJDAMHI(HCIPGPHIAME LJBKINELJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x608E0C0", Offset = "0x608D2C0", VA = "0x18608E0C0", Slot = "15")]
	public void CIPMPDGKPOP(HCIPGPHIAME LJBKINELJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x608F9F0", Offset = "0x608EBF0", VA = "0x18608F9F0", Slot = "22")]
	public bool NNOFNPJOBPO(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x608E940", Offset = "0x608DB40", VA = "0x18608E940")]
	internal bool GNCMJIOFCNA([In] BPJDBMEKNAN MJGHOBDIDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x608E380", Offset = "0x608D580", VA = "0x18608E380")]
	internal bool CBABCFMLNFJ([In] BPJDBMEKNAN MJGHOBDIDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x608EF40", Offset = "0x608E140", VA = "0x18608EF40")]
	internal bool KHODPPHGAAG([In] BPJDBMEKNAN MJGHOBDIDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x608F800", Offset = "0x608EA00", VA = "0x18608F800")]
	internal bool NIBLNGDCFCA([In] BPJDBMEKNAN MJGHOBDIDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x608EBC0", Offset = "0x608DDC0", VA = "0x18608EBC0")]
	internal void INIBNKAPAGE(HCIPGPHIAME LJBKINELJNM, int LFAJNJLKEFO, bool KBCHMAIMKIH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x608E0C0", Offset = "0x608D2C0", VA = "0x18608E0C0")]
	internal bool BBKGEAGENIL(HCIPGPHIAME MNCCACAKMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x608FA60", Offset = "0x608EC60", VA = "0x18608FA60")]
	internal bool OCADMEGCEMM(HCIPGPHIAME KMHBBEABLLL, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x608E120", Offset = "0x608D320", VA = "0x18608E120", Slot = "16")]
	public void BBKPDPGCCKO(HCIPGPHIAME LJBKINELJNM, HashSet<HCIPGPHIAME> AAHNLOKJEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x608E410", Offset = "0x608D610", VA = "0x18608E410", Slot = "17")]
	public void DJAPAEPAIME(HCIPGPHIAME KMHBBEABLLL, HCIPGPHIAME NPBLALLIKJP, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x608E800", Offset = "0x608DA00", VA = "0x18608E800", Slot = "18")]
	public void ELLECJMEDNJ(HCIPGPHIAME CELCDPKAGKM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x608EA00", Offset = "0x608DC00", VA = "0x18608EA00", Slot = "19")]
	public void ILLIAMENDFN(HCIPGPHIAME CELCDPKAGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x608EFA0", Offset = "0x608E1A0", VA = "0x18608EFA0")]
	public void KONJPLIDIBM([Optional] JFLDDIAKFIC KGFAACGADCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x608EDA0", Offset = "0x608DFA0", VA = "0x18608EDA0", Slot = "23")]
	public void JCPMBFEICFP(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x608E210", Offset = "0x608D410", VA = "0x18608E210", Slot = "20")]
	public KAJMFBHLNPJ BCOFCCOCJCL(bool DNPDOKCHPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x608E7E0", Offset = "0x608D9E0", VA = "0x18608E7E0", Slot = "21")]
	public KAJMFBHLNPJ EEHHNALMEPB(HashSet<Guid> CPPLHEPLDPB, bool DNPDOKCHPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x608F9B0", Offset = "0x608EBB0", VA = "0x18608F9B0", Slot = "25")]
	public void NLIPNHKIFDN(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x608EE30", Offset = "0x608E030", VA = "0x18608EE30", Slot = "24")]
	public void JNKBHBJLNGD(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class BDBIBMENDAB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly DOEOOCEHEOD<HCIPGPHIAME, HCIPGPHIAME> JNFOAJFANJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly DOEOOCEHEOD<HCIPGPHIAME, HCIPGPHIAME> BPFEDIEBKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly HCBENJCDKAD<HCIPGPHIAME, HCIPGPHIAME, HCIPGPHIAME> LFINGJBEDFJ;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x608DFA0", Offset = "0x608D1A0", VA = "0x18608DFA0")]
	public BDBIBMENDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	public void MEJEOBIHPJE(BMNJNCHOLEP JPFNBECBJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x608DEE0", Offset = "0x608D0E0", VA = "0x18608DEE0")]
	public void HPFOJHHEDKE(HCIPGPHIAME DLAKBCKOLFN, HCIPGPHIAME MMGOAMJJJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x608DF40", Offset = "0x608D140", VA = "0x18608DF40")]
	public void LKFGKDDGBPM(HCIPGPHIAME DLAKBCKOLFN, HCIPGPHIAME MMGOAMJJJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x608DE60", Offset = "0x608D060", VA = "0x18608DE60")]
	public void HAHJMLELLGP(HCIPGPHIAME OEIDFPFMBNF, HCIPGPHIAME EBKJLIBKJMN, HCIPGPHIAME MMGOAMJJJHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class JNGMEMBJFBC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private BMNJNCHOLEP JPFNBECBJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private EMNAHCCBAJB ELJPPKLMOOJ;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public JNGMEMBJFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6096BB0", Offset = "0x6095DB0", VA = "0x186096BB0")]
	public void MEJEOBIHPJE(BMNJNCHOLEP JPFNBECBJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6096A80", Offset = "0x6095C80", VA = "0x186096A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6096B90", Offset = "0x6095D90", VA = "0x186096B90")]
	private void IFNCPPJJMMB(JFLDDIAKFIC CNFKLDMHALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6096CE0", Offset = "0x6095EE0", VA = "0x186096CE0")]
	private void PIKCPCPFHJI(JFLDDIAKFIC JLOIPNENJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6096980", Offset = "0x6095B80", VA = "0x186096980")]
	public void BCAOOCAMGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6096A90", Offset = "0x6095C90", VA = "0x186096A90")]
	public void IDHIEABNKNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class FPLLBEMEFIA
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FFCEFCODMKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public JGBEMAKPOMJ container;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public FFCEFCODMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x60927C0", Offset = "0x60919C0", VA = "0x1860927C0")]
		internal BMNJNCHOLEP NGINENBJFBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x60929A0", Offset = "0x6091BA0", VA = "0x1860929A0")]
	public static void OKLAJENNLIO(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6092920", Offset = "0x6091B20", VA = "0x186092920")]
	public static void LOGLIDHMHFA(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[UnityEngine.Scripting.Preserve]
internal class HPGCIPBIJND : IDisposable, AFOPDCHMJHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Dictionary<int, JOEBNFCNLPI> ANKDEANDMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly HGFMJOLDDID KIGKGMPODBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private BEIOFMPMCDG IAMPLEHKGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private FLHDNOMJBLH AOFKLCLPNLP;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6096620", Offset = "0x6095820", VA = "0x186096620")]
	public HPGCIPBIJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x60965E0", Offset = "0x60957E0", VA = "0x1860965E0", Slot = "7")]
	public void MEJEOBIHPJE(FLHDNOMJBLH AOFKLCLPNLP, BEIOFMPMCDG IAMPLEHKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6095F90", Offset = "0x6095190", VA = "0x186095F90", Slot = "5")]
	public void KKKGODOLGBJ(AEJBFFDENKG IACMKLBFHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6095E20", Offset = "0x6095020", VA = "0x186095E20", Slot = "9")]
	public void FHLOPEIBPMP(AEJBFFDENKG BECNLLJDENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6095AB0", Offset = "0x6094CB0", VA = "0x186095AB0", Slot = "8")]
	public void CILGABDHFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6096290", Offset = "0x6095490", VA = "0x186096290", Slot = "10")]
	public void LOFNKJONAJA(AEJBFFDENKG OIIHGALKFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x60961D0", Offset = "0x60953D0", VA = "0x1860961D0", Slot = "11")]
	public void KODAPCHPLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6095C70", Offset = "0x6094E70", VA = "0x186095C70")]
	private bool DOAAIJLJLAB(AEJBFFDENKG OMICJFCLNPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class GFHGAAKPMPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct MBFJODNOLEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly KBJDFFPAKLE FGFEJMCDNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly HashSet<Guid> CPPLHEPLDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly KDHAEKBIJNF DOKOOFFJJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly KDHAEKBIJNF IEPEIFGOHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly bool DNPDOKCHPHN;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool KKFNKIKMPCC
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x6099DE0", Offset = "0x6098FE0", VA = "0x186099DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x609A640", Offset = "0x6099840", VA = "0x18609A640")]
		public MBFJODNOLEB(KBJDFFPAKLE FGFEJMCDNEH, HashSet<Guid> CPPLHEPLDPB, bool DNPDOKCHPHN, [Optional] KDHAEKBIJNF DOKOOFFJJNE, [Optional] KDHAEKBIJNF IEPEIFGOHBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x609A310", Offset = "0x6099510", VA = "0x18609A310")]
		public KDHAEKBIJNF JCBMCDNAHJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x609A250", Offset = "0x6099450", VA = "0x18609A250")]
		private KDHAEKBIJNF ICNAHKLKPAN([Out] KDHAEKBIJNF EEIPKIDNPHD, [Out] KDHAEKBIJNF FLEHCIHLKBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x609A060", Offset = "0x6099260", VA = "0x18609A060")]
		private KDHAEKBIJNF GOEDBDPPIKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6099EF0", Offset = "0x60990F0", VA = "0x186099EF0")]
		private void FBDKDGFBGEN(KDHAEKBIJNF AEGPOANDGIF, KDHAEKBIJNF BIBCHEOBINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x609A480", Offset = "0x6099680", VA = "0x18609A480")]
		private void PLBGGHHHBKB(KDHAEKBIJNF EEIPKIDNPHD, KDHAEKBIJNF FLEHCIHLKBE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private BMNJNCHOLEP JPFNBECBJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private FLHDNOMJBLH AOFKLCLPNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private AFOPDCHMJHO IJNHBBPLFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private EMNAHCCBAJB ELJPPKLMOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool NHJFHNPJGNP;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool KKJLMILFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6092D20", Offset = "0x6091F20", VA = "0x186092D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool ELDBOEHPCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x60938E0", Offset = "0x6092AE0", VA = "0x1860938E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6092BA0", Offset = "0x6091DA0", VA = "0x186092BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6094830", Offset = "0x6093A30", VA = "0x186094830")]
	public void MEJEOBIHPJE(BMNJNCHOLEP JPFNBECBJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6092BC0", Offset = "0x6091DC0", VA = "0x186092BC0")]
	public KAJMFBHLNPJ BCOFCCOCJCL(bool DNPDOKCHPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6093900", Offset = "0x6092B00", VA = "0x186093900")]
	public KAJMFBHLNPJ EEHHNALMEPB(HashSet<Guid> CPPLHEPLDPB, bool DNPDOKCHPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6094560", Offset = "0x6093760", VA = "0x186094560")]
	public void JCPMBFEICFP(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6094620", Offset = "0x6093820", VA = "0x186094620")]
	public void JNKBHBJLNGD(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x60945F0", Offset = "0x60937F0", VA = "0x1860945F0")]
	public void JKMAAIGHOID(KAJMFBHLNPJ AOFKLCLPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6095390", Offset = "0x6094590", VA = "0x186095390")]
	private void OPNFDOJFNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6092DB0", Offset = "0x6091FB0", VA = "0x186092DB0")]
	private KDHAEKBIJNF CAGBNBOCLCM(KBJDFFPAKLE JCCACJKHFKB, bool DNPDOKCHPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6094F60", Offset = "0x6094160", VA = "0x186094F60")]
	private static void OAPDJHJLMFD(KBJDFFPAKLE JCCACJKHFKB, bool DNPDOKCHPHN, KDHAEKBIJNF AFEJHPJDDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6094B00", Offset = "0x6093D00", VA = "0x186094B00")]
	private void MPHDJNONIHP(KBJDFFPAKLE JCCACJKHFKB, bool DNPDOKCHPHN, KDHAEKBIJNF AFEJHPJDDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6092E80", Offset = "0x6092080", VA = "0x186092E80")]
	private KDHAEKBIJNF CCHFDKIOGBI(KBJDFFPAKLE FGFEJMCDNEH, HashSet<Guid> CPPLHEPLDPB, bool DNPDOKCHPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6092F10", Offset = "0x6092110", VA = "0x186092F10")]
	private bool CEMNNCHLLFH(KAJMFBHLNPJ LFLJKLBAJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6093190", Offset = "0x6092390", VA = "0x186093190")]
	private bool CKOHJOJGNNI(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6094430", Offset = "0x6093630", VA = "0x186094430")]
	private bool GHKAEABOBBM(KAJMFBHLNPJ AOFKLCLPNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6094450", Offset = "0x6093650", VA = "0x186094450")]
	private static bool HJKMOOBNEPM(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6094D20", Offset = "0x6093F20", VA = "0x186094D20")]
	public static bool NNOFNPJOBPO(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6094100", Offset = "0x6093300", VA = "0x186094100")]
	private HCIPGPHIAME FIKKKGBOBGD(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6095210", Offset = "0x6094410", VA = "0x186095210")]
	private HCIPGPHIAME OIPBEMNBJCH(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x60946C0", Offset = "0x60938C0", VA = "0x1860946C0")]
	private HCIPGPHIAME MBNOPCDEHLE(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6092D70", Offset = "0x6091F70", VA = "0x186092D70")]
	private static Guid BMEJFDMJBPK(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x60937F0", Offset = "0x60929F0", VA = "0x1860937F0")]
	private string CMBGLKGHKJF(KDHAEKBIJNF AFEJHPJDDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6093F40", Offset = "0x6093140", VA = "0x186093F40")]
	private bool FHGEFKNHBNB(KBJDFFPAKLE JCCACJKHFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x60948A0", Offset = "0x6093AA0", VA = "0x1860948A0")]
	private static void MLIBBLJJDOM(KBJDFFPAKLE FGFEJMCDNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public GFHGAAKPMPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct BPJDBMEKNAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public HCIPGPHIAME MMGOAMJJJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public HCIPGPHIAME DLAKBCKOLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int PLPLNPOIJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int DGKMHPIAHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector3 DBNJPCOJKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Quaternion MJHGCDJKELD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public CELJGLDLLOJ FGPDDJJMDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x608FFE0", Offset = "0x608F1E0", VA = "0x18608FFE0")]
		get
		{
			return default(CELJGLDLLOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CELJGLDLLOJ ILLIMLAKMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x608FFB0", Offset = "0x608F1B0", VA = "0x18608FFB0")]
		get
		{
			return default(CELJGLDLLOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6090080", Offset = "0x608F280", VA = "0x186090080")]
	public BPJDBMEKNAN(HCIPGPHIAME MMGOAMJJJHK, HCIPGPHIAME DLAKBCKOLFN, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface FLHDNOMJBLH
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	AEJBFFDENKG NECEBBLCHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEJEOBIHPJE(EIHDFIIPGIF JPFNBECBJPL);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MGBLPLCHOBG([In] BPJDBMEKNAN MJGHOBDIDHD, bool KBCHMAIMKIH = true);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EBCNEPNPBOA(HCIPGPHIAME HFPKLKPMFIN);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MHHFJKKLDKE(HCIPGPHIAME KMHBBEABLLL, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DDNLCNNFINH(HCIPGPHIAME CELCDPKAGKM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJGECGGEJDC();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IPHEMBHEMMB(Func<HCIPGPHIAME, bool> DFNCBOLPMNI);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BBKPDPGCCKO(HCIPGPHIAME LJBKINELJNM, HashSet<HCIPGPHIAME> MIJNHBMLFKM);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<HCIPGPHIAME> KKIFLHHKCBJ();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OKKNDMJOGAN(HCIPGPHIAME LJBKINELJNM, [Out] CELJGLDLLOJ ABJHGNMPHLO);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KGMOECPLKDM(HGFMJOLDDID CMMPHMKBCDC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal delegate bool HGFMJOLDDID(AEJBFFDENKG JCCACJKHFKB);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface AEJBFFDENKG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HCIPGPHIAME JKIFEKFMIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AEJBFFDENKG IIBNAPJLELD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CELJGLDLLOJ CPKMFKPJBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EDENICHGNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface JOEBNFCNLPI
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNCDFEHEFDJ(HCIPGPHIAME OKALFKBCAJB, CELJGLDLLOJ MMGOAMJJJHK);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFAGMAIAIDM(HCIPGPHIAME OKALFKBCAJB, CELJGLDLLOJ MMGOAMJJJHK);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLMALMHEBDE(HCIPGPHIAME OKALFKBCAJB, CELJGLDLLOJ MMGOAMJJJHK);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMLCBPCJEHF(HCIPGPHIAME OKALFKBCAJB, CELJGLDLLOJ MMGOAMJJJHK);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JOEBNFCNLPI Instantiate(Transform DIFJEPLFOKN);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJPKHGMGMMP();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BEIOFMPMCDG
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEJEOBIHPJE(Transform DIFJEPLFOKN, JOEBNFCNLPI IHEGPKNHGPP);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JOEBNFCNLPI BCFGAKHLHAM();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHLPKJPMOEO(JOEBNFCNLPI JBAPINAHMPF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LPGBPLAJKDB : MAPIANJJCDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KIOKPOLOGHC(Guid MAJPFPBMDGN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface AFOPDCHMJHO
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKKGODOLGBJ(AEJBFFDENKG IACMKLBFHCN);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEJEOBIHPJE(FLHDNOMJBLH AOFKLCLPNLP, BEIOFMPMCDG HOIPIOGAANO);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CILGABDHFIN();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHLOPEIBPMP(AEJBFFDENKG BECNLLJDENK);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LOFNKJONAJA(AEJBFFDENKG OIIHGALKFKP);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KODAPCHPLFL();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class KBJDFFPAKLE : AEJBFFDENKG
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KJDKLDJPPDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CELJGLDLLOJ nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public KBJDFFPAKLE foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public KJDKLDJPPDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6097C70", Offset = "0x6096E70", VA = "0x186097C70")]
		internal bool HGANMCHPJNE(AEJBFFDENKG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private CELJGLDLLOJ ABJHGNMPHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LinkedList<KBJDFFPAKLE> FCLBFFIINLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private KBJDFFPAKLE GGPIKBBAAME;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public CELJGLDLLOJ CPKMFKPJBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3484AB0", Offset = "0x3483CB0", VA = "0x183484AB0", Slot = "6")]
		get
		{
			return default(CELJGLDLLOJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6097620", Offset = "0x6096820", VA = "0x186097620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private KBJDFFPAKLE DLAKBCKOLFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B7520", Offset = "0x7B6720", VA = "0x1807B7520")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6096FA0", Offset = "0x60961A0", VA = "0x186096FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public AEJBFFDENKG IIBNAPJLELD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B7520", Offset = "0x7B6720", VA = "0x1807B7520", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HCIPGPHIAME JKIFEKFMIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool EDENICHGNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6097BB0", Offset = "0x6096DB0", VA = "0x186097BB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ENJEJMLMLGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x60979E0", Offset = "0x6096BE0", VA = "0x1860979E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected KBJDFFPAKLE MFIBAFBMCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6097650", Offset = "0x6096850", VA = "0x186097650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6097BC0", Offset = "0x6096DC0", VA = "0x186097BC0")]
	public KBJDFFPAKLE(CELJGLDLLOJ PHBKKFEELHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6097670", Offset = "0x6096870", VA = "0x186097670")]
	public KBJDFFPAKLE JJAHBJFPKEC(CELJGLDLLOJ AFOOCCABMHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6097A30", Offset = "0x6096C30", VA = "0x186097A30")]
	public KBJDFFPAKLE OOEEHOHCLJC(CELJGLDLLOJ MJOEABDOMLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6097080", Offset = "0x6096280", VA = "0x186097080")]
	public KBJDFFPAKLE FBCLMIGJMFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6096D50", Offset = "0x6095F50", VA = "0x186096D50")]
	public void DBHKOJLPIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6097930", Offset = "0x6096B30", VA = "0x186097930")]
	public KBJDFFPAKLE MEPCMLGOLNH(CELJGLDLLOJ EBKJLIBKJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x60977D0", Offset = "0x60969D0", VA = "0x1860977D0")]
	private static void KGMOECPLKDM(KBJDFFPAKLE ODCIOHJCBAM, HGFMJOLDDID NOMNBPKHBHG, bool LAKMIBALIMA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x60977C0", Offset = "0x60969C0", VA = "0x1860977C0", Slot = "9")]
	public void KGMOECPLKDM(HGFMJOLDDID CMMPHMKBCDC, bool KDEPPDBHNNN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6097260", Offset = "0x6096460", VA = "0x186097260")]
	public static string GNKFIPIKFJD(KBJDFFPAKLE ODCIOHJCBAM, int ADINCKCGEAK = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6096EA0", Offset = "0x60960A0", VA = "0x186096EA0")]
	public static KBJDFFPAKLE DELAJJDCAPL(KBJDFFPAKLE ODCIOHJCBAM, CELJGLDLLOJ HIPNAAFJJCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface EMNAHCCBAJB
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool KKJLMILFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool MPGNAPCPHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<JFLDDIAKFIC> IFNCPPJJMMB;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<JFLDDIAKFIC> PIKCPCPFHJI;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(BMNJNCHOLEP JPFNBECBJPL);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(HCIPGPHIAME KMHBBEABLLL, HCIPGPHIAME NPBLALLIKJP, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(HCIPGPHIAME CELCDPKAGKM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(KAJMFBHLNPJ EEKJIJIGAID, [Optional] JFLDDIAKFIC KGFAACGADCE);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, EMNAHCCBAJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private BMNJNCHOLEP JPFNBECBJPL;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool KKJLMILFAPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x6099B30", Offset = "0x6098D30", VA = "0x186099B30", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool MPGNAPCPHKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x6099B90", Offset = "0x6098D90", VA = "0x186099B90", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<JFLDDIAKFIC> IFNCPPJJMMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x6099A90", Offset = "0x6098C90", VA = "0x186099A90", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6099C70", Offset = "0x6098E70", VA = "0x186099C70", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<JFLDDIAKFIC> PIKCPCPFHJI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x60999F0", Offset = "0x6098BF0", VA = "0x1860999F0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6099BD0", Offset = "0x6098DD0", VA = "0x186099BD0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B7530", Offset = "0x7B6730", VA = "0x1807B7530", Slot = "19")]
		public void SetManager(BMNJNCHOLEP JPFNBECBJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x60999C0", Offset = "0x6098BC0", VA = "0x1860999C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6098740", Offset = "0x6097940", VA = "0x186098740", Slot = "23")]
		public void RequestMasterConnectNodes(HCIPGPHIAME FEGENNPGEII, int PLPLNPOIJIE, HCIPGPHIAME OKALFKBCAJB, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6098870", Offset = "0x6097A70", VA = "0x186098870", Slot = "24")]
		public void RequestMasterDisconnectNode(HCIPGPHIAME HFPKLKPMFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6098930", Offset = "0x6097B30", VA = "0x186098930", Slot = "20")]
		public void RequestMasterModifyNode(HCIPGPHIAME KMHBBEABLLL, HCIPGPHIAME NPBLALLIKJP, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6098A60", Offset = "0x6097C60", VA = "0x186098A60", Slot = "21")]
		public void RequestMasterReparentNodes(HCIPGPHIAME CELCDPKAGKM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6098B90", Offset = "0x6097D90", VA = "0x186098B90", Slot = "25")]
		public void RequestMasterReparentToRoot(HCIPGPHIAME CELCDPKAGKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6098610", Offset = "0x6097810", VA = "0x186098610", Slot = "22")]
		public void RequestDeserializeConnectableGraph(KAJMFBHLNPJ EEKJIJIGAID, [Optional] JFLDDIAKFIC KGFAACGADCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6098F70", Offset = "0x6098170", VA = "0x186098F70")]
		[ONBOCPNOBKD]
		private void RpcMasterConnectNodes(HCIPGPHIAME FEGENNPGEII, int PLPLNPOIJIE, HCIPGPHIAME OKALFKBCAJB, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6099230", Offset = "0x6098430", VA = "0x186099230")]
		[ONBOCPNOBKD]
		private void RpcMasterDisconnectNode(HCIPGPHIAME HFPKLKPMFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6099570", Offset = "0x6098770", VA = "0x186099570")]
		[ONBOCPNOBKD]
		private void RpcMasterReparentNodes(HCIPGPHIAME CELCDPKAGKM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6099370", Offset = "0x6098570", VA = "0x186099370")]
		[ONBOCPNOBKD]
		private void RpcMasterModifyNode(HCIPGPHIAME KMHBBEABLLL, HCIPGPHIAME NPBLALLIKJP, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6098D60", Offset = "0x6097F60", VA = "0x186098D60")]
		[ONBOCPNOBKD]
		private void RpcConnectNodes(HCIPGPHIAME FEGENNPGEII, int PLPLNPOIJIE, HCIPGPHIAME OKALFKBCAJB, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD, ACLALKPBIFO MAONKKNAJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6098EE0", Offset = "0x60980E0", VA = "0x186098EE0")]
		[ONBOCPNOBKD]
		private void RpcDisconnectNode(HCIPGPHIAME HFPKLKPMFIN, ACLALKPBIFO MAONKKNAJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x60998C0", Offset = "0x6098AC0", VA = "0x1860998C0")]
		[ONBOCPNOBKD]
		private void RpcReparentNodes(HCIPGPHIAME CELCDPKAGKM, int KDEMCEHEMNE, HCIPGPHIAME EBKJLIBKJMN, int PPBPBNPIBIO, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD, ACLALKPBIFO MAONKKNAJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6099800", Offset = "0x6098A00", VA = "0x186099800")]
		[ONBOCPNOBKD]
		private void RpcModifyNode(HCIPGPHIAME KMHBBEABLLL, int PLPLNPOIJIE, int DGKMHPIAHDD, Vector3 DBNJPCOJKJH, Quaternion MJHGCDJKELD, ACLALKPBIFO MAONKKNAJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6098EA0", Offset = "0x60980A0", VA = "0x186098EA0")]
		[ONBOCPNOBKD]
		private void RpcDeserializeConnectableGraph(KAJMFBHLNPJ AOFKLCLPNLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7D1180", Offset = "0x7D0380", VA = "0x1807D1180")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, JOEBNFCNLPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6098490", Offset = "0x6097690", VA = "0x186098490", Slot = "4")]
		private void PMIPOKOEMHK(HCIPGPHIAME OKALFKBCAJB, CELJGLDLLOJ MMGOAMJJJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6097F60", Offset = "0x6097160", VA = "0x186097F60", Slot = "5")]
		private void INIFCNOOCHI(HCIPGPHIAME OKALFKBCAJB, CELJGLDLLOJ MMGOAMJJJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6097E50", Offset = "0x6097050", VA = "0x186097E50", Slot = "6")]
		private void DDOAPAOBOEN(HCIPGPHIAME OKALFKBCAJB, CELJGLDLLOJ MMGOAMJJJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x60981D0", Offset = "0x60973D0", VA = "0x1860981D0", Slot = "7")]
		private void IPDCIJMIPEO(HCIPGPHIAME OKALFKBCAJB, CELJGLDLLOJ MMGOAMJJJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6098420", Offset = "0x6097620", VA = "0x186098420", Slot = "8")]
		private JOEBNFCNLPI OAGCEOFIALL(Transform DIFJEPLFOKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x60983C0", Offset = "0x60975C0", VA = "0x1860983C0", Slot = "9")]
		private void KFFOPKAALGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KPLLLBGDKNN
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2906930", Offset = "0x2905B30", VA = "0x182906930")]
	public static NBKHJKLDLDM<T> IFBKADMCMLC<T>(this JGBEMAKPOMJ BIBKBFDHJAF)
	{
		return null;
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
