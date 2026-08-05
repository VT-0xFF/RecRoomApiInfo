using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Core.Pools;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PooledDamageParticles : PooledParticle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Header("Impact Particle System")]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[Header("Impact Particle Start Size")]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		[Header("Impact Particle Start Lifetime")]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[Header("Spray Particle System")]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[Header("Spray Particle Burst Count")]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6060D20", Offset = "0x605F320", VA = "0x186060D20")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles BHIKNMNBHAG, float BAMCGAGNEAG, Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6060B20", Offset = "0x605F120", VA = "0x186060B20")]
		public void SetDamageValue(float BAMCGAGNEAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6060EE0", Offset = "0x605F4E0", VA = "0x186060EE0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MGKGAJOALJF<T> : global::DIHJKCFGFNO<T>, IGOPHNBFNOE, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IIOMEEGJFMH<T> : IGOPHNBFNOE, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MLIGFEJKPNP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LODLPCFEBPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BEDBKOHJADO<T> : global::HCPAFFBNPPI<T>, global::MGKGAJOALJF<T>, global::DIHJKCFGFNO<T>, IGOPHNBFNOE, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MIIDBMHBALG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public BEDBKOHJADO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
			public MIIDBMHBALG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3B47E20", Offset = "0x3B46420", VA = "0x183B47E20")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3354460", Offset = "0x3352A60", VA = "0x183354460")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::IIADFENEKIO<T> CCNOEPGJPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool JJLOBPPKGIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T PFOFOPEANHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4BCC5B0", Offset = "0x4BCABB0", VA = "0x184BCC5B0")]
		public BEDBKOHJADO(global::IIADFENEKIO<T> CCNOEPGJPIA, ObjectPool JJLOBPPKGIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4BCC470", Offset = "0x4BCAA70", VA = "0x184BCC470", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JMPFHKEAIJN<T> : EONHFJBEBFJ, global::IIOMEEGJFMH<T>, IGOPHNBFNOE, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class NLLFMMHPPCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JMPFHKEAIJN<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
			public NLLFMMHPPCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3959C50", Offset = "0x3958250", VA = "0x183959C50")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1F5E5F0", Offset = "0x1F5CBF0", VA = "0x181F5E5F0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::IIADFENEKIO<T> CCNOEPGJPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool LNPMOHBLPOO;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7C80", Offset = "0x3EF6280", VA = "0x183EF7C80")]
		public JMPFHKEAIJN(global::IIADFENEKIO<T> CCNOEPGJPIA, ObjectPool JJLOBPPKGIN, int HCICKDLMEFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7C30", Offset = "0x3EF6230", VA = "0x183EF7C30", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PABALLMPBFP<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LODLPCFEBPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::HCPAFFBNPPI<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::IIADFENEKIO<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		public PABALLMPBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x47CC5F0", Offset = "0x47CABF0", VA = "0x1847CC5F0")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x47CC690", Offset = "0x47CAC90", VA = "0x1847CC690")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x47CC6F0", Offset = "0x47CACF0", VA = "0x1847CC6F0")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<MLIGFEJKPNP> MBJCNIDOKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private GDFCDNFAACG OMLOIMIPELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool JJLOBPPKGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool HLIAAEPKHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x605F470", Offset = "0x605DA70", VA = "0x18605F470")]
	private static void MCCKOCCIEFN(Component AALANACCLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x605F8D0", Offset = "0x605DED0", VA = "0x18605F8D0")]
	public LODLPCFEBPH(string PJDLNFGCCHI, int DLILFLBACNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4465DC0", Offset = "0x44643C0", VA = "0x184465DC0")]
	public global::MGKGAJOALJF<T> DLOPPNFOCOA<T>(AssetReference DEKGEFNEBKC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x44660F0", Offset = "0x44646F0", VA = "0x1844660F0")]
	public global::IIOMEEGJFMH<T> NAIBDEGLPOH<T>(AssetReference DEKGEFNEBKC, int FPLNDBJJHMM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4465E50", Offset = "0x4464450", VA = "0x184465E50")]
	public global::DIHJKCFGFNO<bool> DPFPNIAFGMD<T>(AssetReference DEKGEFNEBKC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x605F220", Offset = "0x605D820", VA = "0x18605F220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x605F330", Offset = "0x605D930", VA = "0x18605F330")]
	private void LGGDCAKBJGN(UnityEngine.Object ALHBBHNIJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x605F6C0", Offset = "0x605DCC0", VA = "0x18605F6C0")]
	private ObjectPool PKGKKLOFEEL(string PJDLNFGCCHI)
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static GlobalPool DDFBEPONIHC;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject EIIDAGHAOAI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool LOGBPMLPMIM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x605F060", Offset = "0x605D660", VA = "0x18605F060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x32CE140", Offset = "0x32CC740", VA = "0x1832CE140")]
		public static void SafeRelease<T>(T LGKNNMGLNIA) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x605EF60", Offset = "0x605D560", VA = "0x18605EF60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x605F050", Offset = "0x605D650", VA = "0x18605F050")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, ADPGFLPIOOM> GHMJHILEPGO;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3565260", Offset = "0x3563860", VA = "0x183565260")]
		public T Acquire<T>(T BHIKNMNBHAG, [Optional] Action<Component> OAICHFIBNBB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x35655F0", Offset = "0x3563BF0", VA = "0x1835655F0")]
		public bool Release<T>(T LGKNNMGLNIA) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3565590", Offset = "0x3563B90", VA = "0x183565590")]
		public void Prefill<T>(T BHIKNMNBHAG, int HFOHGIPGEMK, [Optional] Action<Component> AHFEDKDNBKH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x35653A0", Offset = "0x35639A0", VA = "0x1835653A0")]
		public bool Exists<T>(T BHIKNMNBHAG) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x35652F0", Offset = "0x35638F0", VA = "0x1835652F0")]
		public void Clear<T>(T BHIKNMNBHAG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6060570", Offset = "0x605EB70", VA = "0x186060570")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3565450", Offset = "0x3563A50", VA = "0x183565450")]
		private ADPGFLPIOOM FINCBNNAMFJ<T>(T BHIKNMNBHAG) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public void TrackInstantiation(string AMFLLJIBFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public void EnableStats(bool MEMPEGNNOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60606C0", Offset = "0x605ECC0", VA = "0x1860606C0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class ADPGFLPIOOM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface BLPPHHCMOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NBKNIPPFJIM(bool IBCMFFCNBBB);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component GPDJODBNDCO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int DLLACNIILJM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void NAIBDEGLPOH(int FPLNDBJJHMM, Action<Component> AHFEDKDNBKH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component DLOPPNFOCOA(Action<Component> OAICHFIBNBB);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool ENCBMHFAOCP(Component ODGNFNGJPCH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void PGHHBKOCHPM();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x605E4E0", Offset = "0x605CAE0", VA = "0x18605E4E0")]
	protected void MBJJGMCIPMJ(Component LGKNNMGLNIA, bool IBCMFFCNBBB, bool LKNNIMABIKN, bool OIKCGEINAKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x605E2E0", Offset = "0x605C8E0", VA = "0x18605E2E0")]
	protected void AKKJJLDIIKL(Transform MHMHONJDMNG, bool IBCMFFCNBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	protected ADPGFLPIOOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JKCHLFINIKD<T> : ADPGFLPIOOM where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T BHIKNMNBHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool GNAAFDLPHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool LKNNIMABIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> NJLBMBBOKAN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component GPDJODBNDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1D10", Offset = "0x3EF0310", VA = "0x183EF1D10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int DLLACNIILJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1A70", Offset = "0x3EF0070", VA = "0x183EF1A70", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1F20", Offset = "0x3EF0520", VA = "0x183EF1F20")]
	public JKCHLFINIKD(T BHIKNMNBHAG, ObjectPool GNAAFDLPHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1AA0", Offset = "0x3EF00A0", VA = "0x183EF1AA0", Slot = "7")]
	public override void NAIBDEGLPOH(int FPLNDBJJHMM, Action<Component> OAICHFIBNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1670", Offset = "0x3EEFC70", VA = "0x183EF1670", Slot = "8")]
	public override Component DLOPPNFOCOA(Action<Component> OAICHFIBNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF18E0", Offset = "0x3EEFEE0", VA = "0x183EF18E0", Slot = "9")]
	public override bool ENCBMHFAOCP(Component ODGNFNGJPCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1D30", Offset = "0x3EF0330", VA = "0x183EF1D30", Slot = "10")]
	public override void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1BB0", Offset = "0x3EF01B0", VA = "0x183EF1BB0")]
	private T NHNIBPMCDOH()
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public interface POJCPCGLNHO
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject AAEEOADJGNH
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60601A0", Offset = "0x605E7A0", VA = "0x1860601A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60604F0", Offset = "0x605EAF0", VA = "0x1860604F0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool DDFBEPONIHC;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject EIIDAGHAOAI;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool LOGBPMLPMIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6060930", Offset = "0x605EF30", VA = "0x186060930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6060840", Offset = "0x605EE40", VA = "0x186060840")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x605F050", Offset = "0x605D650", VA = "0x18605F050")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public ADPGFLPIOOM PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KNLPKNCFNFC
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NIJPPOOGHPI(PooledParticle.EGOFHKHLNIB HDPGJJCMHGA);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum JKLAMIJGCCA
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum EGOFHKHLNIB
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface CJDIPOPHPKH
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool LDOFABNPNBN
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 KBPNGINHLPK
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera PILHKBDDCLO
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1922B70", Offset = "0x1921170", VA = "0x181922B70")]
			public ColorConfiguration(ParticleSystem JKMGJCLEJKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x605E690", Offset = "0x605CC90", VA = "0x18605E690")]
			public void BJCJBEACPJC(Color GCBELIJEOPF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CEELFNPAHHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
			public CEELFNPAHHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x605E660", Offset = "0x605CC60", VA = "0x18605E660")]
			internal void <SetRenderingEnabled>b__0(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EPABFEAFJAA : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private PBBBHKGHFDI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private CJDIPOPHPKH <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public EPABFEAFJAA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x605E880", Offset = "0x605CE80", VA = "0x18605E880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x605EF20", Offset = "0x605D520", VA = "0x18605EF20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PHMFKMBNHKI : IEnumerator<PBBBHKGHFDI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private PBBBHKGHFDI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private PBBBHKGHFDI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x777530", Offset = "0x775B30", VA = "0x180777530")]
			[DebuggerHidden]
			public PHMFKMBNHKI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6060740", Offset = "0x605ED40", VA = "0x186060740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6060800", Offset = "0x605EE00", VA = "0x186060800", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> FDHGEJGGNFM;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<KNLPKNCFNFC> JIOBIFNGMPJ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> OFPFHBKKIMP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static PFHLOLIKNNP FCPMLNOODEG;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float IAMCDLDAFNC = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool LGHBPHAJCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int ONJKIHIJCMD;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private EGOFHKHLNIB category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private ParticleSystem.MinMaxGradient[] CGLNIPGBKGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool LGLIIJCPHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float MFAHGCNBGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float NILHCMJHGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform ABJGHNHBBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 ANFCLKIPMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 MAGAKOFNPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private JKLAMIJGCCA KLHJHKBALLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private PFHLOLIKNNP DFEAIBLNCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool NLFAIMDLDNL;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IEnumerable<PooledParticle> OGJLKIFJINA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x60647D0", Offset = "0x6062DD0", VA = "0x1860647D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EGOFHKHLNIB ABIBLNFCFHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x83C6A0", Offset = "0x83ACA0", VA = "0x18083C6A0")]
			get
			{
				return default(EGOFHKHLNIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int DBFBLKANPLD
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DHMPGINIHAH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x60644C0", Offset = "0x6062AC0", VA = "0x1860644C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static int KIINFLMKDHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6064650", Offset = "0x6062C50", VA = "0x186064650")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected static bool FCKFDGOLKIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6061500", Offset = "0x605FB00", VA = "0x186061500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ParticleSystem CCMPAOKEAIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x77C760", Offset = "0x77AD60", VA = "0x18077C760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ParticleSystem[] CLAOBMKNGDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x67A0D0", Offset = "0x6786D0", VA = "0x18067A0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7E5D70", Offset = "0x7E4370", VA = "0x1807E5D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ParticleSystemRenderer[] DMPDIIDDHJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x722690", Offset = "0x720C90", VA = "0x180722690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private JKLAMIJGCCA GIIGHJFAFGD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7E5B50", Offset = "0x7E4150", VA = "0x1807E5B50")]
			get
			{
				return default(JKLAMIJGCCA);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6061330", Offset = "0x605F930", VA = "0x186061330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GPHDCDAFMOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6064420", Offset = "0x6062A20", VA = "0x186064420")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6064830", Offset = "0x6062E30", VA = "0x186064830")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6063FC0", Offset = "0x60625C0", VA = "0x186063FC0")]
		public static PooledParticle TryPlayPrefab(PooledParticle BHIKNMNBHAG, Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6063DD0", Offset = "0x60623D0", VA = "0x186063DD0")]
		public static PooledParticle TryPlayPrefab(PooledParticle BHIKNMNBHAG, Vector3 EINGNKDKDHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6063440", Offset = "0x6061A40", VA = "0x186063440")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6062680", Offset = "0x6060C80", VA = "0x186062680")]
		private void OBOEAMDLFCK(bool DBNFCLHCFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6062760", Offset = "0x6060D60", VA = "0x186062760")]
		[IteratorStateMachine(typeof(EPABFEAFJAA))]
		private static IEnumerator<PBBBHKGHFDI> OIGEFEALIMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6061BF0", Offset = "0x60601F0", VA = "0x186061BF0")]
		private static void JNGIPPPIBOA(Stopwatch IDKFKDEHFHM, Vector3 CDJIIEIOGED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6061590", Offset = "0x605FB90", VA = "0x186061590")]
		private static int HNLNLELOEBF(PooledParticle OLACFPEGPAG, PooledParticle GLLCOOLKDAC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x60623E0", Offset = "0x60609E0", VA = "0x1860623E0")]
		private static int NIJPPOOGHPI(EGOFHKHLNIB HDPGJJCMHGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6062830", Offset = "0x6060E30", VA = "0x186062830")]
		protected void PIEAKOJDIIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6061640", Offset = "0x605FC40", VA = "0x186061640")]
		protected void HPBAFKBAMIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6060F80", Offset = "0x605F580", VA = "0x186060F80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6062140", Offset = "0x6060740", VA = "0x186062140")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60627B0", Offset = "0x6060DB0", VA = "0x1860627B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60620C0", Offset = "0x60606C0", VA = "0x1860620C0")]
		[IteratorStateMachine(typeof(PHMFKMBNHKI))]
		private IEnumerator<PBBBHKGHFDI> KGDPCEODFDG(float OLGHJNFBDFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6061350", Offset = "0x605F950", VA = "0x186061350")]
		private void ENCBMHFAOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6063BE0", Offset = "0x60621E0", VA = "0x186063BE0")]
		public void SetDuration(float OLGHJNFBDFD, bool IMHMDKPPLDN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6063120", Offset = "0x6061720", VA = "0x186063120")]
		public void Play(Transform DEJNEMNPACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6062B00", Offset = "0x6061100", VA = "0x186062B00")]
		public void Play(Transform DEJNEMNPACA, bool CMNHEIPEENN, float BHOBCEMEJNM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6062C50", Offset = "0x6061250", VA = "0x186062C50")]
		public void Play(Transform DEJNEMNPACA, Vector3 MAGAKOFNPLN, bool CMNHEIPEENN, float BHOBCEMEJNM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6062ED0", Offset = "0x60614D0", VA = "0x186062ED0")]
		public void Play(Transform GHKGHAFBFFC, Quaternion JGCPJBFFFAC, bool CMNHEIPEENN = false, float BHOBCEMEJNM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6062DA0", Offset = "0x60613A0", VA = "0x186062DA0")]
		public void Play(Transform GHKGHAFBFFC, Vector3 MAGAKOFNPLN, Quaternion JGCPJBFFFAC, bool CMNHEIPEENN = false, float BHOBCEMEJNM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6062A30", Offset = "0x6061030", VA = "0x186062A30")]
		public void Play(Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC, Vector3 CPHPLAEKCBK, bool CMNHEIPEENN = false, float BHOBCEMEJNM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6063260", Offset = "0x6061860", VA = "0x186063260")]
		public void Play(Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC, bool CMNHEIPEENN = false, float BHOBCEMEJNM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6063010", Offset = "0x6061610", VA = "0x186063010")]
		public void Play(bool CMNHEIPEENN = false, float BHOBCEMEJNM = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6063D40", Offset = "0x6062340", VA = "0x186063D40")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6063CB0", Offset = "0x60622B0", VA = "0x186063CB0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x60624F0", Offset = "0x6060AF0", VA = "0x1860624F0")]
		private void NPGGDKOMOGK(float OLGHJNFBDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x60611C0", Offset = "0x605F7C0", VA = "0x1860611C0")]
		private void DOGDKMMGDLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6063320", Offset = "0x6061920", VA = "0x186063320")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x60635E0", Offset = "0x6061BE0", VA = "0x1860635E0")]
		public void SetColor(Color GCBELIJEOPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6061F80", Offset = "0x6060580", VA = "0x186061F80")]
		private void JOLGHMDBGLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x60643C0", Offset = "0x60629C0", VA = "0x1860643C0")]
		public PooledParticle()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x605FEC0", Offset = "0x605E4C0", VA = "0x18605FEC0")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x605FB70", Offset = "0x605E170", VA = "0x18605FB70")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
