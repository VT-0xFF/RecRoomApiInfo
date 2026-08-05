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
public class ADLMFLBPAGI : JJAAKEFKIGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte MNLGIKLPIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] IPIFIIOCFHJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FDHHGOOKNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x807520", Offset = "0x805D20", VA = "0x180807520", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x807500", Offset = "0x805D00", VA = "0x180807500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GIIDIEBDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A1FB0", Offset = "0x7A07B0", VA = "0x1807A1FB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A15B0", Offset = "0x79FDB0", VA = "0x1807A15B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float CBGLIFKNBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B4810", VA = "0x1807B6010", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B6C70", Offset = "0x7B5470", VA = "0x1807B6C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JNBPGFLPOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B6920", Offset = "0x7B5120", VA = "0x1807B6920", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B47F0", VA = "0x1807B5FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> IPHKJPLDIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6342010", Offset = "0x6340810", VA = "0x186342010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> CFHMOPLHJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6341C70", Offset = "0x6340470", VA = "0x186341C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject AAPMKHJIGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76B2A0", Offset = "0x769AA0", VA = "0x18076B2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte FJHJGJFNMGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6342060", Offset = "0x6340860", VA = "0x186342060", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x63420B0", Offset = "0x63408B0", VA = "0x1863420B0")]
	public ADLMFLBPAGI(List<GMHHLNKACIJ> DMCLKEOIPOP, List<GMHHLNKACIJ> IGOOBDEBOBC, List<FEDLPIHABFD> PANMMGKOKGH, Material LGHJCFHBOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6341DA0", Offset = "0x63405A0", VA = "0x186341DA0")]
	private int EECNLCJIOKC(List<GMHHLNKACIJ> MNIDFKMMDJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6341B10", Offset = "0x6340310", VA = "0x186341B10")]
	private void AOAIKDDPNIH(int JOCBKCHCPDN, bool MGALCAEGIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6341EC0", Offset = "0x63406C0", VA = "0x186341EC0")]
	public void IBCMEDCLBDF(Vector3 GPKKMPBLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6341CA0", Offset = "0x63404A0", VA = "0x186341CA0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6341AD0", Offset = "0x63402D0", VA = "0x186341AD0")]
	public void AGDHFHHIJAM(Transform OEKMOCIJAHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PNKGGCKHOEM : ONDOKBJAAPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class GHGMBIFFIFI : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PNKGGCKHOEM <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public GHGMBIFFIFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6344230", Offset = "0x6342A30", VA = "0x186344230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6343C20", Offset = "0x6342420", VA = "0x186343C20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6343BD0", Offset = "0x63423D0", VA = "0x186343BD0")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6343B30", Offset = "0x6342330", VA = "0x186343B30")]
		private void ADBDFKNJMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6343B80", Offset = "0x6342380", VA = "0x186343B80")]
		private void FJBACAKCOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63441E0", Offset = "0x63429E0", VA = "0x1863441E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6344130", Offset = "0x6342930", VA = "0x186344130", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6344130", Offset = "0x6342930", VA = "0x186344130", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class MGJLDIIEOED : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PNKGGCKHOEM <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public MGJLDIIEOED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6349A10", Offset = "0x6348210", VA = "0x186349A10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63495A0", Offset = "0x6347DA0", VA = "0x1863495A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6349550", Offset = "0x6347D50", VA = "0x186349550")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6349500", Offset = "0x6347D00", VA = "0x186349500")]
		private void ADBDFKNJMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x63499C0", Offset = "0x63481C0", VA = "0x1863499C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6349910", Offset = "0x6348110", VA = "0x186349910", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6349910", Offset = "0x6348110", VA = "0x186349910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IHBGBGAIGLD MPNGAKIOPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<NDAINBGMLHF> EOEGCEMFOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> CKKHPAMCKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer GLGBMDCBDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool CAJNNNKHDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool LANLMHLDPFJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<HJOLPJMNPAD> BHFEHMLFCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HGLBKMAFMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6352690", Offset = "0x6350E90", VA = "0x186352690", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FEDLPIHABFD OBMOPJFGLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6351EF0", Offset = "0x63506F0", VA = "0x186351EF0", Slot = "8")]
		get
		{
			return default(FEDLPIHABFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> FBHBIJEFMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7612F0", VA = "0x180762AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63526D0", Offset = "0x6350ED0", VA = "0x1863526D0")]
	private bool MPGCHJDNKCP(NDAINBGMLHF FECMDKHDNMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63520C0", Offset = "0x63508C0", VA = "0x1863520C0")]
	private static bool LJOLENHEJDB(NDAINBGMLHF FECMDKHDNMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6352A40", Offset = "0x6351240", VA = "0x186352A40")]
	public PNKGGCKHOEM(IHBGBGAIGLD KOIMDAJNDOD, bool NENNKBNIFNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6351980", Offset = "0x6350180", VA = "0x186351980", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6351B00", Offset = "0x6350300", VA = "0x186351B00")]
	public void EIGFNHEIDIC(NDAINBGMLHF FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6352920", Offset = "0x6351120", VA = "0x186352920")]
	public void OICBJJIPNIH(NDAINBGMLHF FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6351480", Offset = "0x634FC80", VA = "0x186351480", Slot = "4")]
	public void DPOMIBPANFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6351CA0", Offset = "0x63504A0", VA = "0x186351CA0")]
	public void HFBGFFHILGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x63526F0", Offset = "0x6350EF0", VA = "0x1863526F0")]
	private void NOPCGPIHNMD(List<NDAINBGMLHF> EOEGCEMFOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6349CE0", Offset = "0x63484E0", VA = "0x186349CE0")]
	private static Material IJCJLJAIFHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6352880", Offset = "0x6351080", VA = "0x186352880")]
	private void NOPCGPIHNMD(NDAINBGMLHF FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6351340", Offset = "0x634FB40", VA = "0x186351340")]
	private void AFNOKEOPMKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63520E0", Offset = "0x63508E0", VA = "0x1863520E0")]
	public void MBHDNFJIGAI(bool FMBHPPIFIFO, bool JIPPCDHMBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6352040", Offset = "0x6350840", VA = "0x186352040")]
	protected void LECCNIFGMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6351FC0", Offset = "0x63507C0", VA = "0x186351FC0")]
	[IteratorStateMachine(typeof(GHGMBIFFIFI))]
	public IEnumerable<Renderer> KGBLKBOFNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6351400", Offset = "0x634FC00", VA = "0x186351400")]
	[IteratorStateMachine(typeof(MGJLDIIEOED))]
	public IEnumerable<Renderer> DICKMDHHDAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class NECMDCFGAHH : NDAINBGMLHF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct BGKFFFLIOBJ : CADDPHNGDAA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private ANLJNALAKBD MPLECHMLAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle LOGMOOGMKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private DIBOPPIAHCF HFHFAACCGGD;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6342440", Offset = "0x6340C40", VA = "0x186342440")]
		public BGKFFFLIOBJ(ANLJNALAKBD MPLECHMLAIA, JobHandle LOGMOOGMKPB, DIBOPPIAHCF HFHFAACCGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6342410", Offset = "0x6340C10", VA = "0x186342410", Slot = "4")]
		public ANLJNALAKBD LEICLPMPLAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x63423C0", Offset = "0x6340BC0", VA = "0x1863423C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly HBDGMIMMFHO KHLODHLNGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float GHMDEACFNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 JBNJNPEBDPK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 KNEIEDGBHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x634A3B0", Offset = "0x6348BB0", VA = "0x18634A3B0", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x634BB40", Offset = "0x634A340", VA = "0x18634BB40")]
	public NECMDCFGAHH(PNKGGCKHOEM KLOAHFNCDKG, HBDGMIMMFHO KOIMDAJNDOD, bool NENNKBNIFNM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "15")]
	public override bool AOAKHNBHDCO(FEDLPIHABFD KLOAHFNCDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x634AFB0", Offset = "0x63497B0", VA = "0x18634AFB0", Slot = "17")]
	public override int EECNLCJIOKC(JNDHJMNFEHO OLLEBMKIFPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x634B8A0", Offset = "0x634A0A0", VA = "0x18634B8A0", Slot = "18")]
	public override int LDHNOKGHJPE(JNDHJMNFEHO OLLEBMKIFPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x634B180", Offset = "0x6349980", VA = "0x18634B180", Slot = "19")]
	public override void GPLJANHAPJI(JNDHJMNFEHO OLLEBMKIFPO, LLAEMFOHIND OECGCCLJNEK, int KFBJIKKGIHF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x634BA70", Offset = "0x634A270", VA = "0x18634BA70", Slot = "20")]
	public override FEDLPIHABFD NFBOIDPEJFF()
	{
		return default(FEDLPIHABFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x634AE00", Offset = "0x6349600", VA = "0x18634AE00", Slot = "22")]
	public override PMAJPDDBAFD CHBBFJMFGJD()
	{
		return default(PMAJPDDBAFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x634A4E0", Offset = "0x6348CE0", VA = "0x18634A4E0", Slot = "23")]
	public override CADDPHNGDAA CBGEAMBDFDP(JNDHJMNFEHO OLLEBMKIFPO, JobHandle LOGMOOGMKPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DefaultMember("Item")]
public interface ICCGAGHPKMA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PNKGGCKHOEM NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NDAINBGMLHF NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ICGCCADEEIO NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class NJFDKFCJKFG : JMJOKMNENBD, IDisposable, ICCGAGHPKMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DGFMEFGJCBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NJFDKFCJKFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6343360", Offset = "0x6341B60", VA = "0x186343360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6343880", Offset = "0x6342080", VA = "0x186343880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly ONHMPLGNLPA<LKGNCEIDMAL, PNKGGCKHOEM> JIGLJFOJFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly ONHMPLGNLPA<LNCMOMKNIHJ, NDAINBGMLHF> EOEGCEMFOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly ONHMPLGNLPA<EKGGCBHAACJ, ICGCCADEEIO> KFDNPIPFMOI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PNKGGCKHOEM NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x634BDD0", Offset = "0x634A5D0", VA = "0x18634BDD0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public NDAINBGMLHF NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x634BE30", Offset = "0x634A630", VA = "0x18634BE30", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ICGCCADEEIO NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x634BD70", Offset = "0x634A570", VA = "0x18634BD70", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool EOLKHIGAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4F0", Offset = "0x7FBCF0", VA = "0x1807FD4F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x867C80", Offset = "0x866480", VA = "0x180867C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x634DD00", Offset = "0x634C500", VA = "0x18634DD00")]
	public NJFDKFCJKFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x634C2D0", Offset = "0x634AAD0", VA = "0x18634C2D0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x634CF20", Offset = "0x634B720", VA = "0x18634CF20", Slot = "4")]
	public LKGNCEIDMAL GBIGIENIKPD(IHBGBGAIGLD KOIMDAJNDOD)
	{
		return default(LKGNCEIDMAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x634CCA0", Offset = "0x634B4A0", VA = "0x18634CCA0", Slot = "5")]
	public LKGNCEIDMAL GBIGIENIKPD(IHBGBGAIGLD KOIMDAJNDOD, bool NENNKBNIFNM)
	{
		return default(LKGNCEIDMAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x634BE90", Offset = "0x634A690", VA = "0x18634BE90", Slot = "6")]
	public void BLKDKIMAOFA(LKGNCEIDMAL KLOAHFNCDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x634C460", Offset = "0x634AC60", VA = "0x18634C460", Slot = "7")]
	public void ECPMEAHHLFH(LKGNCEIDMAL KLOAHFNCDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x634D5C0", Offset = "0x634BDC0", VA = "0x18634D5C0", Slot = "8")]
	public LNCMOMKNIHJ JNKMMJAKCKG(LKGNCEIDMAL KLOAHFNCDKG, NEFLADIEICF KOIMDAJNDOD)
	{
		return default(LNCMOMKNIHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x634C7C0", Offset = "0x634AFC0", VA = "0x18634C7C0", Slot = "9")]
	public LNCMOMKNIHJ EJNOBFKDMDJ(LKGNCEIDMAL KLOAHFNCDKG, HBDGMIMMFHO KOIMDAJNDOD)
	{
		return default(LNCMOMKNIHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x634CFA0", Offset = "0x634B7A0", VA = "0x18634CFA0", Slot = "11")]
	public void HLHPAJKLMEF(LNCMOMKNIHJ FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x634D360", Offset = "0x634BB60", VA = "0x18634D360", Slot = "10")]
	public void JHAPCFONALO(LNCMOMKNIHJ FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x634C260", Offset = "0x634AA60", VA = "0x18634C260", Slot = "20")]
	public IEnumerable<Renderer> DGHLJECPJCB(LKGNCEIDMAL KLOAHFNCDKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x634C0F0", Offset = "0x634A8F0", VA = "0x18634C0F0", Slot = "12")]
	public EKGGCBHAACJ CPLCCOADMDD(PIDEGFHGMKB KOIMDAJNDOD)
	{
		return default(EKGGCBHAACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x634CF30", Offset = "0x634B730", VA = "0x18634CF30", Slot = "14")]
	public void HKJILCADEPO(EKGGCBHAACJ AHFFLKDLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x634DAA0", Offset = "0x634C2A0", VA = "0x18634DAA0", Slot = "16")]
	public Task NGEEEECCABG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x634BBF0", Offset = "0x634A3F0", VA = "0x18634BBF0", Slot = "17")]
	public Task AEIHJCOOFKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x634DC30", Offset = "0x634C430", VA = "0x18634DC30", Slot = "18")]
	[AsyncStateMachine(typeof(DGFMEFGJCBM))]
	public Task PHKMMNMOAKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x634C170", Offset = "0x634A970", VA = "0x18634C170", Slot = "19")]
	public void DBJBGOMELIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x634C200", Offset = "0x634AA00", VA = "0x18634C200", Slot = "13")]
	public void DDKHOJIDKKK(EKGGCBHAACJ AHFFLKDLDMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class PEMKJIJMFON : NDAINBGMLHF
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private struct ACOPIHOAKFG : CADDPHNGDAA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ANLJNALAKBD MPLECHMLAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle LOGMOOGMKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private BKHAEOEBPNM HFHFAACCGGD;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6341A80", Offset = "0x6340280", VA = "0x186341A80")]
		public ACOPIHOAKFG(ANLJNALAKBD MPLECHMLAIA, JobHandle LOGMOOGMKPB, BKHAEOEBPNM HFHFAACCGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6341A50", Offset = "0x6340250", VA = "0x186341A50", Slot = "4")]
		public ANLJNALAKBD LEICLPMPLAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6341A00", Offset = "0x6340200", VA = "0x186341A00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly NEFLADIEICF KJPNLGBHIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] MCKHOGEGCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 JBNJNPEBDPK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override GEBHNBLDLCA EAPDBFFGKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6350E00", Offset = "0x634F600", VA = "0x186350E00", Slot = "16")]
		get
		{
			return default(GEBHNBLDLCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private Vector3 OHKNJJFIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6350250", Offset = "0x634EA50", VA = "0x186350250")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	protected override Hash128 KNEIEDGBHND
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x634F440", Offset = "0x634DC40", VA = "0x18634F440", Slot = "21")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6351290", Offset = "0x634FA90", VA = "0x186351290")]
	public PEMKJIJMFON(PNKGGCKHOEM KLOAHFNCDKG, NEFLADIEICF KOIMDAJNDOD, bool ILNNBDCMLMN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x634EFB0", Offset = "0x634D7B0", VA = "0x18634EFB0", Slot = "15")]
	public override bool AOAKHNBHDCO(FEDLPIHABFD KLOAHFNCDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x63501B0", Offset = "0x634E9B0", VA = "0x1863501B0", Slot = "17")]
	public override int EECNLCJIOKC(JNDHJMNFEHO OLLEBMKIFPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6350D60", Offset = "0x634F560", VA = "0x186350D60", Slot = "18")]
	public override int LDHNOKGHJPE(JNDHJMNFEHO OLLEBMKIFPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x634FF60", Offset = "0x634E760", VA = "0x18634FF60")]
	private int CKAAMDHHFMH(JNDHJMNFEHO OLLEBMKIFPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x63505D0", Offset = "0x634EDD0", VA = "0x1863505D0", Slot = "19")]
	public override void GPLJANHAPJI(JNDHJMNFEHO OLLEBMKIFPO, LLAEMFOHIND OECGCCLJNEK, int KFBJIKKGIHF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x63511C0", Offset = "0x634F9C0", VA = "0x1863511C0", Slot = "20")]
	public override FEDLPIHABFD NFBOIDPEJFF()
	{
		return default(FEDLPIHABFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x634FDB0", Offset = "0x634E5B0", VA = "0x18634FDB0", Slot = "22")]
	public override PMAJPDDBAFD CHBBFJMFGJD()
	{
		return default(PMAJPDDBAFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x634F570", Offset = "0x634DD70", VA = "0x18634F570", Slot = "23")]
	public override CADDPHNGDAA CBGEAMBDFDP(JNDHJMNFEHO OLLEBMKIFPO, JobHandle LOGMOOGMKPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DGKOLLLOEKM
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEGBDNJDBPC(NJNMPGINBDC BJKOKHNAAID, Renderer GHDBAAFPFPI, int FFKCIMODIKD);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FDBJPICNOKN(Renderer GHDBAAFPFPI, AFJJKEILDGC HJBKPCAHCIG, Vector3 LCJCAKBOJFD, Vector3 PNMJODLKANA, Vector3 JKJDEGNCEDI, float KJHBMGHEOGC, float FHFNMHAIGPJ, float ECMBGAJDNPL = -1f, [Optional] Color? JFJPGCGPBNP, [Optional] IReadOnlyList<Camera> PMCAKIMANJL);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILIAEDCINJC(Renderer GHDBAAFPFPI, int FFKCIMODIKD);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GFBBOBEFPIH();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCNCFMGMHKA(int LJGGFHFIAFM, PFCOBFLEOJA BJKOKHNAAID, Renderer GHDBAAFPFPI, int FFKCIMODIKD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GIAOGOIAOGM : LPLNEKGDBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class FFGMBHJEPKK : JPLCDIPDGHD<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6343AE0", Offset = "0x63422E0", VA = "0x186343AE0")]
		public FFGMBHJEPKK(string BOBHOMKFHJB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly DGKOLLLOEKM LFEDDFLDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly ICCGAGHPKMA GELCAGJACCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer ANDAODMFBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private FFGMBHJEPKK JAHPCHHBEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool NMGGADKNFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer MIDKFHILHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private FFGMBHJEPKK ONLMJDFDOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool LEAOLDPGPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer DPGPCJCKJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private FFGMBHJEPKK CPEMKAGMDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x760A40", Offset = "0x75F240", VA = "0x180760A40")]
	public GIAOGOIAOGM(DGKOLLLOEKM BBPDCCFHENH, ICCGAGHPKMA GELCAGJACCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x63448E0", Offset = "0x63430E0", VA = "0x1863448E0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x63460E0", Offset = "0x63448E0", VA = "0x1863460E0")]
	private void NIHMPNMMODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6344EC0", Offset = "0x63436C0", VA = "0x186344EC0", Slot = "4")]
	public void ICPIMHKNNMH(LKGNCEIDMAL KLOAHFNCDKG, PFCOBFLEOJA JMCPMFFLLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6344CA0", Offset = "0x63434A0", VA = "0x186344CA0", Slot = "5")]
	public void ICPIMHKNNMH(LNCMOMKNIHJ FECMDKHDNMG, PFCOBFLEOJA JMCPMFFLLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x63447B0", Offset = "0x6342FB0", VA = "0x1863447B0", Slot = "6")]
	public void DHNDKDBMGHP(LNCMOMKNIHJ FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6344460", Offset = "0x6342C60", VA = "0x186344460", Slot = "7")]
	public void CKBHLGLAJAK(LNCMOMKNIHJ FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6344420", Offset = "0x6342C20", VA = "0x186344420", Slot = "21")]
	public void BCJBPKOAKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7FFE50", Offset = "0x7FE650", VA = "0x1807FFE50", Slot = "8")]
	public void PEHPJAIFJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6344B30", Offset = "0x6343330", VA = "0x186344B30", Slot = "9")]
	public void GCAHGCICOMG(PFCOBFLEOJA JMCPMFFLLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6346650", Offset = "0x6344E50", VA = "0x186346650", Slot = "10")]
	public void OMDHHPCIHGL(LKGNCEIDMAL KLOAHFNCDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6346320", Offset = "0x6344B20", VA = "0x186346320", Slot = "11")]
	public void OMDHHPCIHGL(LNCMOMKNIHJ FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x63451C0", Offset = "0x63439C0", VA = "0x1863451C0", Slot = "12")]
	public void IFFFHGELEFD(LKGNCEIDMAL KLOAHFNCDKG, NJNMPGINBDC BJKOKHNAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6345490", Offset = "0x6343C90", VA = "0x186345490", Slot = "13")]
	public void IFFFHGELEFD(LNCMOMKNIHJ FECMDKHDNMG, NJNMPGINBDC BJKOKHNAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6346010", Offset = "0x6344810", VA = "0x186346010", Slot = "22")]
	public void JPLBMNIOJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6344A90", Offset = "0x6343290", VA = "0x186344A90", Slot = "14")]
	public void FLBEBIFEDOB(LNCMOMKNIHJ FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6346050", Offset = "0x6344850", VA = "0x186346050", Slot = "15")]
	public void NAPCEJPOHPH(LNCMOMKNIHJ FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x15A6CB0", Offset = "0x15A54B0", VA = "0x1815A6CB0", Slot = "16")]
	public void JBJHCJNJPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6345EE0", Offset = "0x63446E0", VA = "0x186345EE0", Slot = "17")]
	public void JMGNPLPNDMA(NJNMPGINBDC BJKOKHNAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6344570", Offset = "0x6342D70", VA = "0x186344570")]
	private void DAPIHMAFKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6345B10", Offset = "0x6344310", VA = "0x186345B10", Slot = "18")]
	public void IJCFHNIALOK(LKGNCEIDMAL KLOAHFNCDKG, Vector3 LCJCAKBOJFD, Vector3 PNMJODLKANA, Vector3 JKJDEGNCEDI, float KJHBMGHEOGC, float FHFNMHAIGPJ, IReadOnlyList<Camera> ECHEBEDNLBH, AFJJKEILDGC HJBKPCAHCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6345670", Offset = "0x6343E70", VA = "0x186345670", Slot = "19")]
	public void IJCFHNIALOK(EKGGCBHAACJ AHFFLKDLDMN, Vector3 LCJCAKBOJFD, Vector3 PNMJODLKANA, Vector3 JKJDEGNCEDI, float KJHBMGHEOGC, float FHFNMHAIGPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class NDAINBGMLHF : FCNHNEPKNEN, HJOLPJMNPAD, BIDFGLJCHBO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly PNKGGCKHOEM AAPMKHJIGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected Bounds BOFAFDDKADB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Bounds OFPOCAKKLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xD3C770", Offset = "0xD3AF70", VA = "0x180D3C770", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public virtual GEBHNBLDLCA EAPDBFFGKNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x634A2F0", Offset = "0x6348AF0", VA = "0x18634A2F0", Slot = "16")]
		get
		{
			return default(GEBHNBLDLCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LANLMHLDPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CB0", Offset = "0x7B54B0", VA = "0x1807B6CB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B6890", Offset = "0x7B5090", VA = "0x1807B6890")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	protected abstract Hash128 KNEIEDGBHND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int FCOLANCDCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB70", Offset = "0x7DC370", VA = "0x1807DDB70", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ANBPMMDBELG CDFJFBNINHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7612F0", VA = "0x180762AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool FPMEJLOPPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x10A7630", Offset = "0x10A5E30", VA = "0x1810A7630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	protected NDAINBGMLHF(PNKGGCKHOEM KLOAHFNCDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x634A1C0", Offset = "0x63489C0", VA = "0x18634A1C0", Slot = "14")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "15")]
	public virtual bool AOAKHNBHDCO(FEDLPIHABFD KLOAHFNCDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract int EECNLCJIOKC(JNDHJMNFEHO OLLEBMKIFPO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract int LDHNOKGHJPE(JNDHJMNFEHO OLLEBMKIFPO);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract void GPLJANHAPJI(JNDHJMNFEHO OLLEBMKIFPO, LLAEMFOHIND OECGCCLJNEK, int KFBJIKKGIHF = -1);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract FEDLPIHABFD NFBOIDPEJFF();

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x634A380", Offset = "0x6348B80", VA = "0x18634A380", Slot = "10")]
	public Hash128 NLPBJMJDFMA(int OLLEBMKIFPO)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract PMAJPDDBAFD CHBBFJMFGJD();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract CADDPHNGDAA CBGEAMBDFDP(JNDHJMNFEHO OLLEBMKIFPO, JobHandle LOGMOOGMKPB);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x634A190", Offset = "0x6348990", VA = "0x18634A190", Slot = "9")]
	public CADDPHNGDAA ALFKDFCCJPO(int OLLEBMKIFPO)
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
		[Cpp2IlInjected.Address(RVA = "0x6352B30", Offset = "0x6351330", VA = "0x186352B30")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OGMAMPBKHPF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NBLAMEMNNEG : IEnumerable<MIICBGOAHOJ>, IEnumerable, IEnumerator<MIICBGOAHOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private MIICBGOAHOJ <>2__current;

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
		private MIICBGOAHOJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public NBLAMEMNNEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6349FD0", Offset = "0x63487D0", VA = "0x186349FD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x634A140", Offset = "0x6348940", VA = "0x18634A140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x634A0A0", Offset = "0x63488A0", VA = "0x18634A0A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MIICBGOAHOJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x634A0A0", Offset = "0x63488A0", VA = "0x18634A0A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static MIICBGOAHOJ[][] JKDKNLOGPLM;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static GKECCAAHCDI AFEALKOJGFG;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static ShapeRendererConfig JEBFBJJPNHD;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ComputeShader LEHDHLEJOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x634EB20", Offset = "0x634D320", VA = "0x18634EB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static SkinnedShapeRenderer FGCBILBLCNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x634E1B0", Offset = "0x634C9B0", VA = "0x18634E1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x634EA60", Offset = "0x634D260", VA = "0x18634EA60")]
	public static Mesh LMMGINDPNFO(CJKCDDOLIDB DHIGOOPGBKC, int OLLEBMKIFPO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x634E210", Offset = "0x634CA10", VA = "0x18634E210")]
	public static int CLJFCGKJAAC(CJKCDDOLIDB DHIGOOPGBKC, int OLLEBMKIFPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x634E220", Offset = "0x634CA20", VA = "0x18634E220")]
	public static GKECCAAHCDI EEBIKEAEOFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x634E740", Offset = "0x634CF40", VA = "0x18634E740")]
	[IteratorStateMachine(typeof(NBLAMEMNNEG))]
	private static IEnumerable<MIICBGOAHOJ> FOEFGNCDAIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x634E7B0", Offset = "0x634CFB0", VA = "0x18634E7B0")]
	public static MIICBGOAHOJ KHIGIPMHJLE(CJKCDDOLIDB DHIGOOPGBKC, int OLLEBMKIFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x634EB00", Offset = "0x634D300", VA = "0x18634EB00")]
	public static bool LMNFKHBEPLC(this CJKCDDOLIDB DHIGOOPGBKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x634ED50", Offset = "0x634D550", VA = "0x18634ED50")]
	public static void PJGMPCCPLIA(CJKCDDOLIDB DHIGOOPGBKC, float3 FKHBDAPIMJA, [Out] LKCKKNIKBKM OCPBJONADDO, [Out] float3 OJDBHCPBDBC, [Out] float EKDHAAGEGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x634E370", Offset = "0x634CB70", VA = "0x18634E370")]
	public static void FGGPIIDBEJO(Vector3 FKHBDAPIMJA, CJKCDDOLIDB DHIGOOPGBKC, [Out] Vector3 OJDBHCPBDBC, [Out] float EKDHAAGEGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x634E7A0", Offset = "0x634CFA0", VA = "0x18634E7A0")]
	[EODBIJHEOFL(IPEKLHHMMFE.ExitingPlayMode, 0)]
	private static void GMBEKCOLMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x634EB80", Offset = "0x634D380", VA = "0x18634EB80")]
	[EODBIJHEOFL(IPEKLHHMMFE.ExitingPlayMode, 0)]
	private static void OGAJNJFMCCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class DBHLFDDMLPC : JMJOKMNENBD, IDisposable, ICCGAGHPKMA
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly ONHMPLGNLPA<LKGNCEIDMAL, PNKGGCKHOEM> JIGLJFOJFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly ONHMPLGNLPA<LNCMOMKNIHJ, NDAINBGMLHF> EOEGCEMFOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly ONHMPLGNLPA<EKGGCBHAACJ, ICGCCADEEIO> KFDNPIPFMOI;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public PNKGGCKHOEM NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6342540", Offset = "0x6340D40", VA = "0x186342540", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public NDAINBGMLHF NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6342600", Offset = "0x6340E00", VA = "0x186342600", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ICGCCADEEIO NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x63425A0", Offset = "0x6340DA0", VA = "0x1863425A0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool EOLKHIGAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4F0", Offset = "0x7FBCF0", VA = "0x1807FD4F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x867C80", Offset = "0x866480", VA = "0x180867C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6342F70", Offset = "0x6341770", VA = "0x186342F70")]
	public DBHLFDDMLPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6342810", Offset = "0x6341010", VA = "0x186342810", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6342A60", Offset = "0x6341260", VA = "0x186342A60", Slot = "4")]
	public LKGNCEIDMAL GBIGIENIKPD(IHBGBGAIGLD KOIMDAJNDOD)
	{
		return default(LKGNCEIDMAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6342A60", Offset = "0x6341260", VA = "0x186342A60", Slot = "5")]
	public LKGNCEIDMAL GBIGIENIKPD(IHBGBGAIGLD KOIMDAJNDOD, bool NENNKBNIFNM)
	{
		return default(LKGNCEIDMAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6342660", Offset = "0x6340E60", VA = "0x186342660", Slot = "6")]
	public void BLKDKIMAOFA(LKGNCEIDMAL KLOAHFNCDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x63428A0", Offset = "0x63410A0", VA = "0x1863428A0", Slot = "7")]
	public void ECPMEAHHLFH(LKGNCEIDMAL KLOAHFNCDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6342C60", Offset = "0x6341460", VA = "0x186342C60", Slot = "8")]
	public LNCMOMKNIHJ JNKMMJAKCKG(LKGNCEIDMAL KLOAHFNCDKG, NEFLADIEICF KOIMDAJNDOD)
	{
		return default(LNCMOMKNIHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6342920", Offset = "0x6341120", VA = "0x186342920", Slot = "9")]
	public LNCMOMKNIHJ EJNOBFKDMDJ(LKGNCEIDMAL KLOAHFNCDKG, HBDGMIMMFHO KOIMDAJNDOD)
	{
		return default(LNCMOMKNIHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6342B70", Offset = "0x6341370", VA = "0x186342B70", Slot = "11")]
	public void HLHPAJKLMEF(LNCMOMKNIHJ FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6342C00", Offset = "0x6341400", VA = "0x186342C00", Slot = "10")]
	public void JHAPCFONALO(LNCMOMKNIHJ FECMDKHDNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x63427A0", Offset = "0x6340FA0", VA = "0x1863427A0", Slot = "20")]
	public IEnumerable<Renderer> DGHLJECPJCB(LKGNCEIDMAL KLOAHFNCDKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x63426C0", Offset = "0x6340EC0", VA = "0x1863426C0", Slot = "12")]
	public EKGGCBHAACJ CPLCCOADMDD(PIDEGFHGMKB KOIMDAJNDOD)
	{
		return default(EKGGCBHAACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6342B00", Offset = "0x6341300", VA = "0x186342B00", Slot = "14")]
	public void HKJILCADEPO(EKGGCBHAACJ AHFFLKDLDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6342DA0", Offset = "0x63415A0", VA = "0x186342DA0", Slot = "16")]
	public Task NGEEEECCABG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x63424A0", Offset = "0x6340CA0", VA = "0x1863424A0", Slot = "17")]
	public Task AEIHJCOOFKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6342E40", Offset = "0x6341640", VA = "0x186342E40", Slot = "18")]
	public Task PHKMMNMOAKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1B6B000", Offset = "0x1B69800", VA = "0x181B6B000", Slot = "19")]
	public void DBJBGOMELIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6342740", Offset = "0x6340F40", VA = "0x186342740", Slot = "13")]
	public void DDKHOJIDKKK(EKGGCBHAACJ AHFFLKDLDMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PNOFMOFINFO
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ANKGAAFPKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material GFIGLJHDHEB();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material IJCJLJAIFHH();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material MEDAOJNBKKE();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CGJJJLMPBBE(BEDEGOOCNBJ FIILJIGAEIK);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DGIOJDKKFEK(BGHPHHADMEG EHFHAHKGBNC);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNNMLDBGKKF(GameObject ELOCHLKHPBP);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IPIKAEBDBDN(GameObject ELOCHLKHPBP, bool BHGELEACGNP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class MNPPNAPDADB
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static PNOFMOFINFO HJDEGHPGGHF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool ANKGAAFPKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6349B40", Offset = "0x6348340", VA = "0x186349B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6349F70", Offset = "0x6348770", VA = "0x186349F70")]
	public static void NDONHPHJBMJ(PNOFMOFINFO CBHFEHJAJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6349C80", Offset = "0x6348480", VA = "0x186349C80")]
	public static Material GFIGLJHDHEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6349CE0", Offset = "0x63484E0", VA = "0x186349CE0")]
	public static Material IJCJLJAIFHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6349F10", Offset = "0x6348710", VA = "0x186349F10")]
	public static Material MEDAOJNBKKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6349BA0", Offset = "0x63483A0", VA = "0x186349BA0")]
	public static int CGJJJLMPBBE(BEDEGOOCNBJ FIILJIGAEIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6349C10", Offset = "0x6348410", VA = "0x186349C10")]
	public static int DGIOJDKKFEK(BGHPHHADMEG EHFHAHKGBNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6349E30", Offset = "0x6348630", VA = "0x186349E30")]
	public static void KNNMLDBGKKF(GameObject ELOCHLKHPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6349D40", Offset = "0x6348540", VA = "0x186349D40")]
	public static void IPIKAEBDBDN(GameObject ELOCHLKHPBP, bool BHGELEACGNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ICGCCADEEIO : ONDOKBJAAPK
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JDMGLHBFEIF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public ICGCCADEEIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public JDMGLHBFEIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6349470", Offset = "0x6347C70", VA = "0x186349470", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6349150", Offset = "0x6347950", VA = "0x186349150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6349100", Offset = "0x6347900", VA = "0x186349100")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6349420", Offset = "0x6347C20", VA = "0x186349420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6349370", Offset = "0x6347B70", VA = "0x186349370", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6349370", Offset = "0x6347B70", VA = "0x186349370", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly PIDEGFHGMKB BJOJDKEPDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly ICCGAGHPKMA GELCAGJACCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private ADLMFLBPAGI KCJHEIKFPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<GMHHLNKACIJ> HNKOCIADFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<GMHHLNKACIJ> ICLIALNCIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GameObject MPANMDLGCKK;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6348BD0", Offset = "0x63473D0", VA = "0x186348BD0")]
	public static ICGCCADEEIO GNPAGIDMJBG(PIDEGFHGMKB KOIMDAJNDOD, ICCGAGHPKMA GELCAGJACCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6349020", Offset = "0x6347820", VA = "0x186349020")]
	private ICGCCADEEIO(PIDEGFHGMKB KOIMDAJNDOD, ICCGAGHPKMA GELCAGJACCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6348740", Offset = "0x6346F40", VA = "0x186348740")]
	public void FFAMFELMPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6348F70", Offset = "0x6347770", VA = "0x186348F70")]
	[IteratorStateMachine(typeof(JDMGLHBFEIF))]
	public IEnumerable<Renderer> KGBLKBOFNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6347C70", Offset = "0x6346470", VA = "0x186347C70", Slot = "4")]
	public void DPOMIBPANFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6348FF0", Offset = "0x63477F0", VA = "0x186348FF0")]
	private void LOOBBAFOBAL(Vector3 GPKKMPBLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6348D20", Offset = "0x6347520", VA = "0x186348D20")]
	public void HFBGFFHILGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GMHHLNKACIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct EBLCDJCLMEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public LLAEMFOHIND NKNMINGHJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FEDLPIHABFD OMLBHEBHPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int MIKBLAOMLHP;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ENNIKHAIKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public GMHHLNKACIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JNDHJMNFEHO lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<EBLCDJCLMEJ> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public ANLJNALAKBD combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public ENNIKHAIKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x63438E0", Offset = "0x63420E0", VA = "0x1863438E0")]
		internal JobHandle GCCBPAJHLKB()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6343AB0", Offset = "0x63422B0", VA = "0x186343AB0")]
		internal void OGLGMONJHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6343940", Offset = "0x6342140", VA = "0x186343940")]
		internal void GMFLBINIJLC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int[] BIPKNNFABNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private OAOFHOMKICG LNJFNNEADPM;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static Matrix4x4 KBJMGHJBEPI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh CEMCJDNFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x762B90", Offset = "0x761390", VA = "0x180762B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NEOHOODKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x76CBA0", Offset = "0x76B3A0", VA = "0x18076CBA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x76C460", Offset = "0x76AC60", VA = "0x18076C460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x63474B0", Offset = "0x6345CB0", VA = "0x1863474B0")]
	public void MNNENDCNEIN(List<FEDLPIHABFD> MLLLLKEGKCP, Matrix4x4[] NMBHKLOJJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6346E20", Offset = "0x6345620", VA = "0x186346E20")]
	public static List<GMHHLNKACIJ> GFPEABNIECK(List<PNKGGCKHOEM> DMLIMBBBNJJ, JNDHJMNFEHO OLLEBMKIFPO, Bounds DPMIOBOIGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6346930", Offset = "0x6345130", VA = "0x186346930")]
	private JobHandle AOBAGCKOJIF(ANLJNALAKBD ANDMHOKCCOD, int FGCMOFPHLFL, int NFBMPHODCPI, JNDHJMNFEHO OLLEBMKIFPO, List<EBLCDJCLMEJ> IMHMIOALJGF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6346D40", Offset = "0x6345540", VA = "0x186346D40")]
	private void EOICCIAOJHF(List<EBLCDJCLMEJ> IMHMIOALJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6347840", Offset = "0x6346040", VA = "0x186347840")]
	private GMHHLNKACIJ(List<EBLCDJCLMEJ> IMHMIOALJGF, int FGCMOFPHLFL, int NFBMPHODCPI, JNDHJMNFEHO OLLEBMKIFPO, Bounds DPMIOBOIGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6346CA0", Offset = "0x63454A0", VA = "0x186346CA0", Slot = "4")]
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
		private MaterialPropertyBlock FAEBKOOKOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private GMHHLNKACIJ MPLECHMLAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private List<FEDLPIHABFD> PANMMGKOKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private RenderTexture ENNMCCJPAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private ComputeBuffer EFBOLFMJDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeShader OHIGONDMIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Matrix4x4[] JBEJBIAPPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int OKAGLBOFMHJ;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public MeshRenderer BCGIAEKADBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x762B00", Offset = "0x761300", VA = "0x180762B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int LKJIIIFGGBN
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x6353830", Offset = "0x6352030", VA = "0x186353830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6352B60", Offset = "0x6351360", VA = "0x186352B60")]
		public static List<SkinnedShapeRenderer> Create(GameObject KLOAHFNCDKG, List<GMHHLNKACIJ> MNIDFKMMDJD, List<FEDLPIHABFD> PANMMGKOKGH, Material LGHJCFHBOJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6352DF0", Offset = "0x63515F0", VA = "0x186352DF0")]
		public void Init(GMHHLNKACIJ MPLECHMLAIA, List<FEDLPIHABFD> PANMMGKOKGH, Material LGHJCFHBOJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6353790", Offset = "0x6351F90", VA = "0x186353790")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x63536F0", Offset = "0x6351EF0", VA = "0x1863536F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x63536B0", Offset = "0x6351EB0", VA = "0x1863536B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x63535F0", Offset = "0x6351DF0", VA = "0x1863535F0")]
		private void NNCNAOCIPMN(ScriptableRenderContext LIODJEBJPCP, Camera[] HAKPBFDGMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6353280", Offset = "0x6351A80", VA = "0x186353280")]
		private void MNNENDCNEIN(CommandBuffer EKAPBJIIHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
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
