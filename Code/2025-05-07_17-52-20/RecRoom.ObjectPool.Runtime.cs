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
		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7640", Offset = "0x7FB6640", VA = "0x187FB7640")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles OMOOALIODHP, float PGDIIIELPOD, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7FB72E0", Offset = "0x7FB62E0", VA = "0x187FB72E0")]
		public void SetDamageValue(float PGDIIIELPOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7780", Offset = "0x7FB6780", VA = "0x187FB7780")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HAEOIFBJICJ<T> : KGAPFDAFEHM<T>, HPIGCMLNLFB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NGBCDGMGDEL<T> : HPIGCMLNLFB, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EDMOPJNMBCK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KNLPBBBAOIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OFHCINFHGMN<T> : AIKFLNNDLCF<T>, HAEOIFBJICJ<T>, KGAPFDAFEHM<T>, HPIGCMLNLFB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DGODOBNGIPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OFHCINFHGMN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public DGODOBNGIPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6A5CB70", Offset = "0x6A5BB70", VA = "0x186A5CB70")]
			internal void GOAGLAFDPGD(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3CA44E0", Offset = "0x3CA34E0", VA = "0x183CA44E0")]
			internal void ABMHHCHGLAC(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GKHPBLLBAIL<T> FHKOFHKFLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool FBGEPLFBKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T ELJDCHFNJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool DPFEMHMCJBH;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5513B60", Offset = "0x5512B60", VA = "0x185513B60")]
		public OFHCINFHGMN(GKHPBLLBAIL<T> FHKOFHKFLME, ObjectPool FBGEPLFBKNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x55139F0", Offset = "0x55129F0", VA = "0x1855139F0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class LEAKOLCCIPC<T> : DOIMKNIPPCD, NGBCDGMGDEL<T>, HPIGCMLNLFB, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class FBDKIAGBMDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LEAKOLCCIPC<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public FBDKIAGBMDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x494FAE0", Offset = "0x494EAE0", VA = "0x18494FAE0")]
			internal void GOAGLAFDPGD(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x13F40B0", Offset = "0x13F30B0", VA = "0x1813F40B0")]
			internal void ABMHHCHGLAC(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private GKHPBLLBAIL<T> FHKOFHKFLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool DPFEMHMCJBH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x50E0680", Offset = "0x50DF680", VA = "0x1850E0680")]
		public LEAKOLCCIPC(GKHPBLLBAIL<T> FHKOFHKFLME, ObjectPool FBGEPLFBKNL, int FOAOGPCMOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x50E0620", Offset = "0x50DF620", VA = "0x1850E0620", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GCLDPHDPPGP<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KNLPBBBAOIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AIKFLNNDLCF<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GKHPBLLBAIL<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public GCLDPHDPPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4A511C0", Offset = "0x4A501C0", VA = "0x184A511C0")]
		internal void MFCLCIADJKN(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4A51270", Offset = "0x4A50270", VA = "0x184A51270")]
		internal void NGKGOFOCPJP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4A51170", Offset = "0x4A50170", VA = "0x184A51170")]
		internal void EHKFDINPBLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<EDMOPJNMBCK> IBLADCCEBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private AMOBJFENOPL BIHKNGMCGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool FBGEPLFBKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6190", Offset = "0x7FB5190", VA = "0x187FB6190")]
	private static void GAMBGLPLIJJ(Component HABFEKNHDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6470", Offset = "0x7FB5470", VA = "0x187FB6470")]
	public KNLPBBBAOIO(string EKPIAKIDDJI, int BHHHMMPFAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38F4220", Offset = "0x38F3220", VA = "0x1838F4220")]
	public HAEOIFBJICJ<T> CILCEMKBDAL<T>(AssetReference LJCCCIBDJEF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x38F42F0", Offset = "0x38F32F0", VA = "0x1838F42F0")]
	public NGBCDGMGDEL<T> GONFKMJEJPE<T>(AssetReference LJCCCIBDJEF, int JAALIADHHOC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38F43D0", Offset = "0x38F33D0", VA = "0x1838F43D0")]
	public KGAPFDAFEHM<bool> NOMOJCGANNC<T>(AssetReference LJCCCIBDJEF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FB60A0", Offset = "0x7FB50A0", VA = "0x187FB60A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5F60", Offset = "0x7FB4F60", VA = "0x187FB5F60")]
	private void CPNLELOKOII(UnityEngine.Object CCLJKOJACOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5DD0", Offset = "0x7FB4DD0", VA = "0x187FB5DD0")]
	private ObjectPool CEGHPMEKOID(string EKPIAKIDDJI)
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
		private static GlobalPool KCIKNNAECHN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject MOEMOOHEIDC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool MLIJHBGBMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7FB5C60", Offset = "0x7FB4C60", VA = "0x187FB5C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3862CC0", Offset = "0x3861CC0", VA = "0x183862CC0")]
		public static void SafeRelease<T>(T BOMDCGFKGKF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5B90", Offset = "0x7FB4B90", VA = "0x187FB5B90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5C50", Offset = "0x7FB4C50", VA = "0x187FB5C50")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, MCNFNJGPLLN> ELLOOLKFMAG;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x39E97F0", Offset = "0x39E87F0", VA = "0x1839E97F0")]
		public T Acquire<T>(T OMOOALIODHP, [Optional] Action<Component> MMELMJDIDNC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x39E9BB0", Offset = "0x39E8BB0", VA = "0x1839E9BB0")]
		public bool Release<T>(T BOMDCGFKGKF) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x39E9B40", Offset = "0x39E8B40", VA = "0x1839E9B40")]
		public void Prefill<T>(T OMOOALIODHP, int NNKEMODDKID, [Optional] Action<Component> PCOHFMACAOL) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x39E9960", Offset = "0x39E8960", VA = "0x1839E9960")]
		public bool Exists<T>(T OMOOALIODHP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x39E98B0", Offset = "0x39E88B0", VA = "0x1839E98B0")]
		public void Clear<T>(T OMOOALIODHP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7FB6E80", Offset = "0x7FB5E80", VA = "0x187FB6E80")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x39E9A00", Offset = "0x39E8A00", VA = "0x1839E9A00")]
		private MCNFNJGPLLN GIEMHHMCEOH<T>(T OMOOALIODHP) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public void TrackInstantiation(string HEAFCHGFBPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public void EnableStats(bool OPNKBJHIJPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7FB6FF0", Offset = "0x7FB5FF0", VA = "0x187FB6FF0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class MCNFNJGPLLN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CHGAENCDGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LNCJNIPBOFC(bool CBHHPIGGAMI);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int IJKIKELAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void GONFKMJEJPE(int JAALIADHHOC, Action<Component> PCOHFMACAOL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component CILCEMKBDAL(Action<Component> MMELMJDIDNC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool KKIPOBFIFOD(Component CAJPFDMILMO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void INBDHNEFJBE();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6700", Offset = "0x7FB5700", VA = "0x187FB6700")]
	protected void AKABEMLLFAK(Component BOMDCGFKGKF, bool CBHHPIGGAMI, bool CNIPABGAACH, bool FGEDGIAOEAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6880", Offset = "0x7FB5880", VA = "0x187FB6880")]
	protected void EENFANEGADL(Transform DDBAEPFCLGI, bool CBHHPIGGAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	protected MCNFNJGPLLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JOODJLLPLOE<T> : MCNFNJGPLLN where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T OMOOALIODHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool GHHENMEBFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool CNIPABGAACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> MPMBOGPHHOH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D410", Offset = "0x4E7C410", VA = "0x184E7D410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int IJKIKELAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4E7CFD0", Offset = "0x4E7BFD0", VA = "0x184E7CFD0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D430", Offset = "0x4E7C430", VA = "0x184E7D430")]
	public JOODJLLPLOE(T OMOOALIODHP, ObjectPool GHHENMEBFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CEA0", Offset = "0x4E7BEA0", VA = "0x184E7CEA0", Slot = "6")]
	public override void GONFKMJEJPE(int JAALIADHHOC, Action<Component> MMELMJDIDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CA50", Offset = "0x4E7BA50", VA = "0x184E7CA50", Slot = "7")]
	public override Component CILCEMKBDAL(Action<Component> MMELMJDIDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D250", Offset = "0x4E7C250", VA = "0x184E7D250", Slot = "8")]
	public override bool KKIPOBFIFOD(Component CAJPFDMILMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D030", Offset = "0x4E7C030", VA = "0x184E7D030", Slot = "9")]
	public override void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CCE0", Offset = "0x4E7BCE0", VA = "0x184E7CCE0")]
	private T GNDENMFDDEA()
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
		public interface DPFBACHHIAD
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject LIFEMEGPEKN
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FB6B00", Offset = "0x7FB5B00", VA = "0x187FB6B00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7FB6DF0", Offset = "0x7FB5DF0", VA = "0x187FB6DF0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool KCIKNNAECHN;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject MOEMOOHEIDC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool MLIJHBGBMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7FB7140", Offset = "0x7FB6140", VA = "0x187FB7140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7080", Offset = "0x7FB6080", VA = "0x187FB7080")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7FB5C50", Offset = "0x7FB4C50", VA = "0x187FB5C50")]
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
		public MCNFNJGPLLN PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CBAOKNCELHC
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GIGPIKAJGND(PooledParticle.JEKCPFBKHOL BMEHNMPPGJP);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum JCGKILAHHGI
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum JEKCPFBKHOL
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface CEDBHFIGLJP
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool LNJFOGNFLAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 GKHIBCINPIA
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera ODOHAMONDDN
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6C54060", Offset = "0x6C53060", VA = "0x186C54060")]
			public ColorConfiguration(ParticleSystem GDDEFPNDDIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7FB5320", Offset = "0x7FB4320", VA = "0x187FB5320")]
			public void EHAKGAGPGAI(Color NGGKCKILBNF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class AJNLEEJECEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public AJNLEEJECEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7FB5230", Offset = "0x7FB4230", VA = "0x187FB5230")]
			internal void HNHKGOFEDKK(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class DMLODFHJFLB : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private NFNODNEANBN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private CEDBHFIGLJP <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
			[DebuggerHidden]
			public DMLODFHJFLB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7FB5510", Offset = "0x7FB4510", VA = "0x187FB5510", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7FB5B40", Offset = "0x7FB4B40", VA = "0x187FB5B40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BOEGCEDGKEC : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private NFNODNEANBN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
			[DebuggerHidden]
			public BOEGCEDGKEC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7FB5260", Offset = "0x7FB4260", VA = "0x187FB5260", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7FB52D0", Offset = "0x7FB42D0", VA = "0x187FB52D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> OLNNDMALIIO;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<CBAOKNCELHC> ELLDLIOEOEH;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> NCIHHJNDJKE;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static OLILOOIADED DJLIJGIEDAH;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float BJEMIKGBFMO = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool GNBHLJHANKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int FFPIDHJKNCI;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private JEKCPFBKHOL category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? MIGAOLNOJJA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] LPHNJJIAEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool LBBBGCJLOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float ODKBHGEOOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float HNLIMFNNPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Transform OOLHKMJOAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Vector3 JPHMLDPMNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 EKNIICEEFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private JCGKILAHHGI APHIBGGEBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private OLILOOIADED MLBGCOGKIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected bool KLMONBKHMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Transform KGPIBDKDEPB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> APPONCOMICD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7FBB4A0", Offset = "0x7FBA4A0", VA = "0x187FBB4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JEKCPFBKHOL LMPFHKHMEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA18A40", Offset = "0xA17A40", VA = "0x180A18A40")]
			get
			{
				return default(JEKCPFBKHOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int DCAGBEIAPLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KMGCMFNJFCC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7FBB1D0", Offset = "0x7FBA1D0", VA = "0x187FBB1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int HLIIDGPAIIK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7FBB350", Offset = "0x7FBA350", VA = "0x187FBB350")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool PEMGKKMODOF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7FB8DC0", Offset = "0x7FB7DC0", VA = "0x187FB8DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem LHEPOJPDDMO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] LJCAMJCFMPN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] GKIGGDFALGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private JCGKILAHHGI AFHCPOKCCKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9F9110", Offset = "0x9F8110", VA = "0x1809F9110")]
			get
			{
				return default(JCGKILAHHGI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7FB9170", Offset = "0x7FB8170", VA = "0x187FB9170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform KOOMPFGMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7FBB4F0", Offset = "0x7FBA4F0", VA = "0x187FBB4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PJPINKCMELD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7FBB130", Offset = "0x7FBA130", VA = "0x187FBB130")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7FBB540", Offset = "0x7FBA540", VA = "0x187FBB540")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7FBAB40", Offset = "0x7FB9B40", VA = "0x187FBAB40")]
		public static PooledParticle TryPlayPrefab(PooledParticle OMOOALIODHP, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7FBAC60", Offset = "0x7FB9C60", VA = "0x187FBAC60")]
		public static PooledParticle TryPlayPrefab(PooledParticle OMOOALIODHP, Vector3 EPCLGOKLIPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA130", Offset = "0x7FB9130", VA = "0x187FBA130")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9190", Offset = "0x7FB8190", VA = "0x187FB9190")]
		private void MGLPKOECAHO(bool MIHGKLOAIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9260", Offset = "0x7FB8260", VA = "0x187FB9260")]
		[IteratorStateMachine(typeof(DMLODFHJFLB))]
		private static IEnumerator<NFNODNEANBN> NJBOBDLFEBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8620", Offset = "0x7FB7620", VA = "0x187FB8620")]
		private static void GDMJCDABMPN(Stopwatch DCCJGOAMNIL, Vector3 EHBNNCDMOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8570", Offset = "0x7FB7570", VA = "0x187FB8570")]
		private static int DEEDPAGNMJE(PooledParticle OBNCJFFHHLB, PooledParticle ODHPFGNCGDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8990", Offset = "0x7FB7990", VA = "0x187FB8990")]
		private static int GIGPIKAJGND(JEKCPFBKHOL BMEHNMPPGJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7860", Offset = "0x7FB6860", VA = "0x187FB7860")]
		protected void AFNGOEBMCCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7F40", Offset = "0x7FB6F40", VA = "0x187FB7F40")]
		protected void CLFOENHGIPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7A50", Offset = "0x7FB6A50", VA = "0x187FB7A50", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8E40", Offset = "0x7FB7E40", VA = "0x187FB8E40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9460", Offset = "0x7FB8460", VA = "0x187FB9460")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8B60", Offset = "0x7FB7B60", VA = "0x187FB8B60")]
		[IteratorStateMachine(typeof(BOEGCEDGKEC))]
		private IEnumerator<NFNODNEANBN> JHKHENIOGOI(float JHNMLGDIFJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8BF0", Offset = "0x7FB7BF0", VA = "0x187FB8BF0")]
		private void KKIPOBFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA880", Offset = "0x7FB9880", VA = "0x187FBA880")]
		public void SetDuration(float JHNMLGDIFJL, bool NNJJCMKNBON = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7FB94F0", Offset = "0x7FB84F0", VA = "0x187FB94F0")]
		public void Play(Transform LBHHFFIENIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9DA0", Offset = "0x7FB8DA0", VA = "0x187FB9DA0")]
		public void Play(Transform LBHHFFIENIA, bool NPCGMBJKNBK, float NNMAHNJOBEP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9650", Offset = "0x7FB8650", VA = "0x187FB9650")]
		public void Play(Transform LBHHFFIENIA, Vector3 EKNIICEEFLH, bool NPCGMBJKNBK, float NNMAHNJOBEP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7FB97A0", Offset = "0x7FB87A0", VA = "0x187FB97A0")]
		public void Play(Transform AONFMANDLFE, Quaternion OOBEGCNALKF, bool NPCGMBJKNBK = false, float NNMAHNJOBEP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9F10", Offset = "0x7FB8F10", VA = "0x187FB9F10")]
		public void Play(Transform AONFMANDLFE, Vector3 EKNIICEEFLH, Quaternion OOBEGCNALKF, bool NPCGMBJKNBK = false, float NNMAHNJOBEP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9A40", Offset = "0x7FB8A40", VA = "0x187FB9A40")]
		public void Play(Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, Vector3 NPNMEIDGLAE, bool NPCGMBJKNBK = false, float NNMAHNJOBEP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7FB98E0", Offset = "0x7FB88E0", VA = "0x187FB98E0")]
		public void Play(Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, bool NPCGMBJKNBK = false, float NNMAHNJOBEP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9BC0", Offset = "0x7FB8BC0", VA = "0x187FB9BC0")]
		public void Play(bool NPCGMBJKNBK = false, float NNMAHNJOBEP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7FBAAA0", Offset = "0x7FB9AA0", VA = "0x187FBAAA0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA950", Offset = "0x7FB9950", VA = "0x187FBA950")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7FB92C0", Offset = "0x7FB82C0", VA = "0x187FB92C0")]
		private void OBEPCBEMALJ(float JHNMLGDIFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7CD0", Offset = "0x7FB6CD0", VA = "0x187FB7CD0")]
		private void BPKLBGNPOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA040", Offset = "0x7FB9040", VA = "0x187FBA040")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA2B0", Offset = "0x7FB92B0", VA = "0x187FBA2B0")]
		public void SetColor(Color NGGKCKILBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8AA0", Offset = "0x7FB7AA0", VA = "0x187FB8AA0")]
		private void HLJJLJFIEFD(float? EPGNCELGAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8D50", Offset = "0x7FB7D50", VA = "0x187FB8D50")]
		private void KOKIIFHBIIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7E10", Offset = "0x7FB6E10", VA = "0x187FB7E10")]
		private void CKAKJIIPFGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB090", Offset = "0x7FBA090", VA = "0x187FBB090")]
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
