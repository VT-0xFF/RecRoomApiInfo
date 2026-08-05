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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CE65E0", Offset = "0x8CE55E0", VA = "0x188CE65E0", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CEAC20", Offset = "0x8CE9C20", VA = "0x188CEAC20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FMALOKPONIK : AHKIDBJNFLD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte DGBNNOCKFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] JFMMNOGELOB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JAGJONLANJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FPEOFIKEIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1034ED0", Offset = "0x1033ED0", VA = "0x181034ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GFIOAGOCMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xFA6CB0", Offset = "0xFA5CB0", VA = "0x180FA6CB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1525AB0", Offset = "0x1524AB0", VA = "0x181525AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float MIOLICMFAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD54030", Offset = "0xD53030", VA = "0x180D54030", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD54040", Offset = "0xD53040", VA = "0x180D54040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> LEMEFAFLEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC270", Offset = "0x8CDB270", VA = "0x188CDC270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> AHNCOCDCBBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC2C0", Offset = "0x8CDB2C0", VA = "0x188CDC2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte IBJDDDGBPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC1E0", Offset = "0x8CDB1E0", VA = "0x188CDC1E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC6C0", Offset = "0x8CDB6C0", VA = "0x188CDC6C0")]
	public FMALOKPONIK(List<KMJBBNBAIPG> NBIFFELGAJC, List<KMJBBNBAIPG> EAAKECDAPBK, List<MHHODEBGAFD> NPMNMGOGMEG, Material JNBIMACAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC5A0", Offset = "0x8CDB5A0", VA = "0x188CDC5A0")]
	private int NMILLJNILGJ(List<KMJBBNBAIPG> BIEDIFDPLJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC2F0", Offset = "0x8CDB2F0", VA = "0x188CDC2F0")]
	private void MOCMIHOHPMB(int OJKIAEFDHED, bool OJKKBHHDPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC450", Offset = "0x8CDB450", VA = "0x188CDC450")]
	public void NANIENCNACN(Vector3 POLMDHLPNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC0E0", Offset = "0x8CDB0E0", VA = "0x188CDC0E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC230", Offset = "0x8CDB230", VA = "0x188CDC230")]
	public void HCMKCBBMDKI(Transform HKLPAGOGDOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AANCAKKEJGI : DDGJFAGENIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class CKKMEFAPFOD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public AANCAKKEJGI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public CKKMEFAPFOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8CDBCA0", Offset = "0x8CDACA0", VA = "0x188CDBCA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB690", Offset = "0x8CDA690", VA = "0x188CDB690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB5A0", Offset = "0x8CDA5A0", VA = "0x188CDB5A0")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB5F0", Offset = "0x8CDA5F0", VA = "0x188CDB5F0")]
		private void FNICMDFFEAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB640", Offset = "0x8CDA640", VA = "0x188CDB640")]
		private void KLPFNFIHHLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8CDBC50", Offset = "0x8CDAC50", VA = "0x188CDBC50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8CDBBA0", Offset = "0x8CDABA0", VA = "0x188CDBBA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8CDBBA0", Offset = "0x8CDABA0", VA = "0x188CDBBA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class HPNPBHCDIBP : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public AANCAKKEJGI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public HPNPBHCDIBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4BC0", Offset = "0x8CE3BC0", VA = "0x188CE4BC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4750", Offset = "0x8CE3750", VA = "0x188CE4750", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE46B0", Offset = "0x8CE36B0", VA = "0x188CE46B0")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4700", Offset = "0x8CE3700", VA = "0x188CE4700")]
		private void FNICMDFFEAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4B70", Offset = "0x8CE3B70", VA = "0x188CE4B70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4AC0", Offset = "0x8CE3AC0", VA = "0x188CE4AC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4AC0", Offset = "0x8CE3AC0", VA = "0x188CE4AC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly ILAFMLGLELN GLILNIKDFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<OKGLOCAJCGJ> MBFOINKLGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> MKDDMIEODEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer KHMFGIHANAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool OAFLAOLMIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool LAKMEHDCIGB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<OLBDICAPCOC> FNBOKHPOHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NCGAJFCKJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8CD7190", Offset = "0x8CD6190", VA = "0x188CD7190", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MHHODEBGAFD ACAPNNFBMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8CD71D0", Offset = "0x8CD61D0", VA = "0x188CD71D0", Slot = "8")]
		get
		{
			return default(MHHODEBGAFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> FELOOOKKIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8CD81C0", Offset = "0x8CD71C0", VA = "0x188CD81C0")]
	private bool LKNKFCGPJFB(OKGLOCAJCGJ CBGBGGEBCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8CD85A0", Offset = "0x8CD75A0", VA = "0x188CD85A0")]
	private static bool PNPPINBFKFK(OKGLOCAJCGJ CBGBGGEBCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8CD85C0", Offset = "0x8CD75C0", VA = "0x188CD85C0")]
	public AANCAKKEJGI(ILAFMLGLELN INCJDDLACNP, bool IPOPCBMDIKP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8CD74E0", Offset = "0x8CD64E0", VA = "0x188CD74E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8CD72A0", Offset = "0x8CD62A0", VA = "0x188CD72A0")]
	public void DOPEKGIEJEC(OKGLOCAJCGJ CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8CD8060", Offset = "0x8CD7060", VA = "0x188CD8060")]
	public void LKIPLGLLFFP(OKGLOCAJCGJ CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7B60", Offset = "0x8CD6B60", VA = "0x188CD7B60", Slot = "4")]
	public void JOHECJKJAKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8CD8330", Offset = "0x8CD7330", VA = "0x188CD8330")]
	public void PHBANHJIEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8CD78E0", Offset = "0x8CD68E0", VA = "0x188CD78E0")]
	private void JLDPGALNOOF(List<OKGLOCAJCGJ> MBFOINKLGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8CD76D0", Offset = "0x8CD66D0", VA = "0x188CD76D0")]
	private static Material EHLDKEIMHKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7830", Offset = "0x8CD6830", VA = "0x188CD7830")]
	private void JLDPGALNOOF(OKGLOCAJCGJ CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8CD81E0", Offset = "0x8CD71E0", VA = "0x188CD81E0")]
	private void MCIENADFLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8CD6BD0", Offset = "0x8CD5BD0", VA = "0x188CD6BD0")]
	public void BAPHNBDEDCP(bool JALEMAGKFGO, bool KOBMGCHOCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7AA0", Offset = "0x8CD6AA0", VA = "0x188CD7AA0")]
	protected void JNJNPPGJCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8CD77B0", Offset = "0x8CD67B0", VA = "0x188CD77B0")]
	public void HGHKBAHFIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8CD82B0", Offset = "0x8CD72B0", VA = "0x188CD82B0")]
	[IteratorStateMachine(typeof(CKKMEFAPFOD))]
	public IEnumerable<Renderer> OGOKMKLPNPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7730", Offset = "0x8CD6730", VA = "0x188CD7730")]
	[IteratorStateMachine(typeof(HPNPBHCDIBP))]
	public IEnumerable<Renderer> GMLOFODAPBO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class HOEMHMBDOIE : OKGLOCAJCGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct BJEKHIGOPCD : IHBFIINMGLA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LHCLBAAEINB BFBFJIKLAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle BPLCOHHKDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private HLEMHPNMNHD BIHKCKOLBIO;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8CDAF60", Offset = "0x8CD9F60", VA = "0x188CDAF60")]
		public BJEKHIGOPCD(LHCLBAAEINB BFBFJIKLAEJ, JobHandle BPLCOHHKDGG, HLEMHPNMNHD BIHKCKOLBIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8CDAF30", Offset = "0x8CD9F30", VA = "0x188CDAF30", Slot = "4")]
		public LHCLBAAEINB ECHEACKALCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8CDAEE0", Offset = "0x8CD9EE0", VA = "0x188CDAEE0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly PGOGCEBABLM CFGIGANDBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float JEDEOAHOELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 MKPHIBGJEHF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 KDLPLIDJMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3470", Offset = "0x8CE2470", VA = "0x188CE3470", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8CE4600", Offset = "0x8CE3600", VA = "0x188CE4600")]
	public HOEMHMBDOIE(AANCAKKEJGI NKBKNNLLHKF, PGOGCEBABLM INCJDDLACNP, bool IPOPCBMDIKP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "18")]
	public override bool AJOLOLBHACC(MHHODEBGAFD NKBKNNLLHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8CE35A0", Offset = "0x8CE25A0", VA = "0x188CE35A0", Slot = "19")]
	public override int NMILLJNILGJ(DKDGLPMAAFJ AOHLAGDAFAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8CE32A0", Offset = "0x8CE22A0", VA = "0x188CE32A0", Slot = "20")]
	public override int LFEEIABPMIH(DKDGLPMAAFJ AOHLAGDAFAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2E80", Offset = "0x8CE1E80", VA = "0x188CE2E80", Slot = "21")]
	public override LHGLBAFPIBE KEIKFFBOGLB()
	{
		return default(LHGLBAFPIBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC333B0", Offset = "0xC323B0", VA = "0x180C333B0", Slot = "22")]
	public override float EHNNJABIBEF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3770", Offset = "0x8CE2770", VA = "0x188CE3770", Slot = "23")]
	public override void OABKNBHDDKD(DKDGLPMAAFJ AOHLAGDAFAF, HDCHBBNKGGO ICGGDIEOBMK, int KKLILJLKIJH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8CE4530", Offset = "0x8CE3530", VA = "0x188CE4530", Slot = "24")]
	public override MHHODEBGAFD OLOPDKAFMLO()
	{
		return default(MHHODEBGAFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2CC0", Offset = "0x8CE1CC0", VA = "0x188CE2CC0", Slot = "26")]
	public override AMFFBNPODLJ HBKHMBDBOAC()
	{
		return default(AMFFBNPODLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8CE3D60", Offset = "0x8CE2D60", VA = "0x188CE3D60", Slot = "27")]
	public override IHBFIINMGLA OIJLOOBHABA(DKDGLPMAAFJ AOHLAGDAFAF, JobHandle BPLCOHHKDGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface PMKMNPJOBAB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	AANCAKKEJGI LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OKGLOCAJCGJ LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	HFFHFPAFJFH LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class BCOCAGIAFBJ : CANHEHLEDKA, IDisposable, PMKMNPJOBAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BJFFIOKLLDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public BCOCAGIAFBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8CDAFC0", Offset = "0x8CD9FC0", VA = "0x188CDAFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB540", Offset = "0x8CDA540", VA = "0x188CDB540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly JLKNCNOPDGN<FGANHAMJGGJ, AANCAKKEJGI> NDPNNBFDDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly JLKNCNOPDGN<FLJADJJDFKC, OKGLOCAJCGJ> MBFOINKLGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly JLKNCNOPDGN<JBLJMFHLDMM, HFFHFPAFJFH> OGLKMHCHCHG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public AANCAKKEJGI LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8D70", Offset = "0x8CD7D70", VA = "0x188CD8D70", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public OKGLOCAJCGJ LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8D10", Offset = "0x8CD7D10", VA = "0x188CD8D10", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HFFHFPAFJFH LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8CB0", Offset = "0x8CD7CB0", VA = "0x188CD8CB0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NHGIKFEKHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xBB3410", Offset = "0xBB2410", VA = "0x180BB3410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8CDAA30", Offset = "0x8CD9A30", VA = "0x188CDAA30")]
	public BCOCAGIAFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8CD8DD0", Offset = "0x8CD7DD0", VA = "0x188CD8DD0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8CDA860", Offset = "0x8CD9860", VA = "0x188CDA860", Slot = "4")]
	public FGANHAMJGGJ LACBKHNLHAC(ILAFMLGLELN INCJDDLACNP)
	{
		return default(FGANHAMJGGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8CDA5E0", Offset = "0x8CD95E0", VA = "0x188CDA5E0", Slot = "5")]
	public FGANHAMJGGJ LACBKHNLHAC(ILAFMLGLELN INCJDDLACNP, bool IPOPCBMDIKP)
	{
		return default(FGANHAMJGGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8CDA380", Offset = "0x8CD9380", VA = "0x188CDA380", Slot = "6")]
	public void JAPHBIBBNHA(FGANHAMJGGJ NKBKNNLLHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8CD9010", Offset = "0x8CD8010", VA = "0x188CD9010", Slot = "7")]
	public void FALGAKNNOMK(FGANHAMJGGJ NKBKNNLLHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8CD9370", Offset = "0x8CD8370", VA = "0x188CD9370", Slot = "8")]
	public FLJADJJDFKC GCBAHJDKALN(FGANHAMJGGJ NKBKNNLLHKF, PGILHJFJMGB INCJDDLACNP)
	{
		return default(FLJADJJDFKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8CD9A10", Offset = "0x8CD8A10", VA = "0x188CD9A10", Slot = "9")]
	public FLJADJJDFKC HOFABFACEGL(FGANHAMJGGJ NKBKNNLLHKF, PGOGCEBABLM INCJDDLACNP)
	{
		return default(FLJADJJDFKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8CD9EF0", Offset = "0x8CD8EF0", VA = "0x188CD9EF0", Slot = "11")]
	public void INKHHGCJJNE(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8CD8810", Offset = "0x8CD7810", VA = "0x188CD8810", Slot = "10")]
	public void BDJDGKLHNPJ(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8CD8FA0", Offset = "0x8CD7FA0", VA = "0x188CD8FA0", Slot = "20")]
	public IEnumerable<Renderer> ELGMOKNDIKI(FGANHAMJGGJ NKBKNNLLHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8CD8C30", Offset = "0x8CD7C30", VA = "0x188CD8C30", Slot = "12")]
	public JBLJMFHLDMM CMKGBIAPKKC(MHCAKCKGDAG INCJDDLACNP)
	{
		return default(JBLJMFHLDMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8CD98B0", Offset = "0x8CD88B0", VA = "0x188CD98B0", Slot = "14")]
	public void HGGCJDOHCFH(JBLJMFHLDMM BADMKFACBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8CD8A70", Offset = "0x8CD7A70", VA = "0x188CD8A70", Slot = "16")]
	public Task CBEJLEFKGJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8CDA870", Offset = "0x8CD9870", VA = "0x188CDA870", Slot = "17")]
	public Task MCGPBJMACFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8CDA2B0", Offset = "0x8CD92B0", VA = "0x188CDA2B0", Slot = "18")]
	[AsyncStateMachine(typeof(BJFFIOKLLDH))]
	public Task IPAGGLBOOON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8CD9920", Offset = "0x8CD8920", VA = "0x188CD9920", Slot = "19")]
	public void HHJDCPBAPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8CD9850", Offset = "0x8CD8850", VA = "0x188CD9850", Slot = "13")]
	public void GOCBACGLPDO(JBLJMFHLDMM BADMKFACBPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class GHOFMFEHLPM : OKGLOCAJCGJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct BBLHKPCCMJA : IHBFIINMGLA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private LHCLBAAEINB BFBFJIKLAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> PJGDKFLMEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle BPLCOHHKDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private IFNFPPPMAOL BIHKCKOLBIO;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD87B0", Offset = "0x8CD77B0", VA = "0x188CD87B0")]
		public BBLHKPCCMJA(LHCLBAAEINB BFBFJIKLAEJ, NativeArray<int> PJGDKFLMEFK, JobHandle BPLCOHHKDGG, IFNFPPPMAOL BIHKCKOLBIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8750", Offset = "0x8CD7750", VA = "0x188CD8750", Slot = "4")]
		public LHCLBAAEINB ECHEACKALCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD86B0", Offset = "0x8CD76B0", VA = "0x188CD86B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly PGILHJFJMGB FGNOGEEOKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] NFOLGPPMAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 MKPHIBGJEHF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 GBFNPBCMOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8CDF450", Offset = "0x8CDE450", VA = "0x188CDF450")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 KDLPLIDJMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0230", Offset = "0x8CDF230", VA = "0x188CE0230", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1790", Offset = "0x8CE0790", VA = "0x188CE1790")]
	public GHOFMFEHLPM(AANCAKKEJGI NKBKNNLLHKF, PGILHJFJMGB INCJDDLACNP, bool HCGBEDLIMLP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8CDF380", Offset = "0x8CDE380", VA = "0x188CDF380", Slot = "18")]
	public override bool AJOLOLBHACC(MHHODEBGAFD NKBKNNLLHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8CE0140", Offset = "0x8CDF140", VA = "0x188CE0140", Slot = "21")]
	public override LHGLBAFPIBE KEIKFFBOGLB()
	{
		return default(LHGLBAFPIBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8CDFB30", Offset = "0x8CDEB30", VA = "0x188CDFB30")]
	private LHGLBAFPIBE KEIKFFBOGLB(MHHODEBGAFD NKBKNNLLHKF)
	{
		return default(LHGLBAFPIBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8CDF770", Offset = "0x8CDE770", VA = "0x188CDF770")]
	private FPAJDLAHDEK FHPENMLNMIC([In] UniformTRS NJAJNEEFFEB, [In] float3 IJEEPFLDOFC)
	{
		return default(FPAJDLAHDEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8CE0360", Offset = "0x8CDF360", VA = "0x188CE0360", Slot = "19")]
	public override int NMILLJNILGJ(DKDGLPMAAFJ AOHLAGDAFAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8CE0180", Offset = "0x8CDF180", VA = "0x188CE0180", Slot = "20")]
	public override int LFEEIABPMIH(DKDGLPMAAFJ AOHLAGDAFAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8CDF680", Offset = "0x8CDE680", VA = "0x188CDF680", Slot = "22")]
	public override float EHNNJABIBEF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1510", Offset = "0x8CE0510", VA = "0x188CE1510")]
	private int OOBPNHIEJLD(DKDGLPMAAFJ AOHLAGDAFAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8CE0410", Offset = "0x8CDF410", VA = "0x188CE0410", Slot = "23")]
	public override void OABKNBHDDKD(DKDGLPMAAFJ AOHLAGDAFAF, HDCHBBNKGGO ICGGDIEOBMK, int KKLILJLKIJH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1440", Offset = "0x8CE0440", VA = "0x188CE1440", Slot = "24")]
	public override MHHODEBGAFD OLOPDKAFMLO()
	{
		return default(MHHODEBGAFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8CDF970", Offset = "0x8CDE970", VA = "0x188CDF970", Slot = "26")]
	public override AMFFBNPODLJ HBKHMBDBOAC()
	{
		return default(AMFFBNPODLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8CE0C70", Offset = "0x8CDFC70", VA = "0x188CE0C70", Slot = "27")]
	public override IHBFIINMGLA OIJLOOBHABA(DKDGLPMAAFJ AOHLAGDAFAF, JobHandle BPLCOHHKDGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BMCNLCGHICN
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDBDEHENBPB(CFCGOEKOEDO BJLNCBFOGNL, Renderer LBNDIMGOFLA, int EGJOIKHLMOI);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFDIIOKMBHC(Renderer LBNDIMGOFLA, DILILHCOOLF MHMKGPBCAJP, Vector3 MFCBHBHLABO, Vector3 FBHNPOJCBAF, Vector3 MDKIIKCDCCE, float OCGMAJHHGJO, float CEKCDJIGPMC, float HNPCLHIKGBL = -1f, [Optional] Color? AHIICABHHJO, [Optional] IReadOnlyList<Camera> NIHJDINDENP);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKHOJGGHNDD(Renderer LBNDIMGOFLA, int EGJOIKHLMOI);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OIAMCADOBAH();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNCPNMIAOLN(int APKOAPOEHOE, CIMLIBKMPND BJLNCBFOGNL, Renderer LBNDIMGOFLA, int EGJOIKHLMOI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FPEGGDIFABI : DJNEMOFCFJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class DMKIBDFILLI : AFHLFALOGDI<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8CDBE90", Offset = "0x8CDAE90", VA = "0x188CDBE90")]
		public DMKIBDFILLI(string HJLBILHBIIC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly BMCNLCGHICN NGHPDOIKOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PMKMNPJOBAB DKNHBHBKCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer DHMKMCGGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private DMKIBDFILLI BMGCDNLHCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool DAFCEBODLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer JDLAIPDIAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private DMKIBDFILLI ICDBEGIAGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool LPCIJFIPHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer HLEHEENNBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private DMKIBDFILLI GIIEIBIEDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool EMHKKBHGHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool MCHGOAKENIE;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA653E0", Offset = "0xA643E0", VA = "0x180A653E0")]
	public FPEGGDIFABI(BMCNLCGHICN EMDOKHPMGEI, PMKMNPJOBAB DKNHBHBKCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8CDD060", Offset = "0x8CDC060", VA = "0x188CDD060", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8CDDEC0", Offset = "0x8CDCEC0", VA = "0x188CDDEC0")]
	private void KLMLACANBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8CDE920", Offset = "0x8CDD920", VA = "0x188CDE920", Slot = "4")]
	public void NBGEAGOKANK(FGANHAMJGGJ NKBKNNLLHKF, CIMLIBKMPND PJBEBIJGJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8CDE700", Offset = "0x8CDD700", VA = "0x188CDE700", Slot = "5")]
	public void NBGEAGOKANK(FLJADJJDFKC CBGBGGEBCJG, CIMLIBKMPND PJBEBIJGJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8CDCC50", Offset = "0x8CDBC50", VA = "0x188CDCC50", Slot = "6")]
	public void APFOLGNFJHJ(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8CDE5B0", Offset = "0x8CDD5B0", VA = "0x188CDE5B0", Slot = "7")]
	public void MGOKHKAFIIF(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8CDCDB0", Offset = "0x8CDBDB0", VA = "0x188CDCDB0", Slot = "24")]
	public void BFFHNLPONOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x11E7BF0", Offset = "0x11E6BF0", VA = "0x1811E7BF0", Slot = "8")]
	public void IAOLJFBMJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8CDDD50", Offset = "0x8CDCD50", VA = "0x188CDDD50", Slot = "9")]
	public void JNINPGAEGLA(CIMLIBKMPND PJBEBIJGJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8CDF0B0", Offset = "0x8CDE0B0", VA = "0x188CDF0B0", Slot = "10")]
	public void PFMEENPNENO(FGANHAMJGGJ NKBKNNLLHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8CDED50", Offset = "0x8CDDD50", VA = "0x188CDED50", Slot = "11")]
	public void PFMEENPNENO(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8CDE4E0", Offset = "0x8CDD4E0", VA = "0x188CDE4E0", Slot = "12")]
	public void MEBHFBAPGAO(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8CDDA80", Offset = "0x8CDCA80", VA = "0x188CDDA80", Slot = "13")]
	public void GMGCLBILGNO(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8CDCDF0", Offset = "0x8CDBDF0", VA = "0x188CDCDF0")]
	private void CBOHAJMHGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1555E30", Offset = "0x1554E30", VA = "0x181555E30", Slot = "14")]
	public void GCLHJHLMBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8CDEC30", Offset = "0x8CDDC30", VA = "0x188CDEC30", Slot = "15")]
	public void ODPAMCGAIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8CDE200", Offset = "0x8CDD200", VA = "0x188CDE200", Slot = "16")]
	public void LEOCGGKANDH(FGANHAMJGGJ NKBKNNLLHKF, CFCGOEKOEDO BJLNCBFOGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8CDE130", Offset = "0x8CDD130", VA = "0x188CDE130", Slot = "17")]
	public void LAHAKCLNCIH(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8CDDC80", Offset = "0x8CDCC80", VA = "0x188CDDC80", Slot = "18")]
	public void JLGNIPAHPHK(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xDB9280", Offset = "0xDB8280", VA = "0x180DB9280", Slot = "19")]
	public void NCGENOBDOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8CDDB50", Offset = "0x8CDCB50", VA = "0x188CDDB50", Slot = "20")]
	public void JFDBKLKGCFH(CFCGOEKOEDO BJLNCBFOGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8CDC9E0", Offset = "0x8CDB9E0", VA = "0x188CDC9E0")]
	private void AABELJDHAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8CDD210", Offset = "0x8CDC210", VA = "0x188CDD210", Slot = "21")]
	public void EFLKFOGGGGH(FGANHAMJGGJ NKBKNNLLHKF, Vector3 MFCBHBHLABO, Vector3 FBHNPOJCBAF, Vector3 MDKIIKCDCCE, float OCGMAJHHGJO, float CEKCDJIGPMC, IReadOnlyList<Camera> FKCNKFPCFHA, DILILHCOOLF MHMKGPBCAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8CDD5E0", Offset = "0x8CDC5E0", VA = "0x188CDD5E0", Slot = "22")]
	public void EFLKFOGGGGH(JBLJMFHLDMM BADMKFACBPD, Vector3 MFCBHBHLABO, Vector3 FBHNPOJCBAF, Vector3 MDKIIKCDCCE, float OCGMAJHHGJO, float CEKCDJIGPMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class OKGLOCAJCGJ : FIPGENGPGLO, OLBDICAPCOC, BAAMMHHCOPN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly AANCAKKEJGI AOHAMHAHFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int GBNBCPPGJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds POLACANOPIG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds BFEGFMDIKPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8CE96F0", Offset = "0x8CE86F0", VA = "0x188CE96F0", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool LAKMEHDCIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE98470", Offset = "0xE97470", VA = "0x180E98470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xEB3790", Offset = "0xEB2790", VA = "0x180EB3790")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 KDLPLIDJMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int NACAGAFHHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xC20970", Offset = "0xC1F970", VA = "0x180C20970", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public PJDFFOGFDEB JEEFEMCMNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AGKCFIMHHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xFFD8C0", Offset = "0xFFC8C0", VA = "0x180FFD8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	protected OKGLOCAJCGJ(AANCAKKEJGI NKBKNNLLHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8CE9540", Offset = "0x8CE8540", VA = "0x188CE9540", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "18")]
	public virtual bool AJOLOLBHACC(MHHODEBGAFD NKBKNNLLHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8CE96E0", Offset = "0x8CE86E0", VA = "0x188CE96E0", Slot = "10")]
	public int PHCKIAFALGM(int IGJFHAKEIPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int NMILLJNILGJ(DKDGLPMAAFJ AOHLAGDAFAF);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int LFEEIABPMIH(DKDGLPMAAFJ AOHLAGDAFAF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract LHGLBAFPIBE KEIKFFBOGLB();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float EHNNJABIBEF();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void OABKNBHDDKD(DKDGLPMAAFJ AOHLAGDAFAF, HDCHBBNKGGO ICGGDIEOBMK, int KKLILJLKIJH = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract MHHODEBGAFD OLOPDKAFMLO();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8CE96B0", Offset = "0x8CE86B0", VA = "0x188CE96B0", Slot = "13")]
	public Hash128 GPDPLJBMEJC(int AOHLAGDAFAF)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract AMFFBNPODLJ HBKHMBDBOAC();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract IHBFIINMGLA OIJLOOBHABA(DKDGLPMAAFJ AOHLAGDAFAF, JobHandle BPLCOHHKDGG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8CE9510", Offset = "0x8CE8510", VA = "0x188CE9510", Slot = "12")]
	public IHBFIINMGLA CPGLLEDDELI(int AOHLAGDAFAF)
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
		[Cpp2IlInjected.Address(RVA = "0x8CE9710", Offset = "0x8CE8710", VA = "0x188CE9710")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NHJAGNMMHNA
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KMCDNIPBGNG : IEnumerable<MHOMCOGNFMK>, IEnumerable, IEnumerator<MHOMCOGNFMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private MHOMCOGNFMK <>2__current;

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
		private MHOMCOGNFMK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public KMCDNIPBGNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8CE50F0", Offset = "0x8CE40F0", VA = "0x188CE50F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5260", Offset = "0x8CE4260", VA = "0x188CE5260", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8CE51C0", Offset = "0x8CE41C0", VA = "0x188CE51C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MHOMCOGNFMK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8CE51C0", Offset = "0x8CE41C0", VA = "0x188CE51C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static MHOMCOGNFMK[][] OKAPOLAADDE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static JHIAGONGNFC LDCLICMAEIF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig PFDKKDCCLKE;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader PBHKFACOMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8750", Offset = "0x8CE7750", VA = "0x188CE8750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer EBAPOBPHGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8EA0", Offset = "0x8CE7EA0", VA = "0x188CE8EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8CE8F00", Offset = "0x8CE7F00", VA = "0x188CE8F00")]
	[JDIEABGCJML]
	internal static void OCOPJMCPGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8CE87B0", Offset = "0x8CE77B0", VA = "0x188CE87B0")]
	public static Mesh KOPDLJPINMO(DOKODMHNDOA AJBKLFADAEI, int AOHLAGDAFAF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8CE83B0", Offset = "0x8CE73B0", VA = "0x188CE83B0")]
	public static int FLJHNPMKLLM(DOKODMHNDOA AJBKLFADAEI, int AOHLAGDAFAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8CE8850", Offset = "0x8CE7850", VA = "0x188CE8850")]
	public static JHIAGONGNFC LCFKNHMNGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8CE8E40", Offset = "0x8CE7E40", VA = "0x188CE8E40")]
	[IteratorStateMachine(typeof(KMCDNIPBGNG))]
	private static IEnumerable<MHOMCOGNFMK> MFAFBCMPGMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8CE75A0", Offset = "0x8CE65A0", VA = "0x188CE75A0")]
	public static MHOMCOGNFMK DNFDFPKLOEM(DOKODMHNDOA AJBKLFADAEI, int AOHLAGDAFAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8CE7580", Offset = "0x8CE6580", VA = "0x188CE7580")]
	public static bool COCGADIMLHK(this DOKODMHNDOA AJBKLFADAEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8CE85A0", Offset = "0x8CE75A0", VA = "0x188CE85A0")]
	public static void HPPGFGNNHIP(DOKODMHNDOA AJBKLFADAEI, float3 IBHJNEHHLMJ, [Out] HNGDCJFIOLA FMFMBENAIOI, [Out] float3 AFDFPHFDKAD, [Out] float AFHADBOGFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8CE8A70", Offset = "0x8CE7A70", VA = "0x188CE8A70")]
	public static void MCHDHPGOIFH(Vector3 IBHJNEHHLMJ, DOKODMHNDOA AJBKLFADAEI, [Out] Vector3 AFDFPHFDKAD, [Out] float AFHADBOGFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8CE7570", Offset = "0x8CE6570", VA = "0x188CE7570")]
	[CDCDEFMAODN(0)]
	[BEFBDNPMJDK(ACIAPGFBLAK.ExitingPlayMode, 0)]
	private static void BBBLMNGFJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8CE83C0", Offset = "0x8CE73C0", VA = "0x188CE83C0")]
	[CDCDEFMAODN(0)]
	[BEFBDNPMJDK(ACIAPGFBLAK.ExitingPlayMode, 0)]
	private static void GJJDCIPOOII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class MBKBBAABOGO : CANHEHLEDKA, IDisposable, PMKMNPJOBAB
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly JLKNCNOPDGN<FGANHAMJGGJ, AANCAKKEJGI> NDPNNBFDDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly JLKNCNOPDGN<FLJADJJDFKC, OKGLOCAJCGJ> MBFOINKLGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly JLKNCNOPDGN<JBLJMFHLDMM, HFFHFPAFJFH> OGLKMHCHCHG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public AANCAKKEJGI LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6890", Offset = "0x8CE5890", VA = "0x188CE6890", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public OKGLOCAJCGJ LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6830", Offset = "0x8CE5830", VA = "0x188CE6830", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HFFHFPAFJFH LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8CE68F0", Offset = "0x8CE58F0", VA = "0x188CE68F0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NHGIKFEKHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xBB3410", Offset = "0xBB2410", VA = "0x180BB3410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8CE7180", Offset = "0x8CE6180", VA = "0x188CE7180")]
	public MBKBBAABOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6950", Offset = "0x8CE5950", VA = "0x188CE6950", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6FB0", Offset = "0x8CE5FB0", VA = "0x188CE6FB0", Slot = "4")]
	public FGANHAMJGGJ LACBKHNLHAC(ILAFMLGLELN INCJDDLACNP)
	{
		return default(FGANHAMJGGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6FB0", Offset = "0x8CE5FB0", VA = "0x188CE6FB0", Slot = "5")]
	public FGANHAMJGGJ LACBKHNLHAC(ILAFMLGLELN INCJDDLACNP, bool IPOPCBMDIKP)
	{
		return default(FGANHAMJGGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6F50", Offset = "0x8CE5F50", VA = "0x188CE6F50", Slot = "6")]
	public void JAPHBIBBNHA(FGANHAMJGGJ NKBKNNLLHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6A50", Offset = "0x8CE5A50", VA = "0x188CE6A50", Slot = "7")]
	public void FALGAKNNOMK(FGANHAMJGGJ NKBKNNLLHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6AD0", Offset = "0x8CE5AD0", VA = "0x188CE6AD0", Slot = "8")]
	public FLJADJJDFKC GCBAHJDKALN(FGANHAMJGGJ NKBKNNLLHKF, PGILHJFJMGB INCJDDLACNP)
	{
		return default(FLJADJJDFKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6CE0", Offset = "0x8CE5CE0", VA = "0x188CE6CE0", Slot = "9")]
	public FLJADJJDFKC HOFABFACEGL(FGANHAMJGGJ NKBKNNLLHKF, PGOGCEBABLM INCJDDLACNP)
	{
		return default(FLJADJJDFKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6E20", Offset = "0x8CE5E20", VA = "0x188CE6E20", Slot = "11")]
	public void INKHHGCJJNE(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8CE66B0", Offset = "0x8CE56B0", VA = "0x188CE66B0", Slot = "10")]
	public void BDJDGKLHNPJ(FLJADJJDFKC CBGBGGEBCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8CE69E0", Offset = "0x8CE59E0", VA = "0x188CE69E0", Slot = "20")]
	public IEnumerable<Renderer> ELGMOKNDIKI(FGANHAMJGGJ NKBKNNLLHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8CE67B0", Offset = "0x8CE57B0", VA = "0x188CE67B0", Slot = "12")]
	public JBLJMFHLDMM CMKGBIAPKKC(MHCAKCKGDAG INCJDDLACNP)
	{
		return default(JBLJMFHLDMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6C70", Offset = "0x8CE5C70", VA = "0x188CE6C70", Slot = "14")]
	public void HGGCJDOHCFH(JBLJMFHLDMM BADMKFACBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6710", Offset = "0x8CE5710", VA = "0x188CE6710", Slot = "16")]
	public Task CBEJLEFKGJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8CE7050", Offset = "0x8CE6050", VA = "0x188CE7050", Slot = "17")]
	public Task MCGPBJMACFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6EB0", Offset = "0x8CE5EB0", VA = "0x188CE6EB0", Slot = "18")]
	public Task IPAGGLBOOON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2907AB0", Offset = "0x2906AB0", VA = "0x182907AB0", Slot = "19")]
	public void HHJDCPBAPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8CE6C10", Offset = "0x8CE5C10", VA = "0x188CE6C10", Slot = "13")]
	public void GOCBACGLPDO(JBLJMFHLDMM BADMKFACBPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HEDMJFEFOHH
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool LOPGAMMENEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material DGNAKPBJOEL();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material EHLDKEIMHKK();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material DKPCGDEHEDC();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EDGKGBKPDGD(KOGANNKCGHD IIFJAEBIGOH);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HLOOFJILEOH(DOKJMPJMCCI BMMEGBGADMM);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DGPLPFDMDFL(GameObject PGIOEBKALDP);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BMFBOPFHHCK(GameObject PGIOEBKALDP, bool IGCOBIEIACH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class NOFPEMHDHPA
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static HEDMJFEFOHH JOEHPNNMIOL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool LOPGAMMENEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8CE91E0", Offset = "0x8CE81E0", VA = "0x188CE91E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8CE94B0", Offset = "0x8CE84B0", VA = "0x188CE94B0")]
	public static void PEINOKGGMOF(HEDMJFEFOHH MONJELKPHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8CE9240", Offset = "0x8CE8240", VA = "0x188CE9240")]
	public static Material DGNAKPBJOEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8CD76D0", Offset = "0x8CD66D0", VA = "0x188CD76D0")]
	public static Material EHLDKEIMHKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8CE9370", Offset = "0x8CE8370", VA = "0x188CE9370")]
	public static Material DKPCGDEHEDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8CE93D0", Offset = "0x8CE83D0", VA = "0x188CE93D0")]
	public static int EDGKGBKPDGD(KOGANNKCGHD IIFJAEBIGOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8CE9440", Offset = "0x8CE8440", VA = "0x188CE9440")]
	public static int HLOOFJILEOH(DOKJMPJMCCI BMMEGBGADMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8CE92A0", Offset = "0x8CE82A0", VA = "0x188CE92A0")]
	public static void DGPLPFDMDFL(GameObject PGIOEBKALDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8CE90F0", Offset = "0x8CE80F0", VA = "0x188CE90F0")]
	public static void BMFBOPFHHCK(GameObject PGIOEBKALDP, bool IGCOBIEIACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HFFHFPAFJFH : DDGJFAGENIL
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class JFNCNIENEOK : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public HFFHFPAFJFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public JFNCNIENEOK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5060", Offset = "0x8CE4060", VA = "0x188CE5060", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4D40", Offset = "0x8CE3D40", VA = "0x188CE4D40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4CF0", Offset = "0x8CE3CF0", VA = "0x188CE4CF0")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5010", Offset = "0x8CE4010", VA = "0x188CE5010", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4F60", Offset = "0x8CE3F60", VA = "0x188CE4F60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4F60", Offset = "0x8CE3F60", VA = "0x188CE4F60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MHCAKCKGDAG PBDCFGOJCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly PMKMNPJOBAB DKNHBHBKCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private FMALOKPONIK KJEIFJONDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<KMJBBNBAIPG> JPBLOCJBLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<KMJBBNBAIPG> APGMDLGCDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject HJEKHIGIGLO;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1840", Offset = "0x8CE0840", VA = "0x188CE1840")]
	public static HFFHFPAFJFH CJPMLIFIENC(MHCAKCKGDAG INCJDDLACNP, PMKMNPJOBAB DKNHBHBKCIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2BE0", Offset = "0x8CE1BE0", VA = "0x188CE2BE0")]
	private HFFHFPAFJFH(MHCAKCKGDAG INCJDDLACNP, PMKMNPJOBAB DKNHBHBKCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2480", Offset = "0x8CE1480", VA = "0x188CE2480")]
	public void NIIIKCLLCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2910", Offset = "0x8CE1910", VA = "0x188CE2910")]
	[IteratorStateMachine(typeof(JFNCNIENEOK))]
	public IEnumerable<Renderer> OGOKMKLPNPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8CE1990", Offset = "0x8CE0990", VA = "0x188CE1990", Slot = "4")]
	public void JOHECJKJAKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2450", Offset = "0x8CE1450", VA = "0x188CE2450")]
	private void LABIMOKCIML(Vector3 POLMDHLPNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8CE2990", Offset = "0x8CE1990", VA = "0x188CE2990")]
	public void PHBANHJIEKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KMJBBNBAIPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct IBIMBEBAIMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public HDCHBBNKGGO NMLBDPGOIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MHHODEBGAFD DCHDHLBMAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int KPDBFHLMOIM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EBLGEELPBNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KMJBBNBAIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public DKDGLPMAAFJ lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<IBIMBEBAIMI> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public LHCLBAAEINB combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public EBLGEELPBNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC080", Offset = "0x8CDB080", VA = "0x188CDC080")]
		internal JobHandle IPHOKKAPDOM()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8CDBEE0", Offset = "0x8CDAEE0", VA = "0x188CDBEE0")]
		internal void CIKAONDHCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8CDBF10", Offset = "0x8CDAF10", VA = "0x188CDBF10")]
		internal void DFOAANCIDPJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] KFKBFPEFCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private DKBKNGOOJOH LCNMOAGNJDC;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 FODNDILMKDJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh FKGCABGKIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NFFNGCGABBH
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8CE56C0", Offset = "0x8CE46C0", VA = "0x188CE56C0")]
	public void HNGKMKKCIAF(List<MHHODEBGAFD> MPNGKMOINPP, Matrix4x4[] HOICPDLABBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8CE5990", Offset = "0x8CE4990", VA = "0x188CE5990")]
	public static List<KMJBBNBAIPG> MEFBGKEPBLF(List<AANCAKKEJGI> INFMLEKPAFN, DKDGLPMAAFJ AOHLAGDAFAF, Bounds JCENBMMMLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8CE5350", Offset = "0x8CE4350", VA = "0x188CE5350")]
	private JobHandle GGAEIAMONJE(LHCLBAAEINB HGICNAFNBLG, int ABJOGENEJMC, int EEIFKOCDMLP, DKDGLPMAAFJ AOHLAGDAFAF, List<IBIMBEBAIMI> IJAKAPLFDEE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8CE58B0", Offset = "0x8CE48B0", VA = "0x188CE58B0")]
	private void JJPAJDIBMDG(List<IBIMBEBAIMI> IJAKAPLFDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x8CE61C0", Offset = "0x8CE51C0", VA = "0x188CE61C0")]
	private KMJBBNBAIPG(List<IBIMBEBAIMI> IJAKAPLFDEE, int ABJOGENEJMC, int EEIFKOCDMLP, DKDGLPMAAFJ AOHLAGDAFAF, Bounds JCENBMMMLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8CE52B0", Offset = "0x8CE42B0", VA = "0x188CE52B0", Slot = "4")]
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
		private MaterialPropertyBlock FMOALAMGLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private KMJBBNBAIPG BFBFJIKLAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<MHHODEBGAFD> NPMNMGOGMEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture FFMDMGFGKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer HNBPBILEPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader EIGOOOLAEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] PCNCHHDNFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int BHKKOJGBHIC;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer AHGMMNIDOHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int PMODDNHKKAM
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8CEA4A0", Offset = "0x8CE94A0", VA = "0x188CEA4A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9830", Offset = "0x8CE8830", VA = "0x188CE9830")]
		public static List<SkinnedShapeRenderer> Create(GameObject NKBKNNLLHKF, List<KMJBBNBAIPG> BIEDIFDPLJP, List<MHHODEBGAFD> NPMNMGOGMEG, Material JNBIMACAHOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9E90", Offset = "0x8CE8E90", VA = "0x188CE9E90")]
		public void Init(KMJBBNBAIPG BFBFJIKLAEJ, List<MHHODEBGAFD> NPMNMGOGMEG, Material JNBIMACAHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA400", Offset = "0x8CE9400", VA = "0x188CEA400")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA360", Offset = "0x8CE9360", VA = "0x188CEA360")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA320", Offset = "0x8CE9320", VA = "0x188CEA320")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9770", Offset = "0x8CE8770", VA = "0x188CE9770")]
		private void AOMMBAPHMDF(ScriptableRenderContext IEGLIFIOOBM, Camera[] MGFGHKANOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9B20", Offset = "0x8CE8B20", VA = "0x188CE9B20")]
		private void HNGKMKKCIAF(CommandBuffer BNLNEGCIGAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
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
