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
		[Cpp2IlInjected.Address(RVA = "0x6413380", Offset = "0x6411D80", VA = "0x186413380")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles JFEEEILBEOO, float BBMEODBNDGA, Vector3 OAALNDIAAOB, Quaternion HOOCPOKGFMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6413180", Offset = "0x6411B80", VA = "0x186413180")]
		public void SetDamageValue(float BBMEODBNDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6413540", Offset = "0x6411F40", VA = "0x186413540")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GFEDJJGDFMD<T> : global::OHPLDOPGNGG<T>, GPMDAFELAJF, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LNBLPFGKAPP<T> : GPMDAFELAJF, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HKJIGAIHBEC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GBEIAHDIOPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HGLELDNGGBA<T> : global::MECOGDILELM<T>, global::GFEDJJGDFMD<T>, global::OHPLDOPGNGG<T>, GPMDAFELAJF, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CDHNHMKJGKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public HGLELDNGGBA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
			public CDHNHMKJGKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x37908D0", Offset = "0x378F2D0", VA = "0x1837908D0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1FDE910", Offset = "0x1FDD310", VA = "0x181FDE910")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::FGGCDBFMPJN<T> AHOHGJGFKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool IPJBBJCFMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T AIDJCJOCGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3B9E560", Offset = "0x3B9CF60", VA = "0x183B9E560")]
		public HGLELDNGGBA(global::FGGCDBFMPJN<T> AHOHGJGFKAB, ObjectPool IPJBBJCFMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B9E3B0", Offset = "0x3B9CDB0", VA = "0x183B9E3B0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class MJIFNMKOPOF<T> : AMHJHFKKEOP, global::LNBLPFGKAPP<T>, GPMDAFELAJF, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DHBIJFPDOPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public MJIFNMKOPOF<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
			public DHBIJFPDOPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2596020", Offset = "0x2594A20", VA = "0x182596020")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x11254B0", Offset = "0x1123EB0", VA = "0x1811254B0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::FGGCDBFMPJN<T> AHOHGJGFKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C7F0", Offset = "0x2B1B1F0", VA = "0x182B1C7F0")]
		public MJIFNMKOPOF(global::FGGCDBFMPJN<T> AHOHGJGFKAB, ObjectPool IPJBBJCFMLC, int EFGGLKAPJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C7A0", Offset = "0x2B1B1A0", VA = "0x182B1C7A0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LMLDILMHNIJ<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GBEIAHDIOPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::MECOGDILELM<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::FGGCDBFMPJN<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public LMLDILMHNIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2994060", Offset = "0x2992A60", VA = "0x182994060")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2994100", Offset = "0x2992B00", VA = "0x182994100")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2994160", Offset = "0x2992B60", VA = "0x182994160")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<HKJIGAIHBEC> KAMBAKLGPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private MMHLAEFDJLE MLAJCCBBANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool IPJBBJCFMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool HKPMAOBEGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6411AA0", Offset = "0x64104A0", VA = "0x186411AA0")]
	private static void FGJLGPDBPPG(Component DCIOCIFFEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6411D70", Offset = "0x6410770", VA = "0x186411D70")]
	public GBEIAHDIOPN(string JBGIOGBCJPF, int EKAJJNHPBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2DBA7E0", Offset = "0x2DB91E0", VA = "0x182DBA7E0")]
	public global::GFEDJJGDFMD<T> ILJCNBFDKFF<T>(AssetReference LECNBPGMEDJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2DBA870", Offset = "0x2DB9270", VA = "0x182DBA870")]
	public global::LNBLPFGKAPP<T> JFPJBGIFFHG<T>(AssetReference LECNBPGMEDJ, int JOBJIONNEHK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2DBA420", Offset = "0x2DB8E20", VA = "0x182DBA420")]
	public global::OHPLDOPGNGG<bool> FDOEJMJEMDK<T>(AssetReference LECNBPGMEDJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6411990", Offset = "0x6410390", VA = "0x186411990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6411850", Offset = "0x6410250", VA = "0x186411850")]
	private void BLNGAFBAOCM(UnityEngine.Object FLIDLOFJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64116C0", Offset = "0x64100C0", VA = "0x1864116C0")]
	private ObjectPool APHOICLJDEG(string JBGIOGBCJPF)
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
		private static GlobalPool KGKJDNBEODL;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject ABHGEJPHLGH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool FMAHKEPPCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6412110", Offset = "0x6410B10", VA = "0x186412110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2DC7A40", Offset = "0x2DC6440", VA = "0x182DC7A40")]
		public static void SafeRelease<T>(T LAFPICAOEAI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6412010", Offset = "0x6410A10", VA = "0x186412010")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6412100", Offset = "0x6410B00", VA = "0x186412100")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, CMEMELMPMPI> HKLKJECNEIL;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2914F80", Offset = "0x2913980", VA = "0x182914F80")]
		public T Acquire<T>(T JFEEEILBEOO, [Optional] Action<Component> DGCBLKLHHNB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2915310", Offset = "0x2913D10", VA = "0x182915310")]
		public bool Release<T>(T LAFPICAOEAI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x29152B0", Offset = "0x2913CB0", VA = "0x1829152B0")]
		public void Prefill<T>(T JFEEEILBEOO, int IECDLCKOAMM, [Optional] Action<Component> PLKDBEFPGOH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2915200", Offset = "0x2913C00", VA = "0x182915200")]
		public bool Exists<T>(T JFEEEILBEOO) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2915010", Offset = "0x2913A10", VA = "0x182915010")]
		public void Clear<T>(T JFEEEILBEOO) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6412CD0", Offset = "0x64116D0", VA = "0x186412CD0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x29150C0", Offset = "0x2913AC0", VA = "0x1829150C0")]
		private CMEMELMPMPI EOCKGNPGIIE<T>(T JFEEEILBEOO) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public void TrackInstantiation(string AOJHGICNOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public void EnableStats(bool JLOMAHCFPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6412E20", Offset = "0x6411820", VA = "0x186412E20")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class CMEMELMPMPI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OKHOMCILKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ALMKIGHFILO(bool MHJJEDNLELL);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component AOAHFDAGEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int CDBOGLNEIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void JFPJBGIFFHG(int JOBJIONNEHK, Action<Component> PLKDBEFPGOH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component ILJCNBFDKFF(Action<Component> DGCBLKLHHNB);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool JJOEMGIHELE(Component AADBINKEJCM);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void NMFIICNHENP();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6411020", Offset = "0x640FA20", VA = "0x186411020")]
	protected void OBPLINDLEBM(Component LAFPICAOEAI, bool MHJJEDNLELL, bool AAHBDDNMCKL, bool DGGGOGOPFHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x64111A0", Offset = "0x640FBA0", VA = "0x1864111A0")]
	protected void OHOONHLMKKF(Transform FGDEKGBFCHL, bool MHJJEDNLELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	protected CMEMELMPMPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NGLHIEEOGAN<T> : CMEMELMPMPI where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T JFEEEILBEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool NILEAMAEODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool AAHBDDNMCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> MOJJMMKHKHM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component AOAHFDAGEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x23145A0", Offset = "0x2312FA0", VA = "0x1823145A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int CDBOGLNEIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x23145C0", Offset = "0x2312FC0", VA = "0x1823145C0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2314E50", Offset = "0x2313850", VA = "0x182314E50")]
	public NGLHIEEOGAN(T JFEEEILBEOO, ObjectPool NILEAMAEODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2314860", Offset = "0x2313260", VA = "0x182314860", Slot = "7")]
	public override void JFPJBGIFFHG(int JOBJIONNEHK, Action<Component> DGCBLKLHHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x23145F0", Offset = "0x2312FF0", VA = "0x1823145F0", Slot = "8")]
	public override Component ILJCNBFDKFF(Action<Component> DGCBLKLHHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2314970", Offset = "0x2313370", VA = "0x182314970", Slot = "9")]
	public override bool JJOEMGIHELE(Component AADBINKEJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2314B00", Offset = "0x2313500", VA = "0x182314B00", Slot = "10")]
	public override void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2314CF0", Offset = "0x23136F0", VA = "0x182314CF0")]
	private T ONLCGBHOKDB()
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
		public interface DEJJHPCACDA
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject EAPMLLCMPFK
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
		[Cpp2IlInjected.Address(RVA = "0x6412900", Offset = "0x6411300", VA = "0x186412900")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6412C50", Offset = "0x6411650", VA = "0x186412C50")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool KGKJDNBEODL;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject ABHGEJPHLGH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool FMAHKEPPCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6412F90", Offset = "0x6411990", VA = "0x186412F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6412EA0", Offset = "0x64118A0", VA = "0x186412EA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6412100", Offset = "0x6410B00", VA = "0x186412100")]
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
		public CMEMELMPMPI PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PPALDEGMCJI
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FFMEFFFNGMK(PooledParticle.JJGDJJBEBHG HFGOCHGBNIC);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum BOPPLCIHOOC
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
		public enum JJGDJJBEBHG
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
		public interface GGJOFPNAEFK
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool JCBDJPDDPPF
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 BPJFKILLPBC
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera NPBOHAALEMM
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
			[Cpp2IlInjected.Address(RVA = "0xCBEE80", Offset = "0xCBD880", VA = "0x180CBEE80")]
			public ColorConfiguration(ParticleSystem JKEGNIEDNAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x64113A0", Offset = "0x640FDA0", VA = "0x1864113A0")]
			public void MGEDEMBLBMI(Color HAAENNGJIPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class ELOBIJBBLHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public ELOBIJBBLHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6411590", Offset = "0x640FF90", VA = "0x186411590")]
			internal void <SetRenderingEnabled>b__0(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CLBEAKBNJAH : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private MJOGGKCIPED <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private GGJOFPNAEFK <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
			[DebuggerHidden]
			public CLBEAKBNJAH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6410940", Offset = "0x640F340", VA = "0x186410940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6410FE0", Offset = "0x640F9E0", VA = "0x186410FE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class ENIJOENMIHP : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private MJOGGKCIPED <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
			[DebuggerHidden]
			public ENIJOENMIHP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x64115C0", Offset = "0x640FFC0", VA = "0x1864115C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6411680", Offset = "0x6410080", VA = "0x186411680", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> MANFGMNJCBE;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<PPALDEGMCJI> IFMNIBGHHCN;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> HJOPFDKMLLI;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static KLOMPNKHCCP PLKFEPAFGPE;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float PIJBALNKHLK = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool FKGMJJIDPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int LOBEJHGJENB;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private JJGDJJBEBHG category;

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
		private ParticleSystem.MinMaxGradient[] JDNLFFHNHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool KILOGGGIBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float FNKAFEICCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float MPEKNNHMPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform BNLOFIGMILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 DOAJLCNPHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 IEDPMBJAMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private BOPPLCIHOOC DAIKPANFCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private KLOMPNKHCCP LHHHMLPJGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool GCLKIEEMPOD;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IEnumerable<PooledParticle> CJJOOELCCPK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6416E30", Offset = "0x6415830", VA = "0x186416E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JJGDJJBEBHG GKCFGFINHKB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6DCC90", Offset = "0x6DB690", VA = "0x1806DCC90")]
			get
			{
				return default(JJGDJJBEBHG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int LPFHMNDHDHB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool FCANJHPHPBN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6416B20", Offset = "0x6415520", VA = "0x186416B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static int FCFPMAKHPPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6416CB0", Offset = "0x64156B0", VA = "0x186416CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected static bool MBMLKFABAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6413E20", Offset = "0x6412820", VA = "0x186413E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ParticleSystem NLPAEFKJCFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7031C0", Offset = "0x701BC0", VA = "0x1807031C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ParticleSystem[] LFDECAFICFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ParticleSystemRenderer[] LHADNGBGGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6C8590", Offset = "0x6C6F90", VA = "0x1806C8590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private BOPPLCIHOOC IBBKHGKPDID
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8FBB50", Offset = "0x8FA550", VA = "0x1808FBB50")]
			get
			{
				return default(BOPPLCIHOOC);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6414A40", Offset = "0x6413440", VA = "0x186414A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LGNAEBIBMCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6416A80", Offset = "0x6415480", VA = "0x186416A80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6416E90", Offset = "0x6415890", VA = "0x186416E90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6416620", Offset = "0x6415020", VA = "0x186416620")]
		public static PooledParticle TryPlayPrefab(PooledParticle JFEEEILBEOO, Vector3 OAALNDIAAOB, Quaternion HOOCPOKGFMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6416430", Offset = "0x6414E30", VA = "0x186416430")]
		public static PooledParticle TryPlayPrefab(PooledParticle JFEEEILBEOO, Vector3 OAALNDIAAOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6415AA0", Offset = "0x64144A0", VA = "0x186415AA0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x64135E0", Offset = "0x6411FE0", VA = "0x1864135E0")]
		private void ANGONGKKJJH(bool PLOAPGLMHKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6413EB0", Offset = "0x64128B0", VA = "0x186413EB0")]
		[IteratorStateMachine(typeof(CLBEAKBNJAH))]
		private static IEnumerator<MJOGGKCIPED> BOPLHIHDEDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6413A90", Offset = "0x6412490", VA = "0x186413A90")]
		private static void BJEEIAKPCBB(Stopwatch CEJBHGLMENF, Vector3 IOGMALJEFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6413F00", Offset = "0x6412900", VA = "0x186413F00")]
		private static int DIHIHADKFIG(PooledParticle CIEDPJMPBGL, PooledParticle FAJJLJONDOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6413FB0", Offset = "0x64129B0", VA = "0x186413FB0")]
		private static int FFMEFFFNGMK(JJGDJJBEBHG HFGOCHGBNIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64146D0", Offset = "0x64130D0", VA = "0x1864146D0")]
		protected void MLGGJFGELHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6414AE0", Offset = "0x64134E0", VA = "0x186414AE0")]
		protected void PGOBLNAHEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64136C0", Offset = "0x64120C0", VA = "0x1864136C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6414430", Offset = "0x6412E30", VA = "0x186414430")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6414A60", Offset = "0x6413460", VA = "0x186414A60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64143B0", Offset = "0x6412DB0", VA = "0x1864143B0")]
		[IteratorStateMachine(typeof(ENIJOENMIHP))]
		private IEnumerator<MJOGGKCIPED> JKNIBEMJGAK(float NNKPALPMOPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6414200", Offset = "0x6412C00", VA = "0x186414200")]
		private void JJOEMGIHELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6416240", Offset = "0x6414C40", VA = "0x186416240")]
		public void SetDuration(float NNKPALPMOPF, bool CMNLFLGEFAN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6415780", Offset = "0x6414180", VA = "0x186415780")]
		public void Play(Transform FDFEIAAHACI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6415160", Offset = "0x6413B60", VA = "0x186415160")]
		public void Play(Transform FDFEIAAHACI, bool MJONBNOMBLJ, float AHNOKOPFJJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x64152B0", Offset = "0x6413CB0", VA = "0x1864152B0")]
		public void Play(Transform FDFEIAAHACI, Vector3 IEDPMBJAMNO, bool MJONBNOMBLJ, float AHNOKOPFJJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6415530", Offset = "0x6413F30", VA = "0x186415530")]
		public void Play(Transform CDBNHCABOHB, Quaternion HOOCPOKGFMC, bool MJONBNOMBLJ = false, float AHNOKOPFJJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6415400", Offset = "0x6413E00", VA = "0x186415400")]
		public void Play(Transform CDBNHCABOHB, Vector3 IEDPMBJAMNO, Quaternion HOOCPOKGFMC, bool MJONBNOMBLJ = false, float AHNOKOPFJJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6415090", Offset = "0x6413A90", VA = "0x186415090")]
		public void Play(Vector3 OAALNDIAAOB, Quaternion HOOCPOKGFMC, Vector3 DDEOINEGECJ, bool MJONBNOMBLJ = false, float AHNOKOPFJJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x64158C0", Offset = "0x64142C0", VA = "0x1864158C0")]
		public void Play(Vector3 OAALNDIAAOB, Quaternion HOOCPOKGFMC, bool MJONBNOMBLJ = false, float AHNOKOPFJJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6415670", Offset = "0x6414070", VA = "0x186415670")]
		public void Play(bool MJONBNOMBLJ = false, float AHNOKOPFJJD = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x64163A0", Offset = "0x6414DA0", VA = "0x1864163A0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6416310", Offset = "0x6414D10", VA = "0x186416310")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6413900", Offset = "0x6412300", VA = "0x186413900")]
		private void BBDCCOFPHJJ(float NNKPALPMOPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x64148D0", Offset = "0x64132D0", VA = "0x1864148D0")]
		private void NEPLHNFLMPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6415980", Offset = "0x6414380", VA = "0x186415980")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6415C40", Offset = "0x6414640", VA = "0x186415C40")]
		public void SetColor(Color HAAENNGJIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x64140C0", Offset = "0x6412AC0", VA = "0x1864140C0")]
		private void GOLOENDOPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6416A20", Offset = "0x6415420", VA = "0x186416A20")]
		public PooledParticle()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6412620", Offset = "0x6411020", VA = "0x186412620")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x64122D0", Offset = "0x6410CD0", VA = "0x1864122D0")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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
