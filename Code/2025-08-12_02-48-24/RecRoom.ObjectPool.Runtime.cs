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
		[Cpp2IlInjected.Address(RVA = "0x8817A90", Offset = "0x8816090", VA = "0x188817A90")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles EEGMKGNBEOE, float HMHFFBLKCLF, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8817730", Offset = "0x8815D30", VA = "0x188817730")]
		public void SetDamageValue(float HMHFFBLKCLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8817BD0", Offset = "0x88161D0", VA = "0x188817BD0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PIJNKOECHNH<T> : LDNIFFJFEMD<T>, CNOKEDEBLOH, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DACDAMIMGEG<T> : CNOKEDEBLOH, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BAKBAPJGOJH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CFOGBKGMHHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CBCNPKFOFNB<T> : AMMPBANBFHC<T>, PIJNKOECHNH<T>, LDNIFFJFEMD<T>, CNOKEDEBLOH, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GNCLHFLJLNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public CBCNPKFOFNB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public GNCLHFLJLNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5015930", Offset = "0x5013F30", VA = "0x185015930")]
			internal void KHGBLAEHIPK(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x4218440", Offset = "0x4216A40", VA = "0x184218440")]
			internal void DEMBJFOIDOM(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LHNBHFNPODB<T> OHGCGABAPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool OCOFOPJAIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T PLKOLLOCKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool OPDBEINFGEH;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6CFAEF0", Offset = "0x6CF94F0", VA = "0x186CFAEF0")]
		public CBCNPKFOFNB(LHNBHFNPODB<T> OHGCGABAPHA, ObjectPool OCOFOPJAIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6CFADB0", Offset = "0x6CF93B0", VA = "0x186CFADB0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class KBFFAPENMKJ<T> : CNNOOOMLHEJ, DACDAMIMGEG<T>, CNOKEDEBLOH, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class KKFNFMALHIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KBFFAPENMKJ<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public KKFNFMALHIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x55FA450", Offset = "0x55F8A50", VA = "0x1855FA450")]
			internal void KHGBLAEHIPK(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x1706550", Offset = "0x1704B50", VA = "0x181706550")]
			internal void DEMBJFOIDOM(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LHNBHFNPODB<T> OHGCGABAPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool OPDBEINFGEH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x55AA2F0", Offset = "0x55A88F0", VA = "0x1855AA2F0")]
		public KBFFAPENMKJ(LHNBHFNPODB<T> OHGCGABAPHA, ObjectPool OCOFOPJAIBP, int AMBMFGHPMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x55AA290", Offset = "0x55A8890", VA = "0x1855AA290", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KAGCEGAKKLB<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CFOGBKGMHHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AMMPBANBFHC<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LHNBHFNPODB<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public KAGCEGAKKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x55A49E0", Offset = "0x55A2FE0", VA = "0x1855A49E0")]
		internal void IMAKDHMMBBK(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55A4AE0", Offset = "0x55A30E0", VA = "0x1855A4AE0")]
		internal void OPNDFHOGNDN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55A4A90", Offset = "0x55A3090", VA = "0x1855A4A90")]
		internal void MPCMPLEEHGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<BAKBAPJGOJH> NGELOFDBLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LEHFAKDMKKO GCMLDMCPANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool OCOFOPJAIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool OPDBEINFGEH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88160C0", Offset = "0x88146C0", VA = "0x1888160C0")]
	private static void KNNNHLDJHFA(Component OFJDOOOKCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x88163A0", Offset = "0x88149A0", VA = "0x1888163A0")]
	public CFOGBKGMHHK(string GCNCIPOJBMI, int HFKOFMKHNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B82240", Offset = "0x3B80840", VA = "0x183B82240")]
	public PIJNKOECHNH<T> PEPFMPMNHIJ<T>(AssetReference JCMPOCIHDHC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B82190", Offset = "0x3B80790", VA = "0x183B82190")]
	public DACDAMIMGEG<T> JJDLLJABFCA<T>(AssetReference JCMPOCIHDHC, int FEEKNNBMJMM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3B81ED0", Offset = "0x3B804D0", VA = "0x183B81ED0")]
	public LDNIFFJFEMD<bool> ANHHLAMACIC<T>(AssetReference JCMPOCIHDHC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8815E40", Offset = "0x8814440", VA = "0x188815E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8815CF0", Offset = "0x88142F0", VA = "0x188815CF0")]
	private void AFJKFKMNMNO(UnityEngine.Object IGFIFCAMJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8815F30", Offset = "0x8814530", VA = "0x188815F30")]
	private ObjectPool GMCABMCPBFG(string GCNCIPOJBMI)
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
		private static GlobalPool MDCEPNGNCGO;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject CGKFONCAPMP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool DOBPPELCKJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x88168F0", Offset = "0x8814EF0", VA = "0x1888168F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3DB41A0", Offset = "0x3DB27A0", VA = "0x183DB41A0")]
		public static void SafeRelease<T>(T NDBJJGOPOFO) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8816820", Offset = "0x8814E20", VA = "0x188816820")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88168E0", Offset = "0x8814EE0", VA = "0x1888168E0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct NPNEOJGPKIF<T> : IDisposable where T : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly T LKGMDOIJIDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly ObjectPool KKEHMECDMMK;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public T FAGODIAEODP
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
			internal NPNEOJGPKIF(T FKMNCAKIOFK, ObjectPool KKEHMECDMMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5A2B680", Offset = "0x5A29C80", VA = "0x185A2B680", Slot = "4")]
			void IDisposable.Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, JFMKFJKAJPG> BHLGIMIALHP;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F63DC0", Offset = "0x3F623C0", VA = "0x183F63DC0")]
		public T Acquire<T>(T EEGMKGNBEOE, [Optional] Action<Component> LFGCFCFMCGK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F63D40", Offset = "0x3F62340", VA = "0x183F63D40")]
		public NPNEOJGPKIF<T> AcquirePooledObject<T>(T EEGMKGNBEOE, [Optional] Action<Component> LFGCFCFMCGK) where T : Component
		{
			return default(NPNEOJGPKIF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F64130", Offset = "0x3F62730", VA = "0x183F64130")]
		public bool Release<T>(T NDBJJGOPOFO) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F640E0", Offset = "0x3F626E0", VA = "0x183F640E0")]
		public void Prefill<T>(T EEGMKGNBEOE, int NALFCDGMPKP, [Optional] Action<Component> OMGDAPMCBDK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F63F00", Offset = "0x3F62500", VA = "0x183F63F00")]
		public bool Exists<T>(T EEGMKGNBEOE) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F63E50", Offset = "0x3F62450", VA = "0x183F63E50")]
		public void Clear<T>(T EEGMKGNBEOE) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88172D0", Offset = "0x88158D0", VA = "0x1888172D0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F63FA0", Offset = "0x3F625A0", VA = "0x183F63FA0")]
		private JFMKFJKAJPG ODHLFPODBPA<T>(T EEGMKGNBEOE) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public void TrackInstantiation(string NHMGHOOMJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public void EnableStats(bool LGDLPPIEIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8817440", Offset = "0x8815A40", VA = "0x188817440")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class JFMKFJKAJPG
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface PGELPNKLHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AFABBFJPBNN(bool LHMEEOHCMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int PIDAOAMMPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void JJDLLJABFCA(int FEEKNNBMJMM, Action<Component> OMGDAPMCBDK);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component PEPFMPMNHIJ(Action<Component> LFGCFCFMCGK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool PILMPNHBFAM(Component FOIJIDBLNAC);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void OOIGDCNPPFG();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8816DA0", Offset = "0x88153A0", VA = "0x188816DA0")]
	protected void KCNANODOAHB(Component NDBJJGOPOFO, bool LHMEEOHCMOH, bool FFEDOCBPNCH, bool NFIGKJNAAGG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8816B20", Offset = "0x8815120", VA = "0x188816B20")]
	protected void AEPDNDMAJHP(Transform JGGDMAOLBAC, bool LHMEEOHCMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected JFMKFJKAJPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MDCADEEEJHL<T> : JFMKFJKAJPG where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private T EEGMKGNBEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private ObjectPool KNHOJDCNONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool FFEDOCBPNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Queue<T> BJMLIILHHAD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x594E3D0", Offset = "0x594C9D0", VA = "0x18594E3D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int PIDAOAMMPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x594E280", Offset = "0x594C880", VA = "0x18594E280", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x594EBA0", Offset = "0x594D1A0", VA = "0x18594EBA0")]
	public MDCADEEEJHL(T EEGMKGNBEOE, ObjectPool KNHOJDCNONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x594E2C0", Offset = "0x594C8C0", VA = "0x18594E2C0", Slot = "6")]
	public override void JJDLLJABFCA(int FEEKNNBMJMM, Action<Component> LFGCFCFMCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x594E790", Offset = "0x594CD90", VA = "0x18594E790", Slot = "7")]
	public override Component PEPFMPMNHIJ(Action<Component> LFGCFCFMCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x594EA00", Offset = "0x594D000", VA = "0x18594EA00", Slot = "8")]
	public override bool PILMPNHBFAM(Component FOIJIDBLNAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x594E5A0", Offset = "0x594CBA0", VA = "0x18594E5A0", Slot = "9")]
	public override void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x594E3F0", Offset = "0x594C9F0", VA = "0x18594E3F0")]
	private T LKOHEOJHCGA()
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
		public interface ODIJELGAFCE
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject DJJPDGAJAKG
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
		[Cpp2IlInjected.Address(RVA = "0x8816F50", Offset = "0x8815550", VA = "0x188816F50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8817240", Offset = "0x8815840", VA = "0x188817240")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static PersistentGlobalPool MDCEPNGNCGO;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static GameObject CGKFONCAPMP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool DOBPPELCKJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8817590", Offset = "0x8815B90", VA = "0x188817590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88174D0", Offset = "0x8815AD0", VA = "0x1888174D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88168E0", Offset = "0x8814EE0", VA = "0x1888168E0")]
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
		public JFMKFJKAJPG PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ENOAHMBPNLI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NCEPJPFKBOB(PooledParticle.GNLMHLPOJBD HIKGHFOMFFB);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private enum ENPEAEDLONF
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
		public enum GNLMHLPOJBD
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
		public interface LOOMGLIMEKF
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			bool DNBGCKAOLOI
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Vector3 JPFOLMEOIKE
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Camera OFBJLFCLLMD
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
			[Cpp2IlInjected.Address(RVA = "0x73ACF50", Offset = "0x73AB550", VA = "0x1873ACF50")]
			public ColorConfiguration(ParticleSystem OOIGHBLMNID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8816630", Offset = "0x8814C30", VA = "0x188816630")]
			public void DFHFIDMMMIF(Color ONDGBPEOGJF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class MPCCOKLKPJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public MPCCOKLKPJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8816F20", Offset = "0x8815520", VA = "0x188816F20")]
			internal void EONOKIKONLN(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class AKHECGJCFFB : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private BJJPNELKDDJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private LOOMGLIMEKF <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public AKHECGJCFFB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8815680", Offset = "0x8813C80", VA = "0x188815680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8815CA0", Offset = "0x88142A0", VA = "0x188815CA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class HJHLHJAJAEE : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private BJJPNELKDDJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public HJHLHJAJAEE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8816A60", Offset = "0x8815060", VA = "0x188816A60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8816AD0", Offset = "0x88150D0", VA = "0x188816AD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> KHEKJHDFDDD;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Lazy<ENOAHMBPNLI> PIDPPCDAKDA;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static List<PooledParticle> ONFBDAPDCJK;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static APLPOCKIJEJ JGJHEHCKKIP;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float ABFANHHOCBJ = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool PNFBHHALPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected int JLDDJIKKOII;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private GNLMHLPOJBD category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float? KDJDAEDCJNO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] PCJOMAKEDFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ParticleSystem.MinMaxGradient[] IGCOMHJJBOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool KJNFHGCJGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float EKEAGIEKGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float OLNGEDDHFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Transform MCHBGLEHGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 MECMCLALIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 EKABFIAIMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private ENPEAEDLONF GMEHELPPMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private APLPOCKIJEJ HLMLCAMCPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected bool PACCHHIEEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Transform HNGLPJEGNPF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> GMHLJLGCOFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x881B9B0", Offset = "0x8819FB0", VA = "0x18881B9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public GNLMHLPOJBD FDEFAAMHLFC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xABDCC0", Offset = "0xABC2C0", VA = "0x180ABDCC0")]
			get
			{
				return default(GNLMHLPOJBD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PJEEHADCION
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NEHLGHEFIMD
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x881B6E0", Offset = "0x8819CE0", VA = "0x18881B6E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int MMFEEKPKKJD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x881B860", Offset = "0x8819E60", VA = "0x18881B860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool MGFFEKKLECP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8819280", Offset = "0x8817880", VA = "0x188819280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem LMPMCCMIFPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] KMPDEBNDNPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] FHNHGKEIOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private ENPEAEDLONF APNNHEHFDGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xF42860", Offset = "0xF40E60", VA = "0x180F42860")]
			get
			{
				return default(ENPEAEDLONF);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8817CB0", Offset = "0x88162B0", VA = "0x188817CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Transform JAHKFPBBGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x881BA00", Offset = "0x881A000", VA = "0x18881BA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EPMGBJBKAMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x881B640", Offset = "0x8819C40", VA = "0x18881B640")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x881BA50", Offset = "0x881A050", VA = "0x18881BA50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x881B050", Offset = "0x8819650", VA = "0x18881B050")]
		public static PooledParticle TryPlayPrefab(PooledParticle EEGMKGNBEOE, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x881B170", Offset = "0x8819770", VA = "0x18881B170")]
		public static PooledParticle TryPlayPrefab(PooledParticle EEGMKGNBEOE, Vector3 AANGPKCDGHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x881A760", Offset = "0x8818D60", VA = "0x18881A760")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8818170", Offset = "0x8816770", VA = "0x188818170")]
		private void APKEIKHOCOI(bool COPJEOGEKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8819220", Offset = "0x8817820", VA = "0x188819220")]
		[IteratorStateMachine(typeof(AKHECGJCFFB))]
		private static IEnumerator<BJJPNELKDDJ> KPJJIPCJCJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8817E00", Offset = "0x8816400", VA = "0x188817E00")]
		private static void ANIMHALPLAL(Stopwatch AGEIHALJKLD, Vector3 HAMBEFPHLNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8819630", Offset = "0x8817C30", VA = "0x188819630")]
		private static int NAFBJCNDNPA(PooledParticle KNPHEACNGDK, PooledParticle IMDBLBCMEAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x88196E0", Offset = "0x8817CE0", VA = "0x1888196E0")]
		private static int NCEPJPFKBOB(GNLMHLPOJBD HIKGHFOMFFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88188D0", Offset = "0x8816ED0", VA = "0x1888188D0")]
		protected void CNLEEFGAAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8818AC0", Offset = "0x88170C0", VA = "0x188818AC0")]
		protected void DJMJLJBJLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8818240", Offset = "0x8816840", VA = "0x188818240", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8819300", Offset = "0x8817900", VA = "0x188819300")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x88197F0", Offset = "0x8817DF0", VA = "0x1888197F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88190D0", Offset = "0x88176D0", VA = "0x1888190D0")]
		[IteratorStateMachine(typeof(HJHLHJAJAEE))]
		private IEnumerator<BJJPNELKDDJ> GBCCJDFOFDO(float ECPJMMFGCIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8819880", Offset = "0x8817E80", VA = "0x188819880")]
		private void PILMPNHBFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x881AD90", Offset = "0x8819390", VA = "0x18881AD90")]
		public void SetDuration(float ECPJMMFGCIP, bool NNABIMILGCN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8819A80", Offset = "0x8818080", VA = "0x188819A80")]
		public void Play(Transform NEKFGEJBADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x881A330", Offset = "0x8818930", VA = "0x18881A330")]
		public void Play(Transform NEKFGEJBADK, bool NNLOOPMPBDK, float LAFKFLFLFHP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8819BE0", Offset = "0x88181E0", VA = "0x188819BE0")]
		public void Play(Transform NEKFGEJBADK, Vector3 EKABFIAIMBP, bool NNLOOPMPBDK, float LAFKFLFLFHP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8819D30", Offset = "0x8818330", VA = "0x188819D30")]
		public void Play(Transform GDLONNHDFMC, Quaternion NEOIPHFFLHF, bool NNLOOPMPBDK = false, float LAFKFLFLFHP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x881A4A0", Offset = "0x8818AA0", VA = "0x18881A4A0")]
		public void Play(Transform GDLONNHDFMC, Vector3 EKABFIAIMBP, Quaternion NEOIPHFFLHF, bool NNLOOPMPBDK = false, float LAFKFLFLFHP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8819FD0", Offset = "0x88185D0", VA = "0x188819FD0")]
		public void Play(Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, Vector3 NCEIMCLGMCB, bool NNLOOPMPBDK = false, float LAFKFLFLFHP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8819E70", Offset = "0x8818470", VA = "0x188819E70")]
		public void Play(Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, bool NNLOOPMPBDK = false, float LAFKFLFLFHP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x881A150", Offset = "0x8818750", VA = "0x18881A150")]
		public void Play(bool NNLOOPMPBDK = false, float LAFKFLFLFHP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x881AFB0", Offset = "0x88195B0", VA = "0x18881AFB0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x881AE60", Offset = "0x8819460", VA = "0x18881AE60")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8818740", Offset = "0x8816D40", VA = "0x188818740")]
		private void CGECILHFOLH(float ECPJMMFGCIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88184C0", Offset = "0x8816AC0", VA = "0x1888184C0")]
		private void BIOBINKDJJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x881A5D0", Offset = "0x8818BD0", VA = "0x18881A5D0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x881A8E0", Offset = "0x8818EE0", VA = "0x18881A8E0")]
		public void SetColor(Color ONDGBPEOGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8819160", Offset = "0x8817760", VA = "0x188819160")]
		private void IEANMJFMJBB(float? FLCAFPMKFLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88186D0", Offset = "0x8816CD0", VA = "0x1888186D0")]
		private void CEBADAMIHIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8817CD0", Offset = "0x88162D0", VA = "0x188817CD0")]
		private void AGNLPPJFOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x881B5A0", Offset = "0x8819BA0", VA = "0x18881B5A0")]
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
