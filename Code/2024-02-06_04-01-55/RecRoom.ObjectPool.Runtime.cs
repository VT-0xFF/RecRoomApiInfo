using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
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
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x62B7F80", Offset = "0x62B7380", VA = "0x1862B7F80")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles GIMBJDMJFNN, float DAGHOMMBAJK, Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62B7C20", Offset = "0x62B7020", VA = "0x1862B7C20")]
		public void SetDamageValue(float DAGHOMMBAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62B8100", Offset = "0x62B7500", VA = "0x1862B8100")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NFDDABGKPOL<T> : GKAGCLBDDCM<T>, IIJBCHKFBNI, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EHELJPLMCBD<T> : IIJBCHKFBNI, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OBNPCCFAOJC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BJPPMBKBBPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JOMELODLNMP<T> : LGIBOMCBCJH<T>, NFDDABGKPOL<T>, GKAGCLBDDCM<T>, IIJBCHKFBNI, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GDHHKMELELA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public JOMELODLNMP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public GDHHKMELELA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x36FC4F0", Offset = "0x36FB8F0", VA = "0x1836FC4F0")]
			internal void BOHAJKGCMGE(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2FAD2F0", Offset = "0x2FAC6F0", VA = "0x182FAD2F0")]
			internal void MAMCHPDOEPM(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MCDOFGKDLFK<T> HIHOKFGELBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool FKNPIFKBFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T EANIAGEJDFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KAJILOPLFHP;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3A61B30", Offset = "0x3A60F30", VA = "0x183A61B30")]
		public JOMELODLNMP(MCDOFGKDLFK<T> HIHOKFGELBC, ObjectPool FKNPIFKBFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3A619F0", Offset = "0x3A60DF0", VA = "0x183A619F0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class DLPEBKHHEFO<T> : JLJKALKJOAC, EHELJPLMCBD<T>, IIJBCHKFBNI, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JHDCFCCKJLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public DLPEBKHHEFO<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public JHDCFCCKJLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3A33F80", Offset = "0x3A33380", VA = "0x183A33F80")]
			internal void BOHAJKGCMGE(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x98AC20", Offset = "0x98A020", VA = "0x18098AC20")]
			internal void MAMCHPDOEPM(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private MCDOFGKDLFK<T> HIHOKFGELBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KAJILOPLFHP;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5015BE0", Offset = "0x5014FE0", VA = "0x185015BE0")]
		public DLPEBKHHEFO(MCDOFGKDLFK<T> HIHOKFGELBC, ObjectPool FKNPIFKBFIL, int DIHAKCPANPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5015B80", Offset = "0x5014F80", VA = "0x185015B80", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KBKDLEEEJMB<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BJPPMBKBBPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public LGIBOMCBCJH<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MCDOFGKDLFK<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public KBKDLEEEJMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3A92880", Offset = "0x3A91C80", VA = "0x183A92880")]
		internal void JJNPIJKICKG(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3A92820", Offset = "0x3A91C20", VA = "0x183A92820")]
		internal void HAENGDEBLPB(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3A92770", Offset = "0x3A91B70", VA = "0x183A92770")]
		internal void DFLGNHDLCOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<OBNPCCFAOJC> NLOLGEAGJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BOLHHIENLPL MNENALNMHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool FKNPIFKBFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KAJILOPLFHP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool PFNHOMJBFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62B5F90", Offset = "0x62B5390", VA = "0x1862B5F90")]
	private static void LOMAOBHFGOK(Component LHKDOCKFFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62B6260", Offset = "0x62B5660", VA = "0x1862B6260")]
	public BJPPMBKBBPN(string FDIHAPIDLHM, int BMIICIJEKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x245EF90", Offset = "0x245E390", VA = "0x18245EF90")]
	public NFDDABGKPOL<T> JBGOGNMBDAE<T>(AssetReference PJHIDEHNIND) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x245F030", Offset = "0x245E430", VA = "0x18245F030")]
	public EHELJPLMCBD<T> JKEHFFMNJGO<T>(AssetReference PJHIDEHNIND, int CBPPKGAPPDD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x245EB30", Offset = "0x245DF30", VA = "0x18245EB30")]
	public GKAGCLBDDCM<bool> HMCLEKMJLHA<T>(AssetReference PJHIDEHNIND) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62B5D70", Offset = "0x62B5170", VA = "0x1862B5D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62B5E60", Offset = "0x62B5260", VA = "0x1862B5E60")]
	private void HLCLPKLOGED(UnityEngine.Object ADLFBANMOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62B5BE0", Offset = "0x62B4FE0", VA = "0x1862B5BE0")]
	private ObjectPool DDHGHPOKEOK(string FDIHAPIDLHM)
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
		private static GlobalPool GHPBOHCOJPJ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject CJGGHMLOBLP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool GHDJCOLHINO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x62B6870", Offset = "0x62B5C70", VA = "0x1862B6870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2684A30", Offset = "0x2683E30", VA = "0x182684A30")]
		public static void SafeRelease<T>(T BHPOPDOKECN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62B67A0", Offset = "0x62B5BA0", VA = "0x1862B67A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62B6860", Offset = "0x62B5C60", VA = "0x1862B6860")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, LGKHFJIHBBE> EHCEFHEGKPF;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x281B700", Offset = "0x281AB00", VA = "0x18281B700")]
		public T Acquire<T>(T GIMBJDMJFNN, [Optional] Action<Component> GDAIOJMBOAB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x281BA70", Offset = "0x281AE70", VA = "0x18281BA70")]
		public bool Release<T>(T BHPOPDOKECN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x281BA20", Offset = "0x281AE20", VA = "0x18281BA20")]
		public void Prefill<T>(T GIMBJDMJFNN, int NCKIMDLDFGB, [Optional] Action<Component> ILLNHAMOKPD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x281B840", Offset = "0x281AC40", VA = "0x18281B840")]
		public bool Exists<T>(T GIMBJDMJFNN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x281B790", Offset = "0x281AB90", VA = "0x18281B790")]
		public void Clear<T>(T GIMBJDMJFNN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x62B77C0", Offset = "0x62B6BC0", VA = "0x1862B77C0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x281B8E0", Offset = "0x281ACE0", VA = "0x18281B8E0")]
		private LGKHFJIHBBE GPBHHCKFOCN<T>(T GIMBJDMJFNN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
		public void TrackInstantiation(string BHECMIFIIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
		public void EnableStats(bool OKLCBCMGDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62B7930", Offset = "0x62B6D30", VA = "0x1862B7930")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class LGKHFJIHBBE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GDJDKBGABEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PPBNBPBJKAD(bool NAPMNDMEGPA);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int CLLKHAFIKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void JKEHFFMNJGO(int CBPPKGAPPDD, Action<Component> ILLNHAMOKPD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component JBGOGNMBDAE(Action<Component> GDAIOJMBOAB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool JGNAPAAMDNO(Component CBOGFEPHCCP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void BILLODBOEME();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62B72C0", Offset = "0x62B66C0", VA = "0x1862B72C0")]
	protected void JHKPEIFLLOM(Component BHPOPDOKECN, bool NAPMNDMEGPA, bool CAGKFNILIGD, bool ODPOKOLLONJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62B7040", Offset = "0x62B6440", VA = "0x1862B7040")]
	protected void DNNDOKBNCIH(Transform BNGAOCLLAOE, bool NAPMNDMEGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	protected LGKHFJIHBBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ELMCMAAEADF<T> : LGKHFJIHBBE where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T GIMBJDMJFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool DFKKNCPLIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool CAGKFNILIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> GLFOJOHGJEF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string GAOODFEKINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32C10F0", Offset = "0x32C04F0", VA = "0x1832C10F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int CLLKHAFIKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x32C10B0", Offset = "0x32C04B0", VA = "0x1832C10B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x32C1110", Offset = "0x32C0510", VA = "0x1832C1110")]
	public ELMCMAAEADF(T GIMBJDMJFNN, ObjectPool DFKKNCPLIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x32C0FA0", Offset = "0x32C03A0", VA = "0x1832C0FA0", Slot = "6")]
	public override void JKEHFFMNJGO(int CBPPKGAPPDD, Action<Component> GDAIOJMBOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x32C0B90", Offset = "0x32BFF90", VA = "0x1832C0B90", Slot = "7")]
	public override Component JBGOGNMBDAE(Action<Component> GDAIOJMBOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x32C0E00", Offset = "0x32C0200", VA = "0x1832C0E00", Slot = "8")]
	public override bool JGNAPAAMDNO(Component CBOGFEPHCCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x32C09B0", Offset = "0x32BFDB0", VA = "0x1832C09B0", Slot = "9")]
	public override void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x32C0840", Offset = "0x32BFC40", VA = "0x1832C0840")]
	private T AINNHHJHCMA()
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
		public interface AHKEKANNDNA
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject ODALHKJDEDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62B7440", Offset = "0x62B6840", VA = "0x1862B7440")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x62B7730", Offset = "0x62B6B30", VA = "0x1862B7730")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool GHPBOHCOJPJ;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject CJGGHMLOBLP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool GHDJCOLHINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x62B7A80", Offset = "0x62B6E80", VA = "0x1862B7A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x62B79C0", Offset = "0x62B6DC0", VA = "0x1862B79C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62B6860", Offset = "0x62B5C60", VA = "0x1862B6860")]
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
		public LGKHFJIHBBE PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FOPHHICHCDM
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GLOMEKFALHH(PooledParticle.NECHAPPAMGH CAJANJIPLOM);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum ONOMPFBOKKA
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
		public enum NECHAPPAMGH
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
		public interface IIJNELBBBCG
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool JHEBBJDCAGH
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 FJGADNEDBLF
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera PGMFAHDNDLN
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
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

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5306490", Offset = "0x5305890", VA = "0x185306490")]
			public ColorConfiguration(ParticleSystem MFEJLPGCGAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x62B64F0", Offset = "0x62B58F0", VA = "0x1862B64F0")]
			public void BKJNBLDJBIO(Color MNHFMCFPMMK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class ABCMFLFFPJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public ABCMFLFFPJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x62B5BB0", Offset = "0x62B4FB0", VA = "0x1862B5BB0")]
			internal void PLAHALIEJGE(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JDIFJOFDAIK : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private ALCMBHLDKFG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private IIJNELBBBCG <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
			[DebuggerHidden]
			public JDIFJOFDAIK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x62B69E0", Offset = "0x62B5DE0", VA = "0x1862B69E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x62B6FF0", Offset = "0x62B63F0", VA = "0x1862B6FF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FFDPCDMKAJH : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private ALCMBHLDKFG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
			[DebuggerHidden]
			public FFDPCDMKAJH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x62B66E0", Offset = "0x62B5AE0", VA = "0x1862B66E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x62B6750", Offset = "0x62B5B50", VA = "0x1862B6750", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> CHACAJNMFHH;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<FOPHHICHCDM> IAPJBBPGDNG;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> CKCIEMKEFOF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static ICANAFEODIJ HIPMDPHMDHA;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float PEPIKAFLGPD = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool AEJHMJOPGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int MNGBKDLKAHE;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private NECHAPPAMGH category;

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
		private ParticleSystem.MinMaxGradient[] NCHPNJKDJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool KNPBOJONPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float BFNLKCOOGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float PJMAGJKNIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform NBNKPGMBNEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 PJDNMPHFPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 HBKHBCCLHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private ONOMPFBOKKA PJEDNGCOMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ICANAFEODIJ POEDBGIBOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool EFMOPFDKPFK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> GEFIEDEIJBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x62BB950", Offset = "0x62BAD50", VA = "0x1862BB950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NECHAPPAMGH LCFPDCJDFHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7C7730", Offset = "0x7C6B30", VA = "0x1807C7730")]
			get
			{
				return default(NECHAPPAMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int MGBJOPBPALC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x79E7B0", Offset = "0x79DBB0", VA = "0x18079E7B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool DPGNIFMCGBF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x62BB680", Offset = "0x62BAA80", VA = "0x1862BB680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int IICPJPBKLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x62BB800", Offset = "0x62BAC00", VA = "0x1862BB800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool EPOFIDBHCFG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x62B8BD0", Offset = "0x62B7FD0", VA = "0x1862B8BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem JLKNMEIBAKD
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7A26A0", Offset = "0x7A1AA0", VA = "0x1807A26A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] ABFKEMJAIMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] JELFPACOHDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7A5A10", Offset = "0x7A4E10", VA = "0x1807A5A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private ONOMPFBOKKA PDNJCGMEMOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xDECAF0", Offset = "0xDEBEF0", VA = "0x180DECAF0")]
			get
			{
				return default(ONOMPFBOKKA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x62B9900", Offset = "0x62B8D00", VA = "0x1862B9900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KHCJEIAMCKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x62BB5E0", Offset = "0x62BA9E0", VA = "0x1862BB5E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x62BB9A0", Offset = "0x62BADA0", VA = "0x1862BB9A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62BAF70", Offset = "0x62BA370", VA = "0x1862BAF70")]
		public static PooledParticle TryPlayPrefab(PooledParticle GIMBJDMJFNN, Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x62BB0E0", Offset = "0x62BA4E0", VA = "0x1862BB0E0")]
		public static PooledParticle TryPlayPrefab(PooledParticle GIMBJDMJFNN, Vector3 BEBKKMFGLCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x62BA620", Offset = "0x62B9A20", VA = "0x1862BA620")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x62B8DB0", Offset = "0x62B81B0", VA = "0x1862B8DB0")]
		private void JJDKFKNBFNH(bool AKOFKNDDBNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x62B85D0", Offset = "0x62B79D0", VA = "0x1862B85D0")]
		[IteratorStateMachine(typeof(JDIFJOFDAIK))]
		private static IEnumerator<ALCMBHLDKFG> EENOLHBAMJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x62B8770", Offset = "0x62B7B70", VA = "0x1862B8770")]
		private static void GDPHKICMKFP(Stopwatch KJPGODIMAEL, Vector3 KMMEHBFHDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x62B9920", Offset = "0x62B8D20", VA = "0x1862B9920")]
		private static int OLPPEHACGDH(PooledParticle NNOKPENDLPE, PooledParticle OBLEBBNJEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62B8AC0", Offset = "0x62B7EC0", VA = "0x1862B8AC0")]
		private static int GLOMEKFALHH(NECHAPPAMGH CAJANJIPLOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62B9700", Offset = "0x62B8B00", VA = "0x1862B9700")]
		protected void MHBMEFFOOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x62B8E80", Offset = "0x62B8280", VA = "0x1862B8E80")]
		protected void LPAEOGGMICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x62B81E0", Offset = "0x62B75E0", VA = "0x1862B81E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62B9490", Offset = "0x62B8890", VA = "0x1862B9490")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62B99D0", Offset = "0x62B8DD0", VA = "0x1862B99D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62B8410", Offset = "0x62B7810", VA = "0x1862B8410")]
		[IteratorStateMachine(typeof(FFDPCDMKAJH))]
		private IEnumerator<ALCMBHLDKFG> CIPJJAIPOJP(float POAEONMMKAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x62B8C50", Offset = "0x62B8050", VA = "0x1862B8C50")]
		private void JGNAPAAMDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62BAD80", Offset = "0x62BA180", VA = "0x1862BAD80")]
		public void SetDuration(float POAEONMMKAF, bool NLAFMEGACMD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62B9BE0", Offset = "0x62B8FE0", VA = "0x1862B9BE0")]
		public void Play(Transform PEKFEAHEOLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62BA290", Offset = "0x62B9690", VA = "0x1862BA290")]
		public void Play(Transform PEKFEAHEOLM, bool LKFOJGLEDAP, float PNFKOKPOBOG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62B9D40", Offset = "0x62B9140", VA = "0x1862B9D40")]
		public void Play(Transform PEKFEAHEOLM, Vector3 HBKHBCCLHFM, bool LKFOJGLEDAP, float PNFKOKPOBOG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62B9E90", Offset = "0x62B9290", VA = "0x1862B9E90")]
		public void Play(Transform IEOKNNECIPG, Quaternion IKFFGJBHBIC, bool LKFOJGLEDAP = false, float PNFKOKPOBOG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62BA400", Offset = "0x62B9800", VA = "0x1862BA400")]
		public void Play(Transform IEOKNNECIPG, Vector3 HBKHBCCLHFM, Quaternion IKFFGJBHBIC, bool LKFOJGLEDAP = false, float PNFKOKPOBOG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62BA0B0", Offset = "0x62B94B0", VA = "0x1862BA0B0")]
		public void Play(Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC, Vector3 KDGFADJDBBB, bool LKFOJGLEDAP = false, float PNFKOKPOBOG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62B9FF0", Offset = "0x62B93F0", VA = "0x1862B9FF0")]
		public void Play(Vector3 BEBKKMFGLCG, Quaternion IKFFGJBHBIC, bool LKFOJGLEDAP = false, float PNFKOKPOBOG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x62BA180", Offset = "0x62B9580", VA = "0x1862BA180")]
		public void Play(bool LKFOJGLEDAP = false, float PNFKOKPOBOG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x62BAEE0", Offset = "0x62BA2E0", VA = "0x1862BAEE0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x62BAE50", Offset = "0x62BA250", VA = "0x1862BAE50")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x62B9A50", Offset = "0x62B8E50", VA = "0x1862B9A50")]
		private void PKIHFKEEHIB(float POAEONMMKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x62B8630", Offset = "0x62B7A30", VA = "0x1862B8630")]
		private void EICMPFBALMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x62BA530", Offset = "0x62B9930", VA = "0x1862BA530")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62BA7A0", Offset = "0x62B9BA0", VA = "0x1862BA7A0")]
		public void SetColor(Color MNHFMCFPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62B84A0", Offset = "0x62B78A0", VA = "0x1862B84A0")]
		private void EDGCDGOBOHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62BB550", Offset = "0x62BA950", VA = "0x1862BB550")]
		public PooledParticle()
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
