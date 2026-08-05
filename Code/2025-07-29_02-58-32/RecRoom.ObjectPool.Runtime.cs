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
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86B8930", Offset = "0x86B7330", VA = "0x1886B8930")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles IJAFMJKMLAD, float JGHGCPDAGFI, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86B85D0", Offset = "0x86B6FD0", VA = "0x1886B85D0")]
		public void SetDamageValue(float JGHGCPDAGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86B8A70", Offset = "0x86B7470", VA = "0x1886B8A70")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KJJPCNPCLKJ<T> : DPMDGLGHBHJ<T>, PNBAKNHPHGJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BKPEBGBJDPL<T> : PNBAKNHPHGJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DPPIPIMONOP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AGAMHFFGBGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PLJKGFJHDAK<T> : EPBHKCIONFE<T>, KJJPCNPCLKJ<T>, DPMDGLGHBHJ<T>, PNBAKNHPHGJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BNMIBEPNKIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PLJKGFJHDAK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public BNMIBEPNKIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x65AFCC0", Offset = "0x65AE6C0", VA = "0x1865AFCC0")]
			internal void OKDDNCMJJLP(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3D74E20", Offset = "0x3D73820", VA = "0x183D74E20")]
			internal void CNDDJOKCEKK(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FDLGIOOGFEJ<T> MEHKBGEBNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool GOBILBPNJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T PKGDNOOHCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool JAFNIEKLOJN;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B51FA0", Offset = "0x5B509A0", VA = "0x185B51FA0")]
		public PLJKGFJHDAK(FDLGIOOGFEJ<T> MEHKBGEBNEE, ObjectPool GOBILBPNJNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5B51E60", Offset = "0x5B50860", VA = "0x185B51E60", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class BEGAEDHNDPK<T> : HNFFHHICMCD, BKPEBGBJDPL<T>, PNBAKNHPHGJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class OBJENBLBGNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BEGAEDHNDPK<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public OBJENBLBGNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x59F5D80", Offset = "0x59F4780", VA = "0x1859F5D80")]
			internal void OKDDNCMJJLP(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x169B410", Offset = "0x1699E10", VA = "0x18169B410")]
			internal void CNDDJOKCEKK(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FDLGIOOGFEJ<T> MEHKBGEBNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool JAFNIEKLOJN;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x64BB570", Offset = "0x64B9F70", VA = "0x1864BB570")]
		public BEGAEDHNDPK(FDLGIOOGFEJ<T> MEHKBGEBNEE, ObjectPool GOBILBPNJNM, int NPNMFMPMFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x64BB510", Offset = "0x64B9F10", VA = "0x1864BB510", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GGOPFBEEDMA<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AGAMHFFGBGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EPBHKCIONFE<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FDLGIOOGFEJ<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GGOPFBEEDMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4F5BBB0", Offset = "0x4F5A5B0", VA = "0x184F5BBB0")]
		internal void GBKKLNMOOGC(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4F5BC60", Offset = "0x4F5A660", VA = "0x184F5BC60")]
		internal void KPAJNDIOKJF(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4F5BB60", Offset = "0x4F5A560", VA = "0x184F5BB60")]
		internal void GAMCAHOKFAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<DPPIPIMONOP> DEEDKDACMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private IFOJGBDDOMH IGIEHPJEIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool GOBILBPNJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool JAFNIEKLOJN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86B68E0", Offset = "0x86B52E0", VA = "0x1886B68E0")]
	private static void MMPMMABCFHP(Component BIMLKJFNDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x86B6BC0", Offset = "0x86B55C0", VA = "0x1886B6BC0")]
	public AGAMHFFGBGH(string HJIKHCCLFIK, int DIIFBGMIHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x31C5560", Offset = "0x31C3F60", VA = "0x1831C5560")]
	public KJJPCNPCLKJ<T> PKPFHCOKDBD<T>(AssetReference JNGIGOJOHAP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x31C50C0", Offset = "0x31C3AC0", VA = "0x1831C50C0")]
	public BKPEBGBJDPL<T> ACBBIHFCNDF<T>(AssetReference JNGIGOJOHAP, int CDCPIGCEABM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x31C5170", Offset = "0x31C3B70", VA = "0x1831C5170")]
	public DPMDGLGHBHJ<bool> DBCKAGIKEII<T>(AssetReference JNGIGOJOHAP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86B6660", Offset = "0x86B5060", VA = "0x1886B6660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86B6510", Offset = "0x86B4F10", VA = "0x1886B6510")]
	private void CHHFNBNJPBB(UnityEngine.Object PEPAIGKDMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x86B6750", Offset = "0x86B5150", VA = "0x1886B6750")]
	private ObjectPool KJFCKFLOLAO(string HJIKHCCLFIK)
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
		private static GlobalPool PJHDALLIBIP;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject ODPDBDCONEM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool NDAIDGNOFDA
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x86B7880", Offset = "0x86B6280", VA = "0x1886B7880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C792D0", Offset = "0x3C77CD0", VA = "0x183C792D0")]
		public static void SafeRelease<T>(T CEFJEHJNIAP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86B77B0", Offset = "0x86B61B0", VA = "0x1886B77B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86B7870", Offset = "0x86B6270", VA = "0x1886B7870")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct PMDAHCLAPBK<T> : IDisposable where T : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly T KLDJFGHJNOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly ObjectPool FOHPIGBHJBP;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public T BHKLFFIKDPE
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
			internal PMDAHCLAPBK(T PDKJBMPOMNC, ObjectPool FOHPIGBHJBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5B52FD0", Offset = "0x5B519D0", VA = "0x185B52FD0", Slot = "4")]
			void IDisposable.Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, MMDKMBOCGGO> CHDLNFMDCIP;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E51F00", Offset = "0x3E50900", VA = "0x183E51F00")]
		public T Acquire<T>(T IJAFMJKMLAD, [Optional] Action<Component> EOFGLBAFAAA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E51E80", Offset = "0x3E50880", VA = "0x183E51E80")]
		public PMDAHCLAPBK<T> AcquirePooledObject<T>(T IJAFMJKMLAD, [Optional] Action<Component> EOFGLBAFAAA) where T : Component
		{
			return default(PMDAHCLAPBK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E52270", Offset = "0x3E50C70", VA = "0x183E52270")]
		public bool Release<T>(T CEFJEHJNIAP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E52220", Offset = "0x3E50C20", VA = "0x183E52220")]
		public void Prefill<T>(T IJAFMJKMLAD, int ONGEONHLOPF, [Optional] Action<Component> OAEGALJGJBN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E52040", Offset = "0x3E50A40", VA = "0x183E52040")]
		public bool Exists<T>(T IJAFMJKMLAD) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E51F90", Offset = "0x3E50990", VA = "0x183E51F90")]
		public void Clear<T>(T IJAFMJKMLAD) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86B8170", Offset = "0x86B6B70", VA = "0x1886B8170")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E520E0", Offset = "0x3E50AE0", VA = "0x183E520E0")]
		private MMDKMBOCGGO PFJFCDBFJOJ<T>(T IJAFMJKMLAD) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		public void TrackInstantiation(string KKMKABCEJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		public void EnableStats(bool CGOLPBOHAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86B82E0", Offset = "0x86B6CE0", VA = "0x1886B82E0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class MMDKMBOCGGO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface LBJKCNIABMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CAPIHCPFCGL(bool FJOBDLEAALF);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int BIKAOJLBCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void ACBBIHFCNDF(int CDCPIGCEABM, Action<Component> OAEGALJGJBN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component PKPFHCOKDBD(Action<Component> EOFGLBAFAAA);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool OEENGNANBPH(Component HEKBGGCIFJA);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void CHLOADNGFGM();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86B79F0", Offset = "0x86B63F0", VA = "0x1886B79F0")]
	protected void DJLDNDFOKGI(Component CEFJEHJNIAP, bool FJOBDLEAALF, bool FFFAHNEGHHO, bool LHEDFKEILHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86B7B70", Offset = "0x86B6570", VA = "0x1886B7B70")]
	protected void OJMGBKEMHML(Transform PALLLOMBPNF, bool FJOBDLEAALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected MMDKMBOCGGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FFDJLEMCLAF<T> : MMDKMBOCGGO where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private T IJAFMJKMLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private ObjectPool AKJJNEEOJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool FFFAHNEGHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Queue<T> DAFPHIIBFFO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string FAHMGKIDCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4DF8D20", Offset = "0x4DF7720", VA = "0x184DF8D20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int BIKAOJLBCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4DF8B30", Offset = "0x4DF7530", VA = "0x184DF8B30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9150", Offset = "0x4DF7B50", VA = "0x184DF9150")]
	public FFDJLEMCLAF(T IJAFMJKMLAD, ObjectPool AKJJNEEOJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8830", Offset = "0x4DF7230", VA = "0x184DF8830", Slot = "6")]
	public override void ACBBIHFCNDF(int CDCPIGCEABM, Action<Component> EOFGLBAFAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8EE0", Offset = "0x4DF78E0", VA = "0x184DF8EE0", Slot = "7")]
	public override Component PKPFHCOKDBD(Action<Component> EOFGLBAFAAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8D40", Offset = "0x4DF7740", VA = "0x184DF8D40", Slot = "8")]
	public override bool OEENGNANBPH(Component HEKBGGCIFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8940", Offset = "0x4DF7340", VA = "0x184DF8940", Slot = "9")]
	public override void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8B70", Offset = "0x4DF7570", VA = "0x184DF8B70")]
	private T ENGNIGDGPND()
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public interface OCJOEINPDII
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject IIMGDAGJIOB
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86B7DF0", Offset = "0x86B67F0", VA = "0x1886B7DF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86B80E0", Offset = "0x86B6AE0", VA = "0x1886B80E0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static PersistentGlobalPool PJHDALLIBIP;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static GameObject ODPDBDCONEM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool NDAIDGNOFDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x86B8430", Offset = "0x86B6E30", VA = "0x1886B8430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86B8370", Offset = "0x86B6D70", VA = "0x1886B8370")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86B7870", Offset = "0x86B6270", VA = "0x1886B7870")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MMDKMBOCGGO PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HNBKDIEGPDK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JCFOCLPJIDB(PooledParticle.EKEEMBLNCGE COBMGFAEIIO);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private enum PBAIFNHPEGP
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum EKEEMBLNCGE
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public interface CEFIAPBKIDG
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			bool ODGPDONBHMF
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Vector3 EGMHMCPCGCH
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Camera MAGLNKJFFPB
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x726B750", Offset = "0x726A150", VA = "0x18726B750")]
			public ColorConfiguration(ParticleSystem CNDCIEDONFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x86B7590", Offset = "0x86B5F90", VA = "0x1886B7590")]
			public void PIMJNPCAIJD(Color EDNHAEBPHJD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class DBBMPAHNMEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public DBBMPAHNMEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x86B7780", Offset = "0x86B6180", VA = "0x1886B7780")]
			internal void PHFOPHAJKJF(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class CDMKGIKJHAJ : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private BHOPOIJKEJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private CEFIAPBKIDG <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public CDMKGIKJHAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x86B6F10", Offset = "0x86B5910", VA = "0x1886B6F10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x86B7540", Offset = "0x86B5F40", VA = "0x1886B7540", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class AIMEEKGAIDJ : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private BHOPOIJKEJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public AIMEEKGAIDJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x86B6E50", Offset = "0x86B5850", VA = "0x1886B6E50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x86B6EC0", Offset = "0x86B58C0", VA = "0x1886B6EC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> DADEBBNGKDE;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Lazy<HNBKDIEGPDK> OOFOJKMMBCE;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static List<PooledParticle> IDKJOBPIOEN;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static NNFEFJFFOPD LEDJLGNGAFD;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float NFONCCJHAMA = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool OAGFJLJMBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected int LFPDAIDILOM;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private EKEEMBLNCGE category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float? HHMGPFBLFNI;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] FKAFKELJMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ParticleSystem.MinMaxGradient[] NDGCIFCEJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool GFPDIHCBNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float HEDLGDKDDCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float PNKJIKBBIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Transform BDBDCDEACJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 IOJIDKMLIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 HIDCCHOCHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PBAIFNHPEGP FGCPBFFBNLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private NNFEFJFFOPD BFMMBOJIJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected bool JLOODHHANKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Transform BIFOCPBCDHJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> HJHKLCNOAJD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x86BC860", Offset = "0x86BB260", VA = "0x1886BC860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EKEEMBLNCGE BGCFGHJBKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50")]
			get
			{
				return default(EKEEMBLNCGE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int MHCDMFPFFAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool EKOGOLFOEJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x86BC590", Offset = "0x86BAF90", VA = "0x1886BC590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int DJNKNOHOCDF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x86BC710", Offset = "0x86BB110", VA = "0x1886BC710")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool DMODFFEBCCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x86B9650", Offset = "0x86B8050", VA = "0x1886B9650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem CAJBHIFNCIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] DOPJFEEGMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] BKLCIJMCBOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private PBAIFNHPEGP BMCKBDINFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xF17680", Offset = "0xF16080", VA = "0x180F17680")]
			get
			{
				return default(PBAIFNHPEGP);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x86B9C80", Offset = "0x86B8680", VA = "0x1886B9C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Transform EOBBLENOIHL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x86BC8B0", Offset = "0x86BB2B0", VA = "0x1886BC8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EDALHKLJMPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x86BC4F0", Offset = "0x86BAEF0", VA = "0x1886BC4F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x86BC900", Offset = "0x86BB300", VA = "0x1886BC900")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86BBF00", Offset = "0x86BA900", VA = "0x1886BBF00")]
		public static PooledParticle TryPlayPrefab(PooledParticle IJAFMJKMLAD, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86BC020", Offset = "0x86BAA20", VA = "0x1886BC020")]
		public static PooledParticle TryPlayPrefab(PooledParticle IJAFMJKMLAD, Vector3 DDIHIBMHCDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x86BB610", Offset = "0x86BA010", VA = "0x1886BB610")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x86B9CA0", Offset = "0x86B86A0", VA = "0x1886B9CA0")]
		private void NNCPCPJLGAL(bool JKHDONCCPDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86B90E0", Offset = "0x86B7AE0", VA = "0x1886B90E0")]
		[IteratorStateMachine(typeof(CDMKGIKJHAJ))]
		private static IEnumerator<BHOPOIJKEJE> DEMONCOPNIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x86B9140", Offset = "0x86B7B40", VA = "0x1886B9140")]
		private static void GBABMFKCKKP(Stopwatch HIBNALIEBDI, Vector3 AEGNCCIBCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x86B96D0", Offset = "0x86B80D0", VA = "0x1886B96D0")]
		private static int IAPABPBODMH(PooledParticle HEOFBNHHDGF, PooledParticle HEGCIIKIHGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x86B9780", Offset = "0x86B8180", VA = "0x1886B9780")]
		private static int JCFOCLPJIDB(EKEEMBLNCGE COBMGFAEIIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x86BA580", Offset = "0x86B8F80", VA = "0x1886BA580")]
		protected void OGJIHANJJNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x86B9D70", Offset = "0x86B8770", VA = "0x1886B9D70")]
		protected void OBDJAMGHNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x86B8B50", Offset = "0x86B7550", VA = "0x1886B8B50", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86B9890", Offset = "0x86B8290", VA = "0x1886B9890")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x86BA770", Offset = "0x86B9170", VA = "0x1886BA770")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86B8FE0", Offset = "0x86B79E0", VA = "0x1886B8FE0")]
		[IteratorStateMachine(typeof(AIMEEKGAIDJ))]
		private IEnumerator<BHOPOIJKEJE> BLLJFKHPHKP(float KHJNAGFHPGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x86BA380", Offset = "0x86B8D80", VA = "0x1886BA380")]
		private void OEENGNANBPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x86BBC40", Offset = "0x86BA640", VA = "0x1886BBC40")]
		public void SetDuration(float KHJNAGFHPGB, bool LMIIIFFAMLI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x86BA930", Offset = "0x86B9330", VA = "0x1886BA930")]
		public void Play(Transform EFHFDMAKFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x86BB1E0", Offset = "0x86B9BE0", VA = "0x1886BB1E0")]
		public void Play(Transform EFHFDMAKFMO, bool GINDIDPLJAH, float PGCKEBMPLLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x86BAA90", Offset = "0x86B9490", VA = "0x1886BAA90")]
		public void Play(Transform EFHFDMAKFMO, Vector3 HIDCCHOCHMH, bool GINDIDPLJAH, float PGCKEBMPLLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x86BABE0", Offset = "0x86B95E0", VA = "0x1886BABE0")]
		public void Play(Transform EBHPDGIMNOK, Quaternion JCDLBIBEGAF, bool GINDIDPLJAH = false, float PGCKEBMPLLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x86BB350", Offset = "0x86B9D50", VA = "0x1886BB350")]
		public void Play(Transform EBHPDGIMNOK, Vector3 HIDCCHOCHMH, Quaternion JCDLBIBEGAF, bool GINDIDPLJAH = false, float PGCKEBMPLLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x86BAE80", Offset = "0x86B9880", VA = "0x1886BAE80")]
		public void Play(Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, Vector3 GINLPEHDJCD, bool GINDIDPLJAH = false, float PGCKEBMPLLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x86BAD20", Offset = "0x86B9720", VA = "0x1886BAD20")]
		public void Play(Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, bool GINDIDPLJAH = false, float PGCKEBMPLLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x86BB000", Offset = "0x86B9A00", VA = "0x1886BB000")]
		public void Play(bool GINDIDPLJAH = false, float PGCKEBMPLLL = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x86BBE60", Offset = "0x86BA860", VA = "0x1886BBE60")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x86BBD10", Offset = "0x86BA710", VA = "0x1886BBD10")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86B94B0", Offset = "0x86B7EB0", VA = "0x1886B94B0")]
		private void HICGBCKGOMP(float KHJNAGFHPGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x86B8DD0", Offset = "0x86B77D0", VA = "0x1886B8DD0")]
		private void BDOCEGIOLGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x86BB480", Offset = "0x86B9E80", VA = "0x1886BB480")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86BB790", Offset = "0x86BA190", VA = "0x1886BB790")]
		public void SetColor(Color EDNHAEBPHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x86B9BC0", Offset = "0x86B85C0", VA = "0x1886B9BC0")]
		private void MDNIKOOEIOI(float? FPIFKAOGCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x86B9070", Offset = "0x86B7A70", VA = "0x1886B9070")]
		private void DDAHENNPNPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x86BA800", Offset = "0x86B9200", VA = "0x1886BA800")]
		private void PIGOPJEOLAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x86BC450", Offset = "0x86BAE50", VA = "0x1886BC450")]
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
