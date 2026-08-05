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
public class LCFJEIJOBGG : OPOOJGGGCHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte AEOGPGHAIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] NBOIJOPCFLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FDBAFDCOMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80C100", Offset = "0x80A900", VA = "0x18080C100", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80C0E0", Offset = "0x80A8E0", VA = "0x18080C0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int IDPPLCHKGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A3620", Offset = "0x7A1E20", VA = "0x1807A3620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A2CB0", Offset = "0x7A14B0", VA = "0x1807A2CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float JJCKGLDJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B7DF0", Offset = "0x7B65F0", VA = "0x1807B7DF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B8170", Offset = "0x7B6970", VA = "0x1807B8170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float NGMFJIIHHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B7B30", Offset = "0x7B6330", VA = "0x1807B7B30", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B8150", Offset = "0x7B6950", VA = "0x1807B8150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> COGNPDICHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x63957A0", Offset = "0x6393FA0", VA = "0x1863957A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> NBHKMNINICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6395CC0", Offset = "0x63944C0", VA = "0x186395CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject IDPDODAHCDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte JOCPEGIGHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6395CF0", Offset = "0x63944F0", VA = "0x186395CF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6395D80", Offset = "0x6394580", VA = "0x186395D80")]
	public LCFJEIJOBGG(List<OHFDFDMDBNB> OCFLNDLHEKH, List<OHFDFDMDBNB> LCLGDHJCFFB, List<DJDIIJGKINF> DLJCKJCECBH, Material JGLFCCBLACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6395A50", Offset = "0x6394250", VA = "0x186395A50")]
	private int JMNELNIIDHC(List<OHFDFDMDBNB> JAOGLHIIJJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x63958F0", Offset = "0x63940F0", VA = "0x1863958F0")]
	private void ICGBJCAKPIJ(int FLCBCJKEIKD, bool JLCNOMOAIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6395B70", Offset = "0x6394370", VA = "0x186395B70")]
	public void JNBIADLPIMO(Vector3 CJBHGLHMBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63957F0", Offset = "0x6393FF0", VA = "0x1863957F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6395D40", Offset = "0x6394540", VA = "0x186395D40")]
	public void NMBNOLDIMNL(Transform FLDLELJMDIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ELELKMJINPM : GPNBKLAGOGP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class JCCPMOJOOEG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public ELELKMJINPM <>4__this;

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
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public JCCPMOJOOEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6393D10", Offset = "0x6392510", VA = "0x186393D10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6393660", Offset = "0x6391E60", VA = "0x186393660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6393BC0", Offset = "0x63923C0", VA = "0x186393BC0")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6393B70", Offset = "0x6392370", VA = "0x186393B70")]
		private void NIGDNOCCEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6393610", Offset = "0x6391E10", VA = "0x186393610")]
		private void LBHBILCCMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6393CC0", Offset = "0x63924C0", VA = "0x186393CC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6393C10", Offset = "0x6392410", VA = "0x186393C10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6393C10", Offset = "0x6392410", VA = "0x186393C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class GHMELCAJGCP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public ELELKMJINPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public GHMELCAJGCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6391BC0", Offset = "0x63903C0", VA = "0x186391BC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63916B0", Offset = "0x638FEB0", VA = "0x1863916B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6391A70", Offset = "0x6390270", VA = "0x186391A70")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6391A20", Offset = "0x6390220", VA = "0x186391A20")]
		private void NIGDNOCCEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6391B70", Offset = "0x6390370", VA = "0x186391B70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6391AC0", Offset = "0x63902C0", VA = "0x186391AC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6391AC0", Offset = "0x63902C0", VA = "0x186391AC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FMNMPKALING IGHNNKNKLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<APPPFOINKIN> NHGCCGFDPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> MFNGOHEKNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer EFEIHOJIOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool KKADKINFOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool JNHMFJLBBJE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<LEHAEAFDDGC> OPBMPADCJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KJHELOMONNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x638F6F0", Offset = "0x638DEF0", VA = "0x18638F6F0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DJDIIJGKINF MCBOOJOKEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x638F7D0", Offset = "0x638DFD0", VA = "0x18638F7D0", Slot = "8")]
		get
		{
			return default(DJDIIJGKINF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> OMMFALOCNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76CCB0", VA = "0x18076E4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x638F420", Offset = "0x638DC20", VA = "0x18638F420")]
	private bool IDOABFBDLDA(APPPFOINKIN ODBHMGBBLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x638F7B0", Offset = "0x638DFB0", VA = "0x18638F7B0")]
	private static bool OIGBAKMEDEG(APPPFOINKIN ODBHMGBBLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x638FF70", Offset = "0x638E770", VA = "0x18638FF70")]
	public ELELKMJINPM(FMNMPKALING AELCABDCBDD, bool GCHKPDBJJOB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x638EF90", Offset = "0x638D790", VA = "0x18638EF90", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x638ED70", Offset = "0x638D570", VA = "0x18638ED70")]
	public void BONJGFNEKBE(APPPFOINKIN ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x638F8A0", Offset = "0x638E0A0", VA = "0x18638F8A0")]
	public void PJFBCFIPABD(APPPFOINKIN ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x638E870", Offset = "0x638D070", VA = "0x18638E870", Slot = "4")]
	public void BBGCFMECCIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x638F1D0", Offset = "0x638D9D0", VA = "0x18638F1D0")]
	public void IDAKBLNHKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x638F440", Offset = "0x638DC40", VA = "0x18638F440")]
	private void JKINDDLPGIH(List<APPPFOINKIN> NHGCCGFDPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x638E240", Offset = "0x638CA40", VA = "0x18638E240")]
	private static Material CDEANPAMPBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x638F5D0", Offset = "0x638DDD0", VA = "0x18638F5D0")]
	private void JKINDDLPGIH(APPPFOINKIN ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x638F110", Offset = "0x638D910", VA = "0x18638F110")]
	private void GFCFEPOCIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x638F9C0", Offset = "0x638E1C0", VA = "0x18638F9C0")]
	public void PJKFCICKKOG(bool HIDLLKBNFPD, bool GNPJJLLBNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x638F730", Offset = "0x638DF30", VA = "0x18638F730")]
	protected void NKLKFBFGMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x638EF10", Offset = "0x638D710", VA = "0x18638EF10")]
	[IteratorStateMachine(typeof(JCCPMOJOOEG))]
	public IEnumerable<Renderer> DLFDHNBCNOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x638F670", Offset = "0x638DE70", VA = "0x18638F670")]
	[IteratorStateMachine(typeof(GHMELCAJGCP))]
	public IEnumerable<Renderer> KKGIBABFCPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class HPDGBHBAHMP : APPPFOINKIN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct HAAAHOKJLAM : MEFLACHKCLE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KKLKCKNAHFG LFKHDLANNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle EKJLKMKCKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private CODGBNKGEBM IAHBPMNCGJK;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6391D70", Offset = "0x6390570", VA = "0x186391D70")]
		public HAAAHOKJLAM(KKLKCKNAHFG LFKHDLANNJG, JobHandle EKJLKMKCKOI, CODGBNKGEBM IAHBPMNCGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6391CF0", Offset = "0x63904F0", VA = "0x186391CF0", Slot = "4")]
		public KKLKCKNAHFG ACJKICPGHOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6391D20", Offset = "0x6390520", VA = "0x186391D20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JHADDNMICEP MPMHEMNLGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float PEIBPJNEHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 PDGBGAAANAP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 HBNHJMALKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6392B10", Offset = "0x6391310", VA = "0x186392B10", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6393560", Offset = "0x6391D60", VA = "0x186393560")]
	public HPDGBHBAHMP(ELELKMJINPM DIPDOFGLHFF, JHADDNMICEP AELCABDCBDD, bool GCHKPDBJJOB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "15")]
	public override bool CILINBIALOL(DJDIIJGKINF DIPDOFGLHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6392940", Offset = "0x6391140", VA = "0x186392940", Slot = "17")]
	public override int JMNELNIIDHC(CGDEOGEIDJN IPDIEBPGLHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6392770", Offset = "0x6390F70", VA = "0x186392770", Slot = "18")]
	public override int JIMOENLIPGG(CGDEOGEIDJN IPDIEBPGLHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6391EA0", Offset = "0x63906A0", VA = "0x186391EA0", Slot = "19")]
	public override void EEMLDMLFKKH(CGDEOGEIDJN IPDIEBPGLHC, MBOGPMMPFMJ NHLFCMKCDNB, int LEAGLNALKKH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6391DD0", Offset = "0x63905D0", VA = "0x186391DD0", Slot = "20")]
	public override DJDIIJGKINF EBJNEOCPDGN()
	{
		return default(DJDIIJGKINF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x63925C0", Offset = "0x6390DC0", VA = "0x1863925C0", Slot = "22")]
	public override EBDFOAOLNLD HGHDCPCGHGG()
	{
		return default(EBDFOAOLNLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6392C40", Offset = "0x6391440", VA = "0x186392C40", Slot = "23")]
	public override MEFLACHKCLE NMKDGGCFOHK(CGDEOGEIDJN IPDIEBPGLHC, JobHandle EKJLKMKCKOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DefaultMember("Item")]
public interface AIGGCCFMMIK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ELELKMJINPM HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	APPPFOINKIN HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FNPOKJDMNEI HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class DOGJDBDDIFO : AGDCNEJFEEA, IDisposable, AIGGCCFMMIK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct KFFGPCABMFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public DOGJDBDDIFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6395100", Offset = "0x6393900", VA = "0x186395100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6395620", Offset = "0x6393E20", VA = "0x186395620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MDDFGHLAHHA<OBBBDDOACPB, ELELKMJINPM> NKAOGFMCAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly MDDFGHLAHHA<POFLIBPJHGH, APPPFOINKIN> NHGCCGFDPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly MDDFGHLAHHA<BHIILNDBAOK, FNPOKJDMNEI> GEBEJAEAING;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ELELKMJINPM HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x638DA70", Offset = "0x638C270", VA = "0x18638DA70", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public APPPFOINKIN HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x638DA10", Offset = "0x638C210", VA = "0x18638DA10", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public FNPOKJDMNEI HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x638D9B0", Offset = "0x638C1B0", VA = "0x18638D9B0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PHNNOOKGFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FB580", VA = "0x1807FCD80", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86B8B0", Offset = "0x86A0B0", VA = "0x18086B8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x638DD30", Offset = "0x638C530", VA = "0x18638DD30")]
	public DOGJDBDDIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x638C340", Offset = "0x638AB40", VA = "0x18638C340", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x638D740", Offset = "0x638BF40", VA = "0x18638D740", Slot = "4")]
	public OBBBDDOACPB JFHINBNGKLF(FMNMPKALING AELCABDCBDD)
	{
		return default(OBBBDDOACPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x638D4C0", Offset = "0x638BCC0", VA = "0x18638D4C0", Slot = "5")]
	public OBBBDDOACPB JFHINBNGKLF(FMNMPKALING AELCABDCBDD, bool GCHKPDBJJOB)
	{
		return default(OBBBDDOACPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x638CD10", Offset = "0x638B510", VA = "0x18638CD10", Slot = "6")]
	public void FEDDMFKHPDI(OBBBDDOACPB DIPDOFGLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x638C4D0", Offset = "0x638ACD0", VA = "0x18638C4D0", Slot = "7")]
	public void EHJIMIBKHAN(OBBBDDOACPB DIPDOFGLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x638BCB0", Offset = "0x638A4B0", VA = "0x18638BCB0", Slot = "8")]
	public POFLIBPJHGH AGGGPANEMIM(OBBBDDOACPB DIPDOFGLHFF, ENMEBHFDBBB AELCABDCBDD)
	{
		return default(POFLIBPJHGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x638C830", Offset = "0x638B030", VA = "0x18638C830", Slot = "9")]
	public POFLIBPJHGH FBKDAMLAPLO(OBBBDDOACPB DIPDOFGLHFF, JHADDNMICEP AELCABDCBDD)
	{
		return default(POFLIBPJHGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x638D100", Offset = "0x638B900", VA = "0x18638D100", Slot = "11")]
	public void JDONMKPOEGP(POFLIBPJHGH ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x638DAD0", Offset = "0x638C2D0", VA = "0x18638DAD0", Slot = "10")]
	public void PNANIBBEFEK(POFLIBPJHGH ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x638D940", Offset = "0x638C140", VA = "0x18638D940", Slot = "20")]
	public IEnumerable<Renderer> NKECAHAJMHC(OBBBDDOACPB DIPDOFGLHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x638C260", Offset = "0x638AA60", VA = "0x18638C260", Slot = "12")]
	public BHIILNDBAOK BCDKNMHDKAE(DDGAOBMAIMB AELCABDCBDD)
	{
		return default(BHIILNDBAOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x638D8D0", Offset = "0x638C0D0", VA = "0x18638D8D0", Slot = "14")]
	public void MLKOBAKPJIE(BHIILNDBAOK JDNELDEGCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x638CF70", Offset = "0x638B770", VA = "0x18638CF70", Slot = "16")]
	public Task IFJJPGLDDKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x638D750", Offset = "0x638BF50", VA = "0x18638D750", Slot = "17")]
	public Task KLMIKIPNEFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x638C190", Offset = "0x638A990", VA = "0x18638C190", Slot = "18")]
	[AsyncStateMachine(typeof(KFFGPCABMFE))]
	public Task AJGILFFBDOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x638BC20", Offset = "0x638A420", VA = "0x18638BC20", Slot = "19")]
	public void ACGILCIBJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x638C2E0", Offset = "0x638AAE0", VA = "0x18638C2E0", Slot = "13")]
	public void CEHIHINIBLG(BHIILNDBAOK JDNELDEGCIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class ABAGPDGNIHN : APPPFOINKIN
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct KJLFDKFEJAG : MEFLACHKCLE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private KKLKCKNAHFG LFKHDLANNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle EKJLKMKCKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JAPLAAHDOCJ IAHBPMNCGJK;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6395700", Offset = "0x6393F00", VA = "0x186395700")]
		public KJLFDKFEJAG(KKLKCKNAHFG LFKHDLANNJG, JobHandle EKJLKMKCKOI, JAPLAAHDOCJ IAHBPMNCGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6395680", Offset = "0x6393E80", VA = "0x186395680", Slot = "4")]
		public KKLKCKNAHFG ACJKICPGHOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63956B0", Offset = "0x6393EB0", VA = "0x1863956B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly ENMEBHFDBBB IDDGLNBEBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] MJCDBDNOPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 PDGBGAAANAP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override LLBEIELLHPH FBLEDDHPBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6388840", Offset = "0x6387040", VA = "0x186388840", Slot = "16")]
		get
		{
			return default(LLBEIELLHPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private Vector3 COIGBIICPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63880A0", Offset = "0x63868A0", VA = "0x1863880A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	protected override Hash128 HBNHJMALKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6388710", Offset = "0x6386F10", VA = "0x186388710", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6389440", Offset = "0x6387C40", VA = "0x186389440")]
	public ABAGPDGNIHN(ELELKMJINPM DIPDOFGLHFF, ENMEBHFDBBB AELCABDCBDD, bool OECLAEBJKGH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x63873B0", Offset = "0x6385BB0", VA = "0x1863873B0", Slot = "15")]
	public override bool CILINBIALOL(DJDIIJGKINF DIPDOFGLHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6388670", Offset = "0x6386E70", VA = "0x186388670", Slot = "17")]
	public override int JMNELNIIDHC(CGDEOGEIDJN IPDIEBPGLHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x63885D0", Offset = "0x6386DD0", VA = "0x1863885D0", Slot = "18")]
	public override int JIMOENLIPGG(CGDEOGEIDJN IPDIEBPGLHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6387160", Offset = "0x6385960", VA = "0x186387160")]
	private int ALCAHPECKBD(CGDEOGEIDJN IPDIEBPGLHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6387910", Offset = "0x6386110", VA = "0x186387910", Slot = "19")]
	public override void EEMLDMLFKKH(CGDEOGEIDJN IPDIEBPGLHC, MBOGPMMPFMJ NHLFCMKCDNB, int LEAGLNALKKH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6387840", Offset = "0x6386040", VA = "0x186387840", Slot = "20")]
	public override DJDIIJGKINF EBJNEOCPDGN()
	{
		return default(DJDIIJGKINF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6388420", Offset = "0x6386C20", VA = "0x186388420", Slot = "22")]
	public override EBDFOAOLNLD HGHDCPCGHGG()
	{
		return default(EBDFOAOLNLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6388C00", Offset = "0x6387400", VA = "0x186388C00", Slot = "23")]
	public override MEFLACHKCLE NMKDGGCFOHK(CGDEOGEIDJN IPDIEBPGLHC, JobHandle EKJLKMKCKOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AJBADNNILMM
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNGAEJPNLOL(FIJCAKKIEFB GFGNPBCFEMC, Renderer DKCPICJJNNM, int OOKLFJBMLOI);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGIHIIAEGLB(Renderer DKCPICJJNNM, NNGMIFHAJGO EOHDKBIHLED, Vector3 DOICMHIAPFP, Vector3 DCAGDOFGKOM, Vector3 HKCGMLCEHFK, float CNLKAADLNIB, float MEFAJMNBHCC, float NKFIHGEBBEP = -1f, [Optional] Color? MOJKBHCPNEF, [Optional] IReadOnlyList<Camera> LIFELIGFADE);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBKKMFHPHMH(Renderer DKCPICJJNNM, int OOKLFJBMLOI);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KFICOGPOPHE();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGFDGMGIKJD(int LAEOHMNNJEG, BCDACAGAFEG GFGNPBCFEMC, Renderer DKCPICJJNNM, int OOKLFJBMLOI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AINDJDJDBCA : FKPHICHDIIH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class KOEAIHHFHMH : PODCMFHIOAN<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6395750", Offset = "0x6393F50", VA = "0x186395750")]
		public KOEAIHHFHMH(string HNHMJGCODBA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AJBADNNILMM IKBDGAGFPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly AIGGCCFMMIK AGGNFBFNCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer POOLIAGGDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private KOEAIHHFHMH ENFOCMHEIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool EKKCDCMGMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer AJHOHNNAHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private KOEAIHHFHMH AFHNOHIEBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool GLFPMCJMMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer EPACPCCPMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private KOEAIHHFHMH KKCOGHMOABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
	public AINDJDJDBCA(AJBADNNILMM AGJMHGKNENJ, AIGGCCFMMIK AGGNFBFNCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6389D60", Offset = "0x6388560", VA = "0x186389D60", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x638B780", Offset = "0x6389F80", VA = "0x18638B780")]
	private void PIAGHHJKLPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x63894F0", Offset = "0x6387CF0", VA = "0x1863894F0", Slot = "4")]
	public void ACJAAONFIMK(OBBBDDOACPB DIPDOFGLHFF, BCDACAGAFEG KBLMGJFMDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x63897F0", Offset = "0x6387FF0", VA = "0x1863897F0", Slot = "5")]
	public void ACJAAONFIMK(POFLIBPJHGH ODBHMGBBLOA, BCDACAGAFEG KBLMGJFMDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x638B1A0", Offset = "0x63899A0", VA = "0x18638B1A0", Slot = "6")]
	public void NIFNEKHNNMD(POFLIBPJHGH ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6389C50", Offset = "0x6388450", VA = "0x186389C50", Slot = "7")]
	public void DOLAOFMFCBK(POFLIBPJHGH ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6389FB0", Offset = "0x63887B0", VA = "0x186389FB0", Slot = "21")]
	public void FMNPEDKIJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7FF6E0", Offset = "0x7FDEE0", VA = "0x1807FF6E0", Slot = "8")]
	public void FNKJPEAKIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6389FF0", Offset = "0x63887F0", VA = "0x186389FF0", Slot = "9")]
	public void GJHIGHPAIJJ(BCDACAGAFEG KBLMGJFMDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x638A520", Offset = "0x6388D20", VA = "0x18638A520", Slot = "10")]
	public void JJOKIPEEALJ(OBBBDDOACPB DIPDOFGLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x638A1F0", Offset = "0x63889F0", VA = "0x18638A1F0", Slot = "11")]
	public void JJOKIPEEALJ(POFLIBPJHGH ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x638B2D0", Offset = "0x6389AD0", VA = "0x18638B2D0", Slot = "12")]
	public void PEFEDJPONCF(OBBBDDOACPB DIPDOFGLHFF, FIJCAKKIEFB GFGNPBCFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x638B5A0", Offset = "0x6389DA0", VA = "0x18638B5A0", Slot = "13")]
	public void PEFEDJPONCF(POFLIBPJHGH ODBHMGBBLOA, FIJCAKKIEFB GFGNPBCFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x638B9C0", Offset = "0x638A1C0", VA = "0x18638B9C0", Slot = "22")]
	public void PNIFHNBCNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6389F10", Offset = "0x6388710", VA = "0x186389F10", Slot = "14")]
	public void EMEFDEPEOOB(POFLIBPJHGH ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x638A160", Offset = "0x6388960", VA = "0x18638A160", Slot = "15")]
	public void ICGHIJNINGN(POFLIBPJHGH ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x15921B0", Offset = "0x15909B0", VA = "0x1815921B0", Slot = "16")]
	public void MLADABFPCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x638A800", Offset = "0x6389000", VA = "0x18638A800", Slot = "17")]
	public void JNCBFEDLJNB(FIJCAKKIEFB GFGNPBCFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6389A10", Offset = "0x6388210", VA = "0x186389A10")]
	private void DOBLLLJBHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x638ADD0", Offset = "0x63895D0", VA = "0x18638ADD0", Slot = "18")]
	public void LLOGOLNFEDM(OBBBDDOACPB DIPDOFGLHFF, Vector3 DOICMHIAPFP, Vector3 DCAGDOFGKOM, Vector3 HKCGMLCEHFK, float CNLKAADLNIB, float MEFAJMNBHCC, IReadOnlyList<Camera> DCFMPGHMEOO, NNGMIFHAJGO EOHDKBIHLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x638A930", Offset = "0x6389130", VA = "0x18638A930", Slot = "19")]
	public void LLOGOLNFEDM(BHIILNDBAOK JDNELDEGCIH, Vector3 DOICMHIAPFP, Vector3 DCAGDOFGKOM, Vector3 HKCGMLCEHFK, float CNLKAADLNIB, float MEFAJMNBHCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class APPPFOINKIN : DKGDOFAMGBG, LEHAEAFDDGC, DPBBDDFMAIJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly ELELKMJINPM IDPDODAHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected Bounds HEEDNGFHBEM;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Bounds NKIHOFDCIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xD5F440", Offset = "0xD5DC40", VA = "0x180D5F440", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public virtual LLBEIELLHPH FBLEDDHPBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x638BB90", Offset = "0x638A390", VA = "0x18638BB90", Slot = "16")]
		get
		{
			return default(LLBEIELLHPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JNHMFJLBBJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B7C00", Offset = "0x7B6400", VA = "0x1807B7C00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B8160", Offset = "0x7B6960", VA = "0x1807B8160")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	protected abstract Hash128 HBNHJMALKCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int CFJAPJHKODE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7E1100", Offset = "0x7DF900", VA = "0x1807E1100", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public BHPOOINBLLN ELGNNNDEJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76CCB0", VA = "0x18076E4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool AEFJPFFCPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x10BAE60", Offset = "0x10B9660", VA = "0x1810BAE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	protected APPPFOINKIN(ELELKMJINPM DIPDOFGLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x638BA00", Offset = "0x638A200", VA = "0x18638BA00", Slot = "14")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "15")]
	public virtual bool CILINBIALOL(DJDIIJGKINF DIPDOFGLHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract int JMNELNIIDHC(CGDEOGEIDJN IPDIEBPGLHC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int JIMOENLIPGG(CGDEOGEIDJN IPDIEBPGLHC);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void EEMLDMLFKKH(CGDEOGEIDJN IPDIEBPGLHC, MBOGPMMPFMJ NHLFCMKCDNB, int LEAGLNALKKH = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract DJDIIJGKINF EBJNEOCPDGN();

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x638BB60", Offset = "0x638A360", VA = "0x18638BB60", Slot = "10")]
	public Hash128 KKGHDJAMOPL(int IPDIEBPGLHC)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract EBDFOAOLNLD HGHDCPCGHGG();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract MEFLACHKCLE NMKDGGCFOHK(CGDEOGEIDJN IPDIEBPGLHC, JobHandle EKJLKMKCKOI);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x638BB30", Offset = "0x638A330", VA = "0x18638BB30", Slot = "9")]
	public MEFLACHKCLE IPAPHJDHOEA(int IPDIEBPGLHC)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ShapeRendererConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6398290", Offset = "0x6396A90", VA = "0x186398290")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KDFLNHAFBKF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GFGOJDPJIHA : IEnumerable<CKOMLMBLOHJ>, IEnumerable, IEnumerator<CKOMLMBLOHJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private CKOMLMBLOHJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private CKOMLMBLOHJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public GFGOJDPJIHA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x63914F0", Offset = "0x638FCF0", VA = "0x1863914F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6391660", Offset = "0x638FE60", VA = "0x186391660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x63915C0", Offset = "0x638FDC0", VA = "0x1863915C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CKOMLMBLOHJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x63915C0", Offset = "0x638FDC0", VA = "0x1863915C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static CKOMLMBLOHJ[][] IALNGONEAGA;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static OCNHFKDFPPP BMIHEKENEDH;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static ShapeRendererConfig CNMOOHDBOME;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ComputeShader CHBKNGDHGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6394450", Offset = "0x6392C50", VA = "0x186394450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static SkinnedShapeRenderer FEDFAOJAHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6394700", Offset = "0x6392F00", VA = "0x186394700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x63944B0", Offset = "0x6392CB0", VA = "0x1863944B0")]
	public static Mesh CHBDCBOHNHJ(KCINHOACABA KJJFAEOKJFE, int IPDIEBPGLHC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6395040", Offset = "0x6393840", VA = "0x186395040")]
	public static int PFADFGGEJGN(KCINHOACABA KJJFAEOKJFE, int IPDIEBPGLHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6394300", Offset = "0x6392B00", VA = "0x186394300")]
	public static OCNHFKDFPPP AGEDLNMDJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6394950", Offset = "0x6393150", VA = "0x186394950")]
	[IteratorStateMachine(typeof(GFGOJDPJIHA))]
	private static IEnumerable<CKOMLMBLOHJ> LNEGNOCPGBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6394D90", Offset = "0x6393590", VA = "0x186394D90")]
	public static CKOMLMBLOHJ PCFLJDOMLNF(KCINHOACABA KJJFAEOKJFE, int IPDIEBPGLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6394760", Offset = "0x6392F60", VA = "0x186394760")]
	public static bool GPMKEOJALFK(this KCINHOACABA KJJFAEOKJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6394550", Offset = "0x6392D50", VA = "0x186394550")]
	public static void EANABIGIDIF(KCINHOACABA KJJFAEOKJFE, float3 JMOBBEBOHLN, [Out] JGILFCFGDLO GPCBHELDHIK, [Out] float3 HJBGEOEAPOD, [Out] float BHEGMGIMLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x63949C0", Offset = "0x63931C0", VA = "0x1863949C0")]
	public static void NDFIJMNOABM(Vector3 JMOBBEBOHLN, KCINHOACABA KJJFAEOKJFE, [Out] Vector3 HJBGEOEAPOD, [Out] float BHEGMGIMLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x63949B0", Offset = "0x63931B0", VA = "0x1863949B0")]
	[GDLMDJGGJNB(KNIGDGBBDKN.ExitingPlayMode, 0)]
	[NLNOFOJBGPA(0)]
	private static void MNGDKAGDCCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6394780", Offset = "0x6392F80", VA = "0x186394780")]
	[GDLMDJGGJNB(KNIGDGBBDKN.ExitingPlayMode, 0)]
	[NLNOFOJBGPA(0)]
	private static void HDDGGMHLCNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class MODELDFKLDG : AGDCNEJFEEA, IDisposable, AIGGCCFMMIK
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly MDDFGHLAHHA<OBBBDDOACPB, ELELKMJINPM> NKAOGFMCAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MDDFGHLAHHA<POFLIBPJHGH, APPPFOINKIN> NHGCCGFDPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly MDDFGHLAHHA<BHIILNDBAOK, FNPOKJDMNEI> GEBEJAEAING;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ELELKMJINPM HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6396950", Offset = "0x6395150", VA = "0x186396950", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public APPPFOINKIN HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x63969B0", Offset = "0x63951B0", VA = "0x1863969B0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public FNPOKJDMNEI HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6396A10", Offset = "0x6395210", VA = "0x186396A10", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool PHNNOOKGFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FB580", VA = "0x1807FCD80", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x86B8B0", Offset = "0x86A0B0", VA = "0x18086B8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6396B60", Offset = "0x6395360", VA = "0x186396B60")]
	public MODELDFKLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6396350", Offset = "0x6394B50", VA = "0x186396350", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6396730", Offset = "0x6394F30", VA = "0x186396730", Slot = "4")]
	public OBBBDDOACPB JFHINBNGKLF(FMNMPKALING AELCABDCBDD)
	{
		return default(OBBBDDOACPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6396730", Offset = "0x6394F30", VA = "0x186396730", Slot = "5")]
	public OBBBDDOACPB JFHINBNGKLF(FMNMPKALING AELCABDCBDD, bool GCHKPDBJJOB)
	{
		return default(OBBBDDOACPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x63965A0", Offset = "0x6394DA0", VA = "0x1863965A0", Slot = "6")]
	public void FEDDMFKHPDI(OBBBDDOACPB DIPDOFGLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x63963E0", Offset = "0x6394BE0", VA = "0x1863963E0", Slot = "7")]
	public void EHJIMIBKHAN(OBBBDDOACPB DIPDOFGLHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6396090", Offset = "0x6394890", VA = "0x186396090", Slot = "8")]
	public POFLIBPJHGH AGGGPANEMIM(OBBBDDOACPB DIPDOFGLHFF, ENMEBHFDBBB AELCABDCBDD)
	{
		return default(POFLIBPJHGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6396460", Offset = "0x6394C60", VA = "0x186396460", Slot = "9")]
	public POFLIBPJHGH FBKDAMLAPLO(OBBBDDOACPB DIPDOFGLHFF, JHADDNMICEP AELCABDCBDD)
	{
		return default(POFLIBPJHGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x63966A0", Offset = "0x6394EA0", VA = "0x1863966A0", Slot = "11")]
	public void JDONMKPOEGP(POFLIBPJHGH ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6396A70", Offset = "0x6395270", VA = "0x186396A70", Slot = "10")]
	public void PNANIBBEFEK(POFLIBPJHGH ODBHMGBBLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x63968E0", Offset = "0x63950E0", VA = "0x1863968E0", Slot = "20")]
	public IEnumerable<Renderer> NKECAHAJMHC(OBBBDDOACPB DIPDOFGLHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6396270", Offset = "0x6394A70", VA = "0x186396270", Slot = "12")]
	public BHIILNDBAOK BCDKNMHDKAE(DDGAOBMAIMB AELCABDCBDD)
	{
		return default(BHIILNDBAOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6396870", Offset = "0x6395070", VA = "0x186396870", Slot = "14")]
	public void MLKOBAKPJIE(BHIILNDBAOK JDNELDEGCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6396600", Offset = "0x6394E00", VA = "0x186396600", Slot = "16")]
	public Task IFJJPGLDDKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x63967D0", Offset = "0x6394FD0", VA = "0x1863967D0", Slot = "17")]
	public Task KLMIKIPNEFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x63961D0", Offset = "0x63949D0", VA = "0x1863961D0", Slot = "18")]
	public Task AJGILFFBDOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1B622D0", Offset = "0x1B60AD0", VA = "0x181B622D0", Slot = "19")]
	public void ACGILCIBJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x63962F0", Offset = "0x6394AF0", VA = "0x1863962F0", Slot = "13")]
	public void CEHIHINIBLG(BHIILNDBAOK JDNELDEGCIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EDDFMPMKKHK
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool LMNDNNGBADD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material CHJJCFLEPIF();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material CDEANPAMPBG();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material JEKONGEONGD();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OKBPLOBEKNJ(JEDEOHKCICL DMJAABFNGIE);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LMINPNEGICL(OFBGHIABOOI IHIJBNOHKKP);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILOPHILLNBL(GameObject CBBCDNDPNHF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JNELKIJLHNG(GameObject CBBCDNDPNHF, bool GBMLPLNIMLH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class EDODDKAGNKL
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static EDDFMPMKKHK PCEPPDLMHCM;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool LMNDNNGBADD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x638E1E0", Offset = "0x638C9E0", VA = "0x18638E1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x638E3E0", Offset = "0x638CBE0", VA = "0x18638E3E0")]
	public static void JBNBLGJBCIM(EDDFMPMKKHK IBMHGIJMMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x638E2A0", Offset = "0x638CAA0", VA = "0x18638E2A0")]
	public static Material CHJJCFLEPIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x638E240", Offset = "0x638CA40", VA = "0x18638E240")]
	public static Material CDEANPAMPBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x638E440", Offset = "0x638CC40", VA = "0x18638E440")]
	public static Material JEKONGEONGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x638E600", Offset = "0x638CE00", VA = "0x18638E600")]
	public static int OKBPLOBEKNJ(JEDEOHKCICL DMJAABFNGIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x638E590", Offset = "0x638CD90", VA = "0x18638E590")]
	public static int LMINPNEGICL(OFBGHIABOOI IHIJBNOHKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x638E300", Offset = "0x638CB00", VA = "0x18638E300")]
	public static void ILOPHILLNBL(GameObject CBBCDNDPNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x638E4A0", Offset = "0x638CCA0", VA = "0x18638E4A0")]
	public static void JNELKIJLHNG(GameObject CBBCDNDPNHF, bool GBMLPLNIMLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FNPOKJDMNEI : GPNBKLAGOGP
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KCAKJGCHELK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public FNPOKJDMNEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public KCAKJGCHELK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6394270", Offset = "0x6392A70", VA = "0x186394270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6393F00", Offset = "0x6392700", VA = "0x186393F00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6394120", Offset = "0x6392920", VA = "0x186394120")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6394220", Offset = "0x6392A20", VA = "0x186394220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6394170", Offset = "0x6392970", VA = "0x186394170", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6394170", Offset = "0x6392970", VA = "0x186394170", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly DDGAOBMAIMB ODKCDNJMIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly AIGGCCFMMIK AGGNFBFNCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private LCFJEIJOBGG NBMIPMJNHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<OHFDFDMDBNB> GFDPFMANJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<OHFDFDMDBNB> OAMMNMDNDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject AEKECDPLCAL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6391040", Offset = "0x638F840", VA = "0x186391040")]
	public static FNPOKJDMNEI HGMLNLLKEPG(DDGAOBMAIMB AELCABDCBDD, AIGGCCFMMIK AGGNFBFNCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6391410", Offset = "0x638FC10", VA = "0x186391410")]
	private FNPOKJDMNEI(DDGAOBMAIMB AELCABDCBDD, AIGGCCFMMIK AGGNFBFNCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6390BB0", Offset = "0x638F3B0", VA = "0x186390BB0")]
	public void FILLLFKPAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6390B30", Offset = "0x638F330", VA = "0x186390B30")]
	[IteratorStateMachine(typeof(KCAKJGCHELK))]
	public IEnumerable<Renderer> DLFDHNBCNOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6390060", Offset = "0x638E860", VA = "0x186390060", Slot = "4")]
	public void BBGCFMECCIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x63913E0", Offset = "0x638FBE0", VA = "0x1863913E0")]
	private void NCMDCBANKJD(Vector3 CJBHGLHMBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6391190", Offset = "0x638F990", VA = "0x186391190")]
	public void IDAKBLNHKFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OHFDFDMDBNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct BCDIGFPGDKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public MBOGPMMPFMJ IPPNPELOHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DJDIIJGKINF JHGFPDBOMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int JGFOBGCOLAO;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EJPEMCLFFCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OHFDFDMDBNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CGDEOGEIDJN lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<BCDIGFPGDKA> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public KKLKCKNAHFG combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EJPEMCLFFCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x638E7E0", Offset = "0x638CFE0", VA = "0x18638E7E0")]
		internal JobHandle EHIAOAJMCDN()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x638E840", Offset = "0x638D040", VA = "0x18638E840")]
		internal void OFMALHOHAIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x638E670", Offset = "0x638CE70", VA = "0x18638E670")]
		internal void AEJJFODBBKI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] OJFJGPKOAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private IHPHIDCEEPH CPOJGGJAGLC;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 MOBGKDIIGFL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh LBHOJOKJOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int OJAEFINFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x768D90", Offset = "0x767590", VA = "0x180768D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76B5C0", Offset = "0x769DC0", VA = "0x18076B5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6396F50", Offset = "0x6395750", VA = "0x186396F50")]
	public void CDMKGAIKAMG(List<DJDIIJGKINF> ACJBCJPOKKG, Matrix4x4[] EAHAAOABANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6397630", Offset = "0x6395E30", VA = "0x186397630")]
	public static List<OHFDFDMDBNB> KLKFANDJKFE(List<ELELKMJINPM> GCDMFMJCPGM, CGDEOGEIDJN IPDIEBPGLHC, Bounds FLFNJJPOPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x63972C0", Offset = "0x6395AC0", VA = "0x1863972C0")]
	private JobHandle HCLAJLODHGM(KKLKCKNAHFG GFPLHFKNJGA, int ODACBGOPAOP, int EAODGDLNNLI, CGDEOGEIDJN IPDIEBPGLHC, List<BCDIGFPGDKA> GNAHCNIJOFF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x63971E0", Offset = "0x63959E0", VA = "0x1863971E0")]
	private void GCOELKIECEP(List<BCDIGFPGDKA> GNAHCNIJOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6397E60", Offset = "0x6396660", VA = "0x186397E60")]
	private OHFDFDMDBNB(List<BCDIGFPGDKA> GNAHCNIJOFF, int ODACBGOPAOP, int EAODGDLNNLI, CGDEOGEIDJN IPDIEBPGLHC, Bounds FLFNJJPOPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6397140", Offset = "0x6395940", VA = "0x186397140", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private MaterialPropertyBlock DNLIOHDDFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private OHFDFDMDBNB LFKHDLANNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<DJDIIJGKINF> DLJCKJCECBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture AFKDHCBCOCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer AHDHAIKEDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader CKDEBEOIEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] CKPEFBHIGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int FHAPCOPMHBF;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public MeshRenderer ABCKPKHOPNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x766130", Offset = "0x764930", VA = "0x180766130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int GICLBANDEKL
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x6398F90", Offset = "0x6397790", VA = "0x186398F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6398630", Offset = "0x6396E30", VA = "0x186398630")]
		public static List<SkinnedShapeRenderer> Create(GameObject DIPDOFGLHFF, List<OHFDFDMDBNB> JAOGLHIIJJD, List<DJDIIJGKINF> DLJCKJCECBH, Material JGLFCCBLACF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x63988C0", Offset = "0x63970C0", VA = "0x1863988C0")]
		public void Init(OHFDFDMDBNB LFKHDLANNJG, List<DJDIIJGKINF> DLJCKJCECBH, Material JGLFCCBLACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6398EF0", Offset = "0x63976F0", VA = "0x186398EF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6398E50", Offset = "0x6397650", VA = "0x186398E50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6398E10", Offset = "0x6397610", VA = "0x186398E10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6398D50", Offset = "0x6397550", VA = "0x186398D50")]
		private void NGAGFFECHOA(ScriptableRenderContext FJNGJOFLBMD, Camera[] MCHENHHCEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x63982C0", Offset = "0x6396AC0", VA = "0x1863982C0")]
		private void CDMKGAIKAMG(CommandBuffer MLIEFBBOMEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
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
